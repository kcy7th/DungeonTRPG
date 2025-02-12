using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.EntitySystem;
using DungeonTRPG.Manager.Data;
using DungeonTRPG.StateMachineSystem.SceneStates.Combat;
using DungeonTRPG.Manager;
using DungeonTRPG.EntitySystem.SkillSystem;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class EnemyFindScene : DungeonScene
    {
        internal EnemyFindScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        private int GetRandomIndexInBoundery()
        {
            int index = Random.Next(stateMachine.currentFloor - 2, stateMachine.currentFloor + 2);
            if (index % 10 == 0 && index / 10 != 0) index--;
            else if (index < 1) index = 1;
            else if (index > 100) index = 100;

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
            Console.WriteLine("||     행동을 선택해 주세요       ||");
            Console.WriteLine("||  1. 싸운다   0. 몰래 지나간다  ||");
            Console.WriteLine("===================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 행동 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            int random = Random.Next(0, 101);

            if (int.TryParse(input, out var num))
            {
                if (num == 0)
                {
                    if (random > 50)
                    {
                        SendMessage("몰래 지나가다가 발각 되었습니다.");
                        CreateEnemys();
                        stateMachine.ChangeState(stateMachine.CombatScene);
                    }
                    else
                    {
                        SendMessage("무사히 몰래 지나쳤습니다.");
                        stateMachine.GoPreviousState();
                    }
                }
                else if(num == 1)
                {
                    CreateEnemys();
                    stateMachine.ChangeState(stateMachine.CombatScene);
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }

        private void CreateEnemys()
        {
            stateMachine.enemys.Clear();

            if (stateMachine.currentFloor % 10 == 0 && stateMachine.exploredCount == 10)
            {
                Enemy enemy = GameManager.Instance.DataManager.GameData.EnemyDB.GetByKey(7999 + stateMachine.currentFloor);
                stateMachine.enemys.Add(enemy);
            }
            else
            {
                int enemyCount = Random.Next(1, 5);

                for (int i = 0; i < enemyCount; i++)
                {
                    int enemyIndex = GetRandomIndexInBoundery();
                    Enemy enemy = GameManager.Instance.DataManager.GameData.EnemyDB.GetByKey(7999 + enemyIndex);
                    stateMachine.enemys.Add(enemy);
                }
            }
        }
    }
}
