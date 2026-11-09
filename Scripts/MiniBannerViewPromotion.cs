using UnityEngine;
internal sealed class MiniBannerViewPromotion : UniversalMiniBannerView
{
    // Fields
    private StorePromotionViewBase promotionView;
    
    // Properties
    private PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝 { get; }
    
    // Methods
    private PGCompany.东丑丆丗丏丐丟下丄 与丞丆丑东东丟丆丌()
    {
        if(this.promotionView != null)
        {
                return this.promotionView.与丞丆丑东东丟丆丌();
        }
        
        return this.promotionView.与丞丆丑东东丟丆丌();
    }
    internal void 丈且东丑丂且万丒丅(不专丞丘世七丈丙丞 丄一世丁上丅丘东丈, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_8;
        StorePromotionViewBase val_9;
        val_8 = 且丘丏丁丑与丙与丁;
        this.丈且东丑丂且万丒丅(丄一世丁上丅丘东丈:  丄一世丁上丅丘东丈);
        val_9 = this.promotionView;
        if(val_9 == 0)
        {
                return;
        }
        
        val_8 = ???;
        val_9 = ???;
        goto typeof(StorePromotionViewBase).__il2cppRuntimeField_178;
    }
    public void U_ShowPromotionInfo()
    {
        PGCompany.与万丝丞下丒丗丏丙 val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.与万丝丞下丒丗丏丙>(source:  PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().丟业不业一丈丘丗丁(), predicate:  new System.Func<PGCompany.与万丝丞下丒丗丏丙, System.Boolean>(object:  this, method:  System.Boolean MiniBannerViewPromotion::世丝丌丗丌丟丐且丆(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万)));
        if(val_4 == null)
        {
                return;
        }
        
        UniversalPromotionBanner.ShowBanner(丄丘七三上丕世丞业:  val_4, 丘丒丅三丞丞丛丛丌:  0);
    }
    public void U_ShowStorePromotionInfo()
    {
        StorePromotionInfoBanner.ShowBanner(且丘丏丁丑与丙与丁:  this.与丞丆丑东东丟丆丌(), 丘丒丅三丞丞丛丛丌:  0);
    }
    public MiniBannerViewPromotion()
    {
    
    }
    private bool 世丝丌丗丌丟丐且丆(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万)
    {
        PGCompany.专丟专世丅丂丁且专 val_4 = this.与丞丆丑东东丟丆丌().七丈丒丒下下且万与();
        var val_6 = 0;
        val_6 = val_6 + 1;
        return 三且丑上丕上丅丁万.丂下丏且一丈与下三().七丈丒丒下下且万与().Equals(other:  null);
    }

}
