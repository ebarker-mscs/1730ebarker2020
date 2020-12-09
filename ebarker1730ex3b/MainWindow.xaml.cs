using System;
using System.Windows;

namespace ebarker1730ex3b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //0
            try
            {
                decimal subtotal = Decimal.Parse(inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch 
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox0a);
            }

            //1
            try
            {
                decimal subtotal = Decimal.Parse(inputTextBox1a.Text);
                decimal discountPercent;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox1a);
            }

            //2
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox2a.Text + this.inputTextBox2b.Text + this.inputTextBox2c.Text);
            }

            //3
            try
            {
                int months = Int32.Parse(this.inputTextBox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox3b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox3c.Text);
                decimal futureValue = 0m; 
                Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox3a.Text + this.inputTextBox3b.Text + this.inputTextBox3c.Text);
            }

            //4
            try
            {
                double fahrenheit = Double.Parse(inputTextBox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenheit);
                resultTextBox4.Text = celsius.ToString("0.0");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox4a);
            }

            //5
            try
            {
                double celsius = Double.Parse(inputTextBox5a.Text);
                double fahrenheit = 0.0; 
                Ex3bCalculations.CelsiusToFahrenheit(celsius, out fahrenheit);
                resultTextBox5.Text = fahrenheit.ToString("0.0");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox4a);
            }

            //6
            try
            {
                decimal hours = Decimal.Parse(this.inputTextBox6a.Text);
                decimal rate = Decimal.Parse(this.inputTextBox6b.Text);
                decimal pay = Ex3bCalculations.GrossPay(hours, rate);
                resultTextBox6.Text = pay.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox6a.Text + this.inputTextBox6b.Text);
            }

            //7
            try
            {
                this.resultTextBox7.Text = Ex3bCalculations.TotalHours(this.inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                this.resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox7a.Text);
            }

            //8
            try
            {
                string totalHours = inputTextBox8a.Text;
                decimal rate = decimal.Parse(inputTextBox8b.Text);
                this.resultTextBox8.Text = Ex3bCalculations.GrossPay_String_10(totalHours, rate).ToString("n2");
            }
            catch
            {
                this.resultTextBox8.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox8a.Text + this.inputTextBox8b.Text);
            }
        }
    }
}
