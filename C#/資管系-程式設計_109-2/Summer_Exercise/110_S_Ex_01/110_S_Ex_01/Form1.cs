using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110_S_Ex_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = vScrollBar1.Value;
            this.Text = "間隔 " + (vScrollBar1.Value/1000.0) + "秒";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "正向" || comboBox1.Text == "方向") counter++;
            else counter--;

            if (counter < 0 || counter > 7) counter = 1;

            switch(counter)
            {
                case 0:
                    groupBox1.BackColor = Color.Purple;
                    groupBox1.Text = "紫(Purple)";
                    counter = 7;
                    break;

                case 1:
                    groupBox1.BackColor = Color.Red;
                    groupBox1.Text = "紅(Red)";
                    break;

                case 2:
                    groupBox1.BackColor = Color.Orange;
                    groupBox1.Text = "橙(Orange)";
                    break;

                case 3:
                    groupBox1.BackColor = Color.Yellow;
                    groupBox1.Text = "黃(Yellow)";
                    break;

                case 4:
                    groupBox1.BackColor = Color.Green;
                    groupBox1.Text = "綠(Green)";
                    break;

                case 5:
                    groupBox1.BackColor = Color.Blue;
                    groupBox1.Text = "藍(Blue)";
                    break;

                case 6:
                    groupBox1.BackColor = Color.Indigo;
                    groupBox1.Text = "靛(Indigo)";
                    break;

                case 7:
                    groupBox1.BackColor = Color.Purple;
                    groupBox1.Text = "紫(Purple)";
                    counter = 0;
                    break;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show(this);
        }
    }
}
