using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;


namespace Exercise
{
    public partial class Form1 : Form
    {
        Random RN = new Random();
        string ID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string date1 = "甲" + DateTime.Today.ToString("MMdd");
            string date2 = "乙" + DateTime.Today.ToString("MMdd");
            string password = VB.Interaction.InputBox("請輸入密碼(甲/乙月日)", "密碼管控");

            if (date1 != password && date2 != password) Close();
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
            idDisplay.Items.Clear();
            idDisplay.Items.Add("身份證字號");
            if (!int.TryParse(num.Text, out int number)) num.Text = "0";

            for (int i = 0; i < int.Parse(num.Text); i++)
            {
                ID = (i+1) + ".";
                ID += ((char)RN.Next(65, 91)).ToString() + RN.Next(1, 3);
                for (byte j = 1; j <= 8; j++)
                {
                    ID += RN.Next(0, 10);
                }
                ID += "@";
                int BTN = RN.Next(0, 4);
                switch (BTN)
                {
                    case 0:
                        ID += "A#";
                        break;

                    case 1:
                        ID += "B#";
                        break;

                    case 2:
                        ID += "AB#";
                        break;

                    case 3:
                        ID += "O#";
                        break;
                }
                ID += RN.Next(1, 106);
                idDisplay.Items.Add(ID);
            }
        }

        private void BT_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayL.Clear();

            for (int i = 1; i < idDisplay.Items.Count; i++)
            {
                int p1 = idDisplay.Items[i].ToString().IndexOf("@");
                int p2 = idDisplay.Items[i].ToString().IndexOf("#");
                string BT = idDisplay.Items[i].ToString().Substring(p1 + 1, p2 - p1 - 1);

                if (BTS.Text == BT)
                {
                    DisplayL.Text += idDisplay.Items[i] + "\r\n";
                }
            }          
        }

        private void CB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //新竹縣[J] | 新竹市[O]&(血型&未成年[年齡 < 18])

            DisplayR.Clear();

            for (int i = 1; i < idDisplay.Items.Count; i++)
            {
                int RP = idDisplay.Items[i].ToString().IndexOf(".");
                string R = idDisplay.Items[i].ToString().Substring(RP + 1, 1);

                int BTP1 = idDisplay.Items[i].ToString().IndexOf("@");
                int BTP2 = idDisplay.Items[i].ToString().IndexOf("#");
                string BT = idDisplay.Items[i].ToString().Substring(BTP1 + 1, BTP2 - BTP1 - 1);

                int AP = idDisplay.Items[i].ToString().IndexOf("#");
                int A = int.Parse(idDisplay.Items[i].ToString().Substring(AP + 1));

                if (R == "J" || R == "O")
                {
                    if(BT == BTS.Text && A < 18) DisplayR.Text += idDisplay.Items[i] + "\r\n";
                }

            }
        }
    }
}
