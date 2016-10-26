using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Cold_Flame : Attack_Spell
    {
        public Cold_Flame()
        {
            _manacost = 14;
            _spelldamage = 320;
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
