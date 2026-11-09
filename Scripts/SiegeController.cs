using UnityEngine;
internal sealed class SiegeController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal static SiegeController 丄丘七三上丕世丞业;
    internal static float 丆丙七丑业丌丘丑万;
    internal static float 丑丘三丞七下上丁丌;
    public float timerWaitOtherClan;
    public float timerWaitClanMembers;
    public SiegeController.丛丏丂丄上专且万业 roomStatus;
    public SiegeController.丛丏丂丄上专且万业 lastRoomStatus;
    public float matchTime;
    private const float 丁丑丞东且万一下一 = 25;
    private const float 丐丄丂不丟丈且三丂 = 6;
    private const int 三三万丆下一丗万丛 = 5;
    private float 不丄丟丞丄万不丈丌;
    private float 丙丟丕下丒上丏丝且;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    internal System.Collections.Generic.List<NetworkStartTable> team1;
    internal System.Collections.Generic.List<NetworkStartTable> team2;
    internal System.Collections.Generic.List<NetworkStartTable> 且丄丟丏丛丞丆丂丘;
    public System.Collections.Generic.List<与丅丕丈丘东丝世丟> connectingTeam1;
    public System.Collections.Generic.List<与丅丕丈丘东丝世丟> connectingTeam2;
    private System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丅丑丄丌丛万丐不不;
    public bool playerStarted;
    public bool matchStarted;
    public bool goInterfaceShowed;
    public bool fortInit;
    private float 丞万业丐丛不七且丞;
    private float 丈丛万不丈与专丐世;
    private float 丆丙丌丛丝下一丏上;
    public int mySiegeTeam;
    public UnityEngine.GameObject gatesPosition;
    private readonly int 丂丅丄丈专东丞丛丌;
    private readonly int 丘丏丞丛不丆万丙丕;
    private readonly int 丝丆丌丁丏丙业上丒;
    private readonly int 不丌丙丌丒丙三丕丙;
    private WorldPosIndicationItem 丝丞丒丗丁下丌东下;
    private WorldPosIndicationItem 丒不丆丁丛丂丅丗下;
    public SiegeTeamsController teamsController;
    private bool 丘丝丑丕丒丄丛丆东;
    public float team1Progress;
    private float 丂丈不丗丝丙丈与不;
    private bool 专专丏三丙丁丛丁世;
    public float team2Progress;
    private float 丟东业专下丄丐丟丁;
    private bool 丟东丁世丗且丂丟下;
    private bool 丆万丑丆与丗丟丟丝;
    private bool 专丂业东丈七专丂且;
    public System.Collections.Generic.Dictionary<int, 丆丙丆且下丐丗丁一> connectingPlayerCharacters;
    public System.Collections.Generic.Dictionary<int, 丆丙丆且下丐丗丁一> connectingPlayerCharactersBuffer;
    public SiegeController.与丂东专丏且丆丝丗 fort1Animation;
    public SiegeController.与丂东专丏且丆丝丗 fort2Animation;
    public bool myFortReady;
    private System.Collections.Generic.List<SiegeCharacterPoint> 丙丛丄万东丕丄七丙;
    public string winnerText;
    private bool 丆世丞丞东世丅丗丁;
    
    // Properties
    public SiegeController.丛丏丂丄上专且万业 业丂丆丝丏丛一三丁 { get; set; }
    public bool 丝丝丗七丑丁丕丗丄 { get; }
    public float 丄专万丏丘上丑与一 { get; }
    public bool 专丗丛丝丗丞下丑丄 { get; }
    private WorldPosIndicationItem 丙且丌丂丏丕丆丁且 { get; }
    private WorldPosIndicationItem 业万下世丁丆丄丞丆 { get; }
    public int 丛丈丘丑三东东丒一 { get; }
    public bool 万三万丄上东丝丛丐 { get; }
    public SiegeContainerGUI 世且不专上专丞丁一 { get; }
    public bool 丈丁丅丙丙万丆丄丅 { get; }
    internal bool 三丒一丕丈丁丐丟不 { get; }
    internal float 丅丙丟三三丐上丘丐 { get; }
    internal bool 不丒丁丆丙上世丙上 { get; }
    internal float 东下且丆丛丌东且丕 { get; }
    public bool 丕丄下丗万上丈东世 { get; }
    
    // Methods
    public SiegeController.丛丏丂丄上专且万业 get_roomStatusGlobal()
    {
        var val_5;
        var val_7;
        val_5 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (丛丏丂丄上专且万业)null;
        }
        
        val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_7 = null;
        val_7 = null;
        object val_4 = val_5.Item[GameConnect.丟丞丏丝与丙丁丛与];
        return (丛丏丂丄上专且万业)null;
    }
    public void set_roomStatusGlobal(SiegeController.丛丏丂丄上专且万业 丙业与丙丗丝不丈东)
    {
        var val_6;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Debug.Log(message:  "RoomStatusGlobal = "("RoomStatusGlobal = ") + 丙业与丙丗丝不丈东.ToString());
            ExitGames.Client.Photon.Hashtable val_4 = new ExitGames.Client.Photon.Hashtable();
            val_6 = null;
            val_6 = null;
            val_4.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  688975872);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_4, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
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
    private WorldPosIndicationItem 丕业丈丄与一上丞丅()
    {
        WorldPosIndicationItem val_2 = this.丝丞丒丗丁下丌东下;
        if(val_2 != 0)
        {
                return val_2;
        }
        
        this.丕七下丗专丈三丄丈(丞丈且下且丙丞与丈: out  val_2, 丞下万上三丘上与专:  TramObject.__il2cppRuntimeField_castClass);
        return val_2;
    }
    private WorldPosIndicationItem 世丞业丁业丆丈丘世()
    {
        WorldPosIndicationItem val_3 = this.丒不丆丁丛丂丅丗下;
        if(val_3 != 0)
        {
                return val_3;
        }
        
        UnityEngine.Transform val_2 = this.gatesPosition.transform;
        val_2.丕七下丗专丈三丄丈(丞丈且下且丙丞与丈: out  val_3, 丞下万上三丘上与专:  val_2);
        return val_3;
    }
    public int get_attackTeam()
    {
        丛丏丂丄上专且万业 val_1 = this.roomStatus;
        val_1 = val_1 - 1;
        if(val_1 > 5)
        {
                return 0;
        }
        
        return (int)106014688 + ((this.roomStatus - 1)) << 2;
    }
    public bool get_inAttackTeam()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_6;
        }
        
        val_5 = null;
        val_5 = null;
        丛丏丂丄上专且万业 val_4 = this.roomStatus;
        val_4 = val_4 - 1;
        if(val_4 > 5)
        {
            goto label_11;
        }
        
        val_6 = mem[106014688 + ((this.roomStatus - 1)) << 2];
        val_6 = 106014688 + ((this.roomStatus - 1)) << 2;
        return (bool)(丘丑丅三丆丑丌且丝() == val_6) ? 1 : 0;
        label_6:
        val_7 = 0;
        return (bool)(丘丑丅三丆丑丌且丝() == val_6) ? 1 : 0;
        label_11:
        val_6 = 0;
        return (bool)(丘丑丅三丆丑丌且丝() == val_6) ? 1 : 0;
    }
    public SiegeContainerGUI get_containerUI()
    {
        InGameGUI val_2;
        var val_3;
        val_2 = InGameGUI.丙丞专丌丁丞与不丐;
        val_3 = 0;
        if(val_2 == 0)
        {
                return (SiegeContainerGUI)InGameGUIPart_Siege.__il2cppRuntimeField_this_arg;
        }
        
        val_2 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 768];
        val_2 = InGameGUI.丙丞专丌丁丞与不丐.丅丟与丟东丛东丛一;
        return (SiegeContainerGUI)InGameGUIPart_Siege.__il2cppRuntimeField_this_arg;
    }
    public bool get_calculateRatingOnNullPlayer()
    {
        if(this.丘丝丑丕丒丄丛丆东 == false)
        {
                return false;
        }
        
        丛丏丂丄上专且万业 val_2 = this.roomStatus;
        if(val_2 == 0)
        {
                return false;
        }
        
        if(val_2 == 3)
        {
                return false;
        }
        
        val_2 = val_2 - 1;
        return (bool)(val_2 > 1) ? 1 : 0;
    }
    internal bool 丒一丘丘不丕七一不()
    {
        return (bool)this.专专丏三丙丁丛丁世;
    }
    internal float 丅一丛丑丒丘丅三下()
    {
        return (float)this.丂丈不丗丝丙丈与不;
    }
    internal bool 丈业且上三且丄丅丄()
    {
        return (bool)this.丟东丁世丗且丂丟下;
    }
    internal float 业不丁与业专与丝丂()
    {
        return (float)this.丟东业专下丄丐丟丁;
    }
    public bool get_isRoundEnding()
    {
        return (bool)this.专丂业东丈七专丂且;
    }
    private void Awake()
    {
        var val_9;
        bool val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Action<与丅丕丈丘东丝世丟> val_14;
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_3;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_3:
        val_10 = 0;
        if(this != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        this.enabled = (val_10 != 0) ? 1 : 0;
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        SiegeController.三三万丆下一丗万丛 = this;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        val_13 = null;
        val_13 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void SiegeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_14 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_14;
        this.team1Progress = 0f;
        this.丂丈不丗丝丙丈与不 = 0f;
        this.专专丏三丙丁丛丁世 = false;
        this.丟东丁世丗且丂丟下 = false;
        this.丆万丑丆与丗丟丟丝 = false;
        this.专丂业东丈七专丂且 = false;
        this.team2Progress = 0f;
        this.丟东业专下丄丐丟丁 = 0f;
        this.丘丝丑丕丒丄丛丆东 = true;
        bool val_8 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_8 == false)
        {
                return;
        }
        
        val_8.丛丞丗且丟丈丛丐丌();
    }
    private void 丟一丁与丙丟丟丘不()
    {
        this.专专丏三丙丁丛丁世 = false;
        this.team1Progress = 0f;
        this.丂丈不丗丝丙丈与不 = 0f;
        this.team2Progress = 0f;
        this.丟东业专下丄丐丟丁 = 0f;
        this.丟东丁世丗且丂丟下 = false;
        this.丆万丑丆与丗丟丟丝 = false;
        this.专丂业东丈七专丂且 = false;
        this.丘丝丑丕丒丄丛丆东 = true;
    }
    private void 丕七下丗专丈三丄丈(out WorldPosIndicationItem 丞丈且下且丙丞与丈, UnityEngine.Transform 丞下万上三丘上与专)
    {
        丞丈且下且丙丞与丈 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        WorldPosIndicationItem val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem>();
        丞丈且下且丙丞与丈 = val_2;
        val_2.万三丗丆下万丅上丈(丞下万上三丘上与专:  丞下万上三丘上与专, 丒专丌万丄一丒万丏:  0f);
    }
    private void 丏丅丅丘上丆业丂丟()
    {
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        System.Collections.Generic.List<NetworkStartTable> val_59;
        var val_60;
        System.Collections.Generic.List<NetworkStartTable> val_61;
        var val_62;
        var val_63;
        var val_64;
        string val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        SiegeController val_71;
        var val_72;
        string val_73;
        var val_74;
        string val_75;
        var val_76;
        var val_77;
        string val_78;
        var val_79;
        var val_80;
        this.team1.Clear();
        this.team2.Clear();
        val_54 = 0;
        goto label_3;
        label_33:
        val_55 = null;
        val_55 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() >= 1)
        {
                val_56 = null;
            val_56 = null;
            NetworkStartTable val_3 = Item[0];
            if(val_3.丄且丏一且丈丂与丂 != false)
        {
                val_57 = null;
            val_57 = null;
            if(Item[0].丘丑丅三丆丑丌且丝() == 1)
        {
                val_58 = null;
            val_59 = this.team1;
        }
        else
        {
                val_58 = null;
            val_59 = this.team2;
            val_58 = null;
        }
        
            val_59.Add(item:  Item[0]);
        }
        
        }
        
        val_54 = 1;
        label_3:
        val_60 = null;
        val_60 = null;
        val_61 = mem[GameController.onlineMode + 392];
        val_61 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_54 < Count)
        {
            goto label_33;
        }
        
        this.connectingTeam1.Clear();
        this.connectingTeam2.Clear();
        val_62 = 1152921505107111936;
        val_63 = 0;
        goto label_36;
        label_140:
        val_64 = 0;
        val_65 = 0;
        goto label_37;
        label_65:
        val_64 = 1;
        label_37:
        val_66 = null;
        val_66 = null;
        if(val_64 >= Count)
        {
            goto label_42;
        }
        
        val_67 = null;
        val_67 = null;
        NetworkStartTable val_9 = Item[1];
        if(val_9.丄丈丑丐丆丞丘与丗.owner != 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[val_65])
        {
            goto label_65;
        }
        
        val_68 = null;
        val_68 = null;
        if(Item[1].丘丑丅三丆丑丌且丝() < 1)
        {
            goto label_65;
        }
        
        val_69 = null;
        val_69 = null;
        val_61 = Item[1];
        if(val_14.丄且丏一且丈丂与丂 == false)
        {
            goto label_65;
        }
        
        goto label_66;
        label_42:
        与丅丕丈丘东丝世丟 val_55 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[val_65];
        int val_18 = this.connectingTeam1.Count + this.team1.Count;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_56 = this.connectingTeam2;
        val_65 = this;
        val_56 = val_56.Count + this.team2.Count;
        val_70 = null;
        val_62 = 1152921505107111936;
        val_71 = val_65;
        if((val_55.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.与丘三丈丆丁三丆丐)) != false)
        {
                val_72 = null;
            val_72 = null;
            if((val_55.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丘三丈丆丁三丆丐] != null) && (null != null))
        {
                val_73 = 0;
        }
        
            if((System.String.IsNullOrEmpty(value:  val_73)) != true)
        {
                val_74 = null;
            val_74 = null;
            val_75 = val_55.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丘三丈丆丁三丆丐];
            if((val_75 != null) && (null != null))
        {
                val_75 = 0;
        }
        
            if((System.String.op_Inequality(a:  val_75, b:  "-1")) != false)
        {
                val_76 = null;
            val_76 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丁丝丕上下丗丕丞东)) != false)
        {
                val_77 = null;
            val_77 = null;
            val_78 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丁丝丕上下丗丕丞东];
        }
        else
        {
                val_78 = "-1";
        }
        
            val_79 = null;
            val_79 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟不下业世与丈下三)) != false)
        {
                val_80 = null;
            val_80 = null;
            val_65 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟不下业世与丈下三];
        }
        else
        {
                val_65 = "-1";
        }
        
            val_71 = this;
            bool val_49 = System.String.op_Equality(a:  val_78, b:  "-1");
            if(val_49 != false)
        {
                if(val_18 <= 4)
        {
                if((val_49.丏丘丕丝丝丑丐与东(丌专万丝三七丅丈一:  val_75, 下丄丁丑三丏丗丛七:  1)) > 0)
        {
            goto label_133;
        }
        
        }
        
        }
        
            bool val_51 = System.String.op_Equality(a:  val_65, b:  "-1");
            if(val_51 != false)
        {
                if(val_56 <= 4)
        {
                if((val_51.丏丘丕丝丝丑丐与东(丌专万丝三七丅丈一:  val_75, 下丄丁丑三丏丗丛七:  2)) > 0)
        {
            goto label_132;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        if((((System.String.op_Equality(a:  val_75, b:  val_65).丏丘丕丝丝丑丐与东(丌专万丝三七丅丈一:  val_75, 下丄丁丑三丏丗丛七:  2)) > 4) ? (((System.String.op_Equality(a:  val_75, b:  val_78).丏丘丕丝丝丑丐与东(丌专万丝三七丅丈一:  val_75, 下丄丁丑三丏丗丛七:  1)) > 4) ? ((val_56 < val_18) ? (1 + 1) : 1) : (0 + 1)) : 2) != 2)
        {
            goto label_133;
        }
        
        label_132:
        val_61 = this.connectingTeam2;
        if(val_61 != null)
        {
            goto label_136;
        }
        
        goto label_135;
        label_133:
        val_61 = this.connectingTeam1;
        if(val_61 != null)
        {
            goto label_136;
        }
        
        label_135:
        label_136:
        val_61.Add(item:  val_55);
        label_66:
        val_63 = 1;
        label_36:
        与丅丕丈丘东丝世丟[] val_53 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_63 < val_53.Length)
        {
            goto label_140;
        }
    
    }
    private int 丏丘丕丝丝丑丐与东(string 丌专万丝三七丅丈一, int 下丄丁丑三丏丗丛七)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = 0;
        val_8 = 0;
        goto label_1;
        label_17:
        val_9 = null;
        val_9 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() == 下丄丁丑三丏丗丛七)
        {
                val_10 = null;
            val_10 = null;
            NetworkStartTable val_3 = Item[0];
            val_8 = val_8 + (System.String.op_Equality(a:  val_3.丄下丝业七丅与且丐, b:  丌专万丝三七丅丈一));
        }
        
        val_7 = 1;
        label_1:
        val_11 = null;
        val_11 = null;
        if(val_7 < Count)
        {
            goto label_17;
        }
        
        return (int)val_8;
    }
    private void 专丂世丞丁丁丌丕下()
    {
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        bool val_34;
        if(this.containerUI == 0)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        bool val_3 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable, y:  0);
        if(val_3 == true)
        {
                return;
        }
        
        val_3.containerUI.UpdateTeam(丞丌丁万不东丅丐丒:  this.inAttackTeam);
        bool val_7 = UnityEngine.Object.op_Inequality(x:  TramController.丄丘七三上丕世丞业, y:  0);
        if(val_7 == false)
        {
                return;
        }
        
        val_7.containerUI.SetCheckpointCount(丌丒丝东丌下丕丁丅:  Count);
        bool val_10 = IsMovingForward();
        if(val_10 != false)
        {
                val_29 = UnityEngine.Mathf.Min(a:  3, b:  TramController.丄丘七三上丕世丞业.AttackPlayersOnTram());
        }
        else
        {
                val_29 = 0;
        }
        
        SiegeContainerGUI val_13 = val_10.containerUI;
        val_13.SetTramMoveSpeed(三丑丏世丂丆丕丈专:  0, 一丆丆丈丁丝丆丑丄:  IsMovingBack());
        一上丕丞丙一丈七丛 val_17 = TramController.丄丘七三上丕世丞业.GetCheckpointsProgress();
        val_13.containerUI.UpdateProgress(上丕丈丞丌丘丅不与:  new 一上丕丞丙一丈七丛() {丆丄丘七东世丒丐七 = val_17.丆丄丘七东世丒丐七, 上丕丈丞丌丘丅不与 = val_17.上丕丈丞丌丘丅不与});
        val_30 = null;
        val_30 = null;
        if(丘丑丅三丆丑丌且丝() == 1)
        {
                val_31 = this;
            int val_19 = this.GetTeam1Distance();
        }
        else
        {
                val_31 = this;
        }
        
        val_32 = null;
        val_32 = null;
        if(丘丑丅三丆丑丌且丝() == 1)
        {
                val_33 = this;
            int val_22 = this.GetTeam2Distance();
        }
        else
        {
                val_33 = this;
            int val_23 = this.GetTeam1Distance();
        }
        
        if(this.专专丏三丙丁丛丁世 != false)
        {
                val_34 = 1;
        }
        else
        {
                val_34 = this.丟东丁世丗且丂丟下;
        }
        
        丛丏丂丄上专且万业 val_28 = this.roomStatus;
        val_28 = val_28 - 5;
        一上丕丞丙一丈七丛 val_26 = TramController.丄丘七三上丕世丞业.GetCheckpointsProgressFor(丛一与丝丝丟上不丛:  (val_28 < 2) ? this.team2Progress : this.team1Progress);
        val_23.containerUI.UpdateUI(一丁且丐丑专且一上:  (val_34 == true) ? 1 : 0, 丕丛三丈丂丕专下东:  this.GetTeam2Distance(), 七丝丁上丑万万丛丝:  val_23, 万丆丈丁与世丛下不:  new 一上丕丞丙一丈七丛() {丆丄丘七东世丒丐七 = val_26.丆丄丘七东世丒丐七, 上丕丈丞丌丘丅不与 = val_26.上丕丈丞丌丘丅不与});
    }
    public int GetTeam1Distance()
    {
        if((this.roomStatus - 5) <= 1)
        {
                float val_2 = TramController.丄丘七三上丕世丞业.GetCurrentDistanceProgress();
            return UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team1Progress));
        }
        
        return UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team1Progress));
    }
    public int GetTeam2Distance()
    {
        if((this.roomStatus - 1) <= 3)
        {
                float val_2 = TramController.丄丘七三上丕世丞业.GetCurrentDistanceProgress();
            return UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team2Progress));
        }
        
        return UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team2Progress));
    }
    public 丆丙丆且下丐丗丁一 GetCharacterForConnectingPlayer(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        int val_7;
        丆丙丆且下丐丗丁一 val_8;
        if((this.connectingPlayerCharacters.ContainsKey(key:  专丞上七七且丝七丗.业丐丐三丕一丗丛丁())) != false)
        {
                val_7 = 专丞上七七且丝七丗.业丐丐三丕一丗丛丁();
            val_8 = this.connectingPlayerCharacters.Item[val_7];
            return val_8;
        }
        
        丆丙丆且下丐丗丁一 val_5 = null;
        val_8 = val_5;
        val_5 = new 丆丙丆且下丐丗丁一();
        val_5.丝丅与丒东世丒丁丕();
        val_7 = 专丞上七七且丝七丗.业丐丐三丕一丗丛丁();
        this.connectingPlayerCharacters.Add(key:  val_7, value:  val_5);
        return val_8;
    }
    public 丆丙丆且下丐丗丁一 GetCharacterForConnectingPlayerNotCreate(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        System.Collections.Generic.Dictionary<System.Int32, 丆丙丆且下丐丗丁一> val_5;
        int val_6;
        var val_7;
        val_6 = 专丞上七七且丝七丗;
        if(val_6 != null)
        {
                val_5 = this.connectingPlayerCharacters;
            if((val_5.ContainsKey(key:  val_6.业丐丐三丕一丗丛丁())) != false)
        {
                val_6 = val_6.业丐丐三丕一丗丛丁();
            丆丙丆且下丐丗丁一 val_4 = this.connectingPlayerCharacters.Item[val_6];
            return (丆丙丆且下丐丗丁一)val_7;
        }
        
        }
        
        val_7 = 0;
        return (丆丙丆且下丐丗丁一)val_7;
    }
    private void Update()
    {
        float val_14;
        SiegeTeamsController val_76;
        object val_77;
        var val_78;
        丛丏丂丄上专且万业 val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        NetworkStartTable val_84;
        var val_85;
        System.Collections.Generic.List<NetworkStartTable> val_86;
        var val_87;
        var val_88;
        var val_89;
        var val_90;
        var val_91;
        var val_92;
        var val_93;
        var val_94;
        var val_95;
        System.Collections.Generic.List<NetworkStartTable> val_96;
        System.Collections.Generic.List<NetworkStartTable> val_97;
        UnityEngine.Object val_102;
        var val_103;
        string val_104;
        var val_105;
        float val_107;
        float val_108;
        var val_109;
        var val_110;
        var val_111;
        var val_112;
        val_76 = this;
        val_77 = 1152921505107111936;
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        丛丏丂丄上专且万业 val_2 = val_1.roomStatusGlobal;
        if(val_2 == 0)
        {
                val_2.roomStatusGlobal = 3;
        }
        
        val_78 = val_76;
        val_79 = this.roomStatus;
        if(val_79 > 2)
        {
            goto label_15;
        }
        
        val_79 = val_2.roomStatusGlobal;
        this.roomStatus = val_79;
        if((val_79 | 2) != 6)
        {
            goto label_15;
        }
        
        val_80 = null;
        val_80 = null;
        if(FortEquipmentController.丝丘丞不丂丆不丘且 != 0)
        {
                this.fortInit = true;
            val_81 = null;
            val_81 = null;
            FortEquipmentController.丝丘丞不丂丆不丘且.ResetForNewMatch(且与丘丄丟丄丟丏丝:  (this.roomStatus == 6) ? 1 : 0);
        }
        
        val_79 = this.roomStatus;
        goto label_15;
        label_3:
        val_78 = val_76;
        this.roomStatus = 0;
        val_79 = 0;
        mem[1152921539782512513] = 0;
        label_15:
        val_82 = null;
        val_82 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                this.playerStarted = false;
        }
        
        val_83 = null;
        val_83 = null;
        val_84 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_84 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_84 == 0)
        {
                val_76 = this.teamsController;
            val_76.Clear();
            return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                this.lastRoomStatus = val_79;
        }
        
        val_85 = null;
        val_85 = null;
        int val_10 = 丘丑丅三丆丑丌且丝();
        if(val_10 < 1)
        {
            goto label_37;
        }
        
        if(val_10 != 1)
        {
            goto label_38;
        }
        
        val_86 = this.team1;
        goto label_40;
        label_37:
        val_86 = this.且丄丟丏丛丞丆丂丘;
        goto label_40;
        label_38:
        val_86 = this.team2;
        label_40:
        this.connectingPlayerCharactersBuffer.Clear();
        Dictionary.Enumerator<TKey, TValue> val_11 = this.connectingPlayerCharacters.GetEnumerator();
        label_45:
        if((815914800 & 1) == 0)
        {
            goto label_43;
        }
        
        ConfiguredValueTaskAwaiter val_15 = val_14.GetAwaiter();
        this.connectingPlayerCharactersBuffer.Add(key:  val_15._value._obj.丙东专丂世丈丏丁丂(), value:  val_15._value._obj);
        goto label_45;
        label_43:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_87 = val_77;
        Dictionary.Enumerator<TKey, TValue> val_17 = this.connectingPlayerCharactersBuffer.GetEnumerator();
        val_77 = 1152921505189646336;
        val_88 = 1152921525488042576;
        label_95:
        if((815914800 & 1) == 0)
        {
            goto label_53;
        }
        
        ConfiguredValueTaskAwaiter val_18 = val_14.GetAwaiter();
        val_89 = 0;
        goto label_54;
        label_89:
        val_89 = 1;
        label_54:
        val_90 = null;
        val_90 = null;
        if(val_89 >= Count)
        {
            goto label_59;
        }
        
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
            goto label_90;
        }
        
        val_91 = null;
        val_91 = null;
        NetworkStartTable val_23 = Item[1];
        if(val_23.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_89;
        }
        
        val_92 = null;
        val_92 = null;
        NetworkStartTable val_25 = Item[1];
        if(val_25.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁() != val_18._value._obj.丙东专丂世丈丏丁丂())
        {
            goto label_89;
        }
        
        val_93 = null;
        val_93 = null;
        if(Item[1].丘丑丅三丆丑丌且丝() < 1)
        {
            goto label_89;
        }
        
        val_94 = null;
        val_94 = null;
        NetworkStartTable val_31 = Item[1];
        if(val_31.丄且丏一且丈丂与丂 == false)
        {
            goto label_89;
        }
        
        goto label_90;
        label_59:
        if((与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  val_18._value._obj.丙东专丂世丈丏丁丂())) != null)
        {
            goto label_95;
        }
        
        label_90:
        this.connectingPlayerCharacters.Item[val_18._value._obj.丙东专丂世丈丏丁丂()].Destroy();
        bool val_35 = this.connectingPlayerCharacters.Remove(key:  val_18._value._obj.丙东专丂世丈丏丁丂());
        goto label_95;
        label_53:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_95 = val_79;
        val_96 = this.team1;
        val_97 = val_86;
        this.teamsController.专丑丗丆丌丛丌丐丆(丒七丈丏丏与丛丌丘:  null, 丐且丈丝丕丕一丒与:  null, 丒专丛上丁丗与与丞:  this.connectingTeam2, 丈丏丟丅丕业丆丏业:  this.connectingTeam1);
        val_78 = 1152921504848912384;
        if(this.丆万丑丆与丗丟丟丝 == false)
        {
            goto label_127;
        }
        
        if(( == 3) || ( == 5))
        {
            goto label_129;
        }
        
        goto label_131;
        label_127:
        if(( - 3) > 3)
        {
            goto label_131;
        }
        
        var val_77 = 106014624 + ((val_95 - 3)) << 2;
        val_77 = val_77 + 106014624;
        goto (106014624 + ((val_95 - 3)) << 2 + 106014624);
        label_131:
        var val_78 = val_79;
        val_78 = val_78 - 1;
        if(val_78 > 1)
        {
            goto label_211;
        }
        
        label_129:
        this.丏丅丅丘上丆业丂丟();
        val_84 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        val_102 = val_84;
        if(val_102 == 0)
        {
            goto label_148;
        }
        
        val_103 = null;
        val_103 = null;
        丑丁不万丈丟万且业();
        val_84 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1000];
        val_84 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.siegeUI;
        if(this.myFortReady == false)
        {
            goto label_158;
        }
        
        if(((丘丑丅三丆丑丌且丝() == 1) ? this.fort1Animation : this.fort2Animation) != 0)
        {
                if((val_44 == 1 ? this.fort1Animation : this.fort2Animation + 24) == 0)
        {
            goto label_158;
        }
        
        }
        
        val_104 = this.丑不上业且上丒丞世();
        if(null != 0)
        {
            goto label_161;
        }
        
        goto label_160;
        label_158:
        val_104 = "";
        if(null != 0)
        {
            goto label_161;
        }
        
        label_160:
        label_161:
        val_102 = val_84;
        且专丕丙丈丐下丘丛(专下不丘丘丝丅七三:  val_104);
        label_148:
        if(this.丞万业丐丛不七且丞 <= 0f)
        {
            goto label_162;
        }
        
        if(this.fort1Animation != null)
        {
                if(this.fort1Animation.丄上且东丙丘丙丈丕 == false)
        {
            goto label_166;
        }
        
        }
        
        if(this.fort2Animation != null)
        {
                if(this.fort2Animation.丄上且东丙丘丙丈丕 == false)
        {
            goto label_166;
        }
        
        }
        
        val_105 = 0;
        val_107 = UnityEngine.Time.deltaTime;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_169;
        }
        
        val_108 = this.丞万业丐丛不七且丞 - val_107;
        goto label_170;
        label_162:
        if(isMaster != false)
        {
                if(( - 1) >= 3)
        {
                if(this.丞万业丐丛不七且丞 == 0f)
        {
            goto label_173;
        }
        
        }
        
        }
        
        if(this.丛丕东业不世丞丄丛() == false)
        {
            goto label_174;
        }
        
        label_173:
        this.丞万业丐丛不七且丞 = 5f;
        goto label_211;
        label_166:
        val_84 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_84 == 0)
        {
            goto label_211;
        }
        
        val_84 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1000];
        val_84 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.siegeUI;
        val_109 = 1;
        val_110 = 0;
        val_111 = 0;
        goto label_181;
        label_174:
        val_84 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_84 == 0)
        {
            goto label_211;
        }
        
        val_84 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1000];
        val_84 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.siegeUI;
        val_110 = 0;
        val_111 = 0;
        val_109 = 0;
        label_181:
        丝丂丕东专世丅丝丁(丛丅丘一丏丙且丌上:  false, 三丐东三丒丛丗丅三:  0, 丟丗丕不丏与丂丂丌:  false);
        goto label_211;
        label_169:
        val_108 = 0.01f;
        val_105 = 0;
        label_170:
        this.丞万业丐丛不七且丞 = UnityEngine.Mathf.Max(a:  val_108, b:  this.丞万业丐丛不七且丞 - val_107);
        if(this.isMaster != false)
        {
                object[] val_57 = new object[1];
            val_14 = this.丞万业丐丛不七且丞;
            val_77 = val_14;
            val_57[0] = val_77;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  149, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_57);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_107 = this.丞万业丐丛不七且丞;
            丝丂丕东专世丅丝丁(丛丅丘一丏丙且丌上:  true, 三丐东三丒丛丗丅三:  UnityEngine.Mathf.Max(a:  0, b:  UnityEngine.Mathf.FloorToInt(f:  val_107)), 丟丗丕不丏与丂丂丌:  false);
        }
        
        val_84 = this.team1;
        val_112 = val_84;
        if(val_112.Count < 1)
        {
            goto label_204;
        }
        
        val_84 = this.team2;
        val_112 = val_84;
        int val_62 = val_112.Count;
        if(val_62 > 0)
        {
            goto label_208;
        }
        
        label_204:
        if(( == 5) || (this.丆世丞丞东世丅丗丁 == true))
        {
            goto label_208;
        }
        
        this.丞万业丐丛不七且丞 = 0f;
        goto label_211;
        label_208:
        if(this.丞万业丐丛不七且丞 <= 0f)
        {
                if(val_62.isMaster != false)
        {
                this.丞万业丐丛不七且丞 = 0f;
            this.世且丏万丄三丞丆不();
        }
        
        }
        
        label_211:
        if( != 7)
        {
                return;
        }
        
        this.matchStarted = false;
        this.丏丅丅丘上丆业丂丟();
    }
    private void 丗丅丕东丏七丆丕丁()
    {
        this.丞万业丐丛不七且丞 = 5f;
    }
    private void 丛丞丗且丟丈丛丐丌()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        int val_1 = UnityEngine.Random.Range(min:  0, max:  丏专丝丈丘东丞丟丟.丌业丌与丏一不万七.Length);
        System.String[] val_2 = 丏专丝丈丘东丞丟丟.丌业丌与丏一不万七 + (((long)(int)(val_1)) << 3);
        ExitGames.Client.Photon.Hashtable val_3 = new ExitGames.Client.Photon.Hashtable();
        val_6 = null;
        val_6 = null;
        val_3.set_Item(key:  GameConnect.丁丝丕上下丗丕丞东, value:  System.String.alignConst);
        val_3.set_Item(key:  GameConnect.丏丄丑与与万丛万丒, value:  (丏专丝丈丘东丞丟丟.丌业丌与丏一不万七 + ((long)(int)(val_1)) << 3) + 32);
        val_3.set_Item(key:  GameConnect.丞丂业丝七世专丈不, value:  System.String.alignConst);
        val_3.set_Item(key:  GameConnect.丟东丙且世七一丕丙, value:  System.String.alignConst);
        val_3.set_Item(key:  GameConnect.丟不下业世与丈下三, value:  System.String.alignConst);
        val_3.set_Item(key:  GameConnect.丆丙丘下丑丂丄丂专, value:  (丏专丝丈丘东丞丟丟.丌业丌与丏一不万七 + ((long)(int)(val_1)) << 3) + 32);
        val_3.set_Item(key:  GameConnect.业世上东专丁业丕三, value:  System.String.alignConst);
        val_3.set_Item(key:  GameConnect.丏丁丅丏一世世丙丏, value:  System.String.alignConst);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_3, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 七丘上丐东丂专丐丙(int 七一丞丈万丛下丘上)
    {
        int val_25;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        string val_79;
        var val_80;
        var val_81;
        string val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        string val_89;
        var val_90;
        string val_91;
        string val_92;
        object val_93;
        System.Collections.Generic.List<T> val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        var val_100;
        string val_101;
        var val_102;
        object val_103;
        var val_104;
        object val_105;
        object val_106;
        object val_107;
        int val_108;
        var val_109;
        var val_110;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        val_74 = 1152921505189646336;
        val_75 = 0;
        goto label_1;
        label_38:
        val_76 = null;
        val_76 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() != 七一丞丈万丛下丘上)
        {
            goto label_33;
        }
        
        val_77 = null;
        val_77 = null;
        NetworkStartTable val_4 = Item[0];
        与丅丕丈丘东丝世丟 val_5 = val_4.丄丈丑丐丆丞丘与丗.owner;
        if(val_5 == null)
        {
            goto label_33;
        }
        
        val_78 = null;
        val_78 = null;
        val_79 = GameConnect.丗丑上三一丌丟业丄;
        if((val_5.丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_79)) == false)
        {
            goto label_33;
        }
        
        val_80 = null;
        val_80 = null;
        val_79 = GameConnect.丛一丕丁世丅丆与丆;
        if((val_5.丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_79)) == false)
        {
            goto label_33;
        }
        
        ExitGames.Client.Photon.Hashtable val_74 = val_5.丑丗三丛丛丆丟丌丆();
        val_81 = null;
        val_81 = null;
        object val_11 = val_74.Item[GameConnect.丛一丕丁世丅丆与丆];
        if(val_11 != null)
        {
                val_74 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_82 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_82)) == true)
        {
            goto label_33;
        }
        
        if(val_1 == null)
        {
            goto label_29;
        }
        
        if((val_1.ContainsKey(key:  val_82)) == false)
        {
            goto label_32;
        }
        
        val_83 = val_1.Item[val_82];
        goto label_31;
        label_29:
        if((val_1.ContainsKey(key:  val_82)) == false)
        {
            goto label_32;
        }
        
        val_83 = val_1.Item[val_82];
        label_31:
        val_1.set_Item(key:  val_82, value:  val_83 + 1);
        goto label_33;
        label_32:
        val_1.Add(key:  val_82, value:  1);
        label_33:
        val_75 = 1;
        label_1:
        val_84 = null;
        val_84 = null;
        if(val_75 < Count)
        {
            goto label_38;
        }
        
        System.Collections.Generic.List<System.String> val_19 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.String> val_20 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.String> val_21 = new System.Collections.Generic.List<System.String>();
        Dictionary.Enumerator<TKey, TValue> val_22 = val_1.GetEnumerator();
        label_43:
        val_85 = 0;
        if((816817392 & 1) == 0)
        {
            goto label_40;
        }
        
        ConfiguredValueTaskAwaiter val_26 = val_25.GetAwaiter();
        int val_27 = UnityEngine.Mathf.Max(a:  0, b:  816817376);
        goto label_43;
        label_40:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        Dictionary.Enumerator<TKey, TValue> val_28 = val_1.GetEnumerator();
        label_84:
        if((816817392 & 1) == 0)
        {
            goto label_51;
        }
        
        ConfiguredValueTaskAwaiter val_29 = val_25.GetAwaiter();
        if(816817360 != val_85)
        {
            goto label_84;
        }
        
        val_86 = 0;
        goto label_53;
        label_72:
        val_86 = 1;
        label_53:
        与丅丕丈丘东丝世丟[] val_30 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_86 >= val_30.Length)
        {
            goto label_84;
        }
        
        与丅丕丈丘东丝世丟 val_75 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[1];
        if(val_75 == null)
        {
            goto label_72;
        }
        
        val_87 = null;
        val_87 = null;
        if((val_75.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛一丕丁世丅丆与丆)) == false)
        {
            goto label_72;
        }
        
        ExitGames.Client.Photon.Hashtable val_76 = val_75.丑丗三丛丛丆丟丌丆();
        val_88 = null;
        val_88 = null;
        object val_35 = val_76.Item[GameConnect.丛一丕丁世丅丆与丆];
        if(val_35 != null)
        {
                val_76 = (null == null) ? (val_35) : 0;
        }
        else
        {
                val_89 = 0;
        }
        
        if((System.String.op_Equality(a:  val_29._value._obj.丐丏七丌丕丗业且上(), b:  val_89)) == false)
        {
            goto label_72;
        }
        
        ExitGames.Client.Photon.Hashtable val_77 = val_75.丑丗三丛丛丆丟丌丆();
        val_90 = null;
        val_90 = null;
        object val_39 = val_77.Item[GameConnect.与丘三丈丆丁三丆丐];
        if(val_39 != null)
        {
                val_77 = (null == null) ? (val_39) : 0;
        }
        else
        {
                val_91 = 0;
        }
        
        ExitGames.Client.Photon.Hashtable val_78 = val_75.丑丗三丛丛丆丟丌丆();
        object val_41 = val_78.Item[GameConnect.丕与丌丂万一三丘丂];
        if(val_41 != null)
        {
                val_78 = (null == null) ? (val_41) : 0;
        }
        else
        {
                val_92 = 0;
        }
        
        val_19.Add(item:  val_29._value._obj.丐丏七丌丕丗业且上());
        val_21.Add(item:  val_91);
        val_20.Add(item:  val_92);
        goto label_84;
        label_51:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_93 = 1152921505066536960;
        val_94 = val_19;
        if(val_19.Count == 0)
        {
                return;
        }
        
        val_95 = 0;
        goto label_116;
        label_148:
        val_96 = null;
        val_96 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() != 七一丞丈万丛下丘上)
        {
            goto label_137;
        }
        
        val_97 = null;
        val_97 = null;
        NetworkStartTable val_49 = Item[0];
        val_79 = val_49.丄丈丑丐丆丞丘与丗.owner;
        if(val_79 == null)
        {
            goto label_137;
        }
        
        val_98 = null;
        val_98 = null;
        if((val_79.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丗丑上三一丌丟业丄)) == false)
        {
            goto label_137;
        }
        
        val_99 = null;
        val_99 = null;
        if((val_79.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛一丕丁世丅丆与丆)) == false)
        {
            goto label_137;
        }
        
        val_100 = null;
        ExitGames.Client.Photon.Hashtable val_79 = val_79.丑丗三丛丛丆丟丌丆();
        val_100 = null;
        object val_56 = val_79.Item[GameConnect.丛一丕丁世丅丆与丆];
        if(val_56 != null)
        {
                val_79 = (null == null) ? (val_56) : 0;
        }
        else
        {
                val_101 = 0;
        }
        
        if((System.String.op_Equality(a:  val_19.Item[UnityEngine.Random.Range(min:  0, max:  val_19.Count)], b:  val_101)) == true)
        {
            goto label_143;
        }
        
        label_137:
        val_95 = 1;
        label_116:
        val_102 = null;
        val_102 = null;
        if(val_95 < Count)
        {
            goto label_148;
        }
        
        label_198:
        val_74 = mem[1152921539783414936];
        object[] val_59 = new object[3];
        val_25 = 七一丞丈万丛下丘上;
        val_59[0] = val_25;
        val_85 = 1152921516934571616;
        if(val_21.Count < 2)
        {
            goto label_154;
        }
        
        val_93 = val_21.ToArray();
        if((val_93 == null) || (val_93 != null))
        {
            goto label_158;
        }
        
        goto label_158;
        label_154:
        val_93 = 0;
        label_158:
        val_59[1] = val_93;
        if(val_20.Count < 2)
        {
            goto label_161;
        }
        
        val_103 = val_20.ToArray();
        if((val_103 == null) || (val_103 != null))
        {
            goto label_165;
        }
        
        goto label_165;
        label_161:
        val_103 = 0;
        label_165:
        val_59[2] = val_103;
        val_74.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  20, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_59);
        return;
        label_143:
        val_104 = null;
        val_104 = null;
        string val_80 = GameConnect.丗丑上三一丌丟业丄;
        object val_65 = val_79.丑丗三丛丛丆丟丌丆().Item[val_80];
        if(val_65 != null)
        {
                val_80 = (null == null) ? (val_65) : 0;
        }
        else
        {
                val_105 = 0;
        }
        
        string val_81 = GameConnect.与丘三丈丆丁三丆丐;
        object val_67 = val_79.丑丗三丛丛丆丟丌丆().Item[val_81];
        if(val_67 != null)
        {
                val_81 = (null == null) ? (val_67) : 0;
        }
        else
        {
                val_106 = 0;
        }
        
        ExitGames.Client.Photon.Hashtable val_82 = val_79.丑丗三丛丛丆丟丌丆();
        object val_69 = val_82.Item[GameConnect.丕与丌丂万一三丘丂];
        if(val_69 != null)
        {
                val_82 = (null == null) ? (val_69) : 0;
        }
        else
        {
                val_107 = 0;
        }
        
        ExitGames.Client.Photon.Hashtable val_70 = new ExitGames.Client.Photon.Hashtable();
        val_108 = 七一丞丈万丛下丘上;
        if(val_108 == 1)
        {
                val_109 = null;
            val_109 = null;
            val_70.set_Item(key:  GameConnect.丁丝丕上下丗丕丞东, value:  val_101);
            val_70.set_Item(key:  GameConnect.丏丄丑与与万丛万丒, value:  val_105);
            val_70.set_Item(key:  GameConnect.丞丂业丝七世专丈不, value:  val_107);
            val_70.set_Item(key:  GameConnect.丟东丙且世七一丕丙, value:  val_106);
            val_108 = 七一丞丈万丛下丘上;
        }
        
        if(val_108 == 2)
        {
                val_110 = null;
            val_110 = null;
            val_70.set_Item(key:  GameConnect.丟不下业世与丈下三, value:  val_101);
            val_70.set_Item(key:  GameConnect.丆丙丘下丑丂丄丂专, value:  val_105);
            val_70.set_Item(key:  GameConnect.业世上东专丁业丕三, value:  val_107);
            val_70.set_Item(key:  GameConnect.丏丁丅丏一世世丙丏, value:  val_106);
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_70, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        UnityEngine.Debug.LogError(message:  "Set clan fort " + val_106 + " for team " + 七一丞丈万丛下丘上.ToString());
        goto label_198;
    }
    private void LateUpdate()
    {
        this.东丁专丐三业上业且();
        this.且专丆下万与上丁业();
    }
    private bool 不丙一丘丐丌丗丆与()
    {
        var val_13;
        var val_14;
        var val_15;
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_13 = null;
        val_13 = null;
        if(丘丑丅三丆丑丌且丝() != 1)
        {
            goto label_5;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = null;
        val_16 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丁丝丕上下丗丕丞东];
        val_15 = null;
        if(((Equals(value:  val_16)) == true) || ((val_16.Equals(value:  "-1")) == true))
        {
            goto label_38;
        }
        
        label_5:
        val_17 = null;
        val_17 = null;
        val_16 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_16 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(丘丑丅三丆丑丌且丝() != 2)
        {
            goto label_40;
        }
        
        val_18 = null;
        val_18 = null;
        val_19 = null;
        val_16 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟不下业世与丈下三];
        val_19 = null;
        if((Equals(value:  val_16)) != true)
        {
                if((val_16.Equals(value:  "-1")) == false)
        {
            goto label_40;
        }
        
        }
        
        label_38:
        val_20 = 1;
        return (bool)val_20;
        label_40:
        val_20 = 0;
        return (bool)val_20;
    }
    private string 丑不上业且上丒丞世()
    {
        var val_9;
        NetworkStartTable val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = null;
        val_9 = null;
        if(丘丑丅三丆丑丌且丝() != 1)
        {
            goto label_5;
        }
        
        val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_11 = null;
        val_11 = null;
        if(val_10 != null)
        {
            goto label_24;
        }
        
        label_25:
        label_24:
        object val_4 = val_10.Item[GameConnect.丟东丙且世七一丕丙];
        if(val_4 == null)
        {
                return (string)val_12;
        }
        
        var val_5 = (null == null) ? (val_4) : 0;
        return (string)val_12;
        label_5:
        val_13 = null;
        val_13 = null;
        val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(丘丑丅三丆丑丌且丝() != 2)
        {
            goto label_18;
        }
        
        val_14 = null;
        val_14 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆() != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_18:
        val_12 = "";
        return (string)val_12;
    }
    public void ShowSiegeStartEvent()
    {
        string val_3;
        if(this.inAttackTeam != false)
        {
                val_3 = "Key_4532";
        }
        else
        {
                val_3 = "Key_4641";
        }
        
        this.ShowSiegeEvent(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3), 专业万丗丐丙丕丕下:  false);
    }
    public void ShowTimeEndSiegeEvent(int 丌七丒世丄上丞丞丁)
    {
        string val_8;
        var val_9;
        string val_10;
        if(this.inAttackTeam != false)
        {
                val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0568");
            val_9 = 1152921504622075904;
            val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4787");
        }
        else
        {
                val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0568");
            val_9 = 1152921504622075904;
            val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4788");
        }
        
        this.ShowSiegeEvent(丕丗丘丑丛与丑业丒:  val_8 + "\n" + System.String.Format(format:  val_10, arg0:  丌七丒世丄上丞丞丁)(System.String.Format(format:  val_10, arg0:  丌七丒世丄上丞丞丁)), 专业万丗丐丙丕丕下:  true);
    }
    public void ShowBrokenGateSiegeEvent(float 丂三丟丂丈丐丆丗丟)
    {
        string val_9;
        if(this.inAttackTeam != false)
        {
                string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4640");
            val_9 = "Key_4798";
        }
        else
        {
                val_9 = "Key_4799";
        }
        
        this.ShowSiegeEvent(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4644")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4644")) + "\n" + System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9), arg0:  Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  丂三丟丂丈丐丆丗丟))(System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9), arg0:  Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  丂三丟丂丈丐丆丗丟))), 专业万丗丐丙丕丕下:  true);
    }
    public void ShowSiegeEvent(string 丕丗丘丑丛与丑业丒, bool 专业万丗丐丙丕丕下)
    {
        var val_4;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(专业万丗丐丙丕丕下 != false)
        {
                var val_2 = (this.roomStatus == 4) ? 1 : 0;
        }
        else
        {
                val_4 = 0;
        }
        
        丘丆丈丝万不丕丘丐(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丂三丟丂丈丐丆丗丟:  (val_4 != 0) ? 3f : 2f, 丛丌万丐世丞丗丟丑:  false);
    }
    private void 东丁专丐三业上业且()
    {
        null = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
                return;
        }
        
        if(TramController.丄丘七三上丕世丞业.tramObject == 0)
        {
                return;
        }
        
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        var val_6 = (this.inAttackTeam != true) ? this.丂丅丄丈专东丞丛丌 : this.丘丏丞丛不丆万丙丕;
        UnityEngine.Texture[] val_7 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((val_5 != true ? this.丂丅丄丈专东丞丛丌 : this.丘丏丞丛不丆万丙丕) << 3);
        this.丕业丈丄与一上丞丅().丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (val_5 != true ? this.丂丅丄丈专东丞丛丌 : this.丘丏丞丛不丆万丙丕) << 3) + 32]);
        var val_10 = (this.inAttackTeam != true) ? this.不丌丙丌丒丙三丕丙 : this.丝丆丌丁丏丙业上丒;
        UnityEngine.Texture[] val_11 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((val_9 != true ? this.不丌丙丌丒丙三丕丙 : this.丝丆丌丁丏丙业上丒) << 3);
        this.世丞业丁业丆丈丘世().丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (val_9 != true ? this.不丌丙丌丒丙三丕丙 : this.丝丆丌丁丏丙业上丒) << 3) + 32]);
    }
    private bool 丛丕东业不世丞丄丛()
    {
        System.Collections.Generic.List<NetworkStartTable> val_4;
        var val_5;
        val_4 = this;
        if(this.team2.Count >= 5)
        {
                val_4 = this.team1;
            var val_3 = (val_4.Count > 4) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    private void 世且丏万丄三丞丆不()
    {
        object val_5;
        var val_6;
        val_5 = this;
        if(this.isMaster == false)
        {
                return;
        }
        
        this.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  (this.roomStatus == 5) ? 6 : 4);
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        object[] val_4 = new object[1];
        val_5 = this.matchTime;
        val_4[0] = val_5;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  142, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        PhotonView val_5;
        object val_6;
        val_5 = this.丄丈丑丐丆丞丘与丗;
        bool val_1 = UnityEngine.Object.op_Equality(x:  val_5, y:  0);
        if(val_1 == true)
        {
                return;
        }
        
        if(val_1.isMaster != false)
        {
                val_5 = this.丄丈丑丐丆丞丘与丗;
            object[] val_3 = new object[1];
            val_6 = this.丞万业丐丛不七且丞;
            val_3[0] = val_6;
            val_5.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  149, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_3);
        }
        
        if(this.team1Progress <= 0f)
        {
                if(this.team2Progress <= 0f)
        {
                return;
        }
        
        }
        
        val_5 = this.丄丈丑丐丆丞丘与丗;
        object[] val_4 = new object[6];
        val_4[0] = this.team1Progress;
        val_4[1] = this.team2Progress;
        val_4[2] = this.丂丈不丗丝丙丈与不;
        val_4[3] = this.丟东业专下丄丐丟丁;
        val_6 = this.专专丏三丙丁丛丁世;
        val_4[4] = val_6;
        val_4[5] = this.丟东丁世丗且丂丟下;
        val_5.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  150, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_4);
    }
    public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        bool val_6;
        int val_7;
        int val_9;
        object val_10;
        bool val_11;
        System.String[] val_12;
        byte val_1 = 丗与一丛丐丞丘丌丞 & 255;
        if(val_1 > 150)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if((val_1 - 142) > 8)
        {
            goto label_2;
        }
        
        var val_6 = 106014640;
        val_6 = (106014640 + (((丗与一丛丐丞丘丌丞 & 255) - 142)) << 2) + val_6;
        goto (106014640 + (((丗与一丛丐丞丘丌丞 & 255) - 142)) << 2 + 106014640);
        label_1:
        if(val_1 == 163)
        {
            goto label_6;
        }
        
        if(val_1 != 164)
        {
            goto label_7;
        }
        
        val_7 = 专丒丌丆下丐丞丟丞.Length;
        if(val_7 == 0)
        {
                val_7 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_8 = 专丒丌丆下丐丞丟丞[0];
        object val_9 = 专丒丌丆下丐丞丟丞[1];
        this.丏与丒不丌与三丏丑(丛下丐丞不专丞三丈:  3.782474E-38f, 丝上七万上丄专丟丘:  21884928);
        goto label_49;
        label_6:
        val_6 = true;
        this.丙丟丕下丒上丏丝且 = 3f;
        this.专丂业东丈七专丂且 = val_6;
        专丒丌丆下丐丞丟丞[0].丘专丗丗丕丄丗丐丆();
        return (bool)val_6;
        label_7:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        if(val_1 != 20)
        {
                return (bool)val_6;
        }
        
        val_9 = 专丒丌丆下丐丞丟丞.Length;
        if(val_9 == 0)
        {
                val_9 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_11 = 专丒丌丆下丐丞丟丞[0];
        if(val_9 <= 1)
        {
                val_9 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_10 = 专丒丌丆下丐丞丟丞[1];
        val_11 = 1152921505724518352;
        if(val_10 == null)
        {
            goto label_21;
        }
        
        val_12 = val_10;
        if(val_12 != null)
        {
            goto label_22;
        }
        
        label_21:
        val_12 = 0;
        label_22:
        if(专丒丌丆下丐丞丟丞[2] != null)
        {
                val_10 = null;
        }
        
        this.丐丛丏丒下世万不上(七一丞丈万丛下丘上:  21884928, 丐丆业与不丆丅一丞:  val_12, 丗与与三且一世世三:  null);
        label_49:
        val_6 = 1;
        return (bool)val_6;
    }
    private void 丐丛丏丒下世万不上(int 七一丞丈万丛下丘上, string[] 丐丆业与不丆丅一丞, string[] 丗与与三且一世世三)
    {
        System.String[] val_3;
        var val_4;
        var val_5;
        val_3 = 丐丆业与不丆丅一丞;
        if(七一丞丈万丛下丘上 != 1)
        {
            goto label_1;
        }
        
        if(this.fort1Animation != null)
        {
                return;
        }
        
        goto label_4;
        label_1:
        if(七一丞丈万丛下丘上 != 2)
        {
            goto label_4;
        }
        
        if(this.fort2Animation != null)
        {
                return;
        }
        
        val_4 = 1;
        if(val_3 != null)
        {
            goto label_6;
        }
        
        goto label_10;
        label_4:
        val_4 = 0;
        if(val_3 == null)
        {
            goto label_10;
        }
        
        label_6:
        SiegeController.与丂东专丏且丆丝丗 val_1 = new SiegeController.与丂东专丏且丆丝丗(丆万下上七丄上与丙:  val_3);
        if(七一丞丈万丛下丘上 == 1)
        {
                this.fort1Animation = val_1;
        }
        
        if(val_4 != 0)
        {
                this.fort2Animation = val_1;
        }
        
        label_10:
        val_5 = null;
        val_5 = null;
        val_3 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_3 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(丘丑丅三丆丑丌且丝() != 七一丞丈万丛下丘上)
        {
                return;
        }
        
        this.myFortReady = true;
    }
    private void 且专丆下万与上丁业()
    {
        var val_9;
        SiegeTeamsController val_10;
        var val_11;
        var val_12;
        var val_13;
        if(this.丞万业丐丛不七且丞 > 0f)
        {
                if(this.fort1Animation != null)
        {
                if(this.fort1Animation.丄上且东丙丘丙丈丕 == false)
        {
            goto label_3;
        }
        
        }
        
            val_9 = null;
            val_9 = null;
            val_10 = this.teamsController;
            this.七业与东丏丈丙丘丕(下丝丘丁专丐丅丛丝:  (丘丑丅三丆丑丌且丝() == 1) ? this.teamsController.blueTeamPoints : this.teamsController.redTeamPoints, 七一丞丈万丛下丘上:  1);
        }
        else
        {
                if(this.fort1Animation != null)
        {
                label_3:
            val_11 = null;
            val_11 = null;
            val_10 = 丘丑丅三丆丑丌且丝();
            this.丏丒丒与丛丂丘丙下(丐丐七专三且世三七:  this.fort1Animation, 下丝丘丁专丐丅丛丝:  (val_10 == 1) ? this.teamsController.blueTeamPoints : this.teamsController.redTeamPoints, 七一丞丈万丛下丘上:  0);
        }
        
        }
        
        if(this.丞万业丐丛不七且丞 > 0f)
        {
                if(this.fort2Animation != null)
        {
                if(this.fort2Animation.丄上且东丙丘丙丈丕 == false)
        {
            goto label_18;
        }
        
        }
        
            val_12 = null;
            val_12 = null;
            this.七业与东丏丈丙丘丕(下丝丘丁专丐丅丛丝:  (丘丑丅三丆丑丌且丝() == 1) ? this.teamsController.redTeamPoints : this.teamsController.blueTeamPoints, 七一丞丈万丛下丘上:  2);
            return;
        }
        
        if(this.fort2Animation == null)
        {
                return;
        }
        
        label_18:
        val_13 = null;
        val_13 = null;
        this.丏丒丒与丛丂丘丙下(丐丐七专三且世三七:  this.fort2Animation, 下丝丘丁专丐丅丛丝:  (丘丑丅三丆丑丌且丝() == 1) ? this.teamsController.redTeamPoints : this.teamsController.blueTeamPoints, 七一丞丈万丛下丘上:  0);
    }
    private void 七业与东丏丈丙丘丕(SiegeCharacterPoint[] 下丝丘丁专丐丅丛丝, int 七一丞丈万丛下丘上)
    {
        UnityEngine.GameObject val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        string val_20;
        var val_21;
        var val_22;
        val_16 = 0;
        goto label_1;
        label_6:
        SiegeCharacterPoint val_16 = 下丝丘丁专丐丅丛丝[0];
        val_15 = 下丝丘丁专丐丅丛丝[0x0][0].chooseIndication;
        val_15.SetActive(value:  false);
        val_16 = 1;
        label_1:
        if(val_16 < 下丝丘丁专丐丅丛丝.Length)
        {
            goto label_6;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(七一丞丈万丛下丘上 != 1)
        {
            goto label_10;
        }
        
        val_17 = 1152921505066536960;
        val_18 = null;
        val_18 = null;
        val_15 = GameConnect.丁丝丕上下丗丕丞东;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_15)) == false)
        {
            goto label_32;
        }
        
        ExitGames.Client.Photon.Hashtable val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_19 = null;
        val_19 = null;
        val_15 = GameConnect.丁丝丕上下丗丕丞东;
        if(val_6 != null)
        {
            goto label_38;
        }
        
        label_39:
        label_38:
        val_20 = val_6.Item[val_15];
        goto label_25;
        label_10:
        val_17 = 1152921505066536960;
        val_21 = null;
        val_21 = null;
        val_15 = GameConnect.丟不下业世与丈下三;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_15)) == false)
        {
            goto label_32;
        }
        
        val_22 = null;
        val_22 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆() != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_32:
        val_20 = "-1";
        label_25:
        if(下丝丘丁专丐丅丛丝.Length < 1)
        {
                return;
        }
        
        do
        {
            val_17 = 0;
            SiegeCharacterPoint val_17 = 下丝丘丁专丐丅丛丝[val_17];
            val_15 = 下丝丘丁专丐丅丛丝[0x0][0].table;
            if(val_15 != 0)
        {
                val_15 = mem[下丝丘丁专丐丅丛丝[0x0] + 32 + 104];
            val_15 = 下丝丘丁专丐丅丛丝[0x0] + 32 + 104;
            if((System.String.op_Equality(a:  下丝丘丁专丐丅丛丝[0x0] + 32 + 104 + 128, b:  val_20)) != false)
        {
                val_15 = mem[下丝丘丁专丐丅丛丝[0x0] + 32 + 112];
            val_15 = 下丝丘丁专丐丅丛丝[0x0] + 32 + 112;
            val_15.SetActive(value:  true);
        }
        
        }
        
        }
        while((val_17 + 1) < 下丝丘丁专丐丅丛丝.Length);
    
    }
    private void 丏丒丒与丛丂丘丙下(SiegeController.与丂东专丏且丆丝丗 丐丐七专三且世三七, SiegeCharacterPoint[] 下丝丘丁专丐丅丛丝, int 七一丞丈万丛下丘上)
    {
        var val_9;
        System.Collections.Generic.List<SiegeCharacterPoint> val_10;
        丐丐七专三且世三七.且丑七专与且丈业丑();
        this.丙丛丄万东丕丄七丙.Clear();
        val_9 = 0;
        goto label_3;
        label_8:
        SiegeCharacterPoint val_10 = 下丝丘丁专丐丅丛丝[0];
        下丝丘丁专丐丅丛丝[0x0][0].chooseIndication.SetActive(value:  false);
        val_9 = 1;
        label_3:
        if(val_9 < 下丝丘丁专丐丅丛丝.Length)
        {
            goto label_8;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        bool val_11 = 丐丐七专三且世三七.丄上且东丙丘丙丈丕;
        val_11 = val_11 + 7;
        var val_12 = ~val_11;
        val_12 = val_12 & 7;
        if(val_12 != 0)
        {
                return;
        }
        
        if(下丝丘丁专丐丅丛丝.Length >= 1)
        {
                do
        {
            SiegeCharacterPoint val_13 = 下丝丘丁专丐丅丛丝[0];
            if(下丝丘丁专丐丅丛丝[0x0][0].table != 0)
        {
                if((丐丐七专三且世三七.丌丆丞丘丐丁且丂且(不且上一上丐三万丛:  下丝丘丁专丐丅丛丝[0x0] + 32 + 104)) != false)
        {
                this.丙丛丄万东丕丄七丙.Add(item:  下丝丘丁专丐丅丛丝[0x0] + 32);
        }
        
        }
        
        }
        while((0 + 1) < 下丝丘丁专丐丅丛丝.Length);
        
        }
        
        if(this.丙丛丄万东丕丄七丙.Count < 1)
        {
                return;
        }
        
        val_10 = this.丙丛丄万东丕丄七丙;
        if(丐丐七专三且世三七 == null)
        {
                val_10 = this.丙丛丄万东丕丄七丙;
        }
        
        int val_6 = val_10.Count;
        SiegeCharacterPoint val_9 = this.丙丛丄万东丕丄七丙.Item[丐丐七专三且世三七.不丛三三专丛一万丝 - ((丐丐七专三且世三七.不丛三三专丛一万丝 / val_6) * val_6)];
        val_9.chooseIndication.SetActive(value:  true);
        丐丐七专三且世三七.专万丏丛丝丝丝丙丑(不且上一上丐三万丛:  val_9.table);
    }
    private void 丏与丒不丌与三丏丑(float 丛下丐丞不专丞三丈, int 丝上七万上丄专丟丘)
    {
        if(丝上七万上丄专丟丘 != 1)
        {
                this.ShowTimeEndSiegeEvent(丌七丒世丄上丞丞丁:  丝上七万上丄专丟丘);
        }
        
        if(丛下丐丞不专丞三丈 == (-1f))
        {
                return;
        }
        
        this.ShowBrokenGateSiegeEvent(丂三丟丂丈丐丆丗丟:  丛下丐丞不专丞三丈);
    }
    private void 丕丒丙丄丈丆丄丌丌(bool 丘丌世万丁丐且专丘)
    {
        this.丙丟丕下丒上丏丝且 = 3f;
        this.专丂业东丈七专丂且 = true;
        this.丘专丗丗丕丄丗丐丆();
    }
    private void 丅丄丛世且丌丂下与(float 丛丙专一七上下三丐)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        UnityEngine.Object val_14;
        this.丞万业丐丛不七且丞 = 0f;
        this.丙丟丕下丒上丏丝且 = 0f;
        this.丆万丑丆与丗丟丟丝 = false;
        this.专丂业东丈七专丂且 = false;
        val_9 = 0;
        goto label_1;
        label_11:
        val_10 = null;
        val_10 = null;
        NetworkStartTable val_1 = Item[0];
        val_9 = 1;
        val_1.丄世一丞万一丁丙丁 = false;
        label_1:
        val_11 = null;
        val_11 = null;
        int val_2 = Count;
        if(val_9 < val_2)
        {
            goto label_11;
        }
        
        this.roomStatus = val_2.roomStatusGlobal;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                Close();
        }
        
        val_12 = null;
        val_12 = null;
        if(FortEquipmentController.丝丘丞不丂丆不丘且 != 0)
        {
                this.fortInit = true;
            val_13 = null;
            val_13 = null;
            FortEquipmentController.丝丘丞不丂丆不丘且.ResetForNewMatch(且与丘丄丟丄丟丏丝:  (this.roomStatus == 6) ? 1 : 0);
        }
        
        val_14 = TramController.丄丘七三上丕世丞业;
        if(val_14 != 0)
        {
                val_14 = TramController.丄丘七三上丕世丞业;
            val_14.ResetForNewMatch();
        }
        
        if((val_14.isMaster != false) && (this.roomStatus == 4))
        {
                this.丂下丅专不与丌丅丈();
        }
        
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
        
        this.丞万业丐丛不七且丞 = 丗丞丁丟丄丆上丒下;
    }
    private void 丟丛专七不七丆三万()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        if(this.playerStarted == true)
        {
                return;
        }
        
        this.playerStarted = true;
        val_4 = null;
        val_4 = null;
        if(丘丑丅三丆丑丌且丝() <= 0)
        {
                val_5 = null;
            val_5 = null;
            丐丛丕且东下上丐业();
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                val_7 = null;
            val_7 = null;
            GameController.onlineMode.丟丛专七不七丆三万();
        }
        
        val_8 = null;
        val_8 = null;
        this.mySiegeTeam = 丘丑丅三丆丑丌且丝();
    }
    private void 丘专丗丗丕丄丗丐丆()
    {
        var val_3;
        var val_4;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                InGameGUI.丙丞专丌丁丞与不丐.SetInterfaceVisible(下下东且万业丞丅丒:  false, 丅丞七丟丘丆丟丘丞:  false);
        }
        
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        丒丈丛丘丄七三丒丆();
    }
    private void 丞丟丂丅丒丝丘丌且(SiegeController.丛丏丂丄上专且万业 三丁丂丒不丘丄丂三)
    {
        丛丏丂丄上专且万业 val_6 = 三丁丂丒不丘丄丂三;
        this.roomStatusGlobal = val_6;
        丛丏丂丄上专且万业 val_2 = val_6 - 5;
        val_6 = ((val_6 != 4) ? 1 : 0) & ((val_2 > 2) ? 1 : 0);
        UnityEngine.Debug.Log(message:  (val_2 == 3) ? "Room closed!" : "Room opened!");
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙专丅业东业东丟与(丙业与丙丗丝不丈东:  val_6);
    }
    public void CheackActualsForts()
    {
    
    }
    private void 丂下丅专不与丌丅丈()
    {
        var val_13;
        var val_14;
        string val_15;
        val_13 = null;
        val_13 = null;
        bool val_4 = System.String.op_Inequality(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丁丝丕上下丗丕丞东], b:  "-1");
        if(val_4 != false)
        {
                Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Room Filling Clan", 下下丏一丙不丘丌丞:  val_4.丈丝丁丑丟丐丈丟万(七一丞丈万丛下丘上:  1).ToString());
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟不下业世与丈下三];
        bool val_10 = System.String.op_Inequality(a:  val_15, b:  "-1");
        if(val_10 == false)
        {
                return;
        }
        
        val_15 = val_10.丈丝丁丑丟丐丈丟万(七一丞丈万丛下丘上:  2).ToString();
        Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Room Filling Clan", 下下丏一丙不丘丌丞:  val_15);
    }
    private void 三丝且上丁丘业不丁(int 丕丗丞丞丑丘丛丂且)
    {
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_17 = 丕丗丞丞丑丘丛丂且;
        val_18 = null;
        val_18 = null;
        if((System.String.op_Inequality(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丁丝丕上下丗丕丞东], b:  "-1")) != false)
        {
                val_19 = null;
            val_19 = null;
            Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Fort Filling", 下下丏一丙不丘丌丞:  (val_17 == 1) ? "Win_" : "Lose_"((val_17 == 1) ? "Win_" : "Lose_") + FortEquipmentController.丝丘丞不丂丆不丘且.GetItemsConfigForFortFillingAnalytics(七一丞丈万丛下丘上:  1).ToString()(FortEquipmentController.丝丘丞不丂丆不丘且.GetItemsConfigForFortFillingAnalytics(七一丞丈万丛下丘上:  1).ToString()));
        }
        
        val_20 = null;
        val_20 = null;
        if((System.String.op_Inequality(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟不下业世与丈下三], b:  "-1")) == false)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        val_17 = (val_17 == 2) ? "Win_" : "Lose_"((val_17 == 2) ? "Win_" : "Lose_") + FortEquipmentController.丝丘丞不丂丆不丘且.GetItemsConfigForFortFillingAnalytics(七一丞丈万丛下丘上:  2).ToString()(FortEquipmentController.丝丘丞不丂丆不丘且.GetItemsConfigForFortFillingAnalytics(七一丞丈万丛下丘上:  2).ToString());
        Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Fort Filling", 下下丏一丙不丘丌丞:  val_17);
    }
    private void 丄丗七世丂丟一万丆(int 丕丗丞丞丑丘丛丂且)
    {
        string val_7;
        string val_8;
        string val_9;
        val_8 = 丕丗丞丞丑丘丛丂且;
        if(val_8 < 1)
        {
            goto label_1;
        }
        
        val_9 = this.GetAnalyticsEndReasonLabel();
        goto label_2;
        label_1:
        if(val_8 == 0)
        {
            goto label_3;
        }
        
        val_9 = "";
        label_2:
        if((System.String.IsNullOrEmpty(value:  val_9)) == false)
        {
            goto label_4;
        }
        
        label_3:
        Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Match Results", 下下丏一丙不丘丌丞:  "Draw");
        return;
        label_4:
        val_7 = (val_8 == 1) ? "Win_" : "Lose_"((val_8 == 1) ? "Win_" : "Lose_") + val_9;
        Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Match Results", 下下丏一丙不丘丌丞:  val_7);
        val_8 = (val_8 == 2) ? "Win_" : "Lose_"((val_8 == 2) ? "Win_" : "Lose_") + val_9;
        Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Match Results", 下下丏一丙不丘丌丞:  val_8);
    }
    private int 丈丝丁丑丟丐丈丟万(int 七一丞丈万丛下丘上)
    {
        var val_12;
        var val_13;
        string val_14;
        var val_15;
        string val_16;
        var val_17;
        if(七一丞丈万丛下丘上 < 1)
        {
                return 0;
        }
        
        if(七一丞丈万丛下丘上 != 1)
        {
            goto label_2;
        }
        
        val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_13 = null;
        val_13 = null;
        val_14 = GameConnect.丁丝丕上下丗丕丞东;
        if(val_12 != null)
        {
            goto label_15;
        }
        
        goto label_9;
        label_2:
        val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_15 = null;
        val_15 = null;
        val_14 = GameConnect.丟不下业世与丈下三;
        if(val_12 != null)
        {
            goto label_15;
        }
        
        label_9:
        label_15:
        if(val_12.Item[val_14] == null)
        {
                val_16 = 0;
        }
        
        if((System.String.op_Equality(a:  val_16, b:  "-1")) != false)
        {
                return 0;
        }
        
        val_17 = null;
        val_17 = null;
        List.Enumerator<T> val_7 = GetEnumerator();
        var val_12 = 0;
        goto label_24;
        label_27:
        string val_8 = 0.丐丏七丌丕丗业且上();
        if(val_8.丘丑丅三丆丑丌且丝() == 七一丞丈万丛下丘上)
        {
                val_12 = val_12 + (val_8.Equals(value:  val_16));
        }
        
        label_24:
        if((821762696 & 1) != 0)
        {
            goto label_27;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return 0;
    }
    private void OnDestroy()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void SiegeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    public bool CheckForEndRound()
    {
        var val_1;
        if(this.不丄丟丞丄万不丈丌 <= 0f)
        {
                return true;
        }
        
        val_1 = null;
        val_1 = null;
        if(FortEquipmentController.丝丘丞不丂丆不丘且 != null)
        {
                return FortEquipmentController.丝丘丞不丂丆不丘且.IsGatesBroken();
        }
        
        return FortEquipmentController.丝丘丞不丂丆不丘且.IsGatesBroken();
    }
    private void 丑丘下丒上丐不丗不(float 丞丛丙专丟世专丗与, float 丒与不丒丈丆七东丌, float 丂丈不丗丝丙丈与不, float 丟东业专下丄丐丟丁, bool 专专丏三丙丁丛丁世, bool 丟东丁世丗且丂丟下, int 丘丗三丟丗业丕上丙)
    {
        InGameGUI val_5;
        this.专专丏三丙丁丛丁世 = 专专丏三丙丁丛丁世;
        this.丟东丁世丗且丂丟下 = 丟东丁世丗且丂丟下;
        this.team1Progress = 丞丛丙专丟世专丗与;
        this.丂丈不丗丝丙丈与不 = 丂丈不丗丝丙丈与不;
        this.team2Progress = 丒与不丒丈丆七东丌;
        this.丟东业专下丄丐丟丁 = 丟东业专下丄丐丟丁;
        if(this.丆万丑丆与丗丟丟丝 != false)
        {
                return;
        }
        
        this.playerStarted = false;
        this.丆万丑丆与丗丟丟丝 = true;
        val_5 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_5 != 0)
        {
                val_5 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 672];
            val_5 = InGameGUI.丙丞专丌丁丞与不丐.respawnWindowController;
            Close();
        }
        
        丛丏丂丄上专且万业 val_4 = roomStatusGlobal;
        this.roomStatus = val_4;
        if(val_4 == 7)
        {
                this.丏且丛丛下业专一七(业不丐不丅丐丒世下:  丘丗三丟丗业丕上丙);
            return;
        }
        
        val_4.DestroyMyPlayer();
    }
    private void 上且丈丙丙丆丞丛世(float 丞丛丙专丟世专丗与, float 丒与不丒丈丆七东丌, float 丂丈不丗丝丙丈与不, float 丟东业专下丄丐丟丁, bool 专专丏三丙丁丛丁世, bool 丟东丁世丗且丂丟下)
    {
        this.team1Progress = 丞丛丙专丟世专丗与;
        this.丂丈不丗丝丙丈与不 = 丂丈不丗丝丙丈与不;
        this.team2Progress = 丒与不丒丈丆七东丌;
        this.丟东业专下丄丐丟丁 = 丟东业专下丄丐丟丁;
        this.专专丏三丙丁丛丁世 = 专专丏三丙丁丛丁世;
        this.丟东丁世丗且丂丟下 = 丟东丁世丗且丂丟下;
    }
    public void DestroyMyPlayer()
    {
        null = null;
        丟丙不上丝丂丄丗三();
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ShowStartInterface();
    }
    private void 丛丆专七丛且丈丈万(bool 业丂上世丝一丌丌上 = False)
    {
        var val_12;
        NetworkStartTable val_13;
        丛丏丂丄上专且万业 val_14;
        var val_16;
        var val_17;
        var val_18;
        object val_19;
        丛丏丂丄上专且万业 val_20;
        val_12 = null;
        val_12 = null;
        val_13 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_13 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_13 == 0)
        {
                return;
        }
        
        val_14 = this.roomStatus;
        if(val_14 == 4)
        {
                this.team2Progress = TramController.丄丘七三上丕世丞业.GetCurrentProgress();
            this.丟东业专下丄丐丟丁 = UnityEngine.Mathf.Max(a:  0f, b:  this.不丄丟丞丄万不丈丌);
            val_16 = null;
            val_16 = null;
            val_14 = this.roomStatus;
            this.丟东丁世丗且丂丟下 = FortEquipmentController.丝丘丞不丂丆不丘且.IsGatesBroken();
        }
        
        if(val_14 == 6)
        {
                this.team1Progress = TramController.丄丘七三上丕世丞业.GetCurrentProgress();
            this.丂丈不丗丝丙丈与不 = UnityEngine.Mathf.Max(a:  0f, b:  this.不丄丟丞丄万不丈丌);
            val_17 = null;
            val_17 = null;
            this.专专丏三丙丁丛丁世 = FortEquipmentController.丝丘丞不丂丆不丘且.IsGatesBroken();
        }
        
        if(业丂上世丝一丌丌上 != false)
        {
                this.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  7);
            val_18 = null;
            val_18 = null;
            val_19 = 丘丑丅三丆丑丌且丝();
        }
        else
        {
                if(this.roomStatus <= 6)
        {
                val_20 = mem[106014720 + (this.roomStatus) << 2];
            val_20 = 106014720 + (this.roomStatus) << 2;
        }
        else
        {
                val_20 = 4;
        }
        
            this.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  val_20);
            val_19 = 0;
        }
        
        val_13 = this.丄丈丑丐丆丞丘与丗;
        object[] val_11 = new object[7];
        val_11[0] = this.team1Progress;
        val_11[1] = this.team2Progress;
        val_11[2] = this.丂丈不丗丝丙丈与不;
        val_11[3] = this.丟东业专下丄丐丟丁;
        val_11[4] = this.专专丏三丙丁丛丁世;
        val_11[5] = this.丟东丁世丗且丂丟下;
        val_11[6] = val_19;
        val_13.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  148, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_11);
        this.丑丘下丒上丐不丗不(丞丛丙专丟世专丗与:  this.team1Progress, 丒与不丒丈丆七东丌:  this.team2Progress, 丂丈不丗丝丙丈与不:  this.丂丈不丗丝丙丈与不, 丟东业专下丄丐丟丁:  this.丟东业专下丄丐丟丁, 专专丏三丙丁丛丁世:  this.专专丏三丙丁丛丁世, 丟东丁世丗且丂丟下:  this.丟东丁世丗且丂丟下, 丘丗三丟丗业丕上丙:  0);
    }
    public string GetWinningLabel(int 丕丗丞丞丑丘丛丂且)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return "";
        }
        
        bool val_14 = this.专专丏三丙丁丛丁世;
        var val_2 = (val_14 == true) ? 1 : 0;
        val_2 = val_2 ^ ((this.丟东丁世丗且丂丟下 == true) ? 1 : 0);
        if((val_2 & 1) != 0)
        {
                val_15 = null;
            val_15 = null;
            var val_5 = (丘丑丅三丆丑丌且丝() == 丕丗丞丞丑丘丛丂且) ? "Key_4640" : "Key_4644";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (丘丑丅三丆丑丌且丝() == 丕丗丞丞丑丘丛丂且) ? "Key_4796" : "Key_4797");
        }
        
        val_14 = this.丟东丁世丗且丂丟下 | val_14;
        if(val_14 != false)
        {
                val_17 = null;
            val_17 = null;
            var val_7 = (丘丑丅三丆丑丌且丝() == 丕丗丞丞丑丘丛丂且) ? "Key_4645" : "Key_4646";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (丘丑丅三丆丑丌且丝() == 丕丗丞丞丑丘丛丂且) ? "Key_4796" : "Key_4797");
        }
        
        val_16 = "Key_0571";
        if((UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team1Progress))) == (UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team2Progress))))
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (丘丑丅三丆丑丌且丝() == 丕丗丞丞丑丘丛丂且) ? "Key_4796" : "Key_4797");
        }
        
        val_18 = null;
        val_18 = null;
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (丘丑丅三丆丑丌且丝() == 丕丗丞丞丑丘丛丂且) ? "Key_4796" : "Key_4797");
    }
    public string GetAnalyticsEndReasonLabel()
    {
        var val_10;
        var val_11;
        val_10 = this;
        if((this.丟东丁世丗且丂丟下 | this.专专丏三丙丁丛丁世) != false)
        {
                var val_3 = (this.丟东丁世丗且丂丟下 == true) ? 1 : 0;
            val_3 = ((this.专专丏三丙丁丛丁世 == true) ? 1 : 0) ^ val_3;
            val_11 = mem[val_3 != 0x0 ? "KnockOut" : "Time"];
            val_11 = (val_3 != 0) ? "KnockOut" : "Time";
            return (string)(val_10 != (UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team2Progress)))) ? "Distance" : "";
        }
        
        val_10 = UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team1Progress));
        return (string)(val_10 != (UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team2Progress)))) ? "Distance" : "";
    }
    public int GetWinningTeam()
    {
        var val_10;
        var val_11;
        val_10 = this;
        bool val_10 = this.专专丏三丙丁丛丁世;
        var val_1 = (val_10 == true) ? 1 : 0;
        val_1 = val_1 ^ ((this.丟东丁世丗且丂丟下 == true) ? 1 : 0);
        if((val_1 & 1) != 0)
        {
                var val_3 = (val_10 == false) ? (1 + 1) : 1;
            return (int)(val_10 <= val_8) ? (1 + 1) : 1;
        }
        
        val_10 = this.丟东丁世丗且丂丟下 | val_10;
        if(val_10 != false)
        {
                var val_4 = (this.丂丈不丗丝丙丈与不 <= this.丟东业专下丄丐丟丁) ? 2 : (0 + 1);
            return (int)(val_10 <= val_8) ? (1 + 1) : 1;
        }
        
        val_10 = UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team1Progress));
        int val_8 = UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team2Progress));
        if(val_10 != val_8)
        {
                return (int)(val_10 <= val_8) ? (1 + 1) : 1;
        }
        
        val_11 = 0;
        return (int)(val_10 <= val_8) ? (1 + 1) : 1;
    }
    private void OnDisable()
    {
    
    }
    private void 丏且丛丛下业专一七(int 业不丐不丅丐丒世下)
    {
        int val_10;
        var val_11;
        var val_12;
        NetworkStartTable val_13;
        var val_14;
        val_10 = 业不丐不丅丐丒世下;
        val_11 = this;
        this.playerStarted = false;
        val_12 = null;
        val_12 = null;
        val_13 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_13 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_13 == 0)
        {
                return;
        }
        
        if(val_10 <= 0)
        {
                val_10 = this.GetWinningTeam();
        }
        
        this.winnerText = this.GetWinningLabel(丕丗丞丞丑丘丛丂且:  val_10);
        int val_5 = UnityEngine.Mathf.RoundToInt(f:  TramController.丄丘七三上丕世丞业.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team1Progress));
        val_13 = TramController.丄丘七三上丕世丞业;
        bool val_8 = UnityEngine.Mathf.RoundToInt(f:  val_13.GetDistanceProgressFor(上丕丈丞丌丘丅不与:  this.team2Progress)).isMaster;
        if(val_8 != false)
        {
                val_8.三丝且上丁丘业不丁(丕丗丞丞丑丘丛丂且:  val_10);
            this.丄丗七世丂丟一万丆(丕丗丞丞丑丘丛丂且:  val_10);
        }
        
        this.丘丝丑丕丒丄丛丆东 = false;
        val_11 = 1152921505189646336;
        val_14 = null;
        val_14 = null;
        if(GameController.mode == null)
        {
                return;
        }
        
        var val_9 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + (LegacyModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? GameController.mode : 0;
    }
    public void AddRoundTime(float 丂三丟丂丈丐丆丗丟)
    {
        if(this.isMaster == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Mathf.Max(a:  0f, b:  丂三丟丂丈丐丆丗丟);
        val_2 = this.不丄丟丞丄万不丈丌 + val_2;
        this.不丄丟丞丄万不丈丌 = val_2;
    }
    public void ShowFortHit()
    {
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.containerUI, y:  0);
        if(val_2 != false)
        {
                val_2.containerUI.ShowFortHit();
        }
        
        if(this.inAttackTeam == true)
        {
                return;
        }
        
        this = InGameGUI.丙丞专丌丁丞与不丐;
        if(this == 0)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.BlinkSiegeGateOnAttack();
    }
    public SiegeController()
    {
        this.matchTime = 60f;
        this.team1 = new System.Collections.Generic.List<NetworkStartTable>();
        this.team2 = new System.Collections.Generic.List<NetworkStartTable>();
        this.且丄丟丏丛丞丆丂丘 = new System.Collections.Generic.List<NetworkStartTable>();
        this.connectingTeam1 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.connectingTeam2 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.丅丑丄丌丛万丐不不 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.mySiegeTeam = 0;
        this.丘丏丞丛不丆万丙丕 = 1;
        this.丝丆丌丁丏丙业上丒 = 2;
        this.不丌丙丌丒丙三丕丙 = 3;
        this.丘丝丑丕丒丄丛丆东 = 1;
        this.connectingPlayerCharacters = new System.Collections.Generic.Dictionary<System.Int32, 丆丙丆且下丐丗丁一>();
        this.connectingPlayerCharactersBuffer = new System.Collections.Generic.Dictionary<System.Int32, 丆丙丆且下丐丗丁一>();
        this.丙丛丄万东丕丄七丙 = new System.Collections.Generic.List<SiegeCharacterPoint>();
    }
    private static SiegeController()
    {
        SiegeController.丆丙七丑业丌丘丑万 = 20f;
        SiegeController.丑丘三丞七下上丁丌 = 10f;
    }

}
