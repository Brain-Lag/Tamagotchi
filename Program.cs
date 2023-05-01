using System;
using System.Collections.Generic;
using System.Text;
using Tamagotchi;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat { name = "Барсик", hunger = 10 };
            cat.Meow();

            Fruit apple = new Fruit { type = "apple", satiety = 10 };
            Fruit orange = new Fruit { type = "orange", satiety = 5 };

            while (true)
            {
                Console.WriteLine("Choose action:\n1)Do meal\n2)Go play\n3)Go run\n4)Meow\n5)Check hunger\n6)Exit");

                if (cat.hunger < 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Cat cannot do anything. You lost your friend");
                    Console.ResetColor();
                    break;
                }
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Choose fruit to eat:\n1)An apple\n2)An orange");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1) DoMeal(cat, apple, cat);
                        else if (choice == 2) DoMeal(cat, orange, cat);
                        else Console.WriteLine("Wrong answer.");
                        if (cat.hunger >= 30) Console.WriteLine("The cat doesn't want to eat, he wants to play");
                        continue;
                    case 2:
                        cat.Play();
                        continue;
                    case 3:
                        cat.Run();
                        continue;
                    case 4:
                        cat.Meow();
                        continue;
                    case 5:
                        Console.WriteLine(cat.hunger);
                        continue;
                    case 6:
                        Console.WriteLine("See you next time. Bye bye");
                        break;
                }
            }
        }

        static void DoMeal(Cat c,Fruit f, Cat cat)
        {
            c.Eat(f, cat);
        }
    }
}