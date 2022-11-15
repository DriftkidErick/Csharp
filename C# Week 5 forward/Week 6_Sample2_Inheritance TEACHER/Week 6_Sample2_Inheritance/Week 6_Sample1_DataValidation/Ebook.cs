using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Added this workspace to allow us to use BasicTools and ValidationLibrary
using Week4_Class1;


namespace Week_6_Sample1_DataValidation
{
    class EBook: Book   //Welcome to inheritance...Ebook has all that book has, but more!
    {
        private DateTime dateRentalExpires;
        private int bookmarkPage;

        public DateTime DateRentalExpires
        {
            get
            {
                return dateRentalExpires;
            }

            set
            {
                //If the date given IS a future date...
                if (ValidationLibrary.IsAFutureDate(value))
                {
                    dateRentalExpires = value;  //Past Date...store it
                }
                else
                {
                    //Future Date...Store error msg in feedback
                    //**** ONLY WORKS BECAUSE feedback was changed to PROTECTED
                    feedback += "\nERROR: You must enter future dates";
                }
            }
        }



        public int BookmarkPage
        {
            get
            {
                return bookmarkPage;
            }

            set
            {
                //if we have the miimum number of pages needed...
                if (value >= 0 && value <= Pages)
                {
                    bookmarkPage = value;  //store the # of pages
                }
                else
                {
                    //Store an error msg in Feedback
                    feedback += "\nERROR: Sorry you entered an invalid bookmark page #.";
                }
            }
        }


        //Default Constructor
        public EBook(): base()  //Calls the parents constructor
        {
            BookmarkPage = 0;
            dateRentalExpires = DateTime.Now.AddDays(14);
        }

    }
}
