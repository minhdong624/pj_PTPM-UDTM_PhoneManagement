using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class QuanLiLoaiDienThoai_BUS
    {
        DataContext db=new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        public object XemLoaiDienThoai()
        {
            return db.LOAIDTs.ToList();
        }
        public void ThemLoaiDienThoai(string tenLoai, string moTa)
        {
            LOAIDT ldt = new LOAIDT();
            ldt.tenLoaiDT = tenLoai;
            ldt.moTa = moTa;
            db.LOAIDTs.Add(ldt);
            db.SaveChanges();
        }
        public void XoaLoaiDienThoai(int id)
        {
            LOAIDT ldt = db.LOAIDTs.Find(id);
            db.LOAIDTs.Remove(ldt);
            db.SaveChanges();
        }
        public void SuaLoaiDienThoai(int id, string tenLoai, string moTa)
        {
            var ldt = db.LOAIDTs.Where(x => x.ID_LoaiDT == id).FirstOrDefault();
            if (ldt != null)
            {
                ldt.tenLoaiDT = tenLoai;
                ldt.moTa = moTa;
            }
            db.Entry(ldt).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
