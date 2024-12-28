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
            bnHome = new System.Windows.Forms.Button();
            bnMainExit = new System.Windows.Forms.Button();
            mnStripStatistic = new System.Windows.Forms.MenuStrip();
            báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bÁOCÁODOANHSỐToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bÁOCÁOTỒNKHOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            panel1.Controls.Add(btnOption);
            panel1.Controls.Add(bnStaff);
            panel1.Controls.Add(bnInventory);
            panel1.Controls.Add(bnService);
            panel1.Controls.Add(bnHome);
            panel1.Controls.Add(bnMainExit);
            panel1.Controls.Add(mnStripStatistic);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(190, 1010);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnOption
            // 
            btnOption.BackColor = System.Drawing.Color.OldLace;
            btnOption.Location = new System.Drawing.Point(43, 699);
            btnOption.Name = "btnOption";
            btnOption.Size = new System.Drawing.Size(105, 54);
            btnOption.TabIndex = 5;
            btnOption.Text = "CÀI ĐẶT";
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // bnStaff
            // 
            bnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnStaff.BackColor = System.Drawing.Color.OldLace;
            bnStaff.Location = new System.Drawing.Point(16, 521);
            bnStaff.Margin = new System.Windows.Forms.Padding(2);
            bnStaff.Name = "bnStaff";
            bnStaff.Size = new System.Drawing.Size(127, 55);
            bnStaff.TabIndex = 3;
            bnStaff.Text = "NHÂN VIÊN";
            bnStaff.UseVisualStyleBackColor = false;
            bnStaff.Click += bnStaff_Click;
            // 
            // bnInventory
            // 
            bnInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnInventory.BackColor = System.Drawing.Color.OldLace;
            bnInventory.Location = new System.Drawing.Point(16, 407);
            bnInventory.Margin = new System.Windows.Forms.Padding(2);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new System.Drawing.Size(132, 54);
            bnInventory.TabIndex = 2;
            bnInventory.Text = "KHO HÀNG";
            bnInventory.UseVisualStyleBackColor = false;
            bnInventory.Click += bnInventory_Click;
            // 
            // bnService
            // 
            bnService.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnService.BackColor = System.Drawing.Color.OldLace;
            bnService.Location = new System.Drawing.Point(16, 279);
            bnService.Margin = new System.Windows.Forms.Padding(2);
            bnService.Name = "bnService";
            bnService.Size = new System.Drawing.Size(127, 55);
            bnService.TabIndex = 1;
            bnService.Text = "DỊCH VỤ";
            bnService.UseVisualStyleBackColor = false;
            bnService.Click += bnService_Click;
            // 
            // bnHome
            // 
            bnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnHome.BackColor = System.Drawing.Color.OldLace;
            bnHome.Location = new System.Drawing.Point(16, 187);
            bnHome.Margin = new System.Windows.Forms.Padding(2);
            bnHome.Name = "bnHome";
            bnHome.Size = new System.Drawing.Size(132, 47);
            bnHome.TabIndex = 0;
            bnHome.Text = "TRANG CHỦ";
            bnHome.UseVisualStyleBackColor = false;
            bnHome.Click += bnHome_Click;
            // 
            // bnMainExit
            // 
            bnMainExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            bnMainExit.Location = new System.Drawing.Point(29, 794);
            bnMainExit.Margin = new System.Windows.Forms.Padding(2);
            bnMainExit.Name = "bnMainExit";
            bnMainExit.Size = new System.Drawing.Size(103, 51);
            bnMainExit.TabIndex = 6;
            bnMainExit.Text = "THOÁT";
            bnMainExit.UseVisualStyleBackColor = false;
            bnMainExit.Click += bnMainExit_Click;
            // 
            // mnStripStatistic
            // 
            mnStripStatistic.BackColor = System.Drawing.Color.OldLace;
            mnStripStatistic.Dock = System.Windows.Forms.DockStyle.None;
            mnStripStatistic.ImageScalingSize = new System.Drawing.Size(20, 20);
            mnStripStatistic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { báoCáoToolStripMenuItem });
            mnStripStatistic.Location = new System.Drawing.Point(16, 623);
            mnStripStatistic.Name = "mnStripStatistic";
            mnStripStatistic.Size = new System.Drawing.Size(121, 33);
            mnStripStatistic.TabIndex = 4;
            mnStripStatistic.Text = "Báo cáo";
            mnStripStatistic.ItemClicked += mnStripStatistic_ItemClicked_1;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bÁOCÁODOANHSỐToolStripMenuItem, bÁOCÁOTỒNKHOToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            báoCáoToolStripMenuItem.Text = "THỐNG KÊ";
            // 
            // bÁOCÁODOANHSỐToolStripMenuItem
            // 
            bÁOCÁODOANHSỐToolStripMenuItem.Name = "bÁOCÁODOANHSỐToolStripMenuItem";
            bÁOCÁODOANHSỐToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            bÁOCÁODOANHSỐToolStripMenuItem.Text = "BÁO CÁO DOANH SỐ";
            bÁOCÁODOANHSỐToolStripMenuItem.Click += bÁOCÁODOANHSỐToolStripMenuItem_Click;
            // 
            // bÁOCÁOTỒNKHOToolStripMenuItem
            // 
            bÁOCÁOTỒNKHOToolStripMenuItem.Name = "bÁOCÁOTỒNKHOToolStripMenuItem";
            bÁOCÁOTỒNKHOToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            bÁOCÁOTỒNKHOToolStripMenuItem.Text = "BÁO CÁO TỒN KHO";
            bÁOCÁOTỒNKHOToolStripMenuItem.Click += bÁOCÁOTỒNKHOToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(1247, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(182, 31);
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
            panel2.Location = new System.Drawing.Point(190, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1490, 112);
            panel2.TabIndex = 1;
            // 
            // byHieuXeRadioBtn
            // 
            byHieuXeRadioBtn.Location = new System.Drawing.Point(1014, 66);
            byHieuXeRadioBtn.Name = "byHieuXeRadioBtn";
            byHieuXeRadioBtn.Size = new System.Drawing.Size(282, 30);
            byHieuXeRadioBtn.TabIndex = 6;
            byHieuXeRadioBtn.TabStop = true;
            byHieuXeRadioBtn.Text = "Tìm kiếm theo hiệu xe";
            byHieuXeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // byNameRadioBtn
            // 
            byNameRadioBtn.Location = new System.Drawing.Point(745, 66);
            byNameRadioBtn.Name = "byNameRadioBtn";
            byNameRadioBtn.Size = new System.Drawing.Size(247, 30);
            byNameRadioBtn.TabIndex = 5;
            byNameRadioBtn.TabStop = true;
            byNameRadioBtn.Text = "Tìm kiếm theo tên chủ xe";
            byNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // byBienXeRadioBtn
            // 
            byBienXeRadioBtn.Location = new System.Drawing.Point(474, 66);
            byBienXeRadioBtn.Name = "byBienXeRadioBtn";
            byBienXeRadioBtn.Size = new System.Drawing.Size(219, 30);
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
            label2.Location = new System.Drawing.Point(432, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(129, 41);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm";
            // 
            // searchBar
            // 
            searchBar.Font = new System.Drawing.Font("Segoe UI", 11F);
            searchBar.Location = new System.Drawing.Point(567, 12);
            searchBar.Name = "searchBar";
            searchBar.Size = new System.Drawing.Size(598, 37);
            searchBar.TabIndex = 2;
            searchBar.TextChanged += textBox2_TextChanged;
            // 
            // currentUser
            // 
            currentUser.BackColor = System.Drawing.SystemColors.Window;
            currentUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            currentUser.Location = new System.Drawing.Point(52, 47);
            currentUser.Name = "currentUser";
            currentUser.ReadOnly = true;
            currentUser.Size = new System.Drawing.Size(217, 37);
            currentUser.TabIndex = 1;
            currentUser.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(39, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(287, 35);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên đang sử dụng";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { BienSo, TenChuXe, HieuXe, DiaChi, DienThoai, Email, TienNo });
            dataGridView1.Location = new System.Drawing.Point(6, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1461, 728);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BienSo
            // 
            BienSo.MinimumWidth = 8;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            BienSo.Width = 200;
            // 
            // TenChuXe
            // 
            TenChuXe.MinimumWidth = 8;
            TenChuXe.Name = "TenChuXe";
            TenChuXe.ReadOnly = true;
            TenChuXe.Width = 200;
            // 
            // HieuXe
            // 
            HieuXe.MinimumWidth = 8;
            HieuXe.Name = "HieuXe";
            HieuXe.ReadOnly = true;
            HieuXe.Width = 200;
            // 
            // DiaChi
            // 
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 200;
            // 
            // DienThoai
            // 
            DienThoai.MinimumWidth = 8;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            DienThoai.Width = 200;
            // 
            // Email
            // 
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 200;
            // 
            // TienNo
            // 
            TienNo.MinimumWidth = 8;
            TienNo.Name = "TienNo";
            TienNo.ReadOnly = true;
            TienNo.Width = 197;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new System.Drawing.Point(195, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1473, 764);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách xe tiếp nhận trong ngày";
            // 
            // editCarBtn
            // 
            editCarBtn.Location = new System.Drawing.Point(1437, 899);
            editCarBtn.Name = "editCarBtn";
            editCarBtn.Size = new System.Drawing.Size(202, 83);
            editCarBtn.TabIndex = 3;
            editCarBtn.Text = "Cập nhập thông tin xe";
            editCarBtn.UseVisualStyleBackColor = true;
            editCarBtn.Click += editCarBtn_Click;
            // 
            // MainScence
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1680, 1010);
            Controls.Add(editCarBtn);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(1225, 688);
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
        }

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
        private System.Windows.Forms.Button bnHome;
        private System.Windows.Forms.Button bnStaff;
        private System.Windows.Forms.Button bnInventory;
        private System.Windows.Forms.Button bnMainExit;
        private System.Windows.Forms.MenuStrip mnStripStatistic;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem bÁOCÁODOANHSỐToolStripMenuItem;
        private ToolStripMenuItem bÁOCÁOTỒNKHOToolStripMenuItem;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
    }
}