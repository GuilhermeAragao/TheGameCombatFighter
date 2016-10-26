using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    abstract class Healing_Spell : Spell
    {
        protected int _heal;
        public abstract int getHeal();

    }
}
