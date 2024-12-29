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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            lblAccount = new System.Windows.Forms.Label();
            lblWageDetail = new System.Windows.Forms.Label();
            lblGarageDetail = new System.Windows.Forms.Label();
            lblBrandDetail = new System.Windows.Forms.Label();
            pnlYourProfile = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            txtChucVu = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            picEmail = new System.Windows.Forms.PictureBox();
            picPhoneNumber = new System.Windows.Forms.PictureBox();
            picAddress = new System.Windows.Forms.PictureBox();
            picUsername = new System.Windows.Forms.PictureBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            lblPhoneNumber = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            btnUpdatePassword = new System.Windows.Forms.Button();
            btnChange = new System.Windows.Forms.Button();
            pnlWageDetail = new System.Windows.Forms.Panel();
            txtWageID = new System.Windows.Forms.TextBox();
            lblWageID = new System.Windows.Forms.Label();
            lblWageAmount = new System.Windows.Forms.Label();
            dgvWageDetail = new System.Windows.Forms.DataGridView();
            btnRemoveWage = new System.Windows.Forms.Button();
            btnEditWage = new System.Windows.Forms.Button();
            btnAddWage = new System.Windows.Forms.Button();
            btnExportWage = new System.Windows.Forms.Button();
            btnRefreshWage = new System.Windows.Forms.Button();
            btnSearchWage = new System.Windows.Forms.Button();
            txtWageAmount = new System.Windows.Forms.TextBox();
            txtWageType = new System.Windows.Forms.TextBox();
            lblWageType = new System.Windows.Forms.Label();
            pnlGarageDetail = new System.Windows.Forms.Panel();
            btnChangeCarLimit = new System.Windows.Forms.Button();
            ckbOverDebt = new System.Windows.Forms.CheckBox();
            txtCarLimit = new System.Windows.Forms.TextBox();
            lblCarLimit = new System.Windows.Forms.Label();
            picCar = new System.Windows.Forms.PictureBox();
            pnlBrandDetail = new System.Windows.Forms.Panel();
            btnRemoveBrand = new System.Windows.Forms.Button();
            btnEditBrand = new System.Windows.Forms.Button();
            btnAddBrand = new System.Windows.Forms.Button();
            btnExportBrand = new System.Windows.Forms.Button();
            btnRefreshBrand = new System.Windows.Forms.Button();
            btnSearchBrand = new System.Windows.Forms.Button();
            txtBrandName = new System.Windows.Forms.TextBox();
            lblBrandName = new System.Windows.Forms.Label();
            dgvBrandDetail = new System.Windows.Forms.DataGridView();
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
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(lblAccount);
            panel1.Controls.Add(lblWageDetail);
            panel1.Controls.Add(lblGarageDetail);
            panel1.Controls.Add(lblBrandDetail);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1112, 72);
            panel1.TabIndex = 0;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblAccount.ForeColor = System.Drawing.Color.White;
            lblAccount.Location = new System.Drawing.Point(52, 24);
            lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new System.Drawing.Size(170, 38);
            lblAccount.TabIndex = 18;
            lblAccount.Text = "TÀI KHOẢN";
            lblAccount.Click += lblAccount_Click;
            // 
            // lblWageDetail
            // 
            lblWageDetail.AutoSize = true;
            lblWageDetail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblWageDetail.ForeColor = System.Drawing.Color.White;
            lblWageDetail.Location = new System.Drawing.Point(639, 24);
            lblWageDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWageDetail.Name = "lblWageDetail";
            lblWageDetail.Size = new System.Drawing.Size(166, 38);
            lblWageDetail.TabIndex = 20;
            lblWageDetail.Text = "TIỀN CÔNG";
            lblWageDetail.Click += lblWageDetail_Click;
            // 
            // lblGarageDetail
            // 
            lblGarageDetail.AutoSize = true;
            lblGarageDetail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblGarageDetail.ForeColor = System.Drawing.Color.White;
            lblGarageDetail.Location = new System.Drawing.Point(374, 24);
            lblGarageDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblGarageDetail.Name = "lblGarageDetail";
            lblGarageDetail.Size = new System.Drawing.Size(130, 38);
            lblGarageDetail.TabIndex = 19;
            lblGarageDetail.Text = "GARAGE";
            lblGarageDetail.Click += lblGarageDetail_Click;
            // 
            // lblBrandDetail
            // 
            lblBrandDetail.AutoSize = true;
            lblBrandDetail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblBrandDetail.ForeColor = System.Drawing.Color.White;
            lblBrandDetail.Location = new System.Drawing.Point(956, 24);
            lblBrandDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBrandDetail.Name = "lblBrandDetail";
            lblBrandDetail.Size = new System.Drawing.Size(100, 38);
            lblBrandDetail.TabIndex = 21;
            lblBrandDetail.Text = "HÃNG";
            lblBrandDetail.Click += lblBrandDetail_Click;
            // 
            // pnlYourProfile
            // 
            pnlYourProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            pnlYourProfile.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            pnlYourProfile.Location = new System.Drawing.Point(2, 2);
            pnlYourProfile.Margin = new System.Windows.Forms.Padding(2);
            pnlYourProfile.Name = "pnlYourProfile";
            pnlYourProfile.Size = new System.Drawing.Size(1112, 642);
            pnlYourProfile.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
            pictureBox2.Location = new System.Drawing.Point(151, 172);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(97, 98);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // txtChucVu
            // 
            txtChucVu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtChucVu.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtChucVu.Location = new System.Drawing.Point(274, 221);
            txtChucVu.Margin = new System.Windows.Forms.Padding(2);
            txtChucVu.Multiline = true;
            txtChucVu.Name = "txtChucVu";
            txtChucVu.ReadOnly = true;
            txtChucVu.Size = new System.Drawing.Size(195, 50);
            txtChucVu.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(274, 172);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 38);
            label2.TabIndex = 15;
            label2.Text = "Chức vụ";
            // 
            // picEmail
            // 
            picEmail.Image = ((System.Drawing.Image)resources.GetObject("picEmail.Image"));
            picEmail.Location = new System.Drawing.Point(639, 181);
            picEmail.Margin = new System.Windows.Forms.Padding(2);
            picEmail.Name = "picEmail";
            picEmail.Size = new System.Drawing.Size(97, 98);
            picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picEmail.TabIndex = 14;
            picEmail.TabStop = false;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Image = ((System.Drawing.Image)resources.GetObject("picPhoneNumber.Image"));
            picPhoneNumber.Location = new System.Drawing.Point(639, 49);
            picPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.Size = new System.Drawing.Size(97, 98);
            picPhoneNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPhoneNumber.TabIndex = 13;
            picPhoneNumber.TabStop = false;
            // 
            // picAddress
            // 
            picAddress.Image = ((System.Drawing.Image)resources.GetObject("picAddress.Image"));
            picAddress.Location = new System.Drawing.Point(151, 307);
            picAddress.Margin = new System.Windows.Forms.Padding(2);
            picAddress.Name = "picAddress";
            picAddress.Size = new System.Drawing.Size(97, 98);
            picAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picAddress.TabIndex = 12;
            picAddress.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Image = ((System.Drawing.Image)resources.GetObject("picUsername.Image"));
            picUsername.Location = new System.Drawing.Point(151, 49);
            picUsername.Margin = new System.Windows.Forms.Padding(2);
            picUsername.Name = "picUsername";
            picUsername.Size = new System.Drawing.Size(97, 98);
            picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picUsername.TabIndex = 10;
            picUsername.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtEmail.Location = new System.Drawing.Point(761, 229);
            txtEmail.Margin = new System.Windows.Forms.Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new System.Drawing.Size(195, 50);
            txtEmail.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtPhoneNumber.Location = new System.Drawing.Point(761, 98);
            txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new System.Drawing.Size(195, 50);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtAddress.Location = new System.Drawing.Point(274, 354);
            txtAddress.Margin = new System.Windows.Forms.Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new System.Drawing.Size(195, 50);
            txtAddress.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtUsername.Location = new System.Drawing.Point(274, 98);
            txtUsername.Margin = new System.Windows.Forms.Padding(2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new System.Drawing.Size(195, 50);
            txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblEmail.Location = new System.Drawing.Point(761, 181);
            lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(83, 38);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblPhoneNumber.Location = new System.Drawing.Point(761, 49);
            lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new System.Drawing.Size(180, 38);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblAddress.Location = new System.Drawing.Point(274, 307);
            lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(102, 38);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblUsername.Location = new System.Drawing.Point(274, 49);
            lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(212, 38);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên người dùng";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.IndianRed;
            button1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(498, 469);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 42);
            button1.TabIndex = 17;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = System.Drawing.Color.Teal;
            btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            btnUpdatePassword.Location = new System.Drawing.Point(786, 362);
            btnUpdatePassword.Margin = new System.Windows.Forms.Padding(2);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new System.Drawing.Size(167, 42);
            btnUpdatePassword.TabIndex = 16;
            btnUpdatePassword.Text = "Đổi mật khẩu";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = System.Drawing.Color.Teal;
            btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChange.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnChange.ForeColor = System.Drawing.Color.White;
            btnChange.Location = new System.Drawing.Point(639, 362);
            btnChange.Margin = new System.Windows.Forms.Padding(2);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(101, 42);
            btnChange.TabIndex = 15;
            btnChange.Text = "Sửa";
            btnChange.UseVisualStyleBackColor = false;
            // 
            // pnlWageDetail
            // 
            pnlWageDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pnlWageDetail.Controls.Add(txtWageID);
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
            pnlWageDetail.Location = new System.Drawing.Point(1, 76);
            pnlWageDetail.Margin = new System.Windows.Forms.Padding(2);
            pnlWageDetail.Name = "pnlWageDetail";
            pnlWageDetail.Size = new System.Drawing.Size(1112, 642);
            pnlWageDetail.TabIndex = 6;
            // 
            // txtWageID
            // 
            txtWageID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtWageID.Location = new System.Drawing.Point(42, 92);
            txtWageID.Margin = new System.Windows.Forms.Padding(2);
            txtWageID.Multiline = true;
            txtWageID.Name = "txtWageID";
            txtWageID.Size = new System.Drawing.Size(121, 38);
            txtWageID.TabIndex = 12;
            // 
            // lblWageID
            // 
            lblWageID.AutoSize = true;
            lblWageID.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblWageID.Location = new System.Drawing.Point(42, 39);
            lblWageID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWageID.Name = "lblWageID";
            lblWageID.Size = new System.Drawing.Size(56, 38);
            lblWageID.TabIndex = 11;
            lblWageID.Text = "Mã";
            // 
            // lblWageAmount
            // 
            lblWageAmount.AutoSize = true;
            lblWageAmount.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblWageAmount.Location = new System.Drawing.Point(433, 39);
            lblWageAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWageAmount.Name = "lblWageAmount";
            lblWageAmount.Size = new System.Drawing.Size(103, 38);
            lblWageAmount.TabIndex = 10;
            lblWageAmount.Text = "Số tiền";
            // 
            // dgvWageDetail
            // 
            dgvWageDetail.AllowUserToAddRows = false;
            dgvWageDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvWageDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWageDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvWageDetail.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWageDetail.EnableHeadersVisualStyles = false;
            dgvWageDetail.Location = new System.Drawing.Point(30, 172);
            dgvWageDetail.Margin = new System.Windows.Forms.Padding(2);
            dgvWageDetail.Name = "dgvWageDetail";
            dgvWageDetail.ReadOnly = true;
            dgvWageDetail.RowHeadersVisible = false;
            dgvWageDetail.RowHeadersWidth = 82;
            dgvWageDetail.Size = new System.Drawing.Size(1050, 452);
            dgvWageDetail.TabIndex = 9;
            // 
            // btnRemoveWage
            // 
            btnRemoveWage.BackColor = System.Drawing.Color.IndianRed;
            btnRemoveWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveWage.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnRemoveWage.ForeColor = System.Drawing.Color.White;
            btnRemoveWage.Image = ((System.Drawing.Image)resources.GetObject("btnRemoveWage.Image"));
            btnRemoveWage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRemoveWage.Location = new System.Drawing.Point(956, 98);
            btnRemoveWage.Margin = new System.Windows.Forms.Padding(2);
            btnRemoveWage.Name = "btnRemoveWage";
            btnRemoveWage.Size = new System.Drawing.Size(110, 46);
            btnRemoveWage.TabIndex = 8;
            btnRemoveWage.Text = "Xóa";
            btnRemoveWage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRemoveWage.UseVisualStyleBackColor = false;
            btnRemoveWage.Click += btnRemoveWage_Click;
            // 
            // btnEditWage
            // 
            btnEditWage.BackColor = System.Drawing.Color.RoyalBlue;
            btnEditWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditWage.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEditWage.ForeColor = System.Drawing.Color.White;
            btnEditWage.Image = ((System.Drawing.Image)resources.GetObject("btnEditWage.Image"));
            btnEditWage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEditWage.Location = new System.Drawing.Point(812, 98);
            btnEditWage.Margin = new System.Windows.Forms.Padding(2);
            btnEditWage.Name = "btnEditWage";
            btnEditWage.Size = new System.Drawing.Size(109, 46);
            btnEditWage.TabIndex = 7;
            btnEditWage.Text = "Sửa";
            btnEditWage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEditWage.UseVisualStyleBackColor = false;
            btnEditWage.Click += btnEditWage_Click;
            // 
            // btnAddWage
            // 
            btnAddWage.BackColor = System.Drawing.Color.Teal;
            btnAddWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddWage.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAddWage.ForeColor = System.Drawing.Color.White;
            btnAddWage.Image = ((System.Drawing.Image)resources.GetObject("btnAddWage.Image"));
            btnAddWage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddWage.Location = new System.Drawing.Point(668, 98);
            btnAddWage.Margin = new System.Windows.Forms.Padding(2);
            btnAddWage.Name = "btnAddWage";
            btnAddWage.Size = new System.Drawing.Size(110, 46);
            btnAddWage.TabIndex = 6;
            btnAddWage.Text = "Thêm";
            btnAddWage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAddWage.UseVisualStyleBackColor = false;
            btnAddWage.Click += btnAddWage_Click;
            // 
            // btnExportWage
            // 
            btnExportWage.BackColor = System.Drawing.Color.LightCoral;
            btnExportWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportWage.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnExportWage.ForeColor = System.Drawing.Color.White;
            btnExportWage.Image = ((System.Drawing.Image)resources.GetObject("btnExportWage.Image"));
            btnExportWage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExportWage.Location = new System.Drawing.Point(956, 23);
            btnExportWage.Margin = new System.Windows.Forms.Padding(2);
            btnExportWage.Name = "btnExportWage";
            btnExportWage.Size = new System.Drawing.Size(110, 46);
            btnExportWage.TabIndex = 5;
            btnExportWage.Text = "Xuất";
            btnExportWage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnExportWage.UseVisualStyleBackColor = false;
            btnExportWage.Click += btnExportWage_Click;
            // 
            // btnRefreshWage
            // 
            btnRefreshWage.BackColor = System.Drawing.Color.CornflowerBlue;
            btnRefreshWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshWage.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnRefreshWage.ForeColor = System.Drawing.Color.White;
            btnRefreshWage.Image = ((System.Drawing.Image)resources.GetObject("btnRefreshWage.Image"));
            btnRefreshWage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRefreshWage.Location = new System.Drawing.Point(811, 23);
            btnRefreshWage.Margin = new System.Windows.Forms.Padding(2);
            btnRefreshWage.Name = "btnRefreshWage";
            btnRefreshWage.Size = new System.Drawing.Size(110, 46);
            btnRefreshWage.TabIndex = 4;
            btnRefreshWage.Text = "Làm mới";
            btnRefreshWage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRefreshWage.UseVisualStyleBackColor = false;
            btnRefreshWage.Click += btnRefreshWage_Click;
            // 
            // btnSearchWage
            // 
            btnSearchWage.BackColor = System.Drawing.Color.MediumAquamarine;
            btnSearchWage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearchWage.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnSearchWage.ForeColor = System.Drawing.Color.White;
            btnSearchWage.Image = ((System.Drawing.Image)resources.GetObject("btnSearchWage.Image"));
            btnSearchWage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSearchWage.Location = new System.Drawing.Point(668, 23);
            btnSearchWage.Margin = new System.Windows.Forms.Padding(2);
            btnSearchWage.Name = "btnSearchWage";
            btnSearchWage.Size = new System.Drawing.Size(110, 46);
            btnSearchWage.TabIndex = 3;
            btnSearchWage.Text = "Tìm";
            btnSearchWage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSearchWage.UseVisualStyleBackColor = false;
            btnSearchWage.Click += btnSearchWage_Click;
            // 
            // txtWageAmount
            // 
            txtWageAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtWageAmount.Location = new System.Drawing.Point(433, 92);
            txtWageAmount.Margin = new System.Windows.Forms.Padding(2);
            txtWageAmount.Multiline = true;
            txtWageAmount.Name = "txtWageAmount";
            txtWageAmount.Size = new System.Drawing.Size(181, 38);
            txtWageAmount.TabIndex = 2;
            // 
            // txtWageType
            // 
            txtWageType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtWageType.Location = new System.Drawing.Point(210, 92);
            txtWageType.Margin = new System.Windows.Forms.Padding(2);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new System.Drawing.Size(179, 38);
            txtWageType.TabIndex = 1;
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblWageType.Location = new System.Drawing.Point(210, 39);
            lblWageType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new System.Drawing.Size(191, 38);
            lblWageType.TabIndex = 0;
            lblWageType.Text = "Loại tiền công";
            // 
            // pnlGarageDetail
            // 
            pnlGarageDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pnlGarageDetail.Controls.Add(btnChangeCarLimit);
            pnlGarageDetail.Controls.Add(pnlYourProfile);
            pnlGarageDetail.Controls.Add(ckbOverDebt);
            pnlGarageDetail.Controls.Add(txtCarLimit);
            pnlGarageDetail.Controls.Add(lblCarLimit);
            pnlGarageDetail.Controls.Add(picCar);
            pnlGarageDetail.Location = new System.Drawing.Point(1, 76);
            pnlGarageDetail.Margin = new System.Windows.Forms.Padding(2);
            pnlGarageDetail.Name = "pnlGarageDetail";
            pnlGarageDetail.Size = new System.Drawing.Size(1112, 642);
            pnlGarageDetail.TabIndex = 17;
            // 
            // btnChangeCarLimit
            // 
            btnChangeCarLimit.BackColor = System.Drawing.Color.Teal;
            btnChangeCarLimit.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnChangeCarLimit.ForeColor = System.Drawing.Color.White;
            btnChangeCarLimit.Location = new System.Drawing.Point(535, 352);
            btnChangeCarLimit.Margin = new System.Windows.Forms.Padding(2);
            btnChangeCarLimit.Name = "btnChangeCarLimit";
            btnChangeCarLimit.Size = new System.Drawing.Size(106, 42);
            btnChangeCarLimit.TabIndex = 4;
            btnChangeCarLimit.Text = "Thay đổi";
            btnChangeCarLimit.UseVisualStyleBackColor = false;
            btnChangeCarLimit.Click += btnChangeCarLimit_Click;
            // 
            // ckbOverDebt
            // 
            ckbOverDebt.AutoSize = true;
            ckbOverDebt.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            ckbOverDebt.Location = new System.Drawing.Point(479, 271);
            ckbOverDebt.Margin = new System.Windows.Forms.Padding(2);
            ckbOverDebt.Name = "ckbOverDebt";
            ckbOverDebt.Size = new System.Drawing.Size(289, 34);
            ckbOverDebt.TabIndex = 3;
            ckbOverDebt.Text = "Cho phép trả vượt tiền nợ";
            ckbOverDebt.UseMnemonic = false;
            ckbOverDebt.UseVisualStyleBackColor = true;
            // 
            // txtCarLimit
            // 
            txtCarLimit.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtCarLimit.Location = new System.Drawing.Point(540, 198);
            txtCarLimit.Margin = new System.Windows.Forms.Padding(2);
            txtCarLimit.Multiline = true;
            txtCarLimit.Name = "txtCarLimit";
            txtCarLimit.Size = new System.Drawing.Size(202, 44);
            txtCarLimit.TabIndex = 2;
            // 
            // lblCarLimit
            // 
            lblCarLimit.AutoSize = true;
            lblCarLimit.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblCarLimit.Location = new System.Drawing.Point(540, 142);
            lblCarLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCarLimit.Name = "lblCarLimit";
            lblCarLimit.Size = new System.Drawing.Size(162, 38);
            lblCarLimit.TabIndex = 1;
            lblCarLimit.Text = "Số xe tối đa";
            // 
            // picCar
            // 
            picCar.Image = ((System.Drawing.Image)resources.GetObject("picCar.Image"));
            picCar.Location = new System.Drawing.Point(374, 142);
            picCar.Margin = new System.Windows.Forms.Padding(2);
            picCar.Name = "picCar";
            picCar.Size = new System.Drawing.Size(113, 98);
            picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 0;
            picCar.TabStop = false;
            // 
            // pnlBrandDetail
            // 
            pnlBrandDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pnlBrandDetail.Controls.Add(btnRemoveBrand);
            pnlBrandDetail.Controls.Add(btnEditBrand);
            pnlBrandDetail.Controls.Add(btnAddBrand);
            pnlBrandDetail.Controls.Add(btnExportBrand);
            pnlBrandDetail.Controls.Add(btnRefreshBrand);
            pnlBrandDetail.Controls.Add(btnSearchBrand);
            pnlBrandDetail.Controls.Add(txtBrandName);
            pnlBrandDetail.Controls.Add(lblBrandName);
            pnlBrandDetail.Controls.Add(dgvBrandDetail);
            pnlBrandDetail.Location = new System.Drawing.Point(1, 76);
            pnlBrandDetail.Margin = new System.Windows.Forms.Padding(2);
            pnlBrandDetail.Name = "pnlBrandDetail";
            pnlBrandDetail.Size = new System.Drawing.Size(1112, 642);
            pnlBrandDetail.TabIndex = 11;
            // 
            // btnRemoveBrand
            // 
            btnRemoveBrand.BackColor = System.Drawing.Color.IndianRed;
            btnRemoveBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemoveBrand.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnRemoveBrand.ForeColor = System.Drawing.Color.White;
            btnRemoveBrand.Image = ((System.Drawing.Image)resources.GetObject("btnRemoveBrand.Image"));
            btnRemoveBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRemoveBrand.Location = new System.Drawing.Point(588, 98);
            btnRemoveBrand.Margin = new System.Windows.Forms.Padding(2);
            btnRemoveBrand.Name = "btnRemoveBrand";
            btnRemoveBrand.Size = new System.Drawing.Size(104, 46);
            btnRemoveBrand.TabIndex = 8;
            btnRemoveBrand.Text = "Xóa";
            btnRemoveBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRemoveBrand.UseVisualStyleBackColor = false;
            btnRemoveBrand.Click += btnRemoveBrand_Click;
            // 
            // btnEditBrand
            // 
            btnEditBrand.BackColor = System.Drawing.Color.RoyalBlue;
            btnEditBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditBrand.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnEditBrand.ForeColor = System.Drawing.Color.White;
            btnEditBrand.Image = ((System.Drawing.Image)resources.GetObject("btnEditBrand.Image"));
            btnEditBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEditBrand.Location = new System.Drawing.Point(444, 98);
            btnEditBrand.Margin = new System.Windows.Forms.Padding(2);
            btnEditBrand.Name = "btnEditBrand";
            btnEditBrand.Size = new System.Drawing.Size(104, 46);
            btnEditBrand.TabIndex = 7;
            btnEditBrand.Text = "Sửa";
            btnEditBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEditBrand.UseVisualStyleBackColor = false;
            btnEditBrand.Click += btnEditBrand_Click;
            // 
            // btnAddBrand
            // 
            btnAddBrand.BackColor = System.Drawing.Color.Teal;
            btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddBrand.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAddBrand.ForeColor = System.Drawing.Color.White;
            btnAddBrand.Image = ((System.Drawing.Image)resources.GetObject("btnAddBrand.Image"));
            btnAddBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddBrand.Location = new System.Drawing.Point(300, 98);
            btnAddBrand.Margin = new System.Windows.Forms.Padding(2);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new System.Drawing.Size(104, 46);
            btnAddBrand.TabIndex = 6;
            btnAddBrand.Text = "Thêm";
            btnAddBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAddBrand.UseVisualStyleBackColor = false;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // btnExportBrand
            // 
            btnExportBrand.BackColor = System.Drawing.Color.LightCoral;
            btnExportBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportBrand.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnExportBrand.ForeColor = System.Drawing.Color.White;
            btnExportBrand.Image = ((System.Drawing.Image)resources.GetObject("btnExportBrand.Image"));
            btnExportBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnExportBrand.Location = new System.Drawing.Point(588, 24);
            btnExportBrand.Margin = new System.Windows.Forms.Padding(2);
            btnExportBrand.Name = "btnExportBrand";
            btnExportBrand.Size = new System.Drawing.Size(104, 46);
            btnExportBrand.TabIndex = 5;
            btnExportBrand.Text = "Xuất";
            btnExportBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnExportBrand.UseVisualStyleBackColor = false;
            btnExportBrand.Click += btnExportBrand_Click;
            // 
            // btnRefreshBrand
            // 
            btnRefreshBrand.BackColor = System.Drawing.Color.CornflowerBlue;
            btnRefreshBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshBrand.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnRefreshBrand.ForeColor = System.Drawing.Color.White;
            btnRefreshBrand.Image = ((System.Drawing.Image)resources.GetObject("btnRefreshBrand.Image"));
            btnRefreshBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRefreshBrand.Location = new System.Drawing.Point(444, 24);
            btnRefreshBrand.Margin = new System.Windows.Forms.Padding(2);
            btnRefreshBrand.Name = "btnRefreshBrand";
            btnRefreshBrand.Size = new System.Drawing.Size(104, 46);
            btnRefreshBrand.TabIndex = 4;
            btnRefreshBrand.Text = "Làm mới";
            btnRefreshBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRefreshBrand.UseVisualStyleBackColor = false;
            btnRefreshBrand.Click += btnRefreshBrand_Click;
            // 
            // btnSearchBrand
            // 
            btnSearchBrand.BackColor = System.Drawing.Color.MediumAquamarine;
            btnSearchBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearchBrand.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnSearchBrand.ForeColor = System.Drawing.Color.White;
            btnSearchBrand.Image = ((System.Drawing.Image)resources.GetObject("btnSearchBrand.Image"));
            btnSearchBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSearchBrand.Location = new System.Drawing.Point(300, 24);
            btnSearchBrand.Margin = new System.Windows.Forms.Padding(2);
            btnSearchBrand.Name = "btnSearchBrand";
            btnSearchBrand.Size = new System.Drawing.Size(104, 46);
            btnSearchBrand.TabIndex = 3;
            btnSearchBrand.Text = "Tìm";
            btnSearchBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSearchBrand.UseVisualStyleBackColor = false;
            btnSearchBrand.Click += btnSearchBrand_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtBrandName.Location = new System.Drawing.Point(60, 82);
            txtBrandName.Margin = new System.Windows.Forms.Padding(2);
            txtBrandName.Multiline = true;
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new System.Drawing.Size(179, 38);
            txtBrandName.TabIndex = 1;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblBrandName.Location = new System.Drawing.Point(60, 29);
            lblBrandName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new System.Drawing.Size(119, 38);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Hãng xe";
            // 
            // dgvBrandDetail
            // 
            dgvBrandDetail.AllowUserToAddRows = false;
            dgvBrandDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvBrandDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBrandDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvBrandDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBrandDetail.EnableHeadersVisualStyles = false;
            dgvBrandDetail.Location = new System.Drawing.Point(30, 172);
            dgvBrandDetail.Margin = new System.Windows.Forms.Padding(2);
            dgvBrandDetail.Name = "dgvBrandDetail";
            dgvBrandDetail.ReadOnly = true;
            dgvBrandDetail.RowHeadersVisible = false;
            dgvBrandDetail.RowHeadersWidth = 82;
            dgvBrandDetail.Size = new System.Drawing.Size(1050, 452);
            dgvBrandDetail.TabIndex = 9;
            // 
            // fOption
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1106, 700);
            Controls.Add(panel1);
            Controls.Add(pnlGarageDetail);
            Controls.Add(pnlWageDetail);
            Controls.Add(pnlBrandDetail);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            MaximumSize = new System.Drawing.Size(1128, 756);
            MinimumSize = new System.Drawing.Size(1128, 729);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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