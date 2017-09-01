using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblDisplay.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblDisplay.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Arithmatic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblDisplay.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
               

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double based = results;
            double power = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = (Math.Pow(based, power)).ToString();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Double a;
            Double b;
            a = Convert.ToDouble(txtDisplay.Text);
            b = Convert.ToDouble(txtDisplay.Text) - 1;
            if (a >= 1)
            {
                for (double i = a; i <= a; i++)
                {
                    a = a * i;
                    txtDisplay.Text = System.Convert.ToString(a);
                }
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (-1 * Double.Parse(txtDisplay.Text)).ToString();
        }

        private void lblDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
