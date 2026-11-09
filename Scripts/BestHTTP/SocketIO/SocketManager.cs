using UnityEngine;

namespace BestHTTP.SocketIO
{
    public sealed class SocketManager : IHeartbeat, IManager
    {
        // Fields
        public static BestHTTP.SocketIO.JsonEncoders.IJsonEncoder DefaultEncoder;
        public const int MinProtocolVersion = 4;
        private BestHTTP.SocketIO.SocketManager.States state;
        private BestHTTP.SocketIO.SocketOptions <Options>k__BackingField;
        private bool <InSoftDisconnect>k__BackingField;
        private System.Uri <Uri>k__BackingField;
        private BestHTTP.SocketIO.HandshakeData <Handshake>k__BackingField;
        private BestHTTP.SocketIO.Transports.ITransport <Transport>k__BackingField;
        private ulong <RequestCounter>k__BackingField;
        private int <ReconnectAttempts>k__BackingField;
        private BestHTTP.SocketIO.JsonEncoders.IJsonEncoder <Encoder>k__BackingField;
        private int nextAckId;
        private BestHTTP.SocketIO.SocketManager.States <PreviousState>k__BackingField;
        private BestHTTP.SocketIO.Transports.ITransport <UpgradingTransport>k__BackingField;
        private System.Collections.Generic.Dictionary<string, BestHTTP.SocketIO.Socket> Namespaces;
        private System.Collections.Generic.List<BestHTTP.SocketIO.Socket> Sockets;
        private System.Collections.Generic.List<BestHTTP.SocketIO.Packet> OfflinePackets;
        private System.DateTime LastHeartbeat;
        private System.DateTime ReconnectAt;
        private System.DateTime ConnectionStarted;
        private bool closing;
        private bool IsWaitingPong;
        private Rilisoft.丂世丈丅丝丙丘丌丟 _extras;
        
        // Properties
        public BestHTTP.SocketIO.SocketManager.States State { get; set; }
        public BestHTTP.SocketIO.SocketOptions Options { get; set; }
        public bool InSoftDisconnect { get; set; }
        public System.Uri Uri { get; set; }
        public BestHTTP.SocketIO.HandshakeData Handshake { get; set; }
        public BestHTTP.SocketIO.Transports.ITransport Transport { get; set; }
        public ulong RequestCounter { get; set; }
        public BestHTTP.SocketIO.Socket Socket { get; }
        public BestHTTP.SocketIO.Socket Item { get; }
        public int ReconnectAttempts { get; set; }
        public BestHTTP.SocketIO.JsonEncoders.IJsonEncoder Encoder { get; set; }
        internal uint Timestamp { get; }
        internal int NextAckId { get; }
        internal BestHTTP.SocketIO.SocketManager.States PreviousState { get; set; }
        internal BestHTTP.SocketIO.Transports.ITransport UpgradingTransport { get; set; }
        internal Rilisoft.丂世丈丅丝丙丘丌丟 Extras { get; }
        
        // Methods
        public BestHTTP.SocketIO.SocketManager.States get_State()
        {
            return (States)this.state;
        }
        private void set_State(BestHTTP.SocketIO.SocketManager.States value)
        {
            this.state = value;
            this.<PreviousState>k__BackingField = this.state;
        }
        public BestHTTP.SocketIO.SocketOptions get_Options()
        {
            return (BestHTTP.SocketIO.SocketOptions)this.<Options>k__BackingField;
        }
        private void set_Options(BestHTTP.SocketIO.SocketOptions value)
        {
            this.<Options>k__BackingField = value;
        }
        public bool get_InSoftDisconnect()
        {
            return (bool)this.<InSoftDisconnect>k__BackingField;
        }
        private void set_InSoftDisconnect(bool value)
        {
            this.<InSoftDisconnect>k__BackingField = value;
        }
        public System.Uri get_Uri()
        {
            return (System.Uri)this.<Uri>k__BackingField;
        }
        private void set_Uri(System.Uri value)
        {
            this.<Uri>k__BackingField = value;
        }
        public BestHTTP.SocketIO.HandshakeData get_Handshake()
        {
            return (BestHTTP.SocketIO.HandshakeData)this.<Handshake>k__BackingField;
        }
        private void set_Handshake(BestHTTP.SocketIO.HandshakeData value)
        {
            this.<Handshake>k__BackingField = value;
        }
        public BestHTTP.SocketIO.Transports.ITransport get_Transport()
        {
            return (BestHTTP.SocketIO.Transports.ITransport)this.<Transport>k__BackingField;
        }
        private void set_Transport(BestHTTP.SocketIO.Transports.ITransport value)
        {
            this.<Transport>k__BackingField = value;
        }
        public ulong get_RequestCounter()
        {
            return (ulong)this.<RequestCounter>k__BackingField;
        }
        internal void set_RequestCounter(ulong value)
        {
            this.<RequestCounter>k__BackingField = value;
        }
        public BestHTTP.SocketIO.Socket get_Socket()
        {
            return this.GetSocket();
        }
        public BestHTTP.SocketIO.Socket get_Item(string nsp)
        {
            return this.GetSocket(nsp:  nsp);
        }
        public int get_ReconnectAttempts()
        {
            return (int)this.<ReconnectAttempts>k__BackingField;
        }
        private void set_ReconnectAttempts(int value)
        {
            this.<ReconnectAttempts>k__BackingField = value;
        }
        public BestHTTP.SocketIO.JsonEncoders.IJsonEncoder get_Encoder()
        {
            return (BestHTTP.SocketIO.JsonEncoders.IJsonEncoder)this.<Encoder>k__BackingField;
        }
        public void set_Encoder(BestHTTP.SocketIO.JsonEncoders.IJsonEncoder value)
        {
            this.<Encoder>k__BackingField = value;
        }
        internal uint get_Timestamp()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = val_1.dateData.Subtract(value:  new System.DateTime());
            return (uint)(int)D0;
        }
        internal int get_NextAckId()
        {
            return System.Threading.Interlocked.Increment(location: ref  this.nextAckId);
        }
        internal BestHTTP.SocketIO.SocketManager.States get_PreviousState()
        {
            return (States)this.<PreviousState>k__BackingField;
        }
        private void set_PreviousState(BestHTTP.SocketIO.SocketManager.States value)
        {
            this.<PreviousState>k__BackingField = value;
        }
        internal BestHTTP.SocketIO.Transports.ITransport get_UpgradingTransport()
        {
            return (BestHTTP.SocketIO.Transports.ITransport)this.<UpgradingTransport>k__BackingField;
        }
        internal void set_UpgradingTransport(BestHTTP.SocketIO.Transports.ITransport value)
        {
            this.<UpgradingTransport>k__BackingField = value;
        }
        internal Rilisoft.丂世丈丅丝丙丘丌丟 get_Extras()
        {
            Rilisoft.丂世丈丅丝丙丘丌丟 val_3;
            var val_4;
            val_3 = this._extras;
            if(val_3 != null)
            {
                    return (Rilisoft.丂世丈丅丝丙丘丌丟)val_3;
            }
            
            if(Rilisoft.丁丄与下丄丌丈下丟.不不丂丆丟丑丌丈丕 == null)
            {
                goto label_2;
            }
            
            if(WrapContent3D.丏一丝丗丞万丛丒丒 == null)
            {
                    WrapContent3D.丐丑业丗丒世丗万三();
            }
            
            byte[] val_1 = new byte[32];
            val_4 = 0;
            goto label_4;
            label_11:
            byte val_3 = X9 + 32;
            val_3 = (WrapContent3D.丏一丝丗丞万丛丒丒.Length + 32) ^ val_3;
            val_4 = 1;
            val_1[0] = val_3;
            label_4:
            if(val_4 < val_1.Length)
            {
                goto label_11;
            }
            
            Rilisoft.丂世丈丅丝丙丘丌丟 val_2 = null;
            val_3 = val_2;
            val_2 = new Rilisoft.丂世丈丅丝丙丘丌丟(丅丄三丅丑丑丞且万:  val_1);
            this._extras = val_3;
            return (Rilisoft.丂世丈丅丝丙丘丌丟)val_3;
            label_2:
            UnityEngine.Debug.LogError(message:  "iterators not inited yet");
            val_3 = 0;
            return (Rilisoft.丂世丈丅丝丙丘丌丟)val_3;
        }
        public SocketManager(System.Uri uri)
        {
            BestHTTP.SocketIO.SocketOptions val_1 = new BestHTTP.SocketIO.SocketOptions();
        }
        public SocketManager(System.Uri uri, BestHTTP.SocketIO.SocketOptions options)
        {
            var val_4;
            var val_5;
            this.Namespaces = new System.Collections.Generic.Dictionary<System.String, BestHTTP.SocketIO.Socket>();
            this.Sockets = new System.Collections.Generic.List<BestHTTP.SocketIO.Socket>();
            val_4 = null;
            val_4 = null;
            this.LastHeartbeat = System.DateTime.MinValue;
            val_3 = new System.Object();
            this.<Uri>k__BackingField = uri;
            this.<Options>k__BackingField = val_3;
            this.state = 0;
            this.<PreviousState>k__BackingField = 0;
            val_5 = null;
            val_5 = null;
            this.<Encoder>k__BackingField = BestHTTP.SocketIO.SocketManager.MinProtocolVersion;
        }
        public BestHTTP.SocketIO.Socket GetSocket()
        {
            return this.GetSocket(nsp:  "/");
        }
        public BestHTTP.SocketIO.Socket GetSocket(string nsp)
        {
            System.Collections.Generic.Dictionary<System.String, BestHTTP.SocketIO.Socket> val_11;
            var val_12;
            if((System.String.IsNullOrEmpty(value:  nsp)) == true)
            {
                goto label_1;
            }
            
            val_11 = this.Namespaces;
            if((val_11.TryGetValue(key:  nsp, value: out  0)) == true)
            {
                    return val_4;
            }
            
            BestHTTP.SocketIO.Socket val_4 = new BestHTTP.SocketIO.Socket(nsp:  nsp, manager:  this);
            this.Namespaces.Add(key:  nsp, value:  val_4);
            this.Sockets.Add(item:  val_4);
            BestHTTP.SocketIO.Socket val_11 = val_4;
            if(X9 == 0)
            {
                goto label_10;
            }
            
            var val_10 = 0;
            var val_5 = X11 + 8;
            label_9:
            if(((X11 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_10 = val_10 + 1;
            val_5 = val_5 + 16;
            if(val_10 < X9)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            val_11 = val_11 + (((X11 + 8)) << 4);
            val_12 = val_11 + 296;
            label_10:
            val_4.Open();
            val_11 = 1152921505291137024;
            if(LogController.AnyLogEnabled == false)
            {
                    return val_4;
            }
            
            val_11 = LogController.Instance;
            string[] val_8 = new string[2];
            val_8[0] = "Opening socket of namespace: ";
            val_8[1] = nsp;
            val_11.AddMessage(丝东丗丕丛丞丝且丕:  this, 丛专丛丕一与丅丝丁:  val_8);
            return val_4;
            label_1:
            System.ArgumentNullException val_9 = new System.ArgumentNullException(paramName:  "Namespace parameter is null or empty!");
        }
        private void BestHTTP.SocketIO.IManager.Remove(BestHTTP.SocketIO.Socket socket)
        {
            bool val_1 = this.Namespaces.Remove(key:  socket.<Namespace>k__BackingField);
            bool val_2 = this.Sockets.Remove(item:  socket);
            if(this.Sockets.Count != 0)
            {
                    return;
            }
            
            this.Close();
        }
        public void Open()
        {
            var val_15;
            var val_16;
            BestHTTP.SocketIO.Transports.ITransport val_17;
            States val_14 = this.state;
            if(val_14 > 5)
            {
                    return;
            }
            
            val_14 = 1 << val_14;
            val_14 = val_14 & 35;
            if(val_14 == 0)
            {
                    return;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = public System.Void BestHTTP.Logger.ILogger::Information(string division, string info);
            BestHTTP.HTTPManager.Logger.Information(division:  "SocketManager", info:  "Opening");
            val_16 = null;
            val_16 = null;
            this.ReconnectAt = System.DateTime.MinValue;
            if((this.<Options>k__BackingField.<ConnectWith>k__BackingField) == 0)
            {
                goto label_13;
            }
            
            if((this.<Options>k__BackingField.<ConnectWith>k__BackingField) != 1)
            {
                goto label_14;
            }
            
            BestHTTP.SocketIO.Transports.WebSocketTransport val_3 = null;
            val_17 = val_3;
            val_3 = new BestHTTP.SocketIO.Transports.WebSocketTransport();
            .<State>k__BackingField = 3;
            .<Manager>k__BackingField = this;
            goto label_15;
            label_13:
            BestHTTP.SocketIO.Transports.PollingTransport val_4 = null;
            val_17 = val_4;
            val_4 = new BestHTTP.SocketIO.Transports.PollingTransport(manager:  this);
            label_15:
            this.<Transport>k__BackingField = val_17;
            if(val_17 != null)
            {
                goto label_21;
            }
            
            label_22:
            label_21:
            var val_16 = 0;
            val_16 = val_16 + 1;
            goto label_20;
            label_14:
            if((this.<Transport>k__BackingField) != null)
            {
                goto label_21;
            }
            
            goto label_22;
            label_20:
            val_4.Open();
            if(LogController.AnyLogEnabled != false)
            {
                    string[] val_8 = new string[1];
                val_8[0] = "Opening socket connection";
                val_15 = 0;
                LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  this, 丛专丛丕一与丅丝丁:  val_8);
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            this.EmitEvent(eventName:  "connecting", args:  System.Array.Empty<System.Object>());
            this.state = 2;
            this.<PreviousState>k__BackingField = this.state;
            System.DateTime val_11 = System.DateTime.UtcNow;
            this.ConnectionStarted = val_11;
            BestHTTP.HTTPManager.Heartbeats.Subscribe(heartbeat:  this);
            BestHTTP.SocketIO.Socket val_13 = this.GetSocket(nsp:  "/");
        }
        public void Close()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.Close(removeSockets:  true);
        }
        private void BestHTTP.SocketIO.IManager.Close(bool removeSockets)
        {
            var val_14;
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            var val_21;
            var val_23;
            if(this.state == 1)
            {
                    return;
            }
            
            bool val_14 = this.closing;
            val_14 = val_14 + 3;
            var val_15 = ~val_14;
            val_15 = val_15 & 3;
            if(val_15 != 0)
            {
                    return;
            }
            
            this.closing = true;
            var val_16 = 0;
            val_16 = val_16 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "SocketManager", info:  "Closing");
            BestHTTP.HTTPManager.Heartbeats.Unsubscribe(heartbeat:  this);
            if(removeSockets == false)
            {
                goto label_11;
            }
            
            val_16 = 1152921553712499504;
            goto label_12;
            label_21:
            if(this.Sockets != null)
            {
                    val_17 = this.Sockets.Count;
            }
            else
            {
                    val_17 = 0.Count;
            }
            
            val_18 = public BestHTTP.SocketIO.Socket System.Collections.Generic.List<BestHTTP.SocketIO.Socket>::get_Item(int index);
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = 1;
            this.Sockets.Item[val_17 - 1].Disconnect(remove:  true);
            label_12:
            if(this.Sockets.Count >= 1)
            {
                goto label_21;
            }
            
            goto label_22;
            label_11:
            val_16 = 1152921553712499504;
            val_20 = 0;
            goto label_23;
            label_31:
            val_21 = public BestHTTP.SocketIO.Socket System.Collections.Generic.List<BestHTTP.SocketIO.Socket>::get_Item(int index);
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_21 = 1;
            this.Sockets.Item[0].Disconnect(remove:  false);
            val_20 = 1;
            label_23:
            if(val_20 < this.Sockets.Count)
            {
                goto label_31;
            }
            
            label_22:
            this.state = 1;
            this.<PreviousState>k__BackingField = this.state;
            val_14 = 1152921504618614784;
            val_23 = null;
            val_23 = null;
            this.LastHeartbeat = System.DateTime.MinValue;
            if(this.OfflinePackets != null)
            {
                    this.OfflinePackets.Clear();
            }
            
            if(removeSockets != false)
            {
                    this.Namespaces.Clear();
            }
            
            this.<Handshake>k__BackingField = 0;
            if((this.<Transport>k__BackingField) != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                this.<Transport>k__BackingField.Close();
            }
            
            this.<Transport>k__BackingField = 0;
            this.closing = false;
        }
        private void BestHTTP.SocketIO.IManager.TryToReconnect()
        {
            BestHTTP.SocketIO.SocketOptions val_19;
            var val_20;
            var val_23;
            States val_19 = this.state;
            val_19 = val_19 | 4;
            if(val_19 == 5)
            {
                    return;
            }
            
            if(((this.<Options>k__BackingField.<Reconnection>k__BackingField) == false) || (BestHTTP.HTTPManager.IsQuitting == true))
            {
                goto label_6;
            }
            
            int val_2 = (this.<ReconnectAttempts>k__BackingField) + 1;
            this.<ReconnectAttempts>k__BackingField = val_2;
            if(val_2 >= (this.<Options>k__BackingField.<ReconnectionAttempts>k__BackingField))
            {
                goto label_8;
            }
            
            System.Random val_3 = new System.Random();
            int val_20 = this.<ReconnectAttempts>k__BackingField;
            System.DateTime val_4 = System.DateTime.UtcNow;
            val_19 = this.<Options>k__BackingField;
            if((this.<Options>k__BackingField) != null)
            {
                goto label_12;
            }
            
            val_19 = this.<Options>k__BackingField;
            if(val_19 == null)
            {
                goto label_13;
            }
            
            label_12:
            val_20 = val_20 * (int)V0.16B;
            float val_21 = (float)val_20;
            float val_5 = (this.<Options>k__BackingField.randomizationFactor) * val_21;
            val_5 = val_21 - val_5;
            val_21 = ((this.<Options>k__BackingField.randomizationFactor) * val_21) + val_21;
            System.TimeSpan val_8 = System.TimeSpan.FromMilliseconds(value:  (double)System.Math.Min(val1:  1861926944, val2:  (int)val_21));
            val_20 = 0;
            System.DateTime val_9 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_4.dateData}, t:  new System.TimeSpan() {_ticks = val_8._ticks});
            this.ReconnectAt = val_9;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_20 = 1;
            goto label_23;
            label_8:
            var val_23 = 0;
            val_23 = val_23 + 1;
            this.EmitEvent(eventName:  "reconnect_failed", args:  System.Array.Empty<System.Object>());
            label_6:
            this.Close();
            return;
            label_23:
            this.Close(removeSockets:  false);
            this.state = 5;
            this.<PreviousState>k__BackingField = this.state;
            val_23 = 0;
            goto label_28;
            label_36:
            var val_24 = 0;
            val_24 = val_24 + 1;
            this.Sockets.Item[0].Open();
            val_23 = 1;
            label_28:
            if(val_23 < this.Sockets.Count)
            {
                goto label_36;
            }
            
            BestHTTP.HTTPManager.Heartbeats.Subscribe(heartbeat:  this);
            var val_25 = 0;
            val_25 = val_25 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "SocketManager", info:  "Reconnecting");
            return;
            label_13:
        }
        private bool BestHTTP.SocketIO.IManager.OnTransportConnected(BestHTTP.SocketIO.Transports.ITransport trans)
        {
            BestHTTP.SocketIO.SocketManager val_9;
            var val_11;
            States val_12;
            val_9 = this;
            if(this.state != 2)
            {
                goto label_1;
            }
            
            if((this.<PreviousState>k__BackingField) != 5)
            {
                goto label_2;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_6;
            label_1:
            val_11 = 0;
            return (bool)val_11;
            label_2:
            val_12 = 2;
            goto label_8;
            label_6:
            this.EmitEvent(eventName:  "reconnect", args:  System.Array.Empty<System.Object>());
            val_12 = this.state;
            label_8:
            this.<PreviousState>k__BackingField = val_12;
            this.<InSoftDisconnect>k__BackingField = false;
            this.state = 3;
            this.<ReconnectAttempts>k__BackingField = 0;
            this.SendOfflinePackets();
            var val_11 = 0;
            val_11 = val_11 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "SocketManager", info:  "Open");
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((this.<Transport>k__BackingField.Type) != 1)
            {
                    if((this.<Handshake>k__BackingField.<Upgrades>k__BackingField.Contains(item:  "websocket")) != false)
            {
                    BestHTTP.SocketIO.Transports.WebSocketTransport val_8 = new BestHTTP.SocketIO.Transports.WebSocketTransport();
                .<Manager>k__BackingField = val_9;
                .<State>k__BackingField = 3;
                this.<UpgradingTransport>k__BackingField = val_8;
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_8.Open();
            }
            
            }
            
            val_9 = this.<Handshake>k__BackingField;
            Rilisoft.丁丄与下丄丌丈下丟.七一丘丕下丙下一丑(丂七丂丞专丛丟丙七:  this.<Handshake>k__BackingField.<Sid>k__BackingField);
            val_11 = 1;
            return (bool)val_11;
        }
        private void BestHTTP.SocketIO.IManager.OnTransportError(BestHTTP.SocketIO.Transports.ITransport trans, string err)
        {
            var val_9;
            string val_10;
            val_9 = 1152921505291137024;
            if(LogController.AnyLogEnabled != false)
            {
                    val_10 = err;
                if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    val_10 = "<color=red>"("<color=red>") + err + "</color>"("</color>");
            }
            
                val_9 = LogController.Instance;
                string[] val_5 = new string[1];
                val_5[0] = val_10;
                val_9.AddMessage(丝东丗丕丛丞丝且丕:  this, 丛专丛丕一与丅丝丁:  val_5);
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.EmitError(errCode:  4, msg:  err);
            var val_10 = 0;
            val_10 = val_10 + 1;
            trans.Close();
            var val_11 = 0;
            val_11 = val_11 + 1;
            this.TryToReconnect();
        }
        private void BestHTTP.SocketIO.IManager.OnTransportProbed(BestHTTP.SocketIO.Transports.ITransport trans)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "SocketManager", info:  "\"probe\" packet received");
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.<Options>k__BackingField.<ConnectWith>k__BackingField = trans.Type;
            this.state = 4;
            this.<PreviousState>k__BackingField = this.state;
        }
        private BestHTTP.SocketIO.Transports.ITransport SelectTransport()
        {
            if((this.state == 3) && ((this.<Transport>k__BackingField) != null))
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                if((this.<Transport>k__BackingField.IsRequestInProgress) == false)
            {
                    return 0;
            }
            
            }
            
            return 0;
        }
        private void SendOfflinePackets()
        {
            BestHTTP.SocketIO.Transports.ITransport val_1 = this.SelectTransport();
            if(this.OfflinePackets == null)
            {
                    return;
            }
            
            if(val_1 == null)
            {
                    return;
            }
            
            if(this.OfflinePackets.Count < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Send(packets:  this.OfflinePackets);
            this.OfflinePackets.Clear();
        }
        private void BestHTTP.SocketIO.IManager.SendPacket(BestHTTP.SocketIO.Packet packet)
        {
            BestHTTP.SocketIO.Transports.ITransport val_1 = this.SelectTransport();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_5;
            label_1:
            if(this.OfflinePackets == null)
            {
                goto label_6;
            }
            
            label_10:
            this.OfflinePackets.Add(item:  packet.Clone());
            return;
            label_5:
            val_1.Send(packet:  packet);
            return;
            label_6:
            this.OfflinePackets = new System.Collections.Generic.List<BestHTTP.SocketIO.Packet>();
            if(packet != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        private void BestHTTP.SocketIO.IManager.OnPacket(BestHTTP.SocketIO.Packet packet)
        {
            string val_15;
            var val_16;
            var val_19;
            var val_20;
            string val_22;
            val_16 = this;
            if(this.state == 1)
            {
                    return;
            }
            
            if((packet.<TransportEvent>k__BackingField) == 3)
            {
                goto label_3;
            }
            
            if((packet.<TransportEvent>k__BackingField) == 2)
            {
                goto label_4;
            }
            
            if(((packet.<TransportEvent>k__BackingField) != 0) || ((this.<Handshake>k__BackingField) != null))
            {
                goto label_16;
            }
            
            BestHTTP.SocketIO.HandshakeData val_1 = new BestHTTP.SocketIO.HandshakeData();
            this.<Handshake>k__BackingField = val_1;
            if((val_1.Parse(str:  packet.<Payload>k__BackingField)) == true)
            {
                goto label_8;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_15;
            label_3:
            this.IsWaitingPong = false;
            this.<InSoftDisconnect>k__BackingField = false;
            goto label_16;
            label_4:
            .<Namespace>k__BackingField = "/";
            .<Payload>k__BackingField = System.String.alignConst;
            .<TransportEvent>k__BackingField = ;
            var val_16 = 0;
            val_16 = val_16 + 1;
            this.SendPacket(packet:  new BestHTTP.SocketIO.Packet());
            label_16:
            BestHTTP.SocketIO.Socket val_7 = 0;
            val_15 = packet.<Namespace>k__BackingField;
            if((this.Namespaces.TryGetValue(key:  val_15, value: out  val_7)) == false)
            {
                goto label_23;
            }
            
            val_16 = val_7;
            var val_21 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_25;
            }
            
            var val_17 = mem[282584257676847];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_27:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_26;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < mem[282584257676957])
            {
                goto label_27;
            }
            
            label_25:
            val_19 = 2;
            goto label_28;
            label_23:
            val_16 = BestHTTP.HTTPManager.Logger;
            val_15 = "SocketManager";
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_35;
            label_26:
            var val_20 = val_17;
            val_20 = val_20 + 2;
            val_21 = val_21 + val_20;
            val_20 = val_21 + 296;
            label_28:
            val_16.OnPacket(packet:  packet);
            return;
            label_35:
            val_16.Warning(division:  val_15, warn:  "Namespace \"" + packet.<Namespace>k__BackingField(packet.<Namespace>k__BackingField) + "\" not found!"("\" not found!"));
            return;
            label_15:
            val_22 = "Expected handshake data, but wasn\'t able to pars. Payload: "("Expected handshake data, but wasn\'t able to pars. Payload: ") + packet.<Payload>k__BackingField(packet.<Payload>k__BackingField);
            BestHTTP.HTTPManager.Logger.Warning(division:  "SocketManager", warn:  val_22);
            label_8:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_22 = 3;
            bool val_14 = this.OnTransportConnected(transport:  this.<Transport>k__BackingField);
        }
        public void EmitAll(string eventName, object[] args)
        {
            goto label_1;
            label_5:
            BestHTTP.SocketIO.Socket val_2 = this.Sockets.Item[0].Emit(eventName:  eventName, callback:  0, args:  args);
            0 = 1;
            label_1:
            if(0 < this.Sockets.Count)
            {
                goto label_5;
            }
        
        }
        private void BestHTTP.SocketIO.IManager.EmitEvent(string eventName, object[] args)
        {
            System.Collections.Generic.Dictionary<System.String, BestHTTP.SocketIO.Socket> val_4;
            var val_5;
            BestHTTP.SocketIO.Socket val_1 = 0;
            val_4 = this.Namespaces;
            if((val_4.TryGetValue(key:  "/", value: out  val_1)) == false)
            {
                    return;
            }
            
            val_4 = val_1;
            var val_6 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_7;
            }
            
            var val_3 = mem[282584257676847];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_6:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < mem[282584257676957])
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            var val_5 = val_3;
            val_5 = val_5 + 4;
            val_6 = val_6 + val_5;
            val_5 = val_6 + 296;
            label_7:
            val_4.EmitEvent(eventName:  eventName, args:  args);
        }
        private void BestHTTP.SocketIO.IManager.EmitEvent(BestHTTP.SocketIO.SocketIOEventTypes type, object[] args)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.EmitEvent(eventName:  BestHTTP.SocketIO.Events.EventNames.GetNameFor(type:  type), args:  args);
        }
        private void BestHTTP.SocketIO.IManager.EmitError(BestHTTP.SocketIO.SocketIOErrors errCode, string msg)
        {
            object[] val_1 = new object[1];
            BestHTTP.SocketIO.Error val_2 = new BestHTTP.SocketIO.Error();
            .<Code>k__BackingField = errCode;
            .<Message>k__BackingField = msg;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.EmitEvent(type:  4, args:  val_1);
        }
        private void BestHTTP.SocketIO.IManager.EmitAll(string eventName, object[] args)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.Sockets.Item[0].EmitEvent(eventName:  eventName, args:  args);
            0 = 1;
            label_1:
            if(0 < this.Sockets.Count)
            {
                goto label_9;
            }
        
        }
        private void BestHTTP.Extensions.IHeartbeat.OnHeartbeatUpdate(System.TimeSpan dif)
        {
            System.TimeSpan val_40;
            var val_44;
            var val_48;
            var val_55;
            var val_56;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_66;
            System.TimeSpan val_67;
            States val_40 = this.state;
            val_40 = val_40 - 2;
            if(val_40 > 3)
            {
                    return;
            }
            
            var val_41 = 106066656 + ((this.state - 2)) << 2;
            val_41 = val_41 + 106066656;
            goto (106066656 + ((this.state - 2)) << 2 + 106066656);
            label_32:
            if(((mem[this.<Transport>k__BackingField] + 176 + 8) + -8) == null)
            {
                goto label_31;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[this.<Transport>k__BackingField] + 286))
            {
                goto label_32;
            }
            
            val_44 = 4;
            goto label_33;
            label_31:
            var val_48 = ;
            val_48 = val_48 + 4;
             =  + val_48;
            val_48 =  + 296;
            label_33:
            if(null.IsPollingInProgress == true)
            {
                    return;
            }
            
            this.state = 3;
            this.<PreviousState>k__BackingField = this.state;
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_44 = 9;
            this.<Transport>k__BackingField.Close();
            this.<UpgradingTransport>k__BackingField = 0;
            this.<Transport>k__BackingField = this.<UpgradingTransport>k__BackingField;
            BestHTTP.SocketIO.Packet val_19 = null;
            val_40 = val_19;
            val_19 = new BestHTTP.SocketIO.Packet();
            .<Namespace>k__BackingField = "/";
            .<Payload>k__BackingField = System.String.alignConst;
            .<TransportEvent>k__BackingField = ;
            var val_54 = 0;
            val_54 = val_54 + 1;
            val_44 = 7;
            this.<UpgradingTransport>k__BackingField.Send(packet:  val_19);
            if((this.<Transport>k__BackingField) == null)
            {
                    return;
            }
            
            var val_58 = mem[this.<UpgradingTransport>k__BackingField];
            val_40 = 1152921505556312064;
            if((mem[this.<UpgradingTransport>k__BackingField] + 286) == 0)
            {
                goto label_65;
            }
            
            var val_55 = mem[this.<UpgradingTransport>k__BackingField] + 176;
            var val_56 = 0;
            val_55 = val_55 + 8;
            label_64:
            if(((mem[this.<UpgradingTransport>k__BackingField] + 176 + 8) + -8) == null)
            {
                goto label_63;
            }
            
            val_56 = val_56 + 1;
            val_55 = val_55 + 16;
            if(val_56 < (mem[this.<UpgradingTransport>k__BackingField] + 286))
            {
                goto label_64;
            }
            
            goto label_65;
            label_63:
            var val_57 = val_55;
            val_57 = val_57 + 1;
            val_58 = val_58 + val_57;
            val_60 = val_58 + 296;
            label_65:
            if((this.<Transport>k__BackingField.State) != 2)
            {
                    return;
            }
            
            if((this.<Transport>k__BackingField) == null)
            {
                    return;
            }
            
            var val_62 = mem[this.<UpgradingTransport>k__BackingField];
            if((mem[this.<UpgradingTransport>k__BackingField] + 286) == 0)
            {
                goto label_71;
            }
            
            var val_59 = mem[this.<UpgradingTransport>k__BackingField] + 176;
            var val_60 = 0;
            val_59 = val_59 + 8;
            label_70:
            if(((mem[this.<UpgradingTransport>k__BackingField] + 176 + 8) + -8) == null)
            {
                goto label_69;
            }
            
            val_60 = val_60 + 1;
            val_59 = val_59 + 16;
            if(val_60 < (mem[this.<UpgradingTransport>k__BackingField] + 286))
            {
                goto label_70;
            }
            
            goto label_71;
            label_69:
            var val_61 = val_59;
            val_61 = val_61 + 1;
            val_62 = val_62 + val_61;
            val_61 = val_62 + 296;
            label_71:
            if((this.<Transport>k__BackingField.State) != 2)
            {
                    return;
            }
            
            var val_66 = mem[this.<UpgradingTransport>k__BackingField];
            if((mem[this.<UpgradingTransport>k__BackingField] + 286) == 0)
            {
                goto label_76;
            }
            
            var val_63 = mem[this.<UpgradingTransport>k__BackingField] + 176;
            var val_64 = 0;
            val_63 = val_63 + 8;
            label_75:
            if(((mem[this.<UpgradingTransport>k__BackingField] + 176 + 8) + -8) == null)
            {
                goto label_74;
            }
            
            val_64 = val_64 + 1;
            val_63 = val_63 + 16;
            if(val_64 < (mem[this.<UpgradingTransport>k__BackingField] + 286))
            {
                goto label_75;
            }
            
            goto label_76;
            label_74:
            var val_65 = val_63;
            val_65 = val_65 + 6;
            val_66 = val_66 + val_65;
            val_62 = val_66 + 296;
            label_76:
            this.<Transport>k__BackingField.Poll();
            this.SendOfflinePackets();
            val_63 = null;
            val_63 = null;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.LastHeartbeat}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
            {
                    System.DateTime val_25 = System.DateTime.UtcNow;
                this.LastHeartbeat = val_25;
                return;
            }
            
            if(this.IsWaitingPong == true)
            {
                goto label_94;
            }
            
            System.DateTime val_26 = System.DateTime.UtcNow;
            System.TimeSpan val_27 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_26.dateData}, d2:  new System.DateTime() {dateData = this.LastHeartbeat});
            val_40 = this.<Handshake>k__BackingField.<PingInterval>k__BackingField;
            val_64 = 0;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_27._ticks}, t2:  new System.TimeSpan() {_ticks = val_40})) == false)
            {
                goto label_89;
            }
            
            .<Namespace>k__BackingField = "/";
            .<Payload>k__BackingField = System.String.alignConst;
            .<TransportEvent>k__BackingField = ;
            var val_67 = 0;
            val_67 = val_67 + 1;
            val_64 = 6;
            goto label_93;
            label_89:
            if(this.IsWaitingPong == true)
            {
                goto label_94;
            }
            
            return;
            label_93:
            this.SendPacket(packet:  new BestHTTP.SocketIO.Packet());
            System.DateTime val_31 = System.DateTime.UtcNow;
            this.LastHeartbeat = val_31;
            this.IsWaitingPong = true;
            this.<InSoftDisconnect>k__BackingField = false;
            label_94:
            System.DateTime val_32 = System.DateTime.UtcNow;
            System.TimeSpan val_33 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_32.dateData}, d2:  new System.DateTime() {dateData = this.LastHeartbeat});
            System.TimeSpan val_34 = 下丟世丏三东万丘丏.一丁丒丕丐丙丗上丛();
            val_66 = 1152921504624898048;
            val_40 = val_34._ticks;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_33._ticks}, t2:  new System.TimeSpan() {_ticks = val_40})) != false)
            {
                    this.<InSoftDisconnect>k__BackingField = true;
            }
            
            if(this.IsWaitingPong == false)
            {
                    return;
            }
            
            System.DateTime val_36 = System.DateTime.UtcNow;
            System.TimeSpan val_37 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_36.dateData}, d2:  new System.DateTime() {dateData = this.LastHeartbeat});
            val_67 = this.<Handshake>k__BackingField.<PingTimeout>k__BackingField;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_37._ticks}, t2:  new System.TimeSpan() {_ticks = val_67})) == false)
            {
                    return;
            }
            
            this.IsWaitingPong = false;
            this.<InSoftDisconnect>k__BackingField = false;
            val_55 = null;
            var val_68 = 0;
            val_56 = 1152921505556082696;
            val_68 = val_68 + 1;
            this.TryToReconnect();
        }
        public override string ToString()
        {
            object[] val_1 = new object[9];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.state != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.state == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.state;
            val_1[1] = this.<Options>k__BackingField;
            val_1[2] = this.<Uri>k__BackingField;
            val_1[3] = this.<Handshake>k__BackingField;
            val_1[4] = this.<Transport>k__BackingField;
            val_1[5] = this.<RequestCounter>k__BackingField;
            val_1[6] = this.GetSocket();
            val_1[7] = this.<ReconnectAttempts>k__BackingField;
            val_1[8] = this.<Encoder>k__BackingField;
            return (string)System.String.Format(format:  "[SocketManager: State={0}, Options={1}, Uri={2}, Handshake={3}, Transport={4}, RequestCounter={5}, Socket={6}, ReconnectAttempts={7}, Encoder={8}]", args:  val_1);
        }
        private static SocketManager()
        {
            BestHTTP.SocketIO.SocketManager.MinProtocolVersion = new BestHTTP.SocketIO.JsonEncoders.DefaultJSonEncoder();
        }
    
    }

}
