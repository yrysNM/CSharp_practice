﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towns
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Dog d = new Dog();
            Animal anim = new Dog();
            Cat c = new Cat();
            Ocelot o = new Ocelot();
            OcelotKitten ok = new OcelotKitten();
            Animal [] animals = { a, d, c, o, ok};
            foreach (Animal animal in animals)
            {
                animal.Voice();
            }
            Ocelot[] ocelots = { o, ok};
            foreach (Ocelot ocel in ocelots)
                ocel.Voice();
            Console.ReadKey();
        }

        class Animal {

            private int i;
            public int j;
            protected int k;
            public virtual void Voice()
            {
                Console.WriteLine("Speaking in animalish...");
            }
        }
        class Dog : Animal
        {
            public override void Voice()
            {
                Console.WriteLine("Bark!");
            }
            
        }
        class Cat : Animal {
            public sealed override void Voice()
            {
                Console.WriteLine("Meow!");
            }
        }
        class Ocelot : Cat
        {
            public new virtual void Voice()
            {
                Console.WriteLine("Meooooow!");
            }
        }
        class OcelotKitten : Ocelot
        {
            public override void Voice()
            {
                Console.WriteLine("meooooow!");
            }
        }
    }
}