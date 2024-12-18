using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Screens.Service.InforCar;
using WinFormsApp.Screens.Service.AddCar;

namespace WinFormsApp.Screens.Service
{
    public partial class fService : Form
    {
        public fService()
        {
            InitializeComponent();
            this.LoadCarData();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            this.SetPlaceHolder(cbbLicensePlate, "Biển số");
            this.SetPlaceHolder(cbbHieuXe, "Hiệu xe");
            this.SetPlaceHolder(cbbTenChuXe, "Chủ xe");
            this.SetPlaceHolder(cbbPhoneNumber, "Số điện thoại");
        }

        private void LoadCarData()
        {
            string query = "SELECT * FROM dbo.XE";
            ServiceDAO.Instance.LoadCarData(query, dgvService);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SetPlaceHolder(ComboBox cbb, string sph)
        {
            cbb.Text = sph;
            cbb.ForeColor = Color.Gray;

            cbb.Enter += (sender, e) =>
            {
                if (cbb.Text == sph)
                {
                    cbb.Text = "";
                    cbb.ForeColor = Color.Black;
                }
            };

            cbb.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(cbb.Text))
                {
                    cbb.Text = sph;
                    cbb.ForeColor = Color.Gray;
                }
            };
        }

        private void cbbLicensePlate_Click(object sender, EventArgs e)
        {
            if (cbbLicensePlate.Text == "Biển Số")
            {
                cbbLicensePlate.Text = "";
            }
        }

        private void cbbHieuXe_Click(object sender, EventArgs e)
        {
            if (cbbHieuXe.Text == "Hiệu xe")
            {
                cbbHieuXe.Text = "";
            }
        }

        private void cbbTienNo_Click(object sender, EventArgs e)
        {
            if (cbbPhoneNumber.Text == "Tiền nợ")
            {
                cbbPhoneNumber.Text = "";
            }
        }

        private void cbbChuXe_Click(object sender, EventArgs e)
        {
            if (cbbTenChuXe.Text == "Chủ xe")
            {
                cbbTenChuXe.Text = "";
            }
        }

        private void cbbHieuXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            fAddCar f = new fAddCar();
            f.ShowDialog();
            this.LoadCarData();
            this.Show();
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbLicensePlate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            fInforCar f = new fInforCar();
            Console.WriteLine(dgvService.SelectedRows.Count);
            if (dgvService.SelectedRows.Count > 0)
            {
                string customerName = dgvService.SelectedRows[0].Cells["TenChuXe"].Value.ToString();
                string licensePlate = dgvService.SelectedRows[0].Cells["BienSo"].Value.ToString();
                string carBrand = dgvService.SelectedRows[0].Cells["HieuXe"].Value.ToString();
                string phoneNumber = dgvService.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                string address = dgvService.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string date = dgvService.SelectedRows[0].Cells["NgayTiepNhan"].Value.ToString();
                string debt = dgvService.SelectedRows[0].Cells["TienNo"].Value.ToString();

                // Truyền thông tin sang fInforCar
                f.lbCustomerName.Text = customerName;
                f.lbPlateLicense.Text = licensePlate;
                f.lbCarBrand.Text = carBrand;
                f.lbPhone.Text = phoneNumber;
                f.lbAddress.Text = address;
                f.dtpDateReceived.Text = date;
                f.lbDebt.Text = debt;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before viewing details.");
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            string plateLicense = (string)dgvService.SelectedRows[0].Cells["BienSo"].Value;
            ServiceDAO.Instance.DelCar(plateLicense);
            this.LoadCarData();
        }

        private void bnFind_Click(object sender, EventArgs e)
        {
            string plateLicense = cbbLicensePlate.Text;
            string carBrand = cbbHieuXe.Text;
            string customerName = cbbTenChuXe.Text;
            string PhoneNumber = cbbPhoneNumber.Text;

            DataTable result = null;

            if (!string.IsNullOrEmpty(plateLicense) && plateLicense != "Biển số")
            {
                result = ServiceDAO.Instance.FindCar("BienSo", plateLicense);
            }
            else if (!string.IsNullOrEmpty(carBrand) && carBrand != "Hiệu xe")
            {
                result = ServiceDAO.Instance.FindCar("HieuXe", carBrand);
            }
            else if (!string.IsNullOrEmpty(customerName) && customerName != "Chủ xe")
            {
                result = ServiceDAO.Instance.FindCar("TenChuXe", customerName);
            }
            else if (!string.IsNullOrEmpty(PhoneNumber) && PhoneNumber != "Số điện thoại")
            {
                result = ServiceDAO.Instance.FindCar("DienThoai", PhoneNumber);
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với thông tin này.");
                this.LoadCarData();
                return;
            }

            if (result != null && result.Rows.Count > 0)
            {
                dgvService.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với thông tin này.");
            }
        }

        private void cbbChuXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadCarData();
        }
    }
}
