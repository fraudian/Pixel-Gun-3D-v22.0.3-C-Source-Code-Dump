using UnityEngine;

namespace BestHTTP
{
    internal sealed class KeepAliveHeader
    {
        // Fields
        private System.TimeSpan <TimeOut>k__BackingField;
        private int <MaxRequests>k__BackingField;
        
        // Properties
        public System.TimeSpan TimeOut { get; set; }
        public int MaxRequests { get; set; }
        
        // Methods
        public System.TimeSpan get_TimeOut()
        {
            return (System.TimeSpan)this.<TimeOut>k__BackingField;
        }
        private void set_TimeOut(System.TimeSpan value)
        {
            this.<TimeOut>k__BackingField = value;
        }
        public int get_MaxRequests()
        {
            return (int)this.<MaxRequests>k__BackingField;
        }
        private void set_MaxRequests(int value)
        {
            this.<MaxRequests>k__BackingField = value;
        }
        public void Parse(System.Collections.Generic.List<string> headerValues)
        {
            int val_14;
            var val_15;
            BestHTTP.Extensions.HeaderValue val_3 = 0;
            BestHTTP.Extensions.HeaderParser val_2 = new BestHTTP.Extensions.HeaderParser(headerStr:  headerValues.Item[0]);
            if(((val_2.TryGet(valueKeyName:  "timeout", param: out  val_3)) == false) || (val_3.HasValue == false))
            {
                goto label_5;
            }
            
            if((System.Int32.TryParse(s:  val_3.Value, result: out  0)) == false)
            {
                goto label_7;
            }
            
            System.TimeSpan val_9 = System.TimeSpan.FromSeconds(value:  0);
            this.<TimeOut>k__BackingField = val_9;
            label_5:
            if(val_2 != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            if((val_2.TryGet(valueKeyName:  "max", param: out  val_3)) == false)
            {
                    return;
            }
            
            if(val_3.HasValue == false)
            {
                    return;
            }
            
            int val_12 = 0;
            if((System.Int32.TryParse(s:  "max", result: out  val_12)) == false)
            {
                goto label_14;
            }
            
            val_14 = val_12;
            goto label_15;
            label_7:
            val_15 = null;
            val_15 = null;
            this.<TimeOut>k__BackingField = System.TimeSpan.MaxValue;
            if(val_2 != null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_14:
            val_14 = 2147483647;
            label_15:
            this.<MaxRequests>k__BackingField = val_14;
        }
        public KeepAliveHeader()
        {
        
        }
    
    }

}
