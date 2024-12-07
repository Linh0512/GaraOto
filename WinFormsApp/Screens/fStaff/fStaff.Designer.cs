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
            btnInDanhSach = new Button();
            btnSuaNV = new Button();
            btnXoaNV = new Button();
            btnThem = new Button();
            dgvNhanVien = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            textBox1 = new TextBox();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1535, 121);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_title
            // 
            lbl_title.BackColor = SystemColors.ButtonHighlight;
            lbl_title.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(3, 10);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(400, 101);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Nhân Viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInDanhSach);
            panel2.Controls.Add(btnSuaNV);
            panel2.Controls.Add(btnXoaNV);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(12, 705);
            panel2.Name = "panel2";
            panel2.Size = new Size(1499, 82);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnInDanhSach
            // 
            btnInDanhSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInDanhSach.Location = new Point(1160, 3);
            btnInDanhSach.Name = "btnInDanhSach";
            btnInDanhSach.Size = new Size(211, 76);
            btnInDanhSach.TabIndex = 3;
            btnInDanhSach.Text = "In Danh Sách";
            btnInDanhSach.UseVisualStyleBackColor = true;
            btnInDanhSach.Click += btnInDanhSach_Click;
            // 
            // btnSuaNV
            // 
            btnSuaNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSuaNV.Location = new Point(810, 0);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(211, 76);
            btnSuaNV.TabIndex = 2;
            btnSuaNV.Text = "Sữa Thông Tin";
            btnSuaNV.UseVisualStyleBackColor = true;
            btnSuaNV.Click += btnSuaNV_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoaNV.Location = new Point(423, 3);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(211, 76);
            btnXoaNV.TabIndex = 1;
            btnXoaNV.Text = "Xóa Nhân Viên";
            btnXoaNV.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(70, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(211, 76);
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
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvNhanVien.Location = new Point(12, 230);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(1532, 469);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên đăng nhập";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mật khẩu";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Họ và tên";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "SĐT";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Địa chỉ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Chức vụ";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Location = new Point(1411, 793);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(802, 46);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnTiemKIem
            // 
            btnTiemKIem.Location = new Point(1172, 141);
            btnTiemKIem.Name = "btnTiemKIem";
            btnTiemKIem.Size = new Size(139, 46);
            btnTiemKIem.TabIndex = 6;
            btnTiemKIem.Text = "Tìm kiếm";
            btnTiemKIem.UseVisualStyleBackColor = true;
            // 
            // fStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 830);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnTiemKIem);
            Controls.Add(textBox1);
            Controls.Add(btnThoat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
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
        private Button button2;
        private Button btnThem;
        private DataGridView dgvNhanVien;
        private Button btnThoat;
        private Button btnSuaNV;
        private Button btnXoaNV;
        private Button btnInDanhSach;
        private TextBox textBox1;
        private Button btnTiemKIem;
        private Label lbl_title;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}