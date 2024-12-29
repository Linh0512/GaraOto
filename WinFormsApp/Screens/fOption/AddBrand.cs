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
using WinFormsApp.Utils;

namespace WinFormsApp.Screens.Option
{
    public partial class AddBrand : Form
    {
        public AddBrand()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(QuyDinhManager.Instance.canAddBrand() == false)
                {
                    MessageBox.Show("Số hãng xe đã đạt tối đa.");
                    return;
                }
                
                Brand.Instance = new Brand
                {
                    HieuXe = txtBrandName.Text,
                };

                if (string.IsNullOrWhiteSpace(txtBrandName.Text))
                {
                    MessageBox.Show("Vui lòng không để trống.");
                    return;
                }

                OptionDAO.Instance.AddBrand(Brand.Instance);
                MessageBox.Show("Thêm hãng xe thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
