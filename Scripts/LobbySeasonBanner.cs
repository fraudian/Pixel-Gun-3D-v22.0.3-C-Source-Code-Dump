using UnityEngine;
internal sealed class LobbySeasonBanner : BannerWindow
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    internal static bool 业丗丝万专万丞丟上 { get; }
    
    // Methods
    internal static bool 丂丙上且不丟业丛丒()
    {
        int val_15;
        var val_16;
        if(ExperienceController.丞丞丘业东丙丏七丌() > 2)
        {
            goto label_3;
        }
        
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  129)) == false)
        {
            goto label_13;
        }
        
        val_15 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  129);
        if((丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  val_15)) == false)
        {
            goto label_13;
        }
        
        label_3:
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
            goto label_16;
        }
        
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  129)) == false)
        {
                return (bool)val_16 & 1;
        }
        
        val_15 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  129);
        val_16 = (丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  val_15)) ^ 1;
        return (bool)val_16 & 1;
        label_13:
        val_15 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_15.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  129, 丙业与丙丗丝不丈东:  1);
        label_16:
        val_16 = 0;
        return (bool)val_16 & 1;
    }
    public void HideWindow()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.HideSelf();
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.丑丂丒上东丙丟丕三();
        new System.Action() = new System.Action(object:  this, method:  public System.Void BannerWindow::HideSelf());
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  129, 丙业与丙丗丝不丈东:  1);
        MenuBackgroundMusic.丆不丅丐与业一东丙(七不丐下丟专业万丅:  "season_lobby", 七丆丟丗世丟且丒丆:  false, 丝下丘下丈一丞丄丄:  true, 丆与丈丏丟七丁东丛:  0);
    }
    protected override void OnDisable()
    {
        this.丑丂丒上东丙丟丕三();
        this.OnDisable();
    }
    private void 丑丂丒上东丙丟丕三()
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
    public LobbySeasonBanner()
    {
    
    }

}
