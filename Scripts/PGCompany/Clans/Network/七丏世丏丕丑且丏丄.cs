using UnityEngine;

namespace PGCompany.Clans.Network
{
    internal class 七丏世丏丕丑且丏丄
    {
        // Methods
        internal 七丏世丏丕丑且丏丄()
        {
            null = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.七丐不丒丞丏业丒丅, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.Clans.Network.七丏世丏丕丑且丏丄::丛东丘不下万丘专不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        private void 丛东丘不下万丘专不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
        
        }
        internal void 丞丈上丙丞丗丑丝与(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世, System.Collections.Generic.List<FortFieldItemInfo> 丞不与丌丝业丏丈丂)
        {
            var val_8;
            if(且丟丅丄丒丑丂丁世 == null)
            {
                    return;
            }
            
            if(丞不与丌丝业丏丈丂 == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "clan_id", value:  且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "field_decor", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<FortFieldItemInfo, System.Int32>(source:  丞不与丌丝业丏丈丂, selector:  new System.Func<FortFieldItemInfo, System.Int32>(object:  0, method:  static System.Int32 PGCompany.Clans.Network.七丏世丏丕丑且丏丄::丈丈丒丈与丐丞三丆(FortFieldItemInfo 丄与万丘丏七专丅上)))));
            val_8 = null;
            val_8 = null;
            int val_7 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.七丐不丒丞丏业丒丅, 一丐丗丁丞丆丅丟丄:  val_1);
        }
        private static int 丈丈丒丈与丐丞三丆(FortFieldItemInfo 丄与万丘丏七专丅上)
        {
            PlaceableItemSettings val_1 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  丄与万丘丏七专丅上.name);
            if(val_1 != null)
            {
                    return val_1.Index;
            }
            
            return val_1.Index;
        }
    
    }

}
