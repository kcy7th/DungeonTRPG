using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class EnemyFindScene : SceneState
    {
        internal EnemyFindScene(StateMachine stateMachine) : base(stateMachine)
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
                    stateMachine.ChangeState(stateMachine.CombatScene);
                    break;
                // 다른 입력
                default:
                    SendMessage("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
