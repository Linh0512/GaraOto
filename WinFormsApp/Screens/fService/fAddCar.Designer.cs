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
            panel1 = new Panel();
            lbTiepNhanXe = new Label();
            panel2 = new Panel();
            dtpDateReceived = new DateTimePicker();
            cbbTypeOfCar = new ComboBox();
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
            panel1.Controls.Add(lbTiepNhanXe);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 62);
            panel1.TabIndex = 0;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new Font("Elephant", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTiepNhanXe.Location = new Point(51, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(360, 62);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "Tiếp Nhận Xe";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpDateReceived);
            panel2.Controls.Add(cbbTypeOfCar);
            panel2.Controls.Add(txbPhoneNumber);
            panel2.Controls.Add(txbAddress);
            panel2.Controls.Add(txbLicensePlate);
            panel2.Controls.Add(txbNameCarOwner);
            panel2.Location = new Point(51, 77);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 212);
            panel2.TabIndex = 1;
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Location = new Point(72, 189);
            dtpDateReceived.Margin = new Padding(3, 2, 3, 2);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(219, 23);
            dtpDateReceived.TabIndex = 5;
            // 
            // cbbTypeOfCar
            // 
            cbbTypeOfCar.FormattingEnabled = true;
            cbbTypeOfCar.Location = new Point(72, 85);
            cbbTypeOfCar.Margin = new Padding(3, 2, 3, 2);
            cbbTypeOfCar.Name = "cbbTypeOfCar";
            cbbTypeOfCar.Size = new Size(219, 23);
            cbbTypeOfCar.TabIndex = 2;
            cbbTypeOfCar.Text = "Hiệu xe";
            cbbTypeOfCar.SelectedIndexChanged += cbbTypeOfCar_SelectedIndexChanged;
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Location = new Point(72, 118);
            txbPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new Size(219, 23);
            txbPhoneNumber.TabIndex = 3;
            txbPhoneNumber.Text = "Số điện thoại";
            txbPhoneNumber.TextChanged += textBox1_TextChanged;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(72, 152);
            txbAddress.Margin = new Padding(3, 2, 3, 2);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(219, 23);
            txbAddress.TabIndex = 4;
            txbAddress.Text = "Địa Chỉ";
            // 
            // txbLicensePlate
            // 
            txbLicensePlate.Location = new Point(72, 50);
            txbLicensePlate.Margin = new Padding(3, 2, 3, 2);
            txbLicensePlate.Name = "txbLicensePlate";
            txbLicensePlate.Size = new Size(219, 23);
            txbLicensePlate.TabIndex = 1;
            txbLicensePlate.Text = "Biển số xe";
            // 
            // txbNameCarOwner
            // 
            txbNameCarOwner.Location = new Point(72, 17);
            txbNameCarOwner.Margin = new Padding(3, 2, 3, 2);
            txbNameCarOwner.Name = "txbNameCarOwner";
            txbNameCarOwner.Size = new Size(219, 23);
            txbNameCarOwner.TabIndex = 0;
            txbNameCarOwner.Text = "Tên Chủ Xe";
            // 
            // panel3
            // 
            panel3.Controls.Add(btClose);
            panel3.Controls.Add(btConfirm);
            panel3.Location = new Point(51, 304);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 63);
            panel3.TabIndex = 2;
            // 
            // btClose
            // 
            btClose.BackColor = Color.IndianRed;
            btClose.Location = new Point(208, 22);
            btClose.Margin = new Padding(3, 2, 3, 2);
            btClose.Name = "btClose";
            btClose.Size = new Size(82, 22);
            btClose.TabIndex = 1;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btConfirm
            // 
            btConfirm.BackColor = Color.DeepSkyBlue;
            btConfirm.Location = new Point(72, 22);
            btConfirm.Margin = new Padding(3, 2, 3, 2);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(82, 22);
            btConfirm.TabIndex = 0;
            btConfirm.Text = "Xác nhận";
            btConfirm.UseVisualStyleBackColor = false;
            btConfirm.Click += btConfirm_Click;
            // 
            // fAddCar
            // 
            AcceptButton = btConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btClose;
            ClientSize = new Size(486, 376);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fAddCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddNewCar";
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
        private ComboBox cbbTypeOfCar;
        private DateTimePicker dtpDateReceived;
        private Panel panel3;
        private Button btClose;
        private Button btConfirm;
    }
}