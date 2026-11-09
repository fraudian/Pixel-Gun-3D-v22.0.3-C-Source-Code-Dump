using UnityEngine;

namespace AppsFlyerSDK
{
    public class AppsFlyer : MonoBehaviour
    {
        // Fields
        public static readonly string kAppsFlyerPluginVersion;
        public static string CallBackObjectName;
        private static System.EventHandler 七专丑丐不丂下下万;
        private static System.EventHandler 丛丞丟东丘且丛丕丁;
        private static System.EventHandler 丐丛丄上丙丄丛丏世;
        
        // Methods
        public static void initSDK(string 丁上东丄不丂东万专, string 丛七丞专丛丁丑万丆)
        {
            AppsFlyerSDK.AppsFlyer.initSDK(丁上东丄不丂东万专:  丁上东丄不丂东万专, 丛七丞专丛丁丑万丆:  丛七丞专丛丁丑万丆, 下丐三丆丝与不丗丕:  0);
        }
        public static void initSDK(string 丁上东丄不丂东万专, string 丛七丞专丛丁丑万丆, UnityEngine.MonoBehaviour 下丐三丆丝与不丗丕)
        {
            string val_3;
            var val_4;
            if(下丐三丆丝与不丗丕 != 0)
            {
                    val_3 = 下丐三丆丝与不丗丕.name;
                val_4 = null;
                val_4 = null;
                AppsFlyerSDK.AppsFlyer.CallBackObjectName = val_3;
            }
            
            AppsFlyerSDK.丘丑世下三丑专丏丝.丈丅丒丁丘与下丆丆(下上丛业丗与丑丆丝:  丁上东丄不丂东万专, 下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕);
        }
        public static void startSDK()
        {
            null = null;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丟世世上丛下丒丐丗(丅丂下丆业丝万东万:  (AppsFlyerSDK.AppsFlyer.七专丑丐不丂下下万 != 0) ? 1 : 0, 丅丏丈专三丘万丝与:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void sendEvent(string 丝丏业丅丈东业丝丒, System.Collections.Generic.Dictionary<string, string> 业丆丙下一且七丐丑)
        {
            null = null;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丘丟丈丈万丐三丄丛(丝丏业丅丈东业丝丒:  丝丏业丅丈东业丝丒, 业丆丙下一且七丐丑:  业丆丙下一且七丐丑, 丅丂下丆业丝万东万:  (AppsFlyerSDK.AppsFlyer.丛丞丟东丘且丛丕丁 != 0) ? 1 : 0, 丅丏丈专三丘万丝与:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void stopSDK(bool 丘丅上丑丝丙丙丏万)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丝下丑丌丒丕丝不丌(丘丅上丑丝丙丙丏万:  丘丅上丑丝丙丙丏万);
        }
        public static bool isSDKStopped()
        {
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丘丅上丑丝丙丙丏万();
        }
        public static string getSdkVersion()
        {
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丂世万丒丙丟专万专();
        }
        public static void setIsDebug(bool 丅丘丘丙丘丛世七一)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丏东丟七丈东一东丏(丅丘丘丙丘丛世七一:  丅丘丘丙丘丛世七一);
        }
        public static void setCustomerUserId(string 丞丅上丏丂且下丅与)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丝东丘丛丁东丑七一(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
        }
        public static void setAppInviteOneLinkID(string 丂丄丏丘丐丂丑上丌)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丆丅世丞与世丘上业(丂丄丏丘丐丂丑上丌:  丂丄丏丘丐丂丑上丌);
        }
        public static void setAdditionalData(System.Collections.Generic.Dictionary<string, string> 丅丌丟丟七专业丗一)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丈一下下丄丄丆业且(丅丌丟丟七专业丗一:  丅丌丟丟七专业丗一);
        }
        public static void setResolveDeepLinkURLs(string[] 丅万丛丄丅七一丟丘)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丅丗丝丘万丞世丑下(丅万丛丄丅七一丟丘:  丅万丛丄丅七一丟丘);
        }
        public static void setOneLinkCustomDomain(string[] 丝世丄七且丝丟东丛)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.且三丒一且丈一业专(丝世丄七且丝丟东丛:  丝世丄七且丝丟东丛);
        }
        public static void setCurrencyCode(string 专丄丒丘丅七丂丟丙)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.七丈七且丌上丕丅丒(专丄丒丘丅七丂丟丙:  专丄丒丘丅七丂丟丙);
        }
        public static void recordLocation(double 与丞丐业丈且专丂丐, double 丈与丏丄上三一一丈)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丞丂专丗丐丂丈丄东(与丞丐业丈且专丂丐:  与丞丐业丈且专丂丐, 丈与丏丄上三一一丈:  丈与丏丄上三一一丈);
        }
        public static void anonymizeUser(bool 丌丘丕与丈东与上丆)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丅三丄丐且业下丁丛(丄丌丄与丘丑丈丄丐:  丌丘丕与丈东与上丆);
        }
        public static string getAppsFlyerId()
        {
            return AppsFlyerSDK.丘丑世下三丑专丏丝.东丛上丘东丗丙一不();
        }
        public static void setMinTimeBetweenSessions(int 丆丐七丅丆丗丛上与)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.不丈丝丆三丄不丝丏(丆丐七丅丆丗丛上与:  丆丐七丅丆丗丛上与);
        }
        public static void setHost(string 下与丈丌丁三世丑丈, string 且万丙世东丆下丅丘)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丑一上万与东丒丆(下与丈丌丁三世丑丈:  下与丈丌丁三世丑丈, 且万丙世东丆下丅丘:  且万丙世东丆下丅丘);
        }
        public static void setUserEmails(AppsFlyerSDK.丟丄丘七世丁专世丗 专丏专丄丏丄丗东下, string[] 丘丒丟专七不丐且丌)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丙专专丕上丑丐丝且(专丏专丄丏丄丗东下:  专丏专丄丏丄丗东下, 丘丒丟专七不丐且丌:  丘丒丟专七不丐且丌);
        }
        public static void setPhoneNumber(string 丏丘丙丛上丛三且丘)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.不丂丄丘丌世丐丗丕(丏丘丙丛上丛三且丘:  丏丘丙丛上丛三且丘);
        }
        public static void setSharingFilterForAllPartners()
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丄专丅丗丟丗且专业();
        }
        public static void setSharingFilter(string[] 丒下三丅上丆万丅专)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丙业丐丁业丘丅丁不(丒下三丅上丆万丅专:  丒下三丅上丆万丅专);
        }
        public static void getConversionData(string 丈丕且丈三丘丅丟万)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.专不一与丘丏丕丏下(丈丕且丈三丘丅丟万:  丈丕且丈三丘丅丟万);
        }
        public static void attributeAndOpenStore(string 丛七丞专丛丁丑万丆, string 不三世丒丟一丘专丛, System.Collections.Generic.Dictionary<string, string> 丙一且七丑专丐与丈, UnityEngine.MonoBehaviour 下丐三丆丝与不丗丕)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.一丆丒丙丅丗与丐丄(专东丂丙与丈丗丞丐:  丛七丞专丛丁丑万丆, 不三世丒丟一丘专丛:  不三世丒丟一丘专丛, 丙一且七丑专丐与丈:  丙一且七丑专丐与丈);
        }
        public static void recordCrossPromoteImpression(string 丛七丞专丛丁丑万丆, string 不三世丒丟一丘专丛, System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丗丄与且且丞丄不丛(丛七丞专丛丁丑万丆:  丛七丞专丛丁丑万丆, 不三世丒丟一丘专丛:  不三世丒丟一丘专丛, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
        }
        public static void generateUserInviteLink(System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙, UnityEngine.MonoBehaviour 下丐三丆丝与不丗丕)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丝丒业丛世东丘丙与(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙, 下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕);
        }
        public static void addPushNotificationDeepLinkPath(string[] 三丈一丈丂丆下七丞)
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.专业丄丏不上丕丝七(三丈一丈丂丆下七丞:  三丈一丈丂丆下七丞);
        }
        public static void subscribeForDeepLink()
        {
            null = null;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丘丂丝丝丙丈丕丂丘(丈丕且丈三丘丅丟万:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void add_OnRequestResponse(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            System.EventHandler val_4;
            val_3 = null;
            val_3 = null;
            if(((System.Delegate.Combine(a:  AppsFlyerSDK.AppsFlyer.七专丑丐不丂下下万, b:  丙业与丙丗丝不丈东)) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            AppsFlyerSDK.AppsFlyer.七专丑丐不丂下下万 = val_4;
        }
        public static void remove_OnRequestResponse(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            System.EventHandler val_4;
            val_3 = null;
            val_3 = null;
            if(((System.Delegate.Remove(source:  AppsFlyerSDK.AppsFlyer.七专丑丐不丂下下万, value:  丙业与丙丗丝不丈东)) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            AppsFlyerSDK.AppsFlyer.七专丑丐不丂下下万 = val_4;
        }
        public static void add_OnInAppResponse(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            System.EventHandler val_4;
            val_3 = null;
            val_3 = null;
            if(((System.Delegate.Combine(a:  AppsFlyerSDK.AppsFlyer.丛丞丟东丘且丛丕丁, b:  丙业与丙丗丝不丈东)) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            AppsFlyerSDK.AppsFlyer.丛丞丟东丘且丛丕丁 = val_4;
        }
        public static void remove_OnInAppResponse(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            System.EventHandler val_4;
            val_3 = null;
            val_3 = null;
            if(((System.Delegate.Remove(source:  AppsFlyerSDK.AppsFlyer.丛丞丟东丘且丛丕丁, value:  丙业与丙丗丝不丈东)) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            AppsFlyerSDK.AppsFlyer.丛丞丟东丘且丛丕丁 = val_4;
        }
        public static void add_OnDeepLinkReceived(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            System.EventHandler val_4;
            val_3 = null;
            val_3 = null;
            if(((System.Delegate.Combine(a:  AppsFlyerSDK.AppsFlyer.丐丛丄上丙丄丛丏世, b:  丙业与丙丗丝不丈东)) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            AppsFlyerSDK.AppsFlyer.丐丛丄上丙丄丛丏世 = val_4;
            AppsFlyerSDK.AppsFlyer.subscribeForDeepLink();
        }
        public static void remove_OnDeepLinkReceived(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            System.EventHandler val_4;
            val_3 = null;
            val_3 = null;
            if(((System.Delegate.Remove(source:  AppsFlyerSDK.AppsFlyer.丐丛丄上丙丄丛丏世, value:  丙业与丙丗丝不丈东)) != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            AppsFlyerSDK.AppsFlyer.丐丛丄上丙丄丛丏世 = val_4;
        }
        public void inAppResponseReceived(string 丑与丂丌世丕丆一丗)
        {
            null = null;
            if(AppsFlyerSDK.AppsFlyer.丛丞丟东丘且丛丕丁 == null)
            {
                    return;
            }
            
            AppsFlyerSDK.AppsFlyer.丛丞丟东丘且丛丕丁.Invoke(sender:  0, e:  AppsFlyerSDK.AppsFlyer.丂东丑丈丈七丐丙丈(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗));
        }
        public void requestResponseReceived(string 丑与丂丌世丕丆一丗)
        {
            null = null;
            if(AppsFlyerSDK.AppsFlyer.七专丑丐不丂下下万 == null)
            {
                    return;
            }
            
            AppsFlyerSDK.AppsFlyer.七专丑丐不丂下下万.Invoke(sender:  0, e:  AppsFlyerSDK.AppsFlyer.丂东丑丈丈七丐丙丈(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗));
        }
        public void onDeepLinking(string 丑与丂丌世丕丆一丗)
        {
            var val_2;
            System.EventHandler val_3;
            val_2 = null;
            val_2 = null;
            val_3 = AppsFlyerSDK.AppsFlyer.丐丛丄上丙丄丛丏世;
            if(val_3 == null)
            {
                    return;
            }
            
            val_3 = AppsFlyerSDK.AppsFlyer.丐丛丄上丙丄丛丏世;
            if(val_3 == null)
            {
                    val_3 = 0;
            }
            
            val_3.Invoke(sender:  0, e:  new AppsFlyerSDK.丑七丛丕东世丙不业(下业七不丑丂丏丟东:  丑与丂丌世丕丆一丗));
        }
        private static AppsFlyerSDK.丙七七丅下丈世丏三 丂东丑丈丈七丐丙丈(string 丑与丂丌世丕丆一丗)
        {
            string val_7;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(下业七不丑丂丏丟东:  丑与丂丌世丕丆一丗);
            if((val_1.ContainsKey(key:  "errorDescription")) == false)
            {
                goto label_4;
            }
            
            val_7 = val_1.Item["errorDescription"];
            if(val_7 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_4:
            val_7 = "";
            label_6:
            if(val_7 != null)
            {
                    val_7 = 0;
            }
            
            label_9:
            object val_5 = val_1.Item["statusCode"];
            return (AppsFlyerSDK.丙七七丅下丈世丏三)new AppsFlyerSDK.丙七七丅下丈世丏三(专丏不丏东丏丈丆上:  21884928, 丞丟丂丄下万丈万东:  val_7);
        }
        public static System.Collections.Generic.Dictionary<string, object> CallbackStringToDictionary(string 下业七不丑丂丏丟东)
        {
            var val_3;
            if((AFMiniJSON.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  下业七不丑丂丏丟东)) == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>);
            }
            
            val_3 = 0;
            return (System.Collections.Generic.Dictionary<System.String, System.Object>);
        }
        public static void AFLog(string 丑与丆丝丕东丛丄丝, string 下业七不丑丂丏丟东)
        {
            null = null;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "AppsFlyer_Unity_v{0} {1} called with {2}", arg0:  AppsFlyerSDK.AppsFlyer.kAppsFlyerPluginVersion, arg1:  丑与丆丝丕东丛丄丝, arg2:  下业七不丑丂丏丟东));
        }
        public AppsFlyer()
        {
        
        }
        private static AppsFlyer()
        {
            AppsFlyerSDK.AppsFlyer.kAppsFlyerPluginVersion = "6.2.6";
            AppsFlyerSDK.AppsFlyer.CallBackObjectName = 0;
        }
    
    }

}
