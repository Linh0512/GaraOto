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
using WinFormsApp.MainScene;
using WinFormsApp.Screens.fService;

namespace WinFormsApp
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
            this.SetPlaceHolder(cbbChuXe, "Chủ xe");
            this.SetPlaceHolder(cbbTienNo, "Tiền nợ");
        }

        private void LoadCarData()
        {
            string query = "SELECT * FROM dbo.XE";
            DataProvider dataProvider = new DataProvider();
            dgvService.DataSource = dataProvider.ExecuteQuery(query);
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
            if (cbbTienNo.Text == "Tiền nợ")
            {
                cbbTienNo.Text = "";
            }
        }

        private void cbbChuXe_Click(object sender, EventArgs e)
        {
            if (cbbChuXe.Text == "Chủ xe")
            {
                cbbChuXe.Text = "";
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

        private void bnDetail_Click(object sender, EventArgs e)
        {
            fInforCar fInforCar = new fInforCar();
            if (dgvService.SelectedRows.Count > 0)
            {
                string customerName = dgvService.SelectedRows[0].Cells["TenChuXe"].Value.ToString();
                string licensePlate = dgvService.SelectedRows[0].Cells["BienSo"].Value.ToString();
                string carBrand = dgvService.SelectedRows[0].Cells["HieuXe"].Value.ToString();
                string phone = dgvService.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                string address = dgvService.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string date = dgvService.SelectedRows[0].Cells["NgayTiepNhan"].Value.ToString();
                string debt = dgvService.SelectedRows[0].Cells["TienNo"].Value.ToString();

                // Tạo form và thiết lập property
                fInforCar f = new fInforCar();
                fInforCar.lbCustomerName.Text = customerName;
                fInforCar.lbPlateLicense.Text = licensePlate;
                fInforCar.lbCarBrand.Text = carBrand;
                fInforCar.lbPhone.Text = phone;
                fInforCar.lbAddress.Text = address;
                fInforCar.dtpDateReceived.Text = date;
                fInforCar.lbDebt.Text = debt;

                fInforCar.ShowDialog();
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
    }
}
