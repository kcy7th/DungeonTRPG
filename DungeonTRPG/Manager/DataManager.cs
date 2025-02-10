using DungeonTRPG.Manager.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonTRPG.Manager
{
    internal class DataManager
    {
        public GameData GameData { get; private set; }

        public DataManager()
        {
            GameData = new GameData();
        }

        public void Save()
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string jsonData = JsonConvert.SerializeObject(GameData, Formatting.Indented, settings);
            string path = Path.Combine(Environment.CurrentDirectory, "gameData.json");
            File.WriteAllText(path, jsonData);
        }

        public void Load()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "gameData.json");

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);
                GameData = JsonConvert.DeserializeObject<GameData>(jsonData, settings);
            }
            else
            {
                GameData = new GameData();
            }
        }
    }
}
