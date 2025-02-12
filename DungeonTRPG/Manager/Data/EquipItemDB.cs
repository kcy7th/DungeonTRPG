using DungeonTRPG.ItemsSystem;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;

namespace DungeonTRPG.Manager.Data
{
    internal class EquipItemDB
    {
        [JsonProperty]
        public Dictionary<int, EquipItem> Items { get; } = new Dictionary<int, EquipItem>()
        {
                // 전사
                { 1000, new EquipItem("강철의 검", "전사 전용 강력한 검", 1500, new List<Job>{ Job.Warrior }, new ExtraStat(15, 0, 0, 0, 5), EquipSlot.WEAPON) },
                { 1001, new EquipItem("튼튼한 갑옷", "전사의 방어력을 강화하는 갑옷", 2000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 50, 0, 20), EquipSlot.CHESTPLATE) },
                { 1002, new EquipItem("방패", "공격을 막아주는 방패", 1200, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 0, 0, 30), EquipSlot.ACCESSORY) },

                // 마법사
                { 2000, new EquipItem("마법 지팡이", "마법사의 마력을 증가시키는 지팡이", 1800, new List<Job>{ Job.Mage }, new ExtraStat(5, 20, 0, 0, 0), EquipSlot.WEAPON) },
                { 2001, new EquipItem("마법 로브", "마법 저항력이 높은 로브", 1600, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 30, 1, 10), EquipSlot.CHESTPLATE) },
                { 2002, new EquipItem("마나의 반지", "MP 회복 속도를 증가시키는 반지", 1400, new List<Job>{ Job.Mage }, new ExtraStat(0, 10, 0, 0, 5), EquipSlot.ACCESSORY) },

                // 궁수
                { 3000, new EquipItem("장궁", "궁수 전용 장거리 무기", 2000, new List<Job>{ Job.Archer }, new ExtraStat(12, 0, 0, 0, 3), EquipSlot.WEAPON) },
                { 3001, new EquipItem("가벼운 갑옷", "궁수가 빠르게 움직일 수 있도록 제작된 갑옷", 1700, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 25, 0, 15), EquipSlot.CHESTPLATE) },
                { 3002, new EquipItem("민첩의 장갑", "공격 속도를 증가시키는 장갑", 1300, new List<Job>{ Job.Archer }, new ExtraStat(3, 0, 0, 0, 5), EquipSlot.ACCESSORY) },

                // None
                { 4000, new EquipItem("여행자의 검", "초보자가 사용하기 좋은 기본 검", 1000, new List<Job>{ Job.None }, new ExtraStat(5, 0, 0, 0, 2), EquipSlot.WEAPON) },
                { 4001, new EquipItem("천 갑옷", "가벼운 보호구", 800, new List<Job>{ Job.None }, new ExtraStat(0, 0, 15, 0, 5), EquipSlot.CHESTPLATE) },
                { 4002, new EquipItem("방어의 부적", "착용하면 방어력이 소폭 상승", 700, new List<Job>{ Job.None }, new ExtraStat(0, 0, 0, 0, 8), EquipSlot.ACCESSORY) },
                { 4003, new EquipItem("탐험가의 장화", "장거리 여행에 적합한 가벼운 신발", 600, new List<Job>{ Job.None }, new ExtraStat(0, 0, 10, 0, 3), EquipSlot.ACCESSORY) },
                { 4004, new EquipItem("사냥꾼의 망토", "사냥꾼들이 애용하는 방어력 강화 망토", 900, new List<Job>{ Job.None }, new ExtraStat(0, 0, 20, 0, 6), EquipSlot.CHESTPLATE) },
                { 4005, new EquipItem("은빛 팔찌", "행운을 가져다준다고 전해지는 팔찌", 1100, new List<Job>{ Job.None }, new ExtraStat(2, 0, 0, 0, 5), EquipSlot.ACCESSORY) },
                { 4006, new EquipItem("모험가의 허리띠", "다양한 도구를 넣을 수 있는 허리띠", 950, new List<Job>{ Job.None }, new ExtraStat(0, 5, 0, 0, 5), EquipSlot.ACCESSORY) }
            };

        public EquipItem GetByKey(int key)
        {
            if (Items.ContainsKey(key))
            {
                return Items[key].Clone() as EquipItem;
            }
            return null;
        }
    };
}
