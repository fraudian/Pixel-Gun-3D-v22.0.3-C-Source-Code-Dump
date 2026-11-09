using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class GetPurchaseUpdatesResponseDelegator : IDelegator
    {
        // Fields
        public readonly com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate responseDelegate;
        
        // Methods
        public GetPurchaseUpdatesResponseDelegator(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate responseDelegate)
        {
            this.responseDelegate = responseDelegate;
        }
        public void ExecuteSuccess()
        {
        
        }
        public void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objectDictionary)
        {
            this.responseDelegate.Invoke(eventName:  com.amazon.device.iap.cpt.GetPurchaseUpdatesResponse.CreateFromDictionary(jsonMap:  objectDictionary));
        }
        public void ExecuteError(com.amazon.device.iap.cpt.AmazonException e)
        {
        
        }
    
    }

}
