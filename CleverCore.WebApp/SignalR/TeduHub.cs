using CleverCore.Application.ViewModels.System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CleverCore.WebApp.SignalR
{
    public class TeduHub : Hub
    {
        public async Task SendMessage(AnnouncementViewModel message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}