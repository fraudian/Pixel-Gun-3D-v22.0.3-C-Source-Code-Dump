using UnityEngine;
internal sealed class TrophiesPenaltyBannerWindow : BannerWindow
{
    // Fields
    internal const string 丏三且一丄丐丗万一 = "leave_from_duel_penalty";
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UILabel _penalty;
    
    // Methods
    public override void Show()
    {
        this.Show();
        this._penalty.text = UnityEngine.PlayerPrefs.GetInt(key:  "leave_from_duel_penalty").ToString();
    }
    public void HideButtonAction()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "leave_from_duel_penalty", value:  0);
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  13);
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void TrophiesPenaltyBannerWindow::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Trophies Penalty");
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
        this.HideButtonAction();
    }
    public TrophiesPenaltyBannerWindow()
    {
    
    }

}
