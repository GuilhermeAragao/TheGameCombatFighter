using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    abstract class InHuman : ICharacter
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
        protected IWeapons _handsweapon;
        protected IWeapons[] weapons;
        protected int _allDamage;
        #endregion
        public abstract bool changeWeapon(IWeapons changeWeapon);
        public abstract int Attack();
        public abstract int takingDamage(int damageTotal);
    }
}
