using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Animal : InHuman
    {
        public Animal()
        {
            _life = 3200;
            _mana = 30;
            _atackdamage = 80;
            _spelldamage = 20;
            _armorresist = 90;
            _magicresist = 20;
            _agility = 50;
            _allSpell = new Attack_Spell[1];
            _allSpell[0] = new Bio();
            weapons = new IWeapons[1];
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
