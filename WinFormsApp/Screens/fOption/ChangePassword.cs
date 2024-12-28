using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;

namespace WinFormsApp.Screens.fOption
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = txtOldPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                string username = SessionManager.Instance.CurrentUser.TenDangNhap;
                
                if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
        
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
        
                if (AuthDAO.Instance.ChangePassword(username, oldPassword, newPassword))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        // private void btnAdd_Click(object sender, EventArgs e)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}
