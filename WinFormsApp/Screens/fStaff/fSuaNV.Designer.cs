namespace WinFormsApp
{
    partial class fSuaNV
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
            lblSuaNhanVien = new Label();
            panel3 = new Panel();
            txtTenDangNhap = new TextBox();
            panel4 = new Panel();
            btnSuaNV = new Button();
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
            lblTenDangNhap = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblSuaNhanVien);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(935, 92);
            panel2.TabIndex = 4;
            // 
            // lblSuaNhanVien
            // 
            lblSuaNhanVien.BackColor = SystemColors.ControlDarkDark;
            lblSuaNhanVien.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuaNhanVien.ForeColor = SystemColors.Window;
            lblSuaNhanVien.Location = new Point(245, -2);
            lblSuaNhanVien.Margin = new Padding(2, 0, 2, 0);
            lblSuaNhanVien.Name = "lblSuaNhanVien";
            lblSuaNhanVien.Size = new Size(455, 92);
            lblSuaNhanVien.TabIndex = 0;
            lblSuaNhanVien.Text = "Sửa thông tin";
            lblSuaNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(txtTenDangNhap);
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
            panel3.Controls.Add(lblTenDangNhap);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 92);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(935, 792);
            panel3.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.ForeColor = SystemColors.WindowText;
            txtTenDangNhap.Location = new Point(289, 42);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(604, 37);
            txtTenDangNhap.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSuaNV);
            panel4.Controls.Add(btnThoat);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 674);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(935, 118);
            panel4.TabIndex = 14;
            // 
            // btnSuaNV
            // 
            btnSuaNV.BackColor = SystemColors.Highlight;
            btnSuaNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaNV.Location = new Point(218, 21);
            btnSuaNV.Margin = new Padding(2);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(226, 78);
            btnSuaNV.TabIndex = 0;
            btnSuaNV.Text = "Sửa thông tin";
            btnSuaNV.UseVisualStyleBackColor = false;
            btnSuaNV.Click += btnSuaNV_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(479, 21);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(221, 78);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // cbbChucVu
            // 
            cbbChucVu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(289, 544);
            cbbChucVu.Margin = new Padding(2);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(604, 38);
            cbbChucVu.TabIndex = 13;
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(48, 525);
            lblChucVu.Margin = new Padding(2, 0, 2, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(219, 65);
            lblChucVu.TabIndex = 12;
            lblChucVu.Text = "Chức vụ : ";
            lblChucVu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.ForeColor = SystemColors.WindowText;
            txtDiaChi.Location = new Point(289, 442);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(604, 37);
            txtDiaChi.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(48, 425);
            lblDiaChi.Margin = new Padding(2, 0, 2, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(219, 65);
            lblDiaChi.TabIndex = 10;
            lblDiaChi.Text = "Địa chỉ : ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(289, 342);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(604, 37);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(48, 325);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(219, 65);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email : ";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT.ForeColor = SystemColors.WindowText;
            txtSDT.Location = new Point(289, 242);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(604, 37);
            txtSDT.TabIndex = 7;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(48, 225);
            lblSDT.Margin = new Padding(2, 0, 2, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(219, 65);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "SĐT : ";
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoVaTen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoVaTen.Location = new Point(289, 141);
            txtHoVaTen.Margin = new Padding(2);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(604, 37);
            txtHoVaTen.TabIndex = 5;
            // 
            // lblHovaten
            // 
            lblHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHovaten.Location = new Point(48, 125);
            lblHovaten.Margin = new Padding(2, 0, 2, 0);
            lblHovaten.Name = "lblHovaten";
            lblHovaten.Size = new Size(219, 65);
            lblHovaten.TabIndex = 4;
            lblHovaten.Text = "Họ và tên : ";
            lblHovaten.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(48, 25);
            lblTenDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(219, 65);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập : ";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fSuaNV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 884);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "fSuaNV";
            Text = "fSuaNV";
            Load += fSuaNV_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblSuaNhanVien;
        private Panel panel3;
        private TextBox txtTenDangNhap;
        private Panel panel4;
        private Button btnSuaNV;
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
        private Label lblTenDangNhap;
    }
}