﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroCreator.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperHeroAbility { get; set; }
        public string SecondarySuperHeroAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}
