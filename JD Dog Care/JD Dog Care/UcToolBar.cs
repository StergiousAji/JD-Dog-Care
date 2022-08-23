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
    public partial class UcToolBar : UserControl
    {
        public UcToolBar()
        {
            InitializeComponent();

            //Hide all the controls.
            foreach (Control control in this.Controls)
                control.Hide();

            switch (FrmJDDogCare.currentUserControl)
            {
                //Show Booking buttons.
                case "Booking":
                    btnCreateBooking.Show();
                    btnUpdateBooking.Show();
                    break;
                //Show Payment buttons.
                case "Payment":
                    btnSearchBooking.Show();
                    btnViewPayment.Show();
                    break;
                //Register and Update use the default buttons.
                default:
                    btnClient.Show();
                    btnDog.Show();
                    btnStaff.Show();
                    break;
            }
        }

        public static void BtnClient_Click(object sender, EventArgs e)
        {
            DefaultColours();
            btnClient.BackColor = Color.FromArgb(31, 122, 31);
            btnClient.FlatAppearance.BorderColor = Color.FromArgb(31, 122, 31);

            Form form = Form.ActiveForm;
            RemoveUserControls(form);

            if (FrmJDDogCare.currentUserControl == "Reports")
            {
                UserControl ClientReport = new UcReports(Color.FromArgb(31, 122, 31), "Client", FrmJDDogCare.client_columns);
                ClientReport.Location = new Point(240, 70);
                form.Controls.Add(ClientReport);
            }
            else
            {
                UserControl Client = new UcClient();
                Client.Location = new Point(240, 70);
                form.Controls.Add(Client);
            }
            
        }

        public static void BtnDog_Click(object sender, EventArgs e)
        {
            DefaultColours();
            btnDog.BackColor = Color.FromArgb(116, 37, 77);
            btnDog.FlatAppearance.BorderColor = Color.FromArgb(116, 37, 77);

            Form form = Form.ActiveForm;
            RemoveUserControls(form);

            if (FrmJDDogCare.currentUserControl == "Reports")
            {
                UserControl DogReport = new UcReports(Color.FromArgb(116, 37, 77), "Dog", FrmJDDogCare.dog_columns);
                DogReport.Location = new Point(240, 70);
                form.Controls.Add(DogReport); 
            }
            else
            {
                UserControl Dog = new UcDog();
                Dog.Location = new Point(240, 70);
                form.Controls.Add(Dog);
            }
        }

        public static void BtnStaff_Click(object sender, EventArgs e)
        {
            DefaultColours();
            btnStaff.BackColor = Color.FromArgb(128, 26, 0);
            btnStaff.FlatAppearance.BorderColor = Color.FromArgb(128, 26, 0);

            Form form = Form.ActiveForm;
            RemoveUserControls(form);

            if (FrmJDDogCare.currentUserControl == "Reports")
            {
                UserControl StaffReport = new UcReports(Color.FromArgb(128, 26, 0), "Staff", FrmJDDogCare.staff_columns);
                StaffReport.Location = new Point(240, 70);
                form.Controls.Add(StaffReport);
            }
            else
            {
                UserControl Staff = new UcStaff();
                Staff.Location = new Point(240, 70);
                form.Controls.Add(Staff);
            }
        }

        public static void BtnCreateBooking_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "Create Booking";

            DefaultColours();
            btnCreateBooking.BackColor = Color.FromArgb(116, 77, 37);
            btnCreateBooking.FlatAppearance.BorderColor = Color.FromArgb(116, 77, 37);

            Form form = Form.ActiveForm;
            RemoveUserControls(form);

            UserControl CBooking = new UcBooking();
            CBooking.Location = new Point(240, 70);
            form.Controls.Add(CBooking);
        }

        public static void BtnUpdateBooking_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "Update Booking";

            DefaultColours();
            btnUpdateBooking.BackColor = Color.FromArgb(61, 92, 92);
            btnUpdateBooking.FlatAppearance.BorderColor = Color.FromArgb(61, 92, 92);

            Form form = Form.ActiveForm;
            RemoveUserControls(form);

            UserControl UBooking = new UcBooking();
            UBooking.Location = new Point(240, 70);
            form.Controls.Add(UBooking);
        }

        public static void BtnSearchBooking_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "Search Booking";

            DefaultColours();
            btnSearchBooking.BackColor = Color.FromArgb(134, 45, 45);
            btnSearchBooking.FlatAppearance.BorderColor = Color.FromArgb(134, 45, 45);

            Form form = Form.ActiveForm;
            RemoveUserControls(form);

            UserControl SBooking = new UcPayment();
            SBooking.Location = new Point(240, 70);
            form.Controls.Add(SBooking);
        }

        public static void BtnViewPayment_Click(object sender, EventArgs e)
        {
            FrmJDDogCare.currentUserControl = "View Payment";

            DefaultColours();
            btnViewPayment.BackColor = Color.FromArgb(134, 45, 45);
            btnViewPayment.FlatAppearance.BorderColor = Color.FromArgb(134, 45, 45);

            Form form = Form.ActiveForm;
            RemoveUserControls(form);

            UserControl MPayment = new UcPayment();
            MPayment.Location = new Point(240, 70);
            form.Controls.Add(MPayment);
        }

        private static void DefaultColours()
        {
            //Sets the default colours for all the buttons.
            Color defColour = Color.FromArgb(0, 77, 77);

            btnClient.BackColor = defColour;
            btnClient.FlatAppearance.BorderColor = defColour;

            btnDog.BackColor = defColour;
            btnDog.FlatAppearance.BorderColor = defColour;

            btnStaff.BackColor = defColour;
            btnStaff.FlatAppearance.BorderColor = defColour;

            btnCreateBooking.BackColor = defColour;
            btnCreateBooking.FlatAppearance.BorderColor = defColour;

            btnUpdateBooking.BackColor = defColour;
            btnUpdateBooking.FlatAppearance.BorderColor = defColour;

            btnSearchBooking.BackColor = defColour;
            btnSearchBooking.FlatAppearance.BorderColor = defColour;

            btnViewPayment.BackColor = defColour;
            btnViewPayment.FlatAppearance.BorderColor = defColour;
        }

        private static void RemoveUserControls(Form f)
        {
            //Removes all user controls present in the form except for the tool bar.
            foreach (Control userControl in f.Controls)
            {
                if (userControl is UserControl && !(userControl is UcToolBar))
                    f.Controls.Remove(userControl);
            }
        }
    }
}
