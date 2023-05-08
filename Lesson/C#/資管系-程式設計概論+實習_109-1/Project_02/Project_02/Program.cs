using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)                   //While 循環 , True 永遠正確 (指不斷執行)
            {
                try                        //嘗試執行程式碼
                {
                    Console.Write("Input X , Input Y");                 
                    string[] str = Console.ReadLine().Split(' ');        
                                                                        
                    double G = double.Parse(str[0]);                   
                    double H = double.Parse(str[1]);

                    Console.WriteLine("X + Y = " + (G + H));
                    Console.WriteLine("X - Y = " + (G - H));
                    Console.WriteLine("X * Y = " + (G * H));
                    Console.WriteLine("X / Y = " + (G / H));
                    Console.WriteLine("X / Y = " + Math.Round(G / H, 3));
                    Console.WriteLine("X ^ Y = " + Math.Round(Math.Pow(G, H), 3));
                }
                catch (Exception ABC)      //如果執行錯誤則運行 catch 區塊  , Exception 為錯誤信息 , 命名為 ABC
                {
                    Console.WriteLine(ABC);  //把錯誤信息 ABC 輸出至屏幕
                }
                finally                      //無論程式執行成功或發生錯誤 , 都會執行 finally 區塊
                {
                    Console.WriteLine("Bye Bye !");
                }
            }                                //此行括號為 while 範圍内 , 裏面的程式碼因爲 Ture 會不斷執行
        }
    }
}
