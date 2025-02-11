using DungeonTRPG.Items;

namespace DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene
{
    internal class InventoryScene : SceneState
    {
        internal InventoryScene(StateMachine stateMachine) : base(stateMachine)
        {
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

            List<Item> Items = stateMachine.Player.Inventory.GetItems();
            bool hasEquip = false;
            foreach (var item in Items)
            {
                if (item is EquipItem)
                {
                    string equipment = ((EquipItem)item).IsEquipped ? " [E]" : "";
                    Console.WriteLine($"-{equipment} {item.GetName()} | {item.GetDescription()}");
                    hasEquip = true;
                }
            }
            if (!hasEquip) Console.WriteLine("보유하신 장착 아이템이 없습니다.");

            Console.WriteLine();

            // 소비 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[소비 아이템]");
            Console.ResetColor();

            bool hasActive = false;
            foreach (var item in Items)
            {
                if (item is ActiveItem)
                {
                    Console.WriteLine($"- {item.GetName()} | {item.GetDescription()}");
                    hasActive = true;
                }
            }
            if (!hasActive) Console.WriteLine("보유하신 소비 아이템이 없습니다.");

            // 행동 선택
            Console.WriteLine("\n1. 장착 관리");
            Console.WriteLine("0. 나가기");

            Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
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
