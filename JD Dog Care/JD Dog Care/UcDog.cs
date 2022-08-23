using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace JD_Dog_Care
{
    public partial class UcDog : UserControl
    {
        Dog dog = new Dog();

        //Public string variable to initially store the first DogID in the database table.
        public static string id = FrmJDDogCare.FirstID("Dog");

        //String variable to store the next DogID for a new registered dog.
        string newID;

        List<string> availableDogs = FrmJDDogCare.AvailableIDs("Dog", "DogID");

        //String variable to store the client when the user is transferred from the Client Page.
        public static string currentClientName = "";

        UserControl dogVaccinationHistory;

        public UcDog()
        {
            InitializeComponent();

            newID = FrmJDDogCare.NewID("Dog", "DogID");

            for (int i = 0; i < FrmJDDogCare.GetNames("Client").Count; i++)
                cbClientName.Items.Insert(i, FrmJDDogCare.GetNames("Client")[i]);

            cbClientName.AutoCompleteCustomSource = FrmJDDogCare.GetNames("Client");

            if (FrmJDDogCare.currentUserControl == "Register")
            {
                //Change btnDog to a Register Button and reposition.
                btnDog.Text = "Register";
                btnDog.Top -= 30;

                //Dispose all unwanted controls for registering.
                btnPrevious.Dispose();
                btnNext.Dispose();
                txtSearch.Dispose();
                btnSearch.Dispose();
                pbDogProfile.Dispose();
                lblClientID.Dispose();
                txtClientID.Hide();
                lblMedicalNotes.Dispose();
                rtxtMedicalNotes.Hide();
                btnViewMedicalNotes.Dispose();
                btnViewVaccinationHistory.Dispose();
                btnDelete.Dispose();

                //Reposition desired controls for registering.
                lblDogID.Location = lblClientID.Location;
                txtDogID.Location = txtClientID.Location;
                foreach (Control control in this.Controls)
                {
                    if (control != btnDog)
                        control.Location = new Point(control.Location.X - 155, control.Location.Y - 20);
                }

                //Set the Read Only DogID text field to the new ID number.
                txtDogID.Text = newID;

                //If the Dog Restration was loaded from a new successful Client Registration then set the Client Name to new client.
                cbClientName.Text = currentClientName;

                //Set the Dietary Requirements to the default 'None' which can be changed in the update screen.
                rtxtMedicalNotes.Text = "None";
            }
            else if (FrmJDDogCare.currentUserControl == "Update")
            {
                //Change btnDog to an Update Button.
                btnDog.Text = "Update";
                txtSearch.AutoCompleteCustomSource = FrmJDDogCare.GetNames("Dog");

                //Initially hide Dietery Requirements text field.
                lblMedicalNotes.Hide();
                rtxtMedicalNotes.Hide();

                //Display the dog record depending on the 'id' string variable in the table.
                DisplayRecord("DogID", id);
                LoadImage(Convert.ToInt32(id.TrimStart(new Char[] { '0' })));
            }
        }

        //Click Event to display the previous dog record.
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDogID.Text))
            {
                //Varaible to store the index of the current DogID out of the available ones.
                int currentID = availableDogs.IndexOf(txtDogID.Text);
                //Code to prevent DogID from going below "0001".
                if (currentID > 0)
                    DisplayRecord("DogID", availableDogs[currentID - 1]);

                LoadImage(int.Parse(txtDogID.Text.TrimStart(new Char[] { '0' })));
            }
        }

        //Click Event to display the next dog record.
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDogID.Text))
            {
                //Varaible to store the index of the current DogID out of the available ones.
                int currentID = availableDogs.IndexOf(txtDogID.Text);
                //Code to prevent the index to go over the list's count.
                if (currentID + 1 < availableDogs.Count)
                    DisplayRecord("DogID", availableDogs[currentID + 1]);

                LoadImage(int.Parse(txtDogID.Text.TrimStart(new Char[] { '0' })));
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (FrmJDDogCare.GetNames("Dog").Contains(txtSearch.Text))
            {
                string forename = txtSearch.Text.Split(' ', ',')[4];
                string surname = txtSearch.Text.Split(' ', ',')[2];
                string dogName = txtSearch.Text.Split(' ', ',')[0];
                //Format any apostrophes in surname as 2 apostrophes, e.g. ("O''Doherty").
                if (surname.Contains("'"))
                    surname = surname.Insert(surname.IndexOf('\''), "'");

                string dogID = FrmJDDogCare.FindID("Dog", forename, surname, dogName)[0];
                
                DisplayRecord("DogID", dogID);
                LoadImage(int.Parse(dogID));
            }
        }

        private void BtnDog_Click(object sender, EventArgs e)
        {
            //Do a final check to see if the user input has been set to the Dog class object's properties.
            bool valid = dog.DogID == dog.DogID && dog.ClientID == txtClientID.Text && dog.Name == txtName.Text && dog.Breed == txtBreed.Text && dog.Sex == cbSex.Text &&
                dog.DateOfBirth == dtpDOB.Value && dog.MedicalNotes == rtxtMedicalNotes.Text;

            if (valid)
            {
                if (btnDog.Text == "Register")
                {
                    FrmJDDogCare.RegisterRecord("Dog", new object[] { "DogID", dog.DogID, "ClientID", dog.ClientID, "DogName", dog.Name, "Breed", dog.Breed, "Sex", dog.Sex,
                        "DateOfBirth", dog.DateOfBirth, "MedicalNotes", dog.MedicalNotes });

                    AddVaccinationHistory();

                    //Transfer the user to Dog Update page for updating the new dog.
                    id = dog.DogID;
                    FrmJDDogCare.BtnUpdate_Click(new object(), new EventArgs());
                    UcToolBar.BtnDog_Click(new object(), new EventArgs());
                }
                else if (btnDog.Text == "Update" && dog.MedicalNotes == rtxtMedicalNotes.Text)
                {
                    FrmJDDogCare.UpdateRecord("Dog", new object[] { "DogID", dog.DogID, "ClientID", dog.ClientID, "DogName", dog.Name, "Breed", dog.Breed, "Sex", dog.Sex,
                        "DateOfBirth", dog.DateOfBirth, "MedicalNotes", dog.MedicalNotes});
                }

                //Place tick icons on all the fields.
                ep.Icon = Properties.Resources.Tick;
                foreach (Control control in this.Controls)
                {
                    if (!(control is Button) && !(control is Label) && !(control is PictureBox) && !(control is RichTextBox) &&
                        control != txtSearch)
                        ep.SetError(control, "Valid");
                }
            }
            else
            {
                //If not valid then place error providers where necessary.
                CheckDogID();
                CheckClientID();
                CbClientName_TextChanged(new object(), new EventArgs());
                CheckName();
                CheckBreed();
                CheckSex();
                CheckDOB();
                CheckMedicalNotes();
            }
        }

        //Method to add an empty vaccination history for each new dog which can be updated in the Update Page.
        private void AddVaccinationHistory()
        {
            int numOfVac = FrmJDDogCare.GetTable("Vaccination").Rows.Count;

            for (int i = 1; i <= numOfVac; i++)
            {
                string vaccinationNo = FrmJDDogCare.FormatID(i.ToString());
                FrmJDDogCare.RegisterRecord("Dog_Vaccination", new object[] { dog.DogID, vaccinationNo });
            }

            MessageBox.Show($"An empty vaccination history for the dog has been created. Please view and update it on the Dog Update page.", "VACCINATION HISTORY CREATED SUCCESSFULLY");
        }

        private void BtnViewMedicalNotes_Click(object sender, EventArgs e)
        {
            if (!rtxtMedicalNotes.Visible)
            {
                pbDogProfile.Hide();
                lblMedicalNotes.Show();
                rtxtMedicalNotes.Show();

                btnViewMedicalNotes.BackColor = Color.FromArgb(153, 38, 0);
                btnViewMedicalNotes.Text = "Hide Medical Notes";
            }
            else
            {           

                pbDogProfile.Show();
                lblMedicalNotes.Hide();
                rtxtMedicalNotes.Hide();

                btnViewMedicalNotes.BackColor = Color.FromArgb(0, 115, 153);
                btnViewMedicalNotes.Text = "View Medical Notes";
            }
        }

        private void BtnViewVaccinationHistory_Click(object sender, EventArgs e)
        {
            if (btnViewVaccinationHistory.Text.Contains("View"))
            {
                UcDogVaccinationHistory.currentDogID = dog.DogID;
                dogVaccinationHistory = new UcDogVaccinationHistory();
                dogVaccinationHistory.Location = new Point(149, 30);
                dogVaccinationHistory.Visible = false;
                this.Controls.Add(dogVaccinationHistory);

                foreach (Control control in this.Controls)
                {
                    if (control != btnViewVaccinationHistory)
                        control.Hide();
                }

                dogVaccinationHistory.Show();
                btnViewVaccinationHistory.BackColor = Color.FromArgb(153, 38, 0);
                btnViewVaccinationHistory.Text = "Hide Vaccination History";
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control != lblMedicalNotes && control != rtxtMedicalNotes)
                        control.Show();
                }

                this.Controls.Remove(dogVaccinationHistory);
                btnViewVaccinationHistory.BackColor = Color.FromArgb(0, 115, 153);
                btnViewVaccinationHistory.Text = "View Vaccination History";

                btnViewMedicalNotes.BackColor = Color.FromArgb(0, 115, 153);
                btnViewMedicalNotes.Text = "View Medical Notes";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToUpper();

            DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete '{txtDogID.Text}' {name} from the database?", "CONFIRM DELETION", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                FrmJDDogCare.DeleteRecord("Dog", txtDogID.Text);
                MessageBox.Show($"Dog '{txtDogID.Text}' {name} has been deleted successfully", "DELETED SUCCESSFULLY");
                BtnPrevious_Click(new object(), new EventArgs());
            }
        }

        //UPDATE DISPLAY
        //-Methods to display dog records and images for editing/updating.
        private void DisplayRecord(string column, string value)
        {
            List<object> record = FrmJDDogCare.GetRecord("Dog", column, value, FrmJDDogCare.dog_columns);

            //Record is only displayed on the user control when it is not empty.
            if (record.Count != 0)
            {
                txtDogID.Text = (string)record[0];
                txtClientID.Text = (string)record[1];
                cbClientName.Text = (string)record[2];
                txtName.Text = (string)record[3];
                txtBreed.Text = (string)record[4];
                cbSex.Text = (string)record[5];
                dtpDOB.Value = (DateTime)record[6];
                rtxtMedicalNotes.Text = (string)record[7];
            }
            else
                MessageBox.Show("There are no dog records to show.", "ALERT!");
        }

        private void LoadImage(int dogID)
        {
            //Loads the desired image onto the picture box from the debug folder.
            string image_path = $@".\images\dogs\{dogID}.jpg";
            if (File.Exists(image_path))
            {
                pbDogProfile.BackColor = Color.FromArgb(116, 37, 77);
                pbDogProfile.Load(image_path);
            }
            else
            {
                pbDogProfile.Image = null;
                pbDogProfile.BackColor = Color.FromArgb(179, 179, 179);
            }
        }

        //Validate user input as they enter values into the fields.
        private void TxtDogID_TextChanged(object sender, EventArgs e)
        {
            CheckDogID();
        }

        private void TxtClientID_TextChanged(object sender, EventArgs e)
        {
            CheckClientID();
        }

        private void CbClientName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbClientName.Text))
                ep.SetError(cbClientName, "Please provide the full name of the owner of the dog.");
            else if (!(FrmJDDogCare.GetNames("Client").Contains(cbClientName.Text)))
                ep.SetError(cbClientName, "This client does not exist.");
            else
            {
                ep.SetError(cbClientName, null);

                string forename = cbClientName.Text.Split(',', ' ')[2];
                string surname = cbClientName.Text.Split(',', ' ')[0];
                if (surname.Contains("'"))
                    surname = surname.Insert(surname.IndexOf('\''), "'");

                txtClientID.Text = FrmJDDogCare.FindID("Client", forename, surname)[0];
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            CheckName();
        }

        private void TxtBreed_TextChanged(object sender, EventArgs e)
        {
            CheckBreed();
        }

        private void CbSex_TextChanged(object sender, EventArgs e)
        {
            CheckSex();
        }

        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            CheckDOB();
        }

        private void RtxtDietaryRequirements_TextChanged(object sender, EventArgs e)
        {
            CheckMedicalNotes();
        }

        //Check and Validate User input (Methods)
        private void CheckDogID()
        {
            try
            {
                dog.DogID = txtDogID.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtDogID, ex.Message);
            }
            finally
            {
                if (dog.DogID == txtDogID.Text)
                    ep.SetError(txtDogID, null);
            }
        }

        private void CheckClientID()
        {
            try
            {
                dog.ClientID = txtClientID.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtClientID, ex.Message);
            }
            finally
            {
                if (dog.ClientID == txtClientID.Text)
                    ep.SetError(txtClientID, null);
            }
        }

        private void CheckName()
        {
            try
            {
                dog.Name = txtName.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtName, ex.Message);
            }
            finally
            {
                if (dog.Name == txtName.Text)
                    ep.SetError(txtName, null);
            }
        }

        private void CheckBreed()
        {
            try
            {
                dog.Breed = txtBreed.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtBreed, ex.Message);
            }
            finally
            {
                if (dog.Breed == txtBreed.Text)
                    ep.SetError(txtBreed, null);
            }
        }

        private void CheckSex()
        {
            try
            { 
                dog.Sex = cbSex.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbSex, ex.Message);
            }
            finally
            {
                if (dog.Sex == cbSex.Text)
                    ep.SetError(cbSex, null);
            }
        }

        private void CheckDOB()
        {
            try
            {
                dog.DateOfBirth = dtpDOB.Value;
            }
            catch (CustomException ex)
            { 
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDOB, ex.Message);
            }
            finally
            {
                if (dog.DateOfBirth == dtpDOB.Value)
                    ep.SetError(dtpDOB, null);
            }
        }

        private void CheckMedicalNotes()
        {
            try
            {
                dog.MedicalNotes = rtxtMedicalNotes.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(rtxtMedicalNotes, ex.Message);
            }
            finally
            {
                if (dog.MedicalNotes == rtxtMedicalNotes.Text)
                    ep.SetError(rtxtMedicalNotes, null);
            }
        }
    }
}
