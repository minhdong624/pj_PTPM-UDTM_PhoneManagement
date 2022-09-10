namespace PhoneManagement
{
    partial class frmDoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupNhapThongTin = new DevExpress.XtraEditors.GroupControl();
            this.txtNhapLaiMatkhau = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhapThongTin)).BeginInit();
            this.groupNhapThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupNhapThongTin);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // groupNhapThongTin
            // 
            this.groupNhapThongTin.Controls.Add(this.txtNhapLaiMatkhau);
            this.groupNhapThongTin.Controls.Add(this.labelControl3);
            this.groupNhapThongTin.Controls.Add(this.txtMatKhauMoi);
            this.groupNhapThongTin.Controls.Add(this.labelControl1);
            this.groupNhapThongTin.Controls.Add(this.txtMatKhauCu);
            this.groupNhapThongTin.Controls.Add(this.labelControl2);
            this.groupNhapThongTin.Controls.Add(this.btnDoiMatKhau);
            this.groupNhapThongTin.Controls.Add(this.btnThoat);
            this.groupNhapThongTin.Location = new System.Drawing.Point(229, 12);
            this.groupNhapThongTin.Name = "groupNhapThongTin";
            this.groupNhapThongTin.Size = new System.Drawing.Size(338, 426);
            this.groupNhapThongTin.TabIndex = 0;
            this.groupNhapThongTin.Text = "Nhập thông tin";
            this.groupNhapThongTin.SizeChanged += new System.EventHandler(this.groupNhapThongTin_SizeChanged);
            // 
            // txtNhapLaiMatkhau
            // 
            this.txtNhapLaiMatkhau.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatkhau.Location = new System.Drawing.Point(43, 297);
            this.txtNhapLaiMatkhau.Name = "txtNhapLaiMatkhau";
            this.txtNhapLaiMatkhau.Size = new System.Drawing.Size(252, 30);
            this.txtNhapLaiMatkhau.TabIndex = 2;
            this.txtNhapLaiMatkhau.UseSystemPasswordChar = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(43, 259);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.ShowLineShadow = false;
            this.labelControl3.Size = new System.Drawing.Size(187, 22);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(43, 209);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(252, 30);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 166);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(116, 22);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(43, 117);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(252, 30);
            this.txtMatKhauCu.TabIndex = 0;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.ShowLineShadow = false;
            this.labelControl2.Size = new System.Drawing.Size(104, 22);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Mật khẩu cũ";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(185, 362);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(131, 39);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(21, 362);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.SizeChanged += new System.EventHandler(this.frmDoiMatKhau_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupNhapThongTin)).EndInit();
            this.groupNhapThongTin.ResumeLayout(false);
            this.groupNhapThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupNhapThongTin;
        private System.Windows.Forms.TextBox txtNhapLaiMatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}