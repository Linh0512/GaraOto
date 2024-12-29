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
    public partial class WageList : Form
    {
        public WageList()
        {
            InitializeComponent();
            LoadWageData();
            AutoCompleteId();
            AutoCompleteTenVTPT();
        }

        private void AutoCompleteId()
        {
            string queryItems = "SELECT MaTienCong FROM TIENCONG";
            string columnItems = "MaTienCong";
            txtWageID.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryItems, columnItems);
            txtWageID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtWageID.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void AutoCompleteTenVTPT()
        {
            string queryItems = "SELECT NoiDung FROM TIENCONG";
            string columnItems = "NoiDung";
            txtWageType.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryItems, columnItems);
            txtWageType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtWageType.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void LoadWageData()
        {
            string query = "SELECT * FROM dbo.TIENCONG";
            DataProvider dataProvider = new DataProvider();
            dgvWageDetail.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void btnAddWage_Click(object sender, EventArgs e)
        {
            AddWage addWage = new AddWage();
            addWage.ShowDialog();
            this.Show();
        }

        private void btnSearchWage_Click(object sender, EventArgs e)
        {
            string wageID = txtWageID.Text.Trim();
            string wageType = txtWageType.Text.Trim();

            // Tạo dictionary chứa các điều kiện tìm kiếm
            Dictionary<string, string> conditions = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(wageID) && wageID != "Mã")
            {
                conditions.Add("MaTienCong", wageID);
            }

            if (!string.IsNullOrEmpty(wageType) && wageType != "Loại tiền công")
            {
                conditions.Add("NoiDung", wageType);
            }

            // Gọi hàm FindWage từ OptionDAO
            DataTable result = OptionDAO.Instance.FindWage(conditions);

            // Kiểm tra kết quả và hiển thị
            if (result != null && result.Rows.Count > 0)
            {
                dgvWageDetail.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với thông tin này.");
                this.LoadWageData();
            }
        }


        private void btnEditWage_Click(object sender, EventArgs e)
        {
            if (dgvWageDetail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa.");
                return;
            }

            string wageID = dgvWageDetail.SelectedRows[0].Cells["MaTienCong"].Value.ToString();
            string wageType = dgvWageDetail.SelectedRows[0].Cells["NoiDung"].Value.ToString();
            string wageAmount = dgvWageDetail.SelectedRows[0].Cells["TienCong"].Value.ToString();

            UpdateWage updateWage = new UpdateWage(wageID, wageType, wageAmount);
            updateWage.ShowDialog();
            this.LoadWageData();
        }

        private void btnRemoveWage_Click(object sender, EventArgs e)
        {
            string wageID = (string)dgvWageDetail.SelectedRows[0].Cells["MaTienCong"].Value;
            OptionDAO.Instance.DelWage(wageID);
            this.LoadWageData();
        }

        private void btnExportWage_Click(object sender, EventArgs e)
        {
            BaoCaoDAO.Instance.ExportButtonClick(dgvWageDetail, "WageData.xlsx", "Wage Details");
        }

        private void btnRefreshWage_Click(object sender, EventArgs e)
        {
            this.LoadWageData();
        }
    }
}
