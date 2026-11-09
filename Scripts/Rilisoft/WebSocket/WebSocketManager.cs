using UnityEngine;

namespace Rilisoft.WebSocket
{
    internal class WebSocketManager : Singleton<Rilisoft.WebSocket.WebSocketManager>
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, object> 丈万丒丈丑一丁三东;
        private System.Collections.Generic.Dictionary<int, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上> 丟七东丌丞丝与丏丙;
        private Rilisoft.WebSocket.丛丗丟万丛一丝丅下 上丒丌丑丌专上丈丂;
        private System.Collections.Generic.Dictionary<int, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>> 丟丄且业丌丟丒丆丑;
        private int 丒上丟东下丝丂丗一;
        private UnityEngine.Coroutine 丐万与丁丄丙世丁丙;
        private string 丘丅且且丑丒丈丕专;
        private static float 丟丛丞丄一丅不与七;
        private BestHTTP.SocketIO.SocketManager <丗一丙丝不丟专丙丗>k__BackingField;
        
        // Properties
        internal BestHTTP.SocketIO.SocketManager 七丞且丁丌不且万且 { get; set; }
        internal bool 丐丁一丑业丁万下丄 { get; }
        internal bool 丙丒丐丐世丆一丙专 { get; }
        internal string 丌丆三万七且东三万 { get; set; }
        private BestHTTP.SocketIO.Socket 丕丘东丅丈与与万丘 { get; }
        internal bool 丌一丏东丕丅丈丛丘 { get; }
        internal bool 丘一丕丄专丟七丞且 { get; }
        internal bool 业上丛专丁东丗与丕 { get; }
        
        // Methods
        internal BestHTTP.SocketIO.SocketManager 丛且丈世下下丂丏七()
        {
            return (BestHTTP.SocketIO.SocketManager)this.<丗一丙丝不丟专丙丗>k__BackingField;
        }
        private void 世下丞丈丁世万丕丌(BestHTTP.SocketIO.SocketManager 丙业与丙丗丝不丈东)
        {
            this.<丗一丙丝不丟专丙丗>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 七不东丙丈丌下业丂()
        {
            if((this.<丗一丙丝不丟专丙丗>k__BackingField) == null)
            {
                    return (bool)((this.<丗一丙丝不丟专丙丗>k__BackingField.State) == 0) ? 1 : 0;
            }
            
            if((this.<丗一丙丝不丟专丙丗>k__BackingField.State) == 1)
            {
                    return (bool)((this.<丗一丙丝不丟专丙丗>k__BackingField.State) == 0) ? 1 : 0;
            }
            
            return (bool)((this.<丗一丙丝不丟专丙丗>k__BackingField.State) == 0) ? 1 : 0;
        }
        internal bool 专东丏丙丛丟与丁丅()
        {
            if((this.<丗一丙丝不丟专丙丗>k__BackingField) == null)
            {
                    return true;
            }
            
            return (bool)((this.<丗一丙丝不丟专丙丗>k__BackingField.State) == 1) ? 1 : 0;
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
            if((this.<丗一丙丝不丟专丙丗>k__BackingField) == null)
            {
                    return (BestHTTP.SocketIO.Socket)this.<丗一丙丝不丟专丙丗>k__BackingField;
            }
            
            return this.<丗一丙丝不丟专丙丗>k__BackingField.Item["/sio"];
        }
        internal bool 丕且一与专丘丄上上()
        {
            if(this.丕上业丐七丂且不丁() == false)
            {
                    return false;
            }
            
            业丞丝东丅丞丐丌专 val_2 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
            if(val_2 != null)
            {
                    return val_2.下不丙丌丙丞丞万上();
            }
            
            return val_2.下不丙丌丙丞丞万上();
        }
        internal bool 丂七丘且丑不丁丌丈()
        {
            bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丘丅且且丑丒丈丕专);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        internal void 丗丟万丂丘丈专丄丂()
        {
            var val_3;
            System.Action<System.Collections.Generic.KeyValuePair<System.Int32, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>>> val_5;
            Rilisoft.Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>.Instance.丗丟万丂丘丈专丄丂();
            if((this.<丗一丙丝不丟专丙丗>k__BackingField) == null)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            val_5 = WebSocketManager.<>c.<>9__25_0;
            if(val_5 == null)
            {
                    System.Action<System.Collections.Generic.KeyValuePair<System.Int32, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>>> val_2 = null;
                val_5 = val_2;
                val_2 = new System.Action<System.Collections.Generic.KeyValuePair<System.Int32, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>>>(object:  WebSocketManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WebSocketManager.<>c::丁且业丒丙丏丅七上(System.Collections.Generic.KeyValuePair<int, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>> 三丟东丕丄丄下下丑));
                WebSocketManager.<>c.<>9__25_0 = val_5;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<System.Collections.Generic.KeyValuePair<System.Int32, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>>>(丌丛丏业世丄丞三丌:  this.丟丄且业丌丟丒丆丑, 七丐丅专且专七三丆:  val_2);
            this.丟丄且业丌丟丒丆丑.Clear();
            if(this.上丒丌丑丌专上丈丂 != null)
            {
                    this.上丒丌丑丌专上丈丂.Dispose();
            }
            
            this.<丗一丙丝不丟专丙丗>k__BackingField.Close();
            this.<丗一丙丝不丟专丙丗>k__BackingField = 0;
            BestHTTP.HTTPManager.AbortAll(allowCallbacks:  false);
        }
        internal bool 丕上业丐七丂且不丁()
        {
            BestHTTP.SocketIO.SocketManager val_10 = this.<丗一丙丝不丟专丙丗>k__BackingField;
            if(val_10 == null)
            {
                    return (bool)val_10;
            }
            
            if((val_10.State != 3) || (this.丄丆专丏且丁丘世一().IsOpen == false))
            {
                goto label_13;
            }
            
            if((this.<丗一丙丝不丟专丙丗>k__BackingField.Transport) == null)
            {
                    return (bool)val_10;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((this.<丗一丙丝不丟专丙丗>k__BackingField.Transport.Type) != 1)
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
            var val_11 = ((this.<丗一丙丝不丟专丙丗>k__BackingField.Transport.State) == 2) ? 1 : 0;
            return (bool)val_10;
        }
        private System.Collections.IEnumerable 丛不下丈东与专三专()
        {
            .丗丏丅丕丆世丁专丟 = -2;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerable)new WebSocketManager.东丅万丐且万上世丙();
        }
        protected override void Awake()
        {
            this.Awake();
            this.丈万丒丈丑一丁三东 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            this.丟七东丌丞丝与丏丙 = new System.Collections.Generic.Dictionary<System.Int32, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上>();
            this.丟丄且业丌丟丒丆丑 = new System.Collections.Generic.Dictionary<System.Int32, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>>();
            if(this.上丒丌丑丌专上丈丂 != null)
            {
                    this.上丒丌丑丌专上丈丂.Dispose();
            }
            
            this.上丒丌丑丌专上丈丂 = new Rilisoft.WebSocket.丛丗丟万丛一丝丅下();
        }
        private void Start()
        {
            业丞丝东丅丞丐丌专.丑七不且上丗丁一世().专丂丙丘世万下三且();
        }
        private void 东丝七业丄丑丒世七()
        {
            var val_19;
            var val_37;
            if((this.<丗一丙丝不丟专丙丗>k__BackingField) != null)
            {
                    return;
            }
            
            var val_36 = 0;
            val_36 = val_36 + 1;
            BestHTTP.HTTPManager.Logger.Level = 4;
            BestHTTP.SocketIO.SocketOptions val_3 = new BestHTTP.SocketIO.SocketOptions();
            if(val_3 != null)
            {
                    val_3.ConnectWith = 1;
                val_3.Reconnection = false;
                val_3.ReconnectionAttempts = 3;
            }
            else
            {
                    val_3.ConnectWith = 1;
                val_3.Reconnection = false;
                val_3.ReconnectionAttempts = 3;
            }
            
            val_3.AutoConnect = true;
            System.TimeSpan val_4 = System.TimeSpan.FromSeconds(value:  2);
            val_3.ReconnectionDelayMax = new System.TimeSpan() {_ticks = val_4._ticks};
            PlatformSupport.Collections.ObjectModel.丗丛丆东丂丒上万下<System.String, System.String> val_5 = new PlatformSupport.Collections.ObjectModel.丗丛丆东丂丒上万下<System.String, System.String>();
            if(val_5 != null)
            {
                    val_5.Add(下上丐丆丝丟丝丒不:  "client_ver", 丙业与丙丗丝不丈东:  "v2");
            }
            else
            {
                    val_5.Add(下上丐丆丝丟丝丒不:  "client_ver", 丙业与丙丗丝不丈东:  "v2");
            }
            
            val_5.Add(下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东:  "1");
            if(val_3 != null)
            {
                    val_3.AdditionalQueryParams = val_5;
            }
            else
            {
                    val_3.AdditionalQueryParams = val_5;
            }
            
            val_3.DebugName = "Main";
            BestHTTP.SocketIO.SocketManager val_7 = new BestHTTP.SocketIO.SocketManager(uri:  new System.Uri(uriString:  this.丘丅且且丑丒丈丕专), options:  val_3);
            this.<丗一丙丝不丟专丙丗>k__BackingField = val_7;
            var val_37 = 0;
            val_37 = val_37 + 1;
            if(val_7.Socket.Manager.Transport.Type == 1)
            {
                    BestHTTP.SocketIO.Transports.ITransport val_13 = this.<丗一丙丝不丟专丙丗>k__BackingField.Transport;
                if((val_13 != null) && (null == null))
            {
                    val_13.Implementation.InternalRequest.CustomCertificateVerifyer = new Org.BouncyCastle.Crypto.Tls.PixelCertificateVerifyer();
            }
            
            }
            
            this.丈万丒丈丑一丁三东.Clear();
            this.丟七东丌丞丝与丏丙.Clear();
            val_37 = null;
            val_37 = null;
            List.Enumerator<T> val_17 = Rilisoft.WebSocket.业丛世业世不丄丐三.丕专世世丐丌丁且三.GetEnumerator();
            label_39:
            if((418498352 & 1) == 0)
            {
                goto label_37;
            }
            
            new BestHTTP.SocketIO.Events.SocketIOCallback() = new BestHTTP.SocketIO.Events.SocketIOCallback(object:  this, method:  System.Void Rilisoft.WebSocket.WebSocketManager::丘下丘不与丞丙万丟(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞));
            this.丄丆专丏且丁丘世一().On(eventName:  val_19.丐丏七丌丕丗业且上(), callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(), autoDecodePayload:  false);
            goto label_39;
            label_37:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丄丆专丏且丁丘世一().On(type:  1, callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世(), method:  System.Void 业丞丝东丅丞丐丌专::东丘丆丂丞丏丛丂一(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)));
            this.丄丆专丏且丁丘世一().On(eventName:  "reconnecting", callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世(), method:  System.Void 业丞丝东丅丞丐丌专::不一业丆丛丛丁丞丂(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)));
            this.<丗一丙丝不丟专丙丗>k__BackingField.Item["/"].On(type:  4, callback:  new BestHTTP.SocketIO.Events.SocketIOCallback(object:  业丞丝东丅丞丐丌专.丑七不且上丗丁一世(), method:  System.Void 业丞丝东丅丞丐丌专::丟三丕丆一万七丅丏(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)));
            if(this.丐万与丁丄丙世丁丙 != null)
            {
                    return;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            this.丐万与丁丄丙世丁丙 = this.StartCoroutine(routine:  this.丛不下丈东与专三专().GetEnumerator());
        }
        internal void 丌万丗与七丄丕不丁()
        {
            this.东丝七业丄丑丒世七();
        }
        internal System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> 不丈一丅丆丌丞一丐(string 丈丂丒丄丘丕丌上与, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_3;
            一丐丗丁丞丆丅丟丄.set_Item(key:  "type", value:  丈丂丒丄丘丕丌上与);
            val_3 = null;
            val_3 = null;
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_2 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.下丌业业丐丘丐丘三, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 业丏丈世世世丞丒世:  0, 丝丆丁丞丛三丁丑丙:  0);
            return (System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>)Rilisoft.WebSocket.业丛世业世不丄丐三.下丌业业丐丘丐丘三;
        }
        internal void 不丈一丅丆丌丞一丐(string 丈丂丒丄丘丕丌上与)
        {
            System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_2 = this.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  丈丂丒丄丘丕丌上与, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>());
        }
        internal System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> 丆丞丅三丛丞东专丁(string 丈丂丒丄丘丕丌上与, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_3;
            一丐丗丁丞丆丅丟丄.set_Item(key:  "type", value:  丈丂丒丄丘丕丌上与);
            val_3 = null;
            val_3 = null;
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_2 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.不与丞下业丑丒丙万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 业丏丈世世世丞丒世:  0, 丝丆丁丞丛三丁丑丙:  0);
            return (System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>)Rilisoft.WebSocket.业丛世业世不丄丐三.不与丞下业丑丒丙万;
        }
        internal void 丆丞丅三丛丞东专丁(string 丈丂丒丄丘丕丌上与)
        {
            System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_2 = this.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  丈丂丒丄丘丕丌上与, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>());
        }
        private bool 丝下丑丏下上丌丑三(string 丒丞专丄丝东丐丁万, object 一丐丗丁丞丆丅丟丄, byte[] 丝丆丁丞丛三丁丑丙)
        {
            var val_10;
            string val_11;
            System.Object[] val_12;
            var val_13;
            if(this.丕上业丐七丂且不丁() == false)
            {
                goto label_9;
            }
            
            if(this.丕上业丐七丂且不丁() != false)
            {
                    val_10 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
                if(val_10.下不丙丌丙丞丞万上() != true)
            {
                    if((Rilisoft.WebSocket.业丛世业世不丄丐三.丙丒三丁丘丌下丟业(丝丏业丅丈东业丝丒:  丒丞专丄丝东丐丁万)) == false)
            {
                goto label_9;
            }
            
            }
            
            }
            
            val_10 = this.丄丆专丏且丁丘世一();
            if(丝丆丁丞丛三丁丑丙 == null)
            {
                goto label_10;
            }
            
            object[] val_7 = new object[2];
            val_7[0] = 一丐丗丁丞丆丅丟丄;
            val_7[1] = 丝丆丁丞丛三丁丑丙;
            val_11 = 丒丞专丄丝东丐丁万;
            val_12 = val_7;
            goto label_18;
            label_9:
            val_13 = 0;
            return (bool)val_13;
            label_10:
            object[] val_8 = new object[1];
            val_8[0] = 一丐丗丁丞丆丅丟丄;
            val_11 = 丒丞专丄丝东丐丁万;
            val_12 = val_8;
            label_18:
            BestHTTP.SocketIO.Socket val_9 = val_10.Emit(eventName:  val_11, args:  val_8);
            this.七丑上丆丞一万丛七(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
            val_13 = 1;
            return (bool)val_13;
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万)
        {
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_3 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>(), 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 业丏丈世世世丞丒世:  0, 丝丆丁丞丛三丁丑丙:  0);
            return (int)val_3.Item2;
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_2 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 业丏丈世世世丞丒世:  0, 丝丆丁丞丛三丁丑丙:  0);
            return (int)val_2.Item2;
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 业丏丈世世世丞丒世)
        {
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_3 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>(), 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 丝丆丁丞丛三丁丑丙:  0);
            return (int)val_3.Item2;
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 业丏丈世世世丞丒世)
        {
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_2 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 丝丆丁丞丛三丁丑丙:  0);
            return (int)val_2.Item2;
        }
        internal int 丈丂丑丒三一下丏七(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄, float 丙世丙丒丑三一丝万)
        {
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_1 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  丙世丙丒丑三一丝万, 业丏丈世世世丞丒世:  0, 丝丆丁丞丛三丁丑丙:  0);
            return (int)val_1.Item2;
        }
        internal System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> 且丑丑丂东丈一上丏(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            System.ValueTuple<System.Int32, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_2 = this.三丄与丐丛万丑业万(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丙世丙丒丑三一丝万:  Rilisoft.WebSocket.丛丗丟万丛一丝丅下.丒丑丝丙丂上丆丙世(), 业丏丈世世世丞丒世:  0, 丝丆丁丞丛三丁丑丙:  0);
            return (System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>)丒丞专丄丝东丐丁万;
        }
        private System.ValueTuple<int, System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐>> 三丄与丐丛万丑业万(string 丒丞专丄丝东丐丁万, System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄, float 丙世丙丒丑三一丝万, Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 业丏丈世世世丞丒世, byte[] 丝丆丁丞丛三丁丑丙)
        {
            object val_8;
            System.Collections.Generic.Dictionary<System.Int32, System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>> val_9;
            object val_10;
            int val_11;
            var val_12;
            val_8 = 一丐丗丁丞丆丅丟丄;
            val_9 = this;
            val_8.set_Item(key:  "req_id", value:  this.丒上丟东下丝丂丗一);
            if((this.<丗一丙丝不丟专丙丗>k__BackingField) == null)
            {
                goto label_3;
            }
            
            BestHTTP.SocketIO.HandshakeData val_1 = this.<丗一丙丝不丟专丙丗>k__BackingField.Handshake;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_10 = val_1.Sid;
            if(val_8 != null)
            {
                goto label_6;
            }
            
            goto label_5;
            label_3:
            val_10 = 0;
            if(val_8 != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            val_8.set_Item(key:  "sid", value:  val_10);
            val_11 = this.丒上丟东下丝丂丗一;
            this.丒上丟东下丝丂丗一 = val_11 + 1;
            if((this.丝下丑丏下上丌丑三(丒丞专丄丝东丐丁万:  丒丞专丄丝东丐丁万, 一丐丗丁丞丆丅丟丄:  val_8, 丝丆丁丞丛三丁丑丙:  丝丆丁丞丛三丁丑丙)) != false)
            {
                    val_8 = this.上丒丌丑丌专上丈丂;
                val_8.丟丘三丄丁丐专丙丁(丞丅上丏丂且下丅与:  val_11, 丒丘丏上丙丟丑丕丈:  丒丞专丄丝东丐丁万, 丙世丙丒丑三一丝万:  丙世丙丒丑三一丝万);
                if(业丏丈世世世丞丒世 != null)
            {
                    this.丟七东丌丞丝与丏丙.set_Item(key:  val_11, value:  业丏丈世世世丞丒世);
            }
            
                val_12 = 1;
            }
            else
            {
                    val_12 = 0;
            }
            
            System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_5 = new System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐>();
            if(val_12 == 0)
            {
                goto label_12;
            }
            
            val_9 = this.丟丄且业丌丟丒丆丑;
            val_9.set_Item(key:  val_11, value:  val_5);
            if(val_5 != null)
            {
                goto label_17;
            }
            
            goto label_15;
            label_12:
            bool val_6 = val_5.TrySetCanceled();
            val_11 = 0;
            if(val_5 != null)
            {
                goto label_17;
            }
            
            label_15:
            label_17:
            System.Threading.Tasks.Task<TResult> val_7 = val_5.Task;
            return 0;
        }
        private void 丘下丘不与丞丙万丟(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)
        {
            var val_23;
            var val_24;
            string val_25;
            if(丙丁丌丛业不丄丝丈.AttachmentCount >= 1)
            {
                    bool val_2 = 丙丁丌丛业不丄丝丈.ReconstructAttachmentAsIndex();
            }
            
            System.Object[] val_24 = 丙丁丌丛业不丄丝丈.Decode(encoder:  this.丄丆专丏且丁丘世一().Manager.Encoder);
            this.丟丐万万丟万丟万丕(专丒丌丆下丐丞丟丞:  val_24);
            if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() != true)
            {
                    if((Rilisoft.WebSocket.业丛世业世不丄丐三.丙丒三丁丘丌下丟业(丝丏业丅丈东业丝丒:  丙丁丌丛业不丄丝丈.EventName)) == false)
            {
                goto label_14;
            }
            
            }
            
            object val_23 = val_24[0];
            val_23 = 0;
            goto label_19;
            label_14:
            if(LogController.AnyLogEnabled == false)
            {
                    return;
            }
            
            string[] val_13 = new string[2];
            val_13[0] = "<color=red>Incoming event is skipped because client is not authorized</color>";
            val_13[1] = 丙丁丌丛业不丄丝丈.EventName;
            LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  this.<丗一丙丝不丟专丙丗>k__BackingField, 丛专丛丕一与丅丝丁:  val_13);
            return;
            label_19:
            object val_15 = this.丏丝世万丄丆世丂上(丈三丟一万丕三三三:  null);
            val_24 = 0;
            if(丙丁丌丛业不丄丝丈 != null)
            {
                    val_25 = 丙丁丌丛业不丄丝丈.EventName;
            }
            else
            {
                    val_25 = 0.EventName;
            }
            
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.且丝丑丄丝不东丅丗(丝丏业丅丈东业丝丒:  val_25, 丑与丂丌世丕丆一丗:  null, 东丞丒丙世丏三下丟:  null, 丁不七丙下七丐与不:  丙丁丌丛业不丄丝丈.Attachments);
            if(丙丁丌丛业不丄丝丈 != null)
            {
                    this.下世且丄且丗丆丑丟(丑与丂丌世丕丆一丗:  null, 东丞丒丙世丏三下丟:  null, 丁不七丙下七丐与不:  丙丁丌丛业不丄丝丈.Attachments);
            }
            else
            {
                    this.下世且丄且丗丆丑丟(丑与丂丌世丕丆一丗:  null, 东丞丒丙世丏三下丟:  null, 丁不七丙下七丐与不:  0.Attachments);
            }
            
            this.丆丌丕丌不丄丒专丞(丑与丂丌世丕丆一丗:  null, 东丞丒丙世丏三下丟:  null, 丁不七丙下七丐与不:  丙丁丌丛业不丄丝丈.Attachments);
        }
        private void 丆丌丕丌不丄丒专丞(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            int val_9;
            System.Threading.Tasks.TaskCompletionSource<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_4 = 0;
            object val_1 = 0;
            if(东丞丒丙世丏三下丟 == null)
            {
                    return;
            }
            
            if((东丞丒丙世丏三下丟.TryGetValue(key:  "req_id", value: out  val_1)) == false)
            {
                    return;
            }
            
            val_9 = System.Convert.ToInt32(value:  val_1);
            bool val_5 = this.丟丄且业丌丟丒丆丑.TryGetValue(key:  val_9, value: out  val_4);
            bool val_6 = this.丟丄且业丌丟丒丆丑.Remove(key:  val_9);
            if(val_4 == 0)
            {
                    return;
            }
            
            Rilisoft.WebSocket.下七专丌且丛丘且丐 val_7 = null;
            val_9 = val_7;
            val_7 = new Rilisoft.WebSocket.下七专丌且丛丘且丐();
            if(val_9 != null)
            {
                    .<下上且丆丏丑三丅丛>k__BackingField = 丑与丂丌世丕丆一丗;
                .<丞丞丙且丄丕丒丞上>k__BackingField = 东丞丒丙世丏三下丟;
            }
            else
            {
                    mem[16] = 丑与丂丌世丕丆一丗;
                mem[24] = 东丞丒丙世丏三下丟;
            }
            
            .<丗一丛丒丞万下七下>k__BackingField = 丁不七丙下七丐与不;
            bool val_8 = val_4.TrySetResult(result:  val_7);
        }
        private void 下世且丄且丗丆丑丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            int val_7;
            Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_4 = 0;
            object val_1 = 0;
            if(东丞丒丙世丏三下丟 == null)
            {
                    return;
            }
            
            if((东丞丒丙世丏三下丟.TryGetValue(key:  "req_id", value: out  val_1)) == false)
            {
                    return;
            }
            
            val_7 = System.Convert.ToInt32(value:  val_1);
            bool val_5 = this.丟七东丌丞丝与丏丙.TryGetValue(key:  val_7, value: out  val_4);
            bool val_6 = this.丟七东丌丞丝与丏丙.Remove(key:  val_7);
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4.Invoke(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗, 东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟, 丁不七丙下七丐与不:  丁不七丙下七丐与不);
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
            var val_10;
            int val_2 = 0;
            object val_7 = 0;
            val_10 = 0;
            return (object);
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
        public WebSocketManager()
        {
            this.丒上丟东下丝丂丗一 = 1;
        }
        private static WebSocketManager()
        {
            Rilisoft.WebSocket.WebSocketManager.丟丛丞丄一丅不与七 = 1f;
        }
    
    }

}
