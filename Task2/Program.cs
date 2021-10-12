using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {// Определение объема и площади поверхности куба по длине ребра
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double V, S;

            GetParam(a, out V, out S);

            Console.WriteLine("Объем куба ={0}", V);
            Console.WriteLine("Площадь поверхности ={0}", S);
            Console.ReadKey();
        }

        static void GetParam(double a, out double V, out double S)
        {
            V = a * a * a;
            S = 6 * a * a;
        }


    }
}
