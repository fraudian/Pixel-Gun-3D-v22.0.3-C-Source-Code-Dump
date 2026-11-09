using UnityEngine;

namespace BestHTTP.WebSocket
{
    public sealed class WebSocket
    {
        // Fields
        private BestHTTP.WebSocket.WebSocketStates <State>k__BackingField;
        private bool <StartPingThread>k__BackingField;
        private int <PingFrequency>k__BackingField;
        private System.TimeSpan <CloseAfterNoMesssage>k__BackingField;
        private BestHTTP.HTTPRequest <InternalRequest>k__BackingField;
        private BestHTTP.WebSocket.Extensions.IExtension[] <Extensions>k__BackingField;
        public BestHTTP.WebSocket.OnWebSocketOpenDelegate OnOpen;
        public BestHTTP.WebSocket.OnWebSocketMessageDelegate OnMessage;
        public BestHTTP.WebSocket.OnWebSocketBinaryDelegate OnBinary;
        public BestHTTP.WebSocket.OnWebSocketClosedDelegate OnClosed;
        public BestHTTP.WebSocket.OnWebSocketErrorDelegate OnError;
        public BestHTTP.WebSocket.OnWebSocketErrorDescriptionDelegate OnErrorDesc;
        public BestHTTP.WebSocket.OnWebSocketIncompleteFrameDelegate OnIncompleteFrame;
        private bool requestSent;
        private BestHTTP.WebSocket.WebSocketResponse webSocket;
        
        // Properties
        public BestHTTP.WebSocket.WebSocketStates State { get; set; }
        public bool IsOpen { get; }
        public int BufferedAmount { get; }
        public bool StartPingThread { get; set; }
        public int PingFrequency { get; set; }
        public System.TimeSpan CloseAfterNoMesssage { get; set; }
        public BestHTTP.HTTPRequest InternalRequest { get; set; }
        public BestHTTP.WebSocket.Extensions.IExtension[] Extensions { get; set; }
        public int Latency { get; }
        
        // Methods
        public BestHTTP.WebSocket.WebSocketStates get_State()
        {
            return (BestHTTP.WebSocket.WebSocketStates)this.<State>k__BackingField;
        }
        private void set_State(BestHTTP.WebSocket.WebSocketStates value)
        {
            this.<State>k__BackingField = value;
        }
        public bool get_IsOpen()
        {
            var val_2;
            if(this.webSocket != null)
            {
                    var val_1 = (this.webSocket.closed == false) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public int get_BufferedAmount()
        {
            if(this.webSocket != null)
            {
                    return (int)this.webSocket._bufferedAmount;
            }
            
            return (int)this.webSocket._bufferedAmount;
        }
        public bool get_StartPingThread()
        {
            return (bool)this.<StartPingThread>k__BackingField;
        }
        public void set_StartPingThread(bool value)
        {
            this.<StartPingThread>k__BackingField = value;
        }
        public int get_PingFrequency()
        {
            return (int)this.<PingFrequency>k__BackingField;
        }
        public void set_PingFrequency(int value)
        {
            this.<PingFrequency>k__BackingField = value;
        }
        public System.TimeSpan get_CloseAfterNoMesssage()
        {
            return (System.TimeSpan)this.<CloseAfterNoMesssage>k__BackingField;
        }
        public void set_CloseAfterNoMesssage(System.TimeSpan value)
        {
            this.<CloseAfterNoMesssage>k__BackingField = value;
        }
        public BestHTTP.HTTPRequest get_InternalRequest()
        {
            return (BestHTTP.HTTPRequest)this.<InternalRequest>k__BackingField;
        }
        private void set_InternalRequest(BestHTTP.HTTPRequest value)
        {
            this.<InternalRequest>k__BackingField = value;
        }
        public BestHTTP.WebSocket.Extensions.IExtension[] get_Extensions()
        {
            return (BestHTTP.WebSocket.Extensions.IExtension[])this.<Extensions>k__BackingField;
        }
        private void set_Extensions(BestHTTP.WebSocket.Extensions.IExtension[] value)
        {
            this.<Extensions>k__BackingField = value;
        }
        public int get_Latency()
        {
            if(this.webSocket != null)
            {
                    return (int)this.webSocket.<Latency>k__BackingField;
            }
            
            return (int)this.webSocket.<Latency>k__BackingField;
        }
        public WebSocket(System.Uri uri)
        {
            T[] val_1 = System.Array.Empty<BestHTTP.WebSocket.Extensions.IExtension>();
            BestHTTP.WebSocket.Extensions.IExtension[] val_2 = new BestHTTP.WebSocket.Extensions.IExtension[1];
            BestHTTP.WebSocket.Extensions.PerMessageCompression val_3 = new BestHTTP.WebSocket.Extensions.PerMessageCompression(level:  6, clientNoContextTakeover:  false, serverNoContextTakeover:  false, desiredClientMaxWindowBits:  15, desiredServerMaxWindowBits:  15, minDatalengthToCompress:  5);
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(val_3 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_3 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = val_3;
            this.<Extensions>k__BackingField = val_2;
        }
        public WebSocket(System.Uri uri, string origin, string protocol, BestHTTP.WebSocket.Extensions.IExtension[] extensions)
        {
            object val_35;
            var val_36;
            object val_37;
            string val_38;
            BestHTTP.HTTPRequest val_39;
            val_35 = this;
            val_1 = new System.Object();
            object val_3 = ((BestHTTP.HTTPProtocolFactory.IsSecureProtocol(uri:  uri)) != true) ? "wss" : "ws";
            if(uri.Port != 1)
            {
                    val_36 = uri.Port;
            }
            
            object[] val_8 = new object[6];
            val_8[0] = val_3;
            val_8[1] = "://";
            val_8[2] = uri.Host;
            val_8[3] = ":";
            val_8[4] = ((val_3.Equals(value:  "wss", comparisonType:  5)) != true) ? 443 : 80;
            val_8[5] = BestHTTP.Extensions.Extensions.GetRequestPathAndQueryURL(uri:  uri);
            System.Uri val_12 = new System.Uri(uriString:  +val_8);
            this.<PingFrequency>k__BackingField = 1000;
            System.TimeSpan val_13 = System.TimeSpan.FromSeconds(value:  10);
            this.<CloseAfterNoMesssage>k__BackingField = val_13;
            this.<InternalRequest>k__BackingField = new BestHTTP.HTTPRequest(uri:  val_12, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocket::OnInternalRequestCallback(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp)));
            .OnUpgraded = new BestHTTP.OnRequestFinishedDelegate(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocket::OnInternalRequestUpgraded(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp));
            val_37 = val_12.Host;
            if(val_12.Port != 80)
            {
                    val_37 = val_37 + ":"(":") + val_12.Port;
            }
            
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Host", value:  val_37);
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Upgrade", value:  "websocket");
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Connection", value:  "keep-alive, Upgrade");
            object[] val_21 = new object[4];
            val_21[0] = val_35;
            val_21[1] = this.<InternalRequest>k__BackingField;
            val_21[2] = val_12;
            object val_22 = new System.Object();
            val_21[3] = val_22;
            val_38 = val_22.GetSecKey(from:  val_21);
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Sec-WebSocket-Key", value:  val_38);
            if((System.String.IsNullOrEmpty(value:  string val_1 = origin)) != true)
            {
                    val_38 = this.<InternalRequest>k__BackingField;
                val_38.SetHeader(name:  "Origin", value:  val_1);
            }
            
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Sec-WebSocket-Version", value:  "13");
            if((System.String.IsNullOrEmpty(value:  protocol)) != true)
            {
                    this.<InternalRequest>k__BackingField.SetHeader(name:  "Sec-WebSocket-Protocol", value:  protocol);
            }
            
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Cache-Control", value:  "no-cache");
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Pragma", value:  "no-cache");
            val_39 = this.<InternalRequest>k__BackingField;
            this.<Extensions>k__BackingField = extensions;
            val_39.DisableCache = true;
            this.<InternalRequest>k__BackingField.DisableRetry = true;
            this.<InternalRequest>k__BackingField.TryToMinimizeTCPLatency = true;
            if(BestHTTP.HTTPManager.Proxy != null)
            {
                    val_35 = this.<InternalRequest>k__BackingField;
                val_39 = BestHTTP.HTTPManager.Proxy.Credentials;
                val_38 = BestHTTP.HTTPManager.Proxy.NonTransparentForHTTPS;
                BestHTTP.HTTPProxy val_34 = new BestHTTP.HTTPProxy(address:  BestHTTP.HTTPManager.Proxy.Address, credentials:  val_39, isTransparent:  false, sendWholeUri:  false, nonTransparentForHTTPS:  val_38);
                val_35.Proxy = val_34;
            }
            
            BestHTTP.HTTPManager.Setup();
        }
        private void OnInternalRequestCallback(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp)
        {
            string val_31;
            BestHTTP.WebSocket.WebSocket val_32;
            val_31 = resp;
            val_32 = this;
            if((req.State - 3) > 4)
            {
                    return;
            }
            
            var val_31 = 106032916 + ((val_1 - 3)) << 2;
            val_31 = val_31 + 106032916;
            goto (106032916 + ((val_1 - 3)) << 2 + 106032916);
        }
        private void OnInternalRequestUpgraded(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp)
        {
            BestHTTP.WebSocket.OnWebSocketErrorDelegate val_16;
            BestHTTP.WebSocket.Extensions.IExtension[] val_17;
            var val_18;
            var val_19;
            BestHTTP.WebSocket.WebSocketResponse val_23;
            if(resp != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_16 = this.OnError;
            this.webSocket = 0;
            if(val_16 != null)
            {
                    val_16.Invoke(webSocket:  this, ex:  req.Exception);
            }
            
            if(this.OnErrorDesc != null)
            {
                    val_16 = System.String.alignConst;
                if(req.Exception != null)
            {
                    val_16 = req.Exception + " " + req.Exception;
            }
            
                this.OnErrorDesc.Invoke(webSocket:  this, reason:  val_16);
            }
            
            this.<State>k__BackingField = 3;
            return;
            label_2:
            this.webSocket = resp;
            if((this.<State>k__BackingField) == 3)
            {
                    resp.CloseStream();
                return;
            }
            
            mem2[0] = this;
            val_17 = this.<Extensions>k__BackingField;
            if(val_17 == null)
            {
                goto label_14;
            }
            
            val_18 = 0;
            goto label_26;
            label_41:
            if(val_18 >= (this.<Extensions>k__BackingField.Length))
            {
                    val_19 = 0;
            }
            
            BestHTTP.WebSocket.Extensions.IExtension val_17 = this.<Extensions>k__BackingField[0];
            if(val_17 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_19 = 1;
                if((val_17.ParseNegotiation(resp:  this.webSocket)) != true)
            {
                    this.<Extensions>k__BackingField[0] = 0;
            }
            
            }
            
            val_17 = this.<Extensions>k__BackingField;
            val_18 = 1;
            label_26:
            if(val_18 < (this.<Extensions>k__BackingField.Length))
            {
                goto label_41;
            }
            
            label_14:
            this.<State>k__BackingField = 1;
            if(this.OnOpen != null)
            {
                    this.OnOpen.Invoke(webSocket:  this);
            }
            
            this.webSocket.OnText = new System.Action<BestHTTP.WebSocket.WebSocketResponse, System.String>(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocket::<OnInternalRequestUpgraded>b__42_0(BestHTTP.WebSocket.WebSocketResponse ws, string msg));
            this.webSocket.OnBinary = new System.Action<BestHTTP.WebSocket.WebSocketResponse, System.Byte[]>(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocket::<OnInternalRequestUpgraded>b__42_1(BestHTTP.WebSocket.WebSocketResponse ws, byte[] bin));
            val_23 = this.webSocket;
            this.webSocket.OnClosed = new System.Action<BestHTTP.WebSocket.WebSocketResponse, System.UInt16, System.String>(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocket::<OnInternalRequestUpgraded>b__42_2(BestHTTP.WebSocket.WebSocketResponse ws, ushort code, string msg));
            if(this.OnIncompleteFrame != null)
            {
                    val_23 = this.webSocket;
                this.webSocket.OnIncompleteFrame = new System.Action<BestHTTP.WebSocket.WebSocketResponse, BestHTTP.WebSocket.Frames.WebSocketFrameReader>(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocket::<OnInternalRequestUpgraded>b__42_3(BestHTTP.WebSocket.WebSocketResponse ws, BestHTTP.WebSocket.Frames.WebSocketFrameReader frame));
            }
            
            if((this.<StartPingThread>k__BackingField) != false)
            {
                    val_23 = System.Math.Max(val1:  this.<PingFrequency>k__BackingField, val2:  100);
                this.webSocket.StartPinging(frequency:  val_23);
            }
            
            this.webSocket.StartReceive();
        }
        public void Open()
        {
            var val_6;
            BestHTTP.WebSocket.Extensions.IExtension[] val_7;
            var val_8;
            var val_9;
            BestHTTP.HTTPRequest val_10;
            var val_12;
            val_6 = this;
            if(this.requestSent == true)
            {
                goto label_1;
            }
            
            val_7 = this.<Extensions>k__BackingField;
            if(val_7 == null)
            {
                goto label_13;
            }
            
            val_8 = 0;
            goto label_3;
            label_12:
            if(val_8 >= (this.<Extensions>k__BackingField.Length))
            {
                    val_9 = 0;
            }
            
            BestHTTP.WebSocket.Extensions.IExtension val_6 = this.<Extensions>k__BackingField[0];
            if(val_6 != null)
            {
                    val_10 = this.<InternalRequest>k__BackingField;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_9 = 0;
                val_6.AddNegotiation(request:  val_10);
            }
            
            val_7 = this.<Extensions>k__BackingField;
            val_8 = 1;
            label_3:
            if(val_8 < (this.<Extensions>k__BackingField.Length))
            {
                goto label_12;
            }
            
            goto label_13;
            label_1:
            System.InvalidOperationException val_2 = null;
            val_6 = val_2;
            val_2 = new System.InvalidOperationException(message:  "Open already called! You can\'t reuse this WebSocket instance!");
            val_12 = val_6;
            if(0 != 1)
            {
                goto label_17;
            }
            
            if((null & 1) == 0)
            {
                goto label_18;
            }
            
            val_10 = BestHTTP.HTTPManager.Logger;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_10.Exception(division:  "WebSocket", msg:  "Open", ex:  1152921504622235648);
            label_13:
            BestHTTP.HTTPRequest val_5 = 1152921504622235648.Send();
            mem[1152921553672748504] = 1;
            mem[1152921553672748416] = 0;
            return;
            label_18:
            mem[8] = null;
            val_12 = 8;
            label_17:
        }
        public void Send(string message)
        {
            if(this.webSocket == null)
            {
                    return;
            }
            
            if(this.webSocket.closed != false)
            {
                    return;
            }
            
            this.webSocket.Send(message:  message);
        }
        public void Send(byte[] buffer)
        {
            if(this.webSocket == null)
            {
                    return;
            }
            
            if(this.webSocket.closed != false)
            {
                    return;
            }
            
            this.webSocket.Send(data:  buffer);
        }
        public void Send(byte[] buffer, ulong offset, ulong count)
        {
            if(this.webSocket == null)
            {
                    return;
            }
            
            if(this.webSocket.closed != false)
            {
                    return;
            }
            
            this.webSocket.Send(data:  buffer, offset:  offset, count:  count);
        }
        public void Send(BestHTTP.WebSocket.Frames.WebSocketFrame frame)
        {
            if(this.webSocket == null)
            {
                    return;
            }
            
            if(this.webSocket.closed != false)
            {
                    return;
            }
            
            this.webSocket.Send(frame:  frame);
        }
        public void Close()
        {
            if((this.<State>k__BackingField) > 1)
            {
                    return;
            }
            
            if((this.<State>k__BackingField) != 0)
            {
                    this.<State>k__BackingField = 2;
                this.webSocket.Close();
                return;
            }
            
            this.<State>k__BackingField = 3;
            if(this.OnClosed == null)
            {
                    return;
            }
            
            this.OnClosed.Invoke(webSocket:  this, code:  1005, message:  System.String.alignConst);
        }
        public void Close(ushort code, string message)
        {
            if(this.webSocket == null)
            {
                    return;
            }
            
            if(this.webSocket.closed != false)
            {
                    return;
            }
            
            this.webSocket.Close(code:  code, msg:  message);
        }
        public static byte[] EncodeCloseData(ushort code, string message)
        {
            System.IO.MemoryStream val_3 = new System.IO.MemoryStream(capacity:  System.Text.Encoding.UTF8 + 2);
            if(System.BitConverter.IsLittleEndian != false)
            {
                    System.Array.Reverse(array:  System.BitConverter.GetBytes(value:  code), index:  0, length:  val_4.Length);
            }
            
            System.Text.Encoding val_5 = System.Text.Encoding.UTF8;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_3.Dispose();
            if(0 != 1)
            {
                    return (System.Byte[])val_3;
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])val_3;
            }
            
            return (System.Byte[])val_3;
        }
        private string GetSecKey(object[] from)
        {
            var val_3;
            var val_4;
            var val_5;
            byte[] val_1 = new byte[16];
            val_3 = 0;
            val_4 = 0;
            goto label_1;
            label_14:
            val_5 = 0;
            goto label_6;
            label_12:
            val_5 = 1;
            val_1[(long)(long)(int)(W26)] = System.BitConverter.GetBytes(value:  from[0])[0];
            label_6:
            if(val_5 < val_2.Length)
            {
                    if((val_4 + val_5) < val_1.Length)
            {
                goto label_12;
            }
            
            }
            
            val_3 = 1;
            val_4 = val_4 + val_5;
            label_1:
            if(val_3 < from.Length)
            {
                goto label_14;
            }
            
            return System.Convert.ToBase64String(inArray:  val_1);
        }
        private void <OnInternalRequestUpgraded>b__42_0(BestHTTP.WebSocket.WebSocketResponse ws, string msg)
        {
            if(this.OnMessage == null)
            {
                    return;
            }
            
            this.OnMessage.Invoke(webSocket:  this, message:  msg);
        }
        private void <OnInternalRequestUpgraded>b__42_1(BestHTTP.WebSocket.WebSocketResponse ws, byte[] bin)
        {
            if(this.OnBinary == null)
            {
                    return;
            }
            
            this.OnBinary.Invoke(webSocket:  this, data:  bin);
        }
        private void <OnInternalRequestUpgraded>b__42_2(BestHTTP.WebSocket.WebSocketResponse ws, ushort code, string msg)
        {
            this.<State>k__BackingField = 3;
            if(this.OnClosed == null)
            {
                    return;
            }
            
            this.OnClosed.Invoke(webSocket:  this, code:  code, message:  msg);
        }
        private void <OnInternalRequestUpgraded>b__42_3(BestHTTP.WebSocket.WebSocketResponse ws, BestHTTP.WebSocket.Frames.WebSocketFrameReader frame)
        {
            if(this.OnIncompleteFrame == null)
            {
                    return;
            }
            
            this.OnIncompleteFrame.Invoke(webSocket:  this, frame:  frame);
        }
    
    }

}
