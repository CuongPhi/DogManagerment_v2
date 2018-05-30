using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public static class StatisticBillBUS
    {
        static StatisticBillRepository reps = new StatisticBillRepository();
        public static List<SoQuy> thongKe()
        {
            return reps.thongKe();
        }
        static StatisticBillBUS()
        {
            reps = new StatisticBillRepository();
        }
        public static List<SoQuy> search(string ten)
        {
            return reps.search(ten);
        }
        public static List<SoQuy> DaThanhToan()
        {
            return reps.trangThaiThanhToan();
        }
        public static List<SoQuy> DaHuy()
        {
            return reps.trangThaiDaHuy();
        }
        public static List<SoQuy> LoaiThu(DateTime start, DateTime end)
        {
            return reps.LoaiPhieuThu(start, end);
        }
        public static List<SoQuy> LoaiChi(DateTime start, DateTime end)
        {
            return reps.LoaiPhieuChi(start, end);
        }
    }
}
