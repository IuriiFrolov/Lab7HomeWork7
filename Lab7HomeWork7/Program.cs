using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {// Задача №1 Сравниваются площади двух треугольников
            Console.WriteLine("Введите длины сторон 1 треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double S1= GetParam(x1,y1,z1);
            Console.WriteLine("Площадь  1 треугольника = {0}",S1);
            Console.WriteLine("Введите длины сторон 2 треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S2 = GetParam(x2,y2,z2);
            Console.WriteLine("Площадь  2 треугольника = {0}", S2);
            // Вывод ответа
            Console.WriteLine();
            if (S1>S2)
            {
                Console.WriteLine("Площадь 1 треугольника больше");
            }
            else if (S1 < S2)
            {
                Console.WriteLine("Площадь 2 треугольника больше");
            }
            else if (S1==S2)
            {
                Console.WriteLine("Площадь 1 и 2 треугольников равны");
            }
            else Console.WriteLine("Ошибка ввода данных. Ошибка допущена в треугольнике площадь которого = не число ");
            Console.ReadKey();
        }
        static double GetParam(double a, double b, double c)
        { // Метод считает площадь треугольника по формуле Герона
            double S;
            double p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S ;
        }
    }
}
