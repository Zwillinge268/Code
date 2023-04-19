using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string FM;
            bool sex;
            double waist, Height, Weight, BMI; 

            while(true)
            {
                try
                {
                    checked
                    {
                        Console.WriteLine("\n**************************************************\n");
                        Console.WriteLine("BMI(Body Mass Index)");
                        Console.WriteLine("資料來源: http://zh.wikipedia.org/wiki/身高體重指數");
                        Console.WriteLine("\n==================================================\n");
                        Console.Write("請輸入性別-女[Female](0/f/F)男[Male](1/m/M)？");

                        FM = Console.ReadLine();

                        if ( FM == "0" || FM == "f" || FM == "F")
                        {
                            sex = false;
                            Console.WriteLine("性別: 女(False)");
                        }
                        else if (FM == "1" || FM == "m" || FM == "M")
                        {
                            sex = true;
                            Console.WriteLine("性別: 男(True)");
                        }
                        else
                        {
                            Console.WriteLine("性別選擇錯誤！");


                            //return;                                   //reture 為結束程式
                            //break;                                    //break 為結束循環 , 即執行while以外的程式碼
                            continue;                                   //contiune 為繼續 , 即執行下一區塊(本程式下一區塊為finally) 
                        }

                        Console.Write("請輸入腰圍(cm) ?");
                        waist = double.Parse(Console.ReadLine());

                        Console.Write("請輸入身高(cm)?");
                        Height = double.Parse(Console.ReadLine());

                        Console.Write("請輸入體重(Kg)?");
                        Weight = double.Parse(Console.ReadLine());

                        BMI = Weight / Math.Pow(Height / 100, 2);
                        Console.WriteLine("BMI(體質數[" + BMI + "])= " + Math.Round(BMI, 1));
                        BMI = Math.Round(BMI, 1);

                        if (BMI < 18.5)
                        {
                            Console.WriteLine("體重過低");
                            if ((sex && waist >= 95d) || (!sex && waist >= 90d))
                                Console.WriteLine("腰圍危險");
                        }

                        else if (BMI >= 28d)
                        { 
                            Console.WriteLine("肥胖");
                            if ((sex && waist >= 95d) || (!sex && waist >= 90d))
                                Console.WriteLine("腰圍最高危險");
                            else if ((sex && waist >= 85d) || (!sex && waist >= 80d))
                                Console.WriteLine("腰圍極高危險");
                            else if ((sex && waist > 85d) || (!sex && waist > 80d))
                                Console.WriteLine("腰圍高危險");
                        }  
                        
                        else if (BMI > 24d)
                        {
                            Console.WriteLine("超重");
                            if ((sex && waist >= 95d) || (!sex && waist >= 90d))
                                Console.WriteLine("腰圍極高危險");
                            else if ((sex && waist >= 85d) || (!sex && waist >= 80d))
                                Console.WriteLine("腰圍高危險");
                            else if ((sex && waist > 85d) || (!sex && waist > 80d))
                                Console.WriteLine("腰圍危險");
                        }

                        else
                        {
                            Console.WriteLine("體重正常");
                            if ((sex && waist >= 95d) || (!sex && waist >= 90d))
                                Console.WriteLine("腰圍高危險");
                            else if ((sex && waist >= 85d) || (!sex && waist >= 80d))
                                Console.WriteLine("腰圍危險");
                        }

                    }
                }
                catch(Exception Error)
                {
                    Console.WriteLine(Error);
                }
                finally
                {
                    Console.WriteLine("Press any key to continue \n");
                    Console.ReadKey();
                }
            }
        }
    }
}
