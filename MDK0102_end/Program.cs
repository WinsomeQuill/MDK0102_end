using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK0102_end
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            ModuleS(50.0, 50.0);
            ModuleA(10, 10);
            Console.ReadKey();
        }

        static void ModuleS(double x, double y)
        {
            double z = Math.Sin((Math.Sqrt(x / 3))) + (Math.Cos(Math.Sqrt(Math.Abs(x - y))));
            Console.WriteLine(z);
        }

        static void ModuleA(double x, double y)
        {
            double z = Math.Sqrt((Math.Abs(Math.Sqrt(x)+2*x+1) / 3*x*y) + 2*x*y - (Math.Abs(x+2*y)/Math.Sqrt(2*x*y)));
            Console.WriteLine(z);
        }
    }
}
