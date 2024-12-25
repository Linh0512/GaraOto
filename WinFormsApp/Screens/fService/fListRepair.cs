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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp.Screens.Service.ListRepair
{
    public partial class fListRepair : Form
    {
        public fListRepair()
        {
            InitializeComponent();
            this.AutoCompleteItems();
        }

        private void fListRepair_Load(object sender, EventArgs e)
        {
            General.Instance.TxtMakeTextDisappear(txbSearch, "Nhập biển số xe");
            this.LoadDataRepair();
        }

        private void AutoCompleteItems()
        {
            string queryItems = "SELECT BienSo FROM PHIEUSUACHUA";
            string columnItems = "BienSo";
            txbSearch.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryItems, columnItems);
            txbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void LoadDataRepair()
        {
            string query = "SELECT * FROM PHIEUSUACHUA";
            ServiceDAO.instance.LoadData(query, dtgvRepairList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string plateLicense = txbSearch.Text;
            RepairDAO.instance.SearchRepairByLicensePlate(plateLicense);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUSUACHUA";
            ServiceDAO.instance.LoadData(query, dtgvRepairList);
        }

        private void btnRefresh_Leave(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUSUACHUA WHERE @ngaysuachua";
            string date = dtpSearchByDate.Value.ToString("yyyy-MM-dd");

            DataTable result = RepairDAO.instance.SearchRepairByDate(query, "@ngaysuachua", date);

            if (result != null && result.Rows.Count > 0)
            {
                dtgvRepairList.DataSource = result;
                dtgvRepairList.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu cho ngày này!");
                dtgvRepairList.DataSource = null;
            }
        }

    }
}
