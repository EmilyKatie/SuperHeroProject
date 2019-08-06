using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroProject.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string alterEgo { get; set; }
        public string firstAbility { get; set; }

        public string secondAbility { get; set; }
        public string catchphrase { get; set; }
    }

}
