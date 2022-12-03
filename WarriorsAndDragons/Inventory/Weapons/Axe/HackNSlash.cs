using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsAndDragons.Inventory.Weapons.Axe
{
    public class HackNSlash :Weapon
    {
        private const int DEFAULT_DAMAGE = 3;

        public HackNSlash()
        {
            base.Damage = DEFAULT_DAMAGE;
        }
    }
}
