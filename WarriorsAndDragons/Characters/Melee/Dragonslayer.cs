using System.Runtime.CompilerServices;
using WarriorsAndDragons.Enums;
using WarriorsAndDragons.Inventory.BodyArmors.Heavy;
using WarriorsAndDragons.Inventory.Weapons.Sword;

namespace WarriorsAndDragons.Characters.Melee
{
    internal class Dragonslayer : Melee
    {
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private readonly Bloodthirst DEFAULT_WEAPON = new Bloodthirst();
        public Chainlink Armor { get; set; }
        public Bloodthirst Weapon { get; set; }

        public Dragonslayer() : this(Consts.Dragonslayer.NAME, Consts.Dragonslayer.LEVEL)
        {

        }

        public Dragonslayer(string name, int level) : this(name, level, Consts.Dragonslayer.HEALTH_POINTS)
        {
     
        }

        public Dragonslayer(string name, int level, int healtPoints) 
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healtPoints;
            base.Faction = Consts.Dragonslayer.FACTION;
            base.AbilityPoints = Consts.Dragonslayer.ABILITY_POINTS;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int BaseAttack()
        {
            return base.Weapon.Damage + 8;
        }

        public int Dragonsmash() 
        {
            return base.Weapon.Damage + 12;
        }

        public int Harden() 
        {
            return base.Armor.ArmorPoints + 5;
        }

        public override int Attack()
        {
           return this.BaseAttack();
        }

        public override int Defend()
        {
            return this.Harden();
        }

        public override int SpecialAttack()
        {
            return this.Dragonsmash();
        }
    }
}
