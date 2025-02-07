using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Item
{
    internal class ActiveItem : Item
    {
        public ActiveItem(string name, string description) : base(name, description)
        {
        }

        public override Item Clone()
        {
            return new ActiveItem(name, description);
        }
    }
}
