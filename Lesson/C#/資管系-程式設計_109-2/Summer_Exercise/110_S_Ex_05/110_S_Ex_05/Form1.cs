using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _110_S_Ex_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime time_start;

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            time_start = DateTime.Now;
            Display.Clear();

            switch (select.Text)
            {
                case "4 queens":
                    queens458(4);
                    break;

                case "5 queens":
                    queens458(5);
                    return;

                case "8 queens":
                    queens458(8);
                    break;

                case "11 queens":
                    queens911(11);
                    return;
            }
        }

        public void queens458(int size)
        {
            int[] Queen = new int[size];
            int y, x, i, j, d, t = 0;
            string str = null;
            y = 0;
            Queen[0] = -1;

            while (true)
            {
                for (x = Queen[y] + 1; x < size; x++)
                {
                    for (i = 0; i < y; i++)
                    {
                        j = Queen[i];
                        d = y - i;
                        if ((j == x) || (j == x - d) || (j == x + d)) break;
                    }
                    if (i >= y) break;
                }
                if (x == size)
                {
                    if (0 == y) break;

                    Queen[y] = -1;
                    y--;
                }
                else
                {
                    Queen[y] = x;
                    y++;
                    if (y < size) Queen[y] = -1;
                    else
                    {
                        str += (++t + ": ");

                        for (int z = 0; z < size; z++)
                        {
                            str += (Queen[z] + 1 + ", ");
                        }
                        str += "\r\n";

                        for (i = 0; i < size; i++)
                        {
                            for (j = 0; j < size; j++)
                            {
                                if (Queen[i] == j) str += ("Q ");
                                else str += ("- ");
                            }
                            str += "\r\n";
                        }
                        str += "\r\n";
                        y = size - 1;
                    }
                }
            }
            str += t + "組解\r\n";
            DateTime time_end = DateTime.Now;
            str += "耗時" + (time_end - time_start).TotalSeconds.ToString() + "秒";
            Display.Text = str;           
        }

        public void queens911(int size)
        {
            SFD.Filter = "文字檔|*.txt|所有檔|*.*";
            SFD.Title = "儲存 N 皇后的結果";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(SFD.FileName, false);

                int[] Queen = new int[size];
                int y, x, i, j, d, t = 0;
                y = 0;
                Queen[0] = -1;

                while (true)
                {
                    for (x = Queen[y] + 1; x < size; x++)
                    {
                        for (i = 0; i < y; i++)
                        {
                            j = Queen[i];
                            d = y - i;
                            if ((j == x) || (j == x - d) || (j == x + d)) break;
                        }
                        if (i >= y) break;
                    }
                    if (x == size)
                    {
                        if (0 == y) break;

                        Queen[y] = -1;
                        y--;
                    }
                    else
                    {
                        Queen[y] = x;
                        y++;
                        if (y < size) Queen[y] = -1;
                        else
                        {
                            SW.Write(++t + ": ");

                            for (int z = 0; z < size; z++)
                            {
                                SW.Write(Queen[z] + 1 + ", ");
                            }
                            SW.WriteLine();

                            for (i = 0; i < size; i++)
                            {
                                for (j = 0; j < size; j++)
                                {
                                    if (Queen[i] == j) SW.Write("Q ");
                                    else SW.Write("- ");
                                }
                                SW.WriteLine();
                            }
                            SW.WriteLine();
                            y = size - 1;
                        }
                    }
                }
                Display.Text += t + "組解\r\n";
                DateTime time_end = DateTime.Now;
                Display.Text += "耗時" + (time_end - time_start).TotalSeconds.ToString() + "秒";
            }
            System.Diagnostics.Process.Start(SFD.FileName);           
        }
    }
}