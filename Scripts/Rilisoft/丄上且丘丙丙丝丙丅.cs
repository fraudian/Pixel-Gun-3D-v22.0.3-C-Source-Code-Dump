using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丄上且丘丙丙丝丙丅
    {
        // Fields
        private readonly string 丐万业丝一东一丛东;
        private bool 丆丞丈丐且丌丙丑不;
        
        // Properties
        internal static bool 专且丏七丄丁丏丙丑 { set; }
        
        // Methods
        internal 丄上且丘丙丙丝丙丅(string 万下丈世丏业丛丕不, string 丗万丟万七专丗下丕, string 丗丆丌丘丄丞丞东丁, bool 丅丂且丆万且丂丝丙)
        {
            string val_11;
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            val_11 = 丗丆丌丘丄丞丞东丁;
            bool val_1 = 丅丂且丆万且丂丝丙;
            val_2 = new System.Object();
            if(万下丈世丏业丛丕不 == null)
            {
                goto label_1;
            }
            
            if(val_11 == null)
            {
                goto label_2;
            }
            
            var val_3 = (val_2 == null) ? 0 : (this);
            if(val_2 == null)
            {
                goto label_3;
            }
            
            mem2[0] = val_2;
            this.丆丞丈丐且丌丙丑不 = val_1;
            if(丅丂且丆万且丂丝丙 == true)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_11)) != true)
            {
                    AppsFlyerSDK.AppsFlyer.setCustomerUserId(丞丅上丏丂且下丅与:  val_11);
            }
            
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != true)
            {
                    AppsFlyerSDK.丘丑世下三丑专丏丝.东丂丕专世专与丁专(丟一丄丛丒丑且丄丏:  true);
                AppsFlyerSDK.丘丑世下三丑专丏丝.丅丕不丁丆丛三且丈(丟一丄丛丒丑且丄丏:  true);
            }
            
            AppsFlyerSDK.AppsFlyer.initSDK(丁上东丄不丂东万专:  万下丈世丏业丛丕不, 丛七丞专丛丁丑万丆:  string val_2 = 丗万丟万七专丗下丕, 下丐三丆丝与不丗丕:  PGCompany.AppsFlyerTrackerCallbacks.丑七不且上丗丁一世());
            AppsFlyerSDK.AppsFlyer.startSDK();
            label_35:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            val_11 = "[AppsFlyerFacade..ctor] AppsFlyerFacade initialized. customerId: "("[AppsFlyerFacade..ctor] AppsFlyerFacade initialized. customerId: ") + val_11 + ", isSuspicious: "(", isSuspicious: ") + val_1.ToString();
            UnityEngine.Debug.Log(message:  val_11);
            return;
            label_1:
            val_13 = "appKey";
            goto label_20;
            label_2:
            val_13 = "customerId";
            goto label_20;
            label_3:
            System.ArgumentNullException val_10 = null;
            val_13 = "appId";
            label_20:
            val_10 = new System.ArgumentNullException(paramName:  val_13);
            val_14 = 0;
            val_15 = val_10;
            if(val_14 != 1)
            {
                goto label_31;
            }
            
            if((null & 1) == 0)
            {
                goto label_32;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[AppsFlyerFacade..ctor] Exception happened while initializing AppsFlyerFacade.");
            UnityEngine.Debug.LogException(exception:  1152921504617017344);
            goto label_35;
            label_32:
            val_16 = 8;
            mem[8] = null;
            val_15 = val_16;
            label_31:
        }
        internal static void 万且丏专一不上万下(bool 丙业与丙丗丝不丈东)
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    return;
            }
            
            AppsFlyerSDK.AppsFlyer.setIsDebug(丅丘丘丙丘丛世七一:  丙业与丙丗丝不丈东);
        }
        internal void 且丞丁三一丁丕万丛()
        {
            this.丆丞丈丐且丌丙丑不 = true;
        }
        internal void 丞丑丂丂且七且丐丑(string 丝丏业丅丈东业丝丒, System.Collections.Generic.Dictionary<string, string> 业丆丙下一且七丐丑)
        {
            string val_6;
            var val_7;
            if(丝丏业丅丈东业丝丒 == null)
            {
                goto label_1;
            }
            
            if(业丆丙下一且七丐丑 == null)
            {
                goto label_2;
            }
            
            if((System.String.IsNullOrEmpty(value:  丝丏业丅丈东业丝丒)) == true)
            {
                goto label_3;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.丐万业丝一东一丛东)) == true)
            {
                    return;
            }
            
            if(this.丆丞丈丐且丌丙丑不 != false)
            {
                    return;
            }
            
            AppsFlyerSDK.AppsFlyer.sendEvent(丝丏业丅丈东业丝丒:  丝丏业丅丈东业丝丒, 业丆丙下一且七丐丑:  业丆丙下一且七丐丑);
            return;
            label_1:
            val_6 = "eventName";
            goto label_8;
            label_2:
            System.ArgumentNullException val_3 = null;
            val_6 = "eventValues";
            label_8:
            val_7 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  val_6);
            goto label_9;
            label_3:
            System.ArgumentException val_4 = null;
            val_7 = val_4;
            val_4 = new System.ArgumentException(message:  "Event name must not be empty.", paramName:  "eventName");
            label_9:
        }
        internal static void 丘与丂丐业三专且丂(string 丗万丟万七专丗下丕, string 不三世丒丟一丘专丛, System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙, UnityEngine.MonoBehaviour 业丏丈世世世丞丒世)
        {
            string val_3;
            if(丗万丟万七专丗下丕 == null)
            {
                goto label_1;
            }
            
            if(不三世丒丟一丘专丛 == null)
            {
                goto label_2;
            }
            
            AppsFlyerSDK.AppsFlyer.attributeAndOpenStore(丛七丞专丛丁丑万丆:  丗万丟万七专丗下丕, 不三世丒丟一丘专丛:  不三世丒丟一丘专丛, 丙一且七丑专丐与丈:  丗丟上上丒丐丗丞丙, 下丐三丆丝与不丗丕:  业丏丈世世世丞丒世);
            return;
            label_1:
            val_3 = "appId";
            goto label_5;
            label_2:
            val_3 = "campaign";
            label_5:
            null = new System.ArgumentNullException(paramName:  val_3);
        }
        internal static void 丈丙三不世丗东丅丝(string 丗万丟万七专丗下丕, string 不三世丒丟一丘专丛, System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙)
        {
            string val_3;
            if(丗万丟万七专丗下丕 == null)
            {
                goto label_1;
            }
            
            if(不三世丒丟一丘专丛 == null)
            {
                goto label_2;
            }
            
            AppsFlyerSDK.AppsFlyer.recordCrossPromoteImpression(丛七丞专丛丁丑万丆:  丗万丟万七专丗下丕, 不三世丒丟一丘专丛:  不三世丒丟一丘专丛, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            return;
            label_1:
            val_3 = "appId";
            goto label_5;
            label_2:
            val_3 = "campaign";
            label_5:
            null = new System.ArgumentNullException(paramName:  val_3);
        }
    
    }

}
