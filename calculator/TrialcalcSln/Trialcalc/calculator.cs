using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trialcalc
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt.Text += button9.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt.Text += button3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text += button1.Text;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt.Text += button8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt.Text += button10.Text;
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            if(txt.Text!="" && lblLast.Text!="" && lblFirst.Text!="")
            {
                string fn = lblFirst.Text;
                string ln = txt.Text;
                double f = Double.Parse(fn);
                Double s = Double.Parse(ln);
                Double result;
                switch(lblLast.Text)
                {
                    case "+":
                        result = f + s;
                        txt.Text=result +"";

                        break;

                    case "-":
                        result = f - s;
                        txt.Text = result + "";
                        break;

                    case "*":
                        result = f * s;
                        txt.Text = result + "";
                        break;

                    case "/":
                        double r = (f+0.0) / s;
                        txt.Text = r + "";
                        break;

                }
                lblLast.Text = lblFirst.Text = "";
            }
        }

       
        private void button11_Click(object sender, EventArgs e)
        {

            if (button11.Text == ".")
            {
                if (!txt.Text.Contains("."))
                {
                    txt.Text = txt.Text + button11.Text;

                }
            }
            else
            {
                txt.Text = txt.Text + button11.Text;
            }
        }
        private void btnOptAll_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            lblFirst.Text=txt.Text;
            lblLast.Text=btn.Text;
            txt.Text="";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt.Clear(); 
        } 
    }
}
