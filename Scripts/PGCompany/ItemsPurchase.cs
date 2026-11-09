using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ItemsPurchase
    {
        // Fields
        internal int Date;
        internal int Real;
        internal System.Collections.Generic.List<Rilisoft.CuttedOfferItem> Items;
        
        // Methods
        public ItemsPurchase()
        {
        
        }
    
    }

}
