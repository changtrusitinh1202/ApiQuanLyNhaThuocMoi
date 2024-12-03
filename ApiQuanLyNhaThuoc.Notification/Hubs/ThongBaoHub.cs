using ApiQuanLyNhaThuoc.Business.Service.IService;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApiQuanLyNhaThuoc.Notification.Hubs
{
    public class ThongBaoHub : Hub
    {
        public IHoaDonBanHangService hoaDonBanHangService;

        public ThongBaoHub(IHoaDonBanHangService hoaDonBanHangService, IConfiguration configuration)
        {
            this.hoaDonBanHangService = hoaDonBanHangService;
        }

        public async Task SendHoaDons()
        {
            var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangTaiQuay();
            await Clients.All.SendAsync("ReceiveHoaDonOffs", hoaDonBanHangs);
        }
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
