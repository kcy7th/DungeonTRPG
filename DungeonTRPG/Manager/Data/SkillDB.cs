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
            //0티어 플레이어 스킬 (상급), 9900~9999
            { 9900, new Skill("강한 회복", "체력을 40 회복한다.", new List<IEffect>(){new HpRecovery(40), }, 20 ) },
            { 9901, new Skill("치명적인 타격", "피해를 20 + 공격력의 100%만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(10), new HpDamageATK(1f)}, 20  ) },
            { 9902, new Skill("광란", "피해를 25 입히며, 이 스킬로 적을 처치할때마다 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(25) }, 20 ) },
            { 9903, new Skill("승부수", "스스로에게 피해를 6 입히고, 대상에게 30+공격력의 170%만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDown(6), new HpDamageFixed(30), new HpDamageATK(1.7f) }, 20 ) },
            { 9904, new Skill("천둥 강타", $"공격력의 100%만큼의 피해를 입히고, 95%의 확률로 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(1f), new StateTarget(96,State.Stun,1) }, 20 ) },

            //1티어 플레이어 스킬 (중급) 9800~9899
            { 9800, new Skill("회복", "체력을 20 회복한다.", new List<IEffect>(){new HpRecovery(20), }, 15 ) },
            { 9801, new Skill("맹렬한 타격", "피해를 15 + 공격력의 75%만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(10), new HpDamageATK(0.75f)}, 15  ) },
            { 9802, new Skill("격노", "피해를 12 입히며, 이 스킬로 적을 처치할때마다 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(10) }, 15 ) },
            { 9803, new Skill("맹렬한 돌격", "스스로에게 피해를 4 입히고, 대상에게 20+공격력의 135%만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDown(4), new HpDamageFixed(20), new HpDamageATK(1.35f) }, 15 ) },
            { 9804, new Skill("혼절의 일격", $"공격력의 75%만큼의 피해를 입히고, 75%의 확률로 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StateTarget(76,State.Stun,1) }, 15 ) },
            
            //2티어 플레이어 스킬 (하급), 9700~9799
            { 9700, new Skill("약한 회복", "체력을 10 회복한다.", new List<IEffect>(){new HpRecovery(10), }, 10 ) },
            { 9701, new Skill("강한 타격", "피해를 10 + 공격력의 50%만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(10), new HpDamageATK(0.5f)}, 10  ) },
            { 9702, new Skill("분노", "피해를 5 입히며, 이 스킬로 적을 처치할때마다 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(10) }, 10 ) },
            { 9703, new Skill("무모한 돌격", "스스로에게 피해를 2 입히고, 대상에게 15+공격력의 100%만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDown(2), new HpDamageFixed(15), new HpDamageATK(1f) }, 10 ) },
            { 9704, new Skill("어지러운 일격", $"공격력의 50%만큼의 피해를 입히고, 50%의 확률로 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.5f), new StateTarget(51,State.Stun,1) }, 10 ) },


            //0티어 적 스킬 (강화), 9600~9699
            { 9600, new Skill("섬뜩한 몸통박치기", "피해를 10 + 공격력의 100%만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(10), new HpDamageATK(1f) },0 ) },
            { 9601, new Skill("섬뜩한 도둑질", $"공격력의 100%만큼의 피해를 입히고, 40 골드를 갈취한다.", new List<IEffect>(){new HpDamageATK(1f), new StealGold(40) },2 ) },
            { 9602, new Skill("섬뜩한 베어내기", $"피해를 15 + 공격력의 125%만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(15), new HpDamageATK(1.25f) },2 ) },
            { 9603, new Skill("섬뜩한 내려찍기", $"공격력의 85%만큼의 피해를 입히고, 70%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.85f), new StateTarget(71,State.Stun, 1) },5 ) },
            { 9604, new Skill("섬뜩한 독극물 투척", $"공격력의 90%만큼의 피해를 입히고, 70%의 확률로 3턴간 독을 부여한다.", new List<IEffect>(){new HpDamageATK(0.9f), new StateTarget(71,State.Poison,3) },5 ) },
            { 9605, new Skill("섬뜩한 야만적인 타격", $"공격력의 90%만큼의 피해를 입히고, 90%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.9f), new StateTarget(91,State.Stun, 1) }, 5 ) },
            { 9606, new Skill("섬뜩한 브레스", $"공격력의 145%만큼의 피해를 입히고, 90%의 확률로 3턴간 화상을 부여한다.", new List<IEffect>(){new HpDamageATK(1.45f), new StateTarget(91,State.Burn, 3) }, 5 ) },
            //1티어 적 스킬 (일반), 9500~9599
            { 9500, new Skill("몸통박치기", "피해를 5 + 공격력의 75%만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(5), new HpDamageATK(0.75f) },0 ) },
            { 9501, new Skill("도둑질", $"공격력의 75%만큼의 피해를 입히고, 25 골드를 갈취한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StealGold(25) },2 ) },
            { 9502, new Skill("베어내기", $"피해를 10 + 공격력의 100%만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(10), new HpDamageATK(1f) },2 ) },
            { 9503, new Skill("내려찍기", $"공격력의 65%만큼의 피해를 입히고, 50%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.65f), new StateTarget(51,State.Stun, 1) },5 ) },
            { 9504, new Skill("독극물 투척", $"공격력의 75%만큼의 피해를 입히고, 50%의 확률로 3턴간 독을 부여한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StateTarget(51,State.Poison,3) },5 ) },
            { 9505, new Skill("야만적인 타격", $"공격력의 75%만큼의 피해를 입히고, 70%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StateTarget(71,State.Stun, 1) }, 5 ) },
            { 9506, new Skill("브레스", $"공격력의 125%만큼의 피해를 입히고, 70%의 확률로 3턴간 화상을 부여한다.", new List<IEffect>(){new HpDamageATK(1.25f), new StateTarget(71,State.Burn, 3) }, 5 ) },

        };

        public Skill GetByKey(int key)
        {
            if (Items.ContainsKey(key))
            {
                return Items[key].Clone();
            }
            return null;
        }
    }
}
