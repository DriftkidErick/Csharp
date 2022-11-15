using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_Class1; //Validation library
using SE245_W4Private_Erick; //person class
using System.Windows.Forms;

namespace SE245_W6Lab_Erick
{
    class PersonV2 : Person //Here Inherit the person class
    {
        private string cellPhone;
        private string insta;

        public string CellPhone
        {
            get 
            { 
                return cellPhone; 
            }
            set
            {
                if (ValidationLibrary.DoesItFill(value, 10) == true) // if the value is = to 10 then store the cell phone number
                {
                    cellPhone = value;
                }
                else
                {
                    feedback += "\n\nError: Invalid Cell Phone number"; //stores into feedback
                }
               
            }
        }

        public string Insta
        {
            get
            {
                return insta;
            }

            set
            {
                if (ValidationLibrary.ValidInsta(value) == true)
                {
                    insta = value;
                }

                else
                {
                    feedback += "\n\nError: Sorry Invalid Instagram User Name.";
                }
            }
        }
    }
}
