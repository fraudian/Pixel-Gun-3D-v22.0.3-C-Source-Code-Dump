using UnityEngine;

namespace BestHTTP.WebSocket
{
    public sealed class WebSocketResponse : HTTPResponse, IHeartbeat, IProtocol
    {
        // Fields
        public static int RTTBufferCapacity;
        private BestHTTP.WebSocket.WebSocket <WebSocket>k__BackingField;
        public System.Action<BestHTTP.WebSocket.WebSocketResponse, string> OnText;
        public System.Action<BestHTTP.WebSocket.WebSocketResponse, byte[]> OnBinary;
        public System.Action<BestHTTP.WebSocket.WebSocketResponse, BestHTTP.WebSocket.Frames.WebSocketFrameReader> OnIncompleteFrame;
        public System.Action<BestHTTP.WebSocket.WebSocketResponse, ushort, string> OnClosed;
        private System.TimeSpan <PingFrequnecy>k__BackingField;
        private ushort <MaxFragmentSize>k__BackingField;
        private int _bufferedAmount;
        private int <Latency>k__BackingField;
        private System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader> IncompleteFrames;
        private System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader> CompletedFrames;
        private System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader> frameCache;
        private BestHTTP.WebSocket.Frames.WebSocketFrameReader CloseFrame;
        private object FrameLock;
        private object SendLock;
        private System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrame> unsentFrames;
        private System.Threading.AutoResetEvent newFrameSignal;
        private bool sendThreadCreated;
        private bool closeSent;
        private bool closed;
        private System.DateTime lastPing;
        private System.DateTime lastMessage;
        private BestHTTP.Extensions.CircularBuffer<int> rtts;
        
        // Properties
        public BestHTTP.WebSocket.WebSocket WebSocket { get; set; }
        public bool IsClosed { get; }
        public System.TimeSpan PingFrequnecy { get; set; }
        public ushort MaxFragmentSize { get; set; }
        public int BufferedAmount { get; }
        public int Latency { get; set; }
        
        // Methods
        public BestHTTP.WebSocket.WebSocket get_WebSocket()
        {
            return (BestHTTP.WebSocket.WebSocket)this.<WebSocket>k__BackingField;
        }
        internal void set_WebSocket(BestHTTP.WebSocket.WebSocket value)
        {
            this.<WebSocket>k__BackingField = value;
        }
        public bool get_IsClosed()
        {
            return (bool)this.closed;
        }
        public System.TimeSpan get_PingFrequnecy()
        {
            return (System.TimeSpan)this.<PingFrequnecy>k__BackingField;
        }
        private void set_PingFrequnecy(System.TimeSpan value)
        {
            this.<PingFrequnecy>k__BackingField = value;
        }
        public ushort get_MaxFragmentSize()
        {
            return (ushort)this.<MaxFragmentSize>k__BackingField;
        }
        private void set_MaxFragmentSize(ushort value)
        {
            this.<MaxFragmentSize>k__BackingField = value;
        }
        public int get_BufferedAmount()
        {
            return (int)this._bufferedAmount;
        }
        public int get_Latency()
        {
            return (int)this.<Latency>k__BackingField;
        }
        private void set_Latency(int value)
        {
            this.<Latency>k__BackingField = value;
        }
        internal WebSocketResponse(BestHTTP.HTTPRequest request, System.IO.Stream stream, bool isStreamed, bool isFromCache)
        {
            var val_9;
            var val_10;
            this.IncompleteFrames = new System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader>();
            this.CompletedFrames = new System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader>();
            this.frameCache = new System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader>();
            this.FrameLock = new System.Object();
            this.SendLock = new System.Object();
            this.unsentFrames = new System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrame>();
            this.newFrameSignal = new System.Threading.AutoResetEvent(initialState:  false);
            val_9 = null;
            val_9 = null;
            this.lastPing = System.DateTime.MinValue;
            this.lastMessage = System.DateTime.MinValue;
            val_10 = null;
            val_10 = null;
            isStreamed = isStreamed;
            isFromCache = isFromCache;
            this.rtts = new BestHTTP.Extensions.CircularBuffer<System.Int32>(capacity:  BestHTTP.WebSocket.WebSocketResponse.RTTBufferCapacity);
            this.IsClosedManually = true;
            this.closed = false;
            this.<MaxFragmentSize>k__BackingField = 32767;
        }
        internal void StartReceive()
        {
            if(this.IsUpgraded == false)
            {
                    return;
            }
            
            bool val_3 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocketResponse::ReceiveThreadFunc(object param)));
        }
        internal void CloseStream()
        {
            var val_6;
            if((BestHTTP.HTTPManager.GetConnectionWith(request:  this)) == null)
            {
                    return;
            }
            
            val_6 = ???;
            goto typeof(BestHTTP.ConnectionBase).__il2cppRuntimeField_188;
        }
        public void Send(string message)
        {
            if(message != null)
            {
                    this.Send(frame:  new BestHTTP.WebSocket.Frames.WebSocketFrame(webSocket:  this.<WebSocket>k__BackingField, type:  1, data:  System.Text.Encoding.UTF8, useExtensions:  true));
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "message must not be null!");
        }
        public void Send(byte[] data)
        {
            BestHTTP.WebSocket.Frames.WebSocketFrame val_5;
            System.Byte[] val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = data;
            val_7 = this;
            if(val_6 == null)
            {
                goto label_1;
            }
            
            BestHTTP.WebSocket.Frames.WebSocketFrame val_1 = null;
            val_5 = val_1;
            val_1 = new BestHTTP.WebSocket.Frames.WebSocketFrame(webSocket:  this.<WebSocket>k__BackingField, type:  2, data:  val_6, useExtensions:  true);
            if((((BestHTTP.WebSocket.Frames.WebSocketFrame)[1152921553676839952].<Data>k__BackingField) == null) || (((BestHTTP.WebSocket.Frames.WebSocketFrame)[1152921553676839952].<Data>k__BackingField.Length) <= (this.<MaxFragmentSize>k__BackingField)))
            {
                goto label_17;
            }
            
            val_6 = this.SendLock;
            val_8 = val_1.Fragment(maxFragmentSize:  this.<MaxFragmentSize>k__BackingField);
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  val_6, lockTaken: ref  val_3);
            this.Send(frame:  val_1);
            if(val_8 == null)
            {
                goto label_5;
            }
            
            if(val_2.Length >= 1)
            {
                    do
            {
                long val_6 = 0;
                this.Send(frame:  val_8[val_6]);
                val_6 = val_6 + 1;
            }
            while(val_6 < val_2.Length);
            
            }
            
            val_9 = 0;
            val_8 = 0;
            goto label_10;
            label_5:
            val_9 = 0;
            goto label_10;
            label_1:
            System.ArgumentNullException val_4 = null;
            val_7 = val_4;
            val_4 = new System.ArgumentNullException(paramName:  "data must not be null!");
            if(0 != 1)
            {
                goto label_14;
            }
            
            val_9 = 0;
            label_10:
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_6);
            }
            
            if(val_9 != 1)
            {
                    return;
            }
            
            label_17:
            val_4.Send(frame:  137125888);
            return;
            label_14:
        }
        public void Send(byte[] data, ulong offset, ulong count)
        {
            BestHTTP.WebSocket.Frames.WebSocketFrame val_7;
            ulong val_8;
            System.Byte[] val_9;
            var val_10;
            var val_11;
            val_8 = count;
            val_9 = data;
            val_10 = this;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if((val_8 + offset) > data.Length)
            {
                goto label_2;
            }
            
            BestHTTP.WebSocket.Frames.WebSocketFrame val_2 = null;
            val_7 = val_2;
            val_2 = new BestHTTP.WebSocket.Frames.WebSocketFrame(webSocket:  this.<WebSocket>k__BackingField, type:  2, data:  val_9, pos:  offset, length:  val_8, isFinal:  true, useExtensions:  true);
            if((((BestHTTP.WebSocket.Frames.WebSocketFrame)[1152921553677219344].<Data>k__BackingField) == null) || (((BestHTTP.WebSocket.Frames.WebSocketFrame)[1152921553677219344].<Data>k__BackingField.Length) <= (this.<MaxFragmentSize>k__BackingField)))
            {
                goto label_19;
            }
            
            val_8 = this.SendLock;
            val_11 = val_2.Fragment(maxFragmentSize:  this.<MaxFragmentSize>k__BackingField);
            bool val_4 = false;
            System.Threading.Monitor.Enter(obj:  val_8, lockTaken: ref  val_4);
            this.Send(frame:  val_2);
            if(val_11 == null)
            {
                goto label_6;
            }
            
            if(val_3.Length >= 1)
            {
                    do
            {
                long val_8 = 0;
                this.Send(frame:  val_11[val_8]);
                val_8 = val_8 + 1;
            }
            while(val_8 < val_3.Length);
            
            }
            
            val_9 = 0;
            val_11 = 0;
            goto label_11;
            label_6:
            val_9 = 0;
            goto label_11;
            label_1:
            System.ArgumentNullException val_5 = null;
            val_10 = val_5;
            val_5 = new System.ArgumentNullException(paramName:  "data must not be null!");
            goto label_15;
            label_2:
            System.ArgumentOutOfRangeException val_6 = null;
            val_10 = val_6;
            val_6 = new System.ArgumentOutOfRangeException(paramName:  "offset + count >= data.Length");
            label_15:
            if(0 != 1)
            {
                goto label_16;
            }
            
            val_9 = 0;
            label_11:
            if(val_4 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_8);
            }
            
            if(val_9 != 1)
            {
                    return;
            }
            
            label_19:
            val_6.Send(frame:  137125888);
            return;
            label_16:
        }
        public void Send(BestHTTP.WebSocket.Frames.WebSocketFrame frame)
        {
            object val_10;
            bool val_11;
            var val_12;
            var val_13;
            int val_15;
            val_10 = this;
            if(frame == null)
            {
                goto label_1;
            }
            
            val_11 = this.closed;
            if(val_11 == true)
            {
                    return;
            }
            
            val_11 = this.closeSent;
            if(val_11 == true)
            {
                    return;
            }
            
            val_11 = this.SendLock;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  val_11, lockTaken: ref  val_1);
            this.unsentFrames.Add(item:  frame);
            if(this.sendThreadCreated != false)
            {
                    val_12 = 0;
                val_13 = 0;
            }
            else
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                BestHTTP.HTTPManager.Logger.Information(division:  "WebSocketResponse", info:  "Send - Creating thread");
                new System.Threading.WaitCallback() = new System.Threading.WaitCallback(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocketResponse::SendThreadFunc(object param));
                bool val_5 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback());
                val_12 = 0;
                val_13 = 0;
                this.sendThreadCreated = true;
            }
            
            label_26:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_11);
            }
            
            if((frame.<Data>k__BackingField) != null)
            {
                    val_15 = frame.<Data>k__BackingField.Length;
            }
            else
            {
                    val_15 = 0;
            }
            
            int val_7 = System.Threading.Interlocked.Add(location1: ref  this._bufferedAmount, value:  0);
            val_10 = this.newFrameSignal;
            bool val_8 = val_10.Set();
            return;
            label_1:
            System.ArgumentNullException val_9 = new System.ArgumentNullException(paramName:  "frame is null!");
            if(0 != 1)
            {
                goto label_25;
            }
            
            goto label_26;
            label_25:
        }
        public void Insert(BestHTTP.WebSocket.Frames.WebSocketFrame frame)
        {
            object val_10;
            bool val_11;
            var val_12;
            var val_13;
            int val_15;
            val_10 = this;
            if(frame == null)
            {
                goto label_1;
            }
            
            val_11 = this.closed;
            if(val_11 == true)
            {
                    return;
            }
            
            val_11 = this.closeSent;
            if(val_11 == true)
            {
                    return;
            }
            
            val_11 = this.SendLock;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  val_11, lockTaken: ref  val_1);
            this.unsentFrames.Insert(index:  0, item:  frame);
            if(this.sendThreadCreated != false)
            {
                    val_12 = 0;
                val_13 = 0;
            }
            else
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                BestHTTP.HTTPManager.Logger.Information(division:  "WebSocketResponse", info:  "Insert - Creating thread");
                new System.Threading.WaitCallback() = new System.Threading.WaitCallback(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocketResponse::SendThreadFunc(object param));
                bool val_5 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback());
                val_12 = 0;
                val_13 = 0;
                this.sendThreadCreated = true;
            }
            
            label_26:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_11);
            }
            
            if((frame.<Data>k__BackingField) != null)
            {
                    val_15 = frame.<Data>k__BackingField.Length;
            }
            else
            {
                    val_15 = 0;
            }
            
            int val_7 = System.Threading.Interlocked.Add(location1: ref  this._bufferedAmount, value:  0);
            val_10 = this.newFrameSignal;
            bool val_8 = val_10.Set();
            return;
            label_1:
            System.ArgumentNullException val_9 = new System.ArgumentNullException(paramName:  "frame is null!");
            if(0 != 1)
            {
                goto label_25;
            }
            
            goto label_26;
            label_25:
        }
        public void SendNow(BestHTTP.WebSocket.Frames.WebSocketFrame frame)
        {
            if(frame == null)
            {
                goto label_1;
            }
            
            if(this.closed == true)
            {
                    return;
            }
            
            if(this.closeSent != false)
            {
                    return;
            }
            
            System.Byte[] val_1 = frame.Get();
            if(this != null)
            {
                goto typeof(BestHTTP.WebSocket.WebSocketResponse).__il2cppRuntimeField_268;
            }
            
            goto typeof(BestHTTP.WebSocket.WebSocketResponse).__il2cppRuntimeField_268;
            label_1:
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "frame is null!");
        }
        public void Close()
        {
            this.Close(code:  1000, msg:  "Bye!");
        }
        public void Close(ushort code, string msg)
        {
            ushort val_6 = code;
            if(this.closed == true)
            {
                    return;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.SendLock, lockTaken: ref  val_1);
            this.unsentFrames.Clear();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.SendLock);
            }
            
            int val_3 = System.Threading.Interlocked.Exchange(location1: ref  this._bufferedAmount, value:  0);
            BestHTTP.WebSocket.Frames.WebSocketFrame val_5 = null;
            val_6 = val_5;
            val_5 = new BestHTTP.WebSocket.Frames.WebSocketFrame(webSocket:  this.<WebSocket>k__BackingField, type:  8, data:  BestHTTP.WebSocket.WebSocket.EncodeCloseData(code:  val_6 = code, message:  msg), useExtensions:  true);
            this.Send(frame:  val_5);
        }
        public void StartPinging(int frequency)
        {
            var val_8;
            System.Action<System.Boolean> val_9;
            if(frequency > 99)
            {
                    System.TimeSpan val_1 = System.TimeSpan.FromMilliseconds(value:  (double)frequency);
                this.<PingFrequnecy>k__BackingField = val_1;
                System.DateTime val_2 = System.DateTime.UtcNow;
                this.lastMessage = val_2;
                this.SendPing();
                BestHTTP.HTTPManager.Heartbeats.Subscribe(heartbeat:  this);
                val_8 = null;
                val_8 = null;
                if(((System.Delegate.Combine(a:  BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocketResponse::OnApplicationForegroundStateChanged(bool isPaused)))) != null) && (null != null))
            {
                    val_9 = 0;
            }
            
                BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged = val_9;
                return;
            }
            
            System.ArgumentException val_7 = new System.ArgumentException(message:  "frequency must be at least 100 milliseconds!");
        }
        private void SendThreadFunc(object param)
        {
            var val_18;
            bool val_19;
            System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrame> val_1 = new System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrame>();
            val_18 = 0;
            var val_19 = 0;
            label_42:
            val_19 = this.closed;
            if((val_19 & 255) == true)
            {
                goto label_2;
            }
            
            val_19 = this.closeSent;
            if(val_19 == true)
            {
                goto label_2;
            }
            
            bool val_3 = false;
            System.Threading.Monitor.Enter(obj:  this.SendLock, lockTaken: ref  val_3);
            System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrame> val_18 = this.unsentFrames;
            val_18 = val_18.Count - 1;
            label_8:
            if((val_18 & 2147483648) != 0)
            {
                goto label_5;
            }
            
            val_18 = val_18 - 1;
            val_1.Add(item:  this.unsentFrames.Item[val_18]);
            goto label_8;
            label_5:
            this.unsentFrames.Clear();
            val_19 = val_19 + 1;
            mem2[0] = 213;
            if(val_3 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.SendLock);
            }
            
            if((val_19 == 1) || ((1827193744 + ((0 + 1)) << 2) != 213))
            {
                goto label_18;
            }
            
            var val_20 = 0;
            val_20 = val_20 ^ (val_19 >> 31);
            val_19 = val_19 + val_20;
            if(val_1 != null)
            {
                goto label_39;
            }
            
            goto label_20;
            label_18:
            label_40:
            BestHTTP.WebSocket.Frames.WebSocketFrame val_8 = val_1.Item[val_1.Count - 1];
            val_1.RemoveAt(index:  val_1.Count - 1);
            if(this.closeSent == false)
            {
                goto label_30;
            }
            
            if(val_8 != null)
            {
                goto label_37;
            }
            
            goto label_37;
            label_30:
            System.Byte[] val_11 = val_8.Get();
            if((val_8.<Type>k__BackingField) == 8)
            {
                    this.closeSent = true;
            }
            
            label_37:
            int val_13 = System.Threading.Interlocked.Add(location1: ref  this._bufferedAmount, value:  -(val_8.<Data>k__BackingField.Length));
            if(val_1 != null)
            {
                goto label_39;
            }
            
            label_20:
            label_39:
            if(val_1.Count >= 1)
            {
                goto label_40;
            }
            
            if((val_8.<Data>k__BackingField) != null)
            {
                goto label_42;
            }
            
            goto label_42;
            label_2:
            val_19 = val_19 + 1;
            mem2[0] = 349;
            this.sendThreadCreated = false;
            var val_21 = 0;
            val_21 = val_21 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "WebSocketResponse", info:  "SendThread - Closed!");
            if(val_19 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1827193744 + ((0 + 1)) << 2) == 349)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private void ReceiveThreadFunc(object param)
        {
            System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader> val_22;
            bool val_23;
            var val_28;
            System.Action<System.Boolean> val_29;
            val_22 = 0;
            var val_24 = 0;
            label_103:
            val_23 = this.closed;
            if(( & 255) != 0)
            {
                goto label_3;
            }
            
            new BestHTTP.WebSocket.Frames.WebSocketFrameReader() = new System.Object();
            new BestHTTP.WebSocket.Frames.WebSocketFrameReader().Read(stream:  this.<WebSocket>k__BackingField);
            System.DateTime val_4 = System.DateTime.UtcNow;
            this.lastMessage = val_4;
            if(((BestHTTP.WebSocket.Frames.WebSocketFrameReader)[1152921553679114960].<HasMask>k__BackingField) == true)
            {
                goto label_8;
            }
            
            if(((BestHTTP.WebSocket.Frames.WebSocketFrameReader)[1152921553679114960].<IsFinal>k__BackingField) == false)
            {
                goto label_9;
            }
            
            if(((BestHTTP.WebSocket.Frames.WebSocketFrameReader)[1152921553679114960].<Type>k__BackingField) > 10)
            {
                goto label_103;
            }
            
            var val_23 = 106032936 + ((BestHTTP.WebSocket.Frames.WebSocketFrameReader)[1152921553679114960].<Type>k__BackingField) << 2;
            val_23 = val_23 + 106032936;
            goto (106032936 + ((BestHTTP.WebSocket.Frames.WebSocketFrameReader)[1152921553679114960].<Type>k__BackingField) << 2 + 106032936);
            label_8:
            this.Close(code:  1002, msg:  "Protocol Error: masked frame received from server!");
            goto label_103;
            label_9:
            if(this.OnIncompleteFrame == null)
            {
                goto label_17;
            }
            
            bool val_6 = false;
            System.Threading.Monitor.Enter(obj:  this.FrameLock, lockTaken: ref  val_6);
            this.CompletedFrames.Add(item:  new BestHTTP.WebSocket.Frames.WebSocketFrameReader());
            val_24 = val_24 + 1;
            mem2[0] = 135;
            if(val_6 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.FrameLock);
            }
            
            if((val_24 == 1) || ((1152921553679058480 + ((0 + 1)) << 2) != 135))
            {
                goto label_21;
            }
            
            var val_26 = 0;
            val_26 = val_26 ^ (val_24 >> 31);
            val_24 = val_24 + val_26;
            goto label_103;
            label_21:
            if(val_22 == 0)
            {
                goto label_103;
            }
            
            goto label_103;
            label_17:
            this.IncompleteFrames.Add(item:  new BestHTTP.WebSocket.Frames.WebSocketFrameReader());
            goto label_103;
            label_3:
            val_24 = val_24 + 1;
            mem2[0] = 704;
            BestHTTP.HTTPManager.Heartbeats.Unsubscribe(heartbeat:  this);
            val_28 = null;
            val_28 = null;
            if(((System.Delegate.Remove(source:  BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocketResponse::OnApplicationForegroundStateChanged(bool isPaused)))) != null) && (null != null))
            {
                    val_29 = 0;
            }
            
            BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged = val_29;
            var val_27 = 0;
            val_27 = val_27 + 1;
            BestHTTP.HTTPManager.Logger.Information(division:  "WebSocketResponse", info:  "ReceiveThread - Closed!");
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1152921553679058480 + ((0 + 1)) << 2) == 704)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private void BestHTTP.IProtocol.HandleEvents()
        {
            var val_11;
            System.Collections.Generic.List<BestHTTP.WebSocket.Frames.WebSocketFrameReader> val_14;
            var val_15;
            BestHTTP.WebSocket.Frames.WebSocketFrameReader val_16;
            System.Byte[] val_17;
            this.frameCache.Clear();
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.FrameLock, lockTaken: ref  val_1);
            this.frameCache.AddRange(collection:  this.CompletedFrames);
            this.CompletedFrames.Clear();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.FrameLock);
            }
            
            if(0 == 1)
            {
                goto label_5;
            }
            
            if((0 == 0) || (68 == 68))
            {
                goto label_46;
            }
            
            label_45:
            label_46:
            val_11 = 0;
            goto label_20;
            label_36:
            if((val_2.<Type>k__BackingField) == 0)
            {
                goto label_16;
            }
            
            if((val_2.<Type>k__BackingField) == 1)
            {
                goto label_11;
            }
            
            if((val_2.<Type>k__BackingField) != 2)
            {
                goto label_33;
            }
            
            if((val_2.<IsFinal>k__BackingField) == false)
            {
                goto label_16;
            }
            
            if(this.OnBinary == null)
            {
                goto label_33;
            }
            
            this.OnBinary.Invoke(arg1:  this, arg2:  val_2.<Data>k__BackingField);
            goto label_33;
            label_11:
            if((val_2.<IsFinal>k__BackingField) == false)
            {
                goto label_16;
            }
            
            if(this.OnText == null)
            {
                goto label_33;
            }
            
            this.OnText.Invoke(arg1:  this, arg2:  val_2.<DataAsText>k__BackingField);
            goto label_33;
            label_16:
            if(this.OnIncompleteFrame != null)
            {
                    this.OnIncompleteFrame.Invoke(arg1:  this, arg2:  0.Item[0]);
            }
            
            label_33:
            val_11 = 1;
            label_20:
            val_14 = this.frameCache;
            if(val_11 < this.frameCache.Count)
            {
                goto label_36;
            }
            
            val_14.Clear();
            if(this.closed == false)
            {
                    return;
            }
            
            if(this.OnClosed == null)
            {
                    return;
            }
            
            if(this.closed.State != 2)
            {
                    return;
            }
            
            if((this.CloseFrame != null) && ((this.CloseFrame.<Data>k__BackingField) != null))
            {
                    if((this.CloseFrame.<Data>k__BackingField.Length) >= 2)
            {
                goto label_43;
            }
            
            }
            
            val_14 = 0;
            label_63:
            this.OnClosed.Invoke(arg1:  this, arg2:  0, arg3:  System.String.alignConst);
            return;
            label_5:
            if(0 != 0)
            {
                goto label_45;
            }
            
            goto label_46;
            label_43:
            val_15 = null;
            val_15 = null;
            if(System.BitConverter.IsLittleEndian != false)
            {
                    System.Array.Reverse(array:  this.CloseFrame.<Data>k__BackingField, index:  0, length:  2);
            }
            
            ushort val_7 = System.BitConverter.ToUInt16(value:  this.CloseFrame.<Data>k__BackingField, startIndex:  0);
            if((this.CloseFrame.<Data>k__BackingField.Length) < 3)
            {
                goto label_63;
            }
            
            val_16 = this.CloseFrame;
            if(val_16 != null)
            {
                    val_17 = this.CloseFrame.<Data>k__BackingField;
            }
            else
            {
                    val_17 = this.CloseFrame.<Data>k__BackingField;
                if(this.CloseFrame != null)
            {
                    val_16 = this.CloseFrame;
            }
            else
            {
                    val_16 = 0;
            }
            
            }
            
            if(System.Text.Encoding.UTF8 != null)
            {
                goto label_63;
            }
            
            goto label_63;
        }
        private void BestHTTP.Extensions.IHeartbeat.OnHeartbeatUpdate(System.TimeSpan dif)
        {
            long val_11;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.lastPing});
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_2._ticks}, t2:  new System.TimeSpan() {_ticks = this.<PingFrequnecy>k__BackingField})) != false)
            {
                    this.SendPing();
            }
            
            System.DateTime val_4 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = this.lastMessage}, t:  new System.TimeSpan() {_ticks = this.<PingFrequnecy>k__BackingField});
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = val_4.dateData});
            val_11 = val_5._ticks;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_11}, t2:  new System.TimeSpan() {_ticks = this.<WebSocket>k__BackingField.<CloseAfterNoMesssage>k__BackingField})) == false)
            {
                    return;
            }
            
            val_11 = BestHTTP.HTTPManager.Logger;
            object[] val_8 = new object[4];
            val_8[0] = this.lastMessage;
            val_8[1] = this.<PingFrequnecy>k__BackingField;
            val_8[2] = this.<WebSocket>k__BackingField.<CloseAfterNoMesssage>k__BackingField;
            val_8[3] = val_1;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11.Warning(division:  "WebSocketResponse", warn:  System.String.Format(format:  "No message received in the given time! Closing WebSocket. LastMessage: {0}, PingFrequency: {1}, Close After: {2}, Now: {3}", args:  val_8));
            this.CloseWithError(message:  "No message received in the given time!");
        }
        private void OnApplicationForegroundStateChanged(bool isPaused)
        {
            if(isPaused == true)
            {
                    return;
            }
            
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.lastMessage = val_1;
        }
        private void SendPing()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.lastPing = val_1;
            System.DateTime val_2 = System.DateTime.UtcNow;
            new BestHTTP.WebSocket.Frames.WebSocketFrame() = new BestHTTP.WebSocket.Frames.WebSocketFrame(webSocket:  this.<WebSocket>k__BackingField, type:  9, data:  System.BitConverter.GetBytes(value:  val_2.dateData.Ticks), useExtensions:  true);
            this.Insert(frame:  new BestHTTP.WebSocket.Frames.WebSocketFrame());
        }
        private void CloseWithError(string message)
        {
            var val_7;
            System.Action<System.Boolean> val_8;
            Exception = new System.Exception(message:  message);
            message.State = 4;
            this.closed = true;
            BestHTTP.HTTPManager.Heartbeats.Unsubscribe(heartbeat:  this);
            val_7 = null;
            val_7 = null;
            if(((System.Delegate.Remove(source:  BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void BestHTTP.WebSocket.WebSocketResponse::OnApplicationForegroundStateChanged(bool isPaused)))) != null) && (null != null))
            {
                    val_8 = 0;
            }
            
            BestHTTP.HTTPUpdateDelegator.OnApplicationForegroundStateChanged = val_8;
            bool val_6 = this.newFrameSignal.Set();
            this.CloseStream();
        }
        private int CalculateLatency()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = this.rtts;
            if(val_5.Count == 0)
            {
                    return (int)val_5;
            }
            
            val_6 = 0;
            val_7 = 0;
            goto label_3;
            label_6:
            val_7 = X21.Item[0] + val_7;
            val_6 = 1;
            label_3:
            if(val_6 < this.rtts.Count)
            {
                goto label_6;
            }
            
            val_5 = val_7 / this.rtts.Count;
            return (int)val_5;
        }
        private static WebSocketResponse()
        {
            BestHTTP.WebSocket.WebSocketResponse.RTTBufferCapacity = 5;
        }
    
    }

}
