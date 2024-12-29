

namespace WinFormsApp
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            btn_close = new Button();
            a = new Label();
            dgvPhuTung = new DataGridView();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnAddSupply = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            txtCode = new TextBox();
            btnSearch = new Button();
            btnImportSupplies = new Button();
            btnDelete = new Button();
            btnUpdateInfor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhuTung).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.None;
            btn_close.AutoSize = true;
            btn_close.BackColor = SystemColors.GrayText;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1079, 655);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(163, 59);
            btn_close.TabIndex = 0;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(401, 9);
            a.Name = "a";
            a.Size = new Size(479, 54);
            a.TabIndex = 1;
            a.Text = "DANH SÁCH PHỤ TÙNG";
            // 
            // dgvPhuTung
            // 
            dgvPhuTung.AllowUserToAddRows = false;
            dgvPhuTung.AllowUserToDeleteRows = false;
            dgvPhuTung.Anchor = AnchorStyles.None;
            dgvPhuTung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhuTung.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhuTung.Location = new Point(0, 163);
            dgvPhuTung.Margin = new Padding(3, 4, 3, 4);
            dgvPhuTung.Name = "dgvPhuTung";
            dgvPhuTung.ReadOnly = true;
            dgvPhuTung.RowHeadersVisible = false;
            dgvPhuTung.RowHeadersWidth = 51;
            dgvPhuTung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhuTung.Size = new Size(1272, 471);
            dgvPhuTung.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1272, 89);
            panel2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1032, 115);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // btnAddSupply
            // 
            btnAddSupply.Anchor = AnchorStyles.None;
            btnAddSupply.AutoSize = true;
            btnAddSupply.BackColor = SystemColors.Highlight;
            btnAddSupply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupply.ForeColor = Color.White;
            btnAddSupply.Location = new Point(20, 655);
            btnAddSupply.Margin = new Padding(3, 4, 3, 4);
            btnAddSupply.Name = "btnAddSupply";
            btnAddSupply.Size = new Size(167, 59);
            btnAddSupply.TabIndex = 9;
            btnAddSupply.Text = "Thêm phụ tùng";
            btnAddSupply.UseVisualStyleBackColor = false;
            btnAddSupply.Click += AddSupply_Click;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(20, 115);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Tên phụ tùng....";
            txtCode.Size = new Size(496, 34);
            txtCode.TabIndex = 14;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SkyBlue;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(571, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 42);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button2_Click;
            // 
            // btnImportSupplies
            // 
            btnImportSupplies.Anchor = AnchorStyles.None;
            btnImportSupplies.AutoSize = true;
            btnImportSupplies.BackColor = SystemColors.Highlight;
            btnImportSupplies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportSupplies.ForeColor = Color.White;
            btnImportSupplies.Location = new Point(358, 655);
            btnImportSupplies.Margin = new Padding(3, 4, 3, 4);
            btnImportSupplies.Name = "btnImportSupplies";
            btnImportSupplies.Size = new Size(176, 59);
            btnImportSupplies.TabIndex = 16;
            btnImportSupplies.Text = "Nhập phụ tùng";
            btnImportSupplies.UseVisualStyleBackColor = false;
            btnImportSupplies.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(720, 655);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 59);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa phụ tùng";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button4_Click_1;
            // 
            // btnUpdateInfor
            // 
            btnUpdateInfor.BackColor = Color.Silver;
            btnUpdateInfor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateInfor.Location = new Point(744, 111);
            btnUpdateInfor.Name = "btnUpdateInfor";
            btnUpdateInfor.Size = new Size(201, 42);
            btnUpdateInfor.TabIndex = 18;
            btnUpdateInfor.Text = "Thay đổi thông tin";
            btnUpdateInfor.UseVisualStyleBackColor = false;
            btnUpdateInfor.Click += btnUpdateInfor_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1272, 740);
            Controls.Add(btnUpdateInfor);
            Controls.Add(btnDelete);
            Controls.Add(btnImportSupplies);
            Controls.Add(btnSearch);
            Controls.Add(txtCode);
            Controls.Add(btnAddSupply);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel2);
            Controls.Add(dgvPhuTung);
            Controls.Add(btn_close);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1290, 787);
            MinimumSize = new Size(1290, 787);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DANH SÁCH PHỤ TÙNG";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhuTung).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private Label a;
        private DataGridView dgvPhuTung;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Button btnAddSupply;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox txtCode;
        private Button btnSearch;
        private Button btnImportSupplies;
        private Button btnDelete;
        private Button btnUpdateInfor;
    }
}