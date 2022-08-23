using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD_Dog_Care
{
    class Dog
    {
        //Attributes
        private string dogID, clientID, name, breed, sex, medicalNotes, errorMessage;
        private DateTime dateOfBirth;

        //Constructors
        public Dog() { }

        public Dog(string d, string c, string n, string b, string s, DateTime dob, string mN)
        {
            dogID = d;
            clientID = c;
            name = n;
            breed = b;
            sex = s;
            dateOfBirth = dob;
            medicalNotes = mN;
        }

        //Properties
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

        public string ClientID
        {
            get { return clientID; }
            set
            {
                if (Validate_ID(value, "ClientID"))
                    clientID = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (Validate_Name(value))
                    name = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        public string Breed
        {
            get { return breed; }
            set
            {
                if (Validate_Breed(value))
                    breed = value;
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

        public string MedicalNotes
        {
            get { return medicalNotes; }
            set
            {
                if (Validate_MedicalNotes(value))
                    medicalNotes = value;
                else
                    throw new CustomException(errorMessage);
            }
        }

        //Validation Methods
        private bool Validate_ID(string id, string type)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(id))
            {
                errorMessage = $"Please provide the {type}.";
                return false;
            }

            //If value is not the correct length then ERROR.
            if (id.Length != 4)
            {
                errorMessage = $"This {type} is not the correct length.";
                return false;
            }

            //If value does not contain all numbers then ERROR.
            foreach (char c in id)
            {
                if (!Char.IsNumber(c))
                {
                    errorMessage = $"This {type} is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Name(string name)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(name))
            {
                errorMessage = "Please provide the dog's name.";
                return false;
            }

            //If value exceeds the character limit then ERROR.
            if (name.Length > 30)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            foreach (char c in name)
            {
                if (!Char.IsLetter(c))
                {
                    errorMessage = "This  name is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Breed(string breed)
        {
            //If text field is empty then ERROR.
            if (String.IsNullOrEmpty(breed))
            {
                errorMessage = "Please provide the dog's breed.";
                return false;
            }
            
            //If value exceeds the character limit then ERROR.
            if (breed.Length > 30)
            {
                errorMessage = "The value provided has exceeded the character limit.";
                return false;
            }

            //If value does not contain all letters then ERROR.
            foreach (char c in breed)
            {
                if (!(Char.IsLetter(c) || Char.IsWhiteSpace(c)))
                {
                    errorMessage = "This dog breed is invalid.";
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Sex(string sex)
        {
            //If the text field is empty then ERROR.
            if (String.IsNullOrEmpty(sex))
            {
                errorMessage = "Please provide the dog's sex";
                return false;
            }

            //If value is not contained within the options array then ERROR.
            string[] options = new string[] { "Male", "Female" };
            if (!options.Contains(sex))
            {
                errorMessage = "The value entered is invalid.";
                return false;
            }

            return true;
        }

        private bool Validate_DateOfBirth(DateTime dob)
        {
            //If the dog's age is over 50 years and its date of birth is after the present date then ERROR.
            if (dob < DateTime.Now.AddYears(-50) || dob >= DateTime.Now)
            {
                errorMessage = "This date of birth is invalid.";
                return false;
            }

            return true;
        }

        private bool Validate_MedicalNotes(string mn)
        {
            if (String.IsNullOrEmpty(mn))
            {
                errorMessage = "Please provide any medical notes for the dog. If none, write 'None'.";
                return false;
            }

            return true;
        }
    }
}
