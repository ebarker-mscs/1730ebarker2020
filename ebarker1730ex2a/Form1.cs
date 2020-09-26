using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebarker1730ex2a
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountpercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal discountamount = (subtotal * discountpercent) / 100;
            decimal total = subtotal - discountamount;
            txtDiscountAmount.Text = discountamount.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
