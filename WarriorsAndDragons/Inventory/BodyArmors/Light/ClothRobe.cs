using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsAndDragons.Inventory.BodyArmors.Light
{
    public class ClothRobe : BodyAmor
    {
        private const int DEFAULT_ARMOR_POINTS = 1;

        public ClothRobe()
        {
            ArmorPoints = DEFAULT_ARMOR_POINTS;
        }
    }
}
