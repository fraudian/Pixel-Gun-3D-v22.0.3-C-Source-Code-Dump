using UnityEngine;
internal sealed class PlantTheBombController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static PlantTheBombController 丆丕丝丒不丙且丐丗;
    private string 丙专丈与专一丙且丕;
    internal double 世七丈丕丑上丟丘丟;
    internal int 丞一七丐东世丌专丐;
    internal bool 七业丕且万丝丛丝与;
    internal bool 世丄东丄丕七丟不丗;
    private double 与七业万丈与业七丆;
    private double 下丞不丟七丏丂上丘;
    private double 丄丅丟且一且下丒丙;
    private double 上丘丒丁七丒丂丘丘;
    private double 丂丟丑丌丕丌丙丙丘;
    internal double 东丆与且丏丐丙且七;
    internal double 七丙丟万丏与丆丆丂;
    private bool 丄丗丆丆且且万一上;
    private PlantTheBombController.丈丙丁丂丈丞丝丏专 丙且丅丁丏与丙丛且;
    private PlantTheBombController.业丐下上丄东丏且不 下不丆丅三丟丛丑丙;
    private byte 丆七一世且丏丆专丏;
    private PlantingZone zoneA;
    private PlantingZone zoneB;
    private PlantedBomb plantedBomb;
    private static System.Action<int, int> 丌丁下丁三上丗七业;
    private bool 丅丄不丈一丂丛上七;
    private bool 丟下七丐与丟丒丐丞;
    private bool 丅丌不丗万世与丟丂;
    private bool 丘丕丄与丈七与下三;
    private double 一且且万丁丌丛业丆;
    private double 丌一丞丝七丏丑丏世;
    private double 丞丛上丂丅丅丞世丁;
    private bool 丟丈专丆丁丑万与与;
    private bool 与丛丂一丘上三丘世;
    private float 丑业万丞三丙丄丞专;
    private PlantTheBombController.丐丄丕专丝丏丑东七 三丘专东丐下丂三丑;
    private double 丞丏丕丄丟丕丈丞丈;
    private double 丌专丑丑丛丐丕丂丑;
    private int 丁丅丝丒七一丌丁丛;
    private int 丌且七丒丐丛与世丑;
    private double 丛丒且不一丄三丟专;
    private double 七丅丅丆丂东与丏世;
    
    // Properties
    public static bool 业世丁一一丄世丟丒 { get; }
    public static bool 丙与丟丑万七不丑东 { get; }
    public bool 专丙丌丈丙三丝东丘 { get; }
    public static bool 丝丁丄丂丛下业不下 { get; }
    public bool 万丗上丄丞专上丅丝 { get; }
    public bool 丌丄与丈丑丌上专丝 { get; }
    public bool 丌丏专丈丐丟丕丞专 { get; }
    public double 丏丟世丑丆世丆丌专 { get; }
    internal bool 下丄丘丕丁丑丁丛丆 { get; }
    public float 三丒丛丝且丂与丑业 { get; }
    public double 丄专万丏丘上丑与一 { get; }
    internal static bool 丝下丑丗下丟丂丘丘 { get; }
    public static int 丅丛三不丅丈丟万业 { get; }
    public static int 丕上上丆丘下世与丗 { get; }
    private int 丒丐丟不丆东下丐万 { get; }
    public Player_move_c 丈万丌世丁三丑七丅 { get; }
    internal bool 且丙不世丘丌丟丂业 { get; }
    private bool 与丛东丞丑丂丏丕丕 { get; }
    internal float 世丂且专丒一丆七丂 { get; }
    internal float 世丛七下业东丅不丌 { get; }
    internal int 下丆丐万丅丏丘专丛 { get; set; }
    internal double 丂不丞丆丒东七万丞 { get; set; }
    internal double 丈丄丁丆丅三丁不三 { get; set; }
    internal int 丗丗丟丌世丐丕丙丞 { get; set; }
    internal int 万上丏不丒三上丝世 { get; set; }
    internal PlantTheBombController.世丑丗三丙丒丈丒丏 丕且三不世丘三业万 { get; set; }
    internal PlantTheBombController.丐丄丕专丝丏丑东七 丟丆世且世丂丙丟丈 { get; set; }
    internal int 上丑一与丙丁丅上丝 { get; set; }
    internal int 专丕东七东丏丕丏丒 { get; set; }
    public bool 上丅万丆与不丄丑下 { get; }
    public bool 下丈丒上丟丅丟丂丐 { get; }
    public bool 丑与专东七丄丌专丁 { get; }
    public bool 丐世丐且且丟丗丟丒 { get; }
    public bool 七丙不丕与丐丂且万 { get; }
    public bool 一上东丕与专世丝丟 { get; }
    private bool 丘下丌丙上七业丂丛 { get; }
    
    // Methods
    public static bool get_BlockScoreAndKillStreak()
    {
        var val_5;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 != 0)
        {
                var val_4 = (丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > this.丝丈丟上与一丙与丝()) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public static bool get_ReduceSensitiviity()
    {
        PlantTheBombController val_6;
        var val_7;
        val_6 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(val_6 != 0)
        {
                if(PlantTheBombController.丆丕丝丒不丙且丐丗.zoneA != 0)
        {
                val_6 = mem[PlantTheBombController.丆丕丝丒不丙且丐丗 + 136];
            val_6 = PlantTheBombController.丆丕丝丒不丙且丐丗.zoneA;
        }
        
            if(PlantTheBombController.丆丕丝丒不丙且丐丗.zoneB != 0)
        {
                val_6 = mem[PlantTheBombController.丆丕丝丒不丙且丐丗 + 144];
            val_6 = PlantTheBombController.丆丕丝丒不丙且丐丗.zoneB;
            val_7 = 1;
            return (bool)val_7;
        }
        
            val_6 = mem[PlantTheBombController.丆丕丝丒不丙且丐丗 + 152];
            val_6 = PlantTheBombController.丆丕丝丒不丙且丐丗.plantedBomb;
            if(val_6 != 0)
        {
                val_6 = mem[PlantTheBombController.丆丕丝丒不丙且丐丗 + 152];
            val_6 = PlantTheBombController.丆丕丝丒不丙且丐丗.plantedBomb;
            var val_5 = (typeof(PlantedBomb).__il2cppRuntimeField_29 != 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public bool get_IsBombDefused()
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
            if((val_8.ContainsKey(key:  GameConnect.丕丈丕丕一丞世丆不)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            object val_7 = val_8.Item[GameConnect.丕丈丕丕一丞世丆不];
            if(null == 2)
        {
                val_11 = 1;
            return (bool)val_11;
        }
        
        }
        
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    public static bool get_BlockControls()
    {
        PlantTheBombController val_5;
        var val_6;
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_6;
        }
        
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(val_5 == 0)
        {
            goto label_6;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.goTimer <= 0f)
        {
            goto label_8;
        }
        
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.三丘专东丐下丂三丑 == 1)
        {
            goto label_18;
        }
        
        label_8:
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.丄丗丆丆且且万一上 == false)
        {
            goto label_12;
        }
        
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.三丘专东丐下丂三丑 == 2)
        {
            goto label_18;
        }
        
        label_12:
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.丞丛上丂丅丅丞世丁 > 0f)
        {
            goto label_18;
        }
        
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.丌一丞丝七丏丑丏世 > 0f)
        {
            goto label_18;
        }
        
        val_5 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗.与丛丂一丘上三丘世 == false)
        {
            goto label_20;
        }
        
        label_18:
        val_6 = 1;
        return (bool)val_6;
        label_6:
        val_6 = 0;
        return (bool)val_6;
        label_20:
        var val_4 = (PlantTheBombController.丆丕丝丒不丙且丐丗.丟丈专丆丁丑万与与 == true) ? 1 : 0;
        return (bool)val_6;
    }
    public bool get_isInRound()
    {
        return (bool)(this.三丘专东丐下丂三丑 == 1) ? 1 : 0;
    }
    public bool get_isGo()
    {
        return (bool)(this.goTimer <= 0f) ? 1 : 0;
    }
    public bool get_isShowGo()
    {
        var val_5;
        double val_2 = this.丝丈丟上与一丙与丝();
        val_2 = val_2 + 1.5;
        if((丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + this.世七丈丕丑上丟丘丟) < 0)
        {
                var val_4 = (this.三丘专东丐下丂三丑 == 1) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public double get_goTimer()
    {
        double val_2 = this.丝丈丟上与一丙与丝();
        val_2 = (丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + this.世七丈丕丑上丟丘丟) - val_2;
        val_2 = 0 - val_2;
        return (double)val_2;
    }
    internal static void 与专下丆丕丟万丘东(System.Action<int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PlantTheBombController.丌丁下丁三上丗七业, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PlantTheBombController.丌丁下丁三上丗七业 != 1152921505244282888);
    
    }
    internal static void 下丅万丛丝丕业丅丏(System.Action<int, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PlantTheBombController.丌丁下丁三上丗七业, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PlantTheBombController.丌丁下丁三上丗七业 != 1152921505244282888);
    
    }
    internal bool 丙丐丐东丘且不丞丒()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_6 = null;
            val_6 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_7 = null;
            val_7 = null;
            var val_4 = (丘丑丅三丆丑丌且丝() == this.丆七一世且丏丆专丏) ? 1 : 0;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public float get_myRespawnCooldown()
    {
        return (float)(float)(this.isMyTeamBomberRole != true) ? this.与七业万丈与业七丆 : this.下丞不丟七丏丂上丘;
    }
    public double get_timeLeft()
    {
        if(this.不丙万万丗且丞丌专() > 0f)
        {
                double val_2 = this.不丙万万丗且丞丌专();
        }
        
        double val_4 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_4 = this.丝丈丟上与一丙与丝() - val_4;
        return (double)val_4;
    }
    private void Awake()
    {
        if(GameConnect.丒丗丁丙丗丄丙不丐() != true)
        {
                if(this.丅丌不丗万世与丟丂 == false)
        {
            goto label_4;
        }
        
        }
        
        this.FillAllValues();
        PlantTheBombController.丆丕丝丒不丙且丐丗 = this;
        this.丘丕丄与丈七与下三 = false;
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        this.丈下丒丟丘丝丂东丝();
        this.丑丕丟一不丕下丂下();
        return;
        label_4:
        this.gameObject.SetActive(value:  false);
    }
    private void 丑丕丟一不丕下丂下()
    {
        var val_6 = 0;
        if(this.zoneA == 0)
        {
            goto label_6;
        }
        
        val_6 = 0;
        if(this.zoneB == 0)
        {
            goto label_6;
        }
        
        val_6 = 0;
        if(this.plantedBomb != 0)
        {
            goto label_9;
        }
        
        label_6:
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Mode zones not setted zoneA:{0}, zoneB:{1}, bomb:{2}", arg0:  this.zoneA, arg1:  this.zoneB, arg2:  this.plantedBomb));
        return;
        label_9:
        this.zoneA.ZoneIndex = "A";
        this.zoneB.ZoneIndex = "B";
        this.plantedBomb.gameObject.SetActive(value:  false);
    }
    private void 丈下丒丟丘丝丂东丝()
    {
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PlantTheBombController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.下世丁丄且丘一丁下 = new System.Action(object:  this, method:  System.Void PlantTheBombController::OnDisconnectedFromPhoton());
    }
    internal static bool 丞丞丙丌丙丞与专丒()
    {
        PlantTheBombController val_7;
        var val_8;
        var val_9;
        PlantTheBombController val_10;
        var val_11;
        val_7 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(val_7 == 0)
        {
            goto label_16;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 == 0)
        {
            goto label_16;
        }
        
        val_9 = null;
        val_9 = null;
        val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if((val_7 == 0) || (this.三丘三丈上丕丆丂一() != 1))
        {
            goto label_16;
        }
        
        val_7 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        val_10 = val_7;
        if(val_7 != null)
        {
            goto label_18;
        }
        
        val_10 = PlantTheBombController.丆丕丝丒不丙且丐丗;
        if(val_10 == null)
        {
            goto label_19;
        }
        
        label_18:
        double val_7 = PlantTheBombController.丆丕丝丒不丙且丐丗.世七丈丕丑上丟丘丟;
        val_7 = val_7 - PlantTheBombController.丆丕丝丒不丙且丐丗.七丙丟万丏与丆丆丂;
        var val_6 = (PlantTheBombController.丆丕丝丒不丙且丐丗.timeLeft < 0) ? 1 : 0;
        return (bool)val_11;
        label_16:
        val_11 = 1;
        return (bool)val_11;
        label_19:
    }
    internal void 丕丞丁丐丌世世丞丈()
    {
        ExitGames.Client.Photon.Hashtable val_10;
        var val_11;
        int val_12;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_10 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_11 = null;
        val_11 = null;
        double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_3 = val_3 + this.世七丈丕丑上丟丘丟;
        val_3 = val_3 + 6.8;
        val_2.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  val_3);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_2.set_Item(key:  GameConnect.专丁丄丛丟且上且世, value:  val_4);
        val_2.set_Item(key:  GameConnect.丕丈丕丕一丞世丆不, value:  0);
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  1);
        val_2.set_Item(key:  GameConnect.丈且世丗七丅丂且丌, value:  val_2.丁丝三丝一丂丕丑一() + 1);
        val_2.set_Item(key:  GameConnect.丑七七七专丐丂三丆, value:  0);
        val_2.set_Item(key:  GameConnect.专丕东七东丏丕丏丒, value:  0);
        if(this.七业丕且万丝丛丝与 != false)
        {
                val_12 = 0;
        }
        else
        {
                val_12 = 2 - (val_2.丁丝三丝一丂丕丑一() & 1);
        }
        
        val_2.set_Item(key:  GameConnect.一丘丂丄上丅丁丙丝, value:  val_12);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 东丑丆丂丟丞东且丗()
    {
        ExitGames.Client.Photon.Hashtable val_4;
        var val_5;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_4 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_5 = null;
        val_5 = null;
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  3);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 丌一丐且下世下三上()
    {
        this.丄丗万丞丕丛丄丈丙();
    }
    private void 丛丐万且丒丞丟丝丐()
    {
        if(this.plantedBomb == null)
        {
            
        }
    
    }
    private void 丄丗万丞丕丛丄丈丙()
    {
        this.丛丐万且丒丞丟丝丐();
        this.七下丗丏丌丞万丅万();
        业丐下上丄东丏且不 val_1 = this.下不丆丅三丟丛丑丙;
        val_1 = val_1 - 1;
        if(val_1 <= 1)
        {
                this.zoneA.丏丘且丈丝丙丄丈专();
            this.zoneB.丏丘且丈丝丙丄丈专();
        }
        
        this.世七下东丕丐东丈丈();
        this.丙且丅丁丏与丙丛且 = 0;
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        bool val_1 = GameConnect.丒丗丁丙丗丄丙不丐();
    }
    private void 世七下东丕丐东丈丈()
    {
        var val_10;
        var val_11;
        var val_12;
        if(this.plantedBomb == 0)
        {
                return;
        }
        
        bool val_3 = this.plantedBomb.gameObject.activeSelf;
        if(this.下不丆丅三丟丛丑丙 == 1)
        {
                if(val_3 == true)
        {
                return;
        }
        
            val_10 = null;
            val_10 = null;
            object val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.专丁丄丛丟且上且世];
            this.plantedBomb.transform.position = new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B};
            val_11 = this.plantedBomb.gameObject;
            val_12 = 1;
        }
        else
        {
                if(val_3 == false)
        {
                return;
        }
        
            val_11 = this.plantedBomb.gameObject;
            val_12 = 0;
        }
        
        val_11.SetActive(value:  false);
    }
    private void 丁专丑丒丘丐丁专不()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_8 = 0;
        val_9 = 0;
        val_10 = 0;
        goto label_4;
        label_22:
        val_11 = null;
        val_11 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() != 0)
        {
                val_12 = null;
            val_12 = null;
            if(Item[0].丘丑丅三丆丑丌且丝() == 1)
        {
                val_10 = 1;
        }
        else
        {
                val_9 = 1;
        }
        
        }
        
        val_8 = 1;
        label_4:
        val_13 = null;
        val_13 = null;
        if(val_8 < Count)
        {
            goto label_22;
        }
        
        if((val_9 != 0) && (val_10 != 0))
        {
                return;
        }
        
        this.丄丝丁丄丌丅丝专万(丗三上丞丆七不且七:  (val_9 != 0) ? (1 + 1) : 1);
    }
    public static int get_teamOnePlayersAlive()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<Player_move_c>(丑东与丅丐丅丂丞业:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙)) != false)
        {
                val_7 = 0;
            return (int)(0.丐丏七丌丕丗业且上().丘丑丅三丆丑丌且丝() == 1) ? (val_7 + 1) : (val_7);
        }
        
        val_8 = null;
        val_8 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_7 = 0;
        goto label_10;
        label_13:
        label_10:
        if(((-353652664) & 1) != 0)
        {
            goto label_13;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)(0.丐丏七丌丕丗业且上().丘丑丅三丆丑丌且丝() == 1) ? (val_7 + 1) : (val_7);
    }
    public static int get_teamTwoPlayersAlive()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<Player_move_c>(丑东与丅丐丅丂丞业:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙)) != false)
        {
                val_7 = 0;
            return (int)(0.丐丏七丌丕丗业且上().丘丑丅三丆丑丌且丝() == 2) ? (val_7 + 1) : (val_7);
        }
        
        val_8 = null;
        val_8 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_7 = 0;
        goto label_10;
        label_13:
        label_10:
        if(((-353532472) & 1) != 0)
        {
            goto label_13;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)(0.丐丏七丌丕丗业且上().丘丑丅三丆丑丌且丝() == 2) ? (val_7 + 1) : (val_7);
    }
    private int 万三丈丐且丒丈丒丑()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<Player_move_c>(丑东与丅丐丅丂丞业:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙)) != false)
        {
                return 0;
        }
        
        val_3 = null;
        val_3 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙 != null)
        {
                return 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
        }
        
        return 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
    }
    private void 丁一万丆与丝丑丞业()
    {
        var val_9;
        InGameGUI val_10;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丄丗丆丆且且万一上 != false)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.丙丈丌下丒专丝丄七(且且与丛七丗上丛三:  true);
        this.丄丗丆丆且且万一上 = true;
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        val_9 = gameObject;
        val_9.SetActive(value:  false);
        val_10 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_10 == null)
        {
                return;
        }
        
        if(null != 0)
        {
                val_9 = InGameGUIPart_PlantTheBomb.__il2cppRuntimeField_interopData.gameObject;
            val_9.SetActive(value:  false);
            val_10 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_10 == null)
        {
                return;
        }
        
        }
        
        if(null == 0)
        {
                return;
        }
        
        下丅丛丝万丂与丞七(丛与丙丒丒下丌丟且:  false, 业丝丝丛丕丅丈丘不:  true);
    }
    private void 丁丂下丙丐东丄三丞()
    {
        InGameGUI val_9;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丄丗丆丆且且万一上 == false)
        {
                return;
        }
        
        if(this.与丛丂一丘上三丘世 == true)
        {
                return;
        }
        
        bool val_9 = this.丟丈专丆丁丑万与与;
        val_9 = val_9 + 7;
        var val_10 = ~val_9;
        val_10 = val_10 & 7;
        if(val_10 != 0)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.丙丈丌下丒专丝丄七(且且与丛七丗上丛三:  false);
        this.丄丗丆丆且且万一上 = false;
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        gameObject.SetActive(value:  true);
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_27;
        }
        
        if(null == 0)
        {
            goto label_25;
        }
        
        InGameGUIPart_PlantTheBomb.__il2cppRuntimeField_interopData.gameObject.SetActive(value:  true);
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_27;
        }
        
        label_25:
        gameObject.SetActive(value:  true);
        return;
        label_27:
    }
    public Player_move_c get_BombActorPlayerMoveC()
    {
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 0;
        }
        
        val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_9.ContainsKey(key:  GameConnect.丟丈丑丒丑专丄下丅)) == false)
        {
                return 0;
        }
        
        val_11 = null;
        val_11 = null;
        return 丘丛丞且一丅丁丏丐.丅丞万万三丛且专丁(丞丅上丏丂且下丅与:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅]));
    }
    private void 丅丈丑丈丄下七丄丟()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowAllyDefuseBomb();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowAllyDefuseBomb();
    }
    private void 丏上丗丄不丑丁丅与()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowEnemyDefuseBomb();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowEnemyDefuseBomb();
    }
    private void 丈三业丂丂丌丁万丘()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowEnemiesKilled();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowEnemiesKilled();
    }
    private void 万且丑丁东丐丅丕东()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowMyTeamKilled();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowMyTeamKilled();
    }
    private void 丘丄一三丒丐上丒丙()
    {
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
    }
    private void Update()
    {
        NetworkStartTableNGUIController val_58;
        string val_59;
        var val_60;
        double val_61;
        byte val_62;
        var val_63;
        世丑丗三丙丒丈丒丏 val_64;
        byte val_65;
        val_58 = this;
        val_59 = 1152921504848912384;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
            goto label_20;
        }
        
        if(this.三丘专东丐下丂三丑 == 2)
        {
            goto label_6;
        }
        
        if(this.三丘专东丐下丂三丑 != 1)
        {
            goto label_18;
        }
        
        double val_2 = this.goTimer;
        if(val_2 >= 0)
        {
            goto label_6;
        }
        
        val_60 = mem[null + 408 + 8];
        if(val_2 != 0f)
        {
                val_60 = mem[null + 424 + 8];
        }
        
        this.丁丂下丙丐东丄三丞();
        double val_3 = this.goTimer;
        if(((val_3 >= 0) || (val_3 >= 0)) || (null != 0))
        {
            goto label_18;
        }
        
        goto label_18;
        label_6:
        this.丁一万丆与丝丑丞业();
        label_18:
        val_61 = this.丞丛上丂丅丅丞世丁;
        if(val_61 > 0f)
        {
            goto label_19;
        }
        
        val_61 = this.丌一丞丝七丏丑丏世;
        if(val_61 <= 0f)
        {
            goto label_20;
        }
        
        label_19:
        this.丁一万丆与丝丑丞业();
        label_20:
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null) && (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().业丆丛丁丈丌丘丛丅() != false))
        {
                if(this.丞丛上丂丅丅丞世丁 > 0f)
        {
                int val_7 = PlantTheBombController.teamOnePlayersAlive;
            if(val_7 == 0)
        {
                int val_8 = val_7.下七东业丘三丑丝丘();
            int val_58 = this.丞一七丐东世丌专丐;
            val_58 = val_58 - 1;
            if(val_8 >= val_58)
        {
                val_8.丘丄一三丒丐上丒丙();
        }
        
        }
        
            int val_9 = PlantTheBombController.teamTwoPlayersAlive;
            if(val_9 == 0)
        {
                int val_10 = val_9.丅三七一丘七丒丙下();
            int val_59 = this.丞一七丐东世丌专丐;
            val_59 = val_59 - 1;
            if(val_10 >= val_59)
        {
                val_10.丘丄一三丒丐上丒丙();
        }
        
        }
        
        }
        
            val_61 = this.丌一丞丝七丏丑丏世;
            if(val_61 > 0f)
        {
                val_62 = this.丆七一世且丏丆专丏;
            if(val_62 == 1)
        {
                int val_11 = val_10.下七东业丘三丑丝丘();
            int val_60 = this.丞一七丐东世丌专丐;
            val_60 = val_60 - 1;
            if(val_11 >= val_60)
        {
                val_11.丘丄一三丒丐上丒丙();
        }
        
            val_62 = this.丆七一世且丏丆专丏;
        }
        
            if(val_62 == 2)
        {
                int val_12 = val_11.丅三七一丘七丒丙下();
            int val_61 = this.丞一七丐东世丌专丐;
            val_61 = val_61 - 1;
            if(val_12 >= val_61)
        {
                val_12.丘丄一三丒丐上丒丙();
        }
        
        }
        
        }
        
        }
        
        if((丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > this.丌专丑丑丛丐丕丂丑) && (this.丌专丑丑丛丐丕丂丑 > 0f))
        {
                this.丗万丁丝世丛与专世();
            this.丌专丑丑丛丐丕丂丑 = 0;
        }
        
        if((丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > this.丞丏丕丄丟丕丈丞丈) && (this.丞丏丕丄丟丕丈丞丈 > 0f))
        {
                this.丕三丏专丐专世丂丆();
            this.丞丏丕丄丟丕丈丞丈 = 0;
        }
        
        if((丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > this.丌一丞丝七丏丑丏世) && (this.丌一丞丝七丏丑丏世 > 0f))
        {
                this.丌一丞丝七丏丑丏世 = 0;
            this.丛丆专七丛且丈丈万(丅世丗与丈万丆与三:  5, 丕丗丞丞丑丘丛丂且:  (this.丆七一世且丏丆专丏 == 1) ? (1 + 1) : 1);
        }
        
        if((丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() <= this.丞丛上丂丅丅丞世丁) || (this.丞丛上丂丅丅丞世丁 <= 0f))
        {
            goto label_61;
        }
        
        this.丞丛上丂丅丅丞世丁 = 0;
        if(this.下不丆丅三丟丛丑丙 == 1)
        {
            goto label_54;
        }
        
        if(this.下不丆丅三丟丛丑丙 != 0)
        {
            goto label_61;
        }
        
        var val_19 = (this.丗一专东丆不且下丒() == 1) ? (1 + 1) : 1;
        val_64 = 1;
        goto label_59;
        label_54:
        val_65 = this.丆七一世且丏丆专丏;
        if(val_65 != 1)
        {
            goto label_57;
        }
        
        int val_20 = this.丗一专东丆不且下丒();
        if(val_20 != 2)
        {
            goto label_58;
        }
        
        val_64 = 1;
        val_63 = 1;
        goto label_59;
        label_58:
        val_65 = this.丆七一世且丏丆专丏;
        label_57:
        if((val_65 != 2) || (val_20.丗一专东丆不且下丒() != 1))
        {
            goto label_61;
        }
        
        val_64 = 1;
        val_63 = 2;
        label_59:
        this.丛丆专七丛且丈丈万(丅世丗与丈万丆与三:  val_64, 丕丗丞丞丑丘丛丂且:  2);
        label_61:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                this.三丘专东丐下丂三丑 = 5;
        }
        
        this.七丛不丞丞下丐且七();
        if(this.三丘专东丐下丂三丑 > 3)
        {
                return;
        }
        
        var val_62 = 106039848 + (this.三丘专东丐下丂三丑) << 2;
        val_62 = val_62 + 106039848;
        goto (106039848 + (this.三丘专东丐下丂三丑) << 2 + 106039848);
    }
    private void LateUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  21)) != false)
        {
                UnityEngine.Debug.LogError(message:  "myLocalGameStatus = "("myLocalGameStatus = ") + this.三丘专东丐下丂三丑);
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  22)) == false)
        {
                return;
        }
        
        this.丛丆专七丛且丈丈万(丅世丗与丈万丆与三:  2, 丕丗丞丞丑丘丛丂且:  1);
    }
    private void 丄丝丁丄丌丅丝专万(int 丗三上丞丆七不且七)
    {
        ExitGames.Client.Photon.Hashtable val_10;
        int val_11;
        var val_12;
        int val_13;
        val_11 = 丗三上丞丆七不且七;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_10 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_12 = null;
        val_12 = null;
        double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_3 = val_3 + this.世七丈丕丑上丟丘丟;
        val_3 = val_3 + 6.8;
        val_2.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  val_3);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_2.set_Item(key:  GameConnect.专丁丄丛丟且上且世, value:  val_4);
        val_2.set_Item(key:  GameConnect.丕丈丕丕一丞世丆不, value:  0);
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  4);
        val_2.set_Item(key:  GameConnect.丕丅丙专丄丙东丘三, value:  val_11);
        val_2.set_Item(key:  GameConnect.丈且世丗七丅丂且丌, value:  val_2.丁丝三丝一丂丕丑一() + 1);
        if(this.七业丕且万丝丛丝与 != false)
        {
                val_13 = 0;
        }
        else
        {
                val_13 = 2 - (val_2.丁丝三丝一丂丕丑一() & 1);
        }
        
        val_11 = val_13;
        val_2.set_Item(key:  GameConnect.一丘丂丄上丅丁丙丝, value:  val_13);
        世丁与丕丗丟丒丆上 val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_9.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_9.丘丄一三丒丐上丒丙();
    }
    private void 业丌丛上丏万丈丒丒()
    {
        var val_9;
        var val_10;
        val_9 = null;
        val_9 = null;
        int val_1 = 丘丑丅三丆丑丌且丝();
        val_10 = 1;
        if(PlantTheBombController.teamOnePlayersAlive != 0)
        {
                int val_6 = PlantTheBombController.teamTwoPlayersAlive;
            val_10 = ((val_6 == 0) ? 1 : 0) << 1;
        }
        
        if(((val_1 == 1) ? ((val_1 == 1) ? 1 : 0) : (val_1)) == val_10)
        {
                val_6.万且丑丁东丐丅丕东();
        }
        else
        {
                if(((val_1 == 1) ? (val_10 + 1) : (val_10)) == val_10)
        {
                val_6.丈三业丂丂丌丁万丘();
        }
        
        }
        
        this.与丛丂一丘上三丘世 = true;
    }
    private void 丒丝丕丝三丈丛丈丆()
    {
        var val_8;
        byte val_9;
        if(this.丞丛上丂丅丅丞世丁 > 0f)
        {
                return;
        }
        
        if(this.goTimer > 0f)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<Player_move_c>(丑东与丅丐丅丂丞业:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙)) == true)
        {
                return;
        }
        
        if(this.世丄东丄丕七丟不丗 == false)
        {
                return;
        }
        
        if(this.与丛丂一丘上三丘世 != false)
        {
                return;
        }
        
        if(this.下不丆丅三丟丛丑丙 == 1)
        {
            goto label_10;
        }
        
        if(this.下不丆丅三丟丛丑丙 != 0)
        {
                return;
        }
        
        if(PlantTheBombController.teamOnePlayersAlive == 0)
        {
            goto label_16;
        }
        
        if(PlantTheBombController.teamTwoPlayersAlive != 0)
        {
                return;
        }
        
        goto label_16;
        label_10:
        val_9 = this.丆七一世且丏丆专丏;
        if(val_9 != 1)
        {
            goto label_15;
        }
        
        if(PlantTheBombController.teamTwoPlayersAlive == 0)
        {
            goto label_16;
        }
        
        val_9 = this.丆七一世且丏丆专丏;
        label_15:
        if(val_9 != 2)
        {
                return;
        }
        
        if(PlantTheBombController.teamOnePlayersAlive != 0)
        {
                return;
        }
        
        label_16:
        double val_7 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_7 = val_7 + this.七丙丟万丏与丆丆丂;
        this.丞丛上丂丅丅丞世丁 = val_7;
        this.业丌丛上丏万丈丒丒();
        this.丞丕且丘七一丛丞上();
    }
    private void 丞丕且丘七一丛丞上()
    {
        int val_1 = PlantTheBombController.teamOnePlayersAlive;
        if(val_1 == 0)
        {
                val_1.且丌不与丐丕丏丂东(丙业与丙丗丝不丈东:  1);
        }
        
        int val_2 = PlantTheBombController.teamTwoPlayersAlive;
        if(val_2 != 0)
        {
                return;
        }
        
        val_2.且丌不与丐丕丏丂东(丙业与丙丗丝不丈东:  2);
    }
    private void 上世丏丗万丘丝三丁()
    {
        世丑丗三丙丒丈丒丏 val_5;
        var val_6;
        var val_7;
        if(this.七业丕且万丝丛丝与 != false)
        {
                val_5 = 4;
            val_6 = 0;
        }
        else
        {
                val_7 = null;
            val_7 = null;
            int val_1 = 丘丑丅三丆丑丌且丝();
            val_5 = 3;
        }
        
        this.丛丆专七丛且丈丈万(丅世丗与丈万丆与三:  val_5, 丕丗丞丞丑丘丛丂且:  (this.isMyTeamBomberRole != true) ? ((val_1 == 1) ? (1 + 1) : 1) : (val_1));
    }
    private void 丟丈丐专丁专万一万()
    {
        this.丛丆专七丛且丈丈万(丅世丗与丈万丆与三:  2, 丕丗丞丞丑丘丛丂且:  this.丆七一世且丏丆专丏);
    }
    private void 不与丝丛丆世丝丝丂()
    {
        this.丛丆专七丛且丈丈万(丅世丗与丈万丆与三:  5, 丕丗丞丞丑丘丛丂且:  (this.丆七一世且丏丆专丏 == 1) ? (1 + 1) : 1);
    }
    private void 丟下丘丕与不丈丒丈()
    {
        double val_1 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_1 = val_1 + this.东丆与且丏丐丙且七;
        this.一且且万丁丌丛业丆 = val_1;
    }
    internal bool 丟不丏丈丗丘丕丐丒()
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (bool)val_11;
        }
        
        val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_12 = null;
        val_12 = null;
        if((val_10.ContainsKey(key:  GameConnect.丕丈丕丕一丞世丆不)) != false)
        {
                val_13 = null;
            val_13 = null;
            val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丕丈丕丕一丞世丆不];
            var val_9 = ((System.Byte.Parse(s:  val_10)) != 255) ? 1 : 0;
            return (bool)val_11;
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    private bool 万丑丁丁上丅世丟丁()
    {
        if(this.zoneA.东丟下专七且与一三() != false)
        {
                return true;
        }
        
        if(this.zoneB != null)
        {
                return this.zoneB.东丟下专七且与一三();
        }
        
        return this.zoneB.东丟下专七且与一三();
    }
    private int 丅丗业丞丄丞丏丁且()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        if(this.zoneA.东丟下专七且与一三() != false)
        {
                val_6 = this.zoneA.丛丟丗不丝世丝万丕();
        }
        else
        {
                val_6 = 0;
        }
        
        if(this.zoneB.东丟下专七且与一三() != false)
        {
                val_7 = this.zoneB;
            int val_4 = val_7.丛丟丗不丝世丝万丕();
        }
        else
        {
                val_7 = 0;
        }
        
        if(val_6 == 1)
        {
            goto label_8;
        }
        
        if(val_7 == 1)
        {
            goto label_9;
        }
        
        val_8 = 0;
        if((val_6 == 0) || (val_7 == 0))
        {
            goto label_13;
        }
        
        var val_5 = (val_6 != val_7) ? 0 : (val_6);
        return (int)val_9;
        label_8:
        val_8 = val_7;
        goto label_13;
        label_9:
        val_8 = val_6;
        label_13:
        val_9 = val_8;
        return (int)val_9;
    }
    private void 与丑七丗丂丅一不丁(bool 上丈丗丏丞丏世一上 = False)
    {
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                上丈丗丏丞丏世一上 = 上丈丗丏丞丏世一上;
            与丑七丗丂丅一不丁(上丈丗丏丞丏世一上:  上丈丗丏丞丏世一上);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem == 0)
        {
                return;
        }
        
        与丑七丗丂丅一不丁(上丈丗丏丞丏世一上:  上丈丗丏丞丏世一上);
    }
    private void 专丛与三业丗丝三丄()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowAlliesSettingBomb();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowAlliesSettingBomb();
    }
    private void 丘不丙丘东不丗丄丄()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowEnemiesSettingBomb();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowEnemiesSettingBomb();
    }
    private void 丟三三不丛七丗万丏()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowAlliesDefusingBomb();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowAlliesDefusingBomb();
    }
    private void 不业丗丂丏世丑丁丆()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowEnemiesDefusingBombDontLetThem();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowEnemiesDefusingBombDontLetThem();
    }
    private void 丗下丏丞丒丘丄丅丕()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowBombIsPlacedDefuseIt();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowBombIsPlacedDefuseIt();
    }
    private void 丄世七万丌丑丐丟世()
    {
        NetworkStartTableNGUIController val_3;
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                ShowBombIsPlacedProtectIt();
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowBombIsPlacedProtectIt();
    }
    private void 与丂七丅丂丞世丐业(PlantTheBombController.世丑丗三丙丒丈丒丏 且丅丕三不丛专一丘, int 丕丗丞丞丑丘丛丂且)
    {
        NetworkStartTableNGUIController val_3;
        if(((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0)) && (null != 0))
        {
                ShowResults(且丅丕三不丛专一丘:  且丅丕三不丛专一丘, 丕丗丞丞丑丘丛丂且:  丕丗丞丞丑丘丛丂且);
        }
        
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 1288];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.plantTheBombNotificationsSystem;
        if(val_3 == 0)
        {
                return;
        }
        
        ShowResults(且丅丕三不丛专一丘:  且丅丕三不丛专一丘, 丕丗丞丞丑丘丛丂且:  丕丗丞丞丑丘丛丂且);
    }
    private void 丟丅丑且一东不上丒(PlantTheBombController.丈丙丁丂丈丞丝丏专 且丆不一丁丂七丅丏)
    {
        var val_1;
        if(this.丙且丅丁丏与丙丛且 != 且丆不一丁丂七丅丏)
        {
            goto label_0;
        }
        
        if(且丆不一丁丂七丅丏 == 0)
        {
            goto label_8;
        }
        
        val_1 = 0;
        goto label_2;
        label_0:
        if(且丆不一丁丂七丅丏 > 3)
        {
            goto label_8;
        }
        
        var val_1 = 106039884 + (且丆不一丁丂七丅丏) << 2;
        val_1 = val_1 + 106039884;
        goto (106039884 + (且丆不一丁丂七丅丏) << 2 + 106039884);
        label_2:
        this.与丑七丗丂丅一不丁(上丈丗丏丞丏世一上:  true);
        label_8:
        this.丙且丅丁丏与丙丛且 = 且丆不一丁丂七丅丏;
    }
    private void 不丂丕丅丌且下且东()
    {
        var val_20;
        var val_21;
        InGameGUI val_22;
        var val_23;
        var val_24;
        InGameGUI val_25;
        var val_26;
        var val_27;
        var val_28;
        PlantingZone val_1 = this.七丒丏丑丛丐丑丙丟();
        if((this.isMyTeamBomberRole == false) || ((val_1 == 0) || (val_1.丅丆与丄丂三丑丄专 == false)))
        {
            goto label_6;
        }
        
        val_20 = null;
        val_20 = null;
        if(Pauser.且三丝三七七丐丁丁.丟三东与三丒丛下东() == false)
        {
            goto label_10;
        }
        
        label_6:
        if((InGameGUI.丙丞专丌丁丞与不丐 == 0) || (InGameGUI.丙丞专丌丁丞与不丐.丕丏丕丟丗丝丂业丏 == 0))
        {
            goto label_17;
        }
        
        if(null != 0)
        {
            goto label_20;
        }
        
        goto label_20;
        label_17:
        val_21 = 0;
        label_20:
        val_22 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_21 == 0)
        {
            goto label_21;
        }
        
        if((val_22 != null) && (null != 0))
        {
                丗丐业万与丝丒三且(丙业与丙丗丝不丈东:  false, 不专丑一下且不万七:  true);
            val_22 = InGameGUI.丙丞专丌丁丞与不丐;
        }
        
        if(val_22 == 0)
        {
            goto label_35;
        }
        
        val_22 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 888];
        val_22 = InGameGUI.丙丞专丌丁丞与不丐.丕丏丕丟丗丝丂业丏;
        if(val_22 == 0)
        {
            goto label_35;
        }
        
        val_22 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 888];
        val_22 = InGameGUI.丙丞专丌丁丞与不丐.丕丏丕丟丗丝丂业丏;
        typeof(InGameGUIPart_PlantTheBomb).__il2cppRuntimeField_A0 = 0;
        goto label_35;
        label_21:
        if((val_22 != null) && (null != 0))
        {
                丗丐业万与丝丒三且(丙业与丙丗丝不丈东:  false, 不专丑一下且不万七:  false);
        }
        
        label_35:
        if(this.isMyTeamBomberRole == false)
        {
            goto label_36;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
            goto label_49;
        }
        
        val_22 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 888];
        val_22 = InGameGUI.丙丞专丌丁丞与不丐.丕丏丕丟丗丝丂业丏;
        if(null == 0)
        {
            goto label_49;
        }
        
        if(this.丄丗丆丆且且万一上 == false)
        {
            goto label_39;
        }
        
        val_23 = 0;
        goto label_54;
        label_36:
        if((InGameGUI.丙丞专丌丁丞与不丐 == null) || (null == 0))
        {
            goto label_49;
        }
        
        val_24 = 0;
        var val_10 = (this.丄丗丆丆且且万一上 == false) ? 1 : 0;
        goto label_50;
        label_10:
        val_22 = 1152921505219145728;
        val_25 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_25 == null)
        {
            goto label_49;
        }
        
        if(null == 0)
        {
            goto label_45;
        }
        
        丗丐业万与丝丒三且(丙业与丙丗丝不丈东:  true, 不专丑一下且不万七:  false);
        val_25 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_25 == null)
        {
            goto label_49;
        }
        
        label_45:
        if(null == 0)
        {
            goto label_47;
        }
        
        丒丝丂业丙一丟丄万(业丂万丈丝七一与专:  val_1);
        val_25 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_25 == null)
        {
            goto label_49;
        }
        
        label_47:
        if(null == 0)
        {
            goto label_49;
        }
        
        val_24 = 1;
        val_23 = 0;
        goto label_50;
        label_39:
        if(val_1 == 0)
        {
                val_23 = 1;
        }
        
        label_54:
        val_24 = 1;
        label_50:
        下丅丛丝万丂与丞七(丛与丙丒丒下丌丟且:  (val_1.丅丆与丄丂三丑丄专 == true) ? 1 : 0, 业丝丝丛丕丅丈丘不:  true);
        label_49:
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                丑下丌丆与丒丕丄丞(丙业与丙丗丝不丈东:  false);
        }
        
        if(this.万丑丁丁上丅世丟丁() == false)
        {
            goto label_64;
        }
        
        val_22 = this.丅丗业丞丄丞丏丁且();
        if((val_1 == 0) || (val_1.丆丌专丐丌丛丞丝丈 == false))
        {
            goto label_63;
        }
        
        if(this.七业丕且万丝丛丝与 == false)
        {
            goto label_64;
        }
        
        val_26 = null;
        val_26 = null;
        var val_17 = (val_22 == 丘丑丅三丆丑丌且丝()) ? 0 : 2;
        goto label_70;
        label_64:
        val_27 = 0;
        goto label_70;
        label_63:
        val_28 = null;
        val_28 = null;
        label_70:
        this.丟丅丑且一东不上丒(且丆不一丁丂七丅丏:  (val_22 != 丘丑丅三丆丑丌且丝()) ? (1 + 1) : 1);
    }
    private void 业丑丞丈专丛一丟丌()
    {
        var val_8;
        InGameGUI val_9;
        var val_10;
        InGameGUI val_11;
        if((this.丛与丘丕丞丁世丆丕() == false) || ((this.plantedBomb.世三丕丒丗丅丁一丙() == false) || (this.plantedBomb.丙丛丁丘万丌下丙丁 == true)))
        {
            goto label_5;
        }
        
        val_8 = null;
        val_8 = null;
        if(Pauser.且三丝三七七丐丁丁.丟三东与三丒丛下东() == false)
        {
            goto label_9;
        }
        
        label_5:
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_28;
        }
        
        if(null == 0)
        {
            goto label_11;
        }
        
        丑下丌丆与丒丕丄丞(丙业与丙丗丝不丈东:  false);
        val_9 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_9 == null)
        {
            goto label_28;
        }
        
        label_11:
        if(null == 0)
        {
            goto label_28;
        }
        
        if(this.丛与丘丕丞丁世丆丕() != false)
        {
                var val_5 = (this.plantedBomb.丙丛丁丘万丌下丙丁 != true) ? 1 : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        label_29:
        下丅丛丝万丂与丞七(丛与丙丒丒下丌丟且:  false, 业丝丝丛丕丅丈丘不:  false);
        label_28:
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                丗丐业万与丝丒三且(丙业与丙丗丝不丈东:  false, 不专丑一下且不万七:  false);
        }
        
        bool val_6 = this.plantedBomb.东丟下专七且与一三();
        if(val_6 != false)
        {
                this.丟丅丑且一东不上丒(且丆不一丁丂七丅丏:  (this.plantedBomb.世丟丂三七丕丗丌丛 == true) ? 0 : 3);
            return;
        }
        
        if(this.丙且丅丁丏与丙丛且 != 0)
        {
                val_6.与丑七丗丂丅一不丁(上丈丗丏丞丏世一上:  true);
        }
        
        this.丙且丅丁丏与丙丛且 = 0;
        return;
        label_9:
        val_11 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_11 == null)
        {
            goto label_28;
        }
        
        if(null == 0)
        {
            goto label_24;
        }
        
        丑下丌丆与丒丕丄丞(丙业与丙丗丝不丈东:  true);
        val_11 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_11 == null)
        {
            goto label_28;
        }
        
        label_24:
        if(null == 0)
        {
            goto label_26;
        }
        
        丕丆不丁与专丙上丝(业丝丝丛丕丅丈丘不:  this.plantedBomb);
        val_11 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_11 == null)
        {
            goto label_28;
        }
        
        label_26:
        if(null == 0)
        {
            goto label_28;
        }
        
        goto label_29;
    }
    private void 与丘且万东东丐业上()
    {
        InGameGUI val_1 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_1 == null)
        {
            goto label_6;
        }
        
        if(null == 0)
        {
            goto label_2;
        }
        
        丗丐业万与丝丒三且(丙业与丙丗丝不丈东:  false, 不专丑一下且不万七:  false);
        val_1 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_1 == null)
        {
            goto label_6;
        }
        
        label_2:
        if(null == 0)
        {
            goto label_4;
        }
        
        丑下丌丆与丒丕丄丞(丙业与丙丗丝不丈东:  false);
        val_1 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_1 == null)
        {
            goto label_6;
        }
        
        label_4:
        if(null != 0)
        {
                下丅丛丝万丂与丞七(丛与丙丒丒下丌丟且:  false, 业丝丝丛丕丅丈丘不:  true);
        }
        
        label_6:
        if(this.丙且丅丁丏与丙丛且 != 0)
        {
                与丑七丗丂丅一不丁(上丈丗丏丞丏世一上:  true);
        }
        
        this.丙且丅丁丏与丙丛且 = 0;
    }
    private void 七丛不丞丞下丐且七()
    {
        if((this.下不丆丅三丟丛丑丙 - 2) < 2)
        {
            goto label_0;
        }
        
        if(this.下不丆丅三丟丛丑丙 == 1)
        {
            goto label_1;
        }
        
        if(this.下不丆丅三丟丛丑丙 != 0)
        {
                return;
        }
        
        this.不丂丕丅丌且下且东();
        return;
        label_0:
        this.与丘且万东东丐业上();
        return;
        label_1:
        this.业丑丞丈专丛一丟丌();
    }
    private PlantingZone 七丒丏丑丛丐丑丙丟()
    {
        var val_5;
        if(this.zoneA.世三丕丒丗丅丁一丙() != true)
        {
                val_5 = 0;
            if(this.zoneB.世三丕丒丗丅丁一丙() == false)
        {
                return (PlantingZone)val_5;
        }
        
        }
        
        val_5 = mem[val_3 != true ? 1152921538617684968 : this.zoneB];
        val_5 = (this.zoneA.世三丕丒丗丅丁一丙() != true) ? (this.zoneA) : this.zoneB;
        return (PlantingZone)val_5;
    }
    internal PlantingZone 丌且丆丆东丐专万七()
    {
        var val_17;
        PlantingZone val_18;
        val_17 = this;
        val_18 = 0;
        if(this.zoneA == 0)
        {
                return (PlantingZone)val_18;
        }
        
        val_18 = 0;
        if(this.zoneB == 0)
        {
                return (PlantingZone)val_18;
        }
        
        val_18 = 0;
        if(this.plantedBomb == 0)
        {
                return (PlantingZone)val_18;
        }
        
        if(this.zoneA.丆世东丝丏丘上丂丐 != false)
        {
                val_18 = this.zoneA;
            return (PlantingZone)val_18;
        }
        
        if(this.zoneB.丆世东丝丏丘上丂丐 != false)
        {
                val_18 = this.zoneB;
            return (PlantingZone)val_18;
        }
        
        UnityEngine.Vector3 val_5 = this.zoneA.transform.position;
        UnityEngine.Vector3 val_7 = this.plantedBomb.transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_10 = this.zoneB.transform.position;
        UnityEngine.Vector3 val_12 = this.plantedBomb.transform.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_18 = mem[val_8.x < 0 ? 1152921538617850216 : 1152921538617850224];
        val_18 = (val_8.x < 0) ? (this.zoneA) : (this.zoneB);
        val_17 = this.plantedBomb.gameObject;
        if(val_17.activeSelf == false)
        {
                return (PlantingZone)val_18;
        }
        
        mem2[0] = 1;
        return (PlantingZone)val_18;
    }
    internal float 丌丈丏且丄丏丒丒丂()
    {
        return (float)(float)this.上丘丒丁七丒丂丘丘;
    }
    internal float 下上不丘与丄丕丄且()
    {
        return (float)(float)this.丂丟丑丌丕丌丙丙丘;
    }
    internal float 专丙丅丏丆丂且三业(float 丛东丏丙万三上万七, bool 丒专丒世与丝丞业七 = False)
    {
        丛东丏丙万三上万七 = 丛东丏丙万三上万七 / ((float)(丒专丒世与丝丞业七 != true) ? this.丂丟丑丌丕丌丙丙丘 : this.上丘丒丁七丒丂丘丘);
        if(丛东丏丙万三上万七 < 0)
        {
                return 0f;
        }
        
        return 丛东丏丙万三上万七;
    }
    internal void 七丑与业丞业丂丘不()
    {
        if(this.plantedBomb == 0)
        {
                return;
        }
        
        if(this.plantedBomb.世丟丂三七丕丗丌丛 == true)
        {
                return;
        }
        
        this.plantedBomb.业东丅一丝丐东丁丐();
        this = this.photonView;
        object[] val_3 = new object[1];
        val_3[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  232, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    internal void 丐丌与与东丛丕丕丈()
    {
        object[] val_2 = new object[1];
        int val_4 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_4 != 0)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_4 == 0)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_2[0] = val_4;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  233, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        且丞丘与丕丌七丑丝();
    }
    internal void 东丆丄下丑业与丘七()
    {
        ExitGames.Client.Photon.Hashtable val_6;
        var val_7;
        val_6 = this;
        if(this.下不丆丅三丟丛丑丙 != 1)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_1 = null;
        val_6 = val_1;
        val_1 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        val_1.set_Item(key:  GameConnect.丕丈丕丕一丞世丆不, value:  2);
        val_1.set_Item(key:  GameConnect.丟丈丑丒丑专丄下丅, value:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁());
        ExitGames.Client.Photon.Hashtable val_4 = new ExitGames.Client.Photon.Hashtable();
        val_4.set_Item(key:  GameConnect.丕丈丕丕一丞世丆不, value:  1);
        val_4.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  1);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  val_4, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 丛东与丘丆不丏丌专()
    {
        var val_9;
        PlantingZone val_10 = this.七丒丏丑丛丐丑丙丟();
        if(val_10 == 0)
        {
                return;
        }
        
        if(val_1.丆丌专丐丌丛丞丝丈 == true)
        {
                return;
        }
        
        val_10.丝丙丌丟丄丝下业专();
        val_9 = this.photonView;
        object[] val_4 = new object[2];
        val_4[0] = (((UnityEngine.Object.op_Equality(x:  val_10 = this.七丒丏丑丛丐丑丙丟(), y:  this.zoneA)) & true) != 0) ? (1 + 1) : 1;
        val_10 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        val_4[1] = val_10;
        val_9.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  230, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
    }
    internal void 三丛丁万丟东东丅万(PlantingZone 业丂万丈丝七一与专)
    {
        object[] val_2 = new object[2];
        object val_4 = (((UnityEngine.Object.op_Equality(x:  业丂万丈丝七一与专, y:  this.zoneA)) & true) != 0) ? (1 + 1) : 1;
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_4 == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = val_4;
        val_2[1] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  231, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
        if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                return;
        }
        
        if(null == 0)
        {
                return;
        }
        
        不丌不且与专丆丂世();
    }
    internal void 丅三丐且丕上丞丆丞()
    {
        var val_11;
        var val_12;
        var val_13;
        val_11 = this;
        if(this.下不丆丅三丟丛丑丙 != 0)
        {
                return;
        }
        
        if((InGameGUI.丙丞专丌丁丞与不丐 != null) && (null != 0))
        {
                一且与丌且上下下七();
        }
        
        val_12 = null;
        val_12 = null;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_13 = null;
        val_13 = null;
        UnityEngine.Vector3 val_3 = typeof(Player_move_c).__il2cppRuntimeField_1C8.transform.position;
        val_1.set_Item(key:  GameConnect.专丁丄丛丟且上且世, value:  val_3);
        val_1.set_Item(key:  GameConnect.丕丈丕丕一丞世丆不, value:  1);
        val_1.set_Item(key:  GameConnect.一丘丂丄上丅丁丙丝, value:  丘丑丅三丆丑丌且丝());
        val_1.set_Item(key:  GameConnect.丟丈丑丒丑专丄下丅, value:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁());
        double val_7 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_7 = val_7 + this.丄丅丟且一且下丒丙;
        val_1.set_Item(key:  GameConnect.丑七七七专丐丂三丆, value:  val_7);
        ExitGames.Client.Photon.Hashtable val_8 = new ExitGames.Client.Photon.Hashtable();
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_8.set_Item(key:  GameConnect.专丁丄丛丟且上且世, value:  val_9);
        val_8.set_Item(key:  GameConnect.丕丈丕丕一丞世丆不, value:  this.下不丆丅三丟丛丑丙);
        val_8.set_Item(key:  GameConnect.一丘丂丄上丅丁丙丝, value:  this.丆七一世且丏丆专丏);
        val_8.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  1);
        val_11 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_11.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  val_8, 丅丞丏丈且专丆不丟:  false);
    }
    private void 七下丗丏丌丞万丅万()
    {
        var val_13;
        string val_14;
        var val_15;
        var val_16;
        byte val_17;
        val_13 = null;
        val_13 = null;
        val_14 = GameConnect.丕丈丕丕一丞世丆不;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_14)) == false)
        {
            goto label_14;
        }
        
        val_15 = null;
        val_15 = null;
        val_14 = GameConnect.一丘丂丄上丅丁丙丝;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_14)) == false)
        {
            goto label_14;
        }
        
        val_16 = null;
        val_16 = null;
        object val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丕丈丕丕一丞世丆不];
        this.下不丆丅三丟丛丑丙 = null;
        val_14 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        object val_12 = val_14.Item[GameConnect.一丘丂丄上丅丁丙丝];
        goto label_23;
        label_14:
        val_17 = 0;
        this.下不丆丅三丟丛丑丙 = 0;
        label_23:
        this.丆七一世且丏丆专丏 = val_17;
    }
    private void OnDisconnectedFromPhoton()
    {
        this.丘丕丄与丈七与下三 = false;
        this.丛丐万且丒丞丟丝丐();
    }
    public void FillAllValues()
    {
        var val_28;
        var val_29;
        object val_30;
        var val_31;
        var val_33;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_34;
        var val_35;
        var val_36;
        val_28 = null;
        val_28 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丛丈丄丙万丈丂东上)) != false)
        {
                val_29 = null;
            val_29 = null;
            val_30 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丛丈丄丙万丈丂东上];
        }
        else
        {
                val_30 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  129);
            ExitGames.Client.Photon.Hashtable val_9 = new ExitGames.Client.Photon.Hashtable();
            val_31 = null;
            val_31 = null;
            val_9.set_Item(key:  GameConnect.丛丈丄丙万丈丂东上, value:  val_30);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_9, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        this.丟下七丐与丟丒丐丞 = true;
        this.丙专丈与专一丙且丕 = true;
        val_33 = null;
        val_33 = null;
        val_34 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_34 != null)
        {
                val_34 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_34 == null)
        {
                val_34 = 0;
        }
        
            string val_13 = val_34.丕丅丌丐丙丈丄丁丅();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_13)) != false)
        {
                val_35 = null;
            val_35 = null;
            if((val_13.ContainsKey(key:  GameConnect.丈丝丂丐丟万丙丑丕.丕丅丌丐丙丈丄丁丅())) != false)
        {
                val_36 = null;
            val_36 = null;
            this.丙专丈与专一丙且丕 = GameConnect.丈丝丂丐丟万丙丑丕.丕丅丌丐丙丈丄丁丅();
        }
        
        }
        
        }
        
        this.世七丈丕丑上丟丘丟 = val_18.roundTime;
        this.丞一七丐东世丌专丐 = val_19.roundWinLimit;
        this.七业丕且万丝丛丝与 = val_20.plantingAllTeams;
        this.世丄东丄丕七丟不丗 = val_21.oneRoundOneLife;
        this.与七业万丈与业七丆 = val_22.plantTeamRespawnDelay;
        this.下丞不丟七丏丂上丘 = val_23.disposalTeamRespawnDelay;
        this.丄丅丟且一且下丒丙 = val_24.bombExplosionTimer;
        this.上丘丒丁七丒丂丘丘 = val_25.bombPlantingTime;
        与丝丁丗七丑七丆且 val_26 = GameConnect.丈丝丂丐丟万丙丑丕.Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕].Item[this.丙专丈与专一丙且丕];
        this.丂丟丑丌丕丌丙丙丘 = val_26.bombDisposalTime;
        与丝丁丗七丑七丆且 val_27 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().Item[this.丙专丈与专一丙且丕];
        this.东丆与且丏丐丙且七 = val_27.resultsDelay;
    }
    internal int 丁丝三丝一丂丕丑一()
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
            if((val_8.ContainsKey(key:  GameConnect.丈且世丗七丅丂且丌)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            object val_7 = val_8.Item[GameConnect.丈且世丗七丅丂且丌];
            return (int)val_11;
        }
        
        }
        
        val_11 = 0;
        return (int)val_11;
    }
    internal void 丑世丟丂丞丞丌且丈(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丈且世丗七丅丂且丌, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal double 丝丈丟上与一丙与丝()
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
        if((val_8.ContainsKey(key:  GameConnect.不丈与七丗丘下丌丅)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Double.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.不丈与七丗丘下丌丅]);
    }
    internal void 万丐丌不不与丒丕丙(double 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal double 不丙万万丗且丞丌专()
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
        if((val_8.ContainsKey(key:  GameConnect.丑七七七专丐丂三丆)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Double.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丑七七七专丐丂三丆]);
    }
    internal void 与丞丗不三七业丕丞(double 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丑七七七专丐丂三丆, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal int 丅三七一丘七丒丙下()
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
        if((val_8.ContainsKey(key:  GameConnect.丗丅上丅世与丐丅上)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丗丅上丅世与丐丅上];
        if(val_7 != null)
        {
                return System.Int32.Parse(s:  val_7);
        }
        
        return System.Int32.Parse(s:  val_7);
    }
    internal void 丘七丕丒丐业一丕丄(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丗丅上丅世与丐丅上, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal int 下七东业丘三丑丝丘()
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
        if((val_8.ContainsKey(key:  GameConnect.上专丁丕不丒丛丐专)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.上专丁丕不丒丛丐专];
        if(val_7 != null)
        {
                return System.Int32.Parse(s:  val_7);
        }
        
        return System.Int32.Parse(s:  val_7);
    }
    internal void 丝七丒世不丌丝丈东(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.上专丁丕不丒丛丐专, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal PlantTheBombController.世丑丗三丙丒丈丒丏 丄上三丑丝丐专且上()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (世丑丗三丙丒丈丒丏)val_9;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.丌世万丙三丄丙且丗)) != false)
        {
                val_11 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_8.Item[GameConnect.丌世万丙三丄丙且丗];
            return (世丑丗三丙丒丈丒丏)val_9;
        }
        
        val_9 = 0;
        return (世丑丗三丙丒丈丒丏)val_9;
    }
    internal void 三不丅丕丟丛下一万(PlantTheBombController.世丑丗三丙丒丈丒丏 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丌世万丙三丄丙且丗, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal PlantTheBombController.丐丄丕专丝丏丑东七 三丘三丈上丕丆丂一()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (丐丄丕专丝丏丑东七)val_9;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.丐世丞业丁丄与丐上)) != false)
        {
                val_11 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_8.Item[GameConnect.丐世丞业丁丄与丐上];
            return (丐丄丕专丝丏丑东七)val_9;
        }
        
        val_9 = 0;
        return (丐丄丕专丝丏丑东七)val_9;
    }
    internal void 万下丐丅上丏丅专专(PlantTheBombController.丐丄丕专丝丏丑东七 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal int 丅与丄丞丅丒丒业专()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (int)val_9;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.丟东丐丐丛丒丕丆七)) != false)
        {
                val_11 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_8.Item[GameConnect.丟东丐丐丛丒丕丆七];
            return (int)val_9;
        }
        
        val_9 = 0;
        return (int)val_9;
    }
    internal void 一不丂丌下专丕不丗(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.丟东丐丐丛丒丕丆七, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal int 丗一专东丆不且下丒()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return (int)val_9;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.专丕东七东丏丕丏丒)) != false)
        {
                val_11 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_11 = null;
            object val_7 = val_8.Item[GameConnect.专丕东七东丏丕丏丒];
            return (int)val_9;
        }
        
        val_9 = 0;
        return (int)val_9;
    }
    internal void 且丌不与丐丕丏丂东(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  GameConnect.专丕东七东丏丕丏丒, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    private void 上丄丄下丄丘丕丟丁()
    {
        var val_11;
        string val_12;
        var val_13;
        this.plantedBomb.丘丒丐丒丆丑丒东上();
        PlantingZone val_1 = this.丌且丆丆东丐专万七();
        if(val_1 != null)
        {
                val_1.丑丞丕丂丒上丅丑万();
        }
        
        val_11 = null;
        val_11 = null;
        val_12 = GameConnect.丟丈丑丒丑专丄下丅;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_12)) == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅];
        val_12 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if(null != val_12)
        {
                return;
        }
        
        double val_10 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_10 = val_10 + this.七丙丟万丏与丆丆丂;
        this.丞丏丕丄丟丕丈丞丈 = val_10;
    }
    private void 丕三丏专丐专世丂丆()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  152, 专上丝且丂世丛丝丒:  1f);
    }
    private void 上专业丘一三世不丑()
    {
        var val_11;
        string val_12;
        var val_13;
        this.zoneA.丏丘且丈丝丙丄丈专();
        this.zoneB.丏丘且丈丝丙丄丈专();
        this.plantedBomb.下丏丝丂丁丘丞丝上();
        bool val_1 = this.丙丐丐东丘且不丞丒();
        if(val_1 != false)
        {
                val_1.丄世七万丌丑丐丟世();
        }
        else
        {
                val_1.丗下丏丞丒丘丄丅丕();
        }
        
        this.丙且丅丁丏与丙丛且 = 0;
        val_11 = null;
        val_11 = null;
        val_12 = GameConnect.丟丈丑丒丑专丄下丅;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_12)) == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丈丑丒丑专丄下丅];
        val_12 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        if(null != val_12)
        {
                return;
        }
        
        double val_10 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_10 = val_10 + this.七丙丟万丏与丆丆丂;
        this.丌专丑丑丛丐丕丂丑 = val_10;
    }
    private void 丗万丁丝世丛与专世()
    {
        null = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  151, 专上丝且丂世丛丝丒:  1f);
    }
    private void 丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        string val_41;
        var val_42;
        var val_43;
        string val_44;
        var val_45;
        var val_46;
        string val_47;
        val_30 = null;
        val_30 = null;
        if((业上上东丑东丞丗不.ContainsKey(key:  GameConnect.一丘丂丄上丅丁丙丝)) != false)
        {
                val_31 = null;
            val_31 = null;
            object val_2 = 业上上东丑东丞丗不.Item[GameConnect.一丘丂丄上丅丁丙丝];
            this.丆七一世且丏丆专丏 = null;
        }
        
        val_32 = null;
        val_32 = null;
        if((业上上东丑东丞丗不.ContainsKey(key:  GameConnect.丕丈丕丕一丞世丆不)) == false)
        {
            goto label_11;
        }
        
        val_33 = null;
        val_33 = null;
        object val_4 = 业上上东丑东丞丗不.Item[GameConnect.丕丈丕丕一丞世丆不];
        if(null == 3)
        {
            goto label_15;
        }
        
        if(null == 2)
        {
            goto label_16;
        }
        
        if(null != 1)
        {
            goto label_20;
        }
        
        this.上专业丘一三世不丑();
        goto label_20;
        label_15:
        this.plantedBomb.丏与东丙丑丛丌丝丛();
        goto label_20;
        label_16:
        this.上丄丄下丄丘丕丟丁();
        label_20:
        this.下不丆丅三丟丛丑丙 = null;
        this.世七下东丕丐东丈丈();
        label_11:
        val_34 = null;
        val_34 = null;
        bool val_5 = 业上上东丑东丞丗不.ContainsKey(key:  GameConnect.丐世丞业丁丄与丐上);
        if(val_5 != false)
        {
                丐丄丕专丝丏丑东七 val_6 = val_5.三丘三丈上丕丆丂一();
            if((this.三丘专东丐下丂三丑 != val_6) && (this.三丘专东丐下丂三丑 != 5))
        {
                this.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  val_6.三丘三丈上丕丆丂一());
        }
        
        }
        
        val_35 = null;
        val_35 = null;
        if(((业上上东丑东丞丗不.ContainsKey(key:  GameConnect.丗丅上丅世与丐丅上)) != false) && (PlantTheBombController.丌丁下丁三上丗七业 != null))
        {
                val_36 = null;
            val_36 = null;
            PlantTheBombController.丌丁下丁三上丗七业.Invoke(arg1:  1, arg2:  System.Convert.ToInt32(value:  业上上东丑东丞丗不.Item[GameConnect.丗丅上丅世与丐丅上]));
        }
        
        val_37 = null;
        val_37 = null;
        if(((业上上东丑东丞丗不.ContainsKey(key:  GameConnect.上专丁丕不丒丛丐专)) != false) && (PlantTheBombController.丌丁下丁三上丗七业 != null))
        {
                val_38 = null;
            val_38 = null;
            PlantTheBombController.丌丁下丁三上丗七业.Invoke(arg1:  2, arg2:  System.Convert.ToInt32(value:  业上上东丑东丞丗不.Item[GameConnect.上专丁丕不丒丛丐专]));
        }
        
        val_39 = null;
        val_39 = null;
        if((业上上东丑东丞丗不.ContainsKey(key:  GameConnect.丗丅上丅世与丐丅上)) != true)
        {
                val_40 = null;
            val_40 = null;
            val_41 = GameConnect.上专丁丕不丒丛丐专;
            if((业上上东丑东丞丗不.ContainsKey(key:  val_41)) == false)
        {
                return;
        }
        
        }
        
        val_42 = null;
        val_42 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丗丅上丅世与丐丅上)) == false)
        {
            goto label_61;
        }
        
        val_43 = null;
        val_43 = null;
        val_44 = GameConnect.丗丅上丅世与丐丅上;
        if((System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_44])) == this.丞一七丐东世丌专丐)
        {
            goto label_69;
        }
        
        label_61:
        val_45 = null;
        val_45 = null;
        val_41 = GameConnect.上专丁丕不丒丛丐专;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_41)) == false)
        {
                return;
        }
        
        val_46 = null;
        val_46 = null;
        val_47 = GameConnect.上专丁丕不丒丛丐专;
        int val_29 = System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_47]);
        if(val_29 != this.丞一七丐东世丌专丐)
        {
                return;
        }
        
        label_69:
        val_29.丘丄一三丒丐上丒丙();
    }
    internal void 丅丕丛丑三世丅世东()
    {
        this.东一丟丌丏且一丞丌(丝丝不丝上丂三丌世:  this.三丘三丈上丕丆丂一());
    }
    private void 东一丟丌丏且一丞丌(PlantTheBombController.丐丄丕专丝丏丑东七 丝丝不丝上丂三丌世)
    {
        if(this.三丘专东丐下丂三丑 == 丝丝不丝上丂三丌世)
        {
                return;
        }
        
        if(丝丝不丝上丂三丌世 <= 3)
        {
                var val_19 = 106039900 + (丝丝不丝上丂三丌世) << 2;
            val_19 = val_19 + 106039900;
        }
        else
        {
                this.三丘专东丐下丂三丑 = 丝丝不丝上丂三丌世;
        }
    
    }
    private void 丘三丑丌一不丟丝业()
    {
        var val_4;
        if(this.七业丕且万丝丛丝与 != false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        int val_1 = 丘丑丅三丆丑丌且丝();
        int val_3 = val_1.丅与丄丞丅丒丒业专();
        if(val_3 != ((val_1 == 1) ? (1 + 1) : 1))
        {
            goto label_6;
        }
        
        if(null != 0)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        Play();
        return;
        label_6:
        if(val_3 != val_1)
        {
                return;
        }
        
        if(null != 0)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    private void Start()
    {
        var val_6;
        OnlineModeController val_7;
        var val_8;
        var val_9;
        var val_10;
        System.Action<ExitGames.Client.Photon.Hashtable> val_11;
        val_6 = null;
        val_6 = null;
        val_7 = GameController.onlineMode;
        if(val_7 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_7 = 0;
        val_8 = 1;
        goto label_5;
        label_4:
        val_8 = 0;
        label_5:
        val_9 = System.Delegate.Combine(a:  GameController.onlineMode + 536, b:  new System.Action(object:  this, method:  System.Void PlantTheBombController::丌一丐且下世下三上()));
        if((val_9 != null) && (null != null))
        {
                val_9 = 0;
        }
        
        GameController.onlineMode.__unknownFiledOffset_218 = val_9;
        val_10 = null;
        val_10 = null;
        if(((System.Delegate.Combine(a:  GameConnect.世丄丄与丌业丑丕丈, b:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void PlantTheBombController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_11 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_11;
    }
    private void OnDestroy()
    {
        var val_7;
        var val_8;
        OnlineModeController val_9;
        var val_10;
        var val_11;
        var val_12;
        System.Action<ExitGames.Client.Photon.Hashtable> val_13;
        val_7 = null;
        val_7 = null;
        if(GameController.onlineMode != 0)
        {
                val_8 = null;
            val_8 = null;
            val_9 = GameController.onlineMode;
            if((val_9 != null) && (null == null))
        {
                val_9 = GameController.onlineMode;
            if(((val_9 != null) && (null == null)) && (val_9 != null))
        {
                val_10 = 0;
        }
        else
        {
                val_9 = 0;
            val_10 = 1;
        }
        
            val_11 = System.Delegate.Remove(source:  313, value:  new System.Action(object:  this, method:  System.Void PlantTheBombController::丌一丐且下世下三上()));
            if((val_11 != null) && (null != null))
        {
                val_11 = 0;
        }
        
            mem[536] = val_11;
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        if(((System.Delegate.Remove(source:  GameConnect.世丄丄与丌业丑丕丈, value:  new System.Action<ExitGames.Client.Photon.Hashtable>(object:  this, method:  System.Void PlantTheBombController::丟丘丄丅丅丐丂专世(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)))) != null) && (null != null))
        {
                val_13 = 0;
        }
        
        GameConnect.世丄丄与丌业丑丕丈 = val_13;
    }
    private PlantingZone 丗三丏丈东丝丝专丅(int 丞世不丒下上上丝丑)
    {
        PlantingZone val_1;
        if(丞世不丒下上上丝丑 != 2)
        {
                if(丞世不丒下上上丝丑 != 1)
        {
                return 0;
        }
        
            val_1 = this.zoneA;
            return (PlantingZone)mem[this.zoneB];
        }
        
        val_1 = this.zoneB;
        return (PlantingZone)mem[this.zoneB];
    }
    private void 丑万七三上丘丒丕丐(int 丄丒且丙三丆丟与丏)
    {
        if(this.plantedBomb == null)
        {
                return;
        }
        
        this.plantedBomb.且丐丆一丞丈丈丝丌(业上上丏丄不上丅丈:  丄丒且丙三丆丟与丏);
    }
    private void 下丟东丟丛一七丂一(int 丄丒且丙三丆丟与丏)
    {
        if(this.plantedBomb == null)
        {
                return;
        }
        
        goto typeof(PlantedBomb).__il2cppRuntimeField_188;
    }
    private void 丝世与丅丌丁专丑丟(int 丄丒且丙三丆丟与丏)
    {
        this.下不丆丅三丟丛丑丙 = 2;
    }
    private void 世下不丅丗丗且三万(int 东丒丅七业丒丁丈丌, int 丄丒且丙三丆丟与丏)
    {
        PlantingZone val_1;
        if(东丒丅七业丒丁丈丌 != 2)
        {
                if(东丒丅七业丒丁丈丌 != 1)
        {
                return;
        }
        
            val_1 = this.zoneA;
        }
        else
        {
                val_1 = this.zoneB;
        }
        
        if(mem[this.zoneB] == 0)
        {
                return;
        }
        
        mem[this.zoneB].且丐丆一丞丈丈丝丌(业上上丏丄不上丅丈:  丄丒且丙三丆丟与丏);
    }
    private void 丈三下下丟丞下业丁(int 东丒丅七业丒丁丈丌, int 丄丒且丙三丆丟与丏)
    {
        PlantingZone val_1;
        if(东丒丅七业丒丁丈丌 != 2)
        {
                if(东丒丅七业丒丁丈丌 != 1)
        {
                return;
        }
        
            val_1 = this.zoneA;
        }
        else
        {
                val_1 = this.zoneB;
        }
        
        if(mem[this.zoneB] == 0)
        {
                return;
        }
        
        goto mem[this.zoneB] + 392;
    }
    private void 丛丆专七丛且丈丈万(PlantTheBombController.世丑丗三丙丒丈丒丏 丅世丗与丈万丆与三, int 丕丗丞丞丑丘丛丂且)
    {
        int val_7;
        ExitGames.Client.Photon.Hashtable val_8;
        var val_9;
        var val_10;
        string val_11;
        var val_12;
        var val_13;
        val_7 = 丕丗丞丞丑丘丛丂且;
        val_8 = this;
        this.丁一万丆与丝丑丞业();
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = null;
        val_8 = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_9 = null;
        val_9 = null;
        val_2.set_Item(key:  GameConnect.丟东丐丐丛丒丕丆七, value:  val_7);
        val_2.set_Item(key:  GameConnect.丌世万丙三丄丙且丗, value:  丅世丗与丈万丆与三);
        val_2.set_Item(key:  GameConnect.丐世丞业丁丄与丐上, value:  2);
        if(val_7 == 2)
        {
            goto label_9;
        }
        
        if(val_7 != 1)
        {
            goto label_10;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = GameConnect.丗丅上丅世与丐丅上;
        int val_3 = 丅三七一丘七丒丙下();
        goto label_13;
        label_9:
        val_10 = null;
        val_10 = null;
        val_11 = GameConnect.上专丁丕不丒丛丐专;
        label_13:
        val_2.set_Item(key:  val_11, value:  下七东业丘三丑丝丘() + 1);
        label_10:
        if(丅世丗与丈万丆与三 == 2)
        {
                val_12 = null;
            val_12 = null;
            val_2.set_Item(key:  GameConnect.丕丈丕丕一丞世丆不, value:  3);
        }
        
        val_13 = null;
        val_13 = null;
        val_2.set_Item(key:  GameConnect.丑七七七专丐丂三丆, value:  0);
        val_7 = 0;
        val_2.set_Item(key:  GameConnect.不丈与七丗丘下丌丅, value:  0);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 丆丞丗上丂丁且丅世(Player_move_c 专丞上七七且丝七丗)
    {
        PlantedBomb val_2;
        int val_3;
        ZoneWithActivePlayers[] val_1 = new ZoneWithActivePlayers[3];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.zoneA != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.zoneA == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.zoneA;
        val_1[1] = this.zoneB;
        val_2 = this.plantedBomb;
        val_3 = val_1.Length;
        if(val_3 <= 2)
        {
                val_3 = val_1.Length;
        }
        
        val_1[2] = val_2;
        if(val_3 < 1)
        {
                return;
        }
        
        do
        {
            val_2 = val_1[0];
            val_2.丆丞丗上丂丁且丅世(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        }
        while((0 + 1) < val_1.Length);
    
    }
    public int SelectBomberCommand(int 丝丐丐丟丙丆一丄丗)
    {
        return (int)(丝丐丐丟丙丆一丄丗 & 1) + 1;
    }
    public bool get_isMyTeamBomberRole()
    {
        var val_4;
        if(this.isMyTeamWithBombIcon != false)
        {
                val_4 = 1;
        }
        else
        {
                bool val_2 = this.isMyTeamWithCuttersIcon;
            val_4 = val_2 ^ 1;
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    public bool get_isEnemyTeamBomberRole()
    {
        var val_4;
        if(this.isEnemyTeamWithBombIcon != false)
        {
                val_4 = 1;
        }
        else
        {
                bool val_2 = this.isEnemyTeamWithCuttersIcon;
            val_4 = val_2 ^ 1;
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    public bool get_isMyTeamWithBombIcon()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        WeaponManager val_30;
        var val_31;
        var val_32;
        val_23 = null;
        val_23 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_56;
        }
        
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_56;
        }
        
        丐丄丕专丝丏丑东七 val_3 = this.三丘三丈上丕丆丂一();
        if(val_3 == 2)
        {
            goto label_56;
        }
        
        if(this.七业丕且万丝丛丝与 != false)
        {
                if(val_3.丟不丏丈丗丘丕丐丒() == false)
        {
            goto label_15;
        }
        
        }
        
        val_25 = null;
        val_25 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_37;
        }
        
        val_26 = null;
        val_26 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丕丈丕丕一丞世丆不)) == false)
        {
            goto label_37;
        }
        
        val_27 = null;
        val_27 = null;
        bool val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.一丘丂丄上丅丁丙丝);
        if((val_12 == false) || (val_12.丟不丏丈丗丘丕丐丒() == false))
        {
            goto label_37;
        }
        
        val_28 = null;
        val_28 = null;
        byte val_17 = System.Byte.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.一丘丂丄上丅丁丙丝]);
        goto label_45;
        label_37:
        val_29 = null;
        val_29 = null;
        val_30 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_30 == 0)
        {
            goto label_56;
        }
        
        val_31 = null;
        val_31 = null;
        val_30 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_30 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        bool val_19 = UnityEngine.Object.op_Inequality(x:  val_30, y:  0);
        if(val_19 == false)
        {
            goto label_56;
        }
        
        if(this.七业丕且万丝丛丝与 == false)
        {
            goto label_57;
        }
        
        label_15:
        val_32 = 1;
        return (bool)val_32;
        label_56:
        val_32 = 0;
        return (bool)val_32;
        label_57:
        int val_21 = val_19.丁丝三丝一丂丕丑一() & 1;
        val_21 = val_21 + 1;
        label_45:
        var val_22 = (丘丑丅三丆丑丌且丝() == val_21) ? 1 : 0;
        return (bool)val_32;
    }
    public bool get_isMyTeamWithCuttersIcon()
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        if(this.isMyTeamWithBombIcon == true)
        {
                return false;
        }
        
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return false;
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return false;
        }
        
        val_19 = null;
        val_19 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return false;
        }
        
        val_20 = null;
        val_20 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丕丈丕丕一丞世丆不)) == false)
        {
                return false;
        }
        
        val_21 = null;
        val_21 = null;
        bool val_11 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.一丘丂丄上丅丁丙丝);
        if(val_11 == false)
        {
                return false;
        }
        
        if(val_11.丟不丏丈丗丘丕丐丒() == false)
        {
                return false;
        }
        
        if(this.七业丕且万丝丛丝与 == true)
        {
                return false;
        }
        
        val_22 = null;
        val_22 = null;
        if(丘丑丅三丆丑丌且丝() == (System.Byte.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.一丘丂丄上丅丁丙丝])))
        {
                return false;
        }
        
        return false;
    }
    public bool get_isEnemyTeamWithCuttersIcon()
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(this.isEnemyTeamWithBombIcon == true)
        {
                return false;
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return false;
        }
        
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return false;
        }
        
        val_20 = null;
        val_20 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return false;
        }
        
        val_21 = null;
        val_21 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丕丈丕丕一丞世丆不)) == false)
        {
                return false;
        }
        
        val_22 = null;
        val_22 = null;
        bool val_12 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.一丘丂丄上丅丁丙丝);
        if(val_12 == false)
        {
                return false;
        }
        
        if(val_12.丟不丏丈丗丘丕丐丒() == false)
        {
                return false;
        }
        
        if(this.七业丕且万丝丛丝与 == true)
        {
                return false;
        }
        
        val_23 = null;
        val_23 = null;
        if(((丘丑丅三丆丑丌且丝() == 1) ? (1 + 1) : 1) == (System.Byte.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.一丘丂丄上丅丁丙丝])))
        {
                return false;
        }
        
        return false;
    }
    public bool get_isEnemyTeamWithBombIcon()
    {
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        string val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_56;
        }
        
        val_25 = null;
        val_25 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_56;
        }
        
        丐丄丕专丝丏丑东七 val_3 = this.三丘三丈上丕丆丂一();
        if(val_3 == 2)
        {
            goto label_56;
        }
        
        if(this.七业丕且万丝丛丝与 != false)
        {
                if(val_3.丟不丏丈丗丘丕丐丒() == false)
        {
            goto label_15;
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_37;
        }
        
        val_27 = null;
        val_27 = null;
        val_28 = GameConnect.丕丈丕丕一丞世丆不;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_28)) == false)
        {
            goto label_37;
        }
        
        val_29 = null;
        val_29 = null;
        val_28 = GameConnect.一丘丂丄上丅丁丙丝;
        bool val_13 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_28);
        if((val_13 == false) || (val_13.丟不丏丈丗丘丕丐丒() == false))
        {
            goto label_37;
        }
        
        val_30 = null;
        val_30 = null;
        byte val_18 = System.Byte.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.一丘丂丄上丅丁丙丝]);
        goto label_45;
        label_37:
        val_31 = null;
        val_31 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_56;
        }
        
        val_32 = null;
        val_32 = null;
        bool val_20 = UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable, y:  0);
        if(val_20 == false)
        {
            goto label_56;
        }
        
        if(this.七业丕且万丝丛丝与 == false)
        {
            goto label_57;
        }
        
        label_15:
        val_33 = 1;
        return (bool)val_33;
        label_56:
        val_33 = 0;
        return (bool)val_33;
        label_57:
        int val_22 = val_20.丁丝三丝一丂丕丑一() & 1;
        val_22 = val_22 + 1;
        label_45:
        var val_23 = (((丘丑丅三丆丑丌且丝() == 1) ? (1 + 1) : 1) == val_22) ? 1 : 0;
        return (bool)val_33;
    }
    private bool 丛与丘丕丞丁世丆丕()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        if((this.三丘三丈上丕丆丂一() == 1) && (this.丆七一世且丏丆专丏 != 0))
        {
                val_6 = null;
            val_6 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_7 = null;
            val_7 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_8 = null;
            val_8 = null;
            var val_5 = (丘丑丅三丆丑丌且丝() != this.丆七一世且丏丆专丏) ? 1 : 0;
            return (bool)val_9;
        }
        
        }
        
        }
        
        val_9 = 0;
        return (bool)val_9;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        var val_6;
        val_2 = 丞世不丒下上上丝丑;
        byte val_1 = val_2 & 255;
        val_1 = val_1 - 230;
        if(val_1 <= 3)
        {
                var val_2 = 106039940 + (((丞世不丒下上上丝丑 & 255) - 230)) << 2;
            val_2 = val_2 + 106039940;
        }
        else
        {
                val_6 = 0;
            return (bool);
        }
    
    }
    public PlantTheBombController()
    {
        this.世七丈丕丑上丟丘丟 = 60;
        this.丌一丞丝七丏丑丏世 = -1;
        this.与七业万丈与业七丆 = ;
        this.下丞不丟七丏丂上丘 = 20;
        this.丄丅丟且一且下丒丙 = ;
        this.上丘丒丁七丒丂丘丘 = 5;
        this.世丄东丄丕七丟不丗 = true;
        this.丞一七丐东世丌专丐 = 5;
        this.七丙丟万丏与丆丆丂 = 5;
        this.丑业万丞三丙丄丞专 = -1f;
        this.三丘专东丐下丂三丑 = 5;
        this.丂丟丑丌丕丌丙丙丘 = ;
        this.东丆与且丏丐丙且七 = 5;
        this.丛丒且不一丄三丟专 = 5;
    }

}
