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
using WinFormsApp.Screens.Service.ListPayment;
using WinFormsApp.Screens.Service.UpdateInforCar;
using WinFormsApp.Screens.Service.ListRepair;
using WinFormsApp.Screens.Service.Payment;
using WinFormsApp.Utils;


namespace WinFormsApp.Screens.Service
{
    public partial class fService : Form
    {
        public fService()
        {
            InitializeComponent();
            this.LoadCarData();
            this.LoadAutoCompleteData();
            CheckPermissions();
            // LoadCarBrandData();
        }

        private void CheckPermissions()
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                btnChangeInfor.Enabled = false;
                bnXoa.Enabled = false;
                btnAddService.Enabled = false;
            }
        }

        private void Service_Load(object sender, EventArgs e)
        {
            General.Instance.CbbMakeTextDisappear(cbbLicensePlate, "Biển số");
            General.Instance.CbbMakeTextDisappear(cbbCarBrand, "Hiệu xe");
            General.Instance.CbbMakeTextDisappear(cbbCustomerName, "Chủ xe");
            General.Instance.CbbMakeTextDisappear(cbbPhoneNumber, "Số điện thoại");
        }


        private void LoadCarData()
        {
            string query = "SELECT BienSo AS 'Biển số', TenChuXe 'Tên chủ xe', HieuXe 'Hiệu xe', DiaChi 'Địa chỉ', " +
                "DienThoai 'Số điện thoại', Email 'Email', TienNo 'Tiền nợ', NgayTiepNhan AS 'Ngày tiếp nhận' FROM dbo.XE";
            ServiceDAO.instance.LoadData(query, dtgvService);
        }

        //load auto complete data
        private void LoadAutoCompleteData()
        {
            this.GetLicensePlateAutoComplete();
            this.GetPhoneNumberAutoComplete();
            this.GetCustomerNameAutoComplete();
            this.GetCarBrandAutoComplete();
        }

        private void GetLicensePlateAutoComplete()
        {
            string queryLicensePlate = "SELECT DISTINCT BienSo FROM dbo.XE";
            string columnLicensePlate = "BienSo";
            cbbLicensePlate.AutoCompleteCustomSource =
                ServiceDAO.instance.LoadAutoCompleteData(queryLicensePlate, columnLicensePlate);
            cbbLicensePlate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbLicensePlate.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void GetPhoneNumberAutoComplete()
        {
            string queryPhoneNumber = "SELECT DISTINCT DienThoai FROM dbo.XE";
            string columnPhoneNumber = "DienThoai";
            cbbPhoneNumber.AutoCompleteCustomSource =
                ServiceDAO.instance.LoadAutoCompleteData(queryPhoneNumber, columnPhoneNumber);
            cbbPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void GetCustomerNameAutoComplete()
        {
            string queryCustomerName = "SELECT DISTINCT TenChuXe FROM dbo.XE";
            string columnCustomerName = "TenChuXe";
            cbbCustomerName.AutoCompleteCustomSource =
                ServiceDAO.instance.LoadAutoCompleteData(queryCustomerName, columnCustomerName);
            cbbCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void GetCarBrandAutoComplete()
        {
            string queryCarBrand = "SELECT DISTINCT HieuXe FROM dbo.HIEUXE ORDER BY HieuXe";
            string columnCarBrand = "HieuXe";

            // Set up AutoComplete
            cbbCarBrand.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryCarBrand, columnCarBrand);
            cbbCarBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCarBrand.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
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
            if (cbbCarBrand.Text == "Hiệu xe")
            {
                cbbCarBrand.Text = "";
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
            if (cbbCustomerName.Text == "Chủ xe")
            {
                cbbCustomerName.Text = "";
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
            DataUpdateEvent.NotifyCarListChanged();
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
            if (dtgvService.SelectedRows.Count > 0)
            {
                string customerName = dtgvService.SelectedRows[0].Cells[1].Value.ToString();
                string licensePlate = dtgvService.SelectedRows[0].Cells[0].Value.ToString();
                string carBrand = dtgvService.SelectedRows[0].Cells[2].Value.ToString();
                string phoneNumber = dtgvService.SelectedRows[0].Cells[4].Value.ToString();
                string address = dtgvService.SelectedRows[0].Cells[3].Value.ToString();
                string date = dtgvService.SelectedRows[0].Cells[7].Value.ToString();
                string debt = dtgvService.SelectedRows[0].Cells[6].Value.ToString();
                string email = dtgvService.SelectedRows[0].Cells[5].Value.ToString();

                // Truyền thông tin sang fInforCar
                f.lbCustomerName.Text = customerName;
                f.lbPlateLicense.Text = licensePlate;
                f.lbCarBrand.Text = carBrand;
                f.lbPhone.Text = phoneNumber;
                f.lbAddress.Text = address;
                f.dtpDateReceived.Text = date;
                f.lbDebt.Text = debt;
                f.lbEmail.Text = email;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before viewing details.");
            }

            this.dtgvService.Refresh();
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            string plateLicense = (string)dtgvService.SelectedRows[0].Cells[0].Value;
            ServiceDAO.instance.DelCar(plateLicense);
            this.LoadCarData();
        }

        private void bnFind_Click(object sender, EventArgs e)
        {
            string plateLicense = cbbLicensePlate.Text.Trim();
            string carBrand = cbbCarBrand.Text.Trim();
            string customerName = cbbCustomerName.Text.Trim();
            string phoneNumber = cbbPhoneNumber.Text.Trim();

            // Tạo dictionary chứa các điều kiện tìm kiếm
            Dictionary<string, string> conditions = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(plateLicense) && plateLicense != "Biển số")
            {
                conditions.Add("BienSo", plateLicense);
            }

            if (!string.IsNullOrEmpty(carBrand) && carBrand != "Hiệu xe")
            {
                conditions.Add("HieuXe", carBrand);
            }

            if (!string.IsNullOrEmpty(customerName) && customerName != "Chủ xe")
            {
                conditions.Add("TenChuXe", customerName);
            }

            if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber != "Số điện thoại")
            {
                conditions.Add("DienThoai", phoneNumber);
            }

            // Chỉ thêm điều kiện ngày nếu checkbox được check
            if (checkBox1.Checked)
            {
                string date = dtpDateService.Value.ToString("yyyy-MM-dd");
                conditions.Add("NgayTiepNhan", date);
            }

            // Gọi hàm FindCar từ ServiceDAO
            DataTable result = ServiceDAO.instance.FindCar(conditions, checkBox1.Checked);

            if (result != null && result.Rows.Count > 0)
            {
                dtgvService.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với thông tin này.");
                this.LoadCarData();
            }
        }


        private void cbbChuXe_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadCarData();
            this.cbbCustomerName.Text = "Chủ xe";
            this.cbbCarBrand.Text = "Hiệu xe";
            this.cbbPhoneNumber.Text = "Số điện thoại";
            this.cbbLicensePlate.Text = "Biển số";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(dtgvService.SelectedRows[0].Cells[6].Value) == 0)
            {
                MessageBox.Show("Không có nợ cần thanh toán");
                return;
            }

            fPayment f = new fPayment();
            if (dtgvService.SelectedRows.Count > 0)
            {
                string customerName = dtgvService.SelectedRows[0].Cells[1].Value.ToString();
                string licensePlate = dtgvService.SelectedRows[0].Cells[0].Value.ToString();
                string phoneNumber = dtgvService.SelectedRows[0].Cells[4].Value.ToString();
                string debt = dtgvService.SelectedRows[0].Cells[6].Value.ToString();

                // Truyền thông tin sang fInforCar
                f.lbNameCustomer.Text = customerName;
                f.lbPlateLicense.Text = licensePlate;
                f.lbPhoneNumber.Text = phoneNumber;
                f.txbDebt.Text = debt;
                f.ShowDialog();
                this.LoadCarData();
            }
            else
            {
                MessageBox.Show("Please select a row before viewing details.");
            }

        }

        private void ChangeInfor_Click(object sender, EventArgs e)
        {
            if (dtgvService.SelectedRows.Count == 0) return;
            fUpdateInforCar f = new fUpdateInforCar();
            if (dtgvService.SelectedRows.Count > 0)
            {
                string customerName = dtgvService.SelectedRows[0].Cells[1].Value.ToString();
                string licensePlate = dtgvService.SelectedRows[0].Cells[0].Value.ToString();
                string carBrand = dtgvService.SelectedRows[0].Cells[2].Value.ToString();
                string phoneNumber = dtgvService.SelectedRows[0].Cells[4].Value.ToString();
                string address = dtgvService.SelectedRows[0].Cells[3].Value.ToString();
                string date = dtgvService.SelectedRows[0].Cells[7].Value.ToString();
                string debt = dtgvService.SelectedRows[0].Cells[6].Value.ToString();
                string email = dtgvService.SelectedRows[0].Cells[5].Value.ToString();

                // Truyền thông tin sang fInforCar
                f.txbCustomerName.Text = customerName;
                f.txbLicensePlate.Text = licensePlate;
                f.cbbCarBrand.Text = carBrand;
                f.txbPhoneNumber.Text = phoneNumber;
                f.txbAddress.Text = address;
                f.dtpDateReceived.Text = date;
                f.txbDebt.Text = debt;
                f.txbEmail.Text = email;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadCarData();
                }
            }
        }

        private void dtpDateService_ValueChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateService.Enabled = checkBox1.Checked;

        }

        private void cbbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // private void LoadCarBrandData()
        // {
        //     string query = "SELECT DISTINCT HieuXe FROM dbo.XE ORDER BY HieuXe";
        //     DataTable dt = DataProvider.instance.ExecuteQuery(query);

        //     // Thêm item mặc định
        //     cbbCarBrand.Items.Clear();
        //     cbbCarBrand.Items.Add("Hiệu xe");

        //     // Thêm các hiệu xe từ database
        //     foreach (DataRow row in dt.Rows)
        //     {
        //         cbbCarBrand.Items.Add(row["HieuXe"].ToString());
        //     }

        //     // Set giá trị mặc định
        //     cbbCarBrand.Text = "Hiệu xe";
        // }
    }
}