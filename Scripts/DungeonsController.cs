using UnityEngine;
internal sealed class DungeonsController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static int 丏丘丙与万丂一丈丛;
    internal static int 丅丌世丗丅专万七丟;
    internal static DungeonsController 丄丘七三上丕世丞业;
    internal static bool 一上不下丝丂丟上丞;
    private System.Nullable<丐七不丝丆丐丂丐下> 丘东三下丂丌丘与丞;
    public DungeonsController.丛丏丂丄上专且万业 roomStatus;
    public DungeonsController.丛丏丂丄上专且万业 lastRoomStatus;
    private const float 丛丙专一七上下三丐 = 1800;
    private const float 丁丑丞东且万一下一 = 6;
    private const int 丄丑且丂丘七丈下丝 = 4;
    private bool 丑上丐丙一丌丟丄丟;
    private float 不丄丟丞丄万不丈丌;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    internal System.Collections.Generic.List<NetworkStartTable> team;
    internal System.Collections.Generic.List<NetworkStartTable> 且丄丟丏丛丞丆丂丘;
    public System.Collections.Generic.List<与丅丕丈丘东丝世丟> connectingTeam;
    private System.Collections.Generic.List<与丅丕丈丘东丝世丟> 丅丑丄丌丛万丐不不;
    public bool playerStarted;
    public bool matchStarted;
    public bool goInterfaceShowed;
    private float 丞万业丐丛不七且丞;
    private float 丈丛万不丈与专丐世;
    private float 丆丙丌丛丝下一丏上;
    internal System.Collections.Generic.List<DungeonSpawnPoint> 上业丟丕丈下丑丝丛;
    public DungeonsPlayerPoints playerPoints;
    private bool 丆万丑丆与丗丟丟丝;
    internal bool 丕丈业丟丆七上专丟;
    public System.Collections.Generic.Dictionary<int, 丆丙丆且下丐丗丁一> connectingPlayerCharacters;
    public System.Collections.Generic.Dictionary<int, 丆丙丆且下丐丗丁一> connectingPlayerCharactersBuffer;
    private Rilisoft.丒且丐三丁丅丕一业 一丙世丛丛丑丆丁丒;
    internal System.Collections.Generic.List<万丅世丈丕丕丌丅丗> squadInfo;
    private static string 丅一丞万丑专丅丅与;
    private WorldPosIndicationItem_Distanced[] 丗丂一业丙丈丂丂丗;
    private static readonly string 东丞丗七丄万三丏丁;
    private static System.Action<与丅丕丈丘东丝世丟> 丝丂业丕丁丘一专丘;
    private static System.Action 丟与丈上丐丂丆万丒;
    private static System.Action<与丅丕丈丘东丝世丟> 丒丙丗丄丁丗业一且;
    private static System.Action<与丅丕丈丘东丝世丟> 丝三丂丅丛丌丞上丞;
    private static System.Action 且一丁万丅不丐东丒;
    internal bool 东丗丄与丒丂下且丆;
    private int 上专丕一不丗一丐丄;
    private int 丅丈丆丄丘丗一丌且;
    private System.Collections.Generic.List<BonuseWithWeight> _listBonuseWithWeight;
    internal System.Collections.Generic.Dictionary<Rilisoft.专与丏丞三与不不丆, float> 丛万三丟丅丈业丕丘;
    public float lifeTimeBonuse;
    private bool 丆世丞丞东世丅丗丁;
    
    // Properties
    public DungeonsController.丛丏丂丄上专且万业 业丂丆丝丏丛一三丁 { get; set; }
    public 丐七不丝丆丐丂丐下 与丝丒万且丘丂丟三 { get; }
    public bool 丝丝丗七丑丁丕丗丄 { get; }
    public float 丄专万丏丘上丑与一 { get; }
    public bool 专丗丛丝丗丞下丑丄 { get; }
    internal static int 丆丕丌业丗专七世丒 { get; }
    internal static float 丆上丛万上丞丆丅七 { get; }
    internal static float 丑丏丙七与丕丐丛且 { get; }
    internal static float 东丏丅一丝丑丒丕不 { get; }
    internal static float 丙丆丄丐丞丐丄三丑 { get; }
    internal static float 丛丄丙丙丈三丟丟三 { get; }
    internal static int 丅一丁世三丟丕丝业 { get; }
    internal static int 上丅丑丌丑丏丏丙东 { get; }
    internal float 丛丑丒丘一丟丌丄不 { get; }
    public float 且丌丛丙世一不且上 { get; }
    public float 丝万上丆丘丕东下丆 { get; }
    internal static bool 业丑丁丂且丆东万东 { get; }
    
    // Methods
    internal DungeonsController()
    {
        this.不丄丟丞丄万不丈丌 = 1200f;
        this.team = new System.Collections.Generic.List<NetworkStartTable>();
        this.且丄丟丏丛丞丆丂丘 = new System.Collections.Generic.List<NetworkStartTable>();
        this.connectingTeam = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.丅丑丄丌丛万丐不不 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
        this.上业丟丕丈下丑丝丛 = new System.Collections.Generic.List<DungeonSpawnPoint>();
        this.connectingPlayerCharacters = new System.Collections.Generic.Dictionary<System.Int32, 丆丙丆且下丐丗丁一>();
        this.connectingPlayerCharactersBuffer = new System.Collections.Generic.Dictionary<System.Int32, 丆丙丆且下丐丗丁一>();
        this.一丙世丛丛丑丆丁丒 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.squadInfo = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>();
        this._listBonuseWithWeight = new System.Collections.Generic.List<BonuseWithWeight>();
        this.丛万三丟丅丈业丕丘 = new System.Collections.Generic.Dictionary<Rilisoft.专与丏丞三与不不丆, System.Single>();
        this.lifeTimeBonuse = 5f;
        Rilisoft.且三与世丁丏丂丌下 val_12 = this.与丑丌丌丌丁丌不丕();
        val_12.丑业丆三上东丆七丒 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void DungeonsController::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_14 = this.与丑丌丌丌丁丌不丕();
        val_14.与丝三七丛丕七业丐 = new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void DungeonsController::OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable 不且上一上丐三万丛));
    }
    public DungeonsController.丛丏丂丄上专且万业 get_roomStatusGlobal()
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
    public void set_roomStatusGlobal(DungeonsController.丛丏丂丄上专且万业 丙业与丙丗丝不丈东)
    {
        var val_6;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Debug.Log(message:  "RoomStatusGlobal = "("RoomStatusGlobal = ") + 丙业与丙丗丝不丈东.ToString());
            ExitGames.Client.Photon.Hashtable val_4 = new ExitGames.Client.Photon.Hashtable();
            val_6 = null;
            val_6 = null;
            val_4.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  451862528);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_4, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Room is null, but you trying to change room properties!");
    }
    public 丐七不丝丆丐丂丐下 get_dungeonDifficulty()
    {
        System.Nullable<丐七不丝丆丐丂丐下> val_10;
        var val_11;
        var val_12;
        val_10 = this.丘东三下丂丌丘与丞;
        if((val_10 & 1) != 0)
        {
                val_10 = ???;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (丐七不丝丆丐丂丐下)val_11;
        }
        
        val_12 = null;
        val_12 = null;
        object val_4 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丂丅且专丌丏丑上专];
        val_11 = val_10;
        mem2[0] = 0;
        return (丐七不丝丆丐丂丐下)val_11;
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
    internal static int 一一丕丏丈世丞世丟()
    {
        var val_8;
        var val_9;
        var val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 0;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        if((val_8.ContainsKey(key:  GameConnect.七丝丕东丘丐丗不世)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丝丕东丘丐丗不世]);
    }
    internal static float 专丗丐丒丝且丄七丝()
    {
        null = null;
        return (float)BalanceController.专丑七东丌不丏一丗;
    }
    internal static float 且丂丟丌三丕丄丞世(丐七不丝丆丐丂丐下 三三丂丁与东一丂丝)
    {
        System.Single[] val_1;
        var val_2;
        var val_4;
        var val_5;
        val_1 = 三三丂丁与东一丂丝;
        if(val_1 == 3)
        {
            goto label_1;
        }
        
        if(val_1 == 2)
        {
            goto label_2;
        }
        
        if(val_1 != 1)
        {
                return 1f;
        }
        
        val_2 = null;
        val_2 = null;
        val_1 = BalanceController.丄万丐专万丟上七丒;
        if(BalanceController.丄万丐专万丟上七丒.Length != 0)
        {
                return 1f;
        }
        
        return 1f;
        label_1:
        val_4 = null;
        val_4 = null;
        val_1 = BalanceController.丄万丐专万丟上七丒;
        if(BalanceController.丄万丐专万丟上七丒.Length > 2)
        {
                return 1f;
        }
        
        return 1f;
        label_2:
        val_5 = null;
        val_5 = null;
        val_1 = BalanceController.丄万丐专万丟上七丒;
        return 1f;
    }
    internal static float 丆丘一东丝七三丑七(丐七不丝丆丐丂丐下 三三丂丁与东一丂丝)
    {
        System.Single[] val_1;
        var val_2;
        var val_4;
        var val_5;
        val_1 = 三三丂丁与东一丂丝;
        val_2 = 27748;
        if(val_1 == 3)
        {
            goto label_1;
        }
        
        if(val_1 == 2)
        {
            goto label_2;
        }
        
        if(val_1 != 1)
        {
                return 1f;
        }
        
        if(((99 & 2) != 0) && (1761637481 == 0))
        {
                val_2 = null;
        }
        
        val_1 = BalanceController.丗丒丘丌丛丌丙丕丌;
        if(BalanceController.丗丒丘丌丛丌丙丕丌.Length != 0)
        {
                return 1f;
        }
        
        return 1f;
        label_1:
        val_4 = null;
        val_4 = null;
        val_1 = BalanceController.丗丒丘丌丛丌丙丕丌;
        if(BalanceController.丗丒丘丌丛丌丙丕丌.Length > 2)
        {
                return 1f;
        }
        
        return 1f;
        label_2:
        val_5 = null;
        val_5 = null;
        val_1 = BalanceController.丗丒丘丌丛丌丙丕丌;
        return 1f;
    }
    internal static float 七业与不上丏丌丈丌()
    {
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 1f;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁() == null)
        {
                return 1f;
        }
        
        val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_9.ContainsKey(key:  GameConnect.丞丞丌东丅且业丌丙)) == false)
        {
                return 1f;
        }
        
        val_11 = null;
        val_11 = null;
        return System.Convert.ToSingle(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丞丞丌东丅且业丌丙]);
    }
    internal static float 丟丌专与丈丛丑三丅()
    {
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 1f;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁() == null)
        {
                return 1f;
        }
        
        val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_9.ContainsKey(key:  GameConnect.丈丝丁丄专三丘丒丐)) == false)
        {
                return 1f;
        }
        
        val_11 = null;
        val_11 = null;
        return System.Convert.ToSingle(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丈丝丁丄专三丘丒丐]);
    }
    internal static float 且丗与丈丆丘丙丑丞()
    {
        var val_9;
        var val_10;
        var val_11;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null) && (丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁() != null))
        {
                val_9 = null;
            val_9 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丑丟丙上丐丑业丛丂)) != false)
        {
                val_10 = null;
            val_10 = null;
            return System.Convert.ToSingle(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丑丟丙上丐丑业丛丂]);
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        return (float)RilisoftBot.BaseBot.且业七丒丞丈丟丛不;
    }
    internal static float 上丂丂丂且丟丝业丘()
    {
        var val_9;
        var val_10;
        var val_11;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null) && (丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁() != null))
        {
                val_9 = null;
            val_9 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丂丌专上丛丌丂丄丞)) != false)
        {
                val_10 = null;
            val_10 = null;
            return System.Convert.ToSingle(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丂丌专上丛丌丂丄丞]);
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        return (float)RilisoftBot.BaseBot.东丝丌丗丘东丁丐与;
    }
    internal static int 与世不丕丕丞丈丒七()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_9 = null;
            val_9 = null;
            if((val_8.ContainsKey(key:  GameConnect.一丙与丆上专专丗丐)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            object val_7 = val_8.Item[GameConnect.一丙与丆上专专丗丐];
            return (int)val_11;
        }
        
        }
        
        val_11 = 0;
        return (int)val_11;
    }
    internal static int 万丘三丘下与与且业()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_9 = null;
            val_9 = null;
            if((val_8.ContainsKey(key:  GameConnect.丅丙丛丌丄世丟丝丕)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            object val_7 = val_8.Item[GameConnect.丅丙丛丌丄世丟丝丕];
            return (int)val_11;
        }
        
        }
        
        val_11 = 0;
        return (int)val_11;
    }
    internal static void 丁七丅丟世三业不丑(int 丑且世业下且丟丅丂, bool 丕丌业三丛丑丈丆上 = False)
    {
        var val_12;
        var val_13;
        var val_14;
        ExitGames.Client.Photon.Hashtable val_15;
        var val_16;
        object val_17;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_3;
        }
        
        if(丕丌业三丛丑丈丆上 == true)
        {
            goto label_4;
        }
        
        val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_13 = null;
        val_13 = null;
        if((val_12.ContainsKey(key:  GameConnect.一丙与丆上专专丗丐)) == false)
        {
            goto label_11;
        }
        
        label_4:
        object[] val_5 = new object[4];
        val_5[0] = "SetCurrentScenario  ";
        val_5[1] = 丑且世业下且丟丅丂;
        val_5[2] = " ";
        val_5[3] = 1;
        UnityEngine.Debug.Log(message:  +val_5);
        ExitGames.Client.Photon.Hashtable val_7 = new ExitGames.Client.Photon.Hashtable();
        val_14 = null;
        val_14 = null;
        val_7.set_Item(key:  GameConnect.一丙与丆上专专丗丐, value:  丑且世业下且丟丅丂);
        val_7.set_Item(key:  GameConnect.丅丙丛丌丄世丟丝丕, value:  1);
        val_15 = 0;
        if(丕丌业三丛丑丈丆上 != true)
        {
                ExitGames.Client.Photon.Hashtable val_8 = null;
            val_15 = val_8;
            val_8 = new ExitGames.Client.Photon.Hashtable();
            val_16 = null;
            val_16 = null;
            val_8.set_Item(key:  GameConnect.一丙与丆上专专丗丐, value:  DungeonsController.与世不丕丕丞丈丒七());
            val_8.set_Item(key:  GameConnect.丅丙丛丌丄世丟丝丕, value:  DungeonsController.万丘三丘下与与且业());
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_7, 丒不一专上专丌丈东:  val_8, 丅丞丏丈且专丆不丟:  false);
        return;
        label_3:
        val_17 = "SetCurrentScenario failed. PhotonNetwork.room == null";
        goto label_43;
        label_11:
        val_17 = "SetCurrentScenario failed. KEY_DUNGEON_CURRENT_SCENARIO not initialized";
        label_43:
        UnityEngine.Debug.LogError(message:  val_17);
    }
    internal static void 丞丂不业丂丟丒丑三(string 下上丐丆丝丟丝丒不)
    {
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
            val_2.set_Item(key:  下上丐丆丝丟丝丒不, value:  0);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "SetCurrentScenario failed. PhotonNetwork.room == null");
    }
    internal static void 三世专与丟且丏七专(int 丑且世业下且丟丅丂, int 丏业丟一东丂东丘丛)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        object val_15;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_3;
        }
        
        val_11 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_12 = null;
        val_12 = null;
        if((val_11.ContainsKey(key:  GameConnect.一丙与丆上专专丗丐)) == false)
        {
            goto label_10;
        }
        
        object[] val_5 = new object[4];
        val_5[0] = "UpdateCurrentScenarioState  ";
        val_5[1] = 丑且世业下且丟丅丂;
        val_5[2] = " ";
        val_5[3] = 丏业丟一东丂东丘丛;
        UnityEngine.Debug.Log(message:  +val_5);
        ExitGames.Client.Photon.Hashtable val_7 = new ExitGames.Client.Photon.Hashtable();
        val_13 = null;
        val_13 = null;
        val_7.set_Item(key:  GameConnect.一丙与丆上专专丗丐, value:  丑且世业下且丟丅丂);
        val_7.set_Item(key:  GameConnect.丅丙丛丌丄世丟丝丕, value:  丏业丟一东丂东丘丛);
        ExitGames.Client.Photon.Hashtable val_8 = new ExitGames.Client.Photon.Hashtable();
        val_8.set_Item(key:  GameConnect.一丙与丆上专专丗丐, value:  丑且世业下且丟丅丂);
        val_14 = null;
        val_8.set_Item(key:  GameConnect.丅丙丛丌丄世丟丝丕, value:  DungeonsController.万丘三丘下与与且业());
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_7, 丒不一专上专丌丈东:  val_8, 丅丞丏丈且专丆不丟:  false);
        return;
        label_3:
        val_15 = "UpdateCurrentScenarioState failed. PhotonNetwork.room == null";
        goto label_39;
        label_10:
        val_15 = "UpdateCurrentScenarioState failed. KEY_DUNGEON_CURRENT_SCENARIO not initialized";
        label_39:
        UnityEngine.Debug.LogError(message:  val_15);
    }
    internal float 丅丗丞七与丝一与丈()
    {
        null = null;
        return (float)BalanceController.丑一世丙专丝丒下丂;
    }
    public float get_mobModuleDPSMultiplier()
    {
        null = null;
        return (float)BalanceController.丏丏东一世世丞三世;
    }
    public float get_mobPlayerResistMultiplier()
    {
        null = null;
        return (float)BalanceController.丟丕丗东丒丒三丟丆;
    }
    private void Awake()
    {
        var val_11;
        var val_21;
        string val_22;
        var val_23;
        var val_24;
        var val_25;
        bool val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        System.Action<与丅丕丈丘东丝世丟> val_31;
        var val_32;
        var val_33;
        System.Action<与丅丕丈丘东丝世丟> val_34;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_21 = null;
            val_21 = null;
            val_22 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
            if((DungeonsController.丅一丞万丑专丅丅与.Equals(value:  val_22)) != true)
        {
                val_23 = null;
            val_23 = null;
            丟丌丁且且世丈丈丟.丑世丐丂与一丐丛世 = "";
        }
        
            val_24 = null;
            val_24 = null;
            DungeonsController.丅一丞万丑专丅丅与 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
        }
        
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_22;
        }
        
        val_25 = null;
        val_25 = null;
        val_26 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        if(this != null)
        {
            goto label_27;
        }
        
        goto label_26;
        label_22:
        val_26 = 0;
        if(this != null)
        {
            goto label_27;
        }
        
        label_26:
        label_27:
        this.enabled = (val_26 != 0) ? 1 : 0;
        List.Enumerator<T> val_9 = this._listBonuseWithWeight.GetEnumerator();
        val_27 = 1152921525952287168;
        label_33:
        if(((-129344464) & 1) == 0)
        {
            goto label_29;
        }
        
        string val_12 = val_11.丐丏七丌丕丗业且上();
        if((this.丛万三丟丅丈业丕丘.ContainsKey(key:  val_12)) == true)
        {
            goto label_33;
        }
        
        this.丛万三丟丅丈业丕丘.Add(key:  val_12, value:  val_12 >> 32);
        goto label_33;
        label_29:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        DungeonsController.丄丘七三上丕世丞业 = this;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        val_30 = null;
        val_30 = null;
        val_27 = 1152921504615686144;
        val_32 = null;
        val_33 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void DungeonsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != val_33))
        {
                val_32 = null;
            val_33 = null;
            val_31 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_31;
        System.Action<与丅丕丈丘东丝世丟> val_19 = null;
        val_22 = val_19;
        val_19 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void DungeonsController::OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        if(((System.Delegate.Combine(a:  GameConnect.丅三业三丙专丏丟丐, b:  val_19)) != null) && (null != null))
        {
                val_34 = 0;
        }
        
        GameConnect.丅三业三丙专丏丟丐 = val_34;
        this.丆万丑丆与丗丟丟丝 = false;
        DungeonsController.丆万三一丞万丟不专();
    }
    private void Start()
    {
        ScenarioController.丄丘七三上丕世丞业.丐丒丙丝世丝专上业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DungeonsController::丕一丗丁丈丘丒丄丙()));
    }
    private void 丟一丁与丙丟丟丘不()
    {
        this.丆万丑丆与丗丟丟丝 = false;
    }
    internal static void 丆万三一丞万丟不专()
    {
        ExitGames.Client.Photon.Hashtable val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_12.丑丗三丛丛丆丟丌丆() == null)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_4 = null;
        val_12 = val_4;
        val_4 = new ExitGames.Client.Photon.Hashtable();
        val_13 = null;
        val_13 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丑丟丙上丐丑业丛丂)) != false)
        {
                val_14 = 0;
        }
        else
        {
                val_15 = null;
            val_15 = null;
            val_16 = null;
            val_16 = null;
            val_4.set_Item(key:  GameConnect.丑丟丙上丐丑业丛丂, value:  RilisoftBot.BaseBot.且业七丒丞丈丟丛不);
            val_14 = 1;
        }
        
        val_17 = null;
        val_17 = null;
        val_18 = GameConnect.丂丌专上丛丌丂丄丞;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_18)) == false)
        {
            goto label_27;
        }
        
        if(val_14 != 0)
        {
            goto label_28;
        }
        
        return;
        label_27:
        val_19 = null;
        val_19 = null;
        val_20 = null;
        val_20 = null;
        val_18 = RilisoftBot.BaseBot.东丝丌丗丘东丁丐与;
        val_4.set_Item(key:  GameConnect.丂丌专上丛丌丂丄丞, value:  RilisoftBot.BaseBot.东丝丌丗丘东丁丐与);
        label_28:
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_4, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丏丅丅丘上丆业丂丟()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        System.Collections.Generic.List<NetworkStartTable> val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        this.team.Clear();
        val_11 = 0;
        goto label_2;
        label_18:
        val_12 = null;
        val_12 = null;
        NetworkStartTable val_1 = Item[0];
        if(val_1.丄且丏一且丈丂与丂 != false)
        {
                val_13 = null;
            val_13 = null;
            this.team.Add(item:  Item[0]);
        }
        
        val_11 = 1;
        label_2:
        val_14 = null;
        val_14 = null;
        val_15 = mem[GameController.onlineMode + 392];
        val_15 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_11 < Count)
        {
            goto label_18;
        }
        
        this.connectingTeam.Clear();
        val_16 = 0;
        goto label_20;
        label_53:
        val_17 = 0;
        goto label_21;
        label_43:
        val_17 = 1;
        label_21:
        val_18 = null;
        val_18 = null;
        if(val_17 >= Count)
        {
            goto label_26;
        }
        
        val_19 = null;
        val_19 = null;
        NetworkStartTable val_5 = Item[1];
        if(val_5.丄丈丑丐丆丞丘与丗.owner != 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0])
        {
            goto label_43;
        }
        
        val_20 = null;
        val_20 = null;
        val_15 = Item[1];
        if(val_8.丄且丏一且丈丂与丂 == false)
        {
            goto label_43;
        }
        
        goto label_44;
        label_26:
        val_15 = this.connectingTeam;
        val_15.Add(item:  丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0]);
        label_44:
        val_16 = 1;
        label_20:
        与丅丕丈丘东丝世丟[] val_10 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_16 < val_10.Length)
        {
            goto label_53;
        }
    
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
        float val_10;
        DungeonsPlayerPoints val_57;
        丛丏丂丄上专且万业 val_58;
        var val_59;
        System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_60;
        var val_61;
        NetworkStartTable val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        float val_73;
        var val_74;
        float val_75;
        var val_76;
        var val_77;
        float val_79;
        val_57 = this;
        世丁与丕丗丟丒丆上 val_1 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        丛丏丂丄上专且万业 val_2 = val_1.roomStatusGlobal;
        if(val_2 == 0)
        {
                val_2.roomStatusGlobal = 1;
        }
        
        val_58 = this.roomStatus;
        if(val_58 != 0)
        {
            goto label_6;
        }
        
        val_58 = val_2.roomStatusGlobal;
        this.roomStatus = val_58;
        goto label_6;
        label_3:
        val_58 = 0;
        this.roomStatus = 0;
        this.丆万丑丆与丗丟丟丝 = false;
        label_6:
        val_59 = null;
        val_59 = null;
        val_60 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                this.playerStarted = false;
        }
        
        val_61 = null;
        val_61 = null;
        val_62 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_62 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_62 == 0)
        {
                val_57 = this.playerPoints;
            val_57.Clear();
            return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                this.lastRoomStatus = val_58;
        }
        
        this.connectingPlayerCharactersBuffer.Clear();
        Dictionary.Enumerator<TKey, TValue> val_7 = this.connectingPlayerCharacters.GetEnumerator();
        label_28:
        if(((-127853920) & 1) == 0)
        {
            goto label_26;
        }
        
        ConfiguredValueTaskAwaiter val_11 = val_10.GetAwaiter();
        this.connectingPlayerCharactersBuffer.Add(key:  val_11._value._obj.丙东专丂世丈丏丁丂(), value:  val_11._value._obj);
        goto label_28;
        label_26:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_63 = 1152921505107111936;
        Dictionary.Enumerator<TKey, TValue> val_13 = this.connectingPlayerCharactersBuffer.GetEnumerator();
        label_72:
        if(((-127853920) & 1) == 0)
        {
            goto label_36;
        }
        
        ConfiguredValueTaskAwaiter val_14 = val_10.GetAwaiter();
        val_64 = 0;
        goto label_37;
        label_66:
        val_64 = 1;
        label_37:
        val_65 = null;
        val_65 = null;
        if(val_64 >= Count)
        {
            goto label_42;
        }
        
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
            goto label_67;
        }
        
        val_66 = null;
        val_66 = null;
        NetworkStartTable val_19 = Item[1];
        if(val_19.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_66;
        }
        
        val_67 = null;
        val_67 = null;
        NetworkStartTable val_21 = Item[1];
        if(val_21.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁() != val_14._value._obj.丙东专丂世丈丏丁丂())
        {
            goto label_66;
        }
        
        val_68 = null;
        val_68 = null;
        NetworkStartTable val_25 = Item[1];
        if(val_25.丄且丏一且丈丂与丂 == false)
        {
            goto label_66;
        }
        
        goto label_67;
        label_42:
        if((与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  val_14._value._obj.丙东专丂世丈丏丁丂())) != null)
        {
            goto label_72;
        }
        
        label_67:
        this.connectingPlayerCharacters.Item[val_14._value._obj.丙东专丂世丈丏丁丂()].Destroy();
        bool val_29 = this.connectingPlayerCharacters.Remove(key:  val_14._value._obj.丙东专丂世丈丏丁丂());
        goto label_72;
        label_36:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_69 = 1152921505286238208;
        val_62 = this.playerPoints;
        val_60 = this.connectingTeam;
        val_62.专丑丗丆丌丛丌丐丆(丁丟丌专三上丐丕丙:  this.team, 丘丐丙丟万丁专丆丈:  val_60);
        if((val_58 != 3) || (this.丆万丑丆与丗丟丟丝 == true))
        {
            goto label_102;
        }
        
        this.丏丅丅丘上丆业丂丟();
        val_62 = 1152921504848912384;
        val_70 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                val_71 = null;
            val_71 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_72 = null;
            val_72 = null;
            this.丟丛专七不七丆三万();
        }
        
        }
        
        val_73 = this.不丄丟丞丄万不丈丌;
        val_74 = 0;
        this.matchStarted = true;
        val_75 = val_73 - UnityEngine.Time.deltaTime;
        this.不丄丟丞丄万不丈丌 = val_75;
        if(this.isMaster != false)
        {
                val_75 = this.不丄丟丞丄万不丈丌;
            if(val_75 <= 0f)
        {
                val_74 = val_57;
            this.丛丆专七丛且丈丈万();
        }
        
        }
        
        if(this.isMaster == false)
        {
            goto label_176;
        }
        
        val_73 = this.丈丛万不丈与专丐世;
        float val_35 = UnityEngine.Time.time;
        if(val_73 >= 0)
        {
            goto label_176;
        }
        
        float val_36 = UnityEngine.Time.time;
        val_36 = val_36 + 0.5f;
        this.丈丛万不丈与专丐世 = val_36;
        object[] val_37 = new object[1];
        val_62 = val_37;
        val_10 = this.不丄丟丞丄万不丈丌;
        val_62[0] = val_10;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  144, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_37);
        goto label_176;
        label_102:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_62 = 1152921505058603008;
            val_76 = null;
            val_76 = null;
            DungeonsController.一上不下丝丂丟上丞 = false;
        }
        
        if(val_58 == 4)
        {
            goto label_135;
        }
        
        if(val_58 != 1)
        {
            goto label_176;
        }
        
        this.丏丅丅丘上丆业丂丟();
        val_60 = 1152921505086132224;
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                丑丁不万丈丟万且业();
        }
        
        if(this.丞万业丐丛不七且丞 <= 0f)
        {
            goto label_142;
        }
        
        val_77 = 0;
        val_73 = UnityEngine.Time.deltaTime;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_145;
        }
        
        val_79 = this.丞万业丐丛不七且丞 - val_73;
        goto label_146;
        label_135:
        this.matchStarted = false;
        this.丏丅丅丘上丆业丂丟();
        goto label_176;
        label_142:
        bool val_42 = isMaster;
        if(this.丛丕东业不世丞丄丛() == false)
        {
            goto label_148;
        }
        
        this.丞万业丐丛不七且丞 = 5f;
        goto label_176;
        label_145:
        val_79 = 0.01f;
        val_77 = 0;
        label_146:
        this.丞万业丐丛不七且丞 = UnityEngine.Mathf.Max(a:  val_79, b:  this.丞万业丐丛不七且丞 - val_73);
        if(this.isMaster != false)
        {
                object[] val_47 = new object[1];
            val_62 = val_47;
            val_10 = this.丞万业丐丛不七且丞;
            val_62[0] = val_10;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  149, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_47);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_73 = this.丞万业丐丛不七且丞;
            val_62 = UnityEngine.Mathf.Max(a:  0, b:  UnityEngine.Mathf.FloorToInt(f:  val_73));
            丝丂丕东专世丅丝丁(丛丅丘一丏丙且丌上:  true, 三丐东三丒丛丗丅三:  val_62, 丟丗丕不丏与丂丂丌:  false);
        }
        
        int val_51 = this.team.Count;
        if(val_51 <= 3)
        {
                if(this.丆世丞丞东世丅丗丁 == false)
        {
            goto label_167;
        }
        
        }
        
        if((this.丞万业丐丛不七且丞 > 0f) || (val_51.isMaster == false))
        {
            goto label_176;
        }
        
        this.丞万业丐丛不七且丞 = 0f;
        this.丛丅丈丄七丞丟丂丕();
        goto label_176;
        label_148:
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_176;
        }
        
        丝丂丕东专世丅丝丁(丛丅丘一丏丙且丌上:  false, 三丐东三丒丛丗丅三:  0, 丟丗丕不丏与丂丂丌:  false);
        goto label_176;
        label_167:
        this.丞万业丐丛不七且丞 = 0f;
        label_176:
        this.丅丁丄且丈丞丟丅世();
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(ScenarioController.丄丘七三上丕世丞业.丗丞东东丒丝丄丌专() == false)
        {
                return;
        }
        
        this.与三丑丛业丌丘丏丕();
    }
    private void 丅丁丄且丈丞丟丅世()
    {
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        NetworkStartTable val_53;
        var val_54;
        var val_55;
        var val_56;
        System.Collections.Generic.List<NetworkStartTable> val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        val_41 = 0;
        goto label_1;
        label_94:
        val_42 = null;
        val_42 = null;
        if(Item[0] == 0)
        {
            goto label_77;
        }
        
        val_43 = null;
        val_43 = null;
        NetworkStartTable val_3 = Item[0];
        if(val_3.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_77;
        }
        
        val_44 = null;
        val_44 = null;
        val_45 = null;
        val_45 = null;
        if(Item[0] == WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)
        {
            goto label_77;
        }
        
        val_46 = null;
        val_46 = null;
        NetworkStartTable val_7 = Item[0];
        与丅丕丈丘东丝世丟 val_8 = val_7.丄丈丑丐丆丞丘与丗.owner;
        NetworkStartTable val_9 = Item[0];
        if(val_9.丞丗丅东业丑不丙丞 == true)
        {
            goto label_77;
        }
        
        val_47 = null;
        val_47 = null;
        NetworkStartTable val_10 = Item[0];
        val_10.丞丗丅东业丑不丙丞 = true;
        val_48 = null;
        val_48 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_49 = null;
            val_49 = null;
            val_50 = null;
            val_50 = null;
            NetworkStartTable val_12 = Item[0];
            上丝三一丆丞丝丐丆(专丞上七七且丝七丗:  val_12.丄丈丑丐丆丞丘与丗.owner);
        }
        
        val_51 = 0;
        goto label_57;
        label_67:
        val_51 = 1;
        label_57:
        if(val_51 >= this.squadInfo.Count)
        {
            goto label_69;
        }
        
        万丅世丈丕丕丌丅丗 val_15 = this.squadInfo.Item[1];
        val_52 = null;
        val_52 = null;
        val_53 = Item[0];
        if((System.String.op_Equality(a:  val_15.丆世丘丒丒丏上且丗, b:  val_16.丈三世丞丕万丄七丂)) == false)
        {
            goto label_67;
        }
        
        if(this.squadInfo.Item[1] == null)
        {
            goto label_69;
        }
        
        val_54 = null;
        val_54 = null;
        val_18.不且上一上丐三万丛 = Item[0];
        NetworkStartTable val_20 = Item[0];
        val_20.丙丕丗丁丌丗不丗世 = val_18.丒东丑丟世与下且丟;
        goto label_77;
        label_69:
        val_55 = null;
        val_55 = null;
        val_53 = Item[0];
        this.squadInfo.Add(item:  new 万丅世丈丕丕丌丅丗(不且上一上丐三万丛:  val_53, 丒东丑丟世与下且丟:  UnityEngine.Mathf.Min(a:  2, b:  this.squadInfo.Count)));
        NetworkStartTable val_25 = Item[0];
        val_25.丙丕丗丁丌丗不丗世 = (万丅世丈丕丕丌丅丗)[1152921525954395328].丒东丑丟世与下且丟;
        label_77:
        val_41 = 1;
        label_1:
        val_56 = null;
        val_56 = null;
        val_57 = mem[GameController.onlineMode + 392];
        val_57 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_41 < Count)
        {
            goto label_94;
        }
        
        if(this.matchStarted == false)
        {
                return;
        }
        
        if(this.丑上丐丙一丌丟丄丟 == true)
        {
                return;
        }
        
        val_58 = 0;
        val_57 = 0;
        goto label_97;
        label_146:
        val_59 = null;
        val_59 = null;
        if(Item[0] == 0)
        {
            goto label_134;
        }
        
        val_60 = null;
        val_60 = null;
        NetworkStartTable val_29 = Item[0];
        if(val_29.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_134;
        }
        
        val_61 = null;
        val_61 = null;
        val_62 = null;
        val_62 = null;
        val_53 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_53 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(Item[0] == val_53)
        {
            goto label_134;
        }
        
        val_63 = 0;
        goto label_122;
        label_132:
        val_63 = 1;
        label_122:
        val_53 = this.squadInfo;
        if(val_63 >= val_53.Count)
        {
            goto label_134;
        }
        
        万丅世丈丕丕丌丅丗 val_34 = this.squadInfo.Item[1];
        val_64 = null;
        val_64 = null;
        NetworkStartTable val_35 = Item[0];
        if((System.String.op_Equality(a:  val_34.丆世丘丒丒丏上且丗, b:  val_35.丈三世丞丕万丄七丂)) == false)
        {
            goto label_132;
        }
        
        val_53 = this.squadInfo;
        if(val_53.Item[1] != null)
        {
                val_37.丒东丑丟世与下且丟 = UnityEngine.Mathf.Min(a:  2, b:  0);
            val_65 = null;
            val_65 = null;
            NetworkStartTable val_39 = Item[0];
            val_53 = val_37.丒东丑丟世与下且丟;
            val_39.丙丕丗丁丌丗不丗世 = val_53;
            val_57 = 1;
        }
        
        label_134:
        val_58 = 1;
        label_97:
        val_66 = null;
        val_66 = null;
        if(val_58 < Count)
        {
            goto label_146;
        }
        
        this.丑上丐丙一丌丟丄丟 = true;
    }
    private UnityEngine.Color 七丘丗丘丞丝丁丑丝(int 丝丁丙七丌丛丐一丐)
    {
        if((丝丁丙七丌丛丐一丐 & 2147483648) != 0)
        {
                return UnityEngine.Color.white;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return UnityEngine.Color.white;
        }
        
        return new UnityEngine.Color() {r = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + ((long)(int)(丝丁丙七丌丛丐一丐)) << 4) + 32, g = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + ((long)(int)(丝丁丙七丌丛丐一丐)) << 4) + 32 + 4, b = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + ((long)(int)(丝丁丙七丌丛丐一丐)) << 4) + 40, a = (BattleRoyaleSquadUI.__il2cppRuntimeField_byval_arg + ((long)(int)(丝丁丙七丌丛丐一丐)) << 4) + 40 + 4};
    }
    private void 丝且丄一与丒丈万丄()
    {
        var val_36;
        WorldPosIndicationItem_Distanced[] val_37;
        var val_38;
        WorldPosIndicationItem_Distanced[] val_39;
        float val_40;
        WorldPosIndicationItem_Distanced[] val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        val_36 = 1152921505291722752;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_37 = this.丗丂一业丙丈丂丂丗;
        if(val_37 == null)
        {
            goto label_4;
        }
        
        val_38 = 0;
        if(val_37 != null)
        {
            goto label_38;
        }
        
        goto label_6;
        label_4:
        val_39 = new WorldPosIndicationItem_Distanced[3];
        this.丗丂一业丙丈丂丂丗 = val_39;
        goto label_7;
        label_27:
        WorldPosIndicationItem_Distanced val_3 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        if(this.丗丂一业丙丈丂丂丗 == null)
        {
            goto label_9;
        }
        
        if(val_3 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_3 == null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        this.丗丂一业丙丈丂丂丗[(long)val_37] = val_3;
        UnityEngine.Texture val_4 = DungeonsController.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  0);
        UnityEngine.Color val_5 = val_4.七丘丗丘丞丝丁丑丝(丝丁丙七丌丛丐一丐:  val_37);
        this.丗丂一业丙丈丂丂丗[(long)val_37].丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  val_4, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        WorldPosIndicationItem_Distanced val_37 = this.丗丂一业丙丈丂丂丗[(long)val_37];
        UnityEngine.Color val_6 = this.七丘丗丘丞丝丁丑丝(丝丁丙七丌丛丐一丐:  val_37);
        val_40 = val_6.b;
        WorldPosIndicationItem_Distanced val_38 = this.丗丂一业丙丈丂丂丗[(long)val_37];
        mem2[0] = 0;
        val_39 = this.丗丂一业丙丈丂丂丗;
        label_7:
        if(val_37[1] < this.丗丂一业丙丈丂丂丗.Length)
        {
            goto label_27;
        }
        
        val_38 = 0;
        goto label_28;
        label_39:
        if(this.丗丂一业丙丈丂丂丗[0] != 0)
        {
                this.丗丂一业丙丈丂丂丗[0].gameObject.SetActive(value:  false);
        }
        
        val_38 = 1;
        label_28:
        val_42 = this.丗丂一业丙丈丂丂丗;
        if(val_42 != null)
        {
            goto label_38;
        }
        
        label_6:
        label_38:
        if(val_38 < this.丗丂一业丙丈丂丂丗.Length)
        {
            goto label_39;
        }
        
        val_36 = 1152921505219145728;
        val_43 = 0;
        goto label_40;
        label_148:
        val_44 = null;
        val_44 = null;
        if(Item[0] == 0)
        {
            goto label_138;
        }
        
        val_45 = null;
        val_45 = null;
        NetworkStartTable val_11 = Item[0];
        if(val_11.丌丑丛业丈丘世丞丕 == 0)
        {
            goto label_138;
        }
        
        val_46 = null;
        val_46 = null;
        NetworkStartTable val_13 = Item[0];
        if((val_13.丙丕丗丁丌丗不丗世 & 2147483648) != 0)
        {
            goto label_138;
        }
        
        val_47 = null;
        val_47 = null;
        NetworkStartTable val_14 = Item[0];
        if(val_14.丙丕丗丁丌丗不丗世 >= this.丗丂一业丙丈丂丂丗.Length)
        {
            goto label_138;
        }
        
        val_48 = null;
        val_48 = null;
        NetworkStartTable val_15 = Item[0];
        UnityEngine.Vector3 val_16 = val_15.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
        if(val_16.y < 0)
        {
            goto label_138;
        }
        
        val_49 = null;
        val_49 = null;
        NetworkStartTable val_17 = Item[0];
        WorldPosIndicationItem_Distanced val_41 = this.丗丂一业丙丈丂丂丗[val_17.丙丕丗丁丌丗不丗世];
        if(InGameGUI.丙丞专丌丁丞与不丐.isWorldMapOpened == true)
        {
            goto label_138;
        }
        
        val_50 = null;
        val_50 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_91;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
            goto label_138;
        }
        
        BankController val_21 = BankController.丑七不且上丗丁一世();
        if(val_21.uiRoot.gameObject.activeInHierarchy == true)
        {
            goto label_138;
        }
        
        val_41.gameObject.SetActive(value:  true);
        val_51 = null;
        val_51 = null;
        NetworkStartTable val_25 = Item[0];
        UnityEngine.Vector3 val_26 = val_25.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  1.5f);
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_40 = val_29.y;
        val_41.丝东不丄且不丏业丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_29.x, y = val_40, z = val_29.z});
        NetworkStartTable val_30 = Item[0];
        val_52 = null;
        val_52 = null;
        val_41.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  val_30.丌丑丛业丈丘世丞丕.transform, 丙七丟丏丅丘丈丁丄:  transform);
        val_36 = 1152921505219145728;
        goto label_138;
        label_91:
        val_53 = null;
        val_53 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_54 = null;
            val_54 = null;
            if(丆丗丂三丐不东且丏() != true)
        {
                val_55 = null;
            val_55 = null;
            val_56 = null;
            val_56 = null;
        }
        
        }
        
        label_138:
        val_43 = 1;
        label_40:
        val_57 = null;
        val_57 = null;
        if(val_43 < Count)
        {
            goto label_148;
        }
    
    }
    internal static UnityEngine.Texture 丘丈世丗丞丒丞丒丁(DungeonsController.丙丑丁一丁万丑丞丑 丞丆丆专丆与丄不上)
    {
        var val_3;
        var val_4;
        val_3 = 丞丆丆专丆与丄不上;
        val_4 = 0;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return (UnityEngine.Texture)val_4;
        }
        
        val_3 = (long)val_3;
        UnityEngine.Texture[] val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (((long)(int)(丞丆丆专丆与丄不上)) << 3);
        val_4 = mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((long)(int)(丞丆丆专丆与丄不上)) << 3) + 32];
        return (UnityEngine.Texture)val_4;
    }
    private void 丗丅丕东丏七丆丕丁()
    {
        this.丞万业丐丛不七且丞 = 5f;
    }
    private void LateUpdate()
    {
        this.丝且丄一与丒丈万丄();
    }
    private bool 丛丕东业不世丞丄丛()
    {
        return (bool)(this.team.Count > 3) ? 1 : 0;
    }
    private void 丛丅丈丄七丞丟丂丕()
    {
        PhotonView val_4;
        var val_5;
        val_4 = this;
        bool val_1 = this.isMaster;
        if(val_1 == false)
        {
                return;
        }
        
        val_1.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  3);
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_4 = this.丄丈丑丐丆丞丘与丗;
        object[] val_3 = new object[1];
        val_3[0] = 1800f;
        val_4.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  142, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.丄丈丑丐丆丞丘与丗, y:  0);
        if(val_1 == true)
        {
                return;
        }
        
        if(val_1.isMaster != false)
        {
                object[] val_3 = new object[1];
            val_3[0] = this.丞万业丐丛不七且丞;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  149, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_3);
        }
        
        if(专丞上七七且丝七丗 == null)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = DungeonsController.丒丙丗丄丁丗业一且;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = DungeonsController.丒丙丗丄丁丗业一且;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  专丞上七七且丝七丗);
    }
    private void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_1;
        System.Action<与丅丕丈丘东丝世丟> val_2;
        val_1 = null;
        val_1 = null;
        val_2 = DungeonsController.丝三丂丅丛丌丞上丞;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = DungeonsController.丝三丂丅丛丌丞上丞;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke(obj:  专丞上七七且丝七丗);
    }
    internal static bool 三丅丅丄东丑丛上下()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            val_10 = null;
            if((val_9.ContainsKey(key:  DungeonsController.东丞丗七丄万三丏丁)) != false)
        {
                val_11 = null;
            val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_9.Item[DungeonsController.东丞丗七丄万三丏丁];
            var val_8 = (null != 0) ? 1 : 0;
            return (bool)val_12;
        }
        
        }
        
        val_12 = 0;
        return (bool)val_12;
    }
    internal static void 丒丟丛专上东丗丕业()
    {
        ExitGames.Client.Photon.Hashtable val_4;
        var val_5;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_4 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_5 = null;
        val_5 = null;
        val_2.set_Item(key:  DungeonsController.东丞丗七丄万三丏丁, value:  1);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal static void 丒与丒丄丏东万上丛(System.Action<与丅丕丈丘东丝世丟> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  DungeonsController.丝丂业丕丁丘一专丘, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丝丂业丕丁丘一专丘 != 1152921505058607144);
    
    }
    internal static void 丄三丕东七下丒丒三(System.Action<与丅丕丈丘东丝世丟> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  DungeonsController.丝丂业丕丁丘一专丘, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丝丂业丕丁丘一专丘 != 1152921505058607144);
    
    }
    private void OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_1;
        System.Action<与丅丕丈丘东丝世丟> val_2;
        if(专丞上七七且丝七丗 == null)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        val_2 = DungeonsController.丝丂业丕丁丘一专丘;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = DungeonsController.丝丂业丕丁丘一专丘;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke(obj:  专丞上七七且丝七丗);
    }
    internal static void 丘专专上丑下丝业上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  DungeonsController.丟与丈上丐丂丆万丒, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丟与丈上丐丂丆万丒 != 1152921505058607152);
    
    }
    internal static void 一丕且万丂世丏丌丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  DungeonsController.丟与丈上丐丂丆万丒, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丟与丈上丐丂丆万丒 != 1152921505058607152);
    
    }
    private void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable 不且上一上丐三万丛)
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = DungeonsController.丟与丈上丐丂丆万丒;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = DungeonsController.丟与丈上丐丂丆万丒;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    internal static void 丈专丑专丙丌丞丑三(System.Action<与丅丕丈丘东丝世丟> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  DungeonsController.丒丙丗丄丁丗业一且, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丒丙丗丄丁丗业一且 != 1152921505058607160);
    
    }
    internal static void 丈三丄丑东专丈丗丞(System.Action<与丅丕丈丘东丝世丟> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  DungeonsController.丒丙丗丄丁丗业一且, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丒丙丗丄丁丗业一且 != 1152921505058607160);
    
    }
    internal static void 业丘不丂世丑且万丂(System.Action<与丅丕丈丘东丝世丟> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  DungeonsController.丝三丂丅丛丌丞上丞, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丝三丂丅丛丌丞上丞 != 1152921505058607168);
    
    }
    internal static void 一丁丆丑丒丏万三丈(System.Action<与丅丕丈丘东丝世丟> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  DungeonsController.丝三丂丅丛丌丞上丞, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.丝三丂丅丛丌丞上丞 != 1152921505058607168);
    
    }
    public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_4;
        var val_5;
        int val_6;
        val_4 = 丗与一丛丐丞丘丌丞;
        byte val_1 = val_4 & 255;
        if(val_1 > 142)
        {
            goto label_1;
        }
        
        if(val_1 == 53)
        {
            goto label_2;
        }
        
        if(val_1 != 142)
        {
            goto label_9;
        }
        
        object val_4 = 专丒丌丆下丐丞丟丞[0];
        this.丅丄丛世且丌丂下与(丛丙专一七上下三丐:  3.782474E-38f);
        goto label_22;
        label_1:
        if(val_1 == 144)
        {
            goto label_7;
        }
        
        if(val_1 == 148)
        {
            goto label_8;
        }
        
        if(val_1 != 149)
        {
            goto label_9;
        }
        
        if(专丒丌丆下丐丞丟丞[0].isMaster == true)
        {
            goto label_22;
        }
        
        this.丞万业丐丛不七且丞 = null;
        goto label_22;
        label_9:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_6 = 专丒丌丆下丐丞丟丞.Length;
        if(val_6 == 0)
        {
                val_6 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        object val_7 = 专丒丌丆下丐丞丟丞[1];
        this.丙丘丁且丗三且业丈(不丟丗丏丛丕不丁丌:  21884928, 丞丅上丏丂且下丅与:  21884928);
        goto label_22;
        label_7:
        if(专丒丌丆下丐丞丟丞[0].isMaster == true)
        {
            goto label_22;
        }
        
        this.不丄丟丞丄万不丈丌 = null;
        goto label_22;
        label_8:
        object val_9 = 专丒丌丆下丐丞丟丞[0];
        this.丑丘下丒上丐不丗不(三世丄且丅万丆丂东:  false);
        label_22:
        val_5 = 1;
        return (bool)val_5;
    }
    private void 丅丄丛世且丌丂下与(float 丛丙专一七上下三丐)
    {
        var val_5;
        var val_6;
        var val_7;
        this.丞万业丐丛不七且丞 = 0f;
        this.丆万丑丆与丗丟丟丝 = false;
        val_5 = 0;
        goto label_1;
        label_11:
        val_6 = null;
        val_6 = null;
        NetworkStartTable val_1 = Item[0];
        val_5 = 1;
        val_1.丄世一丞万一丁丙丁 = false;
        label_1:
        val_7 = null;
        val_7 = null;
        int val_2 = Count;
        if(val_5 < val_2)
        {
            goto label_11;
        }
        
        this.roomStatus = val_2.roomStatusGlobal;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                Close();
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
    internal static void 丈丘与丙丆上且丈丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  DungeonsController.且一丁万丅不丐东丒, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.且一丁万丅不丐东丒 != 1152921505058607176);
    
    }
    internal static void 丞丗丏东丛丟丒业丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  DungeonsController.且一丁万丅不丐东丒, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DungeonsController.且一丁万丅不丐东丒 != 1152921505058607176);
    
    }
    private void 丟丛专七不七丆三万()
    {
        丐七不丝丆丐丂丐下 val_8;
        var val_9;
        System.Action val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_8 = this;
        if(this.playerStarted == true)
        {
                return;
        }
        
        this.playerStarted = true;
        val_9 = null;
        val_9 = null;
        val_10 = DungeonsController.且一丁万丅不丐东丒;
        if(val_10 != null)
        {
                val_10 = DungeonsController.且一丁万丅不丐东丒;
            if(val_10 == null)
        {
                val_10 = 0;
        }
        
            val_10.Invoke();
        }
        
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                val_12 = null;
            val_12 = null;
            GameController.onlineMode.丟丛专七不七丆三万();
        }
        
        val_13 = null;
        val_13 = null;
        Rilisoft.一丟专且三万丞丁丂.业丞丆下一丐一三上(丒万丟丅丌丝丟下下:  this.dungeonDifficulty, 丛东与丑丌丗东丕丗:  0, 七丆丂丂下丈且丟世:  丙且上丒不下丑下丞());
        val_8 = this.dungeonDifficulty;
        Rilisoft.一丟专且三万丞丁丂.丗丄丐下丘丗丐且丏(丒万丟丅丌丝丟下下:  val_8, 丈丘丝一丗下丈丐不:  ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂(), 七丆丂丂下丈且丟世:  丙且上丒不下丑下丞());
        val_14 = null;
        val_14 = null;
        DungeonsController.一上不下丝丂丟上丞 = true;
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
    private void 丞丟丂丅丒丝丘丌且(DungeonsController.丛丏丂丄上专且万业 三丁丂丒不丘丄丂三)
    {
        丛丏丂丄上专且万业 val_6 = 三丁丂丒不丘丄丂三;
        this.roomStatusGlobal = val_6;
        丛丏丂丄上专且万业 val_1 = val_6 & 4294967294;
        val_6 = ((val_6 != 4) ? 1 : 0) & ((val_1 != 2) ? 1 : 0);
        UnityEngine.Debug.Log(message:  (val_1 == 2) ? "Room closed!" : "Room opened!");
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丙专丅业东业东丟与(丙业与丙丗丝不丈东:  val_6);
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action<与丅丕丈丘东丝世丟> val_7;
        System.Action val_8;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        val_6 = null;
        val_6 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void DungeonsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_7 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_7;
        val_8 = 1152921505309507584;
        if(ScenarioController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        System.Action val_5 = null;
        val_8 = val_5;
        val_5 = new System.Action(object:  this, method:  System.Void DungeonsController::丕一丗丁丈丘丒丄丙());
        ScenarioController.丄丘七三上丕世丞业.丑东下丈丝丆丅三不(丙业与丙丗丝不丈东:  val_5);
    }
    public bool CheckForEndRound()
    {
        return (bool)(this.不丄丟丞丄万不丈丌 <= 0f) ? 1 : 0;
    }
    private void 丑丘下丒上丐不丗不(bool 三世丄且丅万丆丂东)
    {
        var val_7;
        if(this.丆万丑丆与丗丟丟丝 != false)
        {
                return;
        }
        
        this.playerStarted = false;
        this.丕丈业丟丆七上专丟 = 三世丄且丅万丆丂东;
        this.丆万丑丆与丗丟丟丝 = true;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                Close();
        }
        
        丛丏丂丄上专且万业 val_3 = roomStatusGlobal;
        this.roomStatus = val_3;
        if(val_3 == 4)
        {
                this.丏且丛丛下业专一七();
        }
        else
        {
                val_3.DestroyMyPlayer();
        }
        
        val_7 = null;
        val_7 = null;
        Rilisoft.一丟专且三万丞丁丂.业丞丆下一丐一三上(丒万丟丅丌丝丟下下:  this.dungeonDifficulty, 丛东与丑丌丗东丕丗:  ((三世丄且丅万丆丂东 & true) != 0) ? (1 + 1) : 1, 七丆丂丂下丈且丟世:  丙且上丒不下丑下丞());
    }
    public void DestroyMyPlayer()
    {
        null = null;
        丟丙不上丝丂丄丗三();
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.ShowStartInterface();
    }
    internal void 丕一丗丁丈丘丒丄丙()
    {
        UnityEngine.Debug.Log(message:  "EndDungeonScenario");
        this.丕丈业丟丆七上专丟 = true;
        if(isMaster == false)
        {
                return;
        }
        
        this.丛丆专七丛且丈丈万();
    }
    private void 丛丆专七丛且丈丈万()
    {
        null = null;
        bool val_1 = UnityEngine.Object.op_Equality(x:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable, y:  0);
        if(val_1 == true)
        {
                return;
        }
        
        val_1.丞丟丂丅丒丝丘丌且(三丁丂丒不丘丄丂三:  4);
        object[] val_2 = new object[1];
        val_2[0] = this.丕丈业丟丆七上专丟;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  148, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
        this.丑丘下丒上丐不丗不(三世丄且丅万丆丂东:  this.丕丈业丟丆七上专丟);
    }
    private void 丏且丛丛下业专一七()
    {
        var val_2;
        this.playerStarted = false;
        if(this.东丗丄与丒丂下且丆 != false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(GameController.mode == null)
        {
                return;
        }
        
        (((GameModeController.__il2cppRuntimeField_typeHierarchy + (LegacyModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? GameController.mode : 0.七丁丕一一丒丂七丑();
    }
    internal void 丌丁丏丅且丗下丕丐(丅世一丈七丆业丝丘 丌丗万且世丞丏与下)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  丌丗万且世丞丏与下, 专上丝且丂世丛丝丒:  1f);
    }
    internal void 丑东丂与与丌丙丟丄(float 丗丂丁丂丗丄七丏下)
    {
        float val_6;
        var val_7;
        if(this.一丙世丛丛丑丆丁丒 != null)
        {
                val_6 = this.一丙世丛丛丑丆丁丒.丝丙丐且丟丅三丛七();
        }
        else
        {
                float val_2 = 0.丝丙丐且丟丅三丛七();
            val_6 = val_2;
        }
        
        val_2 = val_6 + 丗丂丁丂丗丄七丏下;
        this.一丙世丛丛丑丆丁丒.与万万丆丆三不上世(丙业与丙丗丝不丈东:  val_2);
        val_7 = null;
        val_7 = null;
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  this.一丙世丛丛丑丆丁丒.丝丙丐且丟丅三丛七()));
    }
    internal void 业丟丆下丄七丅三丂(float 万且丒下丕丝专丟上)
    {
        var val_3;
        this.一丙世丛丛丑丆丁丒.与万万丆丆三不上世(丙业与丙丗丝不丈东:  万且丒下丕丝专丟上);
        val_3 = null;
        val_3 = null;
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  this.一丙世丛丛丑丆丁丒.丝丙丐且丟丅三丛七()));
    }
    private void 与三丑丛业丌丘丏丕()
    {
        var val_11;
        var val_12;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                mem[1152921525960892384] = 0;
            if(this.上专丕一不丗一丐丄 < 1)
        {
                return;
        }
        
            string val_3 = "Mob Distribution: Selected MasterClient mob group, unselecting old: "("Mob Distribution: Selected MasterClient mob group, unselecting old: ") + this.上专丕一不丗一丐丄.ToString();
            UnityEngine.Debug.Log(message:  val_3);
            this.上专丕一不丗一丐丄 = 0;
            val_3.丅丈丙丅丌丑东与万(不丝丄丒丌丐一一与:  0);
            return;
        }
        
        if(this.上专丕一不丗一丐丄 != 0)
        {
                return;
        }
        
        if(this.丅丈丆丄丘丗一丌且 != 0)
        {
                return;
        }
        
        var val_13 = 1;
        label_30:
        val_11 = 0;
        goto label_9;
        label_29:
        val_11 = 1;
        label_9:
        if(val_11 >= val_4.Length)
        {
            goto label_13;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[1] == 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())
        {
            goto label_29;
        }
        
        val_12 = null;
        val_12 = null;
        if(val_13 != (System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[1].丑丗三丛丛丆丟丌丆().Item[GameConnect.丛七东丄丏一专世万])))
        {
            goto label_29;
        }
        
        val_13 = val_13 + 1;
        if(val_13 <= 2)
        {
            goto label_30;
        }
        
        return;
        label_13:
        if(val_13 < 1)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁().丅丈丙丅丌丑东与万(不丝丄丒丌丐一一与:  1);
        this.且丞且丆业万丈丞三(不丝丄丒丌丐一一与:  1);
    }
    private void 丅丈丙丅丌丑东与万(int 不丝丄丒丌丐一一与)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.Add(key:  GameConnect.丛七东丄丏一专世万, value:  不丝丄丒丌丐一一与);
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 且丞且丆业万丈丞三(int 不丝丄丒丌丐一一与)
    {
        UnityEngine.Debug.Log(message:  "Mob Distribution: Requested mob group "("Mob Distribution: Requested mob group ") + 不丝丄丒丌丐一一与);
        this.丅丈丆丄丘丗一丌且 = 不丝丄丒丌丐一一与;
        object[] val_2 = new object[2];
        int val_4 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if(val_2 == null)
        {
            goto label_6;
        }
        
        if(val_4 != 0)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_4 == 0)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_2[0] = val_4;
        val_2[1] = 不丝丄丒丌丐一一与;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  53, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 丙丘丁且丗三且业丈(int 不丟丗丏丛丕不丁丌, int 丞丅上丏丂且下丅与)
    {
        int val_4 = 丞丅上丏丂且下丅与;
        if(this.丅丈丆丄丘丗一丌且 != val_4)
        {
                return;
        }
        
        val_4 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if(val_4.业丐丐三丕一丗丛丁() == 不丟丗丏丛丕不丁丌)
        {
                this.上专丕一不丗一丐丄 = this.丅丈丆丄丘丗一丌且;
            this.丅丈丆丄丘丗一丌且 = 0;
            UnityEngine.Debug.LogError(message:  "Mob Distribution: Selected mob group "("Mob Distribution: Selected mob group ") + this.丅丈丆丄丘丗一丌且);
            this.不丕丐丏业上丆丄上();
            return;
        }
        
        this.丅丈丆丄丘丗一丌且 = 0;
    }
    private void 不丕丐丏业上丆丄上()
    {
        null = null;
        不丕丐丏业上丆丄上(丆三丅丆下上丑丞丅:  this.上专丕一不丗一丐丄, 专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
    }
    private static DungeonsController()
    {
        DungeonsController.丄丑且丂丘七丈下丝 = 50;
        DungeonsController.丅丌世丗丅专万七丟 = 3;
        DungeonsController.丅一丞万丑专丅丅与 = "";
        DungeonsController.东丞丗七丄万三丏丁 = "KEY_SPAWN_ALL_MOBS";
    }

}
