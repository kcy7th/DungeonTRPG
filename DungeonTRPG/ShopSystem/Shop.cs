using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Manager;
using DungeonTRPG.Manager.Data;

namespace DungeonTRPG.ShopSystem
{
    internal class Shop
    {
        public List<Item> Items { get; private set; } = new List<Item>(); // 판매 아이템 목록
        public int BoundaryIndex { get; private set; } = 0;
        private GameData gameData;

        public Shop()
        {
            this.gameData = GameManager.Instance.DataManager.GameData;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            if (item is EquipItem) BoundaryIndex++;
            Items.Sort();
        }

        public void AddItem(int index)
        {
            Item item = gameData.ActiveItemDB.GetByKey(index);
            if (item != null) item = gameData.EquipItemDB.GetByKey(index);

            if (item != null)
            {
                Items.Add(item);
                if (item is EquipItem) BoundaryIndex++;
                Items.Sort();
            }
        }

        // 아이템 구매
        public Item BuyItem(int index)
        {
            Item item = Items[index];
            if (item is EquipItem) BoundaryIndex--;
            Items.RemoveAt(index);
            return item;
        }

        // 판매 아이템 목록 반환
        public Item GetItem(int index)
        {
            return Items[index];
        }
    }
}
