namespace WinFormsApp.Screens.fInventory
{
    partial class invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            a = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbb_inventory = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(135, 366);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(123, 59);
            button2.TabIndex = 29;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = SystemColors.GrayText;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(330, 366);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(123, 59);
            button3.TabIndex = 28;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 269);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 27;
            label3.Text = "Loại phụ tùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 192);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 24;
            label2.Text = "Ngày nhập hàng";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 132);
            panel2.TabIndex = 23;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(23, 35);
            a.Name = "a";
            a.Size = new Size(572, 54);
            a.TabIndex = 1;
            a.Text = "LẬP PHIẾU NHẬP PHỤ TÙNG";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(235, 192);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // cbb_inventory
            // 
            cbb_inventory.FormattingEnabled = true;
            cbb_inventory.Items.AddRange(new object[] { "Chọn phụ tùng", "Phụ tùng 1", "Phụ tùng 2", "Phụ tùng 3" });
            cbb_inventory.Location = new Point(235, 270);
            cbb_inventory.Margin = new Padding(3, 4, 3, 4);
            cbb_inventory.Name = "cbb_inventory";
            cbb_inventory.Size = new Size(292, 28);
            cbb_inventory.TabIndex = 31;
            // 
            // invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 494);
            Controls.Add(cbb_inventory);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(625, 541);
            MinimumSize = new Size(625, 541);
            Name = "invoice";
            Text = "LẬP PHIẾU NHẬP PHỤ TÙNG";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button3;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label a;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbb_inventory;
    }
}