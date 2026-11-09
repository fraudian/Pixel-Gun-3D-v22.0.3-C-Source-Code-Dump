using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class ProductData : Jsonable
    {
        // Fields
        private string <Sku>k__BackingField;
        private string <ProductType>k__BackingField;
        private string <Price>k__BackingField;
        private string <Title>k__BackingField;
        private string <Description>k__BackingField;
        private string <SmallIconUrl>k__BackingField;
        
        // Properties
        public string Sku { get; set; }
        public string ProductType { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SmallIconUrl { get; set; }
        
        // Methods
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
        public string get_Price()
        {
            return (string)this.<Price>k__BackingField;
        }
        public void set_Price(string value)
        {
            this.<Price>k__BackingField = value;
        }
        public string get_Title()
        {
            return (string)this.<Title>k__BackingField;
        }
        public void set_Title(string value)
        {
            this.<Title>k__BackingField = value;
        }
        public string get_Description()
        {
            return (string)this.<Description>k__BackingField;
        }
        public void set_Description(string value)
        {
            this.<Description>k__BackingField = value;
        }
        public string get_SmallIconUrl()
        {
            return (string)this.<SmallIconUrl>k__BackingField;
        }
        public void set_SmallIconUrl(string value)
        {
            this.<SmallIconUrl>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "sku", value:  this.<Sku>k__BackingField);
            null.Add(key:  "productType", value:  this.<ProductType>k__BackingField);
            null.Add(key:  "price", value:  this.<Price>k__BackingField);
            null.Add(key:  "title", value:  this.<Title>k__BackingField);
            null.Add(key:  "description", value:  this.<Description>k__BackingField);
            null.Add(key:  "smallIconUrl", value:  this.<SmallIconUrl>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.device.iap.cpt.ProductData CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_20;
            string val_21;
            string val_22;
            string val_23;
            string val_24;
            string val_25;
            string val_26;
            if(jsonMap != null)
            {
                    val_20 = new com.amazon.device.iap.cpt.ProductData();
                val_20 = new System.Object();
                if((jsonMap.ContainsKey(key:  "sku")) != false)
            {
                    val_21 = jsonMap.Item["sku"];
                if((val_21 != null) && (null != null))
            {
                    val_21 = 0;
            }
            
                .<Sku>k__BackingField = val_21;
            }
            
                if((jsonMap.ContainsKey(key:  "productType")) != false)
            {
                    val_22 = jsonMap.Item["productType"];
                if((val_22 != null) && (null != null))
            {
                    val_22 = 0;
            }
            
                .<ProductType>k__BackingField = val_22;
            }
            
                if((jsonMap.ContainsKey(key:  "price")) != false)
            {
                    val_23 = jsonMap.Item["price"];
                if((val_23 != null) && (null != null))
            {
                    val_23 = 0;
            }
            
                .<Price>k__BackingField = val_23;
            }
            
                if((jsonMap.ContainsKey(key:  "title")) != false)
            {
                    val_24 = jsonMap.Item["title"];
                if((val_24 != null) && (null != null))
            {
                    val_24 = 0;
            }
            
                .<Title>k__BackingField = val_24;
            }
            
                if((jsonMap.ContainsKey(key:  "description")) != false)
            {
                    val_25 = jsonMap.Item["description"];
                if((val_25 != null) && (null != null))
            {
                    val_25 = 0;
            }
            
                .<Description>k__BackingField = val_25;
            }
            
                if((jsonMap.ContainsKey(key:  "smallIconUrl")) == false)
            {
                    return (com.amazon.device.iap.cpt.ProductData)val_20;
            }
            
                val_26 = jsonMap.Item["smallIconUrl"];
                if((val_26 != null) && (null != null))
            {
                    val_26 = 0;
            }
            
                .<SmallIconUrl>k__BackingField = val_26;
                return (com.amazon.device.iap.cpt.ProductData)val_20;
            }
            
            val_20 = 0;
            return (com.amazon.device.iap.cpt.ProductData)val_20;
        }
        public static com.amazon.device.iap.cpt.ProductData CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.device.iap.cpt.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.device.iap.cpt.ProductData)com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.device.iap.cpt.ProductData> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.ProductData> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.device.iap.cpt.ProductData>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_7:
            if(((-1825932056) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj != 0)
            {
                    val_7 = 0;
            }
            
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.device.iap.cpt.ProductData> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.device.iap.cpt.ProductData> val_1 = new System.Collections.Generic.List<com.amazon.device.iap.cpt.ProductData>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_7:
            if(((-1825785200) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4.丐丏七丌丕丗业且上() != null)
            {
                    val_8 = 0;
            }
            
            val_1.Add(item:  com.amazon.device.iap.cpt.ProductData.CreateFromDictionary(jsonMap:  null));
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public ProductData()
        {
            val_1 = new System.Object();
        }
    
    }

}
