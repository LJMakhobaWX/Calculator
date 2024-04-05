using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Calculator
{
    public partial class Calculator : Form
    {
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
            if(txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Trim('-');   
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text; 
            }
        }
    }
}
