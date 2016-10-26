using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Heal : Healing_Spell
    {
        public Heal()
        {
            _heal = 400;
            _manacost = 16;
        }
        public override int getHeal() { return _heal; }
        public override int getManaCost(){ return _manacost; }

    }
}
