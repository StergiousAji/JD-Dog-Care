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
    public partial class UcVaccination : UserControl
    {
        public UcVaccination()
        {
            InitializeComponent();
        }
        private void DgvVaccinations_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnVaccination_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        //UPDATE DISPLAY
        //-Method to display service option records for editing/updating.
        private void DisplayRecord(string column, string value)
        {
            List<object> record = FrmJDDogCare.GetRecord("Vaccination", column, value, new string[] { "VaccinationNo", "VaccinationName" });

            //Record is only displayed on the user control when it is not empty.
            if (record.Count != 0)
            {
                txtVaccinationName.Text = (string)record[0];
                txtVaccinationName.Text = (string)record[1];
            }
        }

        private void TxtVaccinationName_TextChanged(object sender, EventArgs e)
        {
            CheckVaccinationName();
        }

        //Validate user input as they enter values into the fields.
        private bool CheckVaccinationNo()
        {
            bool v = false;

            if (String.IsNullOrEmpty(txtVaccinationName.Text))
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtVaccinationName, "Please provide what vaccination you want to update.");
            }
            else
            {
                ep.SetError(txtVaccinationName, null);
                //Set the vaccination number using the vaccination name.
                //vaccinationNo = FrmJDDogCare.FindID("Vaccination", "", "", "", "", "VaccinationName", cbVaccinationName.Text)[0];
                v = true;
            }

            return v;
        }

        private bool CheckVaccinationName()
        {
            bool v = false;

            if (String.IsNullOrEmpty(txtVaccinationName.Text))
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtVaccinationName, "Please provide what vaccination you want to update.");
            }
            //else if ()
            else
            {
                ep.SetError(txtVaccinationName, null);
                v = true;
            }

            return v;
        }
    }
}
