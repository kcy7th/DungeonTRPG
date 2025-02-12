using DungeonTRPG.EntitySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class PlayerDefeatScene : CombatScene
    {
        public PlayerDefeatScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        protected override void View()
        {
            Console.Clear();

            int preExp = player.Stat.Exp;

            player.Stat.SetExp(0);

            Console.WriteLine("Defeat");
            Console.WriteLine();
            Console.WriteLine($"Exp : {preExp} -> {player.Stat.Exp}");
        }

        protected override void Control()
        {
            Thread.Sleep(stateMachine.tick);
            stateMachine.ChangeState(stateMachine.VillageScene);
        }
    }
}
