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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnSupplierDetail = new TransparentButton();
            btnProfile = new TransparentButton();
            btnGarageDetail = new TransparentButton();
            btnBrandDetail = new TransparentButton();
            btnWageDetail = new TransparentButton();
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
            colIDWageDetail = new DataGridViewTextBoxColumn();
            colWageType = new DataGridViewTextBoxColumn();
            colWageAmount = new DataGridViewTextBoxColumn();
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
            colIDBrandDetail = new DataGridViewTextBoxColumn();
            colBrandName = new DataGridViewTextBoxColumn();
            pnlSupplierDetail = new Panel();
            txtSupplierPhoneNumber = new TextBox();
            lblSupplierEmail = new Label();
            lblSupplierPhoneNumber = new Label();
            dataGridView1 = new DataGridView();
            colIDSupplier = new DataGridViewTextBoxColumn();
            colSupplierName = new DataGridViewTextBoxColumn();
            colSupplierPhoneNumber = new DataGridViewTextBoxColumn();
            colSupplierEmail = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(btnSupplierDetail);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnGarageDetail);
            panel1.Controls.Add(btnBrandDetail);
            panel1.Controls.Add(btnWageDetail);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 54);
            panel1.TabIndex = 0;
            // 
            // btnSupplierDetail
            // 
            btnSupplierDetail.BackColor = Color.Transparent;
            btnSupplierDetail.FlatAppearance.BorderSize = 0;
            btnSupplierDetail.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSupplierDetail.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSupplierDetail.FlatStyle = FlatStyle.Flat;
            btnSupplierDetail.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplierDetail.ForeColor = SystemColors.ControlLightLight;
            btnSupplierDetail.Location = new Point(804, 5);
            btnSupplierDetail.Margin = new Padding(2);
            btnSupplierDetail.Name = "btnSupplierDetail";
            btnSupplierDetail.Size = new Size(148, 44);
            btnSupplierDetail.TabIndex = 4;
            btnSupplierDetail.Text = "SUPPLIER DETAIL";
            btnSupplierDetail.UseVisualStyleBackColor = true;
            btnSupplierDetail.Click += btnSupplierDetail_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = SystemColors.ControlLightLight;
            btnProfile.Location = new Point(12, 8);
            btnProfile.Margin = new Padding(2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(148, 39);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "YOUR PROFILE";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnGarageDetail
            // 
            btnGarageDetail.BackColor = Color.Transparent;
            btnGarageDetail.FlatAppearance.BorderSize = 0;
            btnGarageDetail.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGarageDetail.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGarageDetail.FlatStyle = FlatStyle.Flat;
            btnGarageDetail.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGarageDetail.ForeColor = SystemColors.ControlLightLight;
            btnGarageDetail.Location = new Point(211, 5);
            btnGarageDetail.Margin = new Padding(2);
            btnGarageDetail.Name = "btnGarageDetail";
            btnGarageDetail.Size = new Size(148, 44);
            btnGarageDetail.TabIndex = 1;
            btnGarageDetail.Text = "GARAGE DETAIL";
            btnGarageDetail.UseVisualStyleBackColor = true;
            btnGarageDetail.Click += btnGarageDetail_Click;
            // 
            // btnBrandDetail
            // 
            btnBrandDetail.BackColor = Color.Transparent;
            btnBrandDetail.FlatAppearance.BorderSize = 0;
            btnBrandDetail.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBrandDetail.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBrandDetail.FlatStyle = FlatStyle.Flat;
            btnBrandDetail.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrandDetail.ForeColor = SystemColors.ControlLightLight;
            btnBrandDetail.Location = new Point(608, 5);
            btnBrandDetail.Margin = new Padding(2);
            btnBrandDetail.Name = "btnBrandDetail";
            btnBrandDetail.Size = new Size(148, 44);
            btnBrandDetail.TabIndex = 3;
            btnBrandDetail.Text = "BRAND DETAIL";
            btnBrandDetail.UseVisualStyleBackColor = true;
            btnBrandDetail.Click += btnBrandDetail_Click;
            // 
            // btnWageDetail
            // 
            btnWageDetail.BackColor = Color.Transparent;
            btnWageDetail.FlatAppearance.BorderSize = 0;
            btnWageDetail.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnWageDetail.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnWageDetail.FlatStyle = FlatStyle.Flat;
            btnWageDetail.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWageDetail.ForeColor = SystemColors.ControlLightLight;
            btnWageDetail.Location = new Point(410, 5);
            btnWageDetail.Margin = new Padding(2);
            btnWageDetail.Name = "btnWageDetail";
            btnWageDetail.Size = new Size(152, 44);
            btnWageDetail.TabIndex = 2;
            btnWageDetail.Text = "WAGE DETAIL";
            btnWageDetail.UseVisualStyleBackColor = true;
            btnWageDetail.Click += btnWageDetail_Click;
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
            pnlYourProfile.Location = new Point(1, 57);
            pnlYourProfile.Margin = new Padding(2);
            pnlYourProfile.Name = "pnlYourProfile";
            pnlYourProfile.Size = new Size(973, 482);
            pnlYourProfile.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(436, 352);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 17;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.Teal;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = Color.White;
            btnUpdatePassword.Location = new Point(677, 272);
            btnUpdatePassword.Margin = new Padding(2);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(158, 32);
            btnUpdatePassword.TabIndex = 16;
            btnUpdatePassword.Text = "Update password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Teal;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(559, 272);
            btnChange.Margin = new Padding(2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(85, 32);
            btnChange.TabIndex = 15;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            // 
            // picEmail
            // 
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(559, 136);
            picEmail.Margin = new Padding(2);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(85, 73);
            picEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmail.TabIndex = 14;
            picEmail.TabStop = false;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Image = (Image)resources.GetObject("picPhoneNumber.Image");
            picPhoneNumber.Location = new Point(559, 37);
            picPhoneNumber.Margin = new Padding(2);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.Size = new Size(85, 73);
            picPhoneNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoneNumber.TabIndex = 13;
            picPhoneNumber.TabStop = false;
            // 
            // picAddress
            // 
            picAddress.Image = (Image)resources.GetObject("picAddress.Image");
            picAddress.Location = new Point(132, 230);
            picAddress.Margin = new Padding(2);
            picAddress.Name = "picAddress";
            picAddress.Size = new Size(85, 73);
            picAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            picAddress.TabIndex = 12;
            picAddress.TabStop = false;
            // 
            // picBirthdate
            // 
            picBirthdate.Image = (Image)resources.GetObject("picBirthdate.Image");
            picBirthdate.Location = new Point(132, 136);
            picBirthdate.Margin = new Padding(2);
            picBirthdate.Name = "picBirthdate";
            picBirthdate.Size = new Size(85, 73);
            picBirthdate.SizeMode = PictureBoxSizeMode.StretchImage;
            picBirthdate.TabIndex = 11;
            picBirthdate.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(132, 37);
            picUsername.Margin = new Padding(2);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(85, 73);
            picUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsername.TabIndex = 10;
            picUsername.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(666, 172);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(171, 38);
            txtEmail.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(666, 73);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(171, 38);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(240, 266);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(171, 38);
            txtAddress.TabIndex = 7;
            // 
            // txtBirthdate
            // 
            txtBirthdate.BackColor = SystemColors.ControlLightLight;
            txtBirthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthdate.Location = new Point(240, 172);
            txtBirthdate.Margin = new Padding(2);
            txtBirthdate.Multiline = true;
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.ReadOnly = true;
            txtBirthdate.Size = new Size(171, 38);
            txtBirthdate.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(240, 73);
            txtUsername.Margin = new Padding(2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(171, 38);
            txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(666, 136);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(666, 37);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(137, 25);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone number";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(240, 230);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthdate.Location = new Point(240, 136);
            lblBirthdate.Margin = new Padding(2, 0, 2, 0);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(89, 25);
            lblBirthdate.TabIndex = 1;
            lblBirthdate.Text = "Birthdate";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(240, 37);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
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
            pnlWageDetail.Location = new Point(1, 57);
            pnlWageDetail.Margin = new Padding(2);
            pnlWageDetail.Name = "pnlWageDetail";
            pnlWageDetail.Size = new Size(973, 482);
            pnlWageDetail.TabIndex = 6;
            // 
            // lblWageAmount
            // 
            lblWageAmount.AutoSize = true;
            lblWageAmount.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageAmount.Location = new Point(285, 22);
            lblWageAmount.Margin = new Padding(2, 0, 2, 0);
            lblWageAmount.Name = "lblWageAmount";
            lblWageAmount.Size = new Size(130, 25);
            lblWageAmount.TabIndex = 10;
            lblWageAmount.Text = "Wage amount";
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
            dgvWageDetail.Columns.AddRange(new DataGridViewColumn[] { colIDWageDetail, colWageType, colWageAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWageDetail.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWageDetail.EnableHeadersVisualStyles = false;
            dgvWageDetail.Location = new Point(26, 129);
            dgvWageDetail.Margin = new Padding(2);
            dgvWageDetail.Name = "dgvWageDetail";
            dgvWageDetail.RowHeadersVisible = false;
            dgvWageDetail.RowHeadersWidth = 82;
            dgvWageDetail.Size = new Size(919, 339);
            dgvWageDetail.TabIndex = 9;
            // 
            // colIDWageDetail
            // 
            colIDWageDetail.HeaderText = "ID";
            colIDWageDetail.MinimumWidth = 10;
            colIDWageDetail.Name = "colIDWageDetail";
            // 
            // colWageType
            // 
            colWageType.HeaderText = "Wage type";
            colWageType.MinimumWidth = 10;
            colWageType.Name = "colWageType";
            // 
            // colWageAmount
            // 
            colWageAmount.HeaderText = "Wage amount";
            colWageAmount.MinimumWidth = 10;
            colWageAmount.Name = "colWageAmount";
            // 
            // btnRemoveWage
            // 
            btnRemoveWage.BackColor = Color.IndianRed;
            btnRemoveWage.FlatStyle = FlatStyle.Flat;
            btnRemoveWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveWage.ForeColor = Color.White;
            btnRemoveWage.Image = (Image)resources.GetObject("btnRemoveWage.Image");
            btnRemoveWage.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveWage.Location = new Point(775, 73);
            btnRemoveWage.Margin = new Padding(2);
            btnRemoveWage.Name = "btnRemoveWage";
            btnRemoveWage.Size = new Size(88, 34);
            btnRemoveWage.TabIndex = 8;
            btnRemoveWage.Text = "Remove";
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
            btnEditWage.Location = new Point(649, 73);
            btnEditWage.Margin = new Padding(2);
            btnEditWage.Name = "btnEditWage";
            btnEditWage.Size = new Size(88, 34);
            btnEditWage.TabIndex = 7;
            btnEditWage.Text = "Edit";
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
            btnAddWage.Location = new Point(523, 73);
            btnAddWage.Margin = new Padding(2);
            btnAddWage.Name = "btnAddWage";
            btnAddWage.Size = new Size(88, 34);
            btnAddWage.TabIndex = 6;
            btnAddWage.Text = "Add";
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
            btnExportWage.Location = new Point(775, 18);
            btnExportWage.Margin = new Padding(2);
            btnExportWage.Name = "btnExportWage";
            btnExportWage.Size = new Size(88, 34);
            btnExportWage.TabIndex = 5;
            btnExportWage.Text = "Export";
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
            btnRefreshWage.Location = new Point(649, 18);
            btnRefreshWage.Margin = new Padding(2);
            btnRefreshWage.Name = "btnRefreshWage";
            btnRefreshWage.Size = new Size(88, 34);
            btnRefreshWage.TabIndex = 4;
            btnRefreshWage.Text = "Refresh";
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
            btnSearchWage.Location = new Point(523, 18);
            btnSearchWage.Margin = new Padding(2);
            btnSearchWage.Name = "btnSearchWage";
            btnSearchWage.Size = new Size(88, 34);
            btnSearchWage.TabIndex = 3;
            btnSearchWage.Text = "Search";
            btnSearchWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchWage.UseVisualStyleBackColor = false;
            // 
            // txtWageAmount
            // 
            txtWageAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageAmount.Location = new Point(285, 62);
            txtWageAmount.Margin = new Padding(2);
            txtWageAmount.Multiline = true;
            txtWageAmount.Name = "txtWageAmount";
            txtWageAmount.Size = new Size(159, 30);
            txtWageAmount.TabIndex = 2;
            // 
            // txtWageType
            // 
            txtWageType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageType.Location = new Point(53, 62);
            txtWageType.Margin = new Padding(2);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(157, 30);
            txtWageType.TabIndex = 1;
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(53, 22);
            lblWageType.Margin = new Padding(2, 0, 2, 0);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(101, 25);
            lblWageType.TabIndex = 0;
            lblWageType.Text = "Wage type";
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
            pnlGarageDetail.Location = new Point(1, 57);
            pnlGarageDetail.Margin = new Padding(2);
            pnlGarageDetail.Name = "pnlGarageDetail";
            pnlGarageDetail.Size = new Size(973, 482);
            pnlGarageDetail.TabIndex = 17;
            // 
            // btnUndoCarLimit
            // 
            btnUndoCarLimit.BackColor = Color.Teal;
            btnUndoCarLimit.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUndoCarLimit.ForeColor = Color.White;
            btnUndoCarLimit.Location = new Point(550, 264);
            btnUndoCarLimit.Margin = new Padding(2);
            btnUndoCarLimit.Name = "btnUndoCarLimit";
            btnUndoCarLimit.Size = new Size(98, 30);
            btnUndoCarLimit.TabIndex = 5;
            btnUndoCarLimit.Text = "Undo";
            btnUndoCarLimit.UseVisualStyleBackColor = false;
            // 
            // btnChangeCarLimit
            // 
            btnChangeCarLimit.BackColor = Color.Teal;
            btnChangeCarLimit.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeCarLimit.ForeColor = Color.White;
            btnChangeCarLimit.Location = new Point(356, 263);
            btnChangeCarLimit.Margin = new Padding(2);
            btnChangeCarLimit.Name = "btnChangeCarLimit";
            btnChangeCarLimit.Size = new Size(93, 32);
            btnChangeCarLimit.TabIndex = 4;
            btnChangeCarLimit.Text = "Change";
            btnChangeCarLimit.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(419, 203);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(204, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Accept payment over debt";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(472, 148);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 34);
            textBox1.TabIndex = 2;
            // 
            // lblCarLimit
            // 
            lblCarLimit.AutoSize = true;
            lblCarLimit.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarLimit.Location = new Point(472, 107);
            lblCarLimit.Margin = new Padding(2, 0, 2, 0);
            lblCarLimit.Name = "lblCarLimit";
            lblCarLimit.Size = new Size(83, 25);
            lblCarLimit.TabIndex = 1;
            lblCarLimit.Text = "Car limit";
            // 
            // picCar
            // 
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(327, 107);
            picCar.Margin = new Padding(2);
            picCar.Name = "picCar";
            picCar.Size = new Size(99, 73);
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
            pnlBrandDetail.Location = new Point(1, 57);
            pnlBrandDetail.Margin = new Padding(2);
            pnlBrandDetail.Name = "pnlBrandDetail";
            pnlBrandDetail.Size = new Size(973, 482);
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
            btnRemoveBrand.Location = new Point(514, 73);
            btnRemoveBrand.Margin = new Padding(2);
            btnRemoveBrand.Name = "btnRemoveBrand";
            btnRemoveBrand.Size = new Size(88, 34);
            btnRemoveBrand.TabIndex = 8;
            btnRemoveBrand.Text = "Remove";
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
            btnEditBrand.Location = new Point(388, 73);
            btnEditBrand.Margin = new Padding(2);
            btnEditBrand.Name = "btnEditBrand";
            btnEditBrand.Size = new Size(88, 34);
            btnEditBrand.TabIndex = 7;
            btnEditBrand.Text = "Edit";
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
            btnAddBrand.Location = new Point(262, 73);
            btnAddBrand.Margin = new Padding(2);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(88, 34);
            btnAddBrand.TabIndex = 6;
            btnAddBrand.Text = "Add";
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
            btnExportBrand.Location = new Point(514, 18);
            btnExportBrand.Margin = new Padding(2);
            btnExportBrand.Name = "btnExportBrand";
            btnExportBrand.Size = new Size(88, 34);
            btnExportBrand.TabIndex = 5;
            btnExportBrand.Text = "Export";
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
            btnRefreshBrand.Location = new Point(388, 18);
            btnRefreshBrand.Margin = new Padding(2);
            btnRefreshBrand.Name = "btnRefreshBrand";
            btnRefreshBrand.Size = new Size(88, 34);
            btnRefreshBrand.TabIndex = 4;
            btnRefreshBrand.Text = "Refresh";
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
            btnSearchBrand.Location = new Point(262, 18);
            btnSearchBrand.Margin = new Padding(2);
            btnSearchBrand.Name = "btnSearchBrand";
            btnSearchBrand.Size = new Size(88, 34);
            btnSearchBrand.TabIndex = 3;
            btnSearchBrand.Text = "Search";
            btnSearchBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchBrand.UseVisualStyleBackColor = false;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrandName.Location = new Point(53, 62);
            txtBrandName.Margin = new Padding(2);
            txtBrandName.Multiline = true;
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(157, 30);
            txtBrandName.TabIndex = 1;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(53, 22);
            lblBrandName.Margin = new Padding(2, 0, 2, 0);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(114, 25);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Brand name";
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
            dgvBrandDetail.Columns.AddRange(new DataGridViewColumn[] { colIDBrandDetail, colBrandName });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBrandDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBrandDetail.EnableHeadersVisualStyles = false;
            dgvBrandDetail.Location = new Point(26, 129);
            dgvBrandDetail.Margin = new Padding(2);
            dgvBrandDetail.Name = "dgvBrandDetail";
            dgvBrandDetail.RowHeadersVisible = false;
            dgvBrandDetail.RowHeadersWidth = 82;
            dgvBrandDetail.Size = new Size(919, 339);
            dgvBrandDetail.TabIndex = 9;
            // 
            // colIDBrandDetail
            // 
            colIDBrandDetail.HeaderText = "ID";
            colIDBrandDetail.MinimumWidth = 10;
            colIDBrandDetail.Name = "colIDBrandDetail";
            // 
            // colBrandName
            // 
            colBrandName.HeaderText = "Brand name";
            colBrandName.MinimumWidth = 10;
            colBrandName.Name = "colBrandName";
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
            pnlSupplierDetail.Location = new Point(1, 57);
            pnlSupplierDetail.Margin = new Padding(2);
            pnlSupplierDetail.Name = "pnlSupplierDetail";
            pnlSupplierDetail.Size = new Size(973, 482);
            pnlSupplierDetail.TabIndex = 12;
            // 
            // txtSupplierPhoneNumber
            // 
            txtSupplierPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierPhoneNumber.Location = new Point(231, 62);
            txtSupplierPhoneNumber.Margin = new Padding(2);
            txtSupplierPhoneNumber.Multiline = true;
            txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            txtSupplierPhoneNumber.Size = new Size(142, 28);
            txtSupplierPhoneNumber.TabIndex = 12;
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierEmail.Location = new Point(412, 24);
            lblSupplierEmail.Margin = new Padding(2, 0, 2, 0);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(58, 25);
            lblSupplierEmail.TabIndex = 11;
            lblSupplierEmail.Text = "Email";
            // 
            // lblSupplierPhoneNumber
            // 
            lblSupplierPhoneNumber.AutoSize = true;
            lblSupplierPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierPhoneNumber.Location = new Point(231, 22);
            lblSupplierPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblSupplierPhoneNumber.Name = "lblSupplierPhoneNumber";
            lblSupplierPhoneNumber.Size = new Size(137, 25);
            lblSupplierPhoneNumber.TabIndex = 10;
            lblSupplierPhoneNumber.Text = "Phone number";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colIDSupplier, colSupplierName, colSupplierPhoneNumber, colSupplierEmail });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(26, 129);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(919, 339);
            dataGridView1.TabIndex = 9;
            // 
            // colIDSupplier
            // 
            colIDSupplier.HeaderText = "ID";
            colIDSupplier.MinimumWidth = 10;
            colIDSupplier.Name = "colIDSupplier";
            // 
            // colSupplierName
            // 
            colSupplierName.HeaderText = "Supplier name";
            colSupplierName.MinimumWidth = 10;
            colSupplierName.Name = "colSupplierName";
            // 
            // colSupplierPhoneNumber
            // 
            colSupplierPhoneNumber.HeaderText = "Phone number";
            colSupplierPhoneNumber.MinimumWidth = 10;
            colSupplierPhoneNumber.Name = "colSupplierPhoneNumber";
            // 
            // colSupplierEmail
            // 
            colSupplierEmail.HeaderText = "Email";
            colSupplierEmail.MinimumWidth = 10;
            colSupplierEmail.Name = "colSupplierEmail";
            // 
            // btnRemoveSupplier
            // 
            btnRemoveSupplier.BackColor = Color.IndianRed;
            btnRemoveSupplier.FlatStyle = FlatStyle.Flat;
            btnRemoveSupplier.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveSupplier.ForeColor = Color.White;
            btnRemoveSupplier.Image = (Image)resources.GetObject("btnRemoveSupplier.Image");
            btnRemoveSupplier.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveSupplier.Location = new Point(845, 73);
            btnRemoveSupplier.Margin = new Padding(2);
            btnRemoveSupplier.Name = "btnRemoveSupplier";
            btnRemoveSupplier.Size = new Size(88, 34);
            btnRemoveSupplier.TabIndex = 8;
            btnRemoveSupplier.Text = "Remove";
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
            btnEditSupplier.Location = new Point(719, 73);
            btnEditSupplier.Margin = new Padding(2);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(88, 34);
            btnEditSupplier.TabIndex = 7;
            btnEditSupplier.Text = "Edit";
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
            btnAddSupplier.Location = new Point(593, 73);
            btnAddSupplier.Margin = new Padding(2);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(88, 34);
            btnAddSupplier.TabIndex = 6;
            btnAddSupplier.Text = "Add";
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
            btnExportSupplier.Location = new Point(845, 18);
            btnExportSupplier.Margin = new Padding(2);
            btnExportSupplier.Name = "btnExportSupplier";
            btnExportSupplier.Size = new Size(88, 34);
            btnExportSupplier.TabIndex = 5;
            btnExportSupplier.Text = "Export";
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
            btnRefreshSupplier.Location = new Point(719, 18);
            btnRefreshSupplier.Margin = new Padding(2);
            btnRefreshSupplier.Name = "btnRefreshSupplier";
            btnRefreshSupplier.Size = new Size(88, 34);
            btnRefreshSupplier.TabIndex = 4;
            btnRefreshSupplier.Text = "Refresh";
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
            btnSearchSupplier.Location = new Point(593, 18);
            btnSearchSupplier.Margin = new Padding(2);
            btnSearchSupplier.Name = "btnSearchSupplier";
            btnSearchSupplier.Size = new Size(88, 34);
            btnSearchSupplier.TabIndex = 3;
            btnSearchSupplier.Text = "Search";
            btnSearchSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchSupplier.UseVisualStyleBackColor = false;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(53, 62);
            txtSupplierName.Margin = new Padding(2);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(142, 28);
            txtSupplierName.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierName.Location = new Point(53, 22);
            lblSupplierName.Margin = new Padding(2, 0, 2, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(134, 25);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Supplier name";
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierEmail.Location = new Point(412, 62);
            txtSupplierEmail.Margin = new Padding(2);
            txtSupplierEmail.Multiline = true;
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(142, 28);
            txtSupplierEmail.TabIndex = 13;
            // 
            // fOption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(974, 538);
            Controls.Add(panel1);
            Controls.Add(pnlYourProfile);
            Controls.Add(pnlGarageDetail);
            Controls.Add(pnlWageDetail);
            Controls.Add(pnlBrandDetail);
            Controls.Add(pnlSupplierDetail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fOption";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Option";
            Load += fOption_Load;
            panel1.ResumeLayout(false);
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
        private TransparentButton btnProfile;
        private TransparentButton btnSupplierDetail;
        private TransparentButton btnBrandDetail;
        private TransparentButton btnWageDetail;
        private TransparentButton btnGarageDetail;
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
        private DataGridViewTextBoxColumn colIDBrandDetail;
        private DataGridViewTextBoxColumn colBrandName;
        private Button btnRemoveBrand;
        private Button btnEditBrand;
        private Button btnAddBrand;
        private Button btnExportBrand;
        private Button btnRefreshBrand;
        private Button btnSearchBrand;
        private TextBox txtBrandName;
        private Label lblBrandName;
        private DataGridViewTextBoxColumn colIDWageDetail;
        private DataGridViewTextBoxColumn colWageType;
        private DataGridViewTextBoxColumn colWageAmount;
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
        private DataGridViewTextBoxColumn colIDSupplier;
        private DataGridViewTextBoxColumn colSupplierName;
        private DataGridViewTextBoxColumn colSupplierPhoneNumber;
        private DataGridViewTextBoxColumn colSupplierEmail;
        private TextBox txtSupplierEmail;
        private Button button1;
    }
}