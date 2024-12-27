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
using WinFormsApp.Model;

namespace WinFormsApp.Screens.Option
{
    public partial class UpdateWage : Form
    {
        public UpdateWage()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtWageType.Text)
                    || String.IsNullOrEmpty(txtValue.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                OptionDAO.Instance.UpdateWage(new Wage()
                {
                    NoiDung = txtWageType.Text,
                    TienCong = txtValue.Text
                });

                MessageBox.Show("Cập nhật thông tin thành công!");
            }
        }
    }
}
