using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Manager.Data
{
    internal class GameData
    {
        [JsonProperty] public ActiveItemDB ActiveItemDB { get; private set; }
        [JsonProperty] public EquipItemDB EquipItemDB { get; private set; }
        [JsonProperty] public SkillDB SkillDB { get; private set; }

        public GameData()
        {
            ActiveItemDB = new ActiveItemDB();
            EquipItemDB = new EquipItemDB();
            SkillDB = new SkillDB();
        }
    }
}
