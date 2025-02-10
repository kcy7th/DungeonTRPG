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
        [JsonProperty] public ItemDB ItemDB { get; private set; }
        [JsonProperty] public SkillDB SkillDB { get; private set; }

        public GameData()
        {
            ItemDB = new ItemDB();
            SkillDB = new SkillDB();
        }
    }
}
