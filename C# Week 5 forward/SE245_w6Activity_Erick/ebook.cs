using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWinVer_Erick;
using Week4_Class1;

namespace SE245_w6Activity_Erick
{
    class Ebook : Book
    {
        private DateTime dateExperation;
        private int bookmark;

        


        public DateTime DateExperation
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
                    feedback += "\n\nError You cannot enter a future date";
                }
            }
        }

        public int BookMark
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
                    
                    feedback += "\nERROR: Sorry you entered an invalid bookmark page #.";
                }
            }
            
        }
            

        public string Feedback
        {
            get
            { return feedback;}
        }

        
    

    }
}
