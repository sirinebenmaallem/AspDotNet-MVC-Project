using MonProjetdotNET.Data;
using MonProjetdotNET.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Models
{
    public class NewSweetmeatVM
    {
        public int Id { get; set; }

        [Display(Name = "Sweetmeat name")]
        [Required(ErrorMessage = "Sweetmeat is required")]
        public string Name { get; set; }

        [Display(Name = "Sweetmeat description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price ")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Sweetmeat poster URL")]
        [Required(ErrorMessage = "Sweetmeat poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Sweetmeat category is required")]
        public SweetmeatCategory SweetmeatCategory { get; set; }

        //Relationships
        [Display(Name = "Select Parfum(s)")]
        [Required(ErrorMessage = "Sweetmeat Parfum(s) is required")]
        public List<int> ParfumIds { get; set; }

        [Display(Name = "Select a chef")]
        [Required(ErrorMessage = "Sweetmeat chef is required")]
        public int ChefId { get; set; }
    }
}
