using UnityEngine;

namespace BestHTTP.Extensions
{
    public class KeyValuePairList
    {
        // Fields
        private System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> <Values>k__BackingField;
        
        // Properties
        public System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> Values { get; set; }
        
        // Methods
        public System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> get_Values()
        {
            return (System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue>)this.<Values>k__BackingField;
        }
        protected void set_Values(System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> value)
        {
            this.<Values>k__BackingField = value;
        }
        public bool TryGet(string valueKeyName, out BestHTTP.Extensions.HeaderValue param)
        {
            var val_5;
            System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_6;
            var val_7;
            param = 0;
            val_5 = 0;
            goto label_1;
            label_6:
            val_6 = this.<Values>k__BackingField.Item[0];
            if((System.String.CompareOrdinal(strA:  val_1.<Key>k__BackingField, strB:  valueKeyName)) == 0)
            {
                goto label_4;
            }
            
            val_5 = 1;
            label_1:
            val_6 = this.<Values>k__BackingField;
            if(val_5 < val_6.Count)
            {
                goto label_6;
            }
            
            val_7 = 0;
            return (bool)val_7;
            label_4:
            param = this.<Values>k__BackingField.Item[0];
            val_7 = 1;
            return (bool)val_7;
        }
        public KeyValuePairList()
        {
        
        }
    
    }

}
