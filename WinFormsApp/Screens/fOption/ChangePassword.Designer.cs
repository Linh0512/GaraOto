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
            panel1 = new System.Windows.Forms.Panel();
            lblChangePassword = new System.Windows.Forms.Label();
            txtOldPassword = new System.Windows.Forms.TextBox();
            lblOldPassword = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            txtNewPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            lblNewPassword = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(lblChangePassword);
            panel1.Location = new System.Drawing.Point(-8, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1206, 131);
            panel1.TabIndex = 9;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblChangePassword.ForeColor = System.Drawing.Color.White;
            lblChangePassword.Location = new System.Drawing.Point(372, 24);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new System.Drawing.Size(361, 61);
            lblChangePassword.TabIndex = 0;
            lblChangePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtOldPassword.Location = new System.Drawing.Point(517, 181);
            txtOldPassword.Multiline = true;
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new System.Drawing.Size(405, 54);
            txtOldPassword.TabIndex = 17;
            txtOldPassword.TextChanged += txtOldPassword_TextChanged;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblOldPassword.Location = new System.Drawing.Point(207, 184);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new System.Drawing.Size(170, 38);
            lblOldPassword.TabIndex = 16;
            lblOldPassword.Text = "Mật khẩu cũ";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.IndianRed;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Image = ((System.Drawing.Image)resources.GetObject("btnClose.Image"));
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClose.Location = new System.Drawing.Point(655, 502);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(177, 83);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.Teal;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Image = ((System.Drawing.Image)resources.GetObject("btnAdd.Image"));
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAdd.Location = new System.Drawing.Point(345, 502);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(217, 83);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Cập nhật";
            btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtConfirmPassword.Location = new System.Drawing.Point(517, 384);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new System.Drawing.Size(405, 54);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txtNewPassword.Location = new System.Drawing.Point(517, 278);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new System.Drawing.Size(405, 54);
            txtNewPassword.TabIndex = 12;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblConfirmPassword.Location = new System.Drawing.Point(207, 384);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(131, 38);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Xác nhận";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lblNewPassword.Location = new System.Drawing.Point(207, 281);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new System.Drawing.Size(189, 38);
            lblNewPassword.TabIndex = 10;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1194, 636);
            Controls.Add(panel1);
            Controls.Add(txtOldPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            Margin = new System.Windows.Forms.Padding(2);
            MaximumSize = new System.Drawing.Size(1216, 692);
            MinimumSize = new System.Drawing.Size(1216, 692);
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