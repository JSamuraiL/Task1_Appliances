using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Devices_with_color:electrical_appliances //Абстрактный класс цветной техники
    {
        public string color {  get; set; } //Цвет техники
    }
}
