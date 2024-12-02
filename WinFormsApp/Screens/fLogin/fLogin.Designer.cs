namespace WinFormsApp
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            txbUserName = new TextBox();
            panel2 = new Panel();
            txbPassword = new TextBox();
            label1 = new Label();
            bnLogIn = new Button();
            bnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txbUserName);
            panel1.Location = new Point(113, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 49);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.AcceptsTab = true;
            txbUserName.Anchor = AnchorStyles.None;
            txbUserName.Location = new Point(11, 11);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(193, 27);
            txbUserName.TabIndex = 0;
            txbUserName.Text = "UserName";
            txbUserName.TextChanged += txbUserName_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(txbPassword);
            panel2.Location = new Point(113, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 49);
            panel2.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.AcceptsTab = true;
            txbPassword.Anchor = AnchorStyles.None;
            txbPassword.Location = new Point(11, 11);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(193, 27);
            txbPassword.TabIndex = 1;
            txbPassword.Text = "Password";
            txbPassword.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 64);
            label1.Name = "label1";
            label1.Size = new Size(310, 71);
            label1.TabIndex = 2;
            label1.Text = "GARA OTO";
            label1.Click += label1_Click;
            // 
            // bnLogIn
            // 
            bnLogIn.Anchor = AnchorStyles.None;
            bnLogIn.AutoSize = true;
            bnLogIn.BackColor = SystemColors.HotTrack;
            bnLogIn.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnLogIn.ForeColor = SystemColors.ButtonFace;
            bnLogIn.Location = new Point(162, 333);
            bnLogIn.Name = "bnLogIn";
            bnLogIn.Size = new Size(127, 50);
            bnLogIn.TabIndex = 3;
            bnLogIn.Text = "Log In";
            bnLogIn.UseVisualStyleBackColor = false;
            bnLogIn.Click += bnLogin_Click;
            // 
            // bnExit
            // 
            bnExit.Anchor = AnchorStyles.None;
            bnExit.AutoSize = true;
            bnExit.BackColor = Color.LightCoral;
            bnExit.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnExit.ForeColor = SystemColors.ButtonFace;
            bnExit.Location = new Point(162, 400);
            bnExit.Name = "bnExit";
            bnExit.Size = new Size(127, 51);
            bnExit.TabIndex = 4;
            bnExit.Text = "Exit";
            bnExit.UseVisualStyleBackColor = false;
            bnExit.Click += bnExit_Click;
            // 
            // fLogin
            // 
            AcceptButton = bnLogIn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 512);
            Controls.Add(bnExit);
            Controls.Add(bnLogIn);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(436, 559);
            MinimumSize = new Size(436, 559);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Panel panel2;
        private TextBox txbPassword;
        private Label label1;
        private Button bnLogIn;
        private Button bnExit;
    }
}