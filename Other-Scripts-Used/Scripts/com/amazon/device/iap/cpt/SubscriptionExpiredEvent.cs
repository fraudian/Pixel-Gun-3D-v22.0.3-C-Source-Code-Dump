using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class SubscriptionExpiredEvent : Jsonable
    {
        // Fields
        private string <Sku>k__BackingField;
        
        // Properties
        public string Sku { get; set; }
        
        // Methods
        public string get_Sku()
        {
            return (string)this.<Sku>k__BackingField;
        }
        public void set_Sku(string value)
        {
            this.<Sku>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "sku", value:  this.<Sku>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.SubscriptionExpiredEvent CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_5;
            string val_6;
            if(jsonMap != null)
            {
                    val_5 = new com.amazon.device.iap.cpt.SubscriptionExpiredEvent();
                val_5 = new System.Object();
                if((jsonMap.ContainsKey(key:  "sku")) == false)
            {
                    return (com.amazon.device.iap.cpt.SubscriptionExpiredEvent)val_5;
            }
            
                val_6 = jsonMap.Item["sku"];
                if((val_6 != null) && (null != null))
            {
                    val_6 = 0;
            }
            
                .<Sku>k__BackingField = val_6;
                return (com.amazon.device.iap.cpt.SubscriptionExpiredEvent)val_5;
            }
            
            val_5 = 0;
            return (com.amazon.device.iap.cpt.SubscriptionExpiredEvent)val_5;
        }
        public static com.amazon.device.iap.cpt.SubscriptionExpiredEvent CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.SubscriptionExpiredEvent)com.amazon.device.iap.cpt.SubscriptionExpiredEvent.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.SubscriptionExpiredEvent> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.SubscriptionExpiredEvent> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.SubscriptionExpiredEvent>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1815116776) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.SubscriptionExpiredEvent.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.SubscriptionExpiredEvent> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.SubscriptionExpiredEvent> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.SubscriptionExpiredEvent>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1814969920) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.SubscriptionExpiredEvent.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public SubscriptionExpiredEvent()
        {
            val_1 = new System.Object();
        }
    
    }

}
