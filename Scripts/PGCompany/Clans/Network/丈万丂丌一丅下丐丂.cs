using UnityEngine;

namespace PGCompany.Clans.Network
{
    internal class 丈万丂丌一丅下丐丂
    {
        // Fields
        private static System.Action<PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗> 丆业丗丒丑东专丐丂;
        private static System.Action<int, PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗> 丕丅丑专不丐丗丛丏;
        private readonly System.Collections.Generic.HashSet<string> 丁业下丅万下丛丁东;
        
        // Methods
        internal static void 世丕丝三与丄丄丑三(System.Action<PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丆业丗丒丑东专丐丂, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丛丌丌丁丑丘丛丈业(System.Action<PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丆业丗丒丑东专丐丂, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丐丁七东丑专丌丏丆(System.Action<int, PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丕丅丑专不丐丗丛丏, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丕丅丑专不丐丗丛丏 != 1152921505671172104);
        
        }
        internal static void 丆丒丐丕丒下丙丐七(System.Action<int, PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丕丅丑专不丐丗丛丏, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丕丅丑专不丐丗丛丏 != 1152921505671172104);
        
        }
        internal 丈万丂丌一丅下丐丂()
        {
            var val_3;
            this.丁业下丅万下丛丁东 = new System.Collections.Generic.HashSet<System.String>();
            val_3 = null;
            val_3 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丅下丄丐丁七丕丑丌, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.Clans.Network.丈万丂丌一丅下丐丂::丒丄丆一丛丘不上丕(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        internal bool 且下丅丗丛丅东丝丆(string 丄丒且丙三丆丟与丏)
        {
            if(this.丁业下丅万下丛丁东 != null)
            {
                    return this.丁业下丅万下丛丁东.Contains(item:  丄丒且丙三丆丟与丏);
            }
            
            return this.丁业下丅万下丛丁东.Contains(item:  丄丒且丙三丆丟与丏);
        }
        internal bool 丝丈丁丟丞丆丈一丕()
        {
            return System.Linq.Enumerable.Any<System.String>(source:  this.丁业下丅万下丛丁东);
        }
        internal void 丟三三丆丒丈丒丑一(七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丙且万且上世丅丏丅, string 丄丒且丙三丆丟与丏, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            if(且丟丅丄丒丑丂丁世 != null)
            {
                    if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) != false)
            {
                    bool val_3 = this.丁业下丅万下丛丁东.Add(item:  丄丒且丙三丆丟与丏);
                string val_4 = 且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁();
                val_4.万丟下且丕丌丝三丙(丙且万且上世丅丏丅:  丙且万且上世丅丏丅, 丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏, 丄丒下业一不丈丝丘:  val_4);
                return;
            }
            
            }
            
            下丐丅丁丗丘丐且丛.且丝丑丄丝不东丅丗<System.Int32, 专世一东业丛丞且丗>(七丐丅专且专七三丆:  PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丕丅丑专不丐丗丛丏, 丞丅丟丌丌下丛丑丆:  1, 丞且且丝万丌丐上丝:  new 丈万丂丌一丅下丐丂.专世一东业丛丞且丗(万丘万丈与丆丗丂丄:  丄丒且丙三丆丟与丏, 世丕丌丌丒专丈七专:  丙且万且上世丅丏丅));
        }
        private void 万丟下且丕丌丝三丙(七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丙且万且上世丅丏丅, string 丄丒且丙三丆丟与丏, string 丄丒下业一不丈丝丘)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "clan_id", value:  丄丒下业一不丈丝丘);
            if(val_1 != null)
            {
                    val_1.set_Item(key:  "role_id", value:  丙且万且上世丅丏丅);
            }
            else
            {
                    val_1.set_Item(key:  "role_id", value:  丙且万且上世丅丏丅);
            }
            
            val_1.set_Item(key:  "player_id", value:  丄丒且丙三丆丟与丏);
            val_4 = null;
            val_4 = null;
            int val_3 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丅下丄丐丁七丕丑丌, 一丐丗丁丞丆丅丟丄:  val_1);
        }
        private void 丒丄丆一丛丘不上丕(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            object val_1 = 东丞丒丙世丏三下丟.Item["player_id"];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            string val_2 = (null == null) ? (val_1) : 0;
            if(东丞丒丙世丏三下丟 != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            int val_4 = System.Convert.ToInt32(value:  东丞丒丙世丏三下丟.Item["role_id"]);
            bool val_5 = this.丁业下丅万下丛丁东.Remove(item:  val_2);
            if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
            {
                    下丐丅丁丗丘丐且丛.且丝丑丄丝不东丅丗<System.Int32, 专世一东业丛丞且丗>(七丐丅专且专七三丆:  PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丕丅丑专不丐丗丛丏, 丞丅丟丌丌下丛丑丆:  System.Convert.ToInt32(value:  丑与丂丌世丕丆一丗.Item["err_code"]), 丞且且丝万丌丐上丝:  new 丈万丂丌一丅下丐丂.专世一东业丛丞且丗(万丘万丈与丆丗丂丄:  val_2, 世丕丌丌丒专丈七专:  val_4));
                return;
            }
            
            下丐丅丁丗丘丐且丛.且丝丑丄丝不东丅丗<专世一东业丛丞且丗>(七丐丅专且专七三丆:  PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丆业丗丒丑东专丐丂, 丙丒七丄上与丏丙丙:  new 丈万丂丌一丅下丐丂.专世一东业丛丞且丗(万丘万丈与丆丗丂丄:  val_2, 世丕丌丌丒专丈七专:  val_4));
            return;
            label_2:
            if(东丞丒丙世丏三下丟 != null)
            {
                goto label_12;
            }
            
            goto label_13;
        }
    
    }

}
