using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Models
{
    public class Parfum
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Photo")]
        [Required (ErrorMessage ="Picture is required")]
        public string PictureURL{ get; set; }


        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Nom is required")]
        [StringLength(20,MinimumLength =3, ErrorMessage = "Nom must be between 3 and 10 chars")]
        public string FullName { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }


        //Relations:
        public List<Parfum_Sweetmeat> Parfum_Sweetmeat { get; set; }
    }
}
