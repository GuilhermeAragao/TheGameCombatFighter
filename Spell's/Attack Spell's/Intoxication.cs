using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Intoxication : Attack_Spell
    {
        public Intoxication()
        {
            _manacost = 12;
            _spelldamage = 280;
        }
        public override int getDamage()
        {
            return _spelldamage;
        }
        public override int getManaCost()
        {
            return _manacost;
        }
    }
}
