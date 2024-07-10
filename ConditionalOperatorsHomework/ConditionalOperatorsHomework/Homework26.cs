using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework26
    {
        static void Main(string[] args)
        {
            const string CommandRubToUsd = "1";
            const string CommandRubToEur = "2";
            const string CommandUsdToRub = "3";
            const string CommandEurToRub = "4";
            const string CommandUsdToEur = "5";
            const string CommandEurToUsd = "6";
            const string CommandExit = "7";

            bool isWork = true;

            float BalanceUsd = 10;
            float BalanceRub = 500;
            float BalanceEur = 5;

            float rubToUsd = 86;
            float usdToRub = 84;
            float rubToEur = 97;
            float eurTorub = 90;
            float usdToEur = 0.92f;
            float eurToUsd = 1;

            while (isWork)
            {
                float amountExchanged;

                Console.WriteLine($" На счету у вас: {BalanceUsd} долларов. {BalanceRub} рублей. {BalanceEur} евро.\n");
                Console.WriteLine($"Введите команду для программы:" +
                    $"\n{CommandRubToUsd} - Конвертиция рублей в доллары." +
                    $"\n{CommandRubToEur} - Конвертация рублей в евро." +
                    $"\n{CommandUsdToRub} - Конвертация долларов в рубли." +
                    $"\n{CommandEurToRub} - Конвертация евро в рубли." +
                    $"\n{CommandUsdToEur} - Конвертация долларов в евро." +
                    $"\n{CommandEurToUsd} - Конвертация евро в доллары." +
                    $"\n{CommandExit} - Выход из программы.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandRubToUsd:
                        Console.WriteLine("Сколько рублей на доллары вы хотите поменять?");
                        amountExchanged = Convert.ToSingle(Console.ReadLine());
                        if (amountExchanged <= BalanceRub && amountExchanged > 0)
                        {
                            BalanceUsd += amountExchanged / rubToUsd;
                            BalanceRub -= amountExchanged;
                        }
                        else
                        {
                            Console.WriteLine($"Недостаточно рублей для обмена. Вы хотите обменят {amountExchanged} рублей," +
                                $" а на вашем счёте {BalanceRub} рублей.");
                        }
                        break;

                    case CommandRubToEur:
                        Console.WriteLine("Сколько рублей в евро вы хотите поменять?");
                        amountExchanged = Convert.ToSingle(Console.ReadLine());
                        if (amountExchanged <= BalanceRub && amountExchanged > 0)
                        {
                            BalanceEur += amountExchanged / rubToEur;
                            BalanceRub -= amountExchanged;
                        }
                        else
                        {
                            Console.WriteLine($"Недостаточно рублей для обмена. Вы хотите обменят {amountExchanged} рублей," +
                                $" а на вашем счёте {BalanceRub} рублей.");
                        }
                        break;

                    case CommandUsdToRub:
                        Console.WriteLine("Сколько долларов на рубли вы хотите обменять?");
                        amountExchanged = Convert.ToSingle(Console.ReadLine());
                        if (amountExchanged <= BalanceUsd && amountExchanged > 0)
                        {
                            BalanceRub += amountExchanged * usdToRub;
                            BalanceUsd -= amountExchanged;
                        }
                        else
                        {
                            Console.WriteLine($"Недостаточно долларов для обмена. Вы хотите обменят {amountExchanged} долларов," +
                                $" а на вашем счёте {BalanceUsd} долларов.");
                        }
                        break;

                    case CommandEurToRub:
                        Console.WriteLine("Сколько евро на рубли вы хотите обменять?");
                        amountExchanged = Convert.ToSingle(Console.ReadLine());
                        if (amountExchanged <= BalanceEur && amountExchanged > 0)
                        {
                            BalanceRub += BalanceEur * eurTorub;
                            BalanceEur -= amountExchanged;
                        }
                        else
                        {
                            Console.WriteLine($"Недостаточно евро для обмена на рубли. У вас {BalanceEur} евро," +
                                $" а вы хотите поменять {amountExchanged} евро.");
                        }
                        break;

                    case CommandUsdToEur:
                        Console.WriteLine("Сколько долларов вы хотите обменять на евро?");
                        amountExchanged = Convert.ToSingle(Console.ReadLine());
                        if (amountExchanged <= BalanceUsd && amountExchanged > 0)
                        {
                            BalanceEur += amountExchanged / usdToEur;
                            BalanceUsd -= amountExchanged;
                        }
                        else
                        {
                            Console.WriteLine($"У вас недостаточно долларов. У вас {BalanceUsd}, " +
                                $"а вы хотите поменять {amountExchanged} долларов.");
                        }
                        break;

                    case CommandEurToUsd:
                        Console.WriteLine("Сколько евро вы хотите поменять на доллары?");
                        amountExchanged = Convert.ToSingle(Console.ReadLine());
                        if (amountExchanged <= BalanceEur && amountExchanged > 0)
                        {
                            BalanceUsd += amountExchanged * eurToUsd;
                            BalanceEur -= amountExchanged;
                        }
                        else
                        {
                            Console.WriteLine($"У вас недостаточно евро. У вас {BalanceEur}," +
                                $" а вы хотите поменять {amountExchanged} евро.");
                        }
                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Такой команды не существует. Попробуйте ещё раз!");
                        break;
                }
            }
        }
    }
}
