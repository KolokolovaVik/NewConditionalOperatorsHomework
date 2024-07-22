//using System;

//namespace ConditionalOperatorsHomework
//{
//    internal class Homework29
//    {
//        static void Main(string[] args)
//        {
//            int minNumber = 50;
//            int maximumNumber = 150;
//            int countNumber = 0;
//            int minNumberRandom = 10;
//            int maxNumberRandom = 26;

//            Random random = new Random();
//            int numberN = random.Next(minNumberRandom, maxNumberRandom);
//            Console.WriteLine($"Рандомное число: {numberN}");

//            for (int i = numberN; i <= maximumNumber; i += numberN)
//            {
//                if (minNumber <= i)
//                {
//                    countNumber += 1;
//                }
//            }
//            Console.WriteLine($"Числа кратные {numberN}, которые больше {minNumber}" +
//                $" и меньше {maximumNumber} в количестве составляют: {countNumber} ");
//        }
//    }

//}
