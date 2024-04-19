using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Dishwasher : Appliances, IMulti_mode_technology, IElectrical_appliances //Посудомоечная машина
    {
        public string energy_class { get; set; }
        public int number_of_modes { get; set; }
    }
}
