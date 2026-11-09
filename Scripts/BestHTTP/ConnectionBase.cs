using UnityEngine;

namespace BestHTTP
{
    internal abstract class ConnectionBase : IDisposable
    {
        // Fields
        private string <ServerAddress>k__BackingField;
        private BestHTTP.HTTPConnectionStates <State>k__BackingField;
        private BestHTTP.HTTPRequest <CurrentRequest>k__BackingField;
        private System.DateTime <StartTime>k__BackingField;
        private System.DateTime <TimedOutStart>k__BackingField;
        private BestHTTP.HTTPProxy <Proxy>k__BackingField;
        private System.Uri <LastProcessedUri>k__BackingField;
        protected System.DateTime LastProcessTime;
        protected BestHTTP.HTTPConnectionRecycledDelegate OnConnectionRecycled;
        private bool IsThreaded;
        private bool <IsDisposed>k__BackingField;
        
        // Properties
        public string ServerAddress { get; set; }
        public BestHTTP.HTTPConnectionStates State { get; set; }
        public bool IsFree { get; }
        public bool IsActive { get; }
        public BestHTTP.HTTPRequest CurrentRequest { get; set; }
        public virtual bool IsRemovable { get; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime TimedOutStart { get; set; }
        protected BestHTTP.HTTPProxy Proxy { get; set; }
        public bool HasProxy { get; }
        public System.Uri LastProcessedUri { get; set; }
        protected bool IsDisposed { get; set; }
        
        // Methods
        public string get_ServerAddress()
        {
            return (string)this.<ServerAddress>k__BackingField;
        }
        protected void set_ServerAddress(string value)
        {
            this.<ServerAddress>k__BackingField = value;
        }
        public BestHTTP.HTTPConnectionStates get_State()
        {
            return (BestHTTP.HTTPConnectionStates)this.<State>k__BackingField;
        }
        protected void set_State(BestHTTP.HTTPConnectionStates value)
        {
            this.<State>k__BackingField = value;
        }
        public bool get_IsFree()
        {
            return (bool)(((this.<State>k__BackingField) == 6) ? 1 : 0) | (((this.<State>k__BackingField) == 0) ? 1 : 0);
        }
        public bool get_IsActive()
        {
            BestHTTP.HTTPConnectionStates val_2 = this.<State>k__BackingField;
            val_2 = val_2 - 1;
            return (bool)(val_2 < 5) ? 1 : 0;
        }
        public BestHTTP.HTTPRequest get_CurrentRequest()
        {
            return (BestHTTP.HTTPRequest)this.<CurrentRequest>k__BackingField;
        }
        protected void set_CurrentRequest(BestHTTP.HTTPRequest value)
        {
            this.<CurrentRequest>k__BackingField = value;
        }
        public virtual bool get_IsRemovable()
        {
            if((this.<State>k__BackingField) != 6)
            {
                    if((this.<State>k__BackingField) != 0)
            {
                    return false;
            }
            
            }
            
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.LastProcessTime});
            System.TimeSpan val_3 = BestHTTP.HTTPManager.MaxConnectionIdleTime;
            return System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_2._ticks}, t2:  new System.TimeSpan() {_ticks = val_3._ticks});
        }
        public System.DateTime get_StartTime()
        {
            return (System.DateTime)this.<StartTime>k__BackingField;
        }
        protected void set_StartTime(System.DateTime value)
        {
            this.<StartTime>k__BackingField = value;
        }
        public System.DateTime get_TimedOutStart()
        {
            return (System.DateTime)this.<TimedOutStart>k__BackingField;
        }
        protected void set_TimedOutStart(System.DateTime value)
        {
            this.<TimedOutStart>k__BackingField = value;
        }
        protected BestHTTP.HTTPProxy get_Proxy()
        {
            return (BestHTTP.HTTPProxy)this.<Proxy>k__BackingField;
        }
        protected void set_Proxy(BestHTTP.HTTPProxy value)
        {
            this.<Proxy>k__BackingField = value;
        }
        public bool get_HasProxy()
        {
            return (bool)((this.<Proxy>k__BackingField) != 0) ? 1 : 0;
        }
        public System.Uri get_LastProcessedUri()
        {
            return (System.Uri)this.<LastProcessedUri>k__BackingField;
        }
        protected void set_LastProcessedUri(System.Uri value)
        {
            this.<LastProcessedUri>k__BackingField = value;
        }
        public ConnectionBase(string serverAddress)
        {
        
        }
        public ConnectionBase(string serverAddress, bool threaded)
        {
            this.<ServerAddress>k__BackingField = serverAddress;
            this.<State>k__BackingField = 0;
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.LastProcessTime = val_1;
            this.IsThreaded = threaded;
        }
        internal abstract void Abort(BestHTTP.HTTPConnectionStates hTTPConnectionStates); // 0
        internal void Process(BestHTTP.HTTPRequest request)
        {
            var val_4;
            if((this.<State>k__BackingField) != 1)
            {
                    val_4 = null;
                val_4 = null;
                this.<State>k__BackingField = 1;
                this.<CurrentRequest>k__BackingField = request;
                this.<StartTime>k__BackingField = System.DateTime.MaxValue;
                if(this.IsThreaded == false)
            {
                goto typeof(BestHTTP.ConnectionBase).__il2cppRuntimeField_198;
            }
            
                bool val_2 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback(object:  this, method:  typeof(BestHTTP.ConnectionBase).__il2cppRuntimeField_1A0));
                return;
            }
            
            System.Exception val_3 = new System.Exception(message:  "Connection already processing a request!");
        }
        protected virtual void ThreadFunc(object param)
        {
        
        }
        internal void HandleProgressCallback()
        {
            BestHTTP.HTTPRequest val_7;
            BestHTTP.OnDownloadProgressDelegate val_8;
            BestHTTP.HTTPRequest val_9;
            BestHTTP.OnUploadProgressDelegate val_10;
            if(((this.<CurrentRequest>k__BackingField.OnProgress) != null) && ((this.<CurrentRequest>k__BackingField.DownloadProgressChanged) != false))
            {
                    val_7 = this.<CurrentRequest>k__BackingField;
                if(val_7 != null)
            {
                    val_8 = this.<CurrentRequest>k__BackingField.OnProgress;
            }
            else
            {
                    val_8 = this.<CurrentRequest>k__BackingField.OnProgress;
                if((this.<CurrentRequest>k__BackingField) != null)
            {
                    val_7 = this.<CurrentRequest>k__BackingField;
            }
            else
            {
                    val_7 = 0;
            }
            
            }
            
                val_8.Invoke(originalRequest:  val_7, downloaded:  val_7.Downloaded, downloadLength:  this.<CurrentRequest>k__BackingField.DownloadLength);
                this.<CurrentRequest>k__BackingField.DownloadProgressChanged = false;
            }
            
            if((this.<CurrentRequest>k__BackingField.OnUploadProgress) == null)
            {
                    return;
            }
            
            if((this.<CurrentRequest>k__BackingField.UploadProgressChanged) == false)
            {
                    return;
            }
            
            val_9 = this.<CurrentRequest>k__BackingField;
            if(val_9 != null)
            {
                    val_10 = this.<CurrentRequest>k__BackingField.OnUploadProgress;
            }
            else
            {
                    val_10 = this.<CurrentRequest>k__BackingField.OnUploadProgress;
                if((this.<CurrentRequest>k__BackingField) != null)
            {
                    val_9 = this.<CurrentRequest>k__BackingField;
            }
            else
            {
                    val_9 = 0;
            }
            
            }
            
            val_10.Invoke(originalRequest:  val_9, uploaded:  val_9.Uploaded, uploadLength:  this.<CurrentRequest>k__BackingField.UploadLength);
            this.<CurrentRequest>k__BackingField.UploadProgressChanged = false;
        }
        internal void HandleCallback()
        {
            this.HandleProgressCallback();
            if((this.<State>k__BackingField) == 3)
            {
                    if(((this.<CurrentRequest>k__BackingField) != null) && ((this.<CurrentRequest>k__BackingField.Response) != null))
            {
                    if((this.<CurrentRequest>k__BackingField.Response.IsUpgraded) != false)
            {
                    this.<CurrentRequest>k__BackingField.UpgradeCallback();
            }
            
            }
            
                this.<State>k__BackingField = 4;
                return;
            }
            
            this.<CurrentRequest>k__BackingField.CallCallback();
        }
        internal void Recycle(BestHTTP.HTTPConnectionRecycledDelegate onConnectionRecycled)
        {
            BestHTTP.HTTPConnectionStates val_1 = this.<State>k__BackingField;
            this.OnConnectionRecycled = onConnectionRecycled;
            if(val_1 != 2)
            {
                    val_1 = val_1 - 1;
                if(val_1 < 3)
            {
                    return;
            }
            
            }
            
            this.RecycleNow();
        }
        protected void RecycleNow()
        {
            var val_1;
            BestHTTP.HTTPConnectionStates val_1 = this.<State>k__BackingField;
            val_1 = val_1 & 4294967294;
            if(val_1 == 8)
            {
                    val_1 = null;
                val_1 = null;
                this.LastProcessTime = System.DateTime.MinValue;
            }
            
            this.<State>k__BackingField = 6;
            this.<CurrentRequest>k__BackingField = 0;
            if(this.OnConnectionRecycled == null)
            {
                    return;
            }
            
            this.OnConnectionRecycled.Invoke(conn:  this);
            this.OnConnectionRecycled = 0;
        }
        protected bool get_IsDisposed()
        {
            return (bool)this.<IsDisposed>k__BackingField;
        }
        private void set_IsDisposed(bool value)
        {
            this.<IsDisposed>k__BackingField = value;
        }
        public void Dispose()
        {
            System.GC.SuppressFinalize(obj:  this);
        }
        protected virtual void Dispose(bool disposing)
        {
            this.<IsDisposed>k__BackingField = true;
        }
    
    }

}
