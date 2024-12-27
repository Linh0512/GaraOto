namespace WinFormsApp.Screens.Service.ListRepair_Detail
{
    partial class fListRepair_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListRepair_Detail));
            panel1 = new Panel();
            dtgvRepairList_Detail = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            dtpDateFix = new DateTimePicker();
            label3 = new Label();
            txbLicensePlate = new TextBox();
            txbIdRepair = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            btnExport = new Button();
            btnClose = new Button();
            txbTotalAmount = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRepairList_Detail).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvRepairList_Detail);
            panel1.Location = new Point(12, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 399);
            panel1.TabIndex = 0;
            // 
            // dtgvRepairList_Detail
            // 
            dtgvRepairList_Detail.AllowUserToAddRows = false;
            dtgvRepairList_Detail.AllowUserToDeleteRows = false;
            dtgvRepairList_Detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRepairList_Detail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRepairList_Detail.Dock = DockStyle.Fill;
            dtgvRepairList_Detail.Location = new Point(0, 0);
            dtgvRepairList_Detail.MaximumSize = new Size(1046, 399);
            dtgvRepairList_Detail.MinimumSize = new Size(1046, 399);
            dtgvRepairList_Detail.Name = "dtgvRepairList_Detail";
            dtgvRepairList_Detail.RowHeadersWidth = 51;
            dtgvRepairList_Detail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRepairList_Detail.Size = new Size(1046, 399);
            dtgvRepairList_Detail.TabIndex = 0;
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
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(720, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CHI TIẾT PHIẾU SỬA CHỮA";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpDateFix);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txbLicensePlate);
            panel3.Controls.Add(txbIdRepair);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(12, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 60);
            panel3.TabIndex = 3;
            // 
            // dtpDateFix
            // 
            dtpDateFix.Anchor = AnchorStyles.Top;
            dtpDateFix.Enabled = false;
            dtpDateFix.Format = DateTimePickerFormat.Short;
            dtpDateFix.Location = new Point(840, 19);
            dtpDateFix.Name = "dtpDateFix";
            dtpDateFix.Size = new Size(140, 27);
            dtpDateFix.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(673, 17);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 10;
            label3.Text = "Ngày sửa chữa:";
            // 
            // txbLicensePlate
            // 
            txbLicensePlate.Anchor = AnchorStyles.Top;
            txbLicensePlate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txbLicensePlate.BackColor = Color.Gainsboro;
            txbLicensePlate.Enabled = false;
            txbLicensePlate.Location = new Point(470, 17);
            txbLicensePlate.Name = "txbLicensePlate";
            txbLicensePlate.Size = new Size(125, 27);
            txbLicensePlate.TabIndex = 16;
            // 
            // txbIdRepair
            // 
            txbIdRepair.Anchor = AnchorStyles.Top;
            txbIdRepair.BackColor = Color.Gainsboro;
            txbIdRepair.Enabled = false;
            txbIdRepair.Location = new Point(227, 17);
            txbIdRepair.Name = "txbIdRepair";
            txbIdRepair.Size = new Size(79, 27);
            txbIdRepair.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(350, 17);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 13;
            label6.Text = "Biển số xe:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(50, 16);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 12;
            label5.Text = "Mã phiếu sửa chữa:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnExport);
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(txbTotalAmount);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 541);
            panel4.Name = "panel4";
            panel4.Size = new Size(1070, 81);
            panel4.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ControlDark;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(62, 14);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(187, 55);
            btnExport.TabIndex = 15;
            btnExport.Text = "Xuất file danh sách";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
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
            btnClose.Click += btnClose_Click;
            // 
            // txbTotalAmount
            // 
            txbTotalAmount.Anchor = AnchorStyles.Top;
            txbTotalAmount.BackColor = Color.Gainsboro;
            txbTotalAmount.Enabled = false;
            txbTotalAmount.Location = new Point(610, 28);
            txbTotalAmount.Name = "txbTotalAmount";
            txbTotalAmount.ReadOnly = true;
            txbTotalAmount.ShortcutsEnabled = false;
            txbTotalAmount.Size = new Size(220, 27);
            txbTotalAmount.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(417, 27);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 11;
            label4.Text = "Tổng thành tiền:";
            // 
            // fListRepair_Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 622);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fListRepair_Detail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DANH SÁCH CHI TIẾT PHIẾU SỬA CHỮA";
            Load += fListRepair_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRepairList_Detail).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvRepairList_Detail;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Button btnClose;
        private DateTimePicker dtpDateFix;
        private Label label3;
        private TextBox txbLicensePlate;
        private TextBox txbIdRepair;
        private Label label6;
        private Label label5;
        private TextBox txbTotalAmount;
        private Label label4;
        private Button btnExport;
    }
}