using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Interface;
using DungeonTRPG.Items;
using DungeonTRPG.Manager;
using DungeonTRPG.StateMachineSystem;
using DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene;
using DungeonTRPG.Utility.Enums;
using DungeonTRPG.EntitySystem;
using System.Runtime.InteropServices;

namespace DungeonTRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StateMachine machine = new StateMachine();

            machine.ChangeState(new CreatePlayerScene(machine));

            while (!machine.isGameOver)
            {
                machine.Update();
            }
        }
    }
}
