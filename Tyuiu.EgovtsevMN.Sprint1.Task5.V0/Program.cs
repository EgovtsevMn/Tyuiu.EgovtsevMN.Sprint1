using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.EgovtsevMN.Sprint1.Task5.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint1.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт№1 | Выполнил: Еговцев М. Н.| АСОиУб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Еговцев Максим Николаевич | АСОиУб-23-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Условие:                                                                 *");
            Console.WriteLine("* Написать программу, которая присваивает целой переменной d первую цифру  *");
            Console.WriteLine("* из дробной части положительного вещественного числа x.                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
