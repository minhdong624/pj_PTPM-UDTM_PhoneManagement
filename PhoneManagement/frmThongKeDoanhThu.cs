using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;

namespace PhoneManagement
{
    public partial class frmThongKeDoanhThu : Form
    {
        ThongKeDoanhThu_BUS tk = new ThongKeDoanhThu_BUS();
        frmMain f;
        public frmThongKeDoanhThu(frmMain f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            
            dgvDoanhThu.DataSource = tk.GetDataDoanhThu(Convert.ToDateTime(dateTuNgay.EditValue), Convert.ToDateTime(dateDenNgay.EditValue));
            var a = tk.GetDoanhThu(Convert.ToDateTime(dateTuNgay.EditValue), Convert.ToDateTime(dateDenNgay.EditValue));
            if (a == 0)
            {
                txtDoanhThu.Text = "";
                XtraMessageBox.Show("Không tìm thấy doanh thu");
            }
            else
            {
                txtDoanhThu.Text = a.ToString();
            }
        }
    }
}
