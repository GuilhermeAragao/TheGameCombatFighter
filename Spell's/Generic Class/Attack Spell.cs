using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    abstract class Attack_Spell : Spell
    {
        protected int _spelldamage;
        public abstract int getDamage();
    }
}
