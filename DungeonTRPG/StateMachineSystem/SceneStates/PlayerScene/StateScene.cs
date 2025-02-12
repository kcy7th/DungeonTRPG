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
        }

        private void ViewStat()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("상태 보기");
            Console.ResetColor();
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
            
            Console.Write($"Lv. ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(player.Stat.Lv);
            Console.ResetColor();

            Console.WriteLine($"{player.Name} ( {player.Job} )");

            Console.Write($"상 태 \t: ");
            Console.WriteLine(player.CharacterState.State);

            Console.Write($"체 력 \t: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(player.Stat.Hp);
            Console.ResetColor();
            Console.Write($" / ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(player.Stat.MaxHp);
            Console.ResetColor();
            if(player.Inventory.GetTotalEquipHp() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipHp()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"마 나 \t: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(player.Stat.Mp);
            Console.ResetColor();
            Console.Write($" / ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(player.Stat.MaxMp);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipMp() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipMp()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"공격력 \t: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(player.Stat.Atk);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipAtk() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipAtk()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"방어력 \t: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(player.Stat.Def);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipDef() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipDef()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"Gold \t: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(player.Gold);
            Console.ResetColor();
            Console.WriteLine(" G");

            Console.WriteLine();
            Console.WriteLine($"0. 돌아가기");
            Console.WriteLine();

            InputField();
        }

    }
}
