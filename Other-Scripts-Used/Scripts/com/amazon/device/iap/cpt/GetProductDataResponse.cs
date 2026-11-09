using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class GetProductDataResponse : Jsonable
    {
        // Fields
        private string <RequestId>k__BackingField;
        private System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.ProductData> <ProductDataMap>k__BackingField;
        private System.Collections.Generic.List<string> <UnavailableSkus>k__BackingField;
        private string <Status>k__BackingField;
        
        // Properties
        public string RequestId { get; set; }
        public System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.ProductData> ProductDataMap { get; set; }
        public System.Collections.Generic.List<string> UnavailableSkus { get; set; }
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
        public System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.ProductData> get_ProductDataMap()
        {
            return (System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.ProductData>)this.<ProductDataMap>k__BackingField;
        }
        public void set_ProductDataMap(System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.ProductData> value)
        {
            this.<ProductDataMap>k__BackingField = value;
        }
        public System.Collections.Generic.List<string> get_UnavailableSkus()
        {
            return (System.Collections.Generic.List<System.String>)this.<UnavailableSkus>k__BackingField;
        }
        public void set_UnavailableSkus(System.Collections.Generic.List<string> value)
        {
            this.<UnavailableSkus>k__BackingField = value;
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
            object val_3;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "requestId", value:  this.<RequestId>k__BackingField);
            if((this.<ProductDataMap>k__BackingField) == null)
            {
                goto label_2;
            }
            
            val_3 = com.amazon.device.iap.cpt.Jsonable.unrollObjectIntoMap<com.amazon.device.iap.cpt.ProductData>(obj:  this.<ProductDataMap>k__BackingField);
            if(null != null)
            {
                goto label_5;
            }
            
            goto label_4;
            label_2:
            val_3 = 0;
            if(null != null)
            {
                goto label_5;
            }
            
            label_4:
            label_5:
            null.Add(key:  "productDataMap", value:  val_3);
            null.Add(key:  "unavailableSkus", value:  this.<UnavailableSkus>k__BackingField);
            null.Add(key:  "status", value:  this.<Status>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.GetProductDataResponse CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_22;
            string val_23;
            var val_24;
            var val_25;
            System.Func<System.Object, System.String> val_26;
            System.Collections.Generic.IEnumerable<TSource> val_27;
            var val_28;
            string val_29;
            if(jsonMap == null)
            {
                goto label_1;
            }
            
            val_22 = new com.amazon.device.iap.cpt.GetProductDataResponse();
            val_22 = new System.Object();
            if((jsonMap.ContainsKey(key:  "requestId")) != false)
            {
                    val_23 = jsonMap.Item["requestId"];
                if((val_23 != null) && (null != null))
            {
                    val_23 = 0;
            }
            
                .<RequestId>k__BackingField = val_23;
            }
            
            if((jsonMap.ContainsKey(key:  "productDataMap")) == false)
            {
                goto label_6;
            }
            
            if(jsonMap.Item["productDataMap"] == null)
            {
                goto label_9;
            }
            
            val_24 = 0;
            goto label_9;
            label_1:
            val_22 = 0;
            return (com.amazon.device.iap.cpt.GetProductDataResponse)val_22;
            label_9:
            .<ProductDataMap>k__BackingField = com.amazon.device.iap.cpt.ProductData.MapFromJson(jsonMap:  null);
            label_6:
            if((jsonMap.ContainsKey(key:  "unavailableSkus")) != false)
            {
                    object val_10 = jsonMap.Item["unavailableSkus"];
                val_25 = null;
                val_25 = null;
                val_26 = GetProductDataResponse.<>c.<>9__18_0;
                val_27 = 0;
                if(val_26 != null)
            {
                    val_27 = 0;
            }
            else
            {
                    val_28 = null;
                val_28 = null;
                val_26 = null;
                val_26 = new System.Func<System.Object, System.String>(object:  GetProductDataResponse.<>c.<>9, method:  System.String GetProductDataResponse.<>c::<CreateFromDictionary>b__18_0(object element));
                GetProductDataResponse.<>c.<>9__18_0 = val_26;
            }
            
                .<UnavailableSkus>k__BackingField = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.Object, System.String>(source:  val_27, selector:  null));
            }
            
            if((jsonMap.ContainsKey(key:  "status")) == false)
            {
                    return (com.amazon.device.iap.cpt.GetProductDataResponse)val_22;
            }
            
            val_29 = jsonMap.Item["status"];
            if((val_29 != null) && (null != null))
            {
                    val_29 = 0;
            }
            
            .<Status>k__BackingField = val_29;
            return (com.amazon.device.iap.cpt.GetProductDataResponse)val_22;
        }
        public static com.amazon.device.iap.cpt.GetProductDataResponse CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.GetProductDataResponse)com.amazon.device.iap.cpt.GetProductDataResponse.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.GetProductDataResponse> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.GetProductDataResponse> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.GetProductDataResponse>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1837772440) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.GetProductDataResponse.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.GetProductDataResponse> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.GetProductDataResponse> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.GetProductDataResponse>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1837625584) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.GetProductDataResponse.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public GetProductDataResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
