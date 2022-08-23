using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace JD_Dog_Care
{
    public partial class FrmJDDogCare : Form
    {
        //SQL variables
        public static SqlDataAdapter sda;
        public static DataSet dsJDDogCare;
        public static DataRow dr;
        public static DataTable dt;
        public static SqlCommandBuilder cmd;
        public static string cnstr, sql;

        //String variable keeping track of current user control.
        public static string currentUserControl;

        //String arrays to hold column names for all tables in the database.
        public static string[] client_columns, dog_columns, staff_columns, option_columns, booking_columns, payment_columns;

        public FrmJDDogCare()
        {
            InitializeComponent();

            dsJDDogCare = new DataSet();
            ConnectionString connectionString = new ConnectionString();
            cnstr = connectionString.MyConnection;

            //Instantiate column name arrays for all tables.
            client_columns = new string[] { "ClientID", "Forename", "Surname", "Sex", "DateOfBirth", "HomeAddress", "City", "Postcode", "Email",
                "PhoneNo", "DateJoined" };

            dog_columns = new string[] { "DogID", "ClientID", "DogName", "Breed", "Sex", "DateOfBirth", "MedicalNotes" };

            staff_columns = new string[] { "StaffID", "Forename", "Surname", "Sex", "DateOfBirth", "HomeAddress", "City", "Postcode", "Email",
                "PhoneNo", "JobContract", "JobPosition", "Salary", "DateJoined" };

            option_columns = new string[] { "ServiceOptionNo", "ServiceOptionDescription", "Duration", "Price" };

            booking_columns = new string[] { "BookingNo", "DogID", "AppointmentDate", "StartTime", "ServiceOptionNo", "ExtraOption", "Duration", "Price", "StaffID",
                "DateCreated" };

            payment_columns = new string[] { "PaymentNo", "BookingNo", "PaymentDate", "AmountDue", "PaymentMethod", "CardNumber", "SecurityCode", "Paid" };

            UcHome Home = new UcHome();
            Home.Location = new Point(240, 40);
            this.Controls.Add(Home);
        }

        public static void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderColor = Color.Red;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(0, 13, 26);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 13, 26);
        }

        public static void BtnMinimise_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        public static void BtnHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Home";
            pButtons.Top = btnHome.Top;

            RemoveAllUserControls();

            UcHome Home = new UcHome();
            Home.Location = new Point(240, 40);
            ActiveForm.Controls.Add(Home);
        }

        public static void BtnRegister_Click(object sender, EventArgs e)
        {
            currentUserControl = "Register";
            lblTitle.Text = currentUserControl;
            pButtons.Top = btnRegister.Top;

            RemoveAllUserControls();

            AddClientUserControl();
        }

        public static void BtnUpdate_Click(object sender, EventArgs e)
        {
            currentUserControl = "Update";
            lblTitle.Text = currentUserControl;
            pButtons.Top = btnUpdate.Top;

            RemoveAllUserControls();

            AddClientUserControl();
        }

        public static void BtnBooking_Click(object sender, EventArgs e)
        {
            currentUserControl = "Booking";
            lblTitle.Text = currentUserControl;
            pButtons.Top = btnBooking.Top;

            RemoveAllUserControls();

            UserControl ToolBar = new UcToolBar();
            ToolBar.Location = new Point(240, 40);
            ActiveForm.Controls.Add(ToolBar);

            UcToolBar.btnCreateBooking.Left -= 318;
            UcToolBar.btnUpdateBooking.Left -= 318;

            UcToolBar.BtnCreateBooking_Click(new object(), new EventArgs());
        }

        public static void BtnPayment_Click(object sender, EventArgs e)
        {
            currentUserControl = "Payment";
            lblTitle.Text = currentUserControl;
            pButtons.Top = btnPayment.Top;

            RemoveAllUserControls();

            UserControl ToolBar = new UcToolBar();
            ToolBar.Location = new Point(240, 40);
            ActiveForm.Controls.Add(ToolBar);

            UcToolBar.btnSearchBooking.Left -= 600;
            UcToolBar.btnViewPayment.Left -= 600;

            UcToolBar.BtnSearchBooking_Click(new object(), new EventArgs());
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            currentUserControl = "Reports";
            lblTitle.Text = currentUserControl;
            pButtons.Top = btnReport.Top;

            RemoveAllUserControls();

            AddClientUserControl();
        }

        //METHODS
        //-Removes all user controls present on the form.
        public static void RemoveAllUserControls()
        {
            foreach (Control userControl in ActiveForm.Controls.OfType<UserControl>().ToArray())
                ActiveForm.Controls.Remove(userControl);
        }

        //-The Client User Control will act as the default (first) interaction for most main menu button clicks.
        public static void AddClientUserControl()
        {
            //Adds tool bar and runs the Client Click Event of the Tool Bar.
            UserControl ToolBar = new UcToolBar();
            ToolBar.Location = new Point(240, 40);
            ActiveForm.Controls.Add(ToolBar);

            UcToolBar.BtnClient_Click(new object(), new EventArgs());
        }

        //-Returns all relevant names for each record in a table to add to an auto complete text field.
        public static AutoCompleteStringCollection GetNames(string tableName)
        {
            AutoCompleteStringCollection auto_names = new AutoCompleteStringCollection();

            //Dog is a special case as multiple dogs can have the same name but different owners.
            if (tableName == "Dog")
            {
                sql = $@"SELECT D.DogName, C.Surname, C.Forename FROM Dog D JOIN Client C ON D.ClientID = C.ClientID";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    //String Format: 'Dog_Name - Client_Surname, Client_Forename'
                    auto_names.Add($"{dr[0]} - {dr[1]}, {dr[2]}");
                }
            }
            else if (tableName == "Options")
            {
                sql = $@"SELECT ServiceOptionNo FROM Options";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                    auto_names.Add($"{dr[0]}");
            }
            //Booking does not include client names so multiple tables have to be joined to obtain them.
            else if (tableName == "Booking")
            {
                sql = $@"SELECT C.Surname, C.Forename FROM Booking B JOIN Dog D ON B.DogID = D.DogID JOIN Client C ON D.ClientID = C.ClientID";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                    auto_names.Add($"{dr["Surname"]}, {dr["Forename"]}");
            }
            else if (tableName == "Staff")
            {
                sql = $@"SELECT Surname, Forename FROM Staff WHERE JobPosition = 'Grooming'";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                    auto_names.Add($"{dr["Surname"]}, {dr["Forename"]}");
            }
            else
            {
                sql = $@"SELECT * FROM {tableName}";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                    auto_names.Add($"{dr[2]}, {dr[1]}");
            }

            return auto_names;
        }

        //-Formats and returns the new ID to string form for passing into GetRecord() method.
        public static string FormatID(string id)
        {
            while (id.Length < 4)
            {
                id = id.Insert(0, "0");
            }

            return id;
        }

        //-Finds and returns the corresponding ID depending on the table and relevant information passed through.
        public static List<string> FindID(string tableName, string forename = "", string surname = "", string dogName = "", string clientID = "", string columnName = "", string value = "")
        {
            if (!String.IsNullOrEmpty(columnName) && !String.IsNullOrEmpty(value))
            {
                sql = $@"SELECT * FROM {tableName} WHERE {columnName} = '{value}'";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);
            }

            List<string> id = new List<string>();

            if (tableName == "Client")
            {
                if (!String.IsNullOrEmpty(dogName))
                    sql = $@"SELECT C.ClientID FROM Client C JOIN Dog D ON C.ClientID = D.ClientID 
                             WHERE C.Forename = '{forename}' AND C.Surname = '{surname}' AND D.DogName = '{dogName}'";
                else 
                    sql = $@"SELECT ClientID FROM Client WHERE Forename = '{forename}' AND Surname = '{surname}'";

                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else if (tableName == "Dog")
            {
                //If the ClientID is not passed in then use the dog's name, client forename and surname to find the DogID.
                if (String.IsNullOrEmpty(clientID))
                    sql = $@"SELECT D.DogID FROM Dog D JOIN Client C ON D.ClientID = C.ClientID 
                            WHERE D.DogName = '{dogName}' AND C.Forename = '{forename}' AND C.Surname = '{surname}'";
                else
                    sql = $@"SELECT DogID FROM Dog WHERE ClientID = '{clientID}'";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else if (tableName == "Staff")
            {
                sql = $@"SELECT StaffID FROM Staff WHERE Forename = '{forename}' AND Surname = '{surname}'";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else if (tableName == "Booking")
            {
                sql = $@"SELECT BookingNo FROM Booking B JOIN Dog D ON B.DogID = D.DogID JOIN Client C ON D.ClientID = C.ClientID
                        WHERE C.Forename = '{forename}' AND C.Surname = '{surname}'";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);
            }

            foreach (DataRow dr in dt.Rows)
                id.Add(dr[0].ToString());

            return id;
        }


        //-Finds and returns the corresponding record depending on the table and relevant information passed through.
        public static List<object> GetRecord(string tableName, string columnName, string value, string[] columnNames)
        {
            sql = $@"SELECT * FROM {tableName} WHERE {columnName} = '{value}'";
            sda = new SqlDataAdapter(sql, cnstr);
            cmd = new SqlCommandBuilder(sda);
            dt = new DataTable();
            sda.Fill(dt);

            List<object> record = new List<object>();

            foreach (DataRow dr in dt.Rows)
            { 
                for (int i = 0; i < columnNames.Length; i++)
                {
                    if (tableName == "Booking")
                    {
                        //The Dog and Client Name must be returned instead of the DogID.
                        if (columnNames[i] == "DogID")
                        {
                            sql = $@"SELECT D.DogName, C.Surname, C.Forename FROM Client C JOIN Dog D ON C.ClientID = D.ClientID 
                                     JOIN Booking B ON D.DogID = B.DogID WHERE B.BookingNo = '{value}'";
                            sda = new SqlDataAdapter(sql, cnstr);
                            cmd = new SqlCommandBuilder(sda);
                            dt = new DataTable();
                            sda.Fill(dt);

                            foreach (DataRow r in dt.Rows)
                            {
                                foreach (DataColumn c in dt.Columns)
                                    record.Add(r[c]);
                            }
                        }
                        //The Duration and Price from the Options table must be joined to be displayed.
                        else if (columnNames[i] == "Duration")
                        {
                            sql = $@"SELECT O.Duration, O.Price FROM Options O JOIN Booking B ON O.ServiceOptionNo = B.ServiceOptionNo WHERE B.BookingNo = '{value}'";
                            sda = new SqlDataAdapter(sql, cnstr);
                            cmd = new SqlCommandBuilder(sda);
                            dt = new DataTable();
                            sda.Fill(dt);

                            foreach (DataRow r in dt.Rows)
                            {
                                foreach (DataColumn c in dt.Columns)
                                    record.Add(r[c]);
                            }
                        }
                        else if (columnNames[i] == "Price")
                            continue;
                        //The Staff member's full name must be displayed instead of the StaffID.
                        else if (columnNames[i] == "StaffID")
                        {
                            sql = $@"SELECT S.Surname, S.Forename FROM Staff S JOIN Booking B ON S.StaffID = B.StaffID WHERE B.BookingNo = '{value}'";
                            sda = new SqlDataAdapter(sql, cnstr);
                            cmd = new SqlCommandBuilder(sda);
                            dt = new DataTable();
                            sda.Fill(dt);

                            foreach (DataRow r in dt.Rows)
                            {
                                foreach (DataColumn c in dt.Columns)
                                    record.Add(r[c]);
                            }
                        }
                        else
                            record.Add(dr[columnNames[i]]);
                    }
                    else
                        record.Add(dr[columnNames[i]]);
                }
            }

            //For the Dog Form DisplayRecord() method, the combo box cbClientName must display the owner's full name in the format "Surname, Forename".
            if (tableName == "Dog")
            {
                sql = $@"SELECT C.Surname, C.Forename FROM Client C JOIN Dog D ON C.ClientID = D.ClientID WHERE D.DogID = '{value}'";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow r in dt.Rows)
                    record.Insert(2, $"{r[0]}, {r[1]}");
            }

            return record;
        }

        //-Finds and returns an array containing the first ID present in a table and the next available ID.
        public static string FirstID(string tableName)
        {
            sql = $@"SELECT * FROM {tableName};";
            sda = new SqlDataAdapter(sql, cnstr);
            cmd = new SqlCommandBuilder(sda);
            dt = new DataTable();
            sda.Fill(dt);

            //Set the default firstID to '0001' if there are no records present.
            string firstID = "0001";

            if (dt.Rows.Count != 0)
                firstID = dt.Rows[0][0].ToString();

            return firstID;
        }

        public static string NewID(string tableName, string idName)
        {
            sql = $@"SELECT {idName} FROM {tableName} ORDER BY {idName} DESC";
            sda = new SqlDataAdapter(sql, cnstr);
            cmd = new SqlCommandBuilder(sda);
            dt = new DataTable();
            sda.Fill(dt);

            string newID;
            if (tableName != "Options")
            {
                 newID = "0001";

                if (dt.Rows.Count != 0)
                    newID = FormatID(((Convert.ToInt32(dt.Rows[0][0]) + 1).ToString()));
            }
            else
            {
                newID = "Option 1";

                if (dt.Rows.Count != 0)
                    newID = $"Option {Convert.ToInt32(dt.Rows[0][0].ToString().Split(' ')[1]) + 1}";
            }

            return newID;
        }

        public static List<string> AvailableIDs(string tableName, string idName)
        {
            sql = $@"SELECT {idName} FROM {tableName}";
            sda = new SqlDataAdapter(sql, cnstr);
            cmd = new SqlCommandBuilder(sda);
            dt = new DataTable();
            sda.Fill(dt);

            List<string> availableIDs = new List<string>();

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    availableIDs.Add((string)dr[0]);
                }
            }

            return availableIDs;
        }

        //-Finds and returns a table in the database.
        public static DataTable GetTable(string tableName, string columnName = "", string value = "", bool join = false)
        {
            sql = $@"SELECT * FROM {tableName}";
            if (!String.IsNullOrEmpty(columnName) && !String.IsNullOrEmpty(value))
            {
                if (tableName == "DogVaccinationHistory" && join)
                    sql = $@"SELECT VaccinationName, VaccinationDate FROM {tableName} WHERE {columnName} = '{value}'";
                //Booking is a special case as (if 'join' is true) the table returned will contain bookings owned by the same client.
                else if (tableName == "Booking" && join)
                     sql = $@"SELECT B.BookingNo, B.DogID, D.DogName, C.Surname, C.Forename, B.AppointmentDate, B.StartTime, B.ServiceOptionNo, B.ExtraOption, B.DateCreated
                              FROM Booking B JOIN Dog D ON B.DogID = D.DogID JOIN Client C ON D.ClientID = C.ClientID WHERE C.ClientID = '{value}'";
                else if (tableName == "Payment" && join)
                    sql = $@"SELECT P.PaymentNo, B.BookingNo, B.DogID, D.DogName, C.Surname, C.Forename, B.AppointmentDate, B.StartTime, B.ServiceOptionNo, B.ExtraOption, B.DateCreated, P.Paid
                         FROM Payment P JOIN Booking B ON P.BookingNo = B.BookingNo JOIN Dog D ON B.DogID = D.DogID JOIN Client C ON D.ClientID = C.ClientID WHERE C.ClientID = '{value}'";
                else
                    sql += $@" WHERE {columnName} = '{value}';";
            }

            if (tableName == "Booking" && String.IsNullOrEmpty(value) && join)
                sql = $@"SELECT B.BookingNo, B.DogID, D.DogName, C.Surname, C.Forename, B.AppointmentDate, B.StartTime, B.ServiceOptionNo, B.ExtraOption, B.DateCreated
                         FROM Booking B JOIN Dog D ON B.DogID = D.DogID JOIN Client C ON D.ClientID = C.ClientID";
            if (tableName == "Payment" && String.IsNullOrEmpty(value) && join)
                sql = $@"SELECT P.PaymentNo, B.BookingNo, B.DogID, D.DogName, C.Surname, C.Forename, B.AppointmentDate, B.StartTime, B.ServiceOptionNo, B.ExtraOption, B.DateCreated, P.Paid
                         FROM Payment P JOIN Booking B ON P.BookingNo = B.BookingNo JOIN Dog D ON B.DogID = D.DogID JOIN Client C ON D.ClientID = C.ClientID";


            sda = new SqlDataAdapter(sql, cnstr);
            cmd = new SqlCommandBuilder(sda);
            dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        //-Registers a new record to the selected table.
        public static void RegisterRecord(string tableName, object[] newRecord)
        {
            if (tableName != "Dog_Vaccination")
            { 
                sql = $@"SELECT * FROM {tableName};";
                sda = new SqlDataAdapter(sql, cnstr);
                cmd = new SqlCommandBuilder(sda);
                sda.FillSchema(dsJDDogCare, SchemaType.Source, tableName);
                sda.Fill(dsJDDogCare, tableName);

                dr = dsJDDogCare.Tables[tableName].NewRow();

                //List newRecord is arranged as [ 'ColumnName_1', 'Value_1', 'ColumnName_2', 'Value_2' etc... ].
                //Even indexes are column names (2*i) and odd indexes are the values stored under each column (2*i + 1).
                for (int i = 0; i <= (newRecord.Length - 1) / 2; i++)
                {
                    dr[(string)newRecord[2 * i]] = newRecord[2 * i + 1];
                }

                dsJDDogCare.Tables[tableName].Rows.Add(dr);
                sda.Update(dsJDDogCare, tableName);

                //Display Message Box to confirm registration.
                if (new string[] { "Client", "Staff", "Dog" }.Contains(tableName))
                {
                    if (tableName == "Dog")
                        MessageBox.Show($"{tableName} '{newRecord[1]}' {newRecord[5].ToString().ToUpper()} has been successfully added.", "REGISTERED SUCCESSFULLY");
                    else
                        MessageBox.Show($"{tableName} '{newRecord[1]}' {newRecord[3].ToString().ToUpper()} {newRecord[5].ToString().ToUpper()} has been successfully added.", "REGISTERED SUCCESSFULLY");
                }
            }
            //Dog_Vaccination is a special case.
            else
            {
                sql = $"INSERT INTO {tableName} VALUES('{newRecord[0]}', '{newRecord[1]}', NULL)";
                SqlConnection connection = new SqlConnection(cnstr);
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                    command.ExecuteNonQuery();
            }
        }

        //-Updates an existing record in the selected table.
        public static void UpdateRecord(string tableName, object[] record)
        {
            sql = $@"UPDATE {tableName} SET ";
            //List record is arranged as [ 'ColumnName_1', 'Value_1', 'ColumnName_2', 'Value_2' etc... ].
            //Even indexes are column names (2*i) and odd indexes are the values stored under each column (2*i + 1).
            for (int i = 1; i <= (record.Length - 1) / 2; i++)
            {
                //Every odd numbered index is a value so set this to a variable 'value'.
                object value = record[2 * i + 1];

                //If any string value is null set it to an empty string.
                if (value == null)
                    value = "";
                //Format in single quotation marks if value is of type String.
                if (value.GetType() == typeof(String))
                {
                    //If the value contains single quotation marks (') then format it with another one (e.g. "O''Doherty") for SQL.
                    if (value.ToString().ToCharArray().Contains('\''))
                        value = value.ToString().Insert(value.ToString().IndexOf('\''), "\'");

                    value = String.Format("'{0}'", value);
                }
                //Format like 'DD-MMM-YYYY' if value is of type DateTime.
                else if (value.GetType() == typeof(DateTime))
                {
                    DateTime date = DateTime.Parse(value.ToString());
                    value = String.Format("'{0}'", date.ToString("dd-MMM-yyyy"));
                }
                else if (value.GetType() == typeof(TimeSpan))
                {
                    value = $"'{value}'";
                }
                //Format to 0 (False) or 1 (True) if value is of type Boolean.
                else if (value.GetType() == typeof(Boolean))
                {
                    if ((bool)value)
                        value = 1;
                    else
                        value = 0;
                }

                //Place a comma after each evaluation in the SET except for the last evaluation.
                string comma = ", ";
                if ((2 * i + 2) == record.Length)
                    comma = " ";

                //Append next columnName (2*i) = value (2*i + 1) and comma to sql string.
                sql += $"{record[2 * i]} = {value}{comma}";
            }

            //Only update the desired record in the table by evaluating the record ID.
            sql += $"WHERE {record[0]} = '{record[1]}'";

            if (tableName == "Dog_Vaccination")
                sql = $@"UPDATE {tableName} SET VaccinationDate = '{record[5]}' WHERE DogID = '{record[1]}' AND VaccinationNo = '{record[3]}'";

            SqlConnection connection = new SqlConnection(cnstr);
            connection.Open();

            using (SqlCommand command = new SqlCommand(sql, connection))
                command.ExecuteNonQuery();

            //Display Message Box to confirm update.
            if (new string[] { "Client", "Staff", "Dog" }.Contains(tableName))
            { 
                if (tableName == "Dog")
                    MessageBox.Show($"{tableName} '{record[1]}' {record[5].ToString().ToUpper()} has been updated.", "UPDATED SUCCESSFULLY");
                else
                    MessageBox.Show($"{tableName} '{record[1]}' {record[3].ToString().ToUpper()} {record[5].ToString().ToUpper()} has been updated.", "UPDATED SUCCESSFULLY");
            }
        }

        //-Deletes the desired record from the selected table.
        public static void DeleteRecord(string tableName, string id)
        {
            SqlConnection connection = new SqlConnection(cnstr);
            connection.Open();

            //Client record is a special case as all the client's dogs in the Dog table and their bookings in the Booking table must be deleted as well.
            if (tableName == "Client")
            {
                sql = $@"DELETE FROM Payment WHERE PaymentNo IN
                        (SELECT P.PaymentNo FROM Payment P JOIN Booking B ON P.BookingNo = B.BookingNo JOIN Dog D ON B.DogID = D.DogID WHERE D.ClientID = '{id}')
                         DELETE FROM Booking WHERE BookingNo IN 
                        (SELECT B.BookingNo FROM Booking B JOIN Dog D ON B.DogID = D.DogID WHERE D.ClientID = '{id}')
                         DELETE FROM Dog_Vaccination WHERE DogID IN
                        (SELECT DogID FROM Dog WHERE ClientID = '{id}')
                         DELETE FROM Dog WHERE ClientID = '{id}'
                         DELETE FROM Client WHERE ClientID = '{id}'";
            }
            //Dog record is another special case as all of their appointments in the Booking table must be deleted as well.
            else if (tableName == "Dog")
            {
                sql = $@"DELETE FROM Payment WHERE PaymentNo IN
                        (SELECT P.PaymentNo FROM Payment P JOIN Booking B ON P.BookingNo = B.BookingNo WHERE B.DogID = '{id}')
                         DELETE FROM Booking WHERE DogID = '{id}'
                         DELETE FROM Dog_Vaccination WHERE DogID = '{id}'
                         DELETE FROM Dog WHERE DogID = '{id}'";
            }
            else if (tableName == "Staff")
            {
                sql = $@"DELETE FROM Payment WHERE PaymentNo IN
                        (SELECT P.PaymentNo FROM Payment P JOIN Booking B ON P.BookingNo = B.BookingNo WHERE B.StaffID = '{id}')
                         DELETE FROM Booking WHERE StaffID = '{id}'
                         DELETE FROM Staff WHERE StaffID = '{id}'";
            }
            else if (tableName == "Options")
            {
                sql = $@"DELETE FROM Payment WHERE PaymentNo IN
                        (SELECT P.PaymentNo FROM Payment P JOIN Booking B ON P.BookingNo = B.BookingNo WHERE B.ServiceOptionNo = '{id}')
                         DELETE FROM Booking WHERE BookingNo IN
                        (SELECT B.BookingNo FROM Booking B JOIN Options O ON B.ServiceOptionNo = O.ServiceOptionNo WHERE O.ServiceOptionNo = '{id}')
                         DELETE FROM Options WHERE ServiceOptionNo = '{id}'";
            }
            else
            {
                string columnName = $"{tableName}ID";
                if (tableName == "Booking")
                    columnName = "BookingNo";

                sql = $@"DELETE FROM {tableName} WHERE {columnName} = '{id}'";
            }

            using (SqlCommand command = new SqlCommand(sql, connection))
                command.ExecuteNonQuery();
        }   

        //public static void DisplayItems(ListView l, string tableName, string[] columns)
        //{
        //    sql = $@"SELECT * FROM {tableName};";
        //    sda = new SqlDataAdapter(sql, cnstr);
        //    cmd = new SqlCommandBuilder(sda);
        //    sda.FillSchema(dsJDDogCare, SchemaType.Source, tableName);
        //    sda.Fill(dsJDDogCare, tableName);
        //    ListViewItem item = new ListViewItem();

        //    foreach (DataRow dr in dsJDDogCare.Tables[tableName].Rows)
        //    {
        //        item = l.Items.Add(dr[columns[0]].ToString());
        //        for (int i = 1; i < columns.Length; i++)
        //            item.SubItems.Add(dr[columns[i]].ToString());
        //    }
        //}
    }
}
