using UnityEngine;

namespace Prime31
{
    public class GoogleIAB
    {
        // Fields
        private static UnityEngine.AndroidJavaObject _plugin;
        
        // Methods
        private static GoogleIAB()
        {
            var val_11;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_2 = null;
            val_11 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.prime31.GoogleIABPlugin");
            Prime31.GoogleIAB._plugin = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "instance", args:  System.Array.Empty<System.Object>());
            if(val_11 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_2.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_11 = ???;
        }
        public static void enableLogging(bool shouldEnable)
        {
            UnityEngine.AndroidJavaObject val_4;
            var val_5;
            val_4 = shouldEnable;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            if(val_4 != false)
            {
                    UnityEngine.Debug.LogWarning(message:  "YOU HAVE ENABLED HIGH DETAIL LOGS. DO NOT DISTRIBUTE THE GENERATED APK PUBLICLY. IT WILL DUMP SENSITIVE INFORMATION TO THE CONSOLE!");
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Prime31.GoogleIAB._plugin;
            object[] val_3 = new object[1];
            val_3[0] = val_4;
            val_4.Call(methodName:  "enableLogging", args:  val_3);
        }
        public static void setAutoVerifySignatures(bool shouldVerify)
        {
            UnityEngine.AndroidJavaObject val_4;
            var val_5;
            val_4 = shouldVerify;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Prime31.GoogleIAB._plugin;
            object[] val_3 = new object[1];
            val_3[0] = val_4;
            val_4.Call(methodName:  "setAutoVerifySignatures", args:  val_3);
        }
        public static void init(string publicKey)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = publicKey;
            Prime31.GoogleIAB._plugin.Call(methodName:  "init", args:  val_2);
        }
        public static void unbindService()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.GoogleIAB._plugin.Call(methodName:  "unbindService", args:  System.Array.Empty<System.Object>());
        }
        public static bool areSubscriptionsSupported()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            if(Prime31.GoogleIAB._plugin != null)
            {
                    return Prime31.GoogleIAB._plugin.Call<System.Boolean>(methodName:  "areSubscriptionsSupported", args:  System.Array.Empty<System.Object>());
            }
            
            return Prime31.GoogleIAB._plugin.Call<System.Boolean>(methodName:  "areSubscriptionsSupported", args:  System.Array.Empty<System.Object>());
        }
        public static void queryInventory(string[] skus)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = skus;
            Prime31.GoogleIAB._plugin.Call(methodName:  "queryInventory", args:  val_2);
        }
        public static System.Collections.Generic.List<Prime31.GooglePurchase> getPurchaseHistory()
        {
            object val_5;
            var val_6;
            var val_7;
            val_6 = 0;
            if(UnityEngine.Application.platform != 11)
            {
                    return (System.Collections.Generic.List<Prime31.GooglePurchase>)Prime31.Json.decode<System.Collections.Generic.List<Prime31.GooglePurchase>>(json:  val_5 = Prime31.GoogleIAB._plugin.Call<System.String>(methodName:  "getPurchaseHistory", args:  System.Array.Empty<System.Object>()), rootElement:  0);
            }
            
            val_7 = null;
            val_7 = null;
            UnityEngine.Debug.Log(message:  val_5);
            return (System.Collections.Generic.List<Prime31.GooglePurchase>)Prime31.Json.decode<System.Collections.Generic.List<Prime31.GooglePurchase>>(json:  val_5, rootElement:  0);
        }
        public static void purchaseProduct(string sku)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = sku;
            Prime31.GoogleIAB._plugin.Call(methodName:  "purchaseProduct", args:  val_2);
        }
        public static void consumeProduct(string sku)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = sku;
            Prime31.GoogleIAB._plugin.Call(methodName:  "consumeProduct", args:  val_2);
        }
        public static void acknowledgePurchase(string sku)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = sku;
            Prime31.GoogleIAB._plugin.Call(methodName:  "acknowledgePurchase", args:  val_2);
        }
        public GoogleIAB()
        {
        
        }
    
    }

}
