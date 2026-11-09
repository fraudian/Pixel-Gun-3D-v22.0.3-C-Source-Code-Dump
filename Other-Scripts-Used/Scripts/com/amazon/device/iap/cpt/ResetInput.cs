using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class ResetInput : Jsonable
    {
        // Fields
        private bool <Reset>k__BackingField;
        
        // Properties
        public bool Reset { get; set; }
        
        // Methods
        public bool get_Reset()
        {
            return (bool)this.<Reset>k__BackingField;
        }
        public void set_Reset(bool value)
        {
            this.<Reset>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "reset", value:  this.<Reset>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.ResetInput CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_4;
            if(jsonMap != null)
            {
                    val_4 = new com.amazon.device.iap.cpt.ResetInput();
                val_4 = new System.Object();
                if((jsonMap.ContainsKey(key:  "reset")) == false)
            {
                    return (com.amazon.device.iap.cpt.ResetInput)val_4;
            }
            
                object val_3 = jsonMap.Item["reset"];
                .<Reset>k__BackingField = null;
                return (com.amazon.device.iap.cpt.ResetInput)val_4;
            }
            
            val_4 = 0;
            return (com.amazon.device.iap.cpt.ResetInput)val_4;
        }
        public static com.amazon.device.iap.cpt.ResetInput CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.ResetInput)com.amazon.device.iap.cpt.ResetInput.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.ResetInput> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.ResetInput> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.ResetInput>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1819007208) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.ResetInput.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.ResetInput> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.ResetInput> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.ResetInput>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1818860352) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.ResetInput.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public ResetInput()
        {
            val_1 = new System.Object();
        }
    
    }

}
