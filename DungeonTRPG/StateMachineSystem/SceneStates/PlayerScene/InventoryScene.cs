using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Items;

namespace DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene
{
    internal class InventoryScene : SceneState
    {
        private Inventory inventory;

        internal InventoryScene(StateMachine stateMachine) : base(stateMachine)
        {
            inventory = stateMachine.Player.Inventory;
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();
        }

        // 인벤토리 함수 
        protected override void View()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("인벤토리");
            Console.ResetColor();
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            // 장착 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[장착 아이템]");
            Console.ResetColor();

            List<Item> items = inventory.GetItems();

            for (int i = 0; i < inventory.BoundaryIndex; i++)
            {
                string equipment = ((EquipItem)items[i]).IsEquipped ? " [E]" : "";
                Console.WriteLine($"- {i + 1}{equipment} {items[i].GetItemInformation()}");
            }
            if (inventory.BoundaryIndex == 0) Console.WriteLine("보유하신 장착 아이템이 없습니다. \n");

            Console.WriteLine();

            // 소비 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[소비 아이템]");
            Console.ResetColor();

            for (int i = inventory.BoundaryIndex; i < items.Count; i++)
            {
                Console.WriteLine($"- {items[i].GetItemInformation()}");
            }
            if (inventory.BoundaryIndex == items.Count) Console.WriteLine("보유하신 장착 아이템이 없습니다. \n");

            // 행동 선택
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("2. 소비 아이템");
            Console.WriteLine("0. 나가기");

            Console.WriteLine();

            InputField();
        }

        // 씬 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                // 이전으로 돌아가기
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                case "1":
                    stateMachine.ChangeState(stateMachine.EquipmentScene);
                    break;
                case "2":
                    stateMachine.ChangeState(stateMachine.ItemUseScene);
                    break;
                // 다른 입력
                default:
                    SendMessage("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
