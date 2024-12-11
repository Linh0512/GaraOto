namespace WinFormsApp.MainScene.fInventory
{
    partial class fPayment
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

        #endregion
        private void InitializeComponent()
        {
            btn_close = new Button();
            a = new Label();
            dataGridView1 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            vat_tu = new DataGridViewTextBoxColumn();
            gia_nhap = new DataGridViewTextBoxColumn();
            so_luong = new DataGridViewTextBoxColumn();
            don_gia = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txt_author = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label6 = new Label();
            panel3 = new Panel();
            textBox4 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label9 = new Label();
            label10 = new Label();
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
            btn_close.Location = new Point(1041, 715);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(366, 44);
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
            a.Location = new Point(586, 10);
            a.Name = "a";
            a.Size = new Size(322, 45);
            a.TabIndex = 1;
            a.Text = "Hóa đơn thanh toán";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stt, vat_tu, gia_nhap, so_luong, don_gia });
            dataGridView1.Location = new Point(12, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(941, 611);
            dataGridView1.TabIndex = 2;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.Name = "stt";
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
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(995, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 136);
            panel1.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(318, 94);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 21;
            label8.Text = "mast@gmail.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(364, 57);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 20;
            label7.Text = "1800 1539";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 19;
            label1.Text = "MAST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 94);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 18;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 57);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 17;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 19);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 16;
            label3.Text = "Nhà cung cấp";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(628, 578);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(628, 521);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 14;
            // 
            // txt_author
            // 
            txt_author.Location = new Point(249, 58);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(200, 23);
            txt_author.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 11;
            label2.Text = "Thông tin nhập hàng";
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
            dateTimePicker1.Location = new Point(249, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1041, 648);
            button1.Name = "button1";
            button1.Size = new Size(366, 44);
            button1.TabIndex = 8;
            button1.Text = "In hóa đơn";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(995, 92);
            label6.Name = "label6";
            label6.Size = new Size(173, 20);
            label6.TabIndex = 12;
            label6.Text = "Thông tin nhà cung cấp";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txt_author);
            panel3.Location = new Point(995, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 136);
            panel3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(249, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(28, 94);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 18;
            label12.Text = "Điện thoại";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(28, 57);
            label13.Name = "label13";
            label13.Size = new Size(92, 20);
            label13.TabIndex = 17;
            label13.Text = "Người nhập";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(28, 19);
            label14.Name = "label14";
            label14.Size = new Size(85, 20);
            label14.TabIndex = 16;
            label14.Text = "Ngày nhập";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(1180, 474);
            label9.Name = "label9";
            label9.Size = new Size(149, 40);
            label9.TabIndex = 20;
            label9.Text = "Tổng tiền";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(1192, 521);
            label10.Name = "label10";
            label10.Size = new Size(119, 40);
            label10.TabIndex = 23;
            label10.Text = "200000";
            // 
            // fPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 857);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btn_close);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fPayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hóa đơn nhập hàng";
            Load += Payment_Load;
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

        private Button btn_close;
        private Label a;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txt_author;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label8;
        private Panel panel3;
        private TextBox textBox4;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn vat_tu;
        private DataGridViewTextBoxColumn gia_nhap;
        private DataGridViewTextBoxColumn so_luong;
        private DataGridViewTextBoxColumn don_gia;
    }
}