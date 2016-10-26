using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    abstract class Human : ICharacter
    {
        #region Atributes
        protected int _life;
        protected int _mana;
        protected int _atackdamage;
        protected int _spelldamage;
        protected int _armorresist;
        protected int _magicresist;
        protected int _agility;
        protected int _damageTotal;
        protected Spell[] _allSpell;        
        protected IWeapons[] weapons;
        protected IWeapons _handsweapon;
        protected Spell _usedSpell;
        #endregion

        public abstract int Attack();
        public abstract bool changeWeapon(IWeapons changeweapon);
        public abstract int takingDamage(int damageTotal);
    }
}
