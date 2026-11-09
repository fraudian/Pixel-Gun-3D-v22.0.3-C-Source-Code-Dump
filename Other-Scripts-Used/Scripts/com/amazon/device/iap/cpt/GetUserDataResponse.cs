using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class GetUserDataResponse : Jsonable
    {
        // Fields
        private string <RequestId>k__BackingField;
        private com.amazon.device.iap.cpt.AmazonUserData <AmazonUserData>k__BackingField;
        private string <Status>k__BackingField;
        
        // Properties
        public string RequestId { get; set; }
        public com.amazon.device.iap.cpt.AmazonUserData AmazonUserData { get; set; }
        public string Status { get; set; }
        
        // Methods
        public string get_RequestId()
        {
            return (string)this.<RequestId>k__BackingField;
        }
        public void set_RequestId(string value)
        {
            this.<RequestId>k__BackingField = value;
        }
        public com.amazon.device.iap.cpt.AmazonUserData get_AmazonUserData()
        {
            return (com.amazon.device.iap.cpt.AmazonUserData)this.<AmazonUserData>k__BackingField;
        }
        public void set_AmazonUserData(com.amazon.device.iap.cpt.AmazonUserData value)
        {
            this.<AmazonUserData>k__BackingField = value;
        }
        public string get_Status()
        {
            return (string)this.<Status>k__BackingField;
        }
        public void set_Status(string value)
        {
            this.<Status>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            object val_2;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "requestId", value:  this.<RequestId>k__BackingField);
            if((this.<AmazonUserData>k__BackingField) == null)
            {
                goto label_2;
            }
            
            val_2 = this.<AmazonUserData>k__BackingField;
            if(null != null)
            {
                goto label_5;
            }
            
            goto label_4;
            label_2:
            val_2 = 0;
            if(null != null)
            {
                goto label_5;
            }
            
            label_4:
            label_5:
            null.Add(key:  "amazonUserData", value:  val_2);
            null.Add(key:  "status", value:  this.<Status>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.GetUserDataResponse CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_12;
            string val_13;
            var val_14;
            string val_15;
            if(jsonMap == null)
            {
                goto label_1;
            }
            
            val_12 = new com.amazon.device.iap.cpt.GetUserDataResponse();
            val_12 = new System.Object();
            if((jsonMap.ContainsKey(key:  "requestId")) != false)
            {
                    val_13 = jsonMap.Item["requestId"];
                if((val_13 != null) && (null != null))
            {
                    val_13 = 0;
            }
            
                .<RequestId>k__BackingField = val_13;
            }
            
            if((jsonMap.ContainsKey(key:  "amazonUserData")) == false)
            {
                goto label_6;
            }
            
            if(jsonMap.Item["amazonUserData"] == null)
            {
                goto label_9;
            }
            
            val_14 = 0;
            goto label_9;
            label_1:
            val_12 = 0;
            return (com.amazon.device.iap.cpt.GetUserDataResponse)val_12;
            label_9:
            .<AmazonUserData>k__BackingField = com.amazon.device.iap.cpt.AmazonUserData.CreateFromDictionary(jsonMap:  null);
            label_6:
            if((jsonMap.ContainsKey(key:  "status")) == false)
            {
                    return (com.amazon.device.iap.cpt.GetUserDataResponse)val_12;
            }
            
            val_15 = jsonMap.Item["status"];
            if((val_15 != null) && (null != null))
            {
                    val_15 = 0;
            }
            
            .<Status>k__BackingField = val_15;
            return (com.amazon.device.iap.cpt.GetUserDataResponse)val_12;
        }
        public static com.amazon.device.iap.cpt.GetUserDataResponse CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.GetUserDataResponse)com.amazon.device.iap.cpt.GetUserDataResponse.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.GetUserDataResponse> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.GetUserDataResponse> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.GetUserDataResponse>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1832548344) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.GetUserDataResponse.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.GetUserDataResponse> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.GetUserDataResponse> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.GetUserDataResponse>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1832401488) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.GetUserDataResponse.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public GetUserDataResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
