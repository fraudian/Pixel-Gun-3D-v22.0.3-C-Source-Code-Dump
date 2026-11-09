using UnityEngine;
internal sealed class NovicePromotionSelectorBanner : BannerWindowLobbyPurchase
{
    // Fields
    private static System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 丛东丛且丁丝丟丑丟;
    private static PGCompany.丒丌业一丕丘丐世专 万丗丆专丝丝丝七丆;
    private StorePromotionSelectorView selectorView;
    private UnityEngine.GameObject lightHolder;
    private UnityEngine.GameObject _blockContainer;
    private System.Nullable<UnityEngine.Color> 与丕专丛世丛丅丒东;
    private System.Nullable<bool> 专丆丐丙丒丌七东丙;
    private System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 不丅上丏丐一丟丆丞;
    
    // Methods
    internal static void 下下且丅丆丐丞且丒(System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 七丄丆丘丒与丐丘丅, PGCompany.丒丌业一丕丘丐世专 丛丗七丅下丞丗且丐)
    {
        PGCompany.丒丌业一丕丘丐世专 val_2 = 丛丗七丅下丞丗且丐;
        NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 = 七丄丆丘丒与丐丘丅;
        NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆 = val_2;
        if(NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 != null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专>();
        NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 = val_2;
    }
    public static void ShowBanner(System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 七丄丆丘丒与丐丘丅, PGCompany.丒丌业一丕丘丐世专 丛丗七丅下丞丗且丐)
    {
        NovicePromotionSelectorBanner.下下且丅丆丐丞且丒(七丄丆丘丒与丐丘丅:  七丄丆丘丒与丐丘丅, 丛丗七丅下丞丗且丐:  丛丗七丅下丞丗且丐);
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  66, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public override void Show()
    {
        var val_12;
        var val_13;
        var val_14;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_15;
        val_12 = this;
        this.Show();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._blockContainer, 丏业丟一东丂东丘丛:  (~coinsShop.七三丗丏丑丗三丆世()) & 1);
        val_13 = Rilisoft.Offers.丆不丛丈丒丁专丂丅 Rilisoft.丗下丙丅且丐丞丙世::下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丗与丟上上丑专世丗);
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_4 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_4 != null)
        {
                val_13 = 0;
            val_4.丅丕丈丒一业丏上且(丙业与丙丗丝不丈东:  true);
        }
        
        if(NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 == null)
        {
            goto label_9;
        }
        
        if(NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟.Count == 0)
        {
            goto label_10;
        }
        
        val_14 = 0;
        goto label_12;
        label_9:
        NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟.丂丑丕丙专丈丝丙丟();
        val_14 = 1;
        goto label_12;
        label_10:
        if(val_4 != null)
        {
                System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_6 = val_4.丗不丞一且丟丈丈丗();
        }
        else
        {
                val_15 = 0;
        }
        
        val_14 = 0;
        NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 = val_15;
        label_12:
        if((NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 == null) || (NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟.Count < 1))
        {
            goto label_16;
        }
        
        this.丈且东丑丂且万丒丅(七丄丆丘丒与丐丘丅:  NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟, 丛丗七丅下丞丗且丐:  NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆);
        this.丁万丅丁丝丝丝丛丒(丗丐丏一丛丈丛上丙:  false);
        if(val_14 == 0)
        {
            goto label_24;
        }
        
        val_12 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_12 == null)
        {
            goto label_24;
        }
        
        val_12.世丅万丛与万万七万(丗丟丁丐与下丙丕丛:  NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆.丞丂上世丌丒世下七().丏不丁丛丕丒丏丆丂());
        goto label_24;
        label_16:
        UnityEngine.Debug.LogError(message:  "!!! ALARMA !!!  Nothing to show!");
        label_24:
        NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 = 0;
        NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆 = 0;
    }
    public override void Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lightHolder, 丏业丟一东丂东丘丛:  false);
        this.Hide();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    protected override void OnEnable()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_7 = null;
            val_7 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        mem[1152921539293672912] = 0;
        this.与丕专丛世丛丅丒东 = 0;
        bool val_4 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        this.专丆丐丙丒丌七东丙 = 0;
        UnityEngine.Color val_5 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lightHolder, 丏业丟一东丂东丘丛:  true);
        this.不与丞下业丑丒丙万();
        this.下丌业业丐丘丐丘三();
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = null;
        val_7 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_8 = null;
            val_8 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        if(this.与丕专丛世丛丅丒东.HasValue != false)
        {
            
        }
        else
        {
                UnityEngine.Color val_3 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        if((327191276 & 1) != 0)
        {
                bool val_4 = this.专丆丐丙丒丌七东丙.GetValueOrDefault();
        }
        else
        {
                val_9 = 0;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙());
        this.不与丞下业丑丒丙万();
        this.OnDisable();
    }
    protected override void OnDestroy()
    {
        this.不与丞下业丑丒丙万();
        this.OnDestroy();
    }
    private void 下丌业业丐丘丐丘三()
    {
        this.selectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionSelectorBanner::OnSelect()));
        PGCompany.丌与丛丕业丈不丐世.丅丂且三丂丟丒业丕(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void NovicePromotionSelectorBanner::丞丑业丅丕丅丄丛丒(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
        PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void NovicePromotionSelectorBanner::且一丗丘不七丏丞丈(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七, object 一丐丗丁丞丆丅丟丄)));
    }
    private void 不与丞下业丑丒丙万()
    {
        this.selectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NovicePromotionSelectorBanner::OnSelect()));
        PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void NovicePromotionSelectorBanner::丞丑业丅丕丅丄丛丒(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
        PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void NovicePromotionSelectorBanner::且一丗丘不七丏丞丈(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七, object 一丐丗丁丞丆丅丟丄)));
    }
    private void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 七丄丆丘丒与丐丘丅, PGCompany.丒丌业一丕丘丐世专 丛丗七丅下丞丗且丐)
    {
        this.不丅上丏丐一丟丆丞 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
        if(七丄丆丘丒与丐丘丅 == null)
        {
            goto label_9;
        }
        
        List.Enumerator<T> val_2 = 七丄丆丘丒与丐丘丅.GetEnumerator();
        label_5:
        if((327736488 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if(val_3 == null)
        {
            goto label_5;
        }
        
        this.不丅上丏丐一丟丆丞.Add(item:  val_3);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_9:
        this.selectorView.丈且东丑丂且万丒丅(七丄丆丘丒与丐丘丅:  this.不丅上丏丐一丟丆丞, 丛丗七丅下丞丗且丐:  丛丗七丅下丞丗且丐);
    }
    public void U_ShootButtonPressed()
    {
    
    }
    public void U_BuyButtonPressed()
    {
    
    }
    public static bool CanShowAutomaticaly()
    {
        if(PGCompany.丁东丌世与丕东丆上.丑丅不一不七丒业业() == false)
        {
                return false;
        }
        
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_3 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_3 == null)
        {
                return false;
        }
        
        return val_3.丟世丙丛业丏东与七();
    }
    private void 丂丑丕丙专丈丝丙丟()
    {
        var val_12;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_13;
        NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 = 0;
        NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆 = 0;
        val_12 = 1152921505476546560;
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_2 != null)
        {
                val_13 = val_2.丗不丞一且丟丈丈丗();
        }
        else
        {
                val_13 = 0;
        }
        
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_5 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_5 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<System.Int32> val_6 = val_5.丑丆丛业丞下丆业丁();
        if(val_13 == 0)
        {
                return;
        }
        
        if(val_6 == null)
        {
                return;
        }
        
        if(val_6.Count < 1)
        {
                return;
        }
        
        val_12 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_12 == null)
        {
                return;
        }
        
        PGCompany.丒丌业一丕丘丐世专 val_11 = val_12.丅专上东下丕丄丗丅(丞丅上丏丂且下丅与:  System.Linq.Enumerable.FirstOrDefault<System.Int32>(source:  val_6));
        if(val_11 == null)
        {
                return;
        }
        
        NovicePromotionSelectorBanner.丛东丛且丁丝丟丑丟 = val_13;
        NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆 = val_11;
    }
    private void 丁万丅丁丝丝丝丛丒(bool 丗丐丏一丛丈丛上丙)
    {
        string val_10;
        if(NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆 == null)
        {
                return;
        }
        
        if(丗丐丏一丛丈丛上丙 == false)
        {
            goto label_4;
        }
        
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_3 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_3 == null)
        {
            goto label_8;
        }
        
        var val_7 = ((val_3.丁丕丄丈丅七业丗丝(万丏丗丗丅丄丌业一:  NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆.丞丂上世丌丒世下七().丏不丁丛丕丒丏丆丂())) > 0) ? "Timer" : "FirstTime";
        goto label_11;
        label_4:
        val_10 = "ByUser";
        goto label_12;
        label_8:
        val_10 = "FirstTime";
        label_12:
        label_11:
        PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丗下一不丘丑丅业且:  NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆.丂丁丏一丙丛业且丌(), 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  NovicePromotionSelectorBanner.万丗丆专丝丝丝七丆, 一丑丑丝丏且丂丏丘:  val_10);
    }
    private void OnSelect()
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_1 = this.selectorView.丌丂专七丞丑丁丐丆();
    }
    private void 且一丗丘不七丏丞丈(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七, object 一丐丗丁丞丆丅丟丄)
    {
        if(this.isActiveAndEnabled == false)
        {
                return;
        }
        
        goto typeof(NovicePromotionSelectorBanner).__il2cppRuntimeField_218;
    }
    private void 丞丑业丅丕丅丄丛丒(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
    {
        System.Collections.Generic.List<System.String> val_20;
        long val_21;
        var val_22;
        var val_24;
        val_21 = 丂丈丗丄不丅丅丙丒;
        if(this.isActiveAndEnabled == false)
        {
                return;
        }
        
        val_20 = BankController.丑七不且上丗丁一世();
        if(val_20.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        val_20 = 丂丈丗丄不丅丅丙丒.OfferItemsInfo;
        val_22 = null;
        val_22 = null;
        if((NovicePromotionSelectorBanner.<>c.<>9__26_0) == null)
        {
            goto label_9;
        }
        
        label_28:
        if((val_20.Exists(match:  NovicePromotionSelectorBanner.<>c.<>9__26_0)) == false)
        {
                return;
        }
        
        val_20 = this.selectorView;
        if(val_20.丌丂专七丞丑丁丐丆() == null)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        val_20 = NovicePromotionSelectorBanner.<>c.<>9__26_1;
        if(val_20 == null)
        {
                System.Predicate<PGCompany.三东丏不丗世丅丌丄> val_7 = null;
            val_20 = val_7;
            val_7 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  NovicePromotionSelectorBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NovicePromotionSelectorBanner.<>c::丐丒下三丒丌专且丄(PGCompany.三东丏不丗世丅丌丄 与丛丗丈七专上丕丏));
            NovicePromotionSelectorBanner.<>c.<>9__26_1 = val_20;
        }
        
        if((this.selectorView.丌丂专七丞丑丁丐丆().Exists(match:  val_7)) == false)
        {
                return;
        }
        
        PGCompany.丌不丞丐世丞三丘丌 val_9 = new PGCompany.丌不丞丐世丞三丘丌();
        if(val_9 == null)
        {
            goto label_23;
        }
        
        .Type = 5;
        .ToBuyWindow = true;
        val_21 = 丂丈丗丄不丅丅丙丒.ServerTime;
        goto label_24;
        label_9:
        NovicePromotionSelectorBanner.<>c.<>9__26_0 = new System.Predicate<System.String>(object:  NovicePromotionSelectorBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NovicePromotionSelectorBanner.<>c::万丂与丈丕上丐丂三(string 世万丏丛且下世丞且));
        if(val_20 != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_23:
        mem[16] = 5;
        mem[72] = 1;
        val_21 = 丂丈丗丄不丅丅丙丒.ServerTime;
        label_24:
        .丛与丘业三上丛下东 = val_21;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_9)) == null)
        {
                return;
        }
        
        val_21 = ???;
        val_20 = ???;
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public NovicePromotionSelectorBanner()
    {
    
    }

}
