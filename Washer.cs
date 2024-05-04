using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Washer:Devices_with_color
    {
        public string type_of_load {  get; set; } //Способ загрузки
        public void Washer_exit(string Manufacturer, string energy_class, string color, string type_of_load)
        {
            Console.Write("Washer:");
            if (string.IsNullOrEmpty(Manufacturer)) { Console.Write(" Error enter in Manufacturer, "); };
            if (string.IsNullOrEmpty(energy_class)) { Console.Write(" Error enter in energy_class, "); }
            Console.Write(" Energy class - " + energy_class);
            if (string.IsNullOrEmpty(color)) { Console.Write(" Error enter in color, "); };
            if (string.IsNullOrEmpty(type_of_load)) { Console.Write(" Error enter in type_of_load, "); };
            Console.WriteLine();
        }
    }
}
