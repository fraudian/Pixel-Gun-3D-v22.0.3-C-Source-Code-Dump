using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class AdPair : Jsonable
    {
        // Fields
        private static com.amazon.mas.cpt.ads.AmazonLogger logger;
        private com.amazon.mas.cpt.ads.Ad <AdOne>k__BackingField;
        private com.amazon.mas.cpt.ads.Ad <AdTwo>k__BackingField;
        
        // Properties
        public com.amazon.mas.cpt.ads.Ad AdOne { get; set; }
        public com.amazon.mas.cpt.ads.Ad AdTwo { get; set; }
        
        // Methods
        public com.amazon.mas.cpt.ads.Ad get_AdOne()
        {
            return (com.amazon.mas.cpt.ads.Ad)this.<AdOne>k__BackingField;
        }
        public void set_AdOne(com.amazon.mas.cpt.ads.Ad value)
        {
            this.<AdOne>k__BackingField = value;
        }
        public com.amazon.mas.cpt.ads.Ad get_AdTwo()
        {
            return (com.amazon.mas.cpt.ads.Ad)this.<AdTwo>k__BackingField;
        }
        public void set_AdTwo(com.amazon.mas.cpt.ads.Ad value)
        {
            this.<AdTwo>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            object val_2;
            object val_3;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if((this.<AdOne>k__BackingField) == null)
            {
                goto label_1;
            }
            
            val_2 = this.<AdOne>k__BackingField;
            if(null != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_2 = 0;
            if(null != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            null.Add(key:  "adOne", value:  val_2);
            if((this.<AdTwo>k__BackingField) == null)
            {
                goto label_5;
            }
            
            val_3 = this.<AdTwo>k__BackingField;
            if(null != null)
            {
                goto label_8;
            }
            
            goto label_7;
            label_5:
            val_3 = 0;
            if(null != null)
            {
                goto label_8;
            }
            
            label_7:
            label_8:
            null.Add(key:  "adTwo", value:  val_3);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.mas.cpt.ads.AdPair CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_10;
            var val_11;
            var val_12;
            if(jsonMap == null)
            {
                goto label_1;
            }
            
            val_10 = new com.amazon.mas.cpt.ads.AdPair();
            val_10 = new System.Object();
            if((jsonMap.ContainsKey(key:  "adOne")) == false)
            {
                goto label_2;
            }
            
            object val_3 = jsonMap.Item["adOne"];
            val_11 = 0;
            goto label_7;
            label_1:
            val_10 = 0;
            return (com.amazon.mas.cpt.ads.AdPair)val_10;
            label_7:
            .<AdOne>k__BackingField = com.amazon.mas.cpt.ads.Ad.CreateFromDictionary(jsonMap:  null);
            label_2:
            if((jsonMap.ContainsKey(key:  "adTwo")) == false)
            {
                    return (com.amazon.mas.cpt.ads.AdPair)val_10;
            }
            
            object val_7 = jsonMap.Item["adTwo"];
            val_12 = 0;
            .<AdTwo>k__BackingField = com.amazon.mas.cpt.ads.Ad.CreateFromDictionary(jsonMap:  null);
            return (com.amazon.mas.cpt.ads.AdPair)val_10;
        }
        public static com.amazon.mas.cpt.ads.AdPair CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.mas.cpt.ads.AdPair)com.amazon.mas.cpt.ads.AdPair.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.mas.cpt.ads.AdPair> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.AdPair> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.AdPair>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_9:
            if(((-1888431640) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            val_7 = 0;
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.mas.cpt.ads.AdPair.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.mas.cpt.ads.AdPair> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.mas.cpt.ads.AdPair> val_1 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.AdPair>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_9:
            if(((-1888284800) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            val_8 = 0;
            val_1.Add(item:  com.amazon.mas.cpt.ads.AdPair.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public AdPair()
        {
            val_1 = new System.Object();
        }
        private static AdPair()
        {
            .tag = "Pi";
            com.amazon.mas.cpt.ads.AdPair.logger = new com.amazon.mas.cpt.ads.AmazonLogger();
        }
    
    }

}
