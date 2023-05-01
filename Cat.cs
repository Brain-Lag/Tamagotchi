using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi
{
    struct Fruit
    {
        public string type;
        public int satiety;
    }
    class Cat
    {
        public string name;
        public int hunger;

        public void Meow()
        {
            Console.WriteLine("Meow");
        }

        public void Eat(Fruit f, Cat cat)
        {
            Console.WriteLine($"{name} eats {f.type}. {f.satiety} hp.");
        }

        public void Play()
        {
            hunger -= 5;
            Console.WriteLine("Cat is playing... Hunger is " + hunger);
        }

        public void Run()
        {
            hunger -= 10;
            Console.WriteLine("Cat runs... Hunger is " + hunger);
        }
    }
}