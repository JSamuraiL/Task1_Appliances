using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Gas_stove : Appliances, IMulti_mode_technology
    {
        public int number_of_modes { get; set; }
        public string Manufacturer { get; set; }
        public int number_of_burner { get; set; }
        public bool built_in { get; set; }
    }
}
