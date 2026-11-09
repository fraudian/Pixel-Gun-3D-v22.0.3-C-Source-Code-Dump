using UnityEngine;

namespace PGCompany.Clans.Network
{
    internal class 七一且丑上一丙一万
    {
        // Methods
        internal void 一丟丈丘丏丆东丏丙(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世, System.Collections.Generic.List<SquareFieldCellData> 七且丌丘业丒丟不丆, int 上丁丅东与与与丏丒)
        {
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_8;
            System.Collections.Generic.IEnumerable<TSource> val_9;
            var val_10;
            val_9 = 七且丌丘业丒丟不丆;
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
            val_1.set_Item(key:  "field_cells", value:  System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<SquareFieldCellData, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_9, selector:  new System.Func<SquareFieldCellData, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Collections.Generic.Dictionary<System.String, System.Object> PGCompany.Clans.Network.七一且丑上一丙一万::丁丕上三丕丌丟丗丙(SquareFieldCellData 丌丝万上丅丒一丈丘)))));
            val_1.set_Item(key:  "power", value:  上丁丅东与与与丏丒);
            val_10 = null;
            val_10 = null;
            val_9 = Rilisoft.WebSocket.业丛世业世不丄丐三.丆丕一万丙一一丅丅;
            int val_7 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  val_9, 一丐丗丁丞丆丅丟丄:  val_1);
        }
        private static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(SquareFieldCellData 丌丝万上丅丒一丈丘)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "x", value:  丌丝万上丅丒一丈丘.Position.ToString(format:  "F3"));
            val_1.Add(key:  "y", value:  丌丝万上丅丒一丈丘 + 20.ToString(format:  "F3"));
            val_1.Add(key:  "z", value:  丌丝万上丅丒一丈丘 + 24.ToString(format:  "F3"));
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_7.set_Item(key:  "p", value:  val_1);
            val_7.set_Item(key:  "s", value:  丌丝万上丅丒一丈丘.CellSize);
            val_7.set_Item(key:  "r", value:  丌丝万上丅丒一丈丘.Rotation);
            val_7.set_Item(key:  "i", value:  丌丝万上丅丒一丈丘.ItemSettings.Index);
            return val_7;
        }
        public 七一且丑上一丙一万()
        {
        
        }
    
    }

}
