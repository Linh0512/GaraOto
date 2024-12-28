namespace WinFormsApp.Screens.fInventory
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            btn_close = new System.Windows.Forms.Button();
            a = new System.Windows.Forms.Label();
            dgvHistory = new System.Windows.Forms.DataGridView();
            txt_code = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            radiobtncode = new System.Windows.Forms.RadioButton();
            radiobtnNgayLap = new System.Windows.Forms.RadioButton();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_close.AutoSize = true;
            btn_close.BackColor = System.Drawing.SystemColors.GrayText;
            btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_close.ForeColor = System.Drawing.Color.White;
            btn_close.Location = new System.Drawing.Point(1215, 912);
            btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new System.Drawing.Size(163, 59);
            btn_close.TabIndex = 0;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            a.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            a.Location = new System.Drawing.Point(88, 21);
            a.Name = "a";
            a.Size = new System.Drawing.Size(1183, 65);
            a.TabIndex = 1;
            a.Text = "DANH SÁCH PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new System.Drawing.Point(-2, 214);
            dgvHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new System.Drawing.Size(1153, 525);
            dgvHistory.TabIndex = 2;
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
            // 
            // txt_code
            // 
            txt_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            txt_code.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            txt_code.Location = new System.Drawing.Point(103, 101);
            txt_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_code.Name = "txt_code";
            txt_code.PlaceholderText = "Mã phiếu nhập, tên nhà cung cấp,...";
            txt_code.Size = new System.Drawing.Size(667, 39);
            txt_code.TabIndex = 13;
            txt_code.TextChanged += txt_code_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1150, 89);
            panel2.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpEndDate.Location = new System.Drawing.Point(143, 179);
            dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(177, 31);
            dtpEndDate.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = System.Drawing.SystemColors.GrayText;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(786, 93);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(129, 51);
            button1.TabIndex = 14;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = System.Drawing.Color.Green;
            button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(786, 152);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(129, 51);
            button2.TabIndex = 15;
            button2.Text = "Xuất";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = System.Drawing.SystemColors.Desktop;
            button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(974, 94);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(163, 51);
            button3.TabIndex = 16;
            button3.Text = "Làm mới";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = System.Drawing.SystemColors.HotTrack;
            button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new System.Drawing.Point(974, 153);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(163, 51);
            button4.TabIndex = 17;
            button4.Text = "Xem chi tiết";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // radiobtncode
            // 
            radiobtncode.AutoSize = true;
            radiobtncode.Checked = true;
            radiobtncode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            radiobtncode.Location = new System.Drawing.Point(105, 149);
            radiobtncode.Name = "radiobtncode";
            radiobtncode.Size = new System.Drawing.Size(403, 34);
            radiobtncode.TabIndex = 18;
            radiobtncode.TabStop = true;
            radiobtncode.Text = "Tìm theo mã phiếu nhập, nhà cung cấp";
            radiobtncode.UseVisualStyleBackColor = true;
            radiobtncode.CheckedChanged += radiobtncode_CheckedChanged;
            // 
            // radiobtnNgayLap
            // 
            radiobtnNgayLap.AutoSize = true;
            radiobtnNgayLap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            radiobtnNgayLap.Location = new System.Drawing.Point(555, 146);
            radiobtnNgayLap.Name = "radiobtnNgayLap";
            radiobtnNgayLap.Size = new System.Drawing.Size(263, 34);
            radiobtnNgayLap.TabIndex = 19;
            radiobtnNgayLap.Text = "Tìm theo ngày lập phiếu";
            radiobtnNgayLap.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpStartDate.Location = new System.Drawing.Point(504, 177);
            dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(177, 31);
            dtpStartDate.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 186);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 25);
            label1.TabIndex = 21;
            label1.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(397, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 25);
            label2.TabIndex = 22;
            label2.Text = "Ngày kết thúc:";
            // 
            // history
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1150, 742);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpStartDate);
            Controls.Add(radiobtnNgayLap);
            Controls.Add(radiobtncode);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpEndDate);
            Controls.Add(panel2);
            Controls.Add(txt_code);
            Controls.Add(dgvHistory);
            Controls.Add(btn_close);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximumSize = new System.Drawing.Size(1172, 798);
            MinimumSize = new System.Drawing.Size(1172, 798);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DANH SÁCH PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_close;
        private Label a;
        private DataGridView dgvHistory;
        private Panel panel2;
        private DateTimePicker dtpEndDate;
        private TextBox txt_code;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.RadioButton radiobtncode;
        private RadioButton radiobtnNgayLap;
        private DateTimePicker dtpStartDate;
        private Label label1;
        private Label label2;
    }
}