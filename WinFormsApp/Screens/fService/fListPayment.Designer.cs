namespace WinFormsApp.Screens.Service.ListPayment
{
    partial class fListPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListPayment));
            txbSearch = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            dtgvPaymentList = new DataGridView();
            panel3 = new Panel();
            btnRefresh = new Button();
            dtpSearchByDate = new DateTimePicker();
            btnSearch = new Button();
            label2 = new Label();
            panel4 = new Panel();
            btnClose = new Button();
            btnExport = new Button();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPaymentList).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txbSearch
            // 
            txbSearch.BackColor = SystemColors.HighlightText;
            txbSearch.Location = new Point(272, 87);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(527, 27);
            txbSearch.TabIndex = 6;
            txbSearch.Text = "Nhập biển số xe";
            txbSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 66);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(539, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH PHIẾU THU TIỀN";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvPaymentList);
            panel1.Location = new Point(14, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 373);
            panel1.TabIndex = 4;
            // 
            // dtgvPaymentList
            // 
            dtgvPaymentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPaymentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPaymentList.Dock = DockStyle.Fill;
            dtgvPaymentList.Location = new Point(0, 0);
            dtgvPaymentList.Name = "dtgvPaymentList";
            dtgvPaymentList.RowHeadersWidth = 51;
            dtgvPaymentList.Size = new Size(1046, 373);
            dtgvPaymentList.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(dtpSearchByDate);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(14, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 81);
            panel3.TabIndex = 7;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnRefresh.Location = new Point(910, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 54);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dtpSearchByDate
            // 
            dtpSearchByDate.Format = DateTimePickerFormat.Short;
            dtpSearchByDate.Location = new Point(400, 50);
            dtpSearchByDate.Name = "dtpSearchByDate";
            dtpSearchByDate.Size = new Size(250, 27);
            dtpSearchByDate.TabIndex = 2;
            dtpSearchByDate.ValueChanged += dtpSearchByDate_ValueChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Info;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(791, 12);
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
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 536);
            panel4.Name = "panel4";
            panel4.Size = new Size(1072, 81);
            panel4.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 64, 0);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(716, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 54);
            btnClose.TabIndex = 4;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ControlDark;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(244, 14);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(187, 55);
            btnExport.TabIndex = 1;
            btnExport.Text = "Xuất file danh sách";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 50);
            label3.Name = "label3";
            label3.Size = new Size(232, 28);
            label3.TabIndex = 4;
            label3.Text = "Chọn ngày để tìm kiếm";
            // 
            // fListPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 617);
            Controls.Add(panel4);
            Controls.Add(txbSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1090, 664);
            MinimumSize = new Size(1090, 664);
            Name = "fListPayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DANH SÁCH PHIẾU THU TIỀN";
            Load += fListPayment_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPaymentList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbSearch;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private DataGridView dtgvPaymentList;
        private Panel panel3;
        private Button btnRefresh;
        private DateTimePicker dtpSearchByDate;
        private Button btnSearch;
        private Label label2;
        private Panel panel4;
        private Button btnClose;
        private Button btnExport;
        private Label label3;
    }
}