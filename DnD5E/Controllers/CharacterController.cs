﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DnD5E.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DnD5E.Controllers
{
    [Route("character")]
    public class CharacterController : Controller
    {
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("create/{charRace}/{charClass}/{charBackground}")]
        public IActionResult Create(string charBackground, string charClass, string charRace )
        {
            BackgroundEnum bg;
            ClassEnum c;
            RaceEnum r;

            string notFound = "Not Found";

            string displayBackground = notFound;
            string displayClass = notFound;
            string displayRace = notFound;

            if (Enum.IsDefined(typeof(BackgroundEnum), charBackground))
            {
                bg = (BackgroundEnum)Enum.Parse(typeof(BackgroundEnum), charBackground);
                displayBackground = bg.GetAttributeOfType<DescriptionAttribute>().Description;
            }

            if (Enum.IsDefined(typeof(ClassEnum), charClass))
            {
                c = (ClassEnum)Enum.Parse(typeof(ClassEnum), charClass);
                displayClass = c.GetAttributeOfType<DescriptionAttribute>().Description;
            }

            if (Enum.IsDefined(typeof(RaceEnum), charRace))
            {
                r = (RaceEnum)Enum.Parse(typeof(RaceEnum), charRace);
                displayRace = r.GetAttributeOfType<DescriptionAttribute>().Description;
            }

            return new ContentResult { Content = $"Race: {displayRace} - Class: {displayClass} - Background: {displayBackground}" };
            //return View();
        }

        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            return View();
        }

        [Route("")]
        public IActionResult Index()
        {
            return new ContentResult { Content = "Choose your character!" };
            //return View();
        }
    }
}