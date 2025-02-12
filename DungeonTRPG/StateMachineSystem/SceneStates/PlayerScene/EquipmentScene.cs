using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;

namespace DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene
{
    internal class EquipmentScene : SceneState
    {
        private Inventory? inventory;

        internal EquipmentScene(StateMachine stateMachine) : base(stateMachine)
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

        protected override void View()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("인벤토리 - 장착관리");
            Console.ResetColor();
            Console.WriteLine("이 곳에서 장비를 착용할 수 있습니다.\n");

            // 장착 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[장착 아이템]");
            Console.ResetColor();

            List<Item> items = stateMachine.Player.Inventory.GetItems();

            for (int i = 0; i < inventory.BoundaryIndex; i++)
            {
                string equipment = ((EquipItem)items[i]).IsEquipped ? " [E]" : "";
                Console.WriteLine($"- {i + 1}{equipment} {items[i].GetItemInformation()}");
            }
            if (inventory.BoundaryIndex == 0) Console.WriteLine("보유하신 장착 아이템이 없습니다. \n");

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

                if (0 < num && num <= inventory.BoundaryIndex)
                {
                    inventory.EquipItem(inventory.GetItems()[num - 1] as EquipItem);
                }
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
