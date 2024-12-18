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
using Microsoft.Data.SqlClient;

namespace WinFormsApp.Screens.Service.AddService
{
    public partial class fAddService : Form
    {
        public Dictionary<string, object> ServiceDetails { get; private set; } // Lưu trữ thông tin dịch vụ

        public fAddService()
        {
            InitializeComponent();
            LoadAutoCompleteData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadAutoCompleteData()
        {
            // Tạo AutoCompleteCustomSource cho Tên vật tư
            AutoCompleteStringCollection itemSource = new AutoCompleteStringCollection();
            AutoCompleteStringCollection wageSource = new AutoCompleteStringCollection();

            using (SqlConnection conn = DataProvider.Instance.getConnect())
            {
                conn.Open();

                // Lấy danh sách tên vật tư
                string queryItems = "SELECT TenVTPT FROM PHUTUNG";
                SqlCommand cmdItems = new SqlCommand(queryItems, conn);
                SqlDataReader readerItems = cmdItems.ExecuteReader();
                while (readerItems.Read())
                {
                    itemSource.Add(readerItems["TenVTPT"].ToString());
                }
                readerItems.Close();

                // Lấy danh sách nội dung sửa chữa
                string queryWages = "SELECT NoiDung FROM TIENCONG";
                SqlCommand cmdWages = new SqlCommand(queryWages, conn);
                SqlDataReader readerWages = cmdWages.ExecuteReader();
                while (readerWages.Read())
                {
                    wageSource.Add(readerWages["NoiDung"].ToString());
                }
                readerWages.Close();

                conn.Close();
            }

            // Gán AutoCompleteSource cho các ComboBox
            cbbItem.AutoCompleteCustomSource = itemSource;
            cbbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbItem.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbbWage.AutoCompleteCustomSource = wageSource;
            cbbWage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbWage.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void cbbWage_Leave(object sender, EventArgs e)
        {
            string selectedWage = cbbWage.Text;
            try
            {
                if (!string.IsNullOrEmpty(selectedWage))
                {
                    using (SqlConnection conn = DataProvider.Instance.getConnect())
                    {
                        conn.Open();
                        string query = "SELECT TienCong FROM TIENCONG WHERE NoiDung = @NoiDung";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@NoiDung", selectedWage);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtWagePrice.Text = result.ToString(); // Điền Tiền công vào TextBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbbItem_Leave(object sender, EventArgs e)
        {
            string selectedItem = cbbItem.Text;
            try
            {
                if (!string.IsNullOrEmpty(selectedItem))
                {
                    using (SqlConnection conn = DataProvider.Instance.getConnect())
                    {
                        conn.Open();
                        string query = "SELECT DonGia FROM PHUTUNG WHERE TenVTPT = @TenVTPT";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@TenVTPT", selectedItem);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtPricePerUnit.Text = result.ToString(); // Điền Đơn giá vào TextBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kiểm tra các giá trị đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(cbbWage.Text) || string.IsNullOrEmpty(cbbItem.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPricePerUnit.Text) ||
                string.IsNullOrEmpty(txtWagePrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các TextBox và ComboBox
            ServiceDetails = new Dictionary<string, object>
            {
                {"NoiDung", cbbWage.Text},
                {"TenVTPT", cbbItem.Text},
                {"SoLuong", int.Parse(txtQuantity.Text)},
                {"DonGia", decimal.Parse(txtPricePerUnit.Text)},
                {"TienCong", decimal.Parse(txtWagePrice.Text)},
                {"ThanhTien", int.Parse(txtQuantity.Text) * decimal.Parse(txtPricePerUnit.Text) + decimal.Parse(txtWagePrice.Text)}
            };

            this.DialogResult = DialogResult.OK; // Trả kết quả OK về form chính
            this.Close();
        }

        private void UpdateTxtTotalMoney()
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) &&
                decimal.TryParse(txtPricePerUnit.Text, out decimal pricePerUnit) &&
                decimal.TryParse(txtWagePrice.Text, out decimal wagePrice))
            {
                decimal thanhTien = (quantity * pricePerUnit) + wagePrice;
                txtTotalMoney.Text = thanhTien.ToString();
            }
            else
            {
                txtTotalMoney.Text = "0";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTxtTotalMoney();
        }

        private void txtWagePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
