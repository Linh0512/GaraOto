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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dtpDateService = new DateTimePicker();
            cbbPhoneNumber = new ComboBox();
            cbbTenChuXe = new ComboBox();
            cbbHieuXe = new ComboBox();
            hieuXeBindingSource = new BindingSource(components);
            cbbLicensePlate = new ComboBox();
            xeBindingSource = new BindingSource(components);
            panel3 = new Panel();
            bnThemXe = new Button();
            btnAddService = new Button();
            bnXoa = new Button();
            bnXuat = new Button();
            bnLamMoi = new Button();
            bnFind = new Button();
            panel4 = new Panel();
            cbbTypeCar = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            dgvService = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hieuXeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xeBindingSource).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 81);
            label1.TabIndex = 1;
            label1.Text = "Service";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpDateService);
            panel2.Controls.Add(cbbPhoneNumber);
            panel2.Controls.Add(cbbTenChuXe);
            panel2.Controls.Add(cbbHieuXe);
            panel2.Controls.Add(cbbLicensePlate);
            panel2.Location = new Point(6, 91);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 36);
            panel2.TabIndex = 2;
            // 
            // dtpDateService
            // 
            dtpDateService.Format = DateTimePickerFormat.Short;
            dtpDateService.Location = new Point(491, 0);
            dtpDateService.Margin = new Padding(2, 1, 2, 1);
            dtpDateService.Name = "dtpDateService";
            dtpDateService.Size = new Size(153, 27);
            dtpDateService.TabIndex = 4;
            dtpDateService.Value = new DateTime(2024, 11, 13, 0, 59, 26, 0);
            // 
            // cbbPhoneNumber
            // 
            cbbPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPhoneNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbPhoneNumber.DropDownStyle = ComboBoxStyle.Simple;
            cbbPhoneNumber.FormattingEnabled = true;
            cbbPhoneNumber.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbPhoneNumber.Location = new Point(362, 0);
            cbbPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            cbbPhoneNumber.Name = "cbbPhoneNumber";
            cbbPhoneNumber.RightToLeft = RightToLeft.No;
            cbbPhoneNumber.Size = new Size(125, 28);
            cbbPhoneNumber.TabIndex = 3;
            cbbPhoneNumber.Text = "Số điện thoại";
            cbbPhoneNumber.Click += cbbTienNo_Click;
            // 
            // cbbTenChuXe
            // 
            cbbTenChuXe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenChuXe.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTenChuXe.FormattingEnabled = true;
            cbbTenChuXe.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbTenChuXe.Location = new Point(214, 0);
            cbbTenChuXe.Margin = new Padding(2, 1, 2, 1);
            cbbTenChuXe.Name = "cbbTenChuXe";
            cbbTenChuXe.RightToLeft = RightToLeft.No;
            cbbTenChuXe.Size = new Size(144, 28);
            cbbTenChuXe.TabIndex = 2;
            cbbTenChuXe.Text = "Chủ xe";
            cbbTenChuXe.SelectedIndexChanged += cbbChuXe_SelectedIndexChanged;
            cbbTenChuXe.Click += cbbChuXe_Click;
            // 
            // cbbHieuXe
            // 
            cbbHieuXe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbHieuXe.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbHieuXe.DataSource = hieuXeBindingSource;
            cbbHieuXe.FormattingEnabled = true;
            cbbHieuXe.Location = new Point(115, -1);
            cbbHieuXe.Margin = new Padding(2, 1, 2, 1);
            cbbHieuXe.Name = "cbbHieuXe";
            cbbHieuXe.RightToLeft = RightToLeft.No;
            cbbHieuXe.Size = new Size(95, 28);
            cbbHieuXe.TabIndex = 1;
            cbbHieuXe.Click += cbbHieuXe_Click;
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
            cbbLicensePlate.Location = new Point(6, 0);
            cbbLicensePlate.Margin = new Padding(2, 1, 2, 1);
            cbbLicensePlate.Name = "cbbLicensePlate";
            cbbLicensePlate.RightToLeft = RightToLeft.No;
            cbbLicensePlate.Size = new Size(105, 28);
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
            panel3.Controls.Add(bnThemXe);
            panel3.Controls.Add(btnAddService);
            panel3.Controls.Add(bnXoa);
            panel3.Controls.Add(bnXuat);
            panel3.Controls.Add(bnLamMoi);
            panel3.Controls.Add(bnFind);
            panel3.Location = new Point(656, 81);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(486, 109);
            panel3.TabIndex = 3;
            // 
            // bnThemXe
            // 
            bnThemXe.Location = new Point(356, 20);
            bnThemXe.Margin = new Padding(2, 1, 2, 1);
            bnThemXe.Name = "bnThemXe";
            bnThemXe.Size = new Size(114, 77);
            bnThemXe.TabIndex = 5;
            bnThemXe.Text = "Thêm xe";
            bnThemXe.UseVisualStyleBackColor = true;
            bnThemXe.Click += btnAddCar_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(47, 53);
            btnAddService.Margin = new Padding(2, 1, 2, 1);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(119, 51);
            btnAddService.TabIndex = 4;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // bnXoa
            // 
            bnXoa.Location = new Point(202, 53);
            bnXoa.Margin = new Padding(2, 1, 2, 1);
            bnXoa.Name = "bnXoa";
            bnXoa.Size = new Size(94, 51);
            bnXoa.TabIndex = 3;
            bnXoa.Text = "Xóa";
            bnXoa.UseVisualStyleBackColor = true;
            bnXoa.Click += bnDelete_Click;
            // 
            // bnXuat
            // 
            bnXuat.Location = new Point(258, 0);
            bnXuat.Margin = new Padding(2, 1, 2, 1);
            bnXuat.Name = "bnXuat";
            bnXuat.Size = new Size(94, 51);
            bnXuat.TabIndex = 2;
            bnXuat.Text = "Xuất";
            bnXuat.UseVisualStyleBackColor = true;
            // 
            // bnLamMoi
            // 
            bnLamMoi.Location = new Point(130, 0);
            bnLamMoi.Margin = new Padding(2, 1, 2, 1);
            bnLamMoi.Name = "bnLamMoi";
            bnLamMoi.Size = new Size(94, 51);
            bnLamMoi.TabIndex = 1;
            bnLamMoi.Text = "Làm mới";
            bnLamMoi.UseVisualStyleBackColor = true;
            bnLamMoi.Click += bnRefresh_Click;
            // 
            // bnFind
            // 
            bnFind.Location = new Point(0, 0);
            bnFind.Margin = new Padding(2, 1, 2, 1);
            bnFind.Name = "bnFind";
            bnFind.Size = new Size(94, 51);
            bnFind.TabIndex = 5;
            bnFind.Text = "Tìm xe";
            bnFind.UseVisualStyleBackColor = true;
            bnFind.Click += bnFind_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbbTypeCar);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(6, 129);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 60);
            panel4.TabIndex = 5;
            // 
            // cbbTypeCar
            // 
            cbbTypeCar.FormattingEnabled = true;
            cbbTypeCar.Location = new Point(7, 24);
            cbbTypeCar.Margin = new Padding(2, 1, 2, 1);
            cbbTypeCar.Name = "cbbTypeCar";
            cbbTypeCar.Size = new Size(236, 28);
            cbbTypeCar.TabIndex = 1;
            cbbTypeCar.Text = "Tất cả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 0;
            label2.Text = "Hiển thị danh sách xe theo";
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvService);
            panel5.Location = new Point(6, 192);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(1137, 521);
            panel5.TabIndex = 6;
            // 
            // dgvService
            // 
            dgvService.AllowUserToAddRows = false;
            dgvService.AllowUserToDeleteRows = false;
            dgvService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvService.BackgroundColor = SystemColors.ButtonHighlight;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.GridColor = SystemColors.InactiveCaptionText;
            dgvService.Location = new Point(7, 13);
            dgvService.Margin = new Padding(2, 1, 2, 1);
            dgvService.Name = "dgvService";
            dgvService.RowHeadersWidth = 51;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvService.Size = new Size(1122, 507);
            dgvService.TabIndex = 4;
            dgvService.TabStop = false;
            dgvService.CellContentClick += dgvService_CellContentClick;
            dgvService.CellDoubleClick += dgvService_CellDoubleClick;
            // 
            // fService
            // 
            AcceptButton = bnFind;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 703);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(1165, 750);
            MinimumSize = new Size(1165, 750);
            Name = "fService";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Service";
            Load += Service_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hieuXeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)xeBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox cbbLicensePlate;
        private ComboBox cbbPhoneNumber;
        private ComboBox cbbTenChuXe;
        private ComboBox cbbHieuXe;
        private DateTimePicker dtpDateService;
        private Panel panel3;
        private Button bnLamMoi;
        private Button bnFind;
        private Button bnThemXe;
        private Button btnAddService;
        private Button bnXoa;
        private Button bnXuat;
        private Panel panel4;
        private Label label2;
        private ComboBox cbbTypeCar;
        private Panel panel5;
        private DataGridView dgvService;
        private BindingSource xeBindingSource;
        private BindingSource hieuXeBindingSource;
    }
}