using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal abstract class Effect : IEffect
    {
        //set은 쓸 일 없으니까 생략
        protected int Amount { get; }
        public Effect(int _amount)
        {
            Amount= _amount;
        } 
        public virtual void Invoke(Character character)
        {
            Debug.Print("효과가 할당되지 않았음");
        }
    }
}
