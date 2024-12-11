namespace WinFormsApp.MainScenne.fOption
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
            txtValue = new TextBox();
            txtSupplierName = new TextBox();
            lblValue = new Label();
            lblSupplierName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddSupplier);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 132);
            panel1.TabIndex = 7;
            // 
            // lblAddSupplier
            // 
            lblAddSupplier.AutoSize = true;
            lblAddSupplier.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSupplier.ForeColor = Color.White;
            lblAddSupplier.Location = new Point(297, 36);
            lblAddSupplier.Name = "lblAddSupplier";
            lblAddSupplier.Size = new Size(627, 59);
            lblAddSupplier.TabIndex = 0;
            lblAddSupplier.Text = "ADD ADDITIONAL SUPPLIERS";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(661, 477);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 58);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
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
            btnAdd.Location = new Point(364, 477);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 58);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(745, 307);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(200, 53);
            txtValue.TabIndex = 11;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(215, 307);
            txtSupplierName.Multiline = true;
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(455, 53);
            txtSupplierName.TabIndex = 10;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValue.Location = new Point(745, 217);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(110, 50);
            lblValue.TabIndex = 9;
            lblValue.Text = "Value";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplierName.Location = new Point(215, 206);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(258, 50);
            lblSupplierName.TabIndex = 8;
            lblSupplierName.Text = "Supplier name";
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1206, 662);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtValue);
            Controls.Add(txtSupplierName);
            Controls.Add(lblValue);
            Controls.Add(lblSupplierName);
            Name = "AddSupplier";
            Text = "Add Supplier";
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
        private TextBox txtValue;
        private TextBox txtSupplierName;
        private Label lblValue;
        private Label lblSupplierName;
    }
}