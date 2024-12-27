namespace WinFormsApp.Screens.Option
{
    partial class UpdateBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBrand));
            panel1 = new Panel();
            lblAddBrand = new Label();
            btnClose = new Button();
            btnConfirm = new Button();
            txtBrandName = new TextBox();
            lblBrandName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddBrand);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 131);
            panel1.TabIndex = 14;
            // 
            // lblAddBrand
            // 
            lblAddBrand.AutoSize = true;
            lblAddBrand.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddBrand.ForeColor = Color.White;
            lblAddBrand.Location = new Point(387, 18);
            lblAddBrand.Name = "lblAddBrand";
            lblAddBrand.Size = new Size(441, 81);
            lblAddBrand.TabIndex = 0;
            lblAddBrand.Text = "SỬA HÃNG XE";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(652, 480);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 74);
            btnClose.TabIndex = 18;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Teal;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Image = (Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirm.Location = new Point(363, 480);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(220, 74);
            btnConfirm.TabIndex = 17;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrandName.Location = new Point(367, 309);
            txtBrandName.Multiline = true;
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(456, 54);
            txtBrandName.TabIndex = 16;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(367, 208);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(216, 50);
            lblBrandName.TabIndex = 15;
            lblBrandName.Text = "Tên hãng xe";
            // 
            // UpdateBrand
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1190, 621);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnConfirm);
            Controls.Add(txtBrandName);
            Controls.Add(lblBrandName);
            MaximumSize = new Size(1216, 692);
            MinimumSize = new Size(1216, 692);
            Name = "UpdateBrand";
            Text = "UpdateBrand";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddBrand;
        private Button btnClose;
        private Button btnConfirm;
        private TextBox txtBrandName;
        private Label lblBrandName;
    }
}