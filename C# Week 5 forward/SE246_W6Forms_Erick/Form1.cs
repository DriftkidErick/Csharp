using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE246_W6Forms_Erick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //When submit is clicked
        {
            Ebook temp = new Ebook(); //Create a new Ebook instance


            //FIll in the persons information

            temp.Title = txtTitle.Text;

            temp.AuthorFirst = txtAuthorFname.Text;

            temp.AuthorLast = txtAuthorLName.Text;

            temp.Email = txtEmail.Text;


            

            Int32 result = 0;  //empty Int var for storing Ints

            bool blnRes = Int32.TryParse(intPages.Text, out result);
            
            if (blnRes == true) //if blnRes is good store the value
            {
                temp.Pages = result;
            }
            else               //If blnRes is bad add an error to temp.Feedback
            { 
                temp.FeedBack += "\n\nError: Pages should be numeric like 10";
            }

            
            double dblResult = 0; //empty double var to store doubles

            blnRes = Double.TryParse(dblPrice.Text, out dblResult);

            if (blnRes == true)             //if blnRes is good store the value
            {
                temp.Price = dblResult;
            }
            else                    //If blnRes is bad add an error to temp.Feedback

            {
                temp.FeedBack += "\n\nError: Price should be like 10.99";
            }


            temp.DatePublished = dtPub.Value;
            temp.DateExperation = dtExperation.Value;

            blnRes = Int32.TryParse(txtBookMark.Text, out result); // validation of bookmark
            if (blnRes == true)
            {
                temp.BookMark = result;
            }

            else
            {
                temp.FeedBack += "\n\nError: Bookmark should be numeric like 10";
            }


            //This is the area where the feedback is retrieved
            if (temp.FeedBack.Contains("Error:"))
            {
                lblFeedBack.Text = $"{temp.FeedBack}";

            }

            else //So if there is no errors it will print out 
            { 
                lblFeedBack.Text =
                "\n\nHere is the books inforamtion: " +

                $"\nTitle:               {temp.Title}" +
                $"\nAuthor's First Name: {temp.AuthorFirst}" +
                $"\nAuthor's Last Name:  {temp.AuthorLast}" +
                $"\nEmail:               {temp.Email}" +
                $"\nDate Published:      {temp.DatePublished}" +
                $"\nPages:               {temp.Pages}" +
                $"\nPrice:               {temp.Price}" +
                $"\nDate Experation:     {temp.DateExperation}" +
                $"\nBookMark:            {temp.BookMark}";
            }
            
           


        }
    }
}
