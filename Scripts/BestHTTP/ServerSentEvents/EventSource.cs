using UnityEngine;

namespace BestHTTP.ServerSentEvents
{
    public class EventSource : IHeartbeat
    {
        // Fields
        private System.Uri <Uri>k__BackingField;
        private BestHTTP.ServerSentEvents.States _state;
        private System.TimeSpan <ReconnectionTime>k__BackingField;
        private string <LastEventId>k__BackingField;
        private BestHTTP.HTTPRequest <InternalRequest>k__BackingField;
        private BestHTTP.ServerSentEvents.OnGeneralEventDelegate OnOpen;
        private BestHTTP.ServerSentEvents.OnMessageDelegate OnMessage;
        private BestHTTP.ServerSentEvents.OnErrorDelegate OnError;
        private BestHTTP.ServerSentEvents.OnRetryDelegate OnRetry;
        private BestHTTP.ServerSentEvents.OnGeneralEventDelegate OnClosed;
        private BestHTTP.ServerSentEvents.OnStateChangedDelegate OnStateChanged;
        private System.Collections.Generic.Dictionary<string, BestHTTP.ServerSentEvents.OnEventDelegate> EventTable;
        private byte RetryCount;
        private System.DateTime RetryCalled;
        
        // Properties
        public System.Uri Uri { get; set; }
        public BestHTTP.ServerSentEvents.States State { get; set; }
        public System.TimeSpan ReconnectionTime { get; set; }
        public string LastEventId { get; set; }
        public BestHTTP.HTTPRequest InternalRequest { get; set; }
        
        // Methods
        public System.Uri get_Uri()
        {
            return (System.Uri)this.<Uri>k__BackingField;
        }
        private void set_Uri(System.Uri value)
        {
            this.<Uri>k__BackingField = value;
        }
        public BestHTTP.ServerSentEvents.States get_State()
        {
            return (BestHTTP.ServerSentEvents.States)this._state;
        }
        private void set_State(BestHTTP.ServerSentEvents.States value)
        {
            this._state = value;
            if(this.OnStateChanged == null)
            {
                    return;
            }
            
            this.OnStateChanged.Invoke(eventSource:  this, oldState:  this._state, newState:  value);
        }
        public System.TimeSpan get_ReconnectionTime()
        {
            return (System.TimeSpan)this.<ReconnectionTime>k__BackingField;
        }
        public void set_ReconnectionTime(System.TimeSpan value)
        {
            this.<ReconnectionTime>k__BackingField = value;
        }
        public string get_LastEventId()
        {
            return (string)this.<LastEventId>k__BackingField;
        }
        private void set_LastEventId(string value)
        {
            this.<LastEventId>k__BackingField = value;
        }
        public BestHTTP.HTTPRequest get_InternalRequest()
        {
            return (BestHTTP.HTTPRequest)this.<InternalRequest>k__BackingField;
        }
        private void set_InternalRequest(BestHTTP.HTTPRequest value)
        {
            this.<InternalRequest>k__BackingField = value;
        }
        public void add_OnOpen(BestHTTP.ServerSentEvents.OnGeneralEventDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnOpen, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnOpen != 1152921553739829240);
        
        }
        public void remove_OnOpen(BestHTTP.ServerSentEvents.OnGeneralEventDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnOpen, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnOpen != 1152921553739965816);
        
        }
        public void add_OnMessage(BestHTTP.ServerSentEvents.OnMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMessage, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMessage != 1152921553740102400);
        
        }
        public void remove_OnMessage(BestHTTP.ServerSentEvents.OnMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMessage, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMessage != 1152921553740238976);
        
        }
        public void add_OnError(BestHTTP.ServerSentEvents.OnErrorDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnError, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnError != 1152921553740375560);
        
        }
        public void remove_OnError(BestHTTP.ServerSentEvents.OnErrorDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnError, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnError != 1152921553740512136);
        
        }
        public void add_OnRetry(BestHTTP.ServerSentEvents.OnRetryDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRetry, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRetry != 1152921553740648720);
        
        }
        public void remove_OnRetry(BestHTTP.ServerSentEvents.OnRetryDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRetry, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRetry != 1152921553740785296);
        
        }
        public void add_OnClosed(BestHTTP.ServerSentEvents.OnGeneralEventDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnClosed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnClosed != 1152921553740921880);
        
        }
        public void remove_OnClosed(BestHTTP.ServerSentEvents.OnGeneralEventDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnClosed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnClosed != 1152921553741058456);
        
        }
        public void add_OnStateChanged(BestHTTP.ServerSentEvents.OnStateChangedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStateChanged != 1152921553741195040);
        
        }
        public void remove_OnStateChanged(BestHTTP.ServerSentEvents.OnStateChangedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStateChanged != 1152921553741331616);
        
        }
        public EventSource(System.Uri uri)
        {
            this.<Uri>k__BackingField = uri;
            System.TimeSpan val_1 = System.TimeSpan.FromMilliseconds(value:  2000);
            this.<ReconnectionTime>k__BackingField = val_1;
            mem[1152921553741539232] = this;
            mem[1152921553741539240] = System.Void BestHTTP.ServerSentEvents.EventSource::OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            mem[1152921553741539216] = System.Void BestHTTP.ServerSentEvents.EventSource::OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp);
            BestHTTP.HTTPRequest val_2 = new BestHTTP.HTTPRequest(uri:  this.<Uri>k__BackingField, methodType:  0, isKeepAlive:  true, disableCache:  true, callback:  new BestHTTP.OnRequestFinishedDelegate());
            this.<InternalRequest>k__BackingField = val_2;
            val_2.SetHeader(name:  "Accept", value:  "text/event-stream");
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Cache-Control", value:  "no-cache");
            this.<InternalRequest>k__BackingField.SetHeader(name:  "Accept-Encoding", value:  "identity");
            this.<InternalRequest>k__BackingField.ProtocolHandler = 3;
            mem[1152921553741563808] = this;
            mem[1152921553741563816] = System.Void BestHTTP.ServerSentEvents.EventSource::OnUpgraded(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response);
            mem[1152921553741563792] = System.Void BestHTTP.ServerSentEvents.EventSource::OnUpgraded(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response);
            this.<InternalRequest>k__BackingField.OnUpgraded = new BestHTTP.OnRequestFinishedDelegate();
            this.<InternalRequest>k__BackingField.DisableRetry = true;
        }
        public void Open()
        {
            BestHTTP.ServerSentEvents.States val_3 = this._state;
            if(val_3 > 5)
            {
                    return;
            }
            
            val_3 = 1 << val_3;
            val_3 = val_3 & 41;
            if(val_3 == 0)
            {
                    return;
            }
            
            this.State = 1;
            if((System.String.IsNullOrEmpty(value:  this.<LastEventId>k__BackingField)) != true)
            {
                    this.<InternalRequest>k__BackingField.SetHeader(name:  "Last-Event-ID", value:  this.<LastEventId>k__BackingField);
            }
            
            BestHTTP.HTTPRequest val_2 = this.<InternalRequest>k__BackingField.Send();
        }
        public void Close()
        {
            BestHTTP.ServerSentEvents.States val_1 = this._state;
            val_1 = val_1 & 4294967294;
            if(val_1 == 4)
            {
                    return;
            }
            
            this.State = 4;
            if((this.<InternalRequest>k__BackingField) != null)
            {
                    this.<InternalRequest>k__BackingField.Abort();
                return;
            }
            
            this.State = 5;
        }
        public void On(string eventName, BestHTTP.ServerSentEvents.OnEventDelegate action)
        {
            System.Collections.Generic.Dictionary<System.String, BestHTTP.ServerSentEvents.OnEventDelegate> val_2 = this.EventTable;
            if(val_2 == null)
            {
                    System.Collections.Generic.Dictionary<System.String, BestHTTP.ServerSentEvents.OnEventDelegate> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.String, BestHTTP.ServerSentEvents.OnEventDelegate>();
                this.EventTable = val_2;
            }
            
            val_1.set_Item(key:  eventName, value:  action);
        }
        public void Off(string eventName)
        {
            if(eventName == null)
            {
                    return;
            }
            
            if(this.EventTable == null)
            {
                    return;
            }
            
            bool val_1 = this.EventTable.Remove(key:  eventName);
        }
        private void CallOnError(string error, string msg)
        {
            if(this.OnError == null)
            {
                    return;
            }
            
            this.OnError.Invoke(eventSource:  this, error:  error);
        }
        private bool CallOnRetry()
        {
            BestHTTP.ServerSentEvents.EventSource val_4;
            BestHTTP.ServerSentEvents.OnRetryDelegate val_5;
            val_4 = this;
            val_5 = this.OnRetry;
            if(val_5 != null)
            {
                    bool val_1 = val_5.Invoke(eventSource:  this);
            }
            else
            {
                    val_5 = 1;
            }
            
            val_5 = val_5 & 1;
            return (bool)val_5;
        }
        private void SetClosed(string msg)
        {
            this.State = 5;
            if(this.OnClosed == null)
            {
                    return;
            }
            
            this.OnClosed.Invoke(eventSource:  this);
        }
        private void Retry()
        {
            if(this.RetryCount == 0)
            {
                    if(this.CallOnRetry() != false)
            {
                    byte val_4 = this.RetryCount;
                val_4 = val_4 + 1;
                this.RetryCount = val_4;
                System.DateTime val_2 = System.DateTime.UtcNow;
                this.RetryCalled = val_2;
                BestHTTP.HTTPManager.Heartbeats.Subscribe(heartbeat:  this);
                this.State = 3;
                return;
            }
            
            }
            
            this.SetClosed(msg:  "Retry");
        }
        private void OnUpgraded(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response)
        {
            var val_4;
            if(response != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            this.CallOnError(error:  "Not an EventSourceResponse!", msg:  "OnUpgraded");
            return;
            label_2:
            if(this.OnOpen != null)
            {
                    this.OnOpen.Invoke(eventSource:  this);
            }
            
            if(((System.Delegate.Combine(a:  137166848, b:  new System.Action<BestHTTP.ServerSentEvents.EventSourceResponse, BestHTTP.ServerSentEvents.Message>(object:  this, method:  System.Void BestHTTP.ServerSentEvents.EventSource::OnMessageReceived(BestHTTP.ServerSentEvents.EventSourceResponse resp, BestHTTP.ServerSentEvents.Message message)))) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            mem2[0] = val_4;
            response.StartReceive();
            this.RetryCount = 0;
            this.State = 2;
        }
        private void OnRequestFinished(BestHTTP.HTTPRequest req, BestHTTP.HTTPResponse resp)
        {
            int val_23;
            var val_24;
            if(this._state == 4)
            {
                goto label_1;
            }
            
            if(this._state == 5)
            {
                    return;
            }
            
            if(req.State != 5)
            {
                goto label_4;
            }
            
            label_1:
            this.SetClosed(msg:  "OnRequestFinished");
            return;
            label_4:
            val_23 = System.String.alignConst;
            if((req.State - 2) <= 5)
            {
                    var val_23 = 106066552 + ((val_2 - 2)) << 2;
                val_23 = val_23 + 106066552;
            }
            else
            {
                    val_24 = 1;
                if(this._state <= 3)
            {
                    if((System.String.IsNullOrEmpty(value:  null)) != true)
            {
                    this.CallOnError(error:  null, msg:  "OnRequestFinished");
            }
            
                if((val_24 & 1) != 0)
            {
                    this.Retry();
                return;
            }
            
            }
            
                this.SetClosed(msg:  "OnRequestFinished");
            }
        
        }
        private void OnMessageReceived(BestHTTP.ServerSentEvents.EventSourceResponse resp, BestHTTP.ServerSentEvents.Message message)
        {
            System.Collections.Generic.Dictionary<System.String, BestHTTP.ServerSentEvents.OnEventDelegate> val_5;
            BestHTTP.ServerSentEvents.OnEventDelegate val_3 = 0;
            if(this._state > 3)
            {
                    return;
            }
            
            if((message.<Id>k__BackingField) != null)
            {
                    this.<LastEventId>k__BackingField = message.<Id>k__BackingField;
            }
            
            if(D0 > 0f)
            {
                    this.<ReconnectionTime>k__BackingField = message.<Retry>k__BackingField;
            }
            
            if((System.String.IsNullOrEmpty(value:  message.<Data>k__BackingField)) == true)
            {
                    return;
            }
            
            if(this.OnMessage != null)
            {
                    this.OnMessage.Invoke(eventSource:  this, message:  message);
            }
            
            if(this.EventTable == null)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  message.<Event>k__BackingField)) == true)
            {
                    return;
            }
            
            val_5 = this.EventTable;
            if((val_5.TryGetValue(key:  message.<Event>k__BackingField, value: out  val_3)) == false)
            {
                    return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.Invoke(eventSource:  this, message:  message);
        }
        private void BestHTTP.Extensions.IHeartbeat.OnHeartbeatUpdate(System.TimeSpan dif)
        {
            if(this._state == 3)
            {
                    System.DateTime val_1 = System.DateTime.UtcNow;
                System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.RetryCalled});
                if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_2._ticks}, t2:  new System.TimeSpan() {_ticks = this.<ReconnectionTime>k__BackingField})) == false)
            {
                    return;
            }
            
                this.Open();
                if(this._state != 1)
            {
                    this.SetClosed(msg:  "OnHeartbeatUpdate");
            }
            
            }
            
            BestHTTP.HTTPManager.Heartbeats.Unsubscribe(heartbeat:  this);
        }
    
    }

}
