namespace WinFormsApp
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dtpDateService = new DateTimePicker();
            cbbTienNo = new ComboBox();
            cbbChuXe = new ComboBox();
            cbbHieuXe = new ComboBox();
            cbbLicensePlate = new ComboBox();
            panel3 = new Panel();
            bnThemXe = new Button();
            bnChiTiet = new Button();
            bnXoa = new Button();
            bnXuat = new Button();
            bnLamMoi = new Button();
            bnThem = new Button();
            panel4 = new Panel();
            cbbTypeCar = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            dgvService = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2065, 123);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(379, 128);
            label1.TabIndex = 1;
            label1.Text = "Service";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpDateService);
            panel2.Controls.Add(cbbTienNo);
            panel2.Controls.Add(cbbChuXe);
            panel2.Controls.Add(cbbHieuXe);
            panel2.Controls.Add(cbbLicensePlate);
            panel2.Location = new Point(0, 163);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 48);
            panel2.TabIndex = 2;
            // 
            // dtpDateService
            // 
            dtpDateService.Location = new Point(604, 2);
            dtpDateService.Margin = new Padding(5);
            dtpDateService.Name = "dtpDateService";
            dtpDateService.Size = new Size(422, 39);
            dtpDateService.TabIndex = 4;
            dtpDateService.Value = new DateTime(2024, 11, 13, 0, 59, 26, 0);
            // 
            // cbbTienNo
            // 
            cbbTienNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTienNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTienNo.DropDownStyle = ComboBoxStyle.Simple;
            cbbTienNo.FormattingEnabled = true;
            cbbTienNo.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbTienNo.Location = new Point(458, 0);
            cbbTienNo.Margin = new Padding(5);
            cbbTienNo.Name = "cbbTienNo";
            cbbTienNo.RightToLeft = RightToLeft.No;
            cbbTienNo.Size = new Size(134, 42);
            cbbTienNo.TabIndex = 3;
            cbbTienNo.Text = "Tiền nợ";
            cbbTienNo.Click += cbbTienNo_Click;
            // 
            // cbbChuXe
            // 
            cbbChuXe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbChuXe.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbChuXe.FormattingEnabled = true;
            cbbChuXe.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbChuXe.Location = new Point(312, 0);
            cbbChuXe.Margin = new Padding(5);
            cbbChuXe.Name = "cbbChuXe";
            cbbChuXe.RightToLeft = RightToLeft.No;
            cbbChuXe.Size = new Size(134, 40);
            cbbChuXe.TabIndex = 2;
            cbbChuXe.Text = "Chủ xe";
            cbbChuXe.Click += cbbChuXe_Click;
            // 
            // cbbHieuXe
            // 
            cbbHieuXe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbHieuXe.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbHieuXe.FormattingEnabled = true;
            cbbHieuXe.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbHieuXe.Location = new Point(166, 0);
            cbbHieuXe.Margin = new Padding(5);
            cbbHieuXe.Name = "cbbHieuXe";
            cbbHieuXe.RightToLeft = RightToLeft.No;
            cbbHieuXe.Size = new Size(134, 40);
            cbbHieuXe.TabIndex = 1;
            cbbHieuXe.Text = "Hiệu xe";
            cbbHieuXe.Click += cbbHieuXe_Click;
            // 
            // cbbLicensePlate
            // 
            cbbLicensePlate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbLicensePlate.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbLicensePlate.DropDownStyle = ComboBoxStyle.Simple;
            cbbLicensePlate.FormattingEnabled = true;
            cbbLicensePlate.Items.AddRange(new object[] { "", "Bs1882", "Bs2759", "Bs3872", "Bs4072" });
            cbbLicensePlate.Location = new Point(20, 0);
            cbbLicensePlate.Margin = new Padding(5);
            cbbLicensePlate.Name = "cbbLicensePlate";
            cbbLicensePlate.RightToLeft = RightToLeft.No;
            cbbLicensePlate.Size = new Size(134, 42);
            cbbLicensePlate.TabIndex = 0;
            cbbLicensePlate.Text = "Biển Số";
            cbbLicensePlate.SelectedIndexChanged += cbbLicensePlate_SelectedIndexChanged;
            cbbLicensePlate.Click += cbbLicensePlate_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bnThemXe);
            panel3.Controls.Add(bnChiTiet);
            panel3.Controls.Add(bnXoa);
            panel3.Controls.Add(bnXuat);
            panel3.Controls.Add(bnLamMoi);
            panel3.Controls.Add(bnThem);
            panel3.Location = new Point(1092, 163);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(689, 176);
            panel3.TabIndex = 3;
            // 
            // bnThemXe
            // 
            bnThemXe.Location = new Point(507, 43);
            bnThemXe.Margin = new Padding(5);
            bnThemXe.Name = "bnThemXe";
            bnThemXe.Size = new Size(162, 96);
            bnThemXe.TabIndex = 5;
            bnThemXe.Text = "Thêm xe";
            bnThemXe.UseVisualStyleBackColor = true;
            bnThemXe.Click += bnThemXe_Click;
            // 
            // bnChiTiet
            // 
            bnChiTiet.Location = new Point(167, 96);
            bnChiTiet.Margin = new Padding(5);
            bnChiTiet.Name = "bnChiTiet";
            bnChiTiet.Size = new Size(153, 80);
            bnChiTiet.TabIndex = 4;
            bnChiTiet.Text = "Chi tiết";
            bnChiTiet.UseVisualStyleBackColor = true;
            // 
            // bnXoa
            // 
            bnXoa.Location = new Point(0, 96);
            bnXoa.Margin = new Padding(5);
            bnXoa.Name = "bnXoa";
            bnXoa.Size = new Size(153, 80);
            bnXoa.TabIndex = 3;
            bnXoa.Text = "Xóa";
            bnXoa.UseVisualStyleBackColor = true;
            // 
            // bnXuat
            // 
            bnXuat.Location = new Point(330, 0);
            bnXuat.Margin = new Padding(5);
            bnXuat.Name = "bnXuat";
            bnXuat.Size = new Size(153, 80);
            bnXuat.TabIndex = 2;
            bnXuat.Text = "Xuất";
            bnXuat.UseVisualStyleBackColor = true;
            // 
            // bnLamMoi
            // 
            bnLamMoi.Location = new Point(167, 0);
            bnLamMoi.Margin = new Padding(5);
            bnLamMoi.Name = "bnLamMoi";
            bnLamMoi.Size = new Size(153, 80);
            bnLamMoi.TabIndex = 1;
            bnLamMoi.Text = "Làm mới";
            bnLamMoi.UseVisualStyleBackColor = true;
            // 
            // bnThem
            // 
            bnThem.Location = new Point(0, 2);
            bnThem.Margin = new Padding(5);
            bnThem.Name = "bnThem";
            bnThem.Size = new Size(153, 80);
            bnThem.TabIndex = 0;
            bnThem.Text = "Thêm";
            bnThem.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbbTypeCar);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(20, 224);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 115);
            panel4.TabIndex = 5;
            // 
            // cbbTypeCar
            // 
            cbbTypeCar.FormattingEnabled = true;
            cbbTypeCar.Location = new Point(18, 48);
            cbbTypeCar.Margin = new Padding(5);
            cbbTypeCar.Name = "cbbTypeCar";
            cbbTypeCar.Size = new Size(381, 40);
            cbbTypeCar.TabIndex = 1;
            cbbTypeCar.Text = "Tất cả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(301, 32);
            label2.TabIndex = 0;
            label2.Text = "Hiển thị danh sách xe theo";
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvService);
            panel5.Location = new Point(20, 373);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1953, 883);
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
            dgvService.Location = new Point(18, 5);
            dgvService.Margin = new Padding(5);
            dgvService.Name = "dgvService";
            dgvService.RowHeadersWidth = 51;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvService.Size = new Size(1930, 856);
            dgvService.TabIndex = 4;
            dgvService.TabStop = false;
            dgvService.CellContentClick += dgvService_CellContentClick;
            dgvService.CellDoubleClick += dgvService_CellDoubleClick;
            // 
            // fService
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2065, 1275);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "fService";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Service";
            Load += Service_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private ComboBox cbbTienNo;
        private ComboBox cbbChuXe;
        private ComboBox cbbHieuXe;
        private DateTimePicker dtpDateService;
        private Panel panel3;
        private Button bnLamMoi;
        private Button bnThem;
        private Button bnThemXe;
        private Button bnChiTiet;
        private Button bnXoa;
        private Button bnXuat;
        private Panel panel4;
        private Label label2;
        private ComboBox cbbTypeCar;
        private Panel panel5;
        private DataGridView dgvService;
    }
}