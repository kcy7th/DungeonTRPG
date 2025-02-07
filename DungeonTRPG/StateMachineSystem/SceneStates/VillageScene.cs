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
        DungeonScene dungeonScene;
        INNScene innScene;
        ShopScene shopScene;
        InventoryScene inventoryScene;

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

            Console.WriteLine("마을");
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
                    // 던전에 들어간 적이 없다면
                    if (dungeonScene == null)
                    {
                        // 던전 씬 새롭게 생성
                        dungeonScene = new DungeonScene(stateMachine);
                    }
                    // 상태 던전으로 변경
                    stateMachine.ChangeState(dungeonScene);
                    break;
                // 상점 
                case "2":
                    // 상점에 들어간 적이 없다면
                    if (shopScene == null)
                    {
                        // 상점 씬 새롭게 생성
                        shopScene = new ShopScene(stateMachine);
                    }
                    // 상태 상점으로 변경
                    stateMachine.ChangeState(shopScene);
                    break;
                // 여관
                case "3":
                    // 여관에 들어간 적이 없다면
                    if (innScene == null)
                    {
                        // 여관 씬 새롭게 생성
                        innScene = new INNScene(stateMachine);
                    }
                    // 상태 여관으로 변경
                    stateMachine.ChangeState(innScene);
                    break;
                // 인벤토리
                case "4":
                    // 인벤토리에 들어간 적이 없다면
                    if (inventoryScene == null)
                    {
                        // 여관 씬 새롭게 생성
                        inventoryScene = new InventoryScene(stateMachine);
                    }
                    // 상태 인벤토리로 변경
                    stateMachine.ChangeState(inventoryScene);
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
            Console.WriteLine("1. 던전 입구");
            Console.WriteLine("2. 상점");
            Console.WriteLine("3. 여관");
            Console.WriteLine("4. 인벤토리");
            Console.WriteLine("");
        }
    }
}
