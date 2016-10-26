using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Crossbow : IWeapons
    {
        int _damage;
        string name;
        public Crossbow()
        {
            name = "Besta";
            _damage = 320;
        }
        public int getHit()
        {
            return _damage;
        }
        public string getName() { return name; }
    }
}

