using WinFormsApp.DAO;
using WinFormsApp.Model;
using WinFormsApp.Screens.Service;
using WinFormsApp.Utils;

namespace WinFormsApp.Screens.Service.AddCar
{
    public partial class fAddCar : Form
    {
        public fAddCar()
        {
            InitializeComponent();
            this.GetCarBrandAutoComplete();
        }

        private void fAddCar_Load(object sender, EventArgs e)
        {
            General.Instance.TxtMakeTextDisappear(txbNameCarOwner, "Tên chủ xe");
            General.Instance.TxtMakeTextDisappear(txbLicensePlate, "Biển số xe");
            General.Instance.TxtMakeTextDisappear(txbAddress, "Địa chỉ");
            General.Instance.TxtMakeTextDisappear(txbPhoneNumber, "Số điện thoại");
            General.Instance.TxtMakeTextDisappear(txbEmail, "Email");
            General.Instance.CbbMakeTextDisappear(cbbCarBrandName, "Hiệu xe");
        }

        private void GetCarBrandAutoComplete()
        {
            string queryCarBrand = "SELECT DISTINCT HieuXe FROM dbo.HIEUXE";
            string columnCarBrand = "HieuXe";
            cbbCarBrandName.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryCarBrand, columnCarBrand);
            cbbCarBrandName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCarBrandName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(this.dtpDateReceived.Value != DateTime.Now)
            {
                MessageBox.Show("Ngày tiếp nhận không hợp lệ");
                return;
            }
            try
            { 
                if (!QuyDinhManager.Instance.canReceiveCar())
                {
                    MessageBox.Show("Số lượng xe đã tiếp nhận trong ngày đã đạt giới hạn.");
                    return;
                }

                Car.Instance = new Car
                {
                    TenChuXe = txbNameCarOwner.Text,
                    Hieuxe = cbbCarBrandName.Text,
                    Bienso = txbLicensePlate.Text,
                    DiaChi = txbAddress.Text,
                    DienThoai = txbPhoneNumber.Text,
                    Email = txbEmail.Text,
                    NgayTiepNhan = dtpDateReceived.Value < new DateTime(1753, 1, 1) ? DateTime.Now : dtpDateReceived.Value,
                    TienNo = "0"
                };

                // Kiểm tra thông tin nhập liệu
                if (string.IsNullOrWhiteSpace(txbNameCarOwner.Text) ||
                    string.IsNullOrWhiteSpace(txbLicensePlate.Text) ||
                    string.IsNullOrWhiteSpace(txbAddress.Text) ||
                    string.IsNullOrWhiteSpace(txbPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text))
                {
                    MessageBox.Show("Please fill out all the required fields.");
                    return;
                }

                // Thêm vào cơ sở dữ liệu
                ServiceDAO.instance.AddCar(Car.Instance);
                MessageBox.Show("Thêm xe thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiệu xe không tồn tại");
            }
        }


        private void cbbTypeOfCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateReceived_ValueChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }
    }
}
