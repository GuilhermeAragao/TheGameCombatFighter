using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Fire_Breath : Attack_Spell
    {
        public Fire_Breath()
        {
            _manacost = 12;
            _spelldamage = 400;
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
