using UnityEngine;

namespace BestHTTP.SocketIO
{
    public sealed class HandshakeData
    {
        // Fields
        private string <Sid>k__BackingField;
        private System.Collections.Generic.List<string> <Upgrades>k__BackingField;
        private System.TimeSpan <PingInterval>k__BackingField;
        private System.TimeSpan <PingTimeout>k__BackingField;
        
        // Properties
        public string Sid { get; set; }
        public System.Collections.Generic.List<string> Upgrades { get; set; }
        public System.TimeSpan PingInterval { get; set; }
        public System.TimeSpan PingTimeout { get; set; }
        
        // Methods
        public string get_Sid()
        {
            return (string)this.<Sid>k__BackingField;
        }
        private void set_Sid(string value)
        {
            this.<Sid>k__BackingField = value;
        }
        public System.Collections.Generic.List<string> get_Upgrades()
        {
            return (System.Collections.Generic.List<System.String>)this.<Upgrades>k__BackingField;
        }
        private void set_Upgrades(System.Collections.Generic.List<string> value)
        {
            this.<Upgrades>k__BackingField = value;
        }
        public System.TimeSpan get_PingInterval()
        {
            return (System.TimeSpan)this.<PingInterval>k__BackingField;
        }
        private void set_PingInterval(System.TimeSpan value)
        {
            this.<PingInterval>k__BackingField = value;
        }
        public System.TimeSpan get_PingTimeout()
        {
            return (System.TimeSpan)this.<PingTimeout>k__BackingField;
        }
        private void set_PingTimeout(System.TimeSpan value)
        {
            this.<PingTimeout>k__BackingField = value;
        }
        public bool Parse(string str)
        {
            string val_11;
            System.Exception val_12;
            var val_13;
            var val_14;
            val_12 = this;
            bool val_1 = false;
            object val_2 = BestHTTP.JSON.Json.Decode(json:  str, success: ref  val_1);
            val_13 = 0;
            if(val_1 != 0)
            {
                    this.<Sid>k__BackingField = BestHTTP.SocketIO.HandshakeData.GetString(from:  null, key:  "sid");
                this.<Upgrades>k__BackingField = BestHTTP.SocketIO.HandshakeData.GetStringList(from:  null, key:  "upgrades");
                val_11 = BestHTTP.SocketIO.HandshakeData.GetInt(from:  null, key:  "pingInterval");
                System.TimeSpan val_6 = System.TimeSpan.FromMilliseconds(value:  (double)val_11);
                this.<PingInterval>k__BackingField = val_6;
                System.TimeSpan val_8 = System.TimeSpan.FromMilliseconds(value:  (double)BestHTTP.SocketIO.HandshakeData.GetInt(from:  null, key:  "pingTimeout"));
                this.<PingTimeout>k__BackingField = val_8;
                val_14 = 1;
                return (bool)val_14;
            }
            
            val_14 = 0;
            return (bool)val_14;
        }
        private static object Get(System.Collections.Generic.Dictionary<string, object> from, string key)
        {
            object val_1 = 0;
            if((from.TryGetValue(key:  key, value: out  val_1)) != false)
            {
                    return val_1;
            }
            
            System.Exception val_4 = new System.Exception(message:  System.String.Format(format:  "Can\'t get {0} from Handshake data!", arg0:  key));
        }
        private static string GetString(System.Collections.Generic.Dictionary<string, object> from, string key)
        {
            object val_1 = BestHTTP.SocketIO.HandshakeData.Get(from:  from, key:  key);
            if(val_1 == null)
            {
                    return (string)(null == null) ? (val_1) : 0;
            }
            
            return (string)(null == null) ? (val_1) : 0;
        }
        private static System.Collections.Generic.List<string> GetStringList(System.Collections.Generic.Dictionary<string, object> from, string key)
        {
            var val_6;
            object val_1 = BestHTTP.SocketIO.HandshakeData.Get(from:  from, key:  key);
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>(capacity:  0.Count);
            val_6 = 0;
            goto label_4;
            label_10:
            object val_4 = 0.Item[0];
            if((val_4 != null) && (null == null))
            {
                    val_3.Add(item:  val_4);
            }
            
            val_6 = 1;
            label_4:
            if(val_6 < 0.Count)
            {
                goto label_10;
            }
            
            return val_3;
        }
        private static int GetInt(System.Collections.Generic.Dictionary<string, object> from, string key)
        {
            object val_1 = BestHTTP.SocketIO.HandshakeData.Get(from:  from, key:  key);
            return 1152921504628731904;
        }
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<Sid>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<Sid>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<Sid>k__BackingField;
            val_1[1] = this.<Upgrades>k__BackingField;
            val_1[2] = this.<PingInterval>k__BackingField;
            val_1[3] = this.<PingTimeout>k__BackingField;
            return (string)System.String.Format(format:  "[HandshakeData: Sid={0}, Upgrades={1}, PingInterval={2}, PingTimeout={3}]", args:  val_1);
        }
        public HandshakeData()
        {
        
        }
    
    }

}
