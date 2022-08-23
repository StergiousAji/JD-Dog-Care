using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Dog_Care
{
    class Booking
    {
        //Attributes
        private string bookingNo, dogID, serviceOptionNo, staffID, errorMessage;
        private DateTime date, dateCreated;
        private TimeSpan startTime;
        private bool extraOption;

        //Constructors
        public Booking() { }

        public Booking(string bN, string d, DateTime da, TimeSpan sT, string sON, bool eO, string s, DateTime dC)
        {
            bookingNo = bN;
            dogID = d;
            date = da;
            startTime = sT;
            serviceOptionNo = sON;
            extraOption = eO;
            staffID = s;
            dateCreated = dC;
        }

        //Properties
        public string BookingNo
        {
            get { return bookingNo; }
            set
            {
                if (Validate_ID(value, "BookingNo"))
                    bookingNo = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string DogID
        {
            get { return dogID; }
            set
            {
                if (Validate_ID(value, "DogID"))
                    dogID = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (Validate_Date(value))
                    date = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public TimeSpan StartTime
        {
            get { return startTime; }
            set
            {
                if (Validate_StartTime(value))
                    startTime = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string ServiceOptionNo
        {
            get { return serviceOptionNo; }
            set
            {
                if (Validate_ServiceOptionNo(value))
                    serviceOptionNo = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public bool ExtraOption
        {
            get { return extraOption; }
            set { extraOption = value; }
        }

        public string StaffID
        {
            get { return staffID; }
            set
            {
                if (Validate_ID(value, "StaffID"))
                    staffID = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set
            {
                if (Validate_DateCreated(value))
                    dateCreated = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        //Validation Methods
        private bool Validate_ID(string number, string type)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(number))
            {
                errorMessage = $"Please provide the {type}.";
                return false;
            }

            //If value is not the correct length then ERROR.
            if (number.Length != 4)
            {
                errorMessage = $"This {type} is not the correct length.";
                return false;
            }

            //If value does not contain all numbers then ERROR.
            foreach (char c in number)
            {
                if (!Char.IsNumber(c))
                {
                    errorMessage = $"This {type} is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Date(DateTime date)
        {
            if (date > DateTime.Now.AddMonths(6))
            {
                errorMessage = "You cannot book an appointment over 6 months in advance.";
                return false;
            }

            return true;
        }

        private bool Validate_StartTime(TimeSpan startTime)
        {
            //The start times should between 9am and 5pm and only be set in whole hours or quarter hours.
            if (startTime < new TimeSpan(9, 0, 0) || startTime >= new TimeSpan(17, 0, 0) || !(startTime.Minutes % 15 == 0))
            {
                errorMessage = "This start time is invalid.";
                return false;
            }

            return true;
        }

        private bool Validate_ServiceOptionNo(string serviceOptionNo)
        {
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~CHECK~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
            //string[] options = new string[] { "Option 1", "Option 2", "Option 3" };
            //if (!options.Contains(serviceOption))
            //{
            //    errorMessage = "This service option does not exist.";
            //    return false;
            //}

            return true;
        }

        private bool Validate_DateCreated(DateTime dateCreated)
        {
            if (dateCreated > date)
            {
                errorMessage = "The date of the booking creation cannot occur after the appointment has taken place.";
                return false;
            }

            return true;
        }
    }
}
