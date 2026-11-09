using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class AdExpandedDelegator : IDelegator
    {
        // Fields
        public readonly com.amazon.mas.cpt.ads.AdExpandedDelegate responseDelegate;
        
        // Methods
        public AdExpandedDelegator(com.amazon.mas.cpt.ads.AdExpandedDelegate responseDelegate)
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
