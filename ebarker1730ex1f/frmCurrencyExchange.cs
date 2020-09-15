using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebarker1730ex1f
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            btnVietnam.BackgroundImage = picVietnam.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.0000431266";
            lblCurrency.Text = btnVietnam.Text + ": ";
            txtCurrency.Focus();
            txtTotalUSD.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtCurrency.Text = "0.00";
        }

        private void btnVietnam_Click(object sender, EventArgs e)
        {
            btnVietnam.BackgroundImage = picVietnam.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.0000431266";
            lblCurrency.Text = btnVietnam.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnSouthAfrica_Click(object sender, EventArgs e)
        {
            btnSouthAfrica.BackgroundImage = picSouthAfrica.Image;
            btnVietnam.BackgroundImage = picVietnamDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.0592318";
            lblCurrency.Text = btnSouthAfrica.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnBrazil_Click(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            btnVietnam.BackgroundImage = picVietnamDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.182061";
            lblCurrency.Text = btnBrazil.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnFrance_Click(object sender, EventArgs e)
        {
            btnFrance.BackgroundImage = picFrance.Image;
            btnVietnam.BackgroundImage = picVietnamDim.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            txtRate.Text = "1.19581";
            lblCurrency.Text = btnFrance.Text + ": ";
            txtCurrency.Focus();
        }

        private void CalcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnVietnam.BackgroundImage = picVietnam.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.0000431266";
            lblCurrency.Text = btnVietnam.Text + ": ";
            txtCurrency.Focus();
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
        }
    }
}
