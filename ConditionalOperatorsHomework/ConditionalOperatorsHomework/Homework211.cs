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

            int minAttackBoss = 10;
            int maxAttackBoss = 45;
            int minAttackHero = 25;
            int maxAttackHero = 35;
            int minFireballAttackHero = 10;
            int maxFireballAttackHero = 21;
            int minExplosionAttackHero = 20;
            int maxExplosionAttackHero = 26;

            Random random = new Random();
            int healthBoss = 100;
            int healthHero = 100;
            int attackBoss = random.Next(minAttackBoss, maxAttackBoss);
            int attackHero = random.Next(minAttackHero, maxAttackHero);
            int fireballAttackHero = random.Next(minFireballAttackHero, maxFireballAttackHero);
            int explosionAttackHero = random.Next(minExplosionAttackHero, maxExplosionAttackHero);
            int countMana = fireballAttackHero;

            int initialHealth = healthHero;
            int initialMana = countMana;
            bool isFireballAttack = false;
            int countRecoveries = 2;

            string userInput;

            Console.WriteLine($"Здоровье героя: {healthHero}. Обычный урон: {attackHero}. " +
                       $"Урон огненным шаром: {fireballAttackHero}. Мана: {countMana} " +
                       $"Урон взрывом: {explosionAttackHero}");
            Console.WriteLine($"Здоровье босса: {healthBoss}. Урон от атаки босса: {attackBoss}");

            while (healthBoss > 0 && healthHero > 0)
            {
                Console.WriteLine($"\nВыберите, какую способность использовать герою:" +
                    $"\n{CommandAttackHero} - Нанести обычную атаку." +
                    $"\n{CommandFireballAttackHero} - Нанести атаку огненным шаром (тратит ману). " +
                    $"Способность можно использовать только, когда у героя есть мана." +
                    $"\n{CommandExplosionAttackHero} - Нанести урон взрывом. Может быть нанесён только после использования огненного шара, каждый раз." +
                    $"\n{CommandTreatmentHero} - Лечить здоровье и ману. Осталось {countRecoveries} лечение.");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAttackHero:
                        Console.WriteLine("\nСовершена обычная атака на босса.");
                        healthBoss -= attackHero;
                        break;

                    case CommandFireballAttackHero:
                        if (countMana > 0)
                        {
                            Console.WriteLine("\nСовершена атака на босса огненным шаром.");
                            healthBoss -= fireballAttackHero;
                            countMana -= initialMana;
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

                            template = initialMana - countMana;
                            countMana += template;
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

                healthHero -= attackBoss;
                Console.WriteLine("Босс нанёс удар герою.");

                Console.WriteLine($"\nЗдоровье героя: {healthHero}. Обычный урон: {attackHero}. " +
                   $"Урон огненным шаром: {fireballAttackHero}. Мана {countMana}. " +
                   $"Урон взрывом: {explosionAttackHero}");
                Console.WriteLine($"Здоровье босса: {healthBoss}. Урон от атаки босса: {attackBoss}");
            }

            if (healthBoss <= 0 && healthHero <= 0)
            {
                Console.WriteLine("Ничья!");
            }
            else if (healthBoss <= 0)
            {
                Console.WriteLine($"Босс погиб!");
            }
            else
            {
                Console.WriteLine("Герой погиб!");
            }
        }
    }

}

