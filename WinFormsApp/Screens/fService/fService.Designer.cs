namespace WinFormsApp.Screens.Service
{
    partial class fService
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fService));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dtpDateService = new DateTimePicker();
            cbbPhoneNumber = new ComboBox();
            cbbCustomerName = new ComboBox();
            cbbCarBrand = new ComboBox();
            hieuXeBindingSource = new BindingSource(components);
            cbbLicensePlate = new ComboBox();
            xeBindingSource = new BindingSource(components);
            panel3 = new Panel();
            btnPayment = new Button();
            menuStrip1 = new MenuStrip();
            StripMenuManager = new ToolStripMenuItem();
            ListRepair = new ToolStripMenuItem();
            ListPayment = new ToolStripMenuItem();
            bnAddCar = new Button();
            btnAddService = new Button();
            bnXoa = new Button();
            bnRefresh = new Button();
            bnFind = new Button();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            dtgvService = new DataGridView();
            btnChangeInfor = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hieuXeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xeBindingSource).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvService).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1851, 126);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(448, 128);
            label1.TabIndex = 1;
            label1.Text = "DỊCH VỤ";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpDateService);
            panel2.Controls.Add(cbbPhoneNumber);
            panel2.Controls.Add(cbbCustomerName);
            panel2.Controls.Add(cbbCarBrand);
            panel2.Controls.Add(cbbLicensePlate);
            panel2.Location = new Point(10, 146);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 58);
            panel2.TabIndex = 2;
            // 
            // dtpDateService
            // 
            dtpDateService.Format = DateTimePickerFormat.Short;
            dtpDateService.Location = new Point(798, 0);
            dtpDateService.Margin = new Padding(3, 2, 3, 2);
            dtpDateService.Name = "dtpDateService";
            dtpDateService.Size = new Size(246, 39);
            dtpDateService.TabIndex = 4;
            dtpDateService.Value = new DateTime(2024, 12, 19, 0, 0, 0, 0);
            // 
            // cbbPhoneNumber
            // 
            cbbPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPhoneNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbPhoneNumber.DropDownStyle = ComboBoxStyle.Simple;
            cbbPhoneNumber.FormattingEnabled = true;
            cbbPhoneNumber.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbPhoneNumber.Location = new Point(588, 0);
            cbbPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            cbbPhoneNumber.Name = "cbbPhoneNumber";
            cbbPhoneNumber.RightToLeft = RightToLeft.No;
            cbbPhoneNumber.Size = new Size(201, 42);
            cbbPhoneNumber.TabIndex = 3;
            cbbPhoneNumber.Text = "Số điện thoại";
            cbbPhoneNumber.Click += cbbTienNo_Click;
            // 
            // cbbCustomerName
            // 
            cbbCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCustomerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCustomerName.FormattingEnabled = true;
            cbbCustomerName.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbCustomerName.Location = new Point(348, 0);
            cbbCustomerName.Margin = new Padding(3, 2, 3, 2);
            cbbCustomerName.Name = "cbbCustomerName";
            cbbCustomerName.RightToLeft = RightToLeft.No;
            cbbCustomerName.Size = new Size(232, 40);
            cbbCustomerName.TabIndex = 2;
            cbbCustomerName.Text = "Chủ xe";
            cbbCustomerName.SelectedIndexChanged += cbbChuXe_SelectedIndexChanged;
            cbbCustomerName.Click += cbbChuXe_Click;
            // 
            // cbbCarBrand
            // 
            cbbCarBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCarBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCarBrand.DataSource = hieuXeBindingSource;
            cbbCarBrand.FormattingEnabled = true;
            cbbCarBrand.Location = new Point(187, -2);
            cbbCarBrand.Margin = new Padding(3, 2, 3, 2);
            cbbCarBrand.Name = "cbbCarBrand";
            cbbCarBrand.RightToLeft = RightToLeft.No;
            cbbCarBrand.Size = new Size(152, 40);
            cbbCarBrand.TabIndex = 1;
            cbbCarBrand.Click += cbbHieuXe_Click;
            // 
            // hieuXeBindingSource
            // 
            hieuXeBindingSource.DataSource = typeof(Models.HieuXe);
            // 
            // cbbLicensePlate
            // 
            cbbLicensePlate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbLicensePlate.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbLicensePlate.DataSource = xeBindingSource;
            cbbLicensePlate.DropDownStyle = ComboBoxStyle.Simple;
            cbbLicensePlate.FormattingEnabled = true;
            cbbLicensePlate.Location = new Point(10, 0);
            cbbLicensePlate.Margin = new Padding(3, 2, 3, 2);
            cbbLicensePlate.Name = "cbbLicensePlate";
            cbbLicensePlate.RightToLeft = RightToLeft.No;
            cbbLicensePlate.Size = new Size(168, 42);
            cbbLicensePlate.TabIndex = 0;
            cbbLicensePlate.SelectedIndexChanged += cbbLicensePlate_SelectedIndexChanged;
            cbbLicensePlate.Click += cbbLicensePlate_Click;
            // 
            // xeBindingSource
            // 
            xeBindingSource.DataSource = typeof(Models.Xe);
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPayment);
            panel3.Controls.Add(menuStrip1);
            panel3.Controls.Add(bnAddCar);
            panel3.Controls.Add(btnAddService);
            panel3.Controls.Add(bnXoa);
            panel3.Controls.Add(bnRefresh);
            panel3.Controls.Add(bnFind);
            panel3.Location = new Point(1066, 130);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(790, 174);
            panel3.TabIndex = 3;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(211, 83);
            btnPayment.Margin = new Padding(3, 2, 3, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(172, 91);
            btnPayment.TabIndex = 6;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { StripMenuManager });
            menuStrip1.Location = new Point(419, 16);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(129, 42);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuManager
            // 
            StripMenuManager.BackColor = SystemColors.ButtonHighlight;
            StripMenuManager.DropDownItems.AddRange(new ToolStripItem[] { ListRepair, ListPayment });
            StripMenuManager.Name = "StripMenuManager";
            StripMenuManager.Size = new Size(117, 36);
            StripMenuManager.Text = "Quản lý";
            // 
            // ListRepair
            // 
            ListRepair.Name = "ListRepair";
            ListRepair.Size = new Size(427, 44);
            ListRepair.Text = "Danh sách phiếu sửa chữa";
            ListRepair.Click += ListRepair_Click;
            // 
            // ListPayment
            // 
            ListPayment.Name = "ListPayment";
            ListPayment.Size = new Size(427, 44);
            ListPayment.Text = "Danh sách phiếu thu tiền";
            ListPayment.Click += ListPayment_Click;
            // 
            // bnAddCar
            // 
            bnAddCar.Location = new Point(595, 32);
            bnAddCar.Margin = new Padding(3, 2, 3, 2);
            bnAddCar.Name = "bnAddCar";
            bnAddCar.Size = new Size(185, 123);
            bnAddCar.TabIndex = 5;
            bnAddCar.Text = "Tiếp nhận xe";
            bnAddCar.UseVisualStyleBackColor = true;
            bnAddCar.Click += btnAddCar_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(0, 85);
            btnAddService.Margin = new Padding(3, 2, 3, 2);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(177, 90);
            btnAddService.TabIndex = 4;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // bnXoa
            // 
            bnXoa.Location = new Point(419, 85);
            bnXoa.Margin = new Padding(3, 2, 3, 2);
            bnXoa.Name = "bnXoa";
            bnXoa.Size = new Size(153, 90);
            bnXoa.TabIndex = 3;
            bnXoa.Text = "Xóa";
            bnXoa.UseVisualStyleBackColor = true;
            bnXoa.Click += bnDelete_Click;
            // 
            // bnRefresh
            // 
            bnRefresh.Location = new Point(211, 0);
            bnRefresh.Margin = new Padding(3, 2, 3, 2);
            bnRefresh.Name = "bnRefresh";
            bnRefresh.Size = new Size(172, 82);
            bnRefresh.TabIndex = 1;
            bnRefresh.Text = "Làm mới";
            bnRefresh.UseVisualStyleBackColor = true;
            bnRefresh.Click += bnRefresh_Click;
            // 
            // bnFind
            // 
            bnFind.Location = new Point(0, 0);
            bnFind.Margin = new Padding(3, 2, 3, 2);
            bnFind.Name = "bnFind";
            bnFind.Size = new Size(177, 82);
            bnFind.TabIndex = 5;
            bnFind.Text = "Tìm xe";
            bnFind.UseVisualStyleBackColor = true;
            bnFind.Click += bnFind_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(10, 232);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 72);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(242, 45);
            label2.TabIndex = 0;
            label2.Text = "DANH SÁCH XE";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtgvService);
            panel5.Location = new Point(10, 307);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1848, 834);
            panel5.TabIndex = 6;
            // 
            // dtgvService
            // 
            dtgvService.AllowUserToAddRows = false;
            dtgvService.AllowUserToDeleteRows = false;
            dtgvService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvService.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvService.GridColor = SystemColors.InactiveCaptionText;
            dtgvService.Location = new Point(11, 21);
            dtgvService.Margin = new Padding(3, 2, 3, 2);
            dtgvService.Name = "dtgvService";
            dtgvService.RowHeadersWidth = 51;
            dtgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvService.Size = new Size(1823, 811);
            dtgvService.TabIndex = 4;
            dtgvService.TabStop = false;
            dtgvService.CellContentClick += dgvService_CellContentClick;
            dtgvService.CellDoubleClick += dgvService_CellDoubleClick;
            // 
            // btnChangeInfor
            // 
            btnChangeInfor.Location = new Point(884, 214);
            btnChangeInfor.Margin = new Padding(3, 2, 3, 2);
            btnChangeInfor.Name = "btnChangeInfor";
            btnChangeInfor.Size = new Size(172, 90);
            btnChangeInfor.TabIndex = 7;
            btnChangeInfor.Text = "Sửa thông tin";
            btnChangeInfor.UseVisualStyleBackColor = true;
            btnChangeInfor.Click += ChangeInfor_Click;
            // 
            // fService
            // 
            AcceptButton = bnFind;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 1086);
            Controls.Add(btnChangeInfor);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1877, 1157);
            MinimumSize = new Size(1877, 1157);
            Name = "fService";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DỊCH VỤ";
            Load += Service_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hieuXeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)xeBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox cbbLicensePlate;
        private ComboBox cbbPhoneNumber;
        private ComboBox cbbCustomerName;
        private ComboBox cbbCarBrand;
        private DateTimePicker dtpDateService;
        private Panel panel3;
        private Button bnRefresh;
        private Button bnFind;
        private Button bnAddCar;
        private Button btnAddService;
        private Button bnXoa;
        private Button btnManage;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private DataGridView dtgvService;
        private BindingSource xeBindingSource;
        private BindingSource hieuXeBindingSource;
        private Button btnPayment;
        private Button btnChangeInfor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripMenuManager;
        private ToolStripMenuItem ListRepair;
        private ToolStripMenuItem ListPayment;
    }
}