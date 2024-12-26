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

namespace WinFormsApp.MainScene.fOption
{
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier.Instance = new Supplier
                {
                    MaNCC = txtSupplierID.Text,
                    TenNCC = txtSupplierName.Text,
                    SDT = txtPhoneNumber.Text,
                    Email = txtEmail.Text
                };

                if (string.IsNullOrWhiteSpace(txtSupplierID.Text) ||
                    string.IsNullOrWhiteSpace(txtSupplierName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng không để trống.");
                    return;
                }

                OptionDAO.Instance.AddSupplier(Supplier.Instance);
                MessageBox.Show("Thêm nhà cung cấp thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
