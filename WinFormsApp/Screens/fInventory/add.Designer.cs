namespace WinFormsApp.Screens.fInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add));
            panel2 = new Panel();
            a = new Label();
            label3 = new Label();
            txt_price = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            button3 = new Button();
            txtTenPT = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Location = new Point(-131, -9);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 132);
            panel2.TabIndex = 6;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(282, 37);
            a.Name = "a";
            a.Size = new Size(355, 54);
            a.TabIndex = 1;
            a.Text = "THÊM PHỤ TÙNG";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 242);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 20;
            label3.Text = "Giá bán";
            // 
            // txt_price
            // 
            txt_price.Anchor = AnchorStyles.None;
            txt_price.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_price.Location = new Point(235, 236);
            txt_price.Margin = new Padding(3, 4, 3, 4);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(292, 34);
            txt_price.TabIndex = 19;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 171);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 17;
            label2.Text = "Tên phụ tùng";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.AutoSize = true;
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(151, 350);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 59);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.GrayText;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(383, 350);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(123, 59);
            button3.TabIndex = 21;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtTenPT
            // 
            txtTenPT.Anchor = AnchorStyles.None;
            txtTenPT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenPT.Location = new Point(235, 162);
            txtTenPT.Name = "txtTenPT";
            txtTenPT.Size = new Size(292, 34);
            txtTenPT.TabIndex = 23;
            // 
            // add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 464);
            Controls.Add(txtTenPT);
            Controls.Add(btnThem);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(label2);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(668, 511);
            MinimumSize = new Size(668, 511);
            Name = "add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM PHỤ TÙNG";
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
        private Label label2;
        private Button btnThem;
        private Button button3;
        private TextBox txtTenPT;
    }
}