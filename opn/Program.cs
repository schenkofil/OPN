using opn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opn
{
    class Program
    {
        public static bool _flipACoinResult = new Random().NextDouble() >= 0.5;
        static void Main(string[] args)
        {
            var dragon = new Dragon("Smak", 1000, 55, 20, _flipACoinResult);
            var hero = new Hero("Hero", 2000, 55, 20, !_flipACoinResult);
            int i = 1;

            Console.WriteLine("Fight started");

            while(dragon.Health > 0 || hero.Health > 0)
            {
                Console.WriteLine($"\n Round: {i} \n");

                double attack = dragon.OnTurn ? dragon.Attack() : hero.Attack();
                double defense = !dragon.OnTurn ? dragon.Defense() : hero.Defense();
                double result = (attack - defense) > 0 ? attack - defense : 0;

                if (hero.OnTurn)
                {
                    dragon.Health -= result;
                    Console.WriteLine($"Hero dealt {result} damage to dragon.");
                    Console.WriteLine($"Dragon HP: {dragon.Health}");
                    if(dragon.Health <= 0 )
                    {
                        Console.WriteLine("Dragon died");
                        break;
                    }
                }
                else
                {
                    hero.Health -= result;
                    Console.WriteLine($"Dragon dealt {result} damage to hero.");
                    Console.WriteLine($"Hero HP: {hero.Health}");
                    if (hero.Health <= 0 )
                    {
                        Console.WriteLine("Hero died");
                        break;
                    }
                }

                hero.OnTurn = !hero.OnTurn;
                dragon.OnTurn = !dragon.OnTurn;
                i++;
            }

            Console.WriteLine("Fight ended");
        }
    }
}
