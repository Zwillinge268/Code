using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;            //如果常用系統指令可以先調用 , 後面就可以省略    
                                   //e.g. System.Threading.Thread.Sleep(100) --> Thread.Sleep(100)
namespace Project_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int Chin, Eng, Maths, P1, P2, Total;
            Random RN = new Random();

            while(true)
            {
                try
                {
                    checked
                    {
                        Console.WriteLine("四技二專成績計算模擬[國文 英文 數學 專一 專二]");
                        Console.Write("請選擇[1]Input單人五科分數 [2]Input人數自動產生分數 [其他]結束 ？");

                        string method = Console.ReadLine();

                        switch(method)          //switch決策 , 格式為switch(參數){case "條件": 程式碼;  break;   default:程式碼;}
                        {
                            case "1":
                                Console.Write("Input 國文？英文？數學？專一？專二？");
                                string[] marks = Console.ReadLine().Split(' ');

                                if (marks[0] == ""|| marks[1] == ""|| marks[2] == ""|| marks[3] == ""|| marks[4] == "") return;
                                // && (and) , || (or) , ! (not)

                                Chin  = int.Parse(marks[0]);
                                Eng   = int.Parse(marks[1]);
                                Maths = int.Parse(marks[2]);
                                P1    = int.Parse(marks[3]);
                                P2    = int.Parse(marks[4]);
                                Total = Chin + Eng + Maths + P1 + P2;

                                Console.WriteLine(Chin + " + " + Eng + " + " + Maths + "*2 + " + P1 + "*2 + " + P2 + " = " + Total);
                                Console.WriteLine(Chin + "[國文] + " + Eng + "[英文] + " + Maths + "[數學] + " + P1 + "[專一] * 2 + " + P2 + "[專二] * 2 = " + Total + "[總分]");
                                break;

                            case "2":
                                Console.Write("考生人數？產生單筆資料速度(一秒=1000)？");

                                string[] item = Console.ReadLine().Split(' ');
                                int NoP = int.Parse(item[0]);
                                int Sd = int.Parse(item[1]);

                                for (int b = 1; b <= NoP; b++)    //for 循環 , 格式為 for( 開始值 ; 結束值 ; 計數器 ) {程式碼}
                                {
                                    Thread.Sleep(Sd);             //根據用戶輸入的時間 "sd" 來設定

                                    Chin = RN.Next(0, 101); 
                                    Eng = RN.Next(0, 101);
                                    Maths = RN.Next(0, 101);
                                    P1 = RN.Next(0, 101);
                                    P2 = RN.Next(0, 101);

                                    Total = Chin + Eng + Maths + P1 + P2;

                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(b + "." + Chin + "[國文] + " + Eng + "[英文] +" + Maths + "[數學] +" + P1 + "[專一] * 2 +" + P2 + "[專二] * 2 = " + Total + "[總分]\n");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                }

                                //---------------------------------------------------------------------------------------------

                                int a = 1;           //因爲while 循環沒有設定開始值 , 所以要先行宣告

                                while (a <= NoP)     //while 循環 , 格式為 while (條件) {程式碼}
                                {
                                    Thread.Sleep(Sd);

                                    Chin = RN.Next(0, 101);
                                    Eng = RN.Next(0, 101);
                                    Maths = RN.Next(0, 101);
                                    P1 = RN.Next(0, 101);
                                    P2 = RN.Next(0, 101);

                                    Total = Chin + Eng + Maths + P1 + P2;

                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(a + "." + Chin + "[國文] + " + Eng + "[英文] +" + Maths + "[數學] +" + P1 + "[專一] * 2 +" + P2 + "[專二] * 2 = " + Total + "[總分]\n");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    a++;          //計數用 , 與 for 循環的計數器功用一樣

                                }

                                break;

                            default:
                                return;
                        }
                    }
                }
                catch(Exception Error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Error);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                finally
                {                   
                    Console.WriteLine("Press any key to continue \n \n");
                    Console.ReadKey();
                }
            }
        }
    }
}
