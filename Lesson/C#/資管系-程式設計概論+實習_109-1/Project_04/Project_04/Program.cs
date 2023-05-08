using System;

namespace Project_04
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    checked
                    {
                        Console.Write("請輸入溫度 - 轉換方式(<1>攝氏轉華氏 <2>華氏轉攝氏 <任意鍵>結束)？\nInput...");
                        string[] str = Console.ReadLine().Split(' ');
                        double degree = double.Parse(str[0]);
                        int method = int.Parse(str[1]);
                        double C, F;

                        if (method == 1)                                 // if 決策 , 用作決定程式的走向
                        {                                                // 以 if(條件) {程式碼} else {程式碼} 組成
                            C = degree;
                            F = C * (9 / 5) + 32;                        //華氏 = 攝氏 * (9/5) + 32  

                        }
                        else if (method == 2)
                        {
                            F = degree;
                            C = (F - 32) * 5 / 9;                       //攝氏 = (華氏 - 32) * 5/9

                        }
                        else
                        {
                            return;                                     //指回到原始位置 , 即結束程式
                        }

                        //用戶以 1 或 2 決定攝氏和華氏的轉換 , 因爲 method 的數據類型為 int , 所以 "任意鍵" 只能為整數                    

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("攝氏 " + Math.Round(C, 1) + "℃ ＝ 華氏 " + Math.Round(F, 2) + "℉");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Black;

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
                    Console.WriteLine("Try Again! \n");
                }

            }
        }
    }
}