using UnityEngine;

namespace Prime31
{
    public class TwitterAndroid
    {
        // Fields
        private static UnityEngine.AndroidJavaObject _plugin;
        
        // Methods
        private static TwitterAndroid()
        {
            var val_11;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_2 = null;
            val_11 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.prime31.TwitterPlugin");
            Prime31.TwitterAndroid._plugin = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "instance", args:  System.Array.Empty<System.Object>());
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
        public static void init(string consumerKey, string consumerSecret, string callbackUrlScheme = "twitterplugin")
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[3];
            val_2[0] = consumerKey;
            val_2[1] = consumerSecret;
            val_2[2] = callbackUrlScheme;
            Prime31.TwitterAndroid._plugin.Call(methodName:  "init", args:  val_2);
        }
        public static bool isLoggedIn()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            if(Prime31.TwitterAndroid._plugin != null)
            {
                    return Prime31.TwitterAndroid._plugin.Call<System.Boolean>(methodName:  "isLoggedIn", args:  System.Array.Empty<System.Object>());
            }
            
            return Prime31.TwitterAndroid._plugin.Call<System.Boolean>(methodName:  "isLoggedIn", args:  System.Array.Empty<System.Object>());
        }
        public static string getAccessToken()
        {
            UnityEngine.AndroidJavaObject val_4;
            var val_5;
            int val_6;
            if(UnityEngine.Application.platform == 11)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = Prime31.TwitterAndroid._plugin;
                string val_3 = val_4.Call<System.String>(methodName:  "getAccessToken", args:  System.Array.Empty<System.Object>());
                return (string)val_6;
            }
            
            val_6 = System.String.alignConst;
            return (string)val_6;
        }
        public static string getTokenSecret()
        {
            UnityEngine.AndroidJavaObject val_4;
            var val_5;
            int val_6;
            if(UnityEngine.Application.platform == 11)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = Prime31.TwitterAndroid._plugin;
                string val_3 = val_4.Call<System.String>(methodName:  "getTokenSecret", args:  System.Array.Empty<System.Object>());
                return (string)val_6;
            }
            
            val_6 = System.String.alignConst;
            return (string)val_6;
        }
        public static void showLoginDialog(bool useExternalBrowserForAuthentication = False)
        {
            UnityEngine.AndroidJavaObject val_4;
            var val_5;
            val_4 = useExternalBrowserForAuthentication;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Prime31.TwitterAndroid._plugin;
            object[] val_3 = new object[1];
            val_3[0] = val_4;
            val_4.Call(methodName:  "showLoginDialog", args:  val_3);
        }
        public static void logout()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.TwitterAndroid._plugin.Call(methodName:  "logout", args:  System.Array.Empty<System.Object>());
        }
        public static void postStatusUpdate(string status)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_1.Add(key:  "status", value:  status);
            Prime31.TwitterAndroid.performRequest(methodType:  "post", path:  "/1.1/statuses/update.json", parameters:  val_1);
        }
        public static void postStatusUpdate(string update, byte[] image)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[2];
            val_2[0] = update;
            val_2[1] = image;
            Prime31.TwitterAndroid._plugin.Call(methodName:  "postUpdateWithImage", args:  val_2);
        }
        public static void getHomeTimeline()
        {
            Prime31.TwitterAndroid.performRequest(methodType:  "get", path:  "/1.1/statuses/home_timeline.json", parameters:  0);
        }
        public static void getFollowers()
        {
            Prime31.TwitterAndroid.performRequest(methodType:  "get", path:  "/1.1/followers/ids.json", parameters:  0);
        }
        public static void performRequest(string methodType, string path, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            int val_4;
            var val_5;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            if(parameters != null)
            {
                    val_4 = Prime31.JsonExtensions.toJson(obj:  parameters);
            }
            else
            {
                    val_4 = System.String.alignConst;
            }
            
            val_5 = null;
            val_5 = null;
            object[] val_3 = new object[3];
            val_3[0] = methodType;
            val_3[1] = path;
            val_3[2] = val_4;
            Prime31.TwitterAndroid._plugin.Call(methodName:  "performRequest", args:  val_3);
        }
        public TwitterAndroid()
        {
        
        }
    
    }

}
