﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint2.Task1.V14.Lib;
namespace Tyuiu.SokolovaAA.Sprint2.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Соколова А.А. | АСОиУб-23-3";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Логические операции                                                         *");
            Console.WriteLine("* Задание #1                                                                        *");
            Console.WriteLine("* Вариант #14                                                                       *");
            Console.WriteLine("* Выполнил: Соколова Анастасия Александровна | АСОиУб-23-3                          *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций                    *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)            *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность    *");
            Console.WriteLine("* (False, True, True, True, True, False), при a = 185, b = 216, c = 174, d = 917    *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);



            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
