using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.EgovtsevMN.Sprint1.Task3.V0.Lib;

namespace Tyuiu.EgovtsevMN.Sprint1.Task3.V0
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
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Еговцев Максим Николаевич | АСОиУб-23-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Условие:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            double length = 9;
            double width = 7.5;
            double height = 5;
            Console.WriteLine("Введите длину: " + length);
            Console.WriteLine("Введите ширину: " + width);
            Console.WriteLine("Введите высоту: " + height);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Объём параллелепипида = " + ds.ParallelepipedVolume(length, width, height));
            Console.ReadKey();

        }
    }
}
