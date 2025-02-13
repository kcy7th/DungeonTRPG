using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.Interface;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;

namespace DungeonTRPG.Manager.Data
{
    internal class ActiveItemDB
    {
        [JsonProperty]
        public Dictionary<int, ActiveItem> Items { get; } = new Dictionary<int, ActiveItem>()
        {
            { 1000, new ActiveItem("휴대용 체력 물약", "사용시 체력을 10 회복한다.", 100, new List<Job>{ Job.None }, new List<IEffect>(){ new HpRecovery(10) }, UseableIn.Both, true) },
            { 1001, new ActiveItem("소형 체력 물약", "사용시 체력을 50 회복한다.", 200, new List<Job>{ Job.None }, new List<IEffect>(){ new HpRecovery(50) }, UseableIn.Both, true) },
            { 1002, new ActiveItem("중형 체력 물약", "사용시 체력을 100 회복한다.", 400, new List<Job>{ Job.None }, new List<IEffect>(){ new HpRecovery(100) }, UseableIn.Both, true) },
            { 1003, new ActiveItem("대형 체력 물약", "사용시 체력을 200 회복한다.", 800, new List<Job>{ Job.None }, new List<IEffect>(){ new HpRecovery(200) }, UseableIn.Both, true) },
            { 1004, new ActiveItem("파워엘릭서", "사용시 체력을 전부 회복한다.", 3000, new List<Job>{ Job.None }, new List<IEffect>(){ new HpRecovery(9999999) }, UseableIn.OnlyCombat, true) },
            { 1005, new ActiveItem("휴대용 마나 물약", "사용시 마나를 10 회복한다.", 100, new List<Job>{ Job.None }, new List<IEffect>(){ new MpRecovery(10) }, UseableIn.Both, true) },
            { 1006, new ActiveItem("소형 마나 물약", "사용시 마나를 50 회복한다.", 200, new List<Job>{ Job.None }, new List<IEffect>(){ new MpRecovery(50) }, UseableIn.Both, true) },
            { 1007, new ActiveItem("중형 마나 물약", "사용시 마나를 100 회복한다.", 400, new List<Job>{ Job.None }, new List<IEffect>(){ new MpRecovery(100) }, UseableIn.Both, true) },
            { 1008, new ActiveItem("대형 마나 물약", "사용시 마나를 200 회복한다.", 800, new List<Job>{ Job.None }, new List<IEffect>(){ new MpRecovery(200) }, UseableIn.Both, true) },
            { 1009, new ActiveItem("마나 엘릭서", "사용시 마나를 전부 회복한다.", 3000, new List<Job>{ Job.None }, new List<IEffect>(){ new MpRecovery(9999999) }, UseableIn.OnlyCombat, true) },
            { 1010, new ActiveItem("돌맹이", "적에게 던져 데미지를 입힌다.", 50, new List<Job>{ Job.None }, new List<IEffect>(){ new HpDamageFixed(10) }, UseableIn.OnlyCombat, false) },
            { 1011, new ActiveItem("단검", "적에게 던져 데미지를 입힌다.", 150, new List<Job>{ Job.None }, new List<IEffect>(){ new HpDamageFixed(30) }, UseableIn.OnlyCombat, false) },
            { 1012, new ActiveItem("화염병", "적에게 던져 주변 모두에게 데미지를 입힌다.", 500, new List<Job>{ Job.None }, new List<IEffect>(){ new RecklessCharge(50) }, UseableIn.OnlyCombat, false) },
            { 1013, new ActiveItem("폭탄", "폭발시켜 주변 모두에게 데미지를 입힌다.", 1000, new List<Job>{ Job.None }, new List<IEffect>(){ new RecklessCharge(100) }, UseableIn.OnlyCombat, false) },
            { 1017, new ActiveItem("고통의 물약 I", "적에게 던져 데미지를 입힌다.", 700, new List<Job>{ Job.Mage }, new List<IEffect>(){ new HpDamageATK(1.2f) }, UseableIn.OnlyCombat, false) },
            { 1018, new ActiveItem("고통의 물약 II", "적에게 던져 데미지를 입힌다.", 1200, new List<Job>{ Job.Mage }, new List<IEffect>(){ new HpDamageATK(1.4f) }, UseableIn.OnlyCombat, false) },
            { 1019, new ActiveItem("고통의 물약 III", "적에게 던져 데미지를 입힌다.", 1800, new List<Job>{ Job.Mage }, new List<IEffect>(){ new HpDamageATK(1.6f) }, UseableIn.OnlyCombat, false) },
            { 1020, new ActiveItem("불화살", "적에게 쏴 데미지를 입힌다.", 900, new List<Job>{ Job.None }, new List<IEffect>(){ new HpDamageATK(1.0f), new StateTarget(100, State.Sleep, 10) }, UseableIn.OnlyCombat, false) },
            { 1021, new ActiveItem("폭발형 화살", "적에게 쏴 데미지를 입힌다.", 2000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new HpDamageATK(2f) }, UseableIn.OnlyCombat, false) },
            { 1022, new ActiveItem("고대 화살", "적에게 쏴 데미지를 입힌다.", 2500, new List<Job>{ Job.Archer }, new List<IEffect>(){ new HpDamageATK(1.0f) }, UseableIn.OnlyCombat, false) },
            { 1023, new ActiveItem("번개의 돌", "번개를 불러와 적에게 데미지를 입히고 일정 확률로 움직이지 못하게 한다.", 1500, new List<Job>{ Job.None }, new List<IEffect>(){ new StunningBlow(30) }, UseableIn.OnlyCombat, false) },

            #region 스킬머신
            // 0티어
            { 1900, new ActiveItem("스킬 : 강한 회복", "체력을 40+ MATK(30%)만큼 회복한다.", 150000, new List<Job>{ Job.None }, new List<IEffect>(){ new LearnSkill(9900) }, UseableIn.OnlyCombat, true) },
            { 1901, new ActiveItem("스킬 : 치명적인 타격", "고정 피해를 20+ ATK(100%)만큼 입힌다.", 150000, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9901) }, UseableIn.OnlyCombat, true) },
            { 1902, new ActiveItem("스킬 : 광란", "피해를 25 입히며, 이 스킬로 적을 처치할때마다 데미지가 20% 오른다.", 150000, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9902) }, UseableIn.OnlyCombat, true) },
            { 1903, new ActiveItem("스킬 : 승부수", "스스로에게 고정 피해를 6 입히고, 대상에게 30+ ATK(170%)만큼의 데미지를 입힌다.", 150000, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9903) }, UseableIn.OnlyCombat, true) },
            { 1904, new ActiveItem("스킬 : 대지 강타", "ATK(100%)만큼의 피해를 입히고, 95%의 확률로 기절을 부여한다.", 150000, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9904) }, UseableIn.OnlyCombat, true) },

            { 1930, new ActiveItem("스킬 : 사건의 지평선", "피해를 100+ MATK(200%)만큼 입힌다.", 150000, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9930) }, UseableIn.OnlyCombat, true) },
            { 1931, new ActiveItem("스킬 : 신의 천벌", "피해를 50 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", 150000, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9931) }, UseableIn.OnlyCombat, true) },
            { 1932, new ActiveItem("스킬 : 신의 지팡이", "스스로에게 피해를 50 입히고, 대상에게 30+ MATK(250%)만큼의 데미지를 입힌다.", 150000, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9932) }, UseableIn.OnlyCombat, true) },
            { 1933, new ActiveItem("스킬 : 천둥의 강타", $"MATK(200%)만큼의 피해를 입히고, 95%의 확률로 기절을 1턴 부여한다.", 150000, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9933) }, UseableIn.OnlyCombat, true) },

            { 1960, new ActiveItem("스킬 : 세계수의 약속", "피해를 50+ ATK(150%)만큼 입힌다.", 150000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9960) }, UseableIn.OnlyCombat, true) },
            { 1961, new ActiveItem("스킬 : 정령의 도움", "피해를 50 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", 150000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9961) }, UseableIn.OnlyCombat, true) },
            { 1962, new ActiveItem("스킬 : 아르테미우스의 지원", "스스로에게 피해를 50 입히고, 대상에게 30+ MATK(200%)만큼의 데미지를 입힌다.", 150000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9962) }, UseableIn.OnlyCombat, true) },
            { 1963, new ActiveItem("스킬 : 소닉붐", $"MATK(150%)만큼의 피해를 입히고, 85%의 확률로 기절을 1턴 부여한다.", 150000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9963) }, UseableIn.OnlyCombat, true) },

            // 1티어
            { 1700, new ActiveItem("스킬 : 회복", "체력을 20+ MATK(20%) 회복한다.", 15000, new List<Job>{ Job.None }, new List<IEffect>(){ new LearnSkill(9800) }, UseableIn.OnlyCombat, true) },
            { 1701, new ActiveItem("스킬 : 맹렬한 타격", "고정 피해를 15 + ATK(75%)만큼 입힌다.", 15000, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9801) }, UseableIn.OnlyCombat, true) },
            { 1702, new ActiveItem("스킬 : 격노", "피해를 12 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", 15000, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9802) }, UseableIn.OnlyCombat, true) },
            { 1703, new ActiveItem("스킬 : 맹렬한 돌격", "스스로에게 고정 피해를 25 입히고, 대상에게 20+ ATK(135%)만큼의 데미지를 입힌다.", 1500, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9803) }, UseableIn.OnlyCombat, true) },
            { 1704, new ActiveItem("스킬 : 혼절의 일격", "ATK(75%)만큼의 피해를 입히고, 65%의 확률로 기절을 1턴 부여한다.", 15000, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9804) }, UseableIn.OnlyCombat, true) },

            { 1730, new ActiveItem("스킬 : 파이어 랜스", "고정 피해를 15 + ATK(150%)만큼 입힌다.", 15000, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9831) }, UseableIn.OnlyCombat, true) },
            { 1731, new ActiveItem("스킬 : 죽음의 교향곡", "피해를 12 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", 10500, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9832) }, UseableIn.OnlyCombat, true) },
            { 1732, new ActiveItem("스킬 : 익스플로전", "스스로에게 고정 피해를 25 입히고, 대상에게 20+ ATK(200%)만큼의 데미지를 입힌다.", 15000, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9833) }, UseableIn.OnlyCombat, true) },
            { 1733, new ActiveItem("스킬 : 얼음 세계", $"ATK(150%)만큼의 피해를 입히고, 85%의 확률로 기절을 1턴 부여한다.", 15000, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9834) }, UseableIn.OnlyCombat, true) },

            { 1760, new ActiveItem("스킬 : 신속의 화살", "고정 피해를 15 + ATK(100%)만큼 입힌다.", 10500, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9861) }, UseableIn.OnlyCombat, true) },
            { 1761, new ActiveItem("스킬 : 피의 계약", "피해를 12 입히며, 이 스킬로 적을 처치할때마다 스킬의 데미지가 20% 오른다.", 15000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9862) }, UseableIn.OnlyCombat, true) },
            { 1762, new ActiveItem("스킬 : 혼신의 공격", "스스로에게 고정 피해를 25 입히고, 대상에게 20+ ATK(150%)만큼의 데미지를 입힌다.", 15000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9863) }, UseableIn.OnlyCombat, true) },
            { 1763, new ActiveItem("스킬 : 정령의 가호", $"ATK(75%)만큼의 피해를 입히고, 75%의 확률로 기절을 1턴 부여한다.", 15000, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9864) }, UseableIn.OnlyCombat, true) },

            // 2티어
            { 1800, new ActiveItem("스킬 : 약한 회복", "체력을 10+ MATK(10%) 회복한다.", 1500, new List<Job>{ Job.None }, new List<IEffect>(){ new LearnSkill(9700) }, UseableIn.OnlyCombat, true) },
            { 1801, new ActiveItem("스킬 : 강한 타격", "고정 피해를 10 + ATK(50%)만큼 입힌다.", 1500, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9701) }, UseableIn.OnlyCombat, true) },
            { 1802, new ActiveItem("스킬 : 분노", "피해를 5 입히며, 이 스킬로 적을 처치할때마다 스킬 데미지가 20% 오른다.", 1500, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9702) }, UseableIn.OnlyCombat, true) },
            { 1803, new ActiveItem("스킬 : 무모한 돌격", "스스로에게 고정 피해를 10 입히고, 대상에게 15 + ATK(100%)만큼의 데미지를 입힌다.", 1500, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9703) }, UseableIn.OnlyCombat, true) },
            { 1804, new ActiveItem("스킬 : 어지러운 일격", "ATK(50%)만큼의 피해를 입히고, 50%의 확률로 기절을 부여한다.", 1500, new List<Job>{ Job.Warrior }, new List<IEffect>(){ new LearnSkill(9704) }, UseableIn.OnlyCombat, true) },

            { 1830, new ActiveItem("스킬 : 윈드 에로우", "고정 피해를 10 + ATK(100%)만큼 입힌다.", 1500, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9731) }, UseableIn.OnlyCombat, true) },
            { 1831, new ActiveItem("스킬 : 영혼 타격", "피해를 5 입히며, 이 스킬로 적을 처치할때마다 스킬 데미지가 20% 오른다.", 1500, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9732) }, UseableIn.OnlyCombat, true) },
            { 1832, new ActiveItem("스킬 : 파이어 토네이도", "스스로에게 고정 피해를 10 입히고, 대상에게 15 + ATK(150%)만큼의 데미지를 입힌다.", 1500, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9733) }, UseableIn.OnlyCombat, true) },
            { 1833, new ActiveItem("스킬 : 마력탄", $"ATK(50%)만큼의 피해를 입히고, 50%의 확률로 기절을 부여한다.", 1500, new List<Job>{ Job.Mage }, new List<IEffect>(){ new LearnSkill(9734) }, UseableIn.OnlyCombat, true) },

            { 1860, new ActiveItem("스킬 : 약점 간파", "고정 피해를 10 + ATK(75%)만큼 입힌다.", 1500, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9761) }, UseableIn.OnlyCombat, true) },
            { 1861, new ActiveItem("스킬 : 관통의 화살", "피해를 5 입히며, 이 스킬로 적을 처치할때마다 스킬 데미지가 20% 오른다.", 1500, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9762) }, UseableIn.OnlyCombat, true) },
            { 1862, new ActiveItem("스킬 : 연사", "스스로에게 고정 피해를 10 입히고, 대상에게 15 + ATK(125%)만큼의 데미지를 입힌다.", 1500, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9763) }, UseableIn.OnlyCombat, true) },
            { 1863, new ActiveItem("스킬 : 충격 화살", $"ATK(50%)만큼의 피해를 입히고, 50%의 확률로 기절을 부여한다.", 1500, new List<Job>{ Job.Archer }, new List<IEffect>(){ new LearnSkill(9764) }, UseableIn.OnlyCombat, true) },
            #endregion
        };

        public ActiveItem GetByKey(int key)
        {
            if (Items.ContainsKey(key))
            {
                return Items[key].Clone() as ActiveItem;
            }
            return null;
        }
    }
}