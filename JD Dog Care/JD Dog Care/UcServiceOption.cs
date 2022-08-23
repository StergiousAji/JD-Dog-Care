using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JD_Dog_Care
{
    public partial class UcServiceOption : UserControl
    {
        Option serviceOption = new Option();

        //String variable to store the next Service Option Number.
        string newServiceOptionNo;

        public UcServiceOption()
        {
            InitializeComponent();

            newServiceOptionNo = FrmJDDogCare.NewID("Options", "ServiceOptionNo");

            if (FrmJDDogCare.currentUserControl == "Add Service Option")
            {
                btnServiceOption.Text = "Create";
                btnServiceOption.Top -= 80;

                dgvServiceOptions.Dispose();
                btnDelete.Dispose();

                foreach (Control control in this.Controls)
                {
                    if (control != btnServiceOption && control != btnBack && control != btnDelete)
                        control.Top -= 110;
                }

                txtServiceOptionNo.Text = newServiceOptionNo;
            }
            else if (FrmJDDogCare.currentUserControl == "Update Service Option")
            {
                btnServiceOption.Text = "Update";

                dgvServiceOptions.DataSource = FrmJDDogCare.GetTable("Options");
            }
        }

        private void DgvServiceOptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure that the user has not double clicked the row header by mistake.
            if (e.RowIndex != -1)
            {
                string serviceOptionNo = dgvServiceOptions.Rows[e.RowIndex].Cells["ServiceOptionNo"].Value.ToString();
                DisplayRecord("ServiceOptionNo", serviceOptionNo);
            }
        }

        private void BtnServiceOption_Click(object sender, EventArgs e)
        {
            bool valid = serviceOption.ServiceOptionNo == txtServiceOptionNo.Text && serviceOption.ServiceOptionDescription == rtxtServiceOptionDescription.Text && 
                serviceOption.Price == (double)nupPrice.Value;

            //If Duration is not in the right format then just 
            if (!CheckDuration())
                valid = false;
            else
                valid = valid && serviceOption.Duration == TimeSpan.Parse(txtDuration.Text);

            if (valid)
            {
                if (btnServiceOption.Text == "Create")
                {
                    FrmJDDogCare.RegisterRecord("Options", new object[] { "ServiceOptionNo", serviceOption.ServiceOptionNo, "ServiceOptionDescription", serviceOption.ServiceOptionDescription,
                        "Duration", serviceOption.Duration, "Price", serviceOption.Price });

                    MessageBox.Show($"SERVICE {txtServiceOptionNo.Text.ToUpper()} has been successfully created.", "SERVICE OPTION CREATED SUCCESSFULLY");
                }
                else
                {
                    FrmJDDogCare.UpdateRecord("Options", new object[] { "ServiceOptionNo", serviceOption.ServiceOptionNo, "ServiceOptionDescription", serviceOption.ServiceOptionDescription,
                        "Duration", serviceOption.Duration, "Price", serviceOption.Price });

                    MessageBox.Show($"SERVICE {txtServiceOptionNo.Text.ToUpper()} has been successfully updated.", "UPDATED SUCCESSFULLY");

                    dgvServiceOptions.DataSource = FrmJDDogCare.GetTable("Options");
                }
            }
            else
            {
                CheckServiceOptionNo();
                CheckServiceOptionDescription();
                CheckDuration();
                CheckPrice();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtServiceOptionNo.Text))
            {
                FrmJDDogCare.DeleteRecord("Options", txtServiceOptionNo.Text);
                MessageBox.Show($"SERVICE {txtServiceOptionNo.Text.ToUpper()} has been successfully deleted.", "DELETED SUCCESSFULLY");

                dgvServiceOptions.DataSource = FrmJDDogCare.GetTable("Options");
            }
            else
                CheckServiceOptionNo();
        }

        //UPDATE DISPLAY
        //-Method to display service option records for editing/updating.
        private void DisplayRecord(string column, string value)
        {
            List<object> record = FrmJDDogCare.GetRecord("Options", column, value, FrmJDDogCare.option_columns);

            //Record is only displayed on the user control when it is not empty.
            if (record.Count != 0)
            {
                txtServiceOptionNo.Text = (string)record[0];
                rtxtServiceOptionDescription.Text = (string)record[1];
                TimeSpan duration = (TimeSpan)record[2];
                txtDuration.Text = duration.ToString(@"hh\:mm");
                nupPrice.Value = (decimal)record[3];
            }
        }

        private void TxtServiceOptionNo_TextChanged(object sender, EventArgs e)
        {
            CheckServiceOptionNo();
        }

        private void RtxtServiceOptionDescription_TextChanged(object sender, EventArgs e)
        {
            CheckServiceOptionDescription();
        }

        private void TxtDuration_TextChanged(object sender, EventArgs e)
        {
            CheckDuration();
        }

        private void NupPrice_ValueChanged(object sender, EventArgs e)
        {
            CheckPrice();
        }

        //Validate user input as they enter values into the fields.
        private void CheckServiceOptionNo()
        {
            try
            {
                serviceOption.ServiceOptionNo = txtServiceOptionNo.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtServiceOptionNo, ex.Message);
            }
            finally
            {
                if (txtServiceOptionNo.Text == serviceOption.ServiceOptionNo)
                    ep.SetError(txtServiceOptionNo, null);
            }
        }

        private void CheckServiceOptionDescription()
        {
            try 
            {
                serviceOption.ServiceOptionDescription = rtxtServiceOptionDescription.Text;
            }
            catch (CustomException ex) 
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(rtxtServiceOptionDescription, ex.Message);
            }
            finally 
            {
                if (rtxtServiceOptionDescription.Text == serviceOption.ServiceOptionDescription)
                    ep.SetError(rtxtServiceOptionDescription, null);
            }
        }

        private bool CheckDuration()
        {
            //Reqular expression to see if the duration is in the format: "NN:NN" [N = Number].
            Regex reg = new Regex(@"^(0?[0-4]):[0-5][0-9]$");
            if (!reg.IsMatch(txtDuration.Text))
            {
                ep.SetError(txtDuration, "This duration is not in the correct format.");
                return false;
            }

            try
            {
                serviceOption.Duration = TimeSpan.Parse(txtDuration.Text);
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtDuration, ex.Message);
            }
            finally 
            {
                if (TimeSpan.Parse(txtDuration.Text) == serviceOption.Duration && serviceOption.Duration != TimeSpan.Parse("0:00"))
                    ep.SetError(txtDuration, null);
            }

            return true;
        }

        private void CheckPrice()
        {
            try 
            {
                serviceOption.Price = Convert.ToDouble(nupPrice.Value);
            }
            catch (CustomException ex) 
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(nupPrice, ex.Message);
            }
            finally 
            {
                if (nupPrice.Value == (decimal)serviceOption.Price)
                    ep.SetError(nupPrice, null);
            }
        }
    }
}
