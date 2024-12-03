using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Utility.Hubs
{
    public class ThongBaoHub : Hub
    {
        public async Task SendNotificationToAll(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }

        // Gửi thông báo đến một client cụ thể (ví dụ, mobile hoặc web)
        public async Task SendNotificationToClient(string connectionId, string message)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveNotification", message);
        }
    }
}
