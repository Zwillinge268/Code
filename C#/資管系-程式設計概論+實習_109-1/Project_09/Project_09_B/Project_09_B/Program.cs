using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_09_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double Start = 0;
            double Finish = 0;

            try
            {
                checked
                {
                    int counter = 0;
                    Start = DateTime.Now.TimeOfDay.TotalSeconds;
                    //九宮格求解
                    for (int n1 = 1; n1 <= 9; n1++)
                    {
                        for (int n2 = 1; n2 <= 9; n2++)
                        {
                            if (n2 == n1) continue;
                            for (int n3 = 1; n3 <= 9; n3++)
                            {
                                if (n3 == n1 || n3 == n2) continue;
                                for (int n4 = 1; n4 <= 9; n4++)
                                {
                                    if (n4 == n1 || n4 == n2 || n4 == n3) continue;
                                    for (int n5 = 1; n5 <= 9; n5++)
                                    {
                                        if (n5 != 5) continue;
                                        if (n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4) continue;
                                        for (int n6 = 1; n6 <= 9; n6++)
                                        {
                                            if (n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4 || n6 == n5) continue;
                                            int n456 = n4 * 100 + n5 * 10 + n6;
                                            if (!PrimeYON(n456)) continue;
                                            for (int n7 = 1; n7 <= 9; n7++)
                                            {
                                                if (n7 == n1 || n7 == n2 || n7 == n3 || n7 == n4 || n7 == n5 || n7 == n6) continue;
                                                int n147 = n1 * 100 + n4 * 10 + n7;
                                                if (!PrimeYON(n147)) continue;
                                                int n357 = n3 * 100 + n5 * 10 + n7;
                                                if (!PrimeYON(n357)) continue;
                                                for (int n8 = 1; n8 <= 9; n8++)
                                                {
                                                    if (n8 == n1 || n8 == n2 || n8 == n3 || n8 == n4 || n8 == n5 || n8 == n6 || n8 == n7) continue;
                                                    for (int n9 = 1; n9 <= 9; n9++)
                                                    {
                                                        if (n9 == n1 || n9 == n2 || n9 == n3 || n9 == n4 || n9 == n5 || n9 == n6 || n9 == n7 || n9 == n8) continue;
                                                        int n369 = n3 * 100 + n6 * 10 + n9;
                                                        if (!PrimeYON(n369)) continue;
                                                        int n159 = n1 * 100 + n5 * 10 + n9;
                                                        if (!PrimeYON(n159)) continue;

                                                        counter++;
                                                        Console.WriteLine(n1 + " " + n2 + " " + n3);
                                                        Console.WriteLine(n4 + " " + n5 + " " + n6);
                                                        Console.WriteLine(n7 + " " + n8 + " " + n9 + "\n\n");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    Finish = DateTime.Now.TimeOfDay.TotalSeconds;
                    Console.WriteLine(counter + " Methons");
                }
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.ToString());
            }
            finally
            {
                Console.WriteLine("Time :" + Math.Round(Finish - Start, 3) + " s");
                Console.ReadKey();
            }
        }
        static bool PrimeYON(decimal X)
        {
            if (X < 0) return false;
            else if (X == 1) return true;
            else if (X == 2) return true;
            else
            {
                for (decimal i = 2; i < X; i++)
                {
                    if (X % i == 0) return false;
                }
                return true;
            }
        }
    }
}
