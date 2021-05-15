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
            while (true)
            {
                try
                {
                    Console.Write("Введите число А: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите число B: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Первый ответ: ");
                    ModuleS(a, b);
                    Console.Write("Второй ответ: ");
                    ModuleA(a, b);
                }
                catch(FormatException)
                {
                    Console.WriteLine("<ERROR> Неверный формат числа!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("<ERROR> {0}", e);
                }
            }
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
