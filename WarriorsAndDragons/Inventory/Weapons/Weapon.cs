
namespace WarriorsAndDragons.Inventory.Weapons
{
    public abstract class Weapon
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 1)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage of the weapon should be atleast 1 or higher");
                }
            }
        }
    }
}
