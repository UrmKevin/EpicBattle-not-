using System;

namespace EpicBattle_not_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Bald dude from Brazzers", "69 letniy bomz(lvl 69420 Class = wiseman)", "Shrek", "Dungeon Master", "Oleg"};
            string[] villians = {"Buhoy gopnik(lvl 130 Class = thief)", "Lenin(lvl 9999)", "older brother after u took his crisps", "babayka", "C++", "chel s 10000 hr+ v Dota 2", "LGBT blm feminism woman", "Lil Nas X"};
            string[] weapon = { "Bow", "Sword", "Katana", "Cookie", "Pistol", "Bazooka", "Tank", "Knife", "Pen", "Default Dance" };

            string randomHero = GetRandomCharacter(heroes);
            string randomVillian = GetRandomCharacter(villians);
            string randomHeroWeapon = GetWeapon(weapon);
            string randomVillianWeapon = GetWeapon(weapon);

            Console.WriteLine($"UR HERO IS {randomHero}");
            Console.WriteLine($"with {randomHeroWeapon}");
            Console.WriteLine($"UR VILLIAN IS {randomVillian}");
            Console.WriteLine($"with {randomVillianWeapon}");
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
    }
}
