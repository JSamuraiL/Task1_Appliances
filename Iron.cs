using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Iron:Devices_with_color //Создаем утюг, имеющий производителя, цвет и класс энергопотребления
    {
        public string set_of_functions {  get; set; } //Добавляем набор функций
        public void Iron_exit(string Manufacturer, string energy_class, string set_of_functions, string color)
        {
            Console.Write("Iron:");
            if (string.IsNullOrEmpty(Manufacturer)) { Console.Write(" Error enter in Manufacturer"); };
            if (string.IsNullOrEmpty(energy_class)) { Console.Write(" Error enter in energy_class"); }
            Console.Write("Energy class - " + energy_class);
            if (string.IsNullOrEmpty(color)) { Console.WriteLine(" Error enter in color"); };
            if (string.IsNullOrEmpty(set_of_functions)) { Console.WriteLine(" Error enter in set_of_functions"); };
            Console.WriteLine();
        }
    }
}
