using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public sealed class GetUserDataResponseDelegator : IDelegator
    {
        // Fields
        public readonly com.amazon.device.iap.cpt.GetUserDataResponseDelegate responseDelegate;
        
        // Methods
        public GetUserDataResponseDelegator(com.amazon.device.iap.cpt.GetUserDataResponseDelegate responseDelegate)
        {
            this.responseDelegate = responseDelegate;
        }
        public void ExecuteSuccess()
        {
        
        }
        public void ExecuteSuccess(System.Collections.Generic.Dictionary<string, object> objectDictionary)
        {
            this.responseDelegate.Invoke(eventName:  com.amazon.device.iap.cpt.GetUserDataResponse.CreateFromDictionary(jsonMap:  objectDictionary));
        }
        public void ExecuteError(com.amazon.device.iap.cpt.AmazonException e)
        {
        
        }
    
    }

}
