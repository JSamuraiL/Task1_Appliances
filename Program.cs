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
    number_of_modes = 3,
    energy_class = "C"
};

Console.WriteLine(Iron.ToString().Substring(6)+ ": " + Iron.energy_class);
Console.WriteLine(Washer.ToString().Substring(6) + ": " + Washer.energy_class);
Console.WriteLine(Microwave.ToString().Substring(6) + ": " + Microwave.energy_class);
Console.WriteLine(Diswasher.ToString().Substring(6) + ": " + Diswasher.energy_class);
//Должно вывести название техники и её класс энергопотребления