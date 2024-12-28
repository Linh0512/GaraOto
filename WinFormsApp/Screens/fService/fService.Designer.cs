﻿namespace WinFormsApp.Screens.Service
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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            checkBox1 = new System.Windows.Forms.CheckBox();
            dtpDateService = new System.Windows.Forms.DateTimePicker();
            cbbPhoneNumber = new System.Windows.Forms.ComboBox();
            cbbCustomerName = new System.Windows.Forms.ComboBox();
            cbbCarBrand = new System.Windows.Forms.ComboBox();
            hieuXeBindingSource = new System.Windows.Forms.BindingSource(components);
            cbbLicensePlate = new System.Windows.Forms.ComboBox();
            xeBindingSource = new System.Windows.Forms.BindingSource(components);
            panel3 = new System.Windows.Forms.Panel();
            btnPayment = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            StripMenuManager = new System.Windows.Forms.ToolStripMenuItem();
            ListRepair = new System.Windows.Forms.ToolStripMenuItem();
            ListPayment = new System.Windows.Forms.ToolStripMenuItem();
            bnAddCar = new System.Windows.Forms.Button();
            btnAddService = new System.Windows.Forms.Button();
            bnXoa = new System.Windows.Forms.Button();
            bnRefresh = new System.Windows.Forms.Button();
            bnFind = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            dtgvService = new System.Windows.Forms.DataGridView();
            btnChangeInfor = new System.Windows.Forms.Button();
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
            panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1855, 126);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(336, 96);
            label1.TabIndex = 1;
            label1.Text = "DỊCH VỤ";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(dtpDateService);
            panel2.Controls.Add(cbbPhoneNumber);
            panel2.Controls.Add(cbbCustomerName);
            panel2.Controls.Add(cbbCarBrand);
            panel2.Controls.Add(cbbLicensePlate);
            panel2.Location = new System.Drawing.Point(10, 146);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1050, 58);
            panel2.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.CausesValidation = false;
            checkBox1.Location = new System.Drawing.Point(798, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(231, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Sử dụng ngày để tìm kiếm";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dtpDateService
            // 
            dtpDateService.Enabled = false;
            dtpDateService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDateService.Location = new System.Drawing.Point(798, 0);
            dtpDateService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpDateService.Name = "dtpDateService";
            dtpDateService.Size = new System.Drawing.Size(246, 31);
            dtpDateService.TabIndex = 4;
            dtpDateService.Value = new System.DateTime(2024, 12, 28, 15, 41, 20, 372);
            dtpDateService.ValueChanged += dtpDateService_ValueChanged;
            // 
            // cbbPhoneNumber
            // 
            cbbPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbbPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbbPhoneNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            cbbPhoneNumber.FormattingEnabled = true;
            cbbPhoneNumber.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbPhoneNumber.Location = new System.Drawing.Point(588, 0);
            cbbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbbPhoneNumber.Name = "cbbPhoneNumber";
            cbbPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cbbPhoneNumber.Size = new System.Drawing.Size(201, 42);
            cbbPhoneNumber.TabIndex = 3;
            cbbPhoneNumber.Text = "Số điện thoại";
            cbbPhoneNumber.Click += cbbTienNo_Click;
            // 
            // cbbCustomerName
            // 
            cbbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbbCustomerName.FormattingEnabled = true;
            cbbCustomerName.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbCustomerName.Location = new System.Drawing.Point(348, 0);
            cbbCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbbCustomerName.Name = "cbbCustomerName";
            cbbCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cbbCustomerName.Size = new System.Drawing.Size(232, 33);
            cbbCustomerName.TabIndex = 2;
            cbbCustomerName.Text = "Chủ xe";
            cbbCustomerName.SelectedIndexChanged += cbbChuXe_SelectedIndexChanged;
            cbbCustomerName.Click += cbbChuXe_Click;
            // 
            // cbbCarBrand
            // 
            cbbCarBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbbCarBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbbCarBrand.DataSource = hieuXeBindingSource;
            cbbCarBrand.FormattingEnabled = true;
            cbbCarBrand.Location = new System.Drawing.Point(187, -2);
            cbbCarBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbbCarBrand.Name = "cbbCarBrand";
            cbbCarBrand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cbbCarBrand.Size = new System.Drawing.Size(152, 33);
            cbbCarBrand.TabIndex = 1;
            cbbCarBrand.SelectedIndexChanged += cbbCarBrand_SelectedIndexChanged;
            cbbCarBrand.Click += cbbHieuXe_Click;
            // 
            // hieuXeBindingSource
            // 
            hieuXeBindingSource.DataSource = typeof(WinFormsApp.Models.HieuXe);
            // 
            // cbbLicensePlate
            // 
            cbbLicensePlate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbbLicensePlate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbbLicensePlate.DataSource = xeBindingSource;
            cbbLicensePlate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            cbbLicensePlate.FormattingEnabled = true;
            cbbLicensePlate.Location = new System.Drawing.Point(10, 0);
            cbbLicensePlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbbLicensePlate.Name = "cbbLicensePlate";
            cbbLicensePlate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            cbbLicensePlate.Size = new System.Drawing.Size(168, 42);
            cbbLicensePlate.TabIndex = 0;
            cbbLicensePlate.SelectedIndexChanged += cbbLicensePlate_SelectedIndexChanged;
            cbbLicensePlate.Click += cbbLicensePlate_Click;
            // 
            // xeBindingSource
            // 
            xeBindingSource.DataSource = typeof(WinFormsApp.Models.Xe);
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
            panel3.Location = new System.Drawing.Point(1066, 130);
            panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(790, 174);
            panel3.TabIndex = 3;
            // 
            // btnPayment
            // 
            btnPayment.Location = new System.Drawing.Point(211, 83);
            btnPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new System.Drawing.Size(172, 91);
            btnPayment.TabIndex = 6;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StripMenuManager });
            menuStrip1.Location = new System.Drawing.Point(419, 16);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(101, 35);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuManager
            // 
            StripMenuManager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            StripMenuManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ListRepair, ListPayment });
            StripMenuManager.Name = "StripMenuManager";
            StripMenuManager.Size = new System.Drawing.Size(89, 29);
            StripMenuManager.Text = "Quản lý";
            StripMenuManager.Click += StripMenuManager_Click;
            // 
            // ListRepair
            // 
            ListRepair.Name = "ListRepair";
            ListRepair.Size = new System.Drawing.Size(321, 34);
            ListRepair.Text = "Danh sách phiếu sửa chữa";
            ListRepair.Click += ListRepair_Click;
            // 
            // ListPayment
            // 
            ListPayment.Name = "ListPayment";
            ListPayment.Size = new System.Drawing.Size(321, 34);
            ListPayment.Text = "Danh sách phiếu thu tiền";
            ListPayment.Click += ListPayment_Click;
            // 
            // bnAddCar
            // 
            bnAddCar.Location = new System.Drawing.Point(595, 32);
            bnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bnAddCar.Name = "bnAddCar";
            bnAddCar.Size = new System.Drawing.Size(185, 123);
            bnAddCar.TabIndex = 5;
            bnAddCar.Text = "Tiếp nhận xe";
            bnAddCar.UseVisualStyleBackColor = true;
            bnAddCar.Click += btnAddCar_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new System.Drawing.Point(0, 85);
            btnAddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new System.Drawing.Size(177, 90);
            btnAddService.TabIndex = 4;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // bnXoa
            // 
            bnXoa.Location = new System.Drawing.Point(419, 85);
            bnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bnXoa.Name = "bnXoa";
            bnXoa.Size = new System.Drawing.Size(153, 90);
            bnXoa.TabIndex = 3;
            bnXoa.Text = "Xóa";
            bnXoa.UseVisualStyleBackColor = true;
            bnXoa.Click += bnDelete_Click;
            // 
            // bnRefresh
            // 
            bnRefresh.Location = new System.Drawing.Point(211, 0);
            bnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bnRefresh.Name = "bnRefresh";
            bnRefresh.Size = new System.Drawing.Size(172, 82);
            bnRefresh.TabIndex = 1;
            bnRefresh.Text = "Làm mới";
            bnRefresh.UseVisualStyleBackColor = true;
            bnRefresh.Click += bnRefresh_Click;
            // 
            // bnFind
            // 
            bnFind.Location = new System.Drawing.Point(0, 0);
            bnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bnFind.Name = "bnFind";
            bnFind.Size = new System.Drawing.Size(177, 82);
            bnFind.TabIndex = 5;
            bnFind.Text = "Tìm xe";
            bnFind.UseVisualStyleBackColor = true;
            bnFind.Click += bnFind_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            panel4.Controls.Add(label2);
            panel4.Location = new System.Drawing.Point(10, 232);
            panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(254, 72);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(3, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(180, 32);
            label2.TabIndex = 0;
            label2.Text = "DANH SÁCH XE";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtgvService);
            panel5.Location = new System.Drawing.Point(10, 307);
            panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1848, 834);
            panel5.TabIndex = 6;
            // 
            // dtgvService
            // 
            dtgvService.AllowUserToAddRows = false;
            dtgvService.AllowUserToDeleteRows = false;
            dtgvService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dtgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dtgvService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvService.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            dtgvService.Location = new System.Drawing.Point(11, 21);
            dtgvService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtgvService.Name = "dtgvService";
            dtgvService.ReadOnly = true;
            dtgvService.RowHeadersWidth = 51;
            dtgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgvService.Size = new System.Drawing.Size(1823, 811);
            dtgvService.TabIndex = 4;
            dtgvService.TabStop = false;
            dtgvService.CellContentClick += dgvService_CellContentClick;
            dtgvService.CellDoubleClick += dgvService_CellDoubleClick;
            // 
            // btnChangeInfor
            // 
            btnChangeInfor.Location = new System.Drawing.Point(884, 214);
            btnChangeInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnChangeInfor.Name = "btnChangeInfor";
            btnChangeInfor.Size = new System.Drawing.Size(172, 90);
            btnChangeInfor.TabIndex = 7;
            btnChangeInfor.Text = "Sửa thông tin";
            btnChangeInfor.UseVisualStyleBackColor = true;
            btnChangeInfor.Click += ChangeInfor_Click;
            // 
            // fService
            // 
            AcceptButton = bnFind;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1855, 1101);
            Controls.Add(btnChangeInfor);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximumSize = new System.Drawing.Size(1877, 1157);
            MinimumSize = new System.Drawing.Size(1877, 1157);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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

        private System.Windows.Forms.CheckBox checkBox1;

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ComboBox cbbLicensePlate;
        private ComboBox cbbPhoneNumber;
        private ComboBox cbbCustomerName;
        private System.Windows.Forms.ComboBox cbbCarBrand;
        private System.Windows.Forms.DateTimePicker dtpDateService;
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
        private System.Windows.Forms.DataGridView dtgvService;
        private BindingSource xeBindingSource;
        private BindingSource hieuXeBindingSource;
        private Button btnPayment;
        private Button btnChangeInfor;
        private MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuManager;
        private ToolStripMenuItem ListRepair;
        private ToolStripMenuItem ListPayment;
    }
}