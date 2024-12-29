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
            panel1.Location = new Point(-6, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 105);
            panel1.TabIndex = 9;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.ForeColor = Color.White;
            lblChangePassword.Location = new Point(346, 21);
            lblChangePassword.Margin = new Padding(2, 0, 2, 0);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(297, 50);
            lblChangePassword.TabIndex = 0;
            lblChangePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOldPassword.Location = new Point(414, 145);
            txtOldPassword.Margin = new Padding(2, 2, 2, 2);
            txtOldPassword.Multiline = true;
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(325, 44);
            txtOldPassword.TabIndex = 17;
            txtOldPassword.TextChanged += txtOldPassword_TextChanged;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldPassword.Location = new Point(166, 147);
            lblOldPassword.Margin = new Padding(2, 0, 2, 0);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(147, 32);
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
            btnClose.Location = new Point(524, 402);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 66);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(276, 402);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 66);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Cập nhật";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(414, 307);
            txtConfirmPassword.Margin = new Padding(2, 2, 2, 2);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(325, 44);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(414, 222);
            txtNewPassword.Margin = new Padding(2, 2, 2, 2);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(325, 44);
            txtNewPassword.TabIndex = 12;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(166, 307);
            lblConfirmPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(112, 32);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Xác nhận";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(166, 225);
            lblNewPassword.Margin = new Padding(2, 0, 2, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(163, 32);
            lblNewPassword.TabIndex = 10;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(958, 516);
            Controls.Add(panel1);
            Controls.Add(txtOldPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            Margin = new Padding(2);
            MaximumSize = new Size(976, 563);
            MinimumSize = new Size(976, 563);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblChangePassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private Label lblOldPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private Label lblNewPassword;
    }
}