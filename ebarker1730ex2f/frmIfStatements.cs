using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebarker1730ex2f
{
    public partial class frmIfStatements : Form
    {
        public frmIfStatements()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            // #1: if
            // subtotal = Convert.ToDecimal(input1aTextBox.Text);
            // if (subtotal >= 100m)
            //     discountPercent = 0.2m;
            // result1TextBox.Text = discountPercent.ToString("n2");
            result1TextBox.Text = Ex2fCalculations.Calc01(input1aTextBox.Text);

            // #2: if (block)
            //discountPercent = 0m;
            //subtotal = Convert.ToDecimal(input2aTextBox.Text);
            //string status = "Standard rate: ";
            //if (subtotal >= 100m)
            //{
            //    discountPercent = 0.2m;
            //    status = "Bulk rate: ";
            //}
            //result2TextBox.Text = status + discountPercent.ToString("n2");
            result2TextBox.Text = Ex2fCalculations.Calc02(input2aTextBox.Text);

            //// #3: if else
            //discountPercent = 0m;
            //subtotal = Convert.ToDecimal(input3aTextBox.Text);
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            //result3TextBox.Text = discountPercent.ToString("n2");
            result3TextBox.Text = Ex2fCalculations.Calc03(input3aTextBox.Text);

            //// #4: if else if
            //discountPercent = 0m;
            //subtotal = Convert.ToDecimal(input4aTextBox.Text);
            //if (subtotal >= 100m && subtotal < 200m)
            //    discountPercent = 0.2m;
            //else if (subtotal >= 200m && subtotal < 300m)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 300m)
            //    discountPercent = 0.4m;
            //else
            //    discountPercent = 0.1m;
            //result4TextBox.Text = discountPercent.ToString("n2");
            result4TextBox.Text = Ex2fCalculations.Calc04(input4aTextBox.Text);

            //// #5: better range test
            //discountPercent = 0m;
            //subtotal = Convert.ToDecimal(input5aTextBox.Text);
            //if (subtotal >= 300m)
            //    discountPercent = 0.4m;
            //else if (subtotal >= 200m)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            //else
            //    discountPercent = 0.1m;
            //result5TextBox.Text = discountPercent.ToString("n2");
            result5TextBox.Text = Ex2fCalculations.Calc05(input5aTextBox.Text);

            //// #6: nested if else
            //discountPercent = 0m;
            //subtotal = Convert.ToDecimal(input6aTextBox.Text);
            //string customerType = input6bTextBox.Text;
            //if (customerType == "R")
            //{
            //    if (subtotal >= 100m)
            //        discountPercent = 0.2m;
            //    else
            //        discountPercent = 0.1m;
            //}
            //else
            //    discountPercent = 0.4m;
            //result6TextBox.Text = discountPercent.ToString("n2");
            result6TextBox.Text = Ex2fCalculations.Calc06(input6aTextBox.Text, input6bTextBox.Text);

            // #7: validate input
            result7TextBox.Text = Ex2fCalculations.Calc07(input7aTextBox.Text);

            // #8: price * quantity and shipping
            result8TextBox.Text = Ex2fCalculations.Calc08(input8aTextBox.Text, input8bTextBox.Text);

            // #9: difference of meters * rate
            result9TextBox.Text = Ex2fCalculations.Calc09(input9aTextBox.Text, input9bTextBox.Text);

            // #10: divide large # by small #
            result10TextBox.Text = Ex2fCalculations.Calc10(input10aTextBox.Text, input10bTextBox.Text);
        }
    }
}
