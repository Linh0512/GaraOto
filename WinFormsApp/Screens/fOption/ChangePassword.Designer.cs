namespace WinFormsApp.Screens.fOption
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            panel1 = new Panel();
            lblChangePassword = new Label();
            txtOldPassword = new TextBox();
            lblOldPassword = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblNewPassword = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblChangePassword);
            panel1.Location = new Point(-8, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 131);
            panel1.TabIndex = 9;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.ForeColor = Color.White;
            lblChangePassword.Location = new Point(372, 24);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(481, 81);
            lblChangePassword.TabIndex = 0;
            lblChangePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPassword.Location = new Point(517, 181);
            txtOldPassword.Multiline = true;
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(405, 54);
            txtOldPassword.TabIndex = 17;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldPassword.Location = new Point(207, 184);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(224, 50);
            lblOldPassword.TabIndex = 16;
            lblOldPassword.Text = "Mật khẩu cũ";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(655, 502);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 83);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(345, 502);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(217, 83);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Cập nhật";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(517, 384);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(405, 54);
            txtConfirmPassword.TabIndex = 13;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(517, 278);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(405, 54);
            txtNewPassword.TabIndex = 12;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(207, 384);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(172, 50);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Xác nhận";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(207, 281);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(249, 50);
            lblNewPassword.TabIndex = 10;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1190, 621);
            Controls.Add(panel1);
            Controls.Add(txtOldPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            MaximumSize = new Size(1216, 692);
            MinimumSize = new Size(1216, 692);
            Name = "ChangePassword";
            Text = "ChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblChangePassword;
        private TextBox txtOldPassword;
        private Label lblOldPassword;
        private Button btnClose;
        private Button btnAdd;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private Label lblNewPassword;
    }
}