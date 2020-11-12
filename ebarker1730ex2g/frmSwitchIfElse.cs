﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebarker1730ex2g
{
    public partial class frmSwitchIfElse : Form
    {
        public frmSwitchIfElse()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 1a) 'Switch' with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1aTextBox.Text);

            // 1b) separate 'if' statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1aTextBox.Text);

            // 1c) if elseif
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1aTextBox.Text);

            // 1d) nested if
            resultNestedIfElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1aTextBox.Text);

            //1e) switch with default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1aTextBox.Text);

            // 1f) separate 'if' statements default
            resultIfDefault01TextBox.Text = Ex2gCalculations.IfDefault01(input1aTextBox.Text);

            // 1g) if elseif defualt
            resultElseIfDefault01TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1aTextBox.Text);

            // 1h) nested if default
            resultNestedIfElseDefault01TextBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1aTextBox.Text);

            // 2a) switch w/o default
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input2aTextBox.Text);

            // 2b) Separate 'if' statements
            resultIf02TextBox.Text = Ex2gCalculations.If02(input2aTextBox.Text);

            // 2c) if elseif
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIf02(input2aTextBox.Text);

            // 2d) Nested if-else
            resultNestedIfElse02TextBox.Text = Ex2gCalculations.NestedIfElse02(input2aTextBox.Text);
        }
    }
}