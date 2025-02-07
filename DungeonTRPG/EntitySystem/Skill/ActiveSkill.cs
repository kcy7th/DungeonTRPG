using DungeonTRPG.Entity;
using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.Skill
{
    internal class ActiveSkill: EffectSystem
    {
        private int Resource;
        public Job Job { get; }

        public ActiveSkill(string name, string description, Job job, List<IEffect> effects, int resource): base(name,description)
        {
            Job = job;
            ActiveEffects = effects;
            Resource = resource;
        }

        private List<IEffect> ActiveEffects = new List<IEffect>();


        public override void UseSkill(Character character)
        {
            //실패/성공 메서드를 UseSkill 메서드 안에 넣어놔야할지 모르겠어서 일단 조건문은 전부 주석처리했습니다.

            
            //if (Character.Stat.mp >= Resource) //캐릭터의 마나가 소모값보다 크거나 같다면
            //{
                Character.Stat.mp-=Resource; //캐릭터의 마나를 소모값만큼 감소
                //이후 스킬 시전
                foreach (var effect in ActiveEffects)
                {
                    effect.Invoke(character);
                }
                //이후 스킬 성공 메서드 출력
            //}
            //else
            //{
            //    //스킬 실패 메서드 출력
            //}
        }
    }
}
