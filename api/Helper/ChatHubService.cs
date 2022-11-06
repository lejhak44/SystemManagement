using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace ngJSApp.Helper
{
    public class MessageThread
    {
        public int ID { get; set; }
        public int Recipient_ID_User { get; set; }
        public int Sender_ID_User { get; set; }
        public string Message { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateRead { get; set; }
        public bool? IsRead { get; set; }
    }

    public class ChatHubService
    {
        public void Start()
        {

        }

    }
}
