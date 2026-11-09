using UnityEngine;

namespace PGCompany.Clans.Network
{
    internal class 万丑丒七丏下世七丂
    {
        // Methods
        internal void 东丝丗丟丘丟丝丞丏(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世, System.Collections.Generic.List<ClanTankEquipInfo> 丝丝丗丒且丂丆万丗, int 丑专上世丁丁丌丂下)
        {
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_8;
            System.Collections.Generic.IEnumerable<TSource> val_9;
            var val_10;
            val_9 = 丝丝丗丒且丂丆万丗;
            if(且丟丅丄丒丑丂丁世 == null)
            {
                    return;
            }
            
            if(val_9 == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = null;
            val_8 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "clan_id", value:  且丟丅丄丒丑丂丁世.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "clan_tank", value:  System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<ClanTankEquipInfo, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_9, selector:  new System.Func<ClanTankEquipInfo, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Collections.Generic.Dictionary<System.String, System.Object> PGCompany.Clans.Network.万丑丒七丏下世七丂::丁丕上三丕丌丟丗丙(ClanTankEquipInfo 丅丟丄上丄丘万万丑)))));
            val_1.set_Item(key:  "power", value:  丑专上世丁丁丌丂下);
            val_10 = null;
            val_10 = null;
            val_9 = Rilisoft.WebSocket.业丛世业世不丄丐三.丏丅丐丂丝丈万下丆;
            int val_7 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  val_9, 一丐丗丁丞丆丅丟丄:  val_1);
        }
        private static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(ClanTankEquipInfo 丅丟丄上丄丘万万丑)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "p", value:  丅丟丄上丄丘万万丑.placeId);
            val_1.set_Item(key:  "in", value:  丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  丅丟丄上丄丘万万丑.itemSettingsId).Index);
            return val_1;
        }
        public 万丑丒七丏下世七丂()
        {
        
        }
    
    }

}
