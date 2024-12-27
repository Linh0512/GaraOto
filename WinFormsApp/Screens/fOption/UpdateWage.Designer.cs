﻿namespace WinFormsApp.Screens.Option
{
    partial class UpdateWage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWage));
            panel1 = new Panel();
            lblAddWage = new Label();
            btnClose = new Button();
            btnConfirm = new Button();
            txtValue = new TextBox();
            txtWageType = new TextBox();
            lblValue = new Label();
            lblWageType = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddWage);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 131);
            panel1.TabIndex = 9;
            // 
            // lblAddWage
            // 
            lblAddWage.AutoSize = true;
            lblAddWage.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWage.ForeColor = Color.White;
            lblAddWage.Location = new Point(368, 21);
            lblAddWage.Name = "lblAddWage";
            lblAddWage.Size = new Size(496, 81);
            lblAddWage.TabIndex = 0;
            lblAddWage.Text = "SỬA TIỀN CÔNG";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(655, 482);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 83);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Teal;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Image = (Image)resources.GetObject("btnConfirm.Image");
            btnConfirm.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirm.Location = new Point(347, 482);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(215, 83);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(522, 326);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(405, 54);
            txtValue.TabIndex = 13;
            // 
            // txtWageType
            // 
            txtWageType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageType.Location = new Point(522, 220);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(405, 54);
            txtWageType.TabIndex = 12;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValue.Location = new Point(212, 326);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(120, 50);
            lblValue.TabIndex = 11;
            lblValue.Text = "Giá trị";
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(212, 223);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(253, 50);
            lblWageType.TabIndex = 10;
            lblWageType.Text = "Loại tiền công";
            // 
            // UpdateWage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1194, 651);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnConfirm);
            Controls.Add(txtValue);
            Controls.Add(txtWageType);
            Controls.Add(lblValue);
            Controls.Add(lblWageType);
            MaximumSize = new Size(1220, 722);
            MinimumSize = new Size(1220, 722);
            Name = "UpdateWage";
            Text = "UpdateWage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddWage;
        private Button btnClose;
        private Button btnConfirm;
        private TextBox txtValue;
        private TextBox txtWageType;
        private Label lblValue;
        private Label lblWageType;
    }
}