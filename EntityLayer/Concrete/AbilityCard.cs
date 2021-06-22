using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AbilityCard
    {
        [Key]
        public int AbilityCardId { get; set; }

        [StringLength(250)]
        public string Title  { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Ability1 { get; set; }

        [StringLength(100)]
        public string Ability2 { get; set; }

        [StringLength(100)]
        public string Ability3 { get; set; }

        [StringLength(100)]
        public string Ability4 { get; set; }

        [StringLength(100)]
        public string Ability5 { get; set; }

        [StringLength(100)]
        public string Ability6 { get; set; }

        [StringLength(100)]
        public string Ability7 { get; set; }

        [StringLength(100)]
        public string Ability8 { get; set; }

        [StringLength(100)]
        public string Ability9 { get; set; }

        [StringLength(100)]
        public string Ability10 { get; set; }
        [StringLength(250)]
        public string ImageUrl { get; set; }
        public int AbilityRate1 { get; set; }
        public int AbilityRate2 { get; set; }
        public int AbilityRate3 { get; set; }
        public int AbilityRate4 { get; set; }
        public int AbilityRate5 { get; set; }
        public int AbilityRate6 { get; set; }
        public int AbilityRate7 { get; set; }
        public int AbilityRate8 { get; set; }
        public int AbilityRate9 { get; set; }
        public int AbilityRate10 { get; set; }
        
    }
}
