using UnityEngine;
internal sealed class StorePromotionInfoBanner : BannerWindowWithBack
{
    // Fields
    private UniversalPromotionUI universalPromotionUI;
    
    // Methods
    public static void ShowBanner(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, Rilisoft.BankBannersHolder 丘丒丅三丞丞丛丛丌)
    {
        if(丘丒丅三丞丞丛丛丌 != 0)
        {
                丘丒丅三丞丞丛丛丌.ShowBanner(丌丅丕一丛丛丄一万:  104, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆丞丝丘丗丘丙丅万 = 且丘丏丁丑与丙与丁, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return;
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  104, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆丞丝丘丗丘丙丅万 = 且丘丏丁丑与丙与丁, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    protected override void OnEnable()
    {
        this.universalPromotionUI.不丝丕丈丗丝专丟丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StorePromotionInfoBanner::丗世丒丁不且不丐丏()));
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this.universalPromotionUI.三丒万丘丗丄丕且丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void StorePromotionInfoBanner::丗世丒丁不且不丐丏()));
        this.OnDisable();
    }
    public override void Show()
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_2;
        this.Show();
        PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
        this.universalPromotionUI.丒丙丘丒丄上三丘与(丐丆丝业丙丈下世丁:  val_2);
    }
    public override void Hide()
    {
        this.universalPromotionUI.三丁七丗丞丅丄世丈();
        this.Hide();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    private void 丗世丒丁不且不丐丏()
    {
        goto typeof(StorePromotionInfoBanner).__il2cppRuntimeField_218;
    }
    public StorePromotionInfoBanner()
    {
    
    }

}
