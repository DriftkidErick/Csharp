using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace SE245_W6Lab_Erick
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

        private void button1_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2(); //New Person 


            //Add the information of the new person
            temp.FirstName = txtFname.Text;
            temp.MiddleName = txtMname.Text;
            temp.LastName = txtLname.Text;

            temp.Insta = txtInsta.Text;

            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;

            temp.Email = txtEmail.Text;
  
            //Zipcode Validator
            Int32 result = 0;
            bool blnRes = Int32.TryParse(intZipCode.Text, out result);

            if (blnRes == true)
            { 

                temp.Zipcode = result.ToString();
            }
            else
            {
                temp.FeedBack += "\n\nError: You have enter an invalid value for Zip Code";
            } 


            //CellPhone Validator
            blnRes = Int32.TryParse(intCellPhone.Text, out result);
            if (blnRes == true)
            {
                temp.CellPhone = result.ToString();
            }
            else
            {
                temp.FeedBack += "\n\nError: Invalid Cell Phone Number";
            }

            //Phone Validator
            blnRes = Int32.TryParse(intPhoneNum.Text, out result);
            if (blnRes == true)
            {
                temp.Phone = result.ToString();
            }
            else
            {
                temp.FeedBack += "\n\nError: Invalid Phone Number";
            }

            

            //Here the feedback will print out
            if (temp.FeedBack.Contains("Error:"))
            {
                lblFeedback.Text = $"{temp.FeedBack}";
            }
            else
            {
                lblFeedback.Text =
                    ($"\n\nHere are the Persons stats below: " +
                $"\n\tFrist Name : {temp.FirstName}" +
                $"\n\tMiddle Name: {temp.MiddleName}" +
                $"\n\tLast Name  : {temp.LastName}" +
                $"\n\tInstagram  : {temp.Insta}" +
                $"\n\tStreet 1   : {temp.Street1}" +
                $"\n\tStreet 2   : {temp.Street2}" +
                $"\n\tCity       : {temp.City}" +
                $"\n\tState      : {temp.State}" +
                $"\n\tZip Code   : {temp.Zipcode}" +
                $"\n\tEmail      :{temp.Email} "+
                $"\n\tPhone #    : {temp.Phone}" +
                $"\n\tCell Phone  :{temp.CellPhone}");
            }

            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
