using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class BaoCaoTonKho_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        public object BaoCao()
        {
            return (from a in db.DIENTHOAIs select new { a.ID_dienThoai, a.tenDienThoai, a.soLuongTon, a.ghiChu }).ToList();
        }
        public object BaoCaoTheoHangVaLoai(int idLoai, int idHang)
        {
            return (from a in db.DIENTHOAIs where a.ID_LoaiDT == idLoai && a.ID_HangDT == idHang select new { a.ID_dienThoai, a.tenDienThoai, a.soLuongTon, a.ghiChu }).ToList();
        }
        public object BaoCaoTheoHang(int idHang)
        {
            return (from a in db.DIENTHOAIs where a.ID_HangDT == idHang select new { a.ID_dienThoai, a.tenDienThoai, a.soLuongTon, a.ghiChu }).ToList();
        }
        public object BaoCaoTheoLoai(int idLoai)
        {
            return (from a in db.DIENTHOAIs where a.ID_LoaiDT == idLoai select new { a.ID_dienThoai, a.tenDienThoai, a.soLuongTon, a.ghiChu }).ToList();
        }
        public List<LOAIDT> ldts()
        {
            return db.LOAIDTs.ToList();
        }
        public List<HANGDT> hdts()
        {
            return db.HANGDTs.ToList();
        }
    }
}
