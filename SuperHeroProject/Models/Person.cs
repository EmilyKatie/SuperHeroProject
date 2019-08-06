using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroProject.Models
{
    public class Person
    {   [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
    
}