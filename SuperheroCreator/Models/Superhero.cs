using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string CatchPhrase { get; set; }

        [ForeignKey("PrimaryAbility")]
        public int PrimaryAbilityId { get; set; }
        public PrimaryAbility PrimarySuperHeroAbility { get; set; }

        [ForeignKey("SecondaryAbility")]
        public int SecondaryAbilityId { get; set; }
        public SecondaryAbility SecondarySuperHeroAbility { get; set; }
        
    }
}
