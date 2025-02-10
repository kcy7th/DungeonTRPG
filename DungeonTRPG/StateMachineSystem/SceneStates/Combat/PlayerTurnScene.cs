namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class PlayerTurnScene : CombatScene
    {
        public PlayerTurnScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            base.Exit();
        }

        protected override void View()
        {
            EnemyStat();

            Console.WriteLine(
                $"\n" +
                $"1. 공격 \n" +
                $"2. 스킬 \n" +
                $"3. 아이템 \n" +
                $"4. 방어 \n");
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":

                    break;
                // 아이템 열기
                case "3":
                    stateMachine.ChangeState(stateMachine.CombatItemScene);
                    break;
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                default:
                    break;
            }
        }
    }
}
