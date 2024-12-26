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

namespace WinFormsApp.Screens.fOption
{
    public partial class UpdateBrand : Form
    {
        public UpdateBrand()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBrandName.Text))
                MessageBox.Show("Vui lòng nhập thông tin hãng xe!");
            else
            {
                OptionDAO.Instance.UpdateBrand(new Brand()
                {
                    HieuXe = txtBrandName.Text
                });

                MessageBox.Show("Cập nhật thông tin thành công!");
            }
        }
    }
}
