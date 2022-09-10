using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class QuanLiNguoiDung_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.GetConnectionStringEntity());
        DieuKienKiemTra_BUS dk = new DieuKienKiemTra_BUS();
        

        //Xem thông tin người dùng
        public object XemThongTinNguoiDung()
        {
            return db.sp_ThongTinUsers();
        }

        //Load combobox dữ liệu giới tính
        public List<GioiTinh_BUS> GioiTinh()
        {
            List<GioiTinh_BUS> gioiTinhs = new List<GioiTinh_BUS>();
            gioiTinhs.Add(new GioiTinh_BUS { maGT = 1, tenGT = "Nam" });
            gioiTinhs.Add(new GioiTinh_BUS { maGT = 0, tenGT = "Nữ" });
            return gioiTinhs;
        }

        //Load combobox dữ liệu chức vụ

        public List<ROLE> Role()
        {
            return db.ROLEs.ToList();
        }

        //Thêm người dùng
        public string ThemNguoiDung(string tenNV, string email, string diaChi, string SoDT, string taiKhoan, string matKhau, string luong, int role, bool gioitinh)
        {
            if (dk.KiemTraSoDienThoai(SoDT) == true && dk.KiemTraSoDienThoai(luong) == true)
            {
                if (dk.KiemTraEmail(email) == true)
                {
                    if (dk.KiemTraTaiKhoanUser(taiKhoan) == false)
                    {
                        db.sp_ThemNguoiDung(tenNV, diaChi, gioitinh, email, SoDT, taiKhoan, matKhau, role, Convert.ToInt32(luong));
                        return "Thêm thành công";
                    }
                    else
                    {
                        return "Tài khoản đã tồn tại";
                    }
                }
                else
                {
                    return "Không đúng định dạng Email";
                }
            }
            else
            {
                return "Số điện thoại và lương phải là số";
            }
        }
        //Xóa người dùng
        public string XoaNguoiDung(int uid)
        {
            var ktcthd = (from a in db.CTHOADONs where a.ID_User == uid  select a).FirstOrDefault();
            if (ktcthd == null)
            {
                db.sp_XoaNguoiDung(uid);
                return "Xóa thành công";
            }
            else
            {
                return "Người dùng có đơn hàng trong chi tiết hóa đơn không thể xóa!";
            }
        }
        //Sửa người dùng
        public string SuaNguoiDung(int idnv, string tenNV, string email, string diaChi, string SoDT, string matKhau, string luong, int role, bool gioitinh)
        {
            if (dk.KiemTraSoDienThoai(SoDT) == true && dk.KiemTraSoDienThoai(luong) == true)
            {
                if (dk.KiemTraEmail(email) == true)
                {
                    db.sp_SuaNguoiDung(idnv,tenNV, diaChi, gioitinh, email, SoDT, matKhau, role, Convert.ToInt32(luong));
                    return "Sửa thành công"; 
                }
                else
                {
                    return "Không đúng định dạng Email";
                }
            }
            else
            {
                return "Số điện thoại và lương phải là số";
            }
        }
    }
}
