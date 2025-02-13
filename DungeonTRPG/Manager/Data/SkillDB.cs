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
        private Dictionary<int, Skill> skills = new Dictionary<int, Skill>()
        {
            //0티어 플레이어 스킬 (상급), 9900~9999
            { 9900, new Skill("강한 회복", "체력을 40+ MATK(30%)회복한다.", new List<IEffect>(){new HpRecovery(40), new HpRecoverySpellMATK(0.3f) }, 100, false) },

            { 9901, new Skill("치명적인 타격", "고정 피해를 20+ ATK(100%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(10), new HpDamageATK(1f)}, 70, false) },
            { 9902, new Skill("광란", "피해를 25 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(50) }, 40, false) },
            { 9903, new Skill("승부수", "스스로에게 고정 피해를 50 입히고, 대상에게 30+ ATK(170%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(50), new HpDamageFixed(30), new HpDamageATK(1.7f) }, 50, false) },
            { 9904, new Skill("대지 강타", $"ATK(100%)만큼의 피해를 입히고, 75%의 확률로 기절을 1턴 부여한다.", new List<IEffect>(){new HpDamageATK(1f), new StateTarget(76,State.Stun,1) }, 80, false) },

            { 9930, new Skill("사건의 지평선", "피해를 100+ MATK(200%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(100), new HpDamageSpellATK(2f)}, 100, false) },
            { 9931, new Skill("신의 천벌", "피해를 50 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(50) }, 50, false) },
            { 9932, new Skill("신의 지팡이", "스스로에게 피해를 50 입히고, 대상에게 30+ MATK(250%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(50), new HpDamageFixed(30), new HpDamageATK(2.5f) }, 70, false) },
            { 9933, new Skill("천둥의 강타", $"MATK(200%)만큼의 피해를 입히고, 95%의 확률로 기절을 1턴 부여한다.", new List<IEffect>(){new HpDamageATK(2f), new StateTarget(96,State.Stun,1) }, 100, false) },

            { 9960, new Skill("세계수의 약속", "피해를 50+ ATK(150%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(50), new HpDamageSpellATK(1.5f)}, 80, false) },
            { 9961, new Skill("정령의 도움", "피해를 50 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(50) }, 40, false) },
            { 9962, new Skill("아르테미우스의 지원", "스스로에게 피해를 50 입히고, 대상에게 30+ MATK(200%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(50), new HpDamageFixed(30), new HpDamageATK(2f) }, 60, false) },
            { 9963, new Skill("소닉붐", $"MATK(150%)만큼의 피해를 입히고, 85%의 확률로 기절을 1턴 부여한다.", new List<IEffect>(){new HpDamageATK(1.5f), new StateTarget(86,State.Stun,1) }, 90, false) },

            //1티어 플레이어 스킬 (중급) 9800~9899
            { 9800, new Skill("회복", "체력을 20+ MATK(20%) 회복한다.", new List<IEffect>(){new HpRecovery(20), new HpRecoverySpellMATK(0.2f) }, 15, false) },

            { 9801, new Skill("맹렬한 타격", "고정 피해를 15 + ATK(75%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(15), new HpDamageATK(0.75f)}, 40, false) },
            { 9802, new Skill("격노", "피해를 12 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(12) }, 20, false) },
            { 9803, new Skill("맹렬한 돌격", "스스로에게 고정 피해를 25 입히고, 대상에게 20+ ATK(135%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(25), new HpDamageFixed(20), new HpDamageATK(1.35f) }, 30, false) },
            { 9804, new Skill("혼절의 일격", $"ATK(75%)만큼의 피해를 입히고, 65%의 확률로 기절을 1턴 부여한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StateTarget(66,State.Stun,1) }, 50, false) },

            { 9831, new Skill("파이어 랜스", "고정 피해를 15 + ATK(150%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(15), new HpDamageATK(1.5f)}, 70, false) },
            { 9832, new Skill("죽음의 교향곡", "피해를 12 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(12) }, 50, false) },
            { 9833, new Skill("익스플로전", "스스로에게 고정 피해를 25 입히고, 대상에게 20+ ATK(200%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(25), new HpDamageFixed(20), new HpDamageATK(2f) }, 60, false) },
            { 9834, new Skill("얼음 세계", $"ATK(150%)만큼의 피해를 입히고, 85%의 확률로 기절을 1턴 부여한다.", new List<IEffect>(){new HpDamageATK(1.5f), new StateTarget(86,State.Stun,1) }, 80, false) },

            { 9861, new Skill("신속의 화살", "고정 피해를 15 + ATK(100%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(15), new HpDamageATK(1f)}, 60, false) },
            { 9862, new Skill("피의 계약", "피해를 12 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(12) }, 40, false) },
            { 9863, new Skill("혼신의 공격", "스스로에게 고정 피해를 25 입히고, 대상에게 20+ ATK(150%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(25), new HpDamageFixed(20), new HpDamageATK(1.5f) }, 50, false) },
            { 9864, new Skill("정령의 가호", $"ATK(75%)만큼의 피해를 입히고, 75%의 확률로 기절을 1턴 부여한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StateTarget(76,State.Stun,1) }, 60, false) },
            
            //2티어 플레이어 스킬 (하급), 9700~9799
            { 9700, new Skill("약한 회복", "체력을 10+ MATK(10%) 회복한다.", new List<IEffect>(){new HpRecovery(10), new HpRecoverySpellMATK(0.1f) }, 10, false) },

            { 9701, new Skill("강한 타격", "고정 피해를 10 + ATK(50%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(10), new HpDamageATK(0.5f)}, 20, false) },
            { 9702, new Skill("분노", "피해를 5 입히며, 이 스킬로 적을 처치할때마다 스킬 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(5) }, 10, false) },
            { 9703, new Skill("무모한 돌격", "스스로에게 고정 피해를 10 입히고, 대상에게 15 + ATK(100%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(10), new HpDamageFixed(15), new HpDamageATK(1f) }, 15, false) },
            { 9704, new Skill("어지러운 일격", $"ATK(50%)만큼의 피해를 입히고, 50%의 확률로 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.5f), new StateTarget(51,State.Stun,1) }, 30, false) },

            { 9731, new Skill("윈드 에로우", "고정 피해를 10 + ATK(100%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(10), new HpDamageATK(1f)}, 50, false) },
            { 9732, new Skill("영혼 타격", "피해를 5 입히며, 이 스킬로 적을 처치할때마다 스킬 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(5) }, 40, false) },
            { 9733, new Skill("파이어 토네이도", "스스로에게 고정 피해를 10 입히고, 대상에게 15 + ATK(150%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(10), new HpDamageFixed(15), new HpDamageATK(1.5f) }, 45, false) },
            { 9734, new Skill("마력탄", $"ATK(50%)만큼의 피해를 입히고, 50%의 확률로 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.5f), new StateTarget(51,State.Stun,1) }, 60, false) },

            { 9761, new Skill("약점 간파", "고정 피해를 10 + ATK(75%)만큼 입힌다.", new List<IEffect>(){new HpTrueDamageFixed(10), new HpDamageATK(0.75f)}, 40, false) },
            { 9762, new Skill("관통의 화살", "피해를 5 입히며, 이 스킬로 적을 처치할때마다 스킬 데미지가 20% 오른다.", new List<IEffect>(){new Rampage(5) }, 30, false) },
            { 9763, new Skill("연사", "스스로에게 고정 피해를 10 입히고, 대상에게 15 + ATK(125%)만큼의 데미지를 입힌다.", new List<IEffect>(){new HpDownTrue(10), new HpDamageFixed(15), new HpDamageATK(1.25f) }, 35, false) },
            { 9764, new Skill("충격 화살", $"ATK(50%)만큼의 피해를 입히고, 50%의 확률로 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.5f), new StateTarget(51,State.Stun,1) }, 50, false) },

            //0티어 적 스킬 (강화), 9600~9699
            { 9600, new Skill("섬뜩한 몸통박치기", "피해를 10 + ATK(100%)만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(10), new HpDamageATK(1f) },0, false) },
            { 9601, new Skill("섬뜩한 도둑질", $"ATK(100%)만큼의 피해를 입히고, 40 골드를 갈취한다.", new List<IEffect>(){new HpDamageATK(1f), new StealGold(40) },2, false) },
            { 9602, new Skill("섬뜩한 베어내기", $"피해를 15 + ATK(125%)만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(15), new HpDamageATK(1.25f) },2, false) },
            { 9603, new Skill("섬뜩한 내려찍기", $"ATK(85%)만큼의 피해를 입히고, 70%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.85f), new StateTarget(71,State.Stun, 1) },5, false) },
            { 9604, new Skill("섬뜩한 독극물 투척", $"ATK(90%)만큼의 피해를 입히고, 70%의 확률로 3턴간 독을 부여한다.", new List<IEffect>(){new HpDamageATK(0.9f), new StateTarget(71,State.Poison,3) },5, false) },
            { 9605, new Skill("섬뜩한 야만적인 타격", $"ATK(90%)만큼의 피해를 입히고, 90%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.9f), new StateTarget(91,State.Stun, 1) }, 5, false) },
            { 9606, new Skill("섬뜩한 브레스", $"ATK(145%)만큼의 피해를 입히고, 90%의 확률로 3턴간 화상을 부여한다.", new List<IEffect>(){new HpDamageATK(1.45f), new StateTarget(91,State.Burn, 3) }, 5, false) },
            { 9607, new Skill("섬뜩한 독니", $"ATK(100%)만큼의 피해를 입히고, 80%의 확률로 3턴간 독을 부여한다.", new List<IEffect>(){new HpDamageATK(1f), new StateTarget(81,State.Poison, 3) }, 10, false) },
            { 9608, new Skill("맹독", $"100%의 확률로 5턴간 독을 부여한다.", new List<IEffect>(){ new StateTarget(101,State.Poison, 5) }, 5, false) },

            //1티어 적 스킬 (일반), 9500~9599
            { 9500, new Skill("몸통박치기", "피해를 5 + ATK(75%)만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(5), new HpDamageATK(0.75f) }, 0, false) },
            { 9501, new Skill("도둑질", $"ATK(75%)만큼의 피해를 입히고, 25 골드를 갈취한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StealGold(25) }, 2, false) },
            { 9502, new Skill("베어내기", $"피해를 10 + ATK(100%)만큼 입힌다.", new List<IEffect>(){new HpDamageFixed(10), new HpDamageATK(1f) }, 2, false) },
            { 9503, new Skill("내려찍기", $"ATK(65%)만큼의 피해를 입히고, 50%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.65f), new StateTarget(51,State.Stun, 1) }, 5, false) },
            { 9504, new Skill("독극물 투척", $"ATK(75%)만큼의 피해를 입히고, 50%의 확률로 3턴간 독을 부여한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StateTarget(51,State.Poison,3) }, 5, false) },
            { 9505, new Skill("야만적인 타격", $"ATK(75%)만큼의 피해를 입히고, 70%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){new HpDamageATK(0.75f), new StateTarget(71,State.Stun, 1) }, 5, false) },
            { 9506, new Skill("브레스", $"ATK(125%)만큼의 피해를 입히고, 70%의 확률로 3턴간 화상을 부여한다.", new List<IEffect>(){new HpDamageATK(1.25f), new StateTarget(71,State.Burn, 3) }, 5, false) },
            { 9507, new Skill("독니", $"ATK(50%)만큼의 피해를 입히고, 70%의 확률로 2턴간 독을 부여한다.", new List<IEffect>(){new HpDamageATK(0.5f), new StateTarget(71,State.Poison, 2) }, 5, false) },
            { 9508, new Skill("독", $"70%의 확률로 2턴간 독을 부여한다.", new List<IEffect>(){ new StateTarget(71,State.Poison, 2) }, 5, false) },
            { 9509, new Skill("물기", $"ATK(110%)만큼의 피해를 입힌다.", new List<IEffect>(){ new HpDamageATK(1.1f) }, 2, false) },
            { 9510, new Skill("휘두르기", $"10 + ATK(80%)만큼의 피해를 입히고, 20%의 확률로 1턴간 기절을 부여한다.", new List<IEffect>(){ new HpDamageFixed(10), new HpDamageATK(0.8f), new StateTarget(21,State.Stun, 1) }, 5, false) },

        };

        public Skill GetByKey(int key)
        {
            if (skills.ContainsKey(key))
            {
                return skills[key].Clone();
            }
            return null;
        }
    }
}
