using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week4_Class1;

namespace BookWinVer_Erick
{

    public class Book
    {
        private string title;
        private string authorFirst;
        private string authorLast;
        private string email;
        private DateTime datePublished;
        private int pages;
        private double price;

        protected string feedback;

        public string Title
        {
            get { return title; }

            set
            {
                if (ValidationLibrary.GotBadWords(value) == false)
                {
                    title = value;
                }
                else
                { 
                    feedback += "\n\nError: You cannot enter a bad word here!!! Please learn some manners!";
                }
            }
        }

        public string AuthorFirst
        {
            get
            {
                return authorFirst;
            }

            set
            {
                if (ValidationLibrary.GotBadWords(value) == false)
                {

                    authorFirst = value;
                }

                else
                {
                    feedback += "\n\nError: You cannot enter a bad word here!!! Please learn some manners!";
                }
            }
        }

        public string AuthorLast
        {
            get
            {
                return authorLast;
            }
            set
            {
                if (ValidationLibrary.GotBadWords(value) == false)
                {
                    authorLast = value;
                }

                else
                {
                    feedback += "\n\nError: You cannot enter a bad word here!!! Please learn some manners!";
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
                if (ValidationLibrary.IsValidEmail(value) )
                {
                    email = value;

                }

                else
                {
                    feedback += "\n\nError: Sorry you entered an invalid email. Try again";
                }
            }

        }

        public DateTime DatePublished
        {
            get
            {
                return datePublished;
            }

            set
            {
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    datePublished = value;

                }

                else
                {
                    feedback += "\n\nError: Sorry you cannot enter a future date. Please try again";
                }
            }
        }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    pages = value;
                }

                else
                {
                    feedback += "\n\nError: Sorry the page amount enterted is false. Please try again";
                }
            }

        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    price = value;
                }

                else
                {
                    feedback += "\n\nError: Sorry you entered an invalid value. Please try again.";
                }
            }
        }
        

        public void PrintStats()
        {
            Console.WriteLine($"\n\n\n The book {title}, witten by {authorFirst} {authorLast} was published on {datePublished.ToShortDateString()} and has {pages} pages and costs ${price}. The authors contact is {email}");
        }

        public Book()
        {
            feedback = "";
            datePublished = DateTime.Now; 
            
        }

        public Book(string tTitle, int tpages, double tprice, DateTime tDatePublished)
        {
            feedback = "";
            title = tTitle;
            pages = tpages;
            price = tprice;
            datePublished = tDatePublished;
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

        

    }

}
    
