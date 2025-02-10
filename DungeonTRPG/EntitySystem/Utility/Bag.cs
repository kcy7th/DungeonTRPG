using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonTRPG.Items;

namespace DungeonTRPG.EntitySystem.Utility
{
    internal class Bag
    {
        private List<ActiveItem> items = new List<ActiveItem>();
        private int maxSlots;

        public Bag(int maxSlots = 10)
        {
            this.maxSlots = maxSlots;
        }

        public bool AddItem(ActiveItem item)
        {
            if (items.Count < maxSlots)
            {
                items.Add(item);
                return true;
            }
            return false;
        }

        public bool RemoveItem(ActiveItem item)
        {
            return items.Remove(item);
        }

        public List<ActiveItem> GetItems() => items;

        public int GetMaxSlots() => maxSlots;

        public void ExpandSlots(int additionalSlots)
        {
            maxSlots += additionalSlots;
        }
    }
}