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
using WinFormsApp.Models;
using WinFormsApp.Screens.fReport;
using WinFormsApp.Screens.Service;
using WinFormsApp.Utils;
using WinFormsApp.Screens.Service.UpdateInforCar;
using WinFormsApp.Screens.Service.ListRepair;
using WinFormsApp.Screens.Service.ListPayment;
using WinFormsApp.Screens.fInventory;
using WinFormsApp.Screens.fOption;

namespace WinFormsApp.Screens.MainScene
{
    public partial class MainScence : Form
    {
        private string currentSearchType = "BienSo";

        public MainScence()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadMainSceneData();
            SetupSearchControls();
            DisplayCurrentUser();
            LoadPermisssion();

            // Đăng ký lắng nghe sự kiện
            DataUpdateEvent.CarListChanged += OnCarListChanged;
            DataUpdateEvent.PermissionChanged += OnPermissionChanged;
        }

        private void DisplayCurrentUser()
        {
            currentUser.Text = SessionManager.Instance.CurrentUser.TenNV;
        }

        private void LoadPermisssion()
        {
            soXeDaTN.Text = (MainSceneDAO.Instance.getTodayReceivedCarsCount()).ToString();
            soXeDaTN.Text += "/";
            soXeDaTN.Text += QuyDinhManager.Instance.CurrentQuyDinh.SoXeSuaChuaToiDa.ToString();
        }

        private void OnCarListChanged(object sender, EventArgs e)
        {
            // Đảm bảo update UI được thực hiện trên UI thread
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => RefreshData()));
            }
            else
            {
                RefreshData();
            }
        }

        private void OnPermissionChanged(object sender, EventArgs e)
        {
            LoadPermisssion();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Hủy đăng ký sự kiện khi form đóng
            DataUpdateEvent.CarListChanged -= OnCarListChanged;
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                    { Name = "BienSo", HeaderText = "Biển số", DataPropertyName = "BienSo" },
                new DataGridViewTextBoxColumn()
                    { Name = "TenChuXe", HeaderText = "Chủ xe", DataPropertyName = "TenChuXe" },
                new DataGridViewTextBoxColumn()
                    { Name = "HieuXe", HeaderText = "Hiệu xe", DataPropertyName = "HieuXe" },
                new DataGridViewTextBoxColumn()
                    { Name = "DiaChi", HeaderText = "Địa chỉ", DataPropertyName = "DiaChi" },
                new DataGridViewTextBoxColumn()
                    { Name = "DienThoai", HeaderText = "Điện thoại", DataPropertyName = "DienThoai" },
                new DataGridViewTextBoxColumn() { Name = "Email", HeaderText = "Email", DataPropertyName = "Email" },
                new DataGridViewTextBoxColumn() { Name = "TienNo", HeaderText = "Tiền nợ", DataPropertyName = "TienNo" }
            });

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void LoadMainSceneData()
        {
            try
            {
                dataGridView1.DataSource = MainSceneDAO.Instance.GetTodayReceivedCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshData()
        {
            LoadMainSceneData();
        }

        private void CheckPermissions()
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                // Disable button nhân viên và thống kê
                // bnStaff.Enabled = false;
                // // báoCáoToolStripMenuItem.Visible = false;

                // báoCáoToolStripMenuItem.Enabled = false;
                // báoCáoToolStripMenuItem.Visible = false;
            }
        }

        private void panel1_Paint(object sender, EventArgs e)
        {
        }

        private void MainScence_Load(object sender, EventArgs e)
        {
        }

        private void bnInventory_Click(object sender, EventArgs e)
        {
            Inventory fInventory = new Inventory();
            fInventory.ShowDialog();
            this.Show();
        }

        private void bnStaff_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                this.bnService.Cursor = Cursors.No;
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            fStaff fStaff = new fStaff();
            fStaff.ShowDialog();
            this.Show();
        }

        private void bnService_Click(object sender, EventArgs e)
        {
            try
            {
                fService f = new fService();
                if (f == null)
                {
                    throw new InvalidOperationException("Failed to initialize fService.");
                }

                f.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnOption_Click(object sender, EventArgs e)
        {
            Option.fOption fOption = new Option.fOption();
            fOption.ShowDialog();
            this.Show();
        }

        private void bnHome_Click(object sender, EventArgs e)
        {
        }

        private void bnMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bÁOCÁODOANHSỐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            fBaoCaoDS fBaoCaoDS = new fBaoCaoDS();
            fBaoCaoDS.ShowDialog();
            this.Show();
        }

        private void bÁOCÁOTỒNKHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            fBaoCaoTon fBaoCaoTon = new fBaoCaoTon();
            fBaoCaoTon.ShowDialog();
            this.Show();
        }


        private void dANHSÁCHPHIẾUSỬACHỮAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            fListRepair f = new fListRepair();
            f.ShowDialog();
        }

        private void dANHSÁCHPHIẾUTHUTIỀNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            fListPayment f = new fListPayment();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void SetupSearchControls()
        {
            byBienXeRadioBtn.Checked = true;

            byBienXeRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            byNameRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            byHieuXeRadioBtn.CheckedChanged += RadioButton_CheckedChanged;


            searchBar.TextChanged += SearchBar_TextChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                if (rb == byBienXeRadioBtn)
                    currentSearchType = "BienSo";
                else if (rb == byNameRadioBtn)
                    currentSearchType = "TenChuXe";
                else if (rb == byHieuXeRadioBtn)
                    currentSearchType = "HieuXe";

                // Thực hiện tìm kiếm lại nếu đã có text trong searchBar
                if (!string.IsNullOrWhiteSpace(searchBar.Text))
                    PerformSearch(searchBar.Text);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PerformSearch(searchBar.Text);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            // Tìm kiếm realtime (có thể bỏ nếu không muốn)
            PerformSearch(searchBar.Text);
        }

        private void PerformSearch(string searchValue)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    // Nếu không có giá trị tìm kiếm, load lại toàn bộ dữ liệu
                    LoadMainSceneData();
                    return;
                }

                dataGridView1.DataSource = MainSceneDAO.Instance.SearchCars(searchValue, currentSearchType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void editCarBtn_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                this.editCarBtn.Cursor = Cursors.No;
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0) return;
            fUpdateInforCar f = new fUpdateInforCar();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string customerName = dataGridView1.SelectedRows[0].Cells["TenChuXe"].Value.ToString();
                string licensePlate = dataGridView1.SelectedRows[0].Cells["BienSo"].Value.ToString();
                string carBrand = dataGridView1.SelectedRows[0].Cells["HieuXe"].Value.ToString();
                string phoneNumber = dataGridView1.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                string address = dataGridView1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string debt = dataGridView1.SelectedRows[0].Cells["TienNo"].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();

                // Truyền thông tin sang fInforCar
                f.txbCustomerName.Text = customerName;
                f.txbLicensePlate.Text = licensePlate;
                f.cbbCarBrand.Text = carBrand;
                f.txbPhoneNumber.Text = phoneNumber;
                f.txbAddress.Text = address;
                f.txbDebt.Text = debt;
                f.txbEmail.Text = email;

                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadMainSceneData();
                }
            }
        }

        private void mnStripStatistic_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            // throw new System.NotImplementedException();
            // if(!SessionManager.Instance.IsAdmin())
            // {
            //     MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
            //     return;
            // }
        }

        private void dANHSÁCHPHIẾUNHẬPVTPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            history history = new history();
            history.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }
            fRegulations f = new fRegulations();
            f.ShowDialog();
        }

        private void tÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Account f = new Account();
            f.ShowDialog();
        }

        private void dANHSÁCHHÃNGXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }
            ListCarBrand f = new ListCarBrand();
            f.ShowDialog();
        }

        private void dANHSÁCHLOẠITIỀNCÔNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SessionManager.Instance.IsAdmin())
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }
            WageList f = new WageList();
            f.ShowDialog();
        }
    }
}