using UnityEngine;
public class InGameGUIPart_DeathEscape : InGameGUIPartContainer
{
    // Fields
    public UnityEngine.GameObject panelFinishLap;
    public UILabel currentLapTime;
    public UILabel bestLapTime;
    public UILabel recordLapTime;
    public UILabel noRecordLabel;
    public UILabel recordLabel;
    public UIButton lapFinishButton;
    public UIButton newLapButton;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丛东丛七三七丕丕七 = this;
    }
    public void ShowLapFinishedInterface(int 丟丘丂丂丘丆丕专丘, int 丈丙且丅丙七丞丞不, int 丑丘且丐与且丈丄上, bool 丘下且万业丐丗丕且)
    {
        this.丕不丄丞丌丌且丛世(下下东且万业丞丅丒:  true);
        this.lapFinishButton.onClick.Clear();
        this.newLapButton.onClick.Clear();
        this.lapFinishButton.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void InGameGUIPart_DeathEscape::丝丑丌下丌丐专丗丛())));
        this.newLapButton.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void InGameGUIPart_DeathEscape::DeathEscape_NewLapButtonClick())));
        this.currentLapTime.text = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  丟丘丂丂丘丆丕专丘);
        this.bestLapTime.text = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  丈丙且丅丙七丞丞不);
        this.recordLapTime.text = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  丑丘且丐与且丈丄上);
        this.noRecordLabel.gameObject.SetActive(value:  (~丘下且万业丐丗丕且) & 1);
        this.recordLabel.gameObject.SetActive(value:  丘下且万业丐丗丕且);
    }
    private void 丕不丄丞丌丌且丛世(bool 下下东且万业丞丅丒)
    {
        var val_7 = null;
        下下东且万业丞丅丒 = 下下东且万业丞丅丒;
        上丘一丝丅丞东丗丄(丁与丟万丄丒丗专丌:  下下东且万业丞丅丒);
        SetActive(value:  (~下下东且万业丞丅丒) & 1);
        this.panelFinishLap.SetActive(value:  下下东且万业丞丅丒);
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        if(下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void InGameGUIPart_DeathEscape::丝丑丌下丌丐专丗丛()), 与且专丈不万东一万:  "Death Escape finish");
    }
    private void 丝丑丌下丌丐专丗丛()
    {
        MiniGamesController.丑七不且上丗丁一世().FinishGame();
        this.丕不丄丞丌丌且丛世(下下东且万业丞丅丒:  false);
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
        Rilisoft.一丟专且三万丞丁丂.与上丅上丞与丌七丒(丙业与丙丗丝不丈东:  "Rejected");
    }
    public void DeathEscape_NewLapButtonClick()
    {
        CheckpointController.丄丘七三上丕世丞业.StartNewLap();
        this.丕不丄丞丌丌且丛世(下下东且万业丞丅丒:  false);
        Rilisoft.一丟专且三万丞丁丂.与上丅上丞与丌七丒(丙业与丙丗丝不丈东:  "Accepted");
    }
    public InGameGUIPart_DeathEscape()
    {
    
    }

}
