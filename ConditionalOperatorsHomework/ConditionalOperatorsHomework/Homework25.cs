using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework25
    {
        static void Main(string[] args)
        {
            const string CommandShowText = "1";
            const string CommandShowDateTimeNow = "2";
            const string CommandShowRandomNumber = "3";
            const string CommandClearConsole = "4";
            const string CommandExit = "5";

            bool isWork = true;
            Random random = new Random();

            while (isWork)
            {
                string userInput;
                Console.WriteLine("Добро пожаловать в программу. Введите номер команды:" +
                    $"\n{CommandShowText} - Вывести на экран ваши фамилию и имя." +
                    $"\n{CommandShowDateTimeNow} - Вывести на экран сегодняшнюю дату и время на вашем компьютере." +
                    $"\n{CommandShowRandomNumber} - Показать случайное число." +
                    $"\n{CommandClearConsole} - Очистить консоль." +
                    $"\n{CommandExit} - Выход из программы.");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case CommandShowText:
                        Console.WriteLine("Как вас зовут?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите вашу фамилию:");
                        string surname = Console.ReadLine();
                        Console.WriteLine($"Вас зовут: {name}. Ваша фамилия: {surname}");
                        break;
                    case CommandShowDateTimeNow:
                        Console.WriteLine($"Дата и время на компьютере:{DateTime.Now}");
                        break;
                    case CommandShowRandomNumber:
                        Console.WriteLine($"Рандомное число: {random.Next()}");
                        break;
                    case CommandClearConsole:
                        Console.Clear();
                        break;
                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Программа завершила своё выполнение.");
                        break;
                    default:
                        Console.WriteLine("Такой команды нет!");
                        break;
                }
            }
        }
    }
}
