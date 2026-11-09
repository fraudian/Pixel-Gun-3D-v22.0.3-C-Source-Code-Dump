using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public interface IAmazonMobileAds
    {
        // Methods
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
    
    }

}
