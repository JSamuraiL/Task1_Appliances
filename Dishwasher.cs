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
        public void Diswasher_exit(string Manufacturer, string energy_class, int number_of_modes) 
        {
            Console.Write("Dishwasher: ");
            if (string.IsNullOrEmpty(Manufacturer)) { Console.Write(" Error enter in Manufacturer"); };
            if (string.IsNullOrEmpty(energy_class)) { Console.Write(" Error enter in energy_class"); }
            Console.Write(" Energy class - " + energy_class);
            if (number_of_modes <= 0) { Console.Write(" Error enter in number_of_modes");}
            Console.WriteLine();
        }
    }
}
