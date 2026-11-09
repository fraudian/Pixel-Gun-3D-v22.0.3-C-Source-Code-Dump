using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class AdResizedDelegator : IDelegator
    {
        // Fields
        public readonly com.amazon.mas.cpt.ads.AdResizedDelegate responseDelegate;
        
        // Methods
        public AdResizedDelegator(com.amazon.mas.cpt.ads.AdResizedDelegate responseDelegate)
        {
            this.responseDelegate = responseDelegate;
        }
        public void ExecuteSuccess()
        {
        
        }
        public void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objectDictionary)
        {
            this.responseDelegate.Invoke(adPosition:  com.amazon.mas.cpt.ads.AdPosition.CreateFromDictionary(jsonMap:  objectDictionary));
        }
        public void ExecuteError(com.amazon.mas.cpt.ads.AmazonException e)
        {
        
        }
    
    }

}
