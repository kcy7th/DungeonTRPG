using System;
using System.Collections.Generic;
using System.Linq;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;

namespace DungeonTRPG.ShopSystem
{
    internal class Shop
    {
        private List<Item> availableItems = new List<Item>();  // 판매 아이템 목록

        // 상점에 아이템 추가
        public void AddItemToShop(Item item)
        {
            availableItems.Add(item);
        }

        // 아이템 구매 (인벤에 추가, 상점에서 제거)
        public bool BuyItem(Item item, Inventory playerInventory)
        {
            if (playerInventory.AddItem(item))
            {
                availableItems.Remove(item);
                return true;
            }
            return false;
        }

        // 아이템 목록 반환
        public List<Item> GetItems()
        {
            return availableItems;
        }
    }
}
