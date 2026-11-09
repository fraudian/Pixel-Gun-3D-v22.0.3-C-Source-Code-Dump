using UnityEngine;
internal sealed class AcceptWindow : PGBehaviour
{
    // Fields
    private UILabel labelForText;
    private I2.Loc.Localize buttonAcceptLabel;
    private Rilisoft.ButtonHandler acceptButton;
    private Rilisoft.ButtonHandler cancleButton;
    public string installSeasonKey;
    public string installBundleKey;
    public string btnInstallBundleKey;
    public string btnInstallSeasonKey;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    public void Setup(bool 丘万且丑丂丈丈业丑, System.Action 丙万丌专丟丌丘丆丞, System.Action 丁丙丆丙丑丅丅丞东)
    {
        string val_8;
        var val_9;
        string val_10;
        AcceptWindow.丌万一一业丝丁丈丝 val_1 = new AcceptWindow.丌万一一业丝丁丈丝();
        if(val_1 != null)
        {
                .丙万丌专丟丌丘丆丞 = 丙万丌专丟丌丘丆丞;
        }
        else
        {
                mem[16] = 丙万丌专丟丌丘丆丞;
        }
        
        .丁丙丆丙丑丅丅丞东 = 丁丙丆丙丑丅丅丞东;
        if(this.buttonAcceptLabel != null)
        {
                val_8 = this.buttonAcceptLabel.SecondaryTerm;
        }
        else
        {
                val_8 = this.buttonAcceptLabel.SecondaryTerm;
        }
        
        this.buttonAcceptLabel.SetTerm(丂专丟专丕丈丘丘丌:  (丘万且丑丂丈丈业丑 != true) ? this.btnInstallSeasonKey : this.btnInstallBundleKey, 丟丛不丞丞丏丏丁丕:  val_8);
        if(丘万且丑丂丈丈业丑 != false)
        {
                val_9 = null;
            val_10 = this.installSeasonKey;
        }
        else
        {
                val_9 = null;
            val_10 = this.installBundleKey;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.labelForText, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_10));
        this.acceptButton.ClearEvents();
        this.cancleButton.ClearEvents();
        this.acceptButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void AcceptWindow.丌万一一业丝丁丈丝::丆一且世上丗上一丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.cancleButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void AcceptWindow.丌万一一业丝丁丈丝::一丄业丐丄丒下丏丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void AcceptWindow::U_BackRequest()), 与且专丈不万东一万:  "SeasonLobbyAccept");
    }
    public void U_BackRequest()
    {
        this.cancleButton.DoClick();
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
    public AcceptWindow()
    {
    
    }

}
