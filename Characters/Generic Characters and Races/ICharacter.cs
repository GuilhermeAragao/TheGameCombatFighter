using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    interface ICharacter
    {
        int Attack();
        bool changeWeapon(IWeapons changeweapon);
        int takingDamage(int damageTotal);
        // rebecer dano e talvez calcular resistencia
    }
}
