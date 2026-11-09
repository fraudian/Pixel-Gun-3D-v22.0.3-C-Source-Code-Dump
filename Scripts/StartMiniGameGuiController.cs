using UnityEngine;
internal sealed class StartMiniGameGuiController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject priceContainer;
    public UnityEngine.Transform ticketsIndicatorPoint;
    public UIButton rateButton;
    public UIButton customButton;
    public UITexture miniGameImage;
    public System.Collections.Generic.List<UILabel> miniGameName;
    public System.Collections.Generic.List<UILabel> miniGameDescription;
    public System.Collections.Generic.List<UILabel> priceLabels;
    private UnityEngine.GameObject _rateStarsContainer;
    private UnityEngine.GameObject _rateUsLabel;
    private Rilisoft.RateMiniGameController 丟丈上七丈丗上东丆;
    private Rilisoft.LeaderboardsMiniGameController 丘丕丟丁丛东丗丑丞;
    internal static Rilisoft.七丕丟丏三丈一丄世 万与丈世丝丙万丕一;
    private 丌丑丕丏丝丆上东丄 <七丗丟丄丅且丐丟东>k__BackingField;
    private Rilisoft.七丕丟丏三丈一丄世 <且丈丁专东丆丄丂与>k__BackingField;
    private System.IDisposable 丙世丈且丆丒下下丌;
    
    // Properties
    public 丌丑丕丏丝丆上东丄 丄丗丒专丆与丈上丁 { get; set; }
    public Rilisoft.七丕丟丏三丈一丄世 丒三丝一上丙专丗丒 { get; set; }
    private Rilisoft.RateMiniGameController 不且丏丏不丑专丆丁 { get; }
    private Rilisoft.LeaderboardsMiniGameController 丑丑与业丏丘丅丅上 { get; }
    
    // Methods
    private void Awake()
    {
    
    }
    public void HandleCoinsShop()
    {
        StartMiniGameGuiController.丌丟丘丏丕丅七万丕 val_1 = new StartMiniGameGuiController.丌丟丘丏丕丅七万丕();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .丑丘丐丂不丐丒丟且 = 0;
        .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  val_1, method:  System.Void StartMiniGameGuiController.丌丟丘丏丕丅七万丕::一丏丗丆丈丐万与丕(object 专丙丏丄与丛下丛丒, System.EventArgs 丏一丕七丆丘一世丙));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (StartMiniGameGuiController.丌丟丘丏丕丅七万丕)[1152921540435166000].丑丘丐丂不丐丒丟且);
        this.gameObject.SetActive(value:  false);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  "TicketsCurrency", 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    public 丌丑丕丏丝丆上东丄 get_Parameters()
    {
        return (丌丑丕丏丝丆上东丄)this.<七丗丟丄丅且丐丟东>k__BackingField;
    }
    private void 万专三专业丌丈丌且(丌丑丕丏丝丆上东丄 丙业与丙丗丝不丈东)
    {
        this.<七丗丟丄丅且丐丟东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public Rilisoft.七丕丟丏三丈一丄世 get_Type()
    {
        return (Rilisoft.七丕丟丏三丈一丄世)this.<且丈丁专东丆丄丂与>k__BackingField;
    }
    private void 东丝丕专丒丏三三与(Rilisoft.七丕丟丏三丈一丄世 丙业与丙丗丝不丈东)
    {
        this.<且丈丁专东丆丄丂与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Setup(Rilisoft.七丕丟丏三丈一丄世 丟丘万不丏丕丌丑丟, 丌丑丕丏丝丆上东丄 丗丅七业丝不三丄三)
    {
        var val_17;
        var val_18;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.<七丗丟丄丅且丐丟东>k__BackingField = 丗丅七业丝不三丄三;
        this.<且丈丁专东丆丄丂与>k__BackingField = 丟丘万不丏丕丌丑丟;
        if(this.customButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.customButton, 丏业丟一东丂东丘丛:  ((丟丘万不丏丕丌丑丟 == 9) ? 1 : 0) | ((丟丘万不丏丕丌丑丟 == 30) ? 1 : 0));
        }
        
        this.丏业丐丕东丘专丕七().GameMode = 丟丘万不丏丕丌丑丟;
        this.丘丞丏丙七丕与专丑().丗丟丏不下丆不与专(丙业与丙丗丝不丈东:  new System.Nullable<Rilisoft.七丕丟丏三丈一丄世>() {HasValue = false});
        val_17 = null;
        val_17 = null;
        StartMiniGameGuiController.万与丈世丝丙万丕一 = 丟丘万不丏丕丌丑丟;
        bool val_10 = (this.且丐丅丏上丅七丅世() > 0) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rateButton.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rateStarsContainer, 丏业丟一东丂东丘丛:  val_10);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rateUsLabel, 丏业丟一东丂东丘丛:  val_10);
        this.miniGameName.ForEach(action:  new System.Action<UILabel>(object:  this, method:  System.Void StartMiniGameGuiController::世专丝丗丂丆丑丞丌(UILabel 七丐丞丑丑丕世丙七)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceContainer, 丏业丟一东丂东丘丛:  ((this.<七丗丟丄丅且丐丟东>k__BackingField.丏上专丐三丛丁丗丆) > 0) ? 1 : 0);
        this.priceLabels.ForEach(action:  new System.Action<UILabel>(object:  this, method:  System.Void StartMiniGameGuiController::丕丆下上世丝丕世丝(UILabel 七丐丞丑丑丕世丙七)));
        this.miniGameDescription.ForEach(action:  new System.Action<UILabel>(object:  this, method:  System.Void StartMiniGameGuiController::丏丟丞丄丈丁丆丟不(UILabel 七丐丞丑丑丕世丙七)));
        UnityEngine.Texture val_16 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "MiniGames/Preview/{0}_preview", arg0:  this.<且丈丁专东丆丄丂与>k__BackingField));
        val_18 = null;
        val_18 = null;
        MainMenuController.丄丞丁丈与业上丞丟.丁七丆丏三丆丞丛且(丂丛丑东不丅丈一东:  this.<且丈丁专东丆丄丂与>k__BackingField);
    }
    private void OnEnable()
    {
        this.丒业上丆丘丄丅专丘();
        this.丙世丈且丆丒下下丌 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void StartMiniGameGuiController::HandleBackButtonPressed()), 与且专丈不万东一万:  "StartMiniGameGuiController");
    }
    private void OnDisable()
    {
        this.丒业上丆丘丄丅专丘();
    }
    public void HandleBackButtonPressed()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        this.丒业上丆丘丄丅专丘();
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丗丗与丝丐业丘丆丈();
    }
    public void HandleRatePressed()
    {
        this.丏业丐丕东丘专丕七().丘丘一七丛东丑丕专(下下东且万业丞丅丒:  true);
    }
    public void HandleGoPressed()
    {
        丈丞丕丘丕丗与上一 val_1 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  this.<七丗丟丄丅且丐丟东>k__BackingField.丏上专丐三丛丁丗丆, 丏丂不专上丘丂不丅:  "TicketsCurrency");
        System.Action val_2 = new System.Action(object:  this, method:  System.Void StartMiniGameGuiController::下七丛世丁丗三东东());
        if(val_1.丟丂丞不专丆万丒世() >= 1)
        {
                上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_1, 七丒上且丝业业下七:  val_2, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  (((this.<且丈丁专东丆丄丂与>k__BackingField) & 4294967294) != 12) ? 1 : 0, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  101);
            return;
        }
        
        val_2.Invoke();
    }
    private Rilisoft.RateMiniGameController 丏业丐丕东丘专丕七()
    {
        Rilisoft.RateMiniGameController val_3;
        if(this.丟丈上七丈丗上东丆 == 0)
        {
                this.丟丈上七丈丗上东丆 = this.GetComponent<Rilisoft.RateMiniGameController>();
            return val_3;
        }
        
        val_3 = this.丟丈上七丈丗上东丆;
        return val_3;
    }
    private Rilisoft.LeaderboardsMiniGameController 丘丞丏丙七丕与专丑()
    {
        Rilisoft.LeaderboardsMiniGameController val_3;
        if(this.丘丕丟丁丛东丗丑丞 == 0)
        {
                this.丘丕丟丁丛东丗丑丞 = this.GetComponent<Rilisoft.LeaderboardsMiniGameController>();
            return val_3;
        }
        
        val_3 = this.丘丕丟丁丛东丗丑丞;
        return val_3;
    }
    private static void 丘丛不丙世丅丅且丈()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.StartSurvivalButton();
    }
    private static void 东丗专丅丐上上东一()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.StartClassicArenaButton();
    }
    private void 丒业上丆丘丄丅专丘()
    {
        if(this.丙世丈且丆丒下下丌 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丙世丈且丆丒下下丌.Dispose();
        this.丙世丈且丆丒下下丌 = 0;
    }
    private int 且丐丅丏上丅七丅世()
    {
        return (int)丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "StartMiniGameGuiController.NumberOfMatches_{0}", arg0:  this.<且丈丁专东丆丄丂与>k__BackingField), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    private void 下东丛万三丗丝业且()
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  System.String.Format(format:  "StartMiniGameGuiController.NumberOfMatches_{0}", arg0:  this.<且丈丁专东丆丄丂与>k__BackingField), 下下丏一丙不丘丌丞:  this.且丐丅丏上丅七丅世() + 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void OnDestroy()
    {
        this.丒业上丆丘丄丅专丘();
    }
    public StartMiniGameGuiController()
    {
    
    }
    private static StartMiniGameGuiController()
    {
        StartMiniGameGuiController.万与丈世丝丙万丕一 = 100;
    }
    private void 世专丝丗丂丆丑丞丌(UILabel 七丐丞丑丑丕世丙七)
    {
        string val_4;
        if((this.<且丈丁专东丆丄丂与>k__BackingField) == 12)
        {
                val_4 = "Key_0456";
        }
        else
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = GameConnect.丛丛丏专丏下三与七().Item[???];
        }
        
        七丐丞丑丑丕世丙七.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
    }
    private void 丕丆下上世丝丕世丝(UILabel 七丐丞丑丑丕世丙七)
    {
        七丐丞丑丑丕世丙七.text = this.<七丗丟丄丅且丐丟东>k__BackingField.丏上专丐三丛丁丗丆.ToString();
    }
    private void 丏丟丞丄丈丁丆丟不(UILabel 七丐丞丑丑丕世丙七)
    {
        System.Collections.Generic.IDictionary<System.Int32, System.String> val_3;
        Rilisoft.七丕丟丏三丈一丄世 val_4;
        string val_5;
        var val_6;
        val_3 = this;
        val_4 = this.<且丈丁专东丆丄丂与>k__BackingField;
        if(val_4 == 12)
        {
                val_5 = "Key_0974";
        }
        else
        {
                val_6 = null;
            val_6 = null;
            val_4 = this.<且丈丁专东丆丄丂与>k__BackingField;
            val_3 = GameConnect.丕丒上东丞丕丞一三;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = val_3.Item[???];
        }
        
        七丐丞丑丑丕世丙七.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5);
    }
    private void 下七丛世丁丗三东东()
    {
        Rilisoft.七丕丟丏三丈一丄世 val_11;
        System.Action val_12;
        var val_13;
        var val_14;
        string val_8 = 0;
        if((this.<且丈丁专东丆丄丂与>k__BackingField) == 9)
        {
            goto label_6;
        }
        
        Rilisoft.一丟专且三万丞丁丂.丝丕业与丗三丕七丒(丛丝丗万丐业丒丂丞:  this.<且丈丁专东丆丄丂与>k__BackingField);
        if((this.<且丈丁专东丆丄丂与>k__BackingField) == 25)
        {
            goto label_4;
        }
        
        if((this.<且丈丁专东丆丄丂与>k__BackingField) == 13)
        {
            goto label_5;
        }
        
        if((this.<且丈丁专东丆丄丂与>k__BackingField) != 12)
        {
            goto label_6;
        }
        
        this.下东丛万三丗丝业且();
        StartMiniGameGuiController.丘丛不丙世丅丅且丈();
        goto label_9;
        label_6:
        StartMiniGameGuiController.丐丐七丈丅丐三且丆 val_1 = new StartMiniGameGuiController.丐丐七丈丅丐三且丆();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            val_11 = this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        else
        {
                mem[24] = this;
            val_11 = this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        
        .丐不丄丄丞丁上世三 = val_11;
        System.Action val_2 = null;
        val_12 = val_2;
        val_2 = new System.Action(object:  val_1, method:  System.Void StartMiniGameGuiController.丐丐七丈丅丐三且丆::三丁丙丟丏三下丗东());
        if(((StartMiniGameGuiController.丐丐七丈丅丐三且丆)[1152921540438473040].丐不丄丄丞丁上世三 == 10) && (Rilisoft.CheckpointsRewardedVideoController.丑七不且上丗丁一世() != 0))
        {
                if(Rilisoft.CheckpointsRewardedVideoController.丑七不且上丗丁一世().丄丛丅丐世丌丕且丛() != false)
        {
                if((Rilisoft.CheckpointsRewardedVideoController.丑七不且上丗丁一世().丘丏丅丏与丈上丛丞(业丏丈世世世丞丒世:  val_2, 丏丞专丏业丗丝七丝: out  val_8)) == true)
        {
                return;
        }
        
            UnityEngine.Debug.LogWarning(message:  "[StartMiniGameGuiController.HandleGoPressed] " + val_8);
        }
        
        }
        
        val_2.Invoke();
        return;
        label_5:
        this.下东丛万三丗丝业且();
        val_13 = null;
        val_13 = null;
        MainMenuController.丄丞丁丈与业上丞丟.StartSpeedrunButton();
        MainMenuController.丂不三丈丕丑丌业下 = 0;
        val_12 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业;
        if(val_12 != null)
        {
            goto label_34;
        }
        
        goto label_34;
        label_4:
        this.下东丛万三丗丝业且();
        StartMiniGameGuiController.东丗专丅丐上上东一();
        label_9:
        val_14 = null;
        val_14 = null;
        MainMenuController.丂不三丈丕丑丌业下 = 0;
        val_12 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业;
        label_34:
        PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.专上且丗丑丌丟丈丄 = true;
    }
    private void 一丑丌专世丞丂专丆()
    {
        一丙丅丛丁东丅丅世(上业丈东万下世丝丁:  new System.Action(object:  this, method:  System.Void StartMiniGameGuiController::丑丒丝丏丕丁业丂丕()), 丏丈丗世丙万丆丐丅:  0, 丐且丘丑与万丞丑丅:  0);
    }
    private void 丑丒丝丏丕丁业丂丕()
    {
        null = null;
        MainMenuController.丂不三丈丕丑丌业下 = 0;
        this.下东丛万三丗丝业且();
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        UnityEngine.Coroutine val_3 = CoroutineRunner.Instance.StartCoroutine(routine:  MainMenuController.丝业丗上上丘丐与丗(丛丑丂丛丙一上专丆:  true, 世不丛业丟丝与丆丙:  false, 丑丐丗三丒世丏东丅:  "", 丒不丙万万不丕丞与:  false, 丌与一丌且一不七丆:  false, 丝丅与业且一丛丒一:  false, 丁丟丑丆三丆业一丅:  0, 丅与丏与丙东世丌世:  100));
    }

}
