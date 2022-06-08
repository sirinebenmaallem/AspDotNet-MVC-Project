using MonProjetdotNET.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Models
{
    public class Sweetmeat
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Prix")]
        public double Price{ get; set; }
        [Display(Name = "Photo")]
        public string ImageURL{ get; set; }
        public SweetmeatCategory SweetmeatCategory { get; set; }
        //relations :
        public List<Parfum_Sweetmeat> Parfum_Sweetmeat { get; set; }

        public int ChefId { get; set; }
        [ForeignKey("ChefId")]
        public Chef Chef { get; set; }

    }
}
