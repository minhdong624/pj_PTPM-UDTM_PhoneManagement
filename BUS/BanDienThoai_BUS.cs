using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class BanDienThoai_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        //Xem khách hàng
        public object XemKhachHang(string tensanpham)
        {
            return db.sp_TimKiemKhachHang(tensanpham);
        }
        //Xem sản phẩm
        public object XemSanPham(string tensp, string tenhang, string tenloai)
        {
            return db.sp_TimKiemSanPham(tensp, tenhang, tenloai);
        }
        public List<HANGDT> HangDienThoai()
        {
            return db.HANGDTs.ToList();
        }
        public List<LOAIDT> LoaiDienThoai()
        {
            return db.LOAIDTs.ToList();
        }
    }
}
