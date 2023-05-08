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


namespace CS20210428_Shell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RecursiveFunctions RF = new RecursiveFunctions();
        int[] N = new int[100000];
        public string[] TWID = new string[10000];
        Random RN = new Random();
        string show = null;

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                this.Text = e.KeyChar.ToString();
                e.Handled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display.Clear();
            double Starttime = System.DateTime.Now.TimeOfDay.TotalMilliseconds;
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        SaveFileDialog SFD = new SaveFileDialog();
                        SFD.Filter = "文字檔|*.txt";
                        SFD.Title = "選擇儲存原始ID檔案";
                        if (SFD.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter SW = new StreamWriter(SFD.FileName, false)) //File Overwrite(false) Append(true)
                            {
                                for (int i = 0; i < 10000; i++)
                                {
                                    TWID[i] = ((char)RN.Next(65, 91)).ToString();
                                    TWID[i] += RN.Next(1, 3).ToString();
                                    for (int j = 1; j <= 8; j++) TWID[i] += RN.Next(0, 10);
                                    SW.WriteLine(i + ". " + TWID[i]);
                                }
                            }
                        }
                        else return;
                        System.Diagnostics.Process.Start(SFD.FileName);
                        //Bubble Sort
                        this.Text = "Sorting.........";
                        string temp;
                        for (int i = 1; i < 10000; i++)
                        {
                            for (int j = 0; j < 10000 - i; j++)
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
                        SFD.Title = "選擇儲存排序ID檔案";
                        if (SFD.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter SW = new StreamWriter(SFD.FileName, false)) //File Overwrite(false) Append(true)
                            {
                                for (int i = 0; i < 10000; i++)
                                {
                                    SW.WriteLine("ID[" + i + "]= " + TWID[i]);
                                }
                            }
                        }
                        else return;
                        System.Diagnostics.Process.Start(SFD.FileName);
                        break;

                    case 1:    //Factorial  
                        for (byte i = 0; i <= byte.Parse(Number.Text); i++)
                        {
                            //Display.Text += i + "!= " + Factorial(i) + Environment.NewLine;   //.NewLine == "\r\n"                          
                            Display.Text += i + "!= " + RF.RFact(i) + Environment.NewLine;   // Recursive call
                        }
                        break;

                    case 2:   //Fibonacci Number                        
                        for (byte i = 0; i <= byte.Parse(Number.Text); i++)
                        {
                            //Display.Text += "Fibonacci(" + i + ")= " + FIB(i) + Environment.NewLine;                            
                            Display.Text += "Fibonacci(" + i + ")= " + RF.RFib(i) + Environment.NewLine;  // Recursive call
                        }
                        break;

                    case 3:
                        decimal n1 = decimal.Parse(N1.Text);
                        decimal n2 = decimal.Parse(N2.Text);
                        //GCDValue.Text = GCD(n1, n2).ToString();
                        //LCMValue.Text = LCM(n1, n2).ToString();
                        GCDValue.Text = RF.Rgcd(n1, n2).ToString();          //Recursive call
                        LCMValue.Text = (n1 * n2 / RF.Rgcd(n1, n2)).ToString();
                        break;

                    case 4:
                        show = null;
                        for (int i = 0; i < int.Parse(Number.Text); i++)
                        {
                            N[i] = RN.Next(0, 1000);
                            show += N[i] + ", ";
                        }
                        show += Environment.NewLine;
                        Display.Text = show + Environment.NewLine
                                       + "====================Sorted=====================" + Environment.NewLine + Environment.NewLine;
                        //Bubble Sort
                        //Bubble(N, 0, int.Parse(Number.Text) - 1);
                        RF.BubbleSort(N, 0, int.Parse(Number.Text) - 1);
                        
                        show = null;
                        for (int i = 0; i < int.Parse(Number.Text); i++)
                        {
                            show += N[i] + ", ";
                        }
                        Display.Text += show;
                        break;

                    case 5:
                        show = null;
                        for (int i = 0; i < int.Parse(Number.Text); i++)
                        {
                            N[i] = RN.Next(0, 1000);
                            show += N[i] + ", ";
                        }
                        show += Environment.NewLine + Environment.NewLine;
                        Display.Text = show;
                        this.Text = "Sorting.........";
                        RF.QuickSort(N, 0, int.Parse(Number.Text) - 1);
                        Display.Text += "====================Sorted=====================" + Environment.NewLine + Environment.NewLine;
                        show = null;
                        for (int i = 0; i < int.Parse(Number.Text); i++)
                        {
                            show += N[i] + ", ";
                        }
                        Display.Text += show;
                        this.Text = "Form 1";                        
                        break;

                    case 6:
                        //int index = BinarySearch(TWID,Number.Text, 0,9999);
                        int index = RF.BinarySearch(TWID, Number.Text, 0, 9999);
                        if (index == -1) Display.Text = "檔案中無此身分證字號";
                        else Display.Text = "TWID[" + index + "] = " + TWID[index];
                        break;

                    case 7:
                        int disks = int.Parse(Number.Text);
                        int steps = 0;       // 步驟數                                               
                        TowerOfHanoi HT = new TowerOfHanoi();
                        HT.Initialize();
                        Display.Text = HT.HanoiTower(int.Parse(Number.Text), "Rod[A]", "Rod[C]", "Rod[B]");                       
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                double FinishTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
                this.Text = Math.Round(FinishTime - Starttime, 2) + " 毫秒[10^(-3)]";
            }
        }
        
        private decimal Factorial(byte N)
        {
            checked
            {
                if (N == 0) return 1;
                else
                {
                    decimal Result = 1;
                    for (byte i = 1; i <= N; i++)
                    {
                        Result *= i;
                    }
                    return Result;            
                }
            }
        }        

        private decimal FIB(ulong N)
        {
            checked
            {
                if (N == 0) return 0;
                else if (N == 1) return 1;
                else
                {
                    decimal F0 = 0;
                    decimal F1 = 1;
                    decimal Sum;
                    ulong i = 2;
                    while (i <= N)
                    {
                        Sum = F0 + F1;
                        F0 = F1;
                        F1 = Sum;
                        i++;
                    }
                    return F1;
                }
            }
        }       

        private decimal GCD(decimal A, decimal B)
        {
            checked
            {
                decimal temp, R;
                if (A < 0) A = -A;
                if (B < 0) B = -B;
                if (A < B)
                {
                    temp = A;
                    A = B;
                    B = temp;
                }
                while (true)
                {
                    R = A % B;
                    if (R == 0) return B;
                    A = B;
                    B = R;
                }
            }
        }
       
        private decimal LCM(decimal A, decimal B)
        {
            checked
            {
                decimal Product = A * B;
                return Product / GCD(A, B);
            }
        }

        private void Bubble(int[] N, int first, int last)
        {
            int temp;
            for (int i = 1; i < int.Parse(Number.Text); i++)
            {
                for (int j = 0; j < int.Parse(Number.Text) - i; j++)
                {
                    if (N[j] > N[j + 1])
                    {
                        temp = N[j];
                        N[j] = N[j + 1];
                        N[j + 1] = temp;
                    }
                }
            }
        }

        private int BinarySearch(string[] ID, string X, int first, int last)
        {          
            int ptr = (first + last) / 2;
            while (ptr <= last && ptr >= first) 
            {
                if (ID[ptr] == X) return ptr;
                else if ( string.Compare(X, ID[ptr]) > 0) first = ptr+1;
                else last = ptr-1;
                ptr = (first + last) / 2;
            }
            return -1; 
        }  
    }
}
