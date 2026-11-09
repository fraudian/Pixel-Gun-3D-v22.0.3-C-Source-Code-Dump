using UnityEngine;
internal sealed class ManualPromotionBanner : BannerWindowLobbyPurchase
{
    // Fields
    private MainStorePromotionView promotionView;
    private bool _isPresentationBanner;
    private UnityEngine.Color 世下丕东七丆丆专三;
    private bool 丁丝丌丞与丑丂三上;
    
    // Methods
    protected override void OnEnable()
    {
        var val_6;
        System.Action val_8;
        this.promotionView.丟东东丅业丂丏丁丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ManualPromotionBanner::世世丑丞丒丟业丁与()));
        this.OnEnable();
        UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        this.世下丕东七丆丆专三 = val_2;
        mem[1152921539274994456] = val_2.g;
        mem[1152921539274994460] = val_2.b;
        mem[1152921539274994464] = val_2.a;
        this.丁丝丌丞与丑丂三上 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
        val_6 = null;
        val_6 = null;
        val_8 = ManualPromotionBanner.<>c.<>9__4_0;
        if(val_8 == null)
        {
                System.Action val_5 = null;
            val_8 = val_5;
            val_5 = new System.Action(object:  ManualPromotionBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ManualPromotionBanner.<>c::丆丂丆三丆丌丞七丞());
            ManualPromotionBanner.<>c.<>9__4_0 = val_8;
        }
        
        CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  val_5);
    }
    protected override void OnDisable()
    {
        this.promotionView.丒世丐世丙丄丄且下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ManualPromotionBanner::世世丑丞丒丟业丁与()));
        this.OnDisable();
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.丁丝丌丞与丑丂三上);
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
        CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void ManualPromotionBanner::世丌丌不丒上世世丌()));
    }
    public override void Show()
    {
        var val_9;
        this.Show();
        PGCompany.ManualOffers.与丈三上丗不丝丐丛 val_1 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世();
        if(val_1 == null)
        {
            goto label_0;
        }
        
        if(this._isPresentationBanner == false)
        {
            goto label_1;
        }
        
        label_3:
        val_9 = 0;
        PGCompany.StorePromotionConfig val_2 = val_1.丝一丐万东丄业丛万();
        goto label_2;
        label_0:
        if(this._isPresentationBanner == true)
        {
            goto label_3;
        }
        
        label_1:
        val_9 = 0;
        PGCompany.StorePromotionConfig val_3 = val_1.丕丟与世丛丄丟丙丘();
        label_2:
        if(val_3 != null)
        {
                if(this._isPresentationBanner != false)
        {
                PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().丐七一世丛丕丘万七(一丗与一专丙丙丅丄:  val_3.Identificator);
        }
        
            PGCompany.ManualOffers.与丈三上丗不丝丐丛 val_6 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世();
            val_6.丐丒三下丛丟业业丑(一丗与一专丙丙丅丄:  val_3.Identificator);
            this.promotionView.丒丛丐丐丑丈世专丑(丐丆丝业丙丈下世丁:  val_6.丝与丘丘丅业一业丘(且世丒下丟不三丟丘:  val_3));
            return;
        }
        
        this.Hide();
    }
    private PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(PGCompany.StorePromotionConfig 且世丒下丟不三丟丘)
    {
        PGCompany.MainStore.世专丟丕丝丝专东一 val_13 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丗与与且丕万丘三丛(丙丐万丗丁丏丞专丄:  "manual");
        if(val_13 == null)
        {
                return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)val_13;
        }
        
        .丄丑丘专丄七不专丆 = val_13.丙业丆丘万丙专万丟();
        .丘丏丐丞丈专三且世 = val_13.丅上万丛一丐上上丕();
        .下丐丐丁与丂下世七 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        PGCompany.StorePromotionSettings val_7 = 且世丒下丟不三丟丘.Settings;
        List.Enumerator<T> val_8 = val_7.ItemsParams.GetEnumerator();
        label_13:
        if((308901624 & 1) == 0)
        {
            goto label_7;
        }
        
        string val_9 = 0.丐丏七丌丕丗业且上();
        if(val_9 == null)
        {
            goto label_13;
        }
        
        new PGCompany.丄与丘丑业专丞七丅() = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_9);
        bool val_11 = (PGCompany.丄与丘丑业专丞七丅)[1152921539275572048].Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "reward-main");
        (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921539275543376].下丐丐丁与丂下世七.Add(item:  new PGCompany.丄与丘丑业专丞七丅());
        goto label_13;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_12 = null;
        val_13 = val_12;
        val_12 = new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  且世丒下丟不三丟丘, 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
        return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)val_13;
    }
    private void 丒丛丐丐丑丈世专丑(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        string val_15;
        var val_16;
        var val_17;
        if(丐丆丝业丙丈下世丁 != null)
        {
                val_15 = "Offer";
        }
        else
        {
                val_15 = "Offer";
        }
        
        val_16 = 0;
        if(丐丆丝业丙丈下世丁.上丟丄与丁三丌丘专() >= 1)
        {
                val_16 = 0;
            var val_5 = (PixelTime.丙丅丅业丟丁世丁丗() < (丐丆丝业丙丈下世丁.上丟丄与丁三丌丘专() << )) ? 1 : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丗下一不丘丑丅业且:  丐丆丝业丙丈下世丁.丂丁丏一丙丛业且丌(), 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  null, 一丑丑丝丏且丂丏丘:  ((PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().专与丁丝丒丟丐业世(一丗与一专丙丙丅丄:  丐丆丝业丙丈下世丁.七丈丒丒下下且万与())) != true) ? "FirstTime" : "Timer");
        bool val_14 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().东七丙三丌丘一不丙(一丗与一专丙丙丅丄:  丐丆丝业丙丈下世丁.七丈丒丒下下且万与());
    }
    private void 世世丑丞丒丟业丁与()
    {
        this.Hide();
    }
    public override void Back()
    {
        this.Back();
        this.Hide();
    }
    protected override void OnDestroy()
    {
        this.promotionView.丒世丐世丙丄丄且下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ManualPromotionBanner::世世丑丞丒丟业丁与()));
        this.OnDestroy();
    }
    public ManualPromotionBanner()
    {
    
    }
    private void 世丌丌不丒上世世丌()
    {
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
    }

}
