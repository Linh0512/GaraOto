namespace WinFormsApp.MainScene.fOption
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            panel1 = new Panel();
            lblAddSupplier = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            txtPhoneNumber = new TextBox();
            txtSupplierName = new TextBox();
            lblPhoneNumber = new Label();
            lblSupplierName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtSupplierID = new TextBox();
            lblSupplierID = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddSupplier);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 131);
            panel1.TabIndex = 7;
            // 
            // lblAddSupplier
            // 
            lblAddSupplier.AutoSize = true;
            lblAddSupplier.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSupplier.ForeColor = Color.White;
            lblAddSupplier.Location = new Point(271, 16);
            lblAddSupplier.Name = "lblAddSupplier";
            lblAddSupplier.Size = new Size(677, 81);
            lblAddSupplier.TabIndex = 0;
            lblAddSupplier.Text = "THÊM NHÀ CUNG CẤP";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(689, 546);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 77);
            btnClose.TabIndex = 13;
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
            btnAdd.Location = new Point(369, 546);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 77);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(606, 358);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(362, 54);
            txtPhoneNumber.TabIndex = 11;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(606, 255);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(362, 54);
            txtSupplierName.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(238, 359);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(239, 50);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierName.Location = new Point(238, 259);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(307, 50);
            lblSupplierName.TabIndex = 8;
            lblSupplierName.Text = "Tên nhà cung cấp";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(606, 459);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 54);
            txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(238, 460);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(110, 50);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierID.Location = new Point(606, 150);
            txtSupplierID.Multiline = true;
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(362, 54);
            txtSupplierID.TabIndex = 17;
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierID.Location = new Point(238, 154);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(74, 50);
            lblSupplierID.TabIndex = 16;
            lblSupplierID.Text = "Mã";
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1193, 629);
            Controls.Add(txtSupplierID);
            Controls.Add(lblSupplierID);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtSupplierName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblSupplierName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1219, 700);
            MinimumSize = new Size(1219, 700);
            Name = "AddSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM NHÀ CUNG CẤP";
            Load += AddSupplier_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddSupplier;
        private Button btnClose;
        private Button btnAdd;
        private TextBox txtPhoneNumber;
        private TextBox txtSupplierName;
        private Label lblPhoneNumber;
        private Label lblSupplierName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtSupplierID;
        private Label lblSupplierID;
    }
}