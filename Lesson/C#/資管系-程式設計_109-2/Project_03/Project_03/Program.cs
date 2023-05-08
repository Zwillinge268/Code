using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, last, temp;
            double Start_Time, Finish_Time;
            Functions FS = new Functions();
            Eratosthenes E = new Eratosthenes();
            E.Create();
            //string result;

            while(true)
            {
                try
                {
                    Console.Write("[A]Factorial[？？]  [B]Fibonacci[？？]  [C]Prime Number[？]  [D]GCD[LCM] = (Input Number：？？) [E]Prime Number[？](Eratosthenes)");
                    string[] Line = Console.ReadLine().Split(' ');
                    if (Line[0] == "") break;
                    string Methon = Line[0];

                    switch (Methon)
                    {
                        case ("A"):

                            start = int.Parse(Line[1]);
                            last = int.Parse(Line[2]);

                            for (int n = start; n <= last; n++)
                            {
                                if (FS.Factorial(n) == "Error")
                                {
                                    Console.WriteLine(n + "!= " + " Input value must > 0 ");
                                }
                                else
                                {
                                    Console.WriteLine(n + "!= " + FS.Factorial(n));
                                }
                            }

                                break;

                        case ("B"):

                            start = int.Parse(Line[1]);
                            last = int.Parse(Line[2]);

                            for (int n = start; n <= last; n++)
                            {
                                if (FS.Fibonacci(n) == "Error")
                                {
                                    Console.WriteLine("Fib (" + n + ") = " + " Input value must > 0 ");
                                }
                                else
                                {
                                    if (int.Parse(FS.Fibonacci(n)) % 2 == 0)
                                    {
                                        Console.WriteLine("Fib (" + n + ") = " + FS.Fibonacci(n) + "[偶]");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fib (" + n + ") = " + FS.Fibonacci(n) + "(奇)");
                                    }
                                }
                            }

                            break;

                        case ("D"):

                            decimal X = decimal.Parse(Line[1]);
                            decimal Y = decimal.Parse(Line[2]);
                            Console.WriteLine("GCD(" + X + "," + Y + ") = " + FS.GCD(X, Y));
                            Console.WriteLine("LCM(" + X + "," + Y + ") = " + FS.LCM(X, Y));

                            break;

                        case ("C"):

                            decimal from = decimal.Parse(Line[1]);
                            decimal to = decimal.Parse(Line[2]);
                            decimal counter = 0;
                            //result = null;

                            Start_Time = DateTime.Now.TimeOfDay.TotalSeconds;

                            for(decimal i = from; i <= to; i++)
                            {
                                if (FS.PrimeYON(i))
                                {
                                    counter++;
                                    Console.WriteLine("P" + counter + "= " + i);
                                    //result += ("P" + counter + "= " + i);
                                }
                            }

                            Finish_Time = DateTime.Now.TimeOfDay.TotalSeconds;
                            //Console.WriteLine(result);
                            Console.WriteLine("Calculate " + counter + " prime number: " + Math.Round(Finish_Time - Start_Time, 3) + "second");

                            break;                      

                        case ("E"):

                            int E_from = int.Parse(Line[1]);
                            int E_to = int.Parse(Line[2]);
                            int E_counter = 0;
                            //result = null;

                            Start_Time = DateTime.Now.TimeOfDay.TotalSeconds;

                            for (uint i = (uint)E_from; i <= E_to; i++)
                            {
                                if (E.Test((int)i))
                                {
                                    E_counter++;
                                    Console.WriteLine("P" + E_counter + "= " + i);
                                    //result += ("P" + counter + "= " + i);
                                }
                            }

                            Finish_Time = DateTime.Now.TimeOfDay.TotalSeconds;
                            //Console.WriteLine(result);
                            Console.WriteLine("Calculate " + E_counter + " prime number: " + Math.Round(Finish_Time - Start_Time, 3) + " second");

                            break;

                        default:
                            return;
                    }
                    
                }
                catch(Exception Error)
                {
                    Console.WriteLine(Error);
                }
                finally
                {
                    Console.WriteLine("Press <Enter> to exit \n");
                }
            }    
        }
    }
}
