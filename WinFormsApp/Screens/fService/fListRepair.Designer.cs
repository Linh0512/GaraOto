namespace WinFormsApp.Screens.Service.ListRepair
{
    partial class fListRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListRepair));
            panel1 = new Panel();
            dtgvRepairList = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            txbSearch = new TextBox();
            panel3 = new Panel();
            btnRefresh = new Button();
            dtpSearchByDate = new DateTimePicker();
            btnSearch = new Button();
            label2 = new Label();
            panel4 = new Panel();
            btnClose = new Button();
            btnExport = new Button();
            btnDetail = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRepairList).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvRepairList);
            panel1.Location = new Point(12, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 378);
            panel1.TabIndex = 0;
            // 
            // dtgvRepairList
            // 
            dtgvRepairList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRepairList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRepairList.Dock = DockStyle.Fill;
            dtgvRepairList.Location = new Point(0, 0);
            dtgvRepairList.Name = "dtgvRepairList";
            dtgvRepairList.RowHeadersWidth = 51;
            dtgvRepairList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRepairList.Size = new Size(1046, 378);
            dtgvRepairList.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 66);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(561, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH PHIẾU SỬA CHỮA";
            // 
            // txbSearch
            // 
            txbSearch.BackColor = SystemColors.HighlightText;
            txbSearch.Location = new Point(268, 80);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(527, 27);
            txbSearch.TabIndex = 2;
            txbSearch.Text = "Nhập biển số xe";
            txbSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(dtpSearchByDate);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 81);
            panel3.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(910, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 54);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dtpSearchByDate
            // 
            dtpSearchByDate.Format = DateTimePickerFormat.Short;
            dtpSearchByDate.Location = new Point(393, 43);
            dtpSearchByDate.Name = "dtpSearchByDate";
            dtpSearchByDate.Size = new Size(250, 27);
            dtpSearchByDate.TabIndex = 2;
            dtpSearchByDate.ValueChanged += dtpSearchByDate_ValueChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Info;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(789, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(btnExport);
            panel4.Controls.Add(btnDetail);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 541);
            panel4.Name = "panel4";
            panel4.Size = new Size(1070, 81);
            panel4.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 64, 0);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(922, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 54);
            btnClose.TabIndex = 4;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ControlDark;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(495, 14);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(187, 55);
            btnExport.TabIndex = 1;
            btnExport.Text = "Xuất file danh sách";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.CadetBlue;
            btnDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetail.Location = new Point(157, 14);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(160, 55);
            btnDetail.TabIndex = 0;
            btnDetail.Text = "Xem chi tiết";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 43);
            label3.Name = "label3";
            label3.Size = new Size(232, 28);
            label3.TabIndex = 5;
            label3.Text = "Chọn ngày để tìm kiếm";
            // 
            // fListRepair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 622);
            Controls.Add(panel4);
            Controls.Add(txbSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fListRepair";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DANH SÁCH PHIẾU SỬA CHỮA";
            Load += fListRepair_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRepairList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvRepairList;
        private Panel panel2;
        private Label label1;
        private TextBox txbSearch;
        private Panel panel3;
        private Button btnSearch;
        private Label label2;
        private Button btnRefresh;
        private DateTimePicker dtpSearchByDate;
        private Panel panel4;
        private Button btnDetail;
        private Button btnClose;
        private Button btnExport;
        private Label label3;
    }
}