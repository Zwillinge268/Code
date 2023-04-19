using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int P1, P2, Total, P1S, P2S;
            double Avg, P1Avg, P2Avg, C;
            Random RN = new Random();
            P1S = 0;
            P2S = 0;
            C = 0.0;

            while (true)
            {
                try
                {
                    checked
                    {
                        Console.WriteLine("109-1 1st Quiz 成績計算模擬[計概 程設]");
                        Console.Write("請輸入[考生人數]？(每0.5秒產生一位分數)");
                        int NoC = int.Parse(Console.ReadLine());

                        for (int a = 1; a <= NoC; a++)
                        {
                            Thread.Sleep(500);

                            P1 = RN.Next(0, 101);
                            P2 = RN.Next(0, 101);

                            Total = P1 + P2;
                            Avg = Total / 2.0;
                            
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(a + "." + P1 + "[計概] + " + P2 + " [程設] = " + Total + " [總分]；");

                            if (Avg <= 59.5)
                            { Console.ForegroundColor = ConsoleColor.Red; }

                            Console.WriteLine(Avg + " [平均]\n");


                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            P1S = P1S + P1;
                            P2S = P2S + P2;
                            C = NoC;
                        }

                        P1Avg = P1S / C;
                        P2Avg = P2S / C;

                        Console.WriteLine("=====================================");
                        Console.WriteLine("[計概]平均:" + P1Avg + "[程設]平均:" + P2Avg);

                    }
                }
                catch (Exception Error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Error);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                finally
                {
                    Console.WriteLine("Press any key to continue \n \n");
                    Console.ReadKey();
                }
            }
        }
    }
}
