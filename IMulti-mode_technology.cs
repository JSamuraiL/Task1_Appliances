using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    public interface IMulti_mode_technology //Интерфейс многорежимной техники
    {
        public int number_of_modes {  get; set; } //Количество режимов
        public string Manufacturer { get; set; } //Производитель
    }
}
