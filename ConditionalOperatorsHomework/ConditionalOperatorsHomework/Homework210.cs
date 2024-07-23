using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework210
    {
        static void Main(string[] args)
        {
            int exponent = 1;
            int baseNumber = 2;
            int result = 1;

            Random random = new Random();
            int randomNumber = random.Next();

            Console.WriteLine($"Рандомное число: {randomNumber}");

            for (int i = exponent; result <= randomNumber; i++)
            {
                result *= baseNumber;
                exponent = i;
            }
            Console.WriteLine($"Следующее число двойки: {result}. {baseNumber} в степени {exponent}.");
        }
    }

}
