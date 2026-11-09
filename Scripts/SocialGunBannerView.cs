using UnityEngine;
public sealed class SocialGunBannerView : BannerWindow
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    public bool freePanelBanner;
    public System.Collections.Generic.List<UILabel> rewardLabels;
    private static System.Action<bool> 丒丅上不丙丘下丛专;
    
    // Methods
    internal static void 与东丑丑丙丑丒丟丏(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  SocialGunBannerView.丒丅上不丙丘下丛专, b:  丙业与丙丗丝不丈东);
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
    internal static void 丑业丗上丛丙丟七丒(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  SocialGunBannerView.丒丅上不丙丘下丛专, value:  丙业与丙丗丝不丈东);
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
    private void 业丄丗丑不丙丂业三()
    {
        List.Enumerator<T> val_1 = this.rewardLabels.GetEnumerator();
        label_6:
        if((213122872 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1531"), arg0:  10);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void Awake()
    {
        this.业丄丗丑不丙丂业三();
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SocialGunBannerView::丞丛一丙丂世丈丅丗()));
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SocialGunBannerView::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Social Gun");
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        this.HideWindow();
    }
    public void HideWindow()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.freePanelBanner != true)
        {
                BannerWindowController val_1 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_1 != 0)
        {
                val_1.HideBannerWindow();
            return;
        }
        
        }
        
        this.Hide();
    }
    public void Continue()
    {
        var val_3;
        System.Action val_5;
        val_3 = null;
        val_3 = null;
        val_5 = SocialGunBannerView.<>c.<>9__12_1;
        if(val_5 == null)
        {
                System.Action val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action(object:  SocialGunBannerView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SocialGunBannerView.<>c::一万丅业七七不东丐());
            SocialGunBannerView.<>c.<>9__12_1 = val_5;
        }
        
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void SocialGunBannerView::丟万不丏丐丏七丙业()), 丆丒丅丁不且丛一业:  val_2);
    }
    private void 丝东丁丄业丑与七丐(bool 下下丏一丙不丘丌丞)
    {
        if(SocialGunBannerView.丒丅上不丙丘下丛专 == null)
        {
                return;
        }
        
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞;
        SocialGunBannerView.丒丅上不丙丘下丛专.Invoke(obj:  下下丏一丙不丘丌丞);
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SocialGunBannerView::丞丛一丙丂世丈丅丗()));
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.业丄丗丑不丙丂业三();
    }
    public SocialGunBannerView()
    {
    
    }
    private void 丟万不丏丐丏七丙业()
    {
        FacebookController.丟不丆丂且三丅世专(七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void SocialGunBannerView::丄丁丞丛万丁不七丆()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  this, method:  System.Void SocialGunBannerView::且丑丐丂丈且且不万()), 与且专丈不万东一万:  "Social Gun Banner");
    }
    private void 丄丁丞丛万丁不七丆()
    {
        this.丝东丁丄业丑与七丐(下下丏一丙不丘丌丞:  true);
    }
    private void 且丑丐丂丈且且不万()
    {
        this.丝东丁丄业丑与七丐(下下丏一丙不丘丌丞:  false);
    }

}
