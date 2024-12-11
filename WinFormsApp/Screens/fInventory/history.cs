using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.MainScenne.fInventory
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {

            cbb_provider.SelectedIndex = 0;
            txt_code.Text = "Mã đơn nhập";
            AddRowToDataGridView();
        }

        private void AddRowToDataGridView()
        {
            dataGridView1.Rows.Add("1", "06/25/2021", "200000000", "MAST");
            dataGridView1.Rows.Add("2", "07/06/2021", "0", "Phụ tùng ô tô Minh Châu");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
