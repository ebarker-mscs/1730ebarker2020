using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ebarker1730ex2h
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                TimeSpan timeTillDue = dateA.Subtract(dateB);
                int dueDate = timeTillDue.Days;
                return dueDate.ToString(dueDate + " days");
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                if (dateA > dateB)
                {
                    TimeSpan timeTillDue = dateA.Subtract(dateB);
                    int dueDate = timeTillDue.Days;
                    return dueDate.ToString(dueDate + " days past due");
                }
                return "On time";
            }
            catch { }

            return result;
        }
        public static string StringCalc01(string s) 
        {
            string result = s;
            if (result != "")
            {
                result = result.Trim();
                result = result.Remove(0, 1);
                result = result.Insert(0, "cr");
                return result;
            }

            return "Invalid input";
        }
        public static string StringCalc02(string s)
        {
            string result = s;
            if (result != "")
            {
                result = result.Trim();
                result = result.Remove(1, 1);
                result = result.Insert(1, "rit");
                return result;
            }
            
            return "Invalid input";
        }
        public static string StringCalc03(string s)
        {
            string result = s;
            if (result != "")
            {
                result = result.Trim();
                result = result.Substring(2, 4).ToUpper();
                return result;
            }
            
            return "Invalid input";
        }
        public static string StringCalc04(string s)
        {
            string result = s;
            if (result != "")
            {
                result = result.Trim();
                char pad = '*';
                result = result.PadLeft(10, pad);
                return result;
            }

            return "Invalid input";
        }
        public static string StringCalc05(string s)
        {
            string result = s;
            if (result != "")
            {
                result = result.Trim();
                result = result.Replace("(", "");
                result = result.Replace(")", "");
                result = result.Replace(" ", "");
                result = result.Replace("-", "");
                return result;
            }

            return "Invalid input";
        }
        public static string StringCalc06(string s)
        {
            string result = s;
            if (result != "")
            {
                result = result.Trim();
                result = result.Replace("(", "");
                result = result.Replace(")", "");
                result = result.Replace(" ", "");
                result = result.Replace("-", "");
                result = result.Insert(3, ".");
                result = result.Insert(7, ".");
                return result;
            }

            return "Invalid input";
        }
        public static string StringCalc07(string s)
        {
            string address = s;
            if (address != "")
            {
                address = address.Trim();
                string[] columns = address.Split(' ');
                string number = columns[0];
                string street = columns[1];
                string direction = columns[2];
                if (street.ToLower() == "pioneer")
                    return "Found";
                if (street.ToLower() != "pioneer")
                    return "Not found";
            }
           
            return "Invalid input";
        }
        public static string StringCalc08(string s)
        {
            string address = s;
            if (address != "")
            {
                address = address.Trim();
                int cityindex = address.IndexOf(", ") + 1;
                string city = address.Substring(cityindex);
                return city;
            }

            return "Invalid input";
        }
        public static string StringCalc09(string s)
        {
            string address = s;
            if (address != "")
            {
                address = address.Trim();
                int zipindex = address.LastIndexOf(" ");
                string zip = address.Substring(zipindex);
                return zip;
            }

            return "Invalid input";
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            string address = sb.Append((s1 + ", ") + (s2 + ", ") + s3).ToString();
            
            return address;
        }
    }
}