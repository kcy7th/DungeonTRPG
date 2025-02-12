using DungeonTRPG.Items;
using DungeonTRPG.Manager;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class SecretBoxScene : DungeonScene
    {
        bool isBoxOpen = false;
        int boxOpenCount = 0;
        Random random = new Random();
        int randInt = -1;

        internal SecretBoxScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        // 행동 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                // 던전으로 돌아가기 
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                // 의문의 상자 열어보기
                case "1":
                    isBoxOpen = true;
                    OpenSecretBox(CalProbability());

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
            SecretBox();
            ViewSelect();
        }

        // 의문의 상자 함수 
        private void SecretBox()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("의문의 상자");
            Console.ResetColor();
            Console.WriteLine("의문의 상자를 찾았습니다");
        }

        // 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.WriteLine(
                            $"\n" +
                            $"1. 열어보기 \n" +
                            $"0. 던전 돌아가기 \n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
        }

        // 의문의 상자 확률 계산 함수 
        private int CalProbability()
        {
            randInt = random.Next(0, 101);

            // 0~39 아무일도 없었다
            if (randInt < 40)
            {
                randInt = 1;
            }
            // 40~59 골드 획득 
            else if (randInt < 60)
            {
                randInt = 2;
            }
            // 60~79 포션 획득
            else if (randInt < 80)
            {
                randInt = 3;
            }
            // 80~95 사용 아이템 획득 
            else if (randInt < 95)
            {
                randInt = 4;
            }
            // 95~100 장비 획득
            else
            {
                randInt = 5;
            }
            return randInt;
        }

        // 의문의 상자 열기 함수 
        private void OpenSecretBox(int randInt)
        {
            Console.Clear();
            // 의문의 상자 열기 함수 로직 추가
            switch (randInt)
            {
                // 아무일도 없었다
                case 1:
                    Console.WriteLine("상자를 열어보았지만 아무것도 없었다.");
                    break;
                // 골드 획득
                case 2:
                    GetGold();
                    break;
                // 포션 획득
                case 3:
                    GetPotion();
                    break;
                // 사용 아이템 획득
                case 4:
                    GetActiveItem();
                    break;
                // 장비 획득
                case 5:
                    GetEquipItem();
                    break;
            }
            Thread.Sleep(1500);
        }

        private void GetGold()
        {
            Console.WriteLine("상자에는 골드가 들어있었다.");
            int gold = random.Next(1, 11) * 100;
            stateMachine.Player.GetGold(gold);
            Console.WriteLine($"{gold} Gold를 획득했습니다.");
        }

        private void GetPotion()
        {
            int potionNum = random.Next(0, 10) + 1000;
            ActiveItem potionItem = GameManager.Instance.DataManager.GameData.ActiveItemDB.GetByKey(potionNum);
            Console.WriteLine($"상자에는 {potionItem.GetName()}이 들어있었다.");
            if (stateMachine.Player.Inventory.AddItem(potionItem))
            {
                Console.WriteLine($"{potionItem.GetName()}을 획득했습니다.");
            }
            else
            {
                Console.WriteLine("인벤토리가 가득 찼습니다");
            }
        }

        private void GetActiveItem()
        {
            int potionNum = random.Next(10, 24) + 1000;
            ActiveItem potionItem = GameManager.Instance.DataManager.GameData.ActiveItemDB.GetByKey(potionNum);
            Console.WriteLine($"상자에는 {potionItem.GetName()}이(가) 들어있었다.");
            if (stateMachine.Player.Inventory.AddItem(potionItem))
            {
                Console.WriteLine($"{potionItem.GetName()}을(를) 획득했습니다.");
            }
            else
            {
                Console.WriteLine("인벤토리가 가득 찼습니다");
            }
        }

        private void GetEquipItem() 
        {
            int equipItemNum = random.Next(2, 8) * 1000 + random.Next(0, 2);
            EquipItem equipItem = GameManager.Instance.DataManager.GameData.EquipItemDB.GetByKey(equipItemNum);
            Console.WriteLine($"상자에는 {equipItem.GetName()}이(가) 들어있었다.");
            if (stateMachine.Player.Inventory.AddItem(equipItem))
            {
                Console.WriteLine($"{equipItem.GetName()}을(를) 획득했습니다.");
            }
            else
            {
                Console.WriteLine("인벤토리가 가득 찼습니다");
            }
        }
    }
}
