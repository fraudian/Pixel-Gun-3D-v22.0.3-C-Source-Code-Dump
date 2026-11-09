using UnityEngine;

namespace Rilisoft.WebSocket
{
    public static class 且丗丙丆丕东世与丈
    {
        // Fields
        public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Rilisoft.WebSocket.丌东丏丆丞丐丙丟上>> 丁下丗下丝丈丝丂丂;
        
        // Methods
        public static void 且丝丑丄丝不东丅丗(string 丝丏业丅丈东业丝丒, System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            string val_6;
            var val_7;
            System.Collections.Generic.List<Rilisoft.WebSocket.丌东丏丆丞丐丙丟上> val_2 = 0;
            val_6 = Rilisoft.WebSocket.且丗丙丆丕东世与丈.丑与丕丞七一三七世(丝丏业丅丈东业丝丒:  丝丏业丅丈东业丝丒);
            if((Rilisoft.WebSocket.且丗丙丆丕东世与丈.丁下丗下丝丈丝丂丂.TryGetValue(key:  val_6, value: out  val_2)) == false)
            {
                    return;
            }
            
            val_7 = 0;
            goto label_5;
            label_9:
            val_2.Item[0].Invoke(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗, 东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟, 丁不七丙下七丐与不:  丁不七丙下七丐与不);
            val_7 = 1;
            label_5:
            val_6 = val_2;
            if(val_7 < val_6.Count)
            {
                goto label_9;
            }
        
        }
        private static string 丑与丕丞七一三七世(string 丝丏业丅丈东业丝丒)
        {
            string val_2;
            var val_3;
            var val_4;
            val_2 = 丝丏业丅丈东业丝丒;
            val_3 = null;
            val_3 = null;
            if((Rilisoft.WebSocket.业丛世业世不丄丐三.丕专世世丐丌丁且三.Contains(item:  val_2)) == true)
            {
                    return val_2;
            }
            
            val_4 = null;
            val_4 = null;
            val_2 = Rilisoft.WebSocket.业丛世业世不丄丐三.丏不专丂丗丅丐丟丒;
            return val_2;
        }
        public static void 下丌业业丐丘丐丘三(string 丈丂丒丄丘丕丌上与, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 七丐丅专且专七三丆)
        {
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  丈丂丒丄丘丕丌上与, 七丐丅专且专七三丆:  七丐丅专且专七三丆);
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.丒丑三一丕下丌丟丗(丈丂丒丄丘丕丌上与:  丈丂丒丄丘丕丌上与, 七丐丅专且专七三丆:  七丐丅专且专七三丆, 与丞业丂丁丐丙丑丑:  true);
        }
        public static void 万不丒上丕丗丂丘丒(string 丈丂丒丄丘丕丌上与, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 七丐丅专且专七三丆)
        {
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.丒丑三一丕下丌丟丗(丈丂丒丄丘丕丌上与:  丈丂丒丄丘丕丌上与, 七丐丅专且专七三丆:  七丐丅专且专七三丆, 与丞业丂丁丐丙丑丑:  false);
        }
        private static void 丒丑三一丕下丌丟丗(string 丈丂丒丄丘丕丌上与, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 七丐丅专且专七三丆, bool 与丞业丂丁丐丙丑丑)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = null;
            val_6 = null;
            if((Rilisoft.WebSocket.且丗丙丆丕东世与丈.丁下丗下丝丈丝丂丂.ContainsKey(key:  丈丂丒丄丘丕丌上与)) == false)
            {
                goto label_4;
            }
            
            val_7 = null;
            if(与丞业丂丁丐丙丑丑 == false)
            {
                goto label_5;
            }
            
            goto label_13;
            label_4:
            if(与丞业丂丁丐丙丑丑 == false)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.丁下丗下丝丈丝丂丂.set_Item(key:  丈丂丒丄丘丕丌上与, value:  new System.Collections.Generic.List<Rilisoft.WebSocket.丌东丏丆丞丐丙丟上>());
            val_9 = null;
            val_9 = null;
            label_13:
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.丁下丗下丝丈丝丂丂.Item[丈丂丒丄丘丕丌上与].Add(item:  七丐丅专且专七三丆);
            return;
            label_5:
            val_10 = null;
            bool val_5 = Rilisoft.WebSocket.且丗丙丆丕东世与丈.丁下丗下丝丈丝丂丂.Item[丈丂丒丄丘丕丌上与].Remove(item:  七丐丅专且专七三丆);
        }
        private static 且丗丙丆丕东世与丈()
        {
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.丁下丗下丝丈丝丂丂 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Rilisoft.WebSocket.丌东丏丆丞丐丙丟上>>();
        }
    
    }

}
