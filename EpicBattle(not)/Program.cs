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

            string randomHero = GetRandomCharacter(heroes);
            string randomVillain = GetRandomCharacter(villains);
            string randomHeroWeapon = GetWeapon(weapons);
            string randomVillainWeapon = GetWeapon(weapons);

            Console.WriteLine($"UR HERO IS {randomHero}");
            Console.WriteLine($"with {randomHeroWeapon}");
            Console.WriteLine($"UR VILLIAN IS {randomVillain}");
            Console.WriteLine($"with {randomVillainWeapon}");
        }

        public static string GetRandomCharacter(string[] someArray)
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

    }
}
