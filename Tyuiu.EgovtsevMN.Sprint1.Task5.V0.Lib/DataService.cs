using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.EgovtsevMN.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = Math.Pow(x, 2) / Math.Sqrt(x);
            return (int)res;
             
        }
    }
}
