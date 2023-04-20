using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_01
{
    public partial class Form1 : Form
    {
        Random RN = new Random();
        Thread T1;
        Thread T2;
        Thread T3;
        int Max;
        int delay;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
        {
            Max = int.Parse(MaxNum.Text);
            delay = int.Parse(Delay.Text);

            if (Max < 7) Max = 7;

            T1 = new Thread(Lotto1);
            T2 = new Thread(Lotto2);
            T3 = new Thread(Lotto3);
            T1.Start();
            T2.Start();
            T3.Start();
        }

        void Lotto1()
        {
            L1.Text = "";
            Ans1.Text = "";

            int[] data = new int[7];

            for (int i = 0; i < data.Length; i++) 
            {
                int lotto = RN.Next(1, Max + 1);

                while(true)
                {
                    bool flag = false;
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (data[j] == lotto)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        L1.Text += lotto + "* ";
                        lotto = RN.Next(1, Max + 1);
                        Thread.Sleep(delay);
                    }
                    else break;
                }

                data[i] = lotto;
                L1.Text += lotto + " ";
                Thread.Sleep(delay);
            }

            for (int i = 0; i < data.Length; i++)
            {
                Ans1.Text += data[i] + " ";
            }

            T1.Abort();
        }

        void Lotto2()
        {
            L2.Text = "";
            Ans2.Text = "";

            int[] data = new int[7];

            for (int i = 0; i < data.Length; i++)
            {
                int lotto = RN.Next(1, Max + 1);

                while (true)
                {
                    bool flag = false;
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (data[j] == lotto)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        L2.Text += lotto + "* ";
                        lotto = RN.Next(1, Max + 1);
                        Thread.Sleep(delay);
                    }
                    else break;
                }

                data[i] = lotto;
                L2.Text += lotto + " ";
                Thread.Sleep(delay);
            }

            for (int i = 0; i < data.Length; i++)
            {
                Ans2.Text += data[i] + " ";
            }

            T2.Abort();
        }

        void Lotto3()
        {
            L3.Text = "";
            Ans3.Text = "";

            int[] data = new int[7];

            for (int i = 0; i < data.Length; i++)
            {
                int lotto = RN.Next(1, Max + 1);

                while (true)
                {
                    bool flag = false;
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (data[j] == lotto)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        L3.Text += lotto + "* ";
                        lotto = RN.Next(1, Max + 1);
                        Thread.Sleep(delay);
                    }
                    else break;
                }

                data[i] = lotto;
                L3.Text += lotto + " ";
                Thread.Sleep(delay);
            }

            for (int i = 0; i < data.Length; i++)
            {
                Ans3.Text += data[i] + " ";
            }

            T3.Abort();
        }
    }
}
