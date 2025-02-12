using System.Collections.Generic;
using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.Interface;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;

namespace DungeonTRPG.Manager.Data
{
    internal class SecretItemDB
    {
        [JsonProperty]
        public Dictionary<int, SecretItem> Items { get; } = new Dictionary<int, SecretItem>()
        {
            // 희귀 소비 아이템 (ActiveItemDB 기반, 능력 강화 버전)
            { 9000, new SecretItem("신비한 물약", "HP +2000", 2500, new List<Job>{ Job.None }, new List<IEffect>{ new HpRecovery(2000) }, UseableIn.Both) },
            { 9001, new SecretItem("고대 마법서", "MP +1000", 3200, new List<Job>{ Job.None }, new List<IEffect>{ new MpRecovery(1000) }, UseableIn.Both) },
            { 9002, new SecretItem("불사의 물약", "HP FULL", 5000, new List<Job>{ Job.None }, new List<IEffect>{ new HpRecovery(99999) }, UseableIn.Both) },
            { 9003, new SecretItem("빛의 부적", "MP FULL", 4500, new List<Job>{ Job.None }, new List<IEffect>{ new MpRecovery(99999) }, UseableIn.Both) },
            { 9004, new SecretItem("강화 포션", "HP +1500", 2800, new List<Job>{ Job.None }, new List<IEffect>{ new HpRecovery(1500), new MpRecovery(1500) }, UseableIn.Both) },
            { 9005, new SecretItem("재생의 비약", "MP +2000", 6000, new List<Job>{ Job.None }, new List<IEffect>{ new MpRecovery(2000) }, UseableIn.Both) }
        };

        public SecretItem GetByKey(int key)
        {
            return Items.ContainsKey(key) ? Items[key] : null;
        }

        public List<SecretItem> GetAllItems()
        {
            return new List<SecretItem>(Items.Values);
        }
    }
}