using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Holy_Trident : IWeapons
    {
        int _damage;
        string name;
        public Holy_Trident()
        {
            name = "Tridente Sagrado";
            _damage = 320;
        }
        public int getHit()
        {
            return _damage;
        }
        public string getName()
        {
            return name;
        }
    }
}
