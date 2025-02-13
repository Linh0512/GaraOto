﻿using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp.DAO;
using System.Runtime.InteropServices;
using WinFormsApp.Models;
using WinFormsApp.Screens.fOption;
using WinFormsApp.Utils;
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
            this.LoadCarLimitData();
            this.loadUserInfor();
        }

        private void fOption_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlYourProfile);
        }

        private void loadUserInfor()
        {
            txtUsername.Text = SessionManager.Instance.CurrentUser.TenDangNhap;
            txtAddress.Text = SessionManager.Instance.CurrentUser.DiaChi;
            txtPhoneNumber.Text = SessionManager.Instance.CurrentUser.DienThoai;
            txtEmail.Text = SessionManager.Instance.CurrentUser.Email;
            txtChucVu.Text = SessionManager.Instance.CurrentUser.ChucVu;
        }

        private void ShowPanel(Panel panelToShow)
        {
            pnlYourProfile.Visible = false;
            pnlGarageDetail.Visible = false;
            pnlWageDetail.Visible = false;
            pnlBrandDetail.Visible = false;

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

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ChangePassword updatePassword = new ChangePassword();
            updatePassword.ShowDialog();
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
            if (dgvBrandDetail.SelectedRows.Count == 0) return;
            UpdateBrand updateBrand = new UpdateBrand(this.txtBrandName.Text);
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
                int carLimit = int.Parse(txtCarLimit.Text);
                bool allowOverDebt = ckbOverDebt.Checked;
                QuyDinh quyDinh = new QuyDinh
                {
                    SoXeSuaChuaToiDa = carLimit,
                    ChoPhepTraVuotTienNo = allowOverDebt ? 1 : 0 
                };
                QuyDinhDAO.Instance.UpdateQuyDinh(quyDinh);
                MessageBox.Show("Cập nhật quy định thành công!");
                DataUpdateEvent.NotifyPermissionChanged();
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

        private void ExportDataGridViewToExcel(DataGridView dgv, string worksheetName, string fileName)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            try
            {
                var excel = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excel.Workbooks.Add(Type.Missing);
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                worksheet.Name = worksheetName;

                // Add column headers
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                // Add data rows
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();

                // Release COM objects to prevent memory leaks
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                MessageBox.Show("Xuất dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void ExportButtonClick(DataGridView dgv, string defaultFileName, string worksheetName)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()
                       { Filter = "Excel Workbook|*.xlsx", FileName = defaultFileName })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToExcel(dgv, worksheetName, saveFileDialog.FileName);
                }
            }
        }

        private void btnExportWage_Click(object sender, EventArgs e)
        {
            ExportButtonClick(dgvWageDetail, "WageData.xlsx", "Wage Details");
        }

        private void btnExportBrand_Click(object sender, EventArgs e)
        {
            ExportButtonClick(dgvBrandDetail, "BrandData.xlsx", "Brand Details");
        }
    }
}