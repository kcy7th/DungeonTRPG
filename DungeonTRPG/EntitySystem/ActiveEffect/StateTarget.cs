using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class StateTarget:IEffect
    {
        int probability;
        State state;
        int turn;
        public StateTarget(int probability, State state, int turn)
        {
            this.probability = probability;
            this.state = state;
            this.turn = turn;
        }


        //대상을 특정 확률(roll<probability)로 특정 상태이상(SetState(state))에 걸리게 하는 효과
        public void UseEffect(Character player, Character enemy)
        {
            Random chance = new Random();
            int roll = (int)(chance.Next(1, 101)); //1에서 100까지의 수를 생성

            if (roll < probability) // 생성된 난수가 확률보다 낮다면 성공
            {
                enemy.CharacterState.SetState(state); //enemy의 상태를 효과에 지정된 매개변수로 설정
                enemy.CharacterState.SetRemainingTurn(turn);
                //필요하다면, 성공 메세지 호출하기
            }
            else
            {
                //필요하다면, 실패 메세지 호출하기
            }
        }
    }
}
