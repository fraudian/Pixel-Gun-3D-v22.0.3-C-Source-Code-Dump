using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class AdLoadedDelegator : IDelegator
    {
        // Fields
        public readonly com.amazon.mas.cpt.ads.AdLoadedDelegate responseDelegate;
        
        // Methods
        public AdLoadedDelegator(com.amazon.mas.cpt.ads.AdLoadedDelegate responseDelegate)
        {
            this.responseDelegate = responseDelegate;
        }
        public void ExecuteSuccess()
        {
        
        }
        public void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objectDictionary)
        {
            this.responseDelegate.Invoke(adObject:  com.amazon.mas.cpt.ads.Ad.CreateFromDictionary(jsonMap:  objectDictionary));
        }
        public void ExecuteError(com.amazon.mas.cpt.ads.AmazonException e)
        {
        
        }
    
    }

}
