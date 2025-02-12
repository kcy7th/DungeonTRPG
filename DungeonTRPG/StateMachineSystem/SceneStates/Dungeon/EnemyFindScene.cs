using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.EntitySystem;
using DungeonTRPG.Manager.Data;
using DungeonTRPG.StateMachineSystem.SceneStates.Combat;
using DungeonTRPG.Manager;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class EnemyFindScene : DungeonScene
    {
        private List<Enemy> enemys = new List<Enemy>();

        internal EnemyFindScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            enemys.Clear();

            int enemyCount = Random.Next(1, 5);

            for(int i = 0; i < enemyCount; i++)
            {
                int enemyIndex = GetRandomIndexInBoundery();
                Enemy enemy = GameManager.Instance.DataManager.GameData.EnemyDB.GetByKey(7999 + enemyIndex);
                enemys.Add(enemy);
            }
        }

        private int GetRandomIndexInBoundery()
        {
            int index = Random.Next(stateMachine.currentFloor - 2, stateMachine.currentFloor + 2);
            if (index < 1) index = 1;
            else if(index > 100) index = 100;

            return index;
        }

        // 전투 함수
        protected override void View()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("몬스터와 조우");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("몬스터와 만났습니다.");
            Console.WriteLine("");
            Console.ResetColor();


            // 선택창 보기 
            ViewSelect();
        }

        // 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================");
            Console.WriteLine("||     행동을 선택해 주세요      ||");
            Console.WriteLine("||    1. 싸운다   0.도망간다     ||");
            Console.WriteLine("===================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 행동 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                // 도망간다
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                case "1":
                    // 싸운다
                    stateMachine.ChangeState(new CombatScene(stateMachine, enemys));
                    break;
                // 다른 입력
                default:
                    SendMessage("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
