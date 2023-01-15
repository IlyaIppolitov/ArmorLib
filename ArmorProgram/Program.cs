using ArmorLib;
using ArmorLib.Lib;

var text = "";

while (text != "0")
{
    Console.WriteLine("Выход - 0");
    Console.WriteLine("Введите название оружия: ");

    text = Console.ReadLine();
    if (text != "0")
    {
        var someArmor = IArmor.NewArmor(text);
        Console.WriteLine(someArmor.Name);
    }
}