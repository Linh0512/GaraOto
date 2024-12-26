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

namespace WinFormsApp.Screens.Service.ListPayment
{
    public partial class fListPayment : Form
    {
        public fListPayment()
        {
            InitializeComponent();
            this.AutoCompleteItems();
        }

        private void fListPayment_Load(object sender, EventArgs e)
        {
            General.Instance.TxtMakeTextDisappear(txbSearch, "Nhập biển số xe");
            this.LoadDataPayment();
        }

        private void AutoCompleteItems()
        {
            string queryItems = "SELECT BienSo FROM PHIEUTHUTIEN";
            string columnItems = "BienSo";
            txbSearch.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryItems, columnItems);
            txbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void LoadDataPayment()
        {
            string query = "SELECT * FROM PHIEUTHUTIEN";
            ServiceDAO.instance.LoadData(query, dtgvPaymentList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string plateLicense = txbSearch.Text;
            dtgvPaymentList.DataSource = ReceiptDAO.instance.SearchByLicensePlate(plateLicense);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUTHUTIEN";
            ServiceDAO.instance.LoadData(query, dtgvPaymentList);
        }

        private void dtpSearchByDate_Leave(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUTHUTIEN WHERE @ngaythutien";
            string date = dtpSearchByDate.Value.ToString("yyyy-MM-dd");

            DataTable result = ReceiptDAO.instance.SearchPaymentByDate(query, "@ngaythutien", date);

            if (result != null && result.Rows.Count > 0)
            {
                dtgvPaymentList.DataSource = result;
                dtgvPaymentList.Refresh();
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu cho ngày này!");
                dtgvPaymentList.DataSource = null;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.dtgvPaymentList.Rows.Count == 0)
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
                                workbook.Worksheets.Add(this.dtgvPaymentList.DataSource as DataTable, "PHIEUTHUTIEN");

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
