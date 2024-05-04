// See https://aka.ms/new-console-template for more information
using Task1;

Console.WriteLine("Hello, World!");
var Iron = new Iron {
    Manufacturer = "Tefal",
    color = "Blue",
    set_of_functions = "Отпарить, погладить, брызнуть водой",
    energy_class = "A++"
};
var Washer = new Washer {
    Manufacturer = "Samsung",
    color = "White",
    type_of_load = "Fast",
    energy_class = "A+"
};
var Gas_stove = new Gas_stove {
    Manufacturer = "Трудяга",
    number_of_burner = 4,
    number_of_modes = 6,
    built_in = true
};
var Microwave = new Microwave { 
    Manufacturer = "Panasonic",
    Power = 700,
    number_of_modes = 7,
    energy_class = "B"
};
var Diswasher = new Dishwasher { 
    Manufacturer = "Samsung",
    number_of_modes = 0,
    energy_class = "A"
};
Iron.Iron_exit(Iron.Manufacturer, Iron.energy_class, Iron.set_of_functions, Iron.color);
Diswasher.Diswasher_exit(Diswasher.Manufacturer, Diswasher.energy_class, Diswasher.number_of_modes);
Washer.Washer_exit(Washer.Manufacturer, Washer.energy_class, Washer.color, Washer.type_of_load);
Microwave.Microwave_exit(Microwave.Manufacturer, Microwave.energy_class, Microwave.number_of_modes, Microwave.Power);
Gas_stove.Gas_stove_exit(Gas_stove.Manufacturer, Gas_stove.number_of_burner, Gas_stove.number_of_modes);
//Должно вывести название техники и её класс энергопотребления