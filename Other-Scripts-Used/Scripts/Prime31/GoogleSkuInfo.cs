using UnityEngine;

namespace Prime31
{
    public class GoogleSkuInfo
    {
        // Fields
        private string <title>k__BackingField;
        private string <price>k__BackingField;
        private string <type>k__BackingField;
        private string <description>k__BackingField;
        private string <productId>k__BackingField;
        private string <priceCurrencyCode>k__BackingField;
        private long <priceAmountMicros>k__BackingField;
        
        // Properties
        public string title { get; set; }
        public string price { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string productId { get; set; }
        public string priceCurrencyCode { get; set; }
        public long priceAmountMicros { get; set; }
        
        // Methods
        public string get_title()
        {
            return (string)this.<title>k__BackingField;
        }
        private void set_title(string value)
        {
            this.<title>k__BackingField = value;
        }
        public string get_price()
        {
            return (string)this.<price>k__BackingField;
        }
        private void set_price(string value)
        {
            this.<price>k__BackingField = value;
        }
        public string get_type()
        {
            return (string)this.<type>k__BackingField;
        }
        private void set_type(string value)
        {
            this.<type>k__BackingField = value;
        }
        public string get_description()
        {
            return (string)this.<description>k__BackingField;
        }
        private void set_description(string value)
        {
            this.<description>k__BackingField = value;
        }
        public string get_productId()
        {
            return (string)this.<productId>k__BackingField;
        }
        private void set_productId(string value)
        {
            this.<productId>k__BackingField = value;
        }
        public string get_priceCurrencyCode()
        {
            return (string)this.<priceCurrencyCode>k__BackingField;
        }
        private void set_priceCurrencyCode(string value)
        {
            this.<priceCurrencyCode>k__BackingField = value;
        }
        public long get_priceAmountMicros()
        {
            return (long)this.<priceAmountMicros>k__BackingField;
        }
        private void set_priceAmountMicros(long value)
        {
            this.<priceAmountMicros>k__BackingField = value;
        }
        public static System.Collections.Generic.List<Prime31.GoogleSkuInfo> fromList(System.Collections.Generic.List<object> items)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8;
            System.Collections.Generic.List<Prime31.GoogleSkuInfo> val_1 = new System.Collections.Generic.List<Prime31.GoogleSkuInfo>();
            List.Enumerator<T> val_2 = items.GetEnumerator();
            label_7:
            if(((-1906602752) & 1) == 0)
            {
                goto label_2;
            }
            
            val_8 = val_4.丐丏七丌丕丗业且上();
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            new Prime31.GoogleSkuInfo() = new Prime31.GoogleSkuInfo(dict:  val_8);
            val_1.Add(item:  new Prime31.GoogleSkuInfo());
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return val_1;
        }
        public GoogleSkuInfo(System.Collections.Generic.Dictionary<string, object> dict)
        {
            var val_22;
            string val_23;
            string val_24;
            string val_25;
            string val_26;
            string val_27;
            string val_28;
            val_22 = 1152921516630043280;
            if((dict.ContainsKey(key:  "title")) != false)
            {
                    object val_2 = dict.Item["title"];
                if(val_2 != null)
            {
                    var val_3 = (null == null) ? (val_2) : 0;
            }
            else
            {
                    val_23 = 0;
            }
            
                this.<title>k__BackingField = val_23;
            }
            
            if((dict.ContainsKey(key:  "price")) != false)
            {
                    object val_5 = dict.Item["price"];
                if(val_5 != null)
            {
                    var val_6 = (null == null) ? (val_5) : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
                this.<price>k__BackingField = val_24;
            }
            
            if((dict.ContainsKey(key:  "type")) != false)
            {
                    object val_8 = dict.Item["type"];
                if(val_8 != null)
            {
                    var val_9 = (null == null) ? (val_8) : 0;
            }
            else
            {
                    val_25 = 0;
            }
            
                this.<type>k__BackingField = val_25;
            }
            
            if((dict.ContainsKey(key:  "description")) != false)
            {
                    object val_11 = dict.Item["description"];
                if(val_11 != null)
            {
                    var val_12 = (null == null) ? (val_11) : 0;
            }
            else
            {
                    val_26 = 0;
            }
            
                this.<description>k__BackingField = val_26;
            }
            
            if((dict.ContainsKey(key:  "productId")) != false)
            {
                    object val_14 = dict.Item["productId"];
                if(val_14 != null)
            {
                    var val_15 = (null == null) ? (val_14) : 0;
            }
            else
            {
                    val_27 = 0;
            }
            
                this.<productId>k__BackingField = val_27;
            }
            
            if((dict.ContainsKey(key:  "price_currency_code")) != false)
            {
                    object val_17 = dict.Item["price_currency_code"];
                if(val_17 != null)
            {
                    var val_18 = (null == null) ? (val_17) : 0;
            }
            else
            {
                    val_28 = 0;
            }
            
                this.<priceCurrencyCode>k__BackingField = val_28;
            }
            
            if((dict.ContainsKey(key:  "price_amount_micros")) == false)
            {
                    return;
            }
            
            val_22 = dict.Item["price_amount_micros"];
            if(( & 1) == 0)
            {
                    return;
            }
            
            this.<priceAmountMicros>k__BackingField = ;
        }
        public override string ToString()
        {
            object[] val_1 = new object[6];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<title>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<title>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<title>k__BackingField;
            val_1[1] = this.<price>k__BackingField;
            val_1[2] = this.<type>k__BackingField;
            val_1[3] = this.<description>k__BackingField;
            val_1[4] = this.<productId>k__BackingField;
            val_1[5] = this.<priceCurrencyCode>k__BackingField;
            return System.String.Format(format:  "<GoogleSkuInfo> title: {0}, price: {1}, type: {2}, description: {3}, productId: {4}, priceCurrencyCode: {5}", args:  val_1);
        }
    
    }

}
