using UnityEngine;

namespace Prime31
{
    public class GoogleIABManager : AbstractManager
    {
        // Fields
        private static System.Action billingSupportedEvent;
        private static System.Action<string> billingNotSupportedEvent;
        private static System.Action<System.Collections.Generic.List<Prime31.GooglePurchase>, System.Collections.Generic.List<Prime31.GoogleSkuInfo>> queryInventorySucceededEvent;
        private static System.Action<string> queryInventoryFailedEvent;
        private static System.Action<Prime31.GooglePurchase> purchaseSucceededEvent;
        private static System.Action<string, int> purchaseFailedEvent;
        private static System.Action<Prime31.GooglePurchase> consumePurchaseSucceededEvent;
        private static System.Action<string> consumePurchaseFailedEvent;
        private static System.Action<Prime31.GooglePurchase> acknowledgePurchaseSucceededEvent;
        private static System.Action<string> acknowledgePurchaseFailedEvent;
        
        // Methods
        public static void add_billingSupportedEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.billingSupportedEvent, b:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        public static void remove_billingSupportedEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.billingSupportedEvent, value:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        public static void add_billingNotSupportedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.billingNotSupportedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.billingNotSupportedEvent != 1152921505022824456);
        
        }
        public static void remove_billingNotSupportedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.billingNotSupportedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.billingNotSupportedEvent != 1152921505022824456);
        
        }
        public static void add_queryInventorySucceededEvent(System.Action<System.Collections.Generic.List<Prime31.GooglePurchase>, System.Collections.Generic.List<Prime31.GoogleSkuInfo>> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.queryInventorySucceededEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.queryInventorySucceededEvent != 1152921505022824464);
        
        }
        public static void remove_queryInventorySucceededEvent(System.Action<System.Collections.Generic.List<Prime31.GooglePurchase>, System.Collections.Generic.List<Prime31.GoogleSkuInfo>> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.queryInventorySucceededEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.queryInventorySucceededEvent != 1152921505022824464);
        
        }
        public static void add_queryInventoryFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.queryInventoryFailedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.queryInventoryFailedEvent != 1152921505022824472);
        
        }
        public static void remove_queryInventoryFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.queryInventoryFailedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.queryInventoryFailedEvent != 1152921505022824472);
        
        }
        public static void add_purchaseSucceededEvent(System.Action<Prime31.GooglePurchase> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.purchaseSucceededEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.purchaseSucceededEvent != 1152921505022824480);
        
        }
        public static void remove_purchaseSucceededEvent(System.Action<Prime31.GooglePurchase> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.purchaseSucceededEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.purchaseSucceededEvent != 1152921505022824480);
        
        }
        public static void add_purchaseFailedEvent(System.Action<string, int> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.purchaseFailedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.purchaseFailedEvent != 1152921505022824488);
        
        }
        public static void remove_purchaseFailedEvent(System.Action<string, int> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.purchaseFailedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.purchaseFailedEvent != 1152921505022824488);
        
        }
        public static void add_consumePurchaseSucceededEvent(System.Action<Prime31.GooglePurchase> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.consumePurchaseSucceededEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.consumePurchaseSucceededEvent != 1152921505022824496);
        
        }
        public static void remove_consumePurchaseSucceededEvent(System.Action<Prime31.GooglePurchase> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.consumePurchaseSucceededEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.consumePurchaseSucceededEvent != 1152921505022824496);
        
        }
        public static void add_consumePurchaseFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.consumePurchaseFailedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.consumePurchaseFailedEvent != 1152921505022824504);
        
        }
        public static void remove_consumePurchaseFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.consumePurchaseFailedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.consumePurchaseFailedEvent != 1152921505022824504);
        
        }
        public static void add_acknowledgePurchaseSucceededEvent(System.Action<Prime31.GooglePurchase> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.acknowledgePurchaseSucceededEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.acknowledgePurchaseSucceededEvent != 1152921505022824512);
        
        }
        public static void remove_acknowledgePurchaseSucceededEvent(System.Action<Prime31.GooglePurchase> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.acknowledgePurchaseSucceededEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.acknowledgePurchaseSucceededEvent != 1152921505022824512);
        
        }
        public static void add_acknowledgePurchaseFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.GoogleIABManager.acknowledgePurchaseFailedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.acknowledgePurchaseFailedEvent != 1152921505022824520);
        
        }
        public static void remove_acknowledgePurchaseFailedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.GoogleIABManager.acknowledgePurchaseFailedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.GoogleIABManager.acknowledgePurchaseFailedEvent != 1152921505022824520);
        
        }
        private static GoogleIABManager()
        {
            Prime31.AbstractManager.initialize(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public void billingSupported(string empty)
        {
            null = null;
            Prime31.ActionExtensions.fire(handler:  Prime31.GoogleIABManager.billingSupportedEvent);
        }
        public void billingNotSupported(string error)
        {
            null = null;
            Prime31.ActionExtensions.fire<System.String>(handler:  Prime31.GoogleIABManager.billingNotSupportedEvent, param:  error);
        }
        public void queryInventorySucceeded(string json)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = null;
            val_8 = null;
            if(Prime31.GoogleIABManager.queryInventorySucceededEvent == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = Prime31.JsonExtensions.dictionaryFromJson(json:  json);
            val_9 = null;
            val_9 = null;
            if(val_1.Item["purchases"] != null)
            {
                    val_10 = 0;
            }
            
            if(val_1.Item["skus"] != null)
            {
                    val_11 = 0;
            }
            
            Prime31.GoogleIABManager.queryInventorySucceededEvent.Invoke(arg1:  Prime31.GooglePurchase.fromList(items:  null), arg2:  Prime31.GoogleSkuInfo.fromList(items:  null));
        }
        public void queryInventoryFailed(string error)
        {
            null = null;
            Prime31.ActionExtensions.fire<System.String>(handler:  Prime31.GoogleIABManager.queryInventoryFailedEvent, param:  error);
        }
        public void purchaseSucceeded(string json)
        {
            null = null;
            Prime31.ActionExtensions.fire<Prime31.GooglePurchase>(handler:  Prime31.GoogleIABManager.purchaseSucceededEvent, param:  new Prime31.GooglePurchase(dict:  Prime31.JsonExtensions.dictionaryFromJson(json:  json)));
        }
        public void purchaseFailed(string json)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if(Prime31.GoogleIABManager.purchaseFailedEvent == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = Prime31.Json.decode<System.Collections.Generic.Dictionary<System.String, System.Object>>(json:  json, rootElement:  0);
            val_6 = null;
            val_6 = null;
            Prime31.GoogleIABManager.purchaseFailedEvent.Invoke(arg1:  val_1.Item["result"], arg2:  System.Int32.Parse(s:  val_1.Item["response"]));
        }
        public void consumePurchaseSucceeded(string json)
        {
            var val_3 = null;
            if(Prime31.GoogleIABManager.consumePurchaseSucceededEvent == null)
            {
                    return;
            }
            
            Prime31.ActionExtensions.fire<Prime31.GooglePurchase>(handler:  Prime31.GoogleIABManager.consumePurchaseSucceededEvent, param:  new Prime31.GooglePurchase(dict:  Prime31.JsonExtensions.dictionaryFromJson(json:  json)));
        }
        public void consumePurchaseFailed(string error)
        {
            null = null;
            Prime31.ActionExtensions.fire<System.String>(handler:  Prime31.GoogleIABManager.consumePurchaseFailedEvent, param:  error);
        }
        public void acknowledgePurchaseSucceeded(string json)
        {
            var val_3 = null;
            if(Prime31.GoogleIABManager.acknowledgePurchaseSucceededEvent == null)
            {
                    return;
            }
            
            Prime31.ActionExtensions.fire<Prime31.GooglePurchase>(handler:  Prime31.GoogleIABManager.acknowledgePurchaseSucceededEvent, param:  new Prime31.GooglePurchase(dict:  Prime31.JsonExtensions.dictionaryFromJson(json:  json)));
        }
        public void acknowledgePurchaseFailed(string error)
        {
            null = null;
            Prime31.ActionExtensions.fire<System.String>(handler:  Prime31.GoogleIABManager.acknowledgePurchaseFailedEvent, param:  error);
        }
        public GoogleIABManager()
        {
        
        }
    
    }

}
