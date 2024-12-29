namespace WinFormsApp.Screens.Service.AddCar
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
            panel1 = new System.Windows.Forms.Panel();
            lbTiepNhanXe = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            txbEmail = new System.Windows.Forms.TextBox();
            dtpDateReceived = new System.Windows.Forms.DateTimePicker();
            cbbCarBrandName = new System.Windows.Forms.ComboBox();
            txbPhoneNumber = new System.Windows.Forms.TextBox();
            txbAddress = new System.Windows.Forms.TextBox();
            txbLicensePlate = new System.Windows.Forms.TextBox();
            txbNameCarOwner = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            btClose = new System.Windows.Forms.Button();
            btConfirm = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            panel1.Controls.Add(lbTiepNhanXe);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(478, 71);
            panel1.TabIndex = 0;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbTiepNhanXe.Location = new System.Drawing.Point(102, 9);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new System.Drawing.Size(334, 61);
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
            panel2.Location = new System.Drawing.Point(12, 94);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(450, 323);
            panel2.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new System.Drawing.Point(97, 237);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new System.Drawing.Size(250, 31);
            txbEmail.TabIndex = 5;
            txbEmail.Text = "Email";
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDateReceived.Location = new System.Drawing.Point(97, 279);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new System.Drawing.Size(250, 31);
            dtpDateReceived.TabIndex = 6;
            dtpDateReceived.Value = DateTime.Now;
            dtpDateReceived.ValueChanged += dtpDateReceived_ValueChanged;
            // 
            // cbbCarBrandName
            // 
            cbbCarBrandName.FormattingEnabled = true;
            cbbCarBrandName.Location = new System.Drawing.Point(97, 93);
            cbbCarBrandName.Name = "cbbCarBrandName";
            cbbCarBrandName.Size = new System.Drawing.Size(250, 33);
            cbbCarBrandName.TabIndex = 2;
            cbbCarBrandName.Text = "Hiệu xe";
            cbbCarBrandName.SelectedIndexChanged += cbbTypeOfCar_SelectedIndexChanged;
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Location = new System.Drawing.Point(97, 144);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new System.Drawing.Size(250, 31);
            txbPhoneNumber.TabIndex = 3;
            txbPhoneNumber.Text = "Số điện thoại";
            txbPhoneNumber.TextChanged += textBox1_TextChanged;
            // 
            // txbAddress
            // 
            txbAddress.Location = new System.Drawing.Point(97, 192);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new System.Drawing.Size(250, 31);
            txbAddress.TabIndex = 4;
            txbAddress.Text = "Địa Chỉ";
            // 
            // txbLicensePlate
            // 
            txbLicensePlate.Location = new System.Drawing.Point(97, 47);
            txbLicensePlate.Name = "txbLicensePlate";
            txbLicensePlate.Size = new System.Drawing.Size(250, 31);
            txbLicensePlate.TabIndex = 1;
            txbLicensePlate.Text = "Biển số xe";
            // 
            // txbNameCarOwner
            // 
            txbNameCarOwner.Location = new System.Drawing.Point(97, 3);
            txbNameCarOwner.Name = "txbNameCarOwner";
            txbNameCarOwner.Size = new System.Drawing.Size(250, 31);
            txbNameCarOwner.TabIndex = 0;
            txbNameCarOwner.Text = "Tên Chủ Xe";
            // 
            // panel3
            // 
            panel3.Controls.Add(btClose);
            panel3.Controls.Add(btConfirm);
            panel3.Location = new System.Drawing.Point(12, 423);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(450, 71);
            panel3.TabIndex = 2;
            // 
            // btClose
            // 
            btClose.BackColor = System.Drawing.Color.IndianRed;
            btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btClose.Location = new System.Drawing.Point(253, 18);
            btClose.Name = "btClose";
            btClose.Size = new System.Drawing.Size(94, 38);
            btClose.TabIndex = 1;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btConfirm
            // 
            btConfirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            btConfirm.Location = new System.Drawing.Point(97, 18);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new System.Drawing.Size(94, 38);
            btConfirm.TabIndex = 0;
            btConfirm.Text = "Xác nhận";
            btConfirm.UseVisualStyleBackColor = false;
            btConfirm.Click += btConfirm_Click;
            // 
            // fAddCar
            // 
            AcceptButton = btConfirm;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btClose;
            ClientSize = new System.Drawing.Size(478, 492);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximumSize = new System.Drawing.Size(500, 548);
            MinimumSize = new System.Drawing.Size(500, 548);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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