using DnD5E.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.ViewComponents
{
    [ViewComponent]
    public class CharacterListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var characters = new CharacterModel[] {
                new CharacterModel
                {
                    Class = String.Join(", ", new List<string>{ "ranger" }.ToArray()),
                    Name = "Character Awesome",
                    Race = "halfElf"
                },
                new CharacterModel
                {
                    Class = String.Join(", ", new List<string>{ "eldritchKnight", "cleric" }.ToArray()),
                    Name = "Character DD",
                    Race = "dragonborn"
                }
            };

            return View(characters);
        }
    }
}
