using System;
using System.IO;

namespace EpicBattle_not_
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootPath = @"C:\Users\opilane\Samples\";
            string[] heroes = GetDataFromFile(rootPath + "heroes.txt");
            string[] villains = GetDataFromFile(rootPath + "villains.txt");
            string[] weapons = GetDataFromFile(rootPath + "weapons.txt");
            string[] armor = GetDataFromFile(rootPath + "armor.txt");

            string randomHero = GetRandomElement(heroes);
            string randomVillain = GetRandomElement(villains);
            string randomHeroWeapon = GetWeapon(weapons);
            string randomVillainWeapon = GetWeapon(weapons);
            string heroArmor = GetRandomElement(armor);
            string villainArmor = GetRandomElement(armor);
            int heroHP = GenerateHP(heroArmor);
            int villainHP = GenerateHP(villainArmor);


            Console.WriteLine($"{randomHero} in {heroArmor} with {heroHP} HP");
            Console.WriteLine("             V/S             ");
            Console.WriteLine($"{randomVillain} in {villainArmor} with {villainHP} HP");

            while (heroHP >= 0 && villainHP >= 0)
            {
                heroHP = heroHP - Hit(randomVillain, randomVillainWeapon);
                villainHP = villainHP - Hit(randomHero, randomHeroWeapon);
            }

            if(heroHP > villainHP)
            {
                Console.WriteLine($"{randomHero} saves the day!");
            } else if(heroHP < villainHP)
            {
                Console.WriteLine($"Dark side wins!");
            }
            else
            {
                Console.WriteLine($"Both {randomHero} and {randomVillain} dropped dead.");
            }

        }

        public static string GetRandomElement(string[] someArray)
        {
            return someArray[GetRandomIndex(someArray)];
        }

        public static string GetWeapon(string[] someArray)
        {
            return someArray[GetRandomIndex(someArray)];
        }

        public static int GetRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }

        public static string[] GetDataFromFile(string filePath)
        {
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }

        public static int GenerateHP(string armor)
        {
            return armor.Length;
        }

        public static int Hit(string character, string weapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, weapon.Length - 2);
            Console.WriteLine($"{character} hit {strike}.");

            if (strike==0)
            {
                Console.WriteLine($"Bad luck. {character} missed the target");
            } else if(strike == weapon.Length - 2)
            {
                Console.WriteLine($"Awesome! {character} made a critical hit!");
            }

            return strike;
        }

    }
}
