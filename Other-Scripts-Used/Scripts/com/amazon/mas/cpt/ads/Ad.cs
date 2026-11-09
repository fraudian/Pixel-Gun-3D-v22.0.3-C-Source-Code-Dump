using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class Ad : Jsonable
    {
        // Fields
        private static com.amazon.mas.cpt.ads.AmazonLogger logger;
        private com.amazon.mas.cpt.ads.AdType <AdType>k__BackingField;
        private long <Identifier>k__BackingField;
        
        // Properties
        public com.amazon.mas.cpt.ads.AdType AdType { get; set; }
        public long Identifier { get; set; }
        
        // Methods
        public com.amazon.mas.cpt.ads.AdType get_AdType()
        {
            return (com.amazon.mas.cpt.ads.AdType)this.<AdType>k__BackingField;
        }
        public void set_AdType(com.amazon.mas.cpt.ads.AdType value)
        {
            this.<AdType>k__BackingField = value;
        }
        public long get_Identifier()
        {
            return (long)this.<Identifier>k__BackingField;
        }
        public void set_Identifier(long value)
        {
            this.<Identifier>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)com.amazon.mas.cpt.ads.json.Json.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "adType", value:  this.<AdType>k__BackingField);
            null.Add(key:  "identifier", value:  this.<Identifier>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.mas.cpt.ads.Ad CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            com.amazon.mas.cpt.ads.Jsonable val_9;
            string val_10;
            if(jsonMap != null)
            {
                    val_9 = new com.amazon.mas.cpt.ads.Ad();
                val_9 = new com.amazon.mas.cpt.ads.Jsonable();
                if((jsonMap.ContainsKey(key:  "adType")) != false)
            {
                    val_10 = jsonMap.Item["adType"];
                if((val_10 != null) && (null != null))
            {
                    val_10 = 0;
            }
            
                object val_6 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_10);
                .<AdType>k__BackingField = null;
            }
            
                if((jsonMap.ContainsKey(key:  "identifier")) == false)
            {
                    return (com.amazon.mas.cpt.ads.Ad)val_9;
            }
            
                object val_8 = jsonMap.Item["identifier"];
                .<Identifier>k__BackingField = null;
                return (com.amazon.mas.cpt.ads.Ad)val_9;
            }
            
            val_9 = 0;
            return (com.amazon.mas.cpt.ads.Ad)val_9;
        }
        public static com.amazon.mas.cpt.ads.Ad CreateFromJson(string jsonMessage)
        {
            var val_3;
            object val_1 = com.amazon.mas.cpt.ads.json.Json.Deserialize(json:  jsonMessage);
            val_3 = 0;
            com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.mas.cpt.ads.Ad)com.amazon.mas.cpt.ads.Ad.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.mas.cpt.ads.Ad> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.Ad> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.Ad>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_9:
            if(((-1892437768) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            val_7 = 0;
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.mas.cpt.ads.Ad.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.mas.cpt.ads.Ad> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.mas.cpt.ads.Ad> val_1 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.Ad>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_9:
            if(((-1892290928) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            val_8 = 0;
            val_1.Add(item:  com.amazon.mas.cpt.ads.Ad.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public Ad()
        {
        
        }
        private static Ad()
        {
            com.amazon.mas.cpt.ads.Ad.logger = new com.amazon.mas.cpt.ads.AmazonLogger(tag:  "Pi");
        }
    
    }

}
