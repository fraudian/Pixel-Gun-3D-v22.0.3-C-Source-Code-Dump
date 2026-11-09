using UnityEngine;
internal sealed class ShowItemViewerOnClickMainStore : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView _itemView;
    private bool _consideringTierOnlyForEventWeapons;
    private bool _forceCurrentEfficiency;
    private bool _possibleStackViewers;
    
    // Methods
    private void OnClick()
    {
        UnityEngine.Object val_23;
        if(this._itemView == 0)
        {
                return;
        }
        
        if(this._itemView.Context == null)
        {
                return;
        }
        
        if((MainStoreView.丑七不且上丗丁一世() == 0) || (MainStoreView.丑七不且上丗丁一世().gameObject.activeInHierarchy == false))
        {
            goto label_11;
        }
        
        MainStoreView val_8 = MainStoreView.丑七不且上丗丁一世();
        goto label_12;
        label_11:
        val_23 = 0;
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
            goto label_22;
        }
        
        val_23 = 0;
        if(BannerWindowController.与丅与丒丅专丙丐丗().gameObject.activeInHierarchy == false)
        {
            goto label_22;
        }
        
        label_12:
        val_23 = BannerWindowController.与丅与丒丅专丙丐丗().transform;
        label_22:
        if(val_23 == 0)
        {
                return;
        }
        
        PGCompany.万丞丘与丕丞下万丌.万与东世与丒丌东丕(丆丏七丟不丒与七专:  val_23, 下丅丙一丂丗丅丝七:  this._itemView.Context, 东业丒一丟丝下丌丄:  this._itemView.丙丕丄万业与下七丁(), 业万丒丌丗丄东丁丕:  (this._consideringTierOnlyForEventWeapons == true) ? 1 : 0, 丟丏七下业丄丟丐丗:  (this._forceCurrentEfficiency == true) ? 1 : 0, 丒不业且丄丅世世下:  (this._possibleStackViewers == true) ? 1 : 0);
    }
    public ShowItemViewerOnClickMainStore()
    {
    
    }

}
