using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opn.Models
{
    class Equip
    {
        public string Name { get; set; }
        public double Weight { get; set; }


        public Equip(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }

    class Sword : Equip
    {
        public double Damage { get; set; }

        public Sword(string name, double weight, double damage) : base(name, weight)
        {
            Damage = damage;
        }
    }

    class Shield : Equip
    {
        public double Defense { get; set; }

        public Shield(string name, double weight, double defense) : base(name, weight)
        {
            Defense = defense;
        }
    }
}
