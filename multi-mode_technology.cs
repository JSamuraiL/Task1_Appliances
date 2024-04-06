using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    public abstract class multi_mode_technology:Appliances //Класс многорежимной техники
    {
        public int number_of_modes {  get; set; } //Количество режимов
    }
}
