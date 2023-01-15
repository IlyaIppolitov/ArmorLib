using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorLib.Lib
{
    public interface IArmor
    {
        string Name { get; }
        int Weight { get; }        
        int Damage { get; }
        int Range { get; }

        public static IArmor NewArmor(string armorName)
        {
            if (armorName == "Revolver")
                return new Revolver();
            else if (armorName == "MiniGun")
                return new MiniGun();
            else if (armorName == "Knife")
                return new Knife();
            throw new ArgumentException($"No such Armor {armorName}", armorName);
        }

    }
}
