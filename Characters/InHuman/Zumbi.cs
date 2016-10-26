using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Zumbi : InHuman
    {
        public Zumbi()
        {
            _life = 2500;
            _mana = 20;
            _atackdamage = 40;
            _spelldamage = 20;
            _armorresist = 80;
            _magicresist = 90;
            _agility = 20;
            _allSpell = new Attack_Spell[1];
            _allSpell[0] = new Intoxication();
            weapons = new IWeapons[3];
            _handsweapon = weapons[0];
        }
        #region Method's
        public override int Attack()
        {
            return _damageTotal = _atackdamage + _handsweapon.getHit();
        }
        public override bool changeWeapon(IWeapons changeWeapon)
        {
            if (changeWeapon.getName() == "Garra Letal")
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
            else if (changeWeapon.getName() == "Cajado")
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
