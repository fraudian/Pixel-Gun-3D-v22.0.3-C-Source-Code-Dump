using UnityEngine;
internal sealed class MainStorePromotionTierBundleInfoUI : MainStorePromotionInfoUI
{
    // Fields
    private StorePromotionSelectorView novicePromotionView;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, object 一丐丗丁丞丆丅丟丄, PGCompany.丞丙上世丑丕与丁丁 且丒丛与丞世丙丕丌 = 0)
    {
        var val_8;
        PGCompany.东丑丆丗丏丐丟下丄 val_14;
        StorePromotionSelectorView val_15;
        var val_16;
        val_14 = 且丘丏丁丑与丙与丁;
        val_15 = this;
        this.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  val_14, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 且丒丛与丞世丙丕丌:  0);
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_2 == null)
        {
                return;
        }
        
        val_16 = val_2.丗不丞一且丟丈丈丗();
        if(val_16 == null)
        {
                return;
        }
        
        if(val_14 == null)
        {
                return;
        }
        
        if(val_16.Count == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_5 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
        List.Enumerator<T> val_6 = val_16.GetEnumerator();
        label_11:
        if((286324976 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        if(val_9 == null)
        {
            goto label_11;
        }
        
        val_5.Add(item:  val_9);
        goto label_11;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_15 = this.novicePromotionView;
        val_15.丈且东丑丂且万丒丅(七丄丆丘丒与丐丘丅:  val_5, 丛丗七丅下丞丗且丐:  val_14);
        val_14 = 0.丞丂上世丌丒世下七();
        val_2.世丅万丛与万万七万(万丏丗丗丅丄丌业一:  val_14.丏不丁丛丕丒丏丆丂());
    }
    public MainStorePromotionTierBundleInfoUI()
    {
    
    }

}
