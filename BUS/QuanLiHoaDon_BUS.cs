using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class QuanLiHoaDon_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        public object XemHoaDon()
        {
            return (from a in db.HOADONs join b in db.KHACHHANGs 
                    on a.ID_KhachHang equals b.ID_KhachHang
                    select new { a.ID_HoaDon, a.ngayLap,
                        a.ngayGiaoHang, a.ngayNhanHang,
                        a.thanhtien, a.ghiChu, b.tenKhachHang }).ToList();
        }
        public object XemChiTietHoaDon(int ? id)
        {
            if (id != null)
            {
                return (from a in db.HOADONs
                        join b in db.CTHOADONs
                        on a.ID_HoaDon equals b.ID_HoaDon
                        join c in db.USERs
                        on b.ID_User
                        equals c.ID_User
                        join d in db.DIENTHOAIs
                        on b.ID_DienThoai
                        equals d.ID_dienThoai
                        where a.ID_HoaDon == id
                        select new
                        {
                            b.ID_HoaDon,
                            d.tenDienThoai,
                            b.soLuongMua,
                            c.tenNhanVien
                        }).ToList();
            }
            else
            {
                return "Không tồn tại hóa đơn";
            }
        }
        public string XoaHoaDon(int id)
        {
            var ktcthd = (from a in db.CTHOADONs where a.ID_HoaDon == id select a).FirstOrDefault();
            if (ktcthd == null)
            {
                HOADON hd = db.HOADONs.Find(id);
                db.HOADONs.Remove(hd);
                db.SaveChanges();
                return "Xóa thành công";
            }
            else
            {
                return "Hóa đơn này có tồn tại chi tiết hóa đơn bạn hãy xóa chi tiết hóa đơn trước";
            }
        }
        public string XoaToanBoCTHD(int id)
        {
            CTHOADON cthd= (from a in db.CTHOADONs where a.ID_HoaDon==id select a).FirstOrDefault();
            if (cthd != null)
            {
                db.CTHOADONs.Remove(cthd);
                db.SaveChanges();
                return "Xóa thành công";
            }
            else
            {
                return "Không còn chi tiết hóa đơn để xóa nữa";
            }
        }
        public object TimKiemHoaDon(string str)
        {
            return (from a in db.HOADONs
                    join b in db.KHACHHANGs on a.ID_KhachHang equals b.ID_KhachHang where b.tenKhachHang.Contains(str)
                    select new
                    {
                        a.ID_HoaDon,
                        a.ngayLap,
                        a.ngayGiaoHang,
                        a.ngayNhanHang,
                        a.thanhtien,
                        a.ghiChu,
                        b.tenKhachHang
                    }).ToList();
         }
    }
}
