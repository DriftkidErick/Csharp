using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWinVer_Erick;
using Week4_Class1;


namespace SE246_W6Forms_Erick
{
    class Ebook : Book
    {
        private DateTime dateExperation;
        private int bookmark;




        public DateTime DateExperation //DateExperation validation
        {
            get
            {
                return dateExperation;
            }
            set
            {
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    dateExperation = value;
                }
                else
                {
                    feedback += "\n\nError: You cannot enter a future date";
                }
            }
        }

        public int BookMark //Bookmark validation
        {
            get
            {
                return bookmark;

            }

            set
            {
                if (value >= 0 && value <= Pages)
                {
                    bookmark = value;  //store the # of pages
                }
                else
                {

                    feedback += "\n\nERROR: Sorry you entered an invalid bookmark page #.";
                }
            }

        }

        public Ebook() : base()
        {
            bookmark = 0;
            
        }


    }
}
