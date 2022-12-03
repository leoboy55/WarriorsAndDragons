using MagicDestroyers;
using WarriorsAndDragons.Characters;
using WarriorsAndDragons.Characters.Melee;
using WarriorsAndDragons.Characters.Spellcasters;

namespace WarriorsAndDragons
{
    class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();

            Melee currentMelee;
            Spelcaster currentSpellcaster;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Assasin(),
                new Dragonslayer(),

                new Druid(),
                new Mage(),
                new Necromancer()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spelcaster> spellTeam = new List<Spelcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spelcaster)
                {
                    spellTeam.Add((Spelcaster)character);
                }    
            }

            PlayersInfo.Initialize(characters);

            while (!gameOver)
            {
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());

                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.WonBattle();
                    spellTeam.Remove(currentSpellcaster);

                    if (spellTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nMelee team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
                    }
                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());

                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nSpell team wins!", ConsoleColor.Red);

                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }
            }
            PlayersInfo.UpdateFullInfo(characters);
            PlayersInfo.Save(characters);
            PlayersInfo.PrintFullInfo();
        }
    }
}