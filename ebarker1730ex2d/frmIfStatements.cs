using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebarker1730ex2d
{
    public partial class frmIfStatements : Form
    {
        public frmIfStatements()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";
        }

        private void setFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "fail";
            textBox2ResultA.Text = "fail";
            textBox3ResultA.Text = "fail";
            textBox4ResultA.Text = "fail";
            textBox5ResultA.Text = "fail";
            textBox6ResultA.Text = "fail";
            textBox7ResultA.Text = "fail";
            textBox8ResultA.Text = "fail";
            textBox9ResultA.Text = "fail";
            textBox10ResultA.Text = "fail";

            textBox1ResultB.Text = "success";
            textBox2ResultB.Text = "success";
            textBox3ResultB.Text = "success";
            textBox4ResultB.Text = "success";
            textBox5ResultB.Text = "success";
            textBox6ResultB.Text = "success";
            textBox7ResultB.Text = "success";
            textBox8ResultB.Text = "success";
            textBox9ResultB.Text = "success";
            textBox10ResultB.Text = "success";

            if (textBox1Input.Text == "frank")
                textBox1ResultA.Text = "success";
            if (textBox1Input.Text != "frank")
                textBox1ResultB.Text = "fail";

            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "success";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "fail";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "success";
            if (val4 != false)
                textBox4ResultB.Text = "fail";

            decimal val5A = Convert.ToDecimal(textBox5InputA.Text);
            decimal val5B = Convert.ToDecimal(textBox5InputB.Text);
            if (val5A == val5B)
                textBox5ResultA.Text = "success";
            if (val5A != val5B)
                textBox5ResultB.Text = "fail";

            if (textBox6Input.Text != "jones")
                textBox6ResultA.Text = "success";
            if (textBox6Input.Text == "jones")
                textBox6ResultB.Text = "fail";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 > 0m)
                textBox7ResultA.Text = "success";
            if (val7 <= 0m)
                textBox7ResultB.Text = "fail";

            decimal val8A = Convert.ToDecimal(textBox8InputA.Text);
            decimal val8B = Convert.ToDecimal(textBox8InputB.Text);
            if (val8A < val8B)
                textBox8ResultA.Text = "success";
            if (val8A >= val8B)
                textBox8ResultB.Text = "fail";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 >= 500m)
                textBox9ResultA.Text = "success";
            if (val9 < 500m)
                textBox9ResultB.Text = "fail";

            decimal val10A = Convert.ToDecimal(textBox10InputA.Text);
            decimal val10B = Convert.ToDecimal(textBox10InputB.Text);
            if (val10A <= val10B)
                textBox10ResultA.Text = "success";
            if (val10A > val10B)
                textBox10ResultB.Text = "fail";
        }
    }
}
