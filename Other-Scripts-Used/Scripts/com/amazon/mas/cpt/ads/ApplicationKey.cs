using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class ApplicationKey : Jsonable
    {
        // Fields
        private static com.amazon.mas.cpt.ads.AmazonLogger logger;
        private string <StringValue>k__BackingField;
        
        // Properties
        public string StringValue { get; set; }
        
        // Methods
        public string get_StringValue()
        {
            return (string)this.<StringValue>k__BackingField;
        }
        public void set_StringValue(string value)
        {
            this.<StringValue>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "stringValue", value:  this.<StringValue>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.mas.cpt.ads.ApplicationKey CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_5;
            string val_6;
            if(jsonMap != null)
            {
                    val_5 = new com.amazon.mas.cpt.ads.ApplicationKey();
                val_5 = new System.Object();
                if((jsonMap.ContainsKey(key:  "stringValue")) == false)
            {
                    return (com.amazon.mas.cpt.ads.ApplicationKey)val_5;
            }
            
                val_6 = jsonMap.Item["stringValue"];
                if((val_6 != null) && (null != null))
            {
                    val_6 = 0;
            }
            
                .<StringValue>k__BackingField = val_6;
                return (com.amazon.mas.cpt.ads.ApplicationKey)val_5;
            }
            
            val_5 = 0;
            return (com.amazon.mas.cpt.ads.ApplicationKey)val_5;
        }
        public static com.amazon.mas.cpt.ads.ApplicationKey CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.mas.cpt.ads.ApplicationKey)com.amazon.mas.cpt.ads.ApplicationKey.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.mas.cpt.ads.ApplicationKey> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.ApplicationKey> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.ApplicationKey>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_9:
            if(((-1866918264) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            val_7 = 0;
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.mas.cpt.ads.ApplicationKey.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.mas.cpt.ads.ApplicationKey> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.mas.cpt.ads.ApplicationKey> val_1 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.ApplicationKey>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_9:
            if(((-1866771424) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            val_8 = 0;
            val_1.Add(item:  com.amazon.mas.cpt.ads.ApplicationKey.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public ApplicationKey()
        {
            val_1 = new System.Object();
        }
        private static ApplicationKey()
        {
            .tag = "Pi";
            com.amazon.mas.cpt.ads.ApplicationKey.logger = new com.amazon.mas.cpt.ads.AmazonLogger();
        }
    
    }

}
