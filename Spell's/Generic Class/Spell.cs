using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    abstract class Spell
    {
        protected int _manacost;
        public abstract int getManaCost();
    }
}
