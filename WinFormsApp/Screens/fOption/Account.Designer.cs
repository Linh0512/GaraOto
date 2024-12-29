namespace WinFormsApp.Screens.fOption
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            pnlYourProfile = new Panel();
            btnUpdatePassword = new Button();
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
            panel1 = new Panel();
            label1 = new Label();
            pnlYourProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlYourProfile
            // 
            pnlYourProfile.BackColor = SystemColors.ControlLightLight;
            pnlYourProfile.Controls.Add(btnUpdatePassword);
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
            pnlYourProfile.Location = new Point(11, 93);
            pnlYourProfile.Margin = new Padding(2);
            pnlYourProfile.Name = "pnlYourProfile";
            pnlYourProfile.Size = new Size(713, 436);
            pnlYourProfile.TabIndex = 2;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.CadetBlue;
            btnUpdatePassword.Location = new Point(255, 346);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(213, 62);
            btnUpdatePassword.TabIndex = 18;
            btnUpdatePassword.Text = "Thay đổi mật khẩu";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 108);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // txtChucVu
            // 
            txtChucVu.Anchor = AnchorStyles.None;
            txtChucVu.BackColor = SystemColors.ControlLightLight;
            txtChucVu.Enabled = false;
            txtChucVu.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChucVu.Location = new Point(140, 147);
            txtChucVu.Margin = new Padding(2);
            txtChucVu.Multiline = true;
            txtChucVu.Name = "txtChucVu";
            txtChucVu.ReadOnly = true;
            txtChucVu.Size = new Size(157, 41);
            txtChucVu.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 15;
            label2.Text = "Chức vụ";
            // 
            // picEmail
            // 
            picEmail.Anchor = AnchorStyles.None;
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(432, 115);
            picEmail.Margin = new Padding(2);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(78, 78);
            picEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmail.TabIndex = 14;
            picEmail.TabStop = false;
            // 
            // picPhoneNumber
            // 
            picPhoneNumber.Anchor = AnchorStyles.None;
            picPhoneNumber.Image = (Image)resources.GetObject("picPhoneNumber.Image");
            picPhoneNumber.Location = new Point(432, 9);
            picPhoneNumber.Margin = new Padding(2);
            picPhoneNumber.Name = "picPhoneNumber";
            picPhoneNumber.Size = new Size(78, 78);
            picPhoneNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            picPhoneNumber.TabIndex = 13;
            picPhoneNumber.TabStop = false;
            // 
            // picAddress
            // 
            picAddress.Anchor = AnchorStyles.None;
            picAddress.Image = (Image)resources.GetObject("picAddress.Image");
            picAddress.Location = new Point(232, 220);
            picAddress.Margin = new Padding(2);
            picAddress.Name = "picAddress";
            picAddress.Size = new Size(78, 78);
            picAddress.SizeMode = PictureBoxSizeMode.StretchImage;
            picAddress.TabIndex = 12;
            picAddress.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Anchor = AnchorStyles.None;
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(42, 9);
            picUsername.Margin = new Padding(2);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(78, 78);
            picUsername.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsername.TabIndex = 10;
            picUsername.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(530, 153);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(157, 41);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.BackColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(530, 48);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(157, 41);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(330, 257);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(157, 41);
            txtAddress.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(140, 48);
            txtUsername.Margin = new Padding(2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(157, 41);
            txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(530, 115);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Anchor = AnchorStyles.None;
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(530, 9);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(156, 32);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(330, 220);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 32);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(140, 9);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(184, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên người dùng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 88);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 20);
            label1.Name = "label1";
            label1.Size = new Size(225, 50);
            label1.TabIndex = 0;
            label1.Text = "TÀI KHOẢN";
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 556);
            Controls.Add(panel1);
            Controls.Add(pnlYourProfile);
            MaximumSize = new Size(753, 603);
            MinimumSize = new Size(753, 603);
            Name = "Account";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Account";
            pnlYourProfile.ResumeLayout(false);
            pnlYourProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlYourProfile;
        private PictureBox pictureBox2;
        private TextBox txtChucVu;
        private Label label2;
        private PictureBox picEmail;
        private PictureBox picPhoneNumber;
        private PictureBox picAddress;
        private PictureBox picUsername;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtUsername;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Label lblUsername;
        private Panel panel1;
        private Label label1;
        private Button btnUpdatePassword;
    }
}