namespace WinFormsApp.Screens.fOption
{
    partial class UpdateSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSupplier));
            panel1 = new Panel();
            lblAddSupplier = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnClose = new Button();
            btnConfirm = new Button();
            lblSupplierName = new Label();
            lblPhoneNumber = new Label();
            txtSupplierName = new TextBox();
            txtPhoneNumber = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddSupplier);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 131);
            panel1.TabIndex = 18;
            // 
            // lblAddSupplier
            // 
            lblAddSupplier.AutoSize = true;
            lblAddSupplier.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSupplier.ForeColor = Color.White;
            lblAddSupplier.Location = new Point(287, 24);
            lblAddSupplier.Name = "lblAddSupplier";
            lblAddSupplier.Size = new Size(630, 81);
            lblAddSupplier.TabIndex = 0;
            lblAddSupplier.Text = "SỬA NHÀ CUNG CẤP";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(604, 391);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 54);
            txtEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(236, 392);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(110, 50);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "Email";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(685, 508);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 77);
            btnClose.TabIndex = 24;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Teal;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Image = (Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirm.Location = new Point(365, 508);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(222, 77);
            btnConfirm.TabIndex = 23;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierName.Location = new Point(236, 191);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(307, 50);
            lblSupplierName.TabIndex = 19;
            lblSupplierName.Text = "Tên nhà cung cấp";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(236, 291);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(239, 50);
            lblPhoneNumber.TabIndex = 20;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(604, 187);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(362, 54);
            txtSupplierName.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(604, 290);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(362, 54);
            txtPhoneNumber.TabIndex = 22;
            // 
            // UpdateSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1193, 629);
            Controls.Add(panel1);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnClose);
            Controls.Add(btnConfirm);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtSupplierName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblSupplierName);
            MaximumSize = new Size(1219, 700);
            MinimumSize = new Size(1219, 700);
            Name = "UpdateSupplier";
            Text = "UpdateSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddSupplier;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnClose;
        private Button btnConfirm;
        private Label lblSupplierName;
        private Label lblPhoneNumber;
        private TextBox txtSupplierName;
        private TextBox txtPhoneNumber;
    }
}