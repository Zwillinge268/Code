using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random RN = new Random();
        int num;
        int seqno = 0;

        private void Reset_Click(object sender, EventArgs e)
        {
            num = RN.Next(0, 10);
            this.Text += num + ", ";
            Guess.Text = null;
            PGB.Value = 30;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PGB.Value == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PGB.PerformStep();
                Counter.Text = PGB.Value.ToString();
            }
        }

        private void Guess_TextChanged(object sender, EventArgs e)
        {
            if (Guess.Text == num.ToString())
            {
                timer1.Enabled = false;
                MessageBox.Show("You Win !", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch(comboBox1.SelectedIndex)
                {
                    case 0:

                        pictureBox1.Image = Resource1._1_秋色;

                        break;

                    case 1:

                        pictureBox1.Image = Resource1._2_日落;

                        break;

                    case 2:

                        pictureBox1.Image = Resource1._3_微軟;

                        break;

                    case 3:

                        pictureBox1.Image = Resource1._4_夕陽;

                        break;

                    case 4:

                        pictureBox1.Image = Resource1._5_沙漠;

                        break;
                }
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString(), "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Width = vScrollBar1.Value;
            pictureBox1.Height = vScrollBar1.Value;
            this.Text = ("圖形邊長：" + vScrollBar1.Value + " pixels");
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer2.Interval = hScrollBar1.Value;
            this.Text = ("圖像顯示間隔速度：" + Math.Round((double)hScrollBar1.Value / 1000, 3) + " 秒");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // 1.Randomly
            comboBox1.Text = comboBox1.Items[RN.Next(0, 5)].ToString();

            // 2.Sequentially
            comboBox1.Text = comboBox1.Items[seqno].ToString();
            if (seqno == 4) seqno = 0;
            else seqno++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;
            if (button1.Text == "自動播放") button1.Text = "停止";
            else button1.Text = "自動播放";
        }
    }
}
