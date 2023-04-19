using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_08
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\n\n" + DateTime.Now);
                    Console.Write("[A]Factorial[？？]  [B]Fibonacci[？？]  [C]Prime Number[？]  [D]GCD[LCM] = (Input Number：？？)");
                    string[] Line = Console.ReadLine().Split(' ');
                    if (Line[0] == "") break;
                    string Which = Line[0];
                    int start, last, temp;

                    checked
                    {
                        //根據輸入判定調用哪個區塊                        
                        switch (Which)
                        {
                            //在調用函數前確保大小順序
                            case "A":
                                start = int.Parse(Line[1]);
                                last = int.Parse(Line[2]);

                                if (last < start)
                                {
                                    temp = start;
                                    start = last;
                                    last = temp;
                                }     

                                for (int n = start; n <= last; n++)
                                {
                                    if (Factorial(n) == -1)
                                    {
                                        Console.WriteLine(n + " Input value must > 0 ");
                                    }
                                    else Console.WriteLine(n + "!= " + Factorial(n));
                                }

                                break;

//-----------------------------------------------------------------------------------------------------

                            case "B":

                                start = int.Parse(Line[1]);
                                last = int.Parse(Line[2]);

                                if (last < start)
                                {
                                    temp = start;
                                    start = last;
                                    last = temp;
                                }
                                for (int n = start; n <= last; n++)
                                {
                                    if (Fibonacci(n) == -1)
                                    {
                                        Console.WriteLine("Fib (" + n + ") = " + " Input value must > 0 ");
                                    }
                                    else
                                    {
                                        if (Fibonacci(n) % 2 == 0)
                                        {
                                            Console.WriteLine("Fib (" + n + ") = " + Fibonacci(n) + "[偶]");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fib (" + n + ") = " + Fibonacci(n) + "(奇)");
                                        }
                                    }
                                }

                                break;

                            case "C":

                                decimal i = 0;
                                decimal NN = 0;
                                decimal Number = int.Parse(Line[1]);
                                while(i < Number)
                                {
                                    if (PrimeYON(NN) == true)
                                    {
                                        i++;
                                        Console.WriteLine("P" + i + "= " + NN);
                                    }
                                    NN++;
                                }

                                break;

                            case "D":

                                decimal X = decimal.Parse(Line[1]);
                                decimal Y = decimal.Parse(Line[2]);
                                Console.WriteLine("GCD(" + X + "," + Y + ") = " + GCD(X, Y));
                                Console.WriteLine("LCM(" + X + "," + Y + ") = " + LCM(X, Y));

                                break;

                            default:
                                return;
                        }
                    }

                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error);
                }
                finally
                {
                    Console.WriteLine("Press any key to Exit");
                    Console.ReadKey();
                }
            }
        }

//以下程式區塊必須調用才會執行---------------------------------------------------------------------

        static decimal Factorial(int X)
        {
            if (X < 0) return -1;
            else if (X == 0 || X == 1) return 1;
            else
            {
                decimal F = 1;
                for (int i = X; i > 0; i--)
                {
                    F *= i;
                }
                return F;
            }
        }

//-------------------------------------------------------------------------------------------------

        static decimal Fibonacci(int X)
        {
            if (X < 0) return -1;
            else if (X == 0) return 0;
            else if (X == 1) return 1;
            else
            {
                decimal F0 = 0;
                decimal F1 = 1;
                decimal Fn = 0;
                int f = 2;

                while(f <= X)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                    f++;
                }
                return Fn;
            }
        }

//-------------------------------------------------------------------------------------------------

        static decimal GCD(decimal X, decimal Y)
        {
            if (X < 0) X = -X;
            if (Y < 0) Y = -Y;

            decimal R = 0;

            while(X % Y != 0)
            {
                R = X % Y;
                X = Y;
                Y = R;
            }

            return Y;
        }
        static decimal LCM(decimal X, decimal Y)
        {
            return Math.Abs(X * Y) / GCD(X, Y);
        }

        //----------------------------------------------------------------------------------------------------

        static bool PrimeYON(decimal X)
        {
            if (X < 0) return false;
            else if (X == 1) return true;
            else if (X == 2) return true;
            else
            {
                for(decimal i = 2; i < X; i++)
                {
                    if (X % i == 0) return false;
                }
                return true;
            }
        }
    }
}
