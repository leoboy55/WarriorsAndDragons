using WarriorsAndDragons.Characters.Interfaces;
using WarriorsAndDragons.Enums;
using WarriorsAndDragons.Inventory.BodyArmors;
using WarriorsAndDragons.Inventory.Weapons;

namespace WarriorsAndDragons.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        public BodyAmor Armor { get; set; }
        public Weapon Weapon { get; set; }

        private Faction faction;

        private int healthPoints;
        private int level;
        private int scores;

        private string name;

        private bool isAlive;




        public virtual int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                    this.healthPoints = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "level should be atleast 1 or higher");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }
        public abstract int Attack();
        public abstract int Defend();
        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} healthpoints!", type);
            }
        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
