using DungeonTRPG.Entity;
using DungeonTRPG.Entity.Player;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene
{
    internal class CreatePlayerScene : SceneState
    {
        private Player player; // Player 객체 참조

        internal Job Job { get; private set; }  

        public CreatePlayerScene(StateMachine stateMachine) : base(stateMachine)
        {
            player = stateMachine.Player; // 플레이어 클래스에 이름 관리 메서드에 입력 받은 이름에 대한 정보 전달
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();
        }

        protected override void View()
        {
            Console.WriteLine("사용하실 이름을 입력해주세요");
            string name = Console.ReadLine();

            player.SetName(name); // 플레이어 클래스에 이름 관리 메서드에 입력 받은 이름에 대한 정보 전달

            Console.Clear();

            if (!string.IsNullOrWhiteSpace(name))
            {                
                Console.WriteLine($"안녕하세요 '{name}'님 DungeonTRPG에 오신 것을 환영합니다.");
                Console.WriteLine("");
                Console.WriteLine("[직업 선택]");
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 법사");
                Console.WriteLine("3. 궁수");
                Console.WriteLine("");

                InputField("원하는 직업을 선택해주세요");

                string input = Console.ReadLine();
                switch (input)
                {
                    // 전사
                    case "1":
                        player.Job = Job.Warrior; // player 클래스에 유저가 선택한 직업 정보 전달
                        stateMachine.ChangeState(stateMachine.VillageScene); // 직업 선택 후 마을로 이동
                        break;
                    // 법사
                    case "2":
                        player.Job = Job.Mage;
                        stateMachine.ChangeState(stateMachine.VillageScene);
                        break;
                    // 궁수
                    case "3":
                        player.Job = Job.Archer;
                        stateMachine.ChangeState(stateMachine.VillageScene);
                        break;
                    // 게임 종료
                    case "0":
                        stateMachine.isGameOver = true;
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }
            else
            {
                Console.Clear();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("사용할 수 없는 이름입니다.\n");
                    View();
                }
            }
        }            

        protected override void Control()
        {
            
        }        
    }
}
