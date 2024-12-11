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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
            cbb_inventory.SelectedIndex = 0;
            txt_price.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
