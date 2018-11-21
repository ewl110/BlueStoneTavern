using DnD5E.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace DnD5E.Models
{
    public class BaseModel
    {
        public string Description { get; set; }

        [Required]
        [Display(Name = "Character Name")]
        public string Name { get; set; }

        public ReferencesEnum Ref { get; set; }
    }
}
