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
            string List90x;
            Random RN = new Random();
            P1S = 0;
            P2S = 0;
            C = 0.0;
            List90x = null;

            while (true)
            {
                try
                {
                    checked
                    {
                        Console.WriteLine("109-1 1st Quiz 成績計算模擬[計概 程設]");
                        Console.Write("請輸入[考生人數]？");
                        int NoC = int.Parse(Console.ReadLine());

                        for (int a = 1; a <= NoC; a++)
                        {
                            Thread.Sleep(100);

                            P1 = RN.Next(0, 101);
                            P2 = RN.Next(0, 101);

                            Total = P1 + P2;
                            Avg = Total / 2.0;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(a + "." + P1 + "[計概] + " + P2 + " [程設] = " + Total + " [總分]；");
                            //根據不同情況設定顔色
                            if (Avg >= 90.0)
                            {

                                List90x += a + "; ";

                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.BackgroundColor = ConsoleColor.White;
                            }
                            else if(Avg > 60.0)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }


                            Console.WriteLine(Avg + " [平均]\n");


                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                            P1S = P1S + P1;
                            P2S = P2S + P2;
                            C = NoC;
                        }

                        //計算總平均
                        P1Avg = Math.Round(P1S / C,1);
                        P2Avg = Math.Round(P2S / C,1);

                        Console.WriteLine("=====================================");
                        Console.WriteLine("[計概]平均:" + P1Avg + "[程設]平均:" + P2Avg + "\n");

                        //---------------------------------------------------------------------------

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        //統計平均高分者
                        Console.WriteLine("總平均 >= 90者:" + List90x + "\n");

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;

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
