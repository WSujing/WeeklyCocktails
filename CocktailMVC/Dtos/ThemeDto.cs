using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CocktailMVC.Dtos
{
    public class ThemeDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}