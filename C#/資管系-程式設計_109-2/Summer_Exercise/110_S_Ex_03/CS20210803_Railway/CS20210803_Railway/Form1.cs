using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS20210803_Railway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == true)
            {
                start.Text = "結束";
                stop.Checked = true;
                Y.Checked = true;               
                go.Enabled = true;
                Y.Enabled = true;
                G.Enabled = true;
                this.Text = "噹噹噹噹...";
            }
            else
            {
                start.Text = "模擬";
                Y.Enabled = false;
                G.Enabled = false;
                go.Enabled = false;
                groupBox2.Text = "10";
                this.Text = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(groupBox2.Text == "0")
            {
                if (Y.Checked == true) R.Checked = true;
                else if (R.Checked == true) G.Checked = true;
                else Y.Checked = true;
            }
            else
            {
                groupBox2.Text = (int.Parse(groupBox2.Text) - 1).ToString();
            }           
        }

        private void Y_CheckedChanged(object sender, EventArgs e)
        {
            if(Y.Checked == true)
            {
                groupBox2.Text = "10";
                this.Text = "噹噹噹噹...";
                go_CheckedChanged(null, null);
            }
        }

        private void R_CheckedChanged(object sender, EventArgs e)
        {
            if (R.Checked == true)
            {
                groupBox2.Text = "5";
                this.Text = null;
                go_CheckedChanged(null, null);
            }
        }

        private void G_CheckedChanged(object sender, EventArgs e)
        {
            if (G.Checked == true)
            {
                groupBox2.Text = "15";
                this.Text = null;
            }
        }

        private void go_CheckedChanged(object sender, EventArgs e)
        {
            if (go.Checked == true)
            {
                if(Y.Checked == true)
                {
                    MessageBox.Show("小心火車，停步回頭!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stop.Checked = true;
                }
                else if(R.Checked == true)
                {
                    start_Click(null, null);
                    MessageBox.Show("悲劇...生命不能重來!!", "哀悼", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
        }
    }
}
