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
            { 1000, new ActiveItem("체력 물약", "사용시 체력을 10 회복한다.", new List<Job>{ Job.None }, new List<IEffect>(){ new HpRecovery(10) }, UseableIn.Both) },
            { 1001, new ActiveItem("체력 물약", "사용시 체력을 50 회복한다.", new List < Job > { Job.None }, new List<IEffect>(){ new HpRecovery(50) }, UseableIn.Both) },
            { 1002, new ActiveItem("체력 물약", "사용시 체력을 100 회복한다.", new List < Job > { Job.None }, new List<IEffect>(){ new HpRecovery(100) }, UseableIn.Both) },
            { 1003, new ActiveItem("체력 물약", "사용시 체력을 200 회복한다.", new List < Job > { Job.None }, new List<IEffect>(){ new HpRecovery(200) }, UseableIn.Both) },
            { 1004, new ActiveItem("체력 물약", "사용시 체력을 전부 회복한다.", new List < Job > { Job.None }, new List<IEffect>(){ new HpRecovery(9999999) }, UseableIn.OnlyCombat) },
        };

        public ActiveItem GetByKey(int key)
        {
            if (Items.ContainsKey(key))
            {
                return Items[key];
            }
            return null;
        }
    }
}
