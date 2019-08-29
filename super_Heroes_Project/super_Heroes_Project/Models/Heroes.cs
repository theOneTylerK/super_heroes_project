using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace super_Heroes_Project.Models
{
    public class Heroes
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Real Name")]
        public string RealName { get; set; }
        [Display(Name = "Alter Ego")]
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }

    }
}