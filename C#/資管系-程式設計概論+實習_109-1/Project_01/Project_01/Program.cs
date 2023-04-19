using System;
using System.Collections.Generic;
using System.Text;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!109資一甲(20200922A)");  //Console.WriteLine = 顯示行
            Console.WriteLine("Hello!" + "109資一甲(20200922A)");
            Console.WriteLine("13+7=" + (13 + 7));
            Console.WriteLine("13-7=" + (13 - 7));
            Console.WriteLine("13*7=" + (13 * 7));
            Console.WriteLine("13/7=" + (13 / 7));
            Console.WriteLine("13.0/7.0=" + (13.0 / 7.0));
            Console.WriteLine("13.0/7.0=" + Math.Round(13.0 / 7.0, 2));   //Math 計算符號
            Console.WriteLine("13.0/7.0=" + Math.Round(13.0 / 7.0, 3));   //Round 取近似值 , 逗號後面輸入小數位
            Console.WriteLine("13%7=" + (13 % 7));                        //13 除以 7 後的餘數
            Console.WriteLine("144^(1/2)=" + Math.Pow(144, 1 / 2));       //Pow 次方
            Console.WriteLine("144^(1/2)=" + Math.Pow(144, 1.0 / 2.0));
            Console.WriteLine("144^(1/2)=" + Math.Pow(144, 0.5));
            Console.WriteLine("125^(1/3)=" + Math.Pow(125, 1.0 / 3.0));
            Console.WriteLine("123 * 456=" + (123 * 456));

            //int = 32 bit 整數 、 long = 64 bit 整數 、 string = 字串 、 float = 32 bit 小數 、 double = 64 bit 小數

            Console.WriteLine("123456 * 123456=" + ((long)123456 * 123456));
            Console.WriteLine((long)123456789123456789);

            //---------------------------------------------------------------------------------------//

            //Variables 變數

            int X, Y;   //宣告 X 和 Y 兩個變數

            X = 2;
            Y = 3;     //賦予 X = 2 和 Y = 3
            Console.WriteLine("X + Y = " + (X + Y));   //結果 = 5

            X = 10;
            Y = 5;
            X++;             //X ++ = X + 1
            Y--;             //Y -- = Y - 1  

            Console.WriteLine("X + Y = " + (X + Y));   //結果 = 15

            int A = 2147483647;                        //宣告 + 賦予 + 設定變數
            int B = 2;
            Console.WriteLine("A + B =" + (A + B));    //Overflow 溢位
            //變數不會因爲數據類型導致程式無法運行，但計算結果是錯誤的

            //解決辦法
            Console.WriteLine("A + B =" + ((long)A + B));
            //將變數設爲 Long , 一個變數為 Long , 所有變數均改變

            //----------------------------------------------------------------------------------------//

            //ReadLine 讀取

            Console.WriteLine("Input X ");
            string C = Console.ReadLine();                  //ReadLine 後面要補 ()
            Console.WriteLine("Input Y ");
            string D = Console.ReadLine();
            Console.WriteLine("X + Y =" + (C + D));
            //由於變數類型為 String , 所以會合拼字符而非計算

            //計算方法
            Console.WriteLine("Input X ");
            int E = int.Parse(Console.ReadLine());        //類型設定為 int
            Console.WriteLine("Input Y ");
            int F = int.Parse(Console.ReadLine());        //必須加上 int.Parse 計算
            Console.WriteLine("X + Y =" + (E + F));

            //---------------------------------------------------------------------------------------//

            //資料串 與 Delimiter 分割

            Console.Write("Input X , Input Y");                  //WriteLine 每項資料佔一行 , Write 共佔一行 
            string[] str = Console.ReadLine().Split(' ');        // []為建立資料串 , 資料定義為 string (字串) , 名稱為 str
                                                                 //Split 為分割 , 後面括號定義分割信號為' ' (空格)
            double G = double.Parse(str[0]);                     //將資料串資料寫進變數
            double H = double.Parse(str[1]);

            Console.WriteLine("X + Y = " + (G + H));
            Console.WriteLine("X - Y = " + (G - H));
            Console.WriteLine("X * Y = " + (G * H));
            Console.WriteLine("X / Y = " + (G / H));
            Console.WriteLine("X / Y = " + Math.Round(G / H, 3));
            Console.WriteLine("X ^ Y = " + Math.Round(Math.Pow(G, H), 3));

            //----------------------------------------------------------------------------------------//

            Console.ReadKey(); //等待輸入
        }
    }
}