using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Models
{
    public class CharacterCard
    {
        public List<ClassListModel> Class { get; set; }
        public Guid Id { get; }
        public string Race { get; set; }
    }
}
