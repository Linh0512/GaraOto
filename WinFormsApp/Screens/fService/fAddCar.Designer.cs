namespace WinFormsApp.MainScene
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
            dateTimePicker1 = new DateTimePicker();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 82);
            panel1.TabIndex = 0;
            // 
            // lbTiepNhanXe
            // 
            lbTiepNhanXe.Anchor = AnchorStyles.Top;
            lbTiepNhanXe.AutoSize = true;
            lbTiepNhanXe.Font = new Font("Elephant", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTiepNhanXe.Location = new Point(58, 0);
            lbTiepNhanXe.Name = "lbTiepNhanXe";
            lbTiepNhanXe.Size = new Size(450, 77);
            lbTiepNhanXe.TabIndex = 0;
            lbTiepNhanXe.Text = "Tiếp Nhận Xe";
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(cbbTypeOfCar);
            panel2.Controls.Add(txbPhoneNumber);
            panel2.Controls.Add(txbAddress);
            panel2.Controls.Add(txbLicensePlate);
            panel2.Controls.Add(txbNameCarOwner);
            panel2.Location = new Point(58, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 282);
            panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(82, 252);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // cbbTypeOfCar
            // 
            cbbTypeOfCar.FormattingEnabled = true;
            cbbTypeOfCar.Location = new Point(82, 113);
            cbbTypeOfCar.Name = "cbbTypeOfCar";
            cbbTypeOfCar.Size = new Size(250, 28);
            cbbTypeOfCar.TabIndex = 5;
            cbbTypeOfCar.Text = "Hiệu xe";
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Location = new Point(82, 157);
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new Size(250, 27);
            txbPhoneNumber.TabIndex = 4;
            txbPhoneNumber.Text = "Số điện thoại";
            txbPhoneNumber.TextChanged += textBox1_TextChanged;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(82, 202);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(250, 27);
            txbAddress.TabIndex = 3;
            txbAddress.Text = "Địa Chỉ";
            // 
            // txbLicensePlate
            // 
            txbLicensePlate.Location = new Point(82, 67);
            txbLicensePlate.Name = "txbLicensePlate";
            txbLicensePlate.Size = new Size(250, 27);
            txbLicensePlate.TabIndex = 1;
            txbLicensePlate.Text = "Biển số xe";
            // 
            // txbNameCarOwner
            // 
            txbNameCarOwner.Location = new Point(82, 23);
            txbNameCarOwner.Name = "txbNameCarOwner";
            txbNameCarOwner.Size = new Size(250, 27);
            txbNameCarOwner.TabIndex = 0;
            txbNameCarOwner.Text = "Tên Chủ Xe";
            // 
            // panel3
            // 
            panel3.Controls.Add(btClose);
            panel3.Controls.Add(btConfirm);
            panel3.Location = new Point(58, 406);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 84);
            panel3.TabIndex = 2;
            // 
            // btClose
            // 
            btClose.BackColor = Color.IndianRed;
            btClose.Location = new Point(238, 30);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 1;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btConfirm
            // 
            btConfirm.BackColor = Color.DeepSkyBlue;
            btConfirm.Location = new Point(82, 30);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(94, 29);
            btConfirm.TabIndex = 0;
            btConfirm.Text = "Xác nhận";
            btConfirm.UseVisualStyleBackColor = false;
            // 
            // fAddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 502);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private DateTimePicker dateTimePicker1;
        private Panel panel3;
        private Button btClose;
        private Button btConfirm;
    }
}