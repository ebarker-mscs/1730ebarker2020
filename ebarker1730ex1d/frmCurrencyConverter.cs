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

        }
    }
}
