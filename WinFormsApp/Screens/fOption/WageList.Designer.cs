namespace WinFormsApp.Screens.fOption
{
    partial class WageList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WageList));
            pnlWageDetail = new Panel();
            lblWageID = new Label();
            dgvWageDetail = new DataGridView();
            btnRemoveWage = new Button();
            btnEditWage = new Button();
            btnAddWage = new Button();
            btnExportWage = new Button();
            btnRefreshWage = new Button();
            btnSearchWage = new Button();
            lblWageType = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txtWageID = new TextBox();
            txtWageType = new TextBox();
            pnlWageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWageDetail).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlWageDetail
            // 
            pnlWageDetail.BackColor = SystemColors.ControlLightLight;
            pnlWageDetail.Controls.Add(txtWageType);
            pnlWageDetail.Controls.Add(txtWageID);
            pnlWageDetail.Controls.Add(lblWageID);
            pnlWageDetail.Controls.Add(dgvWageDetail);
            pnlWageDetail.Controls.Add(btnRemoveWage);
            pnlWageDetail.Controls.Add(btnEditWage);
            pnlWageDetail.Controls.Add(btnAddWage);
            pnlWageDetail.Controls.Add(btnExportWage);
            pnlWageDetail.Controls.Add(btnRefreshWage);
            pnlWageDetail.Controls.Add(btnSearchWage);
            pnlWageDetail.Controls.Add(lblWageType);
            pnlWageDetail.Location = new Point(0, 92);
            pnlWageDetail.Margin = new Padding(2);
            pnlWageDetail.Name = "pnlWageDetail";
            pnlWageDetail.Size = new Size(953, 522);
            pnlWageDetail.TabIndex = 7;
            // 
            // lblWageID
            // 
            lblWageID.AutoSize = true;
            lblWageID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageID.Location = new Point(12, 31);
            lblWageID.Margin = new Padding(2, 0, 2, 0);
            lblWageID.Name = "lblWageID";
            lblWageID.Size = new Size(48, 32);
            lblWageID.TabIndex = 11;
            lblWageID.Text = "Mã";
            // 
            // dgvWageDetail
            // 
            dgvWageDetail.AllowUserToAddRows = false;
            dgvWageDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWageDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWageDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWageDetail.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWageDetail.EnableHeadersVisualStyles = false;
            dgvWageDetail.Location = new Point(12, 150);
            dgvWageDetail.Margin = new Padding(2);
            dgvWageDetail.Name = "dgvWageDetail";
            dgvWageDetail.ReadOnly = true;
            dgvWageDetail.RowHeadersVisible = false;
            dgvWageDetail.RowHeadersWidth = 82;
            dgvWageDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWageDetail.Size = new Size(917, 362);
            dgvWageDetail.TabIndex = 9;
            // 
            // btnRemoveWage
            // 
            btnRemoveWage.BackColor = Color.IndianRed;
            btnRemoveWage.FlatStyle = FlatStyle.Flat;
            btnRemoveWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveWage.ForeColor = Color.White;
            btnRemoveWage.Image = (Image)resources.GetObject("btnRemoveWage.Image");
            btnRemoveWage.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveWage.Location = new Point(817, 78);
            btnRemoveWage.Margin = new Padding(2);
            btnRemoveWage.Name = "btnRemoveWage";
            btnRemoveWage.Size = new Size(112, 52);
            btnRemoveWage.TabIndex = 8;
            btnRemoveWage.Text = "Xóa";
            btnRemoveWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveWage.UseVisualStyleBackColor = false;
            btnRemoveWage.Click += btnRemoveWage_Click;
            // 
            // btnEditWage
            // 
            btnEditWage.BackColor = Color.RoyalBlue;
            btnEditWage.FlatStyle = FlatStyle.Flat;
            btnEditWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditWage.ForeColor = Color.White;
            btnEditWage.Image = (Image)resources.GetObject("btnEditWage.Image");
            btnEditWage.ImageAlign = ContentAlignment.MiddleRight;
            btnEditWage.Location = new Point(661, 78);
            btnEditWage.Margin = new Padding(2);
            btnEditWage.Name = "btnEditWage";
            btnEditWage.Size = new Size(141, 52);
            btnEditWage.TabIndex = 7;
            btnEditWage.Text = "Sửa";
            btnEditWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditWage.UseVisualStyleBackColor = false;
            btnEditWage.Click += btnEditWage_Click;
            // 
            // btnAddWage
            // 
            btnAddWage.BackColor = Color.Teal;
            btnAddWage.FlatStyle = FlatStyle.Flat;
            btnAddWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWage.ForeColor = Color.White;
            btnAddWage.Image = (Image)resources.GetObject("btnAddWage.Image");
            btnAddWage.ImageAlign = ContentAlignment.MiddleRight;
            btnAddWage.Location = new Point(534, 78);
            btnAddWage.Margin = new Padding(2);
            btnAddWage.Name = "btnAddWage";
            btnAddWage.Size = new Size(106, 52);
            btnAddWage.TabIndex = 6;
            btnAddWage.Text = "Thêm";
            btnAddWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddWage.UseVisualStyleBackColor = false;
            btnAddWage.Click += btnAddWage_Click;
            // 
            // btnExportWage
            // 
            btnExportWage.BackColor = Color.LightCoral;
            btnExportWage.FlatStyle = FlatStyle.Flat;
            btnExportWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportWage.ForeColor = Color.White;
            btnExportWage.Image = (Image)resources.GetObject("btnExportWage.Image");
            btnExportWage.ImageAlign = ContentAlignment.MiddleRight;
            btnExportWage.Location = new Point(817, 18);
            btnExportWage.Margin = new Padding(2);
            btnExportWage.Name = "btnExportWage";
            btnExportWage.Size = new Size(112, 45);
            btnExportWage.TabIndex = 5;
            btnExportWage.Text = "Xuất";
            btnExportWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportWage.UseVisualStyleBackColor = false;
            btnExportWage.Click += btnExportWage_Click;
            // 
            // btnRefreshWage
            // 
            btnRefreshWage.BackColor = Color.CornflowerBlue;
            btnRefreshWage.FlatStyle = FlatStyle.Flat;
            btnRefreshWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshWage.ForeColor = Color.White;
            btnRefreshWage.Image = (Image)resources.GetObject("btnRefreshWage.Image");
            btnRefreshWage.ImageAlign = ContentAlignment.MiddleRight;
            btnRefreshWage.Location = new Point(661, 18);
            btnRefreshWage.Margin = new Padding(2);
            btnRefreshWage.Name = "btnRefreshWage";
            btnRefreshWage.Size = new Size(141, 45);
            btnRefreshWage.TabIndex = 4;
            btnRefreshWage.Text = "Làm mới";
            btnRefreshWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefreshWage.UseVisualStyleBackColor = false;
            btnRefreshWage.Click += btnRefreshWage_Click;
            // 
            // btnSearchWage
            // 
            btnSearchWage.BackColor = Color.MediumAquamarine;
            btnSearchWage.FlatStyle = FlatStyle.Flat;
            btnSearchWage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchWage.ForeColor = Color.White;
            btnSearchWage.Image = (Image)resources.GetObject("btnSearchWage.Image");
            btnSearchWage.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchWage.Location = new Point(534, 18);
            btnSearchWage.Margin = new Padding(2);
            btnSearchWage.Name = "btnSearchWage";
            btnSearchWage.Size = new Size(106, 45);
            btnSearchWage.TabIndex = 3;
            btnSearchWage.Text = "Tìm";
            btnSearchWage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchWage.UseVisualStyleBackColor = false;
            btnSearchWage.Click += btnSearchWage_Click;
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(239, 31);
            lblWageType.Margin = new Padding(2, 0, 2, 0);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(165, 32);
            lblWageType.TabIndex = 0;
            lblWageType.Text = "Loại tiền công";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 88);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 20);
            label1.Name = "label1";
            label1.Size = new Size(447, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH TIỀN CÔNG";
            // 
            // txtWageID
            // 
            txtWageID.Location = new Point(12, 78);
            txtWageID.Name = "txtWageID";
            txtWageID.Size = new Size(125, 27);
            txtWageID.TabIndex = 12;
            // 
            // txtWageType
            // 
            txtWageType.Location = new Point(239, 78);
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(219, 27);
            txtWageType.TabIndex = 13;
            // 
            // WageList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 625);
            Controls.Add(panel1);
            Controls.Add(pnlWageDetail);
            MaximumSize = new Size(971, 672);
            MinimumSize = new Size(971, 672);
            Name = "WageList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WageList";
            pnlWageDetail.ResumeLayout(false);
            pnlWageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWageDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWageDetail;
        private Label lblWageID;
        private DataGridView dgvWageDetail;
        private Button btnRemoveWage;
        private Button btnEditWage;
        private Button btnAddWage;
        private Button btnExportWage;
        private Button btnRefreshWage;
        private Button btnSearchWage;
        private Label lblWageType;
        private Panel panel1;
        private Label label1;
        private TextBox txtWageType;
        private TextBox txtWageID;
    }
}