using UnityEngine;

namespace com.amazon.device.iap.cpt
{
    public interface IAmazonIapV2
    {
        // Methods
        public abstract com.amazon.device.iap.cpt.RequestOutput GetUserData(); // 0
        public abstract com.amazon.device.iap.cpt.RequestOutput Purchase(com.amazon.device.iap.cpt.SkuInput skuInput); // 0
        public abstract com.amazon.device.iap.cpt.RequestOutput GetProductData(com.amazon.device.iap.cpt.SkusInput skusInput); // 0
        public abstract com.amazon.device.iap.cpt.RequestOutput GetPurchaseUpdates(com.amazon.device.iap.cpt.ResetInput resetInput); // 0
        public abstract void NotifyFulfillment(com.amazon.device.iap.cpt.NotifyFulfillmentInput notifyFulfillmentInput); // 0
        public abstract void UnityFireEvent(string jsonMessage); // 0
        public abstract void AddGetUserDataResponseListener(com.amazon.device.iap.cpt.GetUserDataResponseDelegate responseDelegate); // 0
        public abstract void RemoveGetUserDataResponseListener(com.amazon.device.iap.cpt.GetUserDataResponseDelegate responseDelegate); // 0
        public abstract void AddPurchaseResponseListener(com.amazon.device.iap.cpt.PurchaseResponseDelegate responseDelegate); // 0
        public abstract void RemovePurchaseResponseListener(com.amazon.device.iap.cpt.PurchaseResponseDelegate responseDelegate); // 0
        public abstract void AddGetProductDataResponseListener(com.amazon.device.iap.cpt.GetProductDataResponseDelegate responseDelegate); // 0
        public abstract void RemoveGetProductDataResponseListener(com.amazon.device.iap.cpt.GetProductDataResponseDelegate responseDelegate); // 0
        public abstract void AddGetPurchaseUpdatesResponseListener(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate responseDelegate); // 0
        public abstract void RemoveGetPurchaseUpdatesResponseListener(com.amazon.device.iap.cpt.GetPurchaseUpdatesResponseDelegate responseDelegate); // 0
    
    }

}
