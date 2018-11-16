using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries.PHB.Races
{
    public class Human
    {
        private BaseRace character;


        public BaseRace Character
        {
            get {
                return this.character;
            }
            private set
            {
                this.character = value;
            }
        }

        public Human(string subrace = "standard")
        {
            Array alignments = Enum.GetValues(typeof(AlignmentsEnum));
            var languages = LanguagesDictionary.List;
            var commonLanguages = LanguagesDictionary.List.Where( l => l.Value.Type == LanguageTypesEnum.Common );
            BaseRace human = new BaseRace();
            Random rng = new Random();

            // Get common languages only

            this.character.Age = rng.Next(15, 80);
            this.character.Alignment = (AlignmentsEnum)alignments.GetValue(rng.Next(alignments.Length));
            this.character.Languages.Add("Common");
            this.character.Languages.Add("+1");
            this.character.Size = SizesEnum.Medium;
            this.character.Speed = 30;

            if (subrace == "variant")
            {
                this.character.Asi = "0,0,0,0,0,0";
                this.character.Feats.Add("+1");
                this.character.Skills.Add("+1");
            }
            else
            {
                this.character.Asi = "1,1,1,1,1,1";
            }
        }
    }
}
