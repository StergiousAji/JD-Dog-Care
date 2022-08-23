using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace JD_Dog_Care
{
    class Client
    {
        //Attributes
        private string clientID, forename, surname, sex, address, city, postcode, email, phoneNo, errorMessage;
        private DateTime dateOfBirth, dateJoined;

        //Constructors
        public Client() { }

        public Client(string c, string f, string s, string g, DateTime dob, string a, string cty, string p, string e, string pN, DateTime dJ)
        {
            clientID = c;
            forename = f;
            surname = s;
            sex = g;
            dateOfBirth = dob;
            address = a;
            city = cty;
            postcode = p;
            email = e;
            phoneNo = pN;
            dateJoined = dJ;
        }

        //Properties
        public string ClientID
        {
            get { return clientID; }
            set 
            {
                if (Validate_ClientID(value))
                    clientID = value;
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
        private bool Validate_ClientID(string clientID)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(clientID))
            {
                errorMessage = "Please provide the ClientID.";
                return false;
            }

            //If value is not the correct length then ERROR.
            if (clientID.Length != 4)
            {
                errorMessage = "This ClientID is not the correct length.";
                return false;
            }

            //If value does not contain all numbers then ERROR.
            foreach (char c in clientID)
            {
                if (!Char.IsNumber(c))
                {
                    errorMessage = "This ClientID is invalid.";
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
                errorMessage = $"Please provide the client's {type}";
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
                errorMessage = "Please provide the client's sex.";
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

            //If client's age is below 18 years then ERROR.
            if (age < 18)
            {
                errorMessage = "Only clients over 18 years can be registered into the database.";
                return false;
            }

            //If client's age is too large then ERROR.
            if (age > 100)
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
                errorMessage = "Please provide the client's address.";
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
                errorMessage = "Please provide the city/town that the client lives in.";
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
                errorMessage = "Please provide the client's postcode.";
                return false;
            }

            //Reqular expression to see if the postcode is in the format: "LLNN NLL" (optional space) [L = Letter, N = Number]
            Regex reg = new Regex(@"^([A-Z][A-HJ-Y]?[0-9][A-Z0-9]? ?[0-9][A-Z]{2}|GIR ?0A{2})$");
            if (!reg.IsMatch(postcode))
            {
                errorMessage = "This postcode is not in the correct format.";
                return false;
            }

            //If value is not the correct length then ERROR.
            //if (postcode.Length != 8)
            //{
            //    errorMessage = "This postcode is not the correct length.";
            //    return false;
            //}

            //bool validFormat = true;
            ////If first two characters and last characters are not letters then ERROR.
            //foreach (char c in (postcode.Substring(0, 2) + postcode.Substring(6, 2)))
            //{
            //    if (!Char.IsLetter(c))
            //        validFormat = false;
            //}
            ////If next two characters or the 6th character are not numbers then ERROR.
            //foreach (char c in (postcode.Substring(2, 2) + postcode[5]))
            //{
            //    if (!Char.IsNumber(c))
            //        validFormat = false;
            //}

            //if (!validFormat)
            //    errorMessage = "This postcode is not in the correct format.";

            return true;
        }

        private bool Validate_Email(string email)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(email))
            {
                errorMessage = "Please provide the client's e-mail address.";
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
                errorMessage = "Please provide the client's phone number.";
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
