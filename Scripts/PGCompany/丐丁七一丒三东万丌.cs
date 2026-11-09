using UnityEngine;

namespace PGCompany
{
    internal static class 丐丁七一丒三东万丌
    {
        // Methods
        internal static void 丈丄丝业七丆万不丟()
        {
            var val_11;
            var val_12;
            val_11 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_11.丁下丆三丏丌丕业丂() == false)
            {
                    return;
            }
            
            val_11 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_11.丗丕三下上丗专东业() == false)
            {
                    return;
            }
            
            val_11 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_11.东丛世丟七上丞丕丝() == false)
            {
                    return;
            }
            
            val_11 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_11.丆丅丟丂且丑一与丘() != false)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.世丆丕丁与丂丛丗丌);
            Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.世丆丕丁与丂丛丗丌);
        }
        internal static void 且一不专丆不专专丙()
        {
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_11;
            var val_12;
            val_11 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_11.丞丗丑丈一丅丗丌丟() == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = null;
            val_11 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_5 == null)
            {
                goto label_4;
            }
            
            if(val_11 != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            val_3.set_Item(key:  "clan_id", value:  val_5.业丐丐三丕一丗丛丁());
            val_3.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_12 = null;
            val_12 = null;
            int val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.万丕上丁专丅东丙丙, 一丐丗丁丞丆丅丟丄:  val_3);
            return;
            label_4:
            if(val_11 != null)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        internal static void 丌不丏东丅专不丒丅()
        {
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_11;
            var val_12;
            val_11 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_11.丞丗丑丈一丅丗丌丟() == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = null;
            val_11 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_5 == null)
            {
                goto label_4;
            }
            
            if(val_11 != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            val_3.set_Item(key:  "clan_id", value:  val_5.业丐丐三丕一丗丛丁());
            val_3.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_12 = null;
            val_12 = null;
            int val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丑下丄丝世丆丄上丛, 一丐丗丁丞丆丅丟丄:  val_3);
            return;
            label_4:
            if(val_11 != null)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        internal static void 丟上世丐丈三丂丑丘()
        {
            var val_11;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "war", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_5 == null)
            {
                goto label_4;
            }
            
            if(val_1 != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            val_1.set_Item(key:  "clan_id", value:  val_5.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_11 = null;
            val_11 = null;
            int val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丁上东丞丒丅丘丛丌, 一丐丗丁丞丆丅丟丄:  val_1);
            return;
            label_4:
            if(val_1 != null)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        internal static void 丁丆丏上丁丏万上丆(int 丟丟丄专上丟丁丐丝, int 丟上业丛丂丕丐丒世)
        {
            var val_11;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "event_id", value:  丟丟丄专上丟丁丐丝);
            丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_3 == null)
            {
                goto label_3;
            }
            
            if(val_1 != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            val_1.set_Item(key:  "clan_id", value:  val_3.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "room_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世丗世丕丌下与下丌());
            val_1.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_1.set_Item(key:  "wave", value:  丟上业丛丂丕丐丒世);
            val_11 = null;
            val_11 = null;
            int val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丅业丗专丘丘且丕丁, 一丐丗丁丞丆丅丟丄:  val_1);
            return;
            label_3:
            if(val_1 != null)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        internal static void 丙专丑丗三一七丞丞(int 丟丟丄专上丟丁丐丝)
        {
            var val_11;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "value", value:  1);
            val_1.set_Item(key:  "event_id", value:  丟丟丄专上丟丁丐丝);
            val_1.set_Item(key:  "room_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世丗世丕丌下与下丌());
            丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_5 == null)
            {
                goto label_6;
            }
            
            if(val_1 != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            val_1.set_Item(key:  "clan_id", value:  val_5.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_11 = null;
            val_11 = null;
            int val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丌丐丗丘万丂丁不丄, 一丐丗丁丞丆丅丟丄:  val_1);
            return;
            label_6:
            if(val_1 != null)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        internal static void 东丟专丞丘丈丛丘业(int 丟丟丄专上丟丁丐丝)
        {
            var val_11;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "event_id", value:  丟丟丄专上丟丁丐丝);
            val_1.set_Item(key:  "room_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世丗世丕丌下与下丌());
            丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_5 == null)
            {
                goto label_5;
            }
            
            if(val_1 != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            val_1.set_Item(key:  "clan_id", value:  val_5.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_11 = null;
            val_11 = null;
            int val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丕世与丌丅专丛与且, 一丐丗丁丞丆丅丟丄:  val_1);
            return;
            label_5:
            if(val_1 != null)
            {
                goto label_12;
            }
            
            goto label_13;
        }
        internal static void 丂与业专业丐万丗丂(int 丟丟丄专上丟丁丐丝)
        {
            var val_11;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "event_id", value:  丟丟丄专上丟丁丐丝);
            val_1.set_Item(key:  "room_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世丗世丕丌下与下丌());
            丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_5 == null)
            {
                goto label_5;
            }
            
            if(val_1 != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            val_1.set_Item(key:  "clan_id", value:  val_5.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_11 = null;
            val_11 = null;
            int val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丈下万丗丄三不丞不, 一丐丗丁丞丆丅丟丄:  val_1);
            return;
            label_5:
            if(val_1 != null)
            {
                goto label_12;
            }
            
            goto label_13;
        }
        internal static void 丐丒下丈丈三丟丕丙()
        {
            var val_9;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_3 == null)
            {
                goto label_2;
            }
            
            if(val_1 != null)
            {
                goto label_9;
            }
            
            label_10:
            label_9:
            val_1.set_Item(key:  "clan_id", value:  val_3.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "war_id", value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丕丅三上丏上丆丏());
            val_9 = null;
            val_9 = null;
            int val_8 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丏下万世丝丅丘三丂, 一丐丗丁丞丆丅丟丄:  val_1);
            return;
            label_2:
            if(val_1 != null)
            {
                goto label_9;
            }
            
            goto label_10;
        }
        internal static void 丟上丄丏丈丆上七丌(int 丌三丂丐丈丕且业七)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_3 == null)
            {
                goto label_2;
            }
            
            if(val_1 != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            val_1.set_Item(key:  "clan_id", value:  val_3.业丐丐三丕一丗丛丁());
            val_1.set_Item(key:  "war_id", value:  丌三丂丐丈丕且业七);
            val_7 = null;
            val_7 = null;
            int val_6 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丟上丄丏丈丆上七丌, 一丐丗丁丞丆丅丟丄:  val_1);
            return;
            label_2:
            if(val_1 != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        internal static void 下业专丂丗丁一丘丒()
        {
        
        }
    
    }

}
