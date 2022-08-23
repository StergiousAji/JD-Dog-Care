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
    public partial class UcStaff : UserControl
    {
        Staff staff = new Staff();

        string firstID, newID;

        List<string> availableStaff = FrmJDDogCare.AvailableIDs("Staff", "StaffID");

        public UcStaff()
        {
            InitializeComponent();

            firstID = FrmJDDogCare.FirstID("Staff");
            newID = FrmJDDogCare.NewID("Staff", "StaffID");

            if (FrmJDDogCare.currentUserControl == "Register")
            {
                //Change btnStaff to a Register Button.
                btnStaff.Text = "Register";

                //Hide unwanted controls for registering.
                btnPrevious.Dispose();
                btnNext.Dispose();
                txtSearch.Dispose();
                btnSearch.Dispose();
                lblDateJoined.Dispose();
                dtpDateJoined.Dispose();
                btnDelete.Dispose();

                //Reposition desired controls for registering.
                foreach (Control control in this.Controls)
                {
                    control.Top -= 20;

                    if (control.Right > 390 && control != btnStaff)
                        control.Top += 45;
                }

                //Set the Read Only StaffID text field to the new ID number and set the date joined to the current date.
                txtStaffID.Text = newID;
                dtpDateJoined.Value = DateTime.Now;
            }
            else if (FrmJDDogCare.currentUserControl == "Update")
            {
                //Change btnStaff to an Update Button.
                btnStaff.Text = "Update";
                txtSearch.AutoCompleteCustomSource = FrmJDDogCare.GetNames("Staff");

                //Display the first staff record in the table.
                DisplayRecord("StaffID", firstID);
            }
        }

        //Click Event to display the previous staff record.
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtStaffID.Text))
            { 
                //Varaible to store the index of the current StaffID out of the available ones.
                int currentID = availableStaff.IndexOf(txtStaffID.Text);
                //Code to prevent StaffID from going below "0001".
                if (currentID > 0)
                    DisplayRecord("StaffID", availableStaff[currentID - 1]);
            }
        }

        //Click Event to display the next staff record.
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtStaffID.Text))
            {
                //Varaible to store the index of the current StaffID out of the available ones.
                int currentID = availableStaff.IndexOf(txtStaffID.Text);
                //Code to prevent the index to go over the list's count.
                if (currentID + 1 < availableStaff.Count)
                    DisplayRecord("StaffID", availableStaff[currentID + 1]);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (FrmJDDogCare.GetNames("Staff").Contains(txtSearch.Text))
            {
                string forename = txtSearch.Text.Split(',', ' ')[2];
                string surname = txtSearch.Text.Split(',', ' ')[0];
                if (surname.Contains("'"))
                    surname = surname.Insert(surname.IndexOf('\''), "'");

                string staffID = FrmJDDogCare.FindID("Staff", forename, surname)[0];

                DisplayRecord("StaffID", staffID);
            }
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            //Do a final check to see if the user input has been set to the Staff class object's properties.
            bool valid = staff.Forename == txtForename.Text && staff.Surname == txtSurname.Text && staff.Sex == cbSex.Text && staff.DateOfBirth == dtpDOB.Value &&
                staff.Address == txtAddress.Text && staff.City == txtCity.Text && staff.Postcode == txtPostcode.Text && staff.Email == txtEmail.Text && staff.PhoneNo == txtPhoneNo.Text &&
                (staff.JobContract == chbFullTime.Text || staff.JobContract == chbPartTime.Text) && staff.JobPosition == cbJobPosition.Text && 
                staff.Salary == Convert.ToDouble(nupSalary.Value) && staff.DateJoined == dtpDateJoined.Value;
            
            if (valid)
            {
                if (btnStaff.Text == "Register")
                {
                    FrmJDDogCare.RegisterRecord("Staff", new object[] { "StaffID", staff.StaffID, "Forename", staff.Forename, "Surname", staff.Surname, "Sex", staff.Sex,
                        "DateOfBirth", staff.DateOfBirth, "HomeAddress", staff.Address, "City", staff.City, "Postcode", staff.Postcode, "Email", staff.Email, "PhoneNo", staff.PhoneNo,
                        "JobContract", staff.JobContract, "JobPosition", staff.JobPosition, "Salary", staff.Salary, "DateJoined", staff.DateJoined });
                }
                else if (btnStaff.Text == "Update")
                {
                    FrmJDDogCare.UpdateRecord("Staff", new object[] { "StaffID", staff.StaffID, "Forename", staff.Forename, "Surname", staff.Surname, "Sex", staff.Sex,
                        "DateOfBirth", staff.DateOfBirth, "HomeAddress", staff.Address, "City", staff.City, "Postcode", staff.Postcode, "Email", staff.Email, "PhoneNo", staff.PhoneNo,
                        "JobContract", staff.JobContract, "JobPosition", staff.JobPosition, "Salary", staff.Salary, "DateJoined", staff.DateJoined });
                }

                //Place tick icons on all the fields.
                ep.Icon = Properties.Resources.Tick;
                foreach (Control control in this.Controls)
                {
                    if (!(control is Button) && !(control is Label) && control != txtSearch && control != chbFullTime)
                        ep.SetError(control, "Valid");
                }
            }
            else
            {
                //If not valid then place error providers where necessary.
                CheckForename();
                CheckSurname();
                CheckSex();
                CheckDOB();
                CheckAddress();
                CheckCity();
                CheckPostcode();
                CheckEmail();
                CheckPhoneNo();
                CheckJobContract();
                CheckJobPosition();
                CheckSalary();
                CheckDateJoined();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string forename = txtForename.Text.ToUpper();
            string surname = txtSurname.Text.ToUpper();

            DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete '{txtStaffID.Text}' {forename} {surname} from the database?", "CONFIRM DELETION", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                FrmJDDogCare.DeleteRecord("Staff", txtStaffID.Text);
                MessageBox.Show($"Employee '{txtStaffID.Text}' {forename} {surname} has been deleted successfully", "DELETED SUCCESSFULLY");
                BtnPrevious_Click(new object(), new EventArgs());
            }
        }

        //UPDATE DISPLAY
        //-Method to display staff records for editing/updating.
        private void DisplayRecord(string columnName, string value)
        {
            List<object> record = FrmJDDogCare.GetRecord("Staff", columnName, value, FrmJDDogCare.staff_columns);

            //Record is only displayed on the user control when it is not empty.
            if (record.Count != 0)
            {
                txtStaffID.Text = (string)record[0];
                txtForename.Text = (string)record[1];
                txtSurname.Text = (string)record[2];
                cbSex.Text = (string)record[3];
                dtpDOB.Value = (DateTime)record[4];
                txtAddress.Text = (string)record[5];
                txtCity.Text = (string)record[6];
                txtPostcode.Text = (string)record[7];
                txtEmail.Text = (string)record[8];
                txtPhoneNo.Text = (string)record[9];
                if (chbFullTime.Text == (string)record[10])
                    ChbFullTime_Click(new object(), new EventArgs());
                else
                    ChbPartTime_Click(new object(), new EventArgs());
                cbJobPosition.Text = (string)record[11];
                nupSalary.Value = (decimal)record[12];
                dtpDateJoined.Value = (DateTime)record[13];
            }
            else
                MessageBox.Show("There are no staff records to show.", "ALERT!");
        }

        //Validate user input as they enter values into the fields.
        private void TxtStaffID_TextChanged(object sender, EventArgs e)
        {
            CheckStaffID();
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

        private void ChbFullTime_Click(object sender, EventArgs e)
        {
            ep.SetError(chbPartTime, null);

            //If 'Part-Time' is currently checked then uncheck it and check 'Full-Time'.
            if (chbPartTime.Checked)
                chbPartTime.CheckState = CheckState.Unchecked;

            chbFullTime.CheckState = CheckState.Checked;

            CheckJobContract();
        }

        private void ChbPartTime_Click(object sender, EventArgs e)
        {
            ep.SetError(chbPartTime, null);

            //If 'Full-Time' is currently checked then uncheck it and check 'Part-Time'
            if (chbFullTime.Checked)
                chbFullTime.CheckState = CheckState.Unchecked;

            chbPartTime.CheckState = CheckState.Checked;
            
            CheckJobContract();
        }

        private void CbJobPosition(object sender, EventArgs e)
        {
            CheckJobPosition();
        }

        private void NupSalary_ValueChanged(object sender, EventArgs e)
        {
            CheckSalary();
        }

        private void DtpDateJoined_ValueChanged(object sender, EventArgs e)
        {
            CheckDateJoined();
        }

        //Check and Validate User input (Methods).
        private void CheckStaffID()
        {
            try
            {
                staff.StaffID = txtStaffID.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtStaffID, ex.Message);
            }
            finally
            {
                if (staff.StaffID == txtStaffID.Text)
                    ep.SetError(txtStaffID, null);
            }
        }

        private void CheckForename()
        {
            try
            {
                staff.Forename = txtForename.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtForename, ex.Message);
            }
            finally
            {
                if (staff.Forename == txtForename.Text)
                    ep.SetError(txtForename, null);
            }
        }

        private void CheckSurname()
        {
            try
            {
                staff.Surname = txtSurname.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtSurname, ex.Message);
            }
            finally
            {
                if (staff.Surname == txtSurname.Text)
                    ep.SetError(txtSurname, null);
            }
        }

        private void CheckSex()
        {
            try
            {
                staff.Sex = cbSex.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbSex, ex.Message);
            }
            finally
            {
                if (staff.Sex == cbSex.Text)
                    ep.SetError(cbSex, null);
            }
        }

        private void CheckDOB()
        {
            try
            {
                staff.DateOfBirth = dtpDOB.Value;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDOB, ex.Message);
            }
            finally
            {
                if (staff.DateOfBirth == dtpDOB.Value)
                    ep.SetError(dtpDOB, null);
            }
        }

        private void CheckAddress()
        {
            try
            {
                staff.Address = txtAddress.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtAddress, ex.Message);
            }
            finally
            {
                if (staff.Address == txtAddress.Text)
                    ep.SetError(txtAddress, null);
            }
        }

        private void CheckCity()
        {
            try
            {
                staff.City = txtCity.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtCity, ex.Message);
            }
            finally
            {
                if (staff.City == txtCity.Text)
                    ep.SetError(txtCity, null);
            }
        }

        private void CheckPostcode()
        {
            try
            {
                staff.Postcode = txtPostcode.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtPostcode, ex.Message);
            }
            finally
            {
                if (staff.Postcode == txtPostcode.Text)
                    ep.SetError(txtPostcode, null);
            }
        }

        private void CheckEmail()
        {
            try
            {
                staff.Email = txtEmail.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtEmail, ex.Message);
            }
            finally
            {
                if (staff.Email == txtEmail.Text)
                    ep.SetError(txtEmail, null);
            }
        }

        private void CheckPhoneNo()
        {
            try
            {
                staff.PhoneNo = txtPhoneNo.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtPhoneNo, ex.Message);
            }
            finally
            {
                if (staff.PhoneNo == txtPhoneNo.Text)
                    ep.SetError(txtPhoneNo, null);
            }
        }

        private void CheckJobContract()
        {
            string jobContract = "";

            if (chbFullTime.Checked)
                jobContract = chbFullTime.Text;
            else if (chbPartTime.Checked)
                jobContract = chbPartTime.Text;

            try
            {
                staff.JobContract = jobContract;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(chbPartTime, ex.Message);
            }
            finally
            {
                if (staff.JobContract == jobContract)
                    ep.SetError(chbPartTime, null);
            }
        }

        private void CheckJobPosition()
        {
            try
            {
                staff.JobPosition = cbJobPosition.Text;
            }
            catch (CustomException ex)
            { 
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbJobPosition, ex.Message);
            }
            finally
            {
                if (staff.JobPosition == cbJobPosition.Text)
                    ep.SetError(cbJobPosition, null);
            }
        }

        private void CheckSalary()
        {
            try
            {
                staff.Salary = Convert.ToDouble(nupSalary.Value);
            }
            catch (Exception ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(nupSalary, ex.Message);
            }
            finally
            {
                if (staff.Salary == Convert.ToDouble(nupSalary.Value))
                    ep.SetError(nupSalary, null);
            }
        }

        private void CheckDateJoined()
        {
            try
            {
                staff.DateJoined = dtpDateJoined.Value;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDateJoined, ex.Message);
            }
            finally
            {
                if (staff.DateJoined == dtpDateJoined.Value)
                    ep.SetError(dtpDateJoined, null);
            }
        }
    }
}
