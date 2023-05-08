using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_03
{
    class Eratosthenes
    {
        public long[] primeNo = new long[1000001];
        public void Create()
        {
            Console.WriteLine("\n\n" + DateTime.Now);
            primeNo[1] = 2; primeNo[2] = 3; primeNo[3] = 5; primeNo[4] = 7;
            int NN = 11;
            int np;
            for(int n = 5; n <= 100000; n++)
            {
                np = 1;
                while(primeNo[np] * primeNo[np] <= NN)
                {
                    if (NN % primeNo[np] == 0)
                    {
                        NN++;
                        np = 1;
                    }
                    else np++;
                }
                primeNo[n] = NN;
                NN++;
            }

        }
        public bool Test(int n)
        {
            if (n < 2) return false;
            //else if (n == 2) return true;
            else
            {
                for (int i = 1; primeNo[i] * primeNo[i] <= n; i++)
                {
                    if (n % primeNo[i] == 0) return false;
                }
                return true;
            }
        }
    }
    class Functions
    {
        public string Factorial(int n)
        {
            if (n < 0) return "Error";
            else if (n == 0 || n == 1) return "1";
            else
            {
                decimal F = 1;
                for (int i = n; i > 0; i--)
                {
                    F *= i;
                }
                return F.ToString();
            }
        }
        public string Fibonacci(int n)
        {
            if (n < 0) return "Error";
            else if (n == 0) return "0";
            else if (n == 1) return "1";
            else
            {
                decimal F0 = 0;
                decimal F1 = 1;
                decimal Fn = 0;
                int f = 2;

                while (f <= n)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                    f++;
                }
                return Fn.ToString();
            }
        }
        public bool PrimeYON(decimal n)
        {
            if (n < 2) return false;
            else if (n == 2) return true;
            else if (n % 2 == 0) return false;
            else
            {
                for (decimal i = 3; i*i <= n; i+=2)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }
        public decimal GCD(decimal X, decimal Y)
        {
            if (X < 0) X = -X;
            if (Y < 0) Y = -Y;

            decimal R = 0;

            while (X % Y != 0)
            {
                R = X % Y;
                X = Y;
                Y = R;
            }

            return Y;
        }
        public decimal LCM(decimal X, decimal Y)
        {
            return Math.Abs(X * Y) / GCD(X, Y);
        }
    }
}
