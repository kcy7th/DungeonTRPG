using DungeonTRPG.Entity;
using DungeonTRPG.Entity.Player;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Interface;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal abstract class SceneState : IState
    {
        protected StateMachine stateMachine;
        protected Player player;
        protected Random Random { get; } = new Random();

        internal SceneState(StateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
            player = stateMachine.Player;
        }

        public virtual void Enter()
        {
            player.OnHeal += Heal;
        }

        public virtual void Exit()
        {
            player.OnHeal -= Heal;
        }

        public virtual void Update()
        {
            Console.Clear();

            View();

            Control();
        }

        public void SendMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.Clear();
        }

        protected virtual void Heal(Character target, int heal)
        {
            Console.WriteLine("\n" +
                $"Lv.{target.Stat.Lv} {target.Name} 이(가) 회복하였습니다. [회복 : {heal}]");

            Thread.Sleep(1000);
        }

        protected abstract void View();
        protected abstract void Control();
    }
}
