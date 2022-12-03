using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsAndDragons.Inventory.BodyArmors.Leather
{
    public class LightLeatherVest : BodyAmor
    {
        private const int DEFAULT_ARMOR_POINTS = 3;

        public LightLeatherVest()
        {
            ArmorPoints = DEFAULT_ARMOR_POINTS;
        }
    }
}
