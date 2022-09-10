using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Model;

namespace PhoneManagement
{
    public partial class frmBanDienThoai : Form
    {
        BanDienThoai_BUS b = new BanDienThoai_BUS();
        DataTable dtGioHang = new DataTable();
        frmMain f;
        public frmBanDienThoai(frmMain f)
        {
            this.f = f;
            dtGioHang.Columns.Add("Mã khách hàng", typeof(string));
            dtGioHang.Columns.Add("Mã sản phẩm", typeof(string));
            dtGioHang.Columns.Add("Tên sản phẩm");
            dtGioHang.Columns.Add("Số lượng");
            dtGioHang.Columns.Add("Đơn giá");
            dtGioHang.Columns.Add("Thành tiền");
            InitializeComponent();
        }

        private void frmBanDienThoai_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = b.XemKhachHang(txtTimKiemKhachHang.Text);
            dgvSanPham.DataSource = b.XemSanPham(txtTimKiemSanPham.Text, cmbHangDienThoai.Text, cmbLoaiDienThoai.Text);
            cmbHangDienThoai.DataSource = b.HangDienThoai();
            cmbHangDienThoai.ValueMember = "ID_HangDT";
            cmbHangDienThoai.DisplayMember = "tenHang";
            cmbLoaiDienThoai.DataSource = b.LoaiDienThoai();
            cmbLoaiDienThoai.ValueMember = "ID_LoaiDT";
            cmbLoaiDienThoai.DisplayMember = "tenLoaiDT";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = b.XemKhachHang(txtTimKiemKhachHang.Text);
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = b.XemSanPham(txtTimKiemSanPham.Text, cmbHangDienThoai.Text, cmbLoaiDienThoai.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiemSanPham.Text = "";
            dgvSanPham.DataSource = b.XemSanPham(txtTimKiemSanPham.Text, "", "");
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            int idKhachHang = Convert.ToInt32(gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "ID_KhachHang"));
            int idSanpham = Convert.ToInt32(gvSanPham.GetRowCellValue(gvSanPham.FocusedRowHandle, "ID_dienThoai"));
            var tenKhachHang = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "tenKhachHang");
            var tenSanPham = gvSanPham.GetRowCellValue(gvSanPham.FocusedRowHandle, "tenDienThoai");
            var donGia = gvSanPham.GetRowCellValue(gvSanPham.FocusedRowHandle, "donGia");
            int soluong = Convert.ToInt32(numSoLuong.Value);
            if (dateNgayGiaoHang.DateTime.Date < DateTime.Now.Date || dateNgayNhanHang.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày giao hàng hoặc ngày nhận hàng không được bé hơn ngày hiện tại");
            }
            else
            {
                if (soluong == 0 || soluong < 0)
                {
                    XtraMessageBox.Show("Số lượng không được phép nhỏ hơn 0 và số âm");
                }
                else
                {
                    if (soluong > Convert.ToInt32(gvSanPham.GetRowCellValue(gvSanPham.FocusedRowHandle, "soLuongTon")))
                    {
                        XtraMessageBox.Show("Số lượng tồn không đủ cung cấp hãy nhập thêm vào kho");
                    }
                    else
                    {
                        if (dtGioHang.Rows.Count > 0)
                        {
                            var ktKhachHang = (from a in dtGioHang.AsEnumerable() where a.Field<string>("Mã khách hàng") == idKhachHang.ToString() select a).FirstOrDefault();
                            if (ktKhachHang != null)
                            {
                                var ktSanPham = (from a in dtGioHang.AsEnumerable() where a.Field<string>("Mã sản phẩm") == idSanpham.ToString() select a).FirstOrDefault();
                                if (ktSanPham != null)
                                {
                                    XtraMessageBox.Show("Thêm vào giỏ hàng thất bại sản phẩm đã tồn tại trong giỏ hàng hãy xóa và sửa lại số lượng khi muốn bán");
                                }
                                else
                                {
                                    txtTenKhachHangMua.Text = tenKhachHang.ToString();
                                    dtGioHang.Rows.Add(idKhachHang, idSanpham, tenSanPham, soluong, donGia, soluong * Convert.ToDecimal(donGia));
                                    dgvGioHang.DataSource = dtGioHang;
                                    XtraMessageBox.Show("Thêm vào giỏ hàng thành công");
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Khách hàng mua chỉ được một người không chọn thêm!");
                            }
                        }
                        else
                        {
                            txtTenKhachHangMua.Text = tenKhachHang.ToString();
                            dtGioHang.Rows.Add(idKhachHang, idSanpham, tenSanPham, soluong, donGia, soluong * Convert.ToDecimal(donGia));
                            dgvGioHang.DataSource = dtGioHang;
                            XtraMessageBox.Show("Thêm vào giỏ hàng thành công");
                        }
                    }
                }
            }
                
            
        }
      
      

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            double tong = 0;
            if(dateNgayGiaoHang.Text != "" && dateNgayLapHoaDon.Text != "" && dateNgayNhanHang.Text != "")
            {
                if (gvGioHang.RowCount > 0)
                {
                    using (DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity))
                    {
                        var a = gvGioHang.GetRowCellValue(gvGioHang.FocusedRowHandle, "Mã khách hàng");
                        HOADON hd = new HOADON();
                        hd.ID_KhachHang = Convert.ToInt32(a);
                        hd.ngayLap = Convert.ToDateTime(dateNgayLapHoaDon.Text);
                        hd.ghiChu = rtxtGhiChu.Text;
                        hd.ngayGiaoHang = Convert.ToDateTime(dateNgayGiaoHang.Text);
                        hd.ngayNhanHang = Convert.ToDateTime(dateNgayNhanHang.Text);

                        foreach (DataRow item in dtGioHang.Rows)
                        {               

                            string sql = "update DienThoai set soLuongTon=soLuongTon-{0} where ID_dienThoai={1}";
                            db.Database.ExecuteSqlCommand(sql, Convert.ToInt32(item["Số lượng"]), Convert.ToInt32(item["Mã sản phẩm"]));

                            CTHOADON cthd = new CTHOADON();
                            cthd.ID_DienThoai = Convert.ToInt32(item["Mã sản phẩm"]);
                            cthd.soLuongMua = Convert.ToInt32(item["Số lượng"]);
                            cthd.ID_User = Convert.ToInt32(SessionLogin_BUS.idUser);
                            db.CTHOADONs.Add(cthd);
                            tong = tong + Convert.ToDouble(item["Thành tiền"]);
                        }
                        hd.thanhtien = Convert.ToDecimal(tong);
                        db.HOADONs.Add(hd);
                        db.SaveChanges();
                    }
                    dgvSanPham.DataSource = b.XemSanPham(txtTimKiemSanPham.Text, "", "");
                    XtraMessageBox.Show("Thanh toán thành công!");
                    dtGioHang.Clear();
                }
                else
                {
                    XtraMessageBox.Show("Hãy chọn sản phẩm");
                }
            }
            else
            {
                XtraMessageBox.Show("Không được bỏ trống thông tin về ngày giao hàng và nhận hàng");
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtGioHang.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gvGioHang.DeleteRow(gvGioHang.FocusedRowHandle);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Chức năng chưa xử lí :V"); //
        }

        private void gvSanPham_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string filepath = Path.Combine(Application.StartupPath, @"Image\");
            if (gvSanPham.RowCount > 0)
            {
                if (gvSanPham.GetRowCellValue(e.FocusedRowHandle, "hinhAnh").ToString() != "")
                {
                    picDienThoai.Image = Image.FromFile(filepath + gvSanPham.GetRowCellValue(e.FocusedRowHandle, "hinhAnh").ToString());
                }
            }
            else
            {
                picDienThoai.Image = null;
            }
        }
    }
}
