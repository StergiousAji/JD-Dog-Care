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
    public partial class UcClient : UserControl
    {
        Client client = new Client();

        //String variables to store the first ClientID in the database table and the next ClientID for a new registered client.
        string firstID, newID;

        List<string> availableClients = FrmJDDogCare.AvailableIDs("Client", "ClientID");

        public UcClient()
        {
            InitializeComponent();

            firstID = FrmJDDogCare.FirstID("Client");
            newID = FrmJDDogCare.NewID("Client", "ClientID");

            if (FrmJDDogCare.currentUserControl == "Register")
            {
                //Change btnClient to a Register Button and reposition.
                btnClient.Text = "Register";
                btnClient.Top -= 20;

                //Hide unwanted controls for registering.
                btnPrevious.Dispose();
                btnNext.Dispose();
                btnSearch.Dispose();
                txtSearch.Dispose();
                lblDateJoined.Hide();
                dtpDateJoined.Hide();
                btnViewClientDogs.Dispose();
                btnDelete.Dispose();

                //Reposition desired controls for registering.
                foreach (Control control in this.Controls)
                {
                    if (control != btnClient)
                        control.Top -= 30;
                }

                //Set the Read Only ClientID text field to the new ID number and set the date joined to the current date.
                txtClientID.Text = newID;
                dtpDateJoined.Value = DateTime.Now;
            }
            else if (FrmJDDogCare.currentUserControl == "Update")
            {
                //Change btnClient to an Update Button.
                btnClient.Text = "Update";
                txtSearch.AutoCompleteCustomSource = FrmJDDogCare.GetNames("Client");

                //Display the first client record in the table.
                DisplayRecord("ClientID", firstID);
            }
        }

        //Click Event to display the previous client record.
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtClientID.Text))
            {
                //Varaible to store the index of the current clientID out of the available ones.
                int currentID = availableClients.IndexOf(txtClientID.Text);
                //Code to prevent clientID from going below "0001".
                if (currentID > 0)
                    DisplayRecord("ClientID", availableClients[currentID - 1]);

                dgvDogsOwned.DataSource = FrmJDDogCare.GetTable("Dog", "ClientID", txtClientID.Text);
            }
        }

        //Click Event to display the next client record.
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtClientID.Text))
            {
                //Varaible to store the index of the current clientID out of the available ones.
                int currentID = availableClients.IndexOf(txtClientID.Text);
                //Code to prevent the index to go over the list's count.
                if (currentID + 1 < availableClients.Count)
                    DisplayRecord("ClientID", availableClients[currentID + 1]);
                dgvDogsOwned.DataSource = FrmJDDogCare.GetTable("Dog", "ClientID", txtClientID.Text);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (FrmJDDogCare.GetNames("Client").Contains(txtSearch.Text))
            {
                string forename = txtSearch.Text.Split(',', ' ')[2];
                string surname = txtSearch.Text.Split(',', ' ')[0];
                if (surname.Contains("'"))
                    surname = surname.Insert(surname.IndexOf('\''), "'");

                string clientID = FrmJDDogCare.FindID("Client", forename, surname)[0];

                DisplayRecord("ClientID", clientID);
                dgvDogsOwned.DataSource = FrmJDDogCare.GetTable("Dog", "ClientID", txtClientID.Text);
            }
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            //Do a final check to see if the user input has been set to the Client class object's properties.
            bool valid = client.Forename == txtForename.Text && client.Surname == txtSurname.Text && client.Sex == cbSex.Text && client.DateOfBirth == dtpDOB.Value &&
                client.Address == txtAddress.Text && client.City == txtCity.Text && client.Postcode == txtPostcode.Text && client.Email == txtEmail.Text && client.PhoneNo == txtPhoneNo.Text &&
                client.DateJoined == dtpDateJoined.Value;

            if (valid)
            {
                if (btnClient.Text == "Register")
                {
                    FrmJDDogCare.RegisterRecord("Client", new object[] { "ClientID", client.ClientID, "Forename", client.Forename, "Surname", client.Surname, "Sex", client.Sex,
                        "DateOfBirth", client.DateOfBirth, "HomeAddress", client.Address, "City", client.City, "Postcode", client.Postcode, "Email", client.Email,
                        "PhoneNo", client.PhoneNo, "DateJoined", client.DateJoined });

                    //Automatically transfer user to register a dog for this new client.
                    UcDog.currentClientName = $"{client.Surname}, {client.Forename}";
                    UcToolBar.BtnDog_Click(new object(), new EventArgs());
                }
                else if (btnClient.Text == "Update")
                {
                    FrmJDDogCare.UpdateRecord("Client", new object[] { "ClientID", client.ClientID, "Forename", client.Forename, "Surname", client.Surname, "Sex", client.Sex,
                        "DateOfBirth", client.DateOfBirth, "HomeAddress", client.Address, "City", client.City, "Postcode", client.Postcode, "Email", client.Email,
                        "PhoneNo", client.PhoneNo, "DateJoined", client.DateJoined });
                }

                //Place tick icons on all the fields.
                ep.Icon = Properties.Resources.Tick;
                foreach (Control control in this.Controls)
                {
                    if (!(control is Button) && !(control is Label) && control != txtSearch)
                        ep.SetError(control, "Valid");
                }
            }
            else
            {
                //If not valid then place error providers where necessary.
                CheckClientID();
                CheckForename();
                CheckSurname();
                CheckSex();
                CheckDOB();
                CheckAddress();
                CheckCity();
                CheckPostcode();
                CheckEmail();
                CheckPhoneNo();
                CheckDateJoined();
            }
        }

        private void BtnViewClientDogs_Click(object sender, EventArgs e)
        {
            dgvDogsOwned.DataSource = FrmJDDogCare.GetTable("Dog", "ClientID", txtClientID.Text);

            if (!dgvDogsOwned.Visible)
            {
                foreach (Control control in this.Controls)
                {
                    if (control.Bottom > 70 && control != btnViewClientDogs)
                        control.Hide();
                }

                dgvDogsOwned.Show();

                btnViewClientDogs.BackColor = Color.FromArgb(153, 38, 0);
                btnViewClientDogs.Text = "Hide Dogs Owned";
            }
            else
            {
                foreach (Control control in this.Controls)
                    control.Show();

                dgvDogsOwned.Hide();

                btnViewClientDogs.BackColor = Color.FromArgb(0, 115, 153);
                btnViewClientDogs.Text = "View Dogs Owned";
            }
        }

        private void DgvDogsOwned_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure that the user has not double clicked the row header by mistake.
            if (e.RowIndex != -1)
            {
                //Set variable 'id' to the DogID of the dog that the user selected from the Data Grid and then run the BtnDog Click Event from the Tool Bar.
                UcDog.id = dgvDogsOwned.Rows[e.RowIndex].Cells["DogID"].Value.ToString();
                UcToolBar.BtnDog_Click(new object(), new EventArgs());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string forename = txtForename.Text.ToUpper();
            string surname = txtSurname.Text.ToUpper();

            DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete '{txtClientID.Text}' {forename} {surname} from the database?", "CONFIRM DELETION", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                FrmJDDogCare.DeleteRecord("Client", txtClientID.Text);
                MessageBox.Show($"Client '{txtClientID.Text}' {forename} {surname} has been deleted successfully", "DELETED SUCCESSFULLY");
                BtnPrevious_Click(new object(), new EventArgs());
            }
        }

        //UPDATE DISPLAY
        //-Method to display client records for editing/updating.
        private void DisplayRecord(string column, string value)
        {
            List<object> record = FrmJDDogCare.GetRecord("Client", column, value, FrmJDDogCare.client_columns);

            //Record is only displayed on the user control when it is not empty.
            if (record.Count != 0)
            {
                txtClientID.Text = (string)record[0];
                txtForename.Text = (string)record[1];
                txtSurname.Text = (string)record[2];
                cbSex.Text = (string)record[3];
                dtpDOB.Value = (DateTime)record[4];
                txtAddress.Text = (string)record[5];
                txtCity.Text = (string)record[6];
                txtPostcode.Text = (string)record[7];
                txtEmail.Text = (string)record[8];
                txtPhoneNo.Text = (string)record[9];
                dtpDateJoined.Value = (DateTime)record[10];
            }
            else
                MessageBox.Show("There are no client records to show.", "ALERT!");
        }

        //Validate user input as they enter values into the fields.
        private void TxtClientID_TextChanged(object sender, EventArgs e)
        {
            CheckClientID();
        }

        private void TxtForename_TextChanged(object sender, EventArgs e)
        {
            CheckForename();
        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            CheckSurname();
        }

        private void CbSex_TextChanged(object sender, EventArgs e)
        {
            CheckSex();
        }

        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            CheckDOB();
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            CheckAddress();
        }

        private void TxtCity_TextChanged(object sender, EventArgs e)
        {
            CheckCity();
        }

        private void TxtPostcode_TextChanged(object sender, EventArgs e)
        {
            CheckPostcode();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckEmail();
        }

        private void TxtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            CheckPhoneNo();
        }

        private void DtpDateJoined_ValueChanged(object sender, EventArgs e)
        {
            CheckDateJoined();
        }

        //Check and Validate User input (Methods).        
        private void CheckClientID()
        {
            try
            {
                client.ClientID = txtClientID.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtClientID, ex.Message); 
            }
            finally
            {
                if (client.ClientID == txtClientID.Text)
                    ep.SetError(txtClientID, null);
            }
        }

        private void CheckForename()
        {
            try
            {
                client.Forename = txtForename.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtForename, ex.Message);
            }
            finally
            {
                if (client.Forename == txtForename.Text)
                    ep.SetError(txtForename, null);
            }
        }

        private void CheckSurname()
        {
            try
            {
                client.Surname = txtSurname.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtSurname, ex.Message);
            }
            finally
            {
                if (client.Surname == txtSurname.Text)
                    ep.SetError(txtSurname, null);
            }
        }

        private void CheckSex()
        {
            try
            {
                client.Sex = cbSex.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbSex, ex.Message);
            }
            finally
            {
                if (client.Sex == cbSex.Text)
                    ep.SetError(cbSex, null);
            }
        }

        private void CheckDOB()
        {
            try
            {
                client.DateOfBirth = dtpDOB.Value;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDOB, ex.Message);
            }
            finally
            {
                if (client.DateOfBirth == dtpDOB.Value)
                    ep.SetError(dtpDOB, null);
            }
        }

        private void CheckAddress()
        {
            try
            {
                client.Address = txtAddress.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtAddress, ex.Message);
            }
            finally
            {
                if (client.Address == txtAddress.Text)
                    ep.SetError(txtAddress, null);
            }
        }

        private void CheckCity()
        {
            try
            {
                client.City = txtCity.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtCity, ex.Message);
            }
            finally
            {
                if (client.City == txtCity.Text)
                    ep.SetError(txtCity, null);
            }
        }

        private void CheckPostcode()
        {
            try
            {
                client.Postcode = txtPostcode.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtPostcode, ex.Message);
            }
            finally
            {
                if (client.Postcode == txtPostcode.Text)
                    ep.SetError(txtPostcode, null);
            }
        }

        private void CheckEmail()
        {
            try
            {
                client.Email = txtEmail.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtEmail, ex.Message);
            }
            finally
            {
                if (client.Email == txtEmail.Text)
                    ep.SetError(txtEmail, null);
            }
        }

        private void CheckPhoneNo()
        {
            try
            {
                client.PhoneNo = txtPhoneNo.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtPhoneNo, ex.Message);
            }
            finally
            {
                if (client.PhoneNo == txtPhoneNo.Text)
                    ep.SetError(txtPhoneNo, null);
            }
        }

        private void CheckDateJoined()
        {
            try
            {
                client.DateJoined = dtpDateJoined.Value;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDateJoined, ex.Message);
            }
            finally
            {
                if (client.DateJoined == dtpDateJoined.Value)
                    ep.SetError(dtpDateJoined, null);
            }
        }

        //private void CheckProperty(string property_name, object value, Control control)
        //{
        //    var property = typeof(Client).GetProperty(property_name);
        //    try
        //    {
        //        property.SetValue(client, Convert.ChangeType(value, property.PropertyType), null);
        //    }
        //    catch (CustomException ex)
        //    {
        //        ep.Icon = Properties.Resources.Error;
        //        ep.SetError(control, ex.Message);
        //    }
        //    finally
        //    {
        //        if (property == Convert.ChangeType(value, property.PropertyType))
        //            ep.SetError(control, null);
        //    }
        //}
    }
}
