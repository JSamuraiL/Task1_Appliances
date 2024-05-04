using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Microwave : Appliances, IElectrical_appliances, IMulti_mode_technology
    {
        public string energy_class { get; set; }
        public int Power { get; set; }
        public int number_of_modes { get; set; }
        public void Microwave_exit(string Manufacturer, string energy_class, int number_of_modes, int Power)
        {
            Console.Write("Microwave:");
            if (string.IsNullOrEmpty(Manufacturer)) { Console.Write(" Error enter in Manufacturer"); };
            if (string.IsNullOrEmpty(energy_class)) { Console.Write(" Error enter in energy_class"); }
            Console.Write(" Energy class - " + energy_class);
            if (number_of_modes <= 0) { Console.Write(" Error enter of number_of_modes"); };
            if (Power <= 0) { Console.Write(" Error enter in Power"); };
            Console.WriteLine();
        }
    }
}
