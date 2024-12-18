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
using WinFormsApp.Screens.Service.AddService;
using WinFormsApp.Screens.Service.Paying;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp.Screens.Service.InforCar
{
    public partial class fInforCar : Form
    {
        private DataTable serviceTable;

        public fInforCar()
        {
            InitializeComponent();
            InitializeServiceTable();
        }

        public DataTable GetDataGridViewData()
        {
            // Kiểm tra nếu DataSource đã được gán
            if (dtgvServiceCar.DataSource is DataTable table)
            {
                return table;
            }
            else
            {
                MessageBox.Show("Dữ liệu DataGridView không hợp lệ hoặc chưa được gán vào DataSource.");
                return new DataTable();
            }
        }



        private void InitializeServiceTable()
        {
            serviceTable = new DataTable();
            serviceTable.Columns.Add("Nội dung", typeof(string));
            serviceTable.Columns.Add("Vật tư", typeof(string));
            serviceTable.Columns.Add("Số lượng", typeof(int));
            serviceTable.Columns.Add("Đơn giá", typeof(decimal));
            serviceTable.Columns.Add("Tiền công", typeof(decimal));
            serviceTable.Columns.Add("Thành tiền", typeof(decimal));
            dtgvServiceCar.DataSource = serviceTable;
        }


        private void fInforCar_Load(object sender, EventArgs e)
        {

        }

        private void Test()
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddService_Click(object sender, EventArgs e)
        {
            fAddService f = new fAddService();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string wage = f.ServiceDetails["NoiDung"].ToString();
                string wagePrice = f.ServiceDetails["TienCong"].ToString();
                string pricePerUnit = f.ServiceDetails["DonGia"].ToString();
                string item = f.ServiceDetails["TenVTPT"].ToString();
                string quantity = f.ServiceDetails["SoLuong"].ToString();
                string totalPrice = f.ServiceDetails["ThanhTien"].ToString();

                MessageBox.Show(wage + " " + wagePrice + " " + pricePerUnit + " " + item + " " + quantity + " " + totalPrice);

                this.serviceTable.Rows.Add(wage, item, quantity, pricePerUnit, wagePrice, totalPrice);

                // Chuỗi lưu dữ liệu của hàng đầu tiên
                StringBuilder firstRowData = new StringBuilder();

                // Lấy hàng đầu tiên (bỏ qua dòng trống mới)
                DataGridViewRow firstRow = dtgvServiceCar.Rows[0];

                // Lấy dữ liệu từng ô trong hàng đầu tiên
                foreach (DataGridViewCell cell in firstRow.Cells)
                {
                    firstRowData.Append(cell.Value?.ToString() + "\t");
                }

                // Hiển thị dữ liệu của hàng đầu tiên trong MessageBox
                MessageBox.Show(firstRowData.ToString(), "Dữ liệu hàng đầu tiên", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvServiceCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            try
            {
                this.dtgvServiceCar.Rows.RemoveAt(this.dtgvServiceCar.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa dòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Lấy DataTable từ DataGridView
            DataTable table = this.GetDataGridViewData();

            if (table != null && table.Rows.Count > 0)
            {
                fPaying f = new fPaying(table); // Truyền DataTable vào form fPaying
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dữ liệu rỗng hoặc chưa được khởi tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
