using UnityEngine;

namespace PGCompany
{
    internal sealed class ShowItemInfoScreenOnClick : PGBehaviour
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        private UnityEngine.Transform _targetTransform;
        private bool _consideringTierOnlyForEventWeapons;
        private bool _forceCurrentEfficiency;
        private bool _possibleStackViewers;
        
        // Methods
        private void OnClick()
        {
            if(this._itemView == 0)
            {
                    return;
            }
            
            if(this._itemView.Context == null)
            {
                    return;
            }
            
            if(this._targetTransform == 0)
            {
                    return;
            }
            
            PGCompany.万丞丘与丕丞下万丌.万与东世与丒丌东丕(丆丏七丟不丒与七专:  this._targetTransform, 下丅丙一丂丗丅丝七:  this._itemView.Context, 东业丒一丟丝下丌丄:  this._itemView.丙丕丄万业与下七丁(), 业万丒丌丗丄东丁丕:  (this._consideringTierOnlyForEventWeapons == true) ? 1 : 0, 丟丏七下业丄丟丐丗:  (this._forceCurrentEfficiency == true) ? 1 : 0, 丒不业且丄丅世世下:  (this._possibleStackViewers == true) ? 1 : 0);
        }
        public ShowItemInfoScreenOnClick()
        {
        
        }
    
    }

}
