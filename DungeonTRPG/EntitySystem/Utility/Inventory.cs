using System;
using System.Collections.Generic;
using DungeonTRPG.Utility.Enums;
using DungeonTRPG.Items;

namespace DungeonTRPG.Entity.Utility
{
    internal class Inventory
    {
        private List<Item> items = new List<Item>();  // 아이템 목록
        private int maxSlots = 10;  // 기본 인벤 슬롯 수

        
        // 아이템 추가
        public bool AddItem(Item item)
        {
            // 슬롯 남아있을 경우
            if (items.Count < maxSlots)
            {
                items.Add(item);
                return true;
            }
            return false;
        }

        // 슬롯 확장
        public void ExpandSlots(int additionalSlots)
        {
            maxSlots += additionalSlots;
        }

        // 보유 아이템 리스트
        public List<Item> GetItems() => items;

        private Dictionary<EquipSlot, EquipItem> equippedItems = new Dictionary<EquipSlot, EquipItem>();

        // 아이템 장착, 교체
        public bool EquipItem(EquipSlot slot, EquipItem item)
        {
            equippedItems[slot] = item;
            return true;
        }

        public EquipItem? GetEquippedItem(EquipSlot slot)
        {
            return equippedItems.ContainsKey(slot) ? equippedItems[slot] : null;
        }
    }
}
