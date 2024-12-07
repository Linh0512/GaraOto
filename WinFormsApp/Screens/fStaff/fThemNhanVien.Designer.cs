﻿namespace WinFormsApp
{
    partial class fThemNhanVien
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
            panel2 = new Panel();
            lblThêmNhânViên = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            btnThemNV = new Button();
            btnThoat = new Button();
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
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblThêmNhânViên);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 92);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // lblThêmNhânViên
            // 
            lblThêmNhânViên.BackColor = SystemColors.ControlDarkDark;
            lblThêmNhânViên.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThêmNhânViên.Location = new Point(373, 0);
            lblThêmNhânViên.Name = "lblThêmNhânViên";
            lblThêmNhânViên.Size = new Size(301, 92);
            lblThêmNhânViên.TabIndex = 0;
            lblThêmNhânViên.Text = "Thêm Nhân Viên";
            lblThêmNhânViên.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(cbbChucVu);
            panel3.Controls.Add(lblChucVu);
            panel3.Controls.Add(txtDiaChi);
            panel3.Controls.Add(lblDiaChi);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(txtSDT);
            panel3.Controls.Add(lblSDT);
            panel3.Controls.Add(txtHoVaTen);
            panel3.Controls.Add(lblHovaten);
            panel3.Controls.Add(txtMatKhau);
            panel3.Controls.Add(lblMatKhau);
            panel3.Controls.Add(txtTenDangNhap);
            panel3.Controls.Add(lblTenDangNhap);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(1068, 768);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnThemNV);
            panel4.Controls.Add(btnThoat);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 686);
            panel4.Name = "panel4";
            panel4.Size = new Size(1068, 82);
            panel4.TabIndex = 14;
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = Color.Green;
            btnThemNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemNV.Location = new Point(721, 3);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(226, 76);
            btnThemNV.TabIndex = 0;
            btnThemNV.Text = "Thêm nhân viên";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += btnThemNV_Click;
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
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(293, 536);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(574, 33);
            cbbChucVu.TabIndex = 13;
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(53, 517);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(219, 65);
            lblChucVu.TabIndex = 12;
            lblChucVu.Text = "Chức vụ : ";
            lblChucVu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(293, 454);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(574, 31);
            txtDiaChi.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(53, 433);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(219, 65);
            lblDiaChi.TabIndex = 10;
            lblDiaChi.Text = "Địa chỉ : ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(293, 375);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(574, 31);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(53, 354);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(219, 65);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email : ";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(293, 296);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(574, 31);
            txtSDT.TabIndex = 7;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(53, 275);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(219, 65);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "SĐT : ";
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(293, 231);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(574, 31);
            txtHoVaTen.TabIndex = 5;
            // 
            // lblHovaten
            // 
            lblHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHovaten.Location = new Point(53, 210);
            lblHovaten.Name = "lblHovaten";
            lblHovaten.Size = new Size(219, 65);
            lblHovaten.TabIndex = 4;
            lblHovaten.Text = "Họ và tên : ";
            lblHovaten.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(293, 166);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(574, 31);
            txtMatKhau.TabIndex = 3;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(53, 145);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(219, 65);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu : ";
            lblMatKhau.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(293, 101);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(574, 31);
            txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(53, 80);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(219, 65);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập : ";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 860);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "fThemNhanVien";
            Text = "fThemNhanVien";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblThêmNhânViên;
        private Panel panel3;
        private Panel panel4;
        private Button btnThemNV;
        private Button btnThoat;
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
    }
}