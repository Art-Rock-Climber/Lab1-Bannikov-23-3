using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 1000;
            float b = 0.0001f;
            float numerator = (float)Math.Pow(a - b, 3) - (float)Math.Pow(a, 3); // Числитель
            float denominator = 3 * a * (float)Math.Pow(b, 2) - (float)Math.Pow(b, 3) - 3 * (float)Math.Pow(a, 2) * b; // Знаменатель
            float ans = numerator / denominator;
            Console.WriteLine($"Ответ для float = {ans}");

            double a1 = 1000;
            double b1 = 0.0001;
            double numerator1 = Math.Pow(a - b, 3) - Math.Pow(a, 3); // Числитель
            double denominator1 = 3 * a * Math.Pow(b, 2) - Math.Pow(b, 3) - 3 * Math.Pow(a, 2) * b; // Знаменатель
            double ans1 = numerator1 / denominator1;
            Console.WriteLine($"Ответ для double = {ans1}");
            Console.WriteLine("Ответы не равны из-за разной точности типов float и double");
        }
    }
}
