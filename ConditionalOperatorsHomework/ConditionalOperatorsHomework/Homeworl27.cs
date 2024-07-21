using System;

namespace ConditionalOperatorsHomework
{
    internal class Homeworl27
    {
        static void Main(string[] args)
        {
            string symbolBoundary = "";

            Console.Write("Введите символ для вывода:");
            string symbol = Console.ReadLine();
            Console.Write("Введите имя для вывода:");
            string name = Console.ReadLine();
            string outputText = symbol + name + symbol;

            for (int i = 0; i < outputText.Length; i++)
            {
                symbolBoundary += symbol;
            }

            Console.WriteLine(symbolBoundary);
            Console.WriteLine(outputText);
            Console.WriteLine(symbolBoundary);
        }
    }
}
