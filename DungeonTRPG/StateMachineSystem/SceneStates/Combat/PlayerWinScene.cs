using DungeonTRPG.EntitySystem;
using DungeonTRPG.StateMachineSystem.SceneStates.Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class PlayerWinScene : CombatScene
    {
        public PlayerWinScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine, enemys)
        {
        }

        protected override void View()
        {
            int preLv = player.Stat.Lv;
            int preExp = player.Stat.Exp;

            player.Stat.AddExp(CalculateExp());

            Console.WriteLine("Victory");
            Console.WriteLine();
            Console.WriteLine($"던전에서 몬스터 {enemys.Count}마리를 잡았습니다.");
            Console.WriteLine();
            if (preLv < player.Stat.Lv) Console.WriteLine($"Lv.{preLv} -> {player.Stat.Lv}");
            Console.WriteLine($"Exp : {preExp} -> {player.Stat.Exp}");
        }

        private int CalculateExp()
        {
            int totalExp = 0;
            foreach (Enemy enemy in enemys)
            {
                totalExp += enemy.Stat.MaxExp;
            }
            return totalExp;
        }

        protected override void Control()
        {
            Thread.Sleep(5000);
            stateMachine.ChangeState(stateMachine.DungeonScene);
        }
    }
}
