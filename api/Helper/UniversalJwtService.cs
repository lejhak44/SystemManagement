using System;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using ngJSApp.Database.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using ngJSApp.Controllers;

namespace ngJSApp
{
    

    public class UniversalJwtService
    {
        private readonly string _secret;
        private readonly string _expDate;
        protected IAppCrypterService appCrypter = null;

        public UniversalJwtService(IConfiguration config, IAppCrypterService _appCrypter)
        {
            _secret = config.GetSection("JwtConfig").GetSection("secret").Value;
            _expDate = config.GetSection("JwtConfig").GetSection("expirationInMinutes").Value;

            this.appCrypter = _appCrypter;
        }

        public string GenerateSecurityToken(dynamic user, string password)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim("ID_User", user.ID.ToString()),
                    new Claim("ID_Session", user.ID_UserSession.ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_expDate)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        public string GenerateEncryptedToken(dynamic user, string password)
        {
            string jsonResult = "";
            dynamic tokerKeys = new System.Dynamic.ExpandoObject();

            tokerKeys.ID_User = user.ID.ToString();
            tokerKeys.ID_UserGroup = user.ID_UserGroup.ToString();
            tokerKeys.ID_User_Reference = user.ID_User_Reference.ToString();
            tokerKeys.ID_Model_Reference = user.ID_Model_Reference.ToString();
            //tokerKeys.ID_Employee = user.ID_Employee.ToString();
            tokerKeys.Name=user.Name.ToString();
            //tokerKeys.LastName = user.LastName.ToString();
            //tokerKeys.FirstName = user.FirstName.ToString();
            // tokerKeys.Name_Employee = user.LastName.ToString() + ", " + user.FirstName.ToString();
            tokerKeys.ID_Company = user.ID_Company.ToString();
            // tokerKeys.ID_Position = user.ID_Position.ToString();
            tokerKeys.ID_Session = user.ID_UserSession.ToString();
            tokerKeys.Password = password;

            jsonResult = JsonConvert.SerializeObject(tokerKeys);    

            jsonResult = this.appCrypter.Encrypt(jsonResult);

            return jsonResult;
        }

    }


    //public static class AuthenticationExtension
    //{
    //    public static IServiceCollection AddTokenAuthentication(this IServiceCollection services, IConfiguration config)
    //    {
    //        var secret = config.GetSection("JwtConfig").GetSection("secret").Value;

    //        var key = Encoding.ASCII.GetBytes(secret);
    //        services.AddAuthentication(x =>
    //        {
    //            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    //            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    //        })
    //        .AddJwtBearer(x =>
    //        {
    //            x.TokenValidationParameters = new TokenValidationParameters
    //            {
    //                IssuerSigningKey = new SymmetricSecurityKey(key),
    //                ValidateIssuer = true,
    //                ValidateAudience = true,
    //                ValidIssuer = "localhost",
    //                ValidAudience = "localhost"
    //            };
    //        });

    //        return services;
    //    }
    //}
}