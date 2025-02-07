using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Item
{
    internal abstract class Item
    {
        protected string name;
        protected string description;

        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        public abstract Item Clone();
    }
}
