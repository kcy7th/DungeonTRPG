using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class CombatSkillScene : CombatScene
    {
        public int selectSkill;

        public CombatSkillScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine, enemys)
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
            EnemyStats();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[스킬]");
            Console.ResetColor();

            bool hasFind = false;
            List<Skill> skills = inventory.Character.Skills;
            for (int i = 0; i < skills.Count; i++)
            {
                Console.WriteLine($"- {i+1} {skills[i].name} | {skills[i].description}");
                hasFind = true;
            }
            if (!hasFind) Console.WriteLine("보유하신 스킬이 없습니다. \n");

            Console.WriteLine();

            // 행동 선택
            Console.WriteLine("0. 나가기");

            Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();
                else if (0 < num && num <= inventory.Character.Skills.Count)
                {
                    stateMachine.preCombatScene = this;
                    stateMachine.ChangeState(new SelectEnemyScene(stateMachine, enemys));
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
