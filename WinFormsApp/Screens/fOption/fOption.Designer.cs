using System.Windows.Forms;

namespace WinFormsApp.Screens.Option
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblAccount = new Label();
            lblWageDetail = new Label();
            lblGarageDetail = new Label();
            lblBrandDetail = new Label();
            pnlYourProfile = new Panel();
            pictureBox2 = new PictureBox();
            txtChucVu = new TextBox();
            label2 = new Label();
            picEmail = new PictureBox();
            picPhoneNumber = new PictureBox();
            picAddress = new PictureBox();
            picUsername = new PictureBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtUsername = new TextBox();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            lblUsername = new Label();
            button1 = new Button();
            btnUpdatePassword = new Button();
            btnChange = new Button();
            pnlWageDetail = new Panel();
            txtWageID = new TextBox();
            lblWageID = new Label();
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
            btnChangeCarLimit = new Button();
            ckbOverDebt = new CheckBox();
            txtCarLimit = new TextBox();
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
            panel1.SuspendLayout();
            pnlYourProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            pnlWageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWageDetail).BeginInit();
            pnlGarageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            pnlBrandDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrandDetail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAccount);
            panel1.Controls.Add(lblWageDetail);
            panel1.Controls.Add(lblGarageDetail);
            panel1.Controls.Add(lblBrandDetail);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 58);
            panel1.TabIndex = 0;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.White;
            lblAccount.Location = new Point(42, 19);
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
            lblWageDetail.Location = new Point(511, 19);
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
            lblGarageDetail.Location = new Point(299, 19);
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
            lblBrandDetail.Location = new Point(765, 19);
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
            pnlYourProfile.Controls.Add(pictureBox2);
            pnlYourProfile.Controls.Add(txtChucVu);
            pnlYourProfile.Controls.Add(label2);
            pnlYourProfile.Controls.Add(picEmail);
            pnlYourProfile.Controls.Add(picPhoneNumber);
            pnlYourProfile.Controls.Add(picAddress);
            pnlYourProfile.Controls.Add(picUsername);
            pnlYourProfile.Controls.Add(txtEmail);
            pnlYourProfile.Controls.Add(txtPhoneNumber);
            pnlYourProfile.Controls.Add(txtAddress);
            pnlYourProfile.Controls.Add(txtUsername);
            pnlYourProfile.Controls.Add(lblEmail);
            pnlYourProfile.Controls.Add(lblPhoneNumber);
            pnlYourProfile.Controls.Add(lblAddress);
            pnlYourProfile.Controls.Add(lblUsername);
            pnlYourProfile.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlYourProfile.Location = new Point(48, 282);
            pnlYourProfile.Margin = new Padding(2);
            pnlYourProfile.Name = "pnlYourProfile";
            pnlYourProfile.Size = new Size(890, 514);
            pnlYourProfile.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(121, 138);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // txtChucVu
            // 
            txtChucVu.BackColor = SystemColors.ControlLightLight;
            txtChucVu.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChucVu.Location = new Point(219, 177);
            txtChucVu.Margin = new Padding(2);
            txtChucVu.Multiline = true;
            txtChucVu.Name = "txtChucVu";
            txtChucVu.ReadOnly = true;
            txtChucVu.Size = new Size(157, 41);
            txtChucVu.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 138);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 15;
            label2.Text = "Chức vụ";
            // 
            // picEmail
            // 
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(511, 145);
            picEmail.Margin = new Padding(2);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(78, 78);
            picEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmail.TabIndex = 14;
            picEmail.TabStop = false;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Image = (Image)resources.GetObject("picPhoneNumber.Image");
            picPhoneNumber.Location = new Point(511, 39);
            picPhoneNumber.Margin = new Padding(2);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.Size = new Size(78, 78);
            picPhoneNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoneNumber.TabIndex = 13;
            picPhoneNumber.TabStop = false;
            // 
            // picAddress
            // 
            picAddress.Image = (Image)resources.GetObject("picAddress.Image");
            picAddress.Location = new Point(121, 246);
            picAddress.Margin = new Padding(2);
            picAddress.Name = "picAddress";
            picAddress.Size = new Size(78, 78);
            picAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            picAddress.TabIndex = 12;
            picAddress.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(121, 39);
            picUsername.Margin = new Padding(2);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(78, 78);
            picUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsername.TabIndex = 10;
            picUsername.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(609, 183);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(157, 41);
            txtEmail.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(609, 78);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(157, 41);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(219, 283);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(157, 41);
            txtAddress.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(219, 78);
            txtUsername.Margin = new Padding(2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(157, 41);
            txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(609, 145);
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
            lblPhoneNumber.Location = new Point(609, 39);
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
            lblAddress.Location = new Point(219, 246);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 32);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(219, 39);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(184, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên người dùng";
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
            // pnlWageDetail
            // 
            pnlWageDetail.BackColor = SystemColors.ControlLightLight;
            pnlWageDetail.Controls.Add(txtWageID);
            pnlWageDetail.Controls.Add(pnlGarageDetail);
            pnlWageDetail.Controls.Add(lblWageID);
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
            pnlWageDetail.Location = new Point(881, 485);
            pnlWageDetail.Margin = new Padding(2);
            pnlWageDetail.Name = "pnlWageDetail";
            pnlWageDetail.Size = new Size(890, 514);
            pnlWageDetail.TabIndex = 6;
            // 
            // txtWageID
            // 
            txtWageID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageID.Location = new Point(34, 74);
            txtWageID.Margin = new Padding(2);
            txtWageID.Multiline = true;
            txtWageID.Name = "txtWageID";
            txtWageID.Size = new Size(98, 31);
            txtWageID.TabIndex = 12;
            // 
            // lblWageID
            // 
            lblWageID.AutoSize = true;
            lblWageID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageID.Location = new Point(34, 31);
            lblWageID.Margin = new Padding(2, 0, 2, 0);
            lblWageID.Name = "lblWageID";
            lblWageID.Size = new Size(48, 32);
            lblWageID.TabIndex = 11;
            lblWageID.Text = "Mã";
            // 
            // lblWageAmount
            // 
            lblWageAmount.AutoSize = true;
            lblWageAmount.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageAmount.Location = new Point(346, 31);
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Black;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvWageDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvWageDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvWageDetail.DefaultCellStyle = dataGridViewCellStyle10;
            dgvWageDetail.EnableHeadersVisualStyles = false;
            dgvWageDetail.Location = new Point(24, 138);
            dgvWageDetail.Margin = new Padding(2);
            dgvWageDetail.Name = "dgvWageDetail";
            dgvWageDetail.ReadOnly = true;
            dgvWageDetail.RowHeadersVisible = false;
            dgvWageDetail.RowHeadersWidth = 82;
            dgvWageDetail.Size = new Size(840, 362);
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
            btnRemoveWage.Location = new Point(765, 78);
            btnRemoveWage.Margin = new Padding(2);
            btnRemoveWage.Name = "btnRemoveWage";
            btnRemoveWage.Size = new Size(88, 37);
            btnRemoveWage.TabIndex = 8;
            btnRemoveWage.Text = "Xóa";
            btnRemoveWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveWage.UseVisualStyleBackColor = false;
            btnRemoveWage.Click += btnRemoveWage_Click;
            // 
            // btnEditWage
            // 
            btnEditWage.BackColor = Color.RoyalBlue;
            btnEditWage.FlatStyle = FlatStyle.Flat;
            btnEditWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditWage.ForeColor = Color.White;
            btnEditWage.Image = (Image)resources.GetObject("btnEditWage.Image");
            btnEditWage.ImageAlign = ContentAlignment.MiddleRight;
            btnEditWage.Location = new Point(650, 78);
            btnEditWage.Margin = new Padding(2);
            btnEditWage.Name = "btnEditWage";
            btnEditWage.Size = new Size(87, 37);
            btnEditWage.TabIndex = 7;
            btnEditWage.Text = "Sửa";
            btnEditWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditWage.UseVisualStyleBackColor = false;
            btnEditWage.Click += btnEditWage_Click;
            // 
            // btnAddWage
            // 
            btnAddWage.BackColor = Color.Teal;
            btnAddWage.FlatStyle = FlatStyle.Flat;
            btnAddWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWage.ForeColor = Color.White;
            btnAddWage.Image = (Image)resources.GetObject("btnAddWage.Image");
            btnAddWage.ImageAlign = ContentAlignment.MiddleRight;
            btnAddWage.Location = new Point(534, 78);
            btnAddWage.Margin = new Padding(2);
            btnAddWage.Name = "btnAddWage";
            btnAddWage.Size = new Size(88, 37);
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
            btnExportWage.Location = new Point(765, 18);
            btnExportWage.Margin = new Padding(2);
            btnExportWage.Name = "btnExportWage";
            btnExportWage.Size = new Size(88, 37);
            btnExportWage.TabIndex = 5;
            btnExportWage.Text = "Xuất";
            btnExportWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportWage.UseVisualStyleBackColor = false;
            btnExportWage.Click += btnExportWage_Click;
            // 
            // btnRefreshWage
            // 
            btnRefreshWage.BackColor = Color.CornflowerBlue;
            btnRefreshWage.FlatStyle = FlatStyle.Flat;
            btnRefreshWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshWage.ForeColor = Color.White;
            btnRefreshWage.Image = (Image)resources.GetObject("btnRefreshWage.Image");
            btnRefreshWage.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshWage.Location = new Point(649, 18);
            btnRefreshWage.Margin = new Padding(2);
            btnRefreshWage.Name = "btnRefreshWage";
            btnRefreshWage.Size = new Size(88, 37);
            btnRefreshWage.TabIndex = 4;
            btnRefreshWage.Text = "Làm mới";
            btnRefreshWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshWage.UseVisualStyleBackColor = false;
            btnRefreshWage.Click += btnRefreshWage_Click;
            // 
            // btnSearchWage
            // 
            btnSearchWage.BackColor = Color.MediumAquamarine;
            btnSearchWage.FlatStyle = FlatStyle.Flat;
            btnSearchWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchWage.ForeColor = Color.White;
            btnSearchWage.Image = (Image)resources.GetObject("btnSearchWage.Image");
            btnSearchWage.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchWage.Location = new Point(534, 18);
            btnSearchWage.Margin = new Padding(2);
            btnSearchWage.Name = "btnSearchWage";
            btnSearchWage.Size = new Size(88, 37);
            btnSearchWage.TabIndex = 3;
            btnSearchWage.Text = "Tìm";
            btnSearchWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchWage.UseVisualStyleBackColor = false;
            btnSearchWage.Click += btnSearchWage_Click;
            // 
            // txtWageAmount
            // 
            txtWageAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageAmount.Location = new Point(346, 74);
            txtWageAmount.Margin = new Padding(2);
            txtWageAmount.Multiline = true;
            txtWageAmount.Name = "txtWageAmount";
            txtWageAmount.Size = new Size(146, 31);
            txtWageAmount.TabIndex = 2;
            // 
            // txtWageType
            // 
            txtWageType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageType.Location = new Point(168, 74);
            txtWageType.Margin = new Padding(2);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(144, 31);
            txtWageType.TabIndex = 1;
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(168, 31);
            lblWageType.Margin = new Padding(2, 0, 2, 0);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(165, 32);
            lblWageType.TabIndex = 0;
            lblWageType.Text = "Loại tiền công";
            // 
            // pnlGarageDetail
            // 
            pnlGarageDetail.BackColor = SystemColors.ControlLightLight;
            pnlGarageDetail.Controls.Add(btnChangeCarLimit);
            pnlGarageDetail.Controls.Add(pnlYourProfile);
            pnlGarageDetail.Controls.Add(ckbOverDebt);
            pnlGarageDetail.Controls.Add(txtCarLimit);
            pnlGarageDetail.Controls.Add(lblCarLimit);
            pnlGarageDetail.Controls.Add(picCar);
            pnlGarageDetail.Location = new Point(877, 475);
            pnlGarageDetail.Margin = new Padding(2);
            pnlGarageDetail.Name = "pnlGarageDetail";
            pnlGarageDetail.Size = new Size(890, 514);
            pnlGarageDetail.TabIndex = 17;
            // 
            // btnChangeCarLimit
            // 
            btnChangeCarLimit.BackColor = Color.Teal;
            btnChangeCarLimit.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeCarLimit.ForeColor = Color.White;
            btnChangeCarLimit.Location = new Point(428, 282);
            btnChangeCarLimit.Margin = new Padding(2);
            btnChangeCarLimit.Name = "btnChangeCarLimit";
            btnChangeCarLimit.Size = new Size(85, 34);
            btnChangeCarLimit.TabIndex = 4;
            btnChangeCarLimit.Text = "Thay đổi";
            btnChangeCarLimit.UseVisualStyleBackColor = false;
            btnChangeCarLimit.Click += btnChangeCarLimit_Click;
            // 
            // ckbOverDebt
            // 
            ckbOverDebt.AutoSize = true;
            ckbOverDebt.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbOverDebt.Location = new Point(383, 217);
            ckbOverDebt.Margin = new Padding(2);
            ckbOverDebt.Name = "ckbOverDebt";
            ckbOverDebt.Size = new Size(250, 29);
            ckbOverDebt.TabIndex = 3;
            ckbOverDebt.Text = "Cho phép trả vượt tiền nợ";
            ckbOverDebt.UseMnemonic = false;
            ckbOverDebt.UseVisualStyleBackColor = true;
            // 
            // txtCarLimit
            // 
            txtCarLimit.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarLimit.Location = new Point(432, 158);
            txtCarLimit.Margin = new Padding(2);
            txtCarLimit.Multiline = true;
            txtCarLimit.Name = "txtCarLimit";
            txtCarLimit.Size = new Size(162, 36);
            txtCarLimit.TabIndex = 2;
            // 
            // lblCarLimit
            // 
            lblCarLimit.AutoSize = true;
            lblCarLimit.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarLimit.Location = new Point(432, 114);
            lblCarLimit.Margin = new Padding(2, 0, 2, 0);
            lblCarLimit.Name = "lblCarLimit";
            lblCarLimit.Size = new Size(140, 32);
            lblCarLimit.TabIndex = 1;
            lblCarLimit.Text = "Số xe tối đa";
            // 
            // picCar
            // 
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(299, 114);
            picCar.Margin = new Padding(2);
            picCar.Name = "picCar";
            picCar.Size = new Size(90, 78);
            picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // pnlBrandDetail
            // 
            pnlBrandDetail.BackColor = SystemColors.ControlLightLight;
            pnlBrandDetail.Controls.Add(btnRemoveBrand);
            pnlBrandDetail.Controls.Add(pnlWageDetail);
            pnlBrandDetail.Controls.Add(btnEditBrand);
            pnlBrandDetail.Controls.Add(btnAddBrand);
            pnlBrandDetail.Controls.Add(btnExportBrand);
            pnlBrandDetail.Controls.Add(btnRefreshBrand);
            pnlBrandDetail.Controls.Add(btnSearchBrand);
            pnlBrandDetail.Controls.Add(txtBrandName);
            pnlBrandDetail.Controls.Add(lblBrandName);
            pnlBrandDetail.Controls.Add(dgvBrandDetail);
            pnlBrandDetail.Location = new Point(1, 61);
            pnlBrandDetail.Margin = new Padding(2);
            pnlBrandDetail.Name = "pnlBrandDetail";
            pnlBrandDetail.Size = new Size(890, 514);
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
            btnRemoveBrand.Location = new Point(470, 78);
            btnRemoveBrand.Margin = new Padding(2);
            btnRemoveBrand.Name = "btnRemoveBrand";
            btnRemoveBrand.Size = new Size(83, 37);
            btnRemoveBrand.TabIndex = 8;
            btnRemoveBrand.Text = "Xóa";
            btnRemoveBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveBrand.UseVisualStyleBackColor = false;
            btnRemoveBrand.Click += btnRemoveBrand_Click;
            // 
            // btnEditBrand
            // 
            btnEditBrand.BackColor = Color.RoyalBlue;
            btnEditBrand.FlatStyle = FlatStyle.Flat;
            btnEditBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditBrand.ForeColor = Color.White;
            btnEditBrand.Image = (Image)resources.GetObject("btnEditBrand.Image");
            btnEditBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnEditBrand.Location = new Point(355, 78);
            btnEditBrand.Margin = new Padding(2);
            btnEditBrand.Name = "btnEditBrand";
            btnEditBrand.Size = new Size(83, 37);
            btnEditBrand.TabIndex = 7;
            btnEditBrand.Text = "Sửa";
            btnEditBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditBrand.UseVisualStyleBackColor = false;
            btnEditBrand.Click += btnEditBrand_Click;
            // 
            // btnAddBrand
            // 
            btnAddBrand.BackColor = Color.Teal;
            btnAddBrand.FlatStyle = FlatStyle.Flat;
            btnAddBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBrand.ForeColor = Color.White;
            btnAddBrand.Image = (Image)resources.GetObject("btnAddBrand.Image");
            btnAddBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnAddBrand.Location = new Point(240, 78);
            btnAddBrand.Margin = new Padding(2);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(83, 37);
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
            btnExportBrand.Location = new Point(470, 19);
            btnExportBrand.Margin = new Padding(2);
            btnExportBrand.Name = "btnExportBrand";
            btnExportBrand.Size = new Size(83, 37);
            btnExportBrand.TabIndex = 5;
            btnExportBrand.Text = "Xuất";
            btnExportBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportBrand.UseVisualStyleBackColor = false;
            btnExportBrand.Click += btnExportBrand_Click;
            // 
            // btnRefreshBrand
            // 
            btnRefreshBrand.BackColor = Color.CornflowerBlue;
            btnRefreshBrand.FlatStyle = FlatStyle.Flat;
            btnRefreshBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshBrand.ForeColor = Color.White;
            btnRefreshBrand.Image = (Image)resources.GetObject("btnRefreshBrand.Image");
            btnRefreshBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshBrand.Location = new Point(355, 19);
            btnRefreshBrand.Margin = new Padding(2);
            btnRefreshBrand.Name = "btnRefreshBrand";
            btnRefreshBrand.Size = new Size(83, 37);
            btnRefreshBrand.TabIndex = 4;
            btnRefreshBrand.Text = "Làm mới";
            btnRefreshBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshBrand.UseVisualStyleBackColor = false;
            btnRefreshBrand.Click += btnRefreshBrand_Click;
            // 
            // btnSearchBrand
            // 
            btnSearchBrand.BackColor = Color.MediumAquamarine;
            btnSearchBrand.FlatStyle = FlatStyle.Flat;
            btnSearchBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBrand.ForeColor = Color.White;
            btnSearchBrand.Image = (Image)resources.GetObject("btnSearchBrand.Image");
            btnSearchBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchBrand.Location = new Point(240, 19);
            btnSearchBrand.Margin = new Padding(2);
            btnSearchBrand.Name = "btnSearchBrand";
            btnSearchBrand.Size = new Size(83, 37);
            btnSearchBrand.TabIndex = 3;
            btnSearchBrand.Text = "Tìm";
            btnSearchBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchBrand.UseVisualStyleBackColor = false;
            btnSearchBrand.Click += btnSearchBrand_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrandName.Location = new Point(48, 66);
            txtBrandName.Margin = new Padding(2);
            txtBrandName.Multiline = true;
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(144, 31);
            txtBrandName.TabIndex = 1;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(48, 23);
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Black;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvBrandDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvBrandDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvBrandDetail.DefaultCellStyle = dataGridViewCellStyle12;
            dgvBrandDetail.EnableHeadersVisualStyles = false;
            dgvBrandDetail.Location = new Point(24, 138);
            dgvBrandDetail.Margin = new Padding(2);
            dgvBrandDetail.Name = "dgvBrandDetail";
            dgvBrandDetail.ReadOnly = true;
            dgvBrandDetail.RowHeadersVisible = false;
            dgvBrandDetail.RowHeadersWidth = 82;
            dgvBrandDetail.Size = new Size(840, 362);
            dgvBrandDetail.TabIndex = 9;
            // 
            // fOption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(888, 567);
            Controls.Add(panel1);
            Controls.Add(pnlBrandDetail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(906, 614);
            MinimumSize = new Size(906, 593);
            Name = "fOption";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CÀI ĐẶT";
            Load += fOption_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlYourProfile.ResumeLayout(false);
            pnlYourProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAddress).EndInit();
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
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label1;

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Panel pnlYourProfile;
        private PictureBox picEmail;
        private PictureBox picPhoneNumber;
        private System.Windows.Forms.PictureBox picAddress;
        private System.Windows.Forms.PictureBox picUsername;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUsername;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblUsername;
        private Panel pnlGarageDetail;
        private TextBox txtCarLimit;
        private Label lblCarLimit;
        private PictureBox picCar;
        private Button btnChangeCarLimit;
        private CheckBox ckbOverDebt;
        private Panel pnlWageDetail;
        private Button btnRemoveWage;
        private Button btnEditWage;
        private Button btnAddWage;
        private Button btnUpdatePassword;
        private Button btnExportWage;
        private Button btnRefreshWage;
        private Button btnSearchWage;
        private Button btnChange;
        private Button btnDelete;
        private Button btnChangePassword;
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
        private Button button1;
        private Label lblAccount;
        private Label lblGarageDetail;
        private Label lblBrandDetail;
        private Label lblWageDetail;
        private TextBox txtWageID;
        private Label lblWageID;
        private PictureBox pictureBox2;
        private TextBox txtChucVu;
        private Label label2;
    }
}