using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Characters.Races.Human
{
    public class Human : Character
    {
        public Human() : base()
        {
            base.Languages = Consts.Human.LANGUAGES.ToList();
            base.Name = "Hoomun";
            base.Size = Consts.Human.SIZE;
            base.Speed = Consts.Human.SPEED;
        }
    }
}
