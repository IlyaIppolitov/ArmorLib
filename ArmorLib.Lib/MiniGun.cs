using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorLib.Lib
{
    internal class MiniGun : IArmor
    {
        public string Name => "Миниган";
        public int Weight => 14;
        public int Damage => 60;
        public int Range => 40;
    }
}
