using UnityEngine;
public class PlayerBotsManager : MonoBehaviour
{
    // Fields
    private static PlayerBotsManager <丄且丂丙丒且七丈丆>k__BackingField;
    internal System.Collections.Generic.List<PlayerBotInstance> 与上且丗丄七丑丆丑;
    internal System.Collections.Generic.List<PlayerBotController> 业丌上丁下七不丐丝;
    internal System.Collections.Generic.Dictionary<PlayerBotController, PlayerBotsManager.丅丘万丑东不业丛不> 丞业丆上一丐丟七丂;
    internal System.Collections.Generic.Dictionary<PlayerBotController, PlayerBotsManager.丅丘万丑东不业丛不> 丌三丒丟丙与与丌丛;
    private const int 丑世丌丘丘丂丌一业 = 3;
    private static int 丅丗丕不七专世不万;
    private static int 丝七丐丞丞一业一业;
    private bool 丝与丆丞东丘丈东丘;
    public bool ignorePlayer;
    internal bool 丞丄丘丌上丑丆与丑;
    private PlayerBotsManager.SavedAiLevels 世丐丙七与丛专丅三;
    private int 一一东不且丞丕东丘;
    private int 丑丟与丏一丁一丞丐;
    private int 丞上丘不下丞七万丐;
    private UnityEngine.Coroutine 丅丈丒丑万丐丛万下;
    internal static PGCompany.丁丙七丅专与三丝丙 上丙丕丝与丛三丕丕;
    private PGCompany.丂专丞丟丂与丄万丌 一丛丏丛万丁丝不丂;
    private System.Collections.Generic.HashSet<int> 下专丗丕丟且业与丙;
    private float 丙一东丏上丘与丏丂;
    public bool equalityMode;
    private float 不丐丞专丆东丘东东;
    private float[] 丘专下与三丗丝丝丁;
    private bool 丌丐上专丑丞上丄下;
    private static readonly string 丁丟丛业丅丘丙丕丗;
    
    // Properties
    internal static PlayerBotsManager 丄丘七三上丕世丞业 { get; set; }
    private int 丛丅丙丏下万丛一丏 { get; }
    private int 丂业丙一七丞丌丂丄 { get; }
    private int 丕丞丒丏且七丒丆丈 { get; }
    private PGCompany.丂专丞丟丂与丄万丌 丂一专万丂丏一丘东 { get; }
    private bool 一专丆万丗一且丆丗 { get; }
    private bool 丝丆丘一丅丑丐丝三 { get; }
    private bool 一万万丟上丂丐丘世 { get; }
    
    // Methods
    internal static PlayerBotsManager 与一丅丝不丈业与丙()
    {
        null = null;
        return (PlayerBotsManager)PlayerBotsManager.丑世丌丘丘丂丌一业;
    }
    private static void 丑一上丟丙不东与业(PlayerBotsManager 丙业与丙丗丝不丈东)
    {
        null = null;
        PlayerBotsManager.丑世丌丘丘丂丌一业 = 丙业与丙丗丝不丈东;
    }
    private int 丘下丆丕丐万丟不丐()
    {
        int val_2 = ((this.一一东不且丞丕东丘 + 1) > 3) ? 0 : (this.一一东不且丞丕东丘 + 1);
        this.一一东不且丞丕东丘 = val_2;
        return val_2;
    }
    private int 业丘丑丒丅丝丂三且()
    {
        int val_2 = ((this.丑丟与丏一丁一丞丐 + 1) > 4) ? 0 : (this.丑丟与丏一丁一丞丐 + 1);
        this.丑丟与丏一丁一丞丐 = val_2;
        return val_2;
    }
    private int 世七丒上丒丞丅丕丑()
    {
        int val_2 = ((this.丞上丘不下丞七万丐 + 1) > 8) ? 0 : (this.丞上丘不下丞七万丐 + 1);
        this.丞上丘不下丞七万丐 = val_2;
        return val_2;
    }
    internal static void 且丄万丛丂业下丙丟()
    {
        var val_7;
        string val_2 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  114);
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_7 = null;
        val_7 = null;
        PlayerBotsManager.上丙丕丝与丛三丕丕 = new PGCompany.丁丙七丅专与三丝丙(一丐丗丁丞丆丅丟丄:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝());
        if(PlayerBotsManager.上丙丕丝与丛三丕丕 != null)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "botsConfig is NULL !");
    }
    private PGCompany.丂专丞丟丂与丄万丌 丂丆业且业丅丑丝丟()
    {
        var val_10;
        Rilisoft.七丕丟丏三丈一丄世 val_11;
        var val_12;
        var val_13;
        var val_14;
        if(this.一丛丏丛万丁丝不丂 != null)
        {
                return (PGCompany.丂专丞丟丂与丄万丌)this.一丛丏丛万丁丝不丂;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = 1152921504848912384;
        if(GameController.丆丘丂丈世丏丟丑丏 == 0)
        {
                return (PGCompany.丂专丞丟丂与丄万丌)this.一丛丏丛万丁丝不丂;
        }
        
        val_12 = null;
        val_12 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 == 0)
        {
                return (PGCompany.丂专丞丟丂与丄万丌)this.一丛丏丛万丁丝不丂;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = null;
        val_11 = GameConnect.丑丌丛丈丅丅与不业();
        val_14 = null;
        this.一丛丏丛万丁丝不丂 = PlayerBotsManager.上丙丕丝与丛三丕丕.与丄丆丁丘东丝下七(上且丗一丏丏万丅丌:  val_11, 丞丁丑丏丄丏七丂不:  name, 业万上丆丐丞且丒七:  (丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) + 1);
        return (PGCompany.丂专丞丟丂与丄万丌)this.一丛丏丛万丁丝不丂;
    }
    private void Awake()
    {
        PlayerBotsManager.丑一上丟丙不东与业(丙业与丙丗丝不丈东:  this);
        PlayerBotsManager.且丄万丛丂业下丙丟();
        this.世丐丙七与丛专丅三.丒三丐丕下丌丕丟丝();
        if(GameConnect.七专丝上丆丆丒丐万() == false)
        {
                return;
        }
        
        this.丅丈丒丑万丐丛万下 = this.StartCoroutine(routine:  this.丏丄与七丙丅丂丞丟());
    }
    private void Start()
    {
        this.丞丄丘丌上丑丆与丑 = GameConnect.丛上丆一丂业丕丈丐();
        if(GameConnect.七专丝上丆丆丒丐万() == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.万丒万业业丝丝七丘());
    }
    internal void 丙丏专丞丗东丗世丞()
    {
        var val_4;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_4 = 0;
        goto label_4;
        label_8:
        this.与上且丗丄七丑丆丑.Item[0].不上丙下下东丁丅业();
        val_4 = 1;
        label_4:
        if(val_4 < this.与上且丗丄七丑丆丑.Count)
        {
            goto label_8;
        }
    
    }
    internal void 丞丟丑丛三丗丆丅丛(PlayerBotController 丛世丕丘七东下丌丄, int 东不丑专丄丌丒丗丅)
    {
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.Dictionary<PlayerBotController, 丅丘万丑东不业丛不> val_14;
        System.Int32[] val_15;
        if(this.丞丄丘丌上丑丆与丑 != false)
        {
                return;
        }
        
        if(东不丑专丄丌丒丗丅 == 0)
        {
            goto label_2;
        }
        
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(丘丑丅三丆丑丌且丝() != 东不丑专丄丌丒丗丅)
        {
            goto label_18;
        }
        
        val_14 = this.丞业丆上一丐丟七丂;
        val_15 = this.世丐丙七与丛专丅三.teammatesAiLevels;
        this.一一东不且丞丕东丘 = ((this.一一东不且丞丕东丘 + 1) > 3) ? 0 : (this.一一东不且丞丕东丘 + 1);
        if(val_15 != null)
        {
            goto label_27;
        }
        
        goto label_28;
        label_2:
        val_14 = this.丌三丒丟丙与与丌丛;
        val_15 = this.世丐丙七与丛专丅三.dmAiLevels;
        int val_7 = ((this.丞上丘不下丞七万丐 + 1) > 8) ? 0 : (this.丞上丘不下丞七万丐 + 1);
        this.丞上丘不下丞七万丐 = val_7;
        if(val_15 != null)
        {
            goto label_27;
        }
        
        label_28:
        label_27:
        int val_11 = val_15[(long)val_7];
        PlayerBotsManager.丅丘万丑东不业丛不 val_8 = new PlayerBotsManager.丅丘万丑东不业丛不();
        .丒专丈丛下丒一丒丛 = 丛世丕丘七东下丌丄;
        .丏丙丙丌丑一丅上丆 = val_11;
        val_8.丛丞丟丙万丞丐丌丝(丙业与丙丗丝不丈东:  val_11);
        val_14.Add(key:  丛世丕丘七东下丌丄, value:  val_8);
        return;
        label_18:
        this.丑丟与丏一丁一丞丐 = ((this.丑丟与丏一丁一丞丐 + 1) > 4) ? 0 : (this.丑丟与丏一丁一丞丐 + 1);
        if(this.世丐丙七与丛专丅三.enemiesAiLevels != null)
        {
            goto label_27;
        }
        
        goto label_28;
    }
    internal UnityEngine.GameObject 不丅上丆万上丘丙东()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        return 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "Bots/BotInstance", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0);
    }
    internal void 一丙丞丝与不一丏下()
    {
        goto label_1;
        label_5:
        this.与上且丗丄七丑丆丑.Item[0].七丝丑丁丑丂七丏丕();
        0 = 1;
        label_1:
        if(0 < this.与上且丗丄七丑丆丑.Count)
        {
            goto label_5;
        }
    
    }
    internal void 丈丑与丕丕丕丙丗业(string 三丒三丒一专丈万丑, string 丅业业丟不业丙丏丂)
    {
        var val_3;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.丞丅丅丞丘不丅不丐();
        val_3 = null;
        val_3 = null;
        val_1.set_Item(key:  MatchmakingConnect.丟丆东丑三丙丄丆不, value:  三丒三丒一专丈万丑);
        val_1.set_Item(key:  MatchmakingConnect.丒丐丐丙丘丂丂丗东, value:  丅业业丟不业丙丏丂);
        val_1.set_Item(key:  MatchmakingConnect.丕与丌丂万一三丘丂, value:  0);
        UnityEngine.GameObject val_2 = val_1.丟丌丙丒七丈丟丟丛(东一丁世丑丞业丄丐:  val_1);
    }
    internal UnityEngine.GameObject 丟丌丙丒七丈丟丟丛(System.Collections.Generic.Dictionary<string, object> 东一丁世丑丞业丄丐)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_5;
        }
        
        if(东一丁世丑丞业丄丐 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(东一丁世丑丞业丄丐 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_3[0] = 东一丁世丑丞业丄丐;
        return 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "Bots/BotInstance", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_3);
    }
    internal UnityEngine.GameObject 专七丗业丏业丛与丛(int 丞世不丒下上上丝丑)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_5;
        }
        
        if(丞世不丒下上上丝丑 != 0)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(丞世不丒下上上丝丑 == 0)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_3[0] = 丞世不丒下上上丝丑;
        return (UnityEngine.GameObject)丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "Bots/ScenarioBots/FortBotInstance", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_3);
    }
    internal UnityEngine.GameObject 下专丘丈丝丂丑丂万(string 丞丅上丏丂且下丅与)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        object[] val_3 = new object[1];
        if(val_3 == null)
        {
            goto label_5;
        }
        
        if(丞丅上丏丂且下丅与 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(丞丅上丏丂且下丅与 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_3[0] = 丞丅上丏丂且下丅与;
        return 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "Bots/ScenarioBots/FortAttackBotInstance", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_3);
    }
    internal void 一丄一七上不丆下丆(PlayerBotInstance 丗丈东丕不丘三丞业)
    {
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  丗丈东丕不丘三丞业.gameObject);
    }
    internal void 丛丘东世丂万丕丂世(PlayerBotController 业丘东且七丕丞东不)
    {
        if(this.丌三丒丟丙与与丌丛 != null)
        {
                if((this.丌三丒丟丙与与丌丛.ContainsKey(key:  业丘东且七丕丞东不)) != false)
        {
                bool val_2 = this.丌三丒丟丙与与丌丛.Remove(key:  业丘东且七丕丞东不);
        }
        
        }
        
        if(this.丞业丆上一丐丟七丂 == null)
        {
                return;
        }
        
        if((this.丞业丆上一丐丟七丂.ContainsKey(key:  业丘东且七丕丞东不)) == false)
        {
                return;
        }
        
        bool val_4 = this.丞业丆上一丐丟七丂.Remove(key:  业丘东且七丕丞东不);
    }
    private void Update()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(this.丝与丆丞东丘丈东丘 != false)
        {
                if(this.丞丄丘丌上丑丆与丑 == false)
        {
                return;
        }
        
            this.业丗东且下东丏一不();
            return;
        }
        
        this.上丛丌丆丑上七世三();
    }
    private void 一丁丙东丞丆不丆专()
    {
        if(this.丞丄丘丌上丑丆与丑 == false)
        {
                return;
        }
        
        this.业丗东且下东丏一不();
    }
    private int 上三丌丛丝三世与丗()
    {
        var val_7;
        var val_8;
        val_7 = 0;
        val_8 = 10;
        goto label_1;
        label_8:
        PlayerBotInstance val_1 = this.与上且丗丄七丑丆丑.Item[0];
        if((System.Int32.TryParse(s:  val_1.且业丞丁丁且丒下丕, result: out  0)) != false)
        {
                val_8 = UnityEngine.Mathf.Max(a:  10, b:  0);
        }
        
        val_7 = 1;
        label_1:
        if(val_7 < this.与上且丗丄七丑丆丑.Count)
        {
            goto label_8;
        }
        
        return (int)val_8 + 1;
    }
    private System.Collections.Generic.Dictionary<string, object> 丞丅丅丞丘不丅不丐()
    {
        var val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_18 = null;
        val_18 = null;
        val_1.set_Item(key:  MatchmakingConnect.三不三三丆丅世丞三, value:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丙世丁丘丘丆丗丅丐().ToArray());
        val_1.set_Item(key:  MatchmakingConnect.丕一业丌丄下丈丂专, value:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().一丆丅万世丗与七丈());
        val_1.set_Item(key:  MatchmakingConnect.丗丅丙丕丛丁丂丄万, value:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().上丏丞且与三丞一世());
        val_1.set_Item(key:  MatchmakingConnect.丒丐丐丙丘丂丂丗东, value:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().万七三万丐丑丅一东());
        val_1.set_Item(key:  MatchmakingConnect.丐万丘七专上丅丛丅, value:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丕且丘专三世且下丛());
        int val_14 = PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丐丂丏上且世丛丌丙();
        if((val_14 & 2147483648) == 0)
        {
                val_19 = null;
            val_19 = null;
            val_1.set_Item(key:  MatchmakingConnect.丕与丌丂万一三丘丂, value:  val_14);
            val_1.set_Item(key:  MatchmakingConnect.万丂丞丌丛丂丅丑万, value:  PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丑丐世丞下丈丟丑丄());
        }
        
        val_20 = null;
        val_20 = null;
        val_1.set_Item(key:  MatchmakingConnect.丟丆东丑三丙丄丆不, value:  this.上三丌丛丝三世与丗());
        return val_1;
    }
    private void 业丗东且下东丏一不()
    {
        var val_61;
        bool val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        int val_71;
        var val_72;
        var val_73;
        System.Collections.Generic.List<NetworkStartTable> val_74;
        var val_75;
        var val_76;
        var val_78;
        var val_79;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == true)
        {
                return;
        }
        
        int val_3 = this.与上且丗丄七丑丆丑.Count;
        val_61 = 0;
        val_62 = 0;
        goto label_13;
        label_23:
        val_63 = null;
        val_63 = null;
        NetworkStartTable val_9 = Item[0];
        bool val_61 = val_9.一七不三丌专三丆一;
        val_61 = 1;
        val_61 = val_61 ^ 1;
        val_62 = val_62 + val_61;
        label_13:
        val_64 = null;
        val_64 = null;
        if(val_61 < Count)
        {
            goto label_23;
        }
        
        val_62 = val_62 + val_3;
        val_62 = val_62 - 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下();
        if((this.丂丆业且业丅丑丝丟() != null) && ((GameConnect.丗丁丟丑三丟万丕丌(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != false))
        {
                bool val_18 = this.丂丆业且业丅丑丝丟().丑一丕丅下不万丌丌();
        }
        
        if(val_62 >= true)
        {
                var val_62 = 0;
            do
        {
            PlayerBotInstance val_19 = this.与上且丗丄七丑丆丑.Item[0];
            val_19.一丄一七上不丆下丆(丗丈东丕不丘三丞业:  val_19);
            val_62 = val_62 + 1;
        }
        while(val_62 != val_62);
        
        }
        
        val_65 = 0;
        val_66 = 0;
        val_67 = 0;
        goto label_36;
        label_58:
        val_68 = null;
        val_68 = null;
        val_69 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() >= 1)
        {
                val_70 = null;
            val_71 = Item[0];
            int val_23 = val_71.丘丑丅三丆丑丌且丝();
        }
        else
        {
                val_72 = null;
            NetworkStartTable val_24 = Item[0];
            val_71 = val_24.丝专不七不丏业世上;
        }
        
        var val_25 = (val_71 == 1) ? (val_67 + 1) : (val_67);
        var val_26 = (val_71 == 2) ? (val_66 + 1) : (val_66);
        val_65 = 1;
        label_36:
        val_73 = null;
        val_73 = null;
        val_74 = mem[GameController.onlineMode + 392];
        val_74 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_65 < Count)
        {
            goto label_58;
        }
        
        if((GameConnect.丗丁丟丑三丟万丕丌(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) == false)
        {
            goto label_78;
        }
        
        int val_31 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下();
        if((val_25 <= (((val_31 < 0) ? (val_31 + 1) : (val_31)) >> 1)) || ((val_31.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  1)) < 1))
        {
            goto label_66;
        }
        
        val_75 = 0;
        goto label_67;
        label_73:
        PlayerBotInstance val_34 = this.与上且丗丄七丑丆丑.Item[0];
        if(val_34.丟丛万丛三三业世丘 == 1)
        {
                PlayerBotInstance val_35 = this.与上且丗丄七丑丆丑.Item[0];
            val_35.一丄一七上不丆下丆(丗丈东丕不丘三丞业:  val_35);
        }
        
        val_75 = 1;
        label_67:
        val_74 = this.与上且丗丄七丑丆丑;
        if(val_75 < val_74.Count)
        {
            goto label_73;
        }
        
        label_66:
        int val_38 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下();
        if((val_26 <= (((val_38 < 0) ? (val_38 + 1) : (val_38)) >> 1)) || ((val_38.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  2)) < 1))
        {
            goto label_78;
        }
        
        val_76 = 0;
        goto label_79;
        label_85:
        PlayerBotInstance val_41 = this.与上且丗丄七丑丆丑.Item[0];
        if(val_41.丟丛万丛三三业世丘 == 2)
        {
                PlayerBotInstance val_42 = this.与上且丗丄七丑丆丑.Item[0];
            val_42.一丄一七上不丆下丆(丗丈东丕不丘三丞业:  val_42);
        }
        
        val_76 = 1;
        label_79:
        val_74 = this.与上且丗丄七丑丆丑;
        if(val_76 < val_74.Count)
        {
            goto label_85;
        }
        
        label_78:
        if(this.丙一东丏上丘与丏丂 > 0f)
        {
                float val_44 = UnityEngine.Time.deltaTime;
            val_44 = this.丙一东丏上丘与丏丂 - val_44;
            this.丙一东丏上丘与丏丂 = val_44;
            return;
        }
        
        this.丙一东丏上丘与丏丂 = UnityEngine.Random.Range(min:  3f, max:  6f);
        int val_46 = this.丏丁东丟世丟东丗上();
        var val_47 = (val_46 < 0) ? (val_46 + 1) : (val_46);
        bool val_49 = GameConnect.丗丁丟丑三丟万丕丌(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        if(val_49 == false)
        {
            goto label_89;
        }
        
        val_47 = val_47 >> 1;
        if((val_25 < val_47) || (val_26 < val_47))
        {
            goto label_114;
        }
        
        if(0 == 0)
        {
            goto label_92;
        }
        
        if(val_25 != val_26)
        {
            goto label_93;
        }
        
        int val_50 = val_49.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  1);
        if(val_50 < 1)
        {
                return;
        }
        
        if((val_50.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  2)) < 1)
        {
                return;
        }
        
        if(val_26 > val_47)
        {
            goto label_96;
        }
        
        return;
        label_89:
        int val_52 = (UnityEngine.Mathf.Min(a:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下() - 1, b:  this.丏丁东丟世丟东丗上())) - val_62;
        if(val_52 < 1)
        {
            goto label_98;
        }
        
        label_114:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_53 = this.丞丅丅丞丘不丅不丐();
        UnityEngine.GameObject val_54 = val_53.丟丌丙丒七丈丟丟丛(东一丁世丑丞业丄丐:  val_53);
        return;
        label_98:
        if((UnityEngine.Mathf.Min(a:  val_3, b:  -val_52)) < 1)
        {
                return;
        }
        
        PlayerBotInstance val_56 = this.与上且丗丄七丑丆丑.Item[0];
        val_56.一丄一七上不丆下丆(丗丈东丕不丘三丞业:  val_56);
        return;
        label_92:
        if(val_25 > val_47)
        {
                if((val_49.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  1)) >= 1)
        {
                val_78 = this;
            this.专上一世丂丂丝世丁(七一丞丈万丛下丘上:  1);
        }
        
        }
        
        if(val_26 <= val_47)
        {
                return;
        }
        
        if((this.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  2)) >= 1)
        {
            goto label_106;
        }
        
        return;
        label_93:
        if(val_25 <= val_26)
        {
            goto label_108;
        }
        
        if((val_49.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  1)) < 1)
        {
            goto label_112;
        }
        
        label_96:
        val_79 = 1;
        goto label_110;
        label_108:
        if(val_26 <= val_25)
        {
                return;
        }
        
        if((val_49.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  2)) < 1)
        {
            goto label_112;
        }
        
        label_106:
        val_79 = 2;
        label_110:
        this.专上一世丂丂丝世丁(七一丞丈万丛下丘上:  2);
        return;
        label_112:
        if(val_62 > true)
        {
                return;
        }
        
        goto label_114;
    }
    private int 且与丟丑丒丆丏丑丌(int 七一丞丈万丛下丘上)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = 0;
        val_6 = 0;
        goto label_1;
        label_17:
        val_7 = null;
        val_7 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() == 七一丞丈万丛下丘上)
        {
                val_8 = null;
            val_8 = null;
            NetworkStartTable val_3 = Item[0];
            val_6 = val_6 + val_3.一七不三丌专三丆一;
        }
        
        val_5 = 1;
        label_1:
        val_9 = null;
        val_9 = null;
        if(val_5 < Count)
        {
            goto label_17;
        }
        
        return (int)val_6;
    }
    private int 万丏丗且丐丛丛丐丁(int 七一丞丈万丛下丘上)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = 0;
        val_6 = 0;
        goto label_1;
        label_17:
        val_7 = null;
        val_7 = null;
        if(Item[0].丘丑丅三丆丑丌且丝() == 七一丞丈万丛下丘上)
        {
                val_8 = null;
            val_8 = null;
            NetworkStartTable val_3 = Item[0];
            bool val_5 = val_3.一七不三丌专三丆一;
            val_5 = val_5 ^ 1;
            val_6 = val_6 + val_5;
        }
        
        val_5 = 1;
        label_1:
        val_9 = null;
        val_9 = null;
        if(val_5 < Count)
        {
            goto label_17;
        }
        
        return (int)val_6;
    }
    private void 专上一世丂丂丝世丁(int 七一丞丈万丛下丘上)
    {
        var val_5;
        if((this.且与丟丑丒丆丏丑丌(七一丞丈万丛下丘上:  七一丞丈万丛下丘上)) < 1)
        {
                return;
        }
        
        val_5 = 0;
        goto label_2;
        label_7:
        PlayerBotInstance val_2 = this.与上且丗丄七丑丆丑.Item[0];
        if(val_2.丟丛万丛三三业世丘 == 七一丞丈万丛下丘上)
        {
            goto label_5;
        }
        
        val_5 = 1;
        label_2:
        if(val_5 < this.与上且丗丄七丑丆丑.Count)
        {
            goto label_7;
        }
        
        return;
        label_5:
        PlayerBotInstance val_4 = this.与上且丗丄七丑丆丑.Item[0];
        val_4.一丄一七上不丆下丆(丗丈东丕不丘三丞业:  val_4);
    }
    private void 东万丂丈上世丘丑业()
    {
        goto label_1;
        label_4:
        PlayerBotInstance val_1 = this.与上且丗丄七丑丆丑.Item[0];
        val_1.一丄一七上不丆下丆(丗丈东丕不丘三丞业:  val_1);
        0 = 1;
        label_1:
        if(0 < this.与上且丗丄七丑丆丑.Count)
        {
            goto label_4;
        }
    
    }
    internal int 丏丁东丟世丟东丗上()
    {
        PGCompany.丂专丞丟丂与丄万丌 val_1 = this.丂丆业且业丅丑丝丟();
        if(val_1 == null)
        {
                return (int)val_1;
        }
        
        PGCompany.丂专丞丟丂与丄万丌 val_2 = this.丂丆业且业丅丑丝丟();
        if(val_2 != null)
        {
                return val_2.丄丌丙丗下丒丆丐且();
        }
        
        return val_2.丄丌丙丗下丒丆丐且();
    }
    internal System.Collections.IEnumerator 丒丅丙丁丌丏丝丘东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new PlayerBotsManager.万丁丑丕与丙业丟与();
    }
    private System.Collections.IEnumerator 万丒万业业丝丝七丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerBotsManager.不丕丐三丝且世丕业();
    }
    private void 丘不专丘不专丙万世(int 万丙丆不下一丐且丆, bool 丗东世不丙丁丞世丛, int 丁丞丗业丆丒上丈丞)
    {
        var val_9;
        int val_10;
        val_9 = 0;
        goto label_1;
        label_18:
        if(丗东世不丙丁丞世丛 == false)
        {
            goto label_2;
        }
        
        PlayerBotInstance val_2 = this.与上且丗丄七丑丆丑.Item[0];
        if(val_2.世丌丐丁丂一丘丂一.丘丑丅三丆丑丌且丝() == 丁丞丗业丆丒上丈丞)
        {
            goto label_6;
        }
        
        label_11:
        val_10 = 1;
        goto label_7;
        label_2:
        PlayerBotInstance val_4 = this.与上且丗丄七丑丆丑.Item[0];
        if(val_4.世丌丐丁丂一丘丂一.丘丑丅三丆丑丌且丝() == 丁丞丗业丆丒上丈丞)
        {
            goto label_11;
        }
        
        label_6:
        val_10 = 万丙丆不下一丐且丆 + 1;
        label_7:
        PlayerBotController val_6 = this.业丌上丁下七不丐丝.Item[0];
        val_6.丌丕下东七丗丛丞下.三世丘丝丟不丝世上(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Min(a:  val_10, b:  3));
        val_9 = 1;
        label_1:
        if(val_9 < this.业丌上丁下七不丐丝.Count)
        {
            goto label_18;
        }
    
    }
    private void OnDestroy()
    {
        if(this.丅丈丒丑万丐丛万下 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丅丈丒丑万丐丛万下);
        this.丅丈丒丑万丐丛万下 = 0;
    }
    private bool 东丐丄丂且丒不丌丟(System.Collections.Generic.Dictionary<PlayerBotController, PlayerBotsManager.丅丘万丑东不业丛不> 丝业且丈万丏丒三万)
    {
        var val_11;
        var val_12;
        var val_13;
        丅丘万丑东不业丛不 val_2 = 0;
        val_11 = 0;
        val_12 = 0;
        val_13 = 1;
        goto label_1;
        label_6:
        bool val_3 = 丝业且丈万丏丒三万.TryGetValue(key:  this.业丌上丁下七不丐丝.Item[0], value: out  val_2);
        if(val_2 != 0)
        {
                int val_4 = val_2.一丕业丏丑丂丁丐丏();
        }
        
        val_11 = 1;
        label_1:
        if(val_11 < this.业丌上丁下七不丐丝.Count)
        {
            goto label_6;
        }
        
        return (bool)((((val_4 > val_13) ? (val_4) : (val_13)) < 7) ? 1 : 0) & ((((val_4 < val_12) ? (val_4) : (val_12)) > 4) ? 1 : 0);
    }
    private System.Collections.IEnumerator 丏丄与七丙丅丂丞丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerBotsManager.丄丈丕丁丈丟不丈专();
    }
    internal void 上丛丌丆丑上七世三()
    {
        var val_4;
        var val_5;
        val_4 = this;
        this.丝与丆丞东丘丈东丘 = true;
        this.丙一东丏上丘与丏丂 = UnityEngine.Random.Range(min:  3f, max:  6f);
        bool val_2 = GameConnect.七专丝上丆丆丒丐万();
        if(val_2 == false)
        {
                return;
        }
        
        val_4 = 0;
        goto label_4;
        label_7:
        UnityEngine.GameObject val_3 = val_2.不丅上丆万上丘丙东();
        val_4 = 1;
        label_4:
        val_5 = null;
        val_5 = null;
        if(val_4 < PlayerBotsManager.丅丗丕不七专世不万)
        {
            goto label_7;
        }
    
    }
    private bool 丘世与丑丅丁丅丐七()
    {
        null = null;
        return (bool)(丘丑丅三丆丑丌且丝() == 1) ? 1 : 0;
    }
    private bool 丂丑丘上七丞世丐丙()
    {
        var val_8;
        OnlineModeController val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_8 = null;
        val_8 = null;
        val_9 = GameController.onlineMode;
        if(val_9 == 0)
        {
            goto label_11;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = mem[GameController.onlineMode + 360];
        val_9 = GameController.onlineMode.teamController;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  val_9, y:  0);
        if(val_2 == false)
        {
            goto label_11;
        }
        
        val_11 = null;
        if(val_2.丘世与丑丅丁丅丐七() == false)
        {
            goto label_12;
        }
        
        val_12 = null;
        var val_5 = (((typeof(TeamController).__il2cppRuntimeField_38 - 3)) > typeof(TeamController).__il2cppRuntimeField_3C) ? 1 : 0;
        return (bool)val_13;
        label_11:
        val_13 = 0;
        return (bool)val_13;
        label_12:
        val_14 = null;
        var val_7 = (typeof(TeamController).__il2cppRuntimeField_38 < ((typeof(TeamController).__il2cppRuntimeField_3C - 3))) ? 1 : 0;
        return (bool)val_13;
    }
    private bool 七丑东七且丞丟丙丒()
    {
        null = null;
        return (bool)(业七业丅丅丝万丕丝() == 0) ? 1 : 0;
    }
    private void 丙与专东不三丄丒丒(bool 丁丝三丌丐丐东上丕)
    {
        var val_5;
        SavedAiLevels val_15;
        System.Int32[] val_16;
        System.Int32[] val_17;
        var val_19;
        var val_20;
        var val_22;
        SavedAiLevels val_23;
        SavedAiLevels val_24;
        System.Int32[] val_25;
        System.Int32[] val_26;
        System.Int32[] val_27;
        System.Int32[] val_29;
        val_15 = this;
        val_16 = 1152921505725111792;
        if(丁丝三丌丐丐东上丕 == false)
        {
            goto label_1;
        }
        
        val_17 = new int[4];
        Dictionary.Enumerator<TKey, TValue> val_2 = this.丞业丆上一丐丟七丂.GetEnumerator();
        val_19 = 1152921538693600640;
        val_20 = 1152921538693602688;
        goto label_3;
        label_7:
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        val_17[0] = val_6._value._obj.一丕业丏丑丂丁丐丏();
        label_3:
        if(((-272833504) & 1) != 0)
        {
            goto label_7;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_28;
        label_1:
        int[] val_8 = new int[9];
        val_17 = val_8;
        Dictionary.Enumerator<TKey, TValue> val_9 = this.丌三丒丟丙与与丌丛.GetEnumerator();
        val_19 = 1152921538693600640;
        val_20 = 1152921538693602688;
        val_16 = 0;
        goto label_10;
        label_14:
        ConfiguredValueTaskAwaiter val_10 = val_5.GetAwaiter();
        val_16 = 1;
        val_17[0] = val_10._value._obj.一丕业丏丑丂丁丐丏();
        label_10:
        if(((-272833504) & 1) != 0)
        {
            goto label_14;
        }
        
        val_22 = public System.Void Dictionary.Enumerator<PlayerBotController, 丅丘万丑东不业丛不>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_23 = this.世丐丙七与丛专丅三;
        val_24 = val_23;
        if(val_23 != null)
        {
            goto label_24;
        }
        
        val_24 = this.世丐丙七与丛专丅三;
        if(val_24 == null)
        {
            goto label_25;
        }
        
        label_24:
        val_25 = this.世丐丙七与丛专丅三.teammatesAiLevels;
        val_26 = this.世丐丙七与丛专丅三.enemiesAiLevels;
        val_27 = val_17;
        goto label_26;
        label_25:
        if(val_22 != 1)
        {
            goto label_39;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_28:
        val_23 = val_16;
        Dictionary.Enumerator<TKey, TValue> val_12 = this.丌三丒丟丙与与丌丛.GetEnumerator();
        goto label_30;
        label_34:
        ConfiguredValueTaskAwaiter val_13 = val_5.GetAwaiter();
        var val_15 = val_23 + 0;
        mem2[0] = val_13._value._obj.一丕业丏丑丂丁丐丏();
        label_30:
        if(((-272833504) & 1) != 0)
        {
            goto label_34;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_15 = this.世丐丙七与丛专丅三;
        if(val_15 != null)
        {
                val_29 = this.世丐丙七与丛专丅三.dmAiLevels;
        }
        else
        {
                val_29 = 4194311;
        }
        
        val_25 = val_17;
        val_26 = val_23;
        val_27 = val_29;
        label_26:
        val_15.丟丗丁下丒丗丒丘业(不业业且丙丙七丛丂:  val_8, 丕丆丞与专丝三下东:  val_26, 丒丒丂丛丐丕丐下不:  val_27);
        return;
        label_39:
    }
    public PlayerBotsManager()
    {
        this.与上且丗丄七丑丆丑 = new System.Collections.Generic.List<PlayerBotInstance>();
        this.业丌上丁下七不丐丝 = new System.Collections.Generic.List<PlayerBotController>();
        this.丞业丆上一丐丟七丂 = new System.Collections.Generic.Dictionary<PlayerBotController, 丅丘万丑东不业丛不>();
        this.丌三丒丟丙与与丌丛 = new System.Collections.Generic.Dictionary<PlayerBotController, 丅丘万丑东不业丛不>();
        this.世丐丙七与丛专丅三 = new PlayerBotsManager.SavedAiLevels();
        this.一一东不且丞丕东丘 = 0;
        this.丑丟与丏一丁一丞丐 = 0;
        this.丞上丘不下丞七万丐 = 0;
        this.下专丗丕丟且业与丙 = new System.Collections.Generic.HashSet<System.Int32>();
        this.不丐丞专丆东丘东东 = 10f;
        this.丘专下与三丗丝丝丁 = new float[3] {-6.352689E-23f, 8.82818E-44f, 4.172329E-08f};
    }
    private static PlayerBotsManager()
    {
        PlayerBotsManager.丅丗丕不七专世不万 = 9;
        PlayerBotsManager.丝七丐丞丞一业一业 = 4;
        PlayerBotsManager.丁丟丛业丅丘丙丕丗 = "savedlevelsai";
    }

}
