using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorLib.Lib
{
    internal class Revolver : IArmor
    {
        public string Name => "Револьвер";
        public int Weight => 3;
        public int Damage => 20;
        public int Range => 20;
    }
}
