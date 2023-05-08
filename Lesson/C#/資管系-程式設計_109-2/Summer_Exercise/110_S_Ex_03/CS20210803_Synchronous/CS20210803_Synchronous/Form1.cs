using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS20210803_Synchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton1.Checked) this.Text = radioButton1.Text;
            //if (radioButton2.Checked) this.Text = radioButton2.Text;
            //if (radioButton3.Checked) this.Text = radioButton3.Text;
            //if (radioButton4.Checked) this.Text = radioButton4.Text;

            RadioButton RB = sender as RadioButton;
            this.Text = RB.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(int.Parse(counter.Text) == 0)
            {
                if (Red.Checked) Green.Checked = true;
                else if (Yellow.Checked) Red.Checked = true;
                else Yellow.Checked = true;
            }
            else
            {
                counter.Text = (int.Parse(counter.Text) - 1).ToString();
            }
            if (counter.Text == "5" && Red.Checked) KYellow.Checked = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = null;
            if (checkBox1.Checked) this.Text += checkBox1.Text + " ; ";
            if (checkBox2.Checked) this.Text += checkBox2.Text + " ; ";
            if (checkBox3.Checked) this.Text += checkBox3.Text + " ; ";
            if (checkBox4.Checked) this.Text += checkBox4.Text + " ; ";
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            if(Red.Checked)
            {
                counter.Text = "20";
                KGreen.Checked = true;
            }
        }

        private void Yellow_CheckedChanged(object sender, EventArgs e)
        {
            if (Yellow.Checked)
            {
                counter.Text = "5";
                KRed.Checked = true;
            }
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            if (Green.Checked)
            {
                counter.Text = "20";
                KRed.Checked = true;
            }
        }
    }
}
