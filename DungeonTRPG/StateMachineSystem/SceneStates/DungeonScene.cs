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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("던전");
            Console.WriteLine("");
            ViewSelect();
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AdventureDungeon(RandomInt());
                    break;
                case "2":
                    // 인벤토리로 가기 
                    stateMachine.ChangeState(stateMachine.InventoryScene);
                    break;
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();

                    // 이전 데이터 지우기 
                    stateMachine.PreviousDataClear();
                    break;
                default:
                    break;
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

        private int RandomInt()
        {
            Random random = new Random();
            int randInt = random.Next(1, 5);

            return randInt;
        }

        private void AdventureDungeon(int randInt)
        {
            switch (randInt)
            {
                // 몬스터 조우 
                case 1:
                    break;
                // 휴식 공간
                case 2:
                    // 상태 휴식 공간으로 변경
                    stateMachine.ChangeState(stateMachine.RestRoomScene);
                    break;
                // 비밀 상점
                case 3:
                    break;
                // 의문의 상자
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
}
