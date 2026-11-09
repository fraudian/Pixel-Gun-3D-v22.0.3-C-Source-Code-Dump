using UnityEngine;

namespace Rilisoft.WebSocket
{
    internal class MatchmakingSocketManager : Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, object> 丈万丒丈丑一丁三东;
        private System.Collections.Generic.Dictionary<int, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上> 丁丟丐上丑下且丑丏;
        private System.Collections.Generic.Dictionary<int, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上> 丟专丈上与专丏丆丝;
        private Rilisoft.WebSocket.丛丗丟万丛一丝丅下 上丒丌丑丌专上丈丂;
        private int 丒上丟东下丝丂丗一;
        private UnityEngine.Coroutine 丐万与丁丄丙世丁丙;
        private string 丘丅且且丑丒丈丕专;
        private bool 上丅丝丄且东丆上丛;
        private static float 丟丛丞丄一丅不与七;
        private BestHTTP.SocketIO.SocketManager <丞东万万丐下业丆东>k__BackingField;
        private System.Action 丈且丞丑东不丝七万;
        
        // Properties
        private BestHTTP.SocketIO.SocketManager 丁且丈丄丙万七世万 { get; set; }
        internal bool 丐丁一丑业丁万下丄 { get; }
        internal bool 丙丒丐丐世丆一丙专 { get; }
        internal string 丌丆三万七且东三万 { get; set; }
        private BestHTTP.SocketIO.Socket 丕丘东丅丈与与万丘 { get; }
        internal bool 丌一丏东丕丅丈丛丘 { get; }
        internal bool 丘一丕丄专丟七丞且 { get; }
        internal bool 业上丛专丁东丗与丕 { get; }
        
        // Methods
        private BestHTTP.SocketIO.SocketManager 丏丗且丛专上丝三丙()
        {
            return (BestHTTP.SocketIO.SocketManager)this.<丞东万万丐下业丆东>k__BackingField;
        }
        private void 上一丆且丑丟丅丄丒(BestHTTP.SocketIO.SocketManager 丙业与丙丗丝不丈东)
        {
            this.<丞东万万丐下业丆东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 七不东丙丈丌下业丂()
        {
            if((this.<丞东万万丐下业丆东>k__BackingField) == null)
            {
                    return (bool)((this.<丞东万万丐下业丆东>k__BackingField.State) == 0) ? 1 : 0;
            }
            
            if((this.<丞东万万丐下业丆东>k__BackingField.State) == 1)
            {
                    return (bool)((this.<丞东万万丐下业丆东>k__BackingField.State) == 0) ? 1 : 0;
            }
            
            return (bool)((this.<丞东万万丐下业丆东>k__BackingField.State) == 0) ? 1 : 0;
        }
        internal bool 专东丏丙丛丟与丁丅()
        {
            if((this.<丞东万万丐下业丆东>k__BackingField) == null)
            {
                    return true;
            }
            
            return (bool)((this.<丞东万万丐下业丆东>k__BackingField.State) == 1) ? 1 : 0;
        }
        internal void 丟丟丆专丗一丐与丅(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丈且丞丑东不丝七万, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈且丞丑东不丝七万 != 1152921543668823856);
        
        }
        internal void 丑丑丟丅丐一专丏丏(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丈且丞丑东不丝七万, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈且丞丑东不丝七万 != 1152921543668960432);
        
        }
        internal string 七丆丘丘下丝丞丒丁()
        {
            return (string)this.丘丅且且丑丒丈丕专;
        }
        internal void 丑丛丁丁万丄七丟丑(string 丙业与丙丗丝不丈东)
        {
            if((丙业与丙丗丝不丈东.Equals(value:  this.丘丅且且丑丒丈丕专)) == true)
            {
                    return;
            }
            
            this.丘丅且且丑丒丈丕专 = 丙业与丙丗丝不丈东;
        }
        private BestHTTP.SocketIO.Socket 丄丆专丏且丁丘世一()
        {
            if((this.<丞东万万丐下业丆东>k__BackingField) == null)
            {
                    return (BestHTTP.SocketIO.Socket)this.<丞东万万丐下业丆东>k__BackingField;
            }
            
            return this.<丞东万万丐下业丆东>k__BackingField.Item["/sio"];
        }
        internal bool 丕且一与专丘丄上上()
        {
            if(this.丕上业丐七丂且不丁() == false)
            {
                    return false;
            }
            
            return 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世().万丕丌丞丏丞丑专一());
        }
        internal bool 丂七丘且丑不丁丌丈()
        {
            bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丘丅且且丑丒丈丕专);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        internal void 丗丟万丂丘丈专丄丂()
        {
            string val_3;
            if((this.<丞东万万丐下业丆东>k__BackingField) == null)
            {
                    return;
            }
            
            BestHTTP.SocketIO.HandshakeData val_1 = this.<丞东万万丐下业丆东>k__BackingField.Handshake;
            val_3 = 0;
            if(val_1 != null)
            {
                    val_3 = val_1.Sid;
            }
            
            this.与且东丄丘一下丄丒(丌东东丈丙丕万丛丈:  val_3);
            this.上丒丌丑丌专上丈丂.Dispose();
            this.<丞东万万丐下业丆东>k__BackingField.Close();
            this.<丞东万万丐下业丆东>k__BackingField = 0;
        }
        internal bool 丕上业丐七丂且不丁()
        {
            BestHTTP.SocketIO.SocketManager val_10 = this.<丞东万万丐下业丆东>k__BackingField;
            if(val_10 == null)
            {
                    return (bool)val_10;
            }
            
            if((val_10.State != 3) || (this.丄丆专丏且丁丘世一().IsOpen == false))
            {
                goto label_13;
            }
            
            if((this.<丞东万万丐下业丆东>k__BackingField.Transport) == null)
            {
                    return (bool)val_10;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((this.<丞东万万丐下业丆东>k__BackingField.Transport.Type) != 1)
            {
                goto label_13;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_19;
            label_13:
            val_10 = 0;
            return (bool)val_10;
            label_19:
            var val_11 = ((this.<丞东万万丐下业丆东>k__BackingField.Transport.State) == 2) ? 1 : 0;
            return (bool)val_10;
        }
        private System.Collections.IEnumerable 丛不下丈东与专三专()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerable)new MatchmakingSocketManager.丝一丟丘丁且丘丂丕(丗丏丅丕丆世丁专丟:  -2);
        }
        protected override void Awake()
        {
            this.Awake();
            this.丈万丒丈丑一丁三东 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            this.丁丟丐上丑下且丑丏 = new System.Collections.Generic.Dictionary<System.Int32, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上>();
            this.丟专丈上与专丏丆丝 = new System.Collections.Generic.Dictionary<System.Int32, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上>();
            this.上丒丌丑丌专上丈丂 = new Rilisoft.WebSocket.丛丗丟万丛一丝丅下();
        }
        private void 东丝七业丄丑丒世七()
        {
            var val_10;
            var val_23;
            if((this.<丞东万万丐下业丆东>k__BackingField) != null)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丘丅且且丑丒丈丕专)) == true)
            {
                    return;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            BestHTTP.HTTPManager.Logger.Level = 4;
            BestHTTP.SocketIO.SocketOptions val_4 = new BestHTTP.SocketIO.SocketOptions();
            if(val_4 != null)
            {
                    val_4.ConnectWith = 1;
                val_4.Reconnection = false;
            }
            else
            {
                    val_4.ConnectWith = 1;
                val_4.Reconnection = false;
            }
            
            val_4.AutoConnect = true;
            System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  2);
            if(val_4 != null)
            {
                    val_4.ReconnectionDelayMax = new System.TimeSpan() {_ticks = val_5._ticks};
            }
            else
            {
                    val_4.ReconnectionDelayMax = new System.TimeSpan() {_ticks = val_5._ticks};
            }
            
            val_4.DebugName = "MM";
            this.<丞东万万丐下业丆东>k__BackingField = new BestHTTP.SocketIO.SocketManager(uri:  new System.Uri(uriString:  this.丘丅且且丑丒丈丕专), options:  val_4);
            this.丈万丒丈丑一丁三东.Clear();
            this.丁丟丐上丑下且丑丏.Clear();
            this.丟专丈上与专丏丆丝.Clear();
            val_23 = null;
            val_23 = null;
            List.Enumerator<T> val_8 = Rilisoft.WebSocket.业丛世业世不丄丐三.丕专世世丐丌丁且三.GetEnumerator();
            label_26:
            if((408841392 & 1) == 0)
            {
                goto label_24;
            }
            
            new BestHTTP.SocketIO.Events.SocketIOCallback() = new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void Rilisoft.WebSocket.MatchmakingSocketManager::丘下丘不与丞丙万丟(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞));
            this.丄丆专丏且丁丘世一().On(eventName:  val_10.丐丏七丌丕丗业且上(), callback:  new BestHTTP.SocketIO.Events.SocketIOCallback());
            goto label_26;
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丄丆专丏且丁丘世一().On(type:  1, callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void Rilisoft.WebSocket.MatchmakingSocketManager::丞业丟不与丟丛丅业(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)));
            this.<丞东万万丐下业丆东>k__BackingField.Item["/"].On(type:  4, callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void Rilisoft.WebSocket.MatchmakingSocketManager::丗专丑业业丑丁丈七(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)));
            if(this.丐万与丁丄丙世丁丙 != null)
            {
                    return;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            this.丐万与丁丄丙世丁丙 = this.StartCoroutine(routine:  this.丛不下丈东与专三专().GetEnumerator());
        }
        internal void 丌万丗与七丄丕不丁()
        {
            this.东丝七业丄丑丒世七();
        }
        internal void 不丈一丅丆丌丞一丐(string 丈丂丒丄丘丕丌上与, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_2;
            一丐丗丁丞丆丅丟丄.set_Item(key:  "type", value:  丈丂丒丄丘丕丌上与);
            val_2 = null;
            val_2 = null;
            int val_1 = this.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.下丌业业丐丘丐丘三, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        internal void 不丈一丅丆丌丞一丐(string 丈丂丒丄丘丕丌上与)
        {
            this.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  丈丂丒丄丘丕丌上与, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>());
        }
        internal void 丆丞丅三丛丞东专丁(string 丈丂丒丄丘丕丌上与, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_2;
            一丐丗丁丞丆丅丟丄.set_Item(key:  "type", value:  丈丂丒丄丘丕丌上与);
            val_2 = null;
            val_2 = null;
            int val_1 = this.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.不与丞下业丑丒丙万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        internal void 丆丞丅三丛丞东专丁(string 丈丂丒丄丘丕丌上与)
        {
            this.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  丈丂丒丄丘丕丌上与, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>());
        }
        private bool 丝下丑丏下上丌丑三(string 丒丞专丄丝东丐丁万, object 一丐丗丁丞丆丅丟丄)
        {
            var val_10;
            if(this.丕上业丐七丂且不丁() != false)
            {
                    if(this.丕上业丐七丂且不丁() != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世().万丕丌丞丏丞丑专一())) != false)
            {
                    if((Rilisoft.WebSocket.业丛世业世不丄丐三.丙丒三丁丘丌下丟业(丝丏业丅丈东业丝丒:  丒丞专丄丝东丐丁万)) == false)
            {
                goto label_11;
            }
            
            }
            
            }
            
                object[] val_8 = new object[1];
                val_8[0] = 一丐丗丁丞丆丅丟丄;
                BestHTTP.SocketIO.Socket val_9 = this.丄丆专丏且丁丘世一().Emit(eventName:  丒丞专丄丝东丐丁万, args:  val_8);
                this.七丑上丆丞一万丛七(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
                val_10 = 1;
                return (bool)val_10;
            }
            
            label_11:
            val_10 = 0;
            return (bool)val_10;
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万)
        {
            return this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>(), 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 世丝且丘丏丕丟丈丟:  0, 不万丈丄与丛七丐业:  0);
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            return this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 世丝且丘丏丕丟丈丟:  0, 不万丈丄与丛七丐业:  0);
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 业丏丈世世世丞丒世)
        {
            return this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>(), 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 世丝且丘丏丕丟丈丟:  业丏丈世世世丞丒世, 不万丈丄与丛七丐业:  0);
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 业丏丈世世世丞丒世)
        {
            return this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 世丝且丘丏丕丟丈丟:  业丏丈世世世丞丒世, 不万丈丄与丛七丐业:  0);
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 业丏丈世世世丞丒世, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 不万丈丄与丛七丐业)
        {
            return this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 世丝且丘丏丕丟丈丟:  业丏丈世世世丞丒世, 不万丈丄与丛七丐业:  不万丈丄与丛七丐业);
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄, float 丙世丙丒丑三一丝万)
        {
            return this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  丙世丙丒丑三一丝万, 世丝且丘丏丕丟丈丟:  0, 不万丈丄与丛七丐业:  0);
        }
        private int 三丄与丐丛万丑业万(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄, float 丙世丙丒丑三一丝万, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 世丝且丘丏丕丟丈丟, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 不万丈丄与丛七丐业)
        {
            object val_5;
            object val_6;
            int val_7;
            val_5 = 一丐丗丁丞丆丅丟丄;
            val_5.set_Item(key:  "req_id", value:  this.丒上丟东下丝丂丗一);
            if((this.<丞东万万丐下业丆东>k__BackingField) == null)
            {
                goto label_3;
            }
            
            BestHTTP.SocketIO.HandshakeData val_1 = this.<丞东万万丐下业丆东>k__BackingField.Handshake;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_6 = val_1.Sid;
            if(val_5 != null)
            {
                goto label_6;
            }
            
            goto label_5;
            label_3:
            val_6 = 0;
            if(val_5 != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            val_5.set_Item(key:  "sid", value:  val_6);
            val_7 = this.丒上丟东下丝丂丗一;
            this.丒上丟东下丝丂丗一 = val_7 + 1;
            if((this.丝下丑丏下上丌丑三(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  val_5)) != false)
            {
                    val_5 = this.上丒丌丑丌专上丈丂;
                val_5.丟丘三丄丁丐专丙丁(丞丅上丏丂且下丅与:  val_7, 丒丘丏上丙丟丑丕丈:  丒丞专丄丝东丐丁万, 丙世丙丒丑三一丝万:  丙世丙丒丑三一丝万);
                if(世丝且丘丏丕丟丈丟 != null)
            {
                    this.丁丟丐上丑下且丑丏.set_Item(key:  val_7, value:  世丝且丘丏丕丟丈丟);
            }
            
                if(不万丈丄与丛七丐业 == null)
            {
                    return (int)val_7;
            }
            
                this.丟专丈上与专丏丆丝.set_Item(key:  val_7, value:  不万丈丄与丛七丐业);
                return (int)val_7;
            }
            
            if(不万丈丄与丛七丐业 != null)
            {
                    不万丈丄与丛七丐业.Invoke(丑与丂丌世丕丆一丗:  0, 东丞丒丙世丏三下丟:  val_5, 丁不七丙下七丐与不:  0);
            }
            
            val_7 = 0;
            return (int)val_7;
        }
        private void 丘下丘不与丞丙万丟(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)
        {
            var val_15;
            System.Object[] val_16 = 专丒丌丆下丐丞丟丞;
            this.丟丐万万丟万丟万丕(专丒丌丆下丐丞丟丞:  val_16);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世().万丕丌丞丏丞丑专一())) != false)
            {
                    if((Rilisoft.WebSocket.业丛世业世不丄丐三.丙丒三丁丘丌下丟业(丝丏业丅丈东业丝丒:  丙丁丌丛业不丄丝丈.EventName)) == false)
            {
                goto label_10;
            }
            
            }
            
            object val_15 = val_16[0];
            val_15 = 0;
            goto label_15;
            label_10:
            if(LogController.AnyLogEnabled == false)
            {
                    return;
            }
            
            string[] val_10 = new string[2];
            val_10[0] = (Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != true) ? "<color=red>Incoming event is skipped because client is not authorized</color> " : "Incoming event is skipped because client is not authorized ";
            val_10[1] = 丙丁丌丛业不丄丝丈.EventName;
            LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  this.<丞东万万丐下业丆东>k__BackingField, 丛专丛丕一与丅丝丁:  val_10);
            return;
            label_15:
            object val_12 = this.丏丝世万丄丆世丂上(丈三丟一万丕三三三:  null);
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.且丝丑丄丝不东丅丗(丝丏业丅丈东业丝丒:  丙丁丌丛业不丄丝丈.EventName, 丑与丂丌世丕丆一丗:  null, 东丞丒丙世丏三下丟:  0, 丁不七丙下七丐与不:  0);
            this.下世且丄且丗丆丑丟(丑与丂丌世丕丆一丗:  null, 东丞丒丙世丏三下丟:  0, 丁不七丙下七丐与不:  0);
        }
        private void 下世且丄且丗丆丑丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            object val_1 = 0;
            Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_4 = 0;
            if(东丞丒丙世丏三下丟 == null)
            {
                    return;
            }
            
            if((东丞丒丙世丏三下丟.TryGetValue(key:  "req_id", value: out  val_1)) == false)
            {
                    return;
            }
            
            int val_3 = System.Convert.ToInt32(value:  val_1);
            bool val_5 = this.丁丟丐上丑下且丑丏.TryGetValue(key:  val_3, value: out  val_4);
            this = this.丁丟丐上丑下且丑丏;
            bool val_6 = this.Remove(key:  val_3);
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4.Invoke(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗, 东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟, 丁不七丙下七丐与不:  0);
        }
        private void 与且东丄丘一下丄丒(string 丌东东丈丙丕万丛丈)
        {
            int val_4;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.丟专丈上与专丏丆丝.GetEnumerator();
            label_7:
            if((411314832 & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if(val_5._value._obj == 0)
            {
                goto label_7;
            }
            
            val_4 = val_5._value._obj.丙东专丂世丈丏丁丂();
            object val_8 = this.丏丝世万丄丆世丂上(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}:{1}", arg0:  val_4, arg1:  丌东东丈丙丕万丛丈));
            if(val_8 == null)
            {
                goto label_7;
            }
            
            val_5._value._obj.Invoke(丑与丂丌世丕丆一丗:  0, 东丞丒丙世丏三下丟:  val_8, 丁不七丙下七丐与不:  0);
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丟专丈上与专丏丆丝.Clear();
        }
        private void 七丑上丆丞一万丛七(object 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
        
        }
        private object 丏丝世万丄丆世丂上(object 丈三丟一万丕三三三)
        {
            var val_8;
            int val_2 = 0;
            val_8 = 0;
            return (object);
        }
        private object 丏丝世万丄丆世丂上(string 下上丐丆丝丟丝丒不)
        {
            object val_1 = 0;
            bool val_2 = this.丈万丒丈丑一丁三东.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_1);
            bool val_3 = this.丈万丒丈丑一丁三东.Remove(key:  下上丐丆丝丟丝丒不);
            return val_1;
        }
        private void 丟丐万万丟万丟万丕(object[] 专丒丌丆下丐丞丟丞)
        {
            System.Object[] val_5 = 专丒丌丆下丐丞丟丞;
            if(val_5 == null)
            {
                    return;
            }
            
            if(专丒丌丆下丐丞丟丞.Length == 0)
            {
                    return;
            }
            
            object val_4 = val_5[0];
            if(val_4 == null)
            {
                    return;
            }
            
            val_5 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_4) : 0;
            if((val_5.ContainsKey(key:  "req_id")) == false)
            {
                    return;
            }
            
            this.上丒丌丑丌专上丈丂.丘丁丂丘三丒丙丈丄(丞丅上丏丂且下丅与:  System.Convert.ToInt32(value:  val_5.Item["req_id"]));
        }
        private void Update()
        {
            if(((this.丕且一与专丘丄上上() != false) && (this.上丅丝丄且东丆上丛 != true)) && (this.丈且丞丑东不丝七万 != null))
            {
                    this.丈且丞丑东不丝七万.Invoke();
            }
            
            this.上丅丝丄且东丆上丛 = this.丕且一与专丘丄上上();
        }
        public MatchmakingSocketManager()
        {
            this.丒上丟东下丝丂丗一 = 1;
        }
        private static MatchmakingSocketManager()
        {
            Rilisoft.WebSocket.MatchmakingSocketManager.丟丛丞丄一丅不与七 = 1f;
        }
        private void 丞业丟不与丟丛丅业(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)
        {
            this.丗丟万丂丘丈专丄丂();
        }
        private void 丗专丑业业丑丁丈七(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)
        {
            this.丗丟万丂丘丈专丄丂();
        }
    
    }

}
