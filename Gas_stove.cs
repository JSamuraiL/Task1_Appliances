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
        public void Gas_stove_exit(string Manufacturer, int number_of_burner, int number_of_modes)
        {
            if (string.IsNullOrEmpty(Manufacturer)|| (number_of_modes <= 0)|| (number_of_burner <= 0)) { 
                Console.Write("Gas stove:");
            if (string.IsNullOrEmpty(Manufacturer)) { Console.Write(" Error enter in Manufacturer"); };
            if (number_of_modes <=0) { Console.Write(" Error enter in number_of_modes"); };
            if (number_of_burner <= 0) { Console.Write(" Error enter in number_of_burner"); };
            Console.WriteLine();
            }
        }
    }
}
