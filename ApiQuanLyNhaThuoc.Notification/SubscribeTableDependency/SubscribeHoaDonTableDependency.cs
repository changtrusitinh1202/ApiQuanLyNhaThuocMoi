using ApiQuanLyNhaThuoc.Models.Models.Entities;
using ApiQuanLyNhaThuoc.Notification.Hubs;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;

namespace ApiQuanLyNhaThuoc.NotificationSubscribeTableDependency
{
    public class SubscribeHoaDonTableDependency
    {
        SqlTableDependency<HoaDonBanHang> tableDependency;
        private readonly IServiceScopeFactory serviceScopeFactory;
        ThongBaoHub thongBaoHub;
        public SubscribeHoaDonTableDependency(ThongBaoHub thongBaoHub,IServiceScopeFactory serviceScopeFactory)
        {
            this.thongBaoHub = thongBaoHub;
            this.serviceScopeFactory = serviceScopeFactory;
        }
        public void SubscribeTableDependency()
        {
            string connectionString = "Server=tcp:sqldatabasekl.database.windows.net,1433;Initial Catalog=QuanLyNhaThuoc;Persist Security Info=False;User ID=kltn101;Password=giahuy2203.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            tableDependency = new SqlTableDependency<HoaDonBanHang>(connectionString);
            tableDependency.OnChanged += TableDependency_OnChanged;
            tableDependency.OnError += TableDependency_OnError;
            tableDependency.Start();
        }

        private void TableDependency_OnChanged(object sender, RecordChangedEventArgs<HoaDonBanHang> e)
        {
            if (e.ChangeType != TableDependency.SqlClient.Base.Enums.ChangeType.None)
            {
                using (var scope = serviceScopeFactory.CreateScope())
                {
                    thongBaoHub.SendHoaDons();
                }
            }
        }

        private void TableDependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            Console.WriteLine(e.Message);
        }


    }
}
