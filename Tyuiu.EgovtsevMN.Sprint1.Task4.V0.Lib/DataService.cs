using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.EgovtsevMN.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
            
        {
            var res = (Math.Atan(x) + y) / Math.Exp (x + y);
            

            return res;
        }
    }
}
