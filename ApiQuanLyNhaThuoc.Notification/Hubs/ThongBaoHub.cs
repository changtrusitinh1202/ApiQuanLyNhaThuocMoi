using ApiQuanLyNhaThuoc.Business.Service.IService;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceScopeFactory serviceScopeFactory;
        public ThongBaoHub(IServiceScopeFactory serviceScopeFactory)
        {
            //this.hoaDonBanHangService = hoaDonBanHangService;
            this.serviceScopeFactory = serviceScopeFactory;
        }

        public async Task SendHoaDons()
        {
          //  var hoaDonBanHangs = .GetHoaDonBanHangTaiQuay();
            using (var scope = serviceScopeFactory.CreateScope())
            {
                var hoaDonBanHangService = scope.ServiceProvider.GetRequiredService<IHoaDonBanHangService>();
                var hoaDonBanHangs = hoaDonBanHangService.GetHoaDonBanHangTaiQuay();
                await Clients.All.SendAsync("ReceiveHoaDonOffs", hoaDonBanHangs);
                // Thực hiện logic với hoaDonBanHangService nếu cần
            }
           
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
