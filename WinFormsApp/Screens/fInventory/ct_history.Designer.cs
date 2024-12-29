namespace WinFormsApp.Screens.fInventory
{
    partial class ct_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ct_history));
            dgvCTPN = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtMaPN = new TextBox();
            label2 = new Label();
            datetimepiker = new DateTimePicker();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            txbTotalAmount = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCTPN
            // 
            dgvCTPN.AllowUserToAddRows = false;
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPN.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvCTPN.Location = new Point(2, 143);
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.RowHeadersWidth = 51;
            dgvCTPN.Size = new Size(1013, 443);
            dgvCTPN.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã VTPT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên VTPT";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá nhập";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 96);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã phiếu nhập:";
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(248, 97);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(229, 27);
            txtMaPN.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(527, 99);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 3;
            label2.Text = "Ngày nhập:";
            // 
            // datetimepiker
            // 
            datetimepiker.Location = new Point(668, 99);
            datetimepiker.Name = "datetimepiker";
            datetimepiker.Size = new Size(276, 27);
            datetimepiker.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(857, 613);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 5;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 72);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(126, 9);
            label3.Name = "label3";
            label3.Size = new Size(753, 50);
            label3.TabIndex = 0;
            label3.Text = "CHI TIẾT PHIẾU NHẬP VẬT TƯ PHỤ TÙNG";
            // 
            // txbTotalAmount
            // 
            txbTotalAmount.Anchor = AnchorStyles.Top;
            txbTotalAmount.BackColor = Color.Gainsboro;
            txbTotalAmount.Enabled = false;
            txbTotalAmount.Location = new Point(393, 614);
            txbTotalAmount.Name = "txbTotalAmount";
            txbTotalAmount.ReadOnly = true;
            txbTotalAmount.ShortcutsEnabled = false;
            txbTotalAmount.Size = new Size(220, 27);
            txbTotalAmount.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(200, 613);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 15;
            label4.Text = "Tổng thành tiền:";
            // 
            // ct_history
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 673);
            Controls.Add(txbTotalAmount);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(datetimepiker);
            Controls.Add(label2);
            Controls.Add(txtMaPN);
            Controls.Add(label1);
            Controls.Add(dgvCTPN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1035, 720);
            MinimumSize = new Size(1035, 720);
            Name = "ct_history";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHI TIẾT PHIẾU NHẬP VẬT TƯ PHỤ TÙNG";
            Load += ct_history_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCTPN;
        private Label label1;
        private TextBox txtMaPN;
        private Label label2;
        private DateTimePicker datetimepiker;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panel1;
        private Label label3;
        private TextBox txbTotalAmount;
        private Label label4;
    }
}