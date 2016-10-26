using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Club : IWeapons
    {
        int _damage;
        string name;
        public Club()
        {
            name = "Porrete";
            _damage = 280;
        }
        public int getHit()
        {
            return _damage;
        }
        public string getName() { return name; }
    }
}

