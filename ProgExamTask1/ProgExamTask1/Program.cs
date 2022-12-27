using System;


namespace ProgExamTask1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Задание 1. Разложение числа на простые множители");
            Console.WriteLine("Введите натуральное число");

            var number = int.Parse(Console.ReadLine());
            var printResult = $"{number} =";

            for (int i = 2; number > 1; i++)
            {
                if (!IsNumberSimple(i)) continue;
                if (number % i != 0) continue;
                var degree = 0;
                while (number % i == 0)
                {
                    number /= i;
                    degree++;
                }

                printResult += degree == 1 ? $" {i} *" : $" {i}^{degree} *";
            }

            Console.WriteLine($"{printResult}".Remove(printResult.Length-1));

            Console.ReadKey();
        }

        private static bool IsNumberSimple(int number)
        {
            var count = 0;

            for (var i = 1; i <= number; i++)
                if (number % i == 0)
                    count++;

            return count == 2;
        }
    }
}