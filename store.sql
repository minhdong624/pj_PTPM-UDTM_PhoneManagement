create proc sp_ThongTinUsers
as
begin
	select u.ID_User,u.tenNhanVien,u.diaChi,case when u.gioitinh='1' then N'Nam' 
					when u.gioitinh='0' then N'Nữ' end as gioiTinh,u.email,u.SDT,u.taiKhoan,u.matKhau,r.tenRole,u.luong 
					from [USER]  u, [ROLE] r 
					where u.[role]=r.ID_Role
end


create proc sp_ThemNguoiDung
@tennv nvarchar(100),
@diachi nvarchar(150),
@gioitinh bit,
@email varchar(100),
@sdt varchar(11),
@taikhoan varchar(50),
@matkhau varchar(50),
@role int,
@luong int
as
begin
	insert into [USER] (tenNhanVien,diaChi,gioitinh,email,SDT,taiKhoan,matKhau,[role],luong) 
	values (@tennv,@diachi,@gioitinh,@email,@sdt,@taikhoan,@matkhau,@role,@luong) 
end

create proc sp_XoaNguoiDung
@id int
as
begin
	delete from [USER] where  ID_User=@id
end

create proc sp_SuaNguoiDung
@idnv int,
@tennv nvarchar(100),
@diachi nvarchar(150),
@gioitinh bit,
@email varchar(100),
@sdt varchar(11),
@matkhau varchar(50),
@role int,
@luong int
as
begin
	update [USER] set tenNhanVien=@tennv,diaChi=@diachi,gioitinh=@gioitinh,
	email=@email,SDT=@sdt,
	matKhau=@matkhau,role=@role,luong=@luong
	where ID_User=@idnv
end

create proc sp_TimKiemKhachHang
@ten nvarchar(100)
as
begin
	if(@ten='')
		begin
			select kh.ID_KhachHang,kh.tenKhachHang,kh.diaChi,kh.SCMND,kh.SDT,kh.email
			from KHACHHANG kh
		end
	else
		if(@ten!='')
			begin
				select kh.ID_KhachHang,kh.tenKhachHang,kh.diaChi,kh.SCMND,kh.SDT,kh.email
				from KHACHHANG kh 
				where kh.tenKhachHang like N'%'+LTRIM(RTRIM(@ten))+'%'  
				or kh.email like N'%'+LTRIM(RTRIM(@ten))+'%' 
				or kh.SDT like N'%'+LTRIM(RTRIM(@ten))+'%' 
				or kh.SCMND like N'%'+LTRIM(RTRIM(@ten))+'%' 
				order by kh.tenKhachHang desc
			end
end

create proc sp_TimKiemSanPham
@tensanpham nvarchar(100),
@hangdienthoai varchar(50),
@loaidienthoai nvarchar(50) 
as
begin
	if(@tensanpham='' and @hangdienthoai='' and @loaidienthoai='')
		begin
			select dt.ID_dienThoai,dt.tenDienThoai,dt.soLuongTon,dt.donGia,hdt.tenHang,ldt.tenLoaiDT,dt.hanBaoHanh,dt.ghiChu,dt.moTa,dt.hinhAnh 
			from DIENTHOAI dt,HANGDT hdt, LOAIDT ldt 
			where dt.ID_HangDT=hdt.ID_HangDT and ldt.ID_LoaiDT=dt.ID_LoaiDT
		end
	else
		if(@tensanpham='' and @hangdienthoai!='' and @loaidienthoai!='')
			begin
				select dt.ID_dienThoai,dt.tenDienThoai,dt.soLuongTon,dt.donGia,hdt.tenHang,ldt.tenLoaiDT,dt.hanBaoHanh,dt.ghiChu,dt.moTa,dt.hinhAnh 
				from DIENTHOAI dt,HANGDT hdt, LOAIDT ldt 
				where dt.ID_HangDT=hdt.ID_HangDT and ldt.ID_LoaiDT=dt.ID_LoaiDT 
				and hdt.tenHang like @hangdienthoai 
				and ldt.tenLoaiDT like  @loaidienthoai
			end
		else
			if(@tensanpham!='' and @hangdienthoai!='' and @loaidienthoai!='')
				begin
					select dt.ID_dienThoai,dt.tenDienThoai,dt.soLuongTon,dt.donGia,hdt.tenHang,ldt.tenLoaiDT,dt.hanBaoHanh,dt.ghiChu,dt.moTa,dt.hinhAnh 
					from DIENTHOAI dt,HANGDT hdt, LOAIDT ldt 
					where dt.ID_HangDT=hdt.ID_HangDT and ldt.ID_LoaiDT=dt.ID_LoaiDT 
					and hdt.tenHang like @hangdienthoai
					and ldt.tenLoaiDT like @loaidienthoai
					and dt.tenDienThoai like N'%'+LTRIM(RTRIM(@tensanpham))+'%'
				end
end












