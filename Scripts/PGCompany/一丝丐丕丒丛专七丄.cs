using UnityEngine;

namespace PGCompany
{
    internal static class 一丝丐丕丒丛专七丄
    {
        // Fields
        private static 丞丂丘丒丟丞丑下丄 <上丝丅丑丐丕丅丁丝>k__BackingField;
        
        // Properties
        internal static 丞丂丘丒丟丞丑下丄 丏丞丌丝丗丌丅专丝 { get; set; }
        
        // Methods
        internal static 丞丂丘丒丟丞丑下丄 丌不与丂七不丆丏且()
        {
            return (丞丂丘丒丟丞丑下丄)null;
        }
        internal static void 且一与下丝丟丑丛丟(丞丂丘丒丟丞丑下丄 丙业与丙丗丝不丈东)
        {
            PGCompany.一丝丐丕丒丛专七丄.<上丝丅丑丐丕丅丁丝>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丗丑丅下丘世丆三丄(string 丟丙丈丄丈丈丙丆三)
        {
            var val_6;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
            if(val_2 != null)
            {
                    val_2.Add(item:  "fd");
            }
            else
            {
                    val_2.Add(item:  "fd");
            }
            
            val_2.Add(item:  "fl");
            if(val_2 != null)
            {
                    val_2.Add(item:  "tn");
            }
            else
            {
                    val_2.Add(item:  "tn");
            }
            
            val_2.Add(item:  "it");
            val_2.Add(item:  "bl");
            if(val_1 != null)
            {
                    val_1.set_Item(key:  "params", value:  val_2);
            }
            else
            {
                    val_1.set_Item(key:  "params", value:  val_2);
            }
            
            val_1.set_Item(key:  "clan_id", value:  丟丙丈丄丈丈丙丆三);
            val_6 = null;
            val_6 = null;
            int val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙不丈丁下东下丕丒, 一丐丗丁丞丆丅丟丄:  val_1, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Void PGCompany.一丝丐丕丒丛专七丄::丒万业丛丏东专世丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        private static void 丒万业丛丏东专世丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = 丑与丂丌世丕丆一丗;
            object val_1 = 0;
            if((东丞丒丙世丏三下丟.TryGetValue(key:  "clan_id", value: out  val_1)) == false)
            {
                    return;
            }
            
            丞丂丘丒丟丞丑下丄 val_3 = new 丞丂丘丒丟丞丑下丄();
            val_3.下东丄丄丟丞东丁丅(丙业与丙丗丝不丈东:  val_1);
            val_6 = new 业丐世丛丂七下一业(丈丈世丟丞丘一丆丅:  val_3).丑一丌下三丟丘专丅(万丌东丘丒且丁丆丑:  val_6 = 丑与丂丌世丕丆一丗);
            PGCompany.一丝丐丕丒丛专七丄.<上丝丅丑丐丕丅丁丝>k__BackingField = val_6;
        }
    
    }

}
