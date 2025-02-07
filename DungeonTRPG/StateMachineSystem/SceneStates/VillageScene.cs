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

            Console.WriteLine("Village");
            input = Console.ReadLine();  
            SelectScene(input);
        }

        private void SelectScene(string input)
        {
            switch (input)
            {
                case "던전":
                    if (dungeonScene == null)
                    {
                        dungeonScene = new DungeonScene(stateMachine);
                    }
                    stateMachine.ChangeState(dungeonScene);
                    break;
                case "여관":
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
    }
}
