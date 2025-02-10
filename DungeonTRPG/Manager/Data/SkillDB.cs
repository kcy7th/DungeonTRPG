using DungeonTRPG.EntitySystem.Skill;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Manager.Data
{
    internal class SkillDB
    {
        [JsonProperty]
        public Dictionary<int, Skill> Items { get; } = new Dictionary<int, Skill>()
        {
            { 9000, new Skill("회복", "체력을 10회복한다.", UseableIn.OnlyCombat) },
            { 9001, new Skill("회복", "체력을 10회복한다.", UseableIn.OnlyCombat) },
            { 9002, new Skill("회복", "체력을 10회복한다.", UseableIn.OnlyCombat) },
            { 9003, new Skill("회복", "체력을 10회복한다.", UseableIn.OnlyCombat) },
            { 9004, new Skill("회복", "체력을 10회복한다.", UseableIn.OnlyCombat) },
            { 9005, new Skill("회복", "체력을 10회복한다.", UseableIn.OnlyCombat) },
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
