namespace DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene
{
    internal class StateScene : SceneState
    {
        internal StateScene(StateMachine stateMachine) : base(stateMachine)
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

        // 씬 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                // 마을로 돌아가기 
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                // 다른 입력
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        protected override void View()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("상태 보기");
            Console.ResetColor();
            Console.WriteLine("내 정보를 표시합니다.");

            ViewStat();
            ViewSelect();
        }

        // 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.WriteLine(
                            $"\n" +
                            $"0. 마을로 돌아가기 \n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
        }

        private void ViewStat()
        {           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                $"\n" +
                $"{player.Name} ( Lv.{player.Stat.Lv} ) \n" +
                $"{player.job.ToString()} \n" +
                $"상 태 \t: {player.CharacterState.State} \n" +
                $"체 력 \t: {player.Stat.Hp} / {player.Stat.MaxHp} \n" +
                $"마 나 \t: {player.Stat.Mp} / {player.Stat.MaxMp} \n" +
                $"공격력 \t: {player.Stat.Atk} \n" +
                $"방어력 \t: {player.Stat.Def} \n" +
                $"Gold \t: {player.Gold}");
            Console.ResetColor();
        }

    }
}
