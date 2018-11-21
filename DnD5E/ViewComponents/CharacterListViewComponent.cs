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
                    Class = new List<string>{ "ranger" },
                    Name = "Character Awesome",
                    Race = "halfElf"
                },
                new CharacterModel
                {
                    Class = new List<string>{ "eldritchKnight", "cleric" },
                    Name = "Character DD",
                    Race = "dragonborn"
                }
            };

            return View(characters);
        }
    }
}
