using UnityEngine;
internal sealed class InfoWindowController : MonoBehaviour
{
    // Fields
    private static InfoWindowController 丝业丆丁业三丈丟东;
    private static readonly System.Collections.Generic.Queue<InfoWindowController.不丌丅丗丁丟丅丐一> 东万下丅下东七一万;
    public UnityEngine.Camera camera;
    private System.Collections.Generic.List<UnityEngine.GameObject> _listReviewWindows;
    private UnityEngine.WaitForSeconds 丈丂丙丂丘一与丟丄;
    private UnityEngine.Coroutine 七丑丑丗丏七丏且丄;
    private System.IDisposable 丐丆七且丞丏下三丙;
    public UnityEngine.GameObject autoTestProcessingPanel;
    public ErrorMessage autoTestErrorMessage;
    public UILabel autoTestTimeLabel;
    public UILabel autoTestLapsLabel;
    private UITexture restoreWindowTexture;
    private UnityEngine.GameObject _batteryNotification;
    private Rilisoft.TextGroup _batteryNotificationTextGroup;
    private AchieveBox _battleInviteBox;
    private AchieveBox _clanSiegeInviteBox;
    private ConnectToClanSiegeButton _clanSiegeMessagePanel;
    private AchieveBox _clanWarInviteBox;
    private ConnectToClanWarButton _clanWarMessagePanel;
    private AchieveBox _clanWarTestInviteBox;
    private PGCompany.ConnectToClanWarTestButton _clanWarTestMessagePanel;
    private PGCompany.ClanWarTaskDoneAchieveBox _clanWarTaskBox;
    private PGCompany.ClanWarStartEndAchieveBox _clanWarStartEndBox;
    private PGCompany.ClanWarRaidStartAchieveBox _clanWarRaidStartBox;
    private UILabel _friendNickname;
    private float 丗专丌七三丑万上丄;
    private float 丄上与丈一丐不丘丌;
    private UnityEngine.GameObject _softDisconnectObject;
    private UnityEngine.GameObject _noInternetConnection;
    private UnityEngine.GameObject _noInternetConnectionTouchBlocker;
    private UnityEngine.GameObject _noStoreLogin;
    private UnityEngine.GameObject _noStoreLoginTouchBlocker;
    private AchieveBox _offerwallRewardBox;
    private Rilisoft.TextGroup _offerwallRewardCoins;
    private UnityEngine.GameObject _offerwallRewardCoinsParent;
    private Rilisoft.TextGroup _offerwallRewardGems;
    private UnityEngine.GameObject _offerwallRewardGemsParent;
    private AchieveBox _squadInviteBox;
    private ConnectToSquadButton _squadMessagePanel;
    private InfoWindowController.世不丒东丅丒三丈丆 丆世丟三万丘业丝一;
    private System.Action 丒丏三丄世丅下上专;
    public AchieveBox achievementBox;
    public UILabel[] achievementOrLikeHeader;
    public UISprite achievementSpriteIcon;
    public UILabel achievementText;
    public UITexture achievementTextureBg;
    public UIWidget background;
    public AchieveBox basicBox;
    public UISprite basicSpriteIcon;
    public Rilisoft.TextGroup basicTextFoolterSmall;
    public Rilisoft.TextGroup basicTextHeaderSmall;
    public Rilisoft.TextGroup basicTextLarge;
    public UIBasicSprite basicTextureIcon;
    public AchieveBox ChallengeAlternativeDoneBox;
    public AchieveBox ChallengeAlternativeProgressBox;
    public AchieveBox ChallengeDoneBox;
    public AchieveBox ChallengeProgressBox;
    private UnityEngine.GameObject 不上世丆丆专丁丛丏;
    private System.Action 上丏丒世世且一丗丗;
    public UIWidget dialogBoxContainer;
    private System.Action 丘丒丛三三世一不丗;
    public UILabel dialogBoxText;
    public ExchangeWindow ExchangeWindow;
    public AchieveBox iconTextBox;
    public UILabel iconTextLabel;
    public UISprite iconTextSprite;
    public UIWidget infoBoxContainer;
    public UILabel infoBoxLabel;
    public UnityEngine.Camera infoWindowCamera;
    public UnityEngine.Transform InfoWindowsRoot;
    public UISprite likeSpriteIcon;
    public UIWidget processindDataBoxContainer;
    public UILabel processingDataBoxLabel;
    public AchieveBox questBox;
    public UnityEngine.AudioClip questCompleteSound;
    public UILabel questText;
    public UnityEngine.GameObject restoreWindowPanel;
    public AchieveBox textBox;
    public UILabel textLabel;
    public TimerBox TimerBox;
    public ServerMessageBox ServerMessage;
    public AchieveBox vipBox;
    public UISprite vipSpriteIcon;
    public Rilisoft.TextGroup vipTextFoolterSmall;
    public Rilisoft.TextGroup vipTextHeaderSmall;
    public Rilisoft.TextGroup vipTextLarge;
    public UIBasicSprite vipTextureIcon;
    public UnityEngine.Transform itemViewerPlacePoint;
    public CompetitionConnectWindow competitionConnectWindow;
    public AchieveBox PixelPassTaskAchieveBox;
    private FreePlayTaskProgressView freePlayTaskProgressNotification;
    private AchieveBox freePlayTaskProgressNotificationAchieveBox;
    internal bool 丗东丐丈丞丁且丁万;
    
    // Properties
    internal static InfoWindowController 丆丕丝丒不丙且丐丗 { get; }
    internal static bool 丅业东万丌丕上丌丄 { get; }
    internal bool 丘世一东丘上且丞万 { get; }
    
    // Methods
    public void ShowAutoTestErrorMessage(string 丌一一七丗丗七下七)
    {
    
    }
    public void StopTestingArsenal()
    {
    
    }
    internal static InfoWindowController 丑七不且上丗丁一世()
    {
        var val_10;
        InfoWindowController val_11;
        InfoWindowController val_12;
        var val_13;
        var val_14;
        val_10 = null;
        val_10 = null;
        val_11 = InfoWindowController.丝业丆丁业三丈丟东;
        if(val_11 != 0)
        {
            goto label_21;
        }
        
        val_11 = UnityEngine.Resources.Load(path:  "InfoWindows");
        val_12 = 0;
        if(val_11 == 0)
        {
                return val_12;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  567f);
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
        val_13 = UnityEngine.Object.Instantiate(original:  val_11, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
        if(val_13 == null)
        {
            goto label_15;
        }
        
        if(null == null)
        {
            goto label_18;
        }
        
        val_13 = 0;
        goto label_18;
        label_15:
        label_18:
        val_14 = null;
        val_11 = val_13.GetComponent<InfoWindowController>();
        val_14 = null;
        InfoWindowController.丝业丆丁业三丈丟东 = val_11;
        label_21:
        val_12 = InfoWindowController.丝业丆丁业三丈丟东;
        return val_12;
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        var val_6;
        InfoWindowController val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = InfoWindowController.丝业丆丁业三丈丟东;
        if(val_7 == 0)
        {
                return false;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = mem[InfoWindowController.丝业丆丁业三丈丟东 + 528];
        val_7 = InfoWindowController.丝业丆丁业三丈丟东.infoBoxContainer;
        if(val_7 == 0)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = gameObject;
        if(val_7 == 0)
        {
                return false;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.GameObject val_5 = gameObject;
        if(val_5 != null)
        {
                return val_5.activeInHierarchy;
        }
        
        return val_5.activeInHierarchy;
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        this.autoTestProcessingPanel.SetActive(value:  false);
        this.autoTestErrorMessage.gameObject.SetActive(value:  false);
    }
    private void Start()
    {
        this.processingDataBoxLabel.text = 丟丏下丂七三下丗丕.不丈丂丛万丐七世丛();
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void InfoWindowController::丞丛一丙丂世丈丅丗()));
    }
    private void OnDisable()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        if(InfoWindowController.东万下丅下东七一万.Count >= 1)
        {
                val_7 = null;
            val_7 = null;
            不丌丅丗丁丟丅丐一 val_2 = InfoWindowController.东万下丅下东七一万.Dequeue();
            if(val_2 != null)
        {
                val_2.且万丆七世三不丆丑(丙业与丙丗丝不丈东:  false);
        }
        else
        {
                val_2.且万丆七世三不丆丑(丙业与丙丗丝不丈东:  false);
        }
        
            AchieveBox val_3 = val_2.下七上丐丘丟丒三丞();
            val_3.isOpened = false;
        }
        
        if(this._noInternetConnection != 0)
        {
                this._noInternetConnection.SetActive(value:  false);
        }
        
        if(this._noStoreLogin != 0)
        {
                this._noStoreLogin.SetActive(value:  false);
        }
        
        if(this.七丑丑丗丏七丏且丄 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.七丑丑丗丏七丏且丄);
        this.七丑丑丗丏七丏且丄 = 0;
    }
    private void OnDestroy()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void InfoWindowController::丞丛一丙丂世丈丅丗()));
        if(this.丒丏三丄世丅下上专 != null)
        {
                this.丒丏三丄世丅下上专.Invoke();
        }
        
        if(this.七丑丑丗丏七丏且丄 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.七丑丑丗丏七丏且丄);
        this.七丑丑丗丏七丏且丄 = 0;
    }
    internal void 丞丙下丑丗丑丝业丁()
    {
        if(this.七丑丑丗丏七丏且丄 != null)
        {
                return;
        }
        
        this.七丑丑丗丏七丏且丄 = this.StartCoroutine(routine:  this.三丛上万丏丅业上丌());
    }
    internal bool 丅丗下丝东三丗业丞()
    {
        null = null;
        return (bool)(InfoWindowController.东万下丅下东七一万.Count > 0) ? 1 : 0;
    }
    private System.Collections.IEnumerator 三丛上万丏丅业上丌()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new InfoWindowController.丟丝丞丂丙丝七下丄(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        this.processingDataBoxLabel.text = 丟丏下丂七三下丗丕.不丈丂丛万丐七世丛();
    }
    private void 丄丙丄丟丕一丌三东()
    {
    
    }
    private void 丂丏丅东丒丘丙丙丆(string 丕丗丘丑丛与丑业丒)
    {
        InfoWindowController val_1 = InfoWindowController.丑七不且上丗丁一世();
        if(val_1.丐丆七且丞丏下三丙 != null)
        {
                InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_2.丐丆七且丞丏下三丙.Dispose();
        }
        
        InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
        val_4.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  InfoWindowController.丑七不且上丗丁一世(), method:  System.Void InfoWindowController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Info Window");
        this.infoBoxLabel.text = 丕丗丘丑丛与丑业丒;
        this.infoBoxContainer.gameObject.SetActive(value:  true);
        this.background.gameObject.SetActive(value:  true);
    }
    internal void 丐专丅世专万丒丑丝(bool 世丁万下丗专世万丅)
    {
        if(this._softDisconnectObject.activeInHierarchy ^ 世丁万下丗专世万丅 == false)
        {
                return;
        }
        
        this = this._softDisconnectObject.GetComponent<TweenAlpha>();
        if(世丁万下丗专世万丅 == false)
        {
            goto label_4;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._softDisconnectObject, 丏业丟一东丂东丘丛:  true);
        if(this == 0)
        {
                return;
        }
        
        if(this == null)
        {
            goto label_10;
        }
        
        this.enabled = true;
        this.ResetToBeginning();
        goto label_11;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._softDisconnectObject, 丏业丟一东丂东丘丛:  false);
        if(this == 0)
        {
                return;
        }
        
        this.enabled = false;
        return;
        label_10:
        0.enabled = true;
        0.ResetToBeginning();
        label_11:
        this.PlayForward();
    }
    public void OnClickOkDialog()
    {
        if(this.丘丒丛三三世一不丗 != null)
        {
                this.丘丒丛三三世一不丗.Invoke();
        }
        
        this.丗且丒一丗丐上东丐();
    }
    public void OnClickOkDialogRestorePanel()
    {
        if(this.丘丒丛三三世一不丗 != null)
        {
                this.丘丒丛三三世一不丗.Invoke();
        }
        
        this.丕下丙丞丂丑丆丄丝();
    }
    public void OnClickCancelDialog()
    {
        if(this.上丏丒世世且一丗丗 != null)
        {
                this.上丏丒世世且一丗丗.Invoke();
        }
        
        this.丗且丒一丗丐上东丐();
    }
    private void 丟三业世且丑且丛丆(string 丕丗丘丑丛与丑业丒, System.Action 不万丝丟上丅丞丗上, System.Action 丛丟万且丞丛世且丞)
    {
        this.dialogBoxText.text = 丕丗丘丑丛与丑业丒;
        this.dialogBoxContainer.gameObject.SetActive(value:  true);
        this.丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  true);
        this.丘丒丛三三世一不丗 = 不万丝丟上丅丞丗上;
        this.上丏丒世世且一丗丗 = 丛丟万且丞丛世且丞;
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        if(val_2.丐丆七且丞丏下三丙 != null)
        {
                InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_3.丐丆七且丞丏下三丙.Dispose();
        }
        
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        val_5.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  InfoWindowController.丑七不且上丗丁一世(), method:  System.Void InfoWindowController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Dialog Box");
    }
    internal void 丏东不丌世万丏丌一(System.Action 东丕丞丟一万丈丛丅)
    {
        var val_21;
        UnityEngine.GameObject val_22;
        object val_24;
        val_21 = this;
        val_22 = this.restoreWindowPanel;
        if(val_22 == 0)
        {
                return;
        }
        
        this.restoreWindowPanel.SetActive(value:  true);
        this.丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  false);
        this.丘丒丛三三世一不丗 = 东丕丞丟一万丈丛丅;
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        if(val_2.丐丆七且丞丏下三丙 != null)
        {
                InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_3.丐丆七且丞丏下三丙.Dispose();
        }
        
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        val_24 = InfoWindowController.丑七不且上丗丁一世();
        val_22 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  val_24, method:  System.Void InfoWindowController::七上下世世丟丟丛丌()), 与且专丈不万东一万:  "Restore Panel");
        val_5.丐丆七且丞丏下三丙 = val_22;
        if(this.restoreWindowTexture == 0)
        {
                return;
        }
        
        if(this.restoreWindowTexture != 0)
        {
                return;
        }
        
        UnityEngine.Texture val_12 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Textures/Bank/StarterPack_Weapon");
        val_21 = ???;
        val_22 = ???;
        val_24 = ???;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
    }
    private void 七上下世世丟丟丛丌()
    {
    
    }
    private void 丁上东丟丅丅一丆三()
    {
        var val_10;
        var val_11;
        System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_13;
        var val_14;
        var val_15;
        float val_16;
        val_10 = null;
        val_10 = null;
        val_11 = null;
        val_11 = null;
        val_13 = InfoWindowController.<>c.<>9__117_0;
        if(val_13 == null)
        {
                System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_1 = null;
            val_13 = val_1;
            val_1 = new System.Func<不丌丅丗丁丟丅丐一, System.Boolean>(object:  InfoWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InfoWindowController.<>c::业七三且丛业丑丘丘(InfoWindowController.不丌丅丗丁丟丅丐一 七丞丙丒三丕且丌丟));
            InfoWindowController.<>c.<>9__117_0 = val_13;
        }
        
        if((System.Linq.Enumerable.Any<不丌丅丗丁丟丅丐一>(source:  InfoWindowController.东万下丅下东七一万, predicate:  val_1)) == true)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(InfoWindowController.东万下丅下东七一万.Count < 1)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        不丌丅丗丁丟丅丐一 val_4 = InfoWindowController.东万下丅下东七一万.Peek();
        if(val_4 == null)
        {
            goto label_17;
        }
        
        val_16 = 10f;
        if((((null == null) || (null == null)) || (null == null)) || (null == null))
        {
            goto label_21;
        }
        
        label_17:
        val_16 = 3f;
        label_21:
        val_13 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_7 = val_13.StartCoroutine(routine:  this.丐丈一丐丆丝丅丝丌(丛丄丌三丁丝丈且七:  val_4, 业东且万丄丈业上丝:  val_16));
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.questCompleteSound);
    }
    internal void 丞丐丝丁世丒丈万丐(bool 下下东且万业丞丅丒, decimal 不七丁丘且丁丝七丗)
    {
        int val_9;
        Rilisoft.TextGroup val_10;
        Rilisoft.TextGroup val_11;
        var val_12;
        val_9 = 不七丁丘且丁丝七丗.flags;
        val_10 = this;
        if(this._batteryNotification != 0)
        {
                this._batteryNotification.SetActive(value:  下下东且万业丞丅丒);
        }
        
        val_11 = this._batteryNotificationTextGroup;
        if(val_11 == 0)
        {
                return;
        }
        
        if(下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_9, hi = 不七丁丘且丁丝七丗.hi, lo = 不七丁丘且丁丝七丗.lo, mid = 不七丁丘且丁丝七丗.mid}, d2:  new System.Decimal());
        decimal val_5 = System.Math.Max(val1:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, val2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        val_9 = val_5.lo;
        val_10 = this._batteryNotificationTextGroup;
        val_11 = System.Globalization.CultureInfo.InvariantCulture;
        val_10.Text = System.String.Format(provider:  val_11, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3653"), arg0:  val_5);
    }
    private System.Collections.IEnumerator 丐丈一丐丆丝丅丝丌(InfoWindowController.不丌丅丗丁丟丅丐一 丛丄丌三丁丝丈且七, float 业东且万丄丈业上丝)
    {
        InfoWindowController.丅丁三丙三丕丁丗业 val_1 = new InfoWindowController.丅丁三丙三丕丁丗业(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丛丄丌三丁丝丈且七 = 丛丄丌三丁丝丈且七;
            .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
            mem[40] = 丛丄丌三丁丝丈且七;
        }
        
        .业东且万丄丈业上丝 = 业东且万丄丈业上丝;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 三东一且丑丑丙下丅(InfoWindowController.不丌丅丗丁丟丅丐一 丛丄丌三丁丝丈且七)
    {
        InfoWindowController.丕且丅丒丞丂丌上丏 val_1 = new InfoWindowController.丕且丅丒丞丂丌上丏(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丛丄丌三丁丝丈且七 = 丛丄丌三丁丝丈且七;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 三丅丆与丄丆与丙三()
    {
        this.questBox.HideBox();
    }
    private void 上丕丘丕东丑丁丅丙()
    {
        this.丘丒丛三三世一不丗 = 0;
        this.上丏丒世世且一丗丗 = 0;
        if(this.restoreWindowPanel == 0)
        {
                return;
        }
        
        this.restoreWindowPanel.SetActive(value:  false);
    }
    private void 丆丘业丂丞上一丁下()
    {
        this.丘丒丛三三世一不丗 = 0;
        this.上丏丒世世且一丗丗 = 0;
        this.dialogBoxContainer.gameObject.SetActive(value:  false);
    }
    private void 三丁丗丕丌丒万丞丅()
    {
        this.background.gameObject.SetActive(value:  false);
        this.infoBoxContainer.gameObject.SetActive(value:  false);
    }
    private void 丌一丑不不上世丅世(bool 丑丒业丘丑东丕世丅)
    {
        this.processindDataBoxContainer.gameObject.SetActive(value:  丑丒业丘丑东丕世丅);
    }
    internal void 丂丟东上丒丙且一下(bool 丑丒业丘丑东丕世丅)
    {
        this.background.gameObject.SetActive(value:  丑丒业丘丑东丕世丅);
    }
    private void 上丛丌丆丑上七世三(InfoWindowController.世不丒东丅丒三丈丆 丙且丄丑丂万丅丘丗)
    {
        this.丆世丟三万丘业丝一 = 丙且丄丑丂万丅丘丗;
        this.丞丙下丑丗丑丝业丁();
        this.gameObject.SetActive(value:  true);
    }
    private void HideInfoAndProcessingBox()
    {
        if(this.丒丏三丄世丅下上专 != null)
        {
                this.丒丏三丄世丅下上专.Invoke();
        }
        
        this.丌一丑不不上世丅世(丑丒业丘丑东丕世丅:  false);
        if((this.丆世丟三万丘业丝一 - 1) > 1)
        {
                return;
        }
        
        if(this.丆世丟三万丘业丝一 == 1)
        {
                this.三丁丗丕丌丒万丞丅();
        }
        
        this.丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  false);
        this.丆世丟三万丘业丝一 = 0;
    }
    private void 丗且丒一丗丐上东丐()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        if(this.丒丏三丄世丅下上专 != null)
        {
                this.丒丏三丄世丅下上专.Invoke();
        }
        
        this.丆丘业丂丞上一丁下();
        this.丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  false);
        this.infoBoxContainer.gameObject.SetActive(value:  false);
        if(this.丆世丟三万丘业丝一 != 4)
        {
                return;
        }
        
        this.丆世丟三万丘业丝一 = 0;
    }
    internal void 不七东丘丙丌世丏丒()
    {
        this.freePlayTaskProgressNotificationAchieveBox.HideBox();
    }
    public void HideTimerBox()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        if(this.丒丏三丄世丅下上专 != null)
        {
                this.丒丏三丄世丅下上专.Invoke();
        }
        
        this.TimerBox.gameObject.SetActive(value:  false);
        if(this.丆世丟三万丘业丝一 != 19)
        {
                return;
        }
        
        this.丆世丟三万丘业丝一 = 0;
    }
    public void HideServerMessageBox()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        if(this.丒丏三丄世丅下上专 != null)
        {
                this.丒丏三丄世丅下上专.Invoke();
        }
        
        this.ServerMessage.gameObject.SetActive(value:  false);
        if(this.丆世丟三万丘业丝一 != 20)
        {
                return;
        }
        
        this.丆世丟三万丘业丝一 = 0;
    }
    private void 丕下丙丞丂丑丆丄丝()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        if(this.丒丏三丄世丅下上专 != null)
        {
                this.丒丏三丄世丅下上专.Invoke();
        }
        
        if(this.丆世丟三万丘业丝一 == 0)
        {
                return;
        }
        
        this.上丕丘丕东丑丁丅丙();
        this.丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  false);
        this.丆世丟三万丘业丝一 = 0;
    }
    private void 丆世与丑丆丅丐万且()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        if(this.丒丏三丄世丅下上专 != null)
        {
                this.丒丏三丄世丅下上专.Invoke();
        }
        
        if(this.丆世丟三万丘业丝一 <= 6)
        {
                var val_3 = 106014060 + (this.丆世丟三万丘业丝一) << 2;
            val_3 = val_3 + 106014060;
        }
        else
        {
                this.丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  false);
            this.丆世丟三万丘业丝一 = 0;
        }
    
    }
    internal static void 丟丛业且丁丂上丑丝(string 丕丗丘丑丛与丑业丒)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  1);
        InfoWindowController.丑七不且上丗丁一世().丂丏丅东丒丘丙丙丆(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    internal static void 丟三丟丁丐与不丗且()
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  7);
        if(InfoWindowController.丑七不且上丗丁一世() != null)
        {
                return;
        }
    
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        this.OnClickCancelDialog();
    }
    internal static void 东丆丄丒丅丗丌丏下()
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  2);
        InfoWindowController.丑七不且上丗丁一世().丌一丑不不上世丅世(丑丒业丘丑东丕世丅:  true);
        InfoWindowController.丑七不且上丗丁一世().丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  false);
    }
    internal static void 丘东丕丌丌东丟丕专()
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  3);
        InfoWindowController.丑七不且上丗丁一世().丂丟东上丒丙且一下(丑丒业丘丑东丕世丅:  true);
    }
    internal static void 丕丌丞七丛三一丌万(string 丕丗丘丑丛与丑业丒, System.Action 东不丒丗万丏世世丒, System.Action 丏丙且东丑上丗丏丛)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  4);
        InfoWindowController.丑七不且上丗丁一世().丟三业世且丑且丛丆(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 不万丝丟上丅丞丗上:  东不丒丗万丏世世丒, 丛丟万且丞丛世且丞:  丏丙且东丑上丗丏丛);
    }
    internal static void 一丏丐丕丏丛一丒上(System.Action 东丕丞丟一万丈丛丅)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  6);
        InfoWindowController.丑七不且上丗丁一世().丏东不丌世万丏丌一(东丕丞丟一万丈丛丅:  东丕丞丟一万丈丛丅);
    }
    internal static void 上丁丐丆丗丐与业丗(PGCompany.世丐下丕专东丘丏且 三东丏丐丟三丕丈上)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  26);
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丐一世丅丄丟上东万(不丌丗丂丆业丂丏世:  val_2.freePlayTaskProgressNotificationAchieveBox, 丙丒七丄上与丏丙丙:  三东丏丐丟三丕丈上, 丏丏与丗一专上丆丆:  false));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 上与上丒丕丌丕丑丗(PGCompany.世丐下丕专东丘丏且 三东丏丐丟三丕丈上)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  26);
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丐一世丅丄丟上东万(不丌丗丂丆业丂丏世:  val_2.freePlayTaskProgressNotificationAchieveBox, 丙丒七丄上与丏丙丙:  三东丏丐丟三丕丈上, 丏丏与丗一专上丆丆:  true));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丙丟东七不一丅丁丆(string 且丂丅业丞三丆丗丌, string 丕丗丘丑丛与丑业丒)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  5);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.丁三丂丌丗专丞丈上 val_4 = new InfoWindowController.丁三丂丌丗专丞丈上(不丌丗丂丆业丂丏世:  val_3.questBox);
        if(val_4 != null)
        {
                .丅万丒世丗丕上丁业 = 且丂丅业丞三丆丗丌;
        }
        else
        {
                mem[32] = 且丂丅业丞三丆丗丌;
        }
        
        .不三世丏丙丁与丑丒 = 丕丗丘丑丛与丑业丒;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_4);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丆七下与丁丟丌且丑(string 丕丗丘丑丛与丑业丒, UnityEngine.Texture 业东丗东不丟业丁丆, string 不上丏上丝丆一丛丑, bool 丂丕丄丏丙与丄丐一)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  8);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.不丛世丑丂丅七业丁 val_4 = new InfoWindowController.不丛世丑丂丅七业丁(不丌丗丂丆业丂丏世:  val_3.achievementBox);
        if(val_4 != null)
        {
                .丏东丙丙丈丘丐丝丄 = 不上丏上丝丆一丛丑;
            .不三世丏丙丁与丑丒 = 丕丗丘丑丛与丑业丒;
            .丘丛不与丌丘丏丛丙 = 业东丗东不丟业丁丆;
        }
        else
        {
                mem[56] = 丕丗丘丑丛与丑业丒;
            mem[32] = 业东丗东不丟业丁丆;
            mem[48] = 不上丏上丝丆一丛丑;
        }
        
        .丕专丑丁丐上丏专不 = 丂丕丄丏丙与丄丐一;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_4);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 七丏不丕丈丁丗丒不(string 丕丗丘丑丛与丑业丒, string 世丙丁丗业丝世丕丈, UnityEngine.Texture 不且丁丐不丌丟上丌, string 不上丏上丝丆一丛丑)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  11);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.一三世万丁丘丛丅世 val_4 = new InfoWindowController.一三世万丁丘丛丅世(不丌丗丂丆业丂丏世:  val_3.basicBox);
        if(val_4 != null)
        {
                .七世且丞丗丙与丝丅 = 世丙丁丗业丝世丕丈;
            .不三世丏丙丁与丑丒 = 丕丗丘丑丛与丑业丒;
            .三丒丒丝丘一世丈东 = 不且丁丐不丌丟上丌;
        }
        else
        {
                mem[48] = 丕丗丘丑丛与丑业丒;
            mem[40] = 世丙丁丗业丝世丕丈;
            mem[56] = 不且丁丐不丌丟上丌;
        }
        
        .丏东丙丙丈丘丐丝丄 = 不上丏上丝丆一丛丑;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_4);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丙丈与丙丑丁东业七(string 丕丗丘丑丛与丑业丒, string 世丙丁丗业丝世丕丈, UnityEngine.Texture 不且丁丐不丌丟上丌, string 不上丏上丝丆一丛丑)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  12);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.万丌丟业丅丈丐丌丘 val_4 = new InfoWindowController.万丌丟业丅丈丐丌丘(不丌丗丂丆业丂丏世:  val_3.vipBox);
        if(val_4 != null)
        {
                .七世且丞丗丙与丝丅 = 世丙丁丗业丝世丕丈;
            .不三世丏丙丁与丑丒 = 丕丗丘丑丛与丑业丒;
            .三丒丒丝丘一世丈东 = 不且丁丐不丌丟上丌;
        }
        else
        {
                mem[48] = 丕丗丘丑丛与丑业丒;
            mem[40] = 世丙丁丗业丝世丕丈;
            mem[56] = 不且丁丐不丌丟上丌;
        }
        
        .丏东丙丙丈丘丐丝丄 = 不上丏上丝丆一丛丑;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_4);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 世丌与丅与丏丌东丐(string 丏不丄丑丝丁丘万不, int 且下丆丕丝丄丑三三, int 丗丛万下丙丕上专丌)
    {
        var val_8;
        var val_9;
        System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_11;
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        val_11 = InfoWindowController.<>c.<>9__148_0;
        if(val_11 == null)
        {
                System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Func<不丌丅丗丁丟丅丐一, System.Boolean>(object:  InfoWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InfoWindowController.<>c::下万上东下专下丒丅(InfoWindowController.不丌丅丗丁丟丅丐一 三丟东丕丄丄下下丑));
            InfoWindowController.<>c.<>9__148_0 = val_11;
        }
        
        if((System.Linq.Enumerable.Count<不丌丅丗丁丟丅丐一>(source:  InfoWindowController.东万下丅下东七一万, predicate:  val_2)) > 2)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  17);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.丆世丘丌丒丐且丌不 val_6 = new InfoWindowController.丆世丘丌丒丐且丌不(不丌丗丂丆业丂丏世:  val_5.ChallengeProgressBox);
        if(val_6 != null)
        {
                .不三世丏丙丁与丑丒 = 丏不丄丑丝丁丘万不;
            .丙与丙丌丘丐三丆丙 = 且下丆丕丝丄丑三三;
        }
        else
        {
                mem[48] = 丏不丄丑丝丁丘万不;
            mem[56] = 且下丆丕丝丄丑三三;
        }
        
        .下丅丛不丄丙专丆下 = 丗丛万下丙丕上专丌;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_6);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丁丆三丗东丂丅专万(string 丏不丄丑丝丁丘万不, int 且下丆丕丝丄丑三三, int 丗丛万下丙丕上专丌)
    {
        var val_8;
        var val_9;
        System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_11;
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        val_11 = InfoWindowController.<>c.<>9__149_0;
        if(val_11 == null)
        {
                System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Func<不丌丅丗丁丟丅丐一, System.Boolean>(object:  InfoWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InfoWindowController.<>c::丟丛丑丘丛丐且丏三(InfoWindowController.不丌丅丗丁丟丅丐一 三丟东丕丄丄下下丑));
            InfoWindowController.<>c.<>9__149_0 = val_11;
        }
        
        if((System.Linq.Enumerable.Count<不丌丅丗丁丟丅丐一>(source:  InfoWindowController.东万下丅下东七一万, predicate:  val_2)) > 2)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  17);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.丆世丘丌丒丐且丌不 val_6 = new InfoWindowController.丆世丘丌丒丐且丌不(不丌丗丂丆业丂丏世:  val_5.ChallengeAlternativeProgressBox);
        if(val_6 != null)
        {
                .不三世丏丙丁与丑丒 = 丏不丄丑丝丁丘万不;
            .丙与丙丌丘丐三丆丙 = 且下丆丕丝丄丑三三;
        }
        else
        {
                mem[48] = 丏不丄丑丝丁丘万不;
            mem[56] = 且下丆丕丝丄丑三三;
        }
        
        .下丅丛不丄丙专丆下 = 丗丛万下丙丕上专丌;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_6);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丘丄丏丕丝业一丄与(string 丏不丄丑丝丁丘万不, string 丞丅上丏丂且下丅与, bool 丐万丗丒下七丟丁三)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  22);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.七丒且丄不世丄丟丌 val_4 = new InfoWindowController.七丒且丄不世丄丟丌(不丌丗丂丆业丂丏世:  val_3._clanWarTaskBox);
        if(val_4 != null)
        {
                .不三世丏丙丁与丑丒 = 丏不丄丑丝丁丘万不;
            .下丄丈不与世丐业专 = 丞丅上丏丂且下丅与;
        }
        else
        {
                mem[40] = 丏不丄丑丝丁丘万不;
            mem[48] = 丞丅上丏丂且下丅与;
        }
        
        .下丟丂丌丛丁上上丑 = 丐万丗丒下七丟丁三;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_4);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丅三东下不丅丅业丆(bool 不且东三三丐世下丝)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  23);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        .世业丒万不且丞丒丆 = 不且东三三丐世下丝;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.一一且万七丙丅丂丝(不丌丗丂丆业丂丏世:  val_3._clanWarStartEndBox));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 世丌丂丑丕丁丕一丗()
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  24);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.上丅丅丈丙丑且不丏(不丌丗丂丆业丂丏世:  val_3._clanWarRaidStartBox));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丂且专三丅丌东万专(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业)
    {
        var val_8;
        var val_9;
        System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_11;
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        val_11 = InfoWindowController.<>c.<>9__153_0;
        if(val_11 == null)
        {
                System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Func<不丌丅丗丁丟丅丐一, System.Boolean>(object:  InfoWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InfoWindowController.<>c::三丒专丟与丘与丂丑(InfoWindowController.不丌丅丗丁丟丅丐一 三丟东丕丄丄下下丑));
            InfoWindowController.<>c.<>9__153_0 = val_11;
        }
        
        if((System.Linq.Enumerable.Count<不丌丅丗丁丟丅丐一>(source:  InfoWindowController.东万下丅下东七一万, predicate:  val_2)) > 2)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  27);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        .万下世三丘丏丑上三 = 万不且且丛丆东丒业;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.万丛丝上且丒下且丙(不丌丗丂丆业丂丏世:  val_5.PixelPassTaskAchieveBox));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丕丆丌世丞丞丞一丐(string 丏不丄丑丝丁丘万不, UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        System.Collections.Generic.Queue<不丌丅丗丁丟丅丐一> val_8;
        var val_9;
        var val_10;
        System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_12;
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_8 = InfoWindowController.东万下丅下东七一万;
        val_10 = null;
        val_12 = InfoWindowController.<>c.<>9__154_0;
        if(val_12 == null)
        {
                System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_2 = null;
            val_12 = val_2;
            val_2 = new System.Func<不丌丅丗丁丟丅丐一, System.Boolean>(object:  InfoWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InfoWindowController.<>c::下丅下丁丅丁一丟丝(InfoWindowController.不丌丅丗丁丟丅丐一 三丟东丕丄丄下下丑));
            InfoWindowController.<>c.<>9__154_0 = val_12;
        }
        
        if((System.Linq.Enumerable.Count<不丌丅丗丁丟丅丐一>(source:  val_8, predicate:  val_2)) > 2)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  18);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.丐丐东丕丅且丘万且 val_6 = new InfoWindowController.丐丐东丕丅且丘万且(不丌丗丂丆业丂丏世:  val_5.ChallengeDoneBox);
        if(val_6 != null)
        {
                .不三世丏丙丁与丑丒 = 丏不丄丑丝丁丘万不;
        }
        else
        {
                mem[40] = 丏不丄丑丝丁丘万不;
        }
        
        .丌丟三丅上丅上丗丞 = 与万丆丛丒万丝丙丑;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_6);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丆丏丈七丗且丈且丟(string 丏不丄丑丝丁丘万不)
    {
        var val_8;
        var val_9;
        System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_11;
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        val_11 = InfoWindowController.<>c.<>9__155_0;
        if(val_11 == null)
        {
                System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_2 = null;
            val_11 = val_2;
            val_2 = new System.Func<不丌丅丗丁丟丅丐一, System.Boolean>(object:  InfoWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InfoWindowController.<>c::万丄丂丌丅且万世上(InfoWindowController.不丌丅丗丁丟丅丐一 三丟东丕丄丄下下丑));
            InfoWindowController.<>c.<>9__155_0 = val_11;
        }
        
        if((System.Linq.Enumerable.Count<不丌丅丗丁丟丅丐一>(source:  InfoWindowController.东万下丅下东七一万, predicate:  val_2)) > 2)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  18);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        .不三世丏丙丁与丑丒 = 丏不丄丑丝丁丘万不;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丐丐东丕丅且丘万且(不丌丗丂丆业丂丏世:  val_5.ChallengeAlternativeDoneBox));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    private static void 下三丅下丕丑专万丁(string 丏不丄丑丝丁丘万不, float 丂三丟丂丈丐丆丗丟, bool 一丏且丏东丌丈丄且, string 丛丒丟一万上丒丁七)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  19);
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        if(val_2.丐丆七且丞丏下三丙 != null)
        {
                InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.丐丆七且丞丏下三丙.Dispose();
        }
        
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        val_5.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  InfoWindowController.丑七不且上丗丁一世(), method:  public System.Void InfoWindowController::HideTimerBox()), 与且专丈不万东一万:  "Show Timer Box");
        InfoWindowController val_10 = InfoWindowController.丑七不且上丗丁一世();
        val_10.TimerBox.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  丏不丄丑丝丁丘万不);
        InfoWindowController val_11 = InfoWindowController.丑七不且上丗丁一世();
        val_11.TimerBox.与丕丞一丐七专丗下(丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丕丂丐丌丆丝且万丗:  丛丒丟一万上丒丁七);
        InfoWindowController val_12 = InfoWindowController.丑七不且上丗丁一世();
        val_12.TimerBox.丛丟丌丛上丟世上世(丙丝丒丘东一下丁丁:  一丏且丏东丌丈丄且);
        InfoWindowController val_14 = InfoWindowController.丑七不且上丗丁一世();
        val_14.TimerBox.gameObject.SetActive(value:  true);
    }
    internal static void 丟丂不丘丂下上与世(string 丏不丄丑丝丁丘万不)
    {
        InfoWindowController.下三丅下丕丑专万丁(丏不丄丑丝丁丘万不:  丏不丄丑丝丁丘万不, 丂三丟丂丈丐丆丗丟:  9000000f, 一丏且丏东丌丈丄且:  false, 丛丒丟一万上丒丁七:  0);
    }
    internal static void 丆丛丈不丏丗丗与七(string 丏不丄丑丝丁丘万不, float 丂三丟丂丈丐丆丗丟)
    {
        InfoWindowController.下三丅下丕丑专万丁(丏不丄丑丝丁丘万不:  丏不丄丑丝丁丘万不, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 一丏且丏东丌丈丄且:  true, 丛丒丟一万上丒丁七:  0);
    }
    internal static void 丆丛丈不丏丗丗与七(string 丏不丄丑丝丁丘万不, float 丂三丟丂丈丐丆丗丟, string 丛丒丟一万上丒丁七)
    {
        InfoWindowController.下三丅下丕丑专万丁(丏不丄丑丝丁丘万不:  丏不丄丑丝丁丘万不, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 一丏且丏东丌丈丄且:  true, 丛丒丟一万上丒丁七:  丛丒丟一万上丒丁七);
    }
    internal static void 丁丂丑下世丗丄上上(Rilisoft.WebSocket.下丈丈丆丙万丝丁业 丁丅丈丌丟世丗丗丟)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  20);
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        if(val_2.丐丆七且丞丏下三丙 != null)
        {
                InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_3.丐丆七且丞丏下三丙.Dispose();
        }
        
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        val_5.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  InfoWindowController.丑七不且上丗丁一世(), method:  public System.Void InfoWindowController::HideServerMessageBox()), 与且专丈不万东一万:  "Server Message Box");
        InfoWindowController val_10 = InfoWindowController.丑七不且上丗丁一世();
        val_10.ServerMessage.丅专下万丕丑丆丅丝(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟);
        InfoWindowController val_11 = InfoWindowController.丑七不且上丗丁一世();
        val_11.ServerMessage.gameObject.SetActive(value:  true);
    }
    internal static void 万丝一丒丌且丛丌七(string 丕丗丘丑丛与丑业丒)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  15);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        .不三世丏丙丁与丑丒 = 丕丗丘丑丛与丑业丒;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.七丏丘丗世丂丞丕丒(不丌丗丂丆业丂丏世:  val_3.textBox));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丑丝丛丑丒业三丝丌(string 丕丗丘丑丛与丑业丒, string 丛丐丌丙丈七丛丛东)
    {
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  16);
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.万世三丘丐世丟丂且 val_4 = new InfoWindowController.万世三丘丐世丟丂且(不丌丗丂丆业丂丏世:  val_3.iconTextBox);
        if(val_4 != null)
        {
                .不三世丏丙丁与丑丒 = 丕丗丘丑丛与丑业丒;
        }
        else
        {
                mem[40] = 丕丗丘丑丛与丑业丒;
        }
        
        .不丁丙丑丙丈丒丗上 = 丛丐丌丙丈七丛丛东;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  val_4);
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 丕丈与丒且丞丏业丗(bool 且下丘丟丏丄丈丟万 = True, float 丟丟丗专丅丝与三丝 = 1)
    {
        if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        val_3.丗专丌七三丑万上丄 = 丟丟丗专丅丝与三丝;
        InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
        val_4._noInternetConnection.SetActive(value:  true);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        val_5._noInternetConnectionTouchBlocker.SetActive(value:  且下丘丟丏丄丈丟万);
        InfoWindowController.丑七不且上丗丁一世().StopCoroutine(routine:  InfoWindowController.丑七不且上丗丁一世().丆丅业丆七七丕丟专());
        UnityEngine.Coroutine val_13 = InfoWindowController.丑七不且上丗丁一世().StartCoroutine(routine:  InfoWindowController.丑七不且上丗丁一世().丆丅业丆七七丕丟专());
    }
    private System.Collections.IEnumerator 丆丅业丆七七丕丟专()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new InfoWindowController.万下丝丟丙专丐丅万(丗丏丅丕丆世丁专丟:  0);
    }
    internal static void 丈丅丁丕丙与丗专一(bool 且下丘丟丏丄丈丟万 = True, float 丟丟丗专丅丝与三丝 = 1)
    {
        if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        val_3.丄上与丈一丐不丘丌 = 丟丟丗专丅丝与三丝;
        InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
        val_4._noStoreLogin.SetActive(value:  true);
        InfoWindowController val_5 = InfoWindowController.丑七不且上丗丁一世();
        val_5._noStoreLoginTouchBlocker.SetActive(value:  且下丘丟丏丄丈丟万);
        InfoWindowController.丑七不且上丗丁一世().StopCoroutine(routine:  InfoWindowController.丑七不且上丗丁一世().丘丕丆万业三上丂下());
        UnityEngine.Coroutine val_13 = InfoWindowController.丑七不且上丗丁一世().StartCoroutine(routine:  InfoWindowController.丑七不且上丗丁一世().丘丕丆万业三上丂下());
    }
    internal static void 丆丏丁丂丌丛不丄丐()
    {
    
    }
    private System.Collections.IEnumerator 丘丕丆万业三上丂下()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new InfoWindowController.三万丑丌丑专上东丂(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 丏丞丌上丏丁丛一一(string 三丕业丛丛丙专专丙)
    {
        var val_5;
        if(this._battleInviteBox == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        this.上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  9);
        val_5 = null;
        val_5 = null;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丌丆丐丛丛丞丏丁丗(不丌丗丂丆业丂丏世:  this._battleInviteBox, 三丕业丛丛丙专专丙:  三丕业丛丛丙专专丙));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal void 与不专丁丐且丈丄丂(string 三丕业丛丛丙专专丙, string 丐一三丞丝丌不丏丑, int 丄东七丄一丄万丕丟)
    {
        var val_5;
        if(this._squadInviteBox == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        this.上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  10);
        val_5 = null;
        val_5 = null;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丆丂专专丐万丅专三(不丌丗丂丆业丂丏世:  this._squadInviteBox, 三丕业丛丛丙专专丙:  三丕业丛丛丙专专丙, 丐一三丞丝丌不丏丑:  丐一三丞丝丌不丏丑, 丄东七丄一丄万丕丟:  丄东七丄一丄万丕丟));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal void 丑丆丗专丛丆东丂丛(string 三丕业丛丛丙专专丙)
    {
        var val_5;
        if(this._clanSiegeInviteBox == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        this.上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  13);
        val_5 = null;
        val_5 = null;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丌上丆业丑丘丟丑不(不丌丗丂丆业丂丏世:  this._clanSiegeInviteBox, 三丕业丛丛丙专专丙:  三丕业丛丛丙专专丙));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal void 丌丌专世下丙上且丏(string 三丕业丛丛丙专专丙, string 丅一丞万丑专丅丅与)
    {
        var val_5;
        if(this._clanWarInviteBox == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        this.上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  21);
        val_5 = null;
        val_5 = null;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丝丌下丝丗与一丆丏(不丌丗丂丆业丂丏世:  this._clanWarInviteBox, 三丕业丛丛丙专专丙:  三丕业丛丛丙专专丙, 丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal void 专万丗七世丄与上丄(string 三丕业丛丛丙专专丙, string 丅一丞万丑专丅丅与)
    {
        var val_5;
        if(this._clanWarTestInviteBox == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        this.上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  25);
        val_5 = null;
        val_5 = null;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.万丞丟东世业业且业(不丌丗丂丆业丂丏世:  this._clanWarTestInviteBox, 三丕业丛丛丙专专丙:  三丕业丛丛丙专专丙, 丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal void 下丝丁丂丞下丘东丗()
    {
        var val_7;
        var val_8;
        System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_10;
        var val_11;
        if(this._clanSiegeInviteBox == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = null;
        val_8 = null;
        val_10 = InfoWindowController.<>c.<>9__173_0;
        if(val_10 == null)
        {
                System.Func<不丌丅丗丁丟丅丐一, System.Boolean> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<不丌丅丗丁丟丅丐一, System.Boolean>(object:  InfoWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean InfoWindowController.<>c::丑且丁且丟上丛专丏(InfoWindowController.不丌丅丗丁丟丅丐一 三丟东丕丄丄下下丑));
            InfoWindowController.<>c.<>9__173_0 = val_10;
        }
        
        if((System.Linq.Enumerable.Any<不丌丅丗丁丟丅丐一>(source:  InfoWindowController.东万下丅下东七一万, predicate:  val_2)) == true)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丄下丟下丁下且丏() == false)
        {
                return;
        }
        
        this.上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  13);
        val_11 = null;
        val_11 = null;
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丏不万丌与丂七丙丏(不丌丗丂丆业丂丏世:  this._clanSiegeInviteBox));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    internal static void 一丘丕上丈一丂丐丌()
    {
        InfoWindowController.丑七不且上丗丁一世().丆世与丑丆丅丐万且();
    }
    internal static void 丏三万丏世丛业丒丒(float 丂三丟丂丈丐丆丗丟)
    {
        InfoWindowController.丑七不且上丗丁一世().Invoke(methodName:  "HideInfoAndProcessingBox", time:  丂三丟丂丈丐丆丗丟);
    }
    internal static void 丏三万丏世丛业丒丒()
    {
        InfoWindowController.丑七不且上丗丁一世().HideInfoAndProcessingBox();
    }
    public void OnClickExitButton()
    {
        if(this.丆世丟三万丘业丝一 == 3)
        {
                return;
        }
        
        this.丆世与丑丆丅丐万且();
    }
    public void OnClickVipBox()
    {
        MainMenuController val_3;
        var val_4;
        var val_5;
        if(Rilisoft.VIPController.丌丏丄专丘丕丑上且() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        MainMenuController.丄丞丁丈与业上丞丟.东丏且丑上丑专上不(世且不丏丒丞丙东丐:  "VipOffer");
    }
    internal static void 丟不丗丛丘一丕丄丁(bool 东丏丂丙丑丁丞丞万, bool 丑丒丁丏丝丞丘丁丟)
    {
        string val_2;
        if(东丏丂丙丑丁丞丞万 != false)
        {
                if(丑丒丁丏丝丞丘丁丟 == false)
        {
                return;
        }
        
            val_2 = "Key_1563";
        }
        else
        {
                val_2 = "Key_1528";
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_2));
    }
    internal static void 一业丏万上三上丑不(int 丗七丟丈三不丕一三, string 丐一业丏上七丆下丌)
    {
        InfoWindowController.丑七不且上丗丁一世().上丛丌丆丑上七世三(丙且丄丑丂万丅丘丗:  14);
        InfoWindowController val_2 = InfoWindowController.丑七不且上丗丁一世();
        InfoWindowController.东万下丅下东七一万.Enqueue(item:  new InfoWindowController.丞丏丙丐与东业且不(不丌丗丂丆业丂丏世:  val_2._offerwallRewardBox, 丗七丟丈三不丕一三:  丗七丟丈三不丕一三, 丐一业丏上七丆下丌:  丐一业丏上七丆下丌));
        InfoWindowController.丑七不且上丗丁一世().丁上东丟丅丅一丆三();
    }
    public InfoWindowController()
    {
        this._listReviewWindows = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }
    private static InfoWindowController()
    {
        InfoWindowController.东万下丅下东七一万 = new System.Collections.Generic.Queue<不丌丅丗丁丟丅丐一>();
    }

}
