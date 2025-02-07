using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Item
{
    internal class EquipItem : Item
    {
        public EquipItem(string name, string description) : base(name, description)
        {
        }

        public override Item Clone()
        {
            throw new NotImplementedException();
        }
    }
}
