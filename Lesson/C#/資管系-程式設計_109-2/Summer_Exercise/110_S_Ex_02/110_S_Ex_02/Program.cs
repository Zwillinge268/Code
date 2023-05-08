using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_S_Ex_02
{
    class Program
    {
        //題目：https://e-tutor.itsa.org.tw/e-Tutor/mod/programming/view.php?id=8269

        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("請輸入梯級數：");
                int input = int.Parse(Console.ReadLine());                
                Console.WriteLine("有 " + Calc(input) + " 種方法" + "\n");
            }           
        }
        static int Calc(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            else return Calc(n - 1) + Calc(n - 2);
        }
    }
}
