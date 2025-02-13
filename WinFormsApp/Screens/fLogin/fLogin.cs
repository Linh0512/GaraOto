﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Screens.MainScene;
using WinFormsApp.DAO;

namespace WinFormsApp.Screens.Login
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.SetPlaceHolder(txbUserName, "UserName");
            this.SetPlaceHolder(txbPassword, "Password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetPlaceHolder(TextBox txb, string sph)
        {
            txb.Text = sph;
            txb.ForeColor = Color.Gray;

            txb.Enter += (sender, e) =>
            {
                if (txb.Text == sph)
                {
                    txb.Text = "";
                    txb.ForeColor = Color.Black;
                    if(txb == txbPassword)
                    {
                        txb.PasswordChar = '*';
                    }
                }
            };

            txb.Leave += (sender, e) => {
                if (string.IsNullOrWhiteSpace(txb.Text))
                {
                    txb.Text = sph;
                    txb.ForeColor = Color.Gray;
                    if (txb == txbPassword)
                    {
                        txb.PasswordChar = '\0';
                    }
                }
            };
        }

        private void bnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txbUserName.Text;
                String password = txbPassword.Text;
                
                if(AuthDAO.Instance.Login(username, password))
                {
                    MainScence f = new MainScence();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }   
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi đăng nhập: " + exception.Message);
            }
        }


        private void bnExit_Click(object sender, EventArgs e)
        {
            AuthDAO.Instance.Logout();
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
