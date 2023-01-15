using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorLib.Lib
{
    internal class Knife : IArmor
    {
        public string Name => "Нож";
        public int Weight => 1;
        public int Damage => 40;
        public int Range => 1;
    }
}
