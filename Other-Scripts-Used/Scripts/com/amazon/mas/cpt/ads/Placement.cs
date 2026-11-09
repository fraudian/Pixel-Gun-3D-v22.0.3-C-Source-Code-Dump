using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class Placement : Jsonable
    {
        // Fields
        private static com.amazon.mas.cpt.ads.AmazonLogger logger;
        private com.amazon.mas.cpt.ads.Dock <Dock>k__BackingField;
        private com.amazon.mas.cpt.ads.HorizontalAlign <HorizontalAlign>k__BackingField;
        private com.amazon.mas.cpt.ads.AdFit <AdFit>k__BackingField;
        
        // Properties
        public com.amazon.mas.cpt.ads.Dock Dock { get; set; }
        public com.amazon.mas.cpt.ads.HorizontalAlign HorizontalAlign { get; set; }
        public com.amazon.mas.cpt.ads.AdFit AdFit { get; set; }
        
        // Methods
        public com.amazon.mas.cpt.ads.Dock get_Dock()
        {
            return (com.amazon.mas.cpt.ads.Dock)this.<Dock>k__BackingField;
        }
        public void set_Dock(com.amazon.mas.cpt.ads.Dock value)
        {
            this.<Dock>k__BackingField = value;
        }
        public com.amazon.mas.cpt.ads.HorizontalAlign get_HorizontalAlign()
        {
            return (com.amazon.mas.cpt.ads.HorizontalAlign)this.<HorizontalAlign>k__BackingField;
        }
        public void set_HorizontalAlign(com.amazon.mas.cpt.ads.HorizontalAlign value)
        {
            this.<HorizontalAlign>k__BackingField = value;
        }
        public com.amazon.mas.cpt.ads.AdFit get_AdFit()
        {
            return (com.amazon.mas.cpt.ads.AdFit)this.<AdFit>k__BackingField;
        }
        public void set_AdFit(com.amazon.mas.cpt.ads.AdFit value)
        {
            this.<AdFit>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "dock", value:  this.<Dock>k__BackingField);
            null.Add(key:  "horizontalAlign", value:  this.<HorizontalAlign>k__BackingField);
            null.Add(key:  "adFit", value:  this.<AdFit>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.mas.cpt.ads.Placement CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_17;
            string val_18;
            System.Type val_19;
            string val_20;
            string val_21;
            if(jsonMap != null)
            {
                    val_17 = new com.amazon.mas.cpt.ads.Placement();
                val_17 = new System.Object();
                if((jsonMap.ContainsKey(key:  "dock")) != false)
            {
                    val_18 = jsonMap.Item["dock"];
                if((val_18 != null) && (null != null))
            {
                    val_18 = 0;
            }
            
                val_19 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_18);
                .<Dock>k__BackingField = null;
            }
            
                if((jsonMap.ContainsKey(key:  "horizontalAlign")) != false)
            {
                    val_20 = jsonMap.Item["horizontalAlign"];
                if((val_20 != null) && (null != null))
            {
                    val_20 = 0;
            }
            
                val_19 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_20);
                .<HorizontalAlign>k__BackingField = null;
            }
            
                if((jsonMap.ContainsKey(key:  "adFit")) == false)
            {
                    return (com.amazon.mas.cpt.ads.Placement)val_17;
            }
            
                val_19 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                val_21 = jsonMap.Item["adFit"];
                if((val_21 != null) && (null != null))
            {
                    val_21 = 0;
            }
            
                object val_16 = System.Enum.Parse(enumType:  val_19, value:  val_21);
                .<AdFit>k__BackingField = null;
                return (com.amazon.mas.cpt.ads.Placement)val_17;
            }
            
            val_17 = 0;
            return (com.amazon.mas.cpt.ads.Placement)val_17;
        }
        public static com.amazon.mas.cpt.ads.Placement CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.mas.cpt.ads.Placement)com.amazon.mas.cpt.ads.Placement.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.mas.cpt.ads.Placement> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.Placement> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.Placement>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_9:
            if(((-1857852008) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            val_7 = 0;
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.mas.cpt.ads.Placement.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.mas.cpt.ads.Placement> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.mas.cpt.ads.Placement> val_1 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.Placement>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_9:
            if(((-1857705168) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            val_8 = 0;
            val_1.Add(item:  com.amazon.mas.cpt.ads.Placement.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public Placement()
        {
            val_1 = new System.Object();
        }
        private static Placement()
        {
            .tag = "Pi";
            com.amazon.mas.cpt.ads.Placement.logger = new com.amazon.mas.cpt.ads.AmazonLogger();
        }
    
    }

}
