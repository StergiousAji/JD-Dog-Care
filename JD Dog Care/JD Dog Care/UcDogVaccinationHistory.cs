using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JD_Dog_Care
{
    public partial class UcDogVaccinationHistory : UserControl
    {
        //String variable to store the current dog that is displayed on the Dog Update Page.
        public static string currentDogID = "";

        DataTable vacHistory = FrmJDDogCare.GetTable("DogVaccinationHistory", "DogID", currentDogID, true);
        DataTable dog;

        string vaccinationNo = "";

        public UcDogVaccinationHistory()
        {
            InitializeComponent();

            vacHistory = FrmJDDogCare.GetTable("DogVaccinationHistory", "DogID", currentDogID, true);
            dgvVaccinationHistory.DataSource = vacHistory;
            
            foreach (DataRow dr in vacHistory.Rows)
                cbVaccinationName.Items.Add((string)dr["VaccinationName"]);

            dog = FrmJDDogCare.GetTable("Dog", "DogID", currentDogID);
        }

        private void DgvVaccinationHistory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure that the user has not double clicked the row header by mistake.
            if (e.RowIndex != -1)
            {
                //Display the selected vaccination details onto the fields. NULL values should result in an empty field being shown.
                cbVaccinationName.Text = dgvVaccinationHistory.Rows[e.RowIndex].Cells[0].Value.ToString();
                object vacDate = dgvVaccinationHistory.Rows[e.RowIndex].Cells[1].Value;
                if (vacDate != System.DBNull.Value)
                    dtpVaccinationDate.Value = (DateTime)vacDate;
                else
                {
                    dtpVaccinationDate.CustomFormat = " ";
                    dtpVaccinationDate.Format = DateTimePickerFormat.Custom;
                }
            }
        }

        private void CbVaccinationName_TextChanged(object sender, EventArgs e)
        {
            CheckVaccinationName();   
        }

        private void DtpVaccinationDate_ValueChanged(object sender, EventArgs e)
        {
            CheckVaccinationDate();
        }

        private void BtnUpdateVaccination_Click(object sender, EventArgs e)
        {
            //Only update the vaccination details of the dog if the user input is valid.
            if (CheckVaccinationName() && CheckVaccinationDate())
            {
                FrmJDDogCare.UpdateRecord("Dog_Vaccination", new object[] { "DogID", currentDogID, "VaccinationNo", vaccinationNo,
                    "VaccinationDate", dtpVaccinationDate.Value });

                string name = dog.Rows[0]["DogName"].ToString().ToUpper();
                MessageBox.Show($"{name}'S vaccination history has been successfully updated.", "UPDATED SUCCESSFULLY");

                //Place ticks where necessary.
                ep.Icon = Properties.Resources.Tick;
                foreach (Control control in this.Controls)
                {
                    if (control is ComboBox || control is DateTimePicker)
                        ep.SetError(control, "Valid");
                }

                //Update the table with the new updated vaccination details.
                dgvVaccinationHistory.DataSource = FrmJDDogCare.GetTable("DogVaccinationHistory", "DogID", currentDogID, true);
            }
            else
            {
                //If not valid then place error providers where necessary.
                CheckVaccinationName();
                CheckVaccinationDate();
            }
        }

        //Validate user input as they enter values into the fields.
        private bool CheckVaccinationName()
        {
            bool v = false;

            if (String.IsNullOrEmpty(cbVaccinationName.Text))
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbVaccinationName, "Please provide what vaccination you want to update.");
            }
            else
            {
                ep.SetError(cbVaccinationName, null);
                //Set the vaccination number using the vaccination name.
                vaccinationNo = FrmJDDogCare.FindID("Vaccination", "", "", "", "", "VaccinationName", cbVaccinationName.Text)[0];
                v = true;
            }

            return v;
        }

        private bool CheckVaccinationDate()
        {
            bool v = true;

            //The dog should not be able to get a vaccination before they were born and the date should not be set in the future either.
            if (dtpVaccinationDate.Value < (DateTime)dog.Rows[0]["DateOfBirth"] || dtpVaccinationDate.Value > DateTime.Now)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpVaccinationDate, "This date of vaccination is invalid");
                v = false;
            }
            else
                ep.SetError(dtpVaccinationDate, null);

            return v;
        }
    }
}
