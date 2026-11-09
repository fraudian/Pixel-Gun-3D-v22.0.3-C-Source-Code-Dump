using UnityEngine;
internal sealed class SPViewComponentAllRewards : SPViewComponentBase
{
    // Fields
    private UIBasicSprite mainTexture;
    private ItemListUI allItemListUI;
    private int maxCount;
    private UnityEngine.GameObject andMoreGO;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> itemViews;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_7;
        PGCompany.东丑丆丗丏丐丟下丄 val_16;
        var val_17;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_16 = 且丘丏丁丑与丙与丁;
        mem[1152921539220329496] = val_16;
        if(this.mainTexture != null)
        {
                if(val_16 != null)
        {
                val_16 = val_16;
        }
        
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.mainTexture, 与万丆丛丒万丝丙丑:  val_16);
        }
        
        val_17 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.andMoreGO, 丏业丟一东丂东丘丛:  false);
        if(this.andMoreGO == null)
        {
                return;
        }
        
        if((this.maxCount & 2147483648) != 0)
        {
            goto label_8;
        }
        
        val_17 = public System.Int32 System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>::get_Count();
        if(this.andMoreGO.Count >= this.maxCount)
        {
            goto label_10;
        }
        
        if(this.andMoreGO == null)
        {
            goto label_28;
        }
        
        label_8:
        val_19 = this.andMoreGO;
        goto label_12;
        label_10:
        val_20 = 0;
        label_12:
        if(this.maxCount >= 1)
        {
                var val_4 = (X22.Count > this.maxCount) ? 1 : 0;
        }
        else
        {
                val_21 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.andMoreGO, 丏业丟一东丂东丘丛:  false);
        if(this.allItemListUI != null)
        {
                this.allItemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.andMoreGO.GetRange(index:  0, count:  this.maxCount));
        }
        
        List.Enumerator<T> val_5 = this.itemViews.GetEnumerator();
        label_26:
        if((253731952 & 1) == 0)
        {
            goto label_23;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_26;
        label_23:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_30;
        label_28:
        if(val_17 != 1)
        {
            goto label_29;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_30:
        val_22 = 0;
        goto label_31;
        label_44:
        PGCompany.三东丏不丗世丅丌丄 val_10 = X22.Item[0];
        this.itemViews.Item[0].Setup(丈丄不七三万丄丁不:  val_10);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemViews.Item[0], 丏业丟一东丂东丘丛:  true);
        val_22 = 1;
        label_31:
        val_16 = this.itemViews.Count;
        if(val_22 < (UnityEngine.Mathf.Min(a:  val_16, b:  val_10.Count)))
        {
            goto label_44;
        }
        
        return;
        label_29:
    }
    public SPViewComponentAllRewards()
    {
        this.maxCount = 0;
        val_1 = new PGBehaviour();
    }

}
