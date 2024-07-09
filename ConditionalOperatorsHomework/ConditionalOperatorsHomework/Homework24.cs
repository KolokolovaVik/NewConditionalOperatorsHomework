//using System;

//namespace ConditionalOperatorsHomework
//{
//    internal class Homework24
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            int minRandomNumberRange = 0;
//            int maxRandomNumberRange = 100;
//            int divider1 = 3;
//            int divider2 = 5;
//            Random random = new Random();

//            int randomNumber;

//            randomNumber = random.Next(minRandomNumberRange, maxRandomNumberRange + 1);
//            Console.WriteLine($"Найдём рандомное число не больше {maxRandomNumberRange}.");
//            Console.WriteLine($"Рандомное число: {randomNumber}.");

//            for (int i = 0; i <= randomNumber; i++)
//            {
//                if (i % divider1 == 0 || i % divider2 == 0)
//                {
//                    sum += i;
//                }
//            }

//            Console.WriteLine($"\nСумма положительных чисел меньше {randomNumber}(включая число), " +
//                $"которые кратны {divider1} или {divider2} равна: {sum}");
//        }
//    }
//}
