using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class CombatItemScene : CombatScene
    {
        public int selectItem;
        public int currentPage = 0;
        public int lastPage = 0;

        public CombatItemScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine, enemys)
        {
        }

        public override void Enter()
        {
            base.Enter();

            lastPage = (items.Count - inventory.boundaryIndex) / 5;
            currentPage = 0;
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            base.Exit();
        }

        protected override void View()
        {
            EnemyStats();

            int pageRange = inventory.boundaryIndex + ((1 + currentPage) * 5);
            if (pageRange > items.Count) pageRange = items.Count;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[소비 아이템]");
            Console.ResetColor();
            Console.WriteLine($" - {currentPage + 1} 페이지");

            bool hasFind = false;

            for (int i = inventory.boundaryIndex + (currentPage * 5); i < pageRange; i++)
            {
                if (items[i] is ActiveItem)
                {
                    Console.WriteLine($"- {i - (inventory.boundaryIndex - 1) - (currentPage * 5)} {items[i].GetName()} | {items[i].GetDescription()}");
                    hasFind = true;
                }
            }
            if (!hasFind) Console.WriteLine("보유하신 소비 아이템이 없습니다. \n");

            Console.WriteLine();

            if(currentPage > 0) Console.WriteLine("6. 이전 페이지");
            if(currentPage < lastPage) Console.WriteLine("7. 다음 페이지");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();

            var cursurPos = InputField();

            PlayerStats();

            Console.SetCursorPosition(cursurPos.Left, cursurPos.Top);
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();
                else if (num == 6 && currentPage > 0) currentPage--;
                else if (num == 7 && currentPage < lastPage) currentPage++;
                else if (0 < num && num <= 5)
                {
                    ActiveItem item = (ActiveItem)items[num + (inventory.boundaryIndex - 1) + (currentPage * 5)];
                    if (UseableIn.OnlyIdle == item.UseableIn) SendMessage("전투가 아닌 상태에만 사용할 수 있습니다.");
                    else
                    {
                        if (item.useOnSelf)
                        {
                            inventory.ItemUse(num + (inventory.boundaryIndex - 1) + (currentPage * 5), player, null);
                        }
                        else
                        {
                            selectItem = num + (inventory.boundaryIndex - 1 + (currentPage * 5));
                            stateMachine.preCombatScene = this;
                            stateMachine.ChangeState(new SelectEnemyScene(stateMachine, enemys));
                        }
                    }
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
