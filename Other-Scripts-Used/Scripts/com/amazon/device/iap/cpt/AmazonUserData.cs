using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class AmazonUserData : Jsonable
    {
        // Fields
        private string <UserId>k__BackingField;
        private string <Marketplace>k__BackingField;
        
        // Properties
        public string UserId { get; set; }
        public string Marketplace { get; set; }
        
        // Methods
        public string get_UserId()
        {
            return (string)this.<UserId>k__BackingField;
        }
        public void set_UserId(string value)
        {
            this.<UserId>k__BackingField = value;
        }
        public string get_Marketplace()
        {
            return (string)this.<Marketplace>k__BackingField;
        }
        public void set_Marketplace(string value)
        {
            this.<Marketplace>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "userId", value:  this.<UserId>k__BackingField);
            null.Add(key:  "marketplace", value:  this.<Marketplace>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.AmazonUserData CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_8;
            string val_9;
            string val_10;
            if(jsonMap != null)
            {
                    val_8 = new com.amazon.device.iap.cpt.AmazonUserData();
                val_8 = new System.Object();
                if((jsonMap.ContainsKey(key:  "userId")) != false)
            {
                    val_9 = jsonMap.Item["userId"];
                if((val_9 != null) && (null != null))
            {
                    val_9 = 0;
            }
            
                .<UserId>k__BackingField = val_9;
            }
            
                if((jsonMap.ContainsKey(key:  "marketplace")) == false)
            {
                    return (com.amazon.device.iap.cpt.AmazonUserData)val_8;
            }
            
                val_10 = jsonMap.Item["marketplace"];
                if((val_10 != null) && (null != null))
            {
                    val_10 = 0;
            }
            
                .<Marketplace>k__BackingField = val_10;
                return (com.amazon.device.iap.cpt.AmazonUserData)val_8;
            }
            
            val_8 = 0;
            return (com.amazon.device.iap.cpt.AmazonUserData)val_8;
        }
        public static com.amazon.device.iap.cpt.AmazonUserData CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.AmazonUserData)com.amazon.device.iap.cpt.AmazonUserData.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.AmazonUserData> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.AmazonUserData> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.AmazonUserData>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1839763192) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.AmazonUserData.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.AmazonUserData> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.AmazonUserData> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.AmazonUserData>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1839616336) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.AmazonUserData.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public AmazonUserData()
        {
            val_1 = new System.Object();
        }
    
    }

}
