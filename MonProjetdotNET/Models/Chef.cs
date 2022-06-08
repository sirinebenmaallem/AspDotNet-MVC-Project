using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Models
{
    public class Chef
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Photo du chef")]
        public string PictureURL { get; set; }
        [Display(Name = "Nom du chef ")]
        public string FullName { get; set; }
        [Display(Name = "Biographie du chef")]
        public string Bio { get; set; }
        //relation entre les sweetmeats et les chefs :
        //(relation one to many où un chef peut produire
        //plusieurs sweets or que la creation d'une
        //sweet ne peut etre gérer que par un  seul
        //chef  d'equipe de cuisine):
        public List<Sweetmeat> Sweatmeats{get;set;}
    }
}
