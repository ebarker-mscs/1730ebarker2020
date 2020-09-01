using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebarker1730ex1d
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VietnamTextChanged(object sender, EventArgs e)
        {
            txtUSDVietnam.Text = (
                Convert.ToDecimal(txtAmountVietnam.Text) * Convert.ToDecimal(txtRateVietnam.Text)
                ).ToString("0.00");
        }

        private void SouthAfricaTextChanged(object sender, EventArgs e)
        {
            txtUSDSouthAfrica.Text = (
                Convert.ToDecimal(txtAmountSouthAfrica.Text) * Convert.ToDecimal(txtRateSouthAfrica.Text)
                ).ToString("0.00");
        }

        private void BrazilTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazil.Text = (
                Convert.ToDecimal(txtAmountBrazil.Text) * Convert.ToDecimal(txtRateBrazil.Text)
                ).ToString("0.00");
        }

        private void FranceTextChanged(object sender, EventArgs e)
        {
            txtUSDFrance.Text = (
                Convert.ToDecimal(txtAmountFrance.Text) * Convert.ToDecimal(txtRateFrance.Text)
                ).ToString("0.00");
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDVietnam.Text) + Convert.ToDecimal(txtUSDSouthAfrica.Text) + Convert.ToDecimal(txtUSDBrazil.Text) + Convert.ToDecimal(txtUSDFrance.Text)
                ).ToString("0.00");
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
