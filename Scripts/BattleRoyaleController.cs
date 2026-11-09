using UnityEngine;
internal sealed class BattleRoyaleController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private const bool 东不丑丄上丞丕东丌 = True;
    private UnityEngine.AudioClip killZoneStartMovesAudioClip;
    private UnityEngine.AudioClip safeZoneStartMovesAudioClip;
    internal const int 丏丗丙丄丞丄丝丌丈 = 4;
    private static BattleRoyaleController 丝业丆丁业三丈丟东;
    public SafeZonesController safeZones;
    public UnityEngine.Bounds mapBounds;
    public bool isStartGame;
    public bool isStartTimer;
    public bool isStartGameInitialized;
    public string roomConnectedName;
    public bool theEnd;
    public bool isRunPlayer;
    internal static System.Collections.Generic.Dictionary<int, float> 下丞不七与丈丗专丈;
    internal static float 丟丙丄与上丆一丗世;
    internal static float 丝丑业业丈丕且上丝;
    internal static float 丂丐上丑丅丞且与丏;
    public float startTimer;
    private float 丛一丛丌丈丂万三丗;
    private float 万丄万一丄与丟丏丟;
    private bool 丑丕丐丘丐丒与丗上;
    public float startZoneTimeShow;
    public float startZoneTimeStay;
    public bool playerDead;
    private UnityEngine.Vector3[] 丒丈丗丆丏业丞丈丞;
    public float timeInGame;
    private float 丅与丅七丘丁丗七丁;
    internal static float 丅丒丌上丅丙丛丙丏;
    internal static System.Collections.Generic.Dictionary<int, int> 业不万业东三专与七;
    public int minCountPlayer;
    public bool isEnd;
    public bool isDraw;
    private int 三丞丈丅丅且丕丐与;
    public bool fadeMusic;
    private bool 丆丂丐丏上丒丗丈丅;
    public PhotonView photonView;
    internal System.Collections.Generic.Dictionary<string, 丈万且丗丂丝丙一东> 上丄丈丙丐丘丙丁与;
    public UnityEngine.Transform shutle;
    public UnityEngine.Transform[] shutlePaths;
    private int 丈七丑丒且丏丞丑与;
    public float timeFlyShutle;
    internal static float 丛下丗丐七丏丗丕丕;
    public UnityEngine.Vector3 startPathPoint;
    public UnityEngine.Vector3 endPathPoint;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    private string 业丑丂且世丟丛丞且;
    private bool 万一三丒丂业且丞丙;
    private bool 丐下与且丐丟丕丂丒;
    private float 万丒不丈丙丙丁专丆;
    private bool 丒与丅且丈丄与世丂;
    private bool 世丆丗丟丗丙丘与三;
    private float backgroundMusicOffPlayerPositionY;
    private UnityEngine.GameObject _outOfZoneParticles;
    internal bool 丆世丞丞东世丅丗丁;
    public string mySquadID;
    internal System.Collections.Generic.List<NetworkStartTable> mySquad;
    public System.Collections.Generic.HashSet<string> squadsIDs;
    public bool squadMode;
    public bool notAloneInMatch;
    public UnityEngine.Transform road;
    public UnityEngine.Vector3 initPosRoad;
    public float deltaPosRoadInFly;
    public float markersRaysDisableDistance;
    public float markersRaysStartDisableDistance;
    public float markersRingsDisableDistance;
    public float markersRingsStartDisableDistance;
    public System.Collections.Generic.Dictionary<string, int> SquadPlaces;
    internal bool 丒与丟世七专丘三丛;
    internal System.Collections.Generic.List<万丅世丈丕丕丌丅丗> squadInfo;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> 丂丄丒丌三丅专丗丅;
    private WorldPosIndicationItem_RoyaleSquad[] 丗丂一业丙丈丂丂丗;
    
    // Properties
    internal static BattleRoyaleController 丆丕丝丒不丙且丐丗 { get; }
    public UnityEngine.GameObject 丛丐不丌东万东丟丐 { get; }
    public int 不下丒丗丘一丐业丂 { get; }
    public int 丆丆丏下上上丐世上 { get; }
    internal static double 上与丌世三且丄东丝 { get; set; }
    internal static int 丆丕丌业丗专七世丒 { get; }
    public BattleRoyaleController.丛丏丂丄上专且万业 七专丙丏丘丌丌下与 { get; set; }
    
    // Methods
    internal static BattleRoyaleController 丑七不且上丗丁一世()
    {
        null = null;
        return (BattleRoyaleController)BattleRoyaleController.丝业丆丁业三丈丟东;
    }
    internal static float 丕丂上丏丈与丗丐丘(int 丛丝丁丗且丘丂与万)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((BattleRoyaleController.下丞不七与丈丗专丈.ContainsKey(key:  丛丝丁丗且丘丂与万)) == false)
        {
                return 30f;
        }
        
        val_3 = null;
        val_3 = null;
        if(BattleRoyaleController.下丞不七与丈丗专丈 != null)
        {
                return BattleRoyaleController.下丞不七与丈丗专丈.Item[丛丝丁丗且丘丂与万];
        }
        
        return BattleRoyaleController.下丞不七与丈丗专丈.Item[丛丝丁丗且丘丂与万];
    }
    internal static int 丂丛丁丐七丟一丄丐(int 丛丝丁丗且丘丂与万)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((BattleRoyaleController.业不万业东三专与七.ContainsKey(key:  丛丝丁丗且丘丂与万)) == false)
        {
                return 5;
        }
        
        val_3 = null;
        val_3 = null;
        if(BattleRoyaleController.业不万业东三专与七 != null)
        {
                return BattleRoyaleController.业不万业东三专与七.Item[丛丝丁丗且丘丂与万];
        }
        
        return BattleRoyaleController.业不万业东三专与七.Item[丛丝丁丗且丘丂与万];
    }
    public UnityEngine.GameObject get_OutOfZoneParticles()
    {
        return (UnityEngine.GameObject)this._outOfZoneParticles;
    }
    public int get_DeadSquadsCount()
    {
        var val_5;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String> val_7;
        val_5 = null;
        val_5 = null;
        val_7 = BattleRoyaleController.<>c.<>9__78_0;
        if(val_7 != null)
        {
                return System.Linq.Enumerable.Count<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String>(source:  this.上丄丈丙丐丘丙丁与, selector:  System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String> val_1 = null)), predicate:  new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean BattleRoyaleController::丒一业丞丏丈丘丙丄(string 三丟东丕丄丄下下丑)));
        }
        
        val_7 = val_1;
        val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String>(object:  BattleRoyaleController.<>c.__il2cppRuntimeField_static_fields, method:  System.String BattleRoyaleController.<>c::丘不丘与不一丘专且(System.Collections.Generic.KeyValuePair<string, 丈万且丗丂丝丙一东> 三丟东丕丄丄下下丑));
        BattleRoyaleController.<>c.<>9__78_0 = val_7;
        return System.Linq.Enumerable.Count<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String>(source:  this.上丄丈丙丐丘丙丁与, selector:  val_1)), predicate:  new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean BattleRoyaleController::丒一业丞丏丈丘丙丄(string 三丟东丕丄丄下下丑)));
    }
    public int get_TotalSquadsCount()
    {
        var val_5;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String> val_7;
        var val_9;
        System.Func<System.String, System.Boolean> val_11;
        val_5 = null;
        val_5 = null;
        val_7 = BattleRoyaleController.<>c.<>9__80_0;
        if(val_7 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String>(object:  BattleRoyaleController.<>c.__il2cppRuntimeField_static_fields, method:  System.String BattleRoyaleController.<>c::世且东七丏丄下丄丄(System.Collections.Generic.KeyValuePair<string, 丈万且丗丂丝丙一东> 三丟东丕丄丄下下丑));
            BattleRoyaleController.<>c.<>9__80_0 = val_7;
        }
        
        val_9 = null;
        val_9 = null;
        val_11 = BattleRoyaleController.<>c.<>9__80_1;
        if(val_11 != null)
        {
                return System.Linq.Enumerable.Count<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String>(source:  this.上丄丈丙丐丘丙丁与, selector:  val_1)), predicate:  System.Func<System.String, System.Boolean> val_4 = null);
        }
        
        val_11 = val_4;
        val_4 = new System.Func<System.String, System.Boolean>(object:  BattleRoyaleController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleRoyaleController.<>c::丞丑丝丙丝三不万丞(string 三丟东丕丄丄下下丑));
        BattleRoyaleController.<>c.<>9__80_1 = val_11;
        return System.Linq.Enumerable.Count<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.String>(source:  this.上丄丈丙丐丘丙丁与, selector:  val_1)), predicate:  val_4);
    }
    internal static double 丄专丕丞丟七丐丞世()
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
        if((val_8.ContainsKey(key:  GameConnect.丕丄丛丁丛丂丝上下)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丕丄丛丁丛丂丝上下]);
    }
    internal static void 专下业下七与万东丗(double 丙业与丙丗丝不丈东)
    {
        var val_4;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
            val_4 = null;
            val_4 = null;
            val_2.set_Item(key:  GameConnect.丕丄丛丁丛丂丝上下, value:  丙业与丙丗丝不丈东);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Room is null, but you trying to change room properties!");
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
    public BattleRoyaleController.丛丏丂丄上专且万业 get_roomStatus()
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
    public void set_roomStatus(BattleRoyaleController.丛丏丂丄上专且万业 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 丏丒专下丁丕一世丌()
    {
        null = null;
        this.万专一丂丞业不丒丌(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable);
    }
    private void 万专一丂丞业不丒丌(NetworkStartTable 专丞上七七且丝七丗)
    {
        string val_16;
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.IEnumerable<TSource> val_21;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_22;
        var val_23;
        int val_24;
        string val_25;
        BattleRoyaleController.丟丐丟丝丝不丈下丒 val_1 = new BattleRoyaleController.丟丐丟丝丝不丈下丒();
        val_16 = NetworkStartTable.丏三不丙丐丘丑丞专(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        if(val_1 != null)
        {
                val_17 = val_1;
            .丑丝丌丞丙丝七丆七 = val_16;
        }
        else
        {
                val_17 = 16;
            mem[16] = val_16;
            val_16 = mem[16];
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) == true)
        {
                return;
        }
        
        val_16 = this.SquadPlaces;
        if((val_16.ContainsKey(key:  val_17)) != false)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_16;
        }
        
        val_19 = 1;
        if(val_1 != null)
        {
            goto label_23;
        }
        
        goto label_18;
        label_16:
        val_20 = null;
        val_20 = null;
        if(val_1 != null)
        {
            goto label_23;
        }
        
        label_18:
        label_23:
        .与丏丟与丛丈丆丛下 = (typeof(Player_move_c).__il2cppRuntimeField_56F != 0) ? 1 : 0;
        this.UpdatePlayerScores();
        val_21 = System.Linq.Enumerable.Where<丈万且丗丂丝丙一东>(source:  this.上丄丈丙丐丘丙丁与.Values, predicate:  new System.Func<丈万且丗丂丝丙一东, System.Boolean>(object:  val_1, method:  System.Boolean BattleRoyaleController.丟丐丟丝丝不丈下丒::与丟世丈下丑专丄丏(丈万且丗丂丝丙一东 三丟东丕丄丄下下丑)));
        bool val_11 = System.Linq.Enumerable.Any<丈万且丗丂丝丙一东>(source:  val_21, predicate:  new System.Func<丈万且丗丂丝丙一东, System.Boolean>(object:  val_1, method:  System.Boolean BattleRoyaleController.丟丐丟丝丝不丈下丒::丌丒丝丛业丕丂上万(丈万且丗丂丝丙一东 三丟东丕丄丄下下丑)));
        if(val_11 != false)
        {
                if(val_11.roomStatus != 1)
        {
                return;
        }
        
            val_22 = this.SquadPlaces;
            val_23 = 1152921523768715824;
            val_24 = 1;
            val_25 = mem[16];
        }
        else
        {
                var val_16 = this.TotalSquadsCount;
            val_16 = val_16 + 1;
            val_22 = val_16 - this.DeadSquadsCount;
            BattleRoyaleController val_15 = BattleRoyaleController.丑七不且上丗丁一世();
            val_21 = mem[16];
            val_23 = 1152921523768715824;
            val_25 = val_21;
            val_24 = val_22;
        }
        
        val_15.SquadPlaces.set_Item(key:  val_25, value:  val_24);
    }
    private int 丑丄丝丌丌丁丄丑丂(NetworkStartTable 专丞上七七且丝七丗)
    {
        BattleRoyaleController val_1 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_1.squadMode == false)
        {
                return 0;
        }
        
        string val_2 = NetworkStartTable.丏三不丙丐丘丑丞专(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) == true)
        {
                return 0;
        }
        
        if((this.SquadPlaces.ContainsKey(key:  val_2)) == false)
        {
                return 0;
        }
        
        if(this.SquadPlaces != null)
        {
                return this.SquadPlaces.Item[val_2];
        }
        
        return this.SquadPlaces.Item[val_2];
    }
    internal int 丟丁丕世丕与丑专丈()
    {
        null = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                return this.丑丄丝丌丌丁丄丑丂(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable);
        }
        
        return this.丑丄丝丌丌丁丄丑丂(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable);
    }
    private void Awake()
    {
        BattleRoyaleController val_35;
        var val_36;
        int val_37;
        UnityEngine.Transform val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        val_35 = this;
        val_36 = null;
        val_36 = null;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_1.m_Handle.name)) != 0)
        {
                val_37 = val_3.indexMap;
        }
        else
        {
                val_37 = 5009;
        }
        
        this.startTimer = BattleRoyaleController.丕丂上丏丈与丗丐丘(丛丝丁丗且丘丂与万:  145);
        this.丛一丛丌丈丂万三丗 = BattleRoyaleController.丂丐上丑丅丞且与丏;
        BattleRoyaleController.丝丑业业丈丕且上丝 = this.万丄万一丄与丟丏丟;
        val_38 = this.road;
        if(val_38 != 0)
        {
                val_38 = this.road;
            UnityEngine.Vector3 val_7 = val_38.position;
            this.initPosRoad = val_7;
            mem[1152921525486192148] = val_7.y;
            mem[1152921525486192152] = val_7.z;
        }
        
        this.minCountPlayer = BattleRoyaleController.丂丛丁丐七丟一丄丐(丛丝丁丗且丘丂与万:  145);
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_39 = null;
            val_39 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丐丞丛丛丒丁丈上业)) != false)
        {
                val_40 = null;
            val_40 = null;
            int val_17 = System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丐丞丛丛丒丁丈上业]);
            if(val_17 < this.shutlePaths.Length)
        {
                this.丈七丑丒且丏丞丑与 = val_17;
        }
        
        }
        
            val_41 = null;
            val_41 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.三丗七丘丄丛丐丒世)) != false)
        {
                val_42 = null;
            val_42 = null;
            object val_23 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.三丗七丘丄丛丐丒世];
            this.squadMode = (null == 1) ? 1 : 0;
        }
        
        }
        
            UnityEngine.Vector3 val_25 = this.shutlePaths[this.丈七丑丒且丏丞丑与].position;
            val_38 = this.丈七丑丒且丏丞丑与;
            this.startPathPoint = val_25;
            mem[1152921525486192020] = val_25.y;
            mem[1152921525486192024] = val_25.z;
            UnityEngine.Vector3 val_27 = this.shutlePaths[val_38].GetChild(index:  0).position;
            this.endPathPoint = val_27;
            mem[1152921525486192032] = val_27.y;
            mem[1152921525486192036] = val_27.z;
            this.shutle.position = new UnityEngine.Vector3() {x = this.startPathPoint, y = V9.16B, z = V10.16B};
            this.shutle.LookAt(worldPosition:  new UnityEngine.Vector3() {x = this.endPathPoint, y = V9.16B, z = V10.16B});
            UnityEngine.Quaternion val_28 = this.shutle.rotation;
            val_43 = null;
            val_43 = null;
            ThirdPersonCamera.startMouseXForShattle = val_28.y;
            this.photonView = this.GetComponent<PhotonView>();
            val_44 = null;
            val_44 = null;
            BattleRoyaleController.丝业丆丁业三丈丟东 = val_35;
            this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
            this.业丑丂且世丟丛丞且 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5647");
            this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
            this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
            this.丏七丕七丆东七丐丆();
            return;
        }
        
        val_35 = this.gameObject;
        val_35.SetActive(value:  false);
    }
    private void 丏七丕七丆东七丐丆()
    {
        var val_2 = null;
        this.safeZones.SelectRandomZones(上七不丈下下丛丘与:  BattleRoyaleController.一一丕丏丈世丞世丟());
    }
    internal void 业丒丈丏一万不丏世(NetworkStartTable 不且上一上丐三万丛)
    {
        var val_9;
        var val_10;
        var val_11;
        string val_12;
        val_9 = null;
        val_9 = null;
        val_10 = public System.Boolean UnityEngine.Object::Equals(object other);
        if((不且上一上丐三万丛.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)) != true)
        {
                val_10 = 0;
            if((不且上一上丐三万丛.丈三世丞丕万丄七丂.Equals(value:  "-1")) != false)
        {
                if(不且上一上丐三万丛.业丏三七专东丁丕丂 == 1)
        {
                return;
        }
        
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        if((不且上一上丐三万丛.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)) != false)
        {
                val_12 = "mine";
        }
        else
        {
                val_12 = System.String.Format(format:  "{0}-{1}", arg0:  不且上一上丐三万丛.丈三世丞丕万丄七丂, arg1:  不且上一上丐三万丛.业丏三七专东丁丕丂.ToString());
        }
        
        if((this.上丄丈丙丐丘丙丁与.ContainsKey(key:  val_12)) != false)
        {
                this.上丄丈丙丐丘丙丁与.Item[val_12].丑七下业与丕丛丅丕(不且上一上丐三万丛:  不且上一上丐三万丛);
            return;
        }
        
        this.上丄丈丙丐丘丙丁与.Add(key:  val_12, value:  new 丈万且丗丂丝丙一东(不且上一上丐三万丛:  不且上一上丐三万丛));
    }
    private void OnDestroy()
    {
        null = null;
        BattleRoyaleController.丝业丆丁业三丈丟东 = 0;
    }
    private void OnDisable()
    {
    
    }
    private void Update()
    {
        var val_59;
        var val_60;
        var val_61;
        float val_62;
        float val_64;
        var val_65;
        float val_66;
        var val_67;
        var val_68;
        NetworkStartTableNGUIController val_69;
        float val_70;
        float val_71;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        float val_77;
        string val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        if((System.String.IsNullOrEmpty(value:  this.roomConnectedName)) != false)
        {
                if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                this.roomConnectedName = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘();
        }
        
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
            goto label_16;
        }
        
        val_59 = null;
        val_59 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
            goto label_16;
        }
        
        if(this.万一三丒丂业且丞丙 != true)
        {
                val_60 = null;
            val_60 = null;
            if(JoystickController.丘万丏三丏丑世丐丏 != 0)
        {
                val_61 = null;
            val_61 = null;
            if((JoystickController.丘万丏三丏丑世丐丏.jumpTouch & 1) != 0)
        {
                val_62 = 5f;
            Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5468"), 丂三丟丂丈丐丆丗丟:  val_62, 丂丝且专丒三世丞丐:  true);
            this.万一三丒丂业且丞丙 = true;
        }
        
        }
        
        }
        
        val_64 = this.万丒不丈丙丙丁专丆;
        if(this.safeZones.safeZoneRadius != val_64)
        {
                val_62 = 5f;
            Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5485"), 丂三丟丂丈丐丆丗丟:  val_62, 丂丝且专丒三世丞丐:  true);
            if(this.safeZoneStartMovesAudioClip != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_13 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.safeZoneStartMovesAudioClip);
        }
        
        }
        
        }
        
        if((this.丐下与且丐丟丕丂丒 == true) || (this.safeZones.safeZoneRadius == 0f))
        {
            goto label_48;
        }
        
        val_65 = null;
        val_65 = null;
        UnityEngine.Vector3 val_16 = transform.position;
        val_62 = val_16.x;
        val_64 = val_16.y;
        val_66 = val_16.z;
        if((this.safeZones.IsInSafeZoneRadius(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_62, y = val_64, z = val_66})) == false)
        {
            goto label_55;
        }
        
        label_48:
        if(this.丒与丅且丈丄与世丂 == true)
        {
            goto label_63;
        }
        
        val_67 = null;
        val_67 = null;
        UnityEngine.Vector3 val_19 = transform.position;
        val_62 = val_19.x;
        val_64 = val_19.y;
        val_66 = val_19.z;
        if((this.safeZones.IsOutOfCurrentZoneRadius(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_62, y = val_64, z = val_66})) == false)
        {
            goto label_63;
        }
        
        label_55:
        val_62 = 5f;
        Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5470"), 丂三丟丂丈丐丆丗丟:  val_62, 丂丝且专丒三世丞丐:  true);
        this.丐下与且丐丟丕丂丒 = true;
        label_63:
        if((this.世丆丗丟丗丙丘与三 != true) && (this.safeZones.isCurrentZoneMoves != false))
        {
                val_62 = 5f;
            Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5471"), 丂三丟丂丈丐丆丗丟:  val_62, 丂丝且专丒三世丞丐:  true);
            if(this.killZoneStartMovesAudioClip != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_26 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.killZoneStartMovesAudioClip);
        }
        
        }
        
        }
        
        val_68 = null;
        val_68 = null;
        val_69 = transform;
        UnityEngine.Vector3 val_28 = val_69.position;
        val_70 = val_28.x;
        val_71 = val_70;
        this.丒与丅且丈丄与世丂 = this.safeZones.IsOutOfCurrentZoneRadius(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_71, y = val_28.y, z = val_28.z});
        this.世丆丗丟丗丙丘与三 = this.safeZones.isCurrentZoneMoves;
        this.万丒不丈丙丙丁专丆 = this.safeZones.safeZoneRadius;
        label_16:
        if(this.fadeMusic != false)
        {
                val_69 = 1152921505171275776;
            val_73 = null;
            val_73 = null;
            if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 != false)
        {
                val_74 = null;
            val_74 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer != 0)
        {
                val_75 = null;
            val_75 = null;
            val_76 = null;
            val_76 = null;
            val_70 = 0f;
            if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  val_70, 丒丈丙丐丏丕丆万丗:  0f, 丌丕丗七丒丛万丒东:  0.0001f)) != false)
        {
                this.fadeMusic = false;
        }
        
            val_71 = val_70 * 与丂丏丛丞丞丒丟丄.业且丞丂一与不七丑();
            MenuBackgroundMusic.专下丆丞一丆丏丂东(与丁万东丌丑下丏丕:  val_71);
        }
        
        }
        
        }
        
        if(this.isStartTimer == false)
        {
            goto label_124;
        }
        
        val_70 = this.startTimer;
        if(val_70 <= 0f)
        {
            goto label_121;
        }
        
        val_70 = val_70 - UnityEngine.Time.deltaTime;
        this.startTimer = val_70;
        if(this.isStartTimer == false)
        {
            goto label_124;
        }
        
        label_121:
        if(val_70 <= 0f)
        {
                val_70 = this.丛一丛丌丈丂万三丗;
            if(val_70 > 0f)
        {
                val_71 = val_70 - UnityEngine.Time.deltaTime;
            this.丛一丛丌丈丂万三丗 = val_71;
        }
        
        }
        
        label_124:
        if(this.isStartGame == true)
        {
            goto label_125;
        }
        
        if(this.isStartTimer == false)
        {
            goto label_126;
        }
        
        val_77 = this.startTimer;
        if(val_77 <= 0f)
        {
            goto label_127;
        }
        
        object[] val_39 = new object[4];
        val_39[0] = this.丌业下与丗东丈丌丑;
        val_70 = val_77 / 60f;
        val_39[1] = UnityEngine.Mathf.FloorToInt(f:  val_70);
        var val_58 = 60;
        val_58 = (UnityEngine.Mathf.FloorToInt(f:  val_70)) * val_58;
        float val_59 = (float)val_58;
        val_59 = val_77 - val_59;
        val_39[2] = ((UnityEngine.Mathf.FloorToInt(f:  val_59)) < 10) ? "0" : "";
        var val_60 = 60;
        val_60 = (UnityEngine.Mathf.FloorToInt(f:  val_70)) * val_60;
        val_71 = val_77 - (float)val_60;
        val_39[3] = UnityEngine.Mathf.FloorToInt(f:  val_71);
        val_77 = this.startTimer;
        val_78 = System.String.Format(format:  "{0} {1}:{2}{3}", args:  val_39);
        goto label_145;
        label_126:
        val_78 = this.专丁丈丛丂上丟上一;
        goto label_148;
        label_127:
        val_78 = "";
        label_145:
        if((val_77 < 0) && (this.isStartGame != true))
        {
                val_78 = this.丗丏与丂世丝丐丁且;
        }
        
        label_148:
        val_69 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_69 != 0)
        {
                val_69 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 336];
            val_69 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.HungerStartLabel;
            text = val_78;
        }
        
        if(this.isStartGame == false)
        {
            goto label_167;
        }
        
        label_125:
        if((this.isRunPlayer != true) && (this.isEnd != true))
        {
                val_69 = 1152921505286238208;
            val_79 = null;
            val_79 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_80 = null;
            val_80 = null;
            UnityEngine.Debug.Log(message:  "Start minigames player");
            this.isRunPlayer = true;
            this.isDraw = false;
            this.丞丞下丒丅丅丛世丕();
        }
        
        }
        
        label_167:
        if(this.theEnd == true)
        {
            goto label_176;
        }
        
        val_81 = null;
        val_81 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_176;
        }
        
        if(this.notAloneInMatch != true)
        {
                val_82 = null;
            val_82 = null;
            this.notAloneInMatch = (丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count > 1) ? 1 : 0;
        }
        
        val_70 = this.timeInGame;
        float val_52 = UnityEngine.Time.deltaTime;
        val_52 = val_70 + val_52;
        this.timeInGame = val_52;
        this.丐丈丌不丌丁东丒且(专丏丁丕丅七丏世丑:  false);
        goto label_181;
        label_176:
        this.timeInGame = 0f;
        this.丆丂丐丏上丒丗丈丅 = false;
        label_181:
        if(this.isRunPlayer != false)
        {
                val_83 = null;
            val_83 = null;
            val_69 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
            this.三丞丈丅丅且丕丐与 = UnityEngine.Mathf.Max(a:  this.三丞丈丅丅且丕丐与, b:  val_69);
            this.UpdatePlayerScores();
        }
        
        if(this.squadMode == false)
        {
                return;
        }
        
        this.丛七不下业东世与丑();
        if(this.isRunPlayer == true)
        {
                return;
        }
        
        this.丟丒业丆丐东丏丁上();
    }
    private void LateUpdate()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                this.丝且丄一与丒丈万丄();
            return;
        }
        
        this.丗丂一业丙丈丂丂丗 = 0;
    }
    private void 七下七万丆丌不上与()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        与丅丕丈丘东丝世丟 val_21;
        var val_22;
        var val_23;
        string val_24;
        val_16 = this;
        val_17 = 1152921505107111936;
        val_18 = 1152921505066536960;
        val_19 = 1152921525484599408;
        var val_18 = 0;
        val_20 = 2;
        goto label_1;
        label_39:
        val_21 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[(long)(long)(int)(W21)];
        val_22 = null;
        val_22 = null;
        if((val_21.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.与丈业东丂丘丅三丙)) != false)
        {
                val_23 = null;
            val_23 = null;
            val_24 = System.Convert.ToString(value:  val_21.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丈业东丂丘丅三丙]);
        }
        else
        {
                val_24 = "";
        }
        
        if((System.String.IsNullOrEmpty(value:  val_24)) == false)
        {
            goto label_18;
        }
        
        if(val_18 <= 3)
        {
            goto label_19;
        }
        
        label_29:
        var val_17 = 1;
        val_17 = val_17 + 1;
        goto label_25;
        label_19:
        if(val_18 < 2)
        {
            goto label_25;
        }
        
        与丅丕丈丘东丝世丟[] val_8 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_8.Length != val_20)
        {
            goto label_25;
        }
        
        与丅丕丈丘东丝世丟[] val_9 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_9.Length >= 5)
        {
            goto label_29;
        }
        
        label_25:
        string val_10 = val_17.ToString();
        val_24 = val_10;
        val_10.专丟丑丞不丑丂丙不(专丞上七七且丝七丗:  val_21, 一丌一丕下专丙世丘:  val_24);
        val_18 = val_18 + 1;
        label_18:
        if((this.丂丄丒丌三丅专丗丅.ContainsKey(key:  val_24)) != true)
        {
                this.丂丄丒丌三丅专丗丅.Add(key:  val_24, value:  new System.Collections.Generic.List<System.Int32>());
            val_19 = val_19;
            val_18 = val_18;
            val_17 = val_17;
            val_16 = val_16;
            val_21 = val_21;
        }
        
        this.丂丄丒丌三丅专丗丅.Item[val_24].Add(item:  val_21.业丐丐三丕一丗丛丁());
        val_20 = val_20 + 1;
        label_1:
        与丅丕丈丘东丝世丟[] val_16 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if((val_20 - 2) < val_16.Length)
        {
            goto label_39;
        }
    
    }
    private void 丟丒业丆丐东丏丁上()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        string val_21;
        var val_22;
        this.squadsIDs.Clear();
        val_15 = 0;
        goto label_2;
        label_42:
        val_16 = null;
        val_16 = null;
        if(Item[0] != 0)
        {
                val_17 = null;
            val_17 = null;
            NetworkStartTable val_3 = Item[0];
            if(val_3.丄丈丑丐丆丞丘与丗.owner != null)
        {
                val_18 = null;
            val_18 = null;
            NetworkStartTable val_5 = Item[0];
            与丅丕丈丘东丝世丟 val_6 = val_5.丄丈丑丐丆丞丘与丗.owner;
            val_19 = null;
            val_19 = null;
            if((val_6.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.与丈业东丂丘丅三丙)) != false)
        {
                val_20 = null;
            val_20 = null;
            val_21 = System.Convert.ToString(value:  val_6.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丈业东丂丘丅三丙]);
        }
        else
        {
                val_21 = "";
        }
        
            if((this.squadsIDs.Contains(item:  val_21)) != true)
        {
                bool val_13 = this.squadsIDs.Add(item:  val_21);
        }
        
        }
        
        }
        
        val_15 = 1;
        label_2:
        val_22 = null;
        val_22 = null;
        if(val_15 < Count)
        {
            goto label_42;
        }
    
    }
    private void 丛七不下业东世与丑()
    {
        var val_55;
        string val_56;
        var val_57;
        string val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        string val_68;
        var val_69;
        string val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        string val_83;
        if((丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() != null) && ((System.String.IsNullOrEmpty(value:  this.mySquadID)) != false))
        {
                val_55 = null;
            val_55 = null;
            val_56 = GameConnect.与丈业东丂丘丅三丙;
            if((丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_56)) != false)
        {
                val_57 = null;
            val_57 = null;
            val_56 = GameConnect.与丈业东丂丘丅三丙;
            val_58 = System.Convert.ToString(value:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().Item[val_56]);
        }
        else
        {
                val_58 = "";
        }
        
            if((System.String.IsNullOrEmpty(value:  val_58)) != true)
        {
                this.mySquadID = val_58;
        }
        
        }
        
        this.mySquad.Clear();
        if((System.String.IsNullOrEmpty(value:  this.mySquadID)) == true)
        {
            goto label_23;
        }
        
        val_59 = 1152921505189646336;
        val_60 = 1152921525488043600;
        val_61 = 0;
        goto label_24;
        label_135:
        val_62 = null;
        val_62 = null;
        if(Item[0] == 0)
        {
            goto label_118;
        }
        
        val_63 = null;
        val_63 = null;
        NetworkStartTable val_14 = Item[0];
        if(val_14.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_118;
        }
        
        val_64 = null;
        val_64 = null;
        val_65 = null;
        val_65 = null;
        if(Item[0] == WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)
        {
            goto label_118;
        }
        
        val_66 = null;
        val_66 = null;
        NetworkStartTable val_18 = Item[0];
        与丅丕丈丘东丝世丟 val_19 = val_18.丄丈丑丐丆丞丘与丗.owner;
        val_67 = null;
        val_67 = null;
        val_68 = GameConnect.与丈业东丂丘丅三丙;
        if((val_19.丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_68)) != false)
        {
                val_69 = null;
            val_69 = null;
            string val_24 = System.Convert.ToString(value:  val_19.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丈业东丂丘丅三丙]);
        }
        else
        {
                val_70 = "";
        }
        
        if((System.String.op_Equality(a:  val_70, b:  this.mySquadID)) == false)
        {
            goto label_118;
        }
        
        val_71 = null;
        val_71 = null;
        this.mySquad.Add(item:  Item[0]);
        NetworkStartTable val_27 = Item[0];
        if(val_27.丞丗丅东业丑不丙丞 == true)
        {
            goto label_118;
        }
        
        val_72 = null;
        val_72 = null;
        NetworkStartTable val_28 = Item[0];
        val_28.丞丗丅东业丑不丙丞 = true;
        val_73 = null;
        val_73 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_74 = null;
            val_74 = null;
            val_75 = null;
            val_75 = null;
            NetworkStartTable val_30 = Item[0];
            上丝三一丆丞丝丐丆(专丞上七七且丝七丗:  val_30.丄丈丑丐丆丞丘与丗.owner);
        }
        
        val_76 = 0;
        goto label_98;
        label_108:
        val_76 = 1;
        label_98:
        if(val_76 >= this.squadInfo.Count)
        {
            goto label_110;
        }
        
        万丅世丈丕丕丌丅丗 val_33 = this.squadInfo.Item[1];
        val_77 = null;
        val_77 = null;
        val_68 = Item[0];
        if((System.String.op_Equality(a:  val_33.丆世丘丒丒丏上且丗, b:  val_34.丈三世丞丕万丄七丂)) == false)
        {
            goto label_108;
        }
        
        if(this.squadInfo.Item[1] == null)
        {
            goto label_110;
        }
        
        val_78 = null;
        val_78 = null;
        val_36.不且上一上丐三万丛 = Item[0];
        NetworkStartTable val_38 = Item[0];
        val_38.丙丕丗丁丌丗不丗世 = val_36.丒东丑丟世与下且丟;
        goto label_118;
        label_110:
        val_79 = null;
        val_79 = null;
        val_68 = Item[0];
        this.squadInfo.Add(item:  new 万丅世丈丕丕丌丅丗(不且上一上丐三万丛:  val_68, 丒东丑丟世与下且丟:  UnityEngine.Mathf.Min(a:  2, b:  this.squadInfo.Count)));
        NetworkStartTable val_43 = Item[0];
        val_43.丙丕丗丁丌丗不丗世 = (万丅世丈丕丕丌丅丗)[1152921525488778896].丒东丑丟世与下且丟;
        label_118:
        val_61 = 1;
        label_24:
        val_80 = null;
        val_80 = null;
        val_56 = mem[GameController.onlineMode + 392];
        val_56 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_61 < Count)
        {
            goto label_135;
        }
        
        label_23:
        if(this.isRunPlayer == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.七不丐丐丆丒丛丏万() == false)
        {
                return;
        }
        
        val_59 = 1152921505066536960;
        val_60 = 1152921504618561536;
        val_68 = 0;
        goto label_143;
        label_164:
        与丅丕丈丘东丝世丟 val_55 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
        val_81 = null;
        val_56 = val_55.丑丗三丛丛丆丟丌丆();
        val_81 = null;
        if((val_56.ContainsKey(key:  GameConnect.与丈业东丂丘丅三丙)) != false)
        {
                val_82 = null;
            val_82 = null;
            val_56 = val_55.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丈业东丂丘丅三丙];
            string val_52 = System.Convert.ToString(value:  val_56);
        }
        else
        {
                val_83 = "";
        }
        
        if((System.String.IsNullOrEmpty(value:  val_83)) != false)
        {
                this.与丛专丒丕一丅丄丄(丁丐丁丂丛丟七专世:  val_55);
        }
        
        val_68 = 1;
        label_143:
        与丅丕丈丘东丝世丟[] val_54 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_68 < val_54.Length)
        {
            goto label_164;
        }
    
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
        var val_37;
        WorldPosIndicationItem_RoyaleSquad[] val_38;
        var val_39;
        WorldPosIndicationItem_RoyaleSquad[] val_40;
        float val_41;
        WorldPosIndicationItem_RoyaleSquad[] val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        val_37 = 1152921505291722752;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_38 = this.丗丂一业丙丈丂丂丗;
        if(val_38 == null)
        {
            goto label_4;
        }
        
        val_39 = 0;
        if(val_38 != null)
        {
            goto label_35;
        }
        
        goto label_6;
        label_4:
        val_40 = new WorldPosIndicationItem_RoyaleSquad[3];
        this.丗丂一业丙丈丂丂丗 = val_40;
        goto label_7;
        label_28:
        WorldPosIndicationItem_RoyaleSquad val_3 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_RoyaleSquad>();
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
        this.丗丂一业丙丈丂丂丗[(long)val_38] = val_3;
        UnityEngine.Color val_4 = this.七丘丗丘丞丝丁丑丝(丝丁丙七丌丛丐一丐:  val_38);
        this.丗丂一业丙丈丂丂丗[(long)val_38].丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  UnityEngine.Texture[].__il2cppRuntimeField_byval_arg, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        UnityEngine.Color val_5 = this.七丘丗丘丞丝丁丑丝(丝丁丙七丌丛丐一丐:  val_38);
        val_41 = val_5.b;
        this.丗丂一业丙丈丂丂丗[(long)val_38].丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_41, a = val_5.a});
        WorldPosIndicationItem_RoyaleSquad val_39 = this.丗丂一业丙丈丂丂丗[(long)val_38];
        mem2[0] = 0;
        val_40 = this.丗丂一业丙丈丂丂丗;
        label_7:
        if(val_38[1] < this.丗丂一业丙丈丂丂丗.Length)
        {
            goto label_28;
        }
        
        val_39 = 0;
        goto label_29;
        label_36:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丗丂一业丙丈丂丂丗[0].gameObject, 丏业丟一东丂东丘丛:  false);
        val_39 = 1;
        label_29:
        val_43 = this.丗丂一业丙丈丂丂丗;
        if(val_43 != null)
        {
            goto label_35;
        }
        
        label_6:
        label_35:
        if(val_39 < this.丗丂一业丙丈丂丂丗.Length)
        {
            goto label_36;
        }
        
        val_44 = null;
        val_44 = null;
        val_37 = 1152921505219145728;
        val_45 = 0;
        goto label_39;
        label_134:
        if(Item[0] == 0)
        {
            goto label_126;
        }
        
        NetworkStartTable val_9 = Item[0];
        if(val_9.丌丑丛业丈丘世丞丕 == 0)
        {
            goto label_126;
        }
        
        NetworkStartTable val_11 = Item[0];
        if((val_11.丙丕丗丁丌丗不丗世 & 2147483648) != 0)
        {
            goto label_126;
        }
        
        NetworkStartTable val_12 = Item[0];
        if(val_12.丙丕丗丁丌丗不丗世 >= this.丗丂一业丙丈丂丂丗.Length)
        {
            goto label_126;
        }
        
        NetworkStartTable val_13 = Item[0];
        UnityEngine.Vector3 val_14 = val_13.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
        if(val_14.y < 0)
        {
            goto label_126;
        }
        
        val_46 = null;
        val_46 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_126;
        }
        
        NetworkStartTable val_16 = Item[0];
        WorldPosIndicationItem_RoyaleSquad val_41 = this.丗丂一业丙丈丂丂丗[val_16.丙丕丗丁丌丗不丗世];
        if(InGameGUI.丙丞专丌丁丞与不丐.isWorldMapOpened == true)
        {
            goto label_126;
        }
        
        val_47 = null;
        val_47 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_78;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
            goto label_126;
        }
        
        BankController val_20 = BankController.丑七不且上丗丁一世();
        if(val_20.uiRoot.gameObject.activeInHierarchy == true)
        {
            goto label_126;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_41.gameObject, 丏业丟一东丂东丘丛:  true);
        NetworkStartTable val_24 = Item[0];
        UnityEngine.Vector3 val_25 = val_24.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  1.5f);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        val_41 = val_28.y;
        val_41.丝东不丄且不丏业丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_28.x, y = val_41, z = val_28.z});
        NetworkStartTable val_29 = Item[0];
        val_48 = null;
        val_48 = null;
        val_41.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  val_29.丌丑丛业丈丘世丞丕.transform, 丙七丟丏丅丘丈丁丄:  transform);
        NetworkStartTable val_32 = Item[0];
        val_37 = 1152921505219145728;
        val_41.丗东丕且上丏业丝世(丛与丙丒丒下丌丟且:  (val_32.丌丑丛业丈丘世丞丕.东丑丌丄丝世丞丘三 == true) ? 1 : 0);
        goto label_126;
        label_78:
        val_49 = null;
        val_49 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_50 = null;
            val_50 = null;
            if(丆丗丂三丐不东且丏() != true)
        {
                val_51 = null;
            val_51 = null;
            val_52 = null;
            val_52 = null;
        }
        
        }
        
        label_126:
        val_45 = 1;
        label_39:
        if(val_45 < Count)
        {
            goto label_134;
        }
    
    }
    private void 与丛专丒丕一丅丄丄(与丅丕丈丘东丝世丟 丁丐丁丂丛丟七专世)
    {
        var val_16;
        var val_17;
        var val_18;
        string val_20;
        var val_21;
        string val_22;
        val_16 = 0;
        val_17 = 0;
        goto label_1;
        label_26:
        与丅丕丈丘东丝世丟 val_16 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
        val_18 = null;
        val_18 = null;
        val_20 = GameConnect.与丈业东丂丘丅三丙;
        if((val_16.丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_20)) != false)
        {
                val_21 = null;
            val_21 = null;
            val_22 = System.Convert.ToString(value:  val_16.丑丗三丛丛丆丟丌丆().Item[GameConnect.与丈业东丂丘丅三丙]);
        }
        else
        {
                val_22 = "";
        }
        
        int val_7 = 0;
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_22, 丙业与丙丗丝不丈东: out  val_7)) != false)
        {
                if(val_7 > 1)
        {
                val_17 = 1;
        }
        else
        {
                var val_9 = (val_7 == 1) ? (val_17 + 1) : (val_17);
        }
        
        }
        
        val_16 = 1;
        label_1:
        与丅丕丈丘东丝世丟[] val_10 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_16 < val_10.Length)
        {
            goto label_26;
        }
        
        string val_11 = 1.ToString();
        val_11.专丟丑丞不丑丂丙不(专丞上七七且丝七丗:  丁丐丁丂丛丟七专世, 一丌一丕下专丙世丘:  val_11);
        if((mem[1152921525490288584].ContainsKey(key:  val_11)) != true)
        {
                System.Collections.Generic.List<System.Int32> val_13 = null;
            val_20 = val_13;
            val_13 = new System.Collections.Generic.List<System.Int32>();
            mem[1152921525490288584].Add(key:  val_11, value:  val_13);
        }
        
        mem[1152921525490288584].Item[val_11].Add(item:  丁丐丁丂丛丟七专世.业丐丐三丕一丗丛丁());
    }
    private void 专丟丑丞不丑丂丙不(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, string 一丌一丕下专丙世丘)
    {
        var val_2;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_2 = null;
        val_2 = null;
        val_1.Add(key:  GameConnect.与丈业东丂丘丅三丙, value:  一丌一丕下专丙世丘);
        专丞上七七且丝七丗.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丐丈丌不丌丁东丒且(bool 专丏丁丕丅七丏世丑 = False)
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        Player_move_c val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(this.notAloneInMatch == false)
        {
                return;
        }
        
        if(this.isRunPlayer == false)
        {
                return;
        }
        
        if(this.timeInGame <= 10f)
        {
                return;
        }
        
        if(this.丆世丞丞东世丅丗丁 != false)
        {
                return;
        }
        
        if(this.squadMode == false)
        {
            goto label_11;
        }
        
        val_19 = 1152921525487174064;
        val_20 = 0;
        goto label_12;
        label_43:
        val_21 = null;
        val_21 = null;
        val_22 = null;
        val_22 = null;
        val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0] != val_23)
        {
                val_24 = null;
            val_24 = null;
            Player_move_c val_4 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_4.丟三丏丅世一丟丟上.与丛下丐丆丞万万下 != true)
        {
                val_25 = null;
            val_25 = null;
            Player_move_c val_5 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_5.丟三丏丅世一丟丟上.丏且丞丏丞世丈丕专() != true)
        {
                val_26 = null;
            val_26 = null;
            Player_move_c val_7 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_7.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == false)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        val_20 = 1;
        label_12:
        val_27 = null;
        val_27 = null;
        if(val_20 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_43;
        }
        
        goto label_44;
        label_11:
        val_19 = 1152921525487174064;
        val_20 = 0;
        goto label_45;
        label_70:
        val_28 = null;
        val_28 = null;
        val_29 = null;
        val_29 = null;
        val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0] != val_23)
        {
                val_30 = null;
            val_30 = null;
            Player_move_c val_11 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_11.丟三丏丅世一丟丟上.与丛下丐丆丞万万下 != true)
        {
                val_31 = null;
            val_31 = null;
            Player_move_c val_12 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_12.丟三丏丅世一丟丟上.丏且丞丏丞世丈丕专() == false)
        {
                return;
        }
        
        }
        
        }
        
        val_20 = 1;
        label_45:
        val_32 = null;
        val_32 = null;
        if(val_20 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_70;
        }
        
        label_44:
        if(专丏丁丕丅七丏世丑 != false)
        {
                this.丄丛丐丆丄七专丂丌();
            return;
        }
        
        if(this.丆丂丐丏上丒丗丈丅 == true)
        {
                return;
        }
        
        this.丆丂丐丏上丒丗丈丅 = true;
        object[] val_15 = new object[1];
        val_15[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  186, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_15);
    }
    private void 丛丙丘丁万且专下丆()
    {
        var val_8;
        var val_9;
        float val_8 = 60f;
        val_8 = this.timeInGame / val_8;
        Rilisoft.一丟专且三万丞丁丂.不与丌万丌不下世下(下与丗丕专丅丕丗丌:  ExpController.丑七不且上丗丁一世().丆丝丁丞丙上万三一(), 万丌丅世专丟丞丏与:  UnityEngine.Mathf.RoundToInt(f:  val_8));
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        Rilisoft.一丟专且三万丞丁丂.丏丈东丑下世丈丞与(下与丗丕专丅丕丗丌:  ExpController.丑七不且上丗丁一世().丆丝丁丞丙上万三一(), 下丑丞丛丝世丁东丟:  丑丛丆三丆丄七丐万());
    }
    private void 丄丛丐丆丄七专丂丌()
    {
        var val_1;
        if(this.theEnd != false)
        {
                return;
        }
        
        this.theEnd = true;
        this.丛丙丘丁万且专下丆();
        this.roomStatus = 1;
        val_1 = null;
        val_1 = null;
        丆丄丕丁丕一丙丕丒();
    }
    public void UpdatePlayerScores()
    {
        var val_5;
        var val_6;
        var val_7;
        System.Collections.Generic.Dictionary<System.String, 丈万且丗丂丝丙一东> val_8;
        val_5 = 0;
        goto label_1;
        label_10:
        val_6 = null;
        val_6 = null;
        this.业丒丈丏一万不丏世(不且上一上丐三万丛:  Item[0]);
        val_5 = 1;
        label_1:
        val_7 = null;
        val_7 = null;
        if(val_5 < Count)
        {
            goto label_10;
        }
        
        val_8 = this.上丄丈丙丐丘丙丁与;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_8.GetEnumerator();
        label_14:
        if(((-590550360) & 1) == 0)
        {
            goto label_12;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        val_4._value._obj.与丁七三万丛万丘丌();
        goto label_14;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丞丞下丒丅丅丛世丕()
    {
        null = null;
        GameController.onlineMode.丟丛专七不七丆三万();
        this.SquadPlaces.Clear();
    }
    private void 下万丆七丙下与丂丞()
    {
        UnityEngine.GameObject val_2;
        var val_3;
        var val_4;
        val_2 = this;
        if(this.theEnd == true)
        {
                return;
        }
        
        this.丛丙丘丁万且专下丆();
        this.theEnd = true;
        this.isDraw = true;
        val_3 = null;
        val_3 = null;
        val_2 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_2 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if(val_2 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        下丁不丌丈下上丙丁();
    }
    public void OnPlayerRespawn()
    {
        var val_1;
        var val_2;
        this.playerDead = true;
        val_1 = null;
        val_1 = null;
        丂丛丆万丐丝下东丑();
        this.下万丆七丙下与丂丞();
        val_2 = null;
        val_2 = null;
        丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  false);
    }
    public int GetDiedPlayerCount()
    {
        null = null;
        return UnityEngine.Mathf.Max(a:  0, b:  this.三丞丈丅丅且丕丐与 - 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count);
    }
    public int GetAlivePlayerCount()
    {
        null = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙 != null)
        {
                return 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
        }
        
        return 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
    }
    public int GetPlayerCountInMatch()
    {
        return (int)this.三丞丈丅丅且丕丐与;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        bool val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 > 115)
        {
            goto label_1;
        }
        
        if(val_1 == 99)
        {
            goto label_2;
        }
        
        if(val_1 != 115)
        {
            goto label_9;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        val_2 = true;
        this.isStartTimer = val_2;
        this.startTimer = null;
        return (bool)val_2;
        label_1:
        if(val_1 == 132)
        {
            goto label_14;
        }
        
        if(val_1 == 136)
        {
            goto label_8;
        }
        
        if(val_1 != 186)
        {
            goto label_9;
        }
        
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        this.专丕三下丌不专世专(世丘丙万丝丌丄丞丐:  21884928);
        goto label_14;
        label_9:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        this.丛丛业丈下下丐丟丒();
        goto label_14;
        label_8:
        object val_4 = 专丒丌丆下丐丞丟丞[0];
        this.isStartTimer = null;
        label_14:
        val_2 = 1;
        return (bool)val_2;
    }
    internal void 专丕三下丌不专世专(int 世丘丙万丝丌丄丞丐)
    {
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != 世丘丙万丝丌丄丞丐)
        {
                return;
        }
        
        if(this.丆丂丐丏上丒丗丈丅 == false)
        {
                return;
        }
        
        this.丐丈丌不丌丁东丒且(专丏丁丕丅七丏世丑:  true);
        this.丆丂丐丏上丒丗丈丅 = false;
    }
    internal void 丞丝下丄丆且丌丈丐(bool 丟丌丟丑丂丅丙丕一)
    {
        this.isStartTimer = 丟丌丟丑丂丅丙丕一;
    }
    internal void 丆丁一丐一丄丘一丑(float 丘上三丁与丘世专丝)
    {
        this.isStartTimer = true;
        this.startTimer = 丘上三丁与丘世专丝;
    }
    internal void 丛丛业丈下下丐丟丒()
    {
        var val_6;
        丅丑丕丏丗三丛且东 val_7;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒() != 1)
        {
                if((this.squadMode == false) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒() > 4))
        {
            goto label_9;
        }
        
        }
        
        this.丆世丞丞东世丅丗丁 = true;
        label_9:
        this.isStartGame = true;
        if(this.squadMode != false)
        {
                val_6 = null;
            val_6 = null;
            var val_5 = (GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 == true) ? (1 + 1) : 1;
        }
        else
        {
                val_7 = 0;
        }
        
        Rilisoft.一丟专且三万丞丁丂.与业专丝丈丝三丞丝(丂丛丑东不丅丈一东:  val_7);
    }
    public BattleRoyaleController()
    {
        this.startTimer = 30f;
        this.丛一丛丌丈丂万三丗 = 4f;
        this.万丄万一丄与丟丏丟 = 5f;
        this.startZoneTimeShow = 10f;
        this.startZoneTimeStay = 10f;
        this.丅与丅七丘丁丗七丁 = 2f;
        this.minCountPlayer = 10;
        this.fadeMusic = true;
        this.上丄丈丙丐丘丙丁与 = new System.Collections.Generic.Dictionary<System.String, 丈万且丗丂丝丙一东>(capacity:  30);
        this.timeFlyShutle = 60f;
        this.backgroundMusicOffPlayerPositionY = 70f;
        this.mySquadID = "";
        this.mySquad = new System.Collections.Generic.List<NetworkStartTable>();
        this.squadsIDs = new System.Collections.Generic.HashSet<System.String>();
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.initPosRoad = val_4;
        mem[1152921525492657460] = val_4.y;
        mem[1152921525492657464] = val_4.z;
        mem2[0] = ;
        this.markersRingsStartDisableDistance = 100f;
        this.SquadPlaces = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        this.squadInfo = new System.Collections.Generic.List<万丅世丈丕丕丌丅丗>();
        this.丂丄丒丌三丅专丗丅 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>>();
    }
    private static BattleRoyaleController()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        if(val_1 != null)
        {
                val_1.Add(key:  149, value:  30f);
        }
        else
        {
                val_1.Add(key:  149, value:  30f);
        }
        
        val_1.Add(key:  147, value:  30f);
        BattleRoyaleController.下丞不七与丈丗专丈 = val_1;
        BattleRoyaleController.丟丙丄与上丆一丗世 = 5f;
        BattleRoyaleController.丝丑业业丈丕且上丝 = 5f;
        BattleRoyaleController.丂丐上丑丅丞且与丏 = 4f;
        BattleRoyaleController.丅丒丌上丅丙丛丙丏 = 3f;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(val_2 != null)
        {
                val_2.Add(key:  149, value:  5);
        }
        else
        {
                val_2.Add(key:  149, value:  5);
        }
        
        val_2.Add(key:  147, value:  10);
        BattleRoyaleController.业不万业东三专与七 = val_2;
        BattleRoyaleController.丛下丗丐七丏丗丕丕 = 7f;
    }
    private bool 丒一业丞丏丈丘丙丄(string 三丟东丕丄丄下下丑)
    {
        object val_5;
        var val_6;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Boolean> val_8;
        BattleRoyaleController.丛三上上七丒万丑丅 val_1 = null;
        val_5 = val_1;
        val_1 = new BattleRoyaleController.丛三上上七丒万丑丅();
        .三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        val_6 = null;
        val_6 = null;
        val_8 = BattleRoyaleController.<>c.<>9__78_3;
        if(val_8 != null)
        {
                return System.Linq.Enumerable.All<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>>(source:  this.上丄丈丙丐丘丙丁与, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Boolean>(object:  val_1, method:  System.Boolean BattleRoyaleController.丛三上上七丒万丑丅::丁上不丑丆丂丟万上(System.Collections.Generic.KeyValuePair<string, 丈万且丗丂丝丙一东> 丒丒丄丁且丄丆丂丌))), predicate:  System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Boolean> val_4 = null);
        }
        
        val_8 = val_4;
        val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Boolean>(object:  BattleRoyaleController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleRoyaleController.<>c::丏丟三上丟上一丁丕(System.Collections.Generic.KeyValuePair<string, 丈万且丗丂丝丙一东> 上丂丙丄丌丁丛三丄));
        BattleRoyaleController.<>c.<>9__78_3 = val_8;
        return System.Linq.Enumerable.All<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>>(source:  this.上丄丈丙丐丘丙丁与, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Boolean>(object:  val_1, method:  System.Boolean BattleRoyaleController.丛三上上七丒万丑丅::丁上不丑丆丂丟万上(System.Collections.Generic.KeyValuePair<string, 丈万且丗丂丝丙一东> 丒丒丄丁且丄丆丂丌))), predicate:  val_4);
    }

}
