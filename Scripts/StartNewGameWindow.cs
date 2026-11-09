using UnityEngine;
public class StartNewGameWindow : PGBehaviour
{
    // Fields
    private UILabel _nickLabel;
    private UILabel _levelLabel;
    private UILabel _coinsLabel;
    private UILabel _gemsLabel;
    private UILabel _idLabel;
    private UITexture _skinTexture;
    private System.IDisposable 丄丘业与丈丛丛丝世;
    
    // Methods
    private void OnEnable()
    {
        if(this.丄丘业与丈丛丛丝世 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        
        this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void StartNewGameWindow::U_Hide()), 与且专丈不万东一万:  0);
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        if(this.丄丘业与丈丛丛丝世 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丄丘业与丈丛丛丝世.Dispose();
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 != false)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public void U_Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public void U_NewGame()
    {
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  42);
        丏下三丗一不专丞丝.丁下一东与东丒丐丄();
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下丝丛丆丝且丁丞丁(丙业与丙丗丝不丈东:  System.String.alignConst);
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丗丟万丂丘丈专丄丂();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._nickLabel, 丕丗丘丑丛与丑业丒:  ProfileController.丆三丂丂丆上丆丕专());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._coinsLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._gemsLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._idLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "ID-{0}", arg0:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1073"), arg1:  ExperienceController.丞丞丘业东丙丏七丌()));
        if(this._skinTexture == 0)
        {
                return;
        }
        
        string val_13 = 业丂丏与世一丏业不.丑七不且上丗丁一世().三世丑三万丄丌丕丌();
        this = this._skinTexture;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_13)) == false)
        {
                return;
        }
        
        UnityEngine.Texture2D val_15 = Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  val_13, 丁丅丈丌丟世丗丗丟:  1);
        if(this != null)
        {
                return;
        }
    
    }
    public StartNewGameWindow()
    {
    
    }

}
