
namespace WarriorsAndDragons.Characters.Spellcasters
{
    public abstract class Spelcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get 
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 3 && value <= 10)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "mana points have to be between 3 - 10 range");
                };
            }
        }

    }
}
