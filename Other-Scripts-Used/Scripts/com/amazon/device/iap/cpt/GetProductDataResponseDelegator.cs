using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class GetProductDataResponseDelegator : IDelegator
    {
        // Fields
        public readonly com.amazon.device.iap.cpt.GetProductDataResponseDelegate responseDelegate;
        
        // Methods
        public GetProductDataResponseDelegator(com.amazon.device.iap.cpt.GetProductDataResponseDelegate responseDelegate)
        {
            this.responseDelegate = responseDelegate;
        }
        public void ExecuteSuccess()
        {
        
        }
        public void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objectDictionary)
        {
            this.responseDelegate.Invoke(eventName:  com.amazon.device.iap.cpt.GetProductDataResponse.CreateFromDictionary(jsonMap:  objectDictionary));
        }
        public void ExecuteError(com.amazon.device.iap.cpt.AmazonException e)
        {
        
        }
    
    }

}
