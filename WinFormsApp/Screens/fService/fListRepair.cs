using ClosedXML.Excel;
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
using WinFormsApp.Screens.Service.ListRepair_Detail;

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
            this.dtgvRepairList.DataSource = RepairDAO.instance.SearchByLicensePlate(plateLicense);
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgvRepairList.SelectedRows.Count != 1) return;

                string idRepair = this.dtgvRepairList.SelectedRows[0].Cells["MaPSC"].Value.ToString();
                string licensePlate = this.dtgvRepairList.SelectedRows[0].Cells["BienSo"].Value.ToString();
                string date = this.dtgvRepairList.SelectedRows[0].Cells["NgaySuaChua"].Value.ToString();
                string totalAmout = this.dtgvRepairList.SelectedRows[0].Cells["TongTien"].Value.ToString();
                fListRepair_Detail f = new fListRepair_Detail(idRepair, licensePlate, date, totalAmout);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xem chi tiết!");
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.dtgvRepairList.Rows.Count == 0)
                MessageBox.Show("Không có thông tin để xuất!");
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(this.dtgvRepairList.DataSource as DataTable, "PHIEUSUACHUA");

                                workbook.SaveAs(saveFileDialog.FileName);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xuất file không thành công!");
                        }
                    }
                }
            }
        }
    }
}
