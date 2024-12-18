using DocumentFormat.OpenXml.Spreadsheet;
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
        public fInforCar()
        {
            InitializeComponent();
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

                this.dtgvServiceCar.Rows.Add(wage, item, quantity, pricePerUnit, wagePrice, totalPrice);
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
            if (dtgvServiceCar.Rows.Count > 0)
            {
                fPaying f = new fPaying(dtgvServiceCar); // Truyền DataGridView
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dữ liệu rỗng hoặc chưa được khởi tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
