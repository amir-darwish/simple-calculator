using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float Calcul(string input)
        {
            input = input.Replace(" ", "").Replace("x", "*");

            List<string> tokens = new List<string>();
            string current = "";
            foreach(char c in input)
            {
                if ("+-*/".Contains(c))
                {
                    //add and clear current after adding operaetor
                    tokens.Add(current);
                    tokens.Add(c.ToString());
                    current = "";
                }
                else
                {
                    current += c;
                }

            }
            if (current != "")
                {
                    tokens.Add(current);
                }
            float result = float.Parse(tokens[0]);

            for (int i = 1; i<tokens.Count; i += 2)
            {
                string op = tokens[i];
                float next = float.Parse(tokens[i + 1]);

                switch (op)
                {
                    case "+":
                        result += next;
                        break;
                    case "-":
                        result -=next;
                        break;
                    case "*":
                        result *= next;
                        break;
                    default:
                        result /= next;
                        break;
                }
              

            }

            return result;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            lbInput.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbInput.Text += "1";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lbInput.Text != "")
                lbInput.Text += " + ";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            lbInput.Text += " . ";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbInput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbInput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lbInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbInput.Text += "9";
        }

        private void btnMince_Click(object sender, EventArgs e)
        {
            lbInput.Text += " - ";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (lbInput.Text != "")
                lbInput.Text += " x ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
                lbInput.Text = "";
        }

        private void btnDivise_Click(object sender, EventArgs e)
        {
            if (lbInput.Text != "")
                lbInput.Text += " / ";
        }

        private void btnEgale_Click(object sender, EventArgs e)
        {
            lbInput.Text = lbInput.Text + " = " + Calcul(lbInput.Text).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a trial version of the calculator. Complex expressions are not supported.\n\n Developped By AMIR \n github.com/amir-darwish ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
