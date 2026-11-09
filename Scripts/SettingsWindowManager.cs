using UnityEngine;
internal sealed class SettingsWindowManager : PGBehaviour
{
    // Fields
    public Rilisoft.ButtonHandler backButton;
    public Rilisoft.ButtonHandler gamepadSettingsBtn;
    public UIPanel mainPanel;
    public CategoryButtonsController tabsContainer;
    public UnityEngine.GameObject trainingButton;
    public UnityEngine.GameObject DefSettingsButton;
    private UnityEngine.GameObject setDefConfirmWindow;
    private System.IDisposable 丐丆七且丞丏下三丙;
    internal static SettingsWindowManager 丆丕丝丒不丙且丐丗;
    private bool <丗一丝专上业丗丒丈>k__BackingField;
    internal UnityEngine.Events.UnityAction 与七且下三丒丘丐七;
    
    // Properties
    internal bool 丂与丑三丐丌丐丘丁 { get; }
    internal bool 丒一业丂丆丐丕业丌 { get; }
    internal bool 丅丒上丂且丞丟万世 { get; set; }
    internal bool 丄且丑三丒丐世丕且 { get; }
    internal bool 一丗丕丝丆万业丟丛 { get; }
    
    // Methods
    internal bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    internal bool 丏丐丑专丘丂世丁一()
    {
        null = null;
        return UnityEngine.Object.op_Implicit(exists:  PauseNGUIController.丄丞丁丈与业上丞丟);
    }
    internal bool 不不丈不下专一东丁()
    {
        return (bool)this.<丗一丝专上业丗丒丈>k__BackingField;
    }
    internal void 三专丏七丄丄丒世丏(bool 丙业与丙丗丝不丈东)
    {
        this.<丗一丝专上业丗丒丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 下与专不七世丐丏七()
    {
        CategoryButtonsController val_8;
        UnityEngine.Object val_9;
        var val_10;
        val_8 = this;
        val_9 = this.tabsContainer;
        if((UnityEngine.Object.op_Implicit(exists:  val_9)) == false)
        {
            goto label_7;
        }
        
        val_9 = this.tabsContainer.currentBtnName;
        if((System.String.IsNullOrEmpty(value:  val_9)) == true)
        {
            goto label_7;
        }
        
        val_9 = this.tabsContainer.currentBtnName;
        if((System.String.op_Equality(a:  val_9, b:  "Controls")) == true)
        {
            goto label_7;
        }
        
        val_8 = this.tabsContainer;
        val_9 = this.tabsContainer.currentBtnName;
        bool val_4 = System.String.op_Equality(a:  val_9, b:  "Settings");
        if(val_4 == false)
        {
            goto label_9;
        }
        
        label_7:
        if(val_4.丏丐丑专丘丂世丁一() == false)
        {
            goto label_10;
        }
        
        label_9:
        val_10 = 0;
        goto label_11;
        label_10:
        bool val_6 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
        val_10 = val_6 ^ 1;
        label_11:
        val_6 = val_10;
        return (bool)val_6;
    }
    internal bool 丄丗丈业一东七丂业()
    {
        CategoryButtonsController val_9;
        UnityEngine.Object val_10;
        var val_11;
        val_9 = this;
        val_10 = this.tabsContainer;
        if((UnityEngine.Object.op_Implicit(exists:  val_10)) == false)
        {
            goto label_9;
        }
        
        val_10 = this.tabsContainer.currentBtnName;
        if((System.String.IsNullOrEmpty(value:  val_10)) == true)
        {
            goto label_9;
        }
        
        val_10 = this.tabsContainer.currentBtnName;
        if((System.String.op_Equality(a:  val_10, b:  "Multimedia")) == true)
        {
            goto label_9;
        }
        
        val_10 = this.tabsContainer.currentBtnName;
        if((System.String.op_Equality(a:  val_10, b:  "Settings")) == true)
        {
            goto label_9;
        }
        
        val_9 = this.tabsContainer;
        val_10 = this.tabsContainer.currentBtnName;
        bool val_5 = System.String.op_Equality(a:  val_10, b:  "Controls");
        if(val_5 == false)
        {
            goto label_11;
        }
        
        label_9:
        if(val_5.丏丐丑专丘丂世丁一() == false)
        {
            goto label_12;
        }
        
        label_11:
        val_11 = 0;
        goto label_13;
        label_12:
        bool val_7 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
        val_11 = val_7 ^ 1;
        label_13:
        val_7 = val_11;
        return (bool)val_7;
    }
    private void Awake()
    {
        if(SettingsWindowManager.丆丕丝丒不丙且丐丗 == 0)
        {
                SettingsWindowManager.丆丕丝丒不丙且丐丗 = this;
        }
        
        if(this.trainingButton == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_3 = this.trainingButton.GetComponent<Rilisoft.ButtonHandler>();
        if(val_3 == 0)
        {
                return;
        }
        
        val_3.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsWindowManager::不一东丅丞丘丟世东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 不一东丅丞丘丟世东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_4;
        this.<丗一丝专上业丗丒丈>k__BackingField = true;
        ControlFireSettings val_1 = ControlFireSettings.丈业且丘丈不丄丈丒(丁丅丈丌丟世丗丗丟:  0);
        val_4 = val_1;
        if(val_4 != null)
        {
            goto label_1;
        }
        
        val_4 = ControlFireSettings.不丁丑丁丈上丅丌丐(丁丅丈丌丟世丗丗丟:  val_1, 丏东丆丆丛丄丕丈丞:  0);
        if(val_4 == null)
        {
            goto label_2;
        }
        
        label_1:
        与丂丏丛丞丞丒丟丄.与丟丂三丄丄丒下三(丙业与丙丗丝不丈东:  (val_2.IsAutoShooting == true) ? 1 : 0);
        与丂丏丛丞丞丒丟丄.且丒丅丘丝上丏丒丏(丙业与丙丗丝不丈东:  val_2.IsAiming);
        label_2:
        PolygonController.一下一万丄丅丘且丑.丟丒上丘上丄一下万();
    }
    private void Start()
    {
        System.Action val_9;
        this.东一三一万且丕世不();
        if((UnityEngine.Object.op_Implicit(exists:  this.backButton)) != false)
        {
                this.backButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsWindowManager::不丕且不七丞七丅三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.tabsContainer)) == false)
        {
            goto label_7;
        }
        
        val_9 = System.Delegate.Combine(a:  this.tabsContainer.丛万丈万丘丝丂业与, b:  new System.Action(object:  this, method:  System.Void SettingsWindowManager::丛三七东七丄丂丙丏()));
        if(this.tabsContainer == null)
        {
            goto label_9;
        }
        
        if(val_9 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_9 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_9 = 0;
        }
        
        label_13:
        this.tabsContainer.丛万丈万丘丝丂业与 = val_9;
        label_7:
        GamepadManager.业世丘世丏一丗丗业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void SettingsWindowManager::一丈丑丂丞丈丞丗丘(string 万且万且丑丗且丌丆)));
        GamepadManager.丆丘丘丏丒世且丆丘(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void SettingsWindowManager::一丈丑丂丞丈丞丗丘(string 万且万且丑丗且丌丆)));
    }
    private void 一丈丑丂丞丈丞丗丘(string 万且万且丑丗且丌丆)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.gamepadSettingsBtn)) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gamepadSettingsBtn.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  万且万且丑丗且丌丆))) & 1);
    }
    private void 丛三七东七丄丂丙丏()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.trainingButton, 丏业丟一东丂东丘丛:  this.下与专不七世丐丏七());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.DefSettingsButton, 丏业丟一东丂东丘丛:  this.丄丗丈业一东七丂业());
        if(this.与七且下三丒丘丐七 == null)
        {
                return;
        }
        
        this.与七且下三丒丘丐七.Invoke();
    }
    private void 东一三一万且丕世不()
    {
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.backButton, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsWindowManager.{0} is null", arg0:  "backButton"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.mainPanel, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsWindowManager.{0} is null", arg0:  "mainPanel"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.gamepadSettingsBtn, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsWindowManager.{0} is null", arg0:  "gamepadSettingsBtn"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.tabsContainer, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsWindowManager.{0} is null", arg0:  "tabsContainer"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.trainingButton, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsWindowManager.{0} is null", arg0:  "trainingButton"));
    }
    public void OpenDefConfirmWindow()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.setDefConfirmWindow, 丏业丟一东丂东丘丛:  true);
    }
    public void CloseDefConfirmWindow()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.setDefConfirmWindow, 丏业丟一东丂东丘丛:  false);
    }
    private void OnEnable()
    {
        UnityEngine.GameObject val_11;
        this.一丈丛下丙丂丁丛丞();
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.trainingButton, 丏业丟一东丂东丘丛:  this.下与专不七世丐丏七());
        val_11 = this.DefSettingsButton;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  this.丄丗丈业一东七丂业());
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = this.丐丆七且丞丏下三丙;
            val_11.Dispose();
        }
        
        if(val_11.丏丐丑专丘丂世丁一() != true)
        {
                System.IDisposable val_9 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SettingsWindowManager::七丂专且上且丌丄丆()), 与且专丈不万东一万:  "Settings");
            this.丐丆七且丞丏下三丙 = val_9;
        }
        
        val_9.丕丌丈三专丄上丙丐(丆丄丗七丂丐世丂七:  false);
        this.一丈丑丂丞丈丞丗丘(万且万且丑丗且丌丆:  GamepadManager.丝三丂不丈丛专丙丈.业七不丞丝丝丂丆丂());
        if(this.与七且下三丒丘丐七 == null)
        {
                return;
        }
        
        this.与七且下三丒丘丐七.Invoke();
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        this.CloseDefConfirmWindow();
        this.丕丌丈三专丄上丙丐(丆丄丗七丂丐世丂七:  true);
    }
    private void 丕丌丈三专丄上丙丐(bool 丆丄丗七丂丐世丂七)
    {
        if((UnityEngine.Object.op_Implicit(exists:  PersConfigurator.下一丁七丅丕七万丑())) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  PersConfigurator.下一丁七丅丕七万丑().transform.parent, 丏业丟一东丂东丘丛:  丆丄丗七丂丐世丂七);
    }
    private void 不丕且不七丞七丅三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        string val_2 = 与丂丏丛丞丞丒丟丄.业且丞丂一与不七丑().ToString();
        val_2.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "musicVolume", 丙业与丙丗丝不丈东:  val_2);
        string val_4 = 与丂丏丛丞丞丒丟丄.一一上与丗专丗丏丌().ToString();
        val_4.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "sensativity", 丙业与丙丗丝不丈东:  val_4);
        string val_6 = 与丂丏丛丞丞丒丟丄.丒丞丈丗丟丑丘丅与().ToString();
        val_6.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "sensativityBR", 丙业与丙丗丝不丈东:  val_6);
        string val_8 = 与丂丏丛丞丞丒丟丄.丛丗丅丐丌且与丁与().ToString();
        val_8.与东丕东且丑与丁丐(丌丁不丙丑丑丝丆丌:  "pressure3d", 丙业与丙丗丝不丈东:  val_8);
        PGCompany.Analytics.一业丗丆世世上丁且.且丙且丛丅业丐丝一(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世());
        this.丝东丐丝东三丈世丝();
    }
    private void 丝东丐丝东三丈世丝()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.mainPanel)) != false)
        {
                this.mainPanel.gameObject.SetActive(value:  true);
        }
        
        this.gameObject.SetActive(value:  false);
        PGCompany.Piggy.PiggyOffersLobby.丑七不且上丗丁一世().丝一丅丆三东丂丞七();
        AmongUsButtonLobby.Instance.丕丕业七丙七丅丈丄();
        RedLightButtonInLobby.丑上丞不与丄丗丌一();
        if((UnityEngine.Object.op_Implicit(exists:  MainMenuHeroCamera.丑七不且上丗丁一世())) != false)
        {
                MainMenuHeroCamera.丑七不且上丗丁一世().PlayCloseOptions();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  AnimationGift.丄丘七三上丕世丞业)) != false)
        {
                AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
        }
        
        PGCompany.Piggy.PiggyOffersLobby.丑七不且上丗丁一世().丝一丅丆三东丂丞七();
    }
    private void 一丈丛下丙丂丁丛丞()
    {
        string val_10;
        var val_11;
        var val_12;
        if(this.tabsContainer != 0)
        {
                if((this.<丗一丝专上业丗丒丈>k__BackingField) == false)
        {
            goto label_4;
        }
        
        }
        
        this.<丗一丝专上业丗丒丈>k__BackingField = false;
        return;
        label_4:
        bool val_2 = 上丞丑上丙丈丄丗丐.下丏丗与七丑丅与丅();
        val_10 = val_2;
        val_10 = ~val_2;
        if(丅丛丟上丁丆上丛专.下丂且丕与世丄丝万() != null)
        {
                val_10 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            val_11 = 丅丛丟上丁丆上丛专.下丂且丕与世丄丝万();
            val_12 = (~(val_11.丅不丁下丌万七且下(万丄丅丝三丈丆世丟:  val_10))) & 1;
        }
        else
        {
                val_12 = 1;
        }
        
        val_12 = val_12 | (val_10 & 1);
        if(val_12 == 0)
        {
                val_11 = 0;
            bool val_8 = Rilisoft.七不丑丑下与丛丝丝.不丆丕丁万专东东且();
            if(val_8 == false)
        {
                return;
        }
        
        }
        
        if(val_8.丏丐丑专丘丂世丁一() == true)
        {
                return;
        }
        
        this.tabsContainer.与丐且业丛丌不丄丑(丟专丛丏丝万丘丄丗:  "Account");
    }
    internal void 与东丕东且丑与丁丐(string 丌丁不丙丑丑丝丆丌, string 丙业与丙丗丝不丈东)
    {
        PGCompany.Analytics.一业丗丆世世上丁且.丑下丗专丐丑丅专丑(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 下上丐丆丝丟丝丒不:  丌丁不丙丑丑丝丆丌, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void OnDestroy()
    {
        if(this.trainingButton == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_2 = this.trainingButton.GetComponent<Rilisoft.ButtonHandler>();
        if(val_2 == 0)
        {
                return;
        }
        
        val_2.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SettingsWindowManager::不一东丅丞丘丟世东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public SettingsWindowManager()
    {
    
    }
    private void 七丂专且上且丌丄丆()
    {
        this.不丕且不七丞七丅三(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }

}
