using DungeonTRPG.Manager.Data;

namespace DungeonTRPG.ShopSystem
{
    internal class SecretShop : Shop
    {
        private SecretItemDB secretItemDB;

        public SecretShop()
        {
            secretItemDB = new SecretItemDB();
            LoadSecretItems();
        }

        private void LoadSecretItems()
        {
            foreach (var item in secretItemDB.Items.Values)
            {
                AddItem(item);
            }
        }
    }
}
