using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK0102_UI
{
    class MathManager
    {
        public double ModuleS(double x, double y)
        {
            double z = Math.Round(Math.Sin((Math.Sqrt(x / 3))) + (Math.Cos(Math.Sqrt(Math.Abs(x - y)))), 4);
            return z;
        }

        public double ModuleA(double x, double y)
        {
            double z = Math.Round(Math.Sqrt((Math.Abs(Math.Sqrt(x) + 2 * x + 1) / 3 * x * y) + 2 * x * y - (Math.Abs(x + 2 * y) / Math.Sqrt(2 * x * y))), 4);
            return z;
        }
    }
}
