using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string address2;
        private string city;
        private string state;
        private string zipCode;
        private string phone;
        private string email;
        protected string feedback;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                //if the first name field is filled in...
                if(validationLibrary.IsItFilledIn(value))
                {
                    //...it sets the value of first name = the value of FirstName.
                    firstName = value;
                }
                else
                {
                    //otherwise it adds an error to the feedback variable.
                    feedback += "\nERROR: First Name field not filled out.";
                }
                
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if(validationLibrary.IsItFilledIn(value))
                {
                    lastName = value;
                }
                else
                {
                    feedback += "\nERROR: Last Name field not filled out.";
                }
               
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if(validationLibrary.IsItFilledIn(value))
                {
                    address = value;
                }
                else
                {
                    feedback += "\nERROR: Address field not filled out.";
                }
               
            }
        }

        public string Address2
        {
            get
            {
                return address2;
            }

            set
            {
                address2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                if (validationLibrary.IsItFilledIn(value))
                {
                    city = value;
                }
                else
                {
                    feedback += "\nERROR: City field not filled out.";
                }
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                if(validationLibrary.IsState(value))
                {
                    state = value;
                }
                else
                {
                    feedback += "\nERROR: State field is not a valid state.";
                }
                
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }

            set
            {
                if (validationLibrary.IsValidZipCode(value))
                {
                    zipCode = value;
                }
                else
                {
                    feedback += "\nERROR: Zip Code field must be 5 characters.";
                }                
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                if(validationLibrary.IsValidPhoneNumber(value))
                {
                    phone = value;
                }
                else
                {
                    feedback += "\nERROR: Invalid Phone Number.";
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if(validationLibrary.IsValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "\nERROR: Invalid Email.";
                }
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }

            set
            {
                feedback = value;
            }
        }

        public person()
        {
            firstName = "";
            middleName = "";
            lastName = "";
            address = "";
            address2 = "";
            city = "";
            state = "";
            zipCode = "";
            phone = "";
            email = "";
            feedback = "";
        }


    }
}
