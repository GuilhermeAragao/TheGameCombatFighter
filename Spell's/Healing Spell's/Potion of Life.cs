using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Potion_of_Life : Healing_Spell
    {

        public Potion_of_Life()
        {            
            _heal = 200;
            _manacost = 12;
        }
        public override int getHeal() { return _heal; }
        public override int getManaCost() { return _manacost; }

    }
}
