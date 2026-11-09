using UnityEngine;
internal sealed class TeamDuelController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal static TeamDuelController 丄丘七三上丕世丞业;
    public TeamDuelController.丛丏丂丄上专且万业 roomStatus;
    private const float 丈丗专世丑与下丘不 = 120;
    private const float 丛丙专一七上下三丐 = 90;
    private const float 丁丑丞东且万一下一 = 25;
    private const float 丐丄丂不丟丈且三丂 = 5;
    private const int 三三万丆下一丗万丛 = 3;
    private const int 三丐丁丅丆丘三丏与 = 7;
    private const int 丘下专丏丐丈业一丐 = 4;
    private const int 丅丌丛丏丞上万丛丕 = 300;
    private float 不丄丟丞丄万不丈丌;
    private bool 丈与世七丞丆业丌丂;
    private float 丘丑丌丆与丑丞万三;
    private float 丈丛万不丈与专丐世;
    private float 丆丙丌丛丝下一丏上;
    private float 丏丟世丑丆世丆丌专;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    public bool betsEnabled;
    internal System.Collections.Generic.List<NetworkStartTable> blueTeam;
    internal System.Collections.Generic.List<NetworkStartTable> redTeam;
    public System.Collections.Generic.List<与丅丕丈丘东丝世丟> connectingBlueTeam;
    public System.Collections.Generic.List<与丅丕丈丘东丝世丟> connectingRedTeam;
    internal System.Collections.Generic.List<NetworkStartTable> 且丄丟丏丛丞丆丂丘;
    private System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丅丑丄丌丛万丐不不;
    public bool playerStarted;
    public int myTeamInDuel;
    private bool 丈丒丝丄丒丈丞下不;
    private string 丝丈丏丙丑与丘下一;
    public int roundsPlayed;
    private int[] 七丁丞万丅丄且丈且;
    public bool finalRound;
    private bool 丘丝丑丕丒丄丛丆东;
    public bool isGo;
    public bool showGoInterface;
    public bool goInterfaceShowed;
    private bool 不且丒丑丒丕丐专不;
    private float 业丆丝丝丞丅专丏丏;
    public bool myPlayerDead;
    public bool roundEndFade;
    private float 丞万业丐丛不七且丞;
    private bool 上丏丐丆丌不与下丈;
    public bool spectatorModeStarted;
    private static System.Action<int> 与且一丛丅丟丄丅七;
    
    // Properties
    public TeamDuelUI 七丝一丌丏七丂上不 { get; }
    public TeamDuelController.丛丏丂丄上专且万业 业丂丆丝丏丛一三丁 { get; set; }
    public bool 一丁不丂丘丛丙丆专 { get; set; }
    public bool 丝丝丗七丑丁丕丗丄 { get; }
    public float 丄专万丏丘上丑与一 { get; }
    public bool 专丗丛丝丗丞下丑丄 { get; }
    public bool 丈丁丅丙丙万丆丄丅 { get; }
    public int 丈丘丝丄三丂东下一 { get; }
    public int 世七三丕丛专丌业丁 { get; }
    
    // Methods
    public TeamDuelUI get_duelUI()
    {
        NetworkStartTableNGUIController val_2;
        TeamDuelUI val_3;
        val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        val_3 = 0;
        if(val_2 == 0)
        {
                return val_3;
        }
        
        val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 992];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.teamDuelUI;
        return val_3;
    }
    public TeamDuelController.丛丏丂丄上专且万业 get_roomStatusGlobal()
    {
        var val_5;
        var val_7;
        val_5 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (丛丏丂丄上专且万业)null;
        }
        
        val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌();
        val_7 = null;
        val_7 = null;
        object val_4 = val_5.Item[GameConnect.丟丞丏丝与丙丁丛与];
        return (丛丏丂丄上专且万业)null;
    }
    public void set_roomStatusGlobal(TeamDuelController.丛丏丂丄上专且万业 丙业与丙丗丝不丈东)
    {
        var val_4;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
            val_4 = null;
            val_4 = null;
            val_2.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  丙业与丙丗丝不丈东);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Room is null, but you trying to change room properties!");
    }
    public bool get_spawnSide()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (bool)val_10;
        }
        
        val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌();
        val_11 = null;
        val_11 = null;
        if((val_9.ContainsKey(key:  GameConnect.丆丗下丏丒丅丐丑上)) != false)
        {
                val_12 = null;
            val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌();
            val_12 = null;
            object val_7 = val_9.Item[GameConnect.丆丗下丏丒丅丐丑上];
            var val_8 = (null == 1) ? 1 : 0;
            return (bool)val_10;
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    public void set_spawnSide(bool 丙业与丙丗丝不丈东)
    {
        var val_5;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
            if((((mem[(ExitGames.Client.Photon.Hashtable)[1152921540491466064]..ctor() + 295]) & 2) != 0) && ((mem[(ExitGames.Client.Photon.Hashtable)[1152921540491466064]..ctor() + 216]) == 0))
        {
                val_5 = null;
        }
        
            val_2.set_Item(key:  GameConnect.丆丗下丏丒丅丐丑上, value:  丙业与丙丗丝不丈东);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Room is null, but you trying to change room properties!");
    }
    public bool get_canPause()
    {
        bool val_1 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public float get_timeLeft()
    {
        return (float)this.不丄丟丞丄万不丈丌;
    }
    public bool get_isMaster()
    {
        return 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
    }
    public bool get_calculateRatingOnNullPlayer()
    {
        if(this.丘丝丑丕丒丄丛丆东 == false)
        {
                return false;
        }
        
        return (bool)(this.roomStatus > 1) ? 1 : 0;
    }
    public int get_blueTeamWins()
    {
        var val_3;
        OnlineModeController val_4;
        var val_5;
        var val_6;
        int val_7;
        val_3 = null;
        val_3 = null;
        val_4 = GameController.onlineMode;
        if(val_4 != 0)
        {
                val_5 = null;
            val_5 = null;
            val_4 = mem[GameController.onlineMode + 360];
            val_4 = GameController.onlineMode.teamController;
            if(val_4 != 0)
        {
                val_6 = null;
            val_6 = null;
            val_4 = mem[GameController.onlineMode + 360];
            val_4 = GameController.onlineMode.teamController;
            val_7 = (int)TeamController.__il2cppRuntimeField_element_class;
            return (int)val_7;
        }
        
        }
        
        val_7 = 0;
        return (int)val_7;
    }
    public int get_redTeamWins()
    {
        var val_3;
        OnlineModeController val_4;
        var val_5;
        var val_6;
        int val_7;
        val_3 = null;
        val_3 = null;
        val_4 = GameController.onlineMode;
        if(val_4 != 0)
        {
                val_5 = null;
            val_5 = null;
            val_4 = mem[GameController.onlineMode + 360];
            val_4 = GameController.onlineMode.teamController;
            if(val_4 != 0)
        {
                val_6 = null;
            val_6 = null;
            val_4 = mem[GameController.onlineMode + 360];
            val_4 = GameController.onlineMode.teamController;
            val_7 = (int)typeof(TeamController).__il2cppRuntimeField_44;
            return (int)val_7;
        }
        
        }
        
        val_7 = 0;
        return (int)val_7;
    }
    private void Awake()
    {
        var val_13;
        bool val_14;
        var val_15;
        var val_16;
        bool val_17;
        var val_18;
        System.Action<与丅丕丈丘东丝世丟> val_19;
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_3;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_3:
        val_14 = 0;
        if(this != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        this.enabled = (val_14 != 0) ? 1 : 0;
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        TeamDuelController.丅丌丛丏丞上万丛丕 = this;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        if(((this.enabled != false) && (NetworkStartTable.与一专丒东丏丘专丕() != true)) && (Initializer.丑七不且上丗丁一世() != 0))
        {
                val_16 = null;
            val_16 = null;
            val_17 = GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 ^ 1;
        }
        else
        {
                val_17 = false;
        }
        
        this.betsEnabled = val_17;
        val_18 = null;
        val_18 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void TeamDuelController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_19 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_19;
        this.丟业东业丐业不丆一();
        this.丝丈丏丙丑与丘下一 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0565");
    }
    private void 丟业东业丐业不丆一()
    {
        this.roundEndFade = false;
        this.finalRound = true;
        this.丘丝丑丕丒丄丛丆东 = true;
        this.roundsPlayed = 0;
        goto label_1;
        label_5:
        0 = 1;
        this.七丁丞万丅丄且丈且[0] = 0;
        label_1:
        if(0 < this.七丁丞万丅丄且丈且.Length)
        {
            goto label_5;
        }
        
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.duelUI, y:  0);
        if(val_2 == false)
        {
                return;
        }
        
        TeamDuelUI val_3 = val_2.duelUI;
        val_3.revengePanel.SetActive(value:  false);
    }
    private void 丏丅丅丘上丆业丂丟()
    {
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        System.Collections.Generic.List<NetworkStartTable> val_27;
        var val_28;
        System.Collections.Generic.List<NetworkStartTable> val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_37;
        val_21 = this;
        this.blueTeam.Clear();
        this.redTeam.Clear();
        val_22 = 1152921525488042576;
        val_23 = 0;
        goto label_3;
        label_27:
        val_24 = null;
        val_24 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() >= 1)
        {
                val_25 = null;
            val_25 = null;
            if(Item[0].丘丑丅三丆丑丌且丝() == 1)
        {
                val_26 = null;
            val_27 = this.blueTeam;
        }
        else
        {
                val_26 = null;
            val_27 = this.redTeam;
            val_26 = null;
        }
        
            val_27.Add(item:  Item[0]);
        }
        
        val_23 = 1;
        label_3:
        val_28 = null;
        val_28 = null;
        val_29 = mem[GameController.onlineMode + 392];
        val_29 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_23 < Count)
        {
            goto label_27;
        }
        
        val_30 = 1152921525952952256;
        this.connectingBlueTeam.Clear();
        this.connectingRedTeam.Clear();
        val_31 = 0;
        goto label_30;
        label_70:
        val_32 = 0;
        val_30 = 0;
        goto label_31;
        label_53:
        val_32 = 1;
        label_31:
        val_33 = null;
        val_33 = null;
        if(val_32 >= Count)
        {
            goto label_36;
        }
        
        val_34 = null;
        val_34 = null;
        NetworkStartTable val_8 = Item[1];
        if(val_8.丄丈丑丐丆丞丘与丗.owner != 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[val_30])
        {
            goto label_53;
        }
        
        val_35 = null;
        val_35 = null;
        val_29 = Item[1];
        if(val_29.丘丑丅三丆丑丌且丝() <= 0)
        {
            goto label_53;
        }
        
        goto label_54;
        label_36:
        if((this.connectingRedTeam.Count + this.redTeam.Count) < (this.connectingBlueTeam.Count + this.blueTeam.Count))
        {
                val_36 = static_value_081D9CF0;
            val_21 = val_21;
            val_37 = this.connectingRedTeam;
        }
        else
        {
                val_36 = static_value_081D9CF0;
            val_21 = val_21;
            val_37 = this.connectingBlueTeam;
        }
        
        val_22 = 1152921525488042576;
        val_29 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[val_30];
        val_37.Add(item:  val_29);
        label_54:
        val_31 = 1;
        label_30:
        与丅丕丈丘东丝世丟[] val_20 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_31 < val_20.Length)
        {
            goto label_70;
        }
    
    }
    private void Update()
    {
        var val_71;
        var val_72;
        var val_73;
        System.Collections.Generic.List<NetworkStartTable> val_74;
        System.Collections.Generic.List<NetworkStartTable> val_75;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_76;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_77;
        var val_86;
        var val_87;
        bool val_1 = this.isMaster;
        if(val_1 != false)
        {
                丛丏丂丄上专且万业 val_2 = val_1.roomStatusGlobal;
            if(val_2 == 0)
        {
                val_2.roomStatusGlobal = 1;
        }
        
        }
        
        世丁与丕丗丟丒丆上 val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_3 != null)
        {
                if(this.roomStatus != 0)
        {
            goto label_6;
        }
        
        }
        
        this.roomStatus = val_3.roomStatusGlobal;
        label_6:
        this.丏丅丅丘上丆业丂丟();
        val_71 = null;
        val_71 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                this.playerStarted = false;
        }
        
        val_72 = null;
        val_72 = null;
        bool val_6 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable, y:  0);
        if(val_6 == true)
        {
                return;
        }
        
        if(val_6.duelUI == 0)
        {
                return;
        }
        
        val_73 = null;
        val_73 = null;
        int val_9 = 丘丑丅三丆丑丌且丝();
        if(val_9 < 1)
        {
            goto label_26;
        }
        
        if(val_9 != 1)
        {
            goto label_27;
        }
        
        val_74 = this.blueTeam;
        val_75 = this.redTeam;
        val_76 = this.connectingBlueTeam;
        val_77 = this.connectingRedTeam;
        goto label_29;
        label_26:
        val_75 = this.且丄丟丏丛丞丆丂丘;
        val_77 = this.丅丑丄丌丛万丐不不;
        val_76 = val_77;
        val_74 = val_75;
        goto label_29;
        label_27:
        val_75 = this.blueTeam;
        val_74 = this.redTeam;
        val_77 = this.connectingBlueTeam;
        val_76 = this.connectingRedTeam;
        label_29:
        if((this.roomStatus - 1) > 4)
        {
                return;
        }
        
        var val_70 = 106038104 + ((this.roomStatus - 1)) << 2;
        val_70 = val_70 + 106038104;
        goto (106038104 + ((this.roomStatus - 1)) << 2 + 106038104);
        label_96:
        val_86 = null;
        val_86 = null;
        if( >= Count)
        {
            goto label_90;
        }
        
        val_87 = null;
        val_87 = null;
        NetworkStartTable val_42 = Item[0];
         =  + 1;
        if(val_42.上丟丘丙丅丛丝世不 == true)
        {
            goto label_96;
        }
        
        return;
        label_90:
        ??? + 28.丑丅万丘丂且丞丏丛();
    }
    private void 东一丏丙丗丆上七丅(bool 丛丅丘一丏丙且丌上)
    {
        InGameGUI val_20;
        bool val_21;
        var val_22;
        this.goInterfaceShowed = 丛丅丘一丏丙且丌上;
        val_20 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_20 == 0)
        {
                return;
        }
        
        typeof(InGameGUIPart_TeamDuel).__il2cppRuntimeField_38.gameObject.SetActive(value:  丛丅丘一丏丙且丌上);
        val_21 = 丛丅丘一丏丙且丌上 ^ 1;
        SetActive(value:  val_21);
        SetActive(value:  val_21);
        InGameGUIPart_TeamDuel.__il2cppRuntimeField_generic_class.SetActive(value:  丛丅丘一丏丙且丌上);
        if(丛丅丘一丏丙且丌上 == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        int val_8 = 丘丑丅三丆丑丌且丝();
        if(val_8 == 2)
        {
                int val_10 = val_8.redTeamWins.blueTeamWins;
        }
        else
        {
                int val_11 = val_8.blueTeamWins;
        }
        
        val_21 = 0;
        val_20 = System.String.Format(format:  "[03ddff]{0}[-] - [ff4564]{1}[-]", arg0:  val_11.ToString(), arg1:  val_11.redTeamWins.ToString());
        InGameGUIPart_TeamDuel.__il2cppRuntimeField_castClass.text = val_20;
        this.丆丟丕丈业丘丒丕三(丞三丕丅丝万丛丂丆:  InGameGUIPart_TeamDuel.__il2cppRuntimeField_element_class);
    }
    internal void 丆丟丕丈业丘丒丕三(UISprite[] 丞三丕丅丝万丛丂丆)
    {
        var val_7;
        var val_8;
        string val_9;
        val_7 = null;
        val_7 = null;
        val_8 = 0;
        goto label_5;
        label_25:
        int val_8 = this.七丁丞万丅丄且丈且[0];
        if(this.roundsPlayed <= val_8)
        {
            goto label_9;
        }
        
        if(val_8 != 0)
        {
            goto label_10;
        }
        
        val_9 = "DeadHeatShield";
        goto label_15;
        label_9:
        if(val_8 == 0)
        {
            goto label_12;
        }
        
        label_10:
        var val_2 = (this.七丁丞万丅丄且丈且[0] == 丘丑丅三丆丑丌且丝()) ? "BlueShield" : "RedShield";
        goto label_15;
        label_12:
        val_9 = "GreyShield";
        label_15:
        丞三丕丅丝万丛丂丆[0].spriteName = val_9;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  (val_8 == this.roundsPlayed) ? 1.2f : 1f);
        丞三丕丅丝万丛丂丆[0x0] + 32.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        val_8 = 1;
        label_5:
        if(val_8 < 丞三丕丅丝万丛丂丆.Length)
        {
            goto label_25;
        }
    
    }
    private bool 丛丕东业不世丞丄丛()
    {
        System.Collections.Generic.List<NetworkStartTable> val_4;
        var val_5;
        val_4 = this;
        if(this.redTeam.Count >= 3)
        {
                val_4 = this.blueTeam;
            var val_3 = (val_4.Count > 2) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    private void 丞丞下丒丅丅丛世丕()
    {
        this.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  2);
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(90f != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(90f == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 90f;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  143, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_5;
        var val_6;
        val_5 = 丞世不丒下上上丝丑;
        byte val_1 = val_5 & 255;
        val_1 = val_1 - 142;
        val_6 = 0;
        if(val_1 > 8)
        {
                return (bool);
        }
        
        var val_5 = 106038124 + (((丞世不丒下上上丝丑 & 255) - 142)) << 2;
        val_5 = val_5 + 106038124;
        goto (106038124 + (((丞世不丒下上上丝丑 & 255) - 142)) << 2 + 106038124);
    }
    internal void 丂丂专上专丙下世下(float 丛丙专一七上下三丐)
    {
        var val_6;
        UnityEngine.Object val_11;
        this.不丄丟丞丄万不丈丌 = 丛丙专一七上下三丐;
        this.不且丒丑丒丕丐专不 = true;
        this.业丆丝丝丞丅专丏丏 = 1f;
        this.roomStatus = 2;
        val_11 = PlayerBotsManager.与一丅丝不丈业与丙();
        if(val_11 == 0)
        {
                return;
        }
        
        PlayerBotsManager val_3 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_11 = val_3.与上且丗丄七丑丆丑;
        List.Enumerator<T> val_4 = val_11.GetEnumerator();
        label_18:
        if((1528055872 & 1) == 0)
        {
            goto label_10;
        }
        
        if(isMine == false)
        {
            goto label_18;
        }
        
        PlayerBot.NavMeshAgentController val_9 = val_6.丐丏七丌丕丗业且上().丌且丞丕万丂丆七丅();
        val_9.agent.isStopped = false;
        goto label_18;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丑丅万丘丂且丞丏丛()
    {
        bool val_1 = this.isMaster;
        if(val_1 == false)
        {
                return;
        }
        
        bool val_2 = val_1.spawnSide;
        val_2.spawnSide = (~val_2) & 1;
        val_2.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  1);
        this.不上一丘上丝丟与丅();
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  147, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    private void 不上一丘上丝丟与丅()
    {
        var val_3;
        var val_4;
        var val_5;
        this.丟业东业丐业不丆一();
        this.丈丒丝丄丒丈丞下不 = false;
        this.roomStatus = 1;
        val_3 = 0;
        goto label_1;
        label_11:
        val_4 = null;
        val_4 = null;
        NetworkStartTable val_1 = Item[0];
        val_3 = 1;
        val_1.上丟丘丙丅丛丝世不 = false;
        label_1:
        val_5 = null;
        val_5 = null;
        if(val_3 < Count)
        {
            goto label_11;
        }
        
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ShowStartInterface();
    }
    internal System.Collections.IEnumerable 丗上丙上丏三世且丁(float 丕丕世且下一与丝与)
    {
        TeamDuelController.丗七丅三专丑丁丒丙 val_1 = new TeamDuelController.丗七丅三专丑丁丒丙(丗丏丅丕丆世丁专丟:  -2);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    internal void 丗上丙上丏三世且丁()
    {
        bool val_1 = this.isMaster;
        if(val_1 != false)
        {
                val_1.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  4);
        }
        
        this.丅丄丛世且丌丂下与(丙一丑丏丁一且丒业:  5f, 丛丙专一七上下三丐:  90f);
    }
    private void 世且丏万丄三丞丆不()
    {
        PhotonView val_4;
        var val_5;
        val_4 = this;
        bool val_1 = this.isMaster;
        if(val_1 == false)
        {
                return;
        }
        
        val_1.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  4);
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_4 = this.丄丈丑丐丆丞丘与丗;
        object[] val_3 = new object[2];
        val_3[0] = 5f;
        val_3[1] = 90f;
        val_4.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  142, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_5;
        if(this.丄丈丑丐丆丞丘与丗 == 0)
        {
                return;
        }
        
        object[] val_2 = new object[3];
        int val_3 = val_2.blueTeamWins;
        if(val_2 == null)
        {
                val_5 = 0;
        }
        
        if(val_3 != 0)
        {
                val_5 = val_3;
        }
        
        val_2[0] = val_3;
        val_2[1] = val_3.redTeamWins;
        val_2[2] = this.roundsPlayed;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  150, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 丅丄丛世且丌丂下与(float 丙一丑丏丁一且丒业, float 丛丙专一七上下三丐)
    {
        var val_12;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_17 = 1152921525488042576;
        val_18 = 0;
        goto label_1;
        label_11:
        val_19 = null;
        val_19 = null;
        NetworkStartTable val_1 = Item[0];
        val_18 = 1;
        val_1.丄世一丞万一丁丙丁 = false;
        label_1:
        val_20 = null;
        val_20 = null;
        if(val_18 < Count)
        {
            goto label_11;
        }
        
        this.roomStatus = 4;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                Close();
        }
        
        if(this.myTeamInDuel == 1)
        {
                val_21 = null;
            val_21 = null;
            丐丛丕且东下上丐业();
        }
        
        if(this.上丏丐丆丌不与下丈 != false)
        {
                val_22 = null;
            val_22 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_23 = null;
            val_23 = null;
            typeof(NetworkStartTable).__il2cppRuntimeField_1B0.Reset();
            typeof(NetworkStartTable).__il2cppRuntimeField_1B0.Restart();
            this.上丏丐丆丌不与下丈 = false;
        }
        
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丟丛专七不七丆三万());
        if(PlayerBotsManager.与一丅丝不丈业与丙() == 0)
        {
            goto label_64;
        }
        
        PlayerBotsManager val_9 = PlayerBotsManager.与一丅丝不丈业与丙();
        List.Enumerator<T> val_10 = val_9.与上且丗丄七丑丆丑.GetEnumerator();
        val_17 = 1152921538392201504;
        label_54:
        if((1529093904 & 1) == 0)
        {
            goto label_46;
        }
        
        string val_13 = val_12.丐丏七丌丕丗业且上();
        if(isMine == false)
        {
            goto label_54;
        }
        
        val_13.七丝丑丁丑丂七丏丕();
        PlayerBot.NavMeshAgentController val_15 = val_13.丌且丞丕万丂丆七丅();
        val_15.agent.isStopped = true;
        goto label_54;
        label_46:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_64:
        this.丏丟世丑丆世丆丌专 = 丙一丑丏丁一且丒业;
        this.不丄丟丞丄万不丈丌 = 丛丙专一七上下三丐;
    }
    internal void 丁丏业丄与丌丗上且(float 丛丙专一七上下三丐)
    {
        if(this.isMaster == true)
        {
                return;
        }
        
        this.不丄丟丞丄万不丈丌 = 丛丙专一七上下三丐;
    }
    internal void 万与丗不丑丘丞与业(float 丗丞丁丟丄丆上丒下)
    {
        if(this.isMaster == true)
        {
                return;
        }
        
        this.丏丟世丑丆世丆丌专 = 丗丞丁丟丄丆上丒下;
    }
    private System.Collections.IEnumerator 丟丛专七不七丆三万()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TeamDuelController.丈丞专东丈七丁丌丕(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丞丟丂丅丒丝丘丌且(TeamDuelController.丛丏丂丄上专且万业 三丁丂丒不丘丄丂三)
    {
        丛丏丂丄上专且万业 val_6 = 三丁丂丒不丘丄丂三;
        this.roomStatusGlobal = val_6;
        丛丏丂丄上专且万业 val_1 = val_6 - 3;
        val_6 = ((val_6 != 2) ? 1 : 0) & ((val_1 > 2) ? 1 : 0);
        UnityEngine.Debug.Log(message:  (val_1 == 3) ? "Room closed!" : "Room opened!");
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丄东丅丘东不丘丝丟(丙业与丙丗丝不丈东:  val_6);
    }
    private void OnDestroy()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void TeamDuelController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    internal void 东下丙一丘丒丁丗且()
    {
        if(this.丈丒丝丄丒丈丞下不 != false)
        {
                return;
        }
        
        this.duelUI.丝上与且丞且丑丒专(东丟丐业丏一下丕与:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3675"));
    }
    internal void 专丘丙丞专世丐丛丑()
    {
        var val_3;
        if(this.丈丒丝丄丒丈丞下不 != false)
        {
                return;
        }
        
        this.丈丒丝丄丒丈丞下不 = true;
        val_3 = null;
        val_3 = null;
        不丈东上丁丕丙丄万();
        duelUI.丝上与且丞且丑丒专(东丟丐业丏一下丕与:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3674"));
    }
    private bool 专丞丂丂丟三丑丘世()
    {
        var val_8;
        var val_9;
        bool val_10;
        var val_11;
        var val_12;
        bool val_13;
        val_8 = 0;
        val_9 = 1;
        goto label_1;
        label_7:
        if((val_9 & 1) != 0)
        {
                NetworkStartTable val_1 = this.redTeam.Item[0];
            val_10 = val_1.丄世一丞万一丁丙丁;
        }
        else
        {
                val_10 = 0;
        }
        
        val_8 = 1;
        label_1:
        if(val_8 < this.redTeam.Count)
        {
            goto label_7;
        }
        
        val_11 = 0;
        val_12 = 1;
        goto label_8;
        label_14:
        if((val_12 & 1) != 0)
        {
                NetworkStartTable val_4 = this.blueTeam.Item[0];
            val_13 = val_4.丄世一丞万一丁丙丁;
        }
        else
        {
                val_13 = 0;
        }
        
        val_11 = 1;
        label_8:
        if(val_11 < this.blueTeam.Count)
        {
            goto label_14;
        }
        
        val_13 = ((val_10 != 0) ? 1 : 0) | ((val_13 != 0) ? 1 : 0);
        return (bool)val_13 & 1;
    }
    private int 丑丝丂丌七丐丌丄丗()
    {
        var val_3;
        var val_4;
        val_3 = 0;
        val_4 = 0;
        goto label_1;
        label_5:
        NetworkStartTable val_1 = this.redTeam.Item[0];
        bool val_3 = val_1.丄世一丞万一丁丙丁;
        val_3 = 1;
        val_3 = val_3 ^ 1;
        val_4 = val_4 + val_3;
        label_1:
        if(val_3 < this.redTeam.Count)
        {
            goto label_5;
        }
        
        return (int)val_4;
    }
    private int 万丝上丈丒丕丗丐下()
    {
        var val_3;
        var val_4;
        val_3 = 0;
        val_4 = 0;
        goto label_1;
        label_5:
        NetworkStartTable val_1 = this.blueTeam.Item[0];
        bool val_3 = val_1.丄世一丞万一丁丙丁;
        val_3 = 1;
        val_3 = val_3 ^ 1;
        val_4 = val_4 + val_3;
        label_1:
        if(val_3 < this.blueTeam.Count)
        {
            goto label_5;
        }
        
        return (int)val_4;
    }
    public bool OnMyPlayerKilled()
    {
        var val_1;
        this.myPlayerDead = true;
        val_1 = null;
        val_1 = null;
        丒丝下丐万三丒三不();
        丛丒丗丘七且专丒丟();
        return false;
    }
    internal void 专东丂丑世丙丟上丝()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false) ? 1 : 0);
        val_5 = null;
        val_5 = null;
        下专丅七丂且丗丄丅(丑丒业丘丑东丕世丅:  true);
        val_6 = null;
        val_6 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = GetComponent<UnityEngine.Camera>();
    }
    internal void 丆丄上丛丝东丅专东()
    {
        this.专东丂丑世丙丟上丝();
        this.duelUI.丏丛丈东丘丏丏下丁();
        this.spectatorModeStarted = true;
    }
    internal void 三丒丕七丒丞丕专业()
    {
        if(this.spectatorModeStarted == false)
        {
                return;
        }
        
        this.duelUI.一丞丄丗世丟业丌万();
        this.spectatorModeStarted = false;
    }
    internal void 丕且丅丞世三不七万()
    {
        this.丆丄上丛丝东丅专东();
    }
    private void 丑丘下丒上丐不丗不(int 丗三上丞丆七不且七, int 丂东丘世与不丌丑七, int 丟丝丐东丞万丙丛丂, int 三一丁丟丛丝与万丈, int[] 上丕丁丕丄丂丗业业)
    {
        var val_17;
        int val_27;
        int val_28;
        UnityEngine.Object val_29;
        var val_30;
        WeaponManager val_31;
        UnityEngine.Object val_32;
        var val_33;
        UISprite[] val_35;
        var val_36;
        var val_37;
        val_27 = 丟丝丐东丞万丙丛丂;
        val_28 = 丂东丘世与不丌丑七;
        if(TeamDuelController.与且一丛丅丟丄丅七 != null)
        {
                TeamDuelController.与且一丛丅丟丄丅七.Invoke(obj:  丗三上丞丆七不且七);
        }
        
        if(丗三上丞丆七不且七 == 2)
        {
            goto label_2;
        }
        
        if(丗三上丞丆七不且七 != 1)
        {
            goto label_4;
        }
        
        val_28 = val_28 + 1;
        goto label_4;
        label_2:
        val_27 = val_27 + 1;
        label_4:
        this.roundsPlayed = 三一丁丟丛丝与万丈;
        this.七丁丞万丅丄且丈且 = 上丕丁丕丄丂丗业业;
        this.finalRound = false;
        this.isGo = false;
        this.playerStarted = false;
        this.roundEndFade = true;
        this.三丒丕七丒丞丕专业();
        val_29 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_29 != 0)
        {
                val_29 = InGameGUI.丙丞专丌丁丞与不丐.respawnWindowController;
            Close();
        }
        
        this.roomStatus = 3;
        bool val_2 = isMaster;
        if(val_2 != false)
        {
                val_2.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  3);
        }
        
        val_30 = null;
        val_30 = null;
        val_31 = 1152921504838316032;
        val_32 = 丘丑丅三丆丑丌且丝();
        val_33 = 0;
        val_35 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 920];
        val_35 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.roundShields;
        if(GameConnect.丑丌丛丈丅丅与不业() != 16)
        {
            goto label_82;
        }
        
        val_31 = 1152921505246248960;
        val_32 = PlayerBotsManager.与一丅丝不丈业与丙();
        if(val_32 == 0)
        {
            goto label_82;
        }
        
        PlayerBotsManager val_14 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_32 = val_14.业丌上丁下七不丐丝;
        List.Enumerator<T> val_15 = val_32.GetEnumerator();
        val_31 = 1152921536121657616;
        val_35 = 1152921536121658640;
        label_70:
        if((1531262880 & 1) == 0)
        {
            goto label_55;
        }
        
        if(((isMine == false) || ( == 0)) || ( == 0))
        {
            goto label_70;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  val_17.丐丏七丌丕丗业且上().gameObject);
        goto label_70;
        label_55:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_82:
        if(((val_28 <= 3) && (val_27 <= 3)) && (this.roundsPlayed < 7))
        {
                val_36 = null;
            val_36 = null;
            val_31 = WeaponManager.丟丗丄业丘丗业丗七;
            int[] val_23 = new int[2];
            val_35 = val_23;
            if(val_35 == null)
        {
                val_37 = 0;
        }
        
            val_35[0] = val_23.blueTeamWins;
            val_35[0] = this.redTeamWins;
            世丝丝丛丗丒丙与世(丄丘丄丕下丅下且丆:  丗三上丞丆七不且七, 丝且丄丛专业丞东丙:  val_23);
            return;
        }
        
        this.丏且丛丛下业专一七(业丂上世丝一丌丌上:  false);
    }
    internal static void 丌丛丂七专丛东丛七(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  TeamDuelController.与且一丛丅丟丄丅七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(TeamDuelController.与且一丛丅丟丄丅七 != 1152921505328308232);
    
    }
    internal static void 专丟丁万丒下丙丆业(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  TeamDuelController.与且一丛丅丟丄丅七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(TeamDuelController.与且一丛丅丟丄丅七 != 1152921505328308232);
    
    }
    private void 丛丆专七丛且丈丈万()
    {
        var val_15;
        var val_16;
        var val_17;
        bool val_18;
        var val_19;
        var val_20;
        bool val_21;
        var val_22;
        var val_23;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_16 = 0;
        val_17 = 1;
        goto label_7;
        label_13:
        if((val_17 & 1) != 0)
        {
                NetworkStartTable val_2 = this.redTeam.Item[0];
            val_18 = val_2.丄世一丞万一丁丙丁;
        }
        else
        {
                val_18 = 0;
        }
        
        var val_3 = (val_18 != 0) ? 1 : 0;
        val_16 = 1;
        label_7:
        if(val_16 < this.redTeam.Count)
        {
            goto label_13;
        }
        
        val_19 = 0;
        val_20 = 1;
        goto label_14;
        label_20:
        if((val_20 & 1) != 0)
        {
                NetworkStartTable val_5 = this.blueTeam.Item[0];
            val_21 = val_5.丄世一丞万一丁丙丁;
        }
        else
        {
                val_21 = 0;
        }
        
        var val_6 = (val_21 != 0) ? 1 : 0;
        val_19 = 1;
        label_14:
        if(val_19 < this.blueTeam.Count)
        {
            goto label_20;
        }
        
        var val_15 = ~(val_3 & val_6);
        val_15 = val_15 & 1;
        val_21 = val_3 | val_6;
        if((val_21 & 1) == 0)
        {
                int val_11 = this.万丝上丈丒丕丗丐下();
            int val_12 = this.丑丝丂丌七丐丌丄丗();
            if(val_11 > val_12)
        {
                val_22 = 1;
        }
        else
        {
                int val_13 = (val_12 > val_11) ? 2 : ((val_3 != 1) ? (val_15) : ((val_6 != 1) ? 2 : 0));
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        if(this.roundsPlayed < this.七丁丞万丅丄且丈且.Length)
        {
                this.七丁丞万丅丄且丈且[this.roundsPlayed] = val_13;
        }
        
        int val_16 = this.roundsPlayed;
        val_16 = val_16 + 1;
        this.roundsPlayed = val_16;
        object[] val_14 = new object[5];
        val_14[0] = val_13;
        val_14[1] = typeof(TeamController).__il2cppRuntimeField_38;
        val_14[2] = typeof(TeamController).__il2cppRuntimeField_3C;
        val_14[3] = this.roundsPlayed;
        val_14[4] = this.七丁丞万丅丄且丈且;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  148, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_14);
        this.丑丘下丒上丐不丗不(丗三上丞丆七不且七:  val_13, 丂东丘世与不丌丑七:  typeof(TeamController).__il2cppRuntimeField_38, 丟丝丐东丞万丙丛丂:  typeof(TeamController).__il2cppRuntimeField_3C, 三一丁丟丛丝与万丈:  this.roundsPlayed, 上丕丁丕丄丂丗业业:  this.七丁丞万丅丄且丈且);
    }
    private void 丏且丛丛下业专一七(bool 业丂上世丝一丌丌上 = False)
    {
        var val_8;
        var val_9;
        var val_10;
        this.playerStarted = false;
        this.finalRound = true;
        this.roomStatus = 5;
        bool val_1 = this.isMaster;
        if(val_1 != false)
        {
                val_1.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  5);
        }
        
        val_8 = null;
        val_8 = null;
        bool val_2 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable, y:  0);
        if(val_2 == true)
        {
                return;
        }
        
        if(业丂上世丝一丌丌上 != false)
        {
                val_9 = null;
            val_9 = null;
            int val_3 = 丘丑丅三丆丑丌且丝();
        }
        else
        {
                int val_7 = val_2.blueTeamWins.redTeamWins.redTeamWins.blueTeamWins;
        }
        
        val_10 = null;
        val_10 = null;
        if(GameController.mode != null)
        {
                GameController.mode.七丁丕一一丒丂七丑();
        }
        
        this.丘丝丑丕丒丄丛丆东 = false;
    }
    internal void 上且丈丙丙丆丞丛世(int 丆上下丟丈丈万与丞, int 三七专业不丝丆丕丑, int 丝丐丐丟丙丆一丄丗)
    {
        null = null;
        typeof(TeamController).__il2cppRuntimeField_38 = 丆上下丟丈丈万与丞;
        typeof(TeamController).__il2cppRuntimeField_3C = 三七专业不丝丆丕丑;
        typeof(TeamController).__il2cppRuntimeField_40 = (float)丆上下丟丈丈万与丞;
        typeof(TeamController).__il2cppRuntimeField_44 = (float)三七专业不丝丆丕丑;
        this.roundsPlayed = 丝丐丐丟丙丆一丄丗;
    }
    public TeamDuelController()
    {
        this.blueTeam = new System.Collections.Generic.List<NetworkStartTable>();
        this.redTeam = new System.Collections.Generic.List<NetworkStartTable>();
        this.connectingBlueTeam = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.connectingRedTeam = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.且丄丟丏丛丞丆丂丘 = new System.Collections.Generic.List<NetworkStartTable>();
        this.丅丑丄丌丛万丐不不 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.myTeamInDuel = 0;
        this.七丁丞万丅丄且丈且 = new int[7];
        this.丘丝丑丕丒丄丛丆东 = true;
        this.上丏丐丆丌不与下丈 = true;
    }

}
