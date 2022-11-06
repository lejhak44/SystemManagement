using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ngJSApp.Database.Models;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace ngJSApp.Controllers
{
    [CustomAuthorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ChatHubController : Controller
    {
        private SqlTableDependency<vMessage> sqlTableDependency = null;
        private readonly IHubContext<HubConfig.ChatHub> _chathubContext;
        public ChatHubController(
            IHubContext<HubConfig.ChatHub> chathubContext)
        {
            _chathubContext = chathubContext;

            SQLDependencyMessage_Start();
        }

        [HttpPost]
        public ActionResult Index()
        {
            return Ok(new
            {
                success = true
            });
        }
        private void SQLDependencyMessage_Start()
        {
            if (this.sqlTableDependency != null) return;

            var mapper = new ModelToTableMapper<vMessage>();
            mapper.AddMapping(c => c.Recipient_ID_User, "Recipient_ID_User");
            mapper.AddMapping(c => c.Sender_ID_User, "Sender_ID_User");
            mapper.AddMapping(c => c.ID, "ID");

            this.sqlTableDependency = new SqlTableDependency<vMessage>(Startup.DBConnectionString, "tMessage", "", mapper);
            this.sqlTableDependency.OnChanged += sqlTableDependency_OnChanged;

            this.sqlTableDependency.Start();
        }
        private void sqlTableDependency_OnChanged(object sender, RecordChangedEventArgs<vMessage> e)
        {
            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Insert)
            {
                string Recipient_ID_User = e.Entity.Recipient_ID_User.ToString();
                string Sender_ID_User = e.Entity.Sender_ID_User.ToString();
                string ID = e.Entity.ID.ToString();

                _chathubContext.Clients.Group(Recipient_ID_User).SendAsync("messageReceived", Sender_ID_User, "dependency");
            }
        }
    }
}
