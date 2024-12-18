using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Screens.Service.InforCar;

namespace WinFormsApp.Screens.Service.Paying
{
    public partial class fPaying : Form
    {
        public fPaying(DataTable table)
        {
            InitializeComponent();
            dtgvPayment.DataSource = table;
        }

        private void fPaying_Load(object sender, EventArgs e)
        {

        }
    }
}
