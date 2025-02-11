namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class RestRoomScene : DungeonScene
    {
        int restCount = 0;

        internal RestRoomScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            // 휴식 데이터 초기화
            restCount = 0;
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
            RestRoom();
            ViewSelect();
        }

        // 휴식 공간 함수
        private void RestRoom()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("휴식 공간");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("휴식 공간을 찾았습니다.");
            Console.ResetColor();
        }

        // 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================");
            Console.WriteLine("||     행동을 선택해 주세요    ||");
            Console.WriteLine("||   1. 휴식 0.던전 돌아가기   ||");
            Console.WriteLine("=================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 씬 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                // 이전으로 돌아가기
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                case "1":
                    // 휴식 취하기
                    restCount++;
                    stateMachine.InnScene.GetSomeRest();
                    break;
                // 다른 입력
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
