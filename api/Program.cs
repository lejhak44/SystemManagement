using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using ngJSApp.Helper;
using ngJSApp.HubConfig;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace ngJSApp
{
    public class Program
    {
        public static string DBConnectionString = "Data Source=DESKTOP-395B5RB\\SQLEXPRESS2019;Initial Catalog=DentalTool;User id=chatuser;Password=sql123$%^";
        private  static SqlTableDependency<MessageThread> _sqlTableDependency = null;
        public static IHubContext<ChatHub> _hubContext;

        public IConfiguration Configuration { get; }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
               Host.CreateDefaultBuilder(args)
                   .ConfigureLogging(logBuilder =>
                   {
                       logBuilder.ClearProviders(); // removes all providers from LoggerFactory
                       logBuilder.AddConsole();
                       logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
                   })
                   .ConfigureWebHostDefaults(webBuilder =>
                   {
                       webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                       webBuilder.UseIISIntegration();
                       webBuilder.UseStartup<Startup>();
                   });

        public static void Main(string[] args)
        {

            var host = CreateHostBuilder(args)
                          .Build();

       


            //Program._hubContext = (IHubContext<ChatHub>)host.Services.GetService(typeof(IHubContext<ChatHub>));

            //SqlDependency.Stop(DBConnectionString);
            //SqlDependency.Start(DBConnectionString);

            //SQLDependencyMessageStart();

            host.Run();
        }
        public static void SQLDependencyMessageStart()
        {
            var mapper = new ModelToTableMapper<MessageThread>();

            mapper.AddMapping(c => c.ID, "ID");
            mapper.AddMapping(c => c.Recipient_ID_User, "Recipient_ID_User");
            mapper.AddMapping(c => c.Sender_ID_User, "Sender_ID_User");
            mapper.AddMapping(c => c.Message, "Message");
            mapper.AddMapping(c => c.DateSent, "DateSent");
            mapper.AddMapping(c => c.DateRead, "DateRead");
            mapper.AddMapping(c => c.IsRead, "IsRead");

            Program._sqlTableDependency = new SqlTableDependency<MessageThread>(Startup.DBConnectionString, "tMessageThread", "dbo", mapper);
            Program._sqlTableDependency.OnChanged += sqlTableDependencyOnChanged;
            Program._sqlTableDependency.Start();
        }
        public static void sqlTableDependencyOnChanged(object sender, RecordChangedEventArgs<MessageThread> e)
        {
            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Insert)
            {
                int Recipient_ID_User = e.Entity.Recipient_ID_User;
                int Sender_ID_User = e.Entity.Sender_ID_User;

                Dictionary<string, object> dict = new Dictionary<string, object>();

                dict.Add("ID", e.Entity.ID);
                dict.Add("Recipient_ID_User", e.Entity.Recipient_ID_User);
                dict.Add("Sender_ID_User", e.Entity.Sender_ID_User);
                dict.Add("Message", e.Entity.Message);
                dict.Add("DateSent", e.Entity.DateSent);
                dict.Add("DateRead", e.Entity.DateRead);
                dict.Add("IsRead", e.Entity.IsRead);

                Program._hubContext.Clients.Group(Sender_ID_User + "").SendAsync("messageReceived", Recipient_ID_User, dict);
            }
        }
    }
}


