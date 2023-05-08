using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_03
{
    public partial class Form1 : Form
    {
        Random RN = new Random();
        bool IsStart;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            IsStart = timer1.Enabled;
            if(timer1.Enabled == true)
            {
                Start.Text = "停止";
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent;
                button6.BackColor = Color.Transparent;
                button7.BackColor = Color.Transparent;
                button8.BackColor = Color.Transparent;
                button9.BackColor = Color.Transparent;
                label1.Text = "?";
                label2.Text = "?";
                label3.Text = "?";
                label4.Text = "?";
            }
            else
            {
                Start.Text = "開始";

                if(int.Parse(button2.Text) < int.Parse(button3.Text))
                {
                    button2.BackColor = Color.IndianRed;
                    button3.BackColor = Color.LightGreen;
                    label1.Text = "<";
                }
                else if(int.Parse(button2.Text) > int.Parse(button3.Text))
                {
                    button2.BackColor = Color.LightGreen;
                    button3.BackColor = Color.IndianRed;
                    label1.Text = ">";
                }
                else
                {
                    button2.BackColor = Color.LightYellow;
                    button3.BackColor = Color.LightYellow;
                    label1.Text = "=";
                }

                if (int.Parse(button4.Text) < int.Parse(button5.Text))
                {
                    button4.BackColor = Color.IndianRed;
                    button5.BackColor = Color.LightGreen;
                    label2.Text = "<";
                }
                else if (int.Parse(button4.Text) > int.Parse(button5.Text))
                {
                    button4.BackColor = Color.LightGreen;
                    button5.BackColor = Color.IndianRed;
                    label2.Text = ">";
                }
                else
                {
                    button4.BackColor = Color.LightYellow;
                    button5.BackColor = Color.LightYellow;
                    label2.Text = "=";
                }

                if (int.Parse(button6.Text) < int.Parse(button7.Text))
                {
                    button6.BackColor = Color.IndianRed;
                    button7.BackColor = Color.LightGreen;
                    label3.Text = "<";
                }
                else if (int.Parse(button6.Text) > int.Parse(button7.Text))
                {
                    button6.BackColor = Color.LightGreen;
                    button7.BackColor = Color.IndianRed;
                    label3.Text = ">";
                }
                else
                {
                    button6.BackColor = Color.LightYellow;
                    button7.BackColor = Color.LightYellow;
                    label3.Text = "=";
                }

                if (int.Parse(button8.Text) < int.Parse(button9.Text))
                {
                    button8.BackColor = Color.IndianRed;
                    button9.BackColor = Color.LightGreen;
                    label4.Text = "<";
                }
                else if (int.Parse(button8.Text) > int.Parse(button9.Text))
                {
                    button8.BackColor = Color.LightGreen;
                    button9.BackColor = Color.IndianRed;
                    label4.Text = ">";
                }
                else
                {
                    button8.BackColor = Color.LightYellow;
                    button9.BackColor = Color.LightYellow;
                    label4.Text = "=";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Text = RN.Next(1, 21).ToString();
            button3.Text = RN.Next(1, 21).ToString();
            button4.Text = RN.Next(1, 21).ToString();
            button5.Text = RN.Next(1, 21).ToString();
            button6.Text = RN.Next(1, 21).ToString();
            button7.Text = RN.Next(1, 21).ToString();
            button8.Text = RN.Next(1, 21).ToString();
            button9.Text = RN.Next(1, 21).ToString();
        }

        private void Pause_MouseEnter(object sender, EventArgs e)
        {
            Pause.BackColor = Color.Gold;
            timer1.Enabled = false;
        }

        private void Pause_MouseLeave(object sender, EventArgs e)
        {
            Pause.BackColor = Color.Transparent;

            if(IsStart == true)
            {
                timer1.Enabled = true;
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
