namespace WinFormsApp.Screens.fInventory
{
    partial class fPayment
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

        #endregion
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPayment));
            btn_close = new Button();
            a = new Label();
            dgvNhapHang = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            vat_tu = new DataGridViewTextBoxColumn();
            gia_nhap = new DataGridViewTextBoxColumn();
            so_luong = new DataGridViewTextBoxColumn();
            tong_tien = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txt_author = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dtpNgayNhap = new DateTimePicker();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            txbIdImport = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label9 = new Label();
            txtTongTien = new Label();
            button2 = new Button();
            button3 = new Button();
            btnThanhToan = new Button();
            button5 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhapHang).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.None;
            btn_close.AutoSize = true;
            btn_close.BackColor = SystemColors.GrayText;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1008, 742);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(430, 59);
            btn_close.TabIndex = 0;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(670, 13);
            a.Name = "a";
            a.Size = new Size(269, 54);
            a.TabIndex = 1;
            a.Text = "NHẬP HÀNG";
            // 
            // dgvNhapHang
            // 
            dgvNhapHang.AllowUserToAddRows = false;
            dgvNhapHang.Anchor = AnchorStyles.None;
            dgvNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhapHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNhapHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapHang.Columns.AddRange(new DataGridViewColumn[] { stt, vat_tu, gia_nhap, so_luong, tong_tien });
            dgvNhapHang.Location = new Point(2, 128);
            dgvNhapHang.Margin = new Padding(3, 4, 3, 4);
            dgvNhapHang.Name = "dgvNhapHang";
            dgvNhapHang.RowHeadersVisible = false;
            dgvNhapHang.RowHeadersWidth = 51;
            dgvNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapHang.Size = new Size(972, 606);
            dgvNhapHang.TabIndex = 2;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            // 
            // vat_tu
            // 
            vat_tu.HeaderText = "Phụ tùng";
            vat_tu.MinimumWidth = 6;
            vat_tu.Name = "vat_tu";
            // 
            // gia_nhap
            // 
            gia_nhap.HeaderText = "Giá nhập";
            gia_nhap.MinimumWidth = 6;
            gia_nhap.Name = "gia_nhap";
            // 
            // so_luong
            // 
            so_luong.HeaderText = "Số lượng";
            so_luong.MinimumWidth = 6;
            so_luong.Name = "so_luong";
            // 
            // tong_tien
            // 
            tong_tien.HeaderText = "Tổng tiền";
            tong_tien.MinimumWidth = 6;
            tong_tien.Name = "tong_tien";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(598, 651);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(598, 575);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 27);
            textBox2.TabIndex = 14;
            // 
            // txt_author
            // 
            txt_author.Location = new Point(221, 174);
            txt_author.Margin = new Padding(3, 4, 3, 4);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(228, 27);
            txt_author.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(2, 99);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 11;
            label2.Text = "Thông tin nhập hàng";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Location = new Point(-106, -104);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1690, 89);
            panel2.TabIndex = 5;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(221, 94);
            dtpNgayNhap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(228, 27);
            dtpNgayNhap.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1268, 619);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(159, 59);
            button1.TabIndex = 8;
            button1.Text = "In hóa đơn";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txbIdImport);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dtpNgayNhap);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txt_author);
            panel3.Location = new Point(1002, 128);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 253);
            panel3.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 16);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 19;
            label3.Text = "Mã phiếu nhập";
            // 
            // txbIdImport
            // 
            txbIdImport.Enabled = false;
            txbIdImport.Location = new Point(221, 19);
            txbIdImport.Margin = new Padding(3, 4, 3, 4);
            txbIdImport.Name = "txbIdImport";
            txbIdImport.Size = new Size(228, 27);
            txbIdImport.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(33, 171);
            label13.Name = "label13";
            label13.Size = new Size(119, 25);
            label13.TabIndex = 17;
            label13.Text = "Người nhập";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(33, 94);
            label14.Name = "label14";
            label14.Size = new Size(109, 25);
            label14.TabIndex = 16;
            label14.Text = "Ngày nhập";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(1002, 466);
            label9.Name = "label9";
            label9.Size = new Size(189, 50);
            label9.TabIndex = 20;
            label9.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Anchor = AnchorStyles.None;
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            txtTongTien.ForeColor = SystemColors.HotTrack;
            txtTongTien.Location = new Point(1268, 466);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(148, 50);
            txtTongTien.TabIndex = 23;
            txtTongTien.Text = "200000";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(62, 742);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(167, 59);
            button2.TabIndex = 24;
            button2.Text = "Mua phụ tùng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(622, 742);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(167, 59);
            button3.TabIndex = 25;
            button3.Text = "Xóa phụ tùng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.None;
            btnThanhToan.AutoSize = true;
            btnThanhToan.BackColor = SystemColors.Highlight;
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(1008, 619);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(187, 59);
            btnThanhToan.TabIndex = 26;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.AutoSize = true;
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(341, 742);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(167, 59);
            button5.TabIndex = 27;
            button5.Text = "Sửa phụ tùng";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1478, 96);
            panel4.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(482, 21);
            label1.Name = "label1";
            label1.Size = new Size(433, 50);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(1002, 99);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 12;
            label6.Text = "Thông tin nhập kho";
            // 
            // fPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 814);
            Controls.Add(panel4);
            Controls.Add(dgvNhapHang);
            Controls.Add(button5);
            Controls.Add(btnThanhToan);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtTongTien);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btn_close);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1496, 861);
            MinimumSize = new Size(1496, 861);
            Name = "fPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn nhập hàng";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhapHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_close;
        private Label a;
        public DataGridView dgvNhapHang;
        private Panel panel2;
        private DateTimePicker dtpNgayNhap;
        private Button button1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txt_author;
        private Panel panel3;
        private Label label13;
        private Label label14;
        private Label label9;
        private Label txtTongTien;
        private Button button2;
        private Button button3;
        private Button btnThanhToan;
        private Button button5;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private TextBox txbIdImport;
        private Label label6;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn vat_tu;
        private DataGridViewTextBoxColumn gia_nhap;
        private DataGridViewTextBoxColumn so_luong;
        private DataGridViewTextBoxColumn tong_tien;
    }
}