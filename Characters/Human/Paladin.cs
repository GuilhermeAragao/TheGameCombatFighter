using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Paladin : Human ,IHeal
    {
        protected Healing_Spell[] _healSpell;

        public Paladin()
        {
            _life = 3200;
            _mana = 80;
            _atackdamage = 60;
            _spelldamage = 60;
            _armorresist = 60;
            _magicresist = 60;
            _agility = 60;
            weapons = new IWeapons[2];
            _healSpell = new Healing_Spell[1];
            _healSpell = new Potion_of_Life[0];
            _handsweapon = weapons[0];
            _allSpell = new Attack_Spell[3];
            _allSpell[0] = new Bio();
            _allSpell[1] = new Cold_Flame();
            _allSpell[2] = new Storm();                       
        }
        #region Method's

        /// <summary>
        /// Método para somar o poder total.
        /// </summary>
        /// <returns></returns>
        public override int Attack()
        {
            _damageTotal = _atackdamage + _handsweapon.getHit();
            return _damageTotal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">Posição do vetor de skill</param>
        /// <returns></returns>
        public int _healing(int pos)
        {
            if (_life < 2500)
            {
                _life += _healSpell[pos].getHeal();
                _mana -= _healSpell[pos].getManaCost();
                if (_life > 2500)
                {
                    return _life = 2500;
                }
            }
            return _life;
        }

        public override bool changeWeapon(IWeapons changeWeapon)
        {
            if (changeWeapon.getName() == "Besta")
            {
                _handsweapon = changeWeapon;
                weapons[0] = changeWeapon;
                return true;
            }
            else if (changeWeapon.getName() == "Tridente Sagrado")
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
