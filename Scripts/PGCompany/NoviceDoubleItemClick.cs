using UnityEngine;

namespace PGCompany
{
    internal class NoviceDoubleItemClick : PGBehaviour
    {
        // Fields
        private int _offerIndex;
        private PGCompany.InventoryItemView 万丟下丙丈世且业丕;
        
        // Methods
        private void Awake()
        {
            this.万丟下丙丈世且业丕 = this.GetComponent<PGCompany.InventoryItemView>();
        }
        private void OnClick()
        {
            NoviceDoublePromotionView val_1 = this.GetComponentInParent<NoviceDoublePromotionView>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.丒与不丕三七一丘东(专万一万丌丞丛丟丛:  this.万丟下丙丈世且业丕, 东丑丞丛丆丝丅不三:  this._offerIndex);
        }
        public NoviceDoubleItemClick()
        {
        
        }
    
    }

}
