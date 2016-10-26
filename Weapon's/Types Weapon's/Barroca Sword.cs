using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Barroca_Sword : IWeapons
    {
        int _damage;
        private string name;
        public Barroca_Sword()
        {
            name = "Espada Barroca";
            _damage = 400;
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
