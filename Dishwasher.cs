using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Dishwasher : Appliances, multi_mode_technology, electrical_appliances
    {
        public string energy_class { get; set; }
        public string Manufacturer { get; set; }
        public int number_of_modes { get; set; }
    }
}
