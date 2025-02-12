using DungeonTRPG.Entity;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene
{
    internal class ItemUseScene : SceneState
    {
        private Inventory inventory;
        private List<Item> items;
        internal ItemUseScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            inventory = stateMachine.Player.Inventory;
            items = inventory.GetItems();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();
        }

        protected override void View()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("인벤토리 - 소비 아이템");
            Console.ResetColor();
            Console.WriteLine("이 곳에서 아이템을 사용할 수 있습니다.\n");

            // 장착 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[소비 아이템]");
            Console.ResetColor();

            bool hasFind = false;
            for (int i = inventory.BoundaryIndex; i < items.Count; i++)
            {
                if (items[i] is ActiveItem)
                {
                    Console.WriteLine($"- {i - (inventory.BoundaryIndex - 1)} {items[i].GetItemInformation()}");
                    hasFind = true;
                }
            }
            if (!hasFind) Console.WriteLine("보유하신 소비 아이템이 없습니다. \n");

            Console.WriteLine();

            // 행동 선택
            Console.WriteLine("0. 나가기");
            Console.WriteLine();

            InputField();
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();
                else if (0 < num && num <= items.Count - inventory.BoundaryIndex)
                {
                    ActiveItem item = (ActiveItem)items[num + (inventory.BoundaryIndex - 1)];
                    if (UseableIn.OnlyCombat == item.UseableIn) SendMessage("전투 중에만 사용할 수 있습니다.");
                    else inventory.ItemUse(num + (inventory.BoundaryIndex - 1), stateMachine.Player, new List<Character>() { stateMachine.Enemy });
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
