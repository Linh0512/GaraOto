﻿

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
            button1 = new Button();
            button5 = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            txtCode = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            btn_close.Location = new Point(1097, 655);
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
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1032, 115);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 655);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(167, 59);
            button1.TabIndex = 9;
            button1.Text = "Thêm phụ tùng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.AutoSize = true;
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(801, 655);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(194, 59);
            button5.TabIndex = 11;
            button5.Text = "Lịch sử nhập hàng";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(587, 107);
            button2.Name = "button2";
            button2.Size = new Size(116, 42);
            button2.TabIndex = 15;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(263, 655);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(176, 59);
            button3.TabIndex = 16;
            button3.Text = "Nhập phụ tùng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(543, 655);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(176, 59);
            button4.TabIndex = 17;
            button4.Text = "Xóa phụ tùng";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1272, 740);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtCode);
            Controls.Add(button5);
            Controls.Add(button1);
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
        private Button button1;
        private Button button5;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox txtCode;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}