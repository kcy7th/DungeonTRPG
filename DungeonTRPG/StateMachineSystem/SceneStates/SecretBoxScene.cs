using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class SecretBoxScene : SceneState
    {
        // To Do List
        // 던전 클리어 후 모든 변수 초기화 필요 

        string input = "";

        bool isBoxOpen = false;
        int boxOpenCount = 0;
        Random random = new Random();
        int randInt = -1;

        internal SecretBoxScene(StateMachine stateMachine) : base(stateMachine)
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

            // 의문의 상자
            SecretBoxRoop();
        }

        // 의문의 상자 함수 
        private void SecretBoxRoop()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("의문의 상자");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("의문의 상자를 찾았습니다");
            Console.WriteLine("");
            Console.ResetColor();

            // 선택창 보기 
            ViewSelect();

            if (isBoxOpen && boxOpenCount == 0)
            {
                OpenSecretBox(CalProbability());
                boxOpenCount++;
            }
            else if (isBoxOpen && boxOpenCount > 0)
            {
                Console.WriteLine("이미 상자를 열어보았습니다.");
            }

            // 입력
            input = Console.ReadLine();

            // 행동 선택 
            SelectAction(input);
        }

        // 행동 선택 함수 
        private void SelectAction(string input)
        {
            switch (input)
            {
                // 던전으로 돌아가기 
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();

                    // 이전 데이터 지우기 
                    stateMachine.PreviousDataClear();
                    break;
                // 의문의 상자 열어보기
                case "1":
                    isBoxOpen = true;
                    break;
                // 다른 입력 
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        // 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("============================================");
            Console.WriteLine("||         행동을 선택해 주세요           ||");
            Console.WriteLine("||      1. 열어보기 0. 던전 돌아가기      ||");
            Console.WriteLine("============================================");
            Console.WriteLine("");
            Console.ResetColor();
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
            // 80~84 장비 획득
            else if (randInt < 85)
            {
                randInt = 4;
            }
            // 85~100 몬스터와 조우 
            else
            {
                randInt = 5;
            }
            return randInt;
        }

        // 의문의 상자 열기 함수 
        private void OpenSecretBox(int randInt)
        {
            // 의문의 상자 열기 함수 로직 추가
            switch (randInt)
            {
                // 아무일도 없었다
                case 1:
                    Console.WriteLine("상자를 열어보았지만 아무일도 없었다.");
                    break;
                // 골드 획득
                case 2:
                    int gold = random.Next(1, 11) * 100;
                    Console.WriteLine("상자에는 골드가 들어있었다.");
                    Console.WriteLine($"{gold} Gold를 획득했습니다.");
                    break;
                // 포션 획득
                case 3:
                    randInt = random.Next(1, 3);
                    switch (randInt)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                    }
                    Console.WriteLine("상자에는 포션이 들어있었다.");
                    break;
                // 장비 획득
                case 4:
                    Console.WriteLine("상자에는 장비가 들어있었다.");
                    break;
                // 몬스터와 조우
                case 5:
                    Console.WriteLine("상자에는 몬스터가 들어있었다.");
                    break;
            }
        }
    }
}
