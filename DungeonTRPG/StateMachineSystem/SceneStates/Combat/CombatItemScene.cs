using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class CombatItemScene : CombatScene
    {
        public int selectItem;

        public CombatItemScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine, enemys)
        {
        }

        public override void Enter()
        {
            base.Enter();
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[소비 아이템]");
            Console.ResetColor();

            bool hasFind = false;
            for (int i = inventory.boundaryIndex; i < items.Count; i++)
            {
                if (items[i] is ActiveItem)
                {
                    Console.WriteLine($"- {i - (inventory.boundaryIndex - 1)} {items[i].GetName()} | {items[i].GetDescription()}");
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
                else if (0 < num && num <= items.Count - inventory.boundaryIndex)
                {
                    ActiveItem item = (ActiveItem)items[num + (inventory.boundaryIndex - 1)];
                    if (UseableIn.OnlyIdle == item.UseableIn) SendMessage("전투가 아닌 상태에만 사용할 수 있습니다.");
                    else
                    {
                        selectItem = num + (inventory.boundaryIndex - 1);
                        stateMachine.preCombatScene = this;
                        stateMachine.ChangeState(new SelectEnemyScene(stateMachine, enemys));
                    }
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
