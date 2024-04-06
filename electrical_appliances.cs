using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class electrical_appliances //Абстрактный класс электрических приборов
    {
        public string energy_class {  get; set; } //Класс энергопотребления, string, так как используются буквенные обозначения
    }
}
