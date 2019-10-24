using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ClubineTimothy_MonsterSlayer
{
    class JSON
    {
        public JSON() { }

        public void Save() { }

        public void Load() { }

        public List<Monster> CreateMonsterList()
        {
            List<Monster> mList = new List<Monster>();
            string path = @"..\..\MonsterList.json";
            using (StreamReader inputStream = new StreamReader(path)) {
                string line = inputStream.ReadToEnd();

                mList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Monster>>(line);
            }

            return mList;
            
        }

        
    }
}
