using UnityEngine;
public sealed class RespawnWindow : MonoBehaviour
{
    // Fields
    private static RespawnWindow 丝业丆丁业三丈丟东;
    public RespawnWindow_Healthbar healthbar;
    public RespawnWindowEquipmentItem armorItem;
    public RespawnWindowEquipmentItem bootsItem;
    public RespawnWindowEquipmentItem capeItem;
    public RespawnWindowEquipmentItem hatItem;
    public RespawnWindowEquipmentItem maskItem;
    public RespawnWindowEquipmentItem petItem;
    public RespawnWindowEquipmentItem gadgetToolsItem;
    public RespawnWindowEquipmentItem gadgetTrowingItem;
    public UnityEngine.GameObject nextPlayerButton;
    public UnityEngine.GameObject prevPlayerButton;
    public UnityEngine.GameObject wearPanel;
    public UnityEngine.GameObject showWearBtn;
    public UnityEngine.GameObject hideWearBtn;
    public UnityEngine.GameObject wearBtn;
    public UILabel autoRespawnTimerLabel;
    public UILabel canRespawnTimerLabel;
    public UILabel canRespawnTimerSniperLabel;
    public UILabel yourKillScoreLabel;
    public UILabel enemyKillScoreLabel;
    public UILabel autoRespawnTitleLabel;
    public UILabel canRespawnTitleLabel;
    public UILabel canRespawnTitleSniperLabel;
    public UnityEngine.GameObject cameraDrag;
    public UnityEngine.GameObject characterDrag;
    public CharacterView characterView;
    public UnityEngine.Camera characterViewCamera;
    public UnityEngine.GameObject characterViewHolder;
    public UITexture characterViewTexture;
    public UnityEngine.GameObject killCountContainer;
    public UnityEngine.GameObject goButtleContainer;
    public UnityEngine.GameObject headLabel;
    public UnityEngine.GameObject itemsContainer;
    public UITexture killerClanLogo;
    public UILabel killerClanNameLabel;
    public UILabel killerLevelNicknameLabel;
    public UITexture killerRank;
    private 专丟丗丛上丕丐丒丏 丏丕一丞丘丗万丒丏;
    public WeaponInfoInRespawnWindow killerWeapon;
    public WeaponInfoInRespawnWindow yourWeapon;
    public UIButton respawnButton;
    public UIButton respawnButtonNow;
    public UIButton changeClassButton;
    public UnityEngine.GameObject goLobbyBtn;
    public UnityEngine.AudioClip respawnBuySound;
    public UILabel respawnPriceLabel;
    internal int 丈上万丞丆丐一丑丌;
    private int 丂丑丂上丌三丄不不;
    public UnityEngine.GameObject winningBlue;
    public UnityEngine.GameObject winningRed;
    public Rilisoft.ButtonHandler goToLobby;
    private WeaponToggleModulesUI armorKillerModulesUI;
    private WeaponToggleModulesUI armorKillerModulesUIInHealthBar;
    private WeaponToggleModulesUI weaponKillerToggleModulesUi;
    private WeaponToggleModulesUI weaponYourToggleModulesUi;
    private UnityEngine.Transform _battlePassHolderRight;
    private UnityEngine.Transform _battlePassHolderCenter;
    private UnityEngine.Transform _pixelPassHolderCenter;
    private PGCompany.PixelPass.PixelPassTasksInGameUI 丈丟丂七丛丟三丛丝;
    private UnityEngine.Transform _clanwarTasksHolderCenter;
    private UnityEngine.Transform _cwHolderRight;
    private UnityEngine.GameObject _loadoutsButtonContainer;
    private UILabel _loadoutsButtonNumber;
    private UnityEngine.GameObject _loadoutsUi;
    private UnityEngine.GameObject respawnPointsPanelFreeplay;
    private ChallangeConnectSceneAbstract 世业丂丅丛丟且丆丕;
    private bool 丟丑丆业一丏丐万丟;
    private PGCompany.丗丟丄丈东丝丕丄世 丁万丗丕丁且丆三丘;
    private bool 丗丅丄丄且丞丑丞丘;
    private System.Action 业丁丒丘丐三专丏丕;
    private const int 下丐世一丟丛一业丛 = 1;
    private const int 丆丆丈丟东专丆一丆 = 2;
    private UnityEngine.Vector3 丆三丏丒不丘丙丌丛;
    public EventTournamentTipUI tournamentTipUi;
    internal bool 丅丗丌丅丐三丞丑万;
    private bool 丈丑丘丗一上丅东上;
    private bool 丞一丐丞丏丅不三与;
    private UnityEngine.GameObject killerNameMainObject;
    private Player_move_c 上丝丁东下万七且与;
    private System.Collections.Generic.List<Player_move_c> 东丏东上七一万丆丌;
    
    // Properties
    internal static RespawnWindow 丆丕丝丒不丙且丐丗 { get; }
    public bool 丁丞三七丌且丐丁丝 { get; }
    public bool 不万丗不三丝丛业丏 { get; }
    internal Player_move_c 丟丗丝丈丈丘丒东丈 { get; }
    internal static string 且丗丐丑不丗世丘丛 { get; }
    
    // Methods
    internal static RespawnWindow 丑七不且上丗丁一世()
    {
        null = null;
        return (RespawnWindow)RespawnWindow.丆丆丈丟东专丆一丆;
    }
    public bool get_isShown()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    public bool get_isCanClose()
    {
        if(this.canRespawnTitleSniperLabel.gameObject.activeSelf == true)
        {
                return false;
        }
        
        if(this.canRespawnTitleLabel.gameObject.activeSelf != false)
        {
                return false;
        }
        
        if(this.respawnButton == null)
        {
            
        }
    
    }
    private void Awake()
    {
        this.丟丑丆业一丏丐万丟 = PGCompany.丁东丌世与丕东丆上.七上丁丕东丝丈丆丙();
        if(this.respawnPointsPanelFreeplay == 0)
        {
                return;
        }
        
        this.respawnPointsPanelFreeplay.SetActive(value:  GameConnect.丝丆世丕丂丄万东且());
    }
    private void Update()
    {
        this.丛世丅丟丏东丕丌丁();
        if(this.丈丑丘丗一上丅东上 != false)
        {
                this.丒丝丄世东丄丗丞丛();
            return;
        }
        
        if(this.丏丕一丞丘丗万丒丏 == null)
        {
                return;
        }
        
        if(this.丏丕一丞丘丗万丒丏.丝万丘丂与丄不丑不 != false)
        {
                return;
        }
        
        this.丘丘三世丐丌一丛丗();
    }
    private void 丛世丅丟丏东丕丌丁()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        this.东丏东上七一万丆丌.Clear();
        val_8 = null;
        val_8 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count == 0)
        {
                return;
        }
        
        val_9 = 0;
        goto label_6;
        label_31:
        val_10 = null;
        val_10 = null;
        Player_move_c val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        if(val_2.万丝一万丐且丌业丛 != true)
        {
                val_11 = null;
            val_11 = null;
            Player_move_c val_3 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            UnityEngine.Vector3 val_4 = val_3.myPlayerTransform.position;
            if(val_4.y > (-5000f))
        {
                val_12 = null;
            val_12 = null;
            Player_move_c val_5 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_5.丟三丏丅世一丟丟上.一七不三丌专三丆一 != true)
        {
                val_13 = null;
            val_13 = null;
            this.东丏东上七一万丆丌.Add(item:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0]);
        }
        
        }
        
        }
        
        val_9 = 1;
        label_6:
        val_14 = null;
        val_14 = null;
        if(val_9 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_31;
        }
    
    }
    internal Player_move_c 且与上丙丗万且丅三()
    {
        return (Player_move_c)this.上丝丁东下万七且与;
    }
    private void 丏丛丈东丘丏丏下丁(bool 下下东且万业丞丅丒)
    {
        bool val_1 = 下下东且万业丞丅丒;
        this.nextPlayerButton.SetActive(value:  val_1);
        this.prevPlayerButton.SetActive(value:  val_1);
        bool val_3 = 下下东且万业丞丅丒;
        this.healthbar.gameObject.SetActive(value:  val_3);
        this.万丆丐丏丌丏丏丕丙(下下东且万业丞丅丒:  val_3);
    }
    private void 丞丆丒不上三丗丝丅()
    {
        var val_2;
        if(this.东丏东上七一万丆丌.Count <= 1)
        {
                val_2 = 0;
        }
        else
        {
                val_2 = 1;
        }
        
        this.丏丛丈东丘丏丏下丁(下下东且万业丞丅丒:  true);
    }
    private void 丒丝丄世东丄丗丞丛()
    {
        if(this.上丝丁东下万七且与 != 0)
        {
            goto label_3;
        }
        
        this.万丝丆丙下丏一丘与(丌丒丌丁丛丕专丗丝:  false);
        goto label_9;
        label_3:
        if(this.上丝丁东下万七且与.万丝一万丐且丌业丛 == true)
        {
            goto label_6;
        }
        
        UnityEngine.Vector3 val_2 = this.上丝丁东下万七且与.myPlayerTransform.position;
        if(val_2.y > (-5000f))
        {
            goto label_9;
        }
        
        label_6:
        this.上丝丁东下万七且与 = 0;
        label_9:
        if(this.上丝丁东下万七且与 != 0)
        {
                this.healthbar.丞不七丒业丂丅丛三(专丞上七七且丝七丗:  this.上丝丁东下万七且与);
            this.killerLevelNicknameLabel.text = this.上丝丁东下万七且与.丟三丏丅世一丟丟上.丂丈丐不丏万三七丐;
            this.killerClanNameLabel.text = this.上丝丁东下万七且与.丟三丏丅世一丟丟上.丐丆丒丅且丏世一与;
            this.killerClanNameLabel.丌丂丁万丂丛丌下七();
        }
        else
        {
                if(this.丞一丐丞丏丅不三与 != true)
        {
                this.丞一丐丞丏丅不三与 = true;
        }
        
        }
        
        this.丞丆丒不上三丗丝丅();
    }
    private void 万丝丆丙下丏一丘与(bool 丌丒丌丁丛丕专丗丝 = False)
    {
        System.Collections.Generic.List<Player_move_c> val_11;
        var val_12;
        bool val_11 = 丌丒丌丁丛丕专丗丝;
        val_11 = this.东丏东上七一万丆丌;
        if(val_11.Count == 0)
        {
                return;
        }
        
        if(this.上丝丁东下万七且与 == 0)
        {
            goto label_5;
        }
        
        val_12 = 0;
        goto label_6;
        label_12:
        if(this.上丝丁东下万七且与 == this.东丏东上七一万丆丌.Item[0])
        {
            goto label_10;
        }
        
        val_12 = 1;
        label_6:
        if(val_12 < this.东丏东上七一万丆丌.Count)
        {
            goto label_12;
        }
        
        label_5:
        label_17:
        val_11 = this.东丏东上七一万丆丌;
        this.上丝丁东下万七且与 = val_11.Item[0];
        this.丞一丐丞丏丅不三与 = false;
        return;
        label_10:
        var val_12 = 0;
        var val_7 = ((val_11 & true) != 0) ? (-val_12) : (val_12);
        val_11 = val_7 + val_12;
        int val_8 = this.东丏东上七一万丆丌.Count;
        if((val_11 & 2147483648) != 0)
        {
            goto label_15;
        }
        
        var val_9 = (val_11 < val_8) ? (val_11) : 0;
        goto label_17;
        label_15:
        val_12 = val_7 + val_8;
        int val_10 = val_12 + val_12;
        goto label_17;
    }
    public void HandleNextPlayerButton()
    {
        this.万丝丆丙下丏一丘与(丌丒丌丁丛丕专丗丝:  false);
    }
    public void HandleBackPlayerButton()
    {
        this.万丝丆丙下丏一丘与(丌丒丌丁丛丕专丗丝:  true);
    }
    private void 丘丘三世丐丌一丛丗()
    {
        UnityEngine.Object val_6;
        if(this.丞一丐丞丏丅不三与 != false)
        {
                return;
        }
        
        if(this.丏丕一丞丘丗万丒丏.丐丂上丛丁丄万丗万 != 0)
        {
                UnityEngine.Vector3 val_2 = this.丏丕一丞丘丗万丒丏.丐丂上丛丁丄万丗万.position;
            if(val_2.y > (-5000f))
        {
                return;
        }
        
        }
        
        val_6 = 0;
        if(this.丏丕一丞丘丗万丒丏.丐丂上丛丁丄万丗万 != 0)
        {
                val_6 = this.丏丕一丞丘丗万丒丏.丐丂上丛丁丄万丗万.GetComponent<SkinName>();
        }
        
        if(val_6 != 0)
        {
                if(val_4.playerMoveC.万丝一万丐且丌业丛 == false)
        {
                return;
        }
        
        }
        
        this.丞一丐丞丏丅不三与 = true;
        this.characterDrag.SetActive(value:  true);
        this.cameraDrag.SetActive(value:  false);
        this.东丕丞丂一上业丂丐(丝丞丛七且一丅丐丄:  this.丏丕一丞丘丗万丒丏);
    }
    private void Start()
    {
        var val_25;
        UnityEngine.Transform val_26;
        string val_27;
        float val_28;
        var val_29;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_30;
        var val_31;
        EventTournamentTipUI val_32;
        val_25 = 1152921504848912384;
        if(((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0) || ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝且丗丌丟丈世上万()) == null))
        {
            goto label_12;
        }
        
        PGCompany.ClanWarController val_5 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_5.万丅一丟丑丆世丞且 == null)
        {
            goto label_12;
        }
        
        System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean> val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.GetTaskInfo();
        if(0 != 0)
        {
            goto label_12;
        }
        
        PGCompany.ClanWarController val_8 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_8.万丅一丟丑丆世丞且.七一丈丁专丞丛丟丌() == false)
        {
            goto label_12;
        }
        
        val_26 = this._clanwarTasksHolderCenter;
        val_27 = "CWConnectScene";
        goto label_13;
        label_12:
        if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏() == false)
        {
            goto label_15;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._pixelPassHolderCenter, 丏业丟一东丂东丘丛:  true);
        if(this.丈丟丂七丛丟三丛丝 != 0)
        {
            goto label_21;
        }
        
        this.丈丟丂七丛丟三丛丝 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.丒丒一丕世丟三丂丌<PGCompany.PixelPass.PixelPassTasksInGameUI>(丄三下丙下世丅丘丙:  this._pixelPassHolderCenter, 丟丈一下东业一丝丆:  "PixelPassTasksInGame");
        goto label_21;
        label_15:
        val_26 = this._battlePassHolderCenter;
        val_27 = "BPConnectSceneMini";
        label_13:
        PGCompany.BattlePass.万丈上下三丅丘丛丒.一丝且不丅东丗丒丙(丁丕丗丝万万上丟丌:  val_26, 丟丈一下东业一丝丆:  val_27, 上一丈丕丙世东丅丅:  false);
        label_21:
        ChallangeConnectSceneAbstract val_14 = this._battlePassHolderCenter.GetComponentInChildren<ChallangeConnectSceneAbstract>();
        this.世业丂丅丛丟且丆丕 = val_14;
        if(val_14 == 0)
        {
            goto label_25;
        }
        
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        if(this.世业丂丅丛丟且丆丕 != null)
        {
                if(this.世业丂丅丛丟且丆丕 != null)
        {
            goto label_31;
        }
        
        }
        
        label_31:
        val_28 = val_16.x;
        0.transform.localPosition = new UnityEngine.Vector3() {x = val_28, y = val_16.y, z = val_16.z};
        label_25:
        val_29 = null;
        val_29 = null;
        val_30 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_30 != null)
        {
                val_30 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_30 == null)
        {
                val_30 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_18 = val_30.丌不丅不丞东万专专();
            if(1286394344 == 2)
        {
                if(this.tournamentTipUi != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tournamentTipUi, 丏业丟一东丂东丘丛:  true);
            val_31 = null;
            val_31 = null;
            this.tournamentTipUi.丒丅丕一东丘丙且丛(丛丂下丗丏丅丏丑丌:  GameConnect.丈丝丂丐丟万丙丑丕);
            UnityEngine.Vector3 val_20 = this._battlePassHolderCenter.localPosition;
            this.丆三丏丒不丘丙丌丛 = 0;
            mem[1152921540252992344] = 0;
            val_25 = this.tournamentTipUi.transform;
            val_25.SetParent(p:  this._battlePassHolderCenter);
            this.tournamentTipUi.transform.localPosition = new UnityEngine.Vector3() {x = this.丆三丏丒不丘丙丌丛, y = val_16.y, z = val_16.z};
            val_32 = this.tournamentTipUi.transform;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.one;
            val_28 = val_24.x;
            val_32.localScale = new UnityEngine.Vector3() {x = val_28, y = val_24.y, z = val_24.z};
            return;
        }
        
        }
        
        }
        
        val_32 = this.tournamentTipUi;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_32, 丏业丟一东丂东丘丛:  false);
    }
    public void SetRespawnButtonActive(bool 东丅丞丁丗万且丁丗, bool 丘丟东丙一专万业丟 = False)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 东丅丞丁丗万且丁丗;
        东丅丞丁丗万且丁丗 = val_4;
        if((val_4 != true) && (丘丟东丙一专万业丟 != false))
        {
                val_4 = 1152921505037303808;
            val_5 = null;
            val_5 = null;
            if(BalanceController.万丞丏丙下丐丟东丙 >= 1)
        {
                this.respawnButtonNow.gameObject.SetActive(value:  true);
            val_6 = null;
            val_6 = null;
            this.丂丑丂上丌三丄不不 = BalanceController.万丞丏丙下丐丟东丙;
            this.respawnPriceLabel.text = this.丂丑丂上丌三丄不不.ToString();
            return;
        }
        
        }
        
        this.respawnButtonNow.gameObject.SetActive(value:  false);
        this.丂丑丂上丌三丄不不 = 0;
    }
    internal void 丆不丁丒丗丆丛丐专(bool 丛与丙丒丒下丌丟且)
    {
        if(this.changeClassButton == 0)
        {
                return;
        }
        
        this.changeClassButton.gameObject.SetActive(value:  丛与丙丒丒下丌丟且);
    }
    private void 丌丂丁万丂丛丌下七()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 0;
        goto label_1;
        label_9:
        val_4 = null;
        val_4 = null;
        丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].万业丐丞业丝世东丕();
        val_3 = 1;
        label_1:
        val_5 = null;
        val_5 = null;
        if(val_3 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_9;
        }
    
    }
    internal void 下与丞三丅丛丄七丕(专丟丗丛上丕丐丒丏 丟丑丞世世世丅丂丒)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        专丟丗丛上丕丐丒丏 val_1 = new 专丟丗丛上丕丐丒丏();
        this.丏丕一丞丘丗万丒丏 = val_1;
        丟丑丞世世世丅丂丒.东丕世下丛业且丐丆(丝丞丛七且一丅丐丄:  val_1);
        this.killerLevelNicknameLabel.text = this.丏丕一丞丘丗万丒丏.丛三三与丁丘丄丑下;
        this.killerClanNameLabel.text = this.丏丕一丞丘丗万丒丏.专下不丘丘丝丅七三;
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                this.itemsContainer.SetActive(value:  false);
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                this.丑丆丈万且丐丐东与();
        }
        else
        {
                if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                val_19 = null;
            val_19 = null;
            val_20 = 且世专不丄丏七下万();
        }
        else
        {
                val_20 = 0;
        }
        
            bool val_6 = (val_20 == 0) ? 1 : 0;
            this.一且丌业丝世丑一且(丂丙业丐丅丛丒丘丁:  val_6);
            this.上丟丌三丐丂三丈丆(丝丞丛七且一丅丐丄:  this.丏丕一丞丘丗万丒丏, 丂丙业丐丅丛丒丘丁:  val_6);
            this.下下丅丈下七世七丄(丝丞丛七且一丅丐丄:  this.丏丕一丞丘丗万丒丏);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.healthbar.gameObject, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.丝万丘丂与丄不丑不 == false) ? 1 : 0);
        if(this.丏丕一丞丘丗万丒丏.丝万丘丂与丄不丑不 != true)
        {
                this.healthbar.丄丗世万世丛丒七丝(丝丞丛七且一丅丐丄:  this.丏丕一丞丘丗万丒丏);
        }
        
        val_21 = null;
        val_21 = null;
        if(ExperienceController.丞丞丘业东丙丏七丌() < BalanceController.丗与丆丝丈一七丄丙)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.wearBtn, 丏业丟一东丂东丘丛:  false);
            this.HideWearPanel();
        }
        else
        {
                this.ShowWearPanel();
        }
        
        val_22 = null;
        val_22 = null;
        与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 = true;
        this.gameObject.SetActive(value:  true);
        val_23 = null;
        val_23 = null;
        RespawnWindow.丆丆丈丟东专丆一丆 = this;
        this.丒丞丟丟丛丝丄与一();
        this.万丆丐丏丌丏丏丕丙(下下东且万业丞丅丒:  true);
        this.丌丂丁万丂丛丌下七();
        this.yourKillScoreLabel.text = this.丏丕一丞丘丗万丒丏.丘丅业世丘与丟世丗.ToString();
        this.enemyKillScoreLabel.text = this.丏丕一丞丘丗万丒丏.丅且丘万且东丏丄丑.ToString();
        this.characterDrag.SetActive(value:  false);
        this.cameraDrag.SetActive(value:  true);
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                this.goButtleContainer.SetActive(value:  false);
        }
        
        if((GameConnect.丅丟下专不丁一丈七() != true) && (GameConnect.七丂万专且丏丘一丙() != true))
        {
                if(this.goToLobby != 0)
        {
                this.goToLobby.gameObject.SetActive(value:  false);
        }
        
        }
        
        this.专丕丞丘丑丂丒世丝();
    }
    private void 一且丌业丝世丑一且(bool 丂丙业丐丅丛丒丘丁 = True)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.killerNameMainObject, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.丝万丘丂与丄不丑不 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.killerWeapon.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.yourWeapon.gameObject, 丏业丟一东丂东丘丛:  丂丙业丐丅丛丒丘丁);
    }
    private void 丑丆丈万且丐丐东与()
    {
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                this.killCountContainer.SetActive(value:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.killerNameMainObject, 丏业丟一东丂东丘丛:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.killerWeapon.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.yourWeapon.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 专丕丞丘丑丂丒世丝()
    {
        if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.wearPanel, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.七三东丒丁业万三与 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showWearBtn, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.七三东丒丁业万三与 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hideWearBtn, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.七三东丒丁业万三与 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.wearBtn, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.七三东丒丁业万三与 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.killerWeapon, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.七三东丒丁业万三与 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.healthbar, 丏业丟一东丂东丘丛:  (this.丏丕一丞丘丗万丒丏.七三东丒丁业万三与 == false) ? 1 : 0);
    }
    internal void 业丐丕上丈不世丕不()
    {
        var val_2;
        var val_3;
        this.丏丕一丞丘丗万丒丏 = 0;
        this.丈丑丘丗一上丅东上 = true;
        this.丏丛丈东丘丏丏下丁(下下东且万业丞丅丒:  false);
        this.killerLevelNicknameLabel.text = System.String.alignConst;
        this.killerClanNameLabel.text = System.String.alignConst;
        val_2 = null;
        val_2 = null;
        与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 = true;
        this.gameObject.SetActive(value:  true);
        val_3 = null;
        val_3 = null;
        RespawnWindow.丆丆丈丟东专丆一丆 = this;
        this.characterViewHolder.SetActive(value:  false);
        this.丒丞丟丟丛丝丄与一();
        this.万丆丐丏丌丏丏丕丙(下下东且万业丞丅丒:  false);
        this.丌丂丁万丂丛丌下七();
    }
    internal void 东丕丞丂一上业丂丐(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        string val_19;
        var val_20;
        UnityEngine.Texture val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        CharacterView val_27;
        var val_28;
        int val_29;
        if(this.丈丑丘丗一上丅东上 != false)
        {
                return;
        }
        
        if((GameConnect.与不丗丏万丙丞丌丑() != false) && (丝丞丛七且一丅丐丄.丝万丘丂与丄不丑不 != false))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.healthbar, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        this.characterView.丟一一专不丙丄丒东(丙业与丙丗丝不丈东:  true);
        this.characterView.ShowCharacterType(丞不丁丒丙与丐丏丁:  0);
        this.characterView.ResetForRespawnWindow();
        if(丝丞丛七且一丅丐丄 != null)
        {
                val_19 = 丝丞丛七且一丅丐丄.丌丝下丄业一丄不三;
            val_20 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        }
        else
        {
                val_19 = 0;
            val_20 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        }
        
        val_21 = 丝丞丛七且一丅丐丄.丞与丌丌丗不丝业世;
        this.characterView.一三上三丆丂东丟三(三不三丟专丘东东丂:  val_19, 丅专丕三且丑丘专下:  val_20.一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  丝丞丛七且一丅丐丄.东丈一且丟丆丆七东), 丐万三丘东丌丝丗下:  val_21, 七一丐上丙丂丑丅丁:  丝丞丛七且一丅丐丄.七一丐上丙丂丑丅丁, 下且丆且丂七丛与一:  true);
        if(((System.String.IsNullOrEmpty(value:  丝丞丛七且一丅丐丄.上丈专丌万丕丙万丘)) == true) || (丝丞丛七且一丅丐丄.世丟丘丞丌丁丙丕丕 == false))
        {
            goto label_17;
        }
        
        val_22 = null;
        val_22 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_20;
        }
        
        label_17:
        this.characterView.RemoveHat();
        label_72:
        if(((System.String.IsNullOrEmpty(value:  丝丞丛七且一丅丐丄.丈丐丕业下丟业丛一)) == true) || (丝丞丛七且一丅丐丄.丒丕丄丆专丂丛丙万 == false))
        {
            goto label_23;
        }
        
        val_23 = null;
        val_23 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_26;
        }
        
        label_23:
        this.characterView.RemoveCape();
        label_74:
        if(((System.String.IsNullOrEmpty(value:  丝丞丛七且一丅丐丄.丟世丟丐且丐丟七上)) == true) || (丝丞丛七且一丅丐丄.丕七丟三丗三丐业丁 == false))
        {
            goto label_29;
        }
        
        val_24 = null;
        val_24 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_32;
        }
        
        label_29:
        this.characterView.RemoveMask();
        label_76:
        if(((System.String.IsNullOrEmpty(value:  丝丞丛七且一丅丐丄.且与丛专丗丞丑丑丝)) == true) || (丝丞丛七且一丅丐丄.丛丑上一丗丒丘丗丈 == false))
        {
            goto label_35;
        }
        
        val_25 = null;
        val_25 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_38;
        }
        
        label_35:
        this.characterView.RemoveBoots();
        label_78:
        val_26 = null;
        val_26 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 != 0)
        {
                if(null != 0)
        {
            goto label_47;
        }
        
        }
        else
        {
                val_27 = 0;
        }
        
        label_47:
        val_28 = null;
        val_28 = null;
        val_29 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_29 == 0)
        {
            goto label_63;
        }
        
        val_29 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_29 != 1)
        {
            goto label_53;
        }
        
        val_21 = GameConnect.丑丌丛丈丅丅与不业();
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  val_21, 丞丁丑丏丄丏七丂不:  0)) == true)
        {
            goto label_63;
        }
        
        val_27 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if((val_27.丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) == true)
        {
            goto label_63;
        }
        
        label_53:
        if(((System.String.IsNullOrEmpty(value:  丝丞丛七且一丅丐丄.与丙丕丛一丌丛丆丈)) == true) || (丝丞丛七且一丅丐丄.丏丘丕丌万丆丒丏东 == false))
        {
            goto label_63;
        }
        
        val_27 = this.characterView;
        val_27.UpdateArmor(与丙丕丛一丌丛丆丈:  丝丞丛七且一丅丐丄.与丙丕丛一丌丛丆丈);
        goto label_65;
        label_63:
        this.characterView.RemoveArmor();
        label_65:
        this.characterViewCamera.gameObject.SetActive(value:  true);
        this.characterView.gameObject.SetActive(value:  true);
        this.万丆丐丏丌丏丏丕丙(下下东且万业丞丅丒:  true);
        return;
        label_20:
        this.characterView.UpdateHat(上丈专丌万丕丙万丘:  丝丞丛七且一丅丐丄.上丈专丌万丕丙万丘, 丅丞七丟丘丆丟丘丞:  true);
        goto label_72;
        label_26:
        this.characterView.UpdateCape(丈丐丕业下丟业丛一:  丝丞丛七且一丅丐丄.丈丐丕业下丟业丛一, 下万东丕丏丟丟丝丗:  丝丞丛七且一丅丐丄.下万东丕丏丟丟丝丗, 丅丞七丟丘丆丟丘丞:  true);
        goto label_74;
        label_32:
        this.characterView.UpdateMask(丟世丟丐且丐丟七上:  丝丞丛七且一丅丐丄.丟世丟丐且丐丟七上, 丅丞七丟丘丆丟丘丞:  true);
        goto label_76;
        label_38:
        this.characterView.UpdateBoots(上世丘丐东万丐丆不:  丝丞丛七且一丅丐丄.且与丛专丗丞丑丑丝, 丅丞七丟丘丆丟丘丞:  true);
        goto label_78;
    }
    public void ShowWearPanel()
    {
        var val_16;
        var val_17;
        float val_18;
        val_16 = this;
        this.wearPanel.SetActive(value:  true);
        this.showWearBtn.SetActive(value:  false);
        this.hideWearBtn.SetActive(value:  true);
        if(this.世业丂丅丛丟且丆丕 != 0)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            if(this.世业丂丅丛丟且丆丕 != null)
        {
                val_17 = this.世业丂丅丛丟且丆丕.transform;
            val_17.SetParent(p:  this._cwHolderRight);
        }
        else
        {
                val_17 = this.世业丂丅丛丟且丆丕.transform;
            val_17.SetParent(p:  this._battlePassHolderRight);
        }
        
            this.世业丂丅丛丟且丆丕.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_18 = val_7.x;
            this.世业丂丅丛丟且丆丕.transform.localScale = new UnityEngine.Vector3() {x = val_18, y = val_7.y, z = val_7.z};
        }
        
        if(this.tournamentTipUi == 0)
        {
                return;
        }
        
        if(this.tournamentTipUi.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_17 = this.tournamentTipUi.transform;
        val_17.SetParent(p:  this._battlePassHolderRight);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        this.tournamentTipUi.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        val_16 = this.tournamentTipUi.transform;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        val_18 = val_15.x;
        val_16.localScale = new UnityEngine.Vector3() {x = val_18, y = val_15.y, z = val_15.z};
    }
    public void HideWearPanel()
    {
        var val_14;
        var val_15;
        float val_16;
        val_14 = this;
        this.wearPanel.SetActive(value:  false);
        this.showWearBtn.SetActive(value:  true);
        this.hideWearBtn.SetActive(value:  false);
        if(this.世业丂丅丛丟且丆丕 == 0)
        {
            goto label_6;
        }
        
        this.世业丂丅丛丟且丆丕.transform.SetParent(p:  this._battlePassHolderCenter);
        val_15 = 1152921504838316032;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        if(this.世业丂丅丛丟且丆丕 == null)
        {
            goto label_11;
        }
        
        if(this.世业丂丅丛丟且丆丕 != null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        0.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        val_16 = val_6.x;
        this.世业丂丅丛丟且丆丕.transform.localScale = new UnityEngine.Vector3() {x = val_16, y = val_6.y, z = val_6.z};
        label_6:
        if(this.tournamentTipUi == 0)
        {
                return;
        }
        
        if(this.tournamentTipUi.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_15 = this.tournamentTipUi.transform;
        val_15.SetParent(p:  this._battlePassHolderCenter);
        this.tournamentTipUi.transform.localPosition = new UnityEngine.Vector3() {x = this.丆三丏丒不丘丙丌丛, y = val_6.y, z = val_6.z};
        val_14 = this.tournamentTipUi.transform;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        val_16 = val_13.x;
        val_14.localScale = new UnityEngine.Vector3() {x = val_16, y = val_13.y, z = val_13.z};
    }
    public void CloseRespawnWindow()
    {
        RespawnWindow val_13;
        UnityEngine.GameObject val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_13 = this;
        val_14 = 1152921504848912384;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 != 0)
        {
                WorldPosIndicationsController.丄丘七三上丕世丞业.ShowItems();
        }
        
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                val_15 = null;
            val_15 = null;
            if(丘万丈丒下丕且东丁() == false)
        {
                return;
        }
        
        }
        
        if((GameConnect.丟丆丏上丌一丝丟业() != false) && (this.丂丑丂上丌三丄不不 >= 1))
        {
                .丝且与丝丒丟万丁专 = val_13;
            val_16 = null;
            val_16 = null;
            .世丞丒丛一上万万且 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  this.丂丑丂上丌三丄不不, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
            val_13 = (RespawnWindow.丗丟且丘丙三丏且专)[1152921540255831056].世丞丒丛一上万万且;
            val_14 = this.gameObject;
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_14, 丒世丘丘上丆丝东丞:  val_13, 七丒上且丝业业下七:  new System.Action(object:  new RespawnWindow.丗丟且丘丙三丏且专(), method:  System.Void RespawnWindow.丗丟且丘丙三丏且专::丏丒东七丏业丘丂丕()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  93);
            return;
        }
        
        bool val_9 = GameConnect.丄丏丒丏上东业丒一();
        if(val_9 == false)
        {
            goto label_38;
        }
        
        val_17 = null;
        val_17 = null;
        if(MutationController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_38;
        }
        
        val_18 = null;
        val_18 = null;
        if(MutationController.丆丕丝丒不丙且丐丗.上世上丏丛丛丆丘丟() == true)
        {
            goto label_41;
        }
        
        val_19 = null;
        val_19 = null;
        if(与丆东世一丆丕丛丘() == false)
        {
            goto label_38;
        }
        
        0.专三丟三且下丅丂丄(丄丈且丂丕丐丅丐七:  true);
        goto label_41;
        label_38:
        val_9.丝丟丑丐专丁丁七丑();
        label_41:
        this.Hide();
    }
    public void SetCurrentTime(float 丒丑丏与丄丈丄丌丝)
    {
        UILabel val_7;
        this.autoRespawnTitleLabel.gameObject.SetActive(value:  true);
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_5;
        }
        
        val_7 = this.canRespawnTitleSniperLabel;
        if(val_7 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_5:
        val_7 = this.canRespawnTitleLabel;
        if(val_7 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        val_7.gameObject.SetActive(value:  false);
        this.autoRespawnTimerLabel.text = UnityEngine.Mathf.CeilToInt(f:  UnityEngine.Mathf.Max(a:  0f, b:  丒丑丏与丄丈丄丌丝)).ToString();
    }
    public void SetCanRespawnTime(float 丒丑丏与丄丈丄丌丝)
    {
        var val_27;
        int val_28;
        float val_30;
        var val_31;
        var val_32;
        var val_33;
        UnityEngine.GameObject val_34;
        this.autoRespawnTitleLabel.gameObject.SetActive(value:  false);
        this.丈上万丞丆丐一丑丌 = UnityEngine.Mathf.RoundToInt(f:  丒丑丏与丄丈丄丌丝);
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_7;
        }
        
        val_27 = null;
        val_27 = null;
        val_28 = SiegeController.三三万丆下一丗万丛;
        if(val_28.inAttackTeam == false)
        {
            goto label_11;
        }
        
        label_7:
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_14;
        }
        
        一丌与且丘丐上且丞 val_9 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().丛下丑丅丒丙丒丅丞();
        goto label_16;
        label_14:
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_19;
        }
        
        label_16:
        val_28 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().万丟丒三丝丛丆丁丙();
        val_30 = val_12.丂丝丌丞丄万不丝丝;
        goto label_47;
        label_11:
        val_28 = 1152921505171275776;
        val_31 = null;
        val_31 = null;
        label_50:
        val_30 = (float)与丂丏丛丞丞丒丟丄.丑三丁丑丐东万丟丟;
        goto label_47;
        label_19:
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_28;
        }
        
        val_30 = 5f;
        goto label_47;
        label_28:
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_32;
        }
        
        val_28 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        val_30 = val_28.myRespawnCooldown;
        goto label_47;
        label_32:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_37;
        }
        
        val_32 = null;
        val_32 = null;
        val_28 = MutationController.丆丕丝丒不丙且丐丗;
        val_30 = (float)MutationController.丆丕丝丒不丙且丐丗.丝丐上丘丟且丗一不;
        goto label_47;
        label_37:
        val_28 = GameConnect.丑丌丛丈丅丅与不业();
        val_30 = 与丂丏丛丞丞丒丟丄.丄丒丏三丞丄丈丂丗(上且丗一丏丏万丅丌:  val_28);
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_19 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if((val_19 == null) || ((val_19.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom")) != 100))
        {
            goto label_47;
        }
        
        val_33 = null;
        val_33 = null;
        goto label_50;
        label_47:
        if(val_30 >= 0)
        {
            goto label_51;
        }
        
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_54;
        }
        
        if(this.canRespawnTitleSniperLabel != null)
        {
            goto label_66;
        }
        
        label_67:
        label_66:
        val_34 = this.canRespawnTitleSniperLabel.gameObject;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_34, 丏业丟一东丂东丘丛:  false);
        return;
        label_51:
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_61;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.canRespawnTitleSniperLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        val_34 = this.canRespawnTimerSniperLabel;
        goto label_65;
        label_54:
        if(this.canRespawnTitleLabel != null)
        {
            goto label_66;
        }
        
        goto label_67;
        label_61:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.canRespawnTitleLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        val_34 = this.canRespawnTimerLabel;
        label_65:
        val_34.text = UnityEngine.Mathf.CeilToInt(f:  UnityEngine.Mathf.Max(a:  0f, b:  丒丑丏与丄丈丄丌丝)).ToString();
    }
    private void 丝丟丑丐专丁丁七丑()
    {
        null = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        丝丟丑丐专丁丁七丑();
    }
    public void Hide()
    {
        var val_3;
        var val_4;
        this.gameObject.SetActive(value:  false);
        this.characterViewHolder.SetActive(value:  false);
        this.characterView.gameObject.SetActive(value:  false);
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  23);
        this.Reset();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadoutsUi, 丏业丟一东丂东丘丛:  false);
        val_3 = null;
        val_3 = null;
        与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 = false;
        val_4 = null;
        val_4 = null;
        RespawnWindow.丆丆丈丟东专丆一丆 = 0;
        RespawnWindow.丆丆丈丟东专丆一丆.__il2cppRuntimeField_3 = 0;
        丌丂丁万丂丛丌下七();
    }
    public void OnBtnChoiceCharacterClick()
    {
        0.专三丟三且下丅丂丄(丄丈且丂丕丐丅丐七:  false);
    }
    public void OnBtnGoBattleClick()
    {
        this.CloseRespawnWindow();
    }
    public void OnBtnGoToLobbyClick()
    {
        if(GameController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
    }
    private void 下下丅丈下七世七丄(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        string val_19;
        string val_20;
        string val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        int val_26;
        专丟丗丛上丕丐丒丏 val_27;
        if(丝丞丛七且一丅丐丄 != null)
        {
                val_19 = 丝丞丛七且一丅丐丄;
            val_20 = 丝丞丛七且一丅丐丄.上丈专丌万丕丙万丘;
            val_21 = val_20;
        }
        else
        {
                val_19 = 120;
            val_21 = 1;
            val_20 = 1;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_20)) == false)
        {
            goto label_5;
        }
        
        val_22 = 6;
        if(this.hatItem != null)
        {
            goto label_11;
        }
        
        goto label_7;
        label_5:
        if(this.hatItem != null)
        {
            goto label_11;
        }
        
        label_7:
        label_11:
        this.hatItem.SetItemTag(丕丁下丌不万丅丞丛:  val_21, 业丈世与下丘丛丐且:  ((丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  val_19)) != true) ? 180000 : 6);
        this.maskItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.丟世丟丐且丐丟七上, 业丈世与下丘丛丐且:  12);
        val_23 = null;
        val_23 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 != 0)
        {
                if(null != 0)
        {
            goto label_21;
        }
        
        }
        else
        {
                val_24 = 0;
        }
        
        label_21:
        val_25 = null;
        val_25 = null;
        val_26 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_26 == 0)
        {
            goto label_31;
        }
        
        val_26 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_26 != 1)
        {
            goto label_35;
        }
        
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0)) != true)
        {
                if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) == false)
        {
            goto label_35;
        }
        
        }
        
        label_31:
        val_27 = this.丏丕一丞丘丗万丒丏;
        if((this.丏丕一丞丘丗万丒丏.丏丄三三丝丁丅一七 != null) && ((mem[this.丏丕一丞丘丗万丒丏] + 264 + 24) != 0))
        {
                this.armorItem.modules.不丙丘丄与丞丄七丄(丌丄丁丕丆丄下丂丛:  mem[this.丏丕一丞丘丗万丒丏] + 264);
        }
        
        this.armorItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.丗丞一上世丄七不与, 业丈世与下丘丛丐且:  7);
        goto label_45;
        label_35:
        this.armorItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.丗丞一上世丄七不与, 业丈世与下丘丛丐且:  7);
        val_27 = this.丏丕一丞丘丗万丒丏;
        label_45:
        this.armorKillerModulesUI.不丙丘丄与丞丄七丄(丌丄丁丕丆丄下丂丛:  this.丏丕一丞丘丗万丒丏.丏丄三三丝丁丅一七);
        this.armorKillerModulesUIInHealthBar.不丙丘丄与丞丄七丄(丌丄丁丕丆丄下丂丛:  this.丏丕一丞丘丗万丒丏.丏丄三三丝丁丅一七);
        this.weaponKillerToggleModulesUi.不丙丘丄与丞丄七丄(丌丄丁丕丆丄下丂丛:  this.丏丕一丞丘丗万丒丏.丌丄丁丕丆丄下丂丛);
        this.capeItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.丈丐丕业下丟业丛一, 业丈世与下丘丛丐且:  9);
        this.bootsItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.且与丛专丗丞丑丑丝, 业丈世与下丘丛丐且:  10);
        this.petItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.上东丞世三世且丈丌, 业丈世与下丘丛丐且:  168);
        this.gadgetTrowingItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.丂丙丗且世一专丅东, 业丈世与下丘丛丐且:  212);
        this.gadgetToolsItem.SetItemTag(丕丁下丌不万丅丞丛:  丝丞丛七且一丅丐丄.丒万丁丈丐业不世丛, 业丈世与下丘丛丐且:  200);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.armorItem.gameObject, 丏业丟一东丂东丘丛:  ((mem[this.丏丕一丞丘丗万丒丏] + 16) == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.petItem.gameObject, 丏业丟一东丂东丘丛:  ((mem[this.丏丕一丞丘丗万丒丏] + 16) == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetTrowingItem.gameObject, 丏业丟一东丂东丘丛:  ((mem[this.丏丕一丞丘丗万丒丏] + 16) == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetToolsItem.gameObject, 丏业丟一东丂东丘丛:  ((mem[this.丏丕一丞丘丗万丒丏] + 16) == 0) ? 1 : 0);
    }
    private void 上丟丌三丐丂三丈丆(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄, bool 丂丙业丐丅丛丒丘丁 = True)
    {
        专丟丗丛上丕丐丒丏 val_36;
        RespawnWindow val_37;
        var val_38;
        var val_39;
        float val_41;
        var val_42;
        int val_43;
        PGCompany.丗丟丄丈东丝丕丄世 val_44;
        PGCompany.丗丟丄丈东丝丕丄世 val_45;
        var val_46;
        丕丑丙丑丙东丌丘丕 val_47;
        string val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_53;
        float val_54;
        var val_55;
        System.Exception val_56;
        System.Exception val_57;
        val_36 = 丝丞丛七且一丅丐丄;
        val_37 = this;
        RespawnWindow.丘丒丘世万丁且下丈 val_1 = new RespawnWindow.丘丒丘世万丁且下丈();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_38 = val_1;
        .丂丙业丐丅丛丒丘丁 = 丂丙业丐丅丛丒丘丁;
        val_39 = 1152921540257902216;
        mem[1152921540257902184] = val_37;
        mem[1152921540257902200] = val_36;
        if(val_36 != null)
        {
            goto label_2;
        }
        
        return;
        label_1:
        mem[24] = val_37;
        val_39 = 40;
        mem[40] = val_36;
        val_38 = 56;
        mem[56] = 丂丙业丐丅丛丒丘丁;
        val_36 = mem[40];
        if(val_36 == 0)
        {
                return;
        }
        
        label_2:
        val_41 = BalanceController.丄业世丘一丌三丕丝(业一丝丘专丐上与七:  0, 丏丆丐丑专与丄丘丞:  5);
        if(val_1 != null)
        {
                .丕丗丆丒丄丂丁丈丞 = val_41;
            val_42 = 1152921540257902212;
            mem[1152921540257902208] = -1082130432;
        }
        else
        {
                .丕丗丆丒丄丂丁丈丞 = val_41;
            val_42 = 48;
            mem[48] = -1082130432;
        }
        
        if((((丝丞丛七且一丅丐丄 + 248) & 2147483648) != 0) || (((丝丞丛七且一丅丐丄 + 252) & 2147483648) != 0))
        {
            goto label_13;
        }
        
        if((丝丞丛七且一丅丐丄 + 288) == 0)
        {
            goto label_16;
        }
        
        if(val_1 != null)
        {
            goto label_84;
        }
        
        label_85:
        label_84:
        val_41 = BalanceController.丄业世丘一丌三丕丝(业一丝丘专丐上与七:  0, 丏丆丐丑专与丄丘丞:  丝丞丛七且一丅丐丄 + 252);
        mem[48] = val_41;
        label_13:
        if(val_1 != null)
        {
                .丝七丆且丝丐七一丆 = -1f;
            val_43 = System.String.alignConst;
        }
        else
        {
                .丝七丆且丝丐七一丆 = -1f;
            val_43 = System.String.alignConst;
        }
        
        .丝业丄下丙业三丙丛 = val_43;
        new RespawnWindow.丄七东丂三丂世丁东() = new System.Object();
        .东丟且丗且三专丙丁 = val_1;
        this.丁万丗丕丁且丆三丘 = 0;
        if(((GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  7)) == null) && (this.丟丑丆业一丏丐万丟 != false))
        {
                val_44 = this.yourWeapon.promoUpgrade.丐丙丞丑专丝万丌东();
            this.丁万丗丕丁且丆三丘 = val_44;
        }
        else
        {
                val_44 = this.丁万丗丕丁且丆三丘;
        }
        
        val_45 = val_44;
        if(val_44 != null)
        {
            goto label_32;
        }
        
        val_46 = null;
        val_46 = null;
        三丈丟与丏丘丈丐万 val_11 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        val_45 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_11.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛());
        this.丁万丗丕丁且丆三丘 = val_45;
        if(val_45 == null)
        {
            goto label_41;
        }
        
        label_32:
        if(null == null)
        {
            goto label_42;
        }
        
        label_41:
        .丌丝下丄业一丄不三 = 0;
        .丈三丘丌丈且万东丗 = 0;
        goto label_44;
        label_42:
        .丌丝下丄业一丄不三 = val_45;
        .丈三丘丌丈且万东丗 = 0;
        if(val_45 != null)
        {
                val_47 = val_45.丐上下三丑丈丑丄丟().七丑丌专丒上丒丙七();
            if(val_47 == null)
        {
                val_47 = new 丕丑丙丑丙东丌丘丕();
            val_47 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  (RespawnWindow.丄七东丂三丂世丁东)[1152921540257906256].丌丝下丄业一丄不三.丐上下三丑丈丑丄丟().七丙丛与万且专三三(), 丏丆丐丑专与丄丘丞:  (RespawnWindow.丄七东丂三丂世丁东)[1152921540257906256].丌丝下丄业一丄不三);
            val_42 = val_42;
            val_38 = val_38;
        }
        
            .丈三丘丌丈且万东丗 = val_47;
            val_41 = BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(), 专东丑丑丁丞丛三丗:  false);
            (RespawnWindow.丄七东丂三丂世丁东)[1152921540257906256].东丟且丗且三专丙丁.丝七丆且丝丐七一丆 = val_41;
        }
        
        label_44:
        val_48 = this.丁万丗丕丁且丆三丘.业上丙丞丐丄丆丅七();
        (RespawnWindow.丄七东丂三丂世丁东)[1152921540257906256].东丟且丗且三专丙丁.丝业丄下丙业三丙丛 = val_48;
        if(val_44 == null)
        {
            goto label_55;
        }
        
        if(this.丁万丗丕丁且丆三丘 == null)
        {
            goto label_58;
        }
        
        val_49 = val_42;
        if(this.丁万丗丕丁且丆三丘 != null)
        {
            goto label_59;
        }
        
        val_50 = val_49;
        label_58:
        val_49 = val_50;
        label_59:
        val_51 = null;
        if(this.丁万丗丕丁且丆三丘 == null)
        {
            goto label_86;
        }
        
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_51 = null;
        this.丗丅丄丄且丞丑丞丘 = ((ExperienceController.丞丞丘业东丙丏七丌() - this.丁万丗丕丁且丆三丘.丁丕丁三丁丗不三丟()) > 1) ? 1 : 0;
        val_48 = new System.Action();
        val_48 = new System.Action(object:  new RespawnWindow.丄七东丂三丂世丁东(), method:  System.Void RespawnWindow.丄七东丂三丂世丁东::丄丌万且且一丈不丘());
        val_53 = val_49;
        this.业丁丒丘丐三专丏丕 = val_48;
        val_38 = val_38;
        label_55:
        if(GameConnect.东丒七专丂世丝丏丗() != false)
        {
                if((丝丞丛七且一丅丐丄 + 17) != 0)
        {
            goto label_70;
        }
        
        }
        
        if(val_1 != null)
        {
                val_48 = mem[40];
            val_54 = mem[3212836864];
        }
        else
        {
                val_48 = mem[40];
            val_41 = mem[48];
            val_54 = mem[3212836864];
        }
        
        this.killerWeapon.丁业丑丂丘不丏世丑(丝丞丛七且一丅丐丄:  val_48, 专丘专丟丏丏丁丝丁:  val_41, 且东业丆丁业万七与:  val_54, 丕丗丆丒丄丂丁丈丞:  .丕丗丆丒丄丂丁丈丞);
        label_70:
        if(val_38 != false)
        {
                val_48 = this.yourWeapon;
            val_41 = mem[48];
            val_48.丕东丑丞与丆上与丈(下丅丙一丂丗丅丝七:  this.丁万丗丕丁且丆三丘, 且东业丆丁业万七与:  val_41, 上一丁丑上丈丕丏丑:  (val_44 != 0) ? 1 : 0, 丟丕丙丙丕丄下丄丐:  (this.丗丅丄丄且丞丑丞丘 == true) ? 1 : 0, 万丒丐丛丝丐丞丄丐:  false);
        }
        
        val_36 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
        PGCompany.丗丟丅七东丄丙丟上 val_33 = val_36.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  (RespawnWindow.丘丒丘世万丁且下丈)[1152921540257902160].丝业丄下丙业三丙丛);
        if(val_33 == null)
        {
                return;
        }
        
        val_37 = this.weaponYourToggleModulesUi;
        val_37.不丙丘丄与丞丄七丄(丌丄丁丕丆丄下丂丛:  val_33.丟且丘丗七且下三专());
        return;
        label_16:
        if(val_1 != null)
        {
            goto label_84;
        }
        
        goto label_85;
        label_86:
        val_55 = 0;
        val_56 = X0;
        if( == 1)
        {
                val_57 = ;
            if((null & 1) != 0)
        {
                System.Exception val_36 = null;
            val_57 = val_36;
            val_36 = new System.Exception(message:  "Exception during choosing item to upgrade promote", innerException:  val_57);
        }
        
            mem[8] = null;
            val_56 = 8;
        }
    
    }
    private void 丞且丂与东丐东专下()
    {
        var val_31;
        var val_32;
        var val_33;
        PGCompany.丗丟丄丈东丝丕丄世 val_34;
        string val_35;
        int val_2 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.丁万丗丕丁且丆三丘.业上丙丞丐丄丆丅七());
        丈丞丕丘丕丗与上一 val_5 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  val_2, 丞一丁业丄一一业且:  this.丁万丗丕丁且丆三丘.业上丙丞丐丄丆丅七(), 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  (this.丗丅丄丄且丞丑丞丘 == true) ? 1 : 0, 丗业丕七且丝丆丝丘:  false);
        if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_5.东与三丌丅三丒丏业())) != false) && (val_5.丟丂丞不专丆万丒世() >= 1))
        {
                val_31 = null;
            val_31 = null;
            if((val_5.东与三丌丅三丒丏业().Equals(value:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
        {
                if(val_5.丟丂丞不专丆万丒世() > Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌())
        {
            goto label_22;
        }
        
        }
        
        }
        
        val_32 = null;
        val_32 = null;
        if(((val_5.东与三丌丅三丒丏业().Equals(value:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false) || (val_5.丟丂丞不专丆万丒世() <= Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且()))
        {
            goto label_32;
        }
        
        label_22:
        val_33 = 0;
        val_34 = this.丁万丗丕丁且丆三丘;
        if(this.丁万丗丕丁且丆三丘.不业丙丒丂丞下丆丙() != 10)
        {
            goto label_34;
        }
        
        if(val_34 == null)
        {
            goto label_35;
        }
        
        val_33 = null;
        if(null == val_33)
        {
            goto label_38;
        }
        
        val_33 = 0;
        val_34 = 0;
        goto label_38;
        label_34:
        val_35 = val_34.不业丙丒丂丞下丆丙().ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_42;
        label_35:
        label_38:
        val_35 = val_34.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_42:
        PGCompany.Analytics.一业丗丆世世上丁且.丕三丘丕且丐丙丂业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丐丅专且专七三丆:  2, 下丅丙一丂丗丅丝七:  this.丁万丗丕丁且丆三丘.业上丙丞丐丄丆丅七(), 与丄不丌一世东丁丙:  val_35);
        label_32:
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  0, 丒世丘丘上丆丝东丞:  val_5, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void RespawnWindow::丈丛丆丂业且丟三丒()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  this, method:  System.Void RespawnWindow::丏与世丑丄丘丄世丁()), 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  this.丁万丗丕丁且丆三丘.业上丙丞丐丄丆丅七(), 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  上丑三丁丄丛丁万丑.丄丁丗下不丘丝丁不(丄丕与丈万丂上万丁:  上丑三丁丄丛丁万丑.丑丝丏下丁丞丌丒丂(丈丁丐丌三丟与一丕:  val_2, 不丟丞丑丛丆丁东与:  true, 万丟丝下丟丏丑丕丐:  false)));
        this.丟丑丆业一丏丐万丟 = false;
    }
    public void U_HandleUpgradePressed()
    {
        this.丞且丂与东丐东专下();
    }
    private void 不专丆万一丆丅丌丏(bool 丆丕与三丝丙丑丛三)
    {
    
    }
    private void 丈下下世丌丑东三丐(System.Collections.Generic.List<string> 下丟与东七丂丐且七)
    {
        var val_2 = null;
        if((RespawnWindow.<>c.<>9__124_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        下丟与东七丂丐且七.Sort(comparison:  RespawnWindow.<>c.<>9__124_0);
        return;
        label_3:
        RespawnWindow.<>c.<>9__124_0 = new System.Comparison<System.String>(object:  RespawnWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RespawnWindow.<>c::丅丙丈一不万丘丙世(string 万万丘与世不丆丅东, string 丗业专丄丒世丙丄丛));
        if(下丟与东七丂丐且七 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void 万丆丐丏丌丏丏丕丙(bool 下下东且万业丞丅丒)
    {
        this.killerLevelNicknameLabel.gameObject.SetActive(value:  下下东且万业丞丅丒);
        this.killerClanNameLabel.gameObject.SetActive(value:  下下东且万业丞丅丒);
        this.killerClanLogo.gameObject.SetActive(value:  下下东且万业丞丅丒);
    }
    private void Reset()
    {
        this.丏丕一丞丘丗万丒丏 = 0;
        this.丞一丐丞丏丅不三与 = false;
        this.上丝丁东下万七且与 = 0;
        if(this.丈丑丘丗一上丅东上 != false)
        {
                return;
        }
        
        this.hatItem.ResetImage();
        this.maskItem.ResetImage();
        this.armorItem.ResetImage();
        this.capeItem.ResetImage();
        this.bootsItem.ResetImage();
        this.petItem.ResetImage();
        this.gadgetTrowingItem.ResetImage();
        this.gadgetToolsItem.ResetImage();
    }
    private void 不业丕丕丌一不丄丐()
    {
    
    }
    private void OnEnable()
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 != true)
        {
                this.gameObject.SetActive(value:  false);
        }
        
        Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().七业万且丐丐丛丝与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RespawnWindow::丅且业丐丅丈丐上丛()));
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
                return;
        }
        
        this.丑丆丈万且丐丐东与();
    }
    private void 丅且业丐丅丈丐上丛()
    {
        this.丒丞丟丟丛丝丄与一();
    }
    private void OnDisable()
    {
        if(this.yourWeapon != 0)
        {
                if(this.yourWeapon.promoUpgrade != 0)
        {
                this.yourWeapon.promoUpgrade.不丞三丁丘丐一丘丆(丑丒业丘丑东丕世丅:  false);
        }
        
        }
        
        Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丗业丞丗丏丟业丟专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RespawnWindow::丅且业丐丅丈丐上丛()));
    }
    internal static string 三丕且上丆下丁与专()
    {
        return "༺";
    }
    internal void 丛丏丏东专丐丕丏丕()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterViewHolder, 丏业丟一东丂东丘丛:  true);
    }
    internal void 万丆丛业一东丑七三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterViewHolder, 丏业丟一东丂东丘丛:  false);
    }
    public void U_LoadoutsClicked()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadoutsUi, 丏业丟一东丂东丘丛:  true);
    }
    private void 丒丞丟丟丛丝丄与一()
    {
        if(Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丁丁丆丈丂上丙丞丏() >= 1)
        {
                FilterMaps val_3 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadoutsButtonContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._loadoutsButtonNumber, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丑专丘世丙丑丝世七() + 1);
    }
    public RespawnWindow()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丆三丏丒不丘丙丌丛 = val_1;
        mem[1152921540260318196] = val_1.y;
        mem[1152921540260318200] = val_1.z;
        this.东丏东上七一万丆丌 = new System.Collections.Generic.List<Player_move_c>(capacity:  10);
    }
    private static RespawnWindow()
    {
    
    }
    private void 丈丛丆丂业且丟三丒()
    {
        var val_11;
        PGCompany.丗丟丄丈东丝丕丄世 val_12;
        string val_13;
        var val_14;
        bool val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丞且丂与东丐东专下(下丅丙一丂丗丅丝七:  this.丁万丗丕丁且丆三丘, 丁专专东丌丏丏丏丞:  new PGCompany.丏丙丙丙丄丘丏丈丙() {丟丆丁丛万丑丅下丛 = this.丗丅丄丄且丞丑丞丘 | 47244640256});
        if(this.业丁丒丘丐三专丏丕 != null)
        {
                this.业丁丒丘丐三专丏丕.Invoke();
        }
        
        val_11 = 0;
        val_12 = this.丁万丗丕丁且丆三丘;
        if(this.丁万丗丕丁且丆三丘.不业丙丒丂丞下丆丙() != 10)
        {
            goto label_4;
        }
        
        if(val_12 == null)
        {
            goto label_5;
        }
        
        val_11 = null;
        if(null == val_11)
        {
            goto label_8;
        }
        
        val_11 = 0;
        val_12 = 0;
        goto label_8;
        label_4:
        val_13 = val_12.不业丙丒丂丞下丆丙().ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_12;
        label_5:
        label_8:
        val_13 = val_12.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_12:
        PGCompany.Analytics.一业丗丆世世上丁且.丕三丘丕且丐丙丂业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丐丅专且专七三丆:  1, 下丅丙一丂丗丅丝七:  this.丁万丗丕丁且丆三丘.业上丙丞丐丄丆丅七(), 与丄不丌一世东丁丙:  val_13);
        val_14 = null;
        val_14 = null;
        丒万下丗丂丐丁丒丑(丞丈专下丈专业三丞:  1.25f);
    }
    private void 丏与世丑丄丘丄世丁()
    {
        this.yourWeapon.丙东丑不丆业丁丟丝(丑丒业丘丑东丕世丅:  true);
    }

}
