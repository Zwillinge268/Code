using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random RN = new Random();
        public string CodeChar = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
        public int[] IDCode = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                         23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
        public int Capital;

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (Verify(InputID.Text))
            {
                string sex;
                if (InputID.Text.Substring(1, 1) == "1") sex = "男性";
                else sex = "女性";

                int areaC = CodeChar.IndexOf(InputID.Text.Substring(0, 1));
                string areaS = (Area.Items[areaC].ToString()).Substring(0, 3);

                Display1.Text = "這是正確的[" + areaS + "] 地區[" + sex + "] 身份證號碼!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID;
            while (true)
            {
                ID = Area.SelectedItem.ToString().Substring(4, 1);
                if (M.Checked == true) ID += "1"; else ID += "2";
                switch(third.SelectedIndex)
                {
                    case 0:
                        ID += RN.Next(0,6).ToString();
                        break;

                    case 1:
                        ID += "6";
                        break;

                    case 2:
                        ID += "7";
                        break;

                    case 3:
                        ID += "8";
                        break;

                    case 4:
                        ID += "9";
                        break;
                }
                for (byte j = 1; j <= 7; j++)
                {
                    ID += RN.Next(0, 10);
                }
                if (Verify(ID)) break;
                Display1.Text = "請先輸入身份證號碼";
            }
            Display2.Text = ID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display2.SelectAll();
            Display2.Copy();           
        }

        public bool Verify(string X)
        {
            if (X.Length != 10)
            {
                Display1.Text = "身份證字號長度不足!";
                return false;
            }
            if (String.Compare(X.Substring(0, 1), "A") < 0 || String.Compare(X.Substring(0, 1), "Z") > 0)
            {
                Display1.Text = "首碼必須為大寫字母!";
                return false;
            }
            if (!uint.TryParse(X.Substring(2, 8), out uint result) || result == 0)
            {
                Display1.Text = "身份證流水號格式錯誤!";
                return false;
            }            
            else if (X.Substring(1, 1) != "1" && X.Substring(1, 1) != "2")
            {
                Display1.Text = "第二碼僅限男(1)女(2)!";
                return false;
            }
            else
            {
                int Total;
                int Weight = 8;

                Capital = IDCode[CodeChar.IndexOf(X.Substring(0, 1))];
                Total = (Capital / 10) * 1 + (Capital % 10) * 9;

                for (int i = 1; i <= 8; i++)
                {
                    Total += int.Parse(X.Substring(i, 1)) * Weight;
                    Weight--;
                }

                Total += int.Parse(X.Substring(9, 1));

                if (Total % 10 == 0) return true;
                else
                {
                    Display1.Text = "這不是一個正確的身份證字號 , 請您再試一次 !";
                    return false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Area.Text = "臺北市(A)";
            third.Text = "其他";
        }
    }          
}
