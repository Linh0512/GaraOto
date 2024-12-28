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

namespace WinFormsApp.Screens.fInventory
{
    public partial class UpdateInforSupply : Form
    {
        public UpdateInforSupply(string supplyName, string Price)
        {
            InitializeComponent();
            txtTenPT.Text = supplyName;
            txt_price.Text = Price;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string supplyName = txtTenPT.Text;
            string price = txt_price.Text;
            string query = string.Format("UPDATE PHUTUNG SET DonGia = {0} WHERE TenVTPT = N'{1}'", price, supplyName);
            int result = DataProvider.instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
