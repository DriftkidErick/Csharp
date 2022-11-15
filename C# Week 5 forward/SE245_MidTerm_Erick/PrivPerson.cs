using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_Class1; 

namespace SE245_MidTerm_Erick
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
                if (ValidationLibrary.GotBadWords(value) == true)
                {
                    FirstName = value;

                }

                else
                {
                    feedback += "Error: Sorry wrong input placed"
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
                if (ValidationLibrary.)
            }
        }

        public string Street1  //Set the info into street1
        {
            get { return street1; }
            set { street1 = value; }
        }

        public string Street2   //Set the info into street2
        { 
            get { return street2; }
            set { street2 = value; }
        }

        public string City      //Set the info into city
        {
            get { return city; }
            set { city = value; }
        }

        public string State   //Set the info into state
        {
            get { return state; }
            set { state = value; }
        }

        public string Zipcode    //Set the info into zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public string Phone    //Set the info into phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email  //Set the info into email
        {
            get { return email; }
            set { email = value; }
        }

        public Person()
        {
            feedback = " ";
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
