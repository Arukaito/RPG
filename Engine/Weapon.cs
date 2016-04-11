using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {

        public new int ID { get; set; }
        public new int Name { get; set; }
        public int NamePlural { get; set; }
        public int MaximumDamage { get; set; }
        public int MinimumDamage { get; set; }

    }
}
