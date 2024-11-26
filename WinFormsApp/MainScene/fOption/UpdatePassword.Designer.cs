namespace WinFormsApp.MainScene.fOption
{
    partial class UpdatePassword: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            panel1 = new Panel();
            lblUpdatePassword = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            lblNewPassword = new Label();
            lblCurrentPassword = new Label();
            lblConfirmNewPassword = new Label();
            txtConfirmNewPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblUpdatePassword);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 82);
            panel1.TabIndex = 14;
            // 
            // lblUpdatePassword
            // 
            lblUpdatePassword.AutoSize = true;
            lblUpdatePassword.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdatePassword.ForeColor = Color.White;
            lblUpdatePassword.Location = new Point(193, 21);
            lblUpdatePassword.Margin = new Padding(2, 0, 2, 0);
            lblUpdatePassword.Name = "lblUpdatePassword";
            lblUpdatePassword.Size = new Size(357, 37);
            lblUpdatePassword.TabIndex = 0;
            lblUpdatePassword.Text = "UPDATE YOUR PASSWORD";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(438, 345);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 36);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(226, 345);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 36);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(349, 189);
            txtNewPassword.Margin = new Padding(2, 2, 2, 2);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(282, 35);
            txtNewPassword.TabIndex = 18;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(349, 122);
            txtCurrentPassword.Margin = new Padding(2, 2, 2, 2);
            txtCurrentPassword.Multiline = true;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(282, 35);
            txtCurrentPassword.TabIndex = 17;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(142, 189);
            lblNewPassword.Margin = new Padding(2, 0, 2, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(168, 32);
            lblNewPassword.TabIndex = 16;
            lblNewPassword.Text = "New password";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPassword.Location = new Point(111, 122);
            lblCurrentPassword.Margin = new Padding(2, 0, 2, 0);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(200, 32);
            lblCurrentPassword.TabIndex = 15;
            lblCurrentPassword.Text = "Current password";
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmNewPassword.Location = new Point(58, 255);
            lblConfirmNewPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(257, 32);
            lblConfirmNewPassword.TabIndex = 21;
            lblConfirmNewPassword.Text = "Confirm new password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPassword.Location = new Point(349, 256);
            txtConfirmNewPassword.Margin = new Padding(2, 2, 2, 2);
            txtConfirmNewPassword.Multiline = true;
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(282, 35);
            txtConfirmNewPassword.TabIndex = 22;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 434);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdatePassword";
            Text = "Update Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblUpdatePassword;
        private Button btnClose;
        private Button btnUpdate;
        private TextBox txtNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private Label lblCurrentPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtConfirmNewPassword;
    }
}