using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.SokolovaAA.Sprint2.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Соколова А.А. | АСОиУб-23-3";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                               *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #20                                                                       *");
            Console.WriteLine("* Выполнил: Соколова Анастасия Александровна| АСОиУб-23-3                           *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с              *");
            Console.WriteLine("* использованием вложенных операторов if-else, где пользователь вводит значение     *");
            Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков после     *");
            Console.WriteLine("* запятой.                                                                          *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            double x;

            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            double y = Math.Round(ds.Calculate(x), 3);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
