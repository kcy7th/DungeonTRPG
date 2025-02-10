using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;

namespace DungeonTRPG.Manager.Data
{
    internal class SkillDB
    {
        [JsonProperty]
        public Dictionary<int, Skill> Items { get; } = new Dictionary<int, Skill>()
        {
            { 9000, new Skill("회복", "체력을 10 회복한다.", UseableIn.OnlyCombat, new List<IEffect>(){new HpRecovery(10) } ) },
            { 9001, new Skill("강한 타격", "피해를 10 + 공격력의 50%만큼 입힌다", UseableIn.OnlyCombat, new List<IEffect>(){new HpDownWithATK(10,0.5f) } ) },
            { 9002, new Skill("광란", "피해를 10 입히며, 처치할때마다 데미지가 20% 오른다.", UseableIn.OnlyCombat, new List<IEffect>(){new Rampage(10) } ) },
            { 9003, new Skill("무모한 돌격", "스스로에게 피해를 2 입히고, 대상에게 15+공격력의 100%만큼의 데미지를 입힌다.", UseableIn.OnlyCombat, new List<IEffect>(){new HpRecovery(15) } ) },
            { 9004, new Skill("어지러운 일격", $"공격력의 75%만큼의 피해를 입히며, 공격력에 비례해 일정 확률로 기절을 부여한다.", UseableIn.OnlyCombat, new List<IEffect>(){new HpRecovery(10) } ) },
        };

        public Skill GetByKey(int key)
        {
            if (Items.ContainsKey(key))
            {
                return Items[key];
            }
            return null;
        }
    }
}
