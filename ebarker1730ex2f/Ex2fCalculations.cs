using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ebarker1730ex2f
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Convert.ToDecimal(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }
        public static string Calc02(string input)
        {
            // #2: if (block)
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            discountPercent = 0m;
            subtotal = Convert.ToDecimal(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            discountPercent = 0m;
            subtotal = Convert.ToDecimal(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4: if else if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            discountPercent = 0m;
            subtotal = Convert.ToDecimal(input);
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5: better range test
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            discountPercent = 0m;
            subtotal = Convert.ToDecimal(input);
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6: nested if else
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            discountPercent = 0m;
            subtotal = Convert.ToDecimal(inputA);
            string customerType = inputB;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0.0m;
            if (input != "")
            {
                decimal subtotal = Convert.ToDecimal(input);        
                ethereum = (subtotal * 200m);
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            //price times quantity
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal price = Convert.ToDecimal(inputA);
                decimal quantity = Convert.ToDecimal(inputB);
                total = price * quantity;
                if (total < 50m)
                {
                    return (total + 5m).ToString("n2");
                }
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal price = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal meter1 = Convert.ToDecimal(inputA);
                decimal meter2 = Convert.ToDecimal(inputB);
                if (meter2 < meter1)
                {
                    return "Invalid input";
                }
                price = ((meter2 - meter1) * .10m);
                return price.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal george = Convert.ToDecimal(inputA);
                decimal steven = Convert.ToDecimal(inputB);
                if (george > 0m && steven > 0m)
                {
                    if (george >= steven)
                    {
                        total = george/steven;
                        return total.ToString("n2");
                    }
                    if (steven >= george)
                    {
                        total = steven / george;
                        return total.ToString("n2");
                    }
                }
                return "Invalid input";
            }
            return "Invalid input";
        }
    }
}
