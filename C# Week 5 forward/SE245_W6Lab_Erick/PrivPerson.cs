using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Week4_Class1;

namespace SE245_W4Private_Erick
{
    public class Person
    {
        //This is the Strings we need for the Persons information
        private string fName;
        private string mName;
        private string lName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zipcode;
        private string phone;
        private string email;

        protected string feedback;

        public string FirstName //Set the info into fName
        {
            get
            {
                return fName;
            }
            set
            {
                if (ValidationLibrary.GotBadWords(value) == false )
                {
                    fName = value;
                }

                else
                {
                    feedback += "\n\nError: Wrong First Name";
                }
            }
        }

        public string MiddleName //Set the info into mName
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public string LastName  //Set the info into lName
        {
            get
            {
                return lName;
            }
            set
            {
                if (ValidationLibrary.GotBadWords(value) == false)
                {
                    lName = value;
                }
                else
                {
                    feedback += "\n\nError: Wrong Last Name";
                }
            }
        }

        public string Street1  //Set the info into street1
        {
            get
            {
                return street1;
            }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value) == true) //Test this one before coding the rest out 
                {
                    street1 = value;
                }

                else
                {
                    feedback += "\n\nError: Missing Street 1";
                }
            }
        }

        public string Street2   //Set the info into street2
        {
            get { return street2; }
            set { street2 = value; }
        }

        public string City      //Set the info into city
        {
            get
            { 
                return city; 
            }
            set 
            {
                if (ValidationLibrary.IsItFilledIn(value) == true)
                {
                    city = value;
                }

                else
                {
                    feedback += "\n\nError: Missing City";
                }
            }
        }

        public string State   //Set the info into state
        {
            get 
            {
                return state; 
            }
            set 
            {
                if (ValidationLibrary.DoesItFill(value, 2) == true) // if the input is greater than 2 then store state
                {
                    state = value;
                }
                else //if less than 2 number throw an error
                {
                    feedback += "\n\nError: Missing State";
                }
            }
        }

        public string Zipcode    //Set the info into zipcode
        {
            get
            {
                return zipcode;
            }
            set
            {
                if (ValidationLibrary.DoesItFill(value, 4) == true)
                {
                    zipcode = value;
                }

                else
                {
                    feedback += "\n\nError: Sorry invalid Zip";
                }
            }
        }

        public string Phone    //Set the info into phone
        {
            get
            {
                return phone; 
            }
            set 
            {
                if (ValidationLibrary.DoesItFill(value, 10) == true)
                {
                    phone = value;
                }
                else
                {
                    feedback += "\n\nError: Sorry invalid phone number";
                }
            }
        }

        public string Email  //Set the info into email
        {
            get
            {
                return email;
            }
            set
            {
                if (ValidationLibrary.IsValidEmail(value))
                {
                    email = value;
                }

                else
                {
                    feedback += "\n\nError: Invalid email address";
                }
            }
        }

        public Person()
        {
            feedback = "";
        }
        public string FeedBack
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

        public void PrintPerson()
        {
            //this function will be used to print out the persons information
            Console.WriteLine($"\n\nHere are the Persons stats below: " +
                $"\n\tFrist Name : {fName}" +
                $"\n\tMiddle Name: {mName}" +
                $"\n\tLast Name  : {lName}" +
                $"\n\tStreet 1   : {street1}" +
                $"\n\tStreet 2   : {street2}" +
                $"\n\tCity       : {city}" +
                $"\n\tState      : {state}" +
                $"\n\tZip Code   : {zipcode}" +
                $"\n\tPhone #    : {phone}" +
                $"\n\tEmail      :{email} ");


        }
    }
}
