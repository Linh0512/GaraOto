﻿namespace WinFormsApp.Screens.Service.AddCar
{
    partial class fAddCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddCar));
            panel1 = new Panel();
            lbTiepNhanXe = new Label();
            panel2 = new Panel();
            txbEmail = new TextBox();
            dtpDateReceived = new DateTimePicker();
            cbbCarBrandName = new ComboBox();
            txbPhoneNumber = new TextBox();
            txbAddress = new TextBox();
            txbLicensePlate = new TextBox();
            txbNameCarOwner = new TextBox();
            panel3 = new Panel();
            btClose = new Button();
            btConfirm = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(lbTiepNhanXe);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 57);
            panel1.TabIndex = 0;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTiepNhanXe.Location = new Point(84, 7);
            lbTiepNhanXe.Margin = new Padding(2, 0, 2, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(275, 50);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "TIẾP NHẬN XE";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbEmail);
            panel2.Controls.Add(dtpDateReceived);
            panel2.Controls.Add(cbbCarBrandName);
            panel2.Controls.Add(txbPhoneNumber);
            panel2.Controls.Add(txbAddress);
            panel2.Controls.Add(txbLicensePlate);
            panel2.Controls.Add(txbNameCarOwner);
            panel2.Location = new Point(10, 75);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 296);
            panel2.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(75, 208);
            txbEmail.Margin = new Padding(2, 2, 2, 2);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(269, 27);
            txbEmail.TabIndex = 5;
            txbEmail.Text = "Email";
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Format = DateTimePickerFormat.Short;
            dtpDateReceived.Location = new Point(75, 250);
            dtpDateReceived.Margin = new Padding(2, 2, 2, 2);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(269, 27);
            dtpDateReceived.TabIndex = 6;
            dtpDateReceived.Value = new DateTime(2024, 12, 29, 13, 56, 38, 364);
            dtpDateReceived.ValueChanged += dtpDateReceived_ValueChanged;
            // 
            // cbbCarBrandName
            // 
            cbbCarBrandName.FormattingEnabled = true;
            cbbCarBrandName.Location = new Point(75, 92);
            cbbCarBrandName.Margin = new Padding(2, 2, 2, 2);
            cbbCarBrandName.Name = "cbbCarBrandName";
            cbbCarBrandName.Size = new Size(269, 28);
            cbbCarBrandName.TabIndex = 2;
            cbbCarBrandName.Text = "Hiệu xe";
            cbbCarBrandName.SelectedIndexChanged += cbbTypeOfCar_SelectedIndexChanged;
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Location = new Point(75, 133);
            txbPhoneNumber.Margin = new Padding(2, 2, 2, 2);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new Size(269, 27);
            txbPhoneNumber.TabIndex = 3;
            txbPhoneNumber.Text = "Số điện thoại";
            txbPhoneNumber.TextChanged += textBox1_TextChanged;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(75, 172);
            txbAddress.Margin = new Padding(2, 2, 2, 2);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(269, 27);
            txbAddress.TabIndex = 4;
            txbAddress.Text = "Địa Chỉ";
            // 
            // txbLicensePlate
            // 
            txbLicensePlate.Location = new Point(75, 56);
            txbLicensePlate.Margin = new Padding(2, 2, 2, 2);
            txbLicensePlate.Name = "txbLicensePlate";
            txbLicensePlate.Size = new Size(269, 27);
            txbLicensePlate.TabIndex = 1;
            txbLicensePlate.Text = "Biển số xe";
            // 
            // txbNameCarOwner
            // 
            txbNameCarOwner.Location = new Point(75, 20);
            txbNameCarOwner.Margin = new Padding(2, 2, 2, 2);
            txbNameCarOwner.Name = "txbNameCarOwner";
            txbNameCarOwner.Size = new Size(269, 27);
            txbNameCarOwner.TabIndex = 0;
            txbNameCarOwner.Text = "Tên Chủ Xe";
            // 
            // panel3
            // 
            panel3.Controls.Add(btClose);
            panel3.Controls.Add(btConfirm);
            panel3.Location = new Point(10, 375);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 77);
            panel3.TabIndex = 2;
            // 
            // btClose
            // 
            btClose.BackColor = Color.IndianRed;
            btClose.DialogResult = DialogResult.Cancel;
            btClose.Location = new Point(248, 16);
            btClose.Margin = new Padding(2, 2, 2, 2);
            btClose.Name = "btClose";
            btClose.Size = new Size(101, 45);
            btClose.TabIndex = 1;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btConfirm
            // 
            btConfirm.BackColor = Color.DeepSkyBlue;
            btConfirm.Location = new Point(78, 16);
            btConfirm.Margin = new Padding(2, 2, 2, 2);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(104, 45);
            btConfirm.TabIndex = 0;
            btConfirm.Text = "Xác nhận";
            btConfirm.UseVisualStyleBackColor = false;
            btConfirm.Click += btConfirm_Click;
            // 
            // fAddCar
            // 
            AcceptButton = btConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btClose;
            ClientSize = new Size(452, 463);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(404, 448);
            Name = "fAddCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TIẾP NHẬN XE";
            Load += fAddCar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTiepNhanXe;
        private Panel panel2;
        private TextBox txbNameCarOwner;
        private TextBox txbAddress;
        private TextBox txbLicensePlate;
        private TextBox txbPhoneNumber;
        private ComboBox cbbCarBrandName;
        private System.Windows.Forms.DateTimePicker dtpDateReceived;
        private Panel panel3;
        private Button btClose;
        private Button btConfirm;
        private TextBox txbEmail;
    }
}