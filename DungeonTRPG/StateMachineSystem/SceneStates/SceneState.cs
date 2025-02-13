using DungeonTRPG.EntitySystem;
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
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }

        public virtual void Exit()
        {

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
            Thread.Sleep(stateMachine.tick);
            Console.Clear();
        }

        protected virtual void Heal(Character target, int healHp, int healMp)
        {
            Console.WriteLine(
                $"Lv.{target.Stat.Lv} {target.Name} 이(가) 회복하였습니다. [회복 : Hp {target.Stat.Hp - healHp} -> {target.Stat.Hp} | Mp {target.Stat.Mp - healMp} -> {target.Stat.Mp}]");

            Thread.Sleep(stateMachine.tick);
        }

        protected (int Left, int Top) InputField(string message = "원하시는 행동을 입력해주세요.")
        {
            Console.Write($"{message} \n>> ");
            return Console.GetCursorPosition();
        }

        public void Rest(float persent)
        {
            Console.Clear();

            // 5초마다 회복
            Thread.Sleep(stateMachine.tick);

            int healHp = stateMachine.Player.Heal((int)(stateMachine.Player.Stat.MaxHp * persent));
            int healMp = stateMachine.Player.RecoverMana((int)(stateMachine.Player.Stat.MaxMp * persent));

            Heal(player, healHp, healMp);
        }

        protected abstract void View();
        protected abstract void Control();
    }
}
