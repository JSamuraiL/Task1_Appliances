using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Microwave : Appliances, electrical_appliances, multi_mode_technology
    {
        public string energy_class { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public int number_of_modes { get; set; }
    }
}
