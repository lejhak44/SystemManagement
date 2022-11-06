using FastReport.Data;
using FastReport.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ngJSApp.Controllers;
using ngJSApp.Database;
using ngJSApp.Helper;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using ngJSApp.HubConfig;

namespace ngJSApp
{
    public class Startup
    {
        public static string DBConnectionString = null;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            DBConnectionString = Configuration.GetValue<string>("ConnectionString");
            DBConnectionString = JSLibrary.DBCollection.GetReplacedConnectionString(DBConnectionString);

            services.AddCors();
            services.AddControllers().AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddDbContext<AppDbContext>(options =>
                        options
                        .UseLazyLoadingProxies()
                        .UseSqlServer(DBConnectionString)
            );
            services.AddMvc(
                config =>
                {
                    config.Filters.Add(typeof(AppExecptionFIlter));
                }
            );
            services.AddSingleton<IAppCrypterService, AppCrypterService>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "",
                        ValidAudience = "",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtConfig:secret"])),
                        ClockSkew = TimeSpan.Zero
                    };
            });

            services.AddSignalR();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseFastReport();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMiddleware<JwtMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                endpoints.MapHub <ngJSApp.HubConfig.ChatHub>("/chathub");
            });
            app.UseDefaultFiles();
            app.UseStaticFiles();

            RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));
        }
    }
}
