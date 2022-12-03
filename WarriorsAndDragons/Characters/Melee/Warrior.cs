using WarriorsAndDragons.Enums;
using WarriorsAndDragons.Inventory.BodyArmors.Heavy;
using WarriorsAndDragons.Inventory.Weapons.Hammer;

namespace WarriorsAndDragons.Characters.Melee
{
    public class Warrior : Melee
    {
        private readonly Chainlink DEFAULT_ARMOR = new Chainlink();
        private readonly Stun DEFAULT_WEAPON = new Stun();

        public Chainlink Armor { get; set; }
        public Stun Weapon { get; set; }

        public Warrior() : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        {

        }

        public Warrior(string name, int level) : this(name, level, Consts.Warrior.HEALTH_POINTS)
        {

        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Warrior.FACTION;
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int BaseAttack()
        {
            return base.Weapon.Damage + 5;
        }

        public int Beserk() 
        {
            return base.Weapon.Damage + 15;
        }
        public int Shield()
        {
            return base.Armor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.BaseAttack();
        }

        public override int Defend()
        {
            return this.Shield();
        }

        public override int SpecialAttack()
        {
            return this.Beserk();
        }
    }
}
