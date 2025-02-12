using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity.Utility
{
    internal class Inventory
    {
        internal Character Character { get; }

        private List<Item> items = new List<Item>();
        private int maxSlots;
        public int BoundaryIndex { get; private set; } = 0;

        private Dictionary<EquipSlot, EquipItem> equippedItems = new Dictionary<EquipSlot, EquipItem>(); // 장착된 아이템


        public Inventory(Character character, int maxSlots = 10)
        {
            Character = character;

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
                if (item is EquipItem) BoundaryIndex++;
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

            if (items[index] is EquipItem) BoundaryIndex--;
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
                Character.OnItemUnEquipped(item);
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
                Character.OnItemEquipped(item);
            }
            return true;
        }

        // 장착된 아이템 확인
        public EquipItem? GetEquippedItem(EquipSlot slot)
        {
            return equippedItems.ContainsKey(slot) ? equippedItems[slot] : null;
        }

        public int GetTotalEquipHp()
        {
            int totalHp = 0;
            foreach (var item in equippedItems)
            {
                if(item.Value != null) totalHp += item.Value.ExtraStat.Hp;
            }

            return totalHp;
        }

        public int GetTotalEquipMp()
        {
            int totalMp = 0;
            foreach (var item in equippedItems)
            {
                if (item.Value != null) totalMp += item.Value.ExtraStat.Mp;
            }

            return totalMp;
        }

        public int GetTotalEquipAtk()
        {
            int totalAtk = 0;
            foreach (var item in equippedItems)
            {
                if (item.Value != null) totalAtk += item.Value.ExtraStat.Atk;
            }

            return totalAtk;
        }

        public int GetTotalEquipDef()
        {
            int totalDef = 0;
            foreach (var item in equippedItems)
            {
                if (item.Value != null) totalDef += item.Value.ExtraStat.Def;
            }

            return totalDef;
        }
    }
}
