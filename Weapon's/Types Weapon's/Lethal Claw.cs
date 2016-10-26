using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Lethal_Claw :IWeapons
    {
        int _damage;
        string name;
        public Lethal_Claw()
        {
            name = "Garra Letal";
            _damage = 200;
        }
        public int getHit()
        {
            return _damage;
        }
        public string getName() { return name; }
    }
}

