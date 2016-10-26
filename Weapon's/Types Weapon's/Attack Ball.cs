using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Attack_Ball : IWeapons
    {
        int _damage;
        string name;
        public Attack_Ball()
        {
            name = "Bola de Ataque";
            _damage = 300;
        }
        public int getHit()
        {
            return _damage;
        }
        public string getName() { return name; }
    }
}
