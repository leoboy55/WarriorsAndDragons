using WarriorsAndDragons.Enums;
using WarriorsAndDragons.Inventory.BodyArmors.Leather;
using WarriorsAndDragons.Inventory.Weapons.Staff;
using WarriorsAndDragons.Inventory.Weapons.Sword;

namespace WarriorsAndDragons.Characters.Spellcasters
{
    internal class Mage : Spelcaster
    {
        private readonly LightLeatherVest DEFAULT_ARMOR = new LightLeatherVest();
        private readonly Empower DEFAULT_WEAPON = new Empower();
        public LightLeatherVest Armor { get; set; }
        public Empower Weapon { get; set; }

        public Mage() : this (Consts.Mage.NAME, Consts.Mage.LEVEL)
        {
 
        }

        public Mage(string name, int level) : this(name, level, Consts.Mage.HEALTH_POINTS)
        {

        }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Mage.FACTION;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int Magic()
        {
            return base.Weapon.Damage + 7;
        }

        public int Firerain()
        {
            return base.Weapon.Damage + 12;
        }

        public int Heal()
        {
            return base.Armor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Magic();
        }

        public override int Defend()
        {
            return this.Heal();
        }

        public override int SpecialAttack()
        {
            return this.Firerain();
        }
    }
}
