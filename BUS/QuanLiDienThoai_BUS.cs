using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class QuanLiDienThoai_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        DieuKienKiemTra_BUS dk = new DieuKienKiemTra_BUS();
        public object XemDienThoai()
        {
            var model = (from a in db.DIENTHOAIs
                         join b in db.LOAIDTs
                         on a.ID_LoaiDT equals b.ID_LoaiDT
                         join c in db.HANGDTs
                         on a.ID_HangDT equals c.ID_HangDT
                         select new {a.ID_dienThoai, a.tenDienThoai, a.soLuongTon,
                             a.donGia, a.hanBaoHanh, a.moTa,
                             a.ghiChu, a.thongSoKyThuat,
                             b.tenLoaiDT, c.tenHang, a.hinhAnh }).ToList();
            return model;

        }
        public List<LOAIDT> XemLoaiDienThoai()
        {
            return db.LOAIDTs.ToList();
        }
        public List<HANGDT> XemHangDienThoai()
        {
            return db.HANGDTs.ToList();
        }
        public string XoaDienThoai(int id)
        {
            var ktcthd = (from a in db.CTHOADONs where a.ID_DienThoai == id select a).FirstOrDefault();
            if (ktcthd == null)
            {
                DIENTHOAI dt = db.DIENTHOAIs.Find(id);
                db.DIENTHOAIs.Remove(dt);
                db.SaveChanges();
                return "Xóa thành công";
            }
            else
            {
                return "Điện thoại này có đơn hàng trong chi tiết hóa đơn không thể xóa!";
            }  
        }
        public string ThemDienThoai(string tenDT, string soLuongTon,string donGia,DateTime hanBaoHanh, string moTa, string ghiChu, string thongSoKyThuat, int hangDT, int loaiDT, string tenAnh)
        {
            if(dk.KiemTraSoDienThoai(soLuongTon)==true && dk.KiemTraSoDienThoai(donGia) == true)
            {
                DIENTHOAI dt = new DIENTHOAI();
                dt.tenDienThoai = tenDT;
                dt.soLuongTon = Convert.ToInt32(soLuongTon);
                dt.donGia = Convert.ToDecimal(donGia);
                dt.hinhAnh = tenAnh;
                dt.moTa = moTa;
                dt.ghiChu = ghiChu;
                dt.thongSoKyThuat = thongSoKyThuat;
                dt.hanBaoHanh = hanBaoHanh;
                dt.ID_HangDT = hangDT;
                dt.ID_LoaiDT = loaiDT;
                db.DIENTHOAIs.Add(dt);
                db.SaveChanges();
                return "Thêm thành công!";
            }
            else
            {
                return "Số lượng tồn và đơn giá là số, không  âm và lớn hơn 0";
            }
        }
        public string SuaDienThoai(int id, string tenDT, string soLuongTon, string donGia, DateTime hanBaoHanh, string moTa, string ghiChu, string thongSoKyThuat, int hangDT, int loaiDT, string tenAnh)
        {
            if (tenAnh != "")
            {
                if (dk.KiemTraSoDienThoai(soLuongTon) == true && dk.KiemTraSoDienThoai(donGia) == true)
                {
                    DIENTHOAI dt = db.DIENTHOAIs.Where(x => x.ID_dienThoai == id).FirstOrDefault();
                    if (dt != null)
                    {
                        dt.tenDienThoai = tenDT;
                        dt.soLuongTon = Convert.ToInt32(soLuongTon);
                        dt.donGia = Convert.ToDecimal(donGia);
                        dt.hinhAnh = tenAnh;
                        dt.moTa = moTa;
                        dt.ghiChu = ghiChu;
                        dt.thongSoKyThuat = thongSoKyThuat;
                        dt.hanBaoHanh = hanBaoHanh;
                        dt.ID_HangDT = hangDT;
                        dt.ID_LoaiDT = loaiDT;
                    }
                    db.Entry(dt).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Sửa thành công!";
                }
                else
                {
                    return "Số lượng tồn và đơn giá là số";
                }
            }
            else
            {
                if (dk.KiemTraSoDienThoai(soLuongTon) == true && dk.KiemTraSoDienThoai(donGia) == true)
                {
                    DIENTHOAI dt = db.DIENTHOAIs.Where(x => x.ID_dienThoai == id).FirstOrDefault();
                    if (dt != null)
                    {
                        dt.tenDienThoai = tenDT;
                        dt.soLuongTon = Convert.ToInt32(soLuongTon);
                        dt.donGia = Convert.ToDecimal(donGia);
                        dt.moTa = moTa;
                        dt.ghiChu = ghiChu;
                        dt.thongSoKyThuat = thongSoKyThuat;
                        dt.hanBaoHanh = hanBaoHanh;
                        dt.ID_HangDT = hangDT;
                        dt.ID_LoaiDT = loaiDT;
                        db.DIENTHOAIs.Add(dt);
                    }
                    db.Entry(dt).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Sửa thành công!";
                }
                else
                {
                    return "Số lượng tồn và đơn giá là số";
                }
            }
          
        }
    }
}
