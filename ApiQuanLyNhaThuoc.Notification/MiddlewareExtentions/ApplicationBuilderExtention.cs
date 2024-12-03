

using ApiQuanLyNhaThuoc.NotificationSubscribeTableDependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiQuanLyNhaThuoc.Notification.MiddlewareExtentions
{
    public static class ApplicationBuilderExtention
    {
        public static void UseMiddleware(this Microsoft.AspNetCore.Builder.IApplicationBuilder app)
        {
            var serviceProvider = app.ApplicationServices;
            var service = serviceProvider.GetService(typeof(SubscribeHoaDonTableDependency));
            service.GetType().GetMethod("SubscribeTableDependency");
        }
    }
}
