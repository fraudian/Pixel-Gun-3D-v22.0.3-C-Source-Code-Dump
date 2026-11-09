using UnityEngine;
internal sealed class UniversalPromotionBanner : BannerWindowLobbyPurchase
{
    // Fields
    private static System.Action<PGCompany.丂且业丄丑丌丕丙丅> 业丙丘丈七不下下丐;
    private static System.Action<PGCompany.丂且业丄丑丌丕丙丅> 丛丄业丘不丆丄三丞;
    private UniversalPromotionUI universalPromotionUI;
    private PGCompany.丂且业丄丑丌丕丙丅 丛丛丘丆丟丛丄丙丆;
    
    // Methods
    internal static void 万专丆且七丈业丅丁(System.Action<PGCompany.丂且业丄丑丌丕丙丅> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  UniversalPromotionBanner.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丟丑丟丑丂丄丕丆丌(System.Action<PGCompany.丂且业丄丑丌丕丙丅> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  UniversalPromotionBanner.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丈丗丐丗丛丝丕丙一(System.Action<PGCompany.丂且业丄丑丌丕丙丅> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  UniversalPromotionBanner.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(UniversalPromotionBanner.丛丄业丘不丆丄三丞 != 1152921505280864264);
    
    }
    internal static void 丟不丛世下东且丗丈(System.Action<PGCompany.丂且业丄丑丌丕丙丅> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  UniversalPromotionBanner.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(UniversalPromotionBanner.丛丄业丘不丆丄三丞 != 1152921505280864264);
    
    }
    public static void ShowBanner(PGCompany.与万丝丞下丒丗丏丙 丄丘七三上丕世丞业, Rilisoft.BankBannersHolder 丘丒丅三丞丞丛丛丌)
    {
        if(丘丒丅三丞丞丛丛丌 != 0)
        {
                丘丒丅三丞丞丛丛丌.ShowBanner(丌丅丕一丛丛丄一万:  103, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆一万东丒丗一丝不 = 丄丘七三上丕世丞业, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return;
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  103, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆一万东丒丗一丝不 = 丄丘七三上丕世丞业, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    protected override void OnEnable()
    {
        this.universalPromotionUI.不丝丕丈丗丝专丟丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionBanner::丗世丒丁不且不丐丏()));
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this.universalPromotionUI.三丒万丘丗丄丕且丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalPromotionBanner::丗世丒丁不且不丐丏()));
        this.OnDisable();
    }
    public override void Show()
    {
        var val_2;
        var val_13;
        var val_14;
        PGCompany.东丑丆丗丏丐丟下丄 val_15;
        this.Show();
        this.丛丛丘丆丟丛丄丙丆 = 0;
        mem[1152921539462518120] = 0;
        PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
        if(val_2 != 0)
        {
                mem[1152921539462518113] = 0;
            PGCompany.丆下丐丁丏世丈上丟 val_3 = this.丑丐丙丄丅世世丑丒();
            val_13 = val_2;
            val_14 = 1152921539462518120;
        }
        else
        {
                PGCompany.与万丝丞下丒丗丏丙 val_5 = PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().丞东丄丅上丄丅丏丆();
            val_14 = 1152921539462518120;
            mem[1152921539462518113] = 1;
        }
        
        mem[1152921539462518120] = val_5;
        if(val_5 != null)
        {
                this.丛丛丘丆丟丛丄丙丆 = (val_5.丁丛丝丄丙世东丙丏() == 0) ? 1 : 0;
            val_15 = X21.丂下丏且一丈与下三();
            this.universalPromotionUI.丒丙丘丒丄上三丘与(丐丆丝业丙丈下世丁:  val_15);
            if(1152921505280860160.丁丛丝丄丙世东丙丏() < PixelTime.丝丗专上三不丄丑丑())
        {
                val_15 = 1152921505280860160.业东丅东丌上丗丑不();
            PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().丐丒三下丛丟业业丑(三丏东三不丈丈且且:  val_15);
        }
        
            if(UniversalPromotionBanner.业丙丘丈七不下下丐 == null)
        {
                return;
        }
        
            UniversalPromotionBanner.业丙丘丈七不下下丐.Invoke(obj:  new PGCompany.丂且业丄丑丌丕丙丅() {丁上丟上丕丝与丟下 = this.丛丛丘丆丟丛丄丙丆.丁上丟上丕丝与丟下, 与丘丂万丛一丏上世 = this.丛丛丘丆丟丛丄丙丆.丁上丟上丕丝与丟下});
            return;
        }
        
        this.HideSelf();
    }
    public override void Hide()
    {
        this.universalPromotionUI.三丁七丗丞丅丄世丈();
        if(UniversalPromotionBanner.丛丄业丘不丆丄三丞 != null)
        {
                UniversalPromotionBanner.丛丄业丘不丆丄三丞.Invoke(obj:  new PGCompany.丂且业丄丑丌丕丙丅() {丁上丟上丕丝与丟下 = this.丛丛丘丆丟丛丄丙丆, 与丘丂万丛一丏上世 = this.丛丛丘丆丟丛丄丙丆});
        }
        
        this.Hide();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    private void 丗世丒丁不且不丐丏()
    {
        goto typeof(UniversalPromotionBanner).__il2cppRuntimeField_218;
    }
    public UniversalPromotionBanner()
    {
    
    }

}
