using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Bio : Attack_Spell
    {
        public Bio()
        {
            _manacost = 14;
            _spelldamage = 360;
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
