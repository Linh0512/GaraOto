
namespace WinFormsApp
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            panel1 = new Panel();
            lblNhanVien = new Label();
            panel2 = new Panel();
            btnDatMatKhau = new Button();
            btnHuy = new Button();
            btnXacNhan = new Button();
            lblChucVu = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            lblSoDienThoai = new Label();
            lblHoVaTen = new Label();
            lblTenDangNhap = new Label();
            cbbChucVu = new ComboBox();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHovaTen = new TextBox();
            panel3 = new Panel();
            txtTenDangNhap = new TextBox();
            lblThongTinChiTiet = new Label();
            btnXoa = new Button();
            button1 = new Button();
            btnInDanhSach = new Button();
            btnSuaThongTin = new Button();
            btnThem = new Button();
            dgvNhanVien = new DataGridView();
            btnThoat = new Button();
            txtTiemKiem = new TextBox();
            btnTiemKIem = new Button();
            lblDanhSachNhanVien = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(lblNhanVien);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 61);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblNhanVien
            // 
            lblNhanVien.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.ForeColor = SystemColors.Window;
            lblNhanVien.ImageAlign = ContentAlignment.BottomCenter;
            lblNhanVien.Location = new Point(10, 9);
            lblNhanVien.Margin = new Padding(2, 0, 2, 0);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(235, 46);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "NHÂN VIÊN";
            lblNhanVien.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDatMatKhau);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnXacNhan);
            panel2.Controls.Add(lblChucVu);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblDiaChi);
            panel2.Controls.Add(lblSoDienThoai);
            panel2.Controls.Add(lblHoVaTen);
            panel2.Controls.Add(lblTenDangNhap);
            panel2.Controls.Add(cbbChucVu);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtHovaTen);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(lblThongTinChiTiet);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnInDanhSach);
            panel2.Controls.Add(btnSuaThongTin);
            panel2.Location = new Point(507, 119);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 567);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnDatMatKhau
            // 
            btnDatMatKhau.BackColor = SystemColors.HotTrack;
            btnDatMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDatMatKhau.Location = new Point(126, 487);
            btnDatMatKhau.Margin = new Padding(2, 2, 2, 2);
            btnDatMatKhau.Name = "btnDatMatKhau";
            btnDatMatKhau.Size = new Size(217, 58);
            btnDatMatKhau.TabIndex = 21;
            btnDatMatKhau.Text = "Đặt Lại Mật Khẩu";
            btnDatMatKhau.UseVisualStyleBackColor = false;
            btnDatMatKhau.Click += btnDatMatKhau_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.Location = new Point(348, 505);
            btnHuy.Margin = new Padding(2, 2, 2, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(166, 58);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.HotTrack;
            btnXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXacNhan.Location = new Point(168, 505);
            btnXacNhan.Margin = new Padding(2, 2, 2, 2);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(166, 58);
            btnXacNhan.TabIndex = 19;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(66, 430);
            lblChucVu.Margin = new Padding(2, 0, 2, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(131, 30);
            lblChucVu.TabIndex = 18;
            lblChucVu.Text = "Chức vụ :";
            lblChucVu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(66, 362);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(131, 30);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email :";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(66, 294);
            lblDiaChi.Margin = new Padding(2, 0, 2, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(131, 30);
            lblDiaChi.TabIndex = 16;
            lblDiaChi.Text = "Địa chỉ :";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoDienThoai.Location = new Point(66, 226);
            lblSoDienThoai.Margin = new Padding(2, 0, 2, 0);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(131, 30);
            lblSoDienThoai.TabIndex = 15;
            lblSoDienThoai.Text = "Số điện thoại :";
            lblSoDienThoai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(66, 158);
            lblHoVaTen.Margin = new Padding(2, 0, 2, 0);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(131, 30);
            lblHoVaTen.TabIndex = 14;
            lblHoVaTen.Text = "Họ và tên :";
            lblHoVaTen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(66, 90);
            lblTenDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(131, 30);
            lblTenDangNhap.TabIndex = 13;
            lblTenDangNhap.Text = "Tên đăng nhập :";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
            lblTenDangNhap.Click += lblTenDangNhap_Click;
            // 
            // cbbChucVu
            // 
            cbbChucVu.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbChucVu.BackColor = SystemColors.Window;
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(214, 433);
            cbbChucVu.Margin = new Padding(2, 2, 2, 2);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(481, 28);
            cbbChucVu.TabIndex = 12;
            cbbChucVu.Text = "Chức vụ";
            cbbChucVu.SelectedIndexChanged += cbbChucVu_SelectedIndexChanged;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = SystemColors.WindowText;
            panel8.Location = new Point(214, 464);
            panel8.Margin = new Padding(2, 2, 2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(480, 2);
            panel8.TabIndex = 8;
            panel8.Paint += panel8_Paint;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = SystemColors.WindowText;
            panel7.Location = new Point(214, 386);
            panel7.Margin = new Padding(2, 2, 2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(480, 2);
            panel7.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = SystemColors.WindowText;
            panel6.Location = new Point(214, 322);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(480, 2);
            panel6.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = SystemColors.WindowText;
            panel5.Location = new Point(214, 261);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(480, 2);
            panel5.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = SystemColors.WindowText;
            panel4.Location = new Point(214, 184);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 2);
            panel4.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.AutoCompleteMode = AutoCompleteMode.Append;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(214, 362);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(541, 20);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "Email";
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.None;
            txtDiaChi.AutoCompleteMode = AutoCompleteMode.Append;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Location = new Point(214, 300);
            txtDiaChi.Margin = new Padding(2, 2, 2, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(541, 20);
            txtDiaChi.TabIndex = 10;
            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.TextChanged += textBox3_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.None;
            txtSDT.AutoCompleteMode = AutoCompleteMode.Append;
            txtSDT.BorderStyle = BorderStyle.None;
            txtSDT.Location = new Point(214, 237);
            txtSDT.Margin = new Padding(2, 2, 2, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(541, 20);
            txtSDT.TabIndex = 9;
            txtSDT.Text = "Số điện thoại";
            txtSDT.TextChanged += textBox2_TextChanged;
            // 
            // txtHovaTen
            // 
            txtHovaTen.Anchor = AnchorStyles.None;
            txtHovaTen.AutoCompleteMode = AutoCompleteMode.Append;
            txtHovaTen.BorderStyle = BorderStyle.None;
            txtHovaTen.Location = new Point(214, 160);
            txtHovaTen.Margin = new Padding(2, 2, 2, 2);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.Size = new Size(541, 20);
            txtHovaTen.TabIndex = 8;
            txtHovaTen.Text = "Họ và tên";
            txtHovaTen.TextChanged += textBox1_TextChanged_3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.WindowText;
            panel3.Location = new Point(214, 120);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 2);
            panel3.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.None;
            txtTenDangNhap.AutoCompleteMode = AutoCompleteMode.Append;
            txtTenDangNhap.BorderStyle = BorderStyle.None;
            txtTenDangNhap.Location = new Point(214, 96);
            txtTenDangNhap.Margin = new Padding(2, 2, 2, 2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(541, 20);
            txtTenDangNhap.TabIndex = 7;
            txtTenDangNhap.Text = "Tên đăng nhập";
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // lblThongTinChiTiet
            // 
            lblThongTinChiTiet.BackColor = SystemColors.ActiveCaption;
            lblThongTinChiTiet.Dock = DockStyle.Top;
            lblThongTinChiTiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinChiTiet.Location = new Point(0, 0);
            lblThongTinChiTiet.Margin = new Padding(2, 0, 2, 0);
            lblThongTinChiTiet.Name = "lblThongTinChiTiet";
            lblThongTinChiTiet.Size = new Size(735, 43);
            lblThongTinChiTiet.TabIndex = 6;
            lblThongTinChiTiet.Text = "Thông tin chi tiết";
            lblThongTinChiTiet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(541, 488);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 57);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa Nhân Viên";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoaNhanVien_Click;
            // 
            // button1
            // 
            button1.Location = new Point(274, 18);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(9, 10);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInDanhSach
            // 
            btnInDanhSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInDanhSach.Location = new Point(928, 2);
            btnInDanhSach.Margin = new Padding(2, 2, 2, 2);
            btnInDanhSach.Name = "btnInDanhSach";
            btnInDanhSach.Size = new Size(169, 62);
            btnInDanhSach.TabIndex = 3;
            btnInDanhSach.Text = "In Danh Sách";
            btnInDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = SystemColors.ScrollBar;
            btnSuaThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSuaThongTin.Location = new Point(362, 488);
            btnSuaThongTin.Margin = new Padding(2, 2, 2, 2);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(166, 58);
            btnSuaThongTin.TabIndex = 2;
            btnSuaThongTin.Text = "Sữa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaNV_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(988, 66);
            btnThem.Margin = new Padding(2, 2, 2, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(230, 49);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm Nhân Viên";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(10, 162);
            dgvNhanVien.Margin = new Padding(2, 2, 2, 2);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(494, 520);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Location = new Point(1146, 690);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(89, 26);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTiemKiem
            // 
            txtTiemKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTiemKiem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTiemKiem.Location = new Point(9, 72);
            txtTiemKiem.Margin = new Padding(2, 2, 2, 2);
            txtTiemKiem.Name = "txtTiemKiem";
            txtTiemKiem.Size = new Size(529, 39);
            txtTiemKiem.TabIndex = 5;
            txtTiemKiem.TextAlign = HorizontalAlignment.Center;
            txtTiemKiem.TextChanged += textBox1_TextChanged;
            // 
            // btnTiemKIem
            // 
            btnTiemKIem.Location = new Point(542, 72);
            btnTiemKIem.Margin = new Padding(2, 2, 2, 2);
            btnTiemKIem.Name = "btnTiemKIem";
            btnTiemKIem.Size = new Size(111, 38);
            btnTiemKIem.TabIndex = 6;
            btnTiemKIem.Text = "Tìm kiếm";
            btnTiemKIem.UseVisualStyleBackColor = true;
            btnTiemKIem.Click += btnTiemKIem_Click;
            // 
            // lblDanhSachNhanVien
            // 
            lblDanhSachNhanVien.BackColor = SystemColors.ActiveCaption;
            lblDanhSachNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachNhanVien.Location = new Point(9, 119);
            lblDanhSachNhanVien.Margin = new Padding(2, 0, 2, 0);
            lblDanhSachNhanVien.Name = "lblDanhSachNhanVien";
            lblDanhSachNhanVien.Size = new Size(494, 44);
            lblDanhSachNhanVien.TabIndex = 7;
            lblDanhSachNhanVien.Text = "Danh sách nhân viên";
            lblDanhSachNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 718);
            Controls.Add(lblDanhSachNhanVien);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnTiemKIem);
            Controls.Add(txtTiemKiem);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1270, 765);
            MinimumSize = new Size(1270, 765);
            Name = "fStaff";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NHÂN VIÊN";
            Load += fStaff_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button btnThem;
        private DataGridView dgvNhanVien;
        private Button btnThoat;
        private Button btnSuaThongTin;
        private Button btnInDanhSach;
        private TextBox txtTiemKiem;
        private Button btnTiemKIem;
        private Button button1;
        private Button btnXoa;
        private TextBox txtTenDangNhap;
        private Label lblNhanVien;
        private Label lblThongTinChiTiet;
        public Panel panel3;
        private TextBox txtSDT;
        private TextBox txtHovaTen;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        public Panel panel8;
        public Panel panel7;
        public Panel panel6;
        public Panel panel5;
        public Panel panel4;
        private ComboBox cbbChucVu;
        private Label lblTenDangNhap;
        private Label lblChucVu;
        private Label lblEmail;
        private Label lblDiaChi;
        private Label lblSoDienThoai;
        private Label lblHoVaTen;
        private Button btnXacNhan;
        private Button btnHuy;
        private Button btnDatMatKhau;
        private Label lblDanhSachNhanVien;
    }
}