using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class ThongKeDoanhThu_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        public decimal GetDoanhThu(DateTime tungay, DateTime denngay)
        {   
            decimal ? tongdoanhthu = (from a in db.HOADONs where a.ngayLap >= tungay && a.ngayLap <= denngay select a.thanhtien).Sum();
            return Convert.ToDecimal(tongdoanhthu);
        }
        public object GetDataDoanhThu(DateTime tungay, DateTime denngay)
        {
            return (from a in db.HOADONs join b in db.KHACHHANGs on a.ID_KhachHang equals b.ID_KhachHang where a.ngayLap >= tungay && a.ngayLap <= denngay select new {a.ID_HoaDon,b.tenKhachHang,a.ngayLap,a.ngayGiaoHang,a.ngayNhanHang,a.thanhtien,a.ghiChu }).ToList();
        }
    }
}
