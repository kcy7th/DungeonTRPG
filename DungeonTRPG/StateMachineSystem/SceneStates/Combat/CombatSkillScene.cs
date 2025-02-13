using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonTRPG.Manager;
using DungeonTRPG.Manager.Data;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class CombatSkillScene : CombatScene
    {
        public int selectSkill;
        public int currentPage = 0;
        public int lastPage = 0;

        private List<Skill> skills = new List<Skill>();

        public CombatSkillScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            skills.Clear();

            for (int i = 0; i < player.Skills.Count; i++)
            {
                int key = player.Skills[i];
                skills.Add(GameManager.Instance.DataManager.GameData.SkillDB.GetByKey(key));
            }

            lastPage = skills.Count / 5;
            currentPage = 0;
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
            EnemyStats();

            int pageRange = (1 + currentPage) * 5;
            if (pageRange > skills.Count) pageRange = skills.Count;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[스킬]");
            Console.ResetColor();
            Console.WriteLine($" - {currentPage + 1} 페이지");

            bool hasFind = false;
            for (int i = currentPage * 5; i < pageRange; i++)
            {
                int index = i + (currentPage * 5);
                Console.WriteLine($"- {i + 1 - (currentPage * 5)} {skills[index].name} | {skills[index].description}");
                hasFind = true;
            }
            if (!hasFind) Console.WriteLine("보유하신 스킬이 없습니다.");

            Console.WriteLine();

            if (currentPage > 0) Console.WriteLine("6. 이전 페이지");
            if (currentPage < lastPage) Console.WriteLine("7. 다음 페이지");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();

            var cursurPos = InputField();

            PlayerStats();

            Console.SetCursorPosition(cursurPos.Left, cursurPos.Top);
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();
                else if (num == 6 && currentPage > 0) currentPage--;
                else if (num == 7 && currentPage < lastPage) currentPage++;
                else if (0 < num && num <= player.Skills.Count)
                {
                    if (player.Stat.Mp >= skills[num - 1].cost)
                    {
                        int key = player.Skills[num - 1];
                        Skill skill = GameManager.Instance.DataManager.GameData.SkillDB.GetByKey(key);
                        if (skill.isSplash)
                        {
                            List<Character> targets = new List<Character>(stateMachine.enemys);
                            int damage = skill.UseSkill(player, targets);
                            if (damage > 0) SplashDamage(targets, damage);
                        }
                        else
                        {
                            stateMachine.preCombatScene = this;
                            stateMachine.ChangeState(new SelectEnemyScene(stateMachine));
                        }
                    }
                    else SendMessage("마나가 부족합니다.");
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
