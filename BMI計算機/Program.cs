using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI計算機
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BMI值計算機";
            Console.ForegroundColor = ConsoleColor.Cyan;
            //視窗造型

            Console.WriteLine("歡迎使用BMI值計算機，請輸入以下數據進行計算 :" + "\r\n");
            Console.WriteLine("輸入後請按下ENTER鍵" + "\r\n");
            //使用說明

            Console.WriteLine("性別 : " + "  (男生為1，女生為2)");
            string gender = Console.ReadLine();

            Console.WriteLine("\r\n" + "身高(cm) : ");
            string height = Console.ReadLine();

            Console.WriteLine("\r\n" + "體重(kg) : ");
            string weight = Console.ReadLine();
            //接收性別、身高和體重數值

            double Height = Math.Pow(double.Parse(height) / 100, 2);
            //轉換身高變數類別，計算身高平方，單位由公分(cm)轉為公尺(m)

            double Weight = double.Parse(weight);
            //轉換體重變數類別

            double BMI;
            BMI = Weight / Height;
            Console.WriteLine("\r\n" + "您的BMI值為 : " + BMI);
            //計算BMI值並顯示

            if (BMI < 18.5)
            {
                Console.WriteLine("\r\n" + "體重過輕");
            }

            else if (BMI >= 18.5 && BMI < 24)
            {
                Console.WriteLine("\r\n" + "體重正常");
            }

            else if (BMI >= 24)
            {
                Console.WriteLine("\r\n" + "體重過重");
            }

            else if (BMI >= 27)
            {
                Console.WriteLine("\r\n" + "體重已達肥胖標準");
            }
            //判斷結果顯示

            if (BMI > 30 && int.Parse(gender) == 1)
            {
                Console.WriteLine("\r\n" + "已達免服兵役的標準");
            }

            else if (BMI < 15 && int.Parse(gender) == 1)
            {
                Console.WriteLine("\r\n" + "已達免服兵役的標準");
            }
            //判斷是否免兵役

            Console.ReadLine();
        }
    }
}
