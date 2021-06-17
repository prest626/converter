using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class Form1 : Form
    {
       string op = "";
        string box1 = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void numClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string input = boxOne.Text;

            if (input == "0")
            {
                input = "";
            }
            input = input + button.Text;
            boxOne.Text = input;
        }





        private void boxClear(object sender, EventArgs e)
        {
            boxOne.Text = "0";
            op = "";
        }

        private void cmClick(object sender, EventArgs e)
        {

        }

        private void eq1Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string input = boxOne.Text;
            if (op == "")
            {
                op = button.Text;
            }

            switch (op)
            {
                case "CM":
                    answer.Text = Convert.ToString(Convert.ToDouble(boxOne.Text) / 30.48);
                    break;
                case "FEET":
                    answer.Text = Convert.ToString(Convert.ToDouble(boxOne.Text) * 12);
                    break;
                case "OUNCE":
                    Convert.ToString(Convert.ToDouble(boxOne.Text) / 35.274);
                    break;
                case "CELCIUS":
                    Convert.ToString(Convert.ToDouble(boxOne.Text) / 22222);
                    break;
            
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
