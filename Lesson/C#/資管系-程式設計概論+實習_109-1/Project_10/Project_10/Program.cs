using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RN = new Random();
            while (true)
            {
                try
                {
                    Console.Write("INPUT number of digit & times？");
                    string[] Line = Console.ReadLine().Split(' ');
                    int digit = int.Parse(Line[0]);
                    int times = int.Parse(Line[1]);
                    int number;
                    string ID;

                    checked
                    {
                        for (int i = 1; i <= times; i++)
                        {
                            //    number = RN.Next((int)Math.Pow(10, digit - 1), (int)Math.Pow(10, digit));
                            //    Console.WriteLine(i + ". " + number + ":" + OddEven(number) + "\n");

                            ID = null;

                            for (int d = 1; d <= digit; d++)
                            {
                                ID = ID + RN.Next(0, 10);
                            }
                            Console.WriteLine(i + ". " + ID + ":" + OddEven(ID) + "\n");
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
        static string OddEven(string X)
        {
            int odd = 0;
            int even = 0;
            //int Q, R;

            //while(true)
            //{
            //    R = X % 10;
            //    if (R % 2 == 0) even++;
            //    else odd++;

            //    Q = X / 10;
            //    if (Q == 0) break;
            //    else X = Q;
            //}

            string S = X.ToString();
            for (int ptr = 0; ptr <= S.Length-1; ptr++)
            {
                if (int.Parse(S.Substring(ptr, 1)) % 2 == 0) even++;
                else odd++;
            }

            return "奇(" + odd + ")偶(" + even + ")";

        }
    }
}
