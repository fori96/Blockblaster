using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BB
{
    class FileHandler
    {
        private static string JSON { get; set; }

        public FileHandler()
        {

        }

        public void JsonWritting(string playerName, int score, DateTime date)
        {     
            List<GameData> _data = new List<GameData>();

            if (!File.Exists("saves.json"))
            {                
                _data.Add(new GameData
                {
                    PlayerName = playerName,
                    Score = score,
                    Date = date
                });

                using (FileStream fs = File.Create("saves.json"))
                {
                    System.Text.Json.JsonSerializer.SerializeAsync(fs, _data);
                }
            }
            else
            {
                _data = JsonReading(); _data.Add(new GameData
                {
                    PlayerName = playerName,
                    Score = score,
                    Date = date
                });                

                using (FileStream fs = File.OpenWrite("saves.json"))
                {
                    System.Text.Json.JsonSerializer.SerializeAsync(fs, _data);
                }
            }
        }

        public List<GameData> JsonReading()
        {
            List<GameData> GameDataJson = new List<GameData>();

            try
            {   
                using (StreamReader sr = new StreamReader("saves.json"))
                {
                    JSON = sr.ReadToEnd();
                    GameDataJson = JsonConvert.DeserializeObject<List<GameData>>(JSON);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return GameDataJson;
        }

        public string ReadDescription()
        {
            string content;
            using (StreamReader sr = new StreamReader("readme.txt"))
            {
                content = sr.ReadToEnd();
            }

            return content;
        }

    }
}
