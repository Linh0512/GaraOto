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
        private string SupplierID;
        private string SupplierName;
        private string PhoneNumber;
        private string Email;
        public UpdateSupplier(string supplierID, string supplierName, string phoneNumber, string email)
        {
            InitializeComponent();
            SupplierID = supplierID;
            SupplierName = supplierName;
            PhoneNumber = phoneNumber;
            Email = email;

            // Populate fields
            txtSupplierName.Text = SupplierName;
            txtPhoneNumber.Text = PhoneNumber;
            txtEmail.Text = Email;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSupplierName.Text) ||
                String.IsNullOrEmpty(txtPhoneNumber.Text) || String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            OptionDAO.Instance.UpdateSupplier(new Supplier()
            {
                MaNCC = SupplierID,
                TenNCC = txtSupplierName.Text,
                SDT = txtPhoneNumber.Text,
                Email = txtEmail.Text
            });

            MessageBox.Show("Cập nhật thông tin thành công!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
