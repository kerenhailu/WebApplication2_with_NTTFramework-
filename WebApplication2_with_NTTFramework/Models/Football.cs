using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2_with_NTTFramework.Models
{
    public class Football
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required , MaxLength(15)]
        public string LName { get; set; }
        public int Position { get; set; }
        public int Age { get; set; }
    }
}