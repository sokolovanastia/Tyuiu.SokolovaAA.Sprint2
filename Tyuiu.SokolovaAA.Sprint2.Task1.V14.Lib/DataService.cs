using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaAA.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (d < c);
            res[1] = (a < b) & (d > c);
            res[2] = (a > b) || (d >= c);
            res[3] = (a < b) && (d > c);
            res[4] = !(res[0]);
            res[5] = (a == b) ^ (c >= d);
            return res;
        }
    }
}
