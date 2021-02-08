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
            var sword = new Sword("sword", 2.5, 5);
            var shield = new Shield("shield", 3, 5);

            var entities = new List<EntityBase>()
            {
                new Dragon("Smak", 1000, 55, 20, _flipACoinResult),
                new Hero("Hero", 2000, 55, 20, !_flipACoinResult, sword, shield)
            };
            int i = 1;

            Console.WriteLine("Fight started");

            while(entities.FirstOrDefault(x => x.Health <= 0) == null)
            {
                Console.WriteLine($"\n Round: {i} \n");

                var attackingEntity = entities.FirstOrDefault(x => x.OnTurn);
                var defendingEntity = entities.FirstOrDefault(x => !x.OnTurn);
                double attack = attackingEntity is Hero h ? h.Attack() : attackingEntity.Attack();
                double defense = defendingEntity is Hero hh ? hh.Defense() : defendingEntity.Defense();
                double result = (attack - defense) > 0 ? attack - defense : 0;

                defendingEntity.Health -= result;
                Console.WriteLine($"{attackingEntity.Name} dealt {result} damage to {defendingEntity.Name}!");
                Console.WriteLine($"{defendingEntity.Name} HP: {defendingEntity.Health}");
                if (defendingEntity.Health <= 0)
                {
                    Console.WriteLine($"\n {defendingEntity.Name} has died! \n");
                    break;
                }

                attackingEntity.OnTurn = !attackingEntity.OnTurn;
                defendingEntity.OnTurn = !defendingEntity.OnTurn;
                i++;
            }

            Console.WriteLine("\n Fight ended \n");
        }
    }
}
