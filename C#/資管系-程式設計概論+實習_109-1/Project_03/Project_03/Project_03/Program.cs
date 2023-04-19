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
            Random RND = new Random();     //建立隨機數
            double H = 0.0;                //全域宣告變數
            double t = 0.0;
            double g = 9.80665;

            while (true)
            {
                try
                {
                    Console.WriteLine(System.DateTime.Now);    //顯示現在的系統時間

                    Console.BackgroundColor = ConsoleColor.Red;      //將背景顔色改爲"Red"
                    Console.ForegroundColor = ConsoleColor.Black;    //將字體顔色改為"Black"

                    t = 10.0 * RND.NextDouble();        // 設RND為 0 ~ 1 的隨機數
                    Console.Write("Input 自由落體之秒數(Second)=?" + t);

                    // Console.Write("Input 自由落體之秒數(Second)=?");
                    // t = double.Parse(Console.ReadLine());

                    H = 1.0 / 2.0 * g * Math.Pow(t, 2);
                    Console.WriteLine("吊橋高度(M) =" + Math.Round(H, 2) + "公尺");

                    //System.Threading.Thread.Sleep(1250);    //系統時間降爲 1250(毫秒)再執行下一次
                    System.Threading.Thread.Sleep(RND.Next(1000,5000));    //設RND為 1000 ~ 5000 之間的隨機數

                    Console.BackgroundColor = ConsoleColor.Black;    //將背景顔色改回"Black"
                    Console.ForegroundColor = ConsoleColor.Gray;     //將字體顔色改回"Gray"

                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error);
                    Console.WriteLine("H =)" + H);
                    Console.WriteLine("g =)" + g);
                    Console.WriteLine("t =)" + t);
                }
                finally
                {
                    Console.WriteLine("Try Again ! \n ");     // "\n" 為執行這行後隔一行再顯示下一句  
                }
            }
        }
    }
}
