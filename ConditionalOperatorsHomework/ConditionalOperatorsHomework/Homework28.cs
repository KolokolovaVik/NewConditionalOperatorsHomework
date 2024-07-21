using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework28
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "123qwerty";

            for (int i = tryCount; i > 0; i--)
            {
                Console.Write($"Введите пароль для секретного сообщения. У вас есть {i} попытки:");
                string userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Классный сериал: 'Тёмный кристалл: Эпоха сопротивления'");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль неверен. Попробуйте ещё раз!");
                }
            }
        }
    }

}
