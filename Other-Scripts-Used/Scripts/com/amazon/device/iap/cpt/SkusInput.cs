using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class SkusInput : Jsonable
    {
        // Fields
        private System.Collections.Generic.List<string> <Skus>k__BackingField;
        
        // Properties
        public System.Collections.Generic.List<string> Skus { get; set; }
        
        // Methods
        public System.Collections.Generic.List<string> get_Skus()
        {
            return (System.Collections.Generic.List<System.String>)this.<Skus>k__BackingField;
        }
        public void set_Skus(System.Collections.Generic.List<string> value)
        {
            this.<Skus>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "skus", value:  this.<Skus>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.SkusInput CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_12;
            SkusInput.<>c val_13;
            var val_14;
            System.Func<System.Object, System.String> val_15;
            System.Collections.Generic.IEnumerable<TSource> val_16;
            var val_17;
            if(jsonMap == null)
            {
                goto label_1;
            }
            
            val_12 = new com.amazon.device.iap.cpt.SkusInput();
            val_12 = new System.Object();
            val_13 = "skus";
            if((jsonMap.ContainsKey(key:  "skus")) == false)
            {
                    return (com.amazon.device.iap.cpt.SkusInput)val_12;
            }
            
            val_13 = jsonMap.Item["skus"];
            val_14 = null;
            val_14 = null;
            val_15 = SkusInput.<>c.<>9__6_0;
            if(val_13 != null)
            {
                
            }
            
            val_16 = 0;
            if(val_15 == null)
            {
                goto label_8;
            }
            
            val_16 = 0;
            goto label_17;
            label_1:
            val_12 = 0;
            return (com.amazon.device.iap.cpt.SkusInput)val_12;
            label_8:
            val_17 = null;
            val_17 = null;
            val_13 = SkusInput.<>c.<>9;
            val_15 = null;
            val_15 = new System.Func<System.Object, System.String>(object:  val_13, method:  System.String SkusInput.<>c::<CreateFromDictionary>b__6_0(object element));
            SkusInput.<>c.<>9__6_0 = val_15;
            label_17:
            .<Skus>k__BackingField = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.Object, System.String>(source:  val_16, selector:  null));
            return (com.amazon.device.iap.cpt.SkusInput)val_12;
        }
        public static com.amazon.device.iap.cpt.SkusInput CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.SkusInput)com.amazon.device.iap.cpt.SkusInput.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.SkusInput> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.SkusInput> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.SkusInput>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1816636904) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.SkusInput.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.SkusInput> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.SkusInput> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.SkusInput>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1816490048) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.SkusInput.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public SkusInput()
        {
            val_1 = new System.Object();
        }
    
    }

}
