using System;
using System.Windows.Forms;
using WinFormsApp.MainScene.fOption;

namespace WinFormsApp
{
    public partial class fOption : Form
    {
        public fOption()
        {
            InitializeComponent();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlYourProfile);
        }

        private void btnGarageDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlGarageDetail);
        }

        private void btnWageDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlWageDetail);
        }

        private void btnBrandDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlBrandDetail);
        }

        private void btnSupplierDetail_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSupplierDetail);
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

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword updatePassword = new UpdatePassword();
            updatePassword.ShowDialog();
            this.Show();
        }
    }
}
