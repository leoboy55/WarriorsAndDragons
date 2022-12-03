using WarriorsAndDragons.Inventory.BodyArmors.Light;
using WarriorsAndDragons.Inventory.Weapons.Staff;

namespace WarriorsAndDragons.Characters.Spellcasters
{
    internal class Necromancer : Spelcaster
    {
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        private readonly Empower DEFAULT_WEAPON = new Empower();
        public ClothRobe Armor { get; set; }
        public Empower Weapon { get; set; }

        public Necromancer() : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL)
        {
 
        }
        public Necromancer(string name, int level) : this(name, level, Consts.Necromancer.HEALTH_POINTS)
        {

        }
        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Necromancer.FACTION;
            base.ManaPoints = Consts.Necromancer.MANA_POINTS;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }
        public int Poison()
        {
            return base.Weapon.Damage + 5;
        }

        public int Undeadrise()
        {
            return base.Weapon.Damage + 10;
        }

        public int Resurrect()
        {
            return base.Armor.ArmorPoints + 20;
        }

        public override int Attack()
        {
            return this.Poison();
        }

        public override int Defend()
        {
            return this.Resurrect();
        }

        public override int SpecialAttack()
        {
            return this.Undeadrise();
        }
    }
}
