using System;

namespace ConditionalOperatorsHomework
{
    internal class Homework211
    {
        static void Main(string[] args)
        {
            const string CommandAttackHero = "1";
            const string CommandFireballAttackHero = "2";
            const string CommandExplosionAttackHero = "3";
            const string CommandTreatmentHero = "4";

            Random random = new Random();
            int healthBoss = 100;
            int healthHero = 100;
            int attackBoss = random.Next(10, 45);
            int attackHero = random.Next(25, 35);
            int fireballAttackHero = random.Next(10, 21);
            int explosionAttackHero = random.Next(20, 26);
            bool isBattle = true;

            int initialHealth = healthHero;
            int initialMana = fireballAttackHero;
            bool isFireballAttack = false;
            int countRecoveries = 2;

            Console.WriteLine($"Здоровье героя: {healthHero}. Обычный урон: {attackHero}. " +
                       $"Урон огненным шаром: {fireballAttackHero}. " +
                       $"Урон взрывом: {explosionAttackHero}");
            Console.WriteLine($"Здоровье босса: {healthBoss}. Урон от атаки босса: {attackBoss}");

            while (isBattle)
            {
                string userInput;

                if (healthBoss > 0 && healthHero > 0)
                {
                    healthHero -= attackBoss;
                    Console.WriteLine("\nБосс нанёс удар герою.");

                    Console.WriteLine($"\nВыберите, какую способность использовать герою:" +
                        $"\n{CommandAttackHero} - нанести обычную атаку." +
                        $"\n{CommandFireballAttackHero} - нанести атаку огненным шаром (тратит ману). " +
                        $"Способность можно использовать только, когда у героя есть сила." +
                        $"\n{CommandExplosionAttackHero} - нанести урон взрывом. Может быть нанесён только после использования огненного шара, каждый раз." +
                        $"\n{CommandTreatmentHero} - Лечить здоровье и ману. Осталось {countRecoveries} лечение.");

                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case CommandAttackHero:
                            Console.WriteLine("\nСовершена обычная атака на босса.");
                            healthBoss -= attackHero;
                            break;

                        case CommandFireballAttackHero:
                            if (fireballAttackHero > 0)
                            {
                                Console.WriteLine("\nСовершена атака на босса огненным шаром.");
                                healthBoss -= fireballAttackHero;
                                fireballAttackHero -= fireballAttackHero;
                                isFireballAttack = true;
                            }
                            else
                            {
                                Console.WriteLine("\nНедостаточно маны для удара огненным шаром.");
                            }
                            break;

                        case CommandExplosionAttackHero:
                            if (isFireballAttack == true)
                            {
                                Console.WriteLine("\nСовершена атака на босса взрывом.");
                                healthBoss -= explosionAttackHero;
                                isFireballAttack = false;
                            }
                            else
                            {
                                Console.WriteLine("\nВзрыв можно сделать только после огненного шара.");
                            }
                            break;

                        case CommandTreatmentHero:
                            if (countRecoveries > 0)
                            {
                                Console.WriteLine("\nГерой восстановил здоровье и ману.");
                                int template = initialHealth - healthHero;
                                healthHero += template;

                                template = initialMana - fireballAttackHero;
                                fireballAttackHero += template;
                                countRecoveries--;
                            }
                            else
                            {
                                Console.WriteLine("Герой исчерплал лимит лечения. Дерись сам!");
                            }
                            break;

                        default:
                            Console.WriteLine("Такой способности не сущестует.");
                            break;
                    }

                    Console.WriteLine($"Здоровье героя: {healthHero}. Обычный урон: {attackHero}. " +
                       $"Урон огненным шаром: {fireballAttackHero}. " +
                       $"Урон взрывом: {explosionAttackHero}");
                    Console.WriteLine($"Здоровье босса: {healthBoss}. Урон от атаки босса: {attackBoss}");
                }
                else
                {
                    isBattle = false;
                }
            }

            if (healthBoss <= 0 && healthHero <= 0)
            {
                Console.WriteLine("Ничья!");
            }
            else if (healthBoss <= 0)
            {
                Console.WriteLine($"Босс погиб!");
            }
            else if (healthHero <= 0)
            {
                Console.WriteLine("Герой погиб!");
            }
        }
    }

}

