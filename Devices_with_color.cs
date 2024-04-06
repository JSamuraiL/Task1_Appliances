using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Devices_with_color:Appliances,IElectrical_appliances //Абстрактный класс цветной техники
    {
        public string color {  get; set; } //Цвет техники
        public string energy_class { get; set; } //Класс энергопотребления  
        public string Manufacturer { get; set; } //Производитель
    }
}
