﻿using System;

namespace ConditionalOperatorsHomework
{
    internal class Program22
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            Console.WriteLine("Чтобы завершить программу введите 'exit'");

            while (isWork)
            {
                string exit = "exit";

                string userInput;
                Console.WriteLine("Введите команду:");
                userInput = Console.ReadLine();

                if(userInput == exit)
                {
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели несуществующую команду!");
                }
            }

            Console.WriteLine("Программа завершила своё выполнение!");
        }
    }
}
