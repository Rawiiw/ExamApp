
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    internal class Calculations
    {
        public List<string> CalculationSumSeries(double x, double eps)
        {
            List<string>result = new List<string>();
            double a = x;
            int n = 1;
            double sum = 0;
            while (Math.Abs(a * (2 * x * x) / (2 * n - 1) * 2 * n * (-1)) > 0) 
                {
                a=a*(2*x*x) / ((2*n - 1) * (2*n-1) * 2 * n * (-1));
                sum=sum*a;
                string finishResult = n.ToString() + " ) a =" + a.ToString();
                result.Add(finishResult);  
                n++;
            }
            return result;
        }
    }
}
