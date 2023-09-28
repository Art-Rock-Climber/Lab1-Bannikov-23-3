using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x "); // Ввод x
            string inputX = Console.ReadLine();
            bool isCorrect = double.TryParse(inputX, out var x);
            while (!isCorrect)
            {
                Console.Write("Введите x ");
                inputX = Console.ReadLine();
                isCorrect = double.TryParse(inputX, out x);
            }

            Console.Write("Введите y "); // Ввод y
            string inputY = Console.ReadLine();
            isCorrect = double.TryParse(inputY, out var y);
            while (!isCorrect)
            {
                Console.Write("Введите y ");
                inputY = Console.ReadLine();
                isCorrect = double.TryParse(inputY, out y);
            }

            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
                Console.WriteLine("Точка лежит внутри указанной области");
            else
                Console.WriteLine("Точка не лежит внутри указанной области");
        }
    }
}
