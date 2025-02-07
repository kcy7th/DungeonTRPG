using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class VillageScene : SceneState
    {
        string input = "";

        internal VillageScene(StateMachine stateMachine) : base(stateMachine)
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("마을");
            Console.ResetColor();
            Console.WriteLine("");

            // 선택창 보기
            ViewSelect();

            // 입력 
            input = Console.ReadLine();  

            // 씬 선택
            SelectScene(input);
        }

        // 씬 선택 함수
        private void SelectScene(string input)
        {
            switch (input)
            {
                // 던전 입구 
                case "1":
                    stateMachine.ChangeState(stateMachine.DungeonScene);
                    break;
                // 상점 
                case "2":
                    // 상태 상점으로 변경
                    stateMachine.ChangeState(stateMachine.ShopScene);
                    break;
                // 여관
                case "3":
                    // 상태 여관으로 변경
                    stateMachine.ChangeState(stateMachine.InnScene);
                    break;
                // 인벤토리
                case "4":
                    // 상태 인벤토리로 변경
                    stateMachine.ChangeState(stateMachine.InventoryScene);
                    break;
                // 상태 보기
                case "5":
                    // 상태 인벤토리로 변경
                    //stateMachine.ChangeState(stateMachine.StateScene);
                    break;
                // 게임 종료
                case "0":
                    //stateMachine.isGameOver = true;
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
            Console.WriteLine("===========================================================================");
            Console.WriteLine("||                         이동할 곳을 선택해 주세요                     ||");
            Console.WriteLine("|| 1. 던전 입구  2. 상점  3. 여관  4. 인벤토리 5. 상태 보기 0. 게임 종료 ||");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
