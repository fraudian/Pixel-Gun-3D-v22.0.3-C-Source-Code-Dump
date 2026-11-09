using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public abstract class AmazonMobileAdsImpl : MonoBehaviour, IAmazonMobileAds
    {
        // Fields
        private static com.amazon.mas.cpt.ads.AmazonLogger logger;
        private static readonly System.Collections.Generic.Dictionary<string, com.amazon.mas.cpt.ads.IDelegator> callbackDictionary;
        private static readonly object callbackLock;
        private static readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>> eventListeners;
        private static readonly object eventLock;
        
        // Properties
        public static com.amazon.mas.cpt.ads.IAmazonMobileAds Instance { get; }
        
        // Methods
        private AmazonMobileAdsImpl()
        {
        
        }
        public static com.amazon.mas.cpt.ads.IAmazonMobileAds get_Instance()
        {
            null = null;
            return (com.amazon.mas.cpt.ads.IAmazonMobileAds)AmazonMobileAdsImpl.Builder.instance;
        }
        public static void callback(string jsonMessage)
        {
            var val_8;
            string val_9;
            var val_10;
            val_8 = null;
            val_8 = null;
            AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  "Executing callback");
            object val_2 = 0.Item["callerId"];
            if(val_2 == null)
            {
                goto label_8;
            }
            
            var val_3 = (null == null) ? (val_2) : 0;
            if(1 != 0)
            {
                goto label_9;
            }
            
            goto label_11;
            label_8:
            val_9 = 0;
            if(1 == 0)
            {
                goto label_11;
            }
            
            label_9:
            label_11:
            if(0.Item["response"] != null)
            {
                    val_10 = 0;
            }
            
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.callbackCaller(response:  null, callerId:  val_9);
        }
        private static void callbackCaller(System.Collections.Generic.Dictionary<string, object> response, string callerId)
        {
            var val_5;
            var val_6;
            var val_7;
            com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  response);
            val_5 = null;
            val_5 = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.callbackLock, lockTaken: ref  val_1);
            val_6 = null;
            val_6 = null;
            val_7 = public System.Boolean System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.IDelegator>::Remove(System.String key);
            bool val_3 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.callbackDictionary.Remove(key:  callerId);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_7 = 1;
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.callbackDictionary.Item[callerId].ExecuteSuccess(objDict:  response);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.callbackLock);
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(67 != 67)
            {
                    return;
            }
            
                return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static void FireEvent(string jsonMessage)
        {
            var val_11;
            var val_16;
            string val_17;
            var val_18;
            var val_19;
            object val_20;
            var val_21;
            var val_22;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_16 = null;
            val_16 = null;
            AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  "eventReceived");
            if(jsonMessage != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  jsonMessage);
            }
            
            object val_2 = 0.Item["eventId"];
            if(val_2 == null)
            {
                goto label_8;
            }
            
            var val_3 = (null == null) ? (val_2) : 0;
            if(1 != 0)
            {
                goto label_9;
            }
            
            goto label_11;
            label_8:
            val_17 = 0;
            if(1 == 0)
            {
                goto label_11;
            }
            
            label_9:
            label_11:
            if((0.ContainsKey(key:  "response")) == false)
            {
                goto label_12;
            }
            
            object val_5 = 0.Item["response"];
            val_18 = 0;
            goto label_16;
            label_12:
            val_18 = 0;
            goto label_17;
            label_16:
            com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
            label_17:
            val_19 = null;
            val_19 = null;
            val_20 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock;
            bool val_7 = false;
            System.Threading.Monitor.Enter(obj:  val_20, lockTaken: ref  val_7);
            val_21 = null;
            val_21 = null;
            val_22 = public System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator> System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>>::get_Item(System.String key);
            List.Enumerator<T> val_9 = com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners.Item[val_17].GetEnumerator();
            label_37:
            if(((-1882496400) & 1) == 0)
            {
                goto label_24;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_22 = 1;
            val_11.丐丏七丌丕丗业且上().ExecuteSuccess(objDict:  null);
            goto label_37;
            label_24:
            val_25 = 0;
            val_26 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (173 == 173))
            {
                    val_25 = 0;
            }
            else
            {
                    if(null != null)
            {
                    val_26 = 0;
            }
            
            }
            
            val_28 = 0 + 1;
            mem2[0] = 186;
            goto label_56;
            label_74:
            if(com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag != 1)
            {
                goto label_57;
            }
            
            label_56:
            if(val_7 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_1);
            }
            
            if( != 1)
            {
                    if(null == null)
            {
                    return;
            }
            
                if(173 != 186)
            {
                    return;
            }
            
                return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            return;
            label_57:
            if(com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag != 1)
            {
                goto label_74;
            }
            
            if((null & 1) != 0)
            {
                    val_29 = null;
                val_29 = null;
                val_20 = "Event call threw exception: "("Event call threw exception: ") + 1152921504628731904;
                AmazonLogging.Log(reportLevel:  5, service:  com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.logger.tag, message:  val_20);
                return;
            }
            
            mem[8] = null;
            val_27 = 8;
            goto label_74;
        }
        public abstract void SetApplicationKey(com.amazon.mas.cpt.ads.ApplicationKey applicationKey); // 0
        public abstract void RegisterApplication(); // 0
        public abstract void EnableLogging(com.amazon.mas.cpt.ads.ShouldEnable shouldEnable); // 0
        public abstract void EnableTesting(com.amazon.mas.cpt.ads.ShouldEnable shouldEnable); // 0
        public abstract void EnableGeoLocation(com.amazon.mas.cpt.ads.ShouldEnable shouldEnable); // 0
        public abstract com.amazon.mas.cpt.ads.Ad CreateFloatingBannerAd(com.amazon.mas.cpt.ads.Placement placement); // 0
        public abstract com.amazon.mas.cpt.ads.Ad CreateInterstitialAd(); // 0
        public abstract com.amazon.mas.cpt.ads.LoadingStarted LoadAndShowFloatingBannerAd(com.amazon.mas.cpt.ads.Ad ad); // 0
        public abstract com.amazon.mas.cpt.ads.LoadingStarted LoadInterstitialAd(); // 0
        public abstract com.amazon.mas.cpt.ads.AdShown ShowInterstitialAd(); // 0
        public abstract void CloseFloatingBannerAd(com.amazon.mas.cpt.ads.Ad ad); // 0
        public abstract com.amazon.mas.cpt.ads.IsReady IsInterstitialAdReady(); // 0
        public abstract com.amazon.mas.cpt.ads.IsEqual AreAdsEqual(com.amazon.mas.cpt.ads.AdPair adPair); // 0
        public abstract void UnityFireEvent(string jsonMessage); // 0
        public abstract void AddAdCollapsedListener(com.amazon.mas.cpt.ads.AdCollapsedDelegate responseDelegate); // 0
        public abstract void RemoveAdCollapsedListener(com.amazon.mas.cpt.ads.AdCollapsedDelegate responseDelegate); // 0
        public abstract void AddAdDismissedListener(com.amazon.mas.cpt.ads.AdDismissedDelegate responseDelegate); // 0
        public abstract void RemoveAdDismissedListener(com.amazon.mas.cpt.ads.AdDismissedDelegate responseDelegate); // 0
        public abstract void AddAdExpandedListener(com.amazon.mas.cpt.ads.AdExpandedDelegate responseDelegate); // 0
        public abstract void RemoveAdExpandedListener(com.amazon.mas.cpt.ads.AdExpandedDelegate responseDelegate); // 0
        public abstract void AddAdFailedToLoadListener(com.amazon.mas.cpt.ads.AdFailedToLoadDelegate responseDelegate); // 0
        public abstract void RemoveAdFailedToLoadListener(com.amazon.mas.cpt.ads.AdFailedToLoadDelegate responseDelegate); // 0
        public abstract void AddAdLoadedListener(com.amazon.mas.cpt.ads.AdLoadedDelegate responseDelegate); // 0
        public abstract void RemoveAdLoadedListener(com.amazon.mas.cpt.ads.AdLoadedDelegate responseDelegate); // 0
        public abstract void AddAdResizedListener(com.amazon.mas.cpt.ads.AdResizedDelegate responseDelegate); // 0
        public abstract void RemoveAdResizedListener(com.amazon.mas.cpt.ads.AdResizedDelegate responseDelegate); // 0
        private static AmazonMobileAdsImpl()
        {
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.callbackDictionary = new System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.IDelegator>();
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.callbackLock = new System.Object();
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventListeners = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<com.amazon.mas.cpt.ads.IDelegator>>();
            com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.eventLock = new System.Object();
        }
    
    }

}
