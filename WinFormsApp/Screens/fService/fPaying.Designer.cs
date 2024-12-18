namespace WinFormsApp.Screens.Service.Paying
{
    partial class fPaying
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
            dtgvPayment = new DataGridView();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel8 = new Panel();
            panel3 = new Panel();
            panel12 = new Panel();
            btnClose = new Button();
            btnPrintBill = new Button();
            btnPayment = new Button();
            panel11 = new Panel();
            lbTotalAmout = new Label();
            label12 = new Label();
            panel6 = new Panel();
            panel10 = new Panel();
            txtEmail = new TextBox();
            label11 = new Label();
            panel9 = new Panel();
            dtpDatePay = new DateTimePicker();
            label10 = new Label();
            panel7 = new Panel();
            txtAmoutPaying = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            lbNameCustomer = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPayment).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 60);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn thanh toán";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dtgvPayment);
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(885, 582);
            panel2.TabIndex = 1;
            // 
            // dtgvPayment
            // 
            dtgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPayment.Dock = DockStyle.Fill;
            dtgvPayment.Location = new Point(0, 0);
            dtgvPayment.Name = "dtgvPayment";
            dtgvPayment.RowHeadersWidth = 51;
            dtgvPayment.Size = new Size(885, 582);
            dtgvPayment.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.ForeColor = SystemColors.Highlight;
            panel4.Location = new Point(0, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(1216, 39);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(891, 8);
            label3.Name = "label3";
            label3.Size = new Size(236, 31);
            label3.TabIndex = 1;
            label3.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 8);
            label2.Name = "label2";
            label2.Size = new Size(210, 31);
            label2.TabIndex = 0;
            label2.Text = "Thông tin sửa chữa";
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
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(3, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(130, 119);
            panel8.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(891, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 582);
            panel3.TabIndex = 4;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnClose);
            panel12.Controls.Add(btnPrintBill);
            panel12.Controls.Add(btnPayment);
            panel12.Location = new Point(5, 412);
            panel12.Name = "panel12";
            panel12.Size = new Size(314, 167);
            panel12.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.AppWorkspace;
            btnClose.Location = new Point(110, 120);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 38);
            btnClose.TabIndex = 2;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.MediumSeaGreen;
            btnPrintBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrintBill.Location = new Point(39, 69);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(238, 45);
            btnPrintBill.TabIndex = 1;
            btnPrintBill.Text = "In hóa đơn";
            btnPrintBill.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = SystemColors.ActiveCaption;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(39, 16);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(238, 47);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(lbTotalAmout);
            panel11.Controls.Add(label12);
            panel11.Location = new Point(5, 339);
            panel11.Name = "panel11";
            panel11.Size = new Size(314, 68);
            panel11.TabIndex = 10;
            // 
            // lbTotalAmout
            // 
            lbTotalAmout.AutoSize = true;
            lbTotalAmout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalAmout.ForeColor = Color.SteelBlue;
            lbTotalAmout.Location = new Point(103, 40);
            lbTotalAmout.Name = "lbTotalAmout";
            lbTotalAmout.Size = new Size(100, 28);
            lbTotalAmout.TabIndex = 1;
            lbTotalAmout.Text = "00000000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(103, 0);
            label12.Name = "label12";
            label12.Size = new Size(95, 28);
            label12.TabIndex = 0;
            label12.Text = "Tổng tiền";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(4, 137);
            panel6.Name = "panel6";
            panel6.Size = new Size(315, 195);
            panel6.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtEmail);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(4, 130);
            panel10.Name = "panel10";
            panel10.Size = new Size(305, 45);
            panel10.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 3);
            txtEmail.MinimumSize = new Size(125, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 30);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "A@gmail.com";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Enabled = false;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(55, 23);
            label11.TabIndex = 1;
            label11.Text = "Email:";
            // 
            // panel9
            // 
            panel9.Controls.Add(dtpDatePay);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(4, 67);
            panel9.Name = "panel9";
            panel9.Size = new Size(305, 45);
            panel9.TabIndex = 3;
            // 
            // dtpDatePay
            // 
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
            panel7.Controls.Add(txtAmoutPaying);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(4, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(305, 45);
            panel7.TabIndex = 2;
            // 
            // txtAmoutPaying
            // 
            txtAmoutPaying.Location = new Point(138, 3);
            txtAmoutPaying.MinimumSize = new Size(125, 30);
            txtAmoutPaying.Name = "txtAmoutPaying";
            txtAmoutPaying.Size = new Size(164, 30);
            txtAmoutPaying.TabIndex = 0;
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
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(lbNameCustomer);
            panel5.Location = new Point(139, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 119);
            panel5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 82);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 2;
            label5.Text = "0909309272";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(7, 40);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 1;
            label4.Text = "94A-06633";
            // 
            // lbNameCustomer
            // 
            lbNameCustomer.AutoSize = true;
            lbNameCustomer.Enabled = false;
            lbNameCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNameCustomer.Location = new Point(7, 0);
            lbNameCustomer.Name = "lbNameCustomer";
            lbNameCustomer.Size = new Size(136, 28);
            lbNameCustomer.TabIndex = 0;
            lbNameCustomer.Text = "Nguyễn Văn A";
            // 
            // fPaying
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 715);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fPaying";
            Text = "fPaying";
            Load += fPaying_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPayment).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dtgvPayment;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private Panel panel3;
        private Panel panel5;
        private Label lbNameCustomer;
        private Panel panel6;
        private TextBox txtAmoutPaying;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel9;
        private DateTimePicker dtpDatePay;
        private Label label10;
        private Panel panel7;
        private Panel panel12;
        private Button btnPayment;
        private Panel panel11;
        private Label lbTotalAmout;
        private Label label12;
        private Panel panel10;
        private TextBox txtEmail;
        private Label label11;
        private Button btnClose;
        private Button btnPrintBill;
    }
}