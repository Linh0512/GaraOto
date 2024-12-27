namespace WinFormsApp.Screens.Option
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 82);
            panel1.TabIndex = 14;
            // 
            // lblUpdatePassword
            // 
            lblUpdatePassword.AutoSize = true;
            lblUpdatePassword.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdatePassword.ForeColor = Color.White;
            lblUpdatePassword.Location = new Point(215, 18);
            lblUpdatePassword.Margin = new Padding(2, 0, 2, 0);
            lblUpdatePassword.Name = "lblUpdatePassword";
            lblUpdatePassword.Size = new Size(297, 50);
            lblUpdatePassword.TabIndex = 0;
            lblUpdatePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(431, 351);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 50);
            btnClose.TabIndex = 20;
            btnClose.Text = "Đóng";
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
            btnUpdate.Location = new Point(191, 351);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 50);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(336, 187);
            txtNewPassword.Margin = new Padding(2);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(264, 35);
            txtNewPassword.TabIndex = 18;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(336, 120);
            txtCurrentPassword.Margin = new Padding(2);
            txtCurrentPassword.Multiline = true;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(264, 35);
            txtCurrentPassword.TabIndex = 17;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(129, 187);
            lblNewPassword.Margin = new Padding(2, 0, 2, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(163, 32);
            lblNewPassword.TabIndex = 16;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPassword.Location = new Point(129, 122);
            lblCurrentPassword.Margin = new Padding(2, 0, 2, 0);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(147, 32);
            lblCurrentPassword.TabIndex = 15;
            lblCurrentPassword.Text = "Mật khẩu cũ";
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmNewPassword.Location = new Point(129, 254);
            lblConfirmNewPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(112, 32);
            lblConfirmNewPassword.TabIndex = 21;
            lblConfirmNewPassword.Text = "Xác nhận";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPassword.Location = new Point(336, 254);
            txtConfirmNewPassword.Margin = new Padding(2);
            txtConfirmNewPassword.Multiline = true;
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(264, 35);
            txtConfirmNewPassword.TabIndex = 22;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "UpdatePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ĐỔI MẬT KHẨU";
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