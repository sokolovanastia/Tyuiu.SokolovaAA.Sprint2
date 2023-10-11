using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaAA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Sin(x) <= 0.5) && (x > 0) && (x <= 0.5) && (y > 0) && (y <= 5))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
