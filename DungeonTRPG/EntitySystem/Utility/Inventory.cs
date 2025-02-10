using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Entity.Utility
{
    internal class Inventory
    {
        private List<Bag> bags = new List<Bag>(); // 가방 리스트
        private Dictionary<EquipSlot, EquipItem> equippedItems = new Dictionary<EquipSlot, EquipItem>(); // 장착된 아이템

        public Inventory()
        {
            bags.Add(new Bag(10)); // 기본 가방 추가

            // null 값 할당 (오류 방지)
            foreach (EquipSlot slot in Enum.GetValues(typeof(EquipSlot)))
            {
                equippedItems[slot] = null;
            }
        }

        // 가방에 ActiveItem 추가
        public bool AddItemToBag(ActiveItem item)
        {
            foreach (var bag in bags)
            {
                if (bag.AddItem(item))
                    return true;
            }
            return false;
        }

        // 가방 슬롯 구매
        public void AddBag(Bag newBag)
        {
            bags.Add(newBag);
        }

        public List<Bag> GetBags() => bags;

        // 장착
        public bool EquipItem(EquipItem item)
        {
            equippedItems[item.Slot] = item;
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

        // 장비 종류 별 아이템 필터링 -- 여기부터 추가로 한 건데, 여기서 구현하는 게 맞나 싶어서요
        public List<EquipItem> GetItemsByEquipSlot(EquipSlot slot)
        {
            List<EquipItem> filteredItems = new List<EquipItem>();
            foreach (var bag in bags)
            {
                filteredItems.AddRange(
                    bag.GetItems().OfType<EquipItem>().Where(item => item.Slot == slot)
                );
            }
            return filteredItems;
        }

        // 직업 별 아이템 필터링
        public List<Item> GetItemsByJob(Job job)
        {
            List<Item> filteredItems = new List<Item>();
            foreach (var bag in bags)
            {
                filteredItems.AddRange(
                    bag.GetItems().Where(item => item.AllowedJobs.Contains(job))
                );
            }
            return filteredItems;
        }
    }

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
