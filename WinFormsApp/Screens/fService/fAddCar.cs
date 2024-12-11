using WinFormsApp.DAO;
using WinFormsApp.Model;

namespace WinFormsApp.Screens.Service.AddCar
{
    public partial class fAddCar : Form
    {
        public fAddCar()
        {
            InitializeComponent();
        }

        private void fAddCar_Load(object sender, EventArgs e)
        {
            this.SetPlaceHolder(txbNameCarOwner, "Tên chủ xe");
            this.SetPlaceHolder(txbLicensePlate, "Biển số xe");
            this.SetPlaceHolder(txbAddress, "Địa chỉ");
            this.SetPlaceHolder(txbPhoneNumber, "Số điện thoại");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetPlaceHolder(TextBox text, String placeHolder)
        {
            text.Text = placeHolder;
            text.ForeColor = Color.Gray;

            text.Enter += (sender, e) =>
            {
                if (text.Text == placeHolder)
                {
                    text.Text = "";
                    text.ForeColor = Color.Black;
                }
            };

            text.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(text.Text))
                {
                    text.Text = placeHolder;
                    text.ForeColor = Color.Gray;
                }
            };
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Car.Instance = new Car
                {
                    TenChuXe = txbNameCarOwner.Text,
                    Hieuxe = cbbTypeOfCar.Text,
                    Bienso = txbLicensePlate.Text,
                    DiaChi = txbAddress.Text,
                    DienThoai = txbPhoneNumber.Text,
                    NgayTiepNhan = dtpDateReceived.Value < new DateTime(1753, 1, 1) ? DateTime.Now : dtpDateReceived.Value,
                    TienNo = "0"
                };

                // Kiểm tra thông tin nhập liệu
                if (string.IsNullOrWhiteSpace(txbNameCarOwner.Text) ||
                    string.IsNullOrWhiteSpace(txbLicensePlate.Text) ||
                    string.IsNullOrWhiteSpace(txbAddress.Text) ||
                    string.IsNullOrWhiteSpace(txbPhoneNumber.Text))
                {
                    MessageBox.Show("Please fill out all the required fields.");
                    return;
                }

                // Thêm vào cơ sở dữ liệu
                ServiceDAO.Instance.AddCar(Car.Instance);
                MessageBox.Show("Car added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cbbTypeOfCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
