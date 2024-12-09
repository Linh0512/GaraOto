
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
            panel1 = new Panel();
            lbl_title = new Label();
            panel2 = new Panel();
            btnXoa = new Button();
            button1 = new Button();
            btnInDanhSach = new Button();
            btnThongTinChiTiet = new Button();
            btnThem = new Button();
            dgvNhanVien = new DataGridView();
            btnThoat = new Button();
            txtTiemKiem = new TextBox();
            btnTiemKIem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(lbl_title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 73);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_title
            // 
            lbl_title.BackColor = SystemColors.ButtonHighlight;
            lbl_title.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(2, 6);
            lbl_title.Margin = new Padding(2, 0, 2, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(280, 61);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Nhân Viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnInDanhSach);
            panel2.Controls.Add(btnThongTinChiTiet);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(8, 423);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 49);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(283, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(148, 46);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa Nhân Viên";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoaNhanVien_Click;
            // 
            // button1
            // 
            button1.Location = new Point(240, 14);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInDanhSach
            // 
            btnInDanhSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInDanhSach.Location = new Point(812, 2);
            btnInDanhSach.Margin = new Padding(2);
            btnInDanhSach.Name = "btnInDanhSach";
            btnInDanhSach.Size = new Size(148, 46);
            btnInDanhSach.TabIndex = 3;
            btnInDanhSach.Text = "In Danh Sách";
            btnInDanhSach.UseVisualStyleBackColor = true;
            btnInDanhSach.Click += btnInDanhSach_Click;
            // 
            // btnThongTinChiTiet
            // 
            btnThongTinChiTiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongTinChiTiet.Location = new Point(569, 0);
            btnThongTinChiTiet.Margin = new Padding(2);
            btnThongTinChiTiet.Name = "btnThongTinChiTiet";
            btnThongTinChiTiet.Size = new Size(158, 46);
            btnThongTinChiTiet.TabIndex = 2;
            btnThongTinChiTiet.Text = "Thông Tin Chi Tiết";
            btnThongTinChiTiet.UseVisualStyleBackColor = true;
            btnThongTinChiTiet.Click += btnSuaNV_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(49, 2);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(148, 46);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm Nhân Viên";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(8, 138);
            dgvNhanVien.Margin = new Padding(2);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(1072, 281);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Location = new Point(988, 476);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(78, 20);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTiemKiem
            // 
            txtTiemKiem.Location = new Point(245, 85);
            txtTiemKiem.Margin = new Padding(2);
            txtTiemKiem.Multiline = true;
            txtTiemKiem.Name = "txtTiemKiem";
            txtTiemKiem.Size = new Size(563, 29);
            txtTiemKiem.TabIndex = 5;
            txtTiemKiem.TextAlign = HorizontalAlignment.Center;
            txtTiemKiem.TextChanged += textBox1_TextChanged;
            // 
            // btnTiemKIem
            // 
            btnTiemKIem.Location = new Point(820, 85);
            btnTiemKIem.Margin = new Padding(2);
            btnTiemKIem.Name = "btnTiemKIem";
            btnTiemKIem.Size = new Size(97, 28);
            btnTiemKIem.TabIndex = 6;
            btnTiemKIem.Text = "Tìm kiếm";
            btnTiemKIem.UseVisualStyleBackColor = true;
            btnTiemKIem.Click += btnTiemKIem_Click;
            // 
            // fStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 498);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnTiemKIem);
            Controls.Add(txtTiemKiem);
            Controls.Add(btnThoat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fStaff";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff";
            Load += fStaff_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private Button btnThongTinChiTiet;
        private Button btnInDanhSach;
        private TextBox txtTiemKiem;
        private Button btnTiemKIem;
        private Label lbl_title;
        private Button button1;
        private Button btnXoa;
    }
}