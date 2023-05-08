using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte TB = 0;
                if (((TextBox)sender).Name == "TB1")
                {
                    TB = byte.Parse(TB1.Text);
                }
                else if (((TextBox)sender).Name == "TB2")
                {
                    TB = byte.Parse(TB2.Text);
                }
                else if (((TextBox)sender).Name == "Result")
                {
                    TB = byte.Parse(Result.Text);
                }

                string TD = null;
                for (byte i = 0; i < 8; i++)
                {
                    TD = (TB % 2).ToString() + TD;
                    TB = (byte)(TB >> 1);
                }

                if (((TextBox)sender).Name == "TB1")
                {
                    TD1.Text = TD;
                }
                else if (((TextBox)sender).Name == "TB2")
                {
                    TD2.Text = TD;
                }
                else if (((TextBox)sender).Name == "Result")
                {
                    textBox3.Text = TD;
                }
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString(), "提示信息",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch(comboBox1.SelectedIndex)
                {
                    case 0:
                        Result.Text = (byte.Parse(TB1.Text) << byte.Parse(TB2.Text)).ToString();
                        break;

                    case 1:
                        Result.Text = (byte.Parse(TB1.Text) >> byte.Parse(TB2.Text)).ToString();
                        break;

                    case 2:
                        textBox3.Clear();
                        for (int i = 0; i < TD1.Text.Length; i++)
                        {
                            if (TD1.Text.Substring(i, 1) == "0") textBox3.Text += 1;
                            else textBox3.Text += 0;
                        }
                        break;

                    case 3:
                        Result.Text = (byte.Parse(TB1.Text) & byte.Parse(TB2.Text)).ToString();
                        break;

                    case 4:
                        Result.Text = (byte.Parse(TB1.Text) | byte.Parse(TB2.Text)).ToString();
                        break;

                    case 5:
                        Result.Text = (byte.Parse(TB1.Text) ^ byte.Parse(TB2.Text)).ToString();
                        break;

                    case 6:
                        TB1.Text = (byte.Parse(TB1.Text) ^ byte.Parse(TB2.Text)).ToString();
                        TB2.Text = (byte.Parse(TB1.Text) ^ byte.Parse(TB2.Text)).ToString();
                        TB1.Text = (byte.Parse(TB1.Text) ^ byte.Parse(TB2.Text)).ToString();
                        break;
                }
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString(), "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
