using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace JD_Dog_Care
{
    class Staff
    {
        //Attributes
        private string staffID, forename, surname, sex, address, city, postcode, email, phoneNo, jobContract, jobPosition, errorMessage;
        private double salary;
        private DateTime dateOfBirth, dateJoined;

        //Constructors
        public Staff() { }

        public Staff(string sID, string f, string s, string g, DateTime dob, string a, string c, string p, string e, string pN,
            string jC, string jP, double sal, DateTime dJ)
        {
            staffID = sID;
            forename = f;
            surname = s;
            sex = g;
            dateOfBirth = dob;
            address = a;
            city = c;
            postcode = p;
            email = e;
            phoneNo = pN;
            jobContract = jC;
            jobPosition = jP;
        }

        //Properties
        public string StaffID
        {
            get { return staffID; }
            set
            {
                if (Validate_StaffID(value))
                    staffID = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string Forename
        {
            get { return forename; }
            set
            {
                if (Validate_Name(value, "forename"))
                    forename = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (Validate_Name(value, "surname"))
                    surname = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string Sex
        {
            get { return sex; }
            set
            {
                if (Validate_Sex(value))
                    sex = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (Validate_DateOfBirth(value))
                    dateOfBirth = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (Validate_Address(value))
                    address = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (Validate_City(value))
                    city = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (Validate_Postcode(value))
                    postcode = value;
                else
                    throw new CustomException(errorMessage);
            }
        } 

        public string Email
        {
            get { return email; }
            set
            {
                if (Validate_Email(value))
                    email = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string PhoneNo
        {
            get { return phoneNo; }
            set
            {
                if (Validate_PhoneNo(value))
                    phoneNo = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string JobContract
        {
            get { return jobContract; }
            set 
            {
                if (Validate_JobContract(value))
                    jobContract = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string JobPosition
        {
            get { return jobPosition; }
            set
            {
                if (Validate_JobPosition(value))
                    jobPosition = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (Validate_Salary(value))
                    salary = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public DateTime DateJoined
        {
            get { return dateJoined; }
            set
            {
                if (Validate_DateJoined(value))
                    dateJoined = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        //Validation Methods
        private bool Validate_StaffID(string staffID)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(staffID))
            {
                errorMessage = "Please provide the StaffID.";
                return false;
            }

            //If value is not the correct length then ERROR.
            if (staffID.Length != 4)
            {
                errorMessage = "This StaffID is not the correct length.";
                return false;
            }

            //If value does not contain all numbers then ERROR.
            foreach (char c in staffID)
            {
                if (!Char.IsNumber(c))
                {
                    errorMessage = "This StaffID is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Name(string name, string type)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(name))
            {
                errorMessage = $"Please provide the staff's {type}";
                return false;
            }

            //If value exceeds the character limit then ERROR.
            if (name.Length > 30)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            //If value does not all letters and/or apostrophe (e.g. O'Gallagher) then ERROR.
            foreach (char c in name)
            {
                if (!(Char.IsLetter(c) || c == '\''))
                {
                    errorMessage = $"This {type} is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Sex(string sex)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(sex))
            {
                errorMessage = "Please provide the staff's sex.";
                return false;
            }

            //If value is not contained within the options array then ERROR.
            string[] options = new string[] { "Male", "Female", "Other" };
            if (!options.Contains(sex))
            {
                errorMessage = "The value entered is invalid.";
                return false;
            }

            return true;
        }

        private bool Validate_DateOfBirth(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            //Check to see if an extra year has been added to the age due to the difference in months. If so decrement age.
            if (dob > DateTime.Now.AddYears(-age))
                age--;

            //If staff's age is below 16 years then ERROR.
            if (age < 16)
            {
                errorMessage = "Only staff over 16 years can be registered into the database.";
                return false;
            }

            //If staff's age is too large then ERROR.
            if (age > 70)
            {
                errorMessage = "This date of birth is unrealistic.";
            }

            return true;
        }

        private bool Validate_Address(string address)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(address))
            {
                errorMessage = "Please provide the staff's address.";
                return false;
            }

            //If value exceeds the character limit then ERROR.
            if (address.Length > 50)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            //If value contains any punctuation then ERROR.
            foreach (char c in address)
            {
                if (Char.IsPunctuation(c))
                {
                    errorMessage = "The address is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_City(string city)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(city))
            {
                errorMessage = "Please provide the city/town that the employee lives in.";
                return false;
            }

            //If value exceeds the character limit then ERROR.
            if (city.Length > 50)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            //If value does not contain letters and/or punctuation then ERROR.
            foreach (char c in city)
            {
                if (!(Char.IsLetter(c) || c == '/'))
                {
                    errorMessage = "The city/town is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Postcode(string postcode)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(postcode))
            {
                errorMessage = "Please provide the staff's postcode.";
                return false;
            }

            //Reqular expression to see if the postcode is in the format: "LLNN NLL" (optional space) [L = Letter, N = Number].
            Regex reg = new Regex(@"^([A-Z][A-HJ-Y]?[0-9][A-Z0-9]? ?[0-9][A-Z]{2}|GIR ?0A{2})$");
            if (!reg.IsMatch(postcode))
            {
                errorMessage = "This postcode is not in the correct format.";
                return false;
            }

            return true;
        }

        private bool Validate_Email(string email)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(email))
            {
                errorMessage = "Please provide the staff's e-mail address.";
                return false;
            }

            //If value exceeds the character limit then ERROR.
            if (email.Length > 50)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            //Regular expression to see if the e-mail address is in the format: "someone@email.com".
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!reg.IsMatch(email))
            {
                errorMessage = "This e-mail address is not in the correct format.";
                return false;
            }

            return true;
        }

        private bool Validate_PhoneNo(string phoneNo)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(phoneNo))
            {
                errorMessage = "Please provide the staff's phone number.";
                return false;
            }

            //If the value is not the correct length then ERROR.
            if (phoneNo.Length < 11 || phoneNo.Length > 15)
            {
                errorMessage = "This phone number is not the correct length.";
                return false;
            }

            //If the value begins with a "+" character then remove it.
            string number = phoneNo;
            if (phoneNo.StartsWith("+"))
                number = phoneNo.Remove(0, 1);

            //If the value does not contain all numbers then ERROR.
            foreach (char c in number)
            {
                if (!Char.IsNumber(c))
                {
                    errorMessage = "This phone number is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_JobContract(string contract)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(contract))
            {
                errorMessage = "Please select the staff's work contract.";
                return false;
            }

            //If value is not contained within the options array then ERROR.
            string[] options = new string[] { "Full-Time", "Part-Time" };
            if (!options.Contains(contract))
            {
                errorMessage = "The value entered is invalid.";
                return false;
            }

            return true;
        }

        private bool Validate_JobPosition(string position)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(position))
            {
                errorMessage = "Please provide the staff's field of work.";
                return false;
            }

            //If value is not contained within the options array then ERROR.
            string[] options = new string[] { "Management", "Administration", "Grooming" };
            if (!options.Contains(position))
            {
                errorMessage = "The value entered is invalid.";
                return false;
            }

            return true;
        }

        private bool Validate_Salary(double salary)
        {
            //If value exceeds the character limit then ERROR.
            if ((salary.ToString()).Length > 10)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            return true;
        }

        private bool Validate_DateJoined(DateTime dateJoined)
        {
            //If value provided is after the present date then ERROR.
            if (dateJoined > DateTime.Now)
            {
                errorMessage = "This date is invalid.";
                return false;
            }

            return true;
        }
    }
}
