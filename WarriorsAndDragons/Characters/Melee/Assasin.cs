using System.Runtime.CompilerServices;
using WarriorsAndDragons.Enums;
using WarriorsAndDragons.Inventory.BodyArmors.Heavy;
using WarriorsAndDragons.Inventory.Weapons.Axe;

namespace WarriorsAndDragons.Characters.Melee
{
    public class Assasin : Melee
    {
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private readonly HackNSlash DEFAULT_WEAPON = new HackNSlash();

        public Chainlink BodyArmor { get; set; }

        public HackNSlash Weapon { get; set;}

        public Assasin() : this(Consts.Assasin.NAME, Consts.Assasin.LEVEL)
        {
            
        }

        public Assasin(string name, int level) : this(name, level, Consts.Assasin.HEALTH_POINTS)
        {
         
        }
        public Assasin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Assasin.ABILITY_POINTS;
            base.Faction = Consts.Assasin.FACTION;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int BaseAttack()
        {
            return base.Weapon.Damage + 10;
        }

        public int Assasinate()
        {
            return base.Weapon.Damage + 20;
        }

        public int Invisible()
        {
            return base.Armor.ArmorPoints + 100;

        }

        public override int Attack()
        {
            return this.BaseAttack();
        }

        public override int Defend()
        {
            return this.Invisible();
        }

        public override int SpecialAttack()
        {
            return this.Assasinate();
        }
    }
}