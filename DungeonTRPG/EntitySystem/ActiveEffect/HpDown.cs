﻿using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDown:IEffect
    {
        int amount;

        public HpDown(int amount)
        {
            this.amount = amount;
        }

        //시전자의 Hp가 amount만큼 줄어드는 효과
        public void UseEffect(Character caster, List<Character> enemys)
        {
            caster.Damaged(amount);
        }
    }
}
