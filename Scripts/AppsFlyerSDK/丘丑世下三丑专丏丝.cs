using UnityEngine;

namespace AppsFlyerSDK
{
    public class 丘丑世下三丑专丏丝
    {
        // Fields
        private static UnityEngine.AndroidJavaClass 丑丈不丏且上下东丘;
        
        // Methods
        public static void 丈丅丒丁丘与下丆丆(string 下上丛业丗与丑丆丝, UnityEngine.MonoBehaviour 下丐三丆丝与不丗丕)
        {
            var val_4;
            object val_5;
            val_4 = null;
            val_4 = null;
            object[] val_1 = new object[2];
            val_1[0] = 下上丛业丗与丑丆丝;
            val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  下丐三丆丝与不丗丕)) != false)
            {
                    val_5 = 下丐三丆丝与不丗丕.name;
            }
            
            val_1[1] = val_5;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "initSDK", args:  val_1);
        }
        public static void 丟世世上丛下丒丐丗()
        {
            null = null;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丟世世上丛下丒丐丗(丅丂下丆业丝万东万:  false, 丅丏丈专三丘万丝与:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void 丟世世上丛下丒丐丗(bool 丅丂下丆业丝万东万, string 丅丏丈专三丘万丝与)
        {
            var val_3;
            bool val_1 = 丅丂下丆业丝万东万;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[2];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            val_2[1] = 丅丏丈专三丘万丝与;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "startTracking", args:  val_2);
        }
        public static void 丝下丑丌丒丕丝不丌(bool 丘丅上丑丝丙丙丏万)
        {
            var val_3;
            bool val_1 = 丘丅上丑丝丙丙丏万;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "stopTracking", args:  val_2);
        }
        public static string 丂世万丒丙丟专万专()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>());
        }
        public static void 丕丞东三丒与上丞下(string 不丒三业下丑不丞业)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(不丒三业下丑不丞业 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(不丒三业下丑不丞业 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 不丒三业下丑不丞业;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "updateServerUninstallToken", args:  val_1);
        }
        public static void 丏东丟七丈东一东丏(bool 丅丘丘丙丘丛世七一)
        {
            var val_3;
            bool val_1 = 丅丘丘丙丘丛世七一;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setIsDebug", args:  val_2);
        }
        public static void 丅一东丈专世三丝丂(string 业丂三丒丂七与世专)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(业丂三丒丂七与世专 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(业丂三丒丂七与世专 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 业丂三丒丂七与世专;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setImeiData", args:  val_1);
        }
        public static void 丅三东下业丂丁东三(string 丘一丁世丕丘丌丐专)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丘一丁世丕丘丌丐专 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丘一丁世丕丘丌丐专 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丘一丁世丕丘丌丐专;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setAndroidIdData", args:  val_1);
        }
        public static void 丝东丘丛丁东丑七一(string 丞丅上丏丂且下丅与)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丞丅上丏丂且下丅与 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丞丅上丏丂且下丅与 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丞丅上丏丂且下丅与;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setCustomerUserId", args:  val_1);
        }
        public static void 丟世且丏业七七丒七(bool 且丆万丕丐丛三丙丟)
        {
            var val_3;
            bool val_1 = 且丆万丕丐丛三丙丟;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "waitForCustomerUserId", args:  val_2);
        }
        public static void 丏丝丞丗三三三与且(string 丞丅上丏丂且下丅与)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丞丅上丏丂且下丅与 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丞丅上丏丂且下丅与 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丞丅上丏丂且下丅与;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setCustomerIdAndTrack", args:  val_1);
        }
        public static string 下上丐丞丗丕丗丁丈()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getOutOfStore", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getOutOfStore", args:  System.Array.Empty<System.Object>());
        }
        public static void 丈一丗专万丝丄丗丘(string 丂丛丆万丁丆下三丘)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丂丛丆万丁丆下三丘 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丂丛丆万丁丆下三丘 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丂丛丆万丁丆下三丘;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setOutOfStore", args:  val_1);
        }
        public static void 丆丅世丞与世丘上业(string 丂丄丏丘丐丂丑上丌)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丂丄丏丘丐丂丑上丌 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丂丄丏丘丐丂丑上丌 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丂丄丏丘丐丂丑上丌;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setAppInviteOneLinkID", args:  val_1);
        }
        public static void 丈一下下丄丄丆业且(System.Collections.Generic.Dictionary<string, string> 丅丌丟丟七专业丗一)
        {
            null = null;
            object[] val_1 = new object[1];
            UnityEngine.AndroidJavaObject val_2 = AppsFlyerSDK.丘丑世下三丑专丏丝.专丄丙丆丒专丏且上(万丝且丘不丑丝下丑:  丅丌丟丟七专业丗一);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = val_2;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setAdditionalData", args:  val_1);
        }
        public static void 丙专专丕上丑丐丝且(string[] 丘丒丟专七不丐且丌)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丘丒丟专七不丐且丌 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丘丒丟专七不丐且丌 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丘丒丟专七不丐且丌;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setUserEmails", args:  val_1);
        }
        public static void 不丂丄丘丌世丐丗丕(string 丏丘丙丛上丛三且丘)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丏丘丙丛上丛三且丘 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丏丘丙丛上丛三且丘 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丏丘丙丛上丛三且丘;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setPhoneNumber", args:  val_1);
        }
        public static void 丙专专丕上丑丐丝且(AppsFlyerSDK.丟丄丘七世丁专世丗 专丏专丄丏丄丗东下, string[] 丘丒丟专七不丐且丌)
        {
            null = null;
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = AppsFlyerSDK.丘丑世下三丑专丏丝.丂专丝世万丄且世丅(丘丁与且不丒不丈丂:  专丏专丄丏丄丗东下);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = val_2;
            val_1[1] = 丘丒丟专七不丐且丌;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setUserEmails", args:  val_1);
        }
        public static void 丅丕不丁丆丛三且丈(bool 丟一丄丛丒丑且丄丏)
        {
            var val_3;
            bool val_1 = 丟一丄丛丒丑且丄丏;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setCollectAndroidID", args:  val_2);
        }
        public static void 东丂丕专世专与丁专(bool 丟一丄丛丒丑且丄丏)
        {
            var val_3;
            bool val_1 = 丟一丄丛丒丑且丄丏;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setCollectIMEI", args:  val_2);
        }
        public static void 丅丗丝丘万丞世丑下(string[] 丅万丛丄丅七一丟丘)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丅万丛丄丅七一丟丘 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丅万丛丄丅七一丟丘 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丅万丛丄丅七一丟丘;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setResolveDeepLinkURLs", args:  val_1);
        }
        public static void 且三丒一且丈一业专(string[] 丝世丄七且丝丟东丛)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丝世丄七且丝丟东丛 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丝世丄七且丝丟东丛 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丝世丄七且丝丟东丛;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setOneLinkCustomDomain", args:  val_1);
        }
        public static void 丑丄丌丗三专一三丙(bool 丝丞东丙丂丏丙丞丕)
        {
            var val_3;
            bool val_1 = 丝丞东丙丂丏丙丞丕;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setIsUpdate", args:  val_2);
        }
        public static void 七丈七且丌上丕丅丒(string 专丄丒丘丅七丂丟丙)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(专丄丒丘丅七丂丟丙 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(专丄丒丘丅七丂丟丙 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 专丄丒丘丅七丂丟丙;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setCurrencyCode", args:  val_1);
        }
        public static void 丞丂专丗丐丂丈丄东(double 与丞丐业丈且专丂丐, double 丈与丏丄上三一一丈)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(与丞丐业丈且专丂丐 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(与丞丐业丈且专丂丐 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 与丞丐业丈且专丂丐;
            val_1[1] = 丈与丏丄上三一一丈;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "trackLocation", args:  val_1);
        }
        public static void 丘丟丈丈万丐三丄丛(string 丝丏业丅丈东业丝丒, System.Collections.Generic.Dictionary<string, string> 业丆丙下一且七丐丑)
        {
            null = null;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丘丟丈丈万丐三丄丛(丝丏业丅丈东业丝丒:  丝丏业丅丈东业丝丒, 业丆丙下一且七丐丑:  业丆丙下一且七丐丑, 丅丂下丆业丝万东万:  false, 丅丏丈专三丘万丝与:  AppsFlyerSDK.AppsFlyer.CallBackObjectName);
        }
        public static void 丘丟丈丈万丐三丄丛(string 丝丏业丅丈东业丝丒, System.Collections.Generic.Dictionary<string, string> 业丆丙下一且七丐丑, bool 丅丂下丆业丝万东万, string 丅丏丈专三丘万丝与)
        {
            null = null;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丝丏业丅丈东业丝丒 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丝丏业丅丈东业丝丒 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丝丏业丅丈东业丝丒;
            val_1[1] = AppsFlyerSDK.丘丑世下三丑专丏丝.专丄丙丆丒专丏且上(万丝且丘不丑丝下丑:  业丆丙下一且七丐丑);
            val_1[2] = 丅丂下丆业丝万东万;
            val_1[3] = 丅丏丈专三丘万丝与;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "trackEvent", args:  val_1);
        }
        public static void 丅三丄丐且业下丁丛(bool 丄丌丄与丘丑丈丄丐)
        {
            var val_3;
            bool val_1 = 丄丌丄与丘丑丈丄丐;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setDeviceTrackingDisabled", args:  val_2);
        }
        public static void 且丄且丛丙丟丑万一(bool 丆丛丆丞下丅丂且丝)
        {
            var val_3;
            bool val_1 = 丆丛丆丞下丅丂且丝;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "enableFacebookDeferredApplinks", args:  val_2);
        }
        public static void 丒丘丐丈万七丕丗丘(bool 丁丟业丂三丝丕丆不)
        {
            var val_3;
            bool val_1 = 丁丟业丂三丝丕丆不;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setConsumeAFDeepLinks", args:  val_2);
        }
        public static void 丗丕丕丘丕丈丏丕丄(string 下且七丕东丗下七丅, string 不三世丒丟一丘专丛, string 与丅丝丈专上丄三不)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(下且七丕东丗下七丅 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(下且七丕东丗下七丅 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 下且七丕东丗下七丅;
            val_1[1] = 不三世丒丟一丘专丛;
            val_1[2] = 与丅丝丈专上丄三不;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setPreinstallAttribution", args:  val_1);
        }
        public static bool 业丕丏且业丛丂且丏()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.Boolean>(methodName:  "isPreInstalledApp", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.Boolean>(methodName:  "isPreInstalledApp", args:  System.Array.Empty<System.Object>());
        }
        public static string 业丏东一不且丞丟丄()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getAttributionId", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getAttributionId", args:  System.Array.Empty<System.Object>());
        }
        public static string 东丛上丘东丗丙一不()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getAppsFlyerId", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getAppsFlyerId", args:  System.Array.Empty<System.Object>());
        }
        public static void 丌丒丟丛丈七丈丆丒(string 丒三丟丑业丗丌下丘, string 丈丘丟上三专三丅丄, string 一丁丟丟丟丗丘丗专, string 丒世丘丘上丆丝东丞, string 丏丂不专上丘丂不丅, System.Collections.Generic.Dictionary<string, string> 不丅下一丁丏一丈丝, UnityEngine.MonoBehaviour 下丐三丆丝与不丗丕)
        {
            var val_5;
            object val_6;
            val_5 = null;
            val_5 = null;
            object[] val_1 = new object[7];
            val_1[0] = 丒三丟丑业丗丌下丘;
            val_1[1] = 丈丘丟上三专三丅丄;
            val_1[2] = 一丁丟丟丟丗丘丗专;
            val_1[3] = 丒世丘丘上丆丝东丞;
            val_1[4] = 丏丂不专上丘丂不丅;
            val_1[5] = AppsFlyerSDK.丘丑世下三丑专丏丝.专丄丙丆丒专丏且上(万丝且丘不丑丝下丑:  不丅下一丁丏一丈丝);
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  下丐三丆丝与不丗丕)) != false)
            {
                    val_6 = 下丐三丆丝与不丗丕.name;
            }
            
            val_1[6] = val_6;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "validateAndTrackInAppPurchase", args:  val_1);
        }
        public static bool 丘丅上丑丝丙丙丏万()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.Boolean>(methodName:  "isTrackingStopped", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.Boolean>(methodName:  "isTrackingStopped", args:  System.Array.Empty<System.Object>());
        }
        public static void 不丈丝丆三丄不丝丏(int 丆丐七丅丆丗丛上与)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丆丐七丅丆丗丛上与 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丆丐七丅丆丗丛上与 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丆丐七丅丆丗丛上与;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setMinTimeBetweenSessions", args:  val_1);
        }
        public static void 丑丑一上万与东丒丆(string 下与丈丌丁三世丑丈, string 且万丙世东丆下丅丘)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(下与丈丌丁三世丑丈 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(下与丈丌丁三世丑丈 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 下与丈丌丁三世丑丈;
            val_1[1] = 且万丙世东丆下丅丘;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setHost", args:  val_1);
        }
        public static string 丘丏丏三丁丅东不万()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getHostName", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getHostName", args:  System.Array.Empty<System.Object>());
        }
        public static string 丈丗丕丑万丁下丛万()
        {
            null = null;
            if(AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 != null)
            {
                    return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getHostPrefix", args:  System.Array.Empty<System.Object>());
            }
            
            return AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic<System.String>(methodName:  "getHostPrefix", args:  System.Array.Empty<System.Object>());
        }
        public static void 丄专丅丗丟丗且专业()
        {
            null = null;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setSharingFilterForAllPartners", args:  System.Array.Empty<System.Object>());
        }
        public static void 丙业丐丁业丘丅丁不(string[] 丒下三丅上丆万丅专)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丒下三丅上丆万丅专 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丒下三丅上丆万丅专 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丒下三丅上丆万丅专;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setSharingFilter", args:  val_1);
        }
        public static void 专不一与丘丏丕丏下(string 丈丕且丈三丘丅丟万)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丈丕且丈三丘丅丟万 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丈丕且丈三丘丅丟万 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丈丕且丈三丘丅丟万;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "getConversionData", args:  val_1);
        }
        public static void 专丂三丕丑三上世业(UnityEngine.MonoBehaviour 下丐三丆丝与不丗丕)
        {
            var val_4;
            object val_5;
            val_4 = null;
            val_4 = null;
            object[] val_1 = new object[1];
            val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  下丐三丆丝与不丗丕)) == true)
            {
                goto label_5;
            }
            
            if(val_1 == null)
            {
                goto label_6;
            }
            
            label_10:
            if(val_5 != 0)
            {
                goto label_7;
            }
            
            goto label_12;
            label_5:
            val_5 = 下丐三丆丝与不丗丕.name;
            if(val_1 != null)
            {
                goto label_10;
            }
            
            label_6:
            if(val_5 == null)
            {
                goto label_12;
            }
            
            label_7:
            label_12:
            val_1[0] = val_5;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "initInAppPurchaseValidatorListener", args:  val_1);
        }
        public static void 丒万专业丒丌丄丙丂(bool 丟一丄丛丒丑且丄丏)
        {
            var val_3;
            bool val_1 = 丟一丄丛丒丑且丄丏;
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_1 == true)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_1 == false)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_1;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "setCollectOaid", args:  val_2);
        }
        public static void 一丆丒丙丅丗与丐丄(string 专东丂丙与丈丗丞丐, string 不三世丒丟一丘专丛, System.Collections.Generic.Dictionary<string, string> 丙一且七丑专丐与丈)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(专东丂丙与丈丗丞丐 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(专东丂丙与丈丗丞丐 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 专东丂丙与丈丗丞丐;
            val_1[1] = 不三世丒丟一丘专丛;
            val_1[2] = AppsFlyerSDK.丘丑世下三丑专丏丝.专丄丙丆丒专丏且上(万丝且丘不丑丝下丑:  丙一且七丑专丐与丈);
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "attributeAndOpenStore", args:  val_1);
        }
        public static void 丗丄与且且丞丄不丛(string 丛七丞专丛丁丑万丆, string 不三世丒丟一丘专丛, System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丛七丞专丛丁丑万丆 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丛七丞专丛丁丑万丆 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丛七丞专丛丁丑万丆;
            val_1[1] = 不三世丒丟一丘专丛;
            val_1[2] = AppsFlyerSDK.丘丑世下三丑专丏丝.专丄丙丆丒专丏且上(万丝且丘不丑丝下丑:  丗丟上上丒丐丗丞丙);
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "recordCrossPromoteImpression", args:  val_1);
        }
        public static void 丝丒业丛世东丘丙与(System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙, UnityEngine.MonoBehaviour 下丐三丆丝与不丗丕)
        {
            var val_5;
            object val_6;
            val_5 = null;
            val_5 = null;
            object[] val_1 = new object[2];
            val_1[0] = AppsFlyerSDK.丘丑世下三丑专丏丝.专丄丙丆丒专丏且上(万丝且丘不丑丝下丑:  丗丟上上丒丐丗丞丙);
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  下丐三丆丝与不丗丕)) != false)
            {
                    val_6 = 下丐三丆丝与不丗丕.name;
            }
            
            val_1[1] = val_6;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "createOneLinkInviteListener", args:  val_1);
        }
        public static void 丅万一东与世丆专丏()
        {
            null = null;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "handlePushNotifications", args:  System.Array.Empty<System.Object>());
        }
        public static void 专业丄丏不上丕丝七(string[] 三丈一丈丂丆下七丞)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(三丈一丈丂丆下七丞 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(三丈一丈丂丆下七丞 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 三丈一丈丂丆下七丞;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "addPushNotificationDeepLinkPath", args:  val_1);
        }
        public static void 丘丂丝丝丙丈丕丂丘(string 丈丕且丈三丘丅丟万)
        {
            null = null;
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丈丕且丈三丘丅丟万 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(丈丕且丈三丘丅丟万 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = 丈丕且丈三丘丅丟万;
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘.CallStatic(methodName:  "subscribeForDeepLink", args:  val_1);
        }
        private static UnityEngine.AndroidJavaObject 丂专丝世万丄且世丅(AppsFlyerSDK.丟丄丘七世丁专世丗 丘丁与且不丒不丈丂)
        {
            return new UnityEngine.AndroidJavaClass(className:  "com.appsflyer.AppsFlyerProperties$EmailsCryptType").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  (丘丁与且不丒不丈丂 == 1) ? "SHA256" : "NONE");
        }
        private static UnityEngine.AndroidJavaObject 专丄丙丆丒专丏且上(System.Collections.Generic.Dictionary<string, string> 万丝且丘不丑丝下丑)
        {
            var val_8;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.HashMap", args:  System.Array.Empty<System.Object>());
            if(万丝且丘不丑丝下丑 == null)
            {
                    return val_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_5 = 万丝且丘不丑丝下丑.GetEnumerator();
            label_15:
            if((2033028096 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
            object[] val_10 = new object[2];
            val_10[0] = val_9._value._obj.丐丏七丌丕丗业且上();
            val_10[1] = ;
            UnityEngine.jvalue[] val_12 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  val_10);
            IntPtr val_14 = UnityEngine.AndroidJNI.CallObjectMethod(obj:  val_2.GetRawObject(), methodID:  UnityEngine.AndroidJNIHelper.GetMethodID(javaClass:  val_2.GetRawClass(), methodName:  "put", signature:  "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"), args:  val_12);
            UnityEngine.AndroidJNI.DeleteLocalRef(obj:  val_12[0]);
            UnityEngine.AndroidJNI.DeleteLocalRef(obj:  val_12[1]);
            goto label_15;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return val_2;
        }
        public 丘丑世下三丑专丏丝()
        {
        
        }
        private static 丘丑世下三丑专丏丝()
        {
            AppsFlyerSDK.丘丑世下三丑专丏丝.丑丈不丏且上下东丘 = new UnityEngine.AndroidJavaClass(className:  "com.appsflyer.unity.AppsFlyerAndroidWrapper");
        }
    
    }

}
