using System;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var v = GetValue(tbValue.Text);

            try
            {
                lblResult.Text =
                    v > 0 ? Program.GetFact(v).ToString() : "invalid";
            }
            catch (OverflowException)
            {
                lblResult.Text = "int overflow";
            }
        }

        private int GetValue(string value)
        {
            var output = -1;
            var msg = "";

            if (value.Equals(""))
            {
                msg = "The value cannot be empty";
            }

            try
            {
                output = int.Parse(value);
            }
            catch (FormatException)
            {
                msg = "Cannot convert the value.";
            }

            if (output < 1)
            {
                msg = "The value cannot be less than zero or equal to zero.";
            }

            if (output > 0) return output;

            MessageBox.Show(
                msg,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            tbValue.SelectAll();
            tbValue.Focus();
            return -1;
        }
    }
}