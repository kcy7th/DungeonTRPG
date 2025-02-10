namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class DungeonScene : SceneState
    {
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
        }

        protected override void View()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("던전");
            Console.WriteLine("");

            ViewSelect();
        }

        // 던전 루프 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AdventureDungeon(RandomInt());
                    break;
                // 인벤토리 열어보기
                case "2":
                    stateMachine.ChangeState(stateMachine.InventoryScene);
                    break;
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
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
            int randInt = random.Next(0, 101);

            // 0~49 몬스터 조우
            if (randInt < 50)
            {
                randInt = 1;
            }
            // 50~69 휴식 공간
            else if (randInt < 70)
            {
                randInt = 2;
            }
            // 70~79 비밀 상점
            else if (randInt < 80)
            {
                randInt = 3;
            }
            // 80~100 의문의 상자
            else
            {
                randInt = 4;
            }

            return randInt;
        }

        private void AdventureDungeon(int randInt)
        {
            switch (randInt)
            {
                // 몬스터 조우 
                case 1:
                    // 상태 전투 씬으로 변경
                    stateMachine.ChangeState(stateMachine.CombatScene);
                    break;
                // 휴식 공간
                case 2:
                    // 상태 휴식 공간으로 변경
                    stateMachine.ChangeState(stateMachine.RestRoomScene);
                    break;
                // 비밀 상점
                case 3:
                    // 상태 비밀 상점으로 변경
                    stateMachine.ChangeState(stateMachine.SecretShopScene);
                    break;
                // 의문의 상자
                case 4:
                    // 상태 의문의 상자로 변경
                    stateMachine.ChangeState(stateMachine.SecretBoxScene);
                    break;
                default:
                    break;
            }
        }
    }
}
