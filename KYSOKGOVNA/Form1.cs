using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYSOKGOVNA
{
    public partial class Form1 : Form
    {
        int j = 0;
        string i;
        string stroka;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (j)
            {
                case 1:
                    if (label1.Text == "0")
                    {
                        MessageBox.Show("Дурак совсем?");
                        Environment.Exit(0);
                    }
                    stroka = label2.Text + " / " + label1.Text + " = " + Convert.ToString((Convert.ToDouble(label2.Text) / Convert.ToDouble(label1.Text)));
                    label1.Text = stroka;
                    break;
                case 2:
                    stroka = label2.Text + " * " + label1.Text + " = " + Convert.ToString((Convert.ToDouble(label2.Text) * Convert.ToDouble(label1.Text)));
                    label1.Text = stroka;
                    break;
                case 3:
                    stroka = label2.Text + " - " + label1.Text + " = " + Convert.ToString((Convert.ToDouble(label2.Text) - Convert.ToDouble(label1.Text)));
                    label1.Text = stroka;
                    break;
                case 4:
                    stroka = label2.Text + " + " + label1.Text + " = " + Convert.ToString((Convert.ToDouble(label2.Text) + Convert.ToDouble(label1.Text)));
                    label1.Text = stroka;
                    break;
                case 5:
                    stroka = "√" + label1.Text + " = " + Convert.ToString(Math.Sqrt(Convert.ToDouble(label1.Text)));
                    label1.Text = stroka;
                    break;
                case 6:
                    stroka = label1.Text + "^2" + " = " + Convert.ToString(Math.Pow((Convert.ToDouble(label1.Text)), 2));
                    label1.Text = stroka;
                    break;
                case 7:
                    stroka = label1.Text + "^" + label2.Text + " = " + Convert.ToString(Math.Pow((Convert.ToDouble(label1.Text)), (Convert.ToDouble(label2.Text))));
                    label1.Text = stroka;
                    break;
                case 8:
                    stroka = "SIN" + label1.Text + " = " + Convert.ToString(Math.Sin((Convert.ToDouble(label2.Text))));
                    label1.Text = stroka;
                    break;
                case 9:
                    stroka = "COS" + label1.Text + " = " + Convert.ToString(Math.Cos((Convert.ToDouble(label2.Text))));
                    label1.Text = stroka;
                    break;
                case 10:
                    stroka = "TG" + label1.Text + " = " + Convert.ToString(Math.Tan((Convert.ToDouble(label2.Text))));
                    label1.Text = stroka;
                    break;
                case 11:
                    stroka = "CTG" + label1.Text + " = " + Convert.ToString(1.0 / Math.Tan((Convert.ToDouble(label2.Text))));
                    label1.Text = stroka;
                    break;
            }
            label2.Text = "";
            label3.Text = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "/";
            label1.Text = "";
            j = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "*";
            label1.Text = "";
            j = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "-";
            label1.Text = "";
            j = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "+";
            label1.Text = "";
            j = 4;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "√";
            j = 5;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = "";
            label3.Text = "^2";
            j = 6;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "^" + label1.Text;
            label1.Text = "";
            j = 7;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "SIN";
            label1.Text = "";
            j = 8;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "COS";
            label1.Text = "";
            j = 9;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "TG";
            label1.Text = "";
            j = 10;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDouble(label1.Text));
            var i = label1.Text;
            label2.Text = i;
            label3.Text = "CTG";
            label1.Text = "";
            j = 11;
        }
    }
}
