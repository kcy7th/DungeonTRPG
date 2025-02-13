using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Interface;
using DungeonTRPG.Items;
using DungeonTRPG.Manager;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene
{
    internal class CreatePlayerScene : IState
    {
        internal Job Job { get; private set; }

        private StateMachine stateMachine;

        public CreatePlayerScene(StateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public void Enter()
        {

        }

        public void Update()
        {
            Console.Clear();

            View();

            Control();
        }

        public void Exit()
        {
            
        }

        protected void View()
        {
            Console.WriteLine("사용하실 이름을 입력해주세요");
            string name = Console.ReadLine();

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

                Player player;

                switch (input)
                {
                    // 전사
                    case "1":
                        player = new Player(name, 500, new Stat(1, 100, 100, 20, 10, 0, 5), Job.Warrior);
                        Item item = GameManager.Instance.DataManager.GameData.ActiveItemDB.GetByKey(1020);
                        player.Inventory.AddItem(item);
                        player.Inventory.AddItem(item);
                        player.Inventory.AddItem(item);
                        player.Inventory.AddItem(item);
                        player.Inventory.AddItem(item);
                        player.Inventory.AddItem(item);
                        player.Inventory.AddItem(item);
                        item = GameManager.Instance.DataManager.GameData.EquipItemDB.GetByKey(7009);
                        player.Inventory.AddItem(item);
                        player.LearnSkill(9903);
                        stateMachine.Init(player);
                        stateMachine.ChangeState(stateMachine.VillageScene); // 직업 선택 후 마을로 이동
                        break;
                    // 법사
                    case "2":
                        player = new Player(name, 500, new Stat(1, 100, 60, 50, 2, 15, 3), Job.Mage);
                        stateMachine.Init(player);
                        stateMachine.ChangeState(stateMachine.VillageScene);
                        break;
                    // 궁수
                    case "3":
                        player = new Player(name, 500, new Stat(1, 100, 80, 30, 8, 2, 4), Job.Archer);
                        stateMachine.Init(player);
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

        protected void Control()
        {
            
        }

        protected (int Left, int Top) InputField(string message = "원하시는 행동을 입력해주세요.")
        {
            Console.Write($"{message} \n>> ");
            return Console.GetCursorPosition();
        }
    }
}
