using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Dog_Care
{
    public partial class UcHome : UserControl
    {
        public UcHome()
        {
            InitializeComponent();
        }

        private void BtnAdminSettings_MouseHover(object sender, EventArgs e)
        {
            lblAdminSettings.Show();
        }

        private void BtnAdminSettings_MouseLeave(object sender, EventArgs e)
        {
            lblAdminSettings.Hide();
        }

        private void BtnAdminSettings_Click(object sender, EventArgs e)
        {
            lblWelcome.Hide();
            rtxtUserGuide.Hide();
            lblAdminSettings.Hide();
            btnAdminSettings.Hide();

            btnServiceOptions.Show();
            btnVaccinations.Show();
            btnBack.Show();
            FrmJDDogCare.lblTitle.Text = "Settings";
        }

        private void BtnVaccinations_Click(object sender, EventArgs e)
        {
            btnVAdd.Show();
            btnVUpdate.Show();
            btnSOAdd.Hide();
            btnSOUpdate.Hide();
        }

        private void BtnServiceOptions_Click(object sender, EventArgs e)
        {
            btnSOAdd.Show();
            btnSOUpdate.Show();
            btnVAdd.Hide();
            btnVUpdate.Hide();
        }

        private void BtnVAdd_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "Add Vaccination";
        }

        private void BtnVUpdate_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "Update Vaccination";
        }

        private void BtnSOAdd_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "Add Service Option";

            UserControl SOAdd = new UcServiceOption();
            SOAdd.Location = new Point(0, 0);
            this.Controls.Add(SOAdd);
            SOAdd.BringToFront();
        }

        private void BtnSOUpdate_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "Update Service Option";

            UserControl SOUpdate = new UcServiceOption();
            SOUpdate.Location = new Point(0, 0);
            this.Controls.Add(SOUpdate);
            SOUpdate.BringToFront();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.BtnHome_Click(sender, e);
        }
    }
}
