namespace WinFormsApp.MainScenne.fInventory
{
    partial class history
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_close = new Button();
            a = new Label();
            dataGridView1 = new DataGridView();
            vat_tu = new DataGridViewTextBoxColumn();
            gia_nhap = new DataGridViewTextBoxColumn();
            so_luong = new DataGridViewTextBoxColumn();
            don_gia = new DataGridViewTextBoxColumn();
            txt_code = new TextBox();
            cbb_provider = new ComboBox();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btn_close.Location = new Point(1312, 801);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(143, 44);
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
            a.Location = new Point(610, 10);
            a.Name = "a";
            a.Size = new Size(291, 45);
            a.TabIndex = 1;
            a.Text = "Lịch sử nhập hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vat_tu, gia_nhap, so_luong, don_gia });
            dataGridView1.Location = new Point(12, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1479, 637);
            dataGridView1.TabIndex = 2;
            // 
            // vat_tu
            // 
            vat_tu.HeaderText = "ID";
            vat_tu.Name = "vat_tu";
            // 
            // gia_nhap
            // 
            gia_nhap.HeaderText = "Ngày nhập hàng";
            gia_nhap.Name = "gia_nhap";
            // 
            // so_luong
            // 
            so_luong.HeaderText = "Tổng tiền thanh toán";
            so_luong.Name = "so_luong";
            // 
            // don_gia
            // 
            don_gia.HeaderText = "Đơn vị cung cấp";
            don_gia.Name = "don_gia";
            // 
            // txt_code
            // 
            txt_code.Anchor = AnchorStyles.None;
            txt_code.Location = new Point(12, 106);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(192, 23);
            txt_code.TabIndex = 13;
            // 
            // cbb_provider
            // 
            cbb_provider.Anchor = AnchorStyles.None;
            cbb_provider.FormattingEnabled = true;
            cbb_provider.Items.AddRange(new object[] { "Đơn vị cung cấp", "Đơn vị 1", "Đơn vị 2", "Đơn vị 3" });
            cbb_provider.Location = new Point(434, 106);
            cbb_provider.Name = "cbb_provider";
            cbb_provider.Size = new Size(256, 23);
            cbb_provider.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1479, 67);
            panel2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(219, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(709, 91);
            button1.Name = "button1";
            button1.Size = new Size(113, 38);
            button1.TabIndex = 14;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(982, 91);
            button2.Name = "button2";
            button2.Size = new Size(113, 38);
            button2.TabIndex = 15;
            button2.Text = "Xuất";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.Desktop;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(845, 91);
            button3.Name = "button3";
            button3.Size = new Size(113, 38);
            button3.TabIndex = 16;
            button3.Text = "Làm mới";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1312, 88);
            button4.Name = "button4";
            button4.Size = new Size(143, 44);
            button4.TabIndex = 17;
            button4.Text = "Xem";
            button4.UseVisualStyleBackColor = false;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1503, 857);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel2);
            Controls.Add(txt_code);
            Controls.Add(dataGridView1);
            Controls.Add(cbb_provider);
            Controls.Add(btn_close);
            Margin = new Padding(3, 2, 3, 2);
            Name = "history";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lịch sử nhập hàng";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_close;
        private Label a;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbb_provider;
        private TextBox txt_code;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn vat_tu;
        private DataGridViewTextBoxColumn gia_nhap;
        private DataGridViewTextBoxColumn so_luong;
        private DataGridViewTextBoxColumn don_gia;
    }
}