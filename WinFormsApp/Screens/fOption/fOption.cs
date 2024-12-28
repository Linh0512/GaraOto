using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp.DAO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp.Screens.Option
{
    public partial class fOption : Form
    {
        public fOption()
        {
            InitializeComponent();
            this.LoadWageData();
            this.LoadBrandData();
            this.LoadSupplierData();
            this.LoadCarLimitData();
        }

        private void fOption_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlYourProfile);
        }

        private void ShowPanel(Panel panelToShow)
        {
            pnlYourProfile.Visible = false;
            pnlGarageDetail.Visible = false;
            pnlWageDetail.Visible = false;
            pnlBrandDetail.Visible = false;
            pnlSupplierDetail.Visible = false;

            panelToShow.Visible = true;
        }

        private void LoadWageData()
        {
            string query = "SELECT * FROM dbo.TIENCONG";
            DataProvider dataProvider = new DataProvider();
            dgvWageDetail.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void LoadBrandData()
        {
            string query = "SELECT * FROM dbo.HIEUXE";
            DataProvider dataProvider = new DataProvider();
            dgvBrandDetail.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void LoadSupplierData()
        {
            string query = "SELECT * FROM dbo.NHACUNGCAP";
            DataProvider dataProvider = new DataProvider();
            dgvSupplierDetail.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void LoadCarLimitData()
        {
            try
            {
                var (carLimit, allowOverDebt) = OptionDAO.Instance.GetCarLimit();

                txtCarLimit.Text = carLimit.ToString();
                ckbOverDebt.Checked = allowOverDebt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu quy định: " + ex.Message);
            }
        }

        private void btnAddWage_Click(object sender, EventArgs e)
        {
            AddWage addWage = new AddWage();
            addWage.ShowDialog();
            this.Show();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            addBrand.ShowDialog();
            this.Show();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.ShowDialog();
            this.Show();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlYourProfile);
        }

        private void lblGarageDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlGarageDetail);
        }

        private void lblWageDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlWageDetail);
        }

        private void lblBrandDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlBrandDetail);
        }

        private void lblSupplierDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSupplierDetail);
        }

        private void btnRefreshSupplier_Click(object sender, EventArgs e)
        {
            this.LoadSupplierData();
        }

        private void btnRefreshWage_Click(object sender, EventArgs e)
        {
            this.LoadWageData();
        }

        private void btnRefreshBrand_Click(object sender, EventArgs e)
        {
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

        private void btnSearchWage_Click(object sender, EventArgs e)
        {
            string wageID = txtWageID.Text.Trim();
            string wageType = txtWageType.Text.Trim();
            string wageAmount = txtWageAmount.Text.Trim();


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
            if (!string.IsNullOrEmpty(wageAmount) && wageAmount != "Số tiền")
            {
                conditions.Add("TienCong", wageAmount);
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

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            string supplierID = txtSupplierID.Text.Trim();
            string supplierName = txtSupplierName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Tạo dictionary chứa các điều kiện tìm kiếm
            Dictionary<string, string> conditions = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(supplierID) && supplierID != "Mã")
            {
                conditions.Add("MaNCC", supplierID);
            }
            if (!string.IsNullOrEmpty(supplierName) && supplierName != "Tên nhà cung cấp")
            {
                conditions.Add("TenNCC", supplierName);
            }
            if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber != "Số điện thoại")
            {
                conditions.Add("SDT", phoneNumber);
            }
            if (!string.IsNullOrEmpty(email) && email != "Email")
            {
                conditions.Add("Email", email);
            }

            // Gọi hàm FindSupplier từ OptionDAO
            DataTable result = OptionDAO.Instance.FindSupplier(conditions);

            // Kiểm tra kết quả và hiển thị
            if (result != null && result.Rows.Count > 0)
            {
                dgvSupplierDetail.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với thông tin này.");
                this.LoadSupplierData();
            }
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSupplierDetail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa.");
                return;
            }

            string supplierID = dgvSupplierDetail.SelectedRows[0].Cells["MaNCC"].Value.ToString();
            string supplierName = dgvSupplierDetail.SelectedRows[0].Cells["TenNCC"].Value.ToString();
            string phoneNumber = dgvSupplierDetail.SelectedRows[0].Cells["SDT"].Value.ToString();
            string email = dgvSupplierDetail.SelectedRows[0].Cells["Email"].Value.ToString();

            UpdateSupplier updateSupplier = new UpdateSupplier(supplierID, supplierName, phoneNumber, email);
            updateSupplier.ShowDialog();
            this.LoadSupplierData();
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

        private void btnEditBrand_Click(object sender, EventArgs e)
        {
            if (dgvBrandDetail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa.");
                return;
            }

            string oldHieuXe = dgvBrandDetail.SelectedRows[0].Cells["HieuXe"].Value.ToString();
            UpdateBrand updateBrand = new UpdateBrand(oldHieuXe);
            updateBrand.ShowDialog();

            this.LoadBrandData();
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            string supplierID = (string)dgvSupplierDetail.SelectedRows[0].Cells["MaNCC"].Value;
            OptionDAO.Instance.DelSupplier(supplierID);
            this.LoadSupplierData();
        }

        private void btnRemoveWage_Click(object sender, EventArgs e)
        {
            string wageID = (string)dgvWageDetail.SelectedRows[0].Cells["MaTienCong"].Value;
            OptionDAO.Instance.DelWage(wageID);
            this.LoadWageData();
        }

        private void btnRemoveBrand_Click(object sender, EventArgs e)
        {
            string brandName = (string)dgvBrandDetail.SelectedRows[0].Cells["HieuXe"].Value;
            OptionDAO.Instance.DelBrand(brandName);
            this.LoadBrandData();
        }

        private void btnChangeCarLimit_Click(object sender, EventArgs e)
        {
            try
            {
                int carLimit;
                if (!int.TryParse(txtCarLimit.Text.Trim(), out carLimit) || carLimit <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số xe sửa chữa tối đa hợp lệ.");
                    return;
                }

                bool allowOverDebt = ckbOverDebt.Checked;

                OptionDAO.Instance.UpdateCarLimit(carLimit, allowOverDebt);

                MessageBox.Show("Cập nhật quy định thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật quy định: " + ex.Message);
            }
        }

        private void txtCarLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExportToExcel(DataGridView dgv, string fileName)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet?)workbook.Sheets["Sheet1"];
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet?)workbook.ActiveSheet;
                worksheet.Name = "ExportedData";

                // Add column headers
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                // Add rows
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                // Save the file
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();

                MessageBox.Show("Xuất dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message);
            }
        }

        private void btnExportWage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "WageData.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvWageDetail, sfd.FileName);
                }
            }
        }

        private void btnExportBrand_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "BrandData.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvBrandDetail, sfd.FileName);
                }
            }
        }

        private void btnExportSupplier_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "SupplierData.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dgvSupplierDetail, sfd.FileName);
                }
            }
        }
    }
}
