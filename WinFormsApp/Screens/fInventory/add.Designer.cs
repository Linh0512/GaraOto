namespace WinFormsApp.MainScenne.fInventory
{
    partial class add
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
            panel2 = new Panel();
            a = new Label();
            label3 = new Label();
            txt_price = new TextBox();
            cbb_inventory = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Location = new Point(1, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 99);
            panel2.TabIndex = 6;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(274, 23);
            a.Name = "a";
            a.Size = new Size(250, 45);
            a.TabIndex = 1;
            a.Text = "Thêm phụ tùng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 231);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 20;
            label3.Text = "Giá nhập";
            // 
            // txt_price
            // 
            txt_price.Anchor = AnchorStyles.None;
            txt_price.Location = new Point(321, 228);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(256, 23);
            txt_price.TabIndex = 19;
            // 
            // cbb_inventory
            // 
            cbb_inventory.Anchor = AnchorStyles.None;
            cbb_inventory.FormattingEnabled = true;
            cbb_inventory.Items.AddRange(new object[] { "Chọn phụ tùng", "Phụ tùng 1", "Phụ tùng 2", "Phụ tùng 3" });
            cbb_inventory.Location = new Point(321, 170);
            cbb_inventory.Name = "cbb_inventory";
            cbb_inventory.Size = new Size(256, 23);
            cbb_inventory.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 173);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 17;
            label2.Text = "Tên phụ tùng";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(230, 343);
            button2.Name = "button2";
            button2.Size = new Size(108, 44);
            button2.TabIndex = 22;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.GrayText;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(401, 343);
            button3.Name = "button3";
            button3.Size = new Size(108, 44);
            button3.TabIndex = 21;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(cbb_inventory);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "add";
            Text = "add";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label a;
        private Label label3;
        private TextBox txt_price;
        private ComboBox cbb_inventory;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}