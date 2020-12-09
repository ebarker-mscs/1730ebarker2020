using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebarker1730ex3b
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, decimal months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, decimal months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            //c=(f-32)*5/9
            double celsius = ((fahrenheit - 32) * (5 / 9));

            return celsius;
        }

        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            //f=c*(9/5) +32
            fahrenheit = ((celsius * (5 / 9)) + 32);
        }

        public static decimal GrossPay(decimal hours, decimal rate)
        {
            //if hours <=40 = hours * rate
            // if hours >40 = (40*rate) + (hours-40 * 1.5)
            decimal pay = 0m;
            if (hours <= 40m)
                pay = hours * rate;
            if (hours > 40m)
            {
                pay = ((40m * rate) + ((hours - 40m) * 1.5m));
            }

            return pay;
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            return total;
        }

        public static decimal GrossPay_String_10(string strNumbers, decimal rate)
        {
            decimal grossPay = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                decimal totalHours = Decimal.Parse(strNumbers);
                grossPay = totalHours * rate;
                startIndex = endIndex + 1;
            }

            return grossPay;
        }
    }
}
