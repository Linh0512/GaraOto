namespace WinFormsApp.MainScenne.fStaff
{
    partial class fSuaThongTin
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
            panel4 = new Panel();
            btnXacNhanSua = new Button();
            btnSuaThongTin = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            lblThongTinChiTiet = new Label();
            panel2 = new Panel();
            cbbChucVu = new ComboBox();
            lblChucVu = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtHoVaTen = new TextBox();
            lblHovaten = new Label();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(btnXacNhanSua);
            panel4.Controls.Add(btnSuaThongTin);
            panel4.Controls.Add(btnThoat);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 435);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(752, 49);
            panel4.TabIndex = 15;
            // 
            // btnXacNhanSua
            // 
            btnXacNhanSua.BackColor = Color.FromArgb(128, 255, 255);
            btnXacNhanSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhanSua.Location = new Point(244, 0);
            btnXacNhanSua.Name = "btnXacNhanSua";
            btnXacNhanSua.Size = new Size(197, 46);
            btnXacNhanSua.TabIndex = 2;
            btnXacNhanSua.Text = "Xác nhận sữa thông tin";
            btnXacNhanSua.UseVisualStyleBackColor = false;
            btnXacNhanSua.Click += btnXacNhanSua_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.ForestGreen;
            btnSuaThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaThongTin.Location = new Point(505, 2);
            btnSuaThongTin.Margin = new Padding(2);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(158, 46);
            btnSuaThongTin.TabIndex = 0;
            btnSuaThongTin.Text = "Sữa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(667, 26);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(78, 22);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(lblThongTinChiTiet);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 68);
            panel1.TabIndex = 16;
            // 
            // lblThongTinChiTiet
            // 
            lblThongTinChiTiet.BackColor = SystemColors.ControlDarkDark;
            lblThongTinChiTiet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinChiTiet.Location = new Point(227, 0);
            lblThongTinChiTiet.Margin = new Padding(2, 0, 2, 0);
            lblThongTinChiTiet.Name = "lblThongTinChiTiet";
            lblThongTinChiTiet.Size = new Size(290, 68);
            lblThongTinChiTiet.TabIndex = 0;
            lblThongTinChiTiet.Text = "THÔNG TIN CHI TIẾT";
            lblThongTinChiTiet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbChucVu);
            panel2.Controls.Add(lblChucVu);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(lblDiaChi);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(lblSDT);
            panel2.Controls.Add(txtHoVaTen);
            panel2.Controls.Add(lblHovaten);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(lblMatKhau);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(lblTenDangNhap);
            panel2.Location = new Point(0, 71);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 359);
            panel2.TabIndex = 17;
            // 
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(244, 302);
            cbbChucVu.Margin = new Padding(2);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(403, 23);
            cbbChucVu.TabIndex = 27;
            cbbChucVu.SelectedIndexChanged += cbbChucVu_SelectedIndexChanged;
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(76, 291);
            lblChucVu.Margin = new Padding(2, 0, 2, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(153, 39);
            lblChucVu.TabIndex = 26;
            lblChucVu.Text = "Chức vụ : ";
            lblChucVu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(244, 253);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(403, 23);
            txtDiaChi.TabIndex = 25;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(76, 241);
            lblDiaChi.Margin = new Padding(2, 0, 2, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(153, 39);
            lblDiaChi.TabIndex = 24;
            lblDiaChi.Text = "Địa chỉ : ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 206);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(403, 23);
            txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(76, 193);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(153, 39);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email : ";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(244, 158);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(403, 23);
            txtSDT.TabIndex = 21;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(76, 146);
            lblSDT.Margin = new Padding(2, 0, 2, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(153, 39);
            lblSDT.TabIndex = 20;
            lblSDT.Text = "SĐT : ";
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(244, 119);
            txtHoVaTen.Margin = new Padding(2);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.ReadOnly = true;
            txtHoVaTen.Size = new Size(403, 23);
            txtHoVaTen.TabIndex = 19;
            // 
            // lblHovaten
            // 
            lblHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHovaten.Location = new Point(76, 107);
            lblHovaten.Margin = new Padding(2, 0, 2, 0);
            lblHovaten.Name = "lblHovaten";
            lblHovaten.Size = new Size(153, 39);
            lblHovaten.TabIndex = 18;
            lblHovaten.Text = "Họ và tên : ";
            lblHovaten.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(244, 80);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.ReadOnly = true;
            txtMatKhau.Size = new Size(403, 23);
            txtMatKhau.TabIndex = 17;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(76, 68);
            lblMatKhau.Margin = new Padding(2, 0, 2, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(153, 39);
            lblMatKhau.TabIndex = 16;
            lblMatKhau.Text = "Mật khẩu : ";
            lblMatKhau.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(244, 41);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = true;
            txtTenDangNhap.RightToLeft = RightToLeft.Yes;
            txtTenDangNhap.Size = new Size(403, 23);
            txtTenDangNhap.TabIndex = 15;
            txtTenDangNhap.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(76, 29);
            lblTenDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(153, 39);
            lblTenDangNhap.TabIndex = 14;
            lblTenDangNhap.Text = "Tên đăng nhập : ";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
            lblTenDangNhap.Click += lblTenDangNhap_Click;
            // 
            // fSuaThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 484);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Margin = new Padding(2);
            Name = "fSuaThongTin";
            Text = "fSuaThongTin";
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button btnSuaThongTin;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cbbChucVu;
        private Label lblChucVu;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtSDT;
        private Label lblSDT;
        private TextBox txtHoVaTen;
        private Label lblHovaten;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private Label lblThongTinChiTiet;
        private Button btnXacNhanSua;
    }
}