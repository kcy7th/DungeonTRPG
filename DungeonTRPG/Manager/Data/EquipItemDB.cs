using DungeonTRPG.Items;
using DungeonTRPG.ItemsSystem;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;

namespace DungeonTRPG.Manager.Data
{
    internal class EquipItemDB
    {
        [JsonProperty]
        public Dictionary<int, EquipItem> Items { get; } = new Dictionary<int, EquipItem>()
        {
            { 2000, new EquipItem("낡은 나무 검", "사용감이 많아 얼마 못 쓸거 같다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 1, 0), EquipSlot.WEAPON) },
            { 2001, new EquipItem("나무 검", "가장 기본적인 연습용 검", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 2, 0), EquipSlot.WEAPON) },
            { 2002, new EquipItem("낡고 녹슨 철제 검", "낡고 관리가 안 되어있어 상태가 안 좋다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 3, 0), EquipSlot.WEAPON) },
            { 2003, new EquipItem("녹슨 철제 검", "관리가 안 되어있어 상태가 안 좋다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 5, 0), EquipSlot.WEAPON) },
            { 2004, new EquipItem("낡은 철제 검", "낡지만 관리가 잘 되어 있어 그럭저럭 쓸만하다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 7, 0), EquipSlot.WEAPON) },
            { 2005, new EquipItem("철제 검", "철로 만들어진 검", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 10, 0), EquipSlot.WEAPON) },
            { 2999, new EquipItem("엑스칼리버", "알 수 없는 재료로 만들어진 검. 사용자를 가리는 듯 하다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 99, 0), EquipSlot.WEAPON) },
            { 3000, new EquipItem("낡은 가죽 투구", "사용감이 많아 너덜너덜하다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 0, 1), EquipSlot.HELMET) },
            { 4000, new EquipItem("낡은 가죽 갑옷", "사용감이 많아 너덜너덜하다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 0, 2), EquipSlot.CHESTPLATE) },
            { 5000, new EquipItem("낡은 가죽 바지", "사용감이 많아 너덜너덜하다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 0, 2), EquipSlot.LEGGINGS) },
            { 6000, new EquipItem("낡은 가죽 신발", "사용감이 많아 너덜너덜하다.", new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 0, 1), EquipSlot.BOOTS) },
            { 7000, new EquipItem("낡은 나무 팔찌", "사용감이 많아 너덜너덜하다.", new List<Job>{ Job.Warrior }, new ExtraStat(2, 2, 0, 0), EquipSlot.ACCESSORY) },
        };

        public EquipItem GetByKey(int key)
        {
            if (Items.ContainsKey(key))
            {
                return Items[key];
            }
            return null;
        }
    }
}
