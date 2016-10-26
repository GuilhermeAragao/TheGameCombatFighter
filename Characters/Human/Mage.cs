using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Mage : Human, IHeal
    {
        protected Healing_Spell[] _healSpell;
        public Mage()
        {
            _life = 2500;
            _mana = 100;
            _atackdamage = 40;
            _spelldamage = 100;
            _armorresist = 30;
            _magicresist = 100;
            _agility = 40;
            _healSpell = new Healing_Spell[2];
            _healSpell[0] = new Potion_of_Life();
            _healSpell[1] = new Heal();
            _allSpell = new Attack_Spell[4];
            weapons = new IWeapons[2];
            _handsweapon = weapons[0];                  
        }
        #region Method's
        /// <summary>
        ///  Metodo para recuperar vida de acordo com a magia usada.
        /// </summary>
        /// <param name="pos">No vetor de magias curaveis, utilizará a posição da magia.</param>
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

        /// <summary>
        /// Troca a arma para a mão no vetor de armas, utilizando uma interface.
        /// </summary>
        /// <param name="changeWeapon">Interface IWeapon's </param>
        /// <param name="_handsweapon">Arma que está sendo usada </param>
        /// <returns></returns>
        public override bool changeWeapon(IWeapons changeWeapon)
        {
            if (changeWeapon.getName() == "Cajado")
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
        /// <summary>
        /// Metodo para atacar
        /// </summary>
        /// <returns></returns>
        public override int Attack()
        {
           return _damageTotal = _atackdamage + _handsweapon.getHit(); 
        }
        public override int takingDamage(int damageTotal)
        {
            _life -= (damageTotal - _armorresist);
            return _life;
        }
        #endregion
    }
}
