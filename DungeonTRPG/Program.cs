using DungeonTRPG.Entity.Player;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Manager;
using DungeonTRPG.StateMachineSystem;
using DungeonTRPG.StateMachineSystem.SceneStates.Village;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Player", 1500, new Stat(1, 1, 1, 1, 1, 1, 1, 1), Job.Warrior);
            EquipItem item1 = GameManager.Instance.DataManager.GameData.EquipItemDB.GetByKey(2001);
            EquipItem item2 = GameManager.Instance.DataManager.GameData.EquipItemDB.GetByKey(4000);
            EquipItem item3 = GameManager.Instance.DataManager.GameData.EquipItemDB.GetByKey(7000);
            ActiveItem item4 = GameManager.Instance.DataManager.GameData.ActiveItemDB.GetByKey(1000);
            ActiveItem item5 = GameManager.Instance.DataManager.GameData.ActiveItemDB.GetByKey(1004);
            player.Inventory.AddItem(item1);
            player.Inventory.AddItem(item2);
            player.Inventory.AddItem(item4);
            player.Inventory.AddItem(item4);
            player.Inventory.AddItem(item4);
            player.Inventory.AddItem(item4);
            player.Inventory.AddItem(item5);
            player.Inventory.AddItem(item3);

            StateMachine machine = new StateMachine(player);

            machine.ChangeState(new VillageScene(machine));

            while (!machine.isGameOver)
            {
                machine.Update();
            }
        }
    }
}
