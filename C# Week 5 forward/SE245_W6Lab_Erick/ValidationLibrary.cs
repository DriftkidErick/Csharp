﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4_Class1
{
    class ValidationLibrary
    {

        public static bool GotBadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = {"POOP", "HOMEWORK", "CACA" };
            
            
            foreach (string strBW in strBadWords)
            if (temp.ToUpper().Contains(strBW))
            {
                result = true;
            }

            return result;
        }




        //**********************************************************************************************
        // Library of validation functions we can use in future projects
        //**********************************************************************************************

        //Receives a string and we can let user know if it is filled in
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        public static bool IsItFilledIn(string temp, string min)
        {
            bool result = false;

            if (temp.Length >= min.Length)
            {
                result = true;
            }

            return result;
        }




        //Receives a string and we can let user know if it is filled in
        public static bool DoesItFill(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length == minlen)
            {
                result = true;
            }

            return result;
        }



        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }

            return blnResult;
        }



        //Receives a string and we can let user know if it has a semi-valid email format
        public static bool IsValidEmail(string temp)
        {
            //assume true, but look for bad stuff to make it false
            bool blnResult = true;

            //Look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation+1);
            
            //temp = scott@neit.ca
            // length = 13
            // position of last period = 10
            
            //Look for position of last period "."
            int periodLocation = temp.LastIndexOf(".");

            //check for minimum length
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2)    //if it is -1, not found and needs at least 2 chars in front
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool ValidInsta(string temp)
        {
            bool blnResult = false;

            int atLocation = temp.IndexOf("@");

            if (atLocation == 0) //If the @ symbol starts at position 0 it works
            {
                blnResult = true;
            }

            else if (atLocation >= 1) //if @ symbol starts past 0 then it fails
            {
                blnResult = false;
            }

            return blnResult;
        }




        public static bool IsMinimumAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

       
        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }


        public static bool ValidCell(int temp, int min)
        { 
            bool blnResult = true; //assume this is true
            

            if (temp == min)
            {
                blnResult = true;
            }

            else
            {
                blnResult  = false;
            }

            return blnResult;

        }
         


    }
}