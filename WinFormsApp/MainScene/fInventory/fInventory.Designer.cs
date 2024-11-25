

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
            btn_close = new Button();
            a = new Label();
            dataGridView1 = new DataGridView();
            vat_tu = new DataGridViewTextBoxColumn();
            gia_nhap = new DataGridViewTextBoxColumn();
            so_luong = new DataGridViewTextBoxColumn();
            don_gia = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_total = new TextBox();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            cbb_inventory = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btn_payment = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.None;
            btn_close.AutoSize = true;
            btn_close.BackColor = SystemColors.GrayText;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1319, 720);
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
            a.Location = new Point(542, 10);
            a.Name = "a";
            a.Size = new Size(396, 45);
            a.TabIndex = 1;
            a.Text = "Lập phiếu nhập phụ tùng";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vat_tu, gia_nhap, so_luong, don_gia });
            dataGridView1.Location = new Point(554, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(908, 516);
            dataGridView1.TabIndex = 2;
            // 
            // vat_tu
            // 
            vat_tu.HeaderText = "Vật tư";
            vat_tu.Name = "vat_tu";
            // 
            // gia_nhap
            // 
            gia_nhap.HeaderText = "Giá nhập";
            gia_nhap.Name = "gia_nhap";
            // 
            // so_luong
            // 
            so_luong.HeaderText = "Số lượng";
            so_luong.Name = "so_luong";
            // 
            // don_gia
            // 
            don_gia.HeaderText = "Đơn giá";
            don_gia.Name = "don_gia";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_total);
            panel1.Controls.Add(txt_quantity);
            panel1.Controls.Add(txt_price);
            panel1.Controls.Add(cbb_inventory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(61, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 612);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 260);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 18;
            label5.Text = "Tổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 203);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 17;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 153);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 16;
            label3.Text = "Giá nhập";
            // 
            // txt_total
            // 
            txt_total.Location = new Point(179, 261);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(256, 23);
            txt_total.TabIndex = 15;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(179, 204);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(256, 23);
            txt_quantity.TabIndex = 14;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(179, 150);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(256, 23);
            txt_price.TabIndex = 13;
            // 
            // cbb_inventory
            // 
            cbb_inventory.FormattingEnabled = true;
            cbb_inventory.Items.AddRange(new object[] { "Chọn phụ tùng", "Phụ tùng 1", "Phụ tùng 2", "Phụ tùng 3" });
            cbb_inventory.Location = new Point(179, 92);
            cbb_inventory.Name = "cbb_inventory";
            cbb_inventory.Size = new Size(256, 23);
            cbb_inventory.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên phụ tùng";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(89, 372);
            button2.Name = "button2";
            button2.Size = new Size(108, 44);
            button2.TabIndex = 10;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(260, 372);
            button3.Name = "button3";
            button3.Size = new Size(108, 44);
            button3.TabIndex = 9;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(61, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 49);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 1;
            label1.Text = "Bảng nhập vật tư";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(1262, 667);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // btn_payment
            // 
            btn_payment.Anchor = AnchorStyles.None;
            btn_payment.AutoSize = true;
            btn_payment.BackColor = SystemColors.Highlight;
            btn_payment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_payment.ForeColor = Color.White;
            btn_payment.Location = new Point(1146, 720);
            btn_payment.Name = "btn_payment";
            btn_payment.Size = new Size(146, 44);
            btn_payment.TabIndex = 8;
            btn_payment.Text = "Thanh toán";
            btn_payment.UseVisualStyleBackColor = false;
            btn_payment.Click += btn_payment_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(963, 790);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 9;
            button1.Text = "Thêm phụ tùng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1146, 790);
            button4.Name = "button4";
            button4.Size = new Size(146, 44);
            button4.TabIndex = 10;
            button4.Text = "Lập phiếu";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.AutoSize = true;
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1319, 790);
            button5.Name = "button5";
            button5.Size = new Size(146, 44);
            button5.TabIndex = 11;
            button5.Text = "Lịch sử";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1503, 857);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(btn_payment);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_close);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập phụ tùng";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private Label a;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn vat_tu;
        private DataGridViewTextBoxColumn gia_nhap;
        private DataGridViewTextBoxColumn so_luong;
        private DataGridViewTextBoxColumn don_gia;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Button btn_payment;
        private ComboBox cbb_inventory;
        private Label label2;
        private TextBox txt_total;
        private TextBox txt_quantity;
        private TextBox txt_price;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button4;
        private Button button5;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}