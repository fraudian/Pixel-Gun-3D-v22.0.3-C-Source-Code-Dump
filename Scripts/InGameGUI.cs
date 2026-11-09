using UnityEngine;
public sealed class InGameGUI : MonoBehaviour
{
    // Fields
    public UIPanel rootMainPanel;
    public AimCrosshairController aimCrosshair;
    public LastBulletsUI lastBulletsUi;
    public GadgetsSFX gadgetsSFX;
    public WeaponTogglesController weaponToggles;
    public WeaponTogglesForCharacterController weaponTogglesForCharacter;
    public UnityEngine.Transform midLeftAnchor;
    public UnityEngine.Transform midRightAnchor;
    public UnityEngine.Transform midCenterAnchor;
    public UnityEngine.GameObject scoreClickHandlerObject;
    public UILabel enemiesLeftLabel;
    public UILabel perfectLabels;
    public UILabel Wave1_And_Counter;
    public UILabel reloadLabel;
    public UnityEngine.GameObject markingEnemyLabel;
    public UnityEngine.GameObject reloadBar;
    public UnityEngine.GameObject getBonusBar;
    public UITexture reloadCircularSprite;
    public UITexture getBonusCircular;
    private UITexture[] 业一丞上与丑丘丘业;
    public UnityEngine.GameObject centerAnhor;
    public UILabel newWave;
    public UILabel waveDone;
    public UILabel waveDoneOffline;
    public UIPanel killWhitePanel;
    public TrainingHints trainingHints;
    public UnityEngine.GameObject chargeShootHint;
    public FadingPanel fadingPanel;
    public UnityEngine.GameObject battleEmojiButton;
    public UnityEngine.GameObject[] hidesPanelInTurrel;
    public UnityEngine.GameObject turretPanel;
    public Rilisoft.ButtonHandler runTurrelButton;
    public Rilisoft.ButtonHandler cancelTurrelButton;
    public UnityEngine.GameObject petIndicatorObject;
    public float minLength;
    public float maxLength;
    public float defaultPanelLength;
    internal static InGameGUI 丙丞专丌丁丞与不丐;
    public UnityEngine.GameObject pausePanel;
    public UnityEngine.GameObject blockedCollider;
    public UnityEngine.GameObject blockedCollider2;
    public UnityEngine.GameObject blockedColliderDater;
    public UnityEngine.GameObject bottomPanel;
    public UnityEngine.GameObject aimPanel;
    public float timerShowNow;
    public UnityEngine.GameObject interfacePanel;
    public UnityEngine.GameObject interfaceContainer;
    public UILabel timerStartHungerLabel;
    public UnityEngine.GameObject leftAnchor;
    public UnityEngine.GameObject rightAnchor;
    public InGameGUI.丝与丑业世丘丘丑丂 health;
    public InGameGUI.丝与丑业世丘丘丑丂 armor;
    public InGameGUI.丝与丑业世丘丘丑丂 maxHealth;
    public InGameGUI.丝与丑业世丘丘丑丂 maxArmor;
    public ProgressBarHealth healthBar;
    public ProgressBarHealth armorBar;
    public InGameGUI.丞丁不丆丗丑专丄世 armorType;
    public InGameGUI.丒丙丝丆丄丆丄且专 killsToMaxKills;
    public InGameGUI.丒丙丝丆丄丆丄且专 timeLeft;
    public UISprite fonSmall;
    public UISprite fonSmallDater;
    public DamageTakenController[] damageTakenControllers;
    private int 不丙丟丏丈丗上丂丛;
    public SetChatLabelController[] killLabels;
    public UnityEngine.GameObject[] chatLabels;
    public UILabel[] messageAddScore;
    public UnityEngine.GameObject scopeText;
    public BadNetworkBlinkingController badConnectionIcon;
    internal Player_move_c playerMoveC;
    private ZombieCreator 专业丙上丕丌丙丕三;
    public UIPanel multyKillPanel;
    public MultyKill multyKill;
    private bool 丁丑丅丏丒不七上丁;
    private bool 丝丙七丒且丂丝与丏;
    public UnityEngine.GameObject weaponPreviewPrefab;
    public int weaponIndexInScroll;
    public int weaponIndexInScrollOld;
    public int widthWeaponScrollPreview;
    public UnityEngine.AudioClip lowResourceBeep;
    public UnityEngine.AudioClip siegeSirenClip;
    public UIPanel joystikPanel;
    public UIPanel bloodPanel;
    private UILabel 业丞丄丆丛下丛下丂;
    private UILabel slowdown;
    private string 丛丅丅丅丆丆世上丌;
    internal RespawnWindowController respawnWindowController;
    public UIPanel offGameGuiPanel;
    public UIButton pauseButton;
    public Rilisoft.BankShopViewGuiElement shopView;
    public UnityEngine.Transform notificationsRoot;
    public UnityEngine.Transform inGameNotificationsRoot;
    public UnityEngine.Transform scoreContainerRoot;
    internal InGameGUIPart_ClassicArena 丄丈万丛专丏丁且丁;
    internal InGameGUIPart_DeathEscape 丛东丛七三七丕丕七;
    internal InGameGUIPart_BattleRoyale 丘丏丛丂丅丂世上丒;
    internal InGameGUIPart_TeamDuel 丂三丐一丂丄丄三丛;
    internal InGameGUIPart_Dungeons 丙丏专与一三万丌下;
    internal InGameGUIPart_Siege 丅丟与丟东丛东丛一;
    internal InGameGUIPart_Racing 七丙丘丂与丐丌与专;
    internal InGameGUIPart_Arena 丟丞丆一丐三丝七不;
    internal InGameGUIPart_HoldPositions 丄丑上且下丟世丏丐;
    internal InGameGUIPart_CapturePoints 丏丁丕东且丐丟专三;
    internal InGameGUIPart_Duel 丆不专一丄丐业上且;
    internal InGameGUIPart_DeadlyGames 专丌且一丒且七世丒;
    internal InGameGUIPart_FlagCapture 专专丛丟丆丂且丄丒;
    internal InGameGUIPart_Speedrun 不不丙世丟一丛丆丗;
    internal InGameGUIPart_FortDefence 专丝丘丆丛丅万丞三;
    internal InGameGUIPart_FortAttack 丕下丌七万丝丅三丘;
    internal InGameGUIPart_Imposter 丙下丆与丁丘丙丕丙;
    internal InGameGUIPart_MonsterHunter 丁丁丕丂丐丐丒万丂;
    internal InGameGUIPart_Freeplay 丈三丁丆丅且丂与丂;
    internal InGameGUIPart_ArmRace 丝三专丏与丗丌业上;
    internal InGameGUIPart_PlantTheBomb 丕丏丕丟丗丝丂业丏;
    internal InGameGUIPart_Mutation 丆丄丁丒且一万与丑;
    internal InGameGUIPart_RedLight 丁丝丆万丈世丄丒丅;
    internal MiniMapController 专丐万丆丑三上丘七;
    internal CompasController 丙丁不东不丅三丛世;
    internal GameStageEventController 丒不上三且与丐丞与;
    internal BattleRoyaleSquadUI 丌不专丝丂丛丛丕丂;
    public UnityEngine.GameObject trainingOverlaysNew;
    public UnityEngine.GameObject jumpButton;
    public UnityEngine.GameObject rightFireButton;
    public HealthBloodIndicator healthBloodIndicator;
    public IconLabelsStorage iconLabelsStorage;
    private System.Collections.IEnumerator 丛丞丟丐丐万与丗丏;
    internal UnityEngine.GameObject[] hidingElems;
    internal System.Collections.Generic.List<UnityEngine.GameObject> leftTopAnchorElems;
    internal System.Collections.Generic.List<UnityEngine.GameObject> 一丝万丂丏丏且万丌;
    private UnityEngine.Coroutine 一与丛丑下不丘七丘;
    private float 世丕丏丁上业东下与;
    internal float 丂丕丒丑不三丑丁丒;
    public UILabel blinkNoAmmoLabel;
    private UnityEngine.GameObject graffitiContainer;
    private float 丕上丑丞不丒丘万三;
    private UILabel graffitiCantBeLabel;
    internal UnityEngine.Rect 丒丅下丌丞丁丕丝丙;
    private float 丒丐丌丁丁七丝丆丗;
    private int 丛且丝七丄丛丅丈且;
    public UILabel blinkGateAttack;
    private float 丝世万丒丞丆丁上一;
    private UILabel wrongModuleLabel;
    internal float 七下丏丛丞丏下且专;
    internal float 上丁业丑万丆丘丄专;
    private float 丐丝东丑丏丏丝三七;
    private float 丙丏丟丒且上一且丞;
    public float timerShowScorePict;
    public float maxTimerShowScorePict;
    public string scorePictName;
    public string scoreIconName;
    public string scoreMessage;
    public UISprite ChargeValue;
    public UnityEngine.GameObject reviveBar;
    public UISprite reviveBarValue;
    private UnityEngine.GameObject _subpanelsContainer;
    private UnityEngine.Camera 业丂下三丂一业丛东;
    internal UnityEngine.Camera InGameGuiCamera;
    private int 丂丞丞业丗丟且丝三;
    private static System.Action 丏丑下丑且三业丄丄;
    private bool 丙丐一世世丙世丞丝;
    public bool isTurretInterfaceActive;
    public float speedAnimateHealth;
    private bool 丕丏专丂一东丆万丏;
    private bool <且业丂丁丘丝专丘丈>k__BackingField;
    private System.Collections.Generic.Dictionary<UIPanel, float> 丛三与丟丗丗东丘七;
    private System.Collections.Generic.Dictionary<UIPanel, float> 丁下世丏丂丅下三下;
    private bool 丏丘万丑丕丁不丈丞;
    
    // Properties
    internal static bool 不丟专丏业与丕七丑 { get; }
    private string 丘丞丒丒丌一丅世世 { get; }
    public UnityEngine.GameObject 东上丅不丛丑丆丑丈 { get; }
    internal UnityEngine.Camera 丈三上东丘世与丒丒 { get; }
    internal bool 七丆丂专丁丈丒东丐 { get; set; }
    internal bool 丁丟丏丁业世且世世 { get; }
    public bool 东东东丟万丞丕丑一 { get; set; }
    public bool 丅世丞丂一与一丛不 { get; }
    
    // Methods
    internal static bool 丕业丁丑丟不丏丗且()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return false;
        }
        
        if(null != 0)
        {
                return activeSelf;
        }
        
        return activeSelf;
    }
    internal void 丙不三丗东三下丐上(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.slowdown, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    private string 万丈丝丝丆丙丘丆丈()
    {
        string val_4;
        if((System.String.IsNullOrEmpty(value:  this.丛丅丅丅丆丆世上丌)) != false)
        {
                UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            this.丛丅丅丅丆丆世上丌 = val_2.m_Handle.name;
            return val_4;
        }
        
        val_4 = this.丛丅丅丅丆丆世上丌;
        return val_4;
    }
    public void ShowCircularIndicatorOnReload(float 丏上万丅丏一不不丕)
    {
        this.StopAllCircularIndicators();
        if((this.playerMoveC != 0) && (this.playerMoveC.万丝一万丐且丌业丛 != false))
        {
                return;
        }
        
        this.reloadBar.SetActive(value:  true);
        this.reloadLabel.gameObject.SetActive(value:  true);
        this.Invoke(methodName:  "ReloadAmmo", time:  丏上万丅丏一不不丕);
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.丆丂丕专丒丌三一七 = true;
        }
        
        this.上丘丅专三丒下丗丙(与丄丈丘丟丕丏丐丁:  this.reloadCircularSprite, 丏上万丅丏一不不丕:  丏上万丅丏一不不丕, 丟丘丙丄丅万丏与丗:  0);
    }
    private void ReloadAmmo()
    {
        var val_3;
        this.reloadLabel.gameObject.SetActive(value:  false);
        this.reloadBar.SetActive(value:  false);
        val_3 = null;
        val_3 = null;
        WeaponManager.丟丗丄业丘丗业丗七.ReloadAmmo();
        if(this.一与丛丑下不丘七丘 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.一与丛丑下不丘七丘);
        this.一与丛丑下不丘七丘 = 0;
    }
    public void StartFireCircularIndicators(float 丏上万丅丏一不不丕)
    {
        this.StopAllCircularIndicators();
    }
    private void 上丘丅专三丒下丗丙(UITexture 与丄丈丘丟丕丏丐丁, float 丏上万丅丏一不不丕, System.Action 丟丘丙丄丅万丏与丗)
    {
        if(this.一与丛丑下不丘七丘 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.一与丛丑下不丘七丘);
            this.一与丛丑下不丘七丘 = 0;
        }
        
        this.一与丛丑下不丘七丘 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丑丝丝丛丅丛业丘三(与丄丈丘丟丕丏丐丁:  与丄丈丘丟丕丏丐丁, 丏上万丅丏一不不丕:  丏上万丅丏一不不丕, 丟丘丙丄丅万丏与丗:  丟丘丙丄丅万丏与丗));
    }
    private System.Collections.IEnumerator 丑丝丝丛丅丛业丘三(UITexture 与丄丈丘丟丕丏丐丁, float 丏上万丅丏一不不丕, System.Action 丟丘丙丄丅万丏与丗)
    {
        InGameGUI.丈三下丅丘丁丏与丕 val_1 = new InGameGUI.丈三下丅丘丁丏与丕();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .与丄丈丘丟丕丏丐丁 = 与丄丈丘丟丕丏丐丁;
            .丏上万丅丏一不不丕 = 丏上万丅丏一不不丕;
        }
        else
        {
                mem[48] = this;
            mem[32] = 与丄丈丘丟丕丏丐丁;
            mem[40] = 丏上万丅丏一不不丕;
        }
        
        .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
        return (System.Collections.IEnumerator)val_1;
    }
    public void StopAllCircularIndicators()
    {
        this.CancelInvoke(methodName:  "ReloadAmmo");
        if(this.一与丛丑下不丘七丘 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.一与丛丑下不丘七丘);
            this.一与丛丑下不丘七丘 = 0;
        }
        
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.丆丂丕专丒丌三一七 = false;
        }
        
        if(this.业一丞上与丑丘丘业 != null)
        {
                if(this.业一丞上与丑丘丘业.Length >= 1)
        {
                do
        {
            UITexture val_6 = this.业一丞上与丑丘丘业[0];
            int val_3 = Holoville.HOTween.HOTween.Kill(p_target:  val_6);
            val_6.fillAmount = 0f;
        }
        while((0 + 1) < this.业一丞上与丑丘丘业.Length);
        
        }
        
            this.reloadLabel.gameObject.SetActive(value:  false);
            this.reloadBar.SetActive(value:  false);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Circular sprites is null!");
    }
    public void PlayLowResourceBeep(int 丌丒丝东丌下丕丁丅)
    {
        if(this.丛丞丟丐丐万与丗丏 != null)
        {
                this.StopCoroutine(routine:  this.丛丞丟丐丐万与丗丏);
            this.丛丞丟丐丐万与丗丏 = 0;
        }
        
        System.Collections.IEnumerator val_1 = this.丌下丐不丘与丏丞丒(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        this.丛丞丟丐丐万与丗丏 = val_1;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  val_1);
    }
    public void SetEnablePerfectLabel(bool 丝三丄专丗丞丄丄丌)
    {
        if(this.perfectLabels == 0)
        {
                return;
        }
        
        this.perfectLabels.gameObject.SetActive(value:  丝三丄专丗丞丄丄丌);
    }
    public void PlayLowResourceBeepIfNotPlaying(int 丌丒丝东丌下丕丁丅)
    {
        if(this.丛丞丟丐丐万与丗丏 != null)
        {
                return;
        }
        
        this.PlayLowResourceBeep(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
    }
    public void StopPlayingLowResourceBeep()
    {
        if(this.丛丞丟丐丐万与丗丏 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丛丞丟丐丐万与丗丏);
        this.丛丞丟丐丐万与丗丏 = 0;
    }
    private System.Collections.IEnumerator 丌下丐不丘与丏丞丒(int 丌丒丝东丌下丕丁丅)
    {
        InGameGUI.东丒丌丁丙世且丝万 val_1 = new InGameGUI.东丒丌丁丙世且丝万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丌丒丝东丌下丕丁丅 = 丌丒丝东丌下丕丁丅;
        return (System.Collections.IEnumerator)val_1;
    }
    public UnityEngine.GameObject get_SubpanelsContainer()
    {
        return (UnityEngine.GameObject)this._subpanelsContainer;
    }
    internal UnityEngine.Camera 丝丙与东丈不丙三丟()
    {
        UnityEngine.Camera val_3;
        if(this.业丂下三丂一业丛东 == 0)
        {
                this.业丂下三丂一业丛东 = this.GetComponentInChildren<UnityEngine.Camera>();
            return val_3;
        }
        
        val_3 = this.业丂下三丂一业丛东;
        return val_3;
    }
    private void Awake()
    {
        var val_29;
        string val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        string val_35;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                this.healthBar.SetTypeBar(丂丟三丕丙丌丝丈丒:  0);
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                this.healthBar.SetTypeBar(丂丟三丕丙丌丝丈丒:  7);
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getBonusBar, 丏业丟一东丂东丘丛:  false);
        string val_6 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}.Awake()", arg0:  this.GetType());
        InGameGUI.丙丞专丌丁丞与不丐 = this;
        this.丟业丅三世万世丞不(东丞下七东下丅丙与:  丘丐丘万丌丟丞下丝.业业与丈丈丝丞丟丑());
        UITexture[] val_8 = new UITexture[1];
        val_8[0] = this.reloadCircularSprite;
        this.业一丞上与丑丘丘业 = val_8;
        new System.Action() = new System.Action(object:  this, method:  System.Void InGameGUI::丘丌三与下丈一与万());
        ControlsSettingsBase.一丆下丆丘丑丌丅丌(丙业与丙丗丝不丈东:  new System.Action());
        val_29 = null;
        val_29 = null;
        this.丁丑丅丏丒不七上丁 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        val_30 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丞丌且不丄专专且丈();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.graffitiContainer, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_30))) & 1);
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                this.centerAnhor.SetActive(value:  false);
        }
        
        val_31 = null;
        val_31 = null;
        this.丝丙七丒且丂丝与丏 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        UnityEngine.GameObject val_18 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕(丑与丞三且丛与丟业:  "WorldPosIndications/WorldPosIndications", 七万上丐一丈丏丏专:  this.丝丙与东丈不丙三丟().gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        string val_20 = GameConnect.丑丌丛丈丅丅与不业().ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_32 = null;
            val_32 = null;
            if((InGameGUIPartContainer.Load(丏丗丞且丙丑丐东专:  val_20 + "_" + 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) == true)
        {
                return;
        }
        
        }
        
        if(GameConnect.业丗与丈丁东下一丛() == false)
        {
            goto label_50;
        }
        
        val_33 = null;
        val_33 = null;
        if(GameController.mode != null)
        {
                val_30 = 1152921505196568576;
            var val_25 = (null == null) ? GameController.mode : 0;
        }
        else
        {
                val_34 = 0;
        }
        
        if(val_34.万东七丁世万丟专且() == false)
        {
            goto label_50;
        }
        
        string val_27 = val_20 + "_Warm";
        goto label_51;
        label_50:
        val_35 = val_20;
        label_51:
        bool val_28 = InGameGUIPartContainer.Load(丏丗丞且丙丑丐东专:  val_35);
    }
    public void AddDamageTaken(float 与专丌丅丙上丌一丄)
    {
        int val_2;
        int val_1 = this.不丙丟丏丈丗上丂丛 + 1;
        this.不丙丟丏丈丗上丂丛 = val_1;
        if(val_1 < this.damageTakenControllers.Length)
        {
                val_2 = this.不丙丟丏丈丗上丂丛;
        }
        else
        {
                val_2 = 0;
            this.不丙丟丏丈丗上丂丛 = 0;
        }
        
        this.damageTakenControllers[0].Reset(与专丌丅丙上丌一丄:  与专丌丅丙上丌一丄);
    }
    public void ResetDamageTaken()
    {
        goto label_0;
        label_5:
        this.damageTakenControllers[0].Remove();
        0 = 1;
        label_0:
        if(0 < this.damageTakenControllers.Length)
        {
            goto label_5;
        }
    
    }
    private void 丘丌三与下丈一与万()
    {
        var val_13;
        WeaponTogglesForCharacterController val_14;
        float val_15;
        val_13 = null;
        val_13 = null;
        JoystickController.世万丁丆业业丘丘丌.UpdateButtonsPosition();
        JoystickController.丘万丏三丏丑世丐丏.UpdateButtonsPosition();
        UISprite val_1 = this.bottomPanel.GetComponent<UISprite>();
        下丂世丂不丛专一一 val_3 = 下丂世丂不丛专一一.丏丛丌世专丒丆不世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业());
        if(val_1 == 0)
        {
            goto label_12;
        }
        
        if(this.丂丞丞业丗丟且丝三 == 0)
        {
            goto label_13;
        }
        
        label_33:
        mem2[0] = 1;
        val_1.width = val_3;
        label_12:
        val_14 = this.weaponTogglesForCharacter;
        if((val_14 != 0) && (this.丂丞丞业丗丟且丝三 != 0))
        {
                float val_7 = (float)val_3 / (float)this.丂丞丞业丗丟且丝三;
            val_14 = this.weaponTogglesForCharacter.transform;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7, y:  val_7);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            val_15 = val_9.x;
            val_14.localScale = new UnityEngine.Vector3() {x = val_15, y = val_9.y, z = val_9.z};
        }
        
        if((this.weaponToggles.GetComponent<UIPanel>()) == 0)
        {
                return;
        }
        
        val_15 = val_15;
        return;
        label_13:
        this.丂丞丞业丗丟且丝三 = val_1.width;
        if(val_1 != null)
        {
            goto label_33;
        }
        
        goto label_33;
    }
    private void Start()
    {
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        System.EventHandler val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.丁丁丗丐东丄丞一丛() != true)) && (GameConnect.且丘丄丛下丆丟万丕() != true))
        {
                if(GameConnect.万七丄丛丈丟专一丑() != true)
        {
                if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
            goto label_15;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.shopView, 丏业丟一东丂东丘丛:  false);
        label_162:
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                this.shopView.ShowPixelBucks = true;
        }
        
        val_46 = null;
        val_46 = null;
        val_47 = 1152921504848912384;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_68;
        }
        
        val_48 = null;
        val_48 = null;
        if((((((((((((((东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true) || (GameConnect.业丛丛丂一丆丕丗丟() == true)) || (GameConnect.丆丕丒与丂七与下上() == true)) || (GameConnect.丛专丌且丕不专丈下() == true)) || (GameConnect.一与东丝万上三丆丏() == true)) || (GameConnect.万不丒丌丙万丗东不() == true)) || (丅丌丝丘丐不丒丄专.丁丘丈丄丅丟下不丈() == true)) || (GameConnect.丁丁丗丐东丄丞一丛() == true)) || (GameConnect.且丘丄丛下丆丟万丕() == true)) || (GameConnect.万七丄丛丈丟专一丑() == true)) || (GameConnect.丙丌丒丈东七丒上丌() == true)) || (GameConnect.与不丗丏万丙丞丌丑() == true)) || (GameConnect.一业上七丟业且业丙() == true)) || (PolygonController.一下一万丄丅丘且丑 != 0))
        {
            goto label_68;
        }
        
        val_49 = null;
        val_49 = null;
        if((GameController.丆丘丂丈世丏丟丑丏 == null) || (GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == false))
        {
            goto label_72;
        }
        
        label_68:
        label_179:
        this.shopView.HideButtons = 0 ^ 1;
        this.shopView.丝一丅丆三东丂丞七();
        this.weaponToggles.丒七丌七丘东业丟丅();
        this.weaponTogglesForCharacter.丒七丌七丘东业丟丅();
        Holoville.HOTween.HOTween.Init(p_permanentInstance:  true, p_renameInstanceToCountTweens:  true, p_allowOverwriteManager:  true);
        Holoville.HOTween.HOTween.EnableOverwriteManager(logWarnings:  true);
        val_50 = 1152921505171275776;
        val_51 = null;
        val_51 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 8)
        {
                this.scoreClickHandlerObject.SetActive(value:  false);
        }
        
        }
        
        val_52 = null;
        val_52 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 21)
        {
                val_53 = null;
            val_53 = null;
            MinigameScoreTable.丄丘七三上丕世丞业.七丏丆与丞丏丟七丁(丛与丙丒丒下丌丟且:  true);
            MinigameScoreTable.丄丘七三上丕世丞业.专且世丘且丗万丄丁(专下丞下七丏丁丐一:  true);
        }
        
        }
        
        val_54 = null;
        val_54 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 23)
        {
                val_50 = 1152921505318506496;
            val_55 = null;
            val_55 = null;
            MinigameScoreTable.丄丘七三上丕世丞业.七丏丆与丞丏丟七丁(丛与丙丒丒下丌丟且:  true);
            MinigameScoreTable.丄丘七三上丕世丞业.三丂且丂丌丌丒丞丐();
            MinigameScoreTable.丄丘七三上丕世丞业.下丞丈丒丁丄世世与(专下丞下七丏丁丐一:  true);
        }
        
        }
        
        this.turretPanel.SetActive(value:  false);
        if(this.runTurrelButton != 0)
        {
                System.EventHandler val_26 = null;
            val_50 = val_26;
            val_26 = new System.EventHandler(object:  this, method:  System.Void InGameGUI::丈东万丁丏一丁丟丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.runTurrelButton.add_Clicked(丙业与丙丗丝不丈东:  val_26);
        }
        
        if(this.cancelTurrelButton != 0)
        {
                System.EventHandler val_28 = null;
            val_50 = val_28;
            val_28 = new System.EventHandler(object:  this, method:  System.Void InGameGUI::丛丗专丒丄丗三丕一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.cancelTurrelButton.add_Clicked(丙业与丙丗丝不丈东:  val_28);
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enemiesLeftLabel, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                val_56 = null;
            val_56 = null;
            this.专业丙上丕丌丙丕三 = ZombieCreator.丞丈丟丒丂丞丏不丑;
        }
        
        this.丘丌三与下丈一与万();
        PauseNGUIController.丒一世七业丙东丒丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void InGameGUI::丘丌三与下丈一与万()));
        if(GameConnect.丆丕丒与丂七与下上() != false)
        {
                val_50 = 1152921505047793664;
            if(CheckpointController.丄丘七三上丕世丞业 != 0)
        {
                if(CheckpointController.丄丘七三上丕世丞业.finishedLap != false)
        {
                CheckpointController.丄丘七三上丕世丞业.ShowLapFinishedInterface();
        }
        
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                val_57 = null;
            val_57 = null;
            SiegeController.三三万丆下一丗万丛.ShowSiegeStartEvent();
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
            goto label_141;
        }
        
        val_50 = 0;
        goto label_142;
        label_151:
        val_47 = 0;
        UnityEngine.Transform val_35 = this.killLabels[val_47].transform;
        UnityEngine.Vector3 val_36 = val_35.localPosition;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  280f);
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
        val_35.localPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
        val_50 = 1;
        label_142:
        if(val_50 < this.killLabels.Length)
        {
            goto label_151;
        }
        
        label_141:
        this.东丞且三丐丒专丄且();
        if(InGameGUI.丏丑下丑且三业丄丄 == null)
        {
                return;
        }
        
        InGameGUI.丏丑下丑且三业丄丄.Invoke();
        return;
        label_15:
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_162;
        }
        
        }
        
        Rilisoft.BankShopView val_42 = this.shopView.丄世下丟三与丛世丅();
        val_42.goldContainer.SetActive(value:  false);
        goto label_162;
        label_72:
        val_58 = null;
        val_58 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_179;
        }
        
        val_59 = null;
        val_59 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_179;
        }
        
        val_60 = null;
        val_60 = null;
        if(null != 0)
        {
            goto label_179;
        }
        
        goto label_179;
    }
    public static void add_OnCreateInGameGUI(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  InGameGUI.丏丑下丑且三业丄丄, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(InGameGUI.丏丑下丑且三业丄丄 != 1152921505219149832);
    
    }
    public static void remove_OnCreateInGameGUI(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  InGameGUI.丏丑下丑且三业丄丄, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(InGameGUI.丏丑下丑且三业丄丄 != 1152921505219149832);
    
    }
    public void ShowTurretInterface(string 丕专万丗一丛三丙丝)
    {
        if(this.turretPanel.activeSelf == true)
        {
                return;
        }
        
        this.isTurretInterfaceActive = true;
        this.weaponToggles.丒七丌七丘东业丟丅();
        this.weaponTogglesForCharacter.丒七丌七丘东业丟丅();
        UIButton val_2 = this.runTurrelButton.GetComponent<UIButton>();
        this.turretPanel.SetActive(value:  true);
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.万世与世丁丗不丕丕 = 丕专万丗一丛三丙丝;
        }
        
        this.playerMoveC.专丐丏丒丘丟丁与丟(丞世不丒下上上丝丑:  233, 丟业下东与东专专业:  false);
        this.丙丐一世世丙世丞丝 = true;
    }
    public void HideTurretInterface()
    {
        this.isTurretInterfaceActive = false;
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  0);
        this.weaponToggles.丒七丌七丘东业丟丅();
        this.weaponTogglesForCharacter.丒七丌七丘东业丟丅();
        this.turretPanel.SetActive(value:  false);
        this.丙丐一世世丙世丞丝 = false;
    }
    private void 丈东万丁丏一丁丟丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        GadgetCategory val_9;
        var val_10;
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.丈东万丁丏一丁丟丝();
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                不丘丄丝丗丒丙一丌 val_5 = 0;
            val_9 = 丁下万丟且丟丛下业.下丁丗丁丅下丆丂丌();
            if((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  val_9, value: out  val_5)) != false)
        {
                val_9 = val_5;
            if(val_9 != 0)
        {
                val_10 = null;
            val_10 = null;
            var val_8 = (((mem[282584257676871] + (丛与下世七三与丑丁.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_10) ? (val_9) : 0;
        }
        
            0.专万三丌且丅七丅业(下不丄七世上与专业:  this.playerMoveC.丆丁与丑三世与东与.GetComponent<TurretController>());
        }
        
        }
        
        this.HideTurretInterface();
    }
    internal void 丛丗专丒丄丗三丕一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.丛丗专丒丄丗三丕一();
        }
        
        this.HideTurretInterface();
    }
    private void 丝三丂七丟东与丁丟(int 七三丗丙丏丘丘丅上)
    {
        UILabel val_6;
        string val_7;
        UILabel val_8;
        float val_9;
        var val_10;
        if(七三丗丙丏丘丘丅上 != 0)
        {
                val_6 = this.timerStartHungerLabel;
            val_7 = +七三丗丙丏丘丘丅上;
            val_8 = this.timerStartHungerLabel;
            val_9 = 0f;
            val_10 = 1f;
        }
        else
        {
                val_6 = this.timerStartHungerLabel;
            val_9 = 1f;
            val_7 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0103");
            val_8 = this.timerStartHungerLabel;
            val_10 = val_9;
        }
        
        val_6.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if((System.String.op_Inequality(a:  mem[this.timerStartHungerLabel].text, b:  val_7)) != false)
        {
                mem[this.timerStartHungerLabel].GetComponent<UITweener>().PlayForward();
        }
        
        mem[this.timerStartHungerLabel].text = val_7;
    }
    private void 丑丄上丙上七且与专()
    {
        this.timerStartHungerLabel.gameObject.SetActive(value:  true);
        this.timerStartHungerLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.timerStartHungerLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0103");
    }
    private void Update()
    {
        string val_99;
        UILabel val_197;
        var val_198;
        var val_199;
        float val_201;
        float val_205;
        var val_206;
        float val_207;
        var val_208;
        var val_209;
        var val_210;
        var val_211;
        int val_212;
        string val_213;
        UILabel val_214;
        string val_215;
        float val_216;
        var val_217;
        Rilisoft.BankShopViewGuiElement val_218;
        var val_219;
        var val_220;
        string val_221;
        string val_222;
        string val_223;
        bool val_224;
        val_197 = this;
        val_198 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.graffitiContainer, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丞丌且不丄专专且丈()))) & 1);
        val_199 = 1152921505066536960;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_6;
        }
        
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_12;
        }
        
        if(typeof(Player_move_c).__il2cppRuntimeField_528.Count < 1)
        {
            goto label_18;
        }
        
        if((InGameGUI.<>c.<>9__197_0) == null)
        {
                System.Func<WeaponBonusItem, System.Single> val_8 = new System.Func<WeaponBonusItem, System.Single>(object:  InGameGUI.<>c.<>9, method:  System.Single InGameGUI.<>c::丄丄专七丄丆丂上一(WeaponBonusItem 丌丗丏丏丛东专丁且));
            InGameGUI.<>c.<>9__197_0 = val_8;
        }
        
        float val_9 = System.Linq.Enumerable.Max<WeaponBonusItem>(source:  typeof(Player_move_c).__il2cppRuntimeField_528, selector:  val_8);
        goto label_28;
        label_12:
        val_198 = 1152921505284374528;
        goto label_31;
        label_18:
        label_28:
        if(typeof(Player_move_c).__il2cppRuntimeField_540.Count >= 1)
        {
                if((InGameGUI.<>c.<>9__197_1) == null)
        {
                System.Func<ChestBatleRoyale, System.Single> val_11 = new System.Func<ChestBatleRoyale, System.Single>(object:  InGameGUI.<>c.<>9, method:  System.Single InGameGUI.<>c::丝下丄丑丗三一且下(ChestBatleRoyale 丌丗丏丏丛东专丁且));
            InGameGUI.<>c.<>9__197_1 = val_11;
        }
        
            float val_13 = UnityEngine.Mathf.Max(a:  0f, b:  System.Linq.Enumerable.Max<ChestBatleRoyale>(source:  typeof(Player_move_c).__il2cppRuntimeField_540, selector:  val_11));
        }
        
        val_198 = 1152921505284374528;
        this.getBonusCircular.fillAmount = val_13;
        label_31:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.getBonusBar, 丏业丟一东丂东丘丛:  (val_13 >= 0.02f) ? 1 : 0);
        label_6:
        float val_196 = this.世丕丏丁上业东下与;
        if(val_196 > 0f)
        {
                val_196 = val_196 - UnityEngine.Time.deltaTime;
            this.世丕丏丁上业东下与 = val_196;
        }
        
        if(val_196 > 0f)
        {
                if((this.playerMoveC != 0) && (this.playerMoveC.东丗丒丝丐且丞丄丏 != true))
        {
                this.blinkNoAmmoLabel.gameObject.SetActive(value:  true);
            UnityEngine.Color val_18 = this.blinkNoAmmoLabel.color;
            val_201 = this.世丕丏丁上业东下与 / this.丂丕丒丑不三丑丁丒;
            UnityEngine.Color val_19 = this.blinkNoAmmoLabel.color;
            UnityEngine.Color val_20 = this.blinkNoAmmoLabel.color;
            float val_197 = 1f;
            val_197 = val_197 - val_201;
            float val_22 = ((val_201 < 0) ? (val_201) : (val_197)) + ((val_201 < 0) ? (val_201) : (val_197));
            this.blinkNoAmmoLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        }
        
        if(this.世丕丏丁上业东下与 >= 0)
        {
                if((this.playerMoveC == 0) || (this.playerMoveC.东丗丒丝丐且丞丄丏 == false))
        {
            goto label_73;
        }
        
        }
        
        if(this.blinkNoAmmoLabel.gameObject.activeSelf != false)
        {
                this.blinkNoAmmoLabel.gameObject.SetActive(value:  false);
        }
        
        label_73:
        if(this.丕上丑丞不丒丘万三 > 0f)
        {
                float val_27 = UnityEngine.Time.deltaTime;
            val_27 = this.丕上丑丞不丒丘万三 - val_27;
            this.丕上丑丞不丒丘万三 = val_27;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.graffitiCantBeLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Color val_29 = this.graffitiCantBeLabel.color;
            val_201 = this.丕上丑丞不丒丘万三 / this.丂丕丒丑不三丑丁丒;
            UnityEngine.Color val_30 = this.graffitiCantBeLabel.color;
            UnityEngine.Color val_31 = this.graffitiCantBeLabel.color;
            float val_198 = 1f;
            val_198 = val_198 - val_201;
            float val_33 = ((val_201 < 0) ? (val_201) : (val_198)) + ((val_201 < 0) ? (val_201) : (val_198));
            this.graffitiCantBeLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.graffitiCantBeLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        val_205 = this.丝世万丒丞丆丁上一;
        if(val_205 > 0f)
        {
                if(this.丛丞丟丐丐万与丗丏 == null)
        {
                this.PlayLowResourceBeep(丌丒丝东丌下丕丁丅:  1);
        }
        
            float val_35 = UnityEngine.Time.deltaTime;
            val_35 = this.丝世万丒丞丆丁上一 - val_35;
            this.丝世万丒丞丆丁上一 = val_35;
            this.blinkGateAttack.gameObject.SetActive(value:  true);
            float val_201 = this.丂丕丒丑不三丑丁丒;
            float val_199 = this.丝世万丒丞丆丁上一;
            val_199 = val_199 / val_201;
            float val_200 = 1f;
            val_200 = val_200 - val_199;
            val_199 = (val_199 < 0) ? (val_199) : (val_200);
            val_201 = val_199 + val_199;
            this.blinkGateAttack.alpha = val_201;
            val_205 = this.丝世万丒丞丆丁上一;
        }
        
        if(val_205 < 0)
        {
                if(this.blinkGateAttack.gameObject.activeSelf != false)
        {
                this.blinkGateAttack.gameObject.SetActive(value:  false);
        }
        
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_144;
        }
        
        }
        
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_116;
        }
        
        WeaponSounds val_43 = 丙不丅丕三丂业东丕();
        if(val_43.丙且丕丝三丞下丞丌 <= this.丙丏丟丒且上一且丞)
        {
            goto label_116;
        }
        
        WeaponSounds val_44 = 丙不丅丕三丂业东丕();
        if(this.丐丝东丑丏丏丝三七 >= 0)
        {
            goto label_122;
        }
        
        WeaponSounds val_45 = 丙不丅丕三丂业东丕();
        val_205 = this.上丁业丑万丆丘丄专;
        this.丐丝东丑丏丏丝三七 = val_45.丙且丕丝三丞下丞丌;
        if(val_205 >= 0)
        {
            goto label_129;
        }
        
        val_205 = val_205 + this.丂丕丒丑不三丑丁丒;
        mem2[0] = val_205;
        goto label_129;
        label_116:
        mem2[0] = 0;
        label_149:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.wrongModuleLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        WeaponSounds val_47 = 丙不丅丕三丂业东丕();
        if(val_47.丙且丕丝三丞下丞丌 <= this.丙丏丟丒且上一且丞)
        {
            goto label_144;
        }
        
        WeaponSounds val_48 = 丙不丅丕三丂业东丕();
        val_48.丙且丕丝三丞下丞丌 = 0f;
        goto label_144;
        label_122:
        val_205 = this.上丁业丑万丆丘丄专;
        label_129:
        if(val_205 > 0f)
        {
                float val_49 = UnityEngine.Time.deltaTime;
            val_49 = val_205 - val_49;
            mem2[0] = val_49;
            this.wrongModuleLabel.gameObject.SetActive(value:  true);
            float val_204 = this.丂丕丒丑不三丑丁丒;
            float val_202 = this.上丁业丑万丆丘丄专;
            val_202 = val_202 / val_204;
            float val_203 = 1f;
            val_203 = val_203 - val_202;
            val_202 = (val_202 < 0) ? (val_202) : (val_203);
            val_204 = val_202 + val_202;
            this.七下丏丛丞丏下且专 = val_204;
            this.wrongModuleLabel.alpha = val_204;
            val_205 = mem[this.上丁业丑万丆丘丄专];
            val_205 = this.上丁业丑万丆丘丄专;
        }
        
        if(val_205 <= 0f)
        {
            goto label_149;
        }
        
        label_144:
        if(GameConnect.丘丐丅丌上与丒丞万() != false)
        {
                val_205 = this.timerShowNow;
            if(val_205 > 0f)
        {
                float val_52 = UnityEngine.Time.deltaTime;
            val_52 = val_205 - val_52;
            this.timerShowNow = val_52;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.专专丛丟丆丂且丄丒.message_now, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丁丑丅丏丒不七上丁 == false)
        {
            goto label_161;
        }
        
        if(this.playerMoveC == 0)
        {
                if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer != 0)
        {
                this.playerMoveC = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        }
        
        if(this.丁丑丅丏丒不七上丁 == true)
        {
            goto label_174;
        }
        
        label_161:
        if(this.playerMoveC == 0)
        {
                this.playerMoveC = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        if(this.丁丑丅丏丒不七上丁 == false)
        {
            goto label_533;
        }
        
        label_174:
        if(this.playerMoveC == 0)
        {
            goto label_533;
        }
        
        val_206 = 1152921505171275776;
        val_207 = 0.3f;
        label_315:
        UIPlaySound val_57 = this.messageAddScore[0].GetComponent<UIPlaySound>();
        val_57.volume = (与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != true) ? 1f : 0f;
        if(0 == 0)
        {
                float val_206 = this.playerMoveC.myScoreController.七东丙与万丒丗丕丅[0];
            val_206 = this.playerMoveC.myScoreController.下丗丘不丌世世丏丒 - val_206;
            if(val_206 < 0)
        {
                float val_208 = this.playerMoveC.myScoreController.下丗丘不丌世世丏丒;
            float val_207 = this.playerMoveC.myScoreController.七东丙与万丒丗丕丅[0];
            val_207 = val_208 - val_207;
            val_207 = val_207 * 0.2f;
            val_207 = val_207 / val_207;
            val_208 = val_207 + 1f;
        }
        
            float val_209 = this.playerMoveC.myScoreController.七东丙与万丒丗丕丅[0];
            val_209 = this.playerMoveC.myScoreController.下丗丘不丌世世丏丒 - val_209;
            val_209 = val_209 + (-0.3f);
            if(val_209 < 0)
        {
                float val_211 = this.playerMoveC.myScoreController.下丗丘不丌世世丏丒;
            float val_210 = this.playerMoveC.myScoreController.七东丙与万丒丗丕丅[0];
            val_210 = val_211 - val_210;
            val_210 = val_210 + (-0.3f);
            val_210 = val_210 / (-0.3f);
            val_210 = val_210 + 1f;
            val_210 = val_210 * 0.2f;
            val_211 = val_210 + 1f;
        }
        
            this.messageAddScore[0].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        UnityEngine.GameObject val_61 = this.killLabels[0].gameObject;
        if(this.playerMoveC.丁丝丘丌不丁丂丝万[0] > 0f)
        {
                val_61.SetActive(value:  true);
            且丗丞丅丕丕丟丕丌 val_217 = this.playerMoveC.丒丞丅丌丝七丞东一[32];
            this.killLabels[0].丒一业业丝丗三丈丏(丄丙下丝丛丒七丂丘:  new 且丗丞丅丕丕丟丕丌() {万七且丕丟世且丌不 = 1152921509441153424, 丕上丄丘世不万一丞 = 539339152, 丙丐丝一丟下丂下丒 = val_217, 丝丅丏丞丐丈丞三丞 = val_217, 丏丒不丌丝万三丄丆 = val_217, 丄丙下丝丛丒七丂丘 = val_217, 丏与丐且丏丘下东上 = new UnityEngine.Color() {r = this.playerMoveC.丒丞丅丌丝七丞东一[32], g = this.playerMoveC.丒丞丅丌丝七丞东一[32], b = this.playerMoveC.丒丞丅丌丝七丞东一[32], a = this.playerMoveC.丒丞丅丌丝七丞东一[32]}});
        }
        else
        {
                val_61.SetActive(value:  false);
        }
        
        bool val_63 = this.messageAddScore[0].gameObject.activeSelf;
        if(this.playerMoveC.myScoreController.七东丙与万丒丗丕丅[0] <= 0f)
        {
            goto label_245;
        }
        
        if(val_63 != true)
        {
                this.messageAddScore[0].gameObject.SetActive(value:  true);
        }
        
        this.messageAddScore[0].text = this.playerMoveC.myScoreController.世丙丆丁与丐丅丏业[0];
        var val_66 = (0 == 1) ? 1 : 0;
        val_66 = val_66 | ((0 == 0) ? 1 : 0);
        UILabel val_223 = this.messageAddScore[0];
        if(val_66 == 0)
        {
            goto label_260;
        }
        
        UnityEngine.Color val_67 = this.playerMoveC.myScoreController.丁且万万丅丒丅三且();
        val_223.gradientTop = new UnityEngine.Color() {r = val_67.r, g = val_67.g, b = val_67.b, a = val_67.a};
        UnityEngine.Color val_68 = this.playerMoveC.myScoreController.下且与丌丂丒上丘东();
        this.messageAddScore[0].gradientBottom = new UnityEngine.Color() {r = val_68.r, g = val_68.g, b = val_68.b, a = val_68.a};
        this.messageAddScore[0].applyGradient = this.playerMoveC.myScoreController.且三丂丕丘与丆业丆();
        this.messageAddScore[0].effectStyle = this.playerMoveC.myScoreController.丈丕丏丂丌不东丈专();
        UnityEngine.Vector2 val_72 = this.playerMoveC.myScoreController.下丝丟丞不丒丆专丛();
        this.messageAddScore[0].effectDistance = new UnityEngine.Vector2() {x = val_72.x, y = val_72.y};
        UILabel val_228 = this.messageAddScore[0];
        UnityEngine.Color val_73 = this.playerMoveC.myScoreController.丄丝丐七万丕丝业丆();
        goto label_288;
        label_245:
        if(val_63 != false)
        {
                this.messageAddScore[0].gameObject.SetActive(value:  false);
        }
        
        this.playerMoveC.myScoreController.丒丄丟东丑不三七世();
        goto label_296;
        label_260:
        UnityEngine.Color val_75 = UnityEngine.Color.white;
        val_223.gradientTop = new UnityEngine.Color() {r = val_75.r, g = val_75.g, b = val_75.b, a = val_75.a};
        UnityEngine.Color val_76 = UnityEngine.Color.white;
        this.messageAddScore[0].gradientBottom = new UnityEngine.Color() {r = val_76.r, g = val_76.g, b = val_76.b, a = val_76.a};
        this.messageAddScore[0].applyGradient = false;
        this.messageAddScore[0].effectStyle = 0;
        UnityEngine.Vector2 val_77 = UnityEngine.Vector2.zero;
        this.messageAddScore[0].effectDistance = new UnityEngine.Vector2() {x = val_77.x, y = val_77.y};
        UnityEngine.Color val_78 = UnityEngine.Color.white;
        label_288:
        val_201 = val_78.b;
        this.messageAddScore[0].effectColor = new UnityEngine.Color() {r = val_78.r, g = val_78.g, b = val_201, a = val_78.a};
        label_296:
        if(1 != 3)
        {
            goto label_315;
        }
        
        val_198 = 1152921505284374528;
        if(与丂丏丛丞丞丒丟丄.丈丂业一丁下丘东万().世三丞丅丑丌丈丈一() == false)
        {
            goto label_319;
        }
        
        System.Collections.Generic.List<丝丄丌丏一专一丘丗> val_235 = this.playerMoveC.丅丛丌不丗丏丞丝丌;
        val_206 = 1152921525660510272;
        int val_81 = val_235.Count;
        val_235 = val_81 - 1;
        if((val_235 & 2147483648) != 0)
        {
            goto label_322;
        }
        
        val_201 = 0.9f;
        val_207 = 10f;
        label_390:
        int val_83 = (-val_81) + this.playerMoveC.丅丛丌不丗丏丞丝丌.Count;
        val_83 = val_83 + 0;
        if(val_83 >= 3)
        {
            goto label_325;
        }
        
        丝丄丌丏一专一丘丗 val_85 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        float val_236 = UnityEngine.Time.time - val_236;
        if(val_236 >= 0)
        {
            goto label_328;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
            goto label_337;
        }
        
        丝丄丌丏一专一丘丗 val_86 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        if(268435457 != (GetComponent<PhotonView>().viewID))
        {
            goto label_337;
        }
        
        UILabel val_89 = this.chatLabels[0].GetComponent<UILabel>();
        goto label_341;
        label_328:
        UnityEngine.GameObject val_238 = this.chatLabels[0];
        goto label_346;
        label_337:
        丝丄丌丏一专一丘丗 val_90 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        if(val_217 == 0)
        {
                this.chatLabels[0].GetComponent<UILabel>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        丝丄丌丏一专一丘丗 val_92 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        if(val_217 == 1)
        {
                this.chatLabels[0].GetComponent<UILabel>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        丝丄丌丏一专一丘丗 val_94 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        if(val_217 != 2)
        {
            goto label_363;
        }
        
        label_341:
        this.chatLabels[0].GetComponent<UILabel>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        label_363:
        ChatLabel val_96 = this.chatLabels[0].GetComponent<ChatLabel>();
        丝丄丌丏一专一丘丗 val_97 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        val_96.nickLabel.text = 0;
        丝丄丌丏一专一丘丗 val_98 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        val_96.iconSprite.spriteName = val_99;
        UnityEngine.Transform val_100 = val_96.iconSprite.transform;
        if(val_100 != null)
        {
                UnityEngine.Vector3 val_102 = val_100.localPosition;
        }
        else
        {
                UnityEngine.Vector3 val_103 = 0.localPosition;
        }
        
        UnityEngine.Vector3 val_104 = val_100.localPosition;
        int val_105 = val_96.nickLabel.width + 20;
        val_100.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_198 = 1152921505284374528;
        丝丄丌丏一专一丘丗 val_106 = this.playerMoveC.丅丛丌不丗丏丞丝丌.Item[val_235];
        label_346:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chatLabels[0], 丏业丟一东丂东丘丛:  true);
        val_235 = val_235 - 1;
        if((val_235 & 2147483648) == 0)
        {
            goto label_390;
        }
        
        label_325:
        val_199 = 1152921505066536960;
        if(1 <= 2)
        {
            goto label_391;
        }
        
        goto label_398;
        label_319:
        do
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chatLabels[0], 丏业丟一东丂东丘丛:  false);
        }
        while(1 != 3);
        
        goto label_398;
        label_322:
        val_199 = 1152921505066536960;
        label_391:
        do
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chatLabels[0], 丏业丟一东丂东丘丛:  false);
        }
        while(0 != 2);
        
        label_398:
        val_205 = this.timerShowScorePict;
        if(val_205 > 0f)
        {
                float val_108 = UnityEngine.Time.deltaTime;
            val_108 = val_205 - val_108;
            this.timerShowScorePict = val_108;
        }
        
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
            goto label_407;
        }
        
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count != 2)
        {
            goto label_416;
        }
        
        MiniGamesController val_111 = MiniGamesController.丑七不且上丗丁一世();
        if(val_111.isGo == false)
        {
            goto label_416;
        }
        
        MiniGamesController val_112 = MiniGamesController.丑七不且上丗丁一世();
        var val_113 = (val_112.timeInGame > 10f) ? 1 : 0;
        goto label_420;
        label_416:
        label_420:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.专丌且一丒且七世丒.duelLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.multyKillPanel.gameObject, 丏业丟一东丂东丘丛:  false);
        label_407:
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
            goto label_444;
        }
        
        if(this.timerShowScorePict > 0f)
        {
                if(PlantTheBombController.BlockScoreAndKillStreak == false)
        {
            goto label_428;
        }
        
        }
        
        if(this.multyKillPanel.gameObject.activeSelf == false)
        {
            goto label_444;
        }
        
        this.multyKillPanel.gameObject.SetActive(value:  false);
        goto label_444;
        label_428:
        if(this.multyKillPanel.gameObject.activeSelf != false)
        {
                if((System.String.op_Inequality(a:  this.scorePictName, b:  this.multyKill.currentStreak)) == false)
        {
            goto label_444;
        }
        
        }
        
        if(PauseGUIController.丑七不且上丗丁一世() != 0)
        {
                if(PauseGUIController.丑七不且上丗丁一世().IsPaused == true)
        {
            goto label_444;
        }
        
        }
        
        this.multyKillPanel.gameObject.SetActive(value:  true);
        this.multyKill.PlayStreak(丅丈丗丒上与下丁业:  this.scorePictName, 万丑丞一丝丌丐丒丘:  this.scoreIconName, 丄丙下丝丛丒七丂丘:  this.scoreMessage);
        val_198 = 1152921505284374528;
        label_444:
        if(GameConnect.不专专丂万丝上东丐() == false)
        {
            goto label_466;
        }
        
        MiniGamesController val_129 = MiniGamesController.丑七不且上丗丁一世();
        if(val_129.isGo == false)
        {
            goto label_454;
        }
        
        MiniGamesController val_130 = MiniGamesController.丑七不且上丗丁一世();
        if(val_130.isGo == false)
        {
            goto label_462;
        }
        
        MiniGamesController val_131 = MiniGamesController.丑七不且上丗丁一世();
        if(val_131.isShowGo == false)
        {
            goto label_462;
        }
        
        this.丑丄上丙上七且与专();
        goto label_466;
        label_462:
        this.timerStartHungerLabel.gameObject.SetActive(value:  false);
        goto label_466;
        label_454:
        this.timerStartHungerLabel.gameObject.SetActive(value:  true);
        MiniGamesController val_134 = MiniGamesController.丑七不且上丗丁一世();
        val_205 = val_134.goTimer;
        this.丝三丂七丟东与丁丟(七三丗丙丏丘丘丅上:  UnityEngine.Mathf.FloorToInt(f:  val_205));
        label_466:
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_489;
        }
        
        this.timerStartHungerLabel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.isInRound == false)
        {
            goto label_489;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.isGo == false)
        {
            goto label_482;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.isShowGo == false)
        {
            goto label_484;
        }
        
        this.丑丄上丙上七且与专();
        goto label_489;
        label_482:
        this.timerStartHungerLabel.gameObject.SetActive(value:  true);
        this.丝三丂七丟东与丁丟(七三丗丙丏丘丘丅上:  ((int)PlantTheBombController.丆丕丝丒不丙且丐丗.goTimer < (2.47032822920623E-323)) ? ((int)PlantTheBombController.丆丕丝丒不丙且丐丗.goTimer) : 5);
        goto label_489;
        label_484:
        this.timerStartHungerLabel.gameObject.SetActive(value:  false);
        label_489:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_515;
        }
        
        this.timerStartHungerLabel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_208 = null;
        val_208 = null;
        if(MutationController.丆丕丝丒不丙且丐丗.下丐万丞业且丈不丞() == false)
        {
            goto label_515;
        }
        
        val_209 = null;
        val_209 = null;
        if(MutationController.丆丕丝丒不丙且丐丗.丗丒丕专丛丆丈万一() == false)
        {
            goto label_504;
        }
        
        val_210 = null;
        val_210 = null;
        if(MutationController.丆丕丝丒不丙且丐丗.七丌丌丐丘下丟丐丌() == false)
        {
            goto label_508;
        }
        
        this.丑丄上丙上七且与专();
        goto label_515;
        label_504:
        this.timerStartHungerLabel.gameObject.SetActive(value:  true);
        val_211 = null;
        val_211 = null;
        this.丝三丂七丟东与丁丟(七三丗丙丏丘丘丅上:  ((int)MutationController.丆丕丝丒不丙且丐丗.goTimer < (2.47032822920623E-323)) ? ((int)MutationController.丆丕丝丒不丙且丐丗.goTimer) : 5);
        goto label_515;
        label_508:
        this.timerStartHungerLabel.gameObject.SetActive(value:  false);
        label_515:
        if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_533;
        }
        
        this.timerStartHungerLabel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(RedLightController.Instance.下丐万丞业且丈不丞() == false)
        {
            goto label_533;
        }
        
        if(RedLightController.Instance.丗丒丕专丛丆丈万一() == false)
        {
            goto label_526;
        }
        
        if(RedLightController.Instance.七丌丌丐丘下丟丐丌() == false)
        {
            goto label_528;
        }
        
        this.丑丄上丙上七且与专();
        goto label_533;
        label_526:
        this.timerStartHungerLabel.gameObject.SetActive(value:  true);
        this.丝三丂七丟东与丁丟(七三丗丙丏丘丘丅上:  ((int)RedLightController.Instance.goTimer < (2.47032822920623E-323)) ? ((int)RedLightController.Instance.goTimer) : 5);
        goto label_533;
        label_528:
        this.timerStartHungerLabel.gameObject.SetActive(value:  false);
        label_533:
        if((this.playerMoveC == 0) || (GameConnect.丛专丌且丕不专丈下() == false))
        {
            goto label_556;
        }
        
        val_212 = SpeedrunTrackController.丛专与丅下丌丆世丒;
        if(val_212 == 0)
        {
            goto label_542;
        }
        
        if((SpeedrunTrackController.丛专与丅下丌丆世丒 + 164) == 0)
        {
            goto label_543;
        }
        
        label_558:
        if(((SpeedrunTrackController.丛专与丅下丌丆世丒 + 164) == 0) || ((SpeedrunTrackController.丛专与丅下丌丆世丒 + 180) == 0))
        {
            goto label_546;
        }
        
        this.timerStartHungerLabel.gameObject.SetActive(value:  true);
        this.timerStartHungerLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_213 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0103");
        goto label_553;
        label_546:
        this.timerStartHungerLabel.gameObject.SetActive(value:  false);
        goto label_556;
        label_542:
        if(SpeedrunTrackController.丛专与丅下丌丆世丒 == 0)
        {
            goto label_557;
        }
        
        val_212 = SpeedrunTrackController.丛专与丅下丌丆世丒;
        if((SpeedrunTrackController.丛专与丅下丌丆世丒 + 164) != 0)
        {
            goto label_558;
        }
        
        label_543:
        val_205 = mem[SpeedrunTrackController.丛专与丅下丌丆世丒 + 168];
        val_205 = SpeedrunTrackController.丛专与丅下丌丆世丒 + 168;
        int val_168 = UnityEngine.Mathf.FloorToInt(f:  val_205);
        this.timerStartHungerLabel.gameObject.SetActive(value:  true);
        if(val_168 != 0)
        {
                val_214 = this.timerStartHungerLabel;
            val_215 = +val_168;
            val_216 = 0f;
            val_217 = 1f;
        }
        else
        {
                val_214 = this.timerStartHungerLabel;
            val_216 = 1f;
            val_215 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0103");
            val_217 = val_216;
        }
        
        val_214.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if((System.String.op_Inequality(a:  this.timerStartHungerLabel.text, b:  val_215)) != false)
        {
                this.timerStartHungerLabel.GetComponent<UITweener>().PlayForward();
        }
        
        val_213 = val_215;
        label_553:
        this.timerStartHungerLabel.text = val_213;
        label_556:
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() != false)
        {
                if((System.String.op_Inequality(a:  this.万丈丝丝丆丙丘丆丈(), b:  与丂丏丛丞丞丒丟丄.丗丄丛丆七丁丗丗专())) != false)
        {
                if(this.turretPanel.activeSelf == false)
        {
            goto label_580;
        }
        
        }
        
        }
        
        label_609:
        val_218 = this.shopView;
        if(false != this.shopView.InteractionEnabled)
        {
                val_218 = this.shopView;
            this.shopView.InteractionEnabled = false;
            this.shopView.丝一丅丆三东丂丞七();
        }
        
        if(this.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        if(this.专业丙上丕丌丙丕三 == 0)
        {
                return;
        }
        
        val_218 = this.专业丙上丕丌丙丕三.丌丟且丛丄丒万丈丑();
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_612;
        }
        
        if((丟丌丁且且世丈丈丟.东丐丄七丆三且丕万(专万丟三世业丙丈且:  this.万丈丝丝丆丙丘丆丈())) != val_218)
        {
            goto label_595;
        }
        
        val_219 = null;
        val_219 = null;
        if((下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.ContainsKey(key:  this.万丈丝丝丆丙丘丆丈())) == false)
        {
            goto label_599;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_605;
        }
        
        val_220 = null;
        val_220 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "cubic_arena_campaign4")) == false)
        {
            goto label_605;
        }
        
        val_221 = "Key_6999";
        goto label_621;
        label_580:
        bool val_246 = this.丙丐一世世丙世丞丝;
        val_246 = val_246 ^ 1;
        bool val_189 = val_246 & 255;
        goto label_609;
        label_595:
        if(CampaignBaseController.丄丘七三上丕世丞业 == 0)
        {
            goto label_612;
        }
        
        val_222 = "Key_6985";
        goto label_615;
        label_612:
        val_197 = this.enemiesLeftLabel;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_197, 丏业丟一东丂东丘丛:  false);
        return;
        label_599:
        val_221 = "Key_0854";
        goto label_621;
        label_605:
        val_221 = "Key_0192";
        label_621:
        val_223 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_221);
        if(this.专业丙上丕丌丙丕三.bossShowm == false)
        {
            goto label_625;
        }
        
        val_222 = "Key_0855";
        label_615:
        val_223 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_222);
        label_625:
        val_218 = this.enemiesLeftLabel;
        if(this.perfectLabels == 0)
        {
                val_224 = 1;
        }
        else
        {
                val_224 = (~this.perfectLabels.gameObject.activeInHierarchy) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_218, 丏业丟一东丂东丘丛:  val_224);
        val_197 = this.enemiesLeftLabel;
        val_197.text = val_223;
        return;
        label_557:
    }
    public void SetScopeForWeapon(string 丙丐一丕丗万丁下一)
    {
        this.scopeText.SetActive(value:  true);
        UnityEngine.Texture val_4 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Scopes", 丌丗丏丏丛东专丁且:  "Scope_" + 丙丐一丕丗万丁下一));
        if((this.scopeText.GetComponent<UITexture>()) == null)
        {
            
        }
    
    }
    public void ResetScope()
    {
        UITexture val_1 = this.scopeText.GetComponent<UITexture>();
        this.scopeText.SetActive(value:  false);
    }
    public void BlinkNoAmmo(int 丌丒丝东丌下丕丁丅)
    {
        if((丌丒丝东丌下丕丁丅 == 0) && (this.丛丞丟丐丐万与丗丏 != null))
        {
                this.StopCoroutine(routine:  this.丛丞丟丐丐万与丗丏);
            this.丛丞丟丐丐万与丗丏 = 0;
        }
        
        float val_4 = this.丂丕丒丑不三丑丁丒;
        val_4 = val_4 * (float)丌丒丝东丌下丕丁丅;
        this.世丕丏丁上业东下与 = val_4;
        UnityEngine.Color val_1 = this.blinkNoAmmoLabel.color;
        UnityEngine.Color val_2 = this.blinkNoAmmoLabel.color;
        UnityEngine.Color val_3 = this.blinkNoAmmoLabel.color;
        this.blinkNoAmmoLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public void BlinkNoGraffiti(int 丌丒丝东丌下丕丁丅)
    {
        if((丌丒丝东丌下丕丁丅 == 0) && (this.丛丞丟丐丐万与丗丏 != null))
        {
                this.StopCoroutine(routine:  this.丛丞丟丐丐万与丗丏);
            this.丛丞丟丐丐万与丗丏 = 0;
        }
        
        float val_4 = this.丂丕丒丑不三丑丁丒;
        val_4 = val_4 * (float)丌丒丝东丌下丕丁丅;
        this.丕上丑丞不丒丘万三 = val_4;
        UnityEngine.Color val_1 = this.graffitiCantBeLabel.color;
        UnityEngine.Color val_2 = this.graffitiCantBeLabel.color;
        UnityEngine.Color val_3 = this.graffitiCantBeLabel.color;
        this.graffitiCantBeLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public void BlinkSiegeGateOnAttack()
    {
        if(this.丒丐丌丁丁七丝丆丗 > 0f)
        {
                return;
        }
        
        this.丝世万丒丞丆丁上一 = this.丂丕丒丑不三丑丁丒;
        this.blinkGateAttack.alpha = 0f;
    }
    internal static void 世丙丆业世丝与丝七(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丁东丑丞与下丛丐东)
    {
        var val_3;
        goto label_2;
        label_7:
        val_3 = 丝三丁东丈丒世丅业.GetComponentsInChildren<UnityEngine.Transform>(includeInactive:  true)[0].gameObject;
        val_3.layer = 丁东丑丞与下丛丐东;
        0 = 1;
        label_2:
        if(0 < val_1.Length)
        {
            goto label_7;
        }
    
    }
    internal void 丟业丅三世万世丞不(float 东丞下七东下丅丙与)
    {
        if(this.slowdown == 0)
        {
                return;
        }
        
        this = this.slowdown;
        this.text = System.String.Format(format:  "Коеф. замедления: {0}", arg0:  东丞下七东下丅丙与);
    }
    private void OnDestroy()
    {
        var val_4;
        InGameGUI.丙丞专丌丁丞与不丐 = 0;
        val_4 = 1152921504615739392;
        PauseNGUIController.丈一丞丘世丌丄上丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void InGameGUI::丘丌三与下丈一与万()));
        ControlsSettingsBase.丂丑不丑丙丛丘丄下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void InGameGUI::丘丌三与下丈一与万()));
        if(this.一与丛丑下不丘七丘 == null)
        {
                return;
        }
        
        val_4 = CoroutineRunner.Instance;
        val_4.StopCoroutine(routine:  this.一与丛丑下不丘七丘);
        this.一与丛丑下不丘七丘 = 0;
    }
    public void SetInterfaceVisible(bool 下下东且万业丞丅丒, bool 丅丞七丟丘丆丟丘丞 = False)
    {
        UnityEngine.GameObject val_7;
        bool val_8;
        if(this.丕丏专丂一东丆万丏 != false)
        {
                return;
        }
        
        if((丅丞七丟丘丆丟丘丞 != false) && (下下东且万业丞丅丒 != true))
        {
                val_7 = this.interfaceContainer;
            val_8 = 0;
        }
        else
        {
                bool val_1 = 下下东且万业丞丅丒;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.interfacePanel, 丏业丟一东丂东丘丛:  val_1);
            val_7 = this.interfaceContainer;
            val_8 = val_1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  val_8);
        this.joystikPanel.gameObject.SetActive(value:  下下东且万业丞丅丒);
        this.bloodPanel.gameObject.SetActive(value:  下下东且万业丞丅丒 | 丅丞七丟丘丆丟丘丞);
    }
    public void DeactivateInterface()
    {
        goto label_1;
        label_12:
        UnityEngine.Transform val_2 = this._subpanelsContainer.transform.GetChild(index:  0);
        if(val_2 != this.killWhitePanel.transform)
        {
                val_2.gameObject.SetActive(value:  false);
        }
        
        0 = 1;
        label_1:
        if(0 < this._subpanelsContainer.transform.childCount)
        {
            goto label_12;
        }
        
        this.enabled = false;
        this.丕丏专丂一东丆万丏 = true;
    }
    internal bool 不东七三丂专丐丆丈()
    {
        return (bool)this.<且业丂丁丘丝专丘丈>k__BackingField;
    }
    private void 上业丗丏丘不丆万世(bool 丙业与丙丗丝不丈东)
    {
        this.<且业丂丁丘丝专丘丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丅丁丕丙业丁专丄一()
    {
        return (bool)this.<且业丂丁丘丝专丘丈>k__BackingField;
    }
    internal void 丌且丄与丘丑丏下丏(bool 丁业丁丘丛丕与丛丘)
    {
        bool val_1 = ~丁业丁丘丛丕与丛丘;
        val_1 = val_1 & 1;
        this.<且业丂丁丘丝专丘丈>k__BackingField = val_1;
        this.丌且丄与丘丑丏下丏();
    }
    internal void 丌且丄与丘丑丏下丏()
    {
        if((this.<且业丂丁丘丝专丘丈>k__BackingField) != false)
        {
                this.东丅丙丈丛丑丏丝丑();
        }
        else
        {
                this.丁丂下丙丐东丄三丞();
        }
        
        bool val_1 = this.<且业丂丁丘丝专丘丈>k__BackingField;
        val_1 = val_1 ^ 1;
        this.<且业丂丁丘丝专丘丈>k__BackingField = val_1;
    }
    internal void 丈万东不丒东丐万丗(int 丞世不丒下上上丝丑)
    {
        MultyKill val_17;
        UnityEngine.GameObject[] val_18;
        var val_19;
        MultyKill val_20;
        bool val_21;
        val_17 = this;
        val_18 = this.hidingElems;
        if(val_18 == null)
        {
            goto label_1;
        }
        
        if((丞世不丒下上上丝丑 & 2147483648) == 0)
        {
            goto label_2;
        }
        
        return;
        label_1:
        if((丞世不丒下上上丝丑 & 2147483648) != 0)
        {
                return;
        }
        
        label_2:
        if(this.hidingElems.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        bool val_2 = UnityEngine.Object.op_Implicit(exists:  this.hidingElems[(long)丞世不丒下上上丝丑].GetComponent<UIPanel>());
        UnityEngine.GameObject val_18 = this.hidingElems[(long)丞世不丒下上上丝丑];
        if(val_18 == null)
        {
            goto label_13;
        }
        
        if(val_2 == false)
        {
            goto label_14;
        }
        
        label_26:
        val_18 = val_18.GetComponent<UIPanel>();
        if(val_18 == 0)
        {
                return;
        }
        
        val_19 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.hidingElems[(long)丞世不丒下上上丝丑].GetComponent<MultyKill>())) == false)
        {
            goto label_23;
        }
        
        val_20 = this.multyKill;
        if(val_20 == null)
        {
            goto label_24;
        }
        
        val_21 = this.multyKill.丐丟东下丘丟丐丗与;
        goto label_25;
        label_13:
        if(val_2 == true)
        {
            goto label_26;
        }
        
        label_14:
        bool val_8 = UnityEngine.Object.op_Implicit(exists:  val_18.GetComponent<TouchButton>());
        UnityEngine.GameObject val_20 = this.hidingElems[(long)丞世不丒下上上丝丑];
        if(val_20 == null)
        {
            goto label_31;
        }
        
        if(val_8 == false)
        {
            goto label_32;
        }
        
        label_38:
        this.hidingElems[(long)丞世不丒下上上丝丑].GetComponent<TouchButton>().丝丆且下丁三不丘世(下丌丟丏丏丘专丒专:  ((val_20.GetComponent<UISprite>().alpha) == 1f) ? 0.004f : 1f);
        return;
        label_31:
        if(val_8 == true)
        {
            goto label_38;
        }
        
        label_32:
        this.hidingElems[(long)丞世不丒下上上丝丑].SetActive(value:  (~val_20.activeSelf) & 1);
        return;
        label_23:
        var val_15 = (S0 == 1f) ? 0.004f : 1f;
        if(val_18 != null)
        {
            goto typeof(UIPanel).__il2cppRuntimeField_1A8;
        }
        
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
        label_24:
        val_20 = 56;
        val_21 = 7;
        label_25:
        mem[56] = 6;
        val_17 = this.multyKill;
        var val_16 = (this.multyKill.丐丟东下丘丟丐丗与 == true) ? 1f : 0.004f;
        if(val_18 == null)
        {
            
        }
    
    }
    internal void 丈万东不丒东丐万丗(int 丞世不丒下上上丝丑, bool 不与万丌一丈下丑丈)
    {
        bool val_14;
        UnityEngine.Object val_15;
        float val_16;
        val_14 = 不与万丌一丈下丑丈;
        if(this.hidingElems == null)
        {
            goto label_1;
        }
        
        if((丞世不丒下上上丝丑 & 2147483648) == 0)
        {
            goto label_2;
        }
        
        return;
        label_1:
        if((丞世不丒下上上丝丑 & 2147483648) != 0)
        {
                return;
        }
        
        label_2:
        if(this.hidingElems.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        bool val_2 = UnityEngine.Object.op_Implicit(exists:  this.hidingElems[(long)丞世不丒下上上丝丑].GetComponent<UIPanel>());
        UnityEngine.GameObject val_15 = this.hidingElems[(long)丞世不丒下上上丝丑];
        if(val_15 == null)
        {
            goto label_13;
        }
        
        if(val_2 == false)
        {
            goto label_14;
        }
        
        label_27:
        UIPanel val_3 = val_15.GetComponent<UIPanel>();
        if(val_3 == 0)
        {
                return;
        }
        
        val_15 = this.hidingElems[(long)丞世不丒下上上丝丑].GetComponent<MultyKill>();
        if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
        {
            goto label_23;
        }
        
        val_15 = this.multyKill;
        this.multyKill.丐丟东下丘丟丐丗与 = val_14;
        val_14 = this.multyKill;
        val_16 = 0.004f;
        goto label_26;
        label_13:
        if(val_2 == true)
        {
            goto label_27;
        }
        
        label_14:
        bool val_9 = UnityEngine.Object.op_Implicit(exists:  val_15.GetComponent<TouchButton>());
        UnityEngine.GameObject val_17 = this.hidingElems[(long)丞世不丒下上上丝丑];
        if(val_17 == null)
        {
            goto label_32;
        }
        
        if(val_9 == false)
        {
            goto label_33;
        }
        
        label_35:
        val_17.GetComponent<TouchButton>().丝丆且下丁三不丘世(下丌丟丏丏丘专丒专:  (val_14 != true) ? 1f : 0.004f);
        return;
        label_32:
        if(val_9 == true)
        {
            goto label_35;
        }
        
        label_33:
        val_17.SetActive(value:  val_14);
        return;
        label_23:
        val_16 = 0.004f;
        label_26:
        var val_13 = (val_14 != true) ? 1f : (val_16);
        if(val_3 == null)
        {
            
        }
    
    }
    private void 丁丂下丙丐东丄三丞()
    {
        UnityEngine.Object val_11;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_2 = new object[1];
            val_2[0] = this.GetType();
            UnityEngine.Debug.LogFormat(format:  "{0}.OnGuiVisibilityButtonClicked()", args:  val_2);
        }
        
        val_11 = this.GetComponent<UIPanel>();
        if(val_11 == 0)
        {
                return;
        }
        
        val_11 = ???;
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
    }
    private void 东丅丙丈丛丑丏丝丑()
    {
        UnityEngine.Object val_11;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_2 = new object[1];
            val_2[0] = this.GetType();
            UnityEngine.Debug.LogFormat(format:  "{0}.OnGuiVisibilityButtonClicked()", args:  val_2);
        }
        
        val_11 = this.GetComponent<UIPanel>();
        if(val_11 == 0)
        {
                return;
        }
        
        val_11 = ???;
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
    }
    internal void 专丌丒东丟三不上专()
    {
        System.Collections.Generic.Dictionary<UIPanel, System.Single> val_8;
        if(this.丛三与丟丗丗东丘七 == null)
        {
            goto label_1;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丛三与丟丗丗东丘七.GetEnumerator();
        label_4:
        if(((-850709336) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        if(val_2._value._obj.丐丏七丌丕丗业且上() != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        System.Collections.Generic.Dictionary<UIPanel, System.Single> val_4 = null;
        val_8 = val_4;
        val_4 = new System.Collections.Generic.Dictionary<UIPanel, System.Single>();
        this.丛三与丟丗丗东丘七 = val_8;
        this.丌下丒丗丐业丂一丒(万且万且丑丗且丌丆:  this.gameObject, 下丐丟下业丑万万丒:  true);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛三与丟丗丗东丘七 = 0;
        label_5:
        this.leftAnchor.gameObject.SetActive(value:  (this.丛三与丟丗丗东丘七 != 0) ? 1 : 0);
    }
    internal void 丌下丒丗丐业丂一丒(UnityEngine.GameObject 万且万且丑丗且丌丆, bool 下丐丟下业丑万万丒)
    {
        bool val_16;
        var val_17;
        UnityEngine.Object val_18;
        UIPanel val_19;
        val_16 = 下丐丟下业丑万万丒;
        UnityEngine.Transform val_1 = 万且万且丑丗且丌丆.transform;
        int val_2 = val_1.childCount;
        if(val_2 < 1)
        {
                return;
        }
        
        val_17 = 1152921524348281760;
        var val_16 = 0;
        var val_3 = (val_16 != true) ? 0.004f : 1f;
        do
        {
            UnityEngine.Transform val_4 = val_1.GetChild(index:  0);
            if(0 != val_4)
        {
                val_18 = val_4.GetComponent<UIPanel>();
            if(val_18 != 0)
        {
                val_18 = val_4.GetComponentInChildren<AimCrosshairController>();
            if(val_18 == 0)
        {
                if(val_4 != null)
        {
                val_19 = val_4.GetComponent<UIPanel>();
        }
        else
        {
                val_19 = val_4.GetComponent<UIPanel>();
        }
        
            UIPanel val_12 = val_4.GetComponent<UIPanel>();
            this.丛三与丟丗丗东丘七.Add(key:  val_19, value:  1f);
            val_17 = val_17;
            val_16 = val_16;
            val_18 = val_4.GetComponent<UIPanel>();
        }
        
        }
        
            UnityEngine.GameObject val_14 = val_4.gameObject;
            bool val_15 = val_16;
        }
        
            val_16 = val_16 + 1;
        }
        while(val_2 != val_16);
    
    }
    internal void 丙丈丌下丒专丝丄七(bool 且且与丛七丗上丛三)
    {
        if(this.丁下世丏丂丅下三下 == null)
        {
            goto label_1;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丁下世丏丂丅下三下.GetEnumerator();
        label_4:
        if(((-850339928) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        if(val_2._value._obj.丐丏七丌丕丗业且上() != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        this.丁下世丏丂丅下三下 = new System.Collections.Generic.Dictionary<UIPanel, System.Single>();
        this.丈一丌世业丅东丄丌(万且万且丑丗且丌丆:  this.gameObject, 下丐丟下业丑万万丒:  且且与丛七丗上丛三);
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丁下世丏丂丅下三下 = 0;
        label_5:
        this.leftAnchor.gameObject.SetActive(value:  (this.丁下世丏丂丅下三下 != 0) ? 1 : 0);
        if(this.killWhitePanel != null)
        {
                return;
        }
    
    }
    internal void 丈一丌世业丅东丄丌(UnityEngine.GameObject 万且万且丑丗且丌丆, bool 下丐丟下业丑万万丒)
    {
        var val_27;
        UnityEngine.Object val_28;
        UnityEngine.Transform val_1 = 万且万且丑丗且丌丆.transform;
        int val_2 = val_1.childCount;
        if(val_2 < 1)
        {
                return;
        }
        
        val_27 = 1152921524348281760;
        var val_27 = 0;
        var val_3 = (下丐丟下业丑万万丒 != true) ? 0.004f : 1f;
        label_41:
        UnityEngine.Transform val_4 = val_1.GetChild(index:  0);
        if(0 == val_4)
        {
            goto label_7;
        }
        
        val_28 = val_4.GetComponent<UIPanel>();
        if(val_28 == 0)
        {
            goto label_32;
        }
        
        val_28 = val_4.gameObject.name;
        if((val_28.Contains(value:  "Notification")) == true)
        {
            goto label_32;
        }
        
        if((val_4.GetComponentInChildren<AimCrosshairController>()) == 0)
        {
            goto label_19;
        }
        
        val_28 = val_4.gameObject.name;
        if((val_28.Contains(value:  "SCOPE")) == false)
        {
            goto label_32;
        }
        
        label_19:
        val_28 = this.interfacePanel;
        if(val_4.gameObject != val_28)
        {
                val_28 = val_4.gameObject;
            if(val_28 != this.rootMainPanel.gameObject)
        {
                if(val_4 != null)
        {
                UIPanel val_21 = val_4.GetComponent<UIPanel>();
        }
        
            UIPanel val_23 = val_4.GetComponent<UIPanel>();
            this.丁下世丏丂丅下三下.Add(key:  val_4.GetComponent<UIPanel>(), value:  1f);
            val_27 = val_27;
            val_28 = val_4.GetComponent<UIPanel>();
        }
        
        }
        
        label_32:
        UnityEngine.GameObject val_25 = val_4.gameObject;
        bool val_26 = 下丐丟下业丑万万丒;
        label_7:
        val_27 = val_27 + 1;
        if(val_2 != val_27)
        {
            goto label_41;
        }
    
    }
    private void 丙丛丕丛丟世上丘上(float 丝三业丛丘且不丝丆)
    {
        UnityEngine.Object val_8 = UICamera.mainCamera;
        if(val_8 != 0)
        {
                val_8 = UICamera.mainCamera.GetComponent<UICamera>();
            if(val_8 != 0)
        {
                UICamera val_7 = UICamera.mainCamera.GetComponent<UICamera>();
            val_7.touchDragThreshold = 丝三业丛丘且不丝丆;
            return;
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  "UICamera.mainCamera is null");
    }
    public void ShowControlSchemeConfigurator()
    {
    
    }
    public bool get_ExitingInCampaign()
    {
        return (bool)this.丏丘万丑丕丁不丈丞;
    }
    public void set_ExitingInCampaign(bool 丙业与丙丗丝不丈东)
    {
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
                return;
        }
        
        this.丏丘万丑丕丁不丈丞 = 丙业与丙丗丝不丈东;
    }
    public bool get_isWorldMapOpened()
    {
        if(this.专丐万丆丑三上丘七 == 0)
        {
                return false;
        }
        
        if(this.专丐万丆丑三上丘七 != null)
        {
                return this.专丐万丆丑三上丘七.isWorldMapOpened;
        }
        
        return this.专丐万丆丑三上丘七.isWorldMapOpened;
    }
    public void CheckVingetteUI()
    {
        this.healthBloodIndicator.丑专东丁丞丑东丁丟();
    }
    private void 东丞且三丐丒专丄且()
    {
        if((ControlFireSettings.丈业且丘丈不丄丈丒(丁丅丈丌丟世丗丗丟:  下丂世丂不丛专一一.丕丙丛万丒七业丄下(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()))) == null)
        {
                return;
        }
        
        与丂丏丛丞丞丒丟丄.与丟丂三丄丄丒下三(丙业与丙丗丝不丈东:  (val_3.IsAutoShooting == true) ? 1 : 0);
        与丂丏丛丞丞丒丟丄.且丒丅丘丝上丏丒丏(丙业与丙丗丝不丈东:  val_3.IsAiming);
        与丂丏丛丞丞丒丟丄.专丅万丄专专一丝丑(丙业与丙丗丝不丈东:  val_3.Style);
    }
    public InGameGUI()
    {
        this.minLength = 300f;
        this.maxLength = 4.591775E-41f;
        this.defaultPanelLength = 486f;
        this.hidingElems = new UnityEngine.GameObject[13];
        this.leftTopAnchorElems = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.一丝万丂丏丏且万丌 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.丂丕丒丑不三丑丁丒 = 2f;
        this.丙丏丟丒且上一且丞 = 3f;
        this.maxTimerShowScorePict = 3f;
        this.scorePictName = System.String.alignConst;
        this.scoreIconName = System.String.alignConst;
        this.speedAnimateHealth = 100f;
        this.<且业丂丁丘丝专丘丈>k__BackingField = true;
        this.scoreMessage = System.String.alignConst;
    }

}
