using System;

namespace ConditionalOperatorsHomework
{
    internal class Homeworl27
    {
        static void Main(string[] args)
        {
            int additionalNumberCharacters = 2;

            Console.Write("Введите символ для вывода:");
            string symbol = Console.ReadLine();
            Console.Write("Введите имя для вывода:");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length + additionalNumberCharacters; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine($"\n{symbol}{name}{symbol}");

            for (int i = 0; i < name.Length + additionalNumberCharacters; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
