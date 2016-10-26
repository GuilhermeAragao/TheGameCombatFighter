using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Thief : Human
    {
        public Thief()
        {
            _life = 2800;
            _mana = 50;
            _atackdamage = 50;
            _spelldamage = 30;
            _armorresist = 40;
            _magicresist = 50;
            _agility = 100;
            _allSpell = new Attack_Spell[2];
            _allSpell[0] = new Intoxication();
            _allSpell[1] = new Storm();
            weapons = new IWeapons[4];
            _handsweapon = weapons[0];
        }
        #region Method's
        public override int Attack()
        {
            return _damageTotal = _atackdamage + _handsweapon.getHit();
        }
        public override bool changeWeapon(IWeapons changeWeapon)
        {
            if (changeWeapon.getName() == "Cajado")
            {
                _handsweapon = changeWeapon;
                weapons[0] = changeWeapon;
                return true;
            }
            else if (changeWeapon.getName() == "Porrete")
            {
                _handsweapon = changeWeapon;
                weapons[0] = changeWeapon;
                return true;
            }
            else if (changeWeapon.getName() == "Besta")
            {
                _handsweapon = changeWeapon;
                weapons[0] = changeWeapon;
                return true;
            }
            else if (changeWeapon.getName() == "Esfera de Ataque")
            {
                _handsweapon = changeWeapon;
                weapons[0] = changeWeapon;
                return true;
            }
            else
                return false;
        }
        public override int takingDamage(int damageTotal)
        {
            _life -= (damageTotal - _armorresist);
            return _life;
        }
    }
    #endregion
}
