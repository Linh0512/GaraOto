namespace WinFormsApp.Screens.MainScene
{
    partial class MainScence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScence));
            panel1 = new Panel();
            btnQuyDinh = new Button();
            bnStaff = new Button();
            bnInventory = new Button();
            bnService = new Button();
            bnMainExit = new Button();
            mnStripStatistic = new MenuStrip();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            bÁOCÁODOANHSỐToolStripMenuItem = new ToolStripMenuItem();
            bÁOCÁOTỒNKHOToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem = new ToolStripMenuItem();
            cÀIĐẶTToolStripMenuItem = new ToolStripMenuItem();
            tÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHHÃNGXEToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            byHieuXeRadioBtn = new RadioButton();
            byNameRadioBtn = new RadioButton();
            byBienXeRadioBtn = new RadioButton();
            label2 = new Label();
            searchBar = new TextBox();
            currentUser = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BienSo = new DataGridViewTextBoxColumn();
            TenChuXe = new DataGridViewTextBoxColumn();
            HieuXe = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TienNo = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            editCarBtn = new Button();
            label3 = new Label();
            soXeDaTN = new TextBox();
            panel1.SuspendLayout();
            mnStripStatistic.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(btnQuyDinh);
            panel1.Controls.Add(bnStaff);
            panel1.Controls.Add(bnInventory);
            panel1.Controls.Add(bnService);
            panel1.Controls.Add(bnMainExit);
            panel1.Controls.Add(mnStripStatistic);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 646);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnQuyDinh
            // 
            btnQuyDinh.Anchor = AnchorStyles.None;
            btnQuyDinh.BackColor = Color.Linen;
            btnQuyDinh.Cursor = Cursors.Hand;
            btnQuyDinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuyDinh.Location = new Point(1, 447);
            btnQuyDinh.Margin = new Padding(2);
            btnQuyDinh.Name = "btnQuyDinh";
            btnQuyDinh.Size = new Size(182, 62);
            btnQuyDinh.TabIndex = 7;
            btnQuyDinh.Text = "QUY ĐỊNH";
            btnQuyDinh.UseVisualStyleBackColor = false;
            btnQuyDinh.Click += btnQuyDinh_Click;
            // 
            // bnStaff
            // 
            bnStaff.Anchor = AnchorStyles.None;
            bnStaff.BackColor = Color.Linen;
            bnStaff.Cursor = Cursors.Hand;
            bnStaff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnStaff.Location = new Point(0, 334);
            bnStaff.Margin = new Padding(2);
            bnStaff.Name = "bnStaff";
            bnStaff.Size = new Size(182, 62);
            bnStaff.TabIndex = 3;
            bnStaff.Text = "NHÂN VIÊN";
            bnStaff.UseVisualStyleBackColor = false;
            bnStaff.Click += bnStaff_Click;
            // 
            // bnInventory
            // 
            bnInventory.Anchor = AnchorStyles.None;
            bnInventory.BackColor = Color.Linen;
            bnInventory.Cursor = Cursors.Hand;
            bnInventory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnInventory.Location = new Point(1, 209);
            bnInventory.Margin = new Padding(2);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new Size(182, 66);
            bnInventory.TabIndex = 2;
            bnInventory.Text = "KHO HÀNG";
            bnInventory.UseVisualStyleBackColor = false;
            bnInventory.Click += bnInventory_Click;
            // 
            // bnService
            // 
            bnService.Anchor = AnchorStyles.None;
            bnService.BackColor = Color.Linen;
            bnService.Cursor = Cursors.Hand;
            bnService.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnService.Location = new Point(0, 91);
            bnService.Margin = new Padding(2);
            bnService.Name = "bnService";
            bnService.Size = new Size(183, 65);
            bnService.TabIndex = 1;
            bnService.Text = "DỊCH VỤ";
            bnService.UseVisualStyleBackColor = false;
            bnService.Click += bnService_Click;
            // 
            // bnMainExit
            // 
            bnMainExit.BackColor = Color.DeepSkyBlue;
            bnMainExit.Cursor = Cursors.Hand;
            bnMainExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnMainExit.Location = new Point(0, 591);
            bnMainExit.Margin = new Padding(2);
            bnMainExit.Name = "bnMainExit";
            bnMainExit.Size = new Size(185, 47);
            bnMainExit.TabIndex = 6;
            bnMainExit.Text = "THOÁT";
            bnMainExit.UseVisualStyleBackColor = false;
            bnMainExit.Click += bnMainExit_Click;
            // 
            // mnStripStatistic
            // 
            mnStripStatistic.BackColor = Color.MintCream;
            mnStripStatistic.Dock = DockStyle.None;
            mnStripStatistic.ImageScalingSize = new Size(20, 20);
            mnStripStatistic.Items.AddRange(new ToolStripItem[] { báoCáoToolStripMenuItem, cÀIĐẶTToolStripMenuItem });
            mnStripStatistic.Location = new Point(0, 0);
            mnStripStatistic.Name = "mnStripStatistic";
            mnStripStatistic.Padding = new Padding(4, 2, 0, 2);
            mnStripStatistic.Size = new Size(180, 28);
            mnStripStatistic.TabIndex = 4;
            mnStripStatistic.Text = "Báo cáo";
            mnStripStatistic.ItemClicked += mnStripStatistic_ItemClicked_1;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bÁOCÁODOANHSỐToolStripMenuItem, bÁOCÁOTỒNKHOToolStripMenuItem, dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem, dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem, dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(95, 24);
            báoCáoToolStripMenuItem.Text = "THỐNG KÊ";
            báoCáoToolStripMenuItem.Click += báoCáoToolStripMenuItem_Click;
            // 
            // bÁOCÁODOANHSỐToolStripMenuItem
            // 
            bÁOCÁODOANHSỐToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            bÁOCÁODOANHSỐToolStripMenuItem.Image = (Image)resources.GetObject("bÁOCÁODOANHSỐToolStripMenuItem.Image");
            bÁOCÁODOANHSỐToolStripMenuItem.Name = "bÁOCÁODOANHSỐToolStripMenuItem";
            bÁOCÁODOANHSỐToolStripMenuItem.Size = new Size(303, 26);
            bÁOCÁODOANHSỐToolStripMenuItem.Text = "BÁO CÁO DOANH SỐ";
            bÁOCÁODOANHSỐToolStripMenuItem.Click += bÁOCÁODOANHSỐToolStripMenuItem_Click;
            // 
            // bÁOCÁOTỒNKHOToolStripMenuItem
            // 
            bÁOCÁOTỒNKHOToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            bÁOCÁOTỒNKHOToolStripMenuItem.Image = (Image)resources.GetObject("bÁOCÁOTỒNKHOToolStripMenuItem.Image");
            bÁOCÁOTỒNKHOToolStripMenuItem.Name = "bÁOCÁOTỒNKHOToolStripMenuItem";
            bÁOCÁOTỒNKHOToolStripMenuItem.Size = new Size(303, 26);
            bÁOCÁOTỒNKHOToolStripMenuItem.Text = "BÁO CÁO TỒN KHO";
            bÁOCÁOTỒNKHOToolStripMenuItem.Click += bÁOCÁOTỒNKHOToolStripMenuItem_Click;
            // 
            // dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem
            // 
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Image = (Image)resources.GetObject("dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Image");
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Name = "dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem";
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Size = new Size(303, 26);
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Text = "DANH SÁCH PHIẾU SỬA CHỮA";
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Click += dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem_Click;
            // 
            // dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem
            // 
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Image = (Image)resources.GetObject("dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Image");
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Name = "dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem";
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Size = new Size(303, 26);
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Text = "DANH SÁCH PHIẾU THU TIỀN";
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Click += dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem_Click;
            // 
            // dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem
            // 
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.BackColor = SystemColors.ButtonShadow;
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Image = (Image)resources.GetObject("dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Image");
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Name = "dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem";
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Size = new Size(303, 26);
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Text = "DANH SÁCH PHIẾU NHẬP VTPT";
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Click += dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem_Click;
            // 
            // cÀIĐẶTToolStripMenuItem
            // 
            cÀIĐẶTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tÀIKHOẢNToolStripMenuItem, dANHSÁCHHÃNGXEToolStripMenuItem, dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem });
            cÀIĐẶTToolStripMenuItem.Name = "cÀIĐẶTToolStripMenuItem";
            cÀIĐẶTToolStripMenuItem.Size = new Size(79, 24);
            cÀIĐẶTToolStripMenuItem.Text = "CÀI ĐẶT";
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            tÀIKHOẢNToolStripMenuItem.BackColor = Color.CadetBlue;
            tÀIKHOẢNToolStripMenuItem.Image = Properties.Resources.user_icon;
            tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            tÀIKHOẢNToolStripMenuItem.Size = new Size(292, 26);
            tÀIKHOẢNToolStripMenuItem.Text = "THÔNG TIN TÀI KHOẢN";
            tÀIKHOẢNToolStripMenuItem.Click += tÀIKHOẢNToolStripMenuItem_Click;
            // 
            // dANHSÁCHHÃNGXEToolStripMenuItem
            // 
            dANHSÁCHHÃNGXEToolStripMenuItem.BackColor = Color.CadetBlue;
            dANHSÁCHHÃNGXEToolStripMenuItem.Image = (Image)resources.GetObject("dANHSÁCHHÃNGXEToolStripMenuItem.Image");
            dANHSÁCHHÃNGXEToolStripMenuItem.Name = "dANHSÁCHHÃNGXEToolStripMenuItem";
            dANHSÁCHHÃNGXEToolStripMenuItem.Size = new Size(292, 26);
            dANHSÁCHHÃNGXEToolStripMenuItem.Text = "DANH SÁCH HIỆU XE";
            dANHSÁCHHÃNGXEToolStripMenuItem.Click += dANHSÁCHHÃNGXEToolStripMenuItem_Click;
            // 
            // dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem
            // 
            dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem.BackColor = Color.CadetBlue;
            dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem.Image = (Image)resources.GetObject("dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem.Image");
            dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem.Name = "dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem";
            dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem.Size = new Size(292, 26);
            dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem.Text = "DANH SÁCH LOẠI TIỀN CÔNG";
            dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem.Click += dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(798, 11);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(118, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(byHieuXeRadioBtn);
            panel2.Controls.Add(byNameRadioBtn);
            panel2.Controls.Add(byBienXeRadioBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(searchBar);
            panel2.Controls.Add(currentUser);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(183, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 72);
            panel2.TabIndex = 1;
            // 
            // byHieuXeRadioBtn
            // 
            byHieuXeRadioBtn.Cursor = Cursors.Hand;
            byHieuXeRadioBtn.Location = new Point(649, 42);
            byHieuXeRadioBtn.Margin = new Padding(2);
            byHieuXeRadioBtn.Name = "byHieuXeRadioBtn";
            byHieuXeRadioBtn.Size = new Size(181, 28);
            byHieuXeRadioBtn.TabIndex = 6;
            byHieuXeRadioBtn.TabStop = true;
            byHieuXeRadioBtn.Text = "Tìm kiếm theo hiệu xe";
            byHieuXeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // byNameRadioBtn
            // 
            byNameRadioBtn.Cursor = Cursors.Hand;
            byNameRadioBtn.Location = new Point(477, 42);
            byNameRadioBtn.Margin = new Padding(2);
            byNameRadioBtn.Name = "byNameRadioBtn";
            byNameRadioBtn.Size = new Size(158, 30);
            byNameRadioBtn.TabIndex = 5;
            byNameRadioBtn.TabStop = true;
            byNameRadioBtn.Text = "Tìm kiếm theo tên chủ xe";
            byNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // byBienXeRadioBtn
            // 
            byBienXeRadioBtn.Cursor = Cursors.Hand;
            byBienXeRadioBtn.Location = new Point(303, 42);
            byBienXeRadioBtn.Margin = new Padding(2);
            byBienXeRadioBtn.Name = "byBienXeRadioBtn";
            byBienXeRadioBtn.Size = new Size(140, 28);
            byBienXeRadioBtn.TabIndex = 4;
            byBienXeRadioBtn.TabStop = true;
            byBienXeRadioBtn.Text = "Tìm kiếm theo biển số xe";
            byBienXeRadioBtn.UseVisualStyleBackColor = true;
            byBienXeRadioBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(256, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm";
            // 
            // searchBar
            // 
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Font = new Font("Segoe UI", 11F);
            searchBar.Location = new Point(363, 8);
            searchBar.Margin = new Padding(2);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(384, 32);
            searchBar.TabIndex = 2;
            searchBar.TextChanged += textBox2_TextChanged;
            // 
            // currentUser
            // 
            currentUser.BackColor = SystemColors.Window;
            currentUser.Enabled = false;
            currentUser.Font = new Font("Segoe UI", 11F);
            currentUser.Location = new Point(34, 30);
            currentUser.Margin = new Padding(2);
            currentUser.Name = "currentUser";
            currentUser.ReadOnly = true;
            currentUser.Size = new Size(140, 32);
            currentUser.TabIndex = 1;
            currentUser.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(25, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên đang sử dụng";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BienSo, TenChuXe, HieuXe, DiaChi, DienThoai, Email, TienNo });
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MaximumSize = new Size(1008, 438);
            dataGridView1.MinimumSize = new Size(1008, 438);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1008, 438);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BienSo
            // 
            BienSo.MinimumWidth = 8;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            // 
            // TenChuXe
            // 
            TenChuXe.MinimumWidth = 8;
            TenChuXe.Name = "TenChuXe";
            TenChuXe.ReadOnly = true;
            // 
            // HieuXe
            // 
            HieuXe.MinimumWidth = 8;
            HieuXe.Name = "HieuXe";
            HieuXe.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.MinimumWidth = 8;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // TienNo
            // 
            TienNo.MinimumWidth = 8;
            TienNo.Name = "TienNo";
            TienNo.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(191, 106);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1016, 466);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách xe tiếp nhận trong ngày";
            // 
            // editCarBtn
            // 
            editCarBtn.BackColor = Color.CadetBlue;
            editCarBtn.Cursor = Cursors.Hand;
            editCarBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCarBtn.Location = new Point(550, 576);
            editCarBtn.Margin = new Padding(2);
            editCarBtn.Name = "editCarBtn";
            editCarBtn.Size = new Size(276, 62);
            editCarBtn.TabIndex = 3;
            editCarBtn.Text = "Cập nhập thông tin xe";
            editCarBtn.UseVisualStyleBackColor = false;
            editCarBtn.Click += editCarBtn_Click;
            // 
            // label3
            // 
            label3.Location = new Point(194, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(222, 18);
            label3.TabIndex = 4;
            label3.Text = "Số xe đã tiếp nhận trong ngày";
            // 
            // soXeDaTN
            // 
            soXeDaTN.BackColor = SystemColors.Window;
            soXeDaTN.Enabled = false;
            soXeDaTN.Location = new Point(420, 75);
            soXeDaTN.Margin = new Padding(2);
            soXeDaTN.Name = "soXeDaTN";
            soXeDaTN.ReadOnly = true;
            soXeDaTN.Size = new Size(126, 27);
            soXeDaTN.TabIndex = 5;
            // 
            // MainScence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 646);
            Controls.Add(soXeDaTN);
            Controls.Add(label3);
            Controls.Add(editCarBtn);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1225, 693);
            MinimumSize = new Size(1225, 693);
            Name = "MainScence";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PHẦN MỀM QUẢN LÝ GARAOTO";
            Load += MainScence_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mnStripStatistic.ResumeLayout(false);
            mnStripStatistic.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnQuyDinh;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soXeDaTN;

        private System.Windows.Forms.Button editCarBtn;

        private System.Windows.Forms.RadioButton byNameRadioBtn;
        private System.Windows.Forms.RadioButton byHieuXeRadioBtn;

        private System.Windows.Forms.RadioButton byBienXeRadioBtn;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox searchBar;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox currentUser;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Email;

        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;

        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;

        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnService;
        private System.Windows.Forms.Button bnStaff;
        private System.Windows.Forms.Button bnInventory;
        private System.Windows.Forms.Button bnMainExit;
        private System.Windows.Forms.MenuStrip mnStripStatistic;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem bÁOCÁODOANHSỐToolStripMenuItem;
        private ToolStripMenuItem bÁOCÁOTỒNKHOToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private ToolStripMenuItem dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem;
        private ToolStripMenuItem cÀIĐẶTToolStripMenuItem;
        private ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHHÃNGXEToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem;
    }
}