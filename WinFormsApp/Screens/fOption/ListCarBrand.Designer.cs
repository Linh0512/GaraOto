namespace WinFormsApp.Screens.fOption
{
    partial class ListCarBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCarBrand));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlBrandDetail = new Panel();
            txtBrandName = new TextBox();
            btnRemoveBrand = new Button();
            btnEditBrand = new Button();
            btnAddBrand = new Button();
            btnExportBrand = new Button();
            btnRefreshBrand = new Button();
            btnSearchBrand = new Button();
            lblBrandName = new Label();
            dgvBrandDetail = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            pnlBrandDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrandDetail).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrandDetail
            // 
            pnlBrandDetail.BackColor = SystemColors.ControlLightLight;
            pnlBrandDetail.Controls.Add(txtBrandName);
            pnlBrandDetail.Controls.Add(btnRemoveBrand);
            pnlBrandDetail.Controls.Add(btnEditBrand);
            pnlBrandDetail.Controls.Add(btnAddBrand);
            pnlBrandDetail.Controls.Add(btnExportBrand);
            pnlBrandDetail.Controls.Add(btnRefreshBrand);
            pnlBrandDetail.Controls.Add(btnSearchBrand);
            pnlBrandDetail.Controls.Add(lblBrandName);
            pnlBrandDetail.Controls.Add(dgvBrandDetail);
            pnlBrandDetail.Location = new Point(1, 93);
            pnlBrandDetail.Margin = new Padding(2);
            pnlBrandDetail.Name = "pnlBrandDetail";
            pnlBrandDetail.Size = new Size(994, 501);
            pnlBrandDetail.TabIndex = 12;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(140, 47);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(219, 27);
            txtBrandName.TabIndex = 10;
            // 
            // btnRemoveBrand
            // 
            btnRemoveBrand.BackColor = Color.IndianRed;
            btnRemoveBrand.FlatStyle = FlatStyle.Flat;
            btnRemoveBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveBrand.ForeColor = Color.White;
            btnRemoveBrand.Image = (Image)resources.GetObject("btnRemoveBrand.Image");
            btnRemoveBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveBrand.Location = new Point(839, 66);
            btnRemoveBrand.Margin = new Padding(2);
            btnRemoveBrand.Name = "btnRemoveBrand";
            btnRemoveBrand.Size = new Size(114, 52);
            btnRemoveBrand.TabIndex = 8;
            btnRemoveBrand.Text = "Xóa";
            btnRemoveBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveBrand.UseVisualStyleBackColor = false;
            btnRemoveBrand.Click += btnRemoveBrand_Click;
            // 
            // btnEditBrand
            // 
            btnEditBrand.BackColor = Color.RoyalBlue;
            btnEditBrand.FlatStyle = FlatStyle.Flat;
            btnEditBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditBrand.ForeColor = Color.White;
            btnEditBrand.Image = (Image)resources.GetObject("btnEditBrand.Image");
            btnEditBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnEditBrand.Location = new Point(667, 66);
            btnEditBrand.Margin = new Padding(2);
            btnEditBrand.Name = "btnEditBrand";
            btnEditBrand.Size = new Size(125, 52);
            btnEditBrand.TabIndex = 7;
            btnEditBrand.Text = "Sửa";
            btnEditBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditBrand.UseVisualStyleBackColor = false;
            btnEditBrand.Click += btnEditBrand_Click;
            // 
            // btnAddBrand
            // 
            btnAddBrand.BackColor = Color.Teal;
            btnAddBrand.FlatStyle = FlatStyle.Flat;
            btnAddBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBrand.ForeColor = Color.White;
            btnAddBrand.Image = (Image)resources.GetObject("btnAddBrand.Image");
            btnAddBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnAddBrand.Location = new Point(498, 66);
            btnAddBrand.Margin = new Padding(2);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(101, 52);
            btnAddBrand.TabIndex = 6;
            btnAddBrand.Text = "Thêm";
            btnAddBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddBrand.UseVisualStyleBackColor = false;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // btnExportBrand
            // 
            btnExportBrand.BackColor = Color.LightCoral;
            btnExportBrand.FlatStyle = FlatStyle.Flat;
            btnExportBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportBrand.ForeColor = Color.White;
            btnExportBrand.Image = (Image)resources.GetObject("btnExportBrand.Image");
            btnExportBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnExportBrand.Location = new Point(839, 2);
            btnExportBrand.Margin = new Padding(2);
            btnExportBrand.Name = "btnExportBrand";
            btnExportBrand.Size = new Size(114, 45);
            btnExportBrand.TabIndex = 5;
            btnExportBrand.Text = "Xuất";
            btnExportBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportBrand.UseVisualStyleBackColor = false;
            btnExportBrand.Click += btnExportBrand_Click;
            // 
            // btnRefreshBrand
            // 
            btnRefreshBrand.BackColor = Color.CornflowerBlue;
            btnRefreshBrand.FlatStyle = FlatStyle.Flat;
            btnRefreshBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshBrand.ForeColor = Color.White;
            btnRefreshBrand.Image = (Image)resources.GetObject("btnRefreshBrand.Image");
            btnRefreshBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshBrand.Location = new Point(667, 2);
            btnRefreshBrand.Margin = new Padding(2);
            btnRefreshBrand.Name = "btnRefreshBrand";
            btnRefreshBrand.Size = new Size(125, 45);
            btnRefreshBrand.TabIndex = 4;
            btnRefreshBrand.Text = "Làm mới";
            btnRefreshBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshBrand.UseVisualStyleBackColor = false;
            btnRefreshBrand.Click += btnRefreshBrand_Click;
            // 
            // btnSearchBrand
            // 
            btnSearchBrand.BackColor = Color.MediumAquamarine;
            btnSearchBrand.FlatStyle = FlatStyle.Flat;
            btnSearchBrand.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBrand.ForeColor = Color.White;
            btnSearchBrand.Image = (Image)resources.GetObject("btnSearchBrand.Image");
            btnSearchBrand.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchBrand.Location = new Point(498, 2);
            btnSearchBrand.Margin = new Padding(2);
            btnSearchBrand.Name = "btnSearchBrand";
            btnSearchBrand.Size = new Size(101, 45);
            btnSearchBrand.TabIndex = 3;
            btnSearchBrand.Text = "Tìm";
            btnSearchBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchBrand.UseVisualStyleBackColor = false;
            btnSearchBrand.Click += btnSearchBrand_Click;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(28, 42);
            lblBrandName.Margin = new Padding(2, 0, 2, 0);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(95, 32);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Hiệu xe";
            // 
            // dgvBrandDetail
            // 
            dgvBrandDetail.AllowUserToAddRows = false;
            dgvBrandDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBrandDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBrandDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBrandDetail.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBrandDetail.EnableHeadersVisualStyles = false;
            dgvBrandDetail.Location = new Point(0, 122);
            dgvBrandDetail.Margin = new Padding(2);
            dgvBrandDetail.Name = "dgvBrandDetail";
            dgvBrandDetail.ReadOnly = true;
            dgvBrandDetail.RowHeadersVisible = false;
            dgvBrandDetail.RowHeadersWidth = 82;
            dgvBrandDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrandDetail.Size = new Size(990, 377);
            dgvBrandDetail.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 88);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(390, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH HIỆU XE";
            // 
            // ListCarBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 591);
            Controls.Add(panel1);
            Controls.Add(pnlBrandDetail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1014, 638);
            MinimumSize = new Size(1014, 638);
            Name = "ListCarBrand";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DANH SÁCH HIỆU XE";
            pnlBrandDetail.ResumeLayout(false);
            pnlBrandDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrandDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBrandDetail;
        private Button btnRemoveBrand;
        private Button btnEditBrand;
        private Button btnAddBrand;
        private Button btnExportBrand;
        private Button btnRefreshBrand;
        private Button btnSearchBrand;
        private Label lblBrandName;
        private DataGridView dgvBrandDetail;
        private Panel panel1;
        private Label label1;
        private TextBox txtBrandName;
    }
}