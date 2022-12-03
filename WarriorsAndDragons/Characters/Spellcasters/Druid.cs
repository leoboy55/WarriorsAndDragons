using WarriorsAndDragons.Enums;
using WarriorsAndDragons.Inventory.BodyArmors.Light;
using WarriorsAndDragons.Inventory.Weapons.Staff;
using WarriorsAndDragons.Inventory.Weapons.Sword;

namespace WarriorsAndDragons.Characters.Spellcasters
{
    internal class Druid : Spelcaster
    {
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        private readonly Empower DEFAULT_WEAPON = new Empower();
        public ClothRobe Armor { get; set; }
        public Empower Weapon { get; set; }

        public Druid() : this(Consts.Druid.NAME, Consts.Druid.LEVEL)
        {

        }
        public Druid (string name, int level) : this(name, level, Consts.Druid.HEALTH_POINTS)
        {

        }

        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Druid.FACTION;
            base.ManaPoints = Consts.Druid.MANA_POINTS;

            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }
        public int BaseAttack() 
        {
            return base.Weapon.Damage + 5;
        }

        public int Naturecall()
        {
            return base.Weapon.Damage + 15;
        }

        public int Ironharden()
        {
            return base.Armor.ArmorPoints + 3;
        }

        public override int Attack()
        {
            return this.BaseAttack();
        }

        public override int Defend()
        {
            return this.Ironharden();
        }

        public override int SpecialAttack()
        {
            return this.Naturecall();
        }
    }
}
