using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opn.Models
{
    class Dragon : EntityBase
    {
        public Dragon(string name, double health, double power, double armor, bool onTurn) : base(name, health, power, armor, onTurn)
        {

        }
    }
}
