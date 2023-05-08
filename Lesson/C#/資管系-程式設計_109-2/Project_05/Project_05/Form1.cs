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

namespace Project_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random RN = new Random();
        Student[] ST = new Student[10000];
        string[] TWID = new string[100000];
        string temp;
        int num;

        struct Student
        {
            public int No, Score;
            public string Name;
        }
        
        private void Create_Click(object sender, EventArgs e)
        {
            DisplayA.Clear();
            int NameLength;
            string Name;
            string Result = null;

            for (int i = 0; i < nud.Value; i++) 
            {
                ST[i].No = i;
                ST[i].Score = RN.Next(0, 101);
                Name = ((char)RN.Next(65, 91)).ToString();
                NameLength = RN.Next(3, 8);

                for (int j = 1; j <= NameLength; j++)
                {
                    Name += ((char)RN.Next(97, 122)).ToString();
                }

                ST[i].Name = Name;
                Result += ST[i].No + ". " +ST[i].Name + " : " + ST[i].Score + "\r\n";
            }

            DisplayA.Text = Result;
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            Create_Click(null,null);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = VB.Interaction.InputBox("Please enter string" , "For From Text");
            if (uint.TryParse(VB.Interaction.InputBox("Please enter a number", "For Number of Student"), out uint result))
            {
                nud.Value = result;
            }          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayB.Clear();
            temp = null;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    for(int i = 0; i < nud.Value; i++)
                    {
                        DisplayB.Text += ST[i].No + ". " + ST[i].Name + " : " + ST[i].Score + "\r\n";
                    }

                    break;

                case 1:
                    for (int j = (int)nud.Value - 1; j >= 0; j--)
                    {
                        temp += ST[j].No + ". " + ST[j].Name + " : " + ST[j].Score + Environment.NewLine;
                    }
                    DisplayB.Text = temp;

                    break;

                case 2:
                    for (int i = 1; i < nud.Value; i++)
                    {
                        for (int j = 1; j <= nud.Value - 1; j++)
                        {
                            if (ST[j - 1].Score > ST[j].Score) 
                            {
                                num = ST[j - 1].No;
                                ST[j - 1].No = ST[j].No;
                                ST[j].No = num;

                                num = ST[j - 1].Score;
                                ST[j - 1].Score = ST[j].Score;
                                ST[j].Score = num;

                                temp = ST[j - 1].Name;
                                ST[j - 1].Name = ST[j].Name;
                                ST[j].Name = temp;
                            }
                        }
                    }

                    for (int k = (int)nud.Value - 1; k >= 0; k--)
                    {
                        temp += ST[k].No + ". " + ST[k].Name + " : " + ST[k].Score + Environment.NewLine;
                    }
                    DisplayB.Text = temp;

                    break;

                case 3:

                    for (int i = 1; i < nud.Value; i++)
                    {
                        for (int j = 1; j <= nud.Value - 1; j++)
                        {
                            if (string.Compare(ST[j - 1].Name,ST[j].Name) > 0)
                            {
                                num = ST[j - 1].No;
                                ST[j - 1].No = ST[j].No;
                                ST[j].No = num;

                                num = ST[j - 1].Score;
                                ST[j - 1].Score = ST[j].Score;
                                ST[j].Score = num;

                                temp = ST[j - 1].Name;
                                ST[j - 1].Name = ST[j].Name;
                                ST[j].Name = temp;
                            }
                        }
                    }

                    for (int k = 0; k < nud.Value; k++)
                    {
                        DisplayB.Text += ST[k].No + ". " + ST[k].Name + " : " + ST[k].Score + "\r\n";
                    }

                    break;

                case 4:

                    for (int i = 1; i < nud.Value; i++)
                    {
                        for (int j = 1; j <= nud.Value - 1; j++)
                        {
                            if (ST[j - 1].Score > ST[j].Score)
                            {
                                num = ST[j - 1].No;
                                ST[j - 1].No = ST[j].No;
                                ST[j].No = num;

                                num = ST[j - 1].Score;
                                ST[j - 1].Score = ST[j].Score;
                                ST[j].Score = num;

                                temp = ST[j - 1].Name;
                                ST[j - 1].Name = ST[j].Name;
                                ST[j].Name = temp;
                            }
                            else if (ST[j - 1].Score == ST[j].Score)
                            {
                                if (string.Compare(ST[j - 1].Name, ST[j].Name) > 0)
                                {
                                    num = ST[j - 1].No;
                                    ST[j - 1].No = ST[j].No;
                                    ST[j].No = num;

                                    num = ST[j - 1].Score;
                                    ST[j - 1].Score = ST[j].Score;
                                    ST[j].Score = num;

                                    temp = ST[j - 1].Name;
                                    ST[j - 1].Name = ST[j].Name;
                                    ST[j].Name = temp;
                                }
                            }
                        }
                    }

                    for (int k = 0; k < nud.Value; k++)
                    {
                        DisplayB.Text += ST[k].No + ". " + ST[k].Name + " : " + ST[k].Score + "\r\n";
                    }


                    break;

                case 5:

                    if (int.TryParse(VB.Interaction.InputBox("", "Input number of TWID"), out int number))
                    {
                        SFD.Filter = "文字檔|*.txt|所有檔|*.*";
                        SFD.Title = "選擇儲存原始ID檔案";
                        if (SFD.ShowDialog() == DialogResult.OK)
                        {
                            using (System.IO.StreamWriter SW = new System.IO.StreamWriter(SFD.FileName, false))
                            {
                                for (int i = 0; i < number; i++)
                                {
                                    TWID[i] = ((char)RN.Next(65, 92)).ToString();
                                    TWID[i] += RN.Next(1, 3).ToString();
                                    for (int j = 1; j <= 8; j++)
                                    {
                                        TWID[i] += RN.Next(0, 10);
                                    }
                                    SW.WriteLine(i + ". " + TWID[i]);
                                }
                            }
                        }
                        else return;
                        System.Diagnostics.Process.Start(SFD.FileName);

                        this.Text = "Sorting......";
                        for (int i = 1; i < number; i++)
                        {
                            for (int j = 0; j < number - i; j++)
                            {
                                if (string.Compare(TWID[j], TWID[j + 1]) > 0)
                                {
                                    temp = TWID[j];
                                    TWID[j] = TWID[j + 1];
                                    TWID[j + 1] = temp;
                                }
                            }
                        }
                        this.Text = null;
                        SFD.Title = "";
                        if (SFD.ShowDialog() == DialogResult.OK) 
                        {
                            using (System.IO.StreamWriter SW = new System.IO.StreamWriter(SFD.FileName, false))
                            {
                                for (int i = 0; i < number; i++)
                                {
                                    SW.WriteLine("ID[" + i + "]= " + TWID[i]);
                                }
                                SW.WriteLine("=========================================");
                            }
                        }
                        else return;
                        System.Diagnostics.Process.Start(SFD.FileName);
                    }
                    break;
            }
        }
    }
}
