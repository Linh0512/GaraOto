using System.Windows.Forms;

namespace WinFormsApp
{
    partial class fOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOption));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblSupplierDetail = new Label();
            lblAccount = new Label();
            lblWageDetail = new Label();
            lblGarageDetail = new Label();
            lblBrandDetail = new Label();
            pnlYourProfile = new Panel();
            button1 = new Button();
            btnUpdatePassword = new Button();
            btnChange = new Button();
            picEmail = new PictureBox();
            picPhoneNumber = new PictureBox();
            picAddress = new PictureBox();
            picBirthdate = new PictureBox();
            picUsername = new PictureBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtBirthdate = new TextBox();
            txtUsername = new TextBox();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            lblBirthdate = new Label();
            lblUsername = new Label();
            pnlWageDetail = new Panel();
            lblWageAmount = new Label();
            dgvWageDetail = new DataGridView();
            btnRemoveWage = new Button();
            btnEditWage = new Button();
            btnAddWage = new Button();
            btnExportWage = new Button();
            btnRefreshWage = new Button();
            btnSearchWage = new Button();
            txtWageAmount = new TextBox();
            txtWageType = new TextBox();
            lblWageType = new Label();
            pnlGarageDetail = new Panel();
            btnUndoCarLimit = new Button();
            btnChangeCarLimit = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            lblCarLimit = new Label();
            picCar = new PictureBox();
            pnlBrandDetail = new Panel();
            btnRemoveBrand = new Button();
            btnEditBrand = new Button();
            btnAddBrand = new Button();
            btnExportBrand = new Button();
            btnRefreshBrand = new Button();
            btnSearchBrand = new Button();
            txtBrandName = new TextBox();
            lblBrandName = new Label();
            dgvBrandDetail = new DataGridView();
            pnlSupplierDetail = new Panel();
            txtSupplierPhoneNumber = new TextBox();
            lblSupplierEmail = new Label();
            lblSupplierPhoneNumber = new Label();
            dataGridView1 = new DataGridView();
            btnRemoveSupplier = new Button();
            btnEditSupplier = new Button();
            btnAddSupplier = new Button();
            btnExportSupplier = new Button();
            btnRefreshSupplier = new Button();
            btnSearchSupplier = new Button();
            txtSupplierName = new TextBox();
            lblSupplierName = new Label();
            txtSupplierEmail = new TextBox();
            panel1.SuspendLayout();
            pnlYourProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBirthdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            pnlWageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWageDetail).BeginInit();
            pnlGarageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            pnlBrandDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrandDetail).BeginInit();
            pnlSupplierDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblSupplierDetail);
            panel1.Controls.Add(lblAccount);
            panel1.Controls.Add(lblWageDetail);
            panel1.Controls.Add(lblGarageDetail);
            panel1.Controls.Add(lblBrandDetail);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 72);
            panel1.TabIndex = 0;
            // 
            // lblSupplierDetail
            // 
            lblSupplierDetail.AutoSize = true;
            lblSupplierDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierDetail.ForeColor = Color.White;
            lblSupplierDetail.Location = new Point(903, 24);
            lblSupplierDetail.Margin = new Padding(2, 0, 2, 0);
            lblSupplierDetail.Name = "lblSupplierDetail";
            lblSupplierDetail.Size = new Size(187, 31);
            lblSupplierDetail.TabIndex = 22;
            lblSupplierDetail.Text = "NHÀ CUNG CẤP";
            lblSupplierDetail.Click += lblSupplierDetail_Click;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.White;
            lblAccount.Location = new Point(52, 24);
            lblAccount.Margin = new Padding(2, 0, 2, 0);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(139, 31);
            lblAccount.TabIndex = 18;
            lblAccount.Text = "TÀI KHOẢN";
            lblAccount.Click += lblAccount_Click;
            // 
            // lblWageDetail
            // 
            lblWageDetail.AutoSize = true;
            lblWageDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWageDetail.ForeColor = Color.White;
            lblWageDetail.Location = new Point(498, 24);
            lblWageDetail.Margin = new Padding(2, 0, 2, 0);
            lblWageDetail.Name = "lblWageDetail";
            lblWageDetail.Size = new Size(134, 31);
            lblWageDetail.TabIndex = 20;
            lblWageDetail.Text = "TIỀN CÔNG";
            lblWageDetail.Click += lblWageDetail_Click;
            // 
            // lblGarageDetail
            // 
            lblGarageDetail.AutoSize = true;
            lblGarageDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGarageDetail.ForeColor = Color.White;
            lblGarageDetail.Location = new Point(293, 24);
            lblGarageDetail.Margin = new Padding(2, 0, 2, 0);
            lblGarageDetail.Name = "lblGarageDetail";
            lblGarageDetail.Size = new Size(105, 31);
            lblGarageDetail.TabIndex = 19;
            lblGarageDetail.Text = "GARAGE";
            lblGarageDetail.Click += lblGarageDetail_Click;
            // 
            // lblBrandDetail
            // 
            lblBrandDetail.AutoSize = true;
            lblBrandDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandDetail.ForeColor = Color.White;
            lblBrandDetail.Location = new Point(721, 24);
            lblBrandDetail.Margin = new Padding(2, 0, 2, 0);
            lblBrandDetail.Name = "lblBrandDetail";
            lblBrandDetail.Size = new Size(82, 31);
            lblBrandDetail.TabIndex = 21;
            lblBrandDetail.Text = "HÃNG";
            lblBrandDetail.Click += lblBrandDetail_Click;
            // 
            // pnlYourProfile
            // 
            pnlYourProfile.BackColor = SystemColors.ControlLightLight;
            pnlYourProfile.Controls.Add(button1);
            pnlYourProfile.Controls.Add(btnUpdatePassword);
            pnlYourProfile.Controls.Add(btnChange);
            pnlYourProfile.Controls.Add(picEmail);
            pnlYourProfile.Controls.Add(picPhoneNumber);
            pnlYourProfile.Controls.Add(picAddress);
            pnlYourProfile.Controls.Add(picBirthdate);
            pnlYourProfile.Controls.Add(picUsername);
            pnlYourProfile.Controls.Add(txtEmail);
            pnlYourProfile.Controls.Add(txtPhoneNumber);
            pnlYourProfile.Controls.Add(txtAddress);
            pnlYourProfile.Controls.Add(txtBirthdate);
            pnlYourProfile.Controls.Add(txtUsername);
            pnlYourProfile.Controls.Add(lblEmail);
            pnlYourProfile.Controls.Add(lblPhoneNumber);
            pnlYourProfile.Controls.Add(lblAddress);
            pnlYourProfile.Controls.Add(lblBirthdate);
            pnlYourProfile.Controls.Add(lblUsername);
            pnlYourProfile.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlYourProfile.Location = new Point(1, 76);
            pnlYourProfile.Margin = new Padding(2);
            pnlYourProfile.Name = "pnlYourProfile";
            pnlYourProfile.Size = new Size(1112, 642);
            pnlYourProfile.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(498, 469);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(113, 42);
            button1.TabIndex = 17;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.Teal;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = Color.White;
            btnUpdatePassword.Location = new Point(786, 362);
            btnUpdatePassword.Margin = new Padding(2);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(167, 42);
            btnUpdatePassword.TabIndex = 16;
            btnUpdatePassword.Text = "Đổi mật khẩu";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Teal;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(639, 362);
            btnChange.Margin = new Padding(2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(101, 42);
            btnChange.TabIndex = 15;
            btnChange.Text = "Sửa";
            btnChange.UseVisualStyleBackColor = false;
            // 
            // picEmail
            // 
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(639, 181);
            picEmail.Margin = new Padding(2);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(97, 98);
            picEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmail.TabIndex = 14;
            picEmail.TabStop = false;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Image = (Image)resources.GetObject("picPhoneNumber.Image");
            picPhoneNumber.Location = new Point(639, 49);
            picPhoneNumber.Margin = new Padding(2);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.Size = new Size(97, 98);
            picPhoneNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoneNumber.TabIndex = 13;
            picPhoneNumber.TabStop = false;
            // 
            // picAddress
            // 
            picAddress.Image = (Image)resources.GetObject("picAddress.Image");
            picAddress.Location = new Point(151, 307);
            picAddress.Margin = new Padding(2);
            picAddress.Name = "picAddress";
            picAddress.Size = new Size(97, 98);
            picAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            picAddress.TabIndex = 12;
            picAddress.TabStop = false;
            // 
            // picBirthdate
            // 
            picBirthdate.Image = (Image)resources.GetObject("picBirthdate.Image");
            picBirthdate.Location = new Point(151, 181);
            picBirthdate.Margin = new Padding(2);
            picBirthdate.Name = "picBirthdate";
            picBirthdate.Size = new Size(97, 98);
            picBirthdate.SizeMode = PictureBoxSizeMode.StretchImage;
            picBirthdate.TabIndex = 11;
            picBirthdate.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(151, 49);
            picUsername.Margin = new Padding(2);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(97, 98);
            picUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsername.TabIndex = 10;
            picUsername.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(761, 229);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(195, 50);
            txtEmail.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(761, 98);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(195, 50);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(274, 354);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(195, 50);
            txtAddress.TabIndex = 7;
            // 
            // txtBirthdate
            // 
            txtBirthdate.BackColor = SystemColors.ControlLightLight;
            txtBirthdate.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthdate.Location = new Point(274, 229);
            txtBirthdate.Margin = new Padding(2);
            txtBirthdate.Multiline = true;
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.ReadOnly = true;
            txtBirthdate.Size = new Size(195, 50);
            txtBirthdate.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(274, 98);
            txtUsername.Margin = new Padding(2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(195, 50);
            txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(761, 181);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(761, 49);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(156, 32);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(274, 307);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 32);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthdate.Location = new Point(274, 181);
            lblBirthdate.Margin = new Padding(2, 0, 2, 0);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(121, 32);
            lblBirthdate.TabIndex = 1;
            lblBirthdate.Text = "Ngày sinh";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(274, 49);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(184, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên người dùng";
            // 
            // pnlWageDetail
            // 
            pnlWageDetail.BackColor = SystemColors.ControlLightLight;
            pnlWageDetail.Controls.Add(lblWageAmount);
            pnlWageDetail.Controls.Add(dgvWageDetail);
            pnlWageDetail.Controls.Add(btnRemoveWage);
            pnlWageDetail.Controls.Add(btnEditWage);
            pnlWageDetail.Controls.Add(btnAddWage);
            pnlWageDetail.Controls.Add(btnExportWage);
            pnlWageDetail.Controls.Add(btnRefreshWage);
            pnlWageDetail.Controls.Add(btnSearchWage);
            pnlWageDetail.Controls.Add(txtWageAmount);
            pnlWageDetail.Controls.Add(txtWageType);
            pnlWageDetail.Controls.Add(lblWageType);
            pnlWageDetail.Location = new Point(1, 76);
            pnlWageDetail.Margin = new Padding(2);
            pnlWageDetail.Name = "pnlWageDetail";
            pnlWageDetail.Size = new Size(1112, 642);
            pnlWageDetail.TabIndex = 6;
            // 
            // lblWageAmount
            // 
            lblWageAmount.AutoSize = true;
            lblWageAmount.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageAmount.Location = new Point(326, 29);
            lblWageAmount.Margin = new Padding(2, 0, 2, 0);
            lblWageAmount.Name = "lblWageAmount";
            lblWageAmount.Size = new Size(89, 32);
            lblWageAmount.TabIndex = 10;
            lblWageAmount.Text = "Số tiền";
            // 
            // dgvWageDetail
            // 
            dgvWageDetail.AllowUserToAddRows = false;
            dgvWageDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvWageDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvWageDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvWageDetail.DefaultCellStyle = dataGridViewCellStyle8;
            dgvWageDetail.EnableHeadersVisualStyles = false;
            dgvWageDetail.Location = new Point(30, 172);
            dgvWageDetail.Margin = new Padding(2);
            dgvWageDetail.Name = "dgvWageDetail";
            dgvWageDetail.RowHeadersVisible = false;
            dgvWageDetail.RowHeadersWidth = 82;
            dgvWageDetail.Size = new Size(1050, 452);
            dgvWageDetail.TabIndex = 9;
            // 
            // btnRemoveWage
            // 
            btnRemoveWage.BackColor = Color.IndianRed;
            btnRemoveWage.FlatStyle = FlatStyle.Flat;
            btnRemoveWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveWage.ForeColor = Color.White;
            btnRemoveWage.Image = (Image)resources.GetObject("btnRemoveWage.Image");
            btnRemoveWage.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveWage.Location = new Point(886, 98);
            btnRemoveWage.Margin = new Padding(2);
            btnRemoveWage.Name = "btnRemoveWage";
            btnRemoveWage.Size = new Size(110, 46);
            btnRemoveWage.TabIndex = 8;
            btnRemoveWage.Text = "Xóa";
            btnRemoveWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveWage.UseVisualStyleBackColor = false;
            // 
            // btnEditWage
            // 
            btnEditWage.BackColor = Color.RoyalBlue;
            btnEditWage.FlatStyle = FlatStyle.Flat;
            btnEditWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditWage.ForeColor = Color.White;
            btnEditWage.Image = (Image)resources.GetObject("btnEditWage.Image");
            btnEditWage.ImageAlign = ContentAlignment.MiddleRight;
            btnEditWage.Location = new Point(742, 98);
            btnEditWage.Margin = new Padding(2);
            btnEditWage.Name = "btnEditWage";
            btnEditWage.Size = new Size(109, 46);
            btnEditWage.TabIndex = 7;
            btnEditWage.Text = "Sửa";
            btnEditWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditWage.UseVisualStyleBackColor = false;
            // 
            // btnAddWage
            // 
            btnAddWage.BackColor = Color.Teal;
            btnAddWage.FlatStyle = FlatStyle.Flat;
            btnAddWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWage.ForeColor = Color.White;
            btnAddWage.Image = (Image)resources.GetObject("btnAddWage.Image");
            btnAddWage.ImageAlign = ContentAlignment.MiddleRight;
            btnAddWage.Location = new Point(598, 98);
            btnAddWage.Margin = new Padding(2);
            btnAddWage.Name = "btnAddWage";
            btnAddWage.Size = new Size(110, 46);
            btnAddWage.TabIndex = 6;
            btnAddWage.Text = "Thêm";
            btnAddWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddWage.UseVisualStyleBackColor = false;
            btnAddWage.Click += btnAddWage_Click;
            // 
            // btnExportWage
            // 
            btnExportWage.BackColor = Color.LightCoral;
            btnExportWage.FlatStyle = FlatStyle.Flat;
            btnExportWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportWage.ForeColor = Color.White;
            btnExportWage.Image = (Image)resources.GetObject("btnExportWage.Image");
            btnExportWage.ImageAlign = ContentAlignment.MiddleRight;
            btnExportWage.Location = new Point(886, 24);
            btnExportWage.Margin = new Padding(2);
            btnExportWage.Name = "btnExportWage";
            btnExportWage.Size = new Size(110, 46);
            btnExportWage.TabIndex = 5;
            btnExportWage.Text = "Xuất";
            btnExportWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportWage.UseVisualStyleBackColor = false;
            // 
            // btnRefreshWage
            // 
            btnRefreshWage.BackColor = Color.CornflowerBlue;
            btnRefreshWage.FlatStyle = FlatStyle.Flat;
            btnRefreshWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshWage.ForeColor = Color.White;
            btnRefreshWage.Image = (Image)resources.GetObject("btnRefreshWage.Image");
            btnRefreshWage.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshWage.Location = new Point(741, 24);
            btnRefreshWage.Margin = new Padding(2);
            btnRefreshWage.Name = "btnRefreshWage";
            btnRefreshWage.Size = new Size(110, 46);
            btnRefreshWage.TabIndex = 4;
            btnRefreshWage.Text = "Làm mới";
            btnRefreshWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshWage.UseVisualStyleBackColor = false;
            // 
            // btnSearchWage
            // 
            btnSearchWage.BackColor = Color.MediumAquamarine;
            btnSearchWage.FlatStyle = FlatStyle.Flat;
            btnSearchWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchWage.ForeColor = Color.White;
            btnSearchWage.Image = (Image)resources.GetObject("btnSearchWage.Image");
            btnSearchWage.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchWage.Location = new Point(598, 24);
            btnSearchWage.Margin = new Padding(2);
            btnSearchWage.Name = "btnSearchWage";
            btnSearchWage.Size = new Size(110, 46);
            btnSearchWage.TabIndex = 3;
            btnSearchWage.Text = "Tìm";
            btnSearchWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchWage.UseVisualStyleBackColor = false;
            // 
            // txtWageAmount
            // 
            txtWageAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageAmount.Location = new Point(326, 82);
            txtWageAmount.Margin = new Padding(2);
            txtWageAmount.Multiline = true;
            txtWageAmount.Name = "txtWageAmount";
            txtWageAmount.Size = new Size(181, 38);
            txtWageAmount.TabIndex = 2;
            // 
            // txtWageType
            // 
            txtWageType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageType.Location = new Point(60, 82);
            txtWageType.Margin = new Padding(2);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(179, 38);
            txtWageType.TabIndex = 1;
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(60, 29);
            lblWageType.Margin = new Padding(2, 0, 2, 0);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(165, 32);
            lblWageType.TabIndex = 0;
            lblWageType.Text = "Loại tiền công";
            // 
            // pnlGarageDetail
            // 
            pnlGarageDetail.BackColor = SystemColors.ControlLightLight;
            pnlGarageDetail.Controls.Add(btnUndoCarLimit);
            pnlGarageDetail.Controls.Add(btnChangeCarLimit);
            pnlGarageDetail.Controls.Add(checkBox1);
            pnlGarageDetail.Controls.Add(textBox1);
            pnlGarageDetail.Controls.Add(lblCarLimit);
            pnlGarageDetail.Controls.Add(picCar);
            pnlGarageDetail.Location = new Point(1, 76);
            pnlGarageDetail.Margin = new Padding(2);
            pnlGarageDetail.Name = "pnlGarageDetail";
            pnlGarageDetail.Size = new Size(1112, 642);
            pnlGarageDetail.TabIndex = 17;
            // 
            // btnUndoCarLimit
            // 
            btnUndoCarLimit.BackColor = Color.Teal;
            btnUndoCarLimit.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUndoCarLimit.ForeColor = Color.White;
            btnUndoCarLimit.Location = new Point(628, 352);
            btnUndoCarLimit.Margin = new Padding(2);
            btnUndoCarLimit.Name = "btnUndoCarLimit";
            btnUndoCarLimit.Size = new Size(112, 40);
            btnUndoCarLimit.TabIndex = 5;
            btnUndoCarLimit.Text = "Hoàn tác";
            btnUndoCarLimit.UseVisualStyleBackColor = false;
            // 
            // btnChangeCarLimit
            // 
            btnChangeCarLimit.BackColor = Color.Teal;
            btnChangeCarLimit.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeCarLimit.ForeColor = Color.White;
            btnChangeCarLimit.Location = new Point(407, 351);
            btnChangeCarLimit.Margin = new Padding(2);
            btnChangeCarLimit.Name = "btnChangeCarLimit";
            btnChangeCarLimit.Size = new Size(106, 42);
            btnChangeCarLimit.TabIndex = 4;
            btnChangeCarLimit.Text = "Thay đổi";
            btnChangeCarLimit.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(479, 271);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(250, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Cho phép trẩ vượt tiền nợ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(540, 198);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 44);
            textBox1.TabIndex = 2;
            // 
            // lblCarLimit
            // 
            lblCarLimit.AutoSize = true;
            lblCarLimit.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarLimit.Location = new Point(540, 142);
            lblCarLimit.Margin = new Padding(2, 0, 2, 0);
            lblCarLimit.Name = "lblCarLimit";
            lblCarLimit.Size = new Size(140, 32);
            lblCarLimit.TabIndex = 1;
            lblCarLimit.Text = "Số xe tối đa";
            // 
            // picCar
            // 
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(374, 142);
            picCar.Margin = new Padding(2);
            picCar.Name = "picCar";
            picCar.Size = new Size(113, 98);
            picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // pnlBrandDetail
            // 
            pnlBrandDetail.BackColor = SystemColors.ControlLightLight;
            pnlBrandDetail.Controls.Add(btnRemoveBrand);
            pnlBrandDetail.Controls.Add(btnEditBrand);
            pnlBrandDetail.Controls.Add(btnAddBrand);
            pnlBrandDetail.Controls.Add(btnExportBrand);
            pnlBrandDetail.Controls.Add(btnRefreshBrand);
            pnlBrandDetail.Controls.Add(btnSearchBrand);
            pnlBrandDetail.Controls.Add(txtBrandName);
            pnlBrandDetail.Controls.Add(lblBrandName);
            pnlBrandDetail.Controls.Add(dgvBrandDetail);
            pnlBrandDetail.Location = new Point(1, 76);
            pnlBrandDetail.Margin = new Padding(2);
            pnlBrandDetail.Name = "pnlBrandDetail";
            pnlBrandDetail.Size = new Size(1112, 642);
            pnlBrandDetail.TabIndex = 11;
            // 
            // btnRemoveBrand
            // 
            btnRemoveBrand.BackColor = Color.IndianRed;
            btnRemoveBrand.FlatStyle = FlatStyle.Flat;
            btnRemoveBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveBrand.ForeColor = Color.White;
            btnRemoveBrand.Image = (Image)resources.GetObject("btnRemoveBrand.Image");
            btnRemoveBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveBrand.Location = new Point(588, 98);
            btnRemoveBrand.Margin = new Padding(2);
            btnRemoveBrand.Name = "btnRemoveBrand";
            btnRemoveBrand.Size = new Size(104, 46);
            btnRemoveBrand.TabIndex = 8;
            btnRemoveBrand.Text = "Xóa";
            btnRemoveBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveBrand.UseVisualStyleBackColor = false;
            // 
            // btnEditBrand
            // 
            btnEditBrand.BackColor = Color.RoyalBlue;
            btnEditBrand.FlatStyle = FlatStyle.Flat;
            btnEditBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditBrand.ForeColor = Color.White;
            btnEditBrand.Image = (Image)resources.GetObject("btnEditBrand.Image");
            btnEditBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnEditBrand.Location = new Point(444, 98);
            btnEditBrand.Margin = new Padding(2);
            btnEditBrand.Name = "btnEditBrand";
            btnEditBrand.Size = new Size(104, 46);
            btnEditBrand.TabIndex = 7;
            btnEditBrand.Text = "Sửa";
            btnEditBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditBrand.UseVisualStyleBackColor = false;
            // 
            // btnAddBrand
            // 
            btnAddBrand.BackColor = Color.Teal;
            btnAddBrand.FlatStyle = FlatStyle.Flat;
            btnAddBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBrand.ForeColor = Color.White;
            btnAddBrand.Image = (Image)resources.GetObject("btnAddBrand.Image");
            btnAddBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnAddBrand.Location = new Point(300, 98);
            btnAddBrand.Margin = new Padding(2);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(104, 46);
            btnAddBrand.TabIndex = 6;
            btnAddBrand.Text = "Thêm";
            btnAddBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddBrand.UseVisualStyleBackColor = false;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // btnExportBrand
            // 
            btnExportBrand.BackColor = Color.LightCoral;
            btnExportBrand.FlatStyle = FlatStyle.Flat;
            btnExportBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportBrand.ForeColor = Color.White;
            btnExportBrand.Image = (Image)resources.GetObject("btnExportBrand.Image");
            btnExportBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnExportBrand.Location = new Point(588, 24);
            btnExportBrand.Margin = new Padding(2);
            btnExportBrand.Name = "btnExportBrand";
            btnExportBrand.Size = new Size(104, 46);
            btnExportBrand.TabIndex = 5;
            btnExportBrand.Text = "Xuất";
            btnExportBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportBrand.UseVisualStyleBackColor = false;
            // 
            // btnRefreshBrand
            // 
            btnRefreshBrand.BackColor = Color.CornflowerBlue;
            btnRefreshBrand.FlatStyle = FlatStyle.Flat;
            btnRefreshBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshBrand.ForeColor = Color.White;
            btnRefreshBrand.Image = (Image)resources.GetObject("btnRefreshBrand.Image");
            btnRefreshBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshBrand.Location = new Point(444, 24);
            btnRefreshBrand.Margin = new Padding(2);
            btnRefreshBrand.Name = "btnRefreshBrand";
            btnRefreshBrand.Size = new Size(104, 46);
            btnRefreshBrand.TabIndex = 4;
            btnRefreshBrand.Text = "Làm mới";
            btnRefreshBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshBrand.UseVisualStyleBackColor = false;
            // 
            // btnSearchBrand
            // 
            btnSearchBrand.BackColor = Color.MediumAquamarine;
            btnSearchBrand.FlatStyle = FlatStyle.Flat;
            btnSearchBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBrand.ForeColor = Color.White;
            btnSearchBrand.Image = (Image)resources.GetObject("btnSearchBrand.Image");
            btnSearchBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchBrand.Location = new Point(300, 24);
            btnSearchBrand.Margin = new Padding(2);
            btnSearchBrand.Name = "btnSearchBrand";
            btnSearchBrand.Size = new Size(104, 46);
            btnSearchBrand.TabIndex = 3;
            btnSearchBrand.Text = "Tìm";
            btnSearchBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchBrand.UseVisualStyleBackColor = false;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrandName.Location = new Point(60, 82);
            txtBrandName.Margin = new Padding(2);
            txtBrandName.Multiline = true;
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(179, 38);
            txtBrandName.TabIndex = 1;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(60, 29);
            lblBrandName.Margin = new Padding(2, 0, 2, 0);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(102, 32);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Hãng xe";
            // 
            // dgvBrandDetail
            // 
            dgvBrandDetail.AllowUserToAddRows = false;
            dgvBrandDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Black;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvBrandDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBrandDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvBrandDetail.DefaultCellStyle = dataGridViewCellStyle10;
            dgvBrandDetail.EnableHeadersVisualStyles = false;
            dgvBrandDetail.Location = new Point(30, 172);
            dgvBrandDetail.Margin = new Padding(2);
            dgvBrandDetail.Name = "dgvBrandDetail";
            dgvBrandDetail.RowHeadersVisible = false;
            dgvBrandDetail.RowHeadersWidth = 82;
            dgvBrandDetail.Size = new Size(1050, 452);
            dgvBrandDetail.TabIndex = 9;
            // 
            // pnlSupplierDetail
            // 
            pnlSupplierDetail.BackColor = SystemColors.ControlLightLight;
            pnlSupplierDetail.Controls.Add(txtSupplierPhoneNumber);
            pnlSupplierDetail.Controls.Add(lblSupplierEmail);
            pnlSupplierDetail.Controls.Add(lblSupplierPhoneNumber);
            pnlSupplierDetail.Controls.Add(dataGridView1);
            pnlSupplierDetail.Controls.Add(btnRemoveSupplier);
            pnlSupplierDetail.Controls.Add(btnEditSupplier);
            pnlSupplierDetail.Controls.Add(btnAddSupplier);
            pnlSupplierDetail.Controls.Add(btnExportSupplier);
            pnlSupplierDetail.Controls.Add(btnRefreshSupplier);
            pnlSupplierDetail.Controls.Add(btnSearchSupplier);
            pnlSupplierDetail.Controls.Add(txtSupplierName);
            pnlSupplierDetail.Controls.Add(lblSupplierName);
            pnlSupplierDetail.Controls.Add(txtSupplierEmail);
            pnlSupplierDetail.Location = new Point(1, 76);
            pnlSupplierDetail.Margin = new Padding(2);
            pnlSupplierDetail.Name = "pnlSupplierDetail";
            pnlSupplierDetail.Size = new Size(1112, 642);
            pnlSupplierDetail.TabIndex = 12;
            // 
            // txtSupplierPhoneNumber
            // 
            txtSupplierPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierPhoneNumber.Location = new Point(278, 82);
            txtSupplierPhoneNumber.Margin = new Padding(2);
            txtSupplierPhoneNumber.Multiline = true;
            txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            txtSupplierPhoneNumber.Size = new Size(162, 36);
            txtSupplierPhoneNumber.TabIndex = 12;
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierEmail.Location = new Point(474, 29);
            lblSupplierEmail.Margin = new Padding(2, 0, 2, 0);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(71, 32);
            lblSupplierEmail.TabIndex = 11;
            lblSupplierEmail.Text = "Email";
            // 
            // lblSupplierPhoneNumber
            // 
            lblSupplierPhoneNumber.AutoSize = true;
            lblSupplierPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierPhoneNumber.Location = new Point(278, 29);
            lblSupplierPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblSupplierPhoneNumber.Name = "lblSupplierPhoneNumber";
            lblSupplierPhoneNumber.Size = new Size(156, 32);
            lblSupplierPhoneNumber.TabIndex = 10;
            lblSupplierPhoneNumber.Text = "Số điện thoại";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Black;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(30, 172);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1050, 452);
            dataGridView1.TabIndex = 9;
            // 
            // btnRemoveSupplier
            // 
            btnRemoveSupplier.BackColor = Color.IndianRed;
            btnRemoveSupplier.FlatStyle = FlatStyle.Flat;
            btnRemoveSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSupplier.ForeColor = Color.White;
            btnRemoveSupplier.Image = (Image)resources.GetObject("btnRemoveSupplier.Image");
            btnRemoveSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveSupplier.Location = new Point(966, 98);
            btnRemoveSupplier.Margin = new Padding(2);
            btnRemoveSupplier.Name = "btnRemoveSupplier";
            btnRemoveSupplier.Size = new Size(107, 46);
            btnRemoveSupplier.TabIndex = 8;
            btnRemoveSupplier.Text = "Xóa";
            btnRemoveSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveSupplier.UseVisualStyleBackColor = false;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.BackColor = Color.RoyalBlue;
            btnEditSupplier.FlatStyle = FlatStyle.Flat;
            btnEditSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditSupplier.ForeColor = Color.White;
            btnEditSupplier.Image = (Image)resources.GetObject("btnEditSupplier.Image");
            btnEditSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnEditSupplier.Location = new Point(822, 96);
            btnEditSupplier.Margin = new Padding(2);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(124, 46);
            btnEditSupplier.TabIndex = 7;
            btnEditSupplier.Text = "Sửa";
            btnEditSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditSupplier.UseVisualStyleBackColor = false;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.Teal;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.Image = (Image)resources.GetObject("btnAddSupplier.Image");
            btnAddSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnAddSupplier.Location = new Point(678, 98);
            btnAddSupplier.Margin = new Padding(2);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(107, 46);
            btnAddSupplier.TabIndex = 6;
            btnAddSupplier.Text = "Thêm";
            btnAddSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnExportSupplier
            // 
            btnExportSupplier.BackColor = Color.LightCoral;
            btnExportSupplier.FlatStyle = FlatStyle.Flat;
            btnExportSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportSupplier.ForeColor = Color.White;
            btnExportSupplier.Image = (Image)resources.GetObject("btnExportSupplier.Image");
            btnExportSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnExportSupplier.Location = new Point(966, 24);
            btnExportSupplier.Margin = new Padding(2);
            btnExportSupplier.Name = "btnExportSupplier";
            btnExportSupplier.Size = new Size(107, 46);
            btnExportSupplier.TabIndex = 5;
            btnExportSupplier.Text = "Xuất";
            btnExportSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportSupplier.UseVisualStyleBackColor = false;
            // 
            // btnRefreshSupplier
            // 
            btnRefreshSupplier.BackColor = Color.CornflowerBlue;
            btnRefreshSupplier.FlatStyle = FlatStyle.Flat;
            btnRefreshSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshSupplier.ForeColor = Color.White;
            btnRefreshSupplier.Image = (Image)resources.GetObject("btnRefreshSupplier.Image");
            btnRefreshSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshSupplier.Location = new Point(822, 24);
            btnRefreshSupplier.Margin = new Padding(2);
            btnRefreshSupplier.Name = "btnRefreshSupplier";
            btnRefreshSupplier.Size = new Size(124, 46);
            btnRefreshSupplier.TabIndex = 4;
            btnRefreshSupplier.Text = "Làm mới";
            btnRefreshSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshSupplier.UseVisualStyleBackColor = false;
            // 
            // btnSearchSupplier
            // 
            btnSearchSupplier.BackColor = Color.MediumAquamarine;
            btnSearchSupplier.FlatStyle = FlatStyle.Flat;
            btnSearchSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchSupplier.ForeColor = Color.White;
            btnSearchSupplier.Image = (Image)resources.GetObject("btnSearchSupplier.Image");
            btnSearchSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchSupplier.Location = new Point(678, 24);
            btnSearchSupplier.Margin = new Padding(2);
            btnSearchSupplier.Name = "btnSearchSupplier";
            btnSearchSupplier.Size = new Size(107, 46);
            btnSearchSupplier.TabIndex = 3;
            btnSearchSupplier.Text = "Tìm";
            btnSearchSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchSupplier.UseVisualStyleBackColor = false;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(42, 82);
            txtSupplierName.Margin = new Padding(2);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(197, 36);
            txtSupplierName.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierName.Location = new Point(42, 29);
            lblSupplierName.Margin = new Padding(2, 0, 2, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(203, 32);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Tên nhà cung cấp";
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierEmail.Location = new Point(474, 82);
            txtSupplierEmail.Margin = new Padding(2);
            txtSupplierEmail.Multiline = true;
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(162, 36);
            txtSupplierEmail.TabIndex = 13;
            // 
            // fOption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1113, 718);
            Controls.Add(panel1);
            Controls.Add(pnlSupplierDetail);
            Controls.Add(pnlYourProfile);
            Controls.Add(pnlGarageDetail);
            Controls.Add(pnlWageDetail);
            Controls.Add(pnlBrandDetail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            MaximumSize = new Size(1131, 765);
            MinimumSize = new Size(1131, 765);
            Name = "fOption";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CÀI ĐẶT";
            Load += fOption_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlYourProfile.ResumeLayout(false);
            pnlYourProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBirthdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            pnlWageDetail.ResumeLayout(false);
            pnlWageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWageDetail).EndInit();
            pnlGarageDetail.ResumeLayout(false);
            pnlGarageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            pnlBrandDetail.ResumeLayout(false);
            pnlBrandDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrandDetail).EndInit();
            pnlSupplierDetail.ResumeLayout(false);
            pnlSupplierDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlYourProfile;
        private PictureBox picEmail;
        private PictureBox picPhoneNumber;
        private PictureBox picAddress;
        private PictureBox picBirthdate;
        private PictureBox picUsername;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtBirthdate;
        private TextBox txtUsername;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Label lblBirthdate;
        private Label lblUsername;
        private Button btnUpdatePassword;
        private Button btnChange;
        private Panel pnlGarageDetail;
        private TextBox textBox1;
        private Label lblCarLimit;
        private PictureBox picCar;
        private Button btnUndoCarLimit;
        private Button btnChangeCarLimit;
        private CheckBox checkBox1;
        private Panel pnlWageDetail;
        private Button btnRemoveWage;
        private Button btnEditWage;
        private Button btnAddWage;
        private Button btnExportWage;
        private Button btnRefreshWage;
        private Button btnSearchWage;
        private TextBox txtWageAmount;
        private TextBox txtWageType;
        private Label lblWageType;
        private DataGridView dgvWageDetail;
        private Label lblWageAmount;
        private Panel pnlBrandDetail;
        private DataGridView dgvBrandDetail;
        private Button btnRemoveBrand;
        private Button btnEditBrand;
        private Button btnAddBrand;
        private Button btnExportBrand;
        private Button btnRefreshBrand;
        private Button btnSearchBrand;
        private TextBox txtBrandName;
        private Label lblBrandName;
        private Panel pnlSupplierDetail;
        private TextBox txtSupplierPhoneNumber;
        private Label lblSupplierEmail;
        private Label lblSupplierPhoneNumber;
        private DataGridView dataGridView1;
        private Button btnRemoveSupplier;
        private Button btnEditSupplier;
        private Button btnAddSupplier;
        private Button btnExportSupplier;
        private Button btnRefreshSupplier;
        private Button btnSearchSupplier;
        private TextBox txtSupplierName;
        private Label lblSupplierName;
        private TextBox txtSupplierEmail;
        private Button button1;
        private Label lblAccount;
        private Label lblGarageDetail;
        private Label lblSupplierDetail;
        private Label lblBrandDetail;
        private Label lblWageDetail;
    }
}