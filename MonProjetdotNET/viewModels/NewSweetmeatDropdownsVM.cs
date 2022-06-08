using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Data.ViewModels
{
    public class NewSweetmeatDropdownsVM
    {
        public NewSweetmeatDropdownsVM()
        {
            Chefs = new List<Chef>();
            Parfums = new List<Parfum>();
        }

        public List<Chef> Chefs { get; set; }
        public List<Parfum> Parfums { get; set; }
    }
}
