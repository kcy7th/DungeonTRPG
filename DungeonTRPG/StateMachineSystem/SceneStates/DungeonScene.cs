﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class DungeonScene : SceneState
    {
        private string input = "";

        internal DungeonScene(StateMachine stateMachine) : base(stateMachine)
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

            // 던전 루프  
            DungeonRoop();
        }

        // 던전 루프 함수 
        private void DungeonRoop()
        {           
            // 루프 불
            bool isRoop = true;

            // 메인 루프
            while (isRoop)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("던전");
                Console.WriteLine("");
                ViewSelect();
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        IntoDungeon();
                        input = Console.ReadLine();
                        break;
                    case "2":
                        // 인벤토리로 가기 
                        stateMachine.ChangeState(stateMachine.InventoryScene);
                        isRoop = false;
                        break;
                    case "0":
                        // 이전 상태로 돌아가기 
                        stateMachine.GoPreviousState();

                        // 이전 데이터 지우기 
                        stateMachine.PreviousDataClear();
                        isRoop = false;
                        break;
                    default:
                        break;
                }
            }
        }

        // 던전 내 선택지 보기 함수
        private void ViewSelect()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("||            행동을 선택해 주세요         ||");
            Console.WriteLine("||      1. 탐험 2. 인벤토리 0. 나가기      ||");
            Console.WriteLine("==============================================");
            Console.WriteLine("");
        }

        private void IntoDungeon()
        {
            Console.Clear();
            Console.WriteLine("던전");
            Console.WriteLine("");
            Console.WriteLine("=================================================================================");
            Console.WriteLine("||                               행동을 선택해 주세요                          ||");
            Console.WriteLine("||      1. 몬스터 조우 2. 휴식 공간 3. 비밀 상점 4. 의문의 상자 0. 나가기      ||");
            Console.WriteLine("=================================================================================");
            Console.WriteLine("");
        }
    }
}
