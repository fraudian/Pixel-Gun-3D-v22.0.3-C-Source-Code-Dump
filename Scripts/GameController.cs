using UnityEngine;
public sealed class GameController : MonoBehaviour
{
    // Fields
    private static GameController <不丁丄七丛不丆丁丕>k__BackingField;
    private bool 不七不丒丅且上且丟;
    public static GameModeController mode;
    public static OnlineModeController onlineMode;
    public static OfflineModeController offlineMode;
    private static System.Action 丂丙丈万东丕一三与;
    internal static InGameConnection 丆丘丂丈世丏丟丑丏;
    internal PGCompany.丒七丐丂丗丞下与丟 丒七丐丂丗丞下与丟;
    internal bool 万丕丘七丟丞丏不专;
    internal bool 丆世专丌丑世上丘不;
    private System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, string> 丙三三丆丕丞丙万丈;
    internal static bool 丒且丅丙丏丙不丒丙;
    internal LoadingNGUIController 三三丆下东丏丌丅上;
    
    // Properties
    internal static GameController 丆丕丝丒不丙且丐丗 { get; set; }
    
    // Methods
    internal static GameController 丑七不且上丗丁一世()
    {
        null = null;
        return (GameController)GameController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(GameController 丙业与丙丗丝不丈东)
    {
        null = null;
        GameController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public static void add_OnReturnToLobby(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GameController.丂丙丈万东丕一三与, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameController.丂丙丈万东丕一三与 != 1152921505189650464);
    
    }
    public static void remove_OnReturnToLobby(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GameController.丂丙丈万东丕一三与, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GameController.丂丙丈万东丕一三与 != 1152921505189650464);
    
    }
    private void Awake()
    {
        var val_7;
        GameController.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        bool val_2 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
        bool val_7 = ~val_2;
        val_7 = val_7 & 1;
        this.不七不丒丅且上且丟 = val_7;
        if(val_2 != true)
        {
                val_7 = null;
            val_7 = null;
            GameController.丒且丅丙丏丙不丒丙 = true;
            ActivityIndicator.万万丅丌丑丗丅世一(丙业与丙丗丝不丈东:  0.93f);
        }
        
        if(东丗上丁下业一丂丂.专七与丏丞丁丅丈丟() != false)
        {
                ActivityIndicator.丁与丏东且与万丝下();
        }
        
        this.丌七丞丆万丄丙丄丂();
        上丑三丁丄丛丁万丑.丑一丈丛专丈且业丅(丙业与丙丗丝不丈东:  new System.Action<System.String, CategoryNames, System.String>(object:  this, method:  System.Void GameController::世丌丘丈丏丞丐一三(string 丛丆东与丑丞丅丝专, CategoryNames 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丕丙万丛丂东丒丆万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void GameController::丞丞下丒丅丅丛世丕(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    private void 丞丞下丒丅丅丛世丕(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        this.丆世专丌丑世上丘不 = false;
        if(丗丛不丁丑专专丂且 == null)
        {
                return;
        }
        
        this.丆世专丌丑世上丘不 = 丗丛不丁丑专专丂且.世万丞三丏七且上与();
    }
    private void 世丌丘丈丏丞丐一三(string 丛丆东与丑丞丅丝专, CategoryNames 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)
    {
        if(不丁丌丐业丑丟且不 != 7)
        {
                return;
        }
        
        this.丆世专丌丑世上丘不 = true;
    }
    private void 丌七丞丆万丄丙丄丂()
    {
        object val_17;
        var val_18;
        var val_19;
        var val_20;
        UnityEngine.GameObject val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
            goto label_3;
        }
        
        val_17 = "PolygonMode";
        goto label_21;
        label_3:
        val_18 = null;
        val_18 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 0)
        {
            goto label_10;
        }
        
        }
        
        if((this.丙三三丆丕丞丙万丈.ContainsKey(key:  GameConnect.丑丌丛丈丅丅与不业())) == false)
        {
            goto label_14;
        }
        
        val_19 = this.丙三三丆丕丞丙万丈.Item[GameConnect.丑丌丛丈丅丅与不业()];
        goto label_18;
        label_14:
        val_20 = null;
        val_20 = null;
        var val_7 = (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true) ? "LegacyMode" : "OfflineMode";
        goto label_21;
        label_10:
        val_17 = "OfflineMode";
        label_21:
        label_18:
        UnityEngine.Object val_9 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "GameModes/{0}", arg0:  val_17));
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        if(val_9 != null)
        {
                var val_12 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_21 = 0;
        }
        
        val_22 = public GameModeController UnityEngine.GameObject::GetComponent<GameModeController>();
        val_23 = 1152921505189646336;
        val_24 = null;
        val_24 = null;
        GameController.mode = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_21, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}).GetComponent<GameModeController>();
        if(GameController.mode != null)
        {
                val_25 = 1152921505197314048;
            val_26 = 0;
            GameController.onlineMode = ;
            val_28 = null;
            GameController.丆丘丂丈世丏丟丑丏 = (mem[val_14] + 200 + (OnlineModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_14 : 0.connection;
            val_22 = 0;
            GameController.丆丘丂丈世丏丟丑丏.Initialize();
            this.万丕丘七丟丞丏不专 = true;
            val_29 = null;
        }
        
        val_29 = null;
        if(GameController.mode != null)
        {
                val_30 = 0;
            GameController.offlineMode = ;
            GameController.丆丘丂丈世丏丟丑丏 = 0;
            this.万丕丘七丟丞丏不专 = false;
        }
        
        val_29 = null;
        val_31 = mem[val_14];
        val_25 = ???;
        val_23 = ???;
        goto mem[val_14] + 360;
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GameController.不丏丅丙丞一丅世七();
    }
    private void Update()
    {
    
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 == false)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  56);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丐丞专专且丒七与();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丂丈七丏业且一东(不丒丄下丆丗丞丂一:  153);
        PGCompany.PixelPass.丐不丏一丝业下三三.丑七不且上丗丁一世().丁七丙下三与丄丒与();
    }
    private void OnDestroy()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_13 = null;
        val_13 = null;
        GameController.onlineMode = 0;
        GameController.offlineMode = 0;
        val_14 = null;
        val_14 = null;
        if((1152921505080864788 & 1) == 0)
        {
                val_15 = null;
            val_15 = null;
            if(null != 0)
        {
                val_16 = null;
            val_16 = null;
            if(ReviewController.丘丐丒丒三一丒丗丁() != false)
        {
                val_17 = static_value_081DACA8;
            val_17 = static_value_081DACA8;
            mem2[0] = 1;
        }
        
        }
        
        }
        
        if(PGCompany.ClanWarProgressController.丆丕丝丒不丙且丐丗 != 0)
        {
                PGCompany.ClanWarProgressController.丈丘业丁七丒丗丌丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  PGCompany.ClanWarProgressController.丆丕丝丒不丙且丐丗, method:  System.Void PGCompany.ClanWarProgressController::丏丝丗且上丂丄丕世(int 丝丌不东丕丒与丒丅)));
        }
        
        val_18 = null;
        val_18 = null;
        GameController.mode = 0;
        GameController.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
        val_19 = null;
        val_19 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        东丟丟万下丛丆丛丟.丟丌一丒业且丒丂丘();
        丁一业专丈三丄丘专.与一丅丝不丈业与丙().丂且不业丂专丛丆东();
        专丐下丁丘万丑丆万.与一丅丝不丈业与丙().丂且不业丂专丛丆东();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  56);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丐丞专专且丒七与();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丂丈七丏业且一东(不丒丄下丆丗丞丂一:  153);
        PGCompany.PixelPass.丐不丏一丝业下三三.丑七不且上丗丁一世().丁七丙下三与丄丒与();
        丘丛丞且一丅丁丏丐.东丙丄三丌丙且丄丁();
        上丑三丁丄丛丁万丑.丁七七丘且丈丂万丂(丙业与丙丗丝不丈东:  new System.Action<System.String, CategoryNames, System.String>(object:  this, method:  System.Void GameController::世丌丘丈丏丞丐一三(string 丛丆东与丑丞丅丝专, CategoryNames 不丁丌丐业丑丟且不, string 丌丙专丟丆丘上一丒)));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().下下丑丕且且业下丆(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void GameController::丞丞下丒丅丅丛世丕(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    internal void 丛七丟万丏丑丙丕丕(string 世丁丙世丄一万丆三 = "")
    {
        var val_12;
        var val_13;
        SceneInfo val_14;
        var val_15;
        var val_16;
        var val_17;
        if((System.String.IsNullOrEmpty(value:  世丁丙世丄一万丆三)) != true)
        {
                PGCompany.Analytics.一业丗丆世世上丁且.且丆丐专丆万丒业丐(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "client", 世丁丙世丄一万丆三:  世丁丙世丄一万丆三);
        }
        
        val_12 = null;
        val_12 = null;
        if(this.万丕丘七丟丞丏不专 != false)
        {
                coinsShop.丌业不世上丘丙且业();
            coinsPlashka.专东丁丕下东上丗丟();
            if(MatchmakingConnect.instance.InRequest != false)
        {
                MatchmakingConnect.instance.且丞七丕丕丕丄丆丅();
        }
        
            val_13 = null;
            val_13 = null;
            val_14 = 0;
            if(GameController.丆丘丂丈世丏丟丑丏 != 0)
        {
                val_15 = null;
            val_15 = null;
            val_14 = mem[GameController.丆丘丂丈世丏丟丑丏 + 48];
            val_14 = GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上;
        }
        
            if(MatchmakingConnect.丐万丗专丐丏丆丗丁() != false)
        {
                if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丏丈丗世丙万丆丐丅:  val_14)) != false)
        {
                PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈.丑七不且上丗丁一世().丙世丙丙东丆丙丁丅();
        }
        
        }
        
            if(this.万丕丘七丟丞丏不专 != false)
        {
                val_16 = null;
            val_16 = null;
            if(GameController.丆丘丂丈世丏丟丑丏.丐丒专丄万丄丒丙丛() != false)
        {
                val_17 = null;
            val_17 = null;
            GameController.丆丘丂丈世丏丟丑丏.下与业丒丝丕丙丘丙();
            return;
        }
        
        }
        
        }
        
        this.上丏丅上世丆丒丟丌();
    }
    internal void 上丏丅上世丆丒丟丌()
    {
        var val_1;
        System.Action val_2;
        if(this.万丕丘七丟丞丏不专 != false)
        {
                val_1 = null;
            val_1 = null;
            val_2 = GameController.丂丙丈万东丕一三与;
            if(val_2 != null)
        {
                val_2 = GameController.丂丙丈万东丕一三与;
            if(val_2 == null)
        {
                val_2 = 0;
        }
        
            val_2.Invoke();
        }
        
            ConnectScene.丌丝业丄三丗上丞东();
            return;
        }
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "LevelToCompleteProm");
    }
    public void ShowLoadingGUI(string 丛丘七丂且丟丁一丙)
    {
        UnityEngine.Texture val_19;
        var val_20;
        var val_21;
        UnityEngine.Texture val_22;
        var val_23;
        LoadingNGUIController val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
        this.三三丆下东丏丌丅上 = val_3;
        UnityEngine.AudioListener val_4 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<UnityEngine.AudioListener>(不下丙丟专丙丆万丆:  val_3);
        this.三三丆下东丏丌丅上.SceneToLoad = 丛丘七丂且丟丁一丙;
        if((丛丘七丂且丟丁一丙.Equals(value:  "main_loading")) == false)
        {
            goto label_8;
        }
        
        val_19 = ConnectScene.丗丅专与丁丙且且丐();
        this.三三丆下东丏丌丅上.SetQuitTexture(与万丆丛丒万丝丙丑:  val_19);
        goto label_12;
        label_8:
        string[] val_7 = new string[6];
        val_7[0] = "LevelLoadings";
        val_7[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "";
        val_7[2] = "/Loading_";
        val_7[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : "";
        val_7[4] = 丛丘七丂且丟丁一丙;
        val_20 = "";
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_21 = null;
            val_21 = null;
        }
        
        val_7[5] = (GameConnect.丙丙东七丙丞专丛不 == true) ? "_squad" : (val_20);
        val_19 = UnityEngine.Resources.Load(path:  +val_7);
        if(this.三三丆下东丏丌丅上 == null)
        {
            goto label_41;
        }
        
        if(val_19 == null)
        {
            goto label_42;
        }
        
        label_44:
        var val_16 = (null == null) ? (val_19) : 0;
        goto label_43;
        label_41:
        if(val_19 != null)
        {
            goto label_44;
        }
        
        label_42:
        val_22 = 0;
        label_43:
        this.三三丆下东丏丌丅上.SetLoadingTexture(与万丆丛丒万丝丙丑:  val_22);
        label_12:
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        this.三三丆下东丏丌丅上.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        this.三三丆下东丏丌丅上.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  false, 丐且丘丑与万丞丑丅:  0);
        val_23 = null;
        val_23 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
    }
    public GameController()
    {
        this.丒七丐丂丗丞下与丟 = new PGCompany.丒七丐丂丗丞下与丟();
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.String> val_2 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.String>();
        if(val_2 != null)
        {
                val_2.set_Item(key:  12, value:  "ArenaMode");
        }
        else
        {
                val_2.set_Item(key:  12, value:  "ArenaMode");
        }
        
        val_2.set_Item(key:  20, value:  "BattleRoyalMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  11, value:  "CampaignMode");
        }
        else
        {
                val_2.set_Item(key:  11, value:  "CampaignMode");
        }
        
        val_2.set_Item(key:  5, value:  "CapturePointsMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  25, value:  "ClassicArenaMode");
        }
        else
        {
                val_2.set_Item(key:  25, value:  "ClassicArenaMode");
        }
        
        val_2.set_Item(key:  9, value:  "DaterMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  3, value:  "DeadlyGamesMode");
        }
        else
        {
                val_2.set_Item(key:  3, value:  "DeadlyGamesMode");
        }
        
        val_2.set_Item(key:  10, value:  "DeathEscapeMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  0, value:  "DeathMatchMode");
        }
        else
        {
                val_2.set_Item(key:  0, value:  "DeathMatchMode");
        }
        
        val_2.set_Item(key:  8, value:  "DuelMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  22, value:  "DungeonsMode");
        }
        else
        {
                val_2.set_Item(key:  22, value:  "DungeonsMode");
        }
        
        val_2.set_Item(key:  4, value:  "FlagCaptureMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  27, value:  "FortAttackMode");
        }
        else
        {
                val_2.set_Item(key:  27, value:  "FortAttackMode");
        }
        
        val_2.set_Item(key:  26, value:  "FortDefenceMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  31, value:  "FreePlayMode");
        }
        else
        {
                val_2.set_Item(key:  31, value:  "FreePlayMode");
        }
        
        val_2.set_Item(key:  21, value:  "GliderMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  30, value:  "ImposterMode");
        }
        else
        {
                val_2.set_Item(key:  30, value:  "ImposterMode");
        }
        
        val_2.set_Item(key:  28, value:  "MMTeamFightMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  29, value:  "MonsterHunterMode");
        }
        else
        {
                val_2.set_Item(key:  29, value:  "MonsterHunterMode");
        }
        
        val_2.set_Item(key:  23, value:  "RacingMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  17, value:  "SiegeMode");
        }
        else
        {
                val_2.set_Item(key:  17, value:  "SiegeMode");
        }
        
        val_2.set_Item(key:  19, value:  "SniperMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  13, value:  "SpeedRunMode");
        }
        else
        {
                val_2.set_Item(key:  13, value:  "SpeedRunMode");
        }
        
        val_2.set_Item(key:  14, value:  "SpleefMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  16, value:  "TeamDuelMode");
        }
        else
        {
                val_2.set_Item(key:  16, value:  "TeamDuelMode");
        }
        
        val_2.set_Item(key:  2, value:  "TeamFightMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  1, value:  "TimeBattleMode");
        }
        else
        {
                val_2.set_Item(key:  1, value:  "TimeBattleMode");
        }
        
        val_2.set_Item(key:  32, value:  "ArmRaceMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  33, value:  "HoldPositionsMode");
        }
        else
        {
                val_2.set_Item(key:  33, value:  "HoldPositionsMode");
        }
        
        val_2.set_Item(key:  36, value:  "PlantTheBombMode");
        if(val_2 != null)
        {
                val_2.set_Item(key:  37, value:  "MutationMode");
        }
        else
        {
                val_2.set_Item(key:  37, value:  "MutationMode");
        }
        
        val_2.set_Item(key:  38, value:  "RedLightMode");
        this.丙三三丆丕丞丙万丈 = val_2;
    }
    private static GameController()
    {
    
    }

}
