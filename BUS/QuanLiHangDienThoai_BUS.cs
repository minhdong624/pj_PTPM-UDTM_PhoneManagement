using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class QuanLiHangDienThoai_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        public object XemHangDienThoai()
        {
            return db.HANGDTs.ToList();
        }
        public void ThemHangDienThoai(string tenHang, string moTa, string ghiChu)
        {
            HANGDT hdt = new HANGDT();
            hdt.tenHang= tenHang;
            hdt.moTa = moTa;
            hdt.ghiChu = ghiChu;
            db.HANGDTs.Add(hdt);
            db.SaveChanges();
        }
        public void XoaHangDienThoai(int id)
        {
            HANGDT ldt = db.HANGDTs.Find(id);
            db.HANGDTs.Remove(ldt);
            db.SaveChanges();
        }
        public void SuaHangDienThoai(int id, string tenHang, string moTa, string ghiChu)
        {
            var hdt = db.HANGDTs.Where(x => x.ID_HangDT == id).FirstOrDefault();
            if (hdt != null)
            {
                hdt.tenHang = tenHang;
                hdt.moTa = moTa;
                hdt.ghiChu = ghiChu;
            }
            db.Entry(hdt).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
