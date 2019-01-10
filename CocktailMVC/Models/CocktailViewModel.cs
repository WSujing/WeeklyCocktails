using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CocktailMVC.Models
{
    public class CocktailViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Range(1.00, 299.00)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Theme")]
        public int ThemeId { get; set; }


        public IEnumerable<Theme> Themes { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Cocktail" : "Add New Cocktail";
            }
        }

        public CocktailViewModel()
        {
            Id = 0;
        }
        public CocktailViewModel(Cocktail cocktail)
        {
            Id = cocktail.Id;
            Name = cocktail.Name;
            Price = cocktail.Price;
            Description = cocktail.Description;
            ThemeId = cocktail.ThemeId;
        }
    }
}