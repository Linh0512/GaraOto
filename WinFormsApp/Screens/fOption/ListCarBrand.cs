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
using WinFormsApp.Screens.Option;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp.Screens.fOption
{
    public partial class ListCarBrand : Form
    {
        public ListCarBrand()
        {
            InitializeComponent();
            this.LoadBrandData();
            this.AutoCompleteItems();
        }

        private void LoadBrandData()
        {
            string query = "SELECT * FROM dbo.HIEUXE";
            DataProvider dataProvider = new DataProvider();
            dgvBrandDetail.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void AutoCompleteItems()
        {
            string queryItems = "SELECT HieuXe FROM HIEUXE";
            string columnItems = "HieuXe";
            txtBrandName.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryItems, columnItems);
            txtBrandName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBrandName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnRefreshBrand_Click(object sender, EventArgs e)
        {
            this.LoadBrandData();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            addBrand.ShowDialog();
            this.LoadBrandData();
        }

        private void btnRemoveBrand_Click(object sender, EventArgs e)
        {
            string brandName = (string)dgvBrandDetail.SelectedRows[0].Cells[0].Value;
            OptionDAO.Instance.DelBrand(brandName);
            this.LoadBrandData();
        }

        private void btnSearchBrand_Click(object sender, EventArgs e)
        {
            string brandName = txtBrandName.Text.Trim();

            // Tạo dictionary chứa các điều kiện tìm kiếm
            Dictionary<string, string> conditions = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(brandName) && brandName != "Hãng xe")
            {
                conditions.Add("HieuXe", brandName);
            }

            // Gọi hàm FindBrand từ OptionDAO
            DataTable result = OptionDAO.Instance.FindBrand(conditions);

            // Kiểm tra kết quả và hiển thị
            if (result != null && result.Rows.Count > 0)
            {
                dgvBrandDetail.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với thông tin này.");
                this.LoadBrandData();
            }
        }

        private void btnExportBrand_Click(object sender, EventArgs e)
        {
            BaoCaoDAO.Instance.ExportButtonClick(dgvBrandDetail, "BrandData.xlsx", "Brand Details");
        }

        private void btnEditBrand_Click(object sender, EventArgs e)
        {
            if (dgvBrandDetail.SelectedRows.Count == 0) return;
            UpdateBrand updateBrand = new UpdateBrand(this.txtBrandName.Text);
        }
    }
}
