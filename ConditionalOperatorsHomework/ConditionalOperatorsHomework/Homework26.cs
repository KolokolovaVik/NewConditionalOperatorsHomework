//using System;

//namespace ConditionalOperatorsHomework
//{
//    internal class Homework26
//    {
//        static void Main(string[] args)
//        {
//            const string CommandRubToUsd = "1";
//            const string CommandRubToEur = "2";
//            const string CommandUsdToRub = "3";
//            const string CommandEurToRub = "4";
//            const string CommandUsdToEur = "5";
//            const string CommandEurToUsd = "6";
//            const string CommandExit = "7";

//            bool isWork = true;

//            float balanceUsd = 10;
//            float balanceRub = 500;
//            float balanceEur = 5;

//            float dollarPurchaseRate = 86;
//            float dollarSellingRate = 90;
//            float euroPurchaseRate = 97;
//            float euroSellingRate = 102;
//            float dollarExchangeRate = 87;
//            float euroExchangeRate = 95;

//            float rubToUsd = 1f / dollarPurchaseRate;
//            float usdToRub = dollarSellingRate;
//            float rubToEur = 1f / euroPurchaseRate;
//            float eurTorub = euroSellingRate;
//            float usdToEur = dollarExchangeRate / euroExchangeRate;
//            float eurToUsd = euroExchangeRate / dollarExchangeRate;

//            while (isWork)
//            {
//                float amountExchanged;

//                Console.WriteLine($" На счету у вас: {balanceUsd} долларов. {balanceRub} рублей. {balanceEur} евро.\n");
//                Console.WriteLine($"Введите команду для программы:" +
//                    $"\n{CommandRubToUsd} - Конвертиция рублей в доллары." +
//                    $"\n{CommandRubToEur} - Конвертация рублей в евро." +
//                    $"\n{CommandUsdToRub} - Конвертация долларов в рубли." +
//                    $"\n{CommandEurToRub} - Конвертация евро в рубли." +
//                    $"\n{CommandUsdToEur} - Конвертация долларов в евро." +
//                    $"\n{CommandEurToUsd} - Конвертация евро в доллары." +
//                    $"\n{CommandExit} - Выход из программы.");
//                string userInput = Console.ReadLine();

//                switch (userInput)
//                {
//                    case CommandRubToUsd:
//                        Console.WriteLine("Сколько рублей на доллары вы хотите поменять?");
//                        amountExchanged = Convert.ToSingle(Console.ReadLine());

//                        if (amountExchanged <= balanceRub && amountExchanged > 0)
//                        {
//                            balanceUsd += amountExchanged * rubToUsd;
//                            balanceRub -= amountExchanged;
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Недостаточно рублей для обмена. Вы хотите обменят {amountExchanged} рублей," +
//                                $" а на вашем счёте {balanceRub} рублей.");
//                        }
//                        break;

//                    case CommandRubToEur:
//                        Console.WriteLine("Сколько рублей в евро вы хотите поменять?");
//                        amountExchanged = Convert.ToSingle(Console.ReadLine());

//                        if (amountExchanged <= balanceRub && amountExchanged > 0)
//                        {
//                            balanceEur += amountExchanged * rubToEur;
//                            balanceRub -= amountExchanged;
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Недостаточно рублей для обмена. Вы хотите обменят {amountExchanged} рублей," +
//                                $" а на вашем счёте {balanceRub} рублей.");
//                        }
//                        break;

//                    case CommandUsdToRub:
//                        Console.WriteLine("Сколько долларов на рубли вы хотите обменять?");
//                        amountExchanged = Convert.ToSingle(Console.ReadLine());
//                        if (amountExchanged <= balanceUsd && amountExchanged > 0)
//                        {
//                            balanceRub += amountExchanged * usdToRub;
//                            balanceUsd -= amountExchanged;
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Недостаточно долларов для обмена. Вы хотите обменят {amountExchanged} долларов," +
//                                $" а на вашем счёте {balanceUsd} долларов.");
//                        }
//                        break;

//                    case CommandEurToRub:
//                        Console.WriteLine("Сколько евро на рубли вы хотите обменять?");
//                        amountExchanged = Convert.ToSingle(Console.ReadLine());

//                        if (amountExchanged <= balanceEur && amountExchanged > 0)
//                        {
//                            balanceRub += balanceEur * eurTorub;
//                            balanceEur -= amountExchanged;
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Недостаточно евро для обмена на рубли. У вас {balanceEur} евро," +
//                                $" а вы хотите поменять {amountExchanged} евро.");
//                        }
//                        break;

//                    case CommandUsdToEur:
//                        Console.WriteLine("Сколько долларов вы хотите обменять на евро?");
//                        amountExchanged = Convert.ToSingle(Console.ReadLine());

//                        if (amountExchanged <= balanceUsd && amountExchanged > 0)
//                        {
//                            balanceEur += amountExchanged * usdToEur;
//                            balanceUsd -= amountExchanged;
//                        }
//                        else
//                        {
//                            Console.WriteLine($"У вас недостаточно долларов. У вас {balanceUsd}, " +
//                                $"а вы хотите поменять {amountExchanged} долларов.");
//                        }
//                        break;

//                    case CommandEurToUsd:
//                        Console.WriteLine("Сколько евро вы хотите поменять на доллары?");
//                        amountExchanged = Convert.ToSingle(Console.ReadLine());

//                        if (amountExchanged <= balanceEur && amountExchanged > 0)
//                        {
//                            balanceUsd += amountExchanged * eurToUsd;
//                            balanceEur -= amountExchanged;
//                        }
//                        else
//                        {
//                            Console.WriteLine($"У вас недостаточно евро. У вас {balanceEur}," +
//                                $" а вы хотите поменять {amountExchanged} евро.");
//                        }
//                        break;

//                    case CommandExit:
//                        isWork = false;
//                        break;

//                    default:
//                        Console.WriteLine("Такой команды не существует. Попробуйте ещё раз!");
//                        break;
//                }
//            }
//        }
//    }
//}
