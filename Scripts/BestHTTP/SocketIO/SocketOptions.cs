using UnityEngine;

namespace BestHTTP.SocketIO
{
    public sealed class SocketOptions
    {
        // Fields
        private string <DebugName>k__BackingField;
        private BestHTTP.SocketIO.Transports.TransportTypes <ConnectWith>k__BackingField;
        private bool <Reconnection>k__BackingField;
        private int <ReconnectionAttempts>k__BackingField;
        private System.TimeSpan <ReconnectionDelay>k__BackingField;
        private System.TimeSpan <ReconnectionDelayMax>k__BackingField;
        private float randomizationFactor;
        private System.TimeSpan <Timeout>k__BackingField;
        private bool <AutoConnect>k__BackingField;
        private PlatformSupport.Collections.ObjectModel.丗丛丆东丂丒上万下<string, string> additionalQueryParams;
        private bool <QueryParamsOnlyForHandshake>k__BackingField;
        private string BuiltQueryParams;
        
        // Properties
        public string DebugName { get; set; }
        public BestHTTP.SocketIO.Transports.TransportTypes ConnectWith { get; set; }
        public bool Reconnection { get; set; }
        public int ReconnectionAttempts { get; set; }
        public System.TimeSpan ReconnectionDelay { get; set; }
        public System.TimeSpan ReconnectionDelayMax { get; set; }
        public float RandomizationFactor { get; set; }
        public System.TimeSpan Timeout { get; set; }
        public bool AutoConnect { get; set; }
        public PlatformSupport.Collections.ObjectModel.丗丛丆东丂丒上万下<string, string> AdditionalQueryParams { get; set; }
        public bool QueryParamsOnlyForHandshake { get; set; }
        
        // Methods
        public string get_DebugName()
        {
            return (string)this.<DebugName>k__BackingField;
        }
        public void set_DebugName(string value)
        {
            this.<DebugName>k__BackingField = value;
        }
        public BestHTTP.SocketIO.Transports.TransportTypes get_ConnectWith()
        {
            return (BestHTTP.SocketIO.Transports.TransportTypes)this.<ConnectWith>k__BackingField;
        }
        public void set_ConnectWith(BestHTTP.SocketIO.Transports.TransportTypes value)
        {
            this.<ConnectWith>k__BackingField = value;
        }
        public bool get_Reconnection()
        {
            return (bool)this.<Reconnection>k__BackingField;
        }
        public void set_Reconnection(bool value)
        {
            this.<Reconnection>k__BackingField = value;
        }
        public int get_ReconnectionAttempts()
        {
            return (int)this.<ReconnectionAttempts>k__BackingField;
        }
        public void set_ReconnectionAttempts(int value)
        {
            this.<ReconnectionAttempts>k__BackingField = value;
        }
        public System.TimeSpan get_ReconnectionDelay()
        {
            return (System.TimeSpan)this.<ReconnectionDelay>k__BackingField;
        }
        public void set_ReconnectionDelay(System.TimeSpan value)
        {
            this.<ReconnectionDelay>k__BackingField = value;
        }
        public System.TimeSpan get_ReconnectionDelayMax()
        {
            return (System.TimeSpan)this.<ReconnectionDelayMax>k__BackingField;
        }
        public void set_ReconnectionDelayMax(System.TimeSpan value)
        {
            this.<ReconnectionDelayMax>k__BackingField = value;
        }
        public float get_RandomizationFactor()
        {
            return (float)this.randomizationFactor;
        }
        public void set_RandomizationFactor(float value)
        {
            this.randomizationFactor = System.Math.Min(val1:  1f, val2:  System.Math.Max(val1:  0f, val2:  value));
        }
        public System.TimeSpan get_Timeout()
        {
            return (System.TimeSpan)this.<Timeout>k__BackingField;
        }
        public void set_Timeout(System.TimeSpan value)
        {
            this.<Timeout>k__BackingField = value;
        }
        public bool get_AutoConnect()
        {
            return (bool)this.<AutoConnect>k__BackingField;
        }
        public void set_AutoConnect(bool value)
        {
            this.<AutoConnect>k__BackingField = value;
        }
        public PlatformSupport.Collections.ObjectModel.丗丛丆东丂丒上万下<string, string> get_AdditionalQueryParams()
        {
            return (PlatformSupport.Collections.ObjectModel.丗丛丆东丂丒上万下<System.String, System.String>)this.additionalQueryParams;
        }
        public void set_AdditionalQueryParams(PlatformSupport.Collections.ObjectModel.丗丛丆东丂丒上万下<string, string> value)
        {
            if(this.additionalQueryParams != null)
            {
                    this.additionalQueryParams.丅丆专三业丝丝业丙(丙业与丙丗丝不丈东:  new PlatformSupport.Collections.Specialized.一七一丞丙丝业丆一(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void BestHTTP.SocketIO.SocketOptions::AdditionalQueryParams_CollectionChanged(object sender, PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛 e)));
            }
            
            this.additionalQueryParams = value;
            this.BuiltQueryParams = 0;
            if(value == null)
            {
                    return;
            }
            
            value.丑万丝丙丌丂与丝万(丙业与丙丗丝不丈东:  new PlatformSupport.Collections.Specialized.一七一丞丙丝业丆一(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void BestHTTP.SocketIO.SocketOptions::AdditionalQueryParams_CollectionChanged(object sender, PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛 e)));
        }
        public bool get_QueryParamsOnlyForHandshake()
        {
            return (bool)this.<QueryParamsOnlyForHandshake>k__BackingField;
        }
        public void set_QueryParamsOnlyForHandshake(bool value)
        {
            this.<QueryParamsOnlyForHandshake>k__BackingField = value;
        }
        public SocketOptions()
        {
            this.<ConnectWith>k__BackingField = 0;
            this.<Reconnection>k__BackingField = true;
            this.<ReconnectionAttempts>k__BackingField = 2147483647;
            System.TimeSpan val_1 = System.TimeSpan.FromMilliseconds(value:  1000);
            this.<ReconnectionDelay>k__BackingField = val_1;
            System.TimeSpan val_2 = System.TimeSpan.FromMilliseconds(value:  5000);
            this.<ReconnectionDelayMax>k__BackingField = val_2;
            this.RandomizationFactor = 0.5f;
            System.TimeSpan val_3 = System.TimeSpan.FromMilliseconds(value:  20000);
            this.<Timeout>k__BackingField = val_3;
            this.<AutoConnect>k__BackingField = true;
            this.<QueryParamsOnlyForHandshake>k__BackingField = true;
        }
        internal string BuildQueryParams()
        {
            var val_16;
            var val_18;
            int val_20;
            var val_21;
            var val_22;
            if(this.additionalQueryParams == null)
            {
                goto label_2;
            }
            
            val_16 = 1152921553719304032;
            if(this.additionalQueryParams.Count == 0)
            {
                goto label_2;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.BuiltQueryParams)) == false)
            {
                goto label_3;
            }
            
            System.Text.StringBuilder val_5 = new System.Text.StringBuilder(capacity:  this.additionalQueryParams.Count << 2);
            val_16 = this.additionalQueryParams.GetEnumerator();
            label_22:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_16.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            T val_10 = val_16.Current;
            System.Text.StringBuilder val_11 = val_5.Append(value:  "&");
            System.Text.StringBuilder val_13 = val_5.Append(value:  val_10.丐丏七丌丕丗业且上());
            if((System.String.IsNullOrEmpty(value:  val_10)) == true)
            {
                goto label_22;
            }
            
            System.Text.StringBuilder val_15 = val_5.Append(value:  "=");
            System.Text.StringBuilder val_16 = val_5.Append(value:  val_10);
            goto label_22;
            label_2:
            val_20 = System.String.alignConst;
            return val_20;
            label_3:
            val_20 = this.BuiltQueryParams;
            return val_20;
            label_11:
            val_21 = 0;
            val_22 = 0;
            if(val_16 == null)
            {
                
            }
            else
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_18 = public System.Void System.IDisposable::Dispose();
                val_16.Dispose();
            }
            
            if(( == 1) && ( != false))
            {
                    val_18 = 0;
            }
            
            val_20 = val_5;
            this.BuiltQueryParams = val_20;
            return val_20;
        }
        private void AdditionalQueryParams_CollectionChanged(object sender, PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛 e)
        {
            this.BuiltQueryParams = 0;
        }
    
    }

}
