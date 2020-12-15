using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebarker1730ex3c
{
     public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (index >= 1 && index < 8)
                return days.ToString();

            return "Invalid index";
        }

        public static string Calc1(string index)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };

            return "";
        }

        public static int Calc2(int[] index)
        {
            return 0;
        }
        public static double Calc3(double[] index1, int index2)
        {
            return 0.0;
        }
        public static double Calc5(double[] index)
        {
            return 0.0;
        }

        public static double[] Calc6(double[] numbers)
        {
            return new double[10];
        }
    }
}
