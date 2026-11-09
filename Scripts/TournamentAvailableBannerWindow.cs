using UnityEngine;
public class TournamentAvailableBannerWindow : BannerWindow
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
        if(TournamentAvailableBannerWindow.丙丌七专丁且业且丌 != null)
        {
                return TournamentAvailableBannerWindow.丙丌七专丁且业且丌.世三丞丅丑丌丈丈一();
        }
        
        return TournamentAvailableBannerWindow.丙丌七专丁且业且丌.世三丞丅丑丌丈丈一();
    }
    internal static void 丈业丙丈丆丈丛丆专(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentAvailableBannerWindow.丙丌七专丁且业且丌.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
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
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void TournamentAvailableBannerWindow::HideButtonAction()), 与且专丈不万东一万:  0);
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
        var val_6;
        var val_7;
        UnityEngine.GameObject val_8;
        TournamentAvailableBannerWindow.丈业丙丈丆丈丛丆专(丙业与丙丗丝不丈东:  false);
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  15);
            BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
        }
        
        val_6 = null;
        val_6 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != null)
        {
                val_8 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
            val_8 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
        }
        else
        {
                val_8 = 106574280;
        }
        
        MainMenuController.丄丞丁丈与业上丞丟.丙七丄与与万世丞丏(世下不上丛丅丌一七:  val_8, 丐丅丒专丛丏上与业:  3, 三丂东专丕专业丏万:  true);
    }
    public TournamentAvailableBannerWindow()
    {
    
    }
    private static TournamentAvailableBannerWindow()
    {
        TournamentAvailableBannerWindow.丙丌七专丁且业且丌 = new Rilisoft.丆专丐丂丆丐丕丝丒(丟东丟丑丕丄丂丟丙:  "TournamentAwailableBannerWindow_needShow");
    }

}
