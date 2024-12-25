namespace WinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemNhanVien));
            panel2 = new Panel();
            lblThêmNhânViên = new Label();
            panel3 = new Panel();
            txtTenDangNhap = new TextBox();
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
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 74);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // lblThêmNhânViên
            // 
            lblThêmNhânViên.BackColor = SystemColors.ControlDarkDark;
            lblThêmNhânViên.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThêmNhânViên.ForeColor = SystemColors.Window;
            lblThêmNhânViên.Location = new Point(196, -2);
            lblThêmNhânViên.Margin = new Padding(2, 0, 2, 0);
            lblThêmNhânViên.Name = "lblThêmNhânViên";
            lblThêmNhânViên.Size = new Size(364, 74);
            lblThêmNhânViên.TabIndex = 0;
            lblThêmNhânViên.Text = "THÊM NHÂN VIÊN";
            lblThêmNhânViên.TextAlign = ContentAlignment.MiddleCenter;
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
            panel3.Location = new Point(0, 74);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(752, 642);
            panel3.TabIndex = 6;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.ForeColor = SystemColors.WindowText;
            txtTenDangNhap.Location = new Point(231, 34);
            txtTenDangNhap.Margin = new Padding(2, 2, 2, 2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(484, 32);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnThemNV);
            panel4.Controls.Add(btnThoat);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 548);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(752, 94);
            panel4.TabIndex = 14;
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = SystemColors.Highlight;
            btnThemNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemNV.Location = new Point(174, 17);
            btnThemNV.Margin = new Padding(2, 2, 2, 2);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(181, 62);
            btnThemNV.TabIndex = 0;
            btnThemNV.Text = "Thêm nhân viên";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += btnThemNV_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(383, 17);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(177, 62);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // cbbChucVu
            // 
            cbbChucVu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(231, 435);
            cbbChucVu.Margin = new Padding(2, 2, 2, 2);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(484, 33);
            cbbChucVu.TabIndex = 13;
            cbbChucVu.SelectedIndexChanged += cbbChucVu_SelectedIndexChanged;
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(38, 420);
            lblChucVu.Margin = new Padding(2, 0, 2, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(175, 52);
            lblChucVu.TabIndex = 12;
            lblChucVu.Text = "Chức vụ : ";
            lblChucVu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.ForeColor = SystemColors.WindowText;
            txtDiaChi.Location = new Point(231, 354);
            txtDiaChi.Margin = new Padding(2, 2, 2, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(484, 32);
            txtDiaChi.TabIndex = 11;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(38, 340);
            lblDiaChi.Margin = new Padding(2, 0, 2, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(175, 52);
            lblDiaChi.TabIndex = 10;
            lblDiaChi.Text = "Địa chỉ : ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(231, 274);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(484, 32);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(38, 260);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(175, 52);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email : ";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT.ForeColor = SystemColors.WindowText;
            txtSDT.Location = new Point(231, 194);
            txtSDT.Margin = new Padding(2, 2, 2, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(484, 32);
            txtSDT.TabIndex = 7;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSDT.Location = new Point(38, 180);
            lblSDT.Margin = new Padding(2, 0, 2, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(175, 52);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "SĐT : ";
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoVaTen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoVaTen.Location = new Point(231, 113);
            txtHoVaTen.Margin = new Padding(2, 2, 2, 2);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(484, 32);
            txtHoVaTen.TabIndex = 5;
            txtHoVaTen.TextChanged += txtHoVaTen_TextChanged;
            // 
            // lblHovaten
            // 
            lblHovaten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHovaten.Location = new Point(38, 100);
            lblHovaten.Margin = new Padding(2, 0, 2, 0);
            lblHovaten.Name = "lblHovaten";
            lblHovaten.Size = new Size(175, 52);
            lblHovaten.TabIndex = 4;
            lblHovaten.Text = "Họ và tên : ";
            lblHovaten.TextAlign = ContentAlignment.MiddleRight;
            lblHovaten.Click += lblHovaten_Click;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(38, 20);
            lblTenDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(175, 52);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập : ";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 716);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(770, 763);
            MinimumSize = new Size(770, 763);
            Name = "fThemNhanVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "THÊM NHÂN VIÊN";
            Load += fThemNhanVien_Load;
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
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
    }
}