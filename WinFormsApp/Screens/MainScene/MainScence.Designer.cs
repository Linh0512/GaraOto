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
            panel1 = new System.Windows.Forms.Panel();
            btnOption = new System.Windows.Forms.Button();
            bnStaff = new System.Windows.Forms.Button();
            bnInventory = new System.Windows.Forms.Button();
            bnService = new System.Windows.Forms.Button();
            bnMainExit = new System.Windows.Forms.Button();
            mnStripStatistic = new System.Windows.Forms.MenuStrip();
            báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bÁOCÁODOANHSỐToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bÁOCÁOTỒNKHOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            panel2 = new System.Windows.Forms.Panel();
            byHieuXeRadioBtn = new System.Windows.Forms.RadioButton();
            byNameRadioBtn = new System.Windows.Forms.RadioButton();
            byBienXeRadioBtn = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            searchBar = new System.Windows.Forms.TextBox();
            currentUser = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TenChuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            editCarBtn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            soXeDaTN = new System.Windows.Forms.TextBox();
            btnQuyDinh = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            mnStripStatistic.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SlateGray;
            panel1.Controls.Add(btnQuyDinh);
            panel1.Controls.Add(btnOption);
            panel1.Controls.Add(bnStaff);
            panel1.Controls.Add(bnInventory);
            panel1.Controls.Add(bnService);
            panel1.Controls.Add(bnMainExit);
            panel1.Controls.Add(mnStripStatistic);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(207, 808);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnOption
            // 
            btnOption.BackColor = System.Drawing.Color.MintCream;
            btnOption.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnOption.Location = new System.Drawing.Point(122, 2);
            btnOption.Margin = new System.Windows.Forms.Padding(2);
            btnOption.Name = "btnOption";
            btnOption.Size = new System.Drawing.Size(87, 28);
            btnOption.TabIndex = 5;
            btnOption.Text = "CÀI ĐẶT";
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // bnStaff
            // 
            bnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnStaff.BackColor = System.Drawing.Color.Linen;
            bnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            bnStaff.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            bnStaff.Location = new System.Drawing.Point(-2, 421);
            bnStaff.Margin = new System.Windows.Forms.Padding(2);
            bnStaff.Name = "bnStaff";
            bnStaff.Size = new System.Drawing.Size(209, 77);
            bnStaff.TabIndex = 3;
            bnStaff.Text = "NHÂN VIÊN";
            bnStaff.UseVisualStyleBackColor = false;
            bnStaff.Click += bnStaff_Click;
            // 
            // bnInventory
            // 
            bnInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnInventory.BackColor = System.Drawing.Color.Linen;
            bnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            bnInventory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            bnInventory.Location = new System.Drawing.Point(-2, 261);
            bnInventory.Margin = new System.Windows.Forms.Padding(2);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new System.Drawing.Size(209, 83);
            bnInventory.TabIndex = 2;
            bnInventory.Text = "KHO HÀNG";
            bnInventory.UseVisualStyleBackColor = false;
            bnInventory.Click += bnInventory_Click;
            // 
            // bnService
            // 
            bnService.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnService.BackColor = System.Drawing.Color.Linen;
            bnService.Cursor = System.Windows.Forms.Cursors.Hand;
            bnService.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            bnService.Location = new System.Drawing.Point(-2, 108);
            bnService.Margin = new System.Windows.Forms.Padding(2);
            bnService.Name = "bnService";
            bnService.Size = new System.Drawing.Size(209, 81);
            bnService.TabIndex = 1;
            bnService.Text = "DỊCH VỤ";
            bnService.UseVisualStyleBackColor = false;
            bnService.Click += bnService_Click;
            // 
            // bnMainExit
            // 
            bnMainExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            bnMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            bnMainExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            bnMainExit.Location = new System.Drawing.Point(0, 738);
            bnMainExit.Margin = new System.Windows.Forms.Padding(2);
            bnMainExit.Name = "bnMainExit";
            bnMainExit.Size = new System.Drawing.Size(209, 59);
            bnMainExit.TabIndex = 6;
            bnMainExit.Text = "THOÁT";
            bnMainExit.UseVisualStyleBackColor = false;
            bnMainExit.Click += bnMainExit_Click;
            // 
            // mnStripStatistic
            // 
            mnStripStatistic.BackColor = System.Drawing.Color.MintCream;
            mnStripStatistic.Dock = System.Windows.Forms.DockStyle.None;
            mnStripStatistic.ImageScalingSize = new System.Drawing.Size(20, 20);
            mnStripStatistic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { báoCáoToolStripMenuItem });
            mnStripStatistic.Location = new System.Drawing.Point(0, 0);
            mnStripStatistic.Name = "mnStripStatistic";
            mnStripStatistic.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            mnStripStatistic.Size = new System.Drawing.Size(120, 33);
            mnStripStatistic.TabIndex = 4;
            mnStripStatistic.Text = "Báo cáo";
            mnStripStatistic.ItemClicked += mnStripStatistic_ItemClicked_1;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bÁOCÁODOANHSỐToolStripMenuItem, bÁOCÁOTỒNKHOToolStripMenuItem, dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem, dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem, dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            báoCáoToolStripMenuItem.Text = "THỐNG KÊ";
            báoCáoToolStripMenuItem.Click += báoCáoToolStripMenuItem_Click;
            // 
            // bÁOCÁODOANHSỐToolStripMenuItem
            // 
            bÁOCÁODOANHSỐToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            bÁOCÁODOANHSỐToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("bÁOCÁODOANHSỐToolStripMenuItem.Image"));
            bÁOCÁODOANHSỐToolStripMenuItem.Name = "bÁOCÁODOANHSỐToolStripMenuItem";
            bÁOCÁODOANHSỐToolStripMenuItem.Size = new System.Drawing.Size(367, 34);
            bÁOCÁODOANHSỐToolStripMenuItem.Text = "BÁO CÁO DOANH SỐ";
            bÁOCÁODOANHSỐToolStripMenuItem.Click += bÁOCÁODOANHSỐToolStripMenuItem_Click;
            // 
            // bÁOCÁOTỒNKHOToolStripMenuItem
            // 
            bÁOCÁOTỒNKHOToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            bÁOCÁOTỒNKHOToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("bÁOCÁOTỒNKHOToolStripMenuItem.Image"));
            bÁOCÁOTỒNKHOToolStripMenuItem.Name = "bÁOCÁOTỒNKHOToolStripMenuItem";
            bÁOCÁOTỒNKHOToolStripMenuItem.Size = new System.Drawing.Size(367, 34);
            bÁOCÁOTỒNKHOToolStripMenuItem.Text = "BÁO CÁO TỒN KHO";
            bÁOCÁOTỒNKHOToolStripMenuItem.Click += bÁOCÁOTỒNKHOToolStripMenuItem_Click;
            // 
            // dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem
            // 
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Image"));
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Name = "dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem";
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Size = new System.Drawing.Size(367, 34);
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Text = "DANH SÁCH PHIẾU SỬA CHỮA";
            dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem.Click += dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem_Click;
            // 
            // dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem
            // 
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Image"));
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Name = "dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem";
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Size = new System.Drawing.Size(367, 34);
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Text = "DANH SÁCH PHIẾU THU TIỀN";
            dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem.Click += dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem_Click;
            // 
            // dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem
            // 
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Image"));
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Name = "dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem";
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Size = new System.Drawing.Size(367, 34);
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Text = "DANH SÁCH PHIẾU NHẬP VTPT";
            dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem.Click += dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(998, 14);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(146, 31);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.CadetBlue;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(byHieuXeRadioBtn);
            panel2.Controls.Add(byNameRadioBtn);
            panel2.Controls.Add(byBienXeRadioBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(searchBar);
            panel2.Controls.Add(currentUser);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(207, 0);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1157, 90);
            panel2.TabIndex = 1;
            // 
            // byHieuXeRadioBtn
            // 
            byHieuXeRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            byHieuXeRadioBtn.Location = new System.Drawing.Point(811, 53);
            byHieuXeRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            byHieuXeRadioBtn.Name = "byHieuXeRadioBtn";
            byHieuXeRadioBtn.Size = new System.Drawing.Size(226, 24);
            byHieuXeRadioBtn.TabIndex = 6;
            byHieuXeRadioBtn.TabStop = true;
            byHieuXeRadioBtn.Text = "Tìm kiếm theo hiệu xe";
            byHieuXeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // byNameRadioBtn
            // 
            byNameRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            byNameRadioBtn.Location = new System.Drawing.Point(596, 53);
            byNameRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            byNameRadioBtn.Name = "byNameRadioBtn";
            byNameRadioBtn.Size = new System.Drawing.Size(198, 24);
            byNameRadioBtn.TabIndex = 5;
            byNameRadioBtn.TabStop = true;
            byNameRadioBtn.Text = "Tìm kiếm theo tên chủ xe";
            byNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // byBienXeRadioBtn
            // 
            byBienXeRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            byBienXeRadioBtn.Location = new System.Drawing.Point(379, 53);
            byBienXeRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            byBienXeRadioBtn.Name = "byBienXeRadioBtn";
            byBienXeRadioBtn.Size = new System.Drawing.Size(175, 24);
            byBienXeRadioBtn.TabIndex = 4;
            byBienXeRadioBtn.TabStop = true;
            byBienXeRadioBtn.Text = "Tìm kiếm theo biển số xe";
            byBienXeRadioBtn.UseVisualStyleBackColor = true;
            byBienXeRadioBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.SystemColors.Window;
            label2.Location = new System.Drawing.Point(346, 10);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 33);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm";
            // 
            // searchBar
            // 
            searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            searchBar.Font = new System.Drawing.Font("Segoe UI", 11F);
            searchBar.Location = new System.Drawing.Point(454, 10);
            searchBar.Margin = new System.Windows.Forms.Padding(2);
            searchBar.Name = "searchBar";
            searchBar.Size = new System.Drawing.Size(479, 37);
            searchBar.TabIndex = 2;
            searchBar.TextChanged += textBox2_TextChanged;
            // 
            // currentUser
            // 
            currentUser.BackColor = System.Drawing.SystemColors.Window;
            currentUser.Enabled = false;
            currentUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            currentUser.Location = new System.Drawing.Point(42, 38);
            currentUser.Margin = new System.Windows.Forms.Padding(2);
            currentUser.Name = "currentUser";
            currentUser.ReadOnly = true;
            currentUser.Size = new System.Drawing.Size(174, 37);
            currentUser.TabIndex = 1;
            currentUser.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(31, 7);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên đang sử dụng";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { BienSo, TenChuXe, HieuXe, DiaChi, DienThoai, Email, TienNo });
            dataGridView1.Location = new System.Drawing.Point(4, 28);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1153, 547);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BienSo
            // 
            BienSo.MinimumWidth = 8;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            BienSo.Width = 156;
            // 
            // TenChuXe
            // 
            TenChuXe.MinimumWidth = 8;
            TenChuXe.Name = "TenChuXe";
            TenChuXe.ReadOnly = true;
            TenChuXe.Width = 155;
            // 
            // HieuXe
            // 
            HieuXe.MinimumWidth = 8;
            HieuXe.Name = "HieuXe";
            HieuXe.ReadOnly = true;
            HieuXe.Width = 156;
            // 
            // DiaChi
            // 
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 155;
            // 
            // DienThoai
            // 
            DienThoai.MinimumWidth = 8;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            DienThoai.Width = 156;
            // 
            // Email
            // 
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 155;
            // 
            // TienNo
            // 
            TienNo.MinimumWidth = 8;
            TienNo.Name = "TienNo";
            TienNo.ReadOnly = true;
            TienNo.Width = 156;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new System.Drawing.Point(207, 133);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(1157, 583);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách xe tiếp nhận trong ngày";
            // 
            // editCarBtn
            // 
            editCarBtn.BackColor = System.Drawing.Color.CadetBlue;
            editCarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            editCarBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            editCarBtn.Location = new System.Drawing.Point(661, 720);
            editCarBtn.Margin = new System.Windows.Forms.Padding(2);
            editCarBtn.Name = "editCarBtn";
            editCarBtn.Size = new System.Drawing.Size(273, 77);
            editCarBtn.TabIndex = 3;
            editCarBtn.Text = "Cập nhập thông tin xe";
            editCarBtn.UseVisualStyleBackColor = false;
            editCarBtn.Click += editCarBtn_Click;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(212, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(278, 23);
            label3.TabIndex = 4;
            label3.Text = "Số xe đã tiếp nhận trong ngày";
            // 
            // soXeDaTN
            // 
            soXeDaTN.BackColor = System.Drawing.SystemColors.Window;
            soXeDaTN.Location = new System.Drawing.Point(464, 105);
            soXeDaTN.Name = "soXeDaTN";
            soXeDaTN.ReadOnly = true;
            soXeDaTN.Size = new System.Drawing.Size(100, 31);
            soXeDaTN.TabIndex = 5;
            // 
            // btnQuyDinh
            // 
            btnQuyDinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnQuyDinh.BackColor = System.Drawing.Color.Linen;
            btnQuyDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuyDinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnQuyDinh.Location = new System.Drawing.Point(-2, 564);
            btnQuyDinh.Margin = new System.Windows.Forms.Padding(2);
            btnQuyDinh.Name = "btnQuyDinh";
            btnQuyDinh.Size = new System.Drawing.Size(209, 77);
            btnQuyDinh.TabIndex = 7;
            btnQuyDinh.Text = "QUY ĐỊNH";
            btnQuyDinh.UseVisualStyleBackColor = false;
            btnQuyDinh.Click += btnQuyDinh_Click;
            // 
            // MainScence
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1364, 808);
            Controls.Add(soXeDaTN);
            Controls.Add(label3);
            Controls.Add(editCarBtn);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(984, 560);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private ToolStripMenuItem dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem;
    }
}