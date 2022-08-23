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
    public partial class UcBooking : UserControl
    {
        Booking booking = new Booking();

        //String variable to store the next Booking No for a new registered client.
        string newBookingNo;

        public UcBooking()
        {
            InitializeComponent();
            
            newBookingNo = FrmJDDogCare.NewID("Booking", "BookingNo");

            //Loop to add dog names to cbDogName.
            foreach (string name in FrmJDDogCare.GetNames("Dog"))
            {
                //Don't add the dog name if it is a duplicate.
                if (!cbDogName.Items.Contains(name.Split(' ')[0]))
                    cbDogName.Items.Add(name.Split(' ')[0]);
            }

            //Loop to add available service options to cbServiceOptions.
            foreach (string option in FrmJDDogCare.GetNames("Options"))
                cbServiceOptionNo.Items.Add(option);

            //Loop to add staff member's names to cbStaffName.
            foreach (string name in FrmJDDogCare.GetNames("Staff"))
            {
                string staffName = $"{name.Split(' ')[0]} {name.Split(' ')[1]}";
                cbStaffName.Items.Add(staffName);
            }

            //Fill the auto complete search box with all dog name and their client names in the booking table.
            txtSearch.AutoCompleteCustomSource = FrmJDDogCare.GetNames("Booking");

            //Booking Screen can have 2 possible states to create a booking or update an existing booking.
            if (FrmJDDogCare.currentUserControl == "Create Booking")
            {
                //Change btnBooking to a Create Booking button.
                btnBooking.Text = "Create Booking";

                //Change colours of background of the user control and all labels.
                this.BackColor = Color.FromArgb(116, 77, 37);
                foreach (Control control in this.Controls)
                { 
                    control.Show();
                    if (control is Label)
                        control.BackColor = this.BackColor;
                }

                //Hide unwanted controls for registering.
                txtSearch.Dispose();
                btnSearch.Dispose();
                dgvBookings.Dispose();
                lblDateCreated.Hide();
                dtpDateCreated.Hide();
                btnBack.Dispose();
                btnDelete.Dispose();

                //Set the Read Only BookingNo text field to the new booking number.
                txtBookingNo.Text = newBookingNo;
                //Set the date of creation of the booking to the current date.
                dtpDateCreated.Value = DateTime.Now;
            }
            else if (FrmJDDogCare.currentUserControl == "Update Booking")
            {
                //Change btnBooking to an Update button.
                btnBooking.Text = "Update Booking";

                //Change colours of background of the user control and all labels.
                this.BackColor = Color.FromArgb(61, 92, 92);
                foreach (Control control in this.Controls)
                {
                    control.Hide();
                    if (control is Label)
                        control.BackColor = this.BackColor;
                }

                //Only show search controls and data grid view table.
                txtSearch.Show();
                btnSearch.Show();
                dgvBookings.DataSource = FrmJDDogCare.GetTable("Booking", "", "", true);
                dgvBookings.Show();
            }
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            //Do a final check to see if the user input has been set to the Client class object's properties.
            bool valid = booking.BookingNo == txtBookingNo.Text && booking.DogID == GetID("Dog", cbClientName.Text, cbDogName.Text) && 
                booking.Date == dtpDate.Value && booking.StartTime == dtpStartTime.Value.TimeOfDay && booking.ServiceOptionNo == cbServiceOptionNo.Text &&
                booking.StaffID == GetID("Staff", cbStaffName.Text);

            if (valid)
            {
                if (btnBooking.Text == "Create Booking")
                {
                    FrmJDDogCare.RegisterRecord("Booking", new object[] { "BookingNo", booking.BookingNo, "DogID", booking.DogID, "AppointmentDate", booking.Date,
                        "StartTime", booking.StartTime, "ServiceOption", booking.ServiceOptionNo, "ExtraOption", booking.ExtraOption, "StaffID", booking.StaffID, "DateCreated", booking.DateCreated });

                    //Automatically create an empty payment record for the new booking.
                    string paymentNo = FrmJDDogCare.NewID("Payment", "PaymentNo");
                    FrmJDDogCare.RegisterRecord("Payment", new object[] { "PaymentNo", paymentNo, "BookingNo", booking.BookingNo, "PaymentDate", System.DBNull.Value,
                        "AmountDue", System.DBNull.Value, "PaymentMethod", System.DBNull.Value, "CardNumber", System.DBNull.Value, "SecurityCode", System.DBNull.Value, "Paid", false });

                    MessageBox.Show($"Booking '{txtBookingNo.Text}' has been successfully created.", "BOOKING CREATED SUCCESSFULLY");

                    UcPayment.paymentNo = FrmJDDogCare.FindID("Payment", "", "", "", "", "BookingNo", txtBookingNo.Text)[0];
                    FrmJDDogCare.BtnPayment_Click(new object(), new EventArgs());
                    UcToolBar.BtnViewPayment_Click(new object(), new EventArgs());
                }
                else if (btnBooking.Text == "Update Booking")
                {
                    FrmJDDogCare.UpdateRecord("Booking", new object[] { "BookingNo", booking.BookingNo, "DogID", booking.DogID, "AppointmentDate", booking.Date,
                        "StartTime", booking.StartTime, "ServiceOption", booking.ServiceOptionNo, "ExtraOption", booking.ExtraOption, "StaffID", booking.StaffID, "DateCreated", booking.DateCreated });

                    MessageBox.Show($"Booking '{txtBookingNo.Text}' has been successfully updated.", "UPDATED SUCCESSFULLY");
                }

                //Place tick icons on all the fields.
                ep.Icon = Properties.Resources.Tick;
                foreach (Control control in this.Controls)
                {
                    if (!(control is Button) && !(control is Label))
                        ep.SetError(control, "Valid");
                }
            }
            else
            {
                //If not valid then place error providers where necessary.
                CheckBookingNo();
                CheckDogID(GetID("Dog", cbClientName.Text, cbDogName.Text));
                CheckDate();
                CheckStartTime();
                CheckServiceOptionNo();
                CheckExtraOption();
                CheckStaffID(GetID("Staff", cbStaffName.Text));
                CheckDateCreated();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (FrmJDDogCare.GetNames("Client").Contains(txtSearch.Text))
            { 
                string clientID = GetID("Client", txtSearch.Text);
                dgvBookings.DataSource = FrmJDDogCare.GetTable("Booking", "ClientID", clientID, true);
            }
        }

        private void DgvBookings_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure that the user has not double clicked the row header by mistake.
            if (e.RowIndex != -1)
            {
                string bookingNo = dgvBookings.Rows[e.RowIndex].Cells["BookingNo"].Value.ToString();

                foreach (Control control in this.Controls)
                    control.Show();

                txtSearch.Hide();
                btnSearch.Hide();
                dgvBookings.Hide();
                btnDelete.Show();

                DisplayBooking("BookingNo", bookingNo);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.DeleteRecord("Booking", txtBookingNo.Text);
            MessageBox.Show($"Booking {txtBookingNo.Text} has been successfully deleted.", "DELETED SUCCESSFULLY");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UcToolBar.BtnUpdateBooking_Click(new object(), new EventArgs());
        }

        //Method to get the id from a table using cbDogName and cbClientName and set error to cbClientName if none is selected.
        private string GetID(string tableName, string text, string dogName = "")
        {
            string forename = "" , surname = "", ID = "";
            if (!String.IsNullOrEmpty(text) || !String.IsNullOrEmpty(dogName))
            {
                forename = text.Split(',', ' ')[2];
                surname = text.Split(',', ' ')[0];
                if (surname.Contains("'"))
                    surname = surname.Insert(surname.IndexOf('\''), "'");

                ID = FrmJDDogCare.FindID(tableName, forename, surname, dogName)[0];

                ep.SetError(cbClientName, null);
                ep.SetError(cbStaffName, null);
            }
            else
            {
                if (tableName == "Client")
                    ep.SetError(cbClientName, "Please select a client.");
            }
            

            return ID;
        }

        //Method to display selected booking for editing/updating.
        private void DisplayBooking(string column, string value)
        {
            List<object> record = FrmJDDogCare.GetRecord("Booking", column, value, FrmJDDogCare.booking_columns);

            //Record is only displayed on the user control when it is not empty.
            if (record.Count != 0)
            {
                txtBookingNo.Text = (string)record[0];
                cbDogName.Text = (string)record[1];
                cbClientName.Text = $"{(string)record[2]}, {(string)record[3]}";
                dtpDate.Value = (DateTime)record[4];
                dtpStartTime.Value = (dtpDate.Value + (TimeSpan)record[5]);
                if ((Boolean)record[7])
                    chbExtraOption.CheckState = CheckState.Checked;
                else
                    chbExtraOption.CheckState = CheckState.Unchecked;
                cbServiceOptionNo.Text = (string)record[6];
                cbStaffName.Text = $"{(string)record[10]}, {(string)record[11]}";
                dtpDateCreated.Value = (DateTime)record[12];
            }
            else
                MessageBox.Show("There are no booking records to show.", "ALERT!");
        }

        //Validate user input as they enter values into the fields.
        private void TxtBookingNo_TextChanged(object sender, EventArgs e)
        {
            CheckBookingNo();
        }

        private void CbDogName_TextChanged(object sender, EventArgs e)
        {
            //Clear and then fill the combo box ClientName with client name/s from the dog provided.
            cbClientName.Items.Clear();

            foreach (string names in FrmJDDogCare.GetNames("Dog"))
            {
                if (names.Contains(cbDogName.Text))
                {
                    string clientNames = $"{names.Split(' ')[2]} {names.Split(' ')[3]}";
                    cbClientName.Items.Add(clientNames);
                }
            }
        }

        private void CbClientName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbDogName.Text) && !String.IsNullOrEmpty(cbClientName.Text))
            {
                //Find the DogID using the client forename, surname and their dog name and then check if it is valid.
                CheckDogID(GetID("Dog", cbClientName.Text, cbDogName.Text));
            }
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            CheckDate();

            //When booking a new appointment, the user should not be able to set the date to a past date.
            if (btnBooking.Text == "Create Booking" && dtpDate.Value.Date < DateTime.Today)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDate, "This date is invalid. Choose a date in the future.");
            }
        }

        private void DtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            CheckStartTime();

            //When booking a new appointment, the user should not be able to set the start time to an earlier time if they have selected today's date.
            if (btnBooking.Text == "Create Booking" && 
                dtpDate.Value.Date == DateTime.Today && (dtpDate.Value.Date + dtpStartTime.Value.TimeOfDay) < DateTime.Now)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpStartTime, "Choose a time in the future.");
            }
        }

        private void CbServiceOptionNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbServiceOptionNo.Text))
            { 
                List<object> record = FrmJDDogCare.GetRecord("Options", "ServiceOptionNo", cbServiceOptionNo.Text, new string[] { "Duration", "Price" });
                //Duration should be in the format 'hh:mm'.
                TimeSpan duration = (TimeSpan)record[0];
                txtDuration.Text = duration.ToString(@"hh\:mm");
                //Price should be shown to two decimal places.
                txtPrice.Text = $"£{record[1]:0.00}";

                ChbExtraOption_CheckStateChanged(new object(), new EventArgs());
            }

            CheckServiceOptionNo();
        }

        private void ChbExtraOption_CheckStateChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDuration.Text) && !String.IsNullOrEmpty(txtPrice.Text))
            {
                TimeSpan duration = TimeSpan.Parse(txtDuration.Text);
                double price = Convert.ToDouble((txtPrice.Text).Split('£')[1]);

                //Add extra duration and price for the extra option if it is checked.
                if (chbExtraOption.Checked)
                {
                    txtDuration.Text = duration.Add(TimeSpan.Parse("0:15")).ToString(@"hh\:mm");
                    txtPrice.Text = $"£{(price + 10):0.00}";
                }
                else
                {
                    List<object> record = FrmJDDogCare.GetRecord("Options", "ServiceOptionNo", cbServiceOptionNo.Text, new string[] { "Duration", "Price" });
                    //Duration should be in the format 'hh:mm'.
                    duration = (TimeSpan)record[0];
                    txtDuration.Text = duration.ToString(@"hh\:mm"); 
                    //Price should be shown to two decimal places.
                    txtPrice.Text = $"£{record[1]:0.00}";
                }
            }

            CheckExtraOption();
        }

        private void CbStaffName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbStaffName.Text))
                CheckStaffID(GetID("Staff", cbStaffName.Text));
        }

        private void DtpDateCreated_ValueChanged(object sender, EventArgs e)
        {
            CheckDateCreated();
        }

        //Check and Validate User input (Methods).
        private void CheckBookingNo()
        {
            try
            {
                booking.BookingNo = txtBookingNo.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtBookingNo, ex.Message);
            }
            finally
            {
                if (booking.BookingNo == txtBookingNo.Text)
                    ep.SetError(txtBookingNo, null);
            }
        }

        private void CheckDogID(string dogID)
        {
            try
            {
                booking.DogID = dogID;
            }
            catch (CustomException)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbDogName, "This dog name is invalid.");
            }
            finally
            {
                if (booking.DogID == dogID)
                    ep.SetError(cbDogName, null);
            }
        }

        private void CheckDate()
        {
            try
            {
                booking.Date = dtpDate.Value;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDate, ex.Message);
            }
            finally
            {
                if (booking.Date == dtpDate.Value)
                    ep.SetError(dtpDate, null);
            }
        }

        private void CheckStartTime()
        {
            try
            {
                booking.StartTime = dtpStartTime.Value.TimeOfDay;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpStartTime, ex.Message);
            }
            finally
            {
                //booking.StarTime's default value is '00:00:00' and this is invalid.
                if (booking.StartTime == dtpStartTime.Value.TimeOfDay && dtpStartTime.Value.TimeOfDay != TimeSpan.Parse("00:00:00"))
                    ep.SetError(dtpStartTime, null);
            }
        }

        private void CheckServiceOptionNo()
        {
            try
            {
                booking.ServiceOptionNo = cbServiceOptionNo.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbServiceOptionNo, ex.Message);
            }
            finally
            {
                if (booking.ServiceOptionNo == cbServiceOptionNo.Text)
                    ep.SetError(cbServiceOptionNo, null);
            }
        }

        private void CheckExtraOption()
        {
            bool extraOption = false;
            if (chbExtraOption.Checked)
                extraOption = true;

            try
            {
                booking.ExtraOption = extraOption;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(chbExtraOption, ex.Message);
            }
            finally
            {
                if (booking.ExtraOption == extraOption)
                    ep.SetError(chbExtraOption, null);
            }
        }

        private void CheckStaffID(string staffID)
        {
            try
            {
                booking.StaffID = staffID;
            }
            catch (CustomException)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbStaffName, "This staff name is not found in the database.");
            }
            finally
            {
                if (booking.StaffID == staffID)
                    ep.SetError(cbStaffName, null);
            }
        }

        private void CheckDateCreated()
        {
            try
            {
                booking.DateCreated = dtpDateCreated.Value;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDateCreated, ex.Message);
            }
            finally
            {
                if (booking.DateCreated == dtpDateCreated.Value)
                    ep.SetError(dtpDateCreated, null);
            }
        }
    }
}
