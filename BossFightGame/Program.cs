using System;

namespace BossFightGame;

public class Program
{
    static void Main(string[] args)
    {

        bool gameActive = true;

        Random random = new Random();

        // Hero
        GameCharacter hero = new GameCharacter();
        hero.health = 100;
        hero.strength = 20;
        hero.stamina = 40;

        // Boss
        GameCharacter boss = new GameCharacter();
        boss.health = 400;
        boss.strength = random.Next(0, 31);
        boss.stamina = 10;

        Console.WriteLine("---BOSS FIGHT---");
        Console.WriteLine("F is for Fight, H is for heal. Good luck!");

        while (gameActive)
        {
            string userInput = Console.ReadLine();
            if (userInput != "f" && userInput != "h")
            {
                Console.WriteLine("Unknown command, please press f or h.");
                gameActive = false;
            }
            else
            {
                Fight();
                Console.ReadLine();

            }
        }
    }

    static void Fight()
    {
        Random random = new Random();

        GameCharacter hero = new GameCharacter();
        hero.health = 100;
        hero.strength = 20;
        hero.stamina = 40;

        GameCharacter boss = new GameCharacter();
        boss.health = 400;
        boss.strength = random.Next(0, 31);
        boss.stamina = 10;

        hero.health -= boss.strength;
        Console.WriteLine("Boss hit hero with " + boss.strength + " damage, hero now has " + hero.health + " left.");

    }
}