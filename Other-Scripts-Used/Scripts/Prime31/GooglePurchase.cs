using UnityEngine;

namespace Prime31
{
    public class GooglePurchase
    {
        // Fields
        private string <packageName>k__BackingField;
        private string <orderId>k__BackingField;
        private string <productId>k__BackingField;
        private string <developerPayload>k__BackingField;
        private string <type>k__BackingField;
        private long <purchaseTime>k__BackingField;
        private Prime31.GooglePurchase.GooglePurchaseState <purchaseState>k__BackingField;
        private string <purchaseToken>k__BackingField;
        private string <signature>k__BackingField;
        private string <originalJson>k__BackingField;
        
        // Properties
        public string packageName { get; set; }
        public string orderId { get; set; }
        public string productId { get; set; }
        public string developerPayload { get; set; }
        public string type { get; set; }
        public long purchaseTime { get; set; }
        public Prime31.GooglePurchase.GooglePurchaseState purchaseState { get; set; }
        public string purchaseToken { get; set; }
        public string signature { get; set; }
        public string originalJson { get; set; }
        
        // Methods
        public string get_packageName()
        {
            return (string)this.<packageName>k__BackingField;
        }
        private void set_packageName(string value)
        {
            this.<packageName>k__BackingField = value;
        }
        public string get_orderId()
        {
            return (string)this.<orderId>k__BackingField;
        }
        private void set_orderId(string value)
        {
            this.<orderId>k__BackingField = value;
        }
        public string get_productId()
        {
            return (string)this.<productId>k__BackingField;
        }
        private void set_productId(string value)
        {
            this.<productId>k__BackingField = value;
        }
        public string get_developerPayload()
        {
            return (string)this.<developerPayload>k__BackingField;
        }
        private void set_developerPayload(string value)
        {
            this.<developerPayload>k__BackingField = value;
        }
        public string get_type()
        {
            return (string)this.<type>k__BackingField;
        }
        private void set_type(string value)
        {
            this.<type>k__BackingField = value;
        }
        public long get_purchaseTime()
        {
            return (long)this.<purchaseTime>k__BackingField;
        }
        private void set_purchaseTime(long value)
        {
            this.<purchaseTime>k__BackingField = value;
        }
        public Prime31.GooglePurchase.GooglePurchaseState get_purchaseState()
        {
            return (GooglePurchaseState)this.<purchaseState>k__BackingField;
        }
        private void set_purchaseState(Prime31.GooglePurchase.GooglePurchaseState value)
        {
            this.<purchaseState>k__BackingField = value;
        }
        public string get_purchaseToken()
        {
            return (string)this.<purchaseToken>k__BackingField;
        }
        private void set_purchaseToken(string value)
        {
            this.<purchaseToken>k__BackingField = value;
        }
        public string get_signature()
        {
            return (string)this.<signature>k__BackingField;
        }
        private void set_signature(string value)
        {
            this.<signature>k__BackingField = value;
        }
        public string get_originalJson()
        {
            return (string)this.<originalJson>k__BackingField;
        }
        private void set_originalJson(string value)
        {
            this.<originalJson>k__BackingField = value;
        }
        public GooglePurchase()
        {
        
        }
        public static System.Collections.Generic.List<Prime31.GooglePurchase> fromList(System.Collections.Generic.List<object> items)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8;
            System.Collections.Generic.List<Prime31.GooglePurchase> val_1 = new System.Collections.Generic.List<Prime31.GooglePurchase>();
            List.Enumerator<T> val_2 = items.GetEnumerator();
            label_7:
            if(((-1908829424) & 1) == 0)
            {
                goto label_2;
            }
            
            val_8 = val_4.丐丏七丌丕丗业且上();
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            new Prime31.GooglePurchase() = new Prime31.GooglePurchase(dict:  val_8);
            val_1.Add(item:  new Prime31.GooglePurchase());
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public GooglePurchase(System.Collections.Generic.Dictionary<string, object> dict)
        {
            string val_24;
            if((dict.ContainsKey(key:  "packageName")) != false)
            {
                    this.<packageName>k__BackingField = dict.Item["packageName"];
            }
            
            if((dict.ContainsKey(key:  "orderId")) != false)
            {
                    this.<orderId>k__BackingField = dict.Item["orderId"];
            }
            
            if((dict.ContainsKey(key:  "productId")) != false)
            {
                    this.<productId>k__BackingField = dict.Item["productId"];
            }
            
            if((dict.ContainsKey(key:  "developerPayload")) != false)
            {
                    this.<developerPayload>k__BackingField = dict.Item["developerPayload"];
            }
            
            if((dict.ContainsKey(key:  "type")) != false)
            {
                    object val_10 = dict.Item["type"];
                if(val_10 != null)
            {
                    var val_11 = (null == null) ? (val_10) : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
                this.<type>k__BackingField = val_24;
            }
            
            if((dict.ContainsKey(key:  "purchaseTime")) != false)
            {
                    this.<purchaseTime>k__BackingField = System.Int64.Parse(s:  dict.Item["purchaseTime"]);
            }
            
            if((dict.ContainsKey(key:  "purchaseState")) != false)
            {
                    this.<purchaseState>k__BackingField = System.Int32.Parse(s:  dict.Item["purchaseState"]);
            }
            
            if((dict.ContainsKey(key:  "purchaseToken")) != false)
            {
                    this.<purchaseToken>k__BackingField = dict.Item["purchaseToken"];
            }
            
            if((dict.ContainsKey(key:  "signature")) != false)
            {
                    this.<signature>k__BackingField = dict.Item["signature"];
            }
            
            if((dict.ContainsKey(key:  "originalJson")) == false)
            {
                    return;
            }
            
            this.<originalJson>k__BackingField = dict.Item["originalJson"];
        }
        public override string ToString()
        {
            object[] val_1 = new object[9];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<packageName>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<packageName>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<packageName>k__BackingField;
            val_1[1] = this.<orderId>k__BackingField;
            val_1[2] = this.<productId>k__BackingField;
            val_1[3] = this.<developerPayload>k__BackingField;
            val_1[4] = this.<purchaseToken>k__BackingField;
            val_1[5] = this.<purchaseState>k__BackingField;
            val_1[6] = this.<signature>k__BackingField;
            val_1[7] = this.<type>k__BackingField;
            val_1[8] = this.<originalJson>k__BackingField;
            return (string)System.String.Format(format:  "<GooglePurchase> packageName: {0}, orderId: {1}, productId: {2}, developerPayload: {3}, purchaseToken: {4}, purchaseState: {5}, signature: {6}, type: {7}, json: {8}", args:  val_1);
        }
    
    }

}
