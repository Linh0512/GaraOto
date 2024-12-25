namespace WinFormsApp.MainScene.fOption
{
    partial class AddWage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWage));
            panel1 = new Panel();
            lblAddWage = new Label();
            lblWageType = new Label();
            lblValue = new Label();
            txtWageType = new TextBox();
            txtValue = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            txtWageID = new TextBox();
            lblWageID = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddWage);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 82);
            panel1.TabIndex = 0;
            // 
            // lblAddWage
            // 
            lblAddWage.AutoSize = true;
            lblAddWage.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWage.ForeColor = Color.White;
            lblAddWage.Location = new Point(218, 9);
            lblAddWage.Margin = new Padding(2, 0, 2, 0);
            lblAddWage.Name = "lblAddWage";
            lblAddWage.Size = new Size(335, 50);
            lblAddWage.TabIndex = 0;
            lblAddWage.Text = "THÊM TIỀN CÔNG";
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(134, 174);
            lblWageType.Margin = new Padding(2, 0, 2, 0);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(165, 32);
            lblWageType.TabIndex = 1;
            lblWageType.Text = "Loại tiền công";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValue.Location = new Point(134, 238);
            lblValue.Margin = new Padding(2, 0, 2, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(77, 32);
            lblValue.TabIndex = 2;
            lblValue.Text = "Giá trị";
            // 
            // txtWageType
            // 
            txtWageType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageType.Location = new Point(325, 172);
            txtWageType.Margin = new Padding(2);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(251, 35);
            txtWageType.TabIndex = 3;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(325, 238);
            txtValue.Margin = new Padding(2);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(251, 35);
            txtValue.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(220, 332);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 52);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(410, 332);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 52);
            btnClose.TabIndex = 6;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtWageID
            // 
            txtWageID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageID.Location = new Point(325, 111);
            txtWageID.Margin = new Padding(2);
            txtWageID.Multiline = true;
            txtWageID.Name = "txtWageID";
            txtWageID.Size = new Size(251, 35);
            txtWageID.TabIndex = 8;
            // 
            // lblWageID
            // 
            lblWageID.AutoSize = true;
            lblWageID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageID.Location = new Point(134, 113);
            lblWageID.Margin = new Padding(2, 0, 2, 0);
            lblWageID.Name = "lblWageID";
            lblWageID.Size = new Size(48, 32);
            lblWageID.TabIndex = 7;
            lblWageID.Text = "Mã";
            // 
            // AddWage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(743, 431);
            Controls.Add(txtWageID);
            Controls.Add(lblWageID);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtValue);
            Controls.Add(txtWageType);
            Controls.Add(lblValue);
            Controls.Add(lblWageType);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximumSize = new Size(761, 478);
            MinimumSize = new Size(761, 478);
            Name = "AddWage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "THÊM TIỀN CÔNG";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddWage;
        private Label lblWageType;
        private Label lblValue;
        private TextBox txtWageType;
        private TextBox txtValue;
        private Button btnAdd;
        private Button btnClose;
        private TextBox txtWageID;
        private Label lblWageID;
    }
}