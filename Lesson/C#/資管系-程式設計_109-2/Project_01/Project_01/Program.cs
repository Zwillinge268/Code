using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RN = new Random();
            int Nth;
            int[] LottoCode = new int[8];
            bool test;

            try
            {
                Console.Write("請輸入需幾組樂透碼[6 + 1(特別號)]？Max.Numbe of Lotto[7 - 49]？Time for one code generated？");
                string[] Lotto = Console.ReadLine().Split(' ');
                int Num = int.Parse(Lotto[0]);
                int Max = int.Parse(Lotto[1]);
                int OneCodeTime = int.Parse(Lotto[2]);

                for(int n = 1 ;n <= Num ;n++)
                {
                    Nth = 1;
                    while(Nth <= 7)
                    {
                        test = true;
                        while(test)
                        {
                            test = false;
                            LottoCode[Nth] = RN.Next(1, Max + 1);
                            Thread.Sleep(OneCodeTime);
                            Console.Write(LottoCode[Nth]);

                            for(int i = 1; i <= Nth; i++)
                            {
                                if (LottoCode[i] == LottoCode[Nth])
                                {
                                    Console.Write(" ");
                                    test = true;
                                    break;
                                }
                            }
                        }

                        Console.Write("*" + " ");
                        Nth++;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(n + ". ");
                    for (byte j = 1; j <= 7; j++)
                    {
                        Console.Write(LottoCode[j] + "  ");
                    }
                    Console.ResetColor();
                    Console.WriteLine("\n \n");

                }
            }
            catch(Exception Error)
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
