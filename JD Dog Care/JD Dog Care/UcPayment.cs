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
    public partial class UcPayment : UserControl
    {
        Payment payment = new Payment();

        public static string paymentNo = "0001";

        public UcPayment()
        {
            InitializeComponent();

            //Payment Screen can have 2 possible states to Search for payment details for an existing booking and another to view them where they can be updated.
            if (FrmJDDogCare.currentUserControl == "Search Booking")
            {
                foreach (Control control in this.Controls)
                    control.Hide();

                dgvBookings.Show();
                txtSearch.Show();
                btnSearch.Show();

                dgvBookings.DataSource = FrmJDDogCare.GetTable("Payment", "", "", true);
            }
            else if (FrmJDDogCare.currentUserControl == "View Payment")
            {
                DisplayPayment("PaymentNo", paymentNo);

                foreach (Control control in this.Controls)
                    control.Show();

                dgvBookings.Hide();
                txtSearch.Hide();
                btnSearch.Hide();
                //As 'cbPaymentType' loads empty then it will hide the 'Card Details' controls and relocate the 'Paid' controls.
                CbPaymentMethod_TextChanged(new object(), new EventArgs());
            }
        }

        private void BtnCreatePayment_Click(object sender, EventArgs e)
        {
            //Do a final check to see if the user input has been set to the Payment class object's properties.
            bool valid = payment.PaymentNo == txtPaymentNo.Text && payment.BookingNo == txtBookingNo.Text && payment.PaymentDate == dtpDate.Value &&
                payment.PaymentMethod == cbPaymentMethod.Text && payment.CardNumber == txtCardNumber.Text && payment.SecurityCode == txtSecurityCode.Text &&
                (payment.Paid == true || payment.Paid == false);

            //Card Number and Security Code both must be filled or none to be valid.
            if (!String.IsNullOrEmpty(txtCardNumber.Text) && String.IsNullOrEmpty(txtSecurityCode.Text))
            {
                valid = false;
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtSecurityCode, "To continue, please enter your security code.");
            }
            else if (String.IsNullOrEmpty(txtCardNumber.Text) && !String.IsNullOrEmpty(txtSecurityCode.Text))
            {
                valid = false;
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtCardNumber, "To continue, please enter your card number.");
            }

            if (valid)
            {
                FrmJDDogCare.UpdateRecord("Payment", new object[] { "PaymentNo", payment.PaymentNo, "BookingNo", payment.BookingNo, "PaymentDate", payment.PaymentDate,
                    "Cost", payment.Cost, "PaymentMethod", payment.PaymentMethod, "CardNumber", payment.CardNumber, "SecurityCode", payment.SecurityCode, "Paid", payment.Paid });

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
                CheckPaymentNo();
                CheckBookingNo();
                CheckDate();
                CheckPaymentType();
                CheckCardNumber();
                CheckSecurityCode();
                CheckPaid();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (FrmJDDogCare.GetNames("Client").Contains(txtSearch.Text))
            {
                string clientID = GetID("Client", txtSearch.Text);
                dgvBookings.DataSource = FrmJDDogCare.GetTable("Payment", "ClientID", clientID, true);
            }
        }

        private void DgvBookings_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure that the user has not double clicked the row header by mistake.
            if (e.RowIndex != -1)
            {
                string bookingNo = dgvBookings.Rows[e.RowIndex].Cells["BookingNo"].Value.ToString();

                UcToolBar.BtnViewPayment_Click(new object(), new EventArgs());

                DisplayPayment("BookingNo", bookingNo);
            }
        }

        //Method to get the id from a table using the client's full name given in txtSearch and 
        private string GetID(string tableName, string text, string dogName = "")
        {
            string forename = "", surname = "", ID = "";
            if (!String.IsNullOrEmpty(text) || !String.IsNullOrEmpty(dogName))
            {
                forename = text.Split(',', ' ')[2];
                surname = text.Split(',', ' ')[0];
                if (surname.Contains("'"))
                    surname = surname.Insert(surname.IndexOf('\''), "'");

                ID = FrmJDDogCare.FindID(tableName, forename, surname, dogName)[0];
            }

            return ID;
        }

        //Method to display the payment details of a the selected booking.
        private void DisplayPayment(string column, string value)
        {
            List<object> record = FrmJDDogCare.GetRecord("Payment", column, value, FrmJDDogCare.payment_columns);

            //If any of the values of the record are null then set to an empty string.
            for (int i = 0; i < record.Count; i++)
            {
                if (record[i] == System.DBNull.Value)
                {
                    if (i == 2)
                    {
                        dtpDate.CustomFormat = " ";
                        dtpDate.Format = DateTimePickerFormat.Custom;
                    }
                    if (i == 3)
                        record[i] = 0.00;
                    if (new int[] { 4, 5, 6 }.Contains(i))
                    {
                        record[i] = "";
                        CbPaymentMethod_TextChanged(new object(), new EventArgs());
                        TxtCardNumber_TextChanged(new object(), new EventArgs());
                        TxtSecurityCode_TextChanged(new object(), new EventArgs());
                    }
                }
            }

            //Record is only displayed on the user control when it is not empty.
            if (record.Count != 0)
            {
                txtPaymentNo.Text = (string)record[0];
                txtBookingNo.Text = (string)record[1];
                if (dtpDate.Format != DateTimePickerFormat.Custom)
                    dtpDate.Value = (DateTime)record[2];
                txtCost.Text = $"£{record[3]:0.00}";
                cbPaymentMethod.Text = (string)record[4];
                txtCardNumber.Text = (string)record[5];
                txtSecurityCode.Text = (string)record[6];
                if ((Boolean)record[7])
                    chbPaid.CheckState = CheckState.Checked;
                else
                    chbPaid.CheckState = CheckState.Unchecked;
            }
            else
                MessageBox.Show("There are no payment records to show.", "ALERT!");
        }

        //Validate user input as they enter values into the fields.
        private void TxtPaymentNo_TextChanged(object sender, EventArgs e)
        {
            CheckPaymentNo();
        }

        private void TxtBookingNo_TextChanged(object sender, EventArgs e)
        {
            CheckBookingNo();
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Short;
            CheckDate();
        }

        private void TxtCost_TextChanged(object sender, EventArgs e)
        {
            ep.SetError(txtCost, null);

            //The cost should be in the format: '£DD.DD' (D = Digit).
            Regex reg = new Regex(@"£([0-9]){1,}(\.[0-9]{1,2})?");
            if (!reg.IsMatch(txtCost.Text))
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtCost, "This value is not in the desired format (e.g. £0.00).");
            }
        }

        private void CbPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            CheckPaymentType();

            string[] cards = new string[] { "Debit Card", "Credit Card" };
            Control[] cardControls = new Control[] { lblCardNumber, txtCardNumber, lblSecurityCode, txtSecurityCode };

            //If the user selects 'Debit Card' or 'Credit Card' then they must enter the card details. The 'Paid' controls must be relocated as a result.
            if (cards.Contains(cbPaymentMethod.Text))
            {
                foreach (Control c in cardControls)
                    c.Show();

                chbPaid.Location = new Point(chbPaid.Location.X, 389);
            }
            else
            {
                foreach (Control c in cardControls)
                    c.Hide();

                chbPaid.Location = new Point(chbPaid.Location.X, 305);
            }
        }

        private void TxtCardNumber_TextChanged(object sender, EventArgs e)
        {
            CheckCardNumber();
        }

        private void TxtSecurityCode_TextChanged(object sender, EventArgs e)
        {
            CheckSecurityCode();
        }

        private void ChbPaid_CheckStateChanged(object sender, EventArgs e)
        {
            CheckPaid();
        }

        //Check and Validate User input (Methods)
        private void CheckPaymentNo()
        {
            try
            {
                payment.PaymentNo = txtPaymentNo.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtPaymentNo, ex.Message);
            }
            finally
            {
                if (payment.PaymentNo == txtPaymentNo.Text)
                    ep.SetError(txtPaymentNo, null);
            }
        }

        private void CheckBookingNo()
        {
            try
            {
                payment.BookingNo = txtBookingNo.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtBookingNo, ex.Message);
            }
            finally
            {
                if (payment.BookingNo == txtBookingNo.Text)
                    ep.SetError(txtBookingNo, null);
            }
        }

        private void CheckDate()
        {
            try
            {
                payment.PaymentDate = dtpDate.Value;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(dtpDate, ex.Message);
            }
            finally
            {
                if (payment.PaymentDate == dtpDate.Value)
                    ep.SetError(dtpDate, null);
            }
        }

        //private void CheckCost()
        //{
        //    try
        //    {
        //        payment.Cost = txtCost.Text;
        //    }
        //    catch (CustomException ex)
        //    {
        //        ep.Icon = Properties.Resources.Error;
        //        ep.SetError(txtCost, ex.Message);
        //    }
        //    finally
        //    {
        //        if (payment.Cost == txtCost.Text)
        //            ep.SetError(txtCost, null);
        //    }
        //}

        private void CheckPaymentType()
        {
            try
            {
                payment.PaymentMethod = cbPaymentMethod.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(cbPaymentMethod, ex.Message);
            }
            finally
            {
                if (payment.PaymentMethod == cbPaymentMethod.Text)
                    ep.SetError(cbPaymentMethod, null);
            }
        }

        private void CheckCardNumber()
        {
            try
            {
                payment.CardNumber = txtCardNumber.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtCardNumber, ex.Message);
            }
            finally
            {
                if (payment.CardNumber == txtCardNumber.Text)
                    ep.SetError(txtCardNumber, null);
            }
        }

        private void CheckSecurityCode()
        {
            try
            {
                payment.SecurityCode = txtSecurityCode.Text;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(txtSecurityCode, ex.Message);
            }
            finally
            {
                if (payment.SecurityCode == txtSecurityCode.Text)
                    ep.SetError(txtSecurityCode, null);
            }
        }

        private void CheckPaid()
        {
            bool paid = false;
            if (chbPaid.Checked)
                paid = true;

            try
            {
                payment.Paid = paid;
            }
            catch (CustomException ex)
            {
                ep.Icon = Properties.Resources.Error;
                ep.SetError(chbPaid, ex.Message);
            }
            finally
            {
                if (payment.Paid == paid)
                    ep.SetError(chbPaid, null);
            }
        }
    }
}
