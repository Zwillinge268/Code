using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random RN = new Random();
        int[,] StudentScore;
        string[] FamilyName;

        private void STNum_TextChanged(object sender, EventArgs e)
        {
            if ( !uint.TryParse(STNum.Text, out uint result) ) 
            {
                STNum.Text = "0";
                return;
            }
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("姓名 -> 計概 + 英文 + 國文 = 總分");

            StudentScore = new int[result, 4];
            int NameLength;
            FamilyName = new string[result];

            for (int i = 0; i < int.Parse(STNum.Text); i++)
            {
                NameLength = RN.Next(3, 8);
                FamilyName[i] = ((char)RN.Next(65, 91)).ToString();

                for (int j = 1; j < NameLength; j++)
                {
                    FamilyName[i] += ((char)RN.Next(97, 123)).ToString();
                }

                for (int k = 1; k <= 3; k++)
                {
                    StudentScore[i, k] = RN.Next(0, 101);
                    StudentScore[i, 0] += StudentScore[i, k];
                }

                checkedListBox1.Items.Add(FamilyName[i] + " : " + StudentScore[i, 1] + " + " + StudentScore[i, 2] + " + " + StudentScore[i, 3] + " = " + StudentScore[i, 0]);

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string item in checkedListBox1.CheckedItems)
            {
                if (item == checkedListBox1.Items[0].ToString()) continue;
                listBox1.Items.Add(item);
            }
            Counter.Text = listBox1.Items.Count.ToString();
        }

        private void SelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            checkedListBox1_SelectedIndexChanged(null, null);
        }

        private void Eng_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for (int i = 0; i < checkedListBox1.Items.Count - 1; i++) 
            {
                listBox2.Items.Add(StudentScore[i, 2]);

                if (StudentScore[i, 2] >= 60)
                {
                    listBox1.Items.Add(checkedListBox1.Items[i + 1]);
                }
            }
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;

            int sp, np;

            int score;
            string name;

            int high = 0, low = 300;
            string highname = null , lowname = null;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sp = listBox1.Items[i].ToString().IndexOf("=");
                score = int.Parse(listBox1.Items[i].ToString().Substring(sp + 2));

                np = listBox1.Items[i].ToString().IndexOf(":");
                name = listBox1.Items[i].ToString().Substring(0, np);

                if (score < low)
                {
                    low = score;
                    lowname = name;
                }

                if (score > high)
                {
                    high = score;
                    highname = name;
                }
            }
            Highest.Text = highname + ": " + high;
            Lowest.Text = lowname + ": " + low;
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            Highest.Text = "最高分者";
            Lowest.Text = "最低分者";
        }

        private void Remove_Click(object sender, EventArgs e)
        {          
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇項目", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Text = listBox1.SelectedIndex.ToString();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            Counter.Text = listBox1.Items.Count.ToString();
        }

        private void Sorting_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.Items.Count <= 1) return;

            string[] Name3S = new string[listBox1.Items.Count];
            int[] Total = new int[listBox1.Items.Count];


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Name3S[i] = listBox1.Items[i].ToString().Substring(0, listBox1.Items[i].ToString().IndexOf("="));
                Total[i] = int.Parse(listBox1.Items[i].ToString().Substring(listBox1.Items[i].ToString().IndexOf("=") + 1));
            }

            Array.Sort(Total,Name3S);
            Array.Reverse(Total);
            Array.Reverse(Name3S);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(Name3S[i] + " = " + Total[i]);
            }

        }
    }
}
