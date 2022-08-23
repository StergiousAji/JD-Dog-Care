using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Dog_Care
{
    class Payment
    {
        //Attributes
        private string paymentNo, bookingNo, paymentMethod, cardNumber, securityCode, errorMessage;
        private DateTime paymentDate;
        private double cost;
        private bool paid;

        //Constructors
        public Payment() { }

        public Payment(string pN, string bN, DateTime pD, double c, string pM, string cN, string sC, bool p)
        {
            paymentNo = pN;
            bookingNo = bN;
            paymentDate = pD;
            cost = c;
            paymentMethod = pM;
            cardNumber = cN;
            securityCode = sC;
            paid = p;
        } 

        //Properties
        public string PaymentNo
        {
            get { return paymentNo; }
            set
            {
                if (Validate_No(value, "PaymentNo"))
                    paymentNo = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string BookingNo
        {
            get { return bookingNo; }
            set
            {
                if (Validate_No(value, "BookingNo"))
                    bookingNo = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set
            {
                if (Validate_PaymentDate(value))
                    paymentDate = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public double Cost
        {
            get { return cost; }
            set
            {
                if (Validate_Cost(value))
                    cost = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set
            {
                if (Validate_PaymentMethod(value))
                    paymentMethod = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (Validate_CardNumber(value))
                    cardNumber = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string SecurityCode
        {
            get { return securityCode; }
            set
            {
                if (Validate_SecurityCode(value))
                    securityCode = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        //Validation Methods
        private bool Validate_No(string number, string type)
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

        private bool Validate_PaymentDate(DateTime paymentDate)
        {
            return true;
        }

        private bool Validate_Cost(double cost)
        {
            //If value exceeds the character limit then ERROR.
            if ((cost.ToString()).Length > 5)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            return true;
        }

        private bool Validate_PaymentMethod(string paymentMethod)
        {
            //If value is not contained within the options array then ERROR.
            string[] options = new string[] { "Cash", "Cheque", "Debit Card", "Credit Card" };
            if (!options.Contains(paymentMethod))
            {
                errorMessage = "The value entered is invalid.";
                return false;
            }

            if (paymentMethod == "Cheque")
            {
                errorMessage = "JD Dog Care currently does not allow payments by cheques.";
                return false;
            }

            return true;
        }

        private bool Validate_CardNumber(string cardNumber)
        {
            //If value is not between 13 and 16 digits then ERROR.
            if (cardNumber.Length < 13 || cardNumber.Length > 16)
            {
                errorMessage = "The value provided is not the correct length.";
                return false;
            }

            //If the value does not contain all numbers then ERROR.
            foreach (char n in cardNumber)
            {
                if (!Char.IsNumber(n))
                {
                    errorMessage = "This card number is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_SecurityCode(string securityCode)
        {
            if (securityCode != " ")
            {
                //If value not the valid length then ERROR.
                if (securityCode.Length != 3)
                {
                    errorMessage = "The value provided is not the correct length.";
                    return false;
                }

                //If the value does not contain all numbers then ERROR.
                foreach (char n in securityCode)
                {
                    if (!Char.IsNumber(n))
                    {
                        errorMessage = "This security code is invalid.";
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
