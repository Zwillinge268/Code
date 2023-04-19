using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11_RE_2

{
    class Program
    {
        static void Main(string[] args)
        {
            Random RN = new Random();
            string Name;
            int S1, S2, S3, Total;
            int pos1, pos2, pos3, pos4;
            string F, S;

            while (true)
            {
                try
                {
                    checked
                    {
                        Console.WriteLine("僅限使用單一個一維陣列");
                        Console.Write("INPUT number of Student？ Max. Length of Last Name？");
                        String[] Line = Console.ReadLine().Split(' ');
                        int Number = int.Parse(Line[0]);
                        int Lenght = int.Parse(Line[1]);

                        string[] Names = new string[Number];
                        //int[] Scores = new int[Number];

                        for (int n = 1; n <= Number; n++)
                        {
                            Name = ((char)RN.Next(65, 91)).ToString();
                            for (int i = 1; i <= RN.Next(1, Lenght); i++)
                            {
                                Name += (char)RN.Next(97, 123);
                            }

                            S1 = RN.Next(0, 101);
                            S2 = RN.Next(0, 101);
                            S3 = RN.Next(0, 101);
                            Total = S1 + S2 + S3;

                            Names[n - 1] = n + ". " + Name + " : " + S1 + " + " + S2 + " + " + S3 + " = " + Total;
                            //Scores[n - 1] = Total;

                            //Console.WriteLine(Names[n - 1] + Scores[n -1 ] + "\n");
                            Console.WriteLine(Names[n - 1] + "\n");
                        }

                        Console.WriteLine("======================================================");
                        Console.Write("Sorting by Score(Descending)|Name(Ascending)|SN？");
                        string Methon = Console.ReadLine();
                        int temp;
                        string str;
                        int Left, Right;

                        switch (Methon)
                        {
                            case "S":
                                for (int j = 1; j < Number; j++)
                                {
                                    for (int k = 1; k <= Number - j; k++)
                                    {
                                        Left = int.Parse(Names[k - 1].Substring(Names[k - 1].IndexOf("=") + 2));
                                        Right = int.Parse(Names[k - 1].Substring(Names[k - 1].IndexOf("=") + 2));

                                        if (Left > Right)
                                        {
                                            str = Names[k - 1];
                                            Names[k - 1] = Names[k];
                                            Names[k] = str;
                                        }
                                    }
                                }

                                for (int l = 0; l < Number; l++)
                                {
                                    Console.WriteLine(Names[l] + "\n");
                                }

                                break;

                            case "N":
                                for (int j = 1; j < Number; j++)
                                {
                                    for (int k = 1; k <= Number - j; k++)
                                    {
                                        pos1 = Names[k - 1].IndexOf(".");
                                        pos2 = Names[k - 1].IndexOf(" : ");
                                        pos3 = Names[k].IndexOf(".");
                                        pos4 = Names[k].IndexOf(" : ");
                                        F = Names[k - 1].Substring(pos1 + 2, pos2 - (pos1 + 2));
                                        S = Names[k].Substring(pos3 + 2, pos4 - (pos3 + 2));

                                        if (string.Compare(F, S) > 0)
                                        {
                                            str = Names[k - 1];
                                            Names[k - 1] = Names[k];
                                            Names[k] = str;
                                        }
                                    }
                                }

                                for (int l = 0; l < Number; l++)
                                {
                                    Console.WriteLine(Names[l] + "\n");
                                }

                                break;

                            case "SN":
                                for (int j = 1; j < Number; j++)
                                {
                                    for (int k = 1; k <= Number - j; k++)
                                    {
                                        Left = int.Parse(Names[k - 1].Substring(Names[k - 1].IndexOf("=") + 2));
                                        Right = int.Parse(Names[k - 1].Substring(Names[k - 1].IndexOf("=") + 2));

                                        if (Left > Right)
                                        {
                                            str = Names[k - 1];
                                            Names[k - 1] = Names[k];
                                            Names[k] = str;

                                        }
                                        else if (Left == Right)
                                        {
                                            pos1 = Names[k - 1].IndexOf(".");
                                            pos2 = Names[k - 1].IndexOf(" : ");
                                            pos3 = Names[k].IndexOf(".");
                                            pos4 = Names[k].IndexOf(" : ");
                                            F = Names[k - 1].Substring(pos1 + 2, pos2 - (pos1 + 2));
                                            S = Names[k].Substring(pos3 + 2, pos4 - (pos3 + 2));

                                            if (string.Compare(F, S) < 0)
                                            {
                                                str = Names[k - 1];
                                                Names[k - 1] = Names[k];
                                                Names[k] = str;
                                            }
                                        }
                                    }
                                }

                                for (int l = Number; l >= 0; l--)
                                {
                                    Console.WriteLine(Names[l] + "\n");
                                }

                                break;

                            case "4":

                                for(int k = 0; k < Number; k++)
                                {

                                }

                                break;

                            default:
                                break;
                        }
                    }
                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error);
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
