using System;


namespace Task09_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 21. Задание 1");
            Console.WriteLine("Введите n");
 
            int n = int.Parse(Console.ReadLine());
            double finalCount = 0;

            for (int i = 1; i <= n; i++)
                finalCount += 1.0 / i;

            Console.WriteLine(finalCount + "\n");




            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите n");

            int nSecondTask = int.Parse(Console.ReadLine());
            int firstFibonacciNumber = 1;
            int secondFibonacciNumber = 1;
            int iSecondTask = 3;

            while (iSecondTask <= nSecondTask)
            {
                int copyFirstFibonacciNumber = firstFibonacciNumber;
                firstFibonacciNumber = secondFibonacciNumber;
                secondFibonacciNumber += copyFirstFibonacciNumber;
                iSecondTask++;
            }

            Console.WriteLine(secondFibonacciNumber + "\n");




            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число");

            int naturalNumber = int.Parse(Console.ReadLine());
            int result = 0;

            for(int i=2; i < naturalNumber; i++)
                if(naturalNumber % i == 0)
                {
                    result = i;
                    break;
                }

            Console.WriteLine(result + "\n");




            Console.WriteLine("Задание 4");
            int bullNumber = 0;
            int cowNumber = 0;
            int calfNumber=0;

            for (bullNumber=1; bullNumber <= 100/10+1; bullNumber++)
            {
                for(cowNumber=1; cowNumber<=100/5+1; cowNumber++)
                {
                    calfNumber = 100 - bullNumber - cowNumber;

                    if (bullNumber * 10 + cowNumber * 5 + calfNumber * 0.5 == 100)
                        Console.WriteLine("быки: " + bullNumber + " коровы: " + cowNumber + " телята: " + calfNumber);

                }
            }



            Console.ReadKey();
        }
    }
}
