using UnityEngine;
public class TournamentLooserBannerWindow : BannerWindow
{
    // Fields
    private static readonly Rilisoft.丆专丐丂丆丐丕丝丒 丙丌七专丁且业且丌;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    internal static bool 丕世一与业丅万专丑 { get; set; }
    
    // Methods
    internal static bool 丌七丘七丗下丐七丞()
    {
        null = null;
        if(TournamentLooserBannerWindow.丙丌七专丁且业且丌 != null)
        {
                return TournamentLooserBannerWindow.丙丌七专丁且业且丌.世三丞丅丑丌丈丈一();
        }
        
        return TournamentLooserBannerWindow.丙丌七专丁且业且丌.世三丞丅丑丌丈丈一();
    }
    internal static void 丈业丙丈丆丈丛丆专(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentLooserBannerWindow.丙丌七专丁且业且丌.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void TournamentLooserBannerWindow::HideButtonAction()), 与且专丈不万东一万:  0);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
    }
    protected override void OnDestroy()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.OnDestroy();
    }
    public void HideButtonAction()
    {
        TournamentLooserBannerWindow.丈业丙丈丆丈丛丆专(丙业与丙丗丝不丈东:  false);
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  17);
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
    }
    public TournamentLooserBannerWindow()
    {
    
    }
    private static TournamentLooserBannerWindow()
    {
        TournamentLooserBannerWindow.丙丌七专丁且业且丌 = new Rilisoft.丆专丐丂丆丐丕丝丒(丟东丟丑丕丄丂丟丙:  "TournamentLooserBannerWindow_needShow");
    }

}
