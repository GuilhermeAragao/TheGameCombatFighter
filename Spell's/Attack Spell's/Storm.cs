using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Storm : Attack_Spell
    {
        public Storm()
        {
            _manacost = 12;
            _spelldamage = 200;
        }
        public override int getManaCost()
        {
            return _manacost;
        }
        public override int getDamage()
        {
            return _spelldamage;
        }
    }
}
