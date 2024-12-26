using System.Data;
using WinFormsApp.DAO;
using ClosedXML.Excel;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            LoadStaff();
            
        }
        void LoadStaff(string tenDangNhap = null)
        {
            dgvNhanVien.DataSource = NHANVIENDAO.Instane.HienThi();
            if ( btnTaiLai.Visible == true && !String.IsNullOrEmpty(txtTiemKiem.Text) )
            {
                dgvNhanVien.DataSource = NHANVIENDAO.Instane.TiemKiem(txtTiemKiem.Text);
                btnTaiLai.Enabled = true;
                txtTiemKiem.Enabled = false;

            }
            else
            {
                btnTaiLai.Hide();
                txtTiemKiem.Enabled = true;
                btnTiemKIem.Enabled = true;
            }

            // Cấu hình hiển thị cột
            dgvNhanVien.Columns["Email"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
            dgvNhanVien.Columns["TenDangNhap"].Visible = false;
            dgvNhanVien.Columns["SDT"].Visible = false;
            dgvNhanVien.Columns["DiaChi"].Visible = false;
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["TenNV"].ReadOnly = true;
            dgvNhanVien.Columns["ChucVu"].ReadOnly = true;

            NHANVIENDAO.Instane.LoadComboBoxData(cbbChucVu);

            // Cấu hình các TextBox và nút
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtHovaTen.Enabled = false;
            txtSDT.Enabled = false;
            txtTenDangNhap.Enabled = false;
            cbbChucVu.Enabled = false;
            btnXacNhan.Hide();
            btnHuy.Hide();
            btnSuaThongTin.Show();
            btnDatMatKhau.Show();
            btnXoa.Show();
            btnDatMatKhau.Show();
            btnThem.Show();
            lblThongTinChiTiet.Text = "Thông tin chi tiết";
            lblThongTinChiTiet.BackColor = SystemColors.ActiveCaption;
            dgvNhanVien.Enabled = true;

            /*txtDiaChi.Clear();
            txtHovaTen.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtSDT.Clear();
            txtTiemKiem.Clear();*/

            // Ẩn cột bên trái cùng
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.AllowUserToAddRows = false;           
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // **Chọn dòng cụ thể dựa trên tên đăng nhập**
            if (!string.IsNullOrEmpty(tenDangNhap))
            {
                SelectRowByTenDangNhap(tenDangNhap);
            }

        }

        // **Hàm tìm và chọn dòng dựa trên tên đăng nhập**
        void SelectRowByTenDangNhap(string tenDangNhap)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells["TenDangNhap"].Value?.ToString() == tenDangNhap)
                {
                    // Xác định cột đầu tiên hiển thị
                    DataGridViewColumn firstVisibleColumn = dgvNhanVien.Columns
                        .Cast<DataGridViewColumn>()
                        .FirstOrDefault(col => col.Visible);

                    if (firstVisibleColumn != null)
                    {
                        // Đặt CurrentCell vào ô đầu tiên hiển thị trong dòng
                        dgvNhanVien.CurrentCell = row.Cells[firstVisibleColumn.Index];
                        row.Selected = true;

                        // Cập nhật thông tin chi tiết
                        UpdateDetailFields(row.Index);
                        return; 
                    }
                }
            }


        }

        void UpdateDetailFields(int rowIndex)
        {
            if (dgvNhanVien.Rows.Count > rowIndex)
            {
                txtHovaTen.Text = dgvNhanVien.Rows[rowIndex].Cells["TenNV"].Value?.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[rowIndex].Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = dgvNhanVien.Rows[rowIndex].Cells["Email"].Value?.ToString();
                txtSDT.Text = dgvNhanVien.Rows[rowIndex].Cells["SDT"].Value?.ToString();
                txtTenDangNhap.Text = dgvNhanVien.Rows[rowIndex].Cells["TenDangNhap"].Value?.ToString();
                cbbChucVu.Text = dgvNhanVien.Rows[rowIndex].Cells["ChucVu"].Value?.ToString();
            }
        }


        private void fStaff_Load(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemNhanVien fThemNhanVien = new fThemNhanVien();
            fThemNhanVien.ShowDialog();
            LoadStaff();
        }

       

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];

                // Hiển thị thông tin đầy đủ vào các TextBox
                txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                txtHovaTen.Text = selectedRow.Cells["TenNV"].Value?.ToString();
                txtSDT.Text = selectedRow.Cells["SDT"].Value?.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                cbbChucVu.Text = selectedRow.Cells["ChucVu"].Value?.ToString();

            }
        }
        //Sữa
        private void btnSuaNV_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                NhanVien nv = new NhanVien();
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                nv.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtHovaTen.Enabled = true;
                txtSDT.Enabled = true;
                cbbChucVu.Enabled = true;

                btnSuaThongTin.Hide();
                btnXoa.Hide();
                btnDatMatKhau.Hide();
                btnXacNhan.Show();
                btnHuy.Show();
                btnThem.Hide();
                btnTiemKIem.Enabled = false;
                btnTaiLai.Enabled = false;  
                txtTiemKiem.Enabled = false;
                lblThongTinChiTiet.Text = "Sữa thông tin ";
                lblThongTinChiTiet.BackColor = System.Drawing.Color.Red;
                dgvNhanVien.Enabled = false;

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.TenNV = txtHovaTen.Text;
            nv.DienThoai = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.ChucVu = cbbChucVu.Text;
            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtHovaTen.Text)
                || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(cbbChucVu.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                if (NHANVIENDAO.Instane.Sua(nv))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");

                }
                LoadStaff(nv.TenDangNhap);             
                
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = txtTenDangNhap.Text;
            btnXoa.Show();
            btnSuaThongTin.Show();
            btnDatMatKhau.Show();           
            dgvNhanVien.Enabled = true;
            LoadStaff(nv.TenDangNhap);
            

        }
        // Tiem Kiem
        private void btnTiemKIem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTiemKiem.Text))
            {
                // Hiển thị thông báo nếu trống
                MessageBox.Show("Bạn phải nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát mà không thực hiện tìm kiếm
            }
            txtTiemKiem.Enabled = false; 
            btnTaiLai.Show();
            string TuKhoa = txtTiemKiem.Text;
            dgvNhanVien.DataSource = NHANVIENDAO.Instane.TiemKiem(TuKhoa);
            dgvNhanVien.Columns["Email"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
            dgvNhanVien.Columns["TenDangNhap"].Visible = false;
            dgvNhanVien.Columns["SDT"].Visible = false;
            dgvNhanVien.Columns["DiaChi"].Visible = false;
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
        }
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {

                string tenDangNhap = dgvNhanVien.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa nhân viên có Tên Đăng Nhập là '{tenDangNhap}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        NHANVIENDAO.Instane.Xoa(tenDangNhap);

                        LoadStaff();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Đặt lại mật khẩu
        private void btnDatMatKhau_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            if (dgvNhanVien.SelectedRows.Count > 0)
            {

                nhanVien.TenDangNhap = dgvNhanVien.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn đặt lại mật khẩu nhân viên có Tên Đăng Nhập là '{nhanVien.TenDangNhap}' thành 1 không?",
                    "Xác nhận ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        NHANVIENDAO.Instane.DatLaiMatKhau(nhanVien);
                        LoadStaff(nhanVien.TenDangNhap);
                        MessageBox.Show("đặt lại mật khẩu thành 1 thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đặt lại mật khẩu : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên đặt lại mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTiemKiem.Clear();    
            txtTiemKiem.Enabled = true ;
            LoadStaff();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void dgvNhanVien_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
