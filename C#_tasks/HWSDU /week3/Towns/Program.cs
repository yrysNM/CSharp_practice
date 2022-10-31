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
            Town t = new Town(); 
            NewYork n = new NewYork();
            Astana a= new Astana(); 
            Almaty al= new Almaty(); 
            Almaty2 al2 = new Almaty2(); 
            
            n.TownInformation();
            a.TownInformation(); 
            al.TownInformation(); 
            al2.TownInformation();

            Console.ReadKey();
        }


        class Town {
            public string name; 
            public long population; 
            
            public virtual void TownInformation() {
                Console.WriteLine("Town name: " + name + " population " + population);
            }
        }

        class NewYork : Town {
            public override void TownInformation() {
                base.name = "New York";
                base.population = 30000000000;
                Console.WriteLine("Town name: " + name + " population " + population);
            }
        }

        class Astana : Town {
            public sealed override void TownInformation() {
                Console.WriteLine("Town name: Astana");
            }
        }

        class Almaty : Town {
            public new virtual void TownInformation() {
                Console.WriteLine("Almaty city \n population: 200000000");
            }
        }

        class Almaty2 : Almaty {
            public override void TownInformation() {
                base.name = "Almaty2";
                base.population = 1000000; 
                Console.WriteLine("Town name: " + name + " population " + population);
            }
        }
    }
}