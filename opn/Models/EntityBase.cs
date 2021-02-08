using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opn.Models
{
    class EntityBase
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Power { get; set; }
        public double Armor { get; set; }
        public bool OnTurn { get; set; }

        public EntityBase(string name, double health, double power, double armor, bool onTurn)
        {
            Name = name;
            Health = health;
            Power = power;
            Armor = armor;
            OnTurn = onTurn;
        }

        public double Attack()
        {
            return Power * new Random().NextDouble();
        }

        public double Defense()
        {
            return Armor * new Random().NextDouble();
        }
    }
}
