using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class GetPurchaseUpdatesResponse : Jsonable
    {
        // Fields
        private string <RequestId>k__BackingField;
        private com.amazon.device.iap.cpt.AmazonUserData <AmazonUserData>k__BackingField;
        private System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt> <Receipts>k__BackingField;
        private string <Status>k__BackingField;
        private bool <HasMore>k__BackingField;
        
        // Properties
        public string RequestId { get; set; }
        public com.amazon.device.iap.cpt.AmazonUserData AmazonUserData { get; set; }
        public System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt> Receipts { get; set; }
        public string Status { get; set; }
        public bool HasMore { get; set; }
        
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
        public System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt> get_Receipts()
        {
            return (System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt>)this.<Receipts>k__BackingField;
        }
        public void set_Receipts(System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt> value)
        {
            this.<Receipts>k__BackingField = value;
        }
        public string get_Status()
        {
            return (string)this.<Status>k__BackingField;
        }
        public void set_Status(string value)
        {
            this.<Status>k__BackingField = value;
        }
        public bool get_HasMore()
        {
            return (bool)this.<HasMore>k__BackingField;
        }
        public void set_HasMore(bool value)
        {
            this.<HasMore>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            object val_3;
            object val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "requestId", value:  this.<RequestId>k__BackingField);
            if((this.<AmazonUserData>k__BackingField) == null)
            {
                goto label_2;
            }
            
            val_3 = this.<AmazonUserData>k__BackingField;
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
            null.Add(key:  "amazonUserData", value:  val_3);
            if((this.<Receipts>k__BackingField) == null)
            {
                goto label_6;
            }
            
            val_4 = com.amazon.device.iap.cpt.Jsonable.unrollObjectIntoList<com.amazon.device.iap.cpt.PurchaseReceipt>(obj:  this.<Receipts>k__BackingField);
            if(null != null)
            {
                goto label_9;
            }
            
            goto label_8;
            label_6:
            val_4 = 0;
            if(null != null)
            {
                goto label_9;
            }
            
            label_8:
            label_9:
            null.Add(key:  "receipts", value:  val_4);
            null.Add(key:  "status", value:  this.<Status>k__BackingField);
            null.Add(key:  "hasMore", value:  this.<HasMore>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_18;
            string val_19;
            var val_20;
            var val_21;
            string val_22;
            if(jsonMap == null)
            {
                goto label_1;
            }
            
            val_18 = new com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse();
            val_18 = new System.Object();
            if((jsonMap.ContainsKey(key:  "requestId")) != false)
            {
                    val_19 = jsonMap.Item["requestId"];
                if((val_19 != null) && (null != null))
            {
                    val_19 = 0;
            }
            
                .<RequestId>k__BackingField = val_19;
            }
            
            if((jsonMap.ContainsKey(key:  "amazonUserData")) == false)
            {
                goto label_6;
            }
            
            if(jsonMap.Item["amazonUserData"] == null)
            {
                goto label_9;
            }
            
            val_20 = 0;
            goto label_9;
            label_1:
            val_18 = 0;
            return (com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse)val_18;
            label_9:
            .<AmazonUserData>k__BackingField = com.amazon.device.iap.cpt.AmazonUserData.CreateFromDictionary(jsonMap:  null);
            label_6:
            if((jsonMap.ContainsKey(key:  "receipts")) != false)
            {
                    if(jsonMap.Item["receipts"] != null)
            {
                    val_21 = 0;
            }
            
                .<Receipts>k__BackingField = com.amazon.device.iap.cpt.PurchaseReceipt.ListFromJson(array:  null);
            }
            
            if((jsonMap.ContainsKey(key:  "status")) != false)
            {
                    val_22 = jsonMap.Item["status"];
                if((val_22 != null) && (null != null))
            {
                    val_22 = 0;
            }
            
                .<Status>k__BackingField = val_22;
            }
            
            if((jsonMap.ContainsKey(key:  "hasMore")) == false)
            {
                    return (com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse)val_18;
            }
            
            object val_17 = jsonMap.Item["hasMore"];
            .<HasMore>k__BackingField = null;
            return (com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse)val_18;
        }
        public static com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse)com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1834726776) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1834579920) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public GetPurchaseUpdatesResponse()
        {
            val_1 = new System.Object();
        }
    
    }

}
