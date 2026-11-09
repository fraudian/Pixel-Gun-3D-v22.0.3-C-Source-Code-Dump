using UnityEngine;

namespace Prime31
{
    public static class GooglePurchaesFix
    {
        // Methods
        public static Prime31.GooglePurchase.GooglePurchaseState getPurchaseState(Prime31.GooglePurchase purchase)
        {
            return (GooglePurchaseState)((purchase.<purchaseState>k__BackingField) == 4) ? (1 + 1) : 1;
        }
    
    }

}
