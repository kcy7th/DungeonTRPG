using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity.Utility
{
    internal class Inventory
    {
        private List<Item> items = new List<Item>();
        private int maxSlots;
        public int boundaryIndex { get; private set; } = 0;

        private Dictionary<EquipSlot, EquipItem> equippedItems = new Dictionary<EquipSlot, EquipItem>(); // 장착된 아이템

        public event Action<EquipItem> OnItemEquip;
        public event Action<EquipItem> OnItemUnEquip;

        public Inventory(int maxSlots = 10)
        {
            this.maxSlots = maxSlots;

            // null 값 할당 (오류 방지)
            foreach (EquipSlot slot in Enum.GetValues(typeof(EquipSlot)))
            {
                equippedItems[slot] = null;
            }
        }

        public bool AddItem(Item item)
        {
            if (items.Count < maxSlots)
            {
                if (item is EquipItem) boundaryIndex++;
                items.Add(item);
                items.Sort();
                return true;
            }
            return false;
        }

        public void ItemUse(int index, Character player, Character target)
        {
            if (items[index] is ActiveItem)
            {
                ((ActiveItem)items[index]).ItemUse(player, target);
                RemoveItem(index);
            }
            else
            {
                Console.WriteLine("사용 아이템이 아닙니다.");
            }
        }

        public void RemoveItem(int index)
        {
            if (index >= items.Count) return;
            items.RemoveAt(index);
        }

        public List<Item> GetItems() => items;

        public int GetMaxSlots() => maxSlots;

        // 가방 슬롯 구매
        public void ExpandSlots(int additionalSlots)
        {
            maxSlots += additionalSlots;
        }

        // 장착
        public bool EquipItem(EquipItem item)
        {
            if (equippedItems[item.Slot] != null)
            {
                equippedItems[item.Slot].IsEquipped = false;
                OnItemUnEquip?.Invoke(equippedItems[item.Slot]);
            }

            if(equippedItems[item.Slot] == item)
            {
                equippedItems[item.Slot].IsEquipped = false;
                equippedItems[item.Slot] = null;
            }
            else
            {
                equippedItems[item.Slot] = item;
                equippedItems[item.Slot].IsEquipped = true;
                OnItemEquip?.Invoke(item);
            }
            return true;
        }

        // 해제
        public bool UnequipItem(EquipSlot slot)
        {
            return equippedItems.Remove(slot);
        }

        // 장착된 아이템 확인
        public EquipItem? GetEquippedItem(EquipSlot slot)
        {
            return equippedItems.ContainsKey(slot) ? equippedItems[slot] : null;
        }
    }
}
