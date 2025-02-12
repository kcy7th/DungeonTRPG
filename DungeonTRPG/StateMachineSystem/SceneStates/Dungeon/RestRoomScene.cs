namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class RestRoomScene : DungeonScene
    {
        internal RestRoomScene(StateMachine stateMachine) : base(stateMachine)
        {
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
            Console.WriteLine("휴식 공간을 찾았습니다.");
        }

        // 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.WriteLine(
                            $"\n" +
                            $"1. 휴식 취하기 \n" +
                            $"0. 던전 돌아가기 \n");         
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
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
                    Rest(0.5f);
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                // 다른 입력
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
