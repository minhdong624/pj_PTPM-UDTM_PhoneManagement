﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<DIENTHOAI> DIENTHOAIs { get; set; }
        public virtual DbSet<HANGDT> HANGDTs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIDT> LOAIDTs { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
    
        public virtual int sp_SuaNguoiDung(Nullable<int> idnv, string tennv, string diachi, Nullable<bool> gioitinh, string email, string sdt, string matkhau, Nullable<int> role, Nullable<int> luong)
        {
            var idnvParameter = idnv.HasValue ?
                new ObjectParameter("idnv", idnv) :
                new ObjectParameter("idnv", typeof(int));
    
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var gioitinhParameter = gioitinh.HasValue ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(bool));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            var roleParameter = role.HasValue ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(int));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("luong", luong) :
                new ObjectParameter("luong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaNguoiDung", idnvParameter, tennvParameter, diachiParameter, gioitinhParameter, emailParameter, sdtParameter, matkhauParameter, roleParameter, luongParameter);
        }
    
        public virtual int sp_ThemNguoiDung(string tennv, string diachi, Nullable<bool> gioitinh, string email, string sdt, string taikhoan, string matkhau, Nullable<int> role, Nullable<int> luong)
        {
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var gioitinhParameter = gioitinh.HasValue ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(bool));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            var roleParameter = role.HasValue ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(int));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("luong", luong) :
                new ObjectParameter("luong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemNguoiDung", tennvParameter, diachiParameter, gioitinhParameter, emailParameter, sdtParameter, taikhoanParameter, matkhauParameter, roleParameter, luongParameter);
        }
    
        public virtual ObjectResult<sp_ThongTinUsers_Result> sp_ThongTinUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ThongTinUsers_Result>("sp_ThongTinUsers");
        }
    
        public virtual ObjectResult<sp_TimKiemKhachHang_Result> sp_TimKiemKhachHang(string ten)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TimKiemKhachHang_Result>("sp_TimKiemKhachHang", tenParameter);
        }
    
        public virtual ObjectResult<sp_TimKiemSanPham_Result> sp_TimKiemSanPham(string tensanpham, string hangdienthoai, string loaidienthoai)
        {
            var tensanphamParameter = tensanpham != null ?
                new ObjectParameter("tensanpham", tensanpham) :
                new ObjectParameter("tensanpham", typeof(string));
    
            var hangdienthoaiParameter = hangdienthoai != null ?
                new ObjectParameter("hangdienthoai", hangdienthoai) :
                new ObjectParameter("hangdienthoai", typeof(string));
    
            var loaidienthoaiParameter = loaidienthoai != null ?
                new ObjectParameter("loaidienthoai", loaidienthoai) :
                new ObjectParameter("loaidienthoai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TimKiemSanPham_Result>("sp_TimKiemSanPham", tensanphamParameter, hangdienthoaiParameter, loaidienthoaiParameter);
        }
    
        public virtual int sp_XoaNguoiDung(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaNguoiDung", idParameter);
        }
    }
}
