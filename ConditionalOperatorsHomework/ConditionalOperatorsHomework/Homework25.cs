using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework25
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            Random random = new Random();

            while (isWork)
            {
                string userInput;
                Console.WriteLine("Добро пожаловать в программу. Введите номер команды:" +
                    "\n1 - Вывести на экран ваши фамилию и имя." +
                    "\n2 - Вывести на экран сегодняшнюю дату и время на вашем компьютере." +
                    "\n3 - Показать случайное число." +
                    "\n4 - Очистить консоль." +
                    "\n5 - Выход из программы.");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Как вас зовут?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите вашу фамилию:");
                        string surname = Console.ReadLine();
                        Console.WriteLine($"Вас зовут: {name}. Ваша фамилия: {surname}");
                        break;
                    case "2":
                        Console.WriteLine($"Дата и время на компьютере:{DateTime.Now}");
                        break;
                    case "3":
                        Console.WriteLine($"Рандомное число: {random.Next()}");
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        isWork = false;
                        break;
                }
            }
        }
    }
}
