using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.FlowAnalysis;
using ngJSApp.Database.Models;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace ngJSApp.HubConfig
{
    public class ChatHub : Hub
    {
        public string GetConnectionId() => Context.ConnectionId;

        public async Task NewMessage(string sender, string recipient, string message)
        {
            await Clients.Group(recipient).SendAsync("messageReceived", sender, message);
        }
        public async Task ReceivedMessage(string sender, string recipient, string message)
        {
            await Clients.Group(recipient).SendAsync("messageReceived", sender, message);
        }

        public async Task RegisterGroup(string connectionID, string GroupName)
        {
            await Groups.AddToGroupAsync(connectionID, GroupName);
        }
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
