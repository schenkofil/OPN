using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opn.Models
{
    class Hero : EntityBase
    {
        public Sword Sword { get; set; }
        public Shield Shield { get; set; }
        public Hero(string name, double health, double power, double armor, bool onTurn, Sword sword, Shield shield) : base(name, health, power, armor, onTurn)
        {
            Sword = sword;
            Shield = shield;
        }

        public double Attack()
        {
            return Power * new Random().NextDouble() + Sword.Damage;
        }

        public double Defense()
        {
            return Armor * new Random().NextDouble() + Shield.Defense;
        }
    }

}
