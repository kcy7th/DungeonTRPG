using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Player;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachine
{
    internal class StateMachine
    {
        private IState currentState;
        private Stack<IState> preStates;

        internal Player Player { get; }
        internal Enemy Enemy { get; set; }
        internal int ExploredCount { get; set; }
        internal int currentFloor { get; set; }

        internal StateMachine(Player player)
        {
            Player = player;
        }

        internal void ChangeState(IState state)
        {
            currentState?.Exit();

            if (currentState != null) preStates.Push(currentState);
            currentState = state;

            currentState?.Enter();
        }

        public void PreviousDataClear()
        {
            if (preStates.Count > 0)
            {
                IState state = preStates.Pop();
                preStates.Clear();
                preStates.Push(state);
            }
        }

        public void GoPreviousState()
        {
            currentState?.Exit();

            currentState = preStates.Pop();

            currentState?.Enter();
        }

        public void Update()
        {
            currentState.Update();
        }
    }
}
