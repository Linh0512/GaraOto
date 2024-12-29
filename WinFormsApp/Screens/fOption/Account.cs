using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Screens.fOption
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            this.loadUserInfor();
        }

        private void loadUserInfor()
        {
            txtUsername.Text = SessionManager.Instance.CurrentUser.TenDangNhap;
            txtAddress.Text = SessionManager.Instance.CurrentUser.DiaChi;
            txtPhoneNumber.Text = SessionManager.Instance.CurrentUser.DienThoai;
            txtEmail.Text = SessionManager.Instance.CurrentUser.Email;
            txtChucVu.Text = SessionManager.Instance.CurrentUser.ChucVu;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ChangePassword updatePassword = new ChangePassword();
            updatePassword.ShowDialog();
            this.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
