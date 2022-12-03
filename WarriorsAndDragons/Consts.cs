using WarriorsAndDragons.Enums;

namespace WarriorsAndDragons
{
    public static class Consts
    {

        public static class Warrior
        {
            public const string NAME = "Warrior";
            public const Faction FACTION = Faction.Orc;

            public const int ABILITY_POINTS = 3;
            public const int HEALTH_POINTS = 10;
            public const int LEVEL = 1;
        }

        public static class Assasin
        {
            public const string NAME = "Assasin";
            public const Faction FACTION = Faction.Human;

            public const int ABILITY_POINTS = 5;
            public const int HEALTH_POINTS = 10;
            public const int LEVEL = 1;
        }

        public static class Dragonslayer
        {
            public const string NAME = "Dragonslayer";
            public const Faction FACTION = Faction.Human;

            public const int ABILITY_POINTS = 3;
            public const int HEALTH_POINTS = 10;
            public const int LEVEL = 1;
        }

        public static class Mage
        {
            public const string NAME = "Mage";
            public const Faction FACTION = Faction.Human;

            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 10;
            public const int LEVEL = 1;
        }

        public static class Druid
        {
            public const string NAME = "Druid";
            public const Faction FACTION = Faction.Orc;

            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 5;
            public const int LEVEL = 1;
        }

        public static class Necromancer
        {
            public const string NAME = "Necromancer";
            public const Faction FACTION = Faction.Orc;

            public const int MANA_POINTS = 10;
            public const int HEALTH_POINTS = 3;
            public const int LEVEL = 1;
        }
    }
}
