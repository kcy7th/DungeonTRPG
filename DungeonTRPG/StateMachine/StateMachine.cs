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
        private Stack<IState> preState;

        internal Player Player { get; }
        internal Enemy Enemy { get; set; }
        internal int ExploredCount { get; set; }
    }
}
