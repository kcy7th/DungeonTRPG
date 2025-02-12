using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class DefDown: IEffect
    {

        private int amount;

        public DefDown(int amount)
        {
            this.amount = amount;
        }

        public void UseEffect(Character caster, List<Character> enemys)
        {
            Random random= new Random();
            int roll = (int)(random.Next(1, 10) + caster.Stat.Atk*0.1);

            if (caster.Stat.Lv < enemys[0].Stat.Lv) //플레이어 레벨이 적보다 낮다면
            {
                if (roll > 5) 
                {
                    enemys[0].Stat.SetDef(enemys[0].Stat.Def- amount); //적의 방어력 amount만큼 감소
                    //가능하다면 공격력 감소 State를 추가해서 일정 턴동안만 유지될 수 있게 하면 좋을 것 같습니다.
                }
                //else
                //{
                //    //필요하다면,실패 알림 출력하기
                //}
            }
            else
            {
                enemys[0].Stat.SetDef(enemys[0].Stat.Def - amount); //적의 방어력 amount만큼 감소
            }
        }
    }
}
