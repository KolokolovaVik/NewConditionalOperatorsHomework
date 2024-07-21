using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework28
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "123qwerty";

            while (tryCount > 0)
            {
                Console.Write($"Введите пароль для секретного сообщения. У вас есть {tryCount} попытки:");
                string userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Классный сериал: 'Тёмный кристалл: Эпоха сопротивления'");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль неверен. Попробуйте ещё раз!");
                    tryCount--;
                }
            }
        }
    }
}
