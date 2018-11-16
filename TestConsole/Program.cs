using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Characters;
using TestConsole.Enums;
using TestConsole.Dictionaries;
using TestConsole.Models;
using System.ComponentModel;

namespace TestConsole
{
    class Program
    {
        public static RacesEnum RacesEnum { get; private set; }

        static void Main()
        {
            var abilityList = AbilitiesDictionary.List;
            var weaponList = Dictionaries.PHB.Classes.Barbarian.BerserkerLevels;
            var barbarian =Dictionaries.PHB.Classes.Barbarian.TotemWarriorLevels;

            //foreach (var item in weaponList.Keys)
            //{
            //    Console.WriteLine($"{item} - {abilityList[item].Name}");
            //}

            //foreach (var item in abilityList.Values)
            //{
            //    Console.WriteLine($"{item.Name} - {item.HasSavingThrow}");
            //}

            var classes = EnumUtil.GetValues<ClassesEnum>();
            var races = EnumUtil.GetValues<RacesEnum>();

            Console.WriteLine("Select your race:");

            // Get enum descriptions
            foreach (var r in races)
            {
                Console.WriteLine(r.GetAttributeOfType<DescriptionAttribute>().Description);
            }

            string raceString = Console.ReadLine();
            // Get enum value from selected description and store it
            RacesEnum race = EnumUtil.GetValueFromDescription<RacesEnum>(raceString);

            Console.WriteLine($"\n\nSelect yoru class:");

            // Get enum descriptions
            foreach (var c in classes)
            {
                Console.WriteLine(c.GetAttributeOfType<DescriptionAttribute>().Description);
            }

            string classString = Console.ReadLine();
            // Get enum value from selected description and store it
            ClassesEnum charClass = EnumUtil.GetValueFromDescription<ClassesEnum>(classString);

            Console.WriteLine("\n\n");

            //Character character1 = new Character(race, charClass);
            Character character1 = new Character();

            Console.WriteLine(
                $"Name: {character1.Name}\n" +
                $"Race: {character1.Race}\n" +
                $"Class: {string.Join(", ", character1.Classes.ToArray())}\n" +
                $"Proficiency Bonus: +{character1.ProficiencyBonus}\n" +
                $"Hit Dice: d{character1.HitDice}\n" +
                $"HP: {character1.HitPointCurrent}/{character1.HitPointMax}\n" +
                $"Speed: {character1.Speed} ft.\n" +
                $"Size: {character1.Size}\n" +
                $"Skills: {string.Join(", ", character1.Skills.ToArray())}\n" +
                $"Languages: {string.Join(", ", character1.Languages.ToArray())}\n" +
                $"Feats: {string.Join(", ", character1.Feats.ToArray())}\n" +
                $"Features: {string.Join(", ", character1.Features.ToArray())}\n" +
                $"Savinbg Throws: {string.Join(", ", character1.SavingThrows.ToArray())}\n"
            );
        }
    }
}
