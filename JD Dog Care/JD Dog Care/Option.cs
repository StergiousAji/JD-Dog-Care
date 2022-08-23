using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Dog_Care
{
    class Option
    {
        //Attributes
        private string serviceOptionNo, serviceOptionDescription, errorMessage;
        private TimeSpan duration;
        private double price;

        //Constructors
        public Option() { }

        public Option(string sON, string sOD, TimeSpan d, double p)
        {
            serviceOptionNo = sON;
            serviceOptionDescription = sOD;
            duration = d;
            price = p;
        }

        //Properties
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

        public string ServiceOptionDescription
        {
            get { return serviceOptionDescription; }
            set
            {
                if (Validate_ServiceOptionDescription(value))
                    serviceOptionDescription = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public TimeSpan Duration
        {
            get { return duration; }
            set
            {
                if (Validate_Duration(value))
                    duration = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (Validate_Price(value))
                    price = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        //Validation Methods
        private bool Validate_ServiceOptionNo(string serviceOptionNo)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(serviceOptionNo))
            {
                errorMessage = "Please provide the service option number.";
                return false;
            }

            //The value must be in the right format: 'Option N' (N = Number).
            if (!serviceOptionNo.StartsWith("Option "))
            {
                errorMessage = "This service option number is in the wrong format.";
                return false;
            }

            return true;
        }

        private bool Validate_ServiceOptionDescription(string serviceOptionDescription)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(serviceOptionDescription))
            {
                errorMessage = "Please provide the service option description.";
                return false;
            }

            //If value exceeds the character limit then ERROR.
            if (serviceOptionDescription.Length > 100)
            {
                errorMessage = "The value provided has exceeded the character limit";
                return false;
            }

            return true;
        }

        private bool Validate_Duration(TimeSpan duration)
        {
            //If the duration is set to 0 or if it is not set in quarter hours then ERROR.
            if (duration == TimeSpan.Parse("0:00") || duration.Minutes % 15 != 0)
            {
                errorMessage = "This duration value is invald.";
                return false;
            }

            //If the duration is greater than 4 hours long.
            if (duration > TimeSpan.Parse("4:00"))
            {
                errorMessage = "The duration can only be set to a maximum of 4 hours";
                return false;
            }

            return true;
        }

        private bool Validate_Price(double price)
        {
            //If value exceeds the character limit then ERROR.
            if ((price.ToString()).Length > 5)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            return true;
        }
    }
}
