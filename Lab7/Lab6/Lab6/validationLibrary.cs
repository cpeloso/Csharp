using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab6
{
    class validationLibrary
    {
        //checks for bad words
        public static bool GotBadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };

            foreach (string strBW in strBadWords)
            if(temp.Contains(strBW))
                {
                    result = true;
                }

            return result;
        }


        //checks to see if the string passed is actually an email.
        public static bool IsValidEmail(string temp)
        {
            bool result = false;

            string reg = @"^\w{2,}@\w{2,}\.\w{2,}$";

            if(Regex.IsMatch(temp,reg))
            {
                result = true;
            }

            else
            {
                result = false;
            }

            return result;

        }

        //checks to see if any characters are in the string passed.
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        //checks to see if string passed is longer than the number passed.
        public static bool IsItFilledIn(string temp, int minimumLength)
        {
            bool result = false;

            if (temp.Length < minimumLength)
            {
                result = true;
            }

            return result;
        }

        //checks to see if datetime variable passed is in the future.
        public static bool IsFutureDate(DateTime temp)
        {
            bool result = false;

            if(temp <= DateTime.Now)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        public static bool IsMinimumAmount(double temp, double min)
        {
            bool result = false;

            if(temp >= min)
            {
                result = true;
            }

            else
            {
                result = false;
            }

            return result;
        }

        /*
         * returns a random number, replacing min and max with
         * whatever numbers are given.
         */
        public static int randomNumber(int min = 100, int max = 0)
        {
            Random rnd = new Random();

            int num = rnd.Next(min, max + 1);
            return num;
        }

        //pause function
        public static void Pause()
        {
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }

        //checks to see if a state is entered
        public static bool IsState(string temp)
        {
            bool result = false;

            //I wanted to die typing this out
            string[] stateList = { "Alabama", "Alaska", "Arizona",
                "Arkansas", "California", "Colorado", "Connecticut",
                "Delaware", "Florida", "Georgia", "Hawaii", "Idaho",
                "Illinois", "Iowa", "Kansas", "Kentucky", "Louisiana",
                "Maine", "Maryland", "Massachusetts", "Michigan",
                "Minnesota", "Mississippi", "Missouri", "Montana",
                "Nebraska", "Nevada", "New Hampshire", "New Jersey",
                "New Mexico", "New York", "North Carolina",
                "North Dakota", "Ohio", "Oklahoma", "Oregon",
                "Pennsylvania", "Rhode Island", "South Carolina",
                "South Dakota", "Tennessee", "Texas", "Utah",
                "Vermont", "Virginia", "Washington", "Wisconsin",
                "Wyoming", "District of Columbia" };

            foreach (string temp2 in stateList)
            if (temp.Contains(temp2))
            {
                result = true;
            }

            return result;
        }

        //checks to see if a valid phone number is entered.
        public static bool IsValidPhoneNumber(string temp)
        {
            bool result = false;

            if(temp.Length == 10)
            {
                result = true;
            }

            return result;
        }

        public static bool IsValidZipCode(string temp)
        {
            bool result = false;

            if(temp.Length == 5)
            {
                result = true;
            }

            return result;
        }

        public static bool FaceBookWebsiteCheck(string temp)
        {
            bool result = false;

            string reg = @"^facebook.com\/\w{2,}";
            
            if(Regex.IsMatch(temp,reg))
            {
                result = true;
            }

            return result;
        }
    }
}
