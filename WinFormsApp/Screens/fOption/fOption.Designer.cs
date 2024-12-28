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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblSupplierDetail = new Label();
            lblAccount = new Label();
            lblWageDetail = new Label();
            lblGarageDetail = new Label();
            lblBrandDetail = new Label();
            pnlYourProfile = new Panel();
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
            pnlSupplierDetail = new Panel();
            txtSupplierID = new TextBox();
            lblSupplierID = new Label();
            txtSupplierPhoneNumber = new TextBox();
            lblSupplierEmail = new Label();
            lblSupplierPhoneNumber = new Label();
            dgvSupplierDetail = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvSupplierDetail).BeginInit();
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
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1807, 115);
            panel1.TabIndex = 0;
            // 
            // lblSupplierDetail
            // 
            lblSupplierDetail.AutoSize = true;
            lblSupplierDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierDetail.ForeColor = Color.White;
            lblSupplierDetail.Location = new Point(1467, 38);
            lblSupplierDetail.Name = "lblSupplierDetail";
            lblSupplierDetail.Size = new Size(302, 50);
            lblSupplierDetail.TabIndex = 22;
            lblSupplierDetail.Text = "NHÀ CUNG CẤP";
            lblSupplierDetail.Click += lblSupplierDetail_Click;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.White;
            lblAccount.Location = new Point(84, 38);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(225, 50);
            lblAccount.TabIndex = 18;
            lblAccount.Text = "TÀI KHOẢN";
            lblAccount.Click += lblAccount_Click;
            // 
            // lblWageDetail
            // 
            lblWageDetail.AutoSize = true;
            lblWageDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWageDetail.ForeColor = Color.White;
            lblWageDetail.Location = new Point(809, 38);
            lblWageDetail.Name = "lblWageDetail";
            lblWageDetail.Size = new Size(220, 50);
            lblWageDetail.TabIndex = 20;
            lblWageDetail.Text = "TIỀN CÔNG";
            lblWageDetail.Click += lblWageDetail_Click;
            // 
            // lblGarageDetail
            // 
            lblGarageDetail.AutoSize = true;
            lblGarageDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGarageDetail.ForeColor = Color.White;
            lblGarageDetail.Location = new Point(476, 38);
            lblGarageDetail.Name = "lblGarageDetail";
            lblGarageDetail.Size = new Size(170, 50);
            lblGarageDetail.TabIndex = 19;
            lblGarageDetail.Text = "GARAGE";
            lblGarageDetail.Click += lblGarageDetail_Click;
            // 
            // lblBrandDetail
            // 
            lblBrandDetail.AutoSize = true;
            lblBrandDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandDetail.ForeColor = Color.White;
            lblBrandDetail.Location = new Point(1172, 38);
            lblBrandDetail.Name = "lblBrandDetail";
            lblBrandDetail.Size = new Size(131, 50);
            lblBrandDetail.TabIndex = 21;
            lblBrandDetail.Text = "HÃNG";
            lblBrandDetail.Click += lblBrandDetail_Click;
            // 
            // pnlYourProfile
            // 
            pnlYourProfile.BackColor = SystemColors.ControlLightLight;
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
            pnlYourProfile.Location = new Point(2, 122);
            pnlYourProfile.Name = "pnlYourProfile";
            pnlYourProfile.Size = new Size(1807, 1027);
            pnlYourProfile.TabIndex = 1;
            // 
            // picEmail
            // 
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(1036, 335);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(158, 157);
            picEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmail.TabIndex = 14;
            picEmail.TabStop = false;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Image = (Image)resources.GetObject("picPhoneNumber.Image");
            picPhoneNumber.Location = new Point(1036, 123);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.Size = new Size(158, 157);
            picPhoneNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoneNumber.TabIndex = 13;
            picPhoneNumber.TabStop = false;
            // 
            // picAddress
            // 
            picAddress.Image = (Image)resources.GetObject("picAddress.Image");
            picAddress.Location = new Point(243, 536);
            picAddress.Name = "picAddress";
            picAddress.Size = new Size(158, 157);
            picAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            picAddress.TabIndex = 12;
            picAddress.TabStop = false;
            // 
            // picBirthdate
            // 
            picBirthdate.Image = (Image)resources.GetObject("picBirthdate.Image");
            picBirthdate.Location = new Point(243, 335);
            picBirthdate.Name = "picBirthdate";
            picBirthdate.Size = new Size(158, 157);
            picBirthdate.SizeMode = PictureBoxSizeMode.StretchImage;
            picBirthdate.TabIndex = 11;
            picBirthdate.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(243, 123);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(158, 157);
            picUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsername.TabIndex = 10;
            picUsername.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(1235, 411);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(314, 78);
            txtEmail.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(1235, 202);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(314, 78);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(443, 611);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(314, 78);
            txtAddress.TabIndex = 7;
            // 
            // txtBirthdate
            // 
            txtBirthdate.BackColor = SystemColors.ControlLightLight;
            txtBirthdate.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthdate.Location = new Point(443, 411);
            txtBirthdate.Multiline = true;
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.ReadOnly = true;
            txtBirthdate.Size = new Size(314, 78);
            txtBirthdate.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(443, 202);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(314, 78);
            txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(1235, 335);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(110, 50);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(1235, 123);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(239, 50);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(443, 536);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(133, 50);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthdate.Location = new Point(443, 335);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(186, 50);
            lblBirthdate.TabIndex = 1;
            lblBirthdate.Text = "Ngày sinh";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(443, 123);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(279, 50);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên người dùng";
            // 
            // pnlWageDetail
            // 
            pnlWageDetail.BackColor = SystemColors.ControlLightLight;
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
            pnlWageDetail.Location = new Point(2, 122);
            pnlWageDetail.Name = "pnlWageDetail";
            pnlWageDetail.Size = new Size(1807, 1027);
            pnlWageDetail.TabIndex = 6;
            // 
            // txtWageID
            // 
            txtWageID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageID.Location = new Point(68, 147);
            txtWageID.Multiline = true;
            txtWageID.Name = "txtWageID";
            txtWageID.Size = new Size(194, 58);
            txtWageID.TabIndex = 12;
            // 
            // lblWageID
            // 
            lblWageID.AutoSize = true;
            lblWageID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageID.Location = new Point(68, 62);
            lblWageID.Name = "lblWageID";
            lblWageID.Size = new Size(74, 50);
            lblWageID.TabIndex = 11;
            lblWageID.Text = "Mã";
            // 
            // lblWageAmount
            // 
            lblWageAmount.AutoSize = true;
            lblWageAmount.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageAmount.Location = new Point(703, 62);
            lblWageAmount.Name = "lblWageAmount";
            lblWageAmount.Size = new Size(136, 50);
            lblWageAmount.TabIndex = 10;
            lblWageAmount.Text = "Số tiền";
            // 
            // dgvWageDetail
            // 
            dgvWageDetail.AllowUserToAddRows = false;
            dgvWageDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWageDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWageDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWageDetail.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWageDetail.EnableHeadersVisualStyles = false;
            dgvWageDetail.Location = new Point(49, 275);
            dgvWageDetail.Name = "dgvWageDetail";
            dgvWageDetail.ReadOnly = true;
            dgvWageDetail.RowHeadersVisible = false;
            dgvWageDetail.RowHeadersWidth = 82;
            dgvWageDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWageDetail.Size = new Size(1706, 723);
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
            btnRemoveWage.Location = new Point(1554, 156);
            btnRemoveWage.Name = "btnRemoveWage";
            btnRemoveWage.Size = new Size(179, 74);
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
            btnEditWage.Location = new Point(1320, 156);
            btnEditWage.Name = "btnEditWage";
            btnEditWage.Size = new Size(177, 74);
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
            btnAddWage.Location = new Point(1086, 156);
            btnAddWage.Name = "btnAddWage";
            btnAddWage.Size = new Size(179, 74);
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
            btnExportWage.Location = new Point(1554, 37);
            btnExportWage.Name = "btnExportWage";
            btnExportWage.Size = new Size(179, 74);
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
            btnRefreshWage.Location = new Point(1318, 37);
            btnRefreshWage.Name = "btnRefreshWage";
            btnRefreshWage.Size = new Size(179, 74);
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
            btnSearchWage.Location = new Point(1086, 37);
            btnSearchWage.Name = "btnSearchWage";
            btnSearchWage.Size = new Size(179, 74);
            btnSearchWage.TabIndex = 3;
            btnSearchWage.Text = "Tìm";
            btnSearchWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchWage.UseVisualStyleBackColor = false;
            btnSearchWage.Click += btnSearchWage_Click;
            // 
            // txtWageAmount
            // 
            txtWageAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageAmount.Location = new Point(703, 147);
            txtWageAmount.Multiline = true;
            txtWageAmount.Name = "txtWageAmount";
            txtWageAmount.Size = new Size(292, 58);
            txtWageAmount.TabIndex = 2;
            // 
            // txtWageType
            // 
            txtWageType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageType.Location = new Point(341, 147);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(288, 58);
            txtWageType.TabIndex = 1;
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(341, 62);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(253, 50);
            lblWageType.TabIndex = 0;
            lblWageType.Text = "Loại tiền công";
            // 
            // pnlGarageDetail
            // 
            pnlGarageDetail.BackColor = SystemColors.ControlLightLight;
            pnlGarageDetail.Controls.Add(btnChangeCarLimit);
            pnlGarageDetail.Controls.Add(ckbOverDebt);
            pnlGarageDetail.Controls.Add(txtCarLimit);
            pnlGarageDetail.Controls.Add(lblCarLimit);
            pnlGarageDetail.Controls.Add(picCar);
            pnlGarageDetail.Location = new Point(2, 122);
            pnlGarageDetail.Name = "pnlGarageDetail";
            pnlGarageDetail.Size = new Size(1807, 1027);
            pnlGarageDetail.TabIndex = 17;
            // 
            // btnChangeCarLimit
            // 
            btnChangeCarLimit.BackColor = Color.Teal;
            btnChangeCarLimit.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeCarLimit.ForeColor = Color.White;
            btnChangeCarLimit.Location = new Point(869, 564);
            btnChangeCarLimit.Name = "btnChangeCarLimit";
            btnChangeCarLimit.Size = new Size(172, 67);
            btnChangeCarLimit.TabIndex = 4;
            btnChangeCarLimit.Text = "Thay đổi";
            btnChangeCarLimit.UseVisualStyleBackColor = false;
            btnChangeCarLimit.Click += btnChangeCarLimit_Click;
            // 
            // ckbOverDebt
            // 
            ckbOverDebt.AutoSize = true;
            ckbOverDebt.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbOverDebt.Location = new Point(778, 434);
            ckbOverDebt.Name = "ckbOverDebt";
            ckbOverDebt.Size = new Size(379, 44);
            ckbOverDebt.TabIndex = 3;
            ckbOverDebt.Text = "Cho phép trả vượt tiền nợ";
            ckbOverDebt.UseMnemonic = false;
            ckbOverDebt.UseVisualStyleBackColor = true;
            // 
            // txtCarLimit
            // 
            txtCarLimit.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarLimit.Location = new Point(878, 317);
            txtCarLimit.Multiline = true;
            txtCarLimit.Name = "txtCarLimit";
            txtCarLimit.Size = new Size(326, 68);
            txtCarLimit.TabIndex = 2;
            // 
            // lblCarLimit
            // 
            lblCarLimit.AutoSize = true;
            lblCarLimit.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarLimit.Location = new Point(878, 227);
            lblCarLimit.Name = "lblCarLimit";
            lblCarLimit.Size = new Size(215, 50);
            lblCarLimit.TabIndex = 1;
            lblCarLimit.Text = "Số xe tối đa";
            // 
            // picCar
            // 
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(608, 227);
            picCar.Name = "picCar";
            picCar.Size = new Size(184, 157);
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
            pnlBrandDetail.Location = new Point(2, 122);
            pnlBrandDetail.Name = "pnlBrandDetail";
            pnlBrandDetail.Size = new Size(1807, 1027);
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
            btnRemoveBrand.Location = new Point(956, 157);
            btnRemoveBrand.Name = "btnRemoveBrand";
            btnRemoveBrand.Size = new Size(169, 74);
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
            btnEditBrand.Location = new Point(722, 157);
            btnEditBrand.Name = "btnEditBrand";
            btnEditBrand.Size = new Size(169, 74);
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
            btnAddBrand.Location = new Point(488, 157);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(169, 74);
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
            btnExportBrand.Location = new Point(956, 38);
            btnExportBrand.Name = "btnExportBrand";
            btnExportBrand.Size = new Size(169, 74);
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
            btnRefreshBrand.Location = new Point(722, 38);
            btnRefreshBrand.Name = "btnRefreshBrand";
            btnRefreshBrand.Size = new Size(169, 74);
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
            btnSearchBrand.Location = new Point(488, 38);
            btnSearchBrand.Name = "btnSearchBrand";
            btnSearchBrand.Size = new Size(169, 74);
            btnSearchBrand.TabIndex = 3;
            btnSearchBrand.Text = "Tìm";
            btnSearchBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchBrand.UseVisualStyleBackColor = false;
            btnSearchBrand.Click += btnSearchBrand_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrandName.Location = new Point(98, 131);
            txtBrandName.Multiline = true;
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(288, 58);
            txtBrandName.TabIndex = 1;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(98, 46);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(156, 50);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Hãng xe";
            // 
            // dgvBrandDetail
            // 
            dgvBrandDetail.AllowUserToAddRows = false;
            dgvBrandDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBrandDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBrandDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBrandDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBrandDetail.EnableHeadersVisualStyles = false;
            dgvBrandDetail.Location = new Point(49, 275);
            dgvBrandDetail.Name = "dgvBrandDetail";
            dgvBrandDetail.ReadOnly = true;
            dgvBrandDetail.RowHeadersVisible = false;
            dgvBrandDetail.RowHeadersWidth = 82;
            dgvBrandDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrandDetail.Size = new Size(1706, 723);
            dgvBrandDetail.TabIndex = 9;
            // 
            // pnlSupplierDetail
            // 
            pnlSupplierDetail.BackColor = SystemColors.ControlLightLight;
            pnlSupplierDetail.Controls.Add(txtSupplierID);
            pnlSupplierDetail.Controls.Add(lblSupplierID);
            pnlSupplierDetail.Controls.Add(txtSupplierPhoneNumber);
            pnlSupplierDetail.Controls.Add(lblSupplierEmail);
            pnlSupplierDetail.Controls.Add(lblSupplierPhoneNumber);
            pnlSupplierDetail.Controls.Add(dgvSupplierDetail);
            pnlSupplierDetail.Controls.Add(btnRemoveSupplier);
            pnlSupplierDetail.Controls.Add(btnEditSupplier);
            pnlSupplierDetail.Controls.Add(btnAddSupplier);
            pnlSupplierDetail.Controls.Add(btnExportSupplier);
            pnlSupplierDetail.Controls.Add(btnRefreshSupplier);
            pnlSupplierDetail.Controls.Add(btnSearchSupplier);
            pnlSupplierDetail.Controls.Add(txtSupplierName);
            pnlSupplierDetail.Controls.Add(lblSupplierName);
            pnlSupplierDetail.Controls.Add(txtSupplierEmail);
            pnlSupplierDetail.Location = new Point(2, 122);
            pnlSupplierDetail.Name = "pnlSupplierDetail";
            pnlSupplierDetail.Size = new Size(1807, 1027);
            pnlSupplierDetail.TabIndex = 12;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierID.Location = new Point(128, 86);
            txtSupplierID.Multiline = true;
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(166, 55);
            txtSupplierID.TabIndex = 15;
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierID.Location = new Point(128, 13);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(74, 50);
            lblSupplierID.TabIndex = 14;
            lblSupplierID.Text = "Mã";
            // 
            // txtSupplierPhoneNumber
            // 
            txtSupplierPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierPhoneNumber.Location = new Point(551, 86);
            txtSupplierPhoneNumber.Multiline = true;
            txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            txtSupplierPhoneNumber.Size = new Size(261, 55);
            txtSupplierPhoneNumber.TabIndex = 12;
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierEmail.Location = new Point(551, 173);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(110, 50);
            lblSupplierEmail.TabIndex = 11;
            lblSupplierEmail.Text = "Email";
            // 
            // lblSupplierPhoneNumber
            // 
            lblSupplierPhoneNumber.AutoSize = true;
            lblSupplierPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierPhoneNumber.Location = new Point(551, 13);
            lblSupplierPhoneNumber.Name = "lblSupplierPhoneNumber";
            lblSupplierPhoneNumber.Size = new Size(239, 50);
            lblSupplierPhoneNumber.TabIndex = 10;
            lblSupplierPhoneNumber.Text = "Số điện thoại";
            // 
            // dgvSupplierDetail
            // 
            dgvSupplierDetail.AllowUserToAddRows = false;
            dgvSupplierDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSupplierDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSupplierDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSupplierDetail.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSupplierDetail.EnableHeadersVisualStyles = false;
            dgvSupplierDetail.Location = new Point(49, 317);
            dgvSupplierDetail.Name = "dgvSupplierDetail";
            dgvSupplierDetail.ReadOnly = true;
            dgvSupplierDetail.RowHeadersVisible = false;
            dgvSupplierDetail.RowHeadersWidth = 82;
            dgvSupplierDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplierDetail.Size = new Size(1706, 681);
            dgvSupplierDetail.TabIndex = 9;
            // 
            // btnRemoveSupplier
            // 
            btnRemoveSupplier.BackColor = Color.IndianRed;
            btnRemoveSupplier.FlatStyle = FlatStyle.Flat;
            btnRemoveSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSupplier.ForeColor = Color.White;
            btnRemoveSupplier.Image = (Image)resources.GetObject("btnRemoveSupplier.Image");
            btnRemoveSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveSupplier.Location = new Point(1506, 181);
            btnRemoveSupplier.Name = "btnRemoveSupplier";
            btnRemoveSupplier.Size = new Size(174, 74);
            btnRemoveSupplier.TabIndex = 8;
            btnRemoveSupplier.Text = "Xóa";
            btnRemoveSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveSupplier.UseVisualStyleBackColor = false;
            btnRemoveSupplier.Click += btnRemoveSupplier_Click;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.BackColor = Color.RoyalBlue;
            btnEditSupplier.FlatStyle = FlatStyle.Flat;
            btnEditSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditSupplier.ForeColor = Color.White;
            btnEditSupplier.Image = (Image)resources.GetObject("btnEditSupplier.Image");
            btnEditSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnEditSupplier.Location = new Point(1272, 178);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(202, 74);
            btnEditSupplier.TabIndex = 7;
            btnEditSupplier.Text = "Sửa";
            btnEditSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditSupplier.UseVisualStyleBackColor = false;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.Teal;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.Image = (Image)resources.GetObject("btnAddSupplier.Image");
            btnAddSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnAddSupplier.Location = new Point(1038, 181);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(174, 74);
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
            btnExportSupplier.Location = new Point(1506, 62);
            btnExportSupplier.Name = "btnExportSupplier";
            btnExportSupplier.Size = new Size(174, 74);
            btnExportSupplier.TabIndex = 5;
            btnExportSupplier.Text = "Xuất";
            btnExportSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportSupplier.UseVisualStyleBackColor = false;
            btnExportSupplier.Click += btnExportSupplier_Click;
            // 
            // btnRefreshSupplier
            // 
            btnRefreshSupplier.BackColor = Color.CornflowerBlue;
            btnRefreshSupplier.FlatStyle = FlatStyle.Flat;
            btnRefreshSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshSupplier.ForeColor = Color.White;
            btnRefreshSupplier.Image = (Image)resources.GetObject("btnRefreshSupplier.Image");
            btnRefreshSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshSupplier.Location = new Point(1272, 62);
            btnRefreshSupplier.Name = "btnRefreshSupplier";
            btnRefreshSupplier.Size = new Size(202, 74);
            btnRefreshSupplier.TabIndex = 4;
            btnRefreshSupplier.Text = "Làm mới";
            btnRefreshSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshSupplier.UseVisualStyleBackColor = false;
            btnRefreshSupplier.Click += btnRefreshSupplier_Click;
            // 
            // btnSearchSupplier
            // 
            btnSearchSupplier.BackColor = Color.MediumAquamarine;
            btnSearchSupplier.FlatStyle = FlatStyle.Flat;
            btnSearchSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchSupplier.ForeColor = Color.White;
            btnSearchSupplier.Image = (Image)resources.GetObject("btnSearchSupplier.Image");
            btnSearchSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchSupplier.Location = new Point(1038, 62);
            btnSearchSupplier.Name = "btnSearchSupplier";
            btnSearchSupplier.Size = new Size(174, 74);
            btnSearchSupplier.TabIndex = 3;
            btnSearchSupplier.Text = "Tìm";
            btnSearchSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchSupplier.UseVisualStyleBackColor = false;
            btnSearchSupplier.Click += btnSearchSupplier_Click;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(130, 242);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(318, 55);
            txtSupplierName.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierName.Location = new Point(130, 173);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(307, 50);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Tên nhà cung cấp";
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierEmail.Location = new Point(551, 242);
            txtSupplierEmail.Multiline = true;
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(261, 55);
            txtSupplierEmail.TabIndex = 13;
            // 
            // fOption
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1796, 1110);
            Controls.Add(panel1);
            Controls.Add(pnlBrandDetail);
            Controls.Add(pnlSupplierDetail);
            Controls.Add(pnlYourProfile);
            Controls.Add(pnlGarageDetail);
            Controls.Add(pnlWageDetail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 3, 6, 3);
            MaximumSize = new Size(1822, 1181);
            MinimumSize = new Size(1822, 1181);
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
            ((System.ComponentModel.ISupportInitialize)dgvSupplierDetail).EndInit();
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
        private DataGridView dgvSupplierDetail;
        private Button btnRemoveSupplier;
        private Button btnEditSupplier;
        private Button btnAddSupplier;
        private Button btnExportSupplier;
        private Button btnRefreshSupplier;
        private Button btnSearchSupplier;
        private TextBox txtSupplierName;
        private Label lblSupplierName;
        private TextBox txtSupplierEmail;
        private Label lblAccount;
        private Label lblGarageDetail;
        private Label lblSupplierDetail;
        private Label lblBrandDetail;
        private Label lblWageDetail;
        private TextBox txtWageID;
        private Label lblWageID;
        private TextBox txtSupplierID;
        private Label lblSupplierID;
    }
}