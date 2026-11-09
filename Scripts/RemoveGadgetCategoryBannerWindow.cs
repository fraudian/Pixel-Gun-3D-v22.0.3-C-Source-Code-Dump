using UnityEngine;
public class RemoveGadgetCategoryBannerWindow : BannerWindow
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    private const string 业东丗丏丘下丘三上 = "Support";
    
    // Properties
    internal static bool 丕世一与业丅万专丑 { get; set; }
    
    // Methods
    internal static bool 丌七丘七丗下丐七丞()
    {
        var val_7;
        if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() != false)
        {
                val_7 = (System.String.IsNullOrEmpty(value:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  1, 下上丐丆丝丟丝丒不:  "Support"))) ^ 1;
            return (bool)val_7 & 1;
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7 & 1;
    }
    internal static void 丈业丙丈丆丈丛丆专(bool 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  1, 下上丐丆丝丟丝丒不:  "Support", 下下丏一丙不丘丌丞:  System.String.alignConst);
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
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void RemoveGadgetCategoryBannerWindow::HideButtonAction()), 与且专丈不万东一万:  0);
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
        RemoveGadgetCategoryBannerWindow.丈业丙丈丆丈丛丆专(丙业与丙丗丝不丈东:  false);
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
        BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  35);
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
    }
    public RemoveGadgetCategoryBannerWindow()
    {
    
    }

}
