using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_00
{
    class Program
    {
        static Thread threadA, threadB, threadC;
        static Random RN = new Random();
        static byte Nth, A, B, C;
        static int ST;

        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Press Y/y for continue. No. of student ? SleepTime(ms) ?");
                    string[] data = Console.ReadLine().Split(' ');
                    Nth = byte.Parse(data[1]);
                    ST = int.Parse(data[2]);

                    if (data[0] == "Y" || data[0] == "y")
                    {
                        A = 0; B = 0; C = 0;
                        threadA = new Thread(new ThreadStart(IMA));
                        threadB = new Thread(new ThreadStart(IMB));
                        threadC = new Thread(new ThreadStart(IMC));
                        threadA.Start();
                        threadB.Start();
                        threadC.Start();
                    }
                    else return;
                }
                catch(Exception Error)
                {
                    Console.WriteLine(Error.ToString());
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }

        private static void IMA()
        {
            while(true)
            {
                Thread.Sleep(RN.Next(0, ST));
                A++;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("資一甲 (" + A + ") : " + DateTime.Now.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine();

                if(A == Nth)
                {
                    threadB.Abort(); 
                    threadC.Abort();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Winner : 資一甲");
                    Console.ResetColor();
                    threadA.Abort();
                }
            }
        }

        private static void IMB()
        {
            while (true)
            {
                Thread.Sleep(RN.Next(0, ST));
                B++;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("資一乙 (" + B + ") : " + DateTime.Now.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine();

                if (B == Nth)
                {
                    threadA.Abort();
                    threadC.Abort();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Winner : 資一乙");
                    Console.ResetColor();
                    threadB.Abort();
                }
            }
        }

        private static void IMC()
        {
            while (true)
            {
                Thread.Sleep(RN.Next(0, ST));
                C++;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("資一丙 (" + C + ") : " + DateTime.Now.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine();

                if (C == Nth)
                {
                    threadA.Abort();
                    threadB.Abort();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Winner : 資一丙");
                    Console.ResetColor();
                    threadC.Abort();
                }
            }
        }
    }
}
