using _5ESpellbook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5ESpellbook.Models
{
    public class SpellLinkModel
    {
        public List<Spell> spells { get; set; }

        public SpellLinkModel()
        {
            spells = new List<Spell>();
        }
    }
}