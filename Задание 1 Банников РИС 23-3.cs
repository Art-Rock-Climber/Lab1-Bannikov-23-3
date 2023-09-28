using System.IO.Pipes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n "); // Ввод n
            string inputN = Console.ReadLine();
            bool isCorrect  = double.TryParse(inputN, out var n);
            while (!isCorrect)
            {
                Console.Write("Введите n ");
                inputN = Console.ReadLine();
                isCorrect = double.TryParse(inputN, out n);
            }

            Console.Write("Введите m "); // Ввод m
            string inputM = Console.ReadLine();
            isCorrect = double.TryParse(inputM, out var m);
            while (!isCorrect)
            {
                Console.Write("Введите m ");
                inputM = Console.ReadLine();
                isCorrect = double.TryParse(inputM, out m);
            }

            double ans1 = n++ * m; // 1) n++ * m
            bool ans2 = n++ < m; // 2) n++ < m
            bool ans3 = --m > n; // 3) --m > n

            Console.Write("Введите x "); // Ввод x
            string inputX = Console.ReadLine();
            isCorrect = double.TryParse(inputX, out var x);
            while (!isCorrect)
            {
                Console.Write("Введите x ");
                inputM = Console.ReadLine();
                isCorrect = double.TryParse(inputX, out x);
            }

            double ans4 = Math.Cbrt(x - Math.Pow(x, 2) + Math.Pow(x, 5)); // 4) (x - x^2 + x^5) ^ 1/3

            Console.WriteLine($"1) n++ * m = {ans1}");
            Console.WriteLine($"2) n++ < m = {ans2}");
            Console.WriteLine($"3) --m > n = {ans3}");
            Console.WriteLine($"4) (x - x^2 + x^5) ^ 1/3 = {ans4}");
        }
    }
}
