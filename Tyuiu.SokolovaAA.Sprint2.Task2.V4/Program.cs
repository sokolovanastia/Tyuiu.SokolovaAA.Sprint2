using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint2.Task2.V4.Lib;
namespace Tyuiu.SokolovaAA.Sprint2.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x;
            int y;

            Console.Title = "Спринт #2 | Выполнил: Соколова А.А. | АСОиУб-23-3";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Логические операции                                                         *");
            Console.WriteLine("* Задание #1                                                                        *");
            Console.WriteLine("* Вариант #14                                                                       *");
            Console.WriteLine("* Выполнил: Соколова Анастасия Александровна | АСОиУб-23-3                          *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры               *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной области.       *");
            Console.WriteLine("*                                                                                   *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение переменной х: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение переменной y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res == true)
                Console.WriteLine("Точка с данными координатами является заштрихованной");
            else
                Console.WriteLine("Точка с данными координатами не является заштрихованной");
            Console.ReadKey();
        }
    }
}
