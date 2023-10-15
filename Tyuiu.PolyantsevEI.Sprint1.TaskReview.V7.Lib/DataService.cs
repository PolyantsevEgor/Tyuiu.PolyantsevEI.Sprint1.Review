using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PolyantsevEI.Sprint1.TaskReview.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((Math.Cos(x) / (Math.PI - 2 * Math.Pow(y, x))) + 16 * x * Math.Cos(y * x) - 2, 3);
        }
    }
}
