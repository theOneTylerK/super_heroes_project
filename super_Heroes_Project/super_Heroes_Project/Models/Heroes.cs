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
        [Display(Name = "Primary Ability")]
        public string PrimaryAbility { get; set; }
        [Display(Name = "Secondary Ability")]
        public string SecondaryAbility { get; set; }
        [Display(Name = "Catchphrase")]
        public string Catchphrase { get; set; }

    }
}