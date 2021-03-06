﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CocktailMVC.Models
{
    public class Cocktail
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Range(1.00, 299.00)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public Theme Theme { get; set; }

        [Required]
        public int ThemeId { get; set; }
    }
}