using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class FightScene : SceneState
    {
        string input = "";

        internal FightScene(StateMachine stateMachine) : base(stateMachine)
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

            // 전투 
            FightRoop();
        }

        // 전투 함수
        private void FightRoop()
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

            // 입력
            input = Console.ReadLine();

            // 행동 선택 
            SelectAction(input);
        }

        // 행동 선택 함수 
        private void SelectAction(string input)
        {
            switch (input)
            {
                // 도망간다
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();

                    // 이전 데이터 지우기 
                    stateMachine.PreviousDataClear();
                    break;
                case "1":
                    // 싸운다
                    break;
                // 다른 입력
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
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
    }
}
