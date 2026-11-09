using UnityEngine;

namespace BestHTTP.ServerSentEvents
{
    public sealed class EventSourceResponse : HTTPResponse, IProtocol
    {
        // Fields
        private bool <IsClosed>k__BackingField;
        public System.Action<BestHTTP.ServerSentEvents.EventSourceResponse, BestHTTP.ServerSentEvents.Message> OnMessage;
        public System.Action<BestHTTP.ServerSentEvents.EventSourceResponse> OnClosed;
        private object FrameLock;
        private byte[] LineBuffer;
        private int LineBufferPos;
        private BestHTTP.ServerSentEvents.Message CurrentMessage;
        private System.Collections.Generic.List<BestHTTP.ServerSentEvents.Message> CompletedMessages;
        
        // Properties
        public bool IsClosed { get; set; }
        
        // Methods
        public bool get_IsClosed()
        {
            return (bool)this.<IsClosed>k__BackingField;
        }
        private void set_IsClosed(bool value)
        {
            this.<IsClosed>k__BackingField = value;
        }
        public EventSourceResponse(BestHTTP.HTTPRequest request, System.IO.Stream stream, bool isStreamed, bool isFromCache)
        {
            this.FrameLock = new System.Object();
            this.LineBuffer = new byte[1024];
            isStreamed = isStreamed;
            isFromCache = isFromCache;
            this.CompletedMessages = new System.Collections.Generic.List<BestHTTP.ServerSentEvents.Message>();
            this.IsClosedManually = true;
        }
        public override bool Receive(int forceReadRawContentLength = -1, bool readPayloadData = True)
        {
            var val_11;
            bool val_1 = this.Receive(forceReadRawContentLength:  forceReadRawContentLength, readPayloadData:  false);
            string val_2 = this.GetFirstHeaderValue(name:  "content-type");
            val_11 = 0;
            if(val_1 != false)
            {
                    if(this.StatusCode == 200)
            {
                    if((System.String.IsNullOrEmpty(value:  val_2)) == false)
            {
                goto label_3;
            }
            
            }
            
                val_11 = 0;
            }
            
            if(this != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            this.IsUpgraded = false;
            if(this.IsUpgraded == true)
            {
                    return val_1;
            }
            
            bool val_6 = this.ReadPayload(forceReadRawContentLength:  forceReadRawContentLength);
            return val_1;
            label_3:
            bool val_10 = val_2.ToLower().StartsWith(value:  "text/event-stream");
            if(this != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        internal void StartReceive()
        {
            if(this.IsUpgraded == false)
            {
                    return;
            }
            
            bool val_3 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback(object:  this, method:  System.Void BestHTTP.ServerSentEvents.EventSourceResponse::ReceiveThreadFunc(object param)));
        }
        private void ReceiveThreadFunc(object param)
        {
            if((this.HasHeaderWithValue(headerName:  "transfer-encoding", value:  "chunked")) != false)
            {
                    this.ReadChunked(stream:  "transfer-encoding");
            }
            else
            {
                    this.ReadRaw(stream:  "transfer-encoding", contentLength:  "chunked");
            }
            
            this.<IsClosed>k__BackingField = true;
        }
        private void ReadChunked(System.IO.Stream stream)
        {
            int val_7;
            System.Byte[] val_8;
            val_7 = this.ReadChunkLength(stream:  stream);
            byte[] val_2 = new byte[0];
            val_8 = val_2;
            if(val_7 == 0)
            {
                goto label_1;
            }
            
            goto label_2;
            label_8:
            val_8 = val_8;
            label_2:
            if(val_7 > mem[1152921553744304664])
            {
                    System.Array.Resize<System.Byte>(array: ref  val_2, newSize:  val_7);
            }
            
            label_7:
            int val_3 = val_7 - 0;
            if(stream == null)
            {
                goto label_6;
            }
            
            if(null < val_7)
            {
                goto label_7;
            }
            
            this.FeedData(buffer:  val_2, count:  35622912);
            string val_4 = BestHTTP.HTTPResponse.ReadTo(stream:  stream, blocker:  10);
            val_7 = this.ReadChunkLength(stream:  stream);
            if(val_7 != 0)
            {
                goto label_8;
            }
            
            label_1:
            this.ReadHeaders(stream:  stream);
            return;
            label_6:
            System.Exception val_6 = new System.Exception(message:  "The remote server closed the connection unexpectedly!");
        }
        private void ReadRaw(System.IO.Stream stream, long contentLength)
        {
            byte[] val_1 = new byte[1024];
            goto label_6;
            label_4:
            if(stream != null)
            {
                goto label_3;
            }
            
            goto label_3;
            label_6:
            if(val_1 == null)
            {
                goto label_4;
            }
            
            label_3:
            this.FeedData(buffer:  val_1, count:  stream);
            if(stream > 0)
            {
                goto label_6;
            }
        
        }
        public void FeedData(byte[] buffer, int count)
        {
            int val_8;
            var val_9;
            var val_10;
            byte val_11;
            var val_12;
            var val_13;
            int val_14;
            val_8 = count;
            if(val_8 == 1)
            {
                    val_8 = buffer.Length;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            val_9 = 0;
            label_18:
            if(val_9 >= val_8)
            {
                goto label_4;
            }
            
            val_10 = 1;
            label_13:
            val_11 = buffer[0];
            if(val_11 == 13)
            {
                    val_12 = 0 + 1;
                if(val_12 < (long)val_8)
            {
                    var val_1 = (buffer[val_12] == 10) ? 2 : (val_10);
            }
            
                val_13 = 0;
            }
            else
            {
                    if(0 >= buffer.Length)
            {
                    val_11 = mem[buffer[0x0] + 32];
                val_11 = buffer[0x0] + 32;
            }
            
                val_12 = 0 + 1;
            }
            
            if(val_12 >= (long)val_8)
            {
                goto label_14;
            }
            
            if(((val_11 == 10) ? 0 : (!0)) == 1)
            {
                goto label_13;
            }
            
            goto label_14;
            label_4:
            val_13 = 0;
            val_10 = 1;
            label_14:
            val_14 = this.LineBufferPos;
            int val_4 = ((val_13 == 1) ? (val_8) : (val_13)) - val_9;
            int val_5 = val_14 + val_4;
            if(val_5 > (this.LineBuffer + 24))
            {
                    System.Array.Resize<System.Byte>(array: ref  this.LineBuffer, newSize:  val_5);
                val_14 = this.LineBufferPos;
            }
            
            System.Array.Copy(sourceArray:  buffer, sourceIndex:  0, destinationArray:  this.LineBuffer, destinationIndex:  val_14, length:  val_4);
            int val_7 = this.LineBufferPos + val_4;
            this.LineBufferPos = val_7;
            if(val_13 == 1)
            {
                    return;
            }
            
            this.ParseLine(buffer:  this.LineBuffer, count:  val_7);
            val_9 = val_13 + val_10;
            this.LineBufferPos = 0;
            if(val_9 < val_8)
            {
                goto label_18;
            }
        
        }
        private void ParseLine(byte[] buffer, int count)
        {
            BestHTTP.ServerSentEvents.Message val_19;
            BestHTTP.ServerSentEvents.Message val_20;
            var val_21;
            string val_22;
            var val_24;
            int val_25;
            val_19 = buffer;
            val_20 = this;
            if(count == 0)
            {
                goto label_1;
            }
            
            if(val_19[0] == 58)
            {
                    return;
            }
            
            if(count < 1)
            {
                goto label_5;
            }
            
            var val_20 = 0;
            label_8:
            val_20 = val_20 + 1;
            if(val_20 >= count)
            {
                goto label_9;
            }
            
            if(((null == 58) ? (val_20) : (!0)) == 1)
            {
                goto label_8;
            }
            
            goto label_9;
            label_1:
            if(this.CurrentMessage == null)
            {
                    return;
            }
            
            bool val_2 = false;
            System.Threading.Monitor.Enter(obj:  this.FrameLock, lockTaken: ref  val_2);
            this.CompletedMessages.Add(item:  this.CurrentMessage);
            val_19 = 0;
            if(val_2 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.FrameLock);
            }
            
            this.CurrentMessage = 0;
            return;
            label_5:
            val_21 = 0;
            label_9:
            System.Text.Encoding val_3 = System.Text.Encoding.UTF8;
            if(val_21 != 1)
            {
                    var val_4 = val_21 + 1;
                val_22 = val_3;
                if(val_4 < count)
            {
                    val_21 = (val_19[(long)val_4] == 32) ? (val_4) : (val_21);
            }
            
                val_24 = val_21 + 1;
                if(val_24 >= count)
            {
                    return;
            }
            
                int val_6 = count - val_24;
                val_25 = System.Text.Encoding.UTF8;
            }
            else
            {
                    val_22 = val_3;
                val_25 = System.String.alignConst;
            }
            
            if(this.CurrentMessage == null)
            {
                    BestHTTP.ServerSentEvents.Message val_7 = null;
                val_19 = val_7;
                val_7 = new BestHTTP.ServerSentEvents.Message();
                this.CurrentMessage = val_19;
            }
            
            if((System.String.op_Equality(a:  val_22, b:  "id")) != false)
            {
                    val_20 = this.CurrentMessage;
                this.CurrentMessage.<Id>k__BackingField = val_25;
                return;
            }
            
            if((System.String.op_Equality(a:  val_22, b:  "event")) != false)
            {
                    val_20 = this.CurrentMessage;
                this.CurrentMessage.<Event>k__BackingField = val_25;
                return;
            }
            
            if((System.String.op_Equality(a:  val_22, b:  "data")) == false)
            {
                goto label_30;
            }
            
            if((this.CurrentMessage.<Data>k__BackingField) != null)
            {
                    this.CurrentMessage.<Data>k__BackingField = this.CurrentMessage.<Data>k__BackingField(this.CurrentMessage.<Data>k__BackingField) + System.Environment.NewLine;
            }
            
            val_19 = this.CurrentMessage;
            if(val_19 == null)
            {
                goto label_35;
            }
            
            val_20 = this.CurrentMessage.<Data>k__BackingField(this.CurrentMessage.<Data>k__BackingField) + val_25;
            goto label_36;
            label_30:
            if((System.String.op_Equality(a:  val_22, b:  "retry")) == false)
            {
                    return;
            }
            
            if((System.Int32.TryParse(s:  val_25, result: out  0)) == false)
            {
                    return;
            }
            
            System.TimeSpan val_17 = System.TimeSpan.FromMilliseconds(value:  0);
            val_20 = val_17._ticks;
            this.CurrentMessage.<Retry>k__BackingField = val_17;
            return;
            label_35:
            val_19 = 32;
            val_20 = 64 + val_25;
            label_36:
            mem[32] = val_20;
        }
        private void BestHTTP.IProtocol.HandleEvents()
        {
            var val_11;
            System.Action<BestHTTP.ServerSentEvents.EventSourceResponse, BestHTTP.ServerSentEvents.Message> val_12;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.FrameLock, lockTaken: ref  val_1);
            if(this.CompletedMessages.Count < 1)
            {
                goto label_2;
            }
            
            if(this.OnMessage == null)
            {
                goto label_5;
            }
            
            var val_9 = 0;
            label_8:
            if(val_9 >= this.CompletedMessages.Count)
            {
                goto label_5;
            }
            
            this.OnMessage.Invoke(arg1:  this, arg2:  this.CompletedMessages.Item[0]);
            val_9 = val_9 + 1;
            goto label_8;
            label_5:
            this.CompletedMessages.Clear();
            label_2:
            val_11 = 0;
            val_12 = 0;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.FrameLock);
            }
            
            if(( != 1) && (135 == 135))
            {
                    val_11 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_12 = 0;
            }
            
            }
            
            if((this.<IsClosed>k__BackingField) == false)
            {
                    return;
            }
            
            this.CompletedMessages.Clear();
            if(this.OnClosed == null)
            {
                    return;
            }
            
            this.OnClosed.Invoke(obj:  this);
            this.OnClosed = 0;
        }
    
    }

}
