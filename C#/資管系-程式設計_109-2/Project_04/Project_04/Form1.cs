using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project_04
{
    public partial class IMAB : Form
    {
        public IMAB()
        {
            InitializeComponent();
        }

        Random Rn = new Random();
        bool SC = false;
        Thread threadA, threadB;
        byte A, B;

        private void IMAB_Load(object sender, EventArgs e)
        {
            Display.Text = DateTime.Now.ToString();
            this.Text = "資一甲乙(MultiTHreading): " + DateTime.Now.ToString();
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void Display_MouseEnter(object sender, EventArgs e)
        {
            Display.Text = "資一甲乙班大隊接力賽";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Display.Text = DateTime.Now.ToString();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if(timer1.Enabled == true)
            {
                Switch.Text = "Off";
                Switch.BackColor = Color.LightGreen;
                Switch.ForeColor = Color.Blue;
            }            
            else
            {
                Switch.Text = "On";
                Switch.BackColor = Color.Red;
                Switch.ForeColor = Color.Yellow;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            SC = !SC;
            if (SC == true)
            {
                Start.Text = "取消";
                Start.BackColor = Color.Red;
                A = 0; B = 0;
                start();
            }
            else
            {
                Start.Text = "開始";
                Start.BackColor = Color.LightGreen;
                DisplayA.Text = ""; DisplayB.Text = "";
                threadA.Abort(); threadB.Abort();
            }
        }

        private void IMA()
        {
            while(true)
            {
                Thread.Sleep(Rn.Next(0, int.Parse(SleepTime.Text)));
                A++;
                DisplayA.Text += "資一甲(" + A + ") : " + DateTime.Now + Environment.NewLine;

                if (A == int.Parse(Nth.Text))
                {
                    threadB.Abort();
                    DisplayA.Text += "Winner is 資一甲";
                    threadA.Abort();
                }
            }
        }

        private void Nth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.Text = e.KeyChar.ToString();
            }
        }

        private void SleepTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                this.Text = e.KeyChar.ToString();
            }
        }

        private void Nth_TextChanged(object sender, EventArgs e)
        {
            if (!byte.TryParse(Nth.Text, out byte result)) Nth.Text = "5";
            if (result == 0) Nth.Text = "5";
        }

        private void SleepTime_TextChanged(object sender, EventArgs e)
        {
            if (!uint.TryParse(SleepTime.Text, out uint result)) SleepTime.Text = "5000";
        }

        private void IMAB_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Goodbye", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IMAB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void IMB()
        {
            while (true)
            {
                Thread.Sleep(Rn.Next(0, int.Parse(SleepTime.Text)));
                B++;
                DisplayB.Text += "資一乙(" + B + ") : " + DateTime.Now + Environment.NewLine;

                if (B == int.Parse(Nth.Text))
                {
                    threadA.Abort();
                    DisplayB.Text += "Winner is 資一乙";
                    threadB.Abort();
                }
            }
        }

        private void start()
        {
            threadA = new Thread(new ThreadStart(IMA));
            threadB = new Thread(new ThreadStart(IMB));
            threadA.Start();
            threadB.Start();
        }
    }
}
