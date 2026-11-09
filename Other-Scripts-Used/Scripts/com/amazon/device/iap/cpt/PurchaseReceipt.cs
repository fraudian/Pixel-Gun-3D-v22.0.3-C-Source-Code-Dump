using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class PurchaseReceipt : Jsonable
    {
        // Fields
        private string <ReceiptId>k__BackingField;
        private long <CancelDate>k__BackingField;
        private long <PurchaseDate>k__BackingField;
        private string <Sku>k__BackingField;
        private string <ProductType>k__BackingField;
        
        // Properties
        public string ReceiptId { get; set; }
        public long CancelDate { get; set; }
        public long PurchaseDate { get; set; }
        public string Sku { get; set; }
        public string ProductType { get; set; }
        
        // Methods
        public string get_ReceiptId()
        {
            return (string)this.<ReceiptId>k__BackingField;
        }
        public void set_ReceiptId(string value)
        {
            this.<ReceiptId>k__BackingField = value;
        }
        public long get_CancelDate()
        {
            return (long)this.<CancelDate>k__BackingField;
        }
        public void set_CancelDate(long value)
        {
            this.<CancelDate>k__BackingField = value;
        }
        public long get_PurchaseDate()
        {
            return (long)this.<PurchaseDate>k__BackingField;
        }
        public void set_PurchaseDate(long value)
        {
            this.<PurchaseDate>k__BackingField = value;
        }
        public string get_Sku()
        {
            return (string)this.<Sku>k__BackingField;
        }
        public void set_Sku(string value)
        {
            this.<Sku>k__BackingField = value;
        }
        public string get_ProductType()
        {
            return (string)this.<ProductType>k__BackingField;
        }
        public void set_ProductType(string value)
        {
            this.<ProductType>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "receiptId", value:  this.<ReceiptId>k__BackingField);
            null.Add(key:  "cancelDate", value:  this.<CancelDate>k__BackingField);
            null.Add(key:  "purchaseDate", value:  this.<PurchaseDate>k__BackingField);
            null.Add(key:  "sku", value:  this.<Sku>k__BackingField);
            null.Add(key:  "productType", value:  this.<ProductType>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.PurchaseReceipt CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_15;
            string val_16;
            string val_17;
            string val_18;
            if(jsonMap != null)
            {
                    val_15 = new com.amazon.device.iap.cpt.PurchaseReceipt();
                val_15 = new System.Object();
                if((jsonMap.ContainsKey(key:  "receiptId")) != false)
            {
                    val_16 = jsonMap.Item["receiptId"];
                if((val_16 != null) && (null != null))
            {
                    val_16 = 0;
            }
            
                .<ReceiptId>k__BackingField = val_16;
            }
            
                if((jsonMap.ContainsKey(key:  "cancelDate")) != false)
            {
                    object val_6 = jsonMap.Item["cancelDate"];
                .<CancelDate>k__BackingField = null;
            }
            
                if((jsonMap.ContainsKey(key:  "purchaseDate")) != false)
            {
                    object val_8 = jsonMap.Item["purchaseDate"];
                .<PurchaseDate>k__BackingField = null;
            }
            
                if((jsonMap.ContainsKey(key:  "sku")) != false)
            {
                    val_17 = jsonMap.Item["sku"];
                if((val_17 != null) && (null != null))
            {
                    val_17 = 0;
            }
            
                .<Sku>k__BackingField = val_17;
            }
            
                if((jsonMap.ContainsKey(key:  "productType")) == false)
            {
                    return (com.amazon.device.iap.cpt.PurchaseReceipt)val_15;
            }
            
                val_18 = jsonMap.Item["productType"];
                if((val_18 != null) && (null != null))
            {
                    val_18 = 0;
            }
            
                .<ProductType>k__BackingField = val_18;
                return (com.amazon.device.iap.cpt.PurchaseReceipt)val_15;
            }
            
            val_15 = 0;
            return (com.amazon.device.iap.cpt.PurchaseReceipt)val_15;
        }
        public static com.amazon.device.iap.cpt.PurchaseReceipt CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.PurchaseReceipt)com.amazon.device.iap.cpt.PurchaseReceipt.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.PurchaseReceipt> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.PurchaseReceipt> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.PurchaseReceipt>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1823769816) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.PurchaseReceipt.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.PurchaseReceipt>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1823622960) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.PurchaseReceipt.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public PurchaseReceipt()
        {
            val_1 = new System.Object();
        }
    
    }

}
