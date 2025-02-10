using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal abstract class SceneState : IState
    {
        protected StateMachine stateMachine;

        internal SceneState(StateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public virtual void Enter()
        {

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
            Thread.Sleep(1000);
            Console.Clear();
        }

        protected abstract void View();
        protected abstract void Control();
    }
}
