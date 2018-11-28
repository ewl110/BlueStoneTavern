using DnD5E.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Models
{
    public class ClassModel : BaseModel
    {
        //public Proficiencies[] Equipment { get; set; } Add directly to character model
        //public bool HasRitualCasting { get; set; } Spellcasters only
        public int HitDice { get; set; }
        public bool IsCaster { get; set; }
        [Required]
        public string Key { get; set; }
        public ClassEnum? ParentClass { get; set; }
        public ClassProficienciesModel Proficiencies { get; set; }
        public List<AbilitiesEnum> SavingThrows { get; set; }
        public ClassSkillsModel Skills { get; set; }
        //public Spell[] Spellbook { get; set; } spellcasters only
    }

    public class ClassSkillsModel {
        public List<SkillsEnum> Available { get; set; }
        public int Number { get; set; }
    }

    public class Level
    {
        public string[] Features { get; set; }
        public int ProficiencyBonus { get; set; }
    }

    public class ClassProficienciesModel
    {
        public List<string> Armor { get; set; }
        public List<string> Tools { get; set; }
        public List<string> Weapons { get; set; }
    }
}