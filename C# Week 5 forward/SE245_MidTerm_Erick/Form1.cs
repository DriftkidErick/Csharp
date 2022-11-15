using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE245_MidTerm_Erick
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

        private void Addbttn_Click(object sender, EventArgs e)
        {
            Person temp = new Person(); //Create a new Person instance

            //FIll in the persons information

            temp.FirstName = txtFname.Text;
            temp.MiddleName = txtMName.Text;
            temp.LastName = txtLName.Text;
            temp.Phone = txtPhone.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.State = txtState.Text;
            temp.City = txtCity.Text;
            temp.Zipcode = txtZipCode.Text;
            temp.Email = txtEmail.Text;

            //This is used to print out the persons inputted information
            lblFeedBack.Text = "\n\nHere are the Persons stats below: " +
                $"\n\tFrist Name : {temp.FirstName}" +
                $"\n\tMiddle Name: {temp.MiddleName}" +
                $"\n\tLast Name  : {temp.LastName}" +
                $"\n\tStreet 1   : {temp.Street1}" +
                $"\n\tStreet 2   : {temp.Street2}" +
                $"\n\tCity       : {temp.City}" +
                $"\n\tState      : {temp.State}" +
                $"\n\tZip Code   : {temp.Zipcode}" +
                $"\n\tPhone #    : {temp.Phone}" +
                $"\n\tEmail      : {temp.Email} ";



        }
    }
}
