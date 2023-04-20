using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_06
{
    public partial class Form1 : Form
    {
        TaiwanID TWID = new TaiwanID();
        Random RN = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_DoubleClick(object sender, EventArgs e)
        {
            Display.ForeColor = Color.Black;
            Display.Clear();

            string ID;
            string Demo = null;
            double V = 0;

            if(! int.TryParse(Number.Text, out int result)) return;
            for (int i = 1; i <= result; i++)
            {
                ID = ((char)RN.Next(65, 91)).ToString() + RN.Next(1, 3);
                for (byte j = 1; j <= 8; j++)
                {
                    ID += RN.Next(0, 10);
                }

                if (TWID.Verify(ID))
                {
                    Demo += i + ". " + ID + "***" + Environment.NewLine;
                    V++;
                }
                else Demo += i + ". " + ID + Environment.NewLine;
            }                
            Display.Text = Demo;
            Display.Text += "======================= \r\n";
            Display.Text += "Valid TWID ratio：" + Math.Round(V/result*100,1) + "%";
        }

        private void Verification_DoubleClick(object sender, EventArgs e)
        {
            if(TWID.Verify(Verification.Text))
            {
                Display.ForeColor = Color.Blue;
                Display.Text = "通過驗證";
            }
            else
            {
                Display.ForeColor = Color.Red;
                Display.Text = "驗證失敗";
            }

        }
    }
}
