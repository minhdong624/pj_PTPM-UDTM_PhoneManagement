using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class QuanLiKhachHang_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        DieuKienKiemTra_BUS dk = new DieuKienKiemTra_BUS();
        public object XemKhachHang()
        {
            return db.KHACHHANGs.ToList();
        }
        public string ThemKhachHang(string tenKH, string SDT, string email, string diachi, string cmnd)
        {
            if (dk.KiemTraSoDienThoai(SDT) == true && SDT.Length >= 10 && SDT.Length <= 11 && dk.KiemTraSoDienThoai(cmnd) == true && cmnd.Length <= 10)
            {
                if (dk.KiemTraEmail(email) == true)
                {
                    if (dk.KiemTraCMND(cmnd) == false)
                    {
                        KHACHHANG kh = new KHACHHANG();
                        kh.tenKhachHang = tenKH;
                        kh.SDT = SDT;
                        kh.diaChi = diachi;
                        kh.SCMND = cmnd;
                        kh.email = email;
                        db.KHACHHANGs.Add(kh);
                        db.SaveChanges();
                        return "Thêm thành công";
                    }
                    else
                    {
                        return "Chứng minh nhân dân đã tồn tại";
                    }
                }
                else
                {
                    return "Không đúng định dạng Email";
                }
            }
            else
            {
                return "Số điện thoại và chứng minh phải là số và số điện thoại từ 10 đến 11 số và số chứng minh là nhỏ hơn hoặc bằng 10 kí tự!";
            }
        }
        public string XoaKhachHang(int id)
        {
            var ktcthd = (from a in db.HOADONs where a.ID_KhachHang == id select a).FirstOrDefault();
            if (ktcthd == null)
            {
                KHACHHANG kh = db.KHACHHANGs.Find(id);
                db.KHACHHANGs.Remove(kh);
                db.SaveChanges();
                return "Xóa thành công";
            }
            else
            {
                return "Khách hàng này có đơn hàng trong hóa đơn không thể xóa";
            }
        }
        public string SuaKhachHang(int id, string tenKH, string SDT, string email, string diachi, string cmnd)
        {
            if (dk.KiemTraSoDienThoai(SDT) == true && SDT.Length >= 10 && SDT.Length <= 11 && dk.KiemTraSoDienThoai(cmnd) == true && cmnd.Length <= 10)
            {
                if (dk.KiemTraEmail(email) == true)
                {
                    var kh = db.KHACHHANGs.Where(x => x.ID_KhachHang == id).FirstOrDefault();
                    if (kh != null)
                    {
                        kh.tenKhachHang = tenKH;
                        kh.SDT = SDT;
                        kh.diaChi = diachi;
                        kh.SCMND = cmnd;
                        kh.email = email;
                    }
                    db.Entry(kh).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Sửa thành công";
                }
                else
                {
                    return "Không đúng định dạng Email";
                }
            }
            else
            {
                return "Số điện thoại và chứng minh phải là số và số điện thoại từ 10 đến 11 số và số chứng minh là nhỏ hơn hoặc bằng 10 kí tự";
            }
        }
        public object search(string value)
        {
            return db.KHACHHANGs.Where(x => x.tenKhachHang.Contains(value) || x.SCMND.Contains(value) || x.SDT.Contains(value) || x.diaChi.Contains(value) || x.email.Contains(value)).ToList();
        }
    }
}
