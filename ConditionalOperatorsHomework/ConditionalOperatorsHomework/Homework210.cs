using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework210
    {
        static void Main(string[] args)
        {
            int baseNumber = 2;
            int exponent = 1;
            int result = 1;

            Random random = new Random();
            int randomNumber = random.Next();

            Console.WriteLine($"Рандомное число: {randomNumber}");

            for (int i = exponent; i <= randomNumber; i++)
            {
                result *= baseNumber;

                if (randomNumber <= result)
                {
                    if (randomNumber == result)
                    {
                        result *= baseNumber;
                        i++;
                    }
                    Console.WriteLine($"Следующее число двойки: {result}. {baseNumber} в степени {i}.");
                    break;
                }
            }
        }
    }

}
