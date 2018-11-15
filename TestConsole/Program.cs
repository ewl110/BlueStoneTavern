using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Characters;
using TestConsole.Characters.Races.Human;
using TestConsole.Enums;
using TestConsole.Dictionaries;
using TestConsole.Models;

namespace TestConsole
{
    class Program
    {
        static void Main()
        {
            var abilityList = Dictionaries.Abilities.List;
            var weaponList = Dictionaries.PHB.Weapons.List;

            //foreach (var item in weaponList.Keys)
            //{
            //    Console.WriteLine($"{item} - {abilityList[item].Name}");
            //}

            //foreach (var item in abilityList.Values)
            //{
            //    Console.WriteLine($"{item.Name} - {item.HasSavingThrow}");
            //}

            Character character = new Human();
            Console.WriteLine(
                $"Name: {character.Name}\n" +
                $"Race: {character.Race}\n" +
                $"Class: {string.Join(", ", character.Classes.ToArray())}\n" +
                $"Languages: {string.Join(", ", character.Languages.ToArray())}\n" +
                $"Speed: {character.Speed} ft.\n" +
                $"Size: {character.Size}\n" +
                $"Skills: {string.Join(", ", character.Skills.ToArray())}\n"
            );
        }
    }
}
