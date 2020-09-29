using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebarker1730ex2b
{
    public partial class frmex2b : Form
    {
        public frmex2b()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountVietnam = Convert.ToDecimal(txtAmountVietnam.Text);
            decimal rateVietnam = Convert.ToDecimal(txtRateVietnam.Text);
            decimal usdVietnam = amountVietnam * rateVietnam;
            txtUSDVietnam.Text = usdVietnam.ToString("0.00");

            decimal amountSouthAfrica = Convert.ToDecimal(txtAmountSouthAfrica.Text);
            decimal rateSouthAfrica = Convert.ToDecimal(txtRateSouthAfrica.Text);
            decimal usdSouthAfrica = amountSouthAfrica * rateSouthAfrica;
            txtUSDSouthAfrica.Text = usdSouthAfrica.ToString("0.00");

            decimal amountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal rateBrazil = Convert.ToDecimal(txtRateBrazil.Text);
            decimal usdBrazil = amountBrazil * rateBrazil;
            txtUSDBrazil.Text = usdBrazil.ToString("0.00");

            decimal amountFrance = Convert.ToDecimal(txtAmountFrance.Text);
            decimal rateFrance = Convert.ToDecimal(txtRateFrance.Text);
            decimal usdFrance = amountFrance * rateFrance;
            txtUSDFrance.Text = usdFrance.ToString("0.00");

            decimal totalUSD = usdVietnam + usdSouthAfrica + usdBrazil + usdFrance;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountVietnam.Text = "0.00";
            txtRateVietnam.Text = "0.0000431266";
            txtAmountSouthAfrica.Text = "0.00";
            txtRateSouthAfrica.Text = "0.0592318";
            txtAmountBrazil.Text = "0.00";
            txtRateBrazil.Text = "0.182061";
            txtAmountFrance.Text = "0.00";
            txtRateFrance.Text = "1.19581";
        }
    }
}
