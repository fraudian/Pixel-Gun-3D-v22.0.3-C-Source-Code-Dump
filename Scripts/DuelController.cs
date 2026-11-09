using UnityEngine;
internal class DuelController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    private static System.Action<int> 上丛丌世东专丂丅丄;
    internal static DuelController 丄丘七三上丕世丞业;
    private const float 丒专丞业丌丄丐世一 = 120;
    internal static float 下世丗下一丆丐丝专;
    internal static float 丟上丝不丏丏万丁丘;
    internal static float 上万丟丟丘丁丙与丛;
    internal const string 丕与且专丌丄丙世丛 = "DuelPlayedBet";
    public CharacterInterfaceV2 myCharacter;
    public CharacterInterfaceV2 enemyCharacter;
    public DuelPlayerInfo myPlayerInfo;
    public DuelPlayerInfo opponentPlayerInfo;
    public UnityEngine.Transform myCharacterPoint;
    public UnityEngine.Transform enemyCharacterPoint;
    private float 不丄丟丞丄万不丈丌;
    private float 丘丑丌丆与丑丞万三;
    private float 丈丛万不丈与专丐世;
    private int 丝丈万丞丑丑一丅与;
    private float 丏丟世丑丆世丆丌专;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    public DuelController.一且丐丗丅丈丏丄丅 gameStatus;
    public NetworkStartTable opponentNetworkTable;
    public int myRespawnPoints;
    private bool 与东丏丟丝丈东丌七;
    private bool 业丐丌丂业三丌东专;
    private bool 丞丘丆下丏丂专一丞;
    public bool betsEnabled;
    public bool betsWrongVersion;
    private bool 丁丌一丈三丌世丘丁;
    private bool 丏专丄丁且丆丐东下;
    private bool 丒业丌七三丁一丐上;
    private bool 世丒与不丘丈东丞七;
    private string 下丆丝丝下丒丑丑丐;
    private bool 世丟丘丞丌丁丙丕丕;
    private bool 丕七丟三丗三丐业丁;
    private bool 丛丑上一丗丒丘丗丈;
    private bool 丒丕丄丆专丂丛丙万;
    private bool 东丏与丆专不丐丛丁;
    private readonly Rilisoft.丝三丕七业丗丂丆三[] 丕世丗一丈与丕丕万;
    internal static string[] 下丆丗专丂丐丈丐上;
    private int 丆丛东丐丄丄丞丄丐;
    private int 丑丂与丂丘上三丌不;
    private int 丒不丟丐丆七丆丕三;
    internal int 不丐丈下专与丒丗丑;
    private Rilisoft.丝丑丂丛万丐丈丘且 下万东上丟丏且七业;
    private 丈丞丕丘丕丗与上一 七丅丞世丑丒七上丈;
    private int 丞下业且专专专丏七;
    private int 不丛专丘丑丝丟丅丝;
    private float 丝丕丘丄与丑丄丁丝;
    private bool 上丟丂丙丝丝世三丞;
    private bool 丑丂丂七丘东丅七东;
    private bool 丆与丙丂丑与丈丌丗;
    private bool 丅丛一下不且丂世丑;
    private int 不一七不丄丑专丁丛;
    
    // Properties
    public float 丄专万丏丘上丑与一 { get; }
    public float 且专东丈丈与丗世丁 { get; }
    public DuelController.丛丏丂丄上专且万业 七专丙丏丘丌丌下与 { get; set; }
    public string 一世丕丒七丅丝丐丟 { get; set; }
    internal bool 丁三业丑万丑丁业业 { get; }
    public bool 丝丝丗七丑丁丕丗丄 { get; }
    public bool 丄三丂丆与丞万一丏 { get; }
    public bool 丝不世丐丘三丁丆三 { get; }
    public DuelUIController 七丝一丌丏七丂上不 { get; }
    public bool 专丗丛丝丗丞下丑丄 { get; }
    internal int 丞与丅丌一与丕且丐 { get; set; }
    
    // Methods
    internal static void 专丗与丄丂丙七业不(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  DuelController.丕与且专丌丄丙世丛, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丒业丛丗一丙一丌丅(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  DuelController.丕与且专丌丄丙世丛, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public float get_timeLeft()
    {
        return (float)this.不丄丟丞丄万不丈丌;
    }
    public float get_playingTime()
    {
        float val_1 = this.不丄丟丞丄万不丈丌;
        val_1 = 120f - val_1;
        return (float)val_1;
    }
    public DuelController.丛丏丂丄上专且万业 get_roomStatus()
    {
        var val_4 = null;
        object val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丟丞丏丝与丙丁丛与];
        return (丛丏丂丄上专且万业)null;
    }
    public void set_roomStatus(DuelController.丛丏丂丄上专且万业 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    public string get_WinnerID()
    {
        var val_8;
        var val_9;
        var val_10;
        int val_11;
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        if((val_8.ContainsKey(key:  GameConnect.丄丙丆丁丟丈丒与丈)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            if(val_8.Item[GameConnect.丄丙丆丁丟丈丒与丈] == null)
        {
                return (string)val_11;
        }
        
            if(null == null)
        {
                return (string)val_11;
        }
        
            val_11 = 0;
            return (string)val_11;
        }
        
        val_11 = System.String.alignConst;
        return (string)val_11;
    }
    public void set_WinnerID(string 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丄丙丆丁丟丈丒与丈, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal bool 丁七丒丕丑一丗一丟()
    {
        return (bool)this.与东丏丟丝丈东丌七;
    }
    public bool get_canPause()
    {
        var val_3;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return (bool)(this.不丄丟丞丄万不丈丌 > 15f) ? 1 : 0;
        }
        
        val_3 = 0;
        return (bool)(this.不丄丟丞丄万不丈丌 > 15f) ? 1 : 0;
    }
    public bool get_showEnemyCharacter()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.opponentNetworkTable, y:  0);
        if(val_1 != true)
        {
                if((this.gameStatus != 7) || (this.世丒与不丘丈东丞七 == false))
        {
                return false;
        }
        
        }
        
        bool val_3 = UnityEngine.Object.op_Inequality(x:  val_1.duelUI, y:  0);
        if(val_3 == false)
        {
                return false;
        }
        
        DuelUIController val_4 = val_3.duelUI;
        if(val_4.showCharacters == false)
        {
                return false;
        }
        
        if(this.gameStatus == 1)
        {
                return false;
        }
        
        var val_7 = ((this.gameStatus != 2) ? 1 : 0) & ((this.gameStatus != 9) ? 1 : 0);
        return false;
    }
    public bool get_showMyCharacter()
    {
        var val_5;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.duelUI, y:  0);
        if(val_2 != false)
        {
                DuelUIController val_3 = val_2.duelUI;
            var val_4 = (val_3.showCharacters == true) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public DuelUIController get_duelUI()
    {
        NetworkStartTableNGUIController val_2;
        DuelUIController val_3;
        val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        val_3 = 0;
        if(val_2 == 0)
        {
                return val_3;
        }
        
        val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 984];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.duelUI;
        return val_3;
    }
    public bool get_isMaster()
    {
        return 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
    }
    private void OnDestroy()
    {
        var val_6;
        var val_7;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        丛且丗丌丏下七下丈.世丄业三一丞丅丌七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void DuelController::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
        丆丟七丌丞东丆丕丌.丂下下丒丘丙丘丟一(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  this, method:  System.Void DuelController::下丂丂丙丘不东丟丄(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘, string 丅丈丘万丁不丑业三)));
        丆丟七丌丞东丆丕丌.不丕丘业专丐丙万丑(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  this, method:  System.Void DuelController::专丕丒丘业丘专下一(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘)));
        val_6 = null;
        val_6 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_7 = null;
            val_7 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
                val_7 = null;
        }
        
            ShopNGUIController.丏丙丅丕一丑丕丑丑.且与丛丈丁丟专丈丑 = 0;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈 = 0;
        }
        
        this.丂丆丝业丛丒上丑丑();
        Progress.丛下丄专下万丒专丂.丕丄七三世上丈且丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void DuelController::OpponentConnected()));
    }
    private void Awake()
    {
        var val_10;
        bool val_11;
        var val_12;
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_3;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_3:
        val_11 = 0;
        if(this != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        this.enabled = (val_11 != 0) ? 1 : 0;
        val_12 = null;
        val_12 = null;
        DuelController.丄丘七三上丕世丞业 = this;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        if(this.enabled == false)
        {
                return;
        }
        
        bool val_5 = UnityEngine.Object.op_Equality(x:  this.myCharacter, y:  0);
        if(val_5 != false)
        {
                this.myCharacter = val_5.丝丅与丒东世丒丁丕(不丂丅丁且丆东东丂:  this.myCharacterPoint);
        }
        
        bool val_7 = UnityEngine.Object.op_Equality(x:  this.enemyCharacter, y:  0);
        if(val_7 != false)
        {
                this.enemyCharacter = val_7.丝丅与丒东世丒丁丕(不丂丅丁且丆东东丂:  this.enemyCharacterPoint);
        }
        
        Progress.丛下丄专下万丒专丂.丈丑上且万丂专丝且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void DuelController::OpponentConnected()));
    }
    internal DuelController()
    {
        this.丝丈万丞丑丑一丅与 = 0;
        this.myRespawnPoints = 1;
        this.下丆丝丝下丒丑丑丐 = "";
        this.丆丛东丐丄丄丞丄丐 = 0;
        this.丑丂与丂丘上三丌不 = 0;
        this.丒不丟丐丆七丆丕三 = 0;
        this.不丐丈下专与丒丗丑 = 0;
        this.丕世丗一丈与丕丕万 = new Rilisoft.丝三丕七业丗丂丆三[4];
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.下万东上丟丏且七业 = 0;
        mem[1152921525917667208] = 0;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.丈万丄与丈三丏丙丂 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void DuelController::OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_5 = this.与丑丌丌丌丁丌不丕();
        val_5.下世丁丄且丘一丁下 = new System.Action(object:  this, method:  public System.Void DuelController::OnDisconnectedFromPhoton());
    }
    private void Start()
    {
        this.SetShopEvents();
    }
    private void 丂丄丛丌丗丘丗丘丏()
    {
        var val_22;
        var val_23;
        string val_24;
        var val_25;
        var val_26;
        string val_27;
        var val_28;
        bool val_29;
        bool val_30;
        if(this.opponentNetworkTable == 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        if((丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.下丝下万三丟下丕不)) == false)
        {
            goto label_10;
        }
        
        val_23 = null;
        ExitGames.Client.Photon.Hashtable val_22 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆();
        val_23 = null;
        object val_7 = val_22.Item[GameConnect.下丝下万三丟下丕不];
        if(val_7 == null)
        {
            goto label_17;
        }
        
        val_22 = (null == null) ? (val_7) : 0;
        goto label_19;
        label_10:
        val_24 = "";
        goto label_19;
        label_17:
        val_24 = 0;
        label_19:
        val_25 = null;
        val_25 = null;
        if((this.opponentNetworkTable.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.下丝下万三丟下丕不)) == false)
        {
            goto label_26;
        }
        
        val_26 = null;
        ExitGames.Client.Photon.Hashtable val_23 = this.opponentNetworkTable.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆();
        val_26 = null;
        object val_13 = val_23.Item[GameConnect.下丝下万三丟下丕不];
        if(val_13 == null)
        {
            goto label_33;
        }
        
        val_23 = (null == null) ? (val_13) : 0;
        goto label_35;
        label_26:
        val_27 = "";
        goto label_35;
        label_33:
        val_27 = 0;
        label_35:
        val_28 = null;
        val_28 = null;
        if((this.opponentNetworkTable.丄丈丑丐丆丞丘与丗.owner.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.下丝下万三丟下丕不)) != false)
        {
                val_29 = 0;
        }
        else
        {
                val_29 = (~(System.String.IsNullOrEmpty(value:  val_24))) & 1;
        }
        
        this.betsWrongVersion = val_29;
        if((System.String.IsNullOrEmpty(value:  val_24)) != false)
        {
                val_30 = 0;
        }
        else
        {
                val_30 = (~(System.String.IsNullOrEmpty(value:  val_27))) & 1;
        }
        
        this.betsEnabled = val_30;
        if(val_30 == 0)
        {
            goto label_46;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != null)
        {
            goto label_48;
        }
        
        label_49:
        label_48:
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丘丙丏丝丛丘丟业丙(丈丞丁丐丑丏万万丒:  this.丙丝上丈七丐丁丟世());
        return;
        label_46:
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != null)
        {
            goto label_48;
        }
        
        goto label_49;
    }
    public void StartDuelMode()
    {
        this.丕丕东丑丑丘三丑丗(丞丅上丏丂且下丅与:  System.String.alignConst);
        this.SetMyCape();
        this.SetMyMask();
        this.SetMyHat();
        this.SetMyBoots();
        this.SetMyWeapon();
        this.SetMyArmor();
        if(this.gameStatus != 0)
        {
                return;
        }
        
        this.gameStatus = 1;
    }
    private void 丞丞下丒丅丅丛世丕()
    {
        string val_28;
        System.Object[] val_29;
        val_28 = this;
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_1.丄东丅丘东不丘丝丟(丙业与丙丗丝不丈东:  false);
        this.丞丘丆下丏丂专一丞 = true;
        val_1.WinnerID = "";
        val_1.丅下丕丘丂丐丏世丟(三丁丂丒不丘丄丂三:  2);
        this.丑世东世丗三丐东丑(丛丙专一七上下三丐:  120f, 丏丅丅专七丘丑上丂:  this.myRespawnPoints);
        object[] val_2 = new object[2];
        val_29 = val_2;
        val_29[0] = 120f;
        val_29[1] = (this.myRespawnPoints != 2) ? (1 + 1) : 1;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  100, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
        bool val_4 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_4 == false)
        {
                return;
        }
        
        if(this.丆丛东丐丄丄丞丄丐 != 1)
        {
                string val_7 = val_4.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐).且丙东丞一丐万丕万().东与三丌丅三丒丏业();
            val_29 = val_7.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐).且丙东丞一丐万丕万();
            Rilisoft.一丟专且三万丞丁丂.丅丗世丄专业东丗丞(丂丐丄丁丆与丈丂上:  "Call", 下下丏一丙不丘丌丞:  System.String.Format(format:  "Bet_{0}_{1}", arg0:  val_7, arg1:  val_29.丟丂丞不专丆万丒世()));
        }
        else
        {
                val_29 = this.丒不丟丐丆七丆丕三;
            if((this.丑丂与丂丘上三丌不 & val_29) != 1)
        {
                int val_13 = UnityEngine.Mathf.Max(a:  this.丑丂与丂丘上三丌不, b:  val_29);
            string val_16 = val_13.GetBetConfigByIndex(丞世不丒下上上丝丑:  val_13).且丙东丞一丐万丕万().东与三丌丅三丒丏业();
            val_29 = val_16.GetBetConfigByIndex(丞世不丒下上上丝丑:  val_13).且丙东丞一丐万丕万();
            Rilisoft.一丟专且三万丞丁丂.丅丗世丄专业东丗丞(丂丐丄丁丆与丈丂上:  "Reject", 下下丏一丙不丘丌丞:  System.String.Format(format:  "Bet_{0}_{1}", arg0:  val_16, arg1:  val_29.丟丂丞不专丆万丒世()));
        }
        
        }
        
        if(this.丆丛东丐丄丄丞丄丐 != 1)
        {
                string val_23 = GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐).且丙东丞一丐万丕万().东与三丌丅三丒丏业();
            val_29 = val_23;
            val_28 = System.String.Format(format:  "Bet_{0}_{1}", arg0:  val_29, arg1:  val_23.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐).且丙东丞一丐万丕万().丟丂丞不专丆万丒世());
        }
        else
        {
                val_28 = "Without Bet";
        }
        
        Rilisoft.一丟专且三万丞丁丂.丅丗世丄专业东丗丞(丂丐丄丁丆与丈丂上:  "Start", 下下丏一丙不丘丌丞:  val_28);
    }
    public void StartRevengeMatch()
    {
        this.gameStatus = 2;
        this.丛丅丈丄七丞丟丂丕();
    }
    private void 丛丅丈丄七丞丟丂丕()
    {
        var val_2;
        var val_3;
        float val_4;
        var val_5;
        var val_6;
        var val_7;
        this.丂丄丛丌丗丘丗丘丏();
        val_2 = null;
        val_2 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
        {
                val_3 = null;
            val_3 = null;
            val_4 = 1152921505058021400;
        }
        else
        {
                val_5 = null;
            if(this.betsEnabled != false)
        {
                val_6 = null;
            val_4 = 1152921505058021392;
        }
        else
        {
                val_7 = null;
            val_4 = 1152921505058021396;
        }
        
        }
        
        this.丕丝下业丟丂业丆上(丙一丑丏丁一且丒业:  val_4);
        object[] val_1 = new object[1];
        val_1[0] = val_4;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  28, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_13;
        int val_14;
        一且丐丗丅丈丏丄丅 val_17;
        var val_18;
        string val_19;
        object val_20;
        int val_21;
        int val_22;
        int val_23;
        val_13 = this;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 > 91)
        {
            goto label_1;
        }
        
        if(val_1 > 52)
        {
            goto label_2;
        }
        
        byte val_2 = 丞世不丒下上上丝丑 & 255;
        if(val_2 == 28)
        {
            goto label_3;
        }
        
        if(val_2 == 38)
        {
            goto label_4;
        }
        
        if(val_2 != 52)
        {
            goto label_23;
        }
        
        val_14 = 专丒丌丆下丐丞丟丞.Length;
        if(val_14 == 0)
        {
                val_14 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_13 = 专丒丌丆下丐丞丟丞[0];
        object val_14 = 专丒丌丆下丐丞丟丞[1];
        this.myRespawnPoints = null;
        if((this.gameStatus - 2) < 2)
        {
            goto label_9;
        }
        
        if(this.gameStatus != 8)
        {
            goto label_100;
        }
        
        val_17 = 4;
        this.不丄丟丞丄万不丈丌 = null;
        goto label_11;
        label_1:
        if(val_1 > 139)
        {
            goto label_12;
        }
        
        byte val_4 = 丞世不丒下上上丝丑 & 255;
        if(val_4 == 100)
        {
            goto label_13;
        }
        
        if(val_4 == 111)
        {
            goto label_14;
        }
        
        if(val_4 != 139)
        {
            goto label_23;
        }
        
        专丒丌丆下丐丞丟丞[0].丅下丕丘丂丐丏世丟(三丁丂丒不丘丄丂三:  0);
        val_17 = 3;
        this.丏丟世丑丆世丆丌专 = null;
        label_11:
        this.gameStatus = val_17;
        goto label_100;
        label_2:
        byte val_5 = 丞世不丒下上上丝丑 & 255;
        val_18 = 0;
        if((val_5 - 53) > 18)
        {
            goto label_19;
        }
        
        var val_16 = 106014832;
        val_16 = (106014832 + (((丞世不丒下上上丝丑 & 255) - 53)) << 2) + val_16;
        goto (106014832 + (((丞世不丒下上上丝丑 & 255) - 53)) << 2 + 106014832);
        label_12:
        byte val_7 = 丞世不丒下上上丝丑 & 255;
        if(val_7 == 141)
        {
            goto label_21;
        }
        
        if(val_7 == 148)
        {
            goto label_22;
        }
        
        if(val_7 != 188)
        {
            goto label_23;
        }
        
        object val_17 = 专丒丌丆下丐丞丟丞[0];
        if(val_17 == null)
        {
            goto label_26;
        }
        
        var val_8 = (null == null) ? (val_17) : 0;
        goto label_27;
        label_23:
        val_18 = 0;
        return (bool)val_18;
        label_4:
        val_20 = 专丒丌丆下丐丞丟丞[0];
        if(val_20 != null)
        {
                val_20 = 0;
        }
        
        val_18 = 1;
        this.DuelPlayerDisconnected(专丞上七七且丝七丗:  val_20, 丆不丐一丙丐丏丗上:  true);
        return (bool)val_18;
        label_14:
        if(专丒丌丆下丐丞丟丞[0].isMaster == true)
        {
            goto label_100;
        }
        
        this.不丄丟丞丄万不丈丌 = null;
        goto label_100;
        label_22:
        val_21 = 专丒丌丆下丐丞丟丞.Length;
        if(val_21 == 0)
        {
                val_21 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_19 = 专丒丌丆下丐丞丟丞[0];
        object val_20 = 专丒丌丆下丐丞丟丞[1];
        this.丑丘下丒上丐不丗不(丄丛丈丈丂不丗且丘:  21884928, 丏丅丟丂七丑丛丕丄:  21884928);
        goto label_100;
        label_3:
        object val_21 = 专丒丌丆下丐丞丟丞[0];
        this.丕丝下业丟丂业丆上(丙一丑丏丁一且丒业:  3.782474E-38f);
        goto label_100;
        label_13:
        val_22 = 专丒丌丆下丐丞丟丞.Length;
        if(val_22 == 0)
        {
                val_22 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_22 = 专丒丌丆下丐丞丟丞[0];
        object val_23 = 专丒丌丆下丐丞丟丞[1];
        label_9:
        this.丑世东世丗三丐东丑(丛丙专一七上下三丐:  3.782474E-38f, 丏丅丅专七丘丑上丂:  21884928);
        goto label_100;
        label_21:
        object val_24 = 专丒丌丆下丐丞丟丞[0];
        this.专丅丒丝丐丂业丛三(万丙丈丙丄丅丝专上:  21884928);
        goto label_100;
        label_19:
        if(val_5 != 91)
        {
                return (bool)val_18;
        }
        
        val_23 = 专丒丌丆下丐丞丟丞.Length;
        if(val_23 == 0)
        {
                val_23 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_25 = 专丒丌丆下丐丞丟丞[0];
        if(val_23 <= 1)
        {
                val_23 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_26 = 专丒丌丆下丐丞丟丞[1];
        if(val_23 <= 2)
        {
                val_23 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_27 = 专丒丌丆下丐丞丟丞[2];
        object val_28 = 专丒丌丆下丐丞丟丞[3];
        this.丆丙上世丟丐与三丑(丑下万丂丞不七丄三:  false, 丅丒丆三丌七丟七与:  false, 丂丈业东丛且丈一下:  false, 丒丒丏业专丌丑丟丆:  false);
        goto label_100;
        label_26:
        val_19 = 0;
        label_27:
        this.丁丏丌丝专上丞且丌(丞丅上丏丂且下丅与:  val_19);
        label_100:
        val_18 = 1;
        return (bool)val_18;
    }
    private void 丕丝下业丟丂业丆上(float 丙一丑丏丁一且丒业)
    {
        this.丏专丄丁且丆丐东下 = false;
        this.丒业丌七三丁一丐上 = false;
        this.丂丄丛丌丗丘丗丘丏();
        this.丅下丕丘丂丐丏世丟(三丁丂丒不丘丄丂三:  0);
        this.丁丌一丈三丌世丘丁 = false;
        this.与东丏丟丝丈东丌七 = false;
        this.业丐丌丂业三丌东专 = false;
        DuelUIController val_1 = this.duelUI;
        UIButton val_2 = val_1.revengeButton.GetComponent<UIButton>();
        if(this.betsEnabled != false)
        {
                this.丌丈丏上丌世丗丛丒();
        }
        
        this.duelUI.丗且丑丁丏丙丘丆丐(上丆丘七丞且丄丘与:  (this.betsEnabled == true) ? 1 : 0, 丛丒丂一丒一三丒万:  (this.betsWrongVersion == true) ? 1 : 0);
        this.gameStatus = 3;
        this.丏丟世丑丆世丆丌专 = 丙一丑丏丁一且丒业;
        this.丁丞丛丂七丝且丐丞();
    }
    private void 一万丞丗丂丘丂七丌(string 丟丟丄专上丟丁丐丝)
    {
        this.下丆丝丝下丒丑丑丐 = 丟丟丄专上丟丁丐丝;
    }
    private void 丐丌丅丙丁丕丛下丐()
    {
        null = null;
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(DuelController.丟上丝不丏丏万丁丘 != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(DuelController.丟上丝不丏丏万丁丘 == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = DuelController.丟上丝不丏丏万丁丘;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  139, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 丕丐东丟丏丕丕业丄(float 丙一丑丏丁一且丒业)
    {
        this.丅下丕丘丂丐丏世丟(三丁丂丒不丘丄丂三:  0);
        this.gameStatus = 3;
        this.丏丟世丑丆世丆丌专 = 丙一丑丏丁一且丒业;
    }
    private void 业丞七丞丗丞丆丝丙()
    {
        this.gameStatus = 4;
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.不丄丟丞丄万不丈丌 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.不丄丟丞丄万不丈丌 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.不丄丟丞丄万不丈丌;
        val_1[1] = (this.myRespawnPoints != 2) ? (1 + 1) : 1;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  52, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丏丛丙丗不丁下丂丆(float 丛丙专一七上下三丐, int 丏丅丅专七丘丑上丂)
    {
        this.myRespawnPoints = 丏丅丅专七丘丑上丂;
        if((this.gameStatus - 2) < 2)
        {
                this.丑世东世丗三丐东丑(丛丙专一七上下三丐:  丛丙专一七上下三丐, 丏丅丅专七丘丑上丂:  丏丅丅专七丘丑上丂);
            return;
        }
        
        if(this.gameStatus != 8)
        {
                return;
        }
        
        this.gameStatus = 4;
        this.不丄丟丞丄万不丈丌 = 丛丙专一七上下三丐;
    }
    internal void 丑世东世丗三丐东丑(float 丛丙专一七上下三丐, int 丏丅丅专七丘丑上丂)
    {
        var val_1;
        this.丂丆丝业丛丒上丑丑();
        this.myRespawnPoints = 丏丅丅专七丘丑上丂;
        this.丟丛专七不七丆三万();
        this.不丄丟丞丄万不丈丌 = 丛丙专一七上下三丐;
        if(this.丆丛东丐丄丄丞丄丐 == 1)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        if(DuelController.丕与且专丌丄丙世丛 == null)
        {
                return;
        }
        
        DuelController.丕与且专丌丄丙世丛.Invoke(obj:  this.丆丛东丐丄丄丞丄丐);
    }
    private void 丟丛专七不七丆三万()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                val_6 = null;
            val_6 = null;
            GameController.onlineMode.丟丛专七不七丆三万();
        }
        
        DuelUIController val_2 = GameController.onlineMode.duelUI;
        this.gameStatus = 4;
        val_2.revengeButton.GetComponent<UIButton>().duelUI.丆东世丝万丆下丞一();
    }
    internal void 丕丟东丏丈丗丕上丟(float 丛丙专一七上下三丐)
    {
        if(this.isMaster == true)
        {
                return;
        }
        
        this.不丄丟丞丄万不丈丌 = 丛丙专一七上下三丐;
    }
    private NetworkStartTable 丒业万一丌丝上世丑()
    {
        var val_14;
        var val_15;
        if(this.opponentNetworkTable != 0)
        {
                if(this.opponentNetworkTable.丆丒丕不七丙丞丒上 == false)
        {
            goto label_5;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        return (NetworkStartTable)WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        label_5:
        val_15 = null;
        val_15 = null;
        if(this.opponentNetworkTable == null)
        {
            goto label_12;
        }
        
        if(this.opponentNetworkTable.丑丛丆三丆丄七丐万() == 1)
        {
            goto label_13;
        }
        
        label_23:
        int val_3 = this.opponentNetworkTable.丑丛丆三丆丄七丐万();
        if(this.opponentNetworkTable == null)
        {
            goto label_14;
        }
        
        label_24:
        if(this.opponentNetworkTable.丝丈丅一丆丗丝丝丘() == 1)
        {
            goto label_15;
        }
        
        label_25:
        int val_5 = this.opponentNetworkTable.丝丈丅一丆丗丝丝丘();
        if(null != 0)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        if(丑丛丆三丆丄七丐万() == val_3)
        {
                if(丝丈丅一丆丗丝丝丘() == val_5)
        {
                return (NetworkStartTable)WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        }
        
        }
        
        if(丑丛丆三丆丄七丐万() <= val_3)
        {
            goto label_21;
        }
        
        return (NetworkStartTable)WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        label_12:
        if(0.丑丛丆三丆丄七丐万() != 1)
        {
            goto label_23;
        }
        
        label_13:
        if(this.opponentNetworkTable != null)
        {
            goto label_24;
        }
        
        label_14:
        if(0.丝丈丅一丆丗丝丝丘() != 1)
        {
            goto label_25;
        }
        
        label_15:
        if(null != 0)
        {
            goto label_26;
        }
        
        goto label_27;
        label_21:
        if(丑丛丆三丆丄七丐万() != val_3)
        {
                return (NetworkStartTable)WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        }
        
        var val_13 = (丝丈丅一丆丗丝丝丘() > val_5) ? WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable : this.opponentNetworkTable;
        return (NetworkStartTable)WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
    }
    private void 丗丞丙丒七业丂丁三()
    {
        string val_10;
        var val_11;
        var val_12;
        var val_14;
        if((System.String.IsNullOrEmpty(value:  this.WinnerID)) != false)
        {
                if(this.丒业万一丌丝上世丑() != 0)
        {
                val_10 = val_3.丈三世丞丕万丄七丂;
        }
        else
        {
                val_10 = "";
        }
        
            this.WinnerID = val_10;
        }
        
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_12 = null;
            val_12 = null;
            专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
            世丄丝丏丘不丂丏丒();
        }
        
        object[] val_7 = new object[2];
        if(this.opponentNetworkTable != 0)
        {
                val_7[0] = this.opponentNetworkTable.丑丛丆三丆丄七丐万();
            int val_9 = this.opponentNetworkTable.丝丈丅一丆丗丝丝丘();
            val_14 = null;
        }
        else
        {
                val_7[0] = 0;
            val_14 = null;
        }
        
        val_7[1] = 0;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  148, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_7);
        this.丏且丛丛下业专一七();
    }
    private void 丑丘下丒上丐不丗不(int 丄丛丈丈丂不丗且丘, int 丏丅丟丂七丑丛丕丄)
    {
        var val_2;
        var val_3;
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        丆专世丒七丒东丕世(丙业与丙丗丝不丈东:  丄丛丈丈丂不丗且丘);
        东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  丏丅丟丂七丑丛丕丄);
        val_3 = null;
        val_3 = null;
        GameController.mode.与丄下丑丈丗三丂丘(丙业与丙丗丝不丈东:  丄丛丈丈丂不丗且丘);
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  丏丅丟丂七丑丛丕丄);
        this.丏且丛丛下业专一七();
    }
    private void 丏且丛丛下业专一七()
    {
        var val_1;
        this.SetMyWeapon();
        this.SendMyWeapon();
        this.gameStatus = 7;
        val_1 = null;
        val_1 = null;
        if(GameController.mode != null)
        {
                GameController.mode.七丁丕一一丒丂七丑();
        }
        
        GameController.mode.丅下丕丘丂丐丏世丟(三丁丂丒不丘丄丂三:  1);
    }
    public void OpponentConnected()
    {
        this.SendMyWearInvisible();
        this.丕丕东丑丑丘三丑丗(丞丅上丏丂且下丅与:  "");
        this.SendMyCape();
        this.SendMyMask();
        this.SendMyHat();
        this.SendMyBoots();
        this.SendMyWeapon();
        this.SendMyArmor();
        if(this.gameStatus != 1)
        {
                return;
        }
        
        this.gameStatus = 2;
        this.丏丟世丑丆世丆丌专 = 2f;
    }
    public void RevengeRequest()
    {
        if(this.与东丏丟丝丈东丌七 != false)
        {
                return;
        }
        
        this.与东丏丟丝丈东丌七 = true;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  53, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        DuelUIController val_2 = this.丄丈丑丐丆丞丘与丗.duelUI;
        val_2.丂丄与丆丁丅丅且且(七丐上丁世丆业丒七:  (this.业丐丌丂业三丌东专 == true) ? 1 : 0, 丘丐丌丈丐丝万丏丆:  false);
        DuelUIController val_4 = val_2.duelUI;
        if(this.业丐丌丂业三丌东专 == false)
        {
                return;
        }
        
        if((val_4.revengeButton.GetComponent<UIButton>().isMaster) == false)
        {
                return;
        }
        
        this.gameStatus = 2;
        this.丛丅丈丄七丞丟丂丕();
    }
    internal void 丌七丆万三丆丒万业()
    {
        this.业丐丌丂业三丌东专 = true;
        if(this.与东丏丟丝丈东丌七 != true)
        {
                DuelUIController val_1 = this.duelUI;
            val_1.丂丄与丆丁丅丅且且(七丐上丁世丆业丒七:  true, 丘丐丌丈丐丝万丏丆:  false);
            if(this.与东丏丟丝丈东丌七 == false)
        {
                return;
        }
        
        }
        
        if(val_1.isMaster == false)
        {
                return;
        }
        
        this.gameStatus = 2;
        this.丛丅丈丄七丞丟丂丕();
    }
    internal void 丆丙上世丟丐与三丑(bool 丑下万丂丞不七丄三, bool 丅丒丆三丌七丟七与, bool 丂丈业东丛且丈一下, bool 丒丒丏业专丌丑丟丆)
    {
        var val_1 = (this.世丟丘丞丌丁丙丕丕 == true) ? 1 : 0;
        val_1 = val_1 ^ 丑下万丂丞不七丄三;
        if(val_1 != true)
        {
                var val_2 = (this.丕七丟三丗三丐业丁 == true) ? 1 : 0;
            val_2 = val_2 ^ 丅丒丆三丌七丟七与;
            if(val_2 != true)
        {
                var val_3 = (this.丛丑上一丗丒丘丗丈 == true) ? 1 : 0;
            val_3 = val_3 ^ 丂丈业东丛且丈一下;
            if(val_3 != true)
        {
                var val_4 = (this.丒丕丄丆专丂丛丙万 == true) ? 1 : 0;
            val_4 = val_4 ^ 丒丒丏业专丌丑丟丆;
            if(val_4 == false)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        this.世丟丘丞丌丁丙丕丕 = 丑下万丂丞不七丄三;
        this.丕七丟三丗三丐业丁 = 丅丒丆三丌七丟七与;
        this.丛丑上一丗丒丘丗丈 = 丂丈业东丛且丈一下;
        this.丒丕丄丆专丂丛丙万 = 丒丒丏业专丌丑丟丆;
        丑下万丂丞不七丄三 = 丑下万丂丞不七丄三 ^ 1;
        this.enemyCharacter.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  丑下万丂丞不七丄三);
        this.enemyCharacter.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (this.丕七丟三丗三丐业丁 == false) ? 1 : 0);
        this.enemyCharacter.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (this.丛丑上一丗丒丘丗丈 == false) ? 1 : 0);
        this.enemyCharacter.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    internal void 丛七丅业丂丟丙丌七(byte[] 丂丒丘丅专丗丂世丛)
    {
        UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  64, height:  32, textureFormat:  4, mipChain:  false);
        bool val_2 = UnityEngine.ImageConversion.LoadImage(tex:  val_1, data:  丂丒丘丅专丗丂世丛, markNonReadable:  true);
        val_1.filterMode = 0;
        this.enemyCharacter.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.enemyCharacter.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  val_1);
    }
    internal void 丁丏丌丝专上丞且丌(string 丞丅上丏丂且下丅与)
    {
        if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
        {
                return;
        }
        
        this.enemyCharacter.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丞丅上丏丂且下丅与);
    }
    internal void 丝丁丐丑业丘丂丕丅(string 丈丐丕业下丟业丛一)
    {
        this.enemyCharacter.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丈丐丕业下丟业丛一);
        this.enemyCharacter.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    internal void 丝丁丐丑业丘丂丕丅(string 丈丐丕业下丟业丛一, byte[] 丂丒丘丅专丗丂世丛)
    {
        UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  12, height:  16, textureFormat:  4, mipChain:  false);
        bool val_2 = UnityEngine.ImageConversion.LoadImage(tex:  val_1, data:  丂丒丘丅专丗丂世丛, markNonReadable:  true);
        val_1.filterMode = 0;
        this.enemyCharacter.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丈丐丕业下丟业丛一, 三丆业丘丑万丘世下:  val_1);
        this.enemyCharacter.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    internal void 七上丑业丕丟世丗丛(string 与丙丕丛一丌丛丆丈, bool 七丅丅世丆丆丗丟丐)
    {
        var val_9;
        var val_10;
        var val_11;
        bool val_12;
        var val_13;
        int val_14;
        val_9 = null;
        val_9 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 != 0)
        {
                val_10 = null;
            val_10 = null;
            if(null != 0)
        {
            goto label_11;
        }
        
        }
        else
        {
                val_11 = 0;
        }
        
        label_11:
        val_12 = 1;
        if(七丅丅世丆丆丗丟丐 == true)
        {
            goto label_24;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_14 == 0)
        {
            goto label_15;
        }
        
        val_14 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_14 != 1)
        {
            goto label_18;
        }
        
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0)) == false)
        {
            goto label_22;
        }
        
        label_15:
        val_12 = 1;
        goto label_24;
        label_18:
        val_12 = 0;
        goto label_24;
        label_22:
        val_12 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        label_24:
        this.世丒与不丘丈东丞七 = true;
        this.enemyCharacter.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  与丙丕丛一丌丛丆丈);
        this.enemyCharacter.丄丌丏三专丏丄丒丌(丙业与丙丗丝不丈东:  val_12);
    }
    internal void 七丑丏丄下丐不丂与(string 丟世丟丐且丐丟七上)
    {
        this.enemyCharacter.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  丟世丟丐且丐丟七上);
        this.enemyCharacter.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (this.丕七丟三丗三丐业丁 == false) ? 1 : 0);
    }
    internal void 与丏丕丗七丂丅三丁(string 且与丛专丗丞丑丑丝)
    {
        this.enemyCharacter.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  且与丛专丗丞丑丑丝);
        this.enemyCharacter.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (this.丛丑上一丗丒丘丗丈 == false) ? 1 : 0);
    }
    internal void 丏不丒世上三世丐业(string 上丈专丌万丕丙万丘)
    {
        this.enemyCharacter.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  上丈专丌万丕丙万丘);
        this.enemyCharacter.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  (this.世丟丘丞丌丁丙丕丕 == false) ? 1 : 0);
    }
    internal void 世丁一下东世丄丝东(string 丌丝下丄业一丄不三, string 世世丛与丒丗丏东下)
    {
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丌丝下丄业一丄不三 = 丌丝下丄业一丄不三)) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  世世丛与丒丗丏东下)) != false)
        {
                var val_6 = ((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丌丝下丄业一丄不三)) == 0) ? 1 : 0;
            val_6 = val_6 | (WeaponManager.丞上一丘丆三下丐丑().Contains(item:  丌丝下丄业一丄不三));
        }
        
        }
        
        this.enemyCharacter.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  (val_6 != true) ? 世世丛与丒丗丏东下 : (丌丝下丄业一丄不三));
    }
    internal void 世丁一下东世丄丝东(string 丌丝下丄业一丄不三, string 世世丛与丒丗丏东下, int 专丙丐世与丐下不丑)
    {
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丌丝下丄业一丄不三);
        this.enemyCharacter.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  丌丝下丄业一丄不三);
        this.enemyCharacter.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  专丙丐世与丐下不丑));
    }
    internal void 丗丏且丏丗丁丟丟丆(string 且丝与丗丑丁业丙丁)
    {
    
    }
    public void SendMyWearInvisible()
    {
        object[] val_1 = new object[4];
        bool val_3 = 三丐下丁丒丆丘下丄.丟万三丁丙丅东三三();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_3 == true)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_3 == false)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_3;
        val_1[1] = 三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅();
        val_1[2] = 三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏();
        val_1[3] = 三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七();
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  91, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendMySkin()
    {
        var val_3;
        object[] val_1 = new object[1];
        val_3 = null;
        val_3 = null;
        System.Byte[] val_2 = UnityEngine.ImageConversion.EncodeToPNG(tex:  SkinsController.丌与世丂丘且下丒丑);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  70, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendMyAvatar()
    {
        object[] val_1 = new object[1];
        string val_2 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  188, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void SendMyCape()
    {
        var val_10;
        object val_11;
        var val_12;
        PhotonTargets val_13;
        System.Object[] val_14;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        string val_3 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  9.ToString());
        if((val_3.Equals(value:  "cape_Custom")) != false)
        {
                val_10 = null;
            val_10 = null;
            val_11 = UnityEngine.ImageConversion.EncodeToPNG(tex:  SkinsController.丌七丞东丟丌世且不);
            if(SkinsController.丌七丞东丟丌世且不.width != 12)
        {
                return;
        }
        
            if(SkinsController.丌七丞东丟丌世且不.height != 16)
        {
                return;
        }
        
            object[] val_8 = new object[2];
            val_8[0] = val_3;
            val_8[1] = val_11;
            val_12 = 66;
            val_13 = 1;
            val_14 = val_8;
        }
        else
        {
                object[] val_9 = new object[1];
            val_11 = val_9;
            val_11[0] = val_3;
            val_12 = 66;
            val_13 = 1;
            val_14 = val_11;
        }
        
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  66, 丞下万上三丘上与专:  val_13, 丗丟上上丒丐丗丞丙:  val_9);
    }
    public void SendMyArmor()
    {
        string val_15;
        Rilisoft.七丕丟丏三丈一丄世 val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        int val_21;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_15 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  7.ToString());
        bool val_4 = 三丐下丁丒丆丘下丄.丟不丞丒丘丁丁丙丁();
        val_16 = 1152921505189646336;
        val_17 = null;
        val_17 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 == 0)
        {
            goto label_11;
        }
        
        val_18 = null;
        val_18 = null;
        if(val_4 == true)
        {
            goto label_16;
        }
        
        goto label_21;
        label_11:
        val_19 = 0;
        if(val_4 == false)
        {
            goto label_21;
        }
        
        label_16:
        val_20 = null;
        val_20 = null;
        val_21 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_21 == 0)
        {
            goto label_21;
        }
        
        val_21 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_21 != 1)
        {
            goto label_44;
        }
        
        val_16 = GameConnect.丑丌丛丈丅丅与不业();
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  val_16, 丞丁丑丏丄丏七丂不:  0)) == false)
        {
            goto label_28;
        }
        
        label_21:
        label_44:
        PGCompany.丙丕丑丑丆丂丗丗丟 val_9 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_15);
        if(val_9 != null)
        {
                val_15 = val_9.业上丙丞丐丄丆丅七();
        }
        
        object[] val_11 = new object[2];
        val_11[0] = val_15;
        val_11[1] = true;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  64, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_11);
        return;
        label_28:
        Rilisoft.七丕丟丏三丈一丄世 val_15 = GameConnect.丑丌丛丈丅丅与不业();
        val_15 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  val_15);
        goto label_44;
    }
    public void SendMyMask()
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_3 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  12.ToString());
        object[] val_4 = new object[1];
        if(val_4 == null)
        {
            goto label_6;
        }
        
        if(val_3 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_3 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_4[0] = val_3;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  68, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
    }
    public void SendMyBoots()
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_3 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  10.ToString());
        object[] val_4 = new object[1];
        if(val_4 == null)
        {
            goto label_6;
        }
        
        if(val_3 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_3 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_4[0] = val_3;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  65, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
    }
    public void SendMyHat()
    {
        string val_1 = 丘丕万丁丞业七丛与.东专丑三丕业世业丈();
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_1 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = val_1;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  67, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
    }
    public void SendMyWeapon()
    {
        var val_11;
        var val_12;
        string val_13;
        object val_14;
        object val_15;
        val_11 = null;
        val_11 = null;
        val_12 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.七丅丒万万丅一丄专()];
        Rilisoft.七丕丟丏三丈一丄世 val_4 = GameConnect.丑丌丛丈丅丅与不业();
        if(val_4 == 8)
        {
                val_12 = val_4.专丗丏丝丏丘丐丘三();
        }
        
        if(val_12 != null)
        {
                val_13 = val_5.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
            val_14 = val_5.三丐三丞丘丕不丒专.三丙且下一专上东与();
        }
        else
        {
                val_13 = "";
            val_14 = val_13;
        }
        
        PGCompany.丟丝世万东万丆丟上 val_8 = 丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  val_13);
        if(val_8 != null)
        {
                val_15 = val_8.业东丅东丌上丗丑不();
        }
        else
        {
                val_15 = 0;
        }
        
        object[] val_10 = new object[3];
        if(val_10 == null)
        {
            goto label_17;
        }
        
        if("" != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        label_18:
        label_21:
        val_10[0] = val_13;
        val_10[1] = val_14;
        val_10[2] = val_15;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  71, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_10);
    }
    public void SendMyPet()
    {
    
    }
    public void SetMySkin()
    {
        var val_1;
        this.myCharacter.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_1 = null;
        val_1 = null;
        this.myCharacter.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  SkinsController.丌与世丂丘且下丒丑);
    }
    public void SetMyAvatar()
    {
        this.myCharacter.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈());
    }
    public void SetMyCape()
    {
        UnityEngine.Texture2D val_7;
        var val_8;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_3 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  9.ToString());
        val_7 = 0;
        if((val_3.Equals(value:  "cape_Custom")) != false)
        {
                val_8 = null;
            val_8 = null;
            val_7 = SkinsController.丌七丞东丟丌世且不;
        }
        
        this.myCharacter.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  val_3, 三丆业丘丑万丘世下:  val_7);
        this.myCharacter.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七()) & 1);
    }
    public void SetMyArmor()
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_8 = Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  7.ToString());
        PGCompany.丙丕丑丑丆丂丗丗丟 val_4 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_8);
        if(val_4 != null)
        {
                string val_5 = val_4.业上丙丞丐丄丆丅七();
        }
        
        val_8 = (val_5 == null) ? (val_8) : (val_5);
        this.myCharacter.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  val_8);
        this.myCharacter.丄丌丏三专丏丄丒丌(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丟不丞丒丘丁丁丙丁()) & 1);
    }
    public void SetMyMask()
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.myCharacter.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  12.ToString()));
        this.myCharacter.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅()) & 1);
    }
    public void SetMyBoots()
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.myCharacter.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  10.ToString()));
        this.myCharacter.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏()) & 1);
    }
    public void SetMyHat()
    {
        this.myCharacter.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  丘丕万丁丞业七丛与.东专丑三丕业世业丈());
        this.myCharacter.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  (~三丐下丁丒丆丘下丄.丟万三丁丙丅东三三()) & 1);
    }
    public void SetMyPet()
    {
    
    }
    public void SetMyWearInvisible()
    {
        this.SetMyCape();
        this.SetMyMask();
        this.SetMyHat();
        this.SetMyBoots();
    }
    public void SetMyWeapon()
    {
        var val_9;
        var val_10;
        string val_11;
        val_9 = null;
        val_9 = null;
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.七丅丒万万丅一丄专()];
        Rilisoft.七丕丟丏三丈一丄世 val_4 = GameConnect.丑丌丛丈丅丅与不业();
        if(val_4 == 8)
        {
                val_10 = val_4.专丗丏丝丏丘丐丘三();
        }
        
        if(val_10 != null)
        {
                val_11 = val_5.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
        }
        else
        {
                val_11 = "";
        }
        
        Rilisoft.WeaponSkin val_7 = Rilisoft.上丑业三丆丆丅丕三.下三世且丅下业下一(丝三丛且丘不丌丙下:  val_11);
        this.myCharacter.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_11);
        this.myCharacter.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  val_11));
    }
    internal 三丈丟与丏丘丈丐万 专丗丏丝丏丘丐丘三()
    {
        var val_3;
        var val_4;
        var val_15;
        var val_16;
        val_15 = null;
        val_15 = null;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_1 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        if(val_1 == null)
        {
            goto label_4;
        }
        
        List.Enumerator<T> val_2 = val_1.GetEnumerator();
        label_12:
        val_16 = 0;
        label_9:
        if(((-155169040) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5 == null)
        {
            goto label_9;
        }
        
        val_3 = 0;
        val_4 = 0;
        PGCompany.丟丝东丈丐丙三下丛 val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丟丝东丈丐丙三下丛>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  X23.业东丅东丌上丗丑不()), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        if(val_9 == null)
        {
            goto label_9;
        }
        
        if(val_16 == 0)
        {
            goto label_12;
        }
        
        int val_10 = val_9.一丏丑丅丟世丗丈丒();
        int val_11 = 0.一丏丑丅丟世丗丈丒();
        var val_12 = (val_10 > val_11) ? (val_9) : 0;
        var val_13 = (val_10 > val_11) ? (val_5) : (val_16);
        goto label_12;
        label_4:
        val_16 = 0;
        return (三丈丟与丏丘丈丐万)val_16;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (三丈丟与丏丘丈丐万)val_16;
    }
    public void SendGameLeft()
    {
        object[] val_1 = new object[1];
        与丅丕丈丘东丝世丟 val_2 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  38, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 且丏丒丅丝且东丗三(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        this.DuelPlayerDisconnected(专丞上七七且丝七丗:  专丞上七七且丝七丗, 丆不丐一丙丐丏丗上:  true);
    }
    public void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        this.DuelPlayerDisconnected(专丞上七七且丝七丗:  专丞上七七且丝七丗, 丆不丐一丙丐丏丗上:  false);
    }
    public void DuelPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, bool 丆不丐一丙丐丏丗上)
    {
        var val_3;
        InGameGUI val_14;
        var val_15;
        var val_16;
        一且丐丗丅丈丏丄丅 val_17;
        var val_18;
        val_14 = 专丞上七七且丝七丗;
        val_15 = this;
        if(丆不丐一丙丐丏丗上 == false)
        {
            goto label_15;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_1 = GetEnumerator();
        goto label_9;
        label_10:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(X23.owner == val_14)
        {
                mem2[0] = 1;
        }
        
        label_9:
        if(((-154618576) & 1) != 0)
        {
            goto label_10;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_15:
        if(this.丏专丄丁且丆丐东下 != true)
        {
                this.ReturnBet(三丒丐丒丘丏丗丆丈:  true);
        }
        
        val_17 = this.gameStatus;
        if((val_17 & 4294967294) == 2)
        {
                if(this.丞丘丆下丏丂专一丞 != false)
        {
                this.gameStatus = 7;
            this.丅下丕丘丂丐丏世丟(三丁丂丒不丘丄丂三:  1);
            val_14 = this.duelUI;
            val_14.一万世专上丟丄丐丑(丘丐丌丈丐丝万丏丆:  true);
        }
        else
        {
                this.gameStatus = 1;
            val_14 = this.duelUI;
            val_14.丄丝七丕丄丐丏业丟();
        }
        
            val_17 = this.gameStatus;
        }
        
        if(val_17 == 4)
        {
                val_14 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_14 != 0)
        {
                InGameGUIPart_Duel.__il2cppRuntimeField_byval_arg.SetActive(value:  true);
        }
        
            val_18 = 0f;
            this.gameStatus = 5;
            if(丆不丐一丙丐丏丗上 != true)
        {
                bool val_10 = GameConnect.丕上丐丄三上丝专万();
        }
        
            val_17 = this.gameStatus;
            this.丘丑丌丆与丑丞万三 = (val_10 != true) ? 40f : 20f;
        }
        
        if(val_17 != 7)
        {
                return;
        }
        
        val_15 = val_10.duelUI;
        val_15.丂丄与丆丁丅丅且且(七丐上丁世丆业丒七:  false, 丘丐丌丈丐丝万丏丆:  true);
    }
    public void OnDisconnectedFromPhoton()
    {
        一且丐丗丅丈丏丄丅 val_1 = this.gameStatus;
        if(val_1 == 4)
        {
                val_1 = 8;
            this.gameStatus = val_1;
        }
        
        if(this.丒业丌七三丁一丐上 != true)
        {
                this.ReturnBet(三丒丐丒丘丏丗丆丈:  true);
            val_1 = this.gameStatus;
        }
        
        if(val_1 != 3)
        {
                return;
        }
        
        this.gameStatus = 1;
    }
    private void 丅下丕丘丂丐丏世丟(DuelController.丛丏丂丄上专且万业 三丁丂丒不丘丄丂三)
    {
        this.roomStatus = 三丁丂丒不丘丄丂三;
        UnityEngine.Debug.Log(message:  (三丁丂丒不丘丄丂三 == 1) ? "Room closed!" : "Room opened!");
    }
    private void 丅丄丅七丗与丟下丐()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_7 = 0;
        goto label_7;
        label_21:
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        if((Item[0].Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)) == false)
        {
            goto label_16;
        }
        
        val_7 = 1;
        label_7:
        val_10 = null;
        val_10 = null;
        if(val_7 < Count)
        {
            goto label_21;
        }
        
        return;
        label_16:
        val_11 = null;
        val_11 = null;
        this.opponentNetworkTable = Item[0];
        this.OpponentConnected();
    }
    private void Update()
    {
        var val_56;
        UnityEngine.Object val_57;
        float val_58;
        System.Object[] val_59;
        一且丐丗丅丈丏丄丅 val_60;
        var val_61;
        var val_62;
        UnityEngine.Object val_63;
        object val_64;
        UnityEngine.Object val_65;
        UnityEngine.Object val_66;
        if(this.opponentNetworkTable == 0)
        {
                this.丅丄丅七丗与丟下丐();
        }
        
        if(this.opponentNetworkTable != 0)
        {
                if(this.opponentNetworkTable.丌丑丛业丈丘世丞丕 != 0)
        {
                this.丏专丄丁且丆丐东下 = true;
        }
        
        }
        
        val_56 = null;
        val_56 = null;
        val_57 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if(val_57 != 0)
        {
                this.丒业丌七三丁一丐上 = true;
        }
        
        if(this.gameStatus == 4)
        {
                val_57 = 0;
            val_58 = this.不丄丟丞丄万不丈丌 - UnityEngine.Time.deltaTime;
            this.不丄丟丞丄万不丈丌 = val_58;
            if(val_58 <= 0f)
        {
                this.不丄丟丞丄万不丈丌 = 0f;
            if(this.isMaster != false)
        {
                val_57 = this;
            this.丗丞丙丒七业丂丁三();
        }
        
        }
        
            if(this.isMaster != false)
        {
                val_57 = 0;
            float val_8 = UnityEngine.Time.time;
            if(this.丈丛万不丈与专丐世 < 0)
        {
                val_58 = UnityEngine.Time.time + 0.5f;
            this.丈丛万不丈与专丐世 = val_58;
            object[] val_10 = new object[1];
            val_59 = val_10;
            val_59[0] = this.不丄丟丞丄万不丈丌;
            val_57 = this.丄丈丑丐丆丞丘与丗;
            val_57.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  111, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_10);
        }
        
        }
        
        }
        
        val_60 = this.gameStatus;
        var val_12 = (val_60 == 5) ? 1 : 0;
        if(val_60 == 6)
        {
            goto label_27;
        }
        
        val_12 = val_57.isMaster & val_12;
        if(val_12 == false)
        {
            goto label_28;
        }
        
        label_27:
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = this.丘丑丌丆与丑丞万三 - val_13;
        this.丘丑丌丆与丑丞万三 = val_13;
        val_59 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_59 = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1126"), arg1:  UnityEngine.Mathf.RoundToInt(f:  this.丘丑丌丆与丑丞万三));
            typeof(InGameGUIPart_Duel).__il2cppRuntimeField_28.text = val_59;
        }
        
        val_58 = this.丘丑丌丆与丑丞万三;
        if((val_58 < 0) && (this.gameStatus == 5))
        {
                this.gameStatus = 6;
            typeof(InGameGUIPart_Duel).__il2cppRuntimeField_28.丅下丕丘丂丐丏世丟(三丁丂丒不丘丄丂三:  1);
            val_58 = this.丘丑丌丆与丑丞万三;
        }
        
        if(val_58 < 0)
        {
                val_61 = null;
            val_61 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_62 = null;
            val_62 = null;
            this.不丄丟丞丄万不丈丌 = 0f;
            this.丘丑丌丆与丑丞万三 = 0f;
            this.丗丞丙丒七业丂丁三();
        }
        
        }
        
        val_60 = this.gameStatus;
        label_28:
        if(val_60 != 3)
        {
            goto label_53;
        }
        
        float val_56 = this.丏丟世丑丆世丆丌专;
        float val_19 = UnityEngine.Time.deltaTime;
        val_56 = val_56 - val_19;
        this.丏丟世丑丆世丆丌专 = val_56;
        val_59 = 1152921504838422528;
        val_63 = new UnityEngine.Mathf().duelUI;
        bool val_21 = UnityEngine.Object.op_Inequality(x:  val_63, y:  0);
        if(val_21 == false)
        {
            goto label_58;
        }
        
        if(this.betsEnabled != true)
        {
                if(this.betsWrongVersion == false)
        {
            goto label_60;
        }
        
        }
        
        DuelUIController val_22 = val_21.duelUI;
        val_64 = UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished.ToString();
        val_59 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3476"), arg0:  null));
        if(val_22.versusTimerInBet != null)
        {
            goto label_132;
        }
        
        label_133:
        label_132:
        val_63 = val_22.versusTimerInBet;
        val_63.text = val_59;
        label_58:
        val_58 = this.丏丟世丑丆世丆丌专;
        if(val_58 < 0)
        {
                this.丏丟世丑丆世丆丌专 = 0f;
            if(val_63.isMaster != false)
        {
                this.丝丈万丞丑丑一丅与 = 0;
            this.丞丞下丒丅丅丛世丕();
        }
        
        }
        
        val_60 = this.gameStatus;
        label_53:
        if(val_60 == 2)
        {
                float val_28 = UnityEngine.Time.deltaTime;
            val_28 = this.丏丟世丑丆世丆丌专 - val_28;
            this.丏丟世丑丆世丆丌专 = val_28;
            if(val_28 < 0)
        {
                this.丏丟世丑丆世丆丌专 = 0f;
            if(this.isMaster != false)
        {
                this.丛丅丈丄七丞丟丂丕();
        }
        
        }
        
        }
        
        if(this.enemyCharacter != 0)
        {
                this.enemyCharacter.gameObject.SetActive(value:  this.showEnemyCharacter);
            UnityEngine.GameObject val_34 = this.enemyCharacterPoint.gameObject;
            val_59 = val_34.showMyCharacter;
            val_34.SetActive(value:  val_59);
        }
        
        val_65 = this.myCharacter;
        if(val_65 != 0)
        {
                UnityEngine.GameObject val_38 = this.myCharacter.gameObject;
            val_38.SetActive(value:  val_38.showMyCharacter);
            UnityEngine.GameObject val_41 = this.myCharacterPoint.gameObject;
            val_59 = val_41.showMyCharacter;
            val_65 = val_41;
            val_65.SetActive(value:  val_59);
        }
        
        if(val_65.isMaster != false)
        {
                if(this.gameStatus != 8)
        {
                if(this.gameStatus != 4)
        {
            goto label_93;
        }
        
        }
        
            if(this.opponentNetworkTable == 0)
        {
                val_59 = 1152921505219145728;
            if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                InGameGUIPart_Duel.__il2cppRuntimeField_byval_arg.SetActive(value:  true);
        }
        
            this.gameStatus = 5;
            this.丘丑丌丆与丑丞万三 = 20f;
        }
        
        }
        
        label_93:
        if(this.丘丑丌丆与丑丞万三 >= 0f)
        {
                一且丐丗丅丈丏丄丅 val_57 = this.gameStatus;
            val_57 = val_57 - 5;
            if((val_57 <= 1) && (this.opponentNetworkTable != 0))
        {
                val_59 = 1152921505219145728;
            val_66 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_66 != 0)
        {
                val_66 = InGameGUIPart_Duel.__il2cppRuntimeField_byval_arg;
            val_66.SetActive(value:  false);
        }
        
            this.gameStatus = 4;
            if(val_66.isMaster != false)
        {
                this.业丞七丞丗丞丆丝丙();
        }
        
        }
        
        }
        
        if(this.betsEnabled == false)
        {
                return;
        }
        
        if(this.opponentNetworkTable == 0)
        {
                return;
        }
        
        if(this.opponentNetworkTable.丌丑丛业丈丘世丞丕 == 0)
        {
                return;
        }
        
        this.丁丌一丈三丌世丘丁 = true;
        return;
        label_60:
        this.丝丈万丞丑丑一丅与 = UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished;
        DuelUIController val_52 = val_21.duelUI;
        TweenScale val_53 = val_52.versusTimer.GetComponent<TweenScale>();
        if(val_53 != null)
        {
                val_53.ResetToBeginning();
        }
        else
        {
                0.ResetToBeginning();
        }
        
        val_53.PlayForward();
        DuelUIController val_54 = val_53.duelUI;
        if(val_19 <= 0f)
        {
            goto label_129;
        }
        
        string val_55 = UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished.ToString();
        if(val_54.versusTimer != null)
        {
            goto label_132;
        }
        
        goto label_133;
        label_129:
        if(val_54.versusTimer != null)
        {
            goto label_132;
        }
        
        goto label_133;
    }
    private CharacterInterfaceV2 丝丅与丒东世丒丁丕(UnityEngine.Transform 不丂丅丁且丆东东丂)
    {
        var val_8;
        UnityEngine.GameObject val_1 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Character_model_V2");
        val_1.SetActive(value:  false);
        UnityEngine.Vector3 val_2 = 不丂丅丁且丆东东丂.position;
        UnityEngine.Quaternion val_3 = 不丂丅丁且丆东东丂.rotation;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        if(val_4 != null)
        {
                val_8 = val_4.GetComponent<CharacterInterfaceV2>();
        }
        else
        {
                val_8 = val_4.GetComponent<CharacterInterfaceV2>();
        }
        
        val_4.transform.SetParent(p:  不丂丅丁且丆东东丂);
        val_1.SetActive(value:  true);
        if(val_8 != null)
        {
                val_8.世丅三丈丐丒万丈万(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_8.世丅三丈丐丒万丈万(丙业与丙丗丝不丈东:  true);
        }
        
        val_8.丟且丟七丌丞专七丁();
        return (CharacterInterfaceV2)val_8;
    }
    private void 下丂丂丙丘不东丟丄(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘, string 丅丈丘万丁不丑业三)
    {
        this.上丛丆丛丐丕一一丏(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
    }
    private void 专丕丒丘业丘专下一(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘)
    {
        this.上丛丆丛丐丕一一丏(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
    }
    private void 上丛丆丛丐丕一一丏(CategoryNames 七丆丒与丗丌丄且丂)
    {
        this.SendMyWearInvisible();
        if((七丆丒与丗丌丄且丂 - 6) > 6)
        {
                return;
        }
        
        var val_6 = 106014908 + ((七丆丒与丗丌丄且丂 - 6)) << 2;
        val_6 = val_6 + 106014908;
        goto (106014908 + ((七丆丒与丗丌丄且丂 - 6)) << 2 + 106014908);
    }
    public void SetShopEvents()
    {
        var val_18;
        var val_19;
        System.Action<System.String> val_20;
        丆丟七丌丞东丆丕丌.丂下下丒丘丙丘丟一(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  this, method:  System.Void DuelController::下丂丂丙丘不东丟丄(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘, string 丅丈丘万丁不丑业三)));
        丆丟七丌丞东丆丕丌.丝丏不丝丕丒一三丗(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String, System.String>(object:  this, method:  System.Void DuelController::下丂丂丙丘不东丟丄(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘, string 丅丈丘万丁不丑业三)));
        丆丟七丌丞东丆丕丌.不丕丘业专丐丙万丑(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  this, method:  System.Void DuelController::专丕丒丘业丘专下一(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘)));
        丆丟七丌丞东丆丕丌.丒专丑丅丐丂且丌丐(丙业与丙丗丝不丈东:  new System.Action<CategoryNames, System.String>(object:  this, method:  System.Void DuelController::专丕丒丘业丘专下一(CategoryNames 七丆丒与丗丌丄且丂, string 与万丌丙东七丁上丘)));
        val_18 = null;
        val_18 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_7;
        }
        
        val_19 = null;
        val_19 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.且与丛丈丁丟专丈丑 = new System.Action<System.String>(object:  this, method:  System.Void DuelController::丈丌七丏丅与七专世(string 丞丅上丏丂且下丅与));
        val_20 = System.Delegate.Combine(a:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈, b:  new System.Action<System.String>(object:  this, method:  System.Void DuelController::丕丕东丑丑丘三丑丗(string 丞丅上丏丂且下丅与)));
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
            goto label_12;
        }
        
        if(val_20 != null)
        {
            goto label_13;
        }
        
        goto label_16;
        label_12:
        if(val_20 == null)
        {
            goto label_16;
        }
        
        label_13:
        if(null != null)
        {
                val_20 = 0;
        }
        
        label_16:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈 = val_20;
        label_7:
        丛且丗丌丏下七下丈.世丄业三一丞丅丌七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void DuelController::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
        丛且丗丌丏下七下丈.丕丞东上丗丄丞东丈(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void DuelController::与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)));
        if(this.东丏与丆专不丐丛丁 != true)
        {
                this.东丏与丆专不丐丛丁 = true;
            Rilisoft.PetsManager.且丛七丟丄丈丑丏丐(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  public System.Void DuelController::OnPetEquipAction(string 三丗丕丏三丄丑丄丙, string 丙上丌世不丒一业七)));
        }
        
        丛且丗丌丏下七下丈.丑丌下丟且丒三丝丙(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void DuelController::丕丕东丑丑丘三丑丗(string 丞丅上丏丂且下丅与)));
        三丐下丁丒丆丘下丄.万丒丐丕丈丏上业丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::东丛丑丅专一丌丕下()));
        三丐下丁丒丆丘下丄.七丏丄丝业丟世业丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::东丛丑丅专一丌丕下()));
        三丐下丁丒丆丘下丄.丝且丁丌丟丑业且丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::丅且三东丗丂丗下丑()));
        三丐下丁丒丆丘下丄.下丛丌下丈丒丟七七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::丅且三东丗丂丗下丑()));
    }
    private void 与丐丑丄丕东专一丘(string 且丆丏丛东下上丄丟)
    {
        this.SendMyWearInvisible();
        this.SetMyHat();
        this.SendMyHat();
    }
    private void 且丘丏丂丏丆丌世一(string 丞丅上丏丂且下丅与)
    {
        this.SetMySkin();
        this.SendMySkin();
    }
    private void 丆七专丂丐丞且丒丑(string 丞丅上丏丂且下丅与)
    {
        this.SetMyAvatar();
        this.SendMyAvatar();
    }
    private void 丕丕东丑丑丘三丑丗(string 丞丅上丏丂且下丅与)
    {
        if((System.String.op_Inequality(a:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈(), b:  "EMPTY_ROYALE_AVATAR")) != false)
        {
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈())) != false)
        {
                this.SetMyAvatar();
            this.SendMyAvatar();
            return;
        }
        
        }
        
        if((System.String.op_Equality(a:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈(), b:  "EMPTY_ROYALE_AVATAR")) != true)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈())) == false)
        {
                return;
        }
        
        }
        
        this.SetMyWeapon();
        this.SendMyWeapon();
        this.SetMySkin();
        this.SendMySkin();
    }
    private void 丂丆丝业丛丒上丑丑()
    {
        var val_9;
        var val_10;
        System.Action<System.String> val_11;
        val_9 = null;
        val_9 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_5;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = System.Delegate.Remove(source:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈, value:  new System.Action<System.String>(object:  this, method:  System.Void DuelController::丕丕东丑丑丘三丑丗(string 丞丅上丏丂且下丅与)));
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
            goto label_9;
        }
        
        if(val_11 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_11 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_13:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丝业丑丑丆丆丞丈 = val_11;
        label_5:
        丛且丗丌丏下七下丈.上丛丗丐下丅专东丟(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void DuelController::丕丕东丑丑丘三丑丗(string 丞丅上丏丂且下丅与)));
        三丐下丁丒丆丘下丄.万丒丐丕丈丏上业丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::东丛丑丅专一丌丕下()));
        三丐下丁丒丆丘下丄.丝且丁丌丟丑业且丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::丅且三东丗丂丗下丑()));
        if(this.东丏与丆专不丐丛丁 == false)
        {
                return;
        }
        
        this.东丏与丆专不丐丛丁 = false;
        Rilisoft.PetsManager.丝丅丑丆三与丛丟丞(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  public System.Void DuelController::OnPetEquipAction(string 三丗丕丏三丄丑丄丙, string 丙上丌世不丒一业七)));
    }
    public void OnPetEquipAction(string 三丗丕丏三丄丑丄丙, string 丙上丌世不丒一业七)
    {
    
    }
    private void 东丛丑丅专一丌丕下()
    {
        var val_1;
        this.SetMyWearInvisible();
        val_1 = null;
        val_1 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        this.SendMyWearInvisible();
    }
    private void 丅且三东丗丂丗下丑()
    {
        var val_1;
        this.SetMyArmor();
        val_1 = null;
        val_1 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        this.SendMyArmor();
    }
    private void 丒丅丑丂丌丘丈丟丞(int 丏业丟一东丂东丘丛)
    {
    
    }
    public void AddOpponentToFriends()
    {
        var val_9;
        string val_10;
        var val_11;
        if(this.opponentNetworkTable == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.opponentNetworkTable.丈三世丞丕万丄七丂)) == true)
        {
                return;
        }
        
        if((this.opponentNetworkTable.丈三世丞丕万丄七丂.Equals(value:  "-1")) == true)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_6 != null)
        {
                val_6.Add(key:  "Added Friends", value:  "Duel");
        }
        else
        {
                val_6.Add(key:  "Added Friends", value:  "Duel");
        }
        
        val_6.Add(key:  "Deleted Friends", value:  "Add");
        丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丙与丗世丏丅丈丞万(丄丒且丙三丆丟与丏:  this.opponentNetworkTable.丈三世丞丕万丄七丂, 下丏丏世丈丌丕丛与:  val_6, 业丏丈世世世丞丒世:  0);
        val_9 = null;
        val_9 = null;
        val_10 = this.opponentNetworkTable.丈三世丞丕万丄七丂;
        if((Contains(item:  val_10)) != true)
        {
                val_11 = null;
            val_11 = null;
            val_10 = this.opponentNetworkTable.丈三世丞丕万丄七丂;
            Add(item:  val_10);
        }
        
        this.丁丞丛丂七丝且丐丞();
    }
    private void 丁丞丛丂七丝且丐丞()
    {
        var val_15;
        var val_16;
        string val_17;
        bool val_18;
        var val_19;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.opponentNetworkTable, y:  0);
        if((((val_1 != false) && ((System.String.IsNullOrEmpty(value:  this.opponentNetworkTable.丈三世丞丕万丄七丂)) != true)) && ((this.opponentNetworkTable.丈三世丞丕万丄七丂.Equals(value:  "-1")) != true)) && (丐丞丞丏丞业丄一丈.七万专丕丝丅丟丐丗() != false))
        {
                val_15 = null;
            val_15 = null;
            val_16 = FriendsController.丄丞丁丈与业上丞丟.IsShowAdd(业丗丑丝丙业丝丏上:  this.opponentNetworkTable.丈三世丞丕万丄七丂);
        }
        else
        {
                val_16 = 0;
        }
        
        DuelUIController val_6 = val_1.duelUI;
        val_6.btnAddFriend.gameObject.SetActive(value:  false);
        val_17 = this.opponentNetworkTable.丈三世丞丕万丄七丂;
        if((丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().与丂丑丆上专业丂丑(丄丒且丙三丆丟与丏:  val_17)) == true)
        {
            goto label_20;
        }
        
        val_17 = this.opponentNetworkTable.丈三世丞丕万丄七丂;
        if((丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Contains(item:  val_17)) == false)
        {
            goto label_26;
        }
        
        label_20:
        val_18 = 1;
        goto label_27;
        label_26:
        val_19 = null;
        val_19 = null;
        val_17 = this.opponentNetworkTable;
        string val_15 = this.opponentNetworkTable.丈三世丞丕万丄七丂;
        bool val_13 = Contains(item:  val_15);
        val_18 = val_13;
        label_27:
        DuelUIController val_14 = val_13.duelUI;
        val_15 = val_18;
        val_14.btnAddFriendChek.SetActive(value:  val_15);
    }
    public void InitializePlayersInfo()
    {
        if(this.myPlayerInfo == 0)
        {
                return;
        }
        
        if(this.opponentPlayerInfo == 0)
        {
                return;
        }
        
        this.myPlayerInfo.SetPointInWorld(丐丝世与且不与上丁:  this.myCharacter.丁丝一下丁不七丗一(), 世丟丈丏丕万丝丆万:  this.myCharacter.transform);
        this.opponentPlayerInfo.SetPointInWorld(丐丝世与且不与上丁:  this.enemyCharacter.丁丝一下丁不七丗一(), 世丟丈丏丕万丝丆万:  this.enemyCharacter.transform);
    }
    public void UpdateCharactersInfo()
    {
        var val_12;
        if(this.myPlayerInfo == 0)
        {
                return;
        }
        
        if(this.opponentPlayerInfo == 0)
        {
                return;
        }
        
        this.opponentPlayerInfo.gameObject.SetActive(value:  this.showEnemyCharacter);
        if(this.showEnemyCharacter != false)
        {
                if(this.opponentNetworkTable != 0)
        {
                this.opponentPlayerInfo.丁不丒东三专丒丝丗(不且上一上丐三万丛:  this.opponentNetworkTable);
        }
        
        }
        
        UnityEngine.GameObject val_8 = this.myPlayerInfo.gameObject;
        val_8.SetActive(value:  val_8.showMyCharacter);
        if(val_8.showMyCharacter == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        this.myPlayerInfo.丁不丒东三专丒丝丗(不且上一上丐三万丛:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable);
    }
    private void 丛丈丌丗丘丐丒丂丄(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.下万东上丟丏且七业 = 0;
        mem[1152921525930925576] = 0;
    }
    internal int 丂丂三专七东丏业丅()
    {
    
    }
    public Rilisoft.上专业三丟丁丞专下 GetBetConfigByIndex(int 丞世不丒下上上丝丑)
    {
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 == null)
        {
                return (Rilisoft.上专业三丟丁丞专下)val_2.丄三丐丟丗丄丟上丞().Item[丞世不丒下上上丝丑];
        }
        
        return (Rilisoft.上专业三丟丁丞专下)val_2.丄三丐丟丗丄丟上丞().Item[丞世不丒下上上丝丑];
    }
    private Rilisoft.丝三丕七业丗丂丆三 丂下丘丞万丌业与丛(int 丞世不丒下上上丝丑)
    {
        return (Rilisoft.丝三丕七业丗丂丆三)this.丕世丗一丈与丕丕万[((long)(int)(丞世不丒下上上丝丑)) << 2];
    }
    public void ReturnBet(bool 三丒丐丒丘丏丗丆丈 = True)
    {
        string val_3;
        if(this.丆丛东丐丄丄丞丄丐 != 1)
        {
                if(this.七丅丞世丑丒七上丈 != null)
        {
                val_3 = this.七丅丞世丑丒七上丈.东与三丌丅三丒丏业();
            BankController.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_3, 丌丒丝东丌下丕丁丅:  this.下万东上丟丏且七业, 丛丞万三下丘七丌丅:  false, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  31, 丟世且丕丂丁万丒万:  0);
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this.七丅丞世丑丒七上丈 = 0;
            this.下万东上丟丏且七业 = 0;
            mem[1152921525931497480] = 0;
        }
        
            this.丆丛东丐丄丄丞丄丐 = 0;
        }
        
        if(三丒丐丒丘丏丗丆丈 == false)
        {
                return;
        }
        
        this.ResetBet();
    }
    public void ResetBet()
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this.丆丛东丐丄丄丞丄丐 = 0;
        this.丑丂与丂丘上三丌不 = 0;
        this.丒不丟丐丆七丆丕三 = 0;
        this.不丐丈下专与丒丗丑 = 0;
        this.丆与丙丂丑与丈丌丗 = false;
        mem[1152921525931617672] = 0;
        this.七丅丞世丑丒七上丈 = 0;
        this.下万东上丟丏且七业 = 0;
    }
    public bool HaveBet()
    {
        return (bool)(this.丆丛东丐丄丄丞丄丐 != 1) ? 1 : 0;
    }
    internal int 丄万丄丆丂丝世三丞(bool 专东丘一三丐不丈专)
    {
        DuelController val_4;
        var val_5;
        var val_6;
        val_4 = 1152921505058017280;
        val_5 = null;
        val_5 = null;
        if(DuelController.丄丘七三上丕世丞业.betsEnabled == false)
        {
                return 0;
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = DuelController.丄丘七三上丕世丞业;
        if(DuelController.丄丘七三上丕世丞业.丆丛东丐丄丄丞丄丐 == 1)
        {
                return 0;
        }
        
        if(this.丆丛东丐丄丄丞丄丐 == 1)
        {
                return 0;
        }
        
        if(专东丘一三丐不丈专 == true)
        {
                return 0;
        }
        
        if(this.丁丌一丈三丌世丘丁 == false)
        {
                return 0;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 == null)
        {
                return 0;
        }
        
        Rilisoft.上专业三丟丁丞专下 val_3 = val_2.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐);
        if(val_3 == null)
        {
                return 0;
        }
        
        return val_3.业上丙丞丐丄丆丅七();
    }
    public int PayBetReward(bool 专东丘一三丐不丈专)
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        string val_22;
        val_18 = null;
        val_18 = null;
        if(DuelController.丄丘七三上丕世丞业.betsEnabled == false)
        {
                return 0;
        }
        
        val_19 = null;
        val_19 = null;
        if((DuelController.丄丘七三上丕世丞业.丆丛东丐丄丄丞丄丐 == 1) || (this.丆丛东丐丄丄丞丄丐 == 1))
        {
                return 0;
        }
        
        val_20 = null;
        val_20 = null;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable, y:  0);
        if(val_1 != false)
        {
                val_21 = null;
            val_21 = null;
            if((System.String.op_Inequality(a:  val_1.WinnerID, b:  NetworkStartTable.__il2cppRuntimeField_method_count)) != false)
        {
                return 0;
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  41);
        if((专东丘一三丐不丈专 == true) || (this.丁丌一丈三丌世丘丁 == false))
        {
            goto label_30;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_6 == null)
        {
            goto label_30;
        }
        
        Rilisoft.上专业三丟丁丞专下 val_7 = val_6.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐);
        if(val_7 == null)
        {
            goto label_30;
        }
        
        Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().且下下丆丝丛丑丅丏(丐东业丕丕丂丗丅丙:  val_7.业上丙丞丐丄丆丅七(), 丁丅丈丌丟世丗丗丟:  0, 下丅三丈世丐丕丌丑:  1, 三丙世丒丙丘一丗上:  true);
        if(this.opponentNetworkTable != 0)
        {
            goto label_36;
        }
        
        val_22 = "-1";
        goto label_37;
        label_30:
        label_57:
        this.ReturnBet(三丒丐丒丘丏丗丆丈:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return 0;
        label_36:
        val_22 = this.opponentNetworkTable.丈三世丞丕万丄七丂;
        label_37:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        PGCompany.Analytics.一业丗丆世世上丁且.东东上丟丏且丑三丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丐下丝丘丑丟丟丗丌:  this.丕世丗一丈与丕丕万[(this.丆丛东丐丄丄丞丄丐) << 2][32].ToString(), 三丒三丒一专丈万丑:  mem[this.opponentNetworkTable.丈三世丞丕万丄七丂]);
        if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  106, 丞丅上丏丂且下丅与:  Rilisoft.上专业三丟丁丞专下.丛丕七丞丟世丒丈七(丞丅上丏丂且下丅与:  val_7.业上丙丞丐丄丆丅七()), 丂丕丂丏专丂丄丕且:  1))) == false)
        {
            goto label_57;
        }
        
        PGCompany.世东三上七丂丌下丑.东丐丗三丛丟三丁七(丅一丘丙上东丏丅不:  new 丕丝丝丝丅丕专丅丝() {且丝丕丆不丅丏丛东 = new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = false}});
        goto label_57;
    }
    public Rilisoft.上专业三丟丁丞专下 GetSelectedBetChest()
    {
        if(this.不丐丈下专与丒丗丑 != 1)
        {
                return this.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.不丐丈下专与丒丗丑);
        }
        
        UnityEngine.Debug.LogError(message:  "No bet in this match!");
        return 0;
    }
    public Rilisoft.丝三丕七业丗丂丆三 GetCurrentBet()
    {
        if(this.丆丛东丐丄丄丞丄丐 != 1)
        {
                return this.丂下丘丞万丌业与丛(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐);
        }
        
        UnityEngine.Debug.LogError(message:  "No bet in this match!");
        return 0;
    }
    private void 丌丈丏上丌世丗丛丒()
    {
        var val_19;
        Rilisoft.上专业三丟丁丞专下 val_20;
        var val_21;
        val_19 = this;
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 == null)
        {
                return;
        }
        
        this.ResetBet();
        DuelUIController val_3 = this.duelUI;
        val_20 = 0;
        val_3.业丛七一丄丝下丅丛(丝丏业丅丈东业丝丒:  val_2.业上丙丞丐丄丆丅七());
        val_21 = 0;
        goto label_6;
        label_13:
        DuelUIController val_5 = val_3.duelUI;
        DuelBetItem val_19 = val_5.betItems[0];
        val_20 = this.GetBetConfigByIndex(丞世不丒下上上丝丑:  0);
        val_19.InitializeBet(丞世不丒下上上丝丑:  0, 东丁与一丝丑丅业丑:  val_20, 丝丏业丅丈东业丝丒:  val_2.业上丙丞丐丄丆丅七());
        val_21 = 1;
        label_6:
        DuelUIController val_8 = val_19.duelUI;
        if(val_21 < val_8.betItems.Length)
        {
            goto label_13;
        }
        
        this.丘丌丅丏不丙与丈东(丈丅丕丄丙丅丒丟丟:  true);
        val_9.resetScrollNow = true;
        DuelUIController val_10 = this.duelUI.duelUI;
        val_19 = ???;
        goto typeof(UIScrollView).__il2cppRuntimeField_1E8;
    }
    public void OpenBet(int 万丙丈丙丄丅丝专上)
    {
        Rilisoft.丝三丕七业丗丂丆三 val_7;
        if(this.丆丛东丐丄丄丞丄丐 > 万丙丈丙丄丅丝专上)
        {
                return;
        }
        
        if(this.不丐丈下专与丒丗丑 == 万丙丈丙丄丅丝专上)
        {
                return;
        }
        
        this.不丐丈下专与丒丗丑 = 万丙丈丙丄丅丝专上;
        this.丘丌丅丏不丙与丈东(丈丅丕丄丙丅丒丟丟:  false);
        if(this.不丐丈下专与丒丗丑 != 1)
        {
                val_7 = this.丂下丘丞万丌业与丛(丞世不丒下上上丝丑:  this.不丐丈下专与丒丗丑);
        }
        else
        {
                val_7 = 0;
        }
        
        Rilisoft.丝三丕七业丗丂丆三 val_2 = this.丂下丘丞万丌业与丛(丞世不丒下上上丝丑:  this.不丐丈下专与丒丗丑);
        val_2.不与丘丈世专一丝丞(丞世不丒下上上丝丑:  万丙丈丙丄丅丝专上);
        DuelUIController val_3 = val_2.duelUI;
        val_3.caseAnimationWrapper.ClearAnimations();
        DuelUIController val_4 = val_3.caseAnimationWrapper.duelUI;
        val_4.caseAnimationWrapper.AddCaseAnimation(丞丂世丏万上上丘丗:  val_7, 世丒丌丆丁丝丒三丕:  val_2, 丐丐七专三且世三七:  3, 丝上丑业丙下丂万与:  (this.不丐丈下专与丒丗丑 == 1) ? 1 : 0);
        DuelUIController val_6 = val_4.caseAnimationWrapper.duelUI;
        val_6.btnShowBetInfo.RotateToDefault();
    }
    private void 不与丘丈世专一丝丞(int 丞世不丒下上上丝丑)
    {
        this.duelUI.丝丈下丝且丛丄世丆(丛丅丘一丏丙且丌上:  true, 上丆丗专丁且万丐三:  丞世不丒下上上丝丑);
    }
    private void 丆丆东七下丄七丅下(bool 丒万丂专专业一下东)
    {
        int val_9 = UnityEngine.Mathf.Min(a:  this.丑丂与丂丘上三丌不, b:  this.丒不丟丐丆七丆丕三);
        int val_2 = UnityEngine.Mathf.Max(a:  this.丑丂与丂丘上三丌不, b:  this.丒不丟丐丆七丆丕三);
        if(val_9 < val_2)
        {
                DuelUIController val_5 = val_2.duelUI;
            val_5.三丈丙一丈下万丘丛(上丆丗专丁且万丐三:  (丒万丂专专业一下东 != true) ? (this.丒不丟丐丆七丆丕三) : (this.丑丂与丂丘上三丌不), 丒万丂专专业一下东:  丒万丂专专业一下东, 世丟丑丈下世丌丐丝:  false);
        }
        
        if(val_9 == this.丆丛东丐丄丄丞丄丐)
        {
                if(丒万丂专专业一下东 != false)
        {
                val_9 = this.丒不丟丐丆七丆丕三;
        }
        else
        {
                val_9 = this.丑丂与丂丘上三丌不;
        }
        
        }
        
        val_5.duelUI.三丈丙一丈下万丘丛(上丆丗专丁且万丐三:  val_9, 丒万丂专专业一下东:  丒万丂专专业一下东, 世丟丑丈下世丌丐丝:  (val_9 != this.丆丛东丐丄丄丞丄丐) ? 1 : 0);
    }
    private void 丘丌丅丏不丙与丈东(bool 丈丅丕丄丙丅丒丟丟 = False)
    {
        var val_30;
        var val_31;
        bool val_32;
        var val_33;
        var val_34;
        val_30 = this;
        if(this.不丐丈下专与丒丗丑 != this.丒不丟丐丆七丆丕三)
        {
                if(this.不丐丈下专与丒丗丑 != this.丆丛东丐丄丄丞丄丐)
        {
            goto label_1;
        }
        
        }
        
        val_31 = 0;
        val_32 = 0;
        goto label_2;
        label_1:
        val_32 = ((this.不丐丈下专与丒丗丑 > this.丒不丟丐丆七丆丕三) ? 1 : 0) & ((this.不丐丈下专与丒丗丑 != this.丑丂与丂丘上三丌不) ? 1 : 0);
        label_2:
        DuelUIController val_4 = this.duelUI;
        UnityEngine.GameObject val_5 = val_4.btnMakeBet.gameObject;
        val_5.SetActive(value:  val_32);
        DuelUIController val_6 = val_5.duelUI;
        UnityEngine.GameObject val_7 = val_6.btnAcceptBet.gameObject;
        val_7.SetActive(value:  (this.不丐丈下专与丒丗丑 == this.丑丂与丂丘上三丌不) ? 1 : 0);
        val_33 = 0;
        val_34 = 0;
        goto label_9;
        label_40:
        if(this.丆丛东丐丄丄丞丄丐 <= val_33)
        {
            goto label_10;
        }
        
        DuelUIController val_8 = val_7.duelUI;
        bool val_10 = val_8.betItems[0].gameObject.activeSelf;
        if(val_10 == false)
        {
            goto label_22;
        }
        
        DuelUIController val_11 = val_10.duelUI;
        val_11.betItems[0].gameObject.SetActive(value:  false);
        val_34 = 1;
        goto label_22;
        label_10:
        DuelUIController val_13 = val_7.duelUI;
        bool val_15 = val_13.betItems[0].gameObject.activeSelf;
        if(val_15 != true)
        {
                DuelUIController val_16 = val_15.duelUI;
            UnityEngine.GameObject val_17 = val_16.betItems[0].gameObject;
            val_34 = 1;
            val_17.SetActive(value:  true);
        }
        
        DuelUIController val_18 = val_17.duelUI;
        DuelBetItem val_33 = val_18.betItems[0];
        val_33.UpdateBet(丄专丕丈万丈不丑且:  (val_33 == this.不丐丈下专与丒丗丑) ? 1 : 0, 丟丈丟丌丕且东世三:  false, 丟丝丁丌丞业业丘丅:  (val_33 == this.丑丂与丂丘上三丌不) ? 1 : 0, 丅丏东专三丌丑丏丏:  (val_33 == this.丆丛东丐丄丄丞丄丐) ? 1 : 0, 七丑丕一业三专丆一:  (val_33 == this.丒不丟丐丆七丆丕三) ? 1 : 0);
        label_22:
        val_33 = 1;
        label_9:
        DuelUIController val_23 = val_33.duelUI;
        if(val_33 < val_23.betItems.Length)
        {
            goto label_40;
        }
        
        if((val_34 & 1) == 0)
        {
                return;
        }
        
        this.且专丟丈丑丞丁丌丌(专丟丐万专丘业业丄:  丈丅丕丄丙丅丒丟丟);
        this.MoveBetScrollToStart();
        if(丈丅丕丄丙丅丒丟丟 == false)
        {
                return;
        }
        
        DuelUIController val_25 = this.duelUI;
        bool val_27 = val_25.betScrollView.gameObject.activeInHierarchy;
        val_30 = val_27.duelUI;
        if(val_30 == null)
        {
            goto label_46;
        }
        
        if(val_27 == false)
        {
            goto label_47;
        }
        
        label_49:
        val_28.betScrollView.ResetPosition();
        return;
        label_46:
        if(val_27 == true)
        {
            goto label_49;
        }
        
        label_47:
        val_28.makeBetScrollResetOnEnable = true;
    }
    private void 且专丟丈丑丞丁丌丌(bool 专丟丐万专丘业业丄)
    {
        float val_9;
        var val_21;
        var val_22;
        float val_24;
        if(this.上丟丂丙丝丝世三丞 != true)
        {
                DuelUIController val_1 = this.duelUI;
            val_21 = val_1.betScrollView.gameObject;
            bool val_3 = val_21.activeInHierarchy;
            if(val_3 == false)
        {
                return;
        }
        
        }
        
        DuelUIController val_4 = val_3.duelUI;
        val_22 = public UIPanel UnityEngine.Component::GetComponent<UIPanel>();
        val_21 = val_4.betScrollView.GetComponent<UIPanel>();
        if(this.上丟丂丙丝丝世三丞 == false)
        {
            goto label_8;
        }
        
        if(专丟丐万专丘业业丄 == true)
        {
            goto label_13;
        }
        
        label_18:
        UnityEngine.Vector4 val_6 = val_21.finalClipRegion;
        val_24 = val_6.z;
        DuelUIController val_7 = val_21.duelUI;
        val_22 = 0;
        if(val_24 >= 0)
        {
            goto label_13;
        }
        
        return;
        label_8:
        this.丞下业且专专专丏七 = X22 + 28;
        val_22 = 0;
        this.不丛专丘丑丝丟丅丝 = X22 + 28;
        UnityEngine.Vector4 val_10 = val_21.finalClipRegion;
        this.丝丕丘丄与丑丄丁丝 = val_10.z;
        this.上丟丂丙丝丝世三丞 = true;
        if(专丟丐万专丘业业丄 == false)
        {
            goto label_18;
        }
        
        label_13:
        DuelUIController val_11 = val_21.duelUI;
        float val_20 = val_9;
        val_24 = val_20;
        val_20 = this.丝丕丘丄与丑丄丁丝 - val_24;
        val_20 = val_20 * 0.5f;
        var val_15 = (专丟丐万专丘业业丄 != true) ? 0 : UnityEngine.Mathf.Max(a:  0, b:  (UnityEngine.Mathf.RoundToInt(f:  val_20)) - 13);
        mem2[0] = this.丞下业且专专专丏七 + val_15;
        mem2[0] = this.不丛专丘丑丝丟丅丝 - val_15;
        val_21.ResetAnchors();
        val_21.UpdateAnchors();
        DuelUIController val_18 = val_21.duelUI;
        val_18.betScrollView.enabled = 专丟丐万专丘业业丄;
    }
    public void MoveBetScrollToStart()
    {
        var val_25;
        var val_26;
        var val_27;
        DuelUIController val_1 = this.duelUI;
        bool val_3 = val_1.betScrollView.gameObject.activeInHierarchy;
        if(val_3 == false)
        {
                return;
        }
        
        DuelUIController val_4 = val_3.duelUI;
        val_4.betScrollView.DisableSpring();
        DuelUIController val_5 = val_4.betScrollView.duelUI;
        val_25 = 0;
        goto label_12;
        label_21:
        DuelUIController val_7 = val_5.betScrollView.GetComponent<UIPanel>().duelUI;
        bool val_9 = val_7.betItems[0].gameObject.activeSelf;
        if(val_9 == true)
        {
            goto label_18;
        }
        
        val_25 = 1;
        label_12:
        DuelUIController val_10 = val_9.duelUI;
        if(val_25 < val_10.betItems.Length)
        {
            goto label_21;
        }
        
        goto label_27;
        label_18:
        DuelUIController val_11 = val_9.duelUI;
        val_26 = val_11.betItems[0].transform;
        if(val_26 == null)
        {
            goto label_27;
        }
        
        val_27 = 0;
        goto label_28;
        label_27:
        val_26 = 0;
        val_27 = 1;
        label_28:
        UnityEngine.Vector3 val_14 = val_26.transform.position;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_17 = val_26.GetComponent<UnityEngine.BoxCollider>().size;
        UnityEngine.Vector3 val_18 = val_26.lossyScale;
        val_18.x = val_17.x * val_18.x;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  val_18.x * 0.5f);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        if(this.丑丂丂七丘东丅七东 != false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ???, y = ???, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Coroutine val_24 = this.StartCoroutine(routine:  this.丐丄且丕丗丄七丐丛(丞丕丙不一丙业三丕:  val_22.x));
    }
    private System.Collections.IEnumerator 丐丄且丕丗丄七丐丛(float 丞丕丙不一丙业三丕)
    {
        DuelController.丙丏与与丆丘丑世七 val_1 = new DuelController.丙丏与与丆丘丑世七(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丞丕丙不一丙业三丕 = 丞丕丙不一丙业三丕;
        return (System.Collections.IEnumerator)val_1;
    }
    public void TryMakeBet()
    {
        if(this.不丐丈下专与丒丗丑 == 1)
        {
                return;
        }
        
        丈丞丕丘丕丗与上一 val_2 = this.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.不丐丈下专与丒丗丑).且丙东丞一丐万丕万();
        int val_5 = val_2.丟丂丞不专丆万丒世();
        val_5 = val_5 - this.下万东上丟丏且七业;
        if((val_5 & 2147483648) != 0)
        {
                return;
        }
        
        this.丐丅丄丕上丞丏丌丌(丞丈与丒丙丟丆丏不:  val_2, 丏丂不专上丘丂不丅:  val_5, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void DuelController::丆丑丘丕上万一世丙()));
    }
    internal bool 丙丝上丈七丐丁丟世()
    {
        Rilisoft.上专业三丟丁丞专下 val_1 = this.GetBetConfigByIndex(丞世不丒下上上丝丑:  0);
        if(val_1 == null)
        {
                return (bool)val_1;
        }
        
        return System.String.op_Equality(a:  val_1.且丙东丞一丐万丕万().东与三丌丅三丒丏业(), b:  "EventCurrency");
    }
    public void MakeBet(int 万丙丈丙丄丅丝专上)
    {
        this.丒不丟丐丆七丆丕三 = 万丙丈丙丄丅丝专上;
        this.不丐丈下专与丒丗丑 = 万丙丈丙丄丅丝专上;
        object[] val_1 = new object[1];
        val_1[0] = 万丙丈丙丄丅丝专上;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  141, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        this.丆丆东七下丄七丅下(丒万丂专专业一下东:  true);
        this.丘三三且与丏丑世丈();
        this.丘丌丅丏不丙与丈东(丈丅丕丄丙丅丒丟丟:  false);
        if(this.丆与丙丂丑与丈丌丗 != false)
        {
                this.丐丌丅丙丁丕丛下丐();
        }
        
        this.不与丘丈世专一丝丞(丞世不丒下上上丝丑:  万丙丈丙丄丅丝专上);
        this.丂丌业与丝不下丞七(三丌且丙丝丅下一丘:  this.丑丂与丂丘上三丌不, 丈丆丁丒丅业丛丙丗:  this.不丐丈下专与丒丗丑, 丞三丞世专丝丆业业:  this.丆丛东丐丄丄丞丄丐, 丂丆一丄且丌丛丈业:  this.丆丛东丐丄丄丞丄丐, 专丑丐丙丈丂丙丐三:  万丙丈丙丄丅丝专上, 丒万丂专专业一下东:  true);
        string val_5 = this.GetBetConfigByIndex(丞世不丒下上上丝丑:  万丙丈丙丄丅丝专上).且丙东丞一丐万丕万().东与三丌丅三丒丏业();
        Rilisoft.一丟专且三万丞丁丂.丅丗世丄专业东丗丞(丂丐丄丁丆与丈丂上:  (this.丆丛东丐丄丄丞丄丐 == 1) ? "Bet" : "Raise", 下下丏一丙不丘丌丞:  System.String.Format(format:  "Bet_{0}_{1}", arg0:  val_5, arg1:  val_5.GetBetConfigByIndex(丞世不丒下上上丝丑:  万丙丈丙丄丅丝专上).且丙东丞一丐万丕万().丟丂丞不专丆万丒世()));
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "DuelPlayedBet", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丂丌业与丝不下丞七(int 三丌且丙丝丅下一丘, int 丈丆丁丒丅业丛丙丗, int 丞三丞世专丝丆业业, int 丂丆一丄且丌丛丈业, int 专丑丐丙丈丂丙丐三, bool 丒万丂专专业一下东)
    {
        CaseAnimationWrapper val_21;
        CaseAnimationWrapper val_22;
        Rilisoft.丝三丕七业丗丂丆三 val_23;
        CaseAnimationWrapper val_24;
        Rilisoft.丝三丕七业丗丂丆三 val_25;
        Rilisoft.丝三丕七业丗丂丆三 val_26;
        专丘万丙丝丌丗丞丛 val_27;
        val_21 = 丒万丂专专业一下东;
        val_22 = 丂丆一丄且丌丛丈业;
        if(丈丆丁丒丅业丛丙丗 != 1)
        {
                val_23 = this.丂下丘丞万丌业与丛(丞世不丒下上上丝丑:  丈丆丁丒丅业丛丙丗);
        }
        else
        {
                val_23 = 0;
        }
        
        Rilisoft.丝三丕七业丗丂丆三 val_3 = this.丂下丘丞万丌业与丛(丞世不丒下上上丝丑:  (丞三丞世专丝丆业业 == 1) ? 专丑丐丙丈丂丙丐三 : 丞三丞世专丝丆业业);
        Rilisoft.丝三丕七业丗丂丆三 val_4 = this.丂下丘丞万丌业与丛(丞世不丒下上上丝丑:  专丑丐丙丈丂丙丐三);
        val_4.不与丘丈世专一丝丞(丞世不丒下上上丝丑:  专丑丐丙丈丂丙丐三);
        DuelUIController val_5 = val_4.duelUI;
        val_5.caseAnimationWrapper.ClearAnimations();
        if(专丑丐丙丈丂丙丐三 <= 三丌且丙丝丅下一丘)
        {
            goto label_4;
        }
        
        bool val_9 = ((丞三丞世专丝丆业业 == 1) ? 1 : 0) | val_21;
        if(丞三丞世专丝丆业业 == val_22)
        {
                if(((val_9 != true) ? ((丈丆丁丒丅业丛丙丗 != 专丑丐丙丈丂丙丐三) ? 1 : 0) : ((丈丆丁丒丅业丛丙丗 != 丞三丞世专丝丆业业) ? 1 : 0)) == 0)
        {
            goto label_12;
        }
        
        }
        
        DuelUIController val_11 = val_5.caseAnimationWrapper.duelUI;
        val_21 = val_11.caseAnimationWrapper;
        val_21.AddCaseAnimation(丞丂世丏万上上丘丗:  val_23, 世丒丌丆丁丝丒三丕:  val_3, 丐丐七专三且世三七:  3, 丝上丑业丙下丂万与:  (丈丆丁丒丅业丛丙丗 == 1) ? 1 : 0);
        if(丞三丞世专丝丆业业 != val_22)
        {
                DuelUIController val_13 = val_21.duelUI;
            val_13.caseAnimationWrapper.AddCaseAnimation(丞丂世丏万上上丘丗:  val_3, 世丒丌丆丁丝丒三丕:  val_3, 丐丐七专三且世三七:  0, 丝上丑业丙下丂万与:  false);
            if(val_9 != false)
        {
                DuelUIController val_14 = val_13.caseAnimationWrapper.duelUI;
            val_14.caseAnimationWrapper.AddCaseAnimation(丞丂世丏万上上丘丗:  val_3, 世丒丌丆丁丝丒三丕:  val_4, 丐丐七专三且世三七:  3, 丝上丑业丙下丂万与:  false);
        }
        
        }
        
        label_12:
        DuelUIController val_15 = val_14.caseAnimationWrapper.duelUI;
        val_24 = val_15.caseAnimationWrapper;
        val_25 = val_3;
        val_26 = val_4;
        val_27 = ((val_9 & true) != 0) ? (1 + 1) : 1;
        goto label_17;
        label_4:
        if(丈丆丁丒丅业丛丙丗 != 专丑丐丙丈丂丙丐三)
        {
                DuelUIController val_17 = val_5.caseAnimationWrapper.duelUI;
            val_22 = val_17.caseAnimationWrapper;
            val_22.AddCaseAnimation(丞丂世丏万上上丘丗:  val_23, 世丒丌丆丁丝丒三丕:  val_3, 丐丐七专三且世三七:  3, 丝上丑业丙下丂万与:  (丈丆丁丒丅业丛丙丗 == 1) ? 1 : 0);
        }
        
        DuelUIController val_19 = val_22.duelUI;
        val_24 = val_19.caseAnimationWrapper;
        val_25 = val_3;
        val_26 = val_4;
        val_27 = 0;
        label_17:
        val_24.AddCaseAnimation(丞丂世丏万上上丘丗:  val_25, 世丒丌丆丁丝丒三丕:  val_26, 丐丐七专三且世三七:  val_27, 丝上丑业丙下丂万与:  false);
        DuelUIController val_20 = val_24.duelUI;
        val_20.btnShowBetInfo.RotateToDefault();
    }
    private void 专丅丒丝丐丂业丛三(int 万丙丈丙丄丅丝专上)
    {
        this.丑丂与丂丘上三丌不 = 万丙丈丙丄丅丝专上;
        this.不丐丈下专与丒丗丑 = 万丙丈丙丄丅丝专上;
        this.丆丆东七下丄七丅下(丒万丂专专业一下东:  false);
        this.丘三三且与丏丑世丈();
        this.丘丌丅丏不丙与丈东(丈丅丕丄丙丅丒丟丟:  false);
        this.不与丘丈世专一丝丞(丞世不丒下上上丝丑:  万丙丈丙丄丅丝专上);
        this.丂丌业与丝不下丞七(三丌且丙丝丅下一丘:  this.丒不丟丐丆七丆丕三, 丈丆丁丒丅业丛丙丗:  this.不丐丈下专与丒丗丑, 丞三丞世专丝丆业业:  this.丆丛东丐丄丄丞丄丐, 丂丆一丄且丌丛丈业:  this.丆丛东丐丄丄丞丄丐, 专丑丐丙丈丂丙丐三:  万丙丈丙丄丅丝专上, 丒万丂专专业一下东:  false);
    }
    private void 丘三三且与丏丑世丈()
    {
        int val_11;
        if(this.丑丂与丂丘上三丌不 == 1)
        {
                return;
        }
        
        if(this.丒不丟丐丆七丆丕三 == 1)
        {
                return;
        }
        
        Rilisoft.上专业三丟丁丞专下 val_2 = this.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丑丂与丂丘上三丌不).GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丒不丟丐丆七丆丕三);
        val_11 = this.丑丂与丂丘上三丌不;
        int val_3 = UnityEngine.Mathf.Min(a:  val_11, b:  this.丒不丟丐丆七丆丕三);
        this.丆与丙丂丑与丈丌丗 = (val_3 != this.丆丛东丐丄丄丞丄丐) ? 1 : 0;
        if(val_3 == this.丆丛东丐丄丄丞丄丐)
        {
                return;
        }
        
        Rilisoft.上专业三丟丁丞专下 val_5 = val_3.GetBetConfigByIndex(丞世不丒下上上丝丑:  val_3);
        if(this.丆丛东丐丄丄丞丄丐 != 1)
        {
                Rilisoft.上专业三丟丁丞专下 val_6 = val_5.GetBetConfigByIndex(丞世不丒下上上丝丑:  this.丆丛东丐丄丄丞丄丐);
        }
        
        丈丞丕丘丕丗与上一 val_7 = val_5.且丙东丞一丐万丕万();
        this.七丅丞世丑丒七上丈 = val_7;
        val_11 = this.下万东上丟丏且七业;
        int val_11 = val_7.丟丂丞不专丆万丒世();
        if(this.七丅丞世丑丒七上丈 != null)
        {
                val_11 = val_11 - val_11;
            if(val_11 >= 1)
        {
                val_11 = val_11 + val_11;
            int val_9 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this.下万东上丟丏且七业 = 0;
            mem[1152921525935754136] = 0;
            val_11 = this.七丅丞世丑丒七上丈.东与三丌丅三丒丏业();
            BankController.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_11, 丌丒丝东丌下丕丁丅:  -val_11, 丛丞万三下丘七丌丅:  false, 丅丅丞丙丁丕丌世东:  0, 丄东三丕丟丅不丌丄:  0, 丟世且丕丂丁万丒万:  104);
        }
        
        }
        
        this.丆丛东丐丄丄丞丄丐 = val_3;
        this.丘丌丅丏不丙与丈东(丈丅丕丄丙丅丒丟丟:  false);
    }
    private void 下丟丈东专丝丁下专(int 丞世不丒下上上丝丑)
    {
        this.丆丛东丐丄丄丞丄丐 = 丞世不丒下上上丝丑;
    }
    private void 丐丅丄丕上丞丏丌丌(丈丞丕丘丕丗与上一 丞丈与丒丙丟丆丏不, int 丏丂不专上丘丂不丅, System.Action 七丒上且丝业业下七)
    {
        if((System.String.op_Equality(a:  丞丈与丒丙丟丆丏不.东与三丌丅三丒丏业(), b:  "EventCurrency")) != false)
        {
                if((this.丄下丑丈丄丕丄丏丆(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅)) == true)
        {
                return;
        }
        
            this.丅丛一下不且丂世丑 = true;
            this.不一七不丄丑专丁丛 = 丏丂不专上丘丂不丅;
            this.丏东丐丞丘丟丐丙丝();
            return;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  0, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  丏丂不专上丘丂不丅, 丏丂不专上丘丂不丅:  丞丈与丒丙丟丆丏不.东与三丌丅三丒丏业()), 七丒上且丝业业下七:  七丒上且丝业业下七, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  true, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  98);
    }
    internal void 丏东丐丞丘丟丐丙丝()
    {
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丁丅丈丌丟世丗丗丟:  100);
        if(val_2 == null)
        {
                return;
        }
        
        string val_3 = val_2.业上丙丞丐丄丆丅七();
        Rilisoft.上丏丂下丄丕丑丏丂.下与丞三丅丛丄七丕(丅丑不丏丞丛丆与丛:  val_3, 丆丏七丟不丒与七专:  val_3.duelUI.transform);
        Rilisoft.上丏丂下丄丕丑丏丂.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::丐万世丌丞丗丏丕丙()));
    }
    private bool 丄下丑丈丄丕丄丏丆(int 丏丂不专上丘丂不丅)
    {
        var val_2;
        if((BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  0)) < 丏丂不专上丘丂不丅)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.MakeBet(万丙丈丙丄丅丝专上:  this.不丐丈下专与丒丗丑);
        val_2 = 1;
        return (bool)val_2;
    }
    private void 丐万世丌丞丗丏丕丙()
    {
        if((this.丅丛一下不且丂世丑 != false) && (this.不一七不丄丑专丁丛 >= 1))
        {
                bool val_1 = this.丄下丑丈丄丕丄丏丆(丏丂不专上丘丂不丅:  this.不一七不丄丑专丁丛);
            this.丅丛一下不且丂世丑 = false;
            this.不一七不丄丑专丁丛 = 0;
        }
        
        Rilisoft.上丏丂下丄丕丑丏丂.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DuelController::丐万世丌丞丗丏丕丙()));
    }
    private static DuelController()
    {
        DuelController.下世丗下一丆丐丝专 = 30f;
        DuelController.丟上丝不丏丏万丁丘 = 5f;
        DuelController.上万丟丟丘丁丙与丛 = 10f;
        string[] val_1 = new string[4];
        val_1[0] = "Key_3940";
        val_1[1] = "Key_3941";
        val_1[2] = "Key_3942";
        val_1[3] = "Key_3310";
        DuelController.下丆丗专丂丐丈丐上 = val_1;
    }
    private void 丈丌七丏丅与七专世(string 丞丅上丏丂且下丅与)
    {
        this.SetMyWeapon();
        this.SendMyWeapon();
    }
    private void 丆丑丘丕上万一世丙()
    {
        this.MakeBet(万丙丈丙丄丅丝专上:  this.不丐丈下专与丒丗丑);
    }

}
