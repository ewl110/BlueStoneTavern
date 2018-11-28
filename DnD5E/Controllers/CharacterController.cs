using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DnD5E.Enums;
using DnD5E.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace DnD5E.Controllers
{
    [Route("character")]
    public class CharacterController : Controller
    {
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.backgroundList = Dictionaries.BackgroundDictionary.List.Values.ToList();
            ViewBag.classList = Dictionaries.ClassDictionary.List.Values.ToList();
            ViewBag.raceList = Dictionaries.RaceDictionary.List.Values.ToList();

            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create( CharacterModel character )
        {
            ViewBag.backgroundList = Dictionaries.BackgroundDictionary.List.Values.ToList();
            ViewBag.classList = Dictionaries.ClassDictionary.List.Values.ToList();
            ViewBag.raceList = Dictionaries.RaceDictionary.List.Values.ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }

            BackgroundEnum bg;
            ClassEnum c;
            RaceEnum r;

            string notFound = "Not Found";

            string displayBackground = notFound;
            string displayClass = notFound;
            string displayRace = notFound;

            //if (Enum.IsDefined(typeof(BackgroundEnum), charBackground))
            //{
            //    bg = (BackgroundEnum)Enum.Parse(typeof(BackgroundEnum), charBackground);
            //    displayBackground = bg.GetAttributeOfType<DescriptionAttribute>().Description;
            //}

            //if (Enum.IsDefined(typeof(ClassEnum), charClass))
            //{
            //    c = (ClassEnum)Enum.Parse(typeof(ClassEnum), charClass);
            //    displayClass = c.GetAttributeOfType<DescriptionAttribute>().Description;
            //}

            //if (Enum.IsDefined(typeof(RaceEnum), charRace))
            //{
            //    r = (RaceEnum)Enum.Parse(typeof(RaceEnum), charRace);
            //    displayRace = r.GetAttributeOfType<DescriptionAttribute>().Description;
            //}

            //return new ContentResult { Content = $"Race: {displayRace} - Class: {displayClass} - Background: {displayBackground}" };
            return View();
        }

        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            CharacterModel character = new CharacterModel
            {
                // TODO: Get dictionary values for background, class and race before adding to model
                Background = "folkHero",
                Class = new List<string>{ "ranger" },
                Level = 1,
                Name = "Huumon",
                Race = "halfElf"
            };

            return View(character);
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("random")]
        public IActionResult Random()
        {
            CharacterCard character = new Characters.Character().CreateNewCharacter();
            return View(character);
        }
    }
}