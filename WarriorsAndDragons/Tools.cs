using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsAndDragons
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfulCW(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch (type)
            {
                case "WarriorsAndDragons.Characters.Melee.Warrior":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "WarriorsAndDragons.Characters.Melee.Dragonslayer":
                    color = ConsoleColor.Yellow;
                    break;
                case "WarriorsAndDragons.Characters.Melee.Assasin":
                    color = ConsoleColor.Gray;
                    break;
                case "WarriorsAndDragons.Characters.Spellcasters.Mage":
                    color = ConsoleColor.Cyan;
                    break;
                case "WarriorsAndDragons.Characters.Spellcasters.Necromancer":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "WarriorsAndDragons.Characters.Spellcasters.Druid":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
