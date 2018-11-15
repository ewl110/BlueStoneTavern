using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Characters;
using TestConsole.Characters.Races.Human;
using TestConsole.Enums;

namespace TestConsole
{
    class Program
    {
        static void Main()
        {
            //var languages = EnumUtil.GetValues<Enums.Languages.Exotic>();

            //foreach (var item in languages)
            //{
            //    Console.WriteLine(item);
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
