using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainScence : Form
    {
        public MainScence()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, EventArgs e)
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
            fStaff fStaff = new fStaff();
            fStaff.ShowDialog();
            this.Show();
        }

        private void bnService_Click(object sender, EventArgs e)
        {
            fService fService = new fService();
            fService.ShowDialog();
            this.Show();
        }

        private void bnOption_Click(object sender, EventArgs e)
        {
            fOption fOption = new fOption();
            fOption.ShowDialog();
            this.Show();
        }

        private void bnStatistic_Click(object sender, EventArgs e)
        {
            fStatistic fStatistic = new fStatistic();
            fStatistic.ShowDialog();
            this.Show();
        }

        private void bnHome_Click(object sender, EventArgs e)
        {

        }
        private void bnMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainScence_Load(object sender, EventArgs e)
        {

        }
    }
}
