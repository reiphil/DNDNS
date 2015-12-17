using _5ESpellbook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5ESpellbook.Models
{
    public class FindSpellModel
    {
        public Spell spell { get; set; }
        public List<string> suggestions { get; set; }

        public FindSpellModel()
        {
            suggestions = new List<string>();
        }
    }
}