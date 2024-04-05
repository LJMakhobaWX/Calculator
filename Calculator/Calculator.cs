using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string Operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text += "0";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Trim('-');
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            Operators = "-";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            Operators = "+";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            Operators = "/";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            Operators = "*";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            Operators = "%";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (Operators)
            {
                case "-":
                    valueSecond = decimal.Parse(txtDisplay.Text);
                    Result = valueFirst - valueSecond;
                    txtDisplay.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(txtDisplay.Text);
                    Result = valueFirst + valueSecond;
                    txtDisplay.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(txtDisplay.Text);
                    Result = valueFirst * valueSecond;
                    txtDisplay.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(txtDisplay.Text);
                    Result = valueFirst / valueSecond;
                    txtDisplay.Text = Result.ToString();
                    break;
                case "%":
                    valueSecond = decimal.Parse(txtDisplay.Text);
                    Result = valueFirst % valueSecond;
                    txtDisplay.Text = Result.ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            txtDisplay.Text = "0";
        }
    }
}
