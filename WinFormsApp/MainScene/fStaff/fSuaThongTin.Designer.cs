namespace WinFormsApp.MainScene.fStaff
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
            btnSuaThongTin = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            lblSuaThongTin = new Label();
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
            panel4.Controls.Add(btnSuaThongTin);
            panel4.Controls.Add(btnThoat);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 725);
            panel4.Name = "panel4";
            panel4.Size = new Size(1074, 82);
            panel4.TabIndex = 15;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.ForestGreen;
            btnSuaThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaThongTin.Location = new Point(721, 3);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(226, 76);
            btnSuaThongTin.TabIndex = 0;
            btnSuaThongTin.Text = "Sữa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnThemNV_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(953, 43);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 36);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(lblSuaThongTin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 113);
            panel1.TabIndex = 16;
            // 
            // lblSuaThongTin
            // 
            lblSuaThongTin.BackColor = SystemColors.ControlDarkDark;
            lblSuaThongTin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuaThongTin.Location = new Point(324, 0);
            lblSuaThongTin.Name = "lblSuaThongTin";
            lblSuaThongTin.Size = new Size(415, 113);
            lblSuaThongTin.TabIndex = 0;
            lblSuaThongTin.Text = "SỮA THÔNG TIN";
            lblSuaThongTin.TextAlign = ContentAlignment.MiddleCenter;
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
            panel2.Location = new Point(0, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1031, 599);
            panel2.TabIndex = 17;
            // 
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(348, 504);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(574, 33);
            cbbChucVu.TabIndex = 27;
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(108, 485);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(219, 65);
            lblChucVu.TabIndex = 26;
            lblChucVu.Text = "Chức vụ : ";
            lblChucVu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(348, 422);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(574, 31);
            txtDiaChi.TabIndex = 25;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(108, 401);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(219, 65);
            lblDiaChi.TabIndex = 24;
            lblDiaChi.Text = "Địa chỉ : ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(348, 343);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(574, 31);
            txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(108, 322);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(219, 65);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email : ";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(348, 264);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(574, 31);
            txtSDT.TabIndex = 21;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(108, 243);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(219, 65);
            lblSDT.TabIndex = 20;
            lblSDT.Text = "SĐT : ";
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(348, 199);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(574, 31);
            txtHoVaTen.TabIndex = 19;
            // 
            // lblHovaten
            // 
            lblHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHovaten.Location = new Point(108, 178);
            lblHovaten.Name = "lblHovaten";
            lblHovaten.Size = new Size(219, 65);
            lblHovaten.TabIndex = 18;
            lblHovaten.Text = "Họ và tên : ";
            lblHovaten.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(348, 134);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(574, 31);
            txtMatKhau.TabIndex = 17;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(108, 113);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(219, 65);
            lblMatKhau.TabIndex = 16;
            lblMatKhau.Text = "Mật khẩu : ";
            lblMatKhau.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(348, 69);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(574, 31);
            txtTenDangNhap.TabIndex = 15;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(108, 48);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(219, 65);
            lblTenDangNhap.TabIndex = 14;
            lblTenDangNhap.Text = "Tên đăng nhập : ";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
            lblTenDangNhap.Click += lblTenDangNhap_Click;
            // 
            // fSuaThongTin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 807);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
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
        private Label lblSuaThongTin;
    }
}