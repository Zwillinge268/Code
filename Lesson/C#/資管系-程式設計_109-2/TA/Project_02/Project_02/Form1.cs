using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool IsNumber(string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void cal1_Click(object sender, EventArgs e)
        {
            if(A1.Text != "" && A2.Text != "")
            {
                if(IsNumber(A1.Text) && IsNumber(A2.Text))
                {
                    A3.Text = "";
                    A3.Text += int.Parse(A1.Text) + int.Parse(A2.Text);
                }
                else
                {
                    MessageBox.Show("Please enter number");
                }
            }
        }

        private void cal2_Click(object sender, EventArgs e)
        {
            if (B1.Text != "" && B2.Text != "")
            {
                if (IsNumber(A1.Text) && IsNumber(A2.Text))
                {
                    B3.Text = "";
                    B3.Text += int.Parse(B1.Text) - int.Parse(B2.Text);
                }
                else
                {
                    MessageBox.Show("Please enter number");
                }
            }
        }

        private void cal3_Click(object sender, EventArgs e)
        {
            if (C1.Text != "" && C2.Text != "")
            {
                if (IsNumber(C1.Text) && IsNumber(C2.Text))
                {
                    C3.Text = "";
                    C3.Text += int.Parse(C1.Text) * int.Parse(C2.Text);
                }
                else
                {
                    MessageBox.Show("Please enter number");
                }
            }
        }

        private void cal4_Click(object sender, EventArgs e)
        {
            if (D1.Text != "" && D2.Text != "")
            {
                if (IsNumber(D1.Text) && IsNumber(D2.Text))
                {
                    D3.Text = "";
                    D3.Text += int.Parse(D1.Text) / int.Parse(D2.Text);
                }
                else
                {
                    MessageBox.Show("Please enter number");
                }
            }
        }
    }
}
