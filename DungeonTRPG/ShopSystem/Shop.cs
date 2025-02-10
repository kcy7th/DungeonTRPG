using System;
using System.Collections.Generic;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;

namespace DungeonTRPG.ShopSystem
{
    internal class Shop
    {
        private List<Item> availableItems = new List<Item>(); // 판매 아이템 목록

        public void AddItemToShop(Item item)
        {
            availableItems.Add(item);
        }

        // 아이템 구매 (ActiveItem은 가방에 추가, EquipItem은 인벤토리에 추가)
        public bool BuyItem(Item item, Inventory playerInventory)
        {
            if (item is ActiveItem activeItem && playerInventory.AddItem(activeItem))
            {
                availableItems.Remove(item);
                return true;
            }
            else if (item is EquipItem equipItem && playerInventory.EquipItem(equipItem))
            {
                availableItems.Remove(item);
                return true;
            }
            return false;
        }

        // 판매 아이템 목록 반환
        public List<Item> GetItems()
        {
            return availableItems;
        }
    }
}
