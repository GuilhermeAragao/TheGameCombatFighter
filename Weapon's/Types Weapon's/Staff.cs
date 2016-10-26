using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Staff : IWeapons
    {
        int _damage;
        string name;
        public Staff()
        {
            name = "Cajado";
            _damage = 100;
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
