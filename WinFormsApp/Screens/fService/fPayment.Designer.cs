namespace WinFormsApp.Screens.Service.Payment
{
    partial class fPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPayment));
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel8 = new Panel();
            panel3 = new Panel();
            panel11 = new Panel();
            txbDebt = new TextBox();
            txbTheRest = new TextBox();
            label5 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            panel2 = new Panel();
            txbIdReceipt = new TextBox();
            label2 = new Label();
            panel9 = new Panel();
            dtpDatePay = new DateTimePicker();
            label10 = new Label();
            panel7 = new Panel();
            txtAmoutPaying = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            lbPhoneNumber = new Label();
            lbPlateLicense = new Label();
            lbNameCustomer = new Label();
            panel12 = new Panel();
            btnClose = new Button();
            btnPay = new Button();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(369, 60);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU THU TIỀN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 85);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 6;
            label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 43);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 5;
            label8.Text = "Biển số xe:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 4;
            label9.Text = "Tên chủ xe:";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(3, 27);
            panel8.Name = "panel8";
            panel8.Size = new Size(174, 119);
            panel8.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(12, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 451);
            panel3.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.Controls.Add(txbDebt);
            panel11.Controls.Add(txbTheRest);
            panel11.Controls.Add(label5);
            panel11.Controls.Add(label12);
            panel11.Location = new Point(3, 336);
            panel11.Name = "panel11";
            panel11.Size = new Size(428, 100);
            panel11.TabIndex = 10;
            // 
            // txbDebt
            // 
            txbDebt.Enabled = false;
            txbDebt.Location = new Point(272, 12);
            txbDebt.Name = "txbDebt";
            txbDebt.Size = new Size(125, 27);
            txbDebt.TabIndex = 5;
            // 
            // txbTheRest
            // 
            txbTheRest.Enabled = false;
            txbTheRest.Location = new Point(272, 60);
            txbTheRest.Multiline = true;
            txbTheRest.Name = "txbTheRest";
            txbTheRest.Size = new Size(125, 27);
            txbTheRest.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(52, 60);
            label5.Name = "label5";
            label5.Size = new Size(210, 28);
            label5.TabIndex = 2;
            label5.Text = "Tiền nợ còn lại sau thu:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(52, 12);
            label12.Name = "label12";
            label12.Size = new Size(80, 28);
            label12.TabIndex = 0;
            label12.Text = "Tiền nợ:";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(3, 152);
            panel6.Name = "panel6";
            panel6.Size = new Size(428, 178);
            panel6.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(txbIdReceipt);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(56, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 45);
            panel2.TabIndex = 4;
            // 
            // txbIdReceipt
            // 
            txbIdReceipt.Enabled = false;
            txbIdReceipt.Location = new Point(138, 3);
            txbIdReceipt.MinimumSize = new Size(125, 30);
            txbIdReceipt.Name = "txbIdReceipt";
            txbIdReceipt.Size = new Size(164, 30);
            txbIdReceipt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã phiếu thu:";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.Controls.Add(dtpDatePay);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(56, 66);
            panel9.Name = "panel9";
            panel9.Size = new Size(314, 45);
            panel9.TabIndex = 3;
            // 
            // dtpDatePay
            // 
            dtpDatePay.Enabled = false;
            dtpDatePay.Format = DateTimePickerFormat.Short;
            dtpDatePay.Location = new Point(138, 7);
            dtpDatePay.Name = "dtpDatePay";
            dtpDatePay.Size = new Size(164, 27);
            dtpDatePay.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Enabled = false;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(119, 23);
            label10.TabIndex = 2;
            label10.Text = "Ngày thu tiền:";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(txtAmoutPaying);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(56, 130);
            panel7.Name = "panel7";
            panel7.Size = new Size(314, 45);
            panel7.TabIndex = 2;
            // 
            // txtAmoutPaying
            // 
            txtAmoutPaying.Location = new Point(138, 3);
            txtAmoutPaying.MinimumSize = new Size(125, 30);
            txtAmoutPaying.Name = "txtAmoutPaying";
            txtAmoutPaying.Size = new Size(164, 30);
            txtAmoutPaying.TabIndex = 0;
            txtAmoutPaying.TextChanged += txtAmoutPaying_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 1;
            label6.Text = "Số tiền thu:";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(lbPhoneNumber);
            panel5.Controls.Add(lbPlateLicense);
            panel5.Controls.Add(lbNameCustomer);
            panel5.Location = new Point(183, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 119);
            panel5.TabIndex = 8;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Enabled = false;
            lbPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPhoneNumber.Location = new Point(19, 82);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(122, 28);
            lbPhoneNumber.TabIndex = 2;
            lbPhoneNumber.Text = "0909309272";
            // 
            // lbPlateLicense
            // 
            lbPlateLicense.AutoSize = true;
            lbPlateLicense.Enabled = false;
            lbPlateLicense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPlateLicense.ForeColor = SystemColors.ControlText;
            lbPlateLicense.Location = new Point(19, 40);
            lbPlateLicense.Name = "lbPlateLicense";
            lbPlateLicense.Size = new Size(110, 28);
            lbPlateLicense.TabIndex = 1;
            lbPlateLicense.Text = "94A-06633";
            // 
            // lbNameCustomer
            // 
            lbNameCustomer.AutoSize = true;
            lbNameCustomer.Enabled = false;
            lbNameCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameCustomer.Location = new Point(19, 0);
            lbNameCustomer.Name = "lbNameCustomer";
            lbNameCustomer.Size = new Size(136, 28);
            lbNameCustomer.TabIndex = 0;
            lbNameCustomer.Text = "Nguyễn Văn A";
            // 
            // panel12
            // 
            panel12.Controls.Add(btnClose);
            panel12.Controls.Add(btnPay);
            panel12.Location = new Point(74, 555);
            panel12.Name = "panel12";
            panel12.Size = new Size(314, 59);
            panel12.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.AppWorkspace;
            btnClose.Location = new Point(220, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 48);
            btnClose.TabIndex = 2;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = SystemColors.ActiveCaption;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(6, 3);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(165, 47);
            btnPay.TabIndex = 0;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPaying_Click;
            // 
            // fPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 626);
            Controls.Add(panel12);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fPayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HÓA ĐƠN THANH TOÁN";
            Load += fPaying_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private Panel panel3;
        private Panel panel5;
        public Label lbNameCustomer;
        private Panel panel6;
        public TextBox txtAmoutPaying;
        private Label label6;
        public Label lbPhoneNumber;
        public Label lbPlateLicense;
        private Panel panel9;
        public DateTimePicker dtpDatePay;
        private Label label10;
        private Panel panel7;
        private Panel panel12;
        private Button btnPay;
        private Panel panel11;
        private Label label12;
        private Button btnClose;
        private Label label5;
        private Panel panel2;
        public TextBox txbIdReceipt;
        private Label label2;
        public TextBox txbDebt;
        public TextBox txbTheRest;
    }
}