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

        private void bnThemXe_Click(object sender, EventArgs e)
        {
            fAddCar f = new fAddCar();
            f.ShowDialog();
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
    }
}
