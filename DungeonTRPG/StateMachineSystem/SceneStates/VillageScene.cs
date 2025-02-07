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
            ViewSelect();
            input = Console.ReadLine();  
            SelectScene(input);
        }

        private void SelectScene(string input)
        {
            switch (input)
            {
                case "1":
                    if (dungeonScene == null)
                    {
                        dungeonScene = new DungeonScene(stateMachine);
                    }
                    stateMachine.ChangeState(dungeonScene);
                    break;
                case "2":
                    if (shopScene == null)
                    {
                        shopScene = new ShopScene(stateMachine);
                    }
                    stateMachine.ChangeState(shopScene);
                    break;
                case "3":
                    if (innScene == null)
                    {
                        innScene = new INNScene(stateMachine);
                    }
                    stateMachine.ChangeState(innScene);
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        private void ViewSelect()
        {
            Console.WriteLine("1. 던전 입구");
            Console.WriteLine("2. 상점");
            Console.WriteLine("3. 여관");
        }
    }
}
