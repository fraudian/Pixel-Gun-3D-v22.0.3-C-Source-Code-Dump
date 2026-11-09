using UnityEngine;
public class UpdateIdBindingWindow : MonoBehaviour
{
    // Fields
    private UILabel _nickLabel;
    private UILabel _levelLabel;
    private UILabel _coinsLabel;
    private UILabel _gemsLabel;
    private UILabel _accountLabel;
    private UILabel _bodyLabel;
    private UILabel _idLabel;
    private UITexture _skinTexture;
    private UITexture _platformTexture;
    private UnityEngine.Texture _iosTexture;
    private UnityEngine.Texture _googleTexture;
    private UnityEngine.Texture _amazonTexture;
    private System.IDisposable 丄丘业与丈丛丛丝世;
    public AccountsMenuItem _accountsMenuItem;
    
    // Methods
    private void OnEnable()
    {
        if(this.丄丘业与丈丛丛丝世 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        
        this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void UpdateIdBindingWindow::U_Hide()), 与且专丈不万东一万:  0);
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
    public void U_Update()
    {
    
    }
    private System.Collections.IEnumerator 且丆丗不丏上丗丌不(System.Threading.Tasks.Task 万不且且丛丆东丒业)
    {
        UpdateIdBindingWindow.丂丗一七三业丒不三 val_1 = new UpdateIdBindingWindow.丂丗一七三业丒不三();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .万不且且丛丆东丒业 = 万不且且丛丆东丒业;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丝一丅丆三东丂丞七()
    {
        UILabel val_27;
        string val_28;
        UnityEngine.Texture val_29;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._nickLabel, 丕丗丘丑丛与丑业丒:  ProfileController.丆三丂丂丆上丆丕专());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._coinsLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._gemsLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._idLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "ID-{0}", arg0:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1073"), arg1:  ExperienceController.丞丞丘业东丙丏七丌()));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._accountLabel, 丕丗丘丑丛与丑业丒:  AccountsMenuItem.与与丆丞世丒丐丁上());
        bool val_12 = UnityEngine.Object.op_Inequality(x:  this._skinTexture, y:  0);
        if(val_12 == false)
        {
            goto label_15;
        }
        
        string val_13 = val_12.丕丂业业丘丝万丒上();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_13)) != false)
        {
                UnityEngine.Texture2D val_15 = Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  val_13, 丁丅丈丌丟世丗丗丟:  1);
            if(this._skinTexture != null)
        {
            goto label_20;
        }
        
        }
        
        label_20:
        label_15:
        if((上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅() != false) && ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丛丟上丁丆上丛专.业丟不七丄且不东下())) != false))
        {
                val_27 = this._bodyLabel;
            val_28 = "Key_7471";
        }
        else
        {
                val_27 = this._bodyLabel;
            val_28 = "Key_7440";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_27, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_28), arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  PlatformDependentLocalize.丄丗丅丙丗丑丘三丏())));
        val_29 = this._iosTexture;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
                val_29 = mem[val_24 == 0x1 ? this._amazonTexture : this._googleTexture];
            val_29 = (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1) ? this._amazonTexture : this._googleTexture;
        }
        
        if(this._platformTexture != null)
        {
                return;
        }
    
    }
    private string 丕丂业业丘丝万丒上()
    {
        null = null;
        string val_2 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) == true)
        {
                return System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  SkinsController.丌与世丂丘且下丒丑));
        }
        
        if((val_2.Contains(value:  "EMPTY_ROYALE_AVATAR")) == false)
        {
                return val_2;
        }
        
        return System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  SkinsController.丌与世丂丘且下丒丑));
    }
    public UpdateIdBindingWindow()
    {
    
    }

}
