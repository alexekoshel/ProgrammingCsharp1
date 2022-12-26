using System;


namespace ConsoleApplication1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите значение N");
            var N = int.Parse(Console.ReadLine());
            var result = permutation(N-1);

            foreach (var i in result)
            {
                switch (i)
                {
                    case 1:
                        Console.Write("a");
                        break;
                    case 2:
                        Console.Write("b");
                        break;
                    case 3:
                        Console.Write("c");
                        break;
                    case 4:
                        Console.Write("d");
                        break;
                    case 5:
                        Console.Write("e");
                        break;
                    case 6:
                        Console.Write("f");
                        break;
                    case 7:
                        Console.Write("g");
                        break;
                    case 8:
                        Console.Write("h");
                        break;
                    case 9:
                        Console.Write("i");
                        break;
                    case 10:
                        Console.Write("j");
                        break;
                    case 11:
                        Console.Write("k");
                        break;
                    case 12:
                        Console.Write("l");
                        break;

                }
            }
            Console.ReadKey();
        }

        public static int factorial(int num)
        {
            var res = 1;
            if (num != 0)
                for (var i = 1; i < num + 1; i++)
                    res *= i;
            else return 1;
            return res;
        }


        public static int[] permutation(int number)
        {
            var number1 = number;
            var res = new int[13];
            var free = new bool[13]
                { true, true, true, true, true,true, true, true, true, true,true, true, true,};
            for (var i = 1; i < 13; i++)
            {
                var fact = factorial(12 - i);
                var num_perm = number1 / fact;
                number1 = number1 % fact;
                var count = 0;
                for (var j = 1; j < 13; j++)
                {
                    if (free[j])
                    {
                        count += 1;
                        if (count - 1 == num_perm)
                        {
                            free[j] = false;
                            res[i] = j;
                        }
                    }
                }
            }

            return res;
        }
    }
}