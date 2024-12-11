using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.MainScenne.fInventory;

namespace WinFormsApp
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            txt_price.Text = "0";
            txt_quantity.Text = "0";
            txt_total.Text = "0";

            cbb_inventory.SelectedIndex = 0;

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            fPayment fPayment = new fPayment();
            fPayment.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            invoice invoice = new invoice();
            invoice.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            history history = new history();
            history.Show();
        }
    }
}
