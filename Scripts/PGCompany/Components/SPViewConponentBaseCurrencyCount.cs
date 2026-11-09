using UnityEngine;

namespace PGCompany.Components
{
    internal class SPViewConponentBaseCurrencyCount : SPViewComponentBase
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        
        // Methods
        public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            this.gameObject.SetActive(value:  false);
            if(this._itemView == 0)
            {
                    return;
            }
            
            if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "view.show.currency-count-base")) == false)
            {
                    return;
            }
            
            if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "reward-bonus")) == false)
            {
                    return;
            }
            
            if(且丘丏丁丑与丙与丁 == null)
            {
                    return;
            }
            
            var val_7 = (((PGCompany.东丑丆丗丏丐丟下丄.__il2cppRuntimeField_typeHierarchy + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 且丘丏丁丑与丙与丁 : 0;
        }
        public SPViewConponentBaseCurrencyCount()
        {
        
        }
    
    }

}
