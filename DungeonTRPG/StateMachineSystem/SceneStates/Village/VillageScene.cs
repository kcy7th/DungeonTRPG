using DungeonTRPG.Manager;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Village
{
    internal class VillageScene : SceneState
    {
        internal VillageScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            stateMachine.PreStateDataClear();
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
                    stateMachine.ChangeState(stateMachine.StateScene);
                    break;
                // 저장
                case "6":
                    // 저장
                    GameManager.Instance.DataManager.Save();
                    break;
                // 불러오기
                case "7":
                    // 불러오기
                    GameManager.Instance.DataManager.Load();
                    break;
                // 게임 종료
                case "0":
                    stateMachine.isGameOver = true;
                    break;
                // 다른 입력
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        // 선택창 보기 함수
        protected override void View()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("마을");
            Console.ResetColor();
            Console.WriteLine("사람들이 머무르는 마을입니다. 어디로 갈지 선택하세요.");

            Console.WriteLine();
            Console.WriteLine("1. 던전");
            Console.Write("2. 상점 ");
            if(stateMachine.currentFloor % 10 == 0) Console.Write("*새로운 물건이 들어온거 같다.");
            Console.WriteLine();
            Console.WriteLine("3. 여관");
            Console.WriteLine("4. 인벤토리");
            Console.WriteLine("5. 상태 보기");
            Console.WriteLine("0. 게임 종료");
            Console.WriteLine();

            InputField();
        }
    }
}
