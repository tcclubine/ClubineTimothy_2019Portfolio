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

        public List<Monster> CreateMonsterList()
        {
            List<Monster> mList = new List<Monster>();
            string file = @"..\..\MonsterList.json";
            using (StreamReader inputStream = new StreamReader(file)) {
                string line = inputStream.ReadToEnd();

                mList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Monster>>(line);
                
            }

            return mList;
            
        }

        
    }
}
