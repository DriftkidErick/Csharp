using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_Class1;
using SE245_w6Activity_Erick;

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

        public string feedback;

        public string Title
        {
            get { return title; }

            set 
            { if (value.ToUpper().Contains("CACA") || value.ToUpper().Contains("POOP"))
                {
                    title = "Invalid Title";
                }
                else
                {
                    title = value;
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
            { if (ValidationLibrary.GotBadWords(value) == false)
                {

                    authorFirst = value;
                }

                else
                {
                    feedback += "\n\nYou cannot enter a bad word here!!! \n\nPlease learn some manners!";
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
                    feedback += "\n\nYou cannot enter a bad word here!!! \n\nPlease learn some manners!";
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
                if (ValidationLibrary.IsValidEmail(value) == false)
                {
                    email = value;

                }

                else
                {
                    feedback += "\n\nSorry you entered an invalid email. Try again";
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
                    feedback += "Sorry you cannot enter a future date. Please try again";
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
                if (ValidationLibrary.IsMinimumAmount(value, 1) == false)
                {
                    pages = value;
                }

                else 
                {
                    feedback += "\n\n Sorry the page amount enterted is false. Please try again";
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
                if (ValidationLibrary.IsMinimumAmount(value, 1) == false)
                {
                    price = value;
                }

                else
            }
        }

        public void PrintStats()
        {
            Console.WriteLine($"\n\n\n The book {title}, witten by {authorFirst} {authorLast} was published on {datePublished.ToShortDateString()} and has {pages} pages and costs ${price}. The authors contact is {email}");
        }

        public Book()
        {
            datePublished = DateTime.Now;
        }

        public Book(string tTitle, int tpages, double tprice, DateTime tDatePublished)
        {
            title = tTitle;
            pages = tpages;
            price = tprice;
            datePublished = tDatePublished;
        }

    }
}
