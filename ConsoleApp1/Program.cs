using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            if ((a < b) && (b > 9))

            {

                a *= 2;

                b *= 3;

            }

            else

            {

                a -= 3; b += 6;

            }

            Console.WriteLine(b + a);
        }
    }
}
