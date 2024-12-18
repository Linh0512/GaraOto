namespace WinFormsApp.Screens.Service.InforCar
{
    partial class fInforCar
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
            btnChangeInfo = new Button();
            label16 = new Label();
            panel11 = new Panel();
            label15 = new Label();
            dtpDateFix = new DateTimePicker();
            panel10 = new Panel();
            label14 = new Label();
            dtpDateReceived = new DateTimePicker();
            panel9 = new Panel();
            lbDebt = new Label();
            label13 = new Label();
            pictureBox6 = new PictureBox();
            panel8 = new Panel();
            lbAddress = new Label();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            lbPhone = new Label();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            lbCarBrand = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            lbPlateLicense = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            lbCustomerName = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dtgvServiceCar = new DataGridView();
            CellWage = new DataGridViewTextBoxColumn();
            cellItem = new DataGridViewTextBoxColumn();
            cellQuantity = new DataGridViewTextBoxColumn();
            cellPricePerUnit = new DataGridViewTextBoxColumn();
            cellWagePrice = new DataGridViewTextBoxColumn();
            cellTotalMoney = new DataGridViewTextBoxColumn();
            btnAddService = new Button();
            panel12 = new Panel();
            btnChangeService = new Button();
            btnDelService = new Button();
            panel13 = new Panel();
            btnCLose = new Button();
            btnPay = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvServiceCar).BeginInit();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(365, 46);
            label1.TabIndex = 0;
            label1.Text = "Thông tin và dịch vụ xe";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(btnChangeInfo);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 79);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 693);
            panel2.TabIndex = 1;
            // 
            // btnChangeInfo
            // 
            btnChangeInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnChangeInfo.BackColor = Color.AliceBlue;
            btnChangeInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangeInfo.Location = new Point(52, 609);
            btnChangeInfo.Margin = new Padding(4);
            btnChangeInfo.Name = "btnChangeInfo";
            btnChangeInfo.Size = new Size(183, 59);
            btnChangeInfo.TabIndex = 9;
            btnChangeInfo.Text = "Thay đổi thông tin";
            btnChangeInfo.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Beige;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(52, 4);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(182, 31);
            label16.TabIndex = 8;
            label16.Text = "Thông tin chung";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel11.BackColor = SystemColors.Control;
            panel11.Controls.Add(label15);
            panel11.Controls.Add(dtpDateFix);
            panel11.Location = new Point(8, 538);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(284, 64);
            panel11.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(6, 6);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(107, 20);
            label15.TabIndex = 1;
            label15.Text = "Ngày sửa chữa";
            // 
            // dtpDateFix
            // 
            dtpDateFix.Location = new Point(4, 29);
            dtpDateFix.Margin = new Padding(4);
            dtpDateFix.Name = "dtpDateFix";
            dtpDateFix.Size = new Size(228, 27);
            dtpDateFix.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = SystemColors.Control;
            panel10.Controls.Add(label14);
            panel10.Controls.Add(dtpDateReceived);
            panel10.Location = new Point(8, 466);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(284, 64);
            panel10.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(6, 6);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(110, 20);
            label14.TabIndex = 1;
            label14.Text = "Ngày tiếp nhận";
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Location = new Point(4, 29);
            dtpDateReceived.Margin = new Padding(4);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(228, 27);
            dtpDateReceived.TabIndex = 0;
            dtpDateReceived.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = SystemColors.Control;
            panel9.Controls.Add(lbDebt);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(pictureBox6);
            panel9.Location = new Point(8, 394);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(284, 62);
            panel9.TabIndex = 5;
            // 
            // lbDebt
            // 
            lbDebt.AutoSize = true;
            lbDebt.BackColor = SystemColors.ButtonShadow;
            lbDebt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDebt.Location = new Point(76, 24);
            lbDebt.Margin = new Padding(4, 0, 4, 0);
            lbDebt.Name = "lbDebt";
            lbDebt.Size = new Size(114, 25);
            lbDebt.TabIndex = 2;
            lbDebt.Text = "Trần Qui Linh";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(76, 4);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 1;
            label13.Text = "Tổng tiền nợ";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.user_icon;
            pictureBox6.Location = new Point(4, 4);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(lbAddress);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(pictureBox5);
            panel8.Location = new Point(8, 324);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(284, 62);
            panel8.TabIndex = 4;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.BackColor = SystemColors.ButtonShadow;
            lbAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(76, 24);
            lbAddress.Margin = new Padding(4, 0, 4, 0);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(114, 25);
            lbAddress.TabIndex = 2;
            lbAddress.Text = "Trần Qui Linh";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(76, 4);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 1;
            label11.Text = "Địa chỉ";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.address_icon;
            pictureBox5.Location = new Point(4, 4);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(lbPhone);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(pictureBox4);
            panel7.Location = new Point(8, 253);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 62);
            panel7.TabIndex = 3;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.BackColor = SystemColors.ButtonShadow;
            lbPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(76, 24);
            lbPhone.Margin = new Padding(4, 0, 4, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(114, 25);
            lbPhone.TabIndex = 2;
            lbPhone.Text = "Trần Qui Linh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(76, 4);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 1;
            label9.Text = "Số điện thoại";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.phonenumber_icon;
            pictureBox4.Location = new Point(4, 4);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(lbCarBrand);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(8, 182);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 62);
            panel6.TabIndex = 3;
            // 
            // lbCarBrand
            // 
            lbCarBrand.AutoSize = true;
            lbCarBrand.BackColor = SystemColors.ButtonShadow;
            lbCarBrand.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCarBrand.Location = new Point(76, 24);
            lbCarBrand.Margin = new Padding(4, 0, 4, 0);
            lbCarBrand.Name = "lbCarBrand";
            lbCarBrand.Size = new Size(114, 25);
            lbCarBrand.TabIndex = 2;
            lbCarBrand.Text = "Trần Qui Linh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(76, 4);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 1;
            label7.Text = "Hiệu xe";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user_icon;
            pictureBox3.Location = new Point(4, 4);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(lbPlateLicense);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(8, 112);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 62);
            panel5.TabIndex = 1;
            // 
            // lbPlateLicense
            // 
            lbPlateLicense.AutoSize = true;
            lbPlateLicense.BackColor = SystemColors.ButtonShadow;
            lbPlateLicense.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPlateLicense.Location = new Point(76, 24);
            lbPlateLicense.Margin = new Padding(4, 0, 4, 0);
            lbPlateLicense.Name = "lbPlateLicense";
            lbPlateLicense.Size = new Size(114, 25);
            lbPlateLicense.TabIndex = 2;
            lbPlateLicense.Text = "Trần Qui Linh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(76, 4);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 1;
            label5.Text = "Biển số xe";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_icon;
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(lbCustomerName);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(8, 41);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 62);
            panel4.TabIndex = 0;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.BackColor = SystemColors.ButtonShadow;
            lbCustomerName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomerName.Location = new Point(76, 24);
            lbCustomerName.Margin = new Padding(4, 0, 4, 0);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(114, 25);
            lbCustomerName.TabIndex = 2;
            lbCustomerName.Text = "Trần Qui Linh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(76, 4);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên chủ xe";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dtgvServiceCar);
            panel3.Location = new Point(296, 79);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 601);
            panel3.TabIndex = 2;
            // 
            // dtgvServiceCar
            // 
            dtgvServiceCar.AllowUserToAddRows = false;
            dtgvServiceCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgvServiceCar.BackgroundColor = SystemColors.Control;
            dtgvServiceCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvServiceCar.Columns.AddRange(new DataGridViewColumn[] { CellWage, cellItem, cellQuantity, cellPricePerUnit, cellWagePrice, cellTotalMoney });
            dtgvServiceCar.GridColor = SystemColors.ActiveBorder;
            dtgvServiceCar.Location = new Point(7, 0);
            dtgvServiceCar.Margin = new Padding(4);
            dtgvServiceCar.Name = "dtgvServiceCar";
            dtgvServiceCar.RowHeadersWidth = 82;
            dtgvServiceCar.Size = new Size(827, 601);
            dtgvServiceCar.TabIndex = 0;
            dtgvServiceCar.CellContentClick += dtgvServiceCar_CellContentClick;
            // 
            // CellWage
            // 
            CellWage.HeaderText = "Nội dung";
            CellWage.MinimumWidth = 6;
            CellWage.Name = "CellWage";
            CellWage.Width = 125;
            // 
            // cellItem
            // 
            cellItem.HeaderText = "Vật tư";
            cellItem.MinimumWidth = 6;
            cellItem.Name = "cellItem";
            cellItem.Width = 125;
            // 
            // cellQuantity
            // 
            cellQuantity.HeaderText = "Số lượng";
            cellQuantity.MinimumWidth = 6;
            cellQuantity.Name = "cellQuantity";
            cellQuantity.Width = 125;
            // 
            // cellPricePerUnit
            // 
            cellPricePerUnit.HeaderText = "Đơn giá";
            cellPricePerUnit.MinimumWidth = 6;
            cellPricePerUnit.Name = "cellPricePerUnit";
            cellPricePerUnit.Width = 125;
            // 
            // cellWagePrice
            // 
            cellWagePrice.HeaderText = "Tiền công";
            cellWagePrice.MinimumWidth = 6;
            cellWagePrice.Name = "cellWagePrice";
            cellWagePrice.Width = 125;
            // 
            // cellTotalMoney
            // 
            cellTotalMoney.HeaderText = "Thành tiền";
            cellTotalMoney.MinimumWidth = 6;
            cellTotalMoney.Name = "cellTotalMoney";
            cellTotalMoney.Width = 125;
            // 
            // btnAddService
            // 
            btnAddService.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddService.BackColor = Color.AliceBlue;
            btnAddService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddService.Location = new Point(4, 4);
            btnAddService.Margin = new Padding(4);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(88, 54);
            btnAddService.TabIndex = 10;
            btnAddService.Text = "Thêm";
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += AddService_Click;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel12.Controls.Add(btnChangeService);
            panel12.Controls.Add(btnDelService);
            panel12.Controls.Add(btnAddService);
            panel12.Location = new Point(300, 688);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(364, 62);
            panel12.TabIndex = 3;
            // 
            // btnChangeService
            // 
            btnChangeService.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnChangeService.BackColor = Color.AliceBlue;
            btnChangeService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangeService.Location = new Point(239, 4);
            btnChangeService.Margin = new Padding(4);
            btnChangeService.Name = "btnChangeService";
            btnChangeService.Size = new Size(88, 54);
            btnChangeService.TabIndex = 12;
            btnChangeService.Text = "Sửa";
            btnChangeService.UseVisualStyleBackColor = false;
            btnChangeService.Click += button4_Click;
            // 
            // btnDelService
            // 
            btnDelService.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelService.BackColor = Color.AliceBlue;
            btnDelService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelService.Location = new Point(122, 2);
            btnDelService.Margin = new Padding(4);
            btnDelService.Name = "btnDelService";
            btnDelService.Size = new Size(88, 54);
            btnDelService.TabIndex = 11;
            btnDelService.Text = "Xóa";
            btnDelService.UseVisualStyleBackColor = false;
            btnDelService.Click += btnDelService_Click;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel13.Controls.Add(btnCLose);
            panel13.Controls.Add(btnPay);
            panel13.Location = new Point(760, 688);
            panel13.Margin = new Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new Size(364, 62);
            panel13.TabIndex = 4;
            // 
            // btnCLose
            // 
            btnCLose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCLose.BackColor = Color.SandyBrown;
            btnCLose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCLose.Location = new Point(257, 2);
            btnCLose.Margin = new Padding(4);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(88, 54);
            btnCLose.TabIndex = 11;
            btnCLose.Text = "Đóng";
            btnCLose.UseVisualStyleBackColor = false;
            btnCLose.Click += btnClose_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPay.BackColor = SystemColors.ActiveCaption;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(52, 4);
            btnPay.Margin = new Padding(4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(121, 54);
            btnPay.TabIndex = 10;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // fInforCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 753);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximumSize = new Size(1148, 800);
            MinimumSize = new Size(1148, 800);
            Name = "fInforCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin dịch vụ";
            Load += fInforCar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvServiceCar).EndInit();
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel10;
        public DateTimePicker dtpDateReceived;
        private Panel panel9;
        public Label lbDebt;
        private Label label13;
        private PictureBox pictureBox6;
        private Panel panel8;
        public Label lbAddress;
        private Label label11;
        private PictureBox pictureBox5;
        private Panel panel7;
        public Label lbPhone;
        private Label label9;
        private PictureBox pictureBox4;
        private Panel panel6;
        public Label lbCarBrand;
        private Label label7;
        private PictureBox pictureBox3;
        private Panel panel5;
        public Label lbPlateLicense;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel4;
        public Label lbCustomerName;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        public DataGridView dtgvServiceCar;
        private Label label14;
        private Label label16;
        private Panel panel11;
        private Label label15;
        public DateTimePicker dtpDateFix;
        private Button btnChangeInfo;
        private Panel panel12;
        private Button btnChangeService;
        private Button btnDelService;
        private Panel panel13;
        private Button btnCLose;
        private Button btnPay;
        private Button btnAddService;
        private DataGridViewTextBoxColumn CellWage;
        private DataGridViewTextBoxColumn cellItem;
        private DataGridViewTextBoxColumn cellQuantity;
        private DataGridViewTextBoxColumn cellPricePerUnit;
        private DataGridViewTextBoxColumn cellWagePrice;
        private DataGridViewTextBoxColumn cellTotalMoney;
    }
}