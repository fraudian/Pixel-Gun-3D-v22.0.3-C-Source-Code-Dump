using UnityEngine;
internal sealed class TierBundleBanner : BannerWindowLobbyPurchase
{
    // Fields
    private static System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 丛东丛且丁丝丟丑丟;
    private static PGCompany.丒丌业一丕丘丐世专 万丗丆专丝丝丝七丆;
    private StorePromotionSelectorView selectorView;
    private UnityEngine.GameObject lightHolder;
    private System.Nullable<UnityEngine.Color> 与丕专丛世丛丅丒东;
    private System.Nullable<bool> 专丆丐丙丒丌七东丙;
    private System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 不丅上丏丐一丟丆丞;
    private UnityEngine.Coroutine 世丛且七丐丕三丞丐;
    
    // Methods
    internal static void 下下且丅丆丐丞且丒(System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 七丄丆丘丒与丐丘丅, PGCompany.丒丌业一丕丘丐世专 丛丗七丅下丞丗且丐)
    {
        PGCompany.丒丌业一丕丘丐世专 val_2 = 丛丗七丅下丞丗且丐;
        TierBundleBanner.丛东丛且丁丝丟丑丟 = 七丄丆丘丒与丐丘丅;
        TierBundleBanner.万丗丆专丝丝丝七丆 = val_2;
        if(TierBundleBanner.丛东丛且丁丝丟丑丟 != null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专>();
        TierBundleBanner.丛东丛且丁丝丟丑丟 = val_2;
    }
    public static void ShowBanner(System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> 七丄丆丘丒与丐丘丅, PGCompany.丒丌业一丕丘丐世专 丛丗七丅下丞丗且丐)
    {
        TierBundleBanner.下下且丅丆丐丞且丒(七丄丆丘丒与丐丘丅:  七丄丆丘丒与丐丘丅, 丛丗七丅下丞丗且丐:  丛丗七丅下丞丗且丐);
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  67, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public override void Show()
    {
        var val_10;
        var val_11;
        val_10 = this;
        this.Show();
        if(TierBundleBanner.丛东丛且丁丝丟丑丟 == null)
        {
            goto label_1;
        }
        
        if(TierBundleBanner.丛东丛且丁丝丟丑丟.Count == 0)
        {
            goto label_2;
        }
        
        val_11 = 0;
        goto label_4;
        label_1:
        TierBundleBanner.丛东丛且丁丝丟丑丟.丂丑丕丙专丈丝丙丟();
        val_11 = 1;
        goto label_4;
        label_2:
        val_11 = 0;
        TierBundleBanner.丛东丛且丁丝丟丑丟 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140).丗不丞一且丟丈丈丗();
        label_4:
        if((TierBundleBanner.丛东丛且丁丝丟丑丟 == null) || (TierBundleBanner.丛东丛且丁丝丟丑丟.Count < 1))
        {
            goto label_10;
        }
        
        this.丈且东丑丂且万丒丅(七丄丆丘丒与丐丘丅:  TierBundleBanner.丛东丛且丁丝丟丑丟, 丛丗七丅下丞丗且丐:  TierBundleBanner.万丗丆专丝丝丝七丆);
        this.丁万丅丁丝丝丝丛丒(丗丐丏一丛丈丛上丙:  false);
        if(val_11 == 0)
        {
            goto label_18;
        }
        
        val_10 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_10 == null)
        {
            goto label_18;
        }
        
        val_10.世丅万丛与万万七万(万丏丗丗丅丄丌业一:  TierBundleBanner.万丗丆专丝丝丝七丆.丞丂上世丌丒世下七().丏不丁丛丕丒丏丆丂());
        goto label_18;
        label_10:
        UnityEngine.Debug.LogError(message:  "!!! ALARMA !!!  Nothing to show!");
        label_18:
        TierBundleBanner.丛东丛且丁丝丟丑丟 = 0;
        TierBundleBanner.万丗丆专丝丝丝七丆 = 0;
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
        UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        mem[1152921539310770552] = 0;
        mem2[0] = 0;
        bool val_3 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        this.专丆丐丙丒丌七东丙 = 0;
        UnityEngine.Color val_4 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lightHolder, 丏业丟一东丂东丘丛:  true);
        this.不与丞下业丑丒丙万();
        this.下丌业业丐丘丐丘三();
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        var val_6;
        if(this.与丕专丛世丛丅丒东.HasValue.HasValue != false)
        {
            
        }
        else
        {
                UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        if((344288892 & 1) != 0)
        {
                bool val_3 = this.专丆丐丙丒丌七东丙.GetValueOrDefault();
        }
        else
        {
                val_6 = 0;
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
        this.selectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TierBundleBanner::OnSelect()));
    }
    private void 不与丞下业丑丒丙万()
    {
        this.selectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TierBundleBanner::OnSelect()));
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
        if((344825944 & 1) == 0)
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
        if((System.Linq.Enumerable.Any<PGCompany.东丑丆丗丏丐丟下丄>(source:  this.不丅上丏丐一丟丆丞)) == false)
        {
                return;
        }
        
        int val_10 = this.不丅上丏丐一丟丆丞.Item[0].下丒丗丄丌丘不丑丘();
        val_10 = val_10 - PixelTime.丝丗专上三不丄丑丑();
        if(this.世丛且七丐丕三丞丐 != null)
        {
                this.StopCoroutine(routine:  this.世丛且七丐丕三丞丐);
        }
        
        this.世丛且七丐丕三丞丐 = this.StartCoroutine(routine:  this.七丁丄丐上丛丑与丈(丌丐上丞丝与丞专万:  val_10));
    }
    private System.Collections.IEnumerator 七丁丄丐上丛丑与丈(int 丌丐上丞丝与丞专万)
    {
        TierBundleBanner.丘丄丙丗丅丞丄一丌 val_1 = new TierBundleBanner.丘丄丙丗丅丞丄一丌();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丌丐上丞丝与丞专万 = 丌丐上丞丝与丞专万;
        return (System.Collections.IEnumerator)val_1;
    }
    public void U_ShootButtonPressed()
    {
    
    }
    public void U_BuyButtonPressed()
    {
        goto typeof(TierBundleBanner).__il2cppRuntimeField_218;
    }
    public static bool CanShowAutomaticaly()
    {
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        return val_2.丟世丙丛业丏东与七();
    }
    private void 丂丑丕丙专丈丝丙丟()
    {
        var val_12;
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_13;
        TierBundleBanner.丛东丛且丁丝丟丑丟 = 0;
        TierBundleBanner.万丗丆专丝丝丝七丆 = 0;
        val_12 = 1152921505476546560;
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_2 != null)
        {
                val_13 = val_2.丗不丞一且丟丈丈丗();
        }
        else
        {
                val_13 = 0;
        }
        
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_5 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
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
        
        val_12 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_12 == null)
        {
                return;
        }
        
        PGCompany.丒丌业一丕丘丐世专 val_11 = val_12.丅专上东下丕丄丗丅(丞丅上丏丂且下丅与:  System.Linq.Enumerable.FirstOrDefault<System.Int32>(source:  val_6));
        if(val_11 == null)
        {
                return;
        }
        
        TierBundleBanner.丛东丛且丁丝丟丑丟 = val_13;
        TierBundleBanner.万丗丆专丝丝丝七丆 = val_11;
    }
    private void 丁万丅丁丝丝丝丛丒(bool 丗丐丏一丛丈丛上丙)
    {
        string val_10;
        if(TierBundleBanner.万丗丆专丝丝丝七丆 == null)
        {
                return;
        }
        
        if(丗丐丏一丛丈丛上丙 == false)
        {
            goto label_4;
        }
        
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_3 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_3 == null)
        {
            goto label_8;
        }
        
        var val_7 = ((val_3.丁丕丄丈丅七业丗丝(万丏丗丗丅丄丌业一:  TierBundleBanner.万丗丆专丝丝丝七丆.丞丂上世丌丒世下七().丏不丁丛丕丒丏丆丂())) > 1) ? "Timer" : "FirstTime";
        goto label_11;
        label_4:
        val_10 = "ByUser";
        goto label_12;
        label_8:
        val_10 = "FirstTime";
        label_12:
        label_11:
        PGCompany.Analytics.一业丗丆世世上丁且.丂下丈丁丈丕下丑丟(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丗下一不丘丑丅业且:  TierBundleBanner.万丗丆专丝丝丝七丆.丂丁丏一丙丛业且丌(), 丒丕丈丛且丕丗东丛:  false, 丒丘丏上丙丟丑丕丈:  TierBundleBanner.万丗丆专丝丝丝七丆, 一丑丑丝丏且丂丏丘:  val_10);
    }
    private void OnSelect()
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_1 = this.selectorView.丌丂专七丞丑丁丐丆();
    }
    public TierBundleBanner()
    {
    
    }

}
