using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class PurchaseResponseDelegator : IDelegator
    {
        // Fields
        public readonly com.amazon.device.iap.cpt.PurchaseResponseDelegate responseDelegate;
        
        // Methods
        public PurchaseResponseDelegator(com.amazon.device.iap.cpt.PurchaseResponseDelegate responseDelegate)
        {
            this.responseDelegate = responseDelegate;
        }
        public void ExecuteSuccess()
        {
        
        }
        public void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objectDictionary)
        {
            this.responseDelegate.Invoke(eventName:  com.amazon.device.iap.cpt.PurchaseResponse.CreateFromDictionary(jsonMap:  objectDictionary));
        }
        public void ExecuteError(com.amazon.device.iap.cpt.AmazonException e)
        {
        
        }
    
    }

}
