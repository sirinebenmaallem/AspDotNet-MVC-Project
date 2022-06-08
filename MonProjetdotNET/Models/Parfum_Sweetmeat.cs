using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Models
{
    public class Parfum_Sweetmeat
    {
        public int SweetmeatId { get; set; }
        public Sweetmeat Sweetmeat { get; set; }

        public int ParfumId { get; set; }
        public Parfum Parfum { get; set; }
    }
}
