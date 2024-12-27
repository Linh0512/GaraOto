using ClosedXML.Excel;
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
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSupplierName.Text)
                    || String.IsNullOrEmpty(txtPhoneNumber.Text) || String.IsNullOrEmpty(txtEmail.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                OptionDAO.Instance.UpdateSupplier(new Supplier()
                {
                    TenNCC = txtSupplierName.Text,
                    SDT = txtPhoneNumber.Text,
                    Email = txtEmail.Text
                });

                MessageBox.Show("Cập nhật thông tin thành công!");
            }
        }
    }
}
