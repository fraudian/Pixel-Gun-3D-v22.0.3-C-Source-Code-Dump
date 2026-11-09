using UnityEngine;
internal sealed class ConnectScene : MonoBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    internal static bool 三专丑丒丌丕丘丗三;
    private UnityEngine.GameObject oldConnectScene;
    private UnityEngine.GameObject newConnectScene;
    private static bool <且丗丙丆丏丌且且丗>k__BackingField;
    internal const int 丘丑上丏万世丁丁丌 = 10;
    public AllInterfacePanel allInterfacePanel;
    public ConnectSceneSelectMap connectSceneSelectMap;
    public UnityEngine.Transform connectSceneSelectMapTransform;
    public ConnectSceneMainMenu connectSceneMainMenu;
    public ConnectScenePanelEventHint connectScenePanelEventHint;
    public UnityEngine.Transform connectScenePanelTaskHint;
    private readonly System.Collections.Generic.List<ConnectScene.丝与一东丄三东丁上> 七丄丁丘丝丑三世专;
    private string 上下丟七丗业丁丒丕;
    internal static Rilisoft.七丕丟丏三丈一丄世 丙东丁丂丝世丑丒丘;
    public UnityEngine.Transform startMiniGameScreenParent;
    public UnityEngine.Transform dungeonWindowParent;
    public UnityEngine.Transform dungeonNoModulesWindowParent;
    internal DungeonWindowUI 丛丁丅丆丅与万三丅;
    internal DungeonNoModulesWindowUI 东丏丆东丆丐丁丌丈;
    public float widthCell;
    public int countMap;
    public UnityEngine.GameObject loadingMapPanel;
    public UITexture loadingToDraw;
    internal static bool 专上且丗丑丌丟丈丄;
    private bool 丌业业丛丞业七丘万;
    public string gameNameFilter;
    internal UnityEngine.GameObject Camera;
    public System.Collections.Generic.List<UnityEngine.GameObject> gamesInfo;
    private readonly System.Collections.Generic.List<丞丘丒一上与丕丒且> 丑丐丅丟下丞三丛且;
    private int 上丞且不七丙万万丘;
    private int 上丁丈丛丌上不丟与;
    private int 七一丟丆丟丞专丆东;
    private int 丗丌上丁且专丈上世;
    private int 一丁丈丗丄丛丑丗业;
    internal static ConnectScene 丄丞丁丈与业上丞丟;
    private string 东丅丒丛丏丄丒丞专;
    public LANBroadcastService lanScan;
    private 丞丘丒一上与丕丒且 一世东丄丗丆丘丛丂;
    private bool 丘丛上丑丗上世专业;
    private bool 丈丝丛东且丁丝且三;
    internal bool 七丘丝丆丏丘丗丏丄;
    private bool 丛丂丘三丐丐丕世丂;
    private Rilisoft.AdvertisementController 丙丕丌丒丞丕不上万;
    public bool isStartShowAdvert;
    public UnityEngine.GameObject competitionSelectPanel;
    private readonly Rilisoft.七丕丟丏三丈一丄世[] 上丒一万世丐丝丏丞;
    public UnityEngine.AudioClip battleNowButtonSound;
    internal static string 丑业业业丒丏丈丞下;
    public UnityEngine.GameObject modeAnimObj;
    public UnityEngine.GameObject hintMapBlocker;
    public UnityEngine.GameObject hintGoBattleBlocker;
    private MapTournamentEventUi 专丛丕七七丅丙丕丅;
    private PreviewClanWarTaskUi 世上世丁下丕丑丕丛;
    internal bool 丏上丒专丞丑东且丞;
    private UnityEngine.Texture 丗丗丈一世丞丏丙丟;
    private UnityEngine.Texture 丅丘丘三三丒不业且;
    private readonly System.Collections.Generic.Dictionary<string, UnityEngine.Texture> 下丒丏丙一不七丕丏;
    private string 丂丝丕三东丏三且下;
    internal ConnectionControl 丙不丅丝丙专丕世丐;
    private UIPanel 丂丝七丂一专专东丘;
    private System.Collections.Generic.Dictionary<int, MapPreviewController> 丂丁七丙下丞丗丁业;
    private SpringPanel 丂不丅一上不丞下且;
    private UIScrollView 丙丟丁业世丆七丌丆;
    private UIPanel 丕丗丑三丆下上与万;
    private UIGrid 丞七丞世下世上上业;
    private static bool 丁丝丒丕丘不丁丁丂;
    public bool waitForSquad;
    private bool 丕丛丐丑丝丏丑丌一;
    private const string 业丟丁且上七丞丁丟 = "SiegeModeAnimated";
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, Progress.不专丂万丐丄七上丗> 业丌丐且七丘东上丗;
    private System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> 丟上丒丕丛丒丆上丌;
    private bool 丏丑丆丐丏丐下与丘;
    internal const string 一七丁三丄专下且丂 = "LA_ST_CHO_OS_ED_GA_ME_MOD_";
    private bool 东三丘丘丝丛不丆丆;
    private bool 万不专丕丒东世三丘;
    private bool 丁丙丄万丅下丐丐东;
    private static bool <七业丈东丆丈丗丂丏>k__BackingField;
    internal static bool 专七下丑丈三上下丞;
    private UnityEngine.Vector3 丏丘丞丆与丕三丝丘;
    private bool 丄东丑与丕东七丆丈;
    private StartMiniGameGuiController 丈丁下丟不不丛丗丏;
    internal System.Action 且丂丗七丕上丄丘与;
    private bool 丆丙丗下专万丗世丑;
    private int 丟上丐三丌丗丏丕三;
    private bool 东丆且丏丕七丟丌业;
    private bool 丙一丑丘丘万东七丟;
    private static bool 丛丆丑三丞丏一丆丆;
    internal static bool 丝上丅丒丂与与不丁;
    private bool 与丘丏丆丁世世丁丗;
    private bool 丛丗与丗下丐三上一;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private System.IDisposable 七丑丅业丘丅专丁丗;
    private System.IDisposable 丏七一七丕不不专丈;
    private int 丄丈丟丙不世与丅丈;
    private string 业且丄丟世且丄世下;
    private bool 上丐丑丟丁上且七丗;
    public System.Collections.Generic.List<FilterMaps> watchedCompetitionFiltermaps;
    public PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 tempSelectedEvent;
    private float 丟丗不丈七下丗与三;
    private System.Collections.Generic.List<ConnectScene.业丂丌丞丆东丏世万> 业不专丛世丄与上丒;
    private System.Collections.Generic.List<ConnectScene.业丂丌丞丆东丏世万> 丂丗丙丆丕丁丛业丐;
    private System.Collections.Generic.List<SceneInfo> 一下丏一丅丝丂上不;
    private bool 万丌丗七丑丄下丞与;
    private bool 丛丗丆丏丟丞东丝丒;
    private bool 上丐丐丆丝丕丟一丁;
    private int 丕专丗万上丁世丝丁;
    private float 丒丙丘丟且丈丗且丞;
    private float 丏丝丕丈丑丙丄丁业;
    private float 丐与丒丐七丙丌三不;
    private float 七与丌三丙丈丅丕丕;
    private LoadingNGUIController 三三丆下东丏丌丅上;
    private LANBroadcastService.丈丒世与万丘丈三专[] 专东丝七丄丞且丛丛;
    private UnityEngine.Vector3 丙一不且丑丆丆丂丆;
    private UnityEngine.Coroutine 不专且丕丘丝丗丄与;
    private float 丂与丛上不丑东丒丘;
    private static bool 丄丟不丌丑下世与丄;
    
    // Properties
    internal static bool 丞七丛与丝下一一丆 { get; set; }
    internal static bool 丐丒丕且丌东丐三丁 { get; }
    internal Rilisoft.七丕丟丏三丈一丄世[] 三三丆丘万丘三丛丘 { get; }
    internal MapTournamentEventUi 丏丈丆业丗不世丗丑 { get; }
    internal PreviewClanWarTaskUi 丘且世三一七万丘一 { get; }
    internal bool 丝三丞丕七丈丅丐世 { get; }
    private UIPanel 丝丝丁业丑丄丏丝丝 { get; }
    private SpringPanel 丙丘万丑丝丅丂丞丅 { get; }
    private UIScrollView 丛丂丏丞万丘一丄丅 { get; }
    private UIPanel 不丗丕丈丐丒丗一丈 { get; }
    private UIGrid 丒世丛业丟业丏丟丑 { get; }
    internal bool 丗丛三丗不丑世丟丙 { get; }
    internal bool 丂且丂丅一万丏东世 { get; }
    public System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> 丏业丛且业东三丒丝 { get; }
    public static int 丕专与丁世丄丒上丟 { get; set; }
    internal static bool 丆丂丏三丐世三丌不 { get; set; }
    public Rilisoft.DoubleRewardConnectScene 业不不丕不丙丞丆七 { get; }
    public Rilisoft.NeedSquadLevelConnectScene 世丅丑东三世丆三丝 { get; }
    private static bool 万万世且下丞丏专丙 { get; set; }
    private int 丞世万且丄不丗业丘 { get; }
    internal bool 丏丌丞丙下三丟丏丙 { get; }
    internal static bool 丙丁丞且专丑丌东丞 { get; }
    private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    internal static bool 丒丆丘丌丘且丛丑丙 { set; }
    
    // Methods
    internal static bool 丈丘丂丙不丛业丟三()
    {
        null = null;
        return (bool)ConnectScene.<且丗丙丆丏丌且且丗>k__BackingField;
    }
    private static void 东丈业东丛丗七丘不(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        ConnectScene.<且丗丙丆丏丌且且丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 一下丗不丒丙与七丛()
    {
        var val_4;
        if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() == 0)
        {
                if(PGCompany.BattlePass.BPTutorialController.不上且丈下丘丁丝七() != false)
        {
                val_4 = 1;
            return (bool)val_4;
        }
        
        }
        
        if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() >= 1)
        {
                return PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞();
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal Rilisoft.七丕丟丏三丈一丄世[] 丏丕三一不丙丈与丒()
    {
        return (Rilisoft.七丕丟丏三丈一丄世[])this.上丒一万世丐丝丏丞;
    }
    internal MapTournamentEventUi 三丗一业丙丑丂丐丛()
    {
        MapTournamentEventUi val_11;
        if(this.专丛丕七七丅丙丕丅 != 0)
        {
            goto label_3;
        }
        
        MapTournamentEventUi val_2 = UnityEngine.Resources.Load<MapTournamentEventUi>(path:  "ContestWindows/Contest_mainUI");
        UnityEngine.Vector3 val_4 = val_2.transform.localPosition;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        UnityEngine.Transform val_7 = UnityEngine.Object.Instantiate<MapTournamentEventUi>(original:  val_2, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}).丌丟丄业且三丛丕丄();
        val_7.SetParent(p:  this.connectScenePanelEventHint.transform);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_7.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        if(val_7 == null)
        {
            goto label_16;
        }
        
        val_7.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_17;
        label_3:
        val_11 = this.专丛丕七七丅丙丕丅;
        return val_10;
        label_16:
        0.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_17:
        MapTournamentEventUi val_10 = val_7.GetComponent<MapTournamentEventUi>();
        this.专丛丕七七丅丙丕丅 = val_10;
        return val_10;
    }
    internal PreviewClanWarTaskUi 东上丕丙丌丈丈业丑()
    {
        PreviewClanWarTaskUi val_11;
        if(this.世上世丁下丕丑丕丛 != 0)
        {
            goto label_3;
        }
        
        PreviewClanWarTaskUi val_2 = UnityEngine.Resources.Load<PreviewClanWarTaskUi>(path:  "NguiWindows/Clan/ClanWarTask_CS_UI");
        UnityEngine.Vector3 val_4 = val_2.transform.localPosition;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        UnityEngine.Transform val_7 = UnityEngine.Object.Instantiate<PreviewClanWarTaskUi>(original:  val_2, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}).丌丟丄业且三丛丕丄();
        val_7.SetParent(p:  this.connectScenePanelTaskHint.transform);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_7.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        if(val_7 == null)
        {
            goto label_16;
        }
        
        val_7.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_17;
        label_3:
        val_11 = this.世上世丁下丕丑丕丛;
        return val_10;
        label_16:
        0.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_17:
        PreviewClanWarTaskUi val_10 = val_7.GetComponent<PreviewClanWarTaskUi>();
        this.世上世丁下丕丑丕丛 = val_10;
        return val_10;
    }
    internal bool 世丞不丈丕丝东丞上()
    {
        return (bool)this.丏上丒专丞丑东且丞;
    }
    internal UnityEngine.Texture 丂丐业丘丑丒三万丒(string 七丆丂丂下丈且丟世)
    {
        var val_7;
        if((this.下丒丏丙一不七丕丏.ContainsKey(key:  七丆丂丂下丈且丟世)) != false)
        {
                val_7 = this.下丒丏丙一不七丕丏.Item[七丆丂丂下丈且丟世];
            return (UnityEngine.Texture);
        }
        
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Loading_{1}", arg0:  this.丂丝丕三东丏三且下, arg1:  七丆丂丂下丈且丟世));
        val_7 = 0;
        if( == 0)
        {
                return (UnityEngine.Texture);
        }
        
        this.下丒丏丙一不七丕丏.Add(key:  七丆丂丂下丈且丟世, value:  null);
        return (UnityEngine.Texture);
    }
    public void HandleClanSiegeButton()
    {
        UnityEngine.Object val_4;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_4 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_4.ForceShowBanner(丌丅丕一丛丛丄一万:  23, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    internal static UnityEngine.Texture 丗丅专与丁丙且且丐()
    {
        if(Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂() == 0)
        {
                return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "main_loading_Hi" : "main_loading");
        }
        
        UnityEngine.Texture2D val_3 = Rilisoft.丛丅丘业丏丕下业丏.世丄七丅专且万丁丂();
        return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "main_loading_Hi" : "main_loading");
    }
    private UIPanel 世丘丞丝丞丘三且丞()
    {
        if(this.丂丝七丂一专专东丘 != 0)
        {
                return (UIPanel)this.丂丝七丂一专专东丘;
        }
        
        if(this.connectSceneSelectMap.ScrollTransform == 0)
        {
                return (UIPanel)this.丂丝七丂一专专东丘;
        }
        
        this.丂丝七丂一专专东丘 = this.connectSceneSelectMap.ScrollTransform.GetComponent<UIPanel>();
        return (UIPanel)this.丂丝七丂一专专东丘;
    }
    private SpringPanel 丈丌下三专丆业与丕()
    {
        if(this.丂不丅一上不丞下且 != 0)
        {
                return (SpringPanel)this.丂不丅一上不丞下且;
        }
        
        if(this.connectSceneSelectMap.ScrollTransform == 0)
        {
                return (SpringPanel)this.丂不丅一上不丞下且;
        }
        
        this.丂不丅一上不丞下且 = this.connectSceneSelectMap.ScrollTransform.GetComponent<SpringPanel>();
        return (SpringPanel)this.丂不丅一上不丞下且;
    }
    private UIScrollView 丒丂丐丝丒丛丁丒丈()
    {
        if(this.丙丟丁业世丆七丌丆 != 0)
        {
                return (UIScrollView)this.丙丟丁业世丆七丌丆;
        }
        
        if(this.connectSceneSelectMap.scrollViewSelectMapTransform == 0)
        {
                return (UIScrollView)this.丙丟丁业世丆七丌丆;
        }
        
        this.丙丟丁业世丆七丌丆 = this.connectSceneSelectMap.scrollViewSelectMapTransform.GetComponent<UIScrollView>();
        return (UIScrollView)this.丙丟丁业世丆七丌丆;
    }
    private UIPanel 下丐丝丗东丙下世丄()
    {
        if(this.丕丗丑三丆下上与万 != 0)
        {
                return (UIPanel)this.丕丗丑三丆下上与万;
        }
        
        if(this.connectSceneSelectMap.scrollViewSelectMapTransform == 0)
        {
                return (UIPanel)this.丕丗丑三丆下上与万;
        }
        
        this.丕丗丑三丆下上与万 = this.connectSceneSelectMap.scrollViewSelectMapTransform.GetComponent<UIPanel>();
        return (UIPanel)this.丕丗丑三丆下上与万;
    }
    private UIGrid 一丌丒丛丈且不业且()
    {
        if(this.丞七丞世下世上上业 != 0)
        {
                return (UIGrid)this.丞七丞世下世上上业;
        }
        
        if(this.connectSceneSelectMap.grid == 0)
        {
                return (UIGrid)this.丞七丞世下世上上业;
        }
        
        this.丞七丞世下世上上业 = this.connectSceneSelectMap.grid.GetComponent<UIGrid>();
        return (UIGrid)this.丞七丞世下世上上业;
    }
    private static void 上丘不丏下丅丕丛世()
    {
        null = null;
        MainMenuController.下且丄丝丘丝丈上丒 = true;
        ConnectScene.上丄与丂不且丑丞丛();
    }
    private static void 丟丐丄丂丄不丆丞丐()
    {
        null = null;
        MainMenuController.业万且与丘与与三丕 = true;
        ConnectScene.上丄与丂不且丑丞丛();
    }
    private static void 丝丟丄丕下下一专丅()
    {
        null = null;
        MainMenuController.丗业丒三丘上丌丄七 = true;
        ConnectScene.上丄与丂不且丑丞丛();
    }
    private static void 三丛东丟丟三下丝丝()
    {
        null = null;
        MainMenuController.万丂丅丕丏丐丈东世 = true;
        ConnectScene.上丄与丂不且丑丞丛();
    }
    private static void 业世丙丆丒丁与丂专()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        MainMenuController.业丌专丒丛三不业且 = true;
        val_2 = null;
        val_2 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        ConnectScene.上丄与丂不且丑丞丛();
    }
    internal static void 上丄与丂不且丑丞丛()
    {
        LoadingNGUIController val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
        val_3.SetQuitTexture(与万丆丛丒万丝丙丑:  ConnectScene.丗丅专与丁丙且且丐());
        if(val_3 != null)
        {
                val_3.SceneToLoad = System.String.alignConst;
        }
        else
        {
                val_3.SceneToLoad = System.String.alignConst;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_3.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        val_3.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  false, 丐且丘丑与万丞丑丅:  0);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐());
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
    }
    private static void 丕世丛业丌丗丗丕丁()
    {
        ShopNGUIController val_13;
        var val_14;
        ShopNGUIController val_15;
        var val_16;
        if((BankController.丑七不且上丗丁一世() != 0) && (BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false))
        {
                if(BankController.丑七不且上丗丁一世().丅丘专丅丏丏丆业三() != 0)
        {
                AbstractBankView val_9 = BankController.丑七不且上丗丁一世().丅丘专丅丏丏丆业三();
            val_9.backButton.DoClick();
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        }
        
        }
        
        val_13 = 1152921505261211648;
        val_14 = null;
        val_14 = null;
        val_15 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_15 == 0)
        {
                return;
        }
        
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        val_16 = null;
        val_13 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        val_16 = null;
        val_15 = ConnectScene.<>c.<>9__98_0;
        if(val_15 == null)
        {
            goto label_31;
        }
        
        label_36:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = val_15;
        return;
        label_31:
        ConnectScene.<>c.<>9__98_0 = new System.Action(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectScene.<>c::东与丅丘丕且丆丁丌());
        if(val_13 != null)
        {
            goto label_36;
        }
        
        goto label_36;
    }
    internal bool 专丗丏丛丅东与万丘()
    {
        if(this.丙不丅丝丙专丕世丐 != null)
        {
                return (bool)this.丙不丅丝丙专丕世丐.canShowStubLoading;
        }
        
        return (bool)this.丙不丅丝丙专丕世丐.canShowStubLoading;
    }
    internal static void 丌丝业丄三丗上丞东()
    {
        var val_4;
        var val_5;
        var val_6;
        丘丑丏业专丞业丆三 val_8;
        var val_9;
        var val_10;
        var val_14;
        var val_16;
        GameConnect.丘丕丈丄丛业东丈丝(丙业与丙丗丝不丈东:  0);
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 != false)
        {
                val_5 = null;
            val_5 = null;
            MainMenuController.丂不三丈丕丑丌业下 = 0;
        }
        
        ConnectScene.丕世丛业丌丗丗丕丁();
        GameConnect.下与业丒丝丕丙丘丙();
        val_6 = null;
        val_6 = null;
        val_8 = 与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅;
        if(val_8 != 1)
        {
            goto label_14;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_17;
        }
        
        Rilisoft.ClansLobbyGui.东丗丁丂专七丑丞丈();
        goto label_49;
        label_14:
        val_6 = null;
        val_8 = 与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅;
        if(val_8 != 3)
        {
            goto label_21;
        }
        
        ConnectScene.业世丙丆丒丁与丂专();
        goto label_49;
        label_17:
        Rilisoft.ClansLobbyGui.丘不丌丈下专丘东七();
        goto label_49;
        label_21:
        val_6 = null;
        if(与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 == false)
        {
            goto label_28;
        }
        
        ConnectScene.丝丟丄丕下下一专丅();
        goto label_49;
        label_28:
        if(与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 == false)
        {
            goto label_34;
        }
        
        ConnectScene.丟丐丄丂丄不丆丞丐();
        goto label_49;
        label_34:
        val_9 = null;
        val_9 = null;
        if((1152921505080864788 & 1) == 0)
        {
            goto label_40;
        }
        
        label_69:
        ConnectScene.上丄与丂不且丑丞丛();
        goto label_49;
        label_40:
        val_10 = null;
        val_10 = null;
        if(与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 == false)
        {
            goto label_46;
        }
        
        ConnectScene.三丛东丟丟三下丝丝();
        goto label_49;
        label_46:
        val_10 = null;
        if(与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 == false)
        {
            goto label_52;
        }
        
        val_10 = null;
        if(与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 != false)
        {
                val_14 = null;
            val_14 = null;
            val_10 = null;
            MainMenuController.丁丝丒丕丘不丁丁丂 = true;
        }
        
        val_10 = null;
        Rilisoft.ClansLobbyGui.丝万丈丕一丝丙丌丘 = (与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 == 2) ? 1 : 0;
        ConnectScene.上丘不丏下丅丕丛世();
        label_49:
        System.DateTime val_3 = System.DateTime.UtcNow;
        Rilisoft.ClansLobbyGui.丁丛东业丕丈丕丆东 = val_3.dateData;
        return;
        label_52:
        val_16 = null;
        if(与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 == false)
        {
            goto label_69;
        }
        
        val_16 = null;
        ConnectScene.丁丝丒丕丘不丁丁丂 = true;
        goto label_69;
    }
    internal static void 与丄丅丁丂丏东下丝()
    {
        var val_2;
        UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丕上丙万丂丛三丗与(), value:  1);
        val_2 = null;
        val_2 = null;
        丟丌丁且且世丈丈丟.与七东且丂上丛丆上 = 0;
        丟丌丁且且世丈丈丟.丆业不三丆下丄丂丑 = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "SkinEditor");
    }
    internal bool 东丙丟丁丅一七丂丈()
    {
        return (bool)this.丕丛丐丑丝丏丑丌一;
    }
    private void 业丅东七且丅丛七丟()
    {
        if(this.丕丛丐丑丝丏丑丌一 != false)
        {
                return;
        }
        
        this.与一丂且丆七东三丏();
    }
    private void 与一丂且丆七东三丏()
    {
        if(this.丕丛丐丑丝丏丑丌一 != false)
        {
                if(this.modeAnimObj != 0)
        {
                this.modeAnimObj.SetActive(value:  false);
        }
        
        }
        
        this.不丗丒专丅丙专丏专();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.专丐东且丄与丆一丟());
    }
    private UnityEngine.GameObject 丌不七业丈丘丅丛丕()
    {
        UnityEngine.GameObject val_3;
        if(this.modeAnimObj == 0)
        {
                this.modeAnimObj = this.丁丞业七世丆丈不世();
            return val_3;
        }
        
        val_3 = this.modeAnimObj;
        return val_3;
    }
    private UnityEngine.GameObject 丁丞业七世丆丈不世()
    {
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "ConnectScene/UnlockAnimationInConnectScene"));
        val_2.transform.parent = this.transform.GetChild(index:  0);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        val_2.transform.GetChild(index:  0).GetComponent<UnityEngine.AudioSource>().enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        return val_2;
    }
    private void 丁丈不与且下万丕丌()
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "SiegeModeAnimated", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private bool 丟丌专丗丕下丈丏丆()
    {
        var val_4;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "SiegeModeAnimated")) != false)
        {
                var val_3 = ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "SiegeModeAnimated", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> get_UnlockGameModes()
    {
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_1 = this.丟上丒丕丛丒丆上丌;
        if(val_1 != null)
        {
                return val_1;
        }
        
        this.与下且丐丛丐丘丆上();
        val_1 = this.丟上丒丕丛丒丆上丌;
        return val_1;
    }
    private void 与下且丐丛丐丘丆上()
    {
        var val_7;
        var val_8;
        val_7 = this;
        this.丟上丒丕丛丒丆上丌 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
        val_8 = null;
        val_8 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = ConnectScene.业丌丐且七丘东上丗.GetEnumerator();
        label_10:
        if(( & 1) == 0)
        {
            goto label_4;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  val_3)) == false)
        {
            goto label_10;
        }
        
        this.丟上丒丕丛丒丆上丌.Add(item:  val_3.丙东专丂世丈丏丁丂());
        goto label_10;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 万丛丛丙一下丌丒一(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_6;
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_7;
        var val_8;
        var val_9;
        val_6 = 上且丗一丏丏万丅丌;
        val_7 = this.丟上丒丕丛丒丆上丌;
        if(val_7 == null)
        {
                this.与下且丐丛丐丘丆上();
            val_7 = this.丟上丒丕丛丒丆上丌;
            if(val_7 == null)
        {
                val_7 = 0;
        }
        
        }
        
        if((val_7.Contains(item:  val_6)) == true)
        {
                return;
        }
        
        if(this.丟上丒丕丛丒丆上丌 == null)
        {
                this.与下且丐丛丐丘丆上();
        }
        
        0.Add(item:  val_6);
        val_8 = null;
        val_8 = null;
        if((ConnectScene.业丌丐且七丘东上丗.ContainsKey(key:  val_6)) != false)
        {
                val_9 = null;
            val_9 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  ConnectScene.业丌丐且七丘东上丗.Item[val_6]);
            return;
        }
        
        object[] val_5 = new object[1];
        val_6 = val_6;
        val_5[0] = val_6;
        UnityEngine.Debug.LogErrorFormat(format:  "*********** Нет такого игрового режима в словаре _gameModesConverter  {0}", args:  val_5);
    }
    private void 业万丄不与丞丌七丙(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_7;
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_8;
        var val_9;
        var val_10;
        val_7 = 上且丗一丏丏万丅丌;
        val_8 = this.丟上丒丕丛丒丆上丌;
        if(val_8 == null)
        {
                this.与下且丐丛丐丘丆上();
            val_8 = this.丟上丒丕丛丒丆上丌;
            if(val_8 == null)
        {
                val_8 = 0;
        }
        
        }
        
        if((val_8.Contains(item:  val_7)) == false)
        {
                return;
        }
        
        if(this.丟上丒丕丛丒丆上丌 == null)
        {
                this.与下且丐丛丐丘丆上();
        }
        
        bool val_2 = 0.Remove(item:  val_7);
        val_9 = null;
        val_9 = null;
        if((ConnectScene.业丌丐且七丘东上丗.ContainsKey(key:  val_7)) != false)
        {
                val_10 = null;
            val_10 = null;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  ConnectScene.业丌丐且七丘东上丗.Item[val_7]);
            return;
        }
        
        object[] val_6 = new object[1];
        val_7 = val_7;
        val_6[0] = val_7;
        UnityEngine.Debug.LogErrorFormat(format:  "*********** Нет такого игрового режима в словаре _gameModesConverter  {0}", args:  val_6);
    }
    internal static System.Collections.Generic.List<Progress.不专丂万丐丄七上丗> 七丘不与丁不业丄丏()
    {
        var val_33;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_43;
        var val_47;
        var val_48;
        var val_49;
        var val_53;
        var val_54;
        var val_56;
        .业丄专丙上丝丑丕丕 = false;
        System.Linq.ILookup<TKey, TSource> val_8 = System.Linq.Enumerable.ToLookup<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(source:  System.Linq.Enumerable.Where<Rilisoft.七丕丟丏三丈一丄世>(source:  Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().丏丙丐丕下三丗丁且(), predicate:  new System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Boolean>(object:  new ConnectScene.丆丕丒不丕不丘丞丒(), method:  System.Boolean ConnectScene.丆丕丒不丕不丘丞丒::丐丂丁丒且丆丌下丟(Rilisoft.七丕丟丏三丈一丄世 与丝丛东上丆丁丘丕))), keySelector:  new System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(object:  Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世(), method:  System.Int32 Rilisoft.一世东上七三丌丅不::丒与丆三丟三丈丄丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)));
        System.Collections.Generic.List<Progress.不专丂万丐丄七上丗> val_10 = new System.Collections.Generic.List<Progress.不专丂万丐丄七上丗>();
        var val_43 = 0;
        val_43 = val_43 + 1;
        System.Collections.Generic.IEnumerator<T> val_12 = val_8.GetEnumerator();
        label_34:
        label_28:
        var val_44 = 0;
        val_44 = val_44 + 1;
        if(val_12.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        T val_16 = val_12.Current;
        var val_48 = val_16;
        if((val_16 + 286) == 0)
        {
            goto label_27;
        }
        
        var val_46 = val_16 + 176;
        var val_47 = 0;
        val_46 = val_46 + 8;
        label_26:
        if(((val_16 + 176 + 8) + -8) == null)
        {
            goto label_25;
        }
        
        val_47 = val_47 + 1;
        val_46 = val_46 + 16;
        if(val_47 < (val_16 + 286))
        {
            goto label_26;
        }
        
        goto label_27;
        label_25:
        val_48 = val_48 + (((val_16 + 176 + 8)) << 4);
        val_37 = val_48 + 296;
        label_27:
        if(val_16.Key <= 0)
        {
            goto label_28;
        }
        
        var val_51 = val_16;
        if((val_16 + 286) == 0)
        {
            goto label_33;
        }
        
        var val_49 = val_16 + 176;
        var val_50 = 0;
        val_49 = val_49 + 8;
        label_32:
        if(((val_16 + 176 + 8) + -8) == null)
        {
            goto label_31;
        }
        
        val_50 = val_50 + 1;
        val_49 = val_49 + 16;
        if(val_50 < (val_16 + 286))
        {
            goto label_32;
        }
        
        goto label_33;
        label_31:
        val_51 = val_51 + (((val_16 + 176 + 8)) << 4);
        val_38 = val_51 + 296;
        label_33:
        TKey val_18 = val_16.Key;
        goto label_34;
        label_17:
        val_39 = 0;
        val_40 = 0;
        if(val_12 == null)
        {
            
        }
        else
        {
                var val_52 = 0;
            val_52 = val_52 + 1;
            val_12.Dispose();
        }
        
        if(( != 1) && (147 == 147))
        {
                val_39 = 0;
        }
        else
        {
                if( != false)
        {
                val_40 = 0;
        }
        
        }
        
        val_43 = 0;
        var val_53 = 0;
        val_53 = val_53 + 1;
        val_43 = 0;
        System.Collections.Generic.IEnumerator<T> val_22 = val_8.GetEnumerator();
        label_143:
        label_79:
        var val_54 = 0;
        val_54 = val_54 + 1;
        val_43 = 0;
        if(val_22.MoveNext() == false)
        {
            goto label_62;
        }
        
        var val_55 = 0;
        val_55 = val_55 + 1;
        val_43 = 0;
        T val_26 = val_22.Current;
        var val_58 = val_26;
        if((val_26 + 286) == 0)
        {
            goto label_69;
        }
        
        var val_56 = val_26 + 176;
        var val_57 = 0;
        val_56 = val_56 + 8;
        label_71:
        if(((val_26 + 176 + 8) + -8) == null)
        {
            goto label_70;
        }
        
        val_57 = val_57 + 1;
        val_56 = val_56 + 16;
        if(val_57 < (val_26 + 286))
        {
            goto label_71;
        }
        
        label_69:
        val_43 = 0;
        goto label_72;
        label_70:
        val_58 = val_58 + (((val_26 + 176 + 8)) << 4);
        val_47 = val_58 + 296;
        label_72:
        if(val_26.Key < 2)
        {
            goto label_79;
        }
        
        var val_61 = val_26;
        if((val_26 + 286) == 0)
        {
            goto label_75;
        }
        
        var val_59 = val_26 + 176;
        var val_60 = 0;
        val_59 = val_59 + 8;
        label_77:
        if(((val_26 + 176 + 8) + -8) == null)
        {
            goto label_76;
        }
        
        val_60 = val_60 + 1;
        val_59 = val_59 + 16;
        if(val_60 < (val_26 + 286))
        {
            goto label_77;
        }
        
        label_75:
        val_43 = 0;
        goto label_78;
        label_76:
        val_61 = val_61 + (((val_26 + 176 + 8)) << 4);
        val_48 = val_61 + 296;
        label_78:
        if((UnityEngine.Mathf.Min(a:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "ModeUnlockStage", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false), b:  0)) < val_26.Key)
        {
            goto label_79;
        }
        
        var val_64 = val_26;
        if((val_26 + 286) == 0)
        {
            goto label_81;
        }
        
        var val_62 = val_26 + 176;
        var val_63 = 0;
        val_62 = val_62 + 8;
        label_83:
        if(((val_26 + 176 + 8) + -8) == null)
        {
            goto label_82;
        }
        
        val_63 = val_63 + 1;
        val_62 = val_62 + 16;
        if(val_63 < (val_26 + 286))
        {
            goto label_83;
        }
        
        label_81:
        val_43 = 0;
        goto label_84;
        label_82:
        val_64 = val_64 + (((val_26 + 176 + 8)) << 4);
        val_49 = val_64 + 296;
        label_84:
        TKey val_29 = val_26.Key;
        var val_65 = 0;
        val_65 = val_65 + 1;
        val_43 = 1;
        var val_66 = 0;
        val_66 = val_66 + 1;
        System.Collections.Generic.IEnumerator<T> val_33 = val_8.Item[147].GetEnumerator();
        goto label_109;
        label_121:
        var val_67 = 0;
        val_67 = val_67 + 1;
        T val_35 = val_33.Current;
        val_53 = null;
        val_53 = null;
        if((ConnectScene.业丌丐且七丘东上丗.ContainsKey(key:  val_35)) != false)
        {
                val_54 = null;
            val_54 = null;
            val_33 = 147;
            val_10.Add(item:  ConnectScene.业丌丐且七丘东上丗.Item[val_35]);
        }
        else
        {
                object[] val_38 = new object[1];
            val_38[0] = val_35;
            UnityEngine.Debug.LogErrorFormat(format:  "*********** Нет такого игрового режима в словаре _gameModesConverter  {0}", args:  val_38);
            val_33 = 147;
        }
        
        label_109:
        var val_68 = 0;
        val_68 = val_68 + 1;
        if(val_33.MoveNext() == true)
        {
            goto label_121;
        }
        
         =  + 1;
        mem2[0] = 312;
        val_56 = val_40;
        if(val_33 == null)
        {
            
        }
        else
        {
                var val_69 = 0;
            val_69 = val_69 + 1;
            val_33.Dispose();
        }
        
        if(( == 1) || ((val_33 + ((val_39 + 1)) << 2) != 312))
        {
            goto label_140;
        }
        
        var val_70 = 0;
        val_70 = val_70 ^ ( >> 31);
         =  + val_70;
        goto label_143;
        label_140:
        if( == false)
        {
            goto label_143;
        }
        
        goto label_143;
        label_62:
         =  + 1;
        mem2[0] = 338;
        if(val_22 == null)
        {
            
        }
        else
        {
                var val_71 = 0;
            val_71 = val_71 + 1;
            val_22.Dispose();
        }
        
        if( != 1)
        {
                if( == false)
        {
                return val_10;
        }
        
            if((1152921525775307296 + ((val_39 + 1)) << 2) == 338)
        {
                return val_10;
        }
        
            return val_10;
        }
        
        if( == true)
        {
                return val_10;
        }
        
        return val_10;
    }
    private System.Collections.IEnumerator 专丐东且丄与丆一丟()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ConnectScene.上七三丞丂丁三专丅(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator 丗业下丙下七丏万东(BtnCategory 丟丒丞丐丐丘丒丄东)
    {
        ConnectScene.业丗且与业丞丏丐丒 val_1 = new ConnectScene.业丗且与业丞丏丐丒(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丟丒丞丐丐丘丒丄东 = 丟丒丞丐丐丘丒丄东;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 不丗丒专丅丙专丏专()
    {
        var val_34;
        var val_35;
        UnityEngine.Object val_36;
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintMapBlocker, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.hintMapPoint.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGoBattleBlocker.gameObject, 丏业丟一东丂东丘丛:  false);
        this.丏丑丆丐丏丐下与丘 = false;
        if(this.丒丂丐丝丒丛丁丒丈() != 0)
        {
                this.connectSceneSelectMap.scrollViewSelectMapTransform.GetComponent<UIScrollView>().enabled = true;
        }
        
        if(this.丛丗与丗下丐三上一 == true)
        {
                return;
        }
        
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.专上且丗丑丌丟丈丄 != false)
        {
                return;
        }
        
        丏下丒东丅丏丌一丛 val_8 = QuestsGSMAnager.丑七不且上丗丁一世().ActiveQuest;
        if(val_8 == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGoBattleBlocker, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        if((System.String.op_Equality(a:  this.connectSceneSelectMap.selectMap.sceneMapName, b:  val_8)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGoBattleBlocker, 丏业丟一东丂东丘丛:  true);
            this.丏丑丆丐丏丐下与丘 = true;
            return;
        }
        
        val_34 = 0;
        val_35 = 0;
        val_36 = 0;
        goto label_33;
        label_50:
        MapPreviewController val_13 = this.connectSceneSelectMap.grid.transform.GetChild(index:  0).GetComponent<MapPreviewController>();
        if((System.String.op_Equality(a:  val_13.sceneMapName, b:  val_8)) != false)
        {
                val_35 = this.connectSceneSelectMap.grid.transform.GetChild(index:  0);
            val_36 = this.connectSceneSelectMap.grid.transform.GetChild(index:  0).GetChild(index:  0);
        }
        
        val_34 = 1;
        label_33:
        if(val_34 < this.connectSceneSelectMap.grid.transform.childCount)
        {
            goto label_50;
        }
        
        if(val_36 == 0)
        {
                return;
        }
        
        this.connectSceneSelectMap.hintMapPoint.gameObject.SetActive(value:  true);
        this.connectSceneSelectMap.hintMapPoint.parent = val_36;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
        this.connectSceneSelectMap.hintMapPoint.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.identity;
        this.connectSceneSelectMap.hintMapPoint.transform.localRotation = new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w};
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
        this.connectSceneSelectMap.hintMapPoint.transform.localScale = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
        this.hintMapBlocker.SetActive(value:  true);
        this.丏丑丆丐丏丐下与丘 = true;
        UIScrollView val_30 = this.丒丂丐丝丒丛丁丒丈();
        val_30.ResetPosition();
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_32 = val_35.localPosition;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  val_32.y);
        val_30.enabled = false;
    }
    private void 丌丒丕丗世丒业丄一()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        System.Collections.Generic.List<SceneInfo> val_1 = new System.Collections.Generic.List<SceneInfo>();
        val_8 = 0;
        goto label_1;
        label_14:
        val_9 = null;
        val_9 = null;
        if(SceneInfoController.丄丘七三上丕世丞业 != 0)
        {
                val_10 = null;
            val_10 = null;
            if((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  this.上丒一万世丐丝丏丞[0])) != null)
        {
                val_1.AddRange(collection:  val_3.avaliableScenes);
        }
        
        }
        
        val_8 = 1;
        label_1:
        if(val_8 < this.上丒一万世丐丝丏丞.Length)
        {
            goto label_14;
        }
        
        val_11 = 0;
        goto label_15;
        label_19:
        UnityEngine.Texture val_6 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_1.Item[0].丙且上丒不下丑下丞());
        val_11 = 1;
        label_15:
        if(val_11 < val_1.Count)
        {
            goto label_19;
        }
    
    }
    private void Awake()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = null;
        val_11 = null;
        ConnectScene.丄丞丁丈与业上丞丟 = this;
        if(ConnectScene.专上且丗丑丌丟丈丄 != false)
        {
                int val_1 = 与丂丏丛丞丞丒丟丄.不丟丘丝丒专丅东丏();
            val_1 = val_1 + 1;
            与丂丏丛丞丞丒丟丄.一丒丐与业不丐丞七(丙业与丙丗丝不丈东:  val_1);
        }
        
        val_12 = null;
        val_12 = null;
        SceneInfoController.丄丘七三上丕世丞业.上丐不丌万上与不且();
        if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != false)
        {
                val_13 = "/Hi";
        }
        
        this.丂丝丕三东丏三且下 = System.String.__il2cppRuntimeField_static_fields;
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Random_Map", arg0:  System.String.__il2cppRuntimeField_static_fields));
        val_14 = 0;
        this.丗丗丈一世丞丏丙丟 = ;
        UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Squad_Map", arg0:  this.丂丝丕三东丏三且下));
        val_15 = 0;
        this.丅丘丘三三丒不业且 = ;
        this.丌丒丕丗世丒业丄一();
        if(this.connectSceneMainMenu.modeUnlockLabelByLevel == null)
        {
                return;
        }
        
        if(this.connectSceneMainMenu.modeUnlockLabelByLevel.Length == 0)
        {
                return;
        }
        
        var val_13 = 0;
        do
        {
            if(this.connectSceneMainMenu.modeUnlockLabelByLevel[0] != 0)
        {
                this.connectSceneMainMenu.modeUnlockLabelByLevel[0].gameObject.SetActive(value:  false);
        }
        
            val_13 = val_13 + 1;
        }
        while(this.connectSceneMainMenu.modeUnlockLabelByLevel.Length != val_13);
    
    }
    public static int get_RegimMulty()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "LA_ST_CHO_OS_ED_GA_ME_MOD_")) == false)
        {
                return 2;
        }
        
        return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "LA_ST_CHO_OS_ED_GA_ME_MOD_", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    public static void set_RegimMulty(int 丙业与丙丗丝不丈东)
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "LA_ST_CHO_OS_ED_GA_ME_MOD_", 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丄上一丌专丞且丗世()
    {
        if(this.东三丘丘丝丛不丆丆 == false)
        {
                return;
        }
        
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0)
        {
                return;
        }
        
        this.东三丘丘丝丛不丆丆 = false;
        Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  0);
    }
    private void Start()
    {
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        System.Action<Rilisoft.NeedSquadLevelConnectScene> val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_64;
        var val_65;
        val_52 = null;
        val_52 = null;
        GameConnect.东丒丗丄一丐且丆丝 = false;
        this.丙不丅丝丙专丕世丐 = this.gameObject.AddComponent<ConnectionControl>();
        val_2.dontResetGameMode = true;
        val_53 = null;
        val_53 = null;
        this.丙不丅丝丙专丕世丐.SetConnectPanel(丛丘下丗业丂一且业:  MainMenuController.丄丞丁丈与业上丞丟.丆丂三一丌一丏丁丞());
        if(this.connectSceneSelectMap.mapPreviewTexture.activeSelf != false)
        {
                this.connectSceneSelectMap.mapPreviewTexture.SetActive(value:  false);
        }
        
        if(this.connectSceneMainMenu.gameObject.activeSelf != true)
        {
                this.connectSceneMainMenu.gameObject.SetActive(value:  true);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtn, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtnSecond, 丏业丟一东丂东丘丛:  false);
        if(this.connectSceneSelectMap.gameObject.activeSelf != true)
        {
                this.connectSceneSelectMap.gameObject.SetActive(value:  true);
        }
        
        if(this.connectSceneMainMenu.accountBlockedLabel.gameObject.activeSelf != false)
        {
                this.connectSceneMainMenu.accountBlockedLabel.gameObject.SetActive(value:  false);
        }
        
        if(this.connectSceneMainMenu.serverIsNotAvalible.gameObject.activeSelf != false)
        {
                this.connectSceneMainMenu.serverIsNotAvalible.gameObject.SetActive(value:  false);
        }
        
        this.七丘专丕上一丝丌丈();
        val_54 = null;
        Rilisoft.七丕丟丏三丈一丄世 val_19 = (ExperienceController.丞丞丘业东丙丏七丌() < 4) ? 2 : ConnectScene.RegimMulty;
        val_19 = ((System.Linq.Enumerable.Contains<Rilisoft.七丕丟丏三丈一丄世>(source:  this.上丒一万世丐丝丏丞, value:  val_19)) != true) ? (val_19) : ((val_19 == 35) ? (val_19) : 2);
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  val_19);
        if(this.DoubleRewardConnectScene != 0)
        {
                this.DoubleRewardConnectScene.丗与丄丑一丈丙不丛(上且丗一丏丏万丅丌:  val_19);
        }
        
        val_55 = null;
        val_55 = null;
        val_57 = ConnectScene.<>c.<>9__135_0;
        if(val_57 == null)
        {
                System.Action<Rilisoft.NeedSquadLevelConnectScene> val_26 = null;
            val_57 = val_26;
            val_26 = new System.Action<Rilisoft.NeedSquadLevelConnectScene>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectScene.<>c::业丅丗丅专丗丆丑丟(Rilisoft.NeedSquadLevelConnectScene 三丟东丕丄丄下下丑));
            ConnectScene.<>c.<>9__135_0 = val_57;
        }
        
        Rilisoft.NeedSquadLevelConnectScene val_27 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.NeedSquadLevelConnectScene>(丞下万上三丘上与专:  this.NeedSquadLevelConnectSceneScript, 丌专业且丛丏丞丝且:  val_26);
        this.connectSceneMainMenu.teamFightToogle.wasPressed = false;
        this.connectSceneMainMenu.deathmatchToggle.wasPressed = false;
        this.connectSceneMainMenu.flagCaptureToogle.wasPressed = false;
        this.connectSceneMainMenu.capturePointsToogle.wasPressed = false;
        this.connectSceneMainMenu.freePlayToggle.wasPressed = false;
        this.connectSceneMainMenu.spleefToogle.wasPressed = false;
        this.connectSceneMainMenu.duelToggle.wasPressed = false;
        this.connectSceneMainMenu.deadlyToogle.wasPressed = false;
        this.connectSceneMainMenu.TeamDuelToggle.wasPressed = false;
        this.connectSceneMainMenu.competitionToggle.wasPressed = false;
        this.connectSceneMainMenu.battleRoyaleToggle.wasPressed = false;
        this.connectSceneMainMenu.armRaceToggle.wasPressed = false;
        this.丒丈丝丛丅丂丟丑丁(上且丗一丏丏万丅丌:  val_19);
        System.Collections.Generic.List<System.Action<BtnCategory>> val_29 = new System.Collections.Generic.List<System.Action<BtnCategory>>();
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::一与丙丟丗丁丙万丙(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::与丙丐丏丏丌丑专丑(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  public System.Void ConnectScene::SetRegimDeathmatch(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::丂丗不上丁丁三丅专(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::与丂丁东丞专丟丒丝(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::丐丌不业世下丏万专(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::万丒丑一丄丛且且万(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::丂与丆东丏丈丄丂上(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::七上丛下万丕丐专与(BtnCategory 不丟丗丏丛丕不丁丌)));
        val_29.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ConnectScene::专七上丐丟丈丟丆丏(BtnCategory 不丟丗丏丛丕不丁丌)));
        this.connectSceneMainMenu.categoryButtonsController.actions.AddRange(collection:  val_29);
        Rilisoft.七丕丟丏三丈一丄世 val_40 = GameConnect.丑丌丛丈丅丅与不业();
        this.connectSceneSelectMap.gameObject.GetComponent<UIPanel>().ResetAndUpdateAnchors();
        this.connectSceneSelectMap.fonMapPreview.ResetAndUpdateAnchors();
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  val_40, 下不丄丞丒丕万丟三:  true, 丌丁丙上七丟丈丌七:  (val_40 == 35) ? 1 : 0);
        val_58 = null;
        val_58 = null;
        if(ConnectScene.专上且丗丑丌丟丈丄 == true)
        {
            goto label_105;
        }
        
        val_59 = null;
        val_59 = null;
        if(MainMenuController.丆不丑丆下丞丙不丞 == false)
        {
            goto label_108;
        }
        
        label_105:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        val_60 = null;
        val_60 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = true;
        val_61 = null;
        val_61 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        ConnectScene.东丈业东丛丗七丘不(丙业与丙丗丝不丈东:  true);
        this.丘丒丂丘丄丒世丏三();
        label_141:
        this.不丗丒专丅丙专丏专();
        val_62 = null;
        val_62 = null;
        if(ConnectScene.丁丝丒丕丘不丁丁丂 != false)
        {
                ConnectScene.丁丝丒丕丘不丁丁丂 = false;
            this.BackToSquad();
            this.waitForSquad = true;
        }
        
        val_64 = null;
        val_64 = null;
        val_65 = System.Delegate.Combine(a:  MapVoteController.丛丆丂丐丛不不丟万 + 64, b:  new System.Action(object:  this, method:  System.Void ConnectScene::丞丑丐丐丁丑业丕丞()));
        if(MapVoteController.丛丆丂丐丛不不丟万 == 0)
        {
            goto label_126;
        }
        
        if(val_65 != null)
        {
            goto label_127;
        }
        
        goto label_130;
        label_126:
        if(val_65 == null)
        {
            goto label_130;
        }
        
        label_127:
        if(null != null)
        {
                val_65 = 0;
        }
        
        label_130:
        MapVoteController.丛丆丂丐丛不不丟万.__unknownFiledOffset_40 = val_65;
        this.connectSceneSelectMap.FreePlayMapPanel.squadButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ConnectScene::HandleCreateSquadBtnFreeplay(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.connectSceneSelectMap.FreePlayMapPanel.squadLocker.SetUnlockProgress(丗丗丑丑与东丗丅三:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.squad"), 且业一丕且丒丅丁七:  false);
        return;
        label_108:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        ConnectScene.东丈业东丛丗七丘不(丙业与丙丗丝不丈东:  false);
        goto label_141;
    }
    internal bool 专万丏七丆丆丙丌丂()
    {
        var val_4;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_13 = null;
        val_13 = null;
        val_14 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        List.Enumerator<T> val_2 = val_14.GetEnumerator();
        val_15 = 0;
        goto label_5;
        label_13:
        if((val_15 & 1) != 0)
        {
                val_16 = 1;
        }
        else
        {
                val_14 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  val_4.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛()).丆丟且丗丒不丄七丌();
        }
        
        var val_12 = (((val_14.Count > 0) ? 1 : 0) != 0) ? 1 : 0;
        label_5:
        if(((-303312784) & 1) != 0)
        {
            goto label_13;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool) & 1;
    }
    internal void 丌丗不丁丈丐丟丄丐(System.Action 且专丏丑丞丙丁东丈)
    {
        DungeonNoModulesWindowUI val_6;
        if(this.东丏丆东丆丐丁丌丈 != 0)
        {
            goto label_3;
        }
        
        val_6 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.dungeonNoModulesWindowParent.gameObject, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Raids/NoModulesWindow")).GetComponent<DungeonNoModulesWindowUI>();
        this.东丏丆东丆丐丁丌丈 = val_6;
        if(val_6 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_3:
        val_6 = this.东丏丆东丆丐丁丌丈;
        if(val_6 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        this.东丏丆东丆丐丁丌丈.下丞丐万丁丟且下丗 = 且专丏丑丞丙丁东丈;
        this.东丏丆东丆丐丁丌丈.丆丙丗三东专丐不上();
    }
    internal void 丈丌一丗丞丂丂丟丞(MapPreviewController 下丒丏丙一不七丕丏)
    {
        if(this.丛丁丅丆丅与万三丅 == 0)
        {
                this.丛丁丅丆丅与万三丅 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.dungeonWindowParent.gameObject, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Raids/DungeonWindow")).GetComponent<DungeonWindowUI>();
            val_5.backBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ConnectScene::世东丄东专丙专丒丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        this.丛丁丅丆丅与万三丅.上东与丛丞下丈专丈(下丒丏丙一不七丕丏:  下丒丏丙一不七丕丏);
        this.dungeonWindowParent.gameObject.SetActive(value:  true);
        if(this.丏七一七丕不不专丈 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            this.丏七一七丕不不专丈.Dispose();
        }
        
        this.丏七一七丕不不专丈 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ConnectScene::丂丅丈丕三世丈丒下()), 与且专丈不万东一万:  "Dungeon Window");
    }
    internal void 世东丄东专丙专丒丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丂丅丈丕三世丈丒下();
    }
    internal void 丂丅丈丕三世丈丒下()
    {
        this.dungeonWindowParent.gameObject.SetActive(value:  false);
        if(this.丏七一七丕不不专丈 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.丏七一七丕不不专丈.Dispose();
        this.丏七一七丕不不专丈 = 0;
    }
    internal void 丙丐丘丂丆丆且万下(MapPreviewController 下丒丏丙一不七丕丏, PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘)
    {
        this.东上丕丙丌丈丈业丑().下丗丒丆丗丗丆东丈(一丈下丕丗不丂丒世:  new System.Action(object:  this, method:  System.Void ConnectScene::丑丌丙丙丞丗丙七丂()), 万不且且丛丆东丒业:  下丒丏丙一不七丕丏.一丟丛三丞丁丐且丘, 丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘, 东丅丛丐丁与丑丟丘:  new System.Action<PGCompany.丁下丒丕丆下丂丆丌>(object:  this, method:  System.Void ConnectScene::与丐丑业丐丅且丐丈(PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectScenePanelTaskHint.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    private void 丂世丝丞丁丝不东一()
    {
        if(this.七丑丅业丘丅专丁丗 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.七丑丅业丘丅专丁丗.Dispose();
        }
        
        this.七丑丅业丘丅专丁丗 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ConnectScene::丏丐不三丘丌不丟不()), 与且专丈不万东一万:  "Map Event Hint");
    }
    internal void 且丐丆且丝丑丒东业(MapPreviewController 下丒丏丙一不七丕丏)
    {
        bool val_9;
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = 下丒丏丙一不七丕丏.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(((-302093032) & 1) == 0)
        {
            goto label_8;
        }
        
        int val_2 = val_1.HasValue.丙东专丂世丈丏丁丂();
        if(val_2 == 4)
        {
            goto label_4;
        }
        
        if(val_2 == 2)
        {
            goto label_5;
        }
        
        if(val_2 != 1)
        {
            goto label_8;
        }
        
        label_4:
        val_9 = 下丒丏丙一不七丕丏.squadMode;
        this.connectScenePanelEventHint.丛丗丝且世丟丌东万(且丝丘万丅与丈丗一:  下丒丏丙一不七丕丏.丐且丘丑与万丞丑丅, 丁丏丗且上丗下与下:  (val_9 == true) ? 1 : 0);
        goto label_8;
        label_5:
        this.connectScenePanelEventHint.丏丆下丘丅丙丐丌丅();
        val_9 = 下丒丏丙一不七丕丏.丐且丘丑与万丞丑丅;
        this.三丗一业丙丑丂丐丛().下丗丒丆丗丗丆东丈(一丈下丕丗不丂丒世:  new System.Action(object:  this, method:  System.Void ConnectScene::丏丐不三丘丌不丟不()), 与不下三丈专丘丂世:  val_9, 东丅丛丐丁与丑丟丘:  new System.Action(object:  this, method:  System.Void ConnectScene::三东专下丌丈丐世与()));
        label_8:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_7 = 下丒丏丙一不七丕丏.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        this.connectScenePanelEventHint.mapEventWindow.七丝丏东东丘丆丒且(且下丕七丙丗丄不七:  new System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>() {HasValue = val_7.HasValue});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectScenePanelEventHint.gameObject, 丏业丟一东丂东丘丛:  true);
        this.丂世丝丞丁丝不东一();
    }
    internal void 三专丈丒丏不丄丗丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丏丐不三丘丌不丟不();
    }
    internal void 丑丌丙丙丞丗丙七丂()
    {
        if(this.东上丕丙丌丈丈业丑() != 0)
        {
                this.东上丕丙丌丈丈业丑().丟三三业丆业丄丞且();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectScenePanelTaskHint.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丏丐不三丘丌不丟不()
    {
        if(this.三丗一业丙丑丂丐丛().丟三三业丆业丄丞且() == false)
        {
                return;
        }
        
        if(丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且() == true)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectScenePanelEventHint.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.connectScenePanelEventHint.mapEventWindow, 丏业丟一东丂东丘丛:  false);
        if(this.七丑丅业丘丅专丁丗 == null)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.七丑丅业丘丅专丁丗.Dispose();
        this.七丑丅业丘丅专丁丗 = 0;
    }
    internal void 丒三且一丕不丞下东()
    {
        if(this.connectSceneMainMenu != null)
        {
            goto label_0;
        }
        
        this.connectSceneMainMenu = this.connectSceneMainMenu;
        if(this.connectSceneMainMenu == null)
        {
            goto label_1;
        }
        
        label_0:
        this.connectSceneMainMenu.categoryButtonsController.BtnClicked(丟专丛丏丝万丘丄丗:  this.connectSceneMainMenu.TeamDuelToggle.btnName, 丌丝丌丁下丐丞丆一:  true);
        return;
        label_1:
    }
    private System.Collections.IEnumerator OnApplicationPause(bool 丄七丙不丟丛与丏丐)
    {
        ConnectScene.世丄丌业世丅世专丝 val_1 = new ConnectScene.世丄丌业世丅世专丝(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丄七丙不丟丛与丏丐 = 丄七丙不丟丛与丏丐;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丄一丕一七丆丑丗丛(string 与且专丈不万东一万, bool 业丛丕丐丏世丞丈且 = True)
    {
        ConnectScene.丛丁丛七一万丝丛东 val_1 = new ConnectScene.丛丁丛七一万丝丛东(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .与且专丈不万东一万 = 与且专丈不万东一万;
        }
        else
        {
                mem[32] = this;
            mem[48] = 与且专丈不万东一万;
        }
        
        .业丛丕丐丏世丞丈且 = 业丛丕丐丏世丞丈且;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static bool 丐丏且世丁丗业一丗()
    {
        null = null;
        return (bool)ConnectScene.<七业丈东丆丈丗丂丏>k__BackingField;
    }
    internal static void 东下丑丁丌丁丂丐上(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        ConnectScene.<七业丈东丆丈丗丂丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 下七东东丁丅丗丂丏()
    {
        Rilisoft.AdvertisementController val_2 = this.gameObject.GetComponent<Rilisoft.AdvertisementController>();
        this.丙丕丌丒丞丕不上万 = val_2;
        if(val_2 == 0)
        {
                this.丙丕丌丒丞丕不上万 = this.gameObject.AddComponent<Rilisoft.AdvertisementController>();
        }
        
        BannerWindowController val_6 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_6.advertiseController = this.丙丕丌丒丞丕不上万;
    }
    public void SetRegimDeathmatch(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 0)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  0, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 一与丙丟丗丁丙万丙(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 2)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  2, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 与丂丁东丞专丟丒丝(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 4)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  4, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 丏七七下丄丌丒业且(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 14)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  14, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 丐丌不业世下丏万专(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 22)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  22, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 丂丗不上丁丁三丅专(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 31)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  31, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 七丁丟业丅上丗丆丗(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 1)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  1, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 万丒丑一丄丛且且万(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 24)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  24, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 与丙丐丏丏丌丑专丑(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch");
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "deathmatch_ab");
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 20)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  20, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 七上丛下万丕丐专与(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 8)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  8, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 上七专丝丘丟丂世丛(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 16)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  16, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 专七上丐丟丈丟丆丏(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
        if(val_1 == 35)
        {
                return;
        }
        
        val_1.与丒丒丏七不丞丐丄();
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  35, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  true);
    }
    private void 丌上万世丙一且东丁(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 17)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  17, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 丘丛丐丆东三丁上丆(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 32)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  32, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 丆丛丞东丙丅且丗丝(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 33)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  33, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    private void 丂与丆东丏丈丄丂上(BtnCategory 不丟丗丏丛丕不丁丌)
    {
        var val_2 = null;
        if(ConnectScene.RegimMulty == 34)
        {
                return;
        }
        
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  34, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
    }
    public void HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_17 = null;
        val_17 = null;
        val_18 = this.一世东丄丗丆丘丛丂.丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七];
        if((val_1.enterPasswordInput.value.Equals(value:  val_18)) == true)
        {
            goto label_11;
        }
        
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_19 = null;
        val_19 = null;
        val_18 = this.一世东丄丗丆丘丛丂.丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七];
        if((val_6.enterPasswordCustomInput.value.Equals(value:  val_18)) == false)
        {
            goto label_22;
        }
        
        label_11:
        this.JoinToRoomPhotonAfterCheck();
        CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
        return;
        label_22:
        CustomPanelConnectScene val_12 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_12.enterPasswordPanel.SetActive(value:  false);
        CustomPanelConnectScene val_13 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_13.enterPasswordCustomPanel.SetActive(value:  false);
        CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  true);
        val_20 = null;
        val_20 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_21 = null;
            val_21 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        CustomPanelConnectScene val_16 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_16.customPanel.SetActive(value:  true);
        this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
    }
    private void 下丐丅丑丘专丑丈丑()
    {
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        this.东丅丒丛丏丄丒丞专 = val_1.setPasswordInput.value;
    }
    public void OnJoinToMap(string 七丆丂丂下丈且丟世)
    {
        this.上下丟七丗业丁丒丕 = 七丆丂丂下丈且丟世;
    }
    public void HandleCreateRoomBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        int val_42;
        var val_43;
        UnityEngine.Object val_44;
        var val_45;
        var val_46;
        int val_47;
        int val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        FilterMaps val_55;
        var val_56;
        val_42 = this;
        val_43 = null;
        val_43 = null;
        if(GameConnect.丛丑世丕丌上丑丂丈 != false)
        {
                CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_44 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1.nameServerInput.value)) != false)
        {
                string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4927");
            InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != true) ? "#Все поля должны быть заполнены" : (val_4));
            return;
        }
        
        }
        
        val_45 = null;
        val_45 = null;
        val_44 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  this.connectSceneSelectMap.selectMap.mapID);
        if(val_44 == 0)
        {
                return;
        }
        
        string val_10 = val_44.gameObject.name;
        CustomPanelConnectScene val_11 = CustomPanelConnectScene.丑七不且上丗丁一世();
        string val_13 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_11.nameServerInput.value);
        val_46 = null;
        val_46 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_40;
        }
        
        val_47 = 丅丒丗丑丒丙丛不丆.丘上业丗丈丌下不丑();
        var val_43 = 0;
        label_44:
        if(val_43 >= val_14.Length)
        {
            goto label_40;
        }
        
        val_43 = val_43 + 1;
        if((val_47[0].丙丆丌丝丛丏丝丕业().Equals(value:  val_13)) == false)
        {
            goto label_44;
        }
        
        CustomPanelConnectScene val_17 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_17.customizePanel.SetActive(value:  false);
        CustomPanelConnectScene val_18 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_18.nameAlreadyUsedLabel.timer = 3f;
        CustomPanelConnectScene val_19 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_19.nameAlreadyUsedLabel.gameObject.SetActive(value:  true);
        CustomPanelConnectScene.丑七不且上丗丁一世().SetRandomRoomName();
        CustomPanelConnectScene val_22 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_22.tryCreateRoomAgain.gameObject.SetActive(value:  true);
        this.丝东丐丝东三丈世丝(东丄丛丝三丛丘丟丑:  false);
        return;
        label_40:
        this.上下丟七丗业丁丒丕 = val_10;
        UnityEngine.PlayerPrefs.SetString(key:  "MapName", value:  val_10);
        UnityEngine.PlayerPrefs.SetString(key:  "MaxKill", value:  "4");
        this.丅丟丘专丞丁丄丌丗(丛丘七丂且丟丁一丙:  this.上下丟七丗业丁丒丕, 丑一丈丐专丑且丞丅:  false);
        this.loadingMapPanel.SetActive(value:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  1176");
        if(GameConnect.丑丌丛丈丅丅与不业() == 20)
        {
                val_48 = this.connectSceneSelectMap.selectMap.mapID;
            int val_25 = GameConnect.丈东丛丝丞不丒一世(丛丝丁丗且丘丂与万:  val_48);
        }
        
        val_47 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        val_49 = null;
        val_49 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                this.loadingMapPanel.SetActive(value:  true);
            AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  1183");
            val_42 = val_7.indexMap;
            CustomPanelConnectScene val_30 = CustomPanelConnectScene.丑七不且上丗丁一世();
            GameConnect.万丐丑上丟丞丞丏丑(丅一丞万丑专丅丅与:  val_13, 丞与一东丈世且丐丕:  val_47, 丛且丞与丕业下丏丞:  val_42, 丗一丁丅与专丐一世:  GameConnect.丏丝一丁丛丕且丐丈(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业()), 专业丛丆丟丆丛业丆:  GameConnect.丐业丏丁业且丏上世(专业丛丆丟丆丛业丆:  val_30.setPasswordInput.value), 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丟丑业丌丙丙丑下丑:  false, 下下东且万业丞丅丒:  true, 丙丘东丏三丆丄丁丟:  0, 丐且丘丑与万丞丑丅:  0, 七专丙丏丘丌丌下与:  0, 丕丑专丗万丕与专丐:  1);
            return;
        }
        
        val_50 = null;
        val_50 = null;
        GameConnect.七七丈东丅上丝丒万 = true;
        UnityEngine.PlayerPrefs.SetString(key:  "ServerName", value:  ((System.String.IsNullOrEmpty(value:  val_13)) != true) ? "Server" : (val_13));
        UnityEngine.PlayerPrefs.SetString(key:  "PlayersLimits", value:  val_47.ToString());
        val_44 = 1152921505286238208;
        val_51 = null;
        val_51 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_94;
        }
        
        val_52 = null;
        val_52 = null;
        val_53 = null;
        val_53 = null;
        val_44 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑;
        if((val_44.ContainsKey(key:  val_10)) == false)
        {
            goto label_100;
        }
        
        val_54 = null;
        val_54 = null;
        val_44 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑;
        val_55 = val_44.Item[val_10];
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_106;
        }
        
        goto label_105;
        label_100:
        val_55 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_106;
        }
        
        label_105:
        label_106:
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  val_55);
        label_94:
        val_42 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
        val_56 = null;
        val_56 = null;
        UnityEngine.AsyncOperation val_41 = val_42.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟, 丂丛丑东不丅丈一东:  0);
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
    }
    private void 丑丅丅下丌丅七世万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        if(CreatePrivateGameWindow.instance == 0)
        {
                return;
        }
        
        CreatePrivateGameWindow.instance.SaveCurrentSettingsToStorager();
        val_2 = null;
        val_2 = null;
        GameConnect.东丒丗丄一丐且丆丝 = true;
        this.HandleCreateRoomBtnClicked(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    private void 丗世丌丘不丕丆丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_19;
        var val_20;
        var val_21;
        this.东丅丒丛丏丄丒丞专 = System.String.alignConst;
        this.上一丝三丗且丆下丟();
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.createPanel.SetActive(value:  true);
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(GameConnect.丑丌丛丈丅丅与不业() != 1)
        {
            goto label_8;
        }
        
        val_19 = 0;
        if(val_2.customizeBtn != null)
        {
            goto label_13;
        }
        
        goto label_10;
        label_8:
        if(val_2.customizeBtn != null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_2.customizeBtn.SetActive(value:  (GameConnect.丑丌丛丈丅丅与不业() != 31) ? 1 : 0);
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_20 = null;
        val_20 = null;
        val_6.setPasswordInput.gameObject.SetActive(value:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true) ? 1 : 0);
        CustomPanelConnectScene val_9 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Transform val_10 = val_9.nameServerInput.transform;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_23;
        }
        
        if(val_10 != null)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        val_10.localPosition = new UnityEngine.Vector3() {x = this.丏丘丞丆与丕三丝丘, y = V9.16B, z = V10.16B};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.gameObject, 丏业丟一东丂东丘丛:  true);
        val_21 = null;
        val_21 = null;
        this.connectSceneSelectMap.SetWideBg(三丟东丕丄丄下下丑:  (GameConnect.丛丑世丕丌上丑丂丈 == true) ? 1 : 0);
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  false, 丕丈丌丐下丅三七丌:  GameConnect.丝丆世丕丂丄万东且(), 世丆丏七且业下丅专:  false, 业三丆丙丗丑丏丆不:  false, 一丅丆丂七与丆丈丂:  false);
        CustomPanelConnectScene val_15 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_15.customPanel.SetActive(value:  false);
        CustomPanelConnectScene val_16 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_16.nameAlreadyUsedLabel.timer = -1f;
        CustomPanelConnectScene val_17 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_17.nameAlreadyUsedLabel.gameObject.SetActive(value:  false);
        return;
        label_23:
        if(val_10 != null)
        {
            goto label_40;
        }
        
        goto label_41;
    }
    private void 丘丆万丆七丗不丌丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_11;
        var val_12;
        val_11 = null;
        val_11 = null;
        if(GameConnect.丛丑世丕丌上丑丂丈 != false)
        {
                CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1.nameServerInput.value)) != false)
        {
                string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4927");
            InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != true) ? "#Все поля должны быть заполнены" : (val_4));
            return;
        }
        
        }
        
        CustomPanelConnectScene val_7 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_7.customizePanel.SetActive(value:  true);
        CustomPanelConnectScene val_8 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_12 = null;
        val_12 = null;
        val_8.customizePanel.GetComponent<CreatePrivateGameWindow>().ReadMapInfoNextFrame(丄不东丁丂丅万丒丟:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  this.connectSceneSelectMap.selectMap.mapID));
    }
    private void 上下丙专丌下丄丈丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.customPanel.SetActive(value:  false);
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_2.searchInput != 0)
        {
                CustomPanelConnectScene val_4 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_4.searchInput.value = this.gameNameFilter;
        }
        
        CustomPanelConnectScene val_5 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_5.searchPanel.SetActive(value:  true);
    }
    public void HandleSearchBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        string val_8;
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.customPanel.SetActive(value:  true);
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_2.searchInput != 0)
        {
                CustomPanelConnectScene val_4 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_8 = val_4.searchInput.value;
            this.gameNameFilter = val_8;
        }
        else
        {
                val_8 = this.gameNameFilter;
        }
        
        this.丘丒丛丙丏丟世不丘(丞丘与万丞三丁丘丙:  val_8);
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_6.scrollGames.ResetPosition();
        CustomPanelConnectScene val_7 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_7.searchPanel.SetActive(value:  false);
    }
    internal void 上世与丗丁丕丌丘上(string 丆丟七丝丏业丅上丄)
    {
        var val_12;
        ConnectScene.丝上丗丄丐东业上专 val_1 = new ConnectScene.丝上丗丄丐东业上专();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丆丟七丝丏业丅上丄 = 丆丟七丝丏业丅上丄;
        if(BankController.丑七不且上丗丁一世() == 0)
        {
            goto label_7;
        }
        
        ConnectScene.丛且不七丁且业丝与 val_4 = new ConnectScene.丛且不七丁且业丝与();
        if(val_4 == null)
        {
            goto label_8;
        }
        
        val_12 = val_4;
        .东丟且丗且三专丙丁 = val_1;
        goto label_9;
        label_7:
        UnityEngine.Debug.LogWarning(message:  "BankController.Instance == null");
        return;
        label_8:
        val_12 = 24;
        mem[24] = val_1;
        label_9:
        .丛丟丌丝丈丞上丕丈 = 0;
        .丛丟丌丝丈丞上丕丈 = new System.EventHandler(object:  val_4, method:  System.Void ConnectScene.丛且不七丁且业丝与::且丈上丟东专丏与丐(object 丟业丏且丟七丞一丆, System.EventArgs 业丝丑丆上丆丌丙业));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ConnectScene.丛且不七丁且业丝与)[1152921525785536336].丛丟丌丝丈丞上丕丈);
        this.connectSceneMainMenu.gameObject.transform.root.gameObject.SetActive(value:  false);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  .丆丟七丝丏业丅上丄, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    private void 专七丁世丞丂丟丈丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.上世与丗丁丕丌丘上(丆丟七丝丏业丅上丄:  0);
    }
    public void HandleLocalBtnClicked()
    {
        var val_2;
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if(((-295909812) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_2 = null;
        val_2 = null;
        与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 = false;
        this.丗丑丛且与丅七丟丏();
    }
    public void HandleCustomDuelBtnClicked()
    {
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  8);
        this.HandleCustomBtnClicked();
    }
    public void HandleCustomTeamDuelBtnClicked()
    {
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  16);
        this.HandleCustomBtnClicked();
    }
    public void HandleCustomBtnClicked()
    {
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if(((-295544132) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if((PGCompany.GameModeLowDeviceWarningBanner.七丑丆丏东业专丒万(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 东下丌丝且七丛丘丒:  this.connectSceneSelectMap.selectMap.curSceneInfo, 万丟丗丏专丆丌上三:  this.connectSceneSelectMap.selectMap.squadMode, 丏丒且丄三世丆丕上:  new System.Action(object:  this, method:  System.Void ConnectScene::专丘丙丘丒不上下丞()))) == true)
        {
                return;
        }
        
        this.丕丕三丝丈丙丗万万(丟丟东丏世三一三丟:  false);
    }
    internal void 丁丁世一不业丈上丑(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newConnectScene, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    private void 丗丑丛且与丅七丟丏()
    {
        UnityEngine.Transform val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_89;
        this.丘丛上丑丗上世专业 = true;
        this.gameNameFilter = System.String.alignConst;
        val_83 = 1152921505052479488;
        val_84 = null;
        val_84 = null;
        if(ConnectScene.一七丁三丄专下且丂 == null)
        {
            goto label_3;
        }
        
        label_183:
        val_85 = null;
        val_85 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
        }
        
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_86 = null;
        val_86 = null;
        val_1.showSearchPanelBtn.SetActive(value:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneMainMenu.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtn, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtnSecond, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.gameObject, 丏业丟一东丂东丘丛:  false);
        CustomPanelConnectScene val_5 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_87 = 0;
        val_5.customPanel.SetActive(value:  true);
        this.丏上丒专丞丑东且丞 = true;
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        Rilisoft.七丕丟丏三丈一丄世 val_8 = GameConnect.丑丌丛丈丅丅与不业();
        var val_84 = 0;
        val_84 = val_84 + 1;
        val_87 = 0;
        goto label_28;
        label_3:
        PGCompany.东丑丒丗一丞下丙丙<T> val_11 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.七丕丟丏三丈一丄世>.万世丅七一专丕丞不();
        PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_10 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丘专丒丈丌丁且丁丟();
        PGCompany.GameModeHub.丂丕且丟丌丐万东丗.专丅专丈丛丙一丂丒(不丝丄丒丌丐一一与:  val_10.丐丂丄丘丈专七万下, 专丂丕丗丗东世丞下: ref  val_11);
        if(val_11.Count >= 1)
        {
                if(val_11.Item[0] != 100)
        {
            goto label_39;
        }
        
        }
        
        this.丝东丐丝东三丈世丝(东丄丛丝三丛丘丟丑:  false);
        return;
        label_28:
        val_6.headCustomPanel.SetText(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[null]));
        this.东丅丒丛丏丄丒丞专 = System.String.alignConst;
        CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
        CustomPanelConnectScene val_18 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_18.gameIsfullLabel.timer = -1f;
        CustomPanelConnectScene val_19 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_19.gameIsfullLabel.gameObject.SetActive(value:  false);
        val_83 = this.gameObject.transform;
        CustomPanelConnectScene.丑七不且上丗丁一世().gameObject.transform.parent = val_83;
        if(this.丄东丑与丕东七丆丈 == true)
        {
                return;
        }
        
        CustomPanelConnectScene val_26 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_28 = val_26.nameServerInput.transform.localPosition;
        this.丏丘丞丆与丕三丝丘 = val_28;
        mem[1152921525786814128] = val_28.y;
        mem[1152921525786814132] = val_28.z;
        CustomPanelConnectScene val_29 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_29.setPasswordInput.onSubmit.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ConnectScene::东丕丗丏丞丘丆丑不())));
        CustomPanelConnectScene val_32 = CustomPanelConnectScene.丑七不且上丗丁一世();
        EventDelegate val_34 = null;
        val_83 = val_34;
        val_34 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ConnectScene::丐丛丈丅丌一丌丑丝()));
        val_32.enterPasswordInput.onSubmit.Add(item:  val_34);
        this.丄东丑与丕东七丆丈 = true;
        CustomPanelConnectScene val_35 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_35.showSearchPanelBtn != 0)
        {
                CustomPanelConnectScene val_37 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_38 = val_37.showSearchPanelBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_38 != 0)
        {
                bool val_40 = null;
            val_83 = val_40;
            val_40 = new System.Boolean(object:  this, method:  System.Void ConnectScene::上下丙专丌下丄丈丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_38.add_Clicked(丙业与丙丗丝不丈东:  val_40);
        }
        
        }
        
        CustomPanelConnectScene val_41 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_41.createRoomBtn != 0)
        {
                CustomPanelConnectScene val_43 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_44 = val_43.createRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_44 != 0)
        {
                System.EventHandler val_46 = null;
            val_83 = val_46;
            val_46 = new System.EventHandler(object:  this, method:  System.Void ConnectScene::丗世丌丘不丕丆丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_44.add_Clicked(丙业与丙丗丝不丈东:  val_46);
        }
        
        }
        
        CustomPanelConnectScene val_47 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_47.createCustomRoomBtn != 0)
        {
                CustomPanelConnectScene val_49 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_50 = val_49.createCustomRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_50 != 0)
        {
                System.EventHandler val_52 = null;
            val_83 = val_52;
            val_52 = new System.EventHandler(object:  this, method:  System.Void ConnectScene::丑丅丅下丌丅七世万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_50.add_Clicked(丙业与丙丗丝不丈东:  val_52);
        }
        
        }
        
        CustomPanelConnectScene val_53 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_53.customizeBtn != 0)
        {
                CustomPanelConnectScene val_55 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_56 = val_55.customizeBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_56 != 0)
        {
                System.EventHandler val_58 = null;
            val_83 = val_58;
            val_58 = new System.EventHandler(object:  this, method:  System.Void ConnectScene::丘丆万丆七丗不丌丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_56.add_Clicked(丙业与丙丗丝不丈东:  val_58);
        }
        
        }
        
        CustomPanelConnectScene val_59 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_59.goToCreateRoomBtn != 0)
        {
                CustomPanelConnectScene val_61 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_62 = val_61.goToCreateRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_62 != 0)
        {
                System.EventHandler val_64 = null;
            val_83 = val_64;
            val_64 = new System.EventHandler(object:  this, method:  public System.Void ConnectScene::HandleCreateRoomBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_62.add_Clicked(丙业与丙丗丝不丈东:  val_64);
        }
        
        }
        
        CustomPanelConnectScene val_65 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_65.searchBtn != 0)
        {
                CustomPanelConnectScene val_67 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_68 = val_67.searchBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_68 != 0)
        {
                System.EventHandler val_70 = null;
            val_83 = val_70;
            val_70 = new System.EventHandler(object:  this, method:  public System.Void ConnectScene::HandleSearchBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_68.add_Clicked(丙业与丙丗丝不丈东:  val_70);
        }
        
        }
        
        CustomPanelConnectScene val_71 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_71.joinRoomFromEnterPasswordBtn != 0)
        {
                CustomPanelConnectScene val_73 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_74 = val_73.joinRoomFromEnterPasswordBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_74 != 0)
        {
                System.EventHandler val_76 = null;
            val_83 = val_76;
            val_76 = new System.EventHandler(object:  this, method:  public System.Void ConnectScene::HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_74.add_Clicked(丙业与丙丗丝不丈东:  val_76);
        }
        
        }
        
        CustomPanelConnectScene val_77 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_77.joinCustomRoomFromEnterPasswordBtn == 0)
        {
                return;
        }
        
        CustomPanelConnectScene val_79 = CustomPanelConnectScene.丑七不且上丗丁一世();
        Rilisoft.ButtonHandler val_80 = val_79.joinCustomRoomFromEnterPasswordBtn.GetComponent<Rilisoft.ButtonHandler>();
        if(val_80 == 0)
        {
                return;
        }
        
        System.EventHandler val_82 = null;
        val_83 = val_82;
        val_82 = new System.EventHandler(object:  this, method:  public System.Void ConnectScene::HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        val_80.add_Clicked(丙业与丙丗丝不丈东:  val_82);
        return;
        label_39:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newConnectScene, 丏业丟一东丂东丘丛:  false);
        val_89 = null;
        val_89 = null;
        ConnectScene.丙东丁丂丝世丑丒丘 = val_11.Item[0];
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  ConnectScene.丙东丁丂丝世丑丒丘);
        goto label_183;
    }
    internal void UpdateFilteredRoomListInvoke()
    {
        this.丘丒丛丙丏丟世不丘(丞丘与万丞三丁丘丙:  this.gameNameFilter);
    }
    private void 丛丂丕不专丗不上丁()
    {
        this.gameObject.SetActive(value:  true);
    }
    internal void 丌丐丒丞且丌丒丂丛(string 丅一丞万丑专丅丅与)
    {
        ConnectScene.丒下东丁丞丗丝七丕 val_1 = new ConnectScene.丒下东丁丞丗丝七丕();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丅一丞万丑专丅丅与 = 丅一丞万丑专丅丅与;
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void ConnectScene.丒下东丁丞丗丝七丕::丆且丂丗丐三丟且丛()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    public void HandleCreateSquadBtnFreeplay(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.上与丏丌七万丈且丝(丟丟东丏世三一三丟:  false);
    }
    public void HandleCreateSquadBtnClicked()
    {
        this.上与丏丌七万丈且丝(丟丟东丏世三一三丟:  false);
    }
    internal void 丝万丈东万丗丕丆丆(PGCompany.GameModeHub.丕业丞七丄七丒万东 一丐丛丏与丗七丂丐, bool 丌与一丌且一不七丆 = False)
    {
        ConnectScene.业丞丐丁丈上丞丆丝 val_1 = new ConnectScene.业丞丐丁丈上丞丆丝();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .一丐丛丏与丗七丂丐 = 一丐丛丏与丗七丂丐;
        }
        else
        {
                mem[16] = this;
            mem[24] = 一丐丛丏与丗七丂丐;
        }
        
        .丌与一丌且一不七丆 = 丌与一丌且一不七丆;
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void ConnectScene.业丞丐丁丈上丞丆丝::专一七丕丁丟丐下丌()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 上与丏丌七万丈且丝(bool 丟丟东丏世三一三丟)
    {
        ConnectScene.丆丛丌东业东丟万三 val_1 = new ConnectScene.丆丛丌东业东丟万三();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丟丟东丏世三一三丟 = 丟丟东丏世三一三丟;
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void ConnectScene.丆丛丌东业东丟万三::丅世丒丕丕东业专且()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    public void HandleRandomBtnClicked()
    {
        this.丏东万丙一万丌且世(丟丟东丏世三一三丟:  false);
    }
    private void 丏东万丙一万丌且世(bool 丟丟东丏世三一三丟)
    {
        ConnectScene.丟七不丑丁丞丁上丈 val_1 = new ConnectScene.丟七不丑丁丞丁上丈();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丟丟东丏世三一三丟 = 丟丟东丏世三一三丟;
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if(((-293345428) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void ConnectScene.丟七不丑丁丞丁上丈::与下丗丑丏世丄丈下()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  false, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 与丞丘万丏丟丗丞与(System.Action 丛丝与丂世丌丌丝丂, PGCompany.GameModeHub.丕业丞七丄七丒万东 一丐丛丏与丗七丂丐, bool 丌与一丌且一不七丆 = False)
    {
        var val_2;
        this.gameObject.SetActive(value:  false);
        val_2 = null;
        val_2 = null;
        丌与一丌且一不七丆 = 丌与一丌且一不七丆;
        SquadController.丄丘七三上丕世丞业.三丟丌下丅丝与丌丛(丛丝与丂世丌丌丝丂:  丛丝与丂世丌丌丝丂, 一丐丛丏与丗七丂丐:  一丐丛丏与丗七丂丐, 丌与一丌且一不七丆:  丌与一丌且一不七丆, 三丛业业专丄丟丄丅:  0, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "", 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
    }
    private void 丅丌丄上一不丗丅上()
    {
        object val_4;
        var val_5;
        var val_6;
        var val_7;
        System.Action val_8;
        Rilisoft.七丕丟丏三丈一丄世 val_9;
        string val_10;
        var val_11;
        System.Action val_13;
        var val_14;
        var val_15;
        val_4 = this;
        this.gameObject.SetActive(value:  false);
        val_5 = null;
        val_5 = null;
        val_6 = null;
        if(ConnectScene.丙东丁丂丝世丑丒丘 == 24)
        {
                val_7 = null;
            System.Action val_2 = null;
            val_8 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void ConnectScene::丛丂丕不专丗不上丁());
            val_9 = 9;
            val_10 = "";
            val_11 = 1;
            val_13 = val_8;
        }
        else
        {
                val_14 = null;
            System.Action val_3 = null;
            val_8 = val_3;
            val_3 = new System.Action(object:  this, method:  System.Void ConnectScene::丛丂丕不专丗不上丁());
            val_15 = null;
            val_15 = null;
            val_4 = ConnectScene.丙东丁丂丝世丑丒丘;
            val_10 = "";
            val_13 = val_8;
            val_9 = val_4;
            val_11 = 0;
        }
        
        SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  val_3, 上且丗一丏丏万丅丌:  val_9, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  0, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  val_10, 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
    }
    public void BackToSquad()
    {
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  this, method:  System.Void ConnectScene::专丐丄上且丏万丑与()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  true, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 专丐丄上且丏万丑与()
    {
        var val_3;
        var val_4;
        this.gameObject.SetActive(value:  false);
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void ConnectScene::丛丂丕不专丗不上丁()), 上且丗一丏丏万丅丌:  ConnectScene.丙东丁丂丝世丑丒丘, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  0, 丟与丏丈丁东丅下丕:  true, 丗不下业上下丆丑丑:  "", 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
    }
    private void 丛东丙丆业一丑丙不()
    {
        this.丙不丅丝丙专丕世丐.一丙丅丛丁东丅丅世(上业丈东万下世丝丁:  0, 丏丈丗世丙万丆丐丅:  0, 丐且丘丑与万丞丑丅:  0);
    }
    internal void 专丆丏且丟丆世丏三(Rilisoft.七丕丟丏三丈一丄世 与丛丛丟丅世丏丐丌)
    {
        if(this.startMiniGameScreenParent.childCount == 0)
        {
            goto label_4;
        }
        
        if(this.丈丁下丟不不丛丗丏 != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        this.丈丁下丟不不丛丗丏.Setup(丟丘万不丏丕丌丑丟:  与丛丛丟丅世丏丐丌, 丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  与丛丛丟丅世丏丐丌));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.gameObject, 丏业丟一东丂东丘丛:  false);
        this.七丘丝丆丏丘丗丏丄 = true;
        return;
        label_4:
        UnityEngine.Transform val_5 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "PanelMiniGame"));
        val_5.parent = this.startMiniGameScreenParent;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_5.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        if(val_5 != null)
        {
                val_5.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        else
        {
                val_5.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        
        StartMiniGameGuiController val_8 = val_5.GetComponent<StartMiniGameGuiController>();
        this.丈丁下丟不不丛丗丏 = val_8;
        if(val_8 != null)
        {
            goto label_17;
        }
        
        goto label_18;
    }
    internal void 丗丗与丝丐业丘丆丈()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.gameObject, 丏业丟一东丂东丘丛:  true);
        this.七丘丝丆丏丘丗丏丄 = false;
    }
    public void HandleGoBtnClicked()
    {
        var val_22;
        Rilisoft.七丕丟丏三丈一丄世 val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        val_22 = null;
        val_22 = null;
        if(ConnectScene.一七丁三丄专下且丂 == null)
        {
                val_23 = 1152921505704501248;
            if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 != 0)
        {
                PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丆丆丄丈与丐丐一丛(上且丁万丝世三丄丂:  2);
            return;
        }
        
        }
        
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  0)) == true)
        {
                return;
        }
        
        if((GameConnect.丑丌丛丈丅丅与不业() != 22) || (this.connectSceneSelectMap.selectMap.mapID < 1))
        {
            goto label_14;
        }
        
        val_24 = null;
        val_24 = null;
        if(ConnectScene.丄丞丁丈与业上丞丟.丛丁丅丆丅与万三丅 == 0)
        {
            goto label_26;
        }
        
        val_25 = null;
        val_25 = null;
        if(gameObject.activeInHierarchy == false)
        {
            goto label_26;
        }
        
        label_14:
        if((GameConnect.丑丌丛丈丅丅与不业() == 24) && (this.connectSceneSelectMap != 0))
        {
                if((this.connectSceneSelectMap.selectMap != 0) && (this.connectSceneSelectMap.selectMap.业丒与丐不丘七业丒 == 11))
        {
                val_26 = null;
            val_26 = null;
            MainMenuController.丄丞丁丈与业上丞丟.StartCampaingButton();
            return;
        }
        
        }
        
        if((丐东不丅丂丂丅丙不.东丌丄丒丟不业专七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != false)
        {
                val_27 = null;
            val_27 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_28 = null;
            val_28 = null;
            丈且东丑丂且万丒丅(丂丈丆丅丟七丐专世:  new System.Action(object:  this, method:  System.Void ConnectScene::且丒丏下丙万丛与丅()));
            return;
        }
        
        }
        
        SceneInfo val_22 = this.connectSceneSelectMap.selectMap.curSceneInfo;
        val_22 = (UnityEngine.Object.op_Inequality(x:  val_22, y:  0)) ^ 1;
        val_22 = ((this.connectSceneSelectMap.selectMap.squadMode == true) ? 1 : 0) & val_22;
        val_23 = GameConnect.丑丌丛丈丅丅与不业();
        if((PGCompany.GameModeLowDeviceWarningBanner.七丑丆丏东业专丒万(上且丗一丏丏万丅丌:  val_23, 东下丌丝且七丛丘丒:  this.connectSceneSelectMap.selectMap.curSceneInfo, 万丟丗丏专丆丌上三:  val_22, 丏丒且丄三世丆丕上:  new System.Action(object:  this, method:  System.Void ConnectScene::丆丞丒丞三丏丒东丌()))) != false)
        {
                return;
        }
        
        if(this.丆丙丗下专万丗世丑 != false)
        {
                if((this.connectScenePanelEventHint.mapEventWindow == 0) || (this.connectScenePanelEventHint.mapEventWindow.gameObject.activeSelf == false))
        {
            goto label_76;
        }
        
        }
        
        this.丆丑丑丆丗丗且丛丑(丟丟东丏世三一三丟:  false);
        return;
        label_26:
        val_29 = null;
        val_29 = null;
        ConnectScene.丄丞丁丈与业上丞丟.丈丌一丗丞丂丂丟丞(下丒丏丙一不七丕丏:  this.connectSceneSelectMap.selectMap);
        return;
        label_76:
        this.且丐丆且丝丑丒东业(下丒丏丙一不七丕丏:  this.connectSceneSelectMap.selectMap);
    }
    private void 与丐丑业丐丅且丐丈(PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘)
    {
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0)
        {
                this.东三丘丘丝丛不丆丆 = true;
            Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  丌丝万上丅丒一丈丘);
        }
        
        SceneInfo val_9 = this.connectSceneSelectMap.selectMap.curSceneInfo;
        val_9 = (UnityEngine.Object.op_Inequality(x:  val_9, y:  0)) ^ 1;
        val_9 = ((this.connectSceneSelectMap.selectMap.squadMode == true) ? 1 : 0) & val_9;
        if((PGCompany.GameModeLowDeviceWarningBanner.七丑丆丏东业专丒万(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 东下丌丝且七丛丘丒:  this.connectSceneSelectMap.selectMap.curSceneInfo, 万丟丗丏专丆丌上三:  val_9, 丏丒且丄三世丆丕上:  new System.Action(object:  this, method:  System.Void ConnectScene::丏一三东丆丌丛丛三()))) != false)
        {
                return;
        }
        
        this.丆丑丑丆丗丗且丛丑(丟丟东丏世三一三丟:  false);
        this.丑丌丙丙丞丗丙七丂();
    }
    private void 丆丑丑丆丗丗且丛丑(bool 丟丟东丏世三一三丟)
    {
        object val_18;
        string val_19;
        MapPreviewController val_20;
        var val_21;
        System.Action val_22;
        val_18 = this;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_19 = this.connectSceneSelectMap.selectMap.sceneMapName;
        PGCompany.Analytics.一业丗丆世世上丁且.丝丂丘与丂丙丅上丆(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业().ToString(), 丏丈丗世丙万丆丐丅:  val_19);
        if(this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅 == null)
        {
            goto label_18;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_4 = this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_4.HasValue.丙东专丂世丈丏丁丂() != 2) || (((-291482056) & 1) == 0))
        {
            goto label_18;
        }
        
        val_20 = this.connectSceneSelectMap.selectMap;
        if((PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.上万世丒丁万下丌丛(丏丒丒丌一丌东丘丝:  this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七(), 万且丕业与丗丗丝七:  false)) == false)
        {
            goto label_25;
        }
        
        this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅.丅不东丁下丒丆东下();
        label_18:
        this.丏丐不三丘丌不丟不();
        this.丂丅丈丕三世丈丒下();
        if(GameConnect.丑丌丛丈丅丅与不业() == 34)
        {
                val_20 = this.connectSceneSelectMap.selectMap;
            if(val_20 == 0)
        {
                return;
        }
        
            val_20 = this.connectSceneSelectMap.selectMap;
            if(this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
            System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_10 = this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅.业丄丄且丕丕不一万();
            GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  val_10.HasValue);
        }
        
        val_21 = null;
        val_21 = null;
        if(ConnectScene.丙东丁丂丝世丑丒丘 == 24)
        {
                val_20 = this.connectSceneSelectMap.selectMap;
            if(this.connectSceneSelectMap.selectMap.mapID == 3)
        {
                this.专丆丏且丟丆世丏三(与丛丛丟丅世丏丐丌:  this.connectSceneSelectMap.selectMap.业丒与丐不丘七业丒);
            return;
        }
        
        }
        
        val_20 = this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅;
        this.东三万丙上丙丅丑一(丟丟东丏世三一三丟:  丟丟东丏世三一三丟);
        if(val_20 != null)
        {
                return;
        }
        
        if(this.丙不丅丝丙专丕世丐 == 0)
        {
                return;
        }
        
        val_22 = System.Delegate.Remove(source:  this.丙不丅丝丙专丕世丐.丂一丑丛不专万丁上, value:  new System.Action(object:  this, method:  System.Void ConnectScene::丄上一丌专丞且丗世()));
        if((val_22 != null) && (null != null))
        {
                val_22 = 0;
        }
        
        this.丙不丅丝丙专丕世丐.丂一丑丛不专万丁上 = val_22;
        val_19 = this.丙不丅丝丙专丕世丐;
        System.Action val_16 = null;
        val_20 = val_16;
        val_16 = new System.Action(object:  this, method:  System.Void ConnectScene::丄上一丌专丞且丗世());
        val_18 = System.Delegate.Combine(a:  this.丙不丅丝丙专丕世丐.丂一丑丛不专万丁上, b:  val_16);
        if((val_18 != null) && (null != null))
        {
                val_18 = 0;
        }
        
        this.丙不丅丝丙专丕世丐.丂一丑丛不专万丁上 = val_18;
        return;
        label_25:
        this.且丐丆且丝丑丒东业(下丒丏丙一不七丕丏:  val_20);
    }
    internal void 丁丗不东丛丐丟丛且()
    {
        if(this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if(val_1.HasValue.丙东专丂世丈丏丁丂() != 4)
        {
                return;
        }
        
        if(((-291120168) & 1) == 0)
        {
                return;
        }
        
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        this = this.connectSceneSelectMap.selectMap.业丞丟万不丄丂丘丑;
        val_3.competitionConnectWindow.丘丌丄万丞一万丐丅(丐且丘丑与万丞丑丅:  this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅, 业丞丟万不丄丂丘丑:  this, 下丞七丒业丂丈丘下:  this.connectSceneSelectMap.selectMap.mapID);
    }
    private void 东三万丙上丙丅丑一(bool 丟丟东丏世三一三丟)
    {
        ConnectScene val_21;
        MapPreviewController val_22;
        Rilisoft.七丕丟丏三丈一丄世 val_23;
        bool val_24;
        var val_25;
        val_21 = this;
        ConnectScene.丏丛丅丁丑丆丑东丌 val_1 = new ConnectScene.丏丛丅丁丑丆丑东丌();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = val_21;
        }
        else
        {
                mem[16] = val_21;
        }
        
        .丟丟东丏世三一三丟 = 丟丟东丏世三一三丟;
        AppsMenu.与不丅丑下专丟丈丟();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "HandleGoBtnClicked");
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.battleNowButtonSound);
        }
        
        val_22 = this.connectSceneSelectMap.selectMap;
        if(this.connectSceneSelectMap.selectMap.mapID == 1)
        {
            goto label_13;
        }
        
        val_22 = this.connectSceneSelectMap.selectMap;
        if(this.connectSceneSelectMap.selectMap.mapID != 2)
        {
            goto label_16;
        }
        
        this.上与丏丌七万丈且丝(丟丟东丏世三一三丟:  (ConnectScene.丏丛丅丁丑丆丑东丌)[1152921525790925280].丟丟东丏世三一三丟);
        return;
        label_13:
        if(GameConnect.丂丏且丄丆丏与丄上() != false)
        {
                GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  ((UnityEngine.Random.Range(min:  0, max:  2)) != 0) ? (4 + 1) : 4);
        }
        
        if(GameConnect.丌不丅丆丏三丅丙上() == false)
        {
            goto label_25;
        }
        
        if(((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  8)) == false) || ((UnityEngine.Random.Range(min:  0, max:  2)) == 0))
        {
            goto label_30;
        }
        
        val_22 = 8;
        goto label_31;
        label_16:
        System.Nullable<System.Boolean> val_12 = TrainingController.万丑万专丑三专丏丟();
        if(((-290802228) & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if(GameConnect.丂丏且丄丆丏与丄上() != true)
        {
                if(GameConnect.丌不丅丆丏三丅丙上() == false)
        {
            goto label_47;
        }
        
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != this.connectSceneSelectMap.selectMap.业丞丟万不丄丂丘丑)
        {
                GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  this.connectSceneSelectMap.selectMap.业丞丟万不丄丂丘丑);
        }
        
        label_47:
        if(((this.connectSceneSelectMap.selectMap == 0) || (this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅 == null)) || (this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅.且丆不丈丞专下世丐() == false))
        {
            goto label_62;
        }
        
        val_23 = 28;
        goto label_65;
        label_62:
        if(GameConnect.丑丌丛丈丅丅与不业() != 28)
        {
            goto label_68;
        }
        
        val_23 = 2;
        label_65:
        GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  val_23);
        label_68:
        if(GameConnect.丑丌丛丈丅丅与不业() == 20)
        {
                val_24 = this.connectSceneSelectMap.selectMap.squadMode;
        }
        else
        {
                val_24 = false;
        }
        
        val_25 = null;
        val_25 = null;
        GameConnect.丙丙东七丙丞专丛不 = val_24;
        val_22 = this.丙不丅丝丙专丕世丐;
        val_21 = this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅;
        val_22.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void ConnectScene.丏丛丅丁丑丆丑东丌::丌与丈三且丐丞丁丑()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  false, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  val_21, 丛且丞与丕业下丏丞:  this.connectSceneSelectMap.selectMap.mapID, 丆丅丙丞丈丘丌万丙:  false);
        return;
        label_30:
        val_22 = 16;
        label_31:
        GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  mem[16]);
        label_25:
        this.丏东万丙一万丌且世(丟丟东丏世三一三丟:  (ConnectScene.丏丛丅丁丑丆丑东丌)[1152921525790925280].丟丟东丏世三一三丟);
    }
    private void 丅丌七丏丐丟丕丗丈()
    {
        var val_3;
        this.丘丛上丑丗上世专业 = true;
        val_3 = null;
        val_3 = null;
        SceneInfo val_1 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  this.connectSceneSelectMap.selectMap.mapID);
        if(this.connectSceneSelectMap.selectMap.mapID == 1)
        {
            goto label_10;
        }
        
        if(this.connectSceneSelectMap.selectMap.mapID != 2)
        {
            goto label_13;
        }
        
        this.丅丌丄上一不丗丅上();
        return;
        label_10:
        this.丛东丙丆业一丑丙不();
        return;
        label_13:
        if(val_1 == 0)
        {
                return;
        }
        
        this.丙不丅丝丙专丕世丐.一丙丅丛丁东丅丅世(上业丈东万下世丝丁:  0, 丏丈丗世丙万丆丐丅:  val_1, 丐且丘丑与万丞丑丅:  this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅);
    }
    public void HandleBackBtnClicked()
    {
        this.丝东丐丝东三丈世丝(东丄丛丝三丛丘丟丑:  false);
    }
    public void HandleBackBtnClickedSkipBannershShow()
    {
        this.丝东丐丝东三丈世丝(东丄丛丝三丛丘丟丑:  false);
    }
    private void 丝东丐丝东三丈世丝(bool 东丄丛丝三丛丘丟丑)
    {
        var val_57;
        var val_58;
        string val_59;
        var val_60;
        var val_61;
        var val_62;
        System.Collections.Generic.List<UnityEngine.GameObject> val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        if(this.丏丑丆丐丏丐下与丘 == true)
        {
                return;
        }
        
        if((this.connectSceneMainMenu.gameObject != 0) && (this.connectSceneMainMenu.gameObject.activeSelf != false))
        {
                if((this.loadingMapPanel != 0) && (this.loadingMapPanel.activeSelf != false))
        {
                GameConnect.下与业丒丝丕丙丘丙();
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
            this.loadingMapPanel.SetActive(value:  false);
        }
        else
        {
                MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = true;
            BannerWindowController.与丅与丒丅专丙丐丗().ResetScene();
            val_57 = null;
            val_57 = null;
            MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
            this.gameObject.SetActive(value:  false);
            this.丈丝丛东且丁丝且三 = false;
            val_58 = null;
            val_58 = null;
            ConnectScene.专上且丗丑丌丟丈丄 = false;
            val_59 = 1152921505080860672;
            val_60 = null;
            val_60 = null;
            val_58 = null;
            MainMenuController.丆不丑丆下丞丙不丞 = false;
            ConnectScene.专七下丑丈三上下丞 = false;
            Rilisoft.丛丅丘业丏丕下业丏.丑七不且上丗丁一世().世世三不丏与丌与专();
            PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
        }
        
        }
        
        if(this.丏上丒专丞丑东且丞 == false)
        {
            goto label_175;
        }
        
        CustomPanelConnectScene val_13 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_13.customPanel == 0)
        {
            goto label_89;
        }
        
        CustomPanelConnectScene val_15 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_15.customPanel.activeSelf == false)
        {
            goto label_89;
        }
        
        this.丏上丒专丞丑东且丞 = false;
        val_61 = null;
        val_61 = null;
        GameConnect.丛丑世丕丌上丑丂丈 = false;
        this.connectSceneSelectMap.SetWideBg(三丟东丕丄丄下下丑:  (GameConnect.丛丑世丕丌上丑丂丈 == true) ? 1 : 0);
        CustomPanelConnectScene val_18 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_18.connectToWiFIInCreateLabel.SetActive(value:  false);
        CustomPanelConnectScene val_19 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_19.connectToWiFIInCustomLabel.SetActive(value:  false);
        CustomPanelConnectScene val_20 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_62 = null;
        val_62 = null;
        与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 = true;
        CustomPanelConnectScene val_21 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_21.customPanel.SetActive(value:  false);
        goto label_63;
        label_78:
        CustomPanelConnectScene val_22 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Transform val_23 = val_22.gridGamesTransform.GetChild(index:  0);
        if(val_23 != null)
        {
                val_23.parent = 0;
            val_63 = this.gamesInfo;
        }
        else
        {
                0.parent = 0;
            val_63 = this.gamesInfo;
        }
        
        bool val_25 = val_63.Remove(item:  val_23.gameObject);
        UnityEngine.Object.Destroy(obj:  val_23.gameObject);
        label_63:
        CustomPanelConnectScene val_27 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_27.gridGamesTransform.childCount > 0)
        {
            goto label_78;
        }
        
        val_59 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneMainMenu.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtn, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtnSecond, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.gameObject, 丏业丟一东丂东丘丛:  true);
        GameConnect.下与业丒丝丕丙丘丙();
        val_64 = null;
        val_64 = null;
        if(ConnectScene.一七丁三丄专下且丂 == null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newConnectScene, 丏业丟一东丂东丘丛:  true);
        }
        
        label_89:
        if(this.丏上丒专丞丑东且丞 != false)
        {
                CustomPanelConnectScene val_31 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_31.searchPanel != 0)
        {
                CustomPanelConnectScene val_33 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_33.searchPanel.activeSelf != false)
        {
                CustomPanelConnectScene val_35 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_59 = this.gameNameFilter;
            val_35.searchInput.value = val_59;
            CustomPanelConnectScene val_36 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_36.searchPanel.SetActive(value:  false);
            CustomPanelConnectScene val_37 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_37.customPanel.SetActive(value:  true);
        }
        
        }
        
            if(this.丏上丒专丞丑东且丞 != false)
        {
                CustomPanelConnectScene val_38 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_38.createPanel != 0)
        {
                CustomPanelConnectScene val_40 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_40.createPanel.activeSelf != false)
        {
                CustomPanelConnectScene.丑七不且上丗丁一世().上丁且丐与万七丌丞();
        }
        
        }
        
            if(this.丏上丒专丞丑东且丞 != false)
        {
                CustomPanelConnectScene val_43 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_43.enterPasswordPanel != 0)
        {
                CustomPanelConnectScene val_45 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_45.enterPasswordPanel.activeSelf != false)
        {
                CustomPanelConnectScene val_47 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_47.enterPasswordPanel.SetActive(value:  false);
            CustomPanelConnectScene val_48 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_48.customPanel.SetActive(value:  true);
            val_59 = 1152921505061052416;
            val_65 = null;
            val_65 = null;
            if(ExperienceController.sharedController != 0)
        {
                val_66 = null;
            val_66 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        }
        
            if(this.丏上丒专丞丑东且丞 != false)
        {
                CustomPanelConnectScene val_50 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_50.enterPasswordCustomPanel != 0)
        {
                CustomPanelConnectScene val_52 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_52.enterPasswordCustomPanel.activeSelf != false)
        {
                CustomPanelConnectScene val_54 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_54.enterPasswordCustomPanel.SetActive(value:  false);
            CustomPanelConnectScene val_55 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_55.customPanel.SetActive(value:  true);
            val_59 = 1152921505061052416;
            val_67 = null;
            val_67 = null;
            if(ExperienceController.sharedController != 0)
        {
                val_68 = null;
            val_68 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_175:
        if(this.且丂丗七丕上丄丘与 == null)
        {
                return;
        }
        
        this.且丂丗七丕上丄丘与.Invoke();
        this.且丂丗七丕上丄丘与 = 0;
    }
    private void 丐丛丛专丄丆丕丛不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_9;
        ConnectScene.丏专丙丈丄不世丕丙 val_1 = new ConnectScene.丏专丙丈丄不世丕丙();
        if(val_1 != null)
        {
                val_9 = val_1;
            .丐丂丛与万丛丞丘万 = 0;
            mem[1152921525792388480] = this;
        }
        else
        {
                mem[32] = this;
            val_9 = 16;
            mem[16] = 0;
        }
        
        .丆丌且丕丏丛丐上不 = "";
        if(GameConnect.丑丌丛丈丅丅与不业() == 4)
        {
                mem[16] = 与丂丏丛丞丞丒丟丄.世丈丄丛丄丒丁丘三();
            .丆丌且丕丏丛丐上不 = 与丂丏丛丞丞丒丟丄.丝丏丆丛三丆一业丟();
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 3)
        {
                mem[16] = 与丂丏丛丞丞丒丟丄.丙丄丄丘丁三丒丌丅();
            .丆丌且丕丏丛丐上不 = 与丂丏丛丞丞丒丟丄.三丄丙上七丂丒世丗();
        }
        
        new System.Action(object:  val_1, method:  System.Void ConnectScene.丏专丙丈丄不世丕丙::丒丏丝上丌丑三上下()).Invoke();
    }
    private static void 丛丏专且丏丞丒丌下()
    {
        null = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = true;
        与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 = true;
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
    }
    internal void 专七上丐丟丈丟丆丏()
    {
    
    }
    private Rilisoft.七丕丟丏三丈一丄世 丁丞三丁丂丁三丏丂(Rilisoft.七丕丟丏三丈一丄世 丒七世丈丌丑丏丄丏)
    {
        if(丒七世丈丌丑丏丄丏 <= 16)
        {
                if(丒七世丈丌丑丏丄丏 == 5)
        {
                return 34;
        }
        
            if(丒七世丈丌丑丏丄丏 != 16)
        {
                return (Rilisoft.七丕丟丏三丈一丄世)(丒七世丈丌丑丏丄丏 == 33) ? 34 : 丒七世丈丌丑丏丄丏;
        }
        
            return 8;
        }
        
        if(丒七世丈丌丑丏丄丏 == 17)
        {
                return 34;
        }
        
        if(丒七世丈丌丑丏丄丏 != 32)
        {
                return (Rilisoft.七丕丟丏三丈一丄世)(丒七世丈丌丑丏丄丏 == 33) ? 34 : 丒七世丈丌丑丏丄丏;
        }
        
        4 = 34;
        return 34;
    }
    private void 丒丈丝丛丅丂丟丑丁(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        if(上且丗一丏丏万丅丌 > 35)
        {
                return;
        }
        
        var val_6 = 106020112 + (上且丗一丏丏万丅丌) << 2;
        val_6 = val_6 + 106020112;
        goto (106020112 + (上且丗一丏丏万丅丌) << 2 + 106020112);
    }
    internal void 丘东万丙丌丑丄丗专(Rilisoft.七丕丟丏三丈一丄世 丒七世丈丌丑丏丄丏)
    {
        this.丒丈丝丛丅丂丟丑丁(上且丗一丏丏万丅丌:  丒七世丈丌丑丏丄丏);
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  丒七世丈丌丑丏丄丏, 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  (丒七世丈丌丑丏丄丏 == 35) ? 1 : 0);
    }
    internal void 丏下丘丂丟丈与不与(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        var val_5;
        ConnectScene.东丞丘丏丛丗东业丏 val_1 = new ConnectScene.东丞丘丏丛丗东业丏();
        val_5 = 4;
        if(上且丗一丏丏万丅丌 > 16)
        {
            goto label_1;
        }
        
        if(上且丗一丏丏万丅丌 == 5)
        {
            goto label_6;
        }
        
        if(上且丗一丏丏万丅丌 != 16)
        {
            goto label_7;
        }
        
        val_5 = 8;
        if(val_1 != null)
        {
            goto label_11;
        }
        
        goto label_12;
        label_1:
        if(上且丗一丏丏万丅丌 == 17)
        {
            goto label_6;
        }
        
        if(上且丗一丏丏万丅丌 != 32)
        {
            goto label_7;
        }
        
        val_5 = 34;
        label_6:
        if(val_1 != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        .丂丂丙丐丈专丕丈丘 = 34;
        BtnCategory val_3 = System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  this.connectSceneMainMenu.modeButtonByLevel, predicate:  new System.Func<BtnCategory, System.Boolean>(object:  val_1, method:  System.Boolean ConnectScene.东丞丘丏丛丗东业丏::专丈丈丒丒丅上丒下(BtnCategory 东丁丈且丌丄七专三)));
        if(val_3 == null)
        {
                return;
        }
        
        val_3.专丅丁万世七丒丑丕();
        return;
        label_7:
        var val_4 = (上且丗一丏丏万丅丌 == 33) ? 34 : 上且丗一丏丏万丅丌;
        if(val_1 != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    internal void 世丞丄丝专上丐丗丂()
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        if(MapPopularityController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 4)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 17)
        {
            goto label_14;
        }
        
        }
        
        }
        
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_5 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
        if(val_5 != null)
        {
                val_5.Add(item:  4);
            val_5.Add(item:  5);
        }
        else
        {
                val_5.Add(item:  4);
            val_5.Add(item:  5);
        }
        
        label_23:
        val_5.Add(item:  17);
        val_9 = null;
        val_9 = null;
        MapPopularityController.丆丕丝丒不丙且丐丗.世丞丄丝专上丐丗丂(业丐世丆不上丏丏业:  val_5);
        return;
        label_14:
        Rilisoft.七丕丟丏三丈一丄世 val_7 = GameConnect.丑丌丛丈丅丅与不业();
        if((new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>()) != null)
        {
            goto label_23;
        }
        
        goto label_23;
    }
    internal void 丟三丛万丅丙丆万丑(Rilisoft.七丕丟丏三丈一丄世 丌丝专丕业丛丝丏世, bool 下不丄丞丒丕万丟三 = False, bool 丌丁丙上七丟丈丌七 = False)
    {
        object val_44;
        Rilisoft.七丕丟丏三丈一丄世 val_45;
        var val_46;
        Rilisoft.七丕丟丏三丈一丄世 val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        UnityEngine.GameObject val_52;
        UnityEngine.Object val_53;
        Rilisoft.七丕丟丏三丈一丄世 val_54;
        BtnCategory val_55;
        Rilisoft.七丕丟丏三丈一丄世 val_56;
        var val_57;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        ConnectScene.上丆丛丒丄丑丈丄丄 val_1 = null;
        val_44 = val_1;
        val_1 = new ConnectScene.上丆丛丒丄丑丈丄丄();
        .丌丝专丕业丛丝丏世 = 丌丝专丕业丛丝丏世;
        if(((GameConnect.丑丌丛丈丅丅与不业() == (ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世) && (下不丄丞丒丕万丟三 != true)) && (丌丁丙上七丟丈丌七 != true))
        {
                if(this.丆丙丗下专万丗世丑 == false)
        {
                return;
        }
        
        }
        
        this.丆丙丗下专万丗世丑 = 丌丁丙上七丟丈丌七;
        if(this.competitionSelectPanel != 0)
        {
                this.competitionSelectPanel.SetActive(value:  丌丁丙上七丟丈丌七);
        }
        
        ConnectSceneSelectMap val_6 = this.connectSceneSelectMap.GetComponent<ConnectSceneSelectMap>();
        UIPanel val_8 = val_6.scrollViewSelectMapTransform.gameObject.GetComponent<UIPanel>();
        mem2[0] = (丌丁丙上七丟丈丌七 != true) ? 208 : -113;
        if((ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世 == 1)
        {
            goto label_18;
        }
        
        if((ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世 != 16)
        {
            goto label_19;
        }
        
        val_45 = 8;
        goto label_20;
        label_18:
        val_45 = 2;
        label_20:
        .丌丝专丕业丛丝丏世 = val_45;
        label_19:
        this.丟上丐三丌丗丏丕三 = ExperienceController.丞丞丘业东丙丏七丌();
        if((ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世 != 9)
        {
            goto label_23;
        }
        
        val_46 = 1;
        val_47 = 9;
        goto label_30;
        label_23:
        ConnectScene.RegimMulty = (ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世;
        val_47 = (ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世;
        if(val_47 != 4)
        {
                if(val_47 != 5)
        {
            goto label_28;
        }
        
        }
        
        val_46 = 0;
        goto label_30;
        label_28:
        if(val_47 != 16)
        {
            goto label_30;
        }
        
        val_48 = 1;
        if(丌丁丙上七丟丈丌七 == true)
        {
            goto label_137;
        }
        
        goto label_33;
        label_30:
        var val_12 = (9 == 8) ? 1 : 0;
        if(丌丁丙上七丟丈丌七 == false)
        {
            goto label_33;
        }
        
        label_137:
        val_49 = 0;
        goto label_142;
        label_33:
        val_49 = 0;
        if(val_47 != 20)
        {
                if(val_47 != 31)
        {
            goto label_36;
        }
        
        }
        
        label_142:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.alternativPanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.alternativeWaysContainer.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneMainMenu.battleRoyalePlayMethodContainer.gameObject, 丏业丟一东丂东丘丛:  ((ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世 == 20) ? 1 : 0);
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  (ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世);
        (ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世.世丞丄丝专上丐丗丂();
        if(this.DoubleRewardConnectScene != 0)
        {
                this.DoubleRewardConnectScene.丗与丄丑一丈丙不丛(上且丗一丏丏万丅丌:  (ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世);
        }
        
        val_50 = null;
        val_50 = null;
        ConnectScene.丙东丁丂丝世丑丒丘 = GameConnect.丑丌丛丈丅丅与不业();
        val_51 = null;
        val_51 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = true;
        与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 = true;
        if(Rilisoft.与丄丁丄丙丞下下丙.东下丝上丗一一丛丟() != false)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
        {
            goto label_58;
        }
        
        }
        
        label_143:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.localBtn, 丏业丟一东丂东丘丛:  false);
        if(this.connectSceneSelectMap.customBtn != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.customBtn, 丏业丟一东丂东丘丛:  (val_48 == 0) ? 1 : 0);
        }
        
        if(this.connectSceneMainMenu.goBtn != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneMainMenu.goBtn, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.connectSceneSelectMap.customDuelBtn != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.customDuelBtn, 丏业丟一东丂东丘丛:  true);
            UIButton val_26 = this.connectSceneSelectMap.customDuelBtn.GetComponent<UIButton>();
            Rilisoft.七丕丟丏三丈一丄世 val_43 = 8;
            val_43 = (~(Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  val_43))) & 1;
        }
        
        val_52 = this.connectSceneSelectMap.customTeamDuelBtn;
        val_53 = 0;
        if(val_52 != val_53)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.customTeamDuelBtn, 丏业丟一东丂东丘丛:  true);
            UIButton val_30 = this.connectSceneSelectMap.customTeamDuelBtn.GetComponent<UIButton>();
            val_52 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  16);
            val_53 = (~val_52) & 1;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_54 = 9;
        }
        else
        {
                val_54 = GameConnect.丑丌丛丈丅丅与不业();
        }
        
        this.丟专丒丅丄不丅七专(丂丛丑东不丅丈一东:  val_54);
        val_55 = null;
        val_55 = null;
        val_56 = ConnectScene.丙东丁丂丝世丑丒丘;
        if(val_56 == 8)
        {
            goto label_111;
        }
        
        val_56 = ConnectScene.丙东丁丂丝世丑丒丘;
        if(val_56 != 16)
        {
            goto label_118;
        }
        
        label_111:
        val_55 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        if((val_55.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  8)) != false)
        {
                val_55 = 0;
            Rilisoft.业丈下丒丁专万七丗.三丅不丂丒丂且业丏();
        }
        
        label_118:
        if(this.connectSceneMainMenu == null)
        {
                val_55 = 0;
        }
        
        if(this.connectSceneMainMenu.modeButtonByLevel == null)
        {
            goto label_132;
        }
        
        val_55 = new BtnCategory();
        if(丌丁丙上七丟丈丌七 == false)
        {
            goto label_124;
        }
        
        val_57 = null;
        val_57 = null;
        val_52 = ConnectScene.<>c.<>9__229_1;
        if(val_52 != null)
        {
            goto label_130;
        }
        
        System.Func<BtnCategory, System.Boolean> val_37 = null;
        val_52 = val_37;
        val_37 = new System.Func<BtnCategory, System.Boolean>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ConnectScene.<>c::丝丏丆丌丙与东世丂(BtnCategory 丛与丝且与东丅丟丄));
        ConnectScene.<>c.<>9__229_1 = val_52;
        goto label_130;
        label_124:
        System.Func<BtnCategory, System.Boolean> val_38 = null;
        val_52 = val_38;
        val_38 = new System.Func<BtnCategory, System.Boolean>(object:  val_1, method:  System.Boolean ConnectScene.上丆丛丒丄丑丈丄丄::丟不与丄七一丁丐上(BtnCategory 丛与丝且与东丅丟丄));
        label_130:
        if(((System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  this.connectSceneMainMenu.modeButtonByLevel, predicate:  val_38)) != null) && (val_39.unlocksController != null))
        {
                val_39.unlocksController.丂丆上丙丌丘万东丝();
        }
        
        label_132:
        if(丌丁丙上七丟丈丌七 != false)
        {
                val_59 = 1;
            val_60 = 1;
            val_61 = 0;
            val_62 = 0;
            val_63 = 0;
        }
        else
        {
                val_61 = 1;
            val_63 = 1;
            val_59 = 1;
            val_62 = 0;
            val_60 = 0;
        }
        
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  false, 世丆丏七且业下丅专:  true, 业三丆丙丗丑丏丆不:  true, 一丅丆丂七与丆丈丂:  false);
        this.丆丑与下业丆专且丄();
        this.业丂下不丌与东丐业();
        return;
        label_58:
        if((ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世 == 0)
        {
            goto label_143;
        }
        
        var val_40 = ((ConnectScene.上丆丛丒丄丑丈丄丄)[1152921525793948000].丌丝专丕业丛丝丏世 == 2) ? 1 : 0;
        goto label_143;
        label_36:
        if(((val_47 != 17) ? 1 : 0) == 0)
        {
            goto label_137;
        }
        
        if((val_47 == 22) || (val_47 == 24))
        {
            goto label_142;
        }
        
        var val_42 = (ExperienceController.丞丞丘业东丙丏七丌() > 2) ? 1 : 0;
        goto label_142;
    }
    internal void 丁丛丘丅业丙丗丗与(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        if(GameConnect.丑丌丛丈丅丅与不业() != 丂丛丑东不丅丈一东)
        {
                GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  丂丛丑东不丅丈一东);
        }
        
        this.丟专丒丅丄不丅七专(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
    }
    internal void 丟专丒丅丄不丅七专(Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_3 = null;
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.connectSceneMainMenu.rulesLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丕丒上东丞丕丞一三.Item[???]);
    }
    public Rilisoft.DoubleRewardConnectScene get_DoubleRewardConnectScene()
    {
        if(this.connectSceneMainMenu.doubleRewardConnectScene == 0)
        {
                this.connectSceneMainMenu.doubleRewardConnectScene = this.GetComponentInChildren<Rilisoft.DoubleRewardConnectScene>();
        }
        
        if(this.connectSceneMainMenu != null)
        {
                return (Rilisoft.DoubleRewardConnectScene)this.connectSceneMainMenu.doubleRewardConnectScene;
        }
        
        return (Rilisoft.DoubleRewardConnectScene)this.connectSceneMainMenu.doubleRewardConnectScene;
    }
    public Rilisoft.NeedSquadLevelConnectScene get_NeedSquadLevelConnectSceneScript()
    {
        if(this.connectSceneMainMenu.needSquadLevelConncectScene == 0)
        {
                this.connectSceneMainMenu.needSquadLevelConncectScene = this.GetComponentInChildren<Rilisoft.NeedSquadLevelConnectScene>();
        }
        
        if(this.connectSceneMainMenu != null)
        {
                return (Rilisoft.NeedSquadLevelConnectScene)this.connectSceneMainMenu.needSquadLevelConncectScene;
        }
        
        return (Rilisoft.NeedSquadLevelConnectScene)this.connectSceneMainMenu.needSquadLevelConncectScene;
    }
    private static bool 丌丐丄丈丘且丑丐丈()
    {
        return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "goToLobbyHintShownKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
    }
    private static void 丅与丂丟丂丏不丕万(bool 丙业与丙丗丝不丈东)
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "goToLobbyHintShownKey", 下下丏一丙不丘丌丞:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void OnEnable()
    {
        object val_65;
        var val_66;
        bool val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        System.Action<System.String> val_74;
        var val_75;
        System.Action<System.Boolean> val_76;
        var val_77;
        System.Action val_78;
        var val_79;
        var val_80;
        System.Action val_81;
        var val_82;
        var val_83;
        System.Action val_84;
        var val_85;
        System.Action<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_86;
        var val_87;
        var val_88;
        string val_90;
        var val_91;
        var val_92;
        var val_94;
        var val_95;
        var val_96;
        System.Action<HintController> val_98;
        var val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        val_65 = this;
        val_66 = null;
        val_66 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.oldConnectScene, 丏业丟一东丂东丘丛:  (ConnectScene.一七丁三丄专下且丂 != null) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newConnectScene, 丏业丟一东丂东丘丛:  (ConnectScene.一七丁三丄专下且丂 == null) ? 1 : 0);
        GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  ConnectScene.丙东丁丂丝世丑丒丘);
        GameConnect.丛丑世丕丌上丑丂丈 = false;
        val_67 = GameConnect.丛丑世丕丌上丑丂丈;
        this.connectSceneSelectMap.SetWideBg(三丟东丕丄丄下下丑:  (val_67 == true) ? 1 : 0);
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        BankController val_5 = BankController.丑七不且上丗丁一世();
        val_68 = null;
        if(val_5.uiRoot.gameObject.activeInHierarchy != false)
        {
                val_68 = null;
            if(ConnectScene.丝上丅丒丂与与不丁 == false)
        {
                return;
        }
        
        }
        
        val_68 = null;
        ConnectScene.丝上丅丒丂与与不丁 = false;
        val_69 = null;
        val_69 = null;
        NotificationController.丄丘七三上丕世丞业.SaveTimeValues();
        if((this.丟上丐三丌丗丏丕三 != ExperienceController.丞丞丘业东丙丏七丌()) && (this.丟上丐三丌丗丏丕三 != 1))
        {
                this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  GameConnect.丑丌丛丈丅丅与不业(), 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
        }
        
        val_70 = null;
        val_70 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_71 = null;
            val_71 = null;
            if(ConnectScene.专上且丗丑丌丟丈丄 != false)
        {
                if(this.丙一丑丘丘万东七丟 == false)
        {
            goto label_39;
        }
        
        }
        
            val_72 = null;
            val_72 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        label_39:
        ConnectScene.东丈业东丛丗七丘不(丙业与丙丗丝不丈东:  true);
        val_73 = null;
        val_73 = null;
        val_75 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄丐七不丂丑且上丛, b:  new System.Action<System.String>(object:  this, method:  public System.Void ConnectScene::OnJoinToMap(string 七丆丂丂下丈且丟世)))) != null) && (null != null))
        {
                val_75 = null;
            val_74 = 0;
        }
        
        GameConnect.丄丐七不丂丑且上丛 = val_74;
        val_77 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void ConnectScene::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_77 = null;
            val_76 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_76;
        val_79 = null;
        val_80 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void ConnectScene::丂丐与丞丗丒丘丑上()))) != null) && (null != val_80))
        {
                val_79 = null;
            val_80 = null;
            val_78 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_78;
        val_82 = null;
        val_83 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void ConnectScene::OnJoinedRoom()))) != null) && (null != val_83))
        {
                val_82 = null;
            val_83 = null;
            val_81 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_81;
        val_85 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丐丗丈下三与丝丙业, b:  new System.Action(object:  this, method:  System.Void ConnectScene::OnReceivedRoomListUpdate()))) != null) && (null != val_85))
        {
                val_85 = null;
            val_84 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_84;
        MapPopularityController.丅丄不丌丑世且丒七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::与丄东世东业丏下丘()));
        Rilisoft.丐丌丝七下丈丒丅丗.丛丑丌丅东上丘丌与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::业丅东七且丅丛七丟()));
        if(((System.Delegate.Combine(a:  PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且, b:  new System.Action<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  this, method:  System.Void ConnectScene::丟丌万一一丛丑下一(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 与不下三丈专丘丂世, bool 东丅丞丁丗万且丁丗)))) != null) && (null != null))
        {
                val_86 = 0;
        }
        
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且 = val_86;
        val_87 = null;
        val_87 = null;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        ExperienceController.丞与丛一上丏丏东三();
        if((this.东三丘丘丝丛不丆丆 != true) && ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0))
        {
                val_88 = null;
            val_88 = null;
            if(SquadController.上丂七上丘且丕且丈 != 2)
        {
                this.东三丘丘丝丛不丆丆 = false;
            Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  0);
        }
        
        }
        
        this.丑丌丙丙丞丗丙七丂();
        if(丅丒丗丑丒丙丛不丆.专东世丞丂丐丂丈丁() == 2)
        {
                this.丘丛上丑丗上世专业 = true;
        }
        
        this.丕丛丟丅丂东业丆丆();
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_66 = 0;
            val_66 = val_66 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        val_90 = "Connect Scene";
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ConnectScene::东丏丛丞丒一且丑丕()), 与且专丈不万东一万:  val_90);
        if(this.与丘丏丆丁世世丁丗 != false)
        {
                this.丂世丝丞丁丝不东一();
        }
        
        if(this.丙一丑丘丘万东七丟 == false)
        {
            goto label_87;
        }
        
        val_91 = null;
        val_91 = null;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_91;
        }
        
        val_92 = 9;
        if(GameConnect.丕丒上东丞丕丞一三 != null)
        {
            goto label_96;
        }
        
        goto label_93;
        label_91:
        val_92 = GameConnect.丑丌丛丈丅丅与不业();
        if(GameConnect.丕丒上东丞丕丞一三 != null)
        {
            goto label_96;
        }
        
        label_93:
        label_96:
        var val_67 = 0;
        val_67 = val_67 + 1;
        val_90 = 0;
        this.connectSceneMainMenu.rulesLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丕丒上东丞丕丞一三.Item[null]);
        if(this.丙一丑丘丘万东七丟 == true)
        {
            goto label_107;
        }
        
        label_87:
        val_94 = null;
        val_94 = null;
        if(ConnectScene.专上且丗丑丌丟丈丄 == true)
        {
            goto label_107;
        }
        
        val_95 = null;
        val_95 = null;
        if(MainMenuController.丆不丑丆下丞丙不丞 == false)
        {
            goto label_110;
        }
        
        label_107:
        this.与一丂且丆七东三丏();
        业丂丏与世一丏业不.丑七不且上丗丁一世().丁下丝丐丑丂丈与丁();
        FriendsController.一丂丝丝丂丕丑丄与();
        label_110:
        val_96 = null;
        val_96 = null;
        val_98 = ConnectScene.<>c.<>9__244_1;
        if(val_98 == null)
        {
                System.Action<HintController> val_41 = null;
            val_98 = val_41;
            val_41 = new System.Action<HintController>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectScene.<>c::丕丞一一世丛与丐丗(HintController 三丟东丕丄丄下下丑));
            ConnectScene.<>c.<>9__244_1 = val_98;
        }
        
        HintController val_42 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<HintController>(丞下万上三丘上与专:  this.GetComponent<HintController>(), 丌专业且丛丏丞丝且:  val_41);
        if(this.丙一丑丘丘万东七丟 != true)
        {
                this.丙一丑丘丘万东七丟 = true;
        }
        
        val_99 = null;
        val_99 = null;
        if(ConnectScene.专七下丑丈三上下丞 != false)
        {
                UnityEngine.Coroutine val_44 = this.StartCoroutine(routine:  this.丌丞世丘万业丁世丐());
        }
        
        if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() != false)
        {
                if(PGCompany.BattlePass.BPTutorialController.不上且丈下丘丁丝七() != false)
        {
                PGCompany.BattlePass.BPTutorialController.丅上丛丝丄丐丁丌丒(丒且丆丘丞丑业丅不:  1);
        }
        
            if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() == 1)
        {
                PGCompany.BattlePass.BPTutorialController.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this.transform);
        }
        
        }
        
        PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丐丐且下丁丄丒专丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::丛丌丆三丅下丂丑丐()));
        FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::丛丌丆三丅下丂丑丐()));
        if(this.connectSceneMainMenu != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.connectSceneMainMenu.pixelPassHolder, 丏业丟一东丂东丘丛:  false);
            if(this.connectSceneMainMenu != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.connectSceneMainMenu.battlePassHolder, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏() != false)
        {
                if(this.connectSceneMainMenu != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.connectSceneMainMenu.pixelPassHolder, 丏业丟一东丂东丘丛:  true);
        }
        
            this.不丝下丗业丘丝下丄();
        }
        else
        {
                if(this.connectSceneMainMenu != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.connectSceneMainMenu.battlePassHolder, 丏业丟一东丂东丘丛:  true);
        }
        
            this.丞丕丅业东丒丐丝万();
        }
        
        if((this.东丆且丏丕七丟丌业 != false) && (this.丟上丐三丌丗丏丕三 != 1))
        {
                this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  false, 世丆丏七且业下丅专:  true, 业三丆丙丗丑丏丆不:  true, 一丅丆丂七与丆丈丂:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtn, 丏业丟一东丂东丘丛:  (~PGCompany.TransitionController.丑七不且上丗丁一世().丟丁与与丘东丈世不()) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel.backBtnSecond, 丏业丟一东丂东丘丛:  PGCompany.TransitionController.丑七不且上丗丁一世().丟丁与与丘东丈世不());
        PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().不业不丘丌丑丒丐丐();
        val_67 = 1152921505175908352;
        val_100 = null;
        val_100 = null;
        val_101 = 0;
        if(ExpView.丄丘七三上丕世丞业 != 0)
        {
                val_102 = null;
            val_102 = null;
            val_101 = 0;
            if(ExpView.丄丘七三上丕世丞业.experienceCamera != 0)
        {
                val_103 = null;
            val_103 = null;
            val_101 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        if(this.丆丙丗下专万丗世丑 != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        }
        
        if(this.上丕东万与一专丂业() != 0)
        {
                return;
        }
        
        val_65 = this.connectSceneMainMenu.goBtn.GetComponent<UIButton>();
    }
    private void OnDisable()
    {
        var val_33;
        System.Action<System.String> val_34;
        var val_35;
        System.Action<System.Boolean> val_36;
        var val_37;
        System.Action val_38;
        var val_39;
        var val_40;
        System.Action val_41;
        var val_42;
        var val_43;
        System.Action val_44;
        var val_45;
        System.Action<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean> val_46;
        System.Action val_47;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        BankController val_2 = BankController.丑七不且上丗丁一世();
        if(val_2.uiRoot.gameObject.activeInHierarchy == true)
        {
                return;
        }
        
        ConnectScene.东丈业东丛丗七丘不(丙业与丙丗丝不丈东:  false);
        val_33 = null;
        val_33 = null;
        val_35 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄丐七不丂丑且上丛, value:  new System.Action<System.String>(object:  this, method:  public System.Void ConnectScene::OnJoinToMap(string 七丆丂丂下丈且丟世)))) != null) && (null != null))
        {
                val_35 = null;
            val_34 = 0;
        }
        
        GameConnect.丄丐七不丂丑且上丛 = val_34;
        val_37 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void ConnectScene::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_37 = null;
            val_36 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_36;
        val_39 = null;
        val_40 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void ConnectScene::丂丐与丞丗丒丘丑上()))) != null) && (null != val_40))
        {
                val_39 = null;
            val_40 = null;
            val_38 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_38;
        val_42 = null;
        val_43 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void ConnectScene::OnJoinedRoom()))) != null) && (null != val_43))
        {
                val_42 = null;
            val_43 = null;
            val_41 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_41;
        val_45 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丐丗丈下三与丝丙业, value:  new System.Action(object:  this, method:  System.Void ConnectScene::OnReceivedRoomListUpdate()))) != null) && (null != val_45))
        {
                val_45 = null;
            val_44 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_44;
        MapPopularityController.东丝丑专七丑丆丒上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::与丄东世东业丏下丘()));
        if(((System.Delegate.Remove(source:  PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且, value:  new System.Action<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒, System.Boolean>(object:  this, method:  System.Void ConnectScene::丟丌万一一丛丑下一(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 与不下三丈专丘丂世, bool 东丅丞丁丗万且丁丗)))) != null) && (null != null))
        {
                val_46 = 0;
        }
        
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒.丘丏且丂万丌丐一且 = val_46;
        if(this.丙不丅丝丙专丕世丐 != 0)
        {
                val_47 = System.Delegate.Remove(source:  this.丙不丅丝丙专丕世丐.丂一丑丛不专万丁上, value:  new System.Action(object:  this, method:  System.Void ConnectScene::丄上一丌专丞且丗世()));
            if((val_47 != null) && (null != null))
        {
                val_47 = 0;
        }
        
            this.丙不丅丝丙专丕世丐.丂一丑丛不专万丁上 = val_47;
        }
        
        Rilisoft.丐丌丝七下丈丒丅丗.丅丗丟丟丘丆专一东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::业丅东七且丅丛七丟()));
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_33 = 0;
            val_33 = val_33 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        this.与丘丏丆丁世世丁丗 = this.connectScenePanelEventHint.gameObject.activeSelf;
        if((this.connectScenePanelEventHint != 0) && (this.connectScenePanelEventHint.mapEventWindow != 0))
        {
                if(this.connectScenePanelEventHint.mapEventWindow.gameObject.activeSelf != true)
        {
                this.丏丐不三丘丌不丟不();
        }
        
        }
        
        PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.上丗丌丌上不丛丌专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::丛丌丆三丅下丂丑丐()));
        FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ConnectScene::丛丌丆三丅下丂丑丐()));
    }
    private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ConnectScene.丅丙丆丝下一世丌万(丗丏丅丕丆世丁专丟:  0);
    }
    private void Update()
    {
        bool val_2 = this.connectSceneMainMenu.gameObject.activeInHierarchy;
        if(this.allInterfacePanel.armoryButton != 0)
        {
                if(val_2 ^ this.allInterfacePanel.armoryButton.activeSelf != false)
        {
                this.allInterfacePanel.armoryButton.SetActive(value:  val_2);
        }
        
        }
        
        var val_9 = (this.丛丗与丗下丐三上一 == true) ? 1 : 0;
        val_9 = this.丙不丅丝丙专丕世丐.connectionPanel.gameObject.activeSelf ^ val_9;
        if(val_9 == false)
        {
                return;
        }
        
        this.丛丗与丗下丐三上一 = this.丙不丅丝丙专丕世丐.connectionPanel.gameObject.activeSelf;
        this.不丗丒专丅丙专丏专();
    }
    private bool 七丛丛丁丕丄丕丅东(int 丒三东丆丕专丞且一, bool 东一业丝丁专丄下东 = False, bool 且丈三且七上一丏丞 = False)
    {
        var val_3;
        var val_4;
        Rilisoft.七丕丟丏三丈一丄世 val_5;
        var val_6;
        val_3 = 且丈三且七上一丏丞;
        val_4 = null;
        val_4 = null;
        var val_1 = (val_3 != true) ? 16 : 8;
        if((东一业丝丁专丄下东 == true) || (val_3 == true))
        {
                return UnityEngine.Object.op_Inequality(x:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丐丝丟丙丛下专丐万:  val_5 = ConnectScene.丙东丁丂丝世丑丒丘, 丈东丅万丟丞丒不丒:  丒三东丆丕专丞且一), y:  0);
        }
        
        val_3 = 1152921505052479488;
        val_6 = null;
        val_6 = null;
        return UnityEngine.Object.op_Inequality(x:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丐丝丟丙丛下专丐万:  val_5, 丈东丅万丟丞丒不丒:  丒三东丆丕专丞且一), y:  0);
    }
    private System.Collections.IEnumerator 丌丞世丘万业丁世丐()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ConnectScene.丘丟丘一丈与丄丟丝(丗丏丅丕丆世丁专丟:  0);
    }
    internal static string 下丁丝业一丗丏丟丅()
    {
        var val_8;
        var val_9;
        var val_10;
        string val_6 = 0;
        val_8 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_8.丌丗丑业丁上丆万七() != false)
        {
                val_9 = "IsRunningTutor";
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        if(InfoWindowController.丈丐丞丐上丑且丕万() != false)
        {
                val_9 = "InfoWindowController";
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  "leave_from_duel_penalty")) != 0)
        {
                val_9 = "TrophiesPenaltyBannerWindow";
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        val_8 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
        if((val_8.丗一一丞一专丝且业(丏丞专丏业丗丝七丝: out  val_6)) != false)
        {
                val_10 = val_6;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }
    internal void 与丄东世东业丏下丘()
    {
        var val_11;
        if(this.connectSceneSelectMap.grid == 0)
        {
                return;
        }
        
        val_11 = 0;
        goto label_5;
        label_21:
        if((this.connectSceneSelectMap.grid.transform.GetChild(index:  0).gameObject.activeInHierarchy) != false)
        {
                if(val_8.mapID <= 3)
        {
                this.connectSceneSelectMap.grid.transform.GetChild(index:  0).GetComponent<MapPreviewController>().丅丂丙丁业丅丆且世();
        }
        
        }
        
        val_11 = 1;
        label_5:
        if(val_11 < this.connectSceneSelectMap.grid.transform.childCount)
        {
            goto label_21;
        }
    
    }
    private void 丟丌万一一丛丑下一(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 与不下三丈专丘丂世, bool 东丅丞丁丗万且丁丗)
    {
        var val_3;
        if(与不下三丈专丘丂世 == null)
        {
                return;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = 与不下三丈专丘丂世.丌不丅不丞东万专专();
        if(val_1.HasValue.丙东专丂世丈丏丁丂() != 4)
        {
                return;
        }
        
        if(((-284549384) & 1) == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(ConnectScene.丙东丁丂丝世丑丒丘 != 35)
        {
                return;
        }
        
        this.上丐丑丟丁上且七丗 = true;
    }
    public void UpdateMapEvents()
    {
        var val_42;
        var val_43;
        MapPreviewController val_44;
        var val_45;
        var val_46;
        MapPreviewController val_47;
        MapPreviewController val_48;
        var val_49;
        var val_50;
        val_42 = 1152921504848912384;
        if(this.connectSceneSelectMap.grid == 0)
        {
                return;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_7;
        }
        
        val_43 = 0;
        goto label_8;
        label_79:
        if((this.connectSceneSelectMap.grid.transform.GetChild(index:  0).gameObject.activeSelf) == false)
        {
            goto label_69;
        }
        
        UnityEngine.Transform val_8 = this.connectSceneSelectMap.grid.transform.GetChild(index:  0);
        int val_12 = val_8.GetInstanceID();
        if((this.丂丁七丙下丞丗丁业.TryGetValue(key:  val_12, value: out  this.connectSceneSelectMap.grid.transform.GetChild(index:  0).GetComponent<MapPreviewController>())) != true)
        {
                MapPreviewController val_15 = val_8.GetComponent<MapPreviewController>();
            this.丂丁七丙下丞丗丁业.Add(key:  val_12, value:  val_15);
        }
        
        if((((val_15 + 144) == 1) || ((val_15 + 144) == 2)) || ((val_15 + 408) == 0))
        {
            goto label_69;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_16 = val_15 + 408.丌不丅不丞东万专专();
        if(val_16.HasValue.丙东专丂世丈丏丁丂() == 3)
        {
                if(((-284291024) & 1) != 0)
        {
            goto label_69;
        }
        
        }
        
        System.Nullable<System.TimeSpan> val_18 = val_15 + 408.丙世丑丅丒丑业与不();
        if(( & 1) == 0)
        {
            goto label_99;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_19 = val_15 + 408.丌不丅不丞东万专专();
        int val_42 = val_19.HasValue.丙东专丂世丈丏丁丂();
        val_42 = ((val_42 == 1) ? 1 : 0) & 1152921525797392432;
        if(val_15 == 0)
        {
            goto label_42;
        }
        
        if(val_42 == 0)
        {
            goto label_43;
        }
        
        label_56:
        System.Nullable<System.TimeSpan> val_22 = val_15 + 408.丙世丑丅丒丑业与不();
        val_15 + 192.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        if((val_15 + 408.且丆不丈丞专下世丐()) == false)
        {
            goto label_59;
        }
        
        val_44 = val_15;
        if(val_15 != 0)
        {
            goto label_52;
        }
        
        val_44 = val_15;
        if(val_44 == 0)
        {
            goto label_71;
        }
        
        label_52:
        val_45 = mem[val_15 + 408];
        val_45 = val_15 + 408;
        val_46 = mem[val_15 + 208];
        val_46 = val_15 + 208;
        if(val_45 != 0)
        {
            goto label_62;
        }
        
        goto label_55;
        label_42:
        if(val_42 != 0)
        {
            goto label_56;
        }
        
        label_43:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_25 = val_15 + 408.丌不丅不丞东万专专();
        if((val_25.HasValue.丙东专丂世丈丏丁丂() != 2) || (((-284291024) & 1) == 0))
        {
            goto label_59;
        }
        
        val_47 = val_15;
        if(val_15 != 0)
        {
            goto label_60;
        }
        
        val_47 = val_15;
        if(val_47 == 0)
        {
            goto label_71;
        }
        
        label_60:
        val_45 = mem[val_15 + 408];
        val_45 = val_15 + 408;
        val_46 = mem[val_15 + 232];
        val_46 = val_15 + 232;
        if(val_45 != 0)
        {
            goto label_62;
        }
        
        label_55:
        label_62:
        System.Nullable<System.TimeSpan> val_27 = val_45.丙世丑丅丒丑业与不();
        val_46.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        label_59:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_29 = val_15 + 408.丌不丅不丞东万专专();
        if((val_29.HasValue.丙东专丂世丈丏丁丂() != 4) || (((-284291024) & 1) == 0))
        {
            goto label_69;
        }
        
        val_48 = val_15;
        if(val_15 != 0)
        {
            goto label_70;
        }
        
        val_48 = val_15;
        if(val_48 == 0)
        {
            goto label_71;
        }
        
        label_70:
        System.Nullable<System.TimeSpan> val_31 = val_15 + 408.丙世丑丅丒丑业与不();
        val_15 + 472.SetText(丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        label_69:
        val_43 = 1;
        label_8:
        if(val_43 < this.connectSceneSelectMap.grid.transform.childCount)
        {
            goto label_79;
        }
        
        val_49 = 0;
        label_99:
        val_42 = 1152921504848912384;
        goto label_80;
        label_7:
        val_49 = 0;
        label_80:
        val_50 = null;
        val_50 = null;
        if(ConnectScene.丙东丁丂丝世丑丒丘 == 35)
        {
                var val_38 = ((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 2) ? 1 : 0;
            val_38 = ((this.万丌丗七丑丄下丞与 == true) ? 1 : 0) ^ val_38;
            val_49 = val_49 | val_38;
        }
        
        if(this.上丐丑丟丁上且七丗 == false)
        {
            goto label_85;
        }
        
        this.上丐丑丟丁上且七丗 = false;
        goto label_86;
        label_85:
        if(val_49 == 0)
        {
            goto label_87;
        }
        
        label_86:
        if(this.丆丙丗下专万丗世丑 != true)
        {
                this.丏丐不三丘丌不丟不();
        }
        
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  false, 世丆丏七且业下丅专:  true, 业三丆丙丗丑丏丆不:  true, 一丅丆丂七与丆丈丂:  false);
        this.丆丑与下业丆专且丄();
        label_87:
        if(this.connectScenePanelEventHint.gameObject.activeSelf == false)
        {
                return;
        }
        
        if(this.connectSceneSelectMap.selectMap != 0)
        {
                if(this.connectSceneSelectMap.selectMap.丐且丘丑与万丞丑丅 != null)
        {
                return;
        }
        
        }
        
        this.丏丐不三丘丌不丟不();
        return;
        label_71:
    }
    public void AddWatchedCompetitionFiltermap(FilterMaps 与丕丁三万专世不丅)
    {
        if((this.IsFiltermapWatchedInCompetition(与丕丁三万专世不丅:  与丕丁三万专世不丅)) != false)
        {
                return;
        }
        
        this.watchedCompetitionFiltermaps.Add(item:  与丕丁三万专世不丅);
    }
    public bool IsFiltermapWatchedInCompetition(FilterMaps 与丕丁三万专世不丅)
    {
        var val_3;
        List.Enumerator<T> val_1 = this.watchedCompetitionFiltermaps.GetEnumerator();
        label_3:
        if(((-283898024) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丙东专丂世丈丏丁丂() != 与丕丁三万专世不丅)
        {
            goto label_3;
        }
        
        val_3 = 1;
        goto label_4;
        label_2:
        val_3 = 0;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    internal void 专且丏东业丄下一丟()
    {
        var val_4;
        Rilisoft.七丕丟丏三丈一丄世 val_5;
        val_4 = null;
        val_4 = null;
        val_5 = ConnectScene.丙东丁丂丝世丑丒丘;
        if(val_5 != 35)
        {
                val_5 = ConnectScene.丙东丁丂丝世丑丒丘;
            GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  val_5);
            this.丏丐不三丘丌不丟不();
        }
        
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  false, 世丆丏七且业下丅专:  true, 业三丆丙丗丑丏丆不:  true, 一丅丆丂七与丆丈丂:  false);
        this.丆丑与下业丆专且丄();
        if(this.丆丙丗下专万丗世丑 != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return;
        }
        
        }
        
        if(this.上丕东万与一专丂业() != 0)
        {
                return;
        }
        
        if((this.connectSceneMainMenu.goBtn.GetComponent<UIButton>()) == null)
        {
            
        }
    
    }
    private void 丛丌丆三丅下丂丑丐()
    {
        this.丆丑与下业丆专且丄();
    }
    internal void 丆丑与下业丆专且丄()
    {
        goto label_0;
        label_7:
        this.connectSceneMainMenu.modeButtonByLevel[0].业丘丒世业丈下万业();
        0 = 1;
        label_0:
        if(0 < this.connectSceneMainMenu.modeButtonByLevel.Length)
        {
            goto label_7;
        }
    
    }
    private void 业丂下不丌与东丐业()
    {
        if(this.connectSceneMainMenu.gameEventInfoObject == 0)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 24)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 35)
        {
            goto label_10;
        }
        
        }
        
        label_21:
        this.connectSceneMainMenu.gameEventInfoObject.SetActive(value:  false);
        return;
        label_10:
        Rilisoft.丛且世丐丆上七业丁 val_5 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if((((val_5 != 0) ? 1 : 0) ^ this.connectSceneMainMenu.gameEventInfoObject.activeSelf) == false)
        {
                return;
        }
        
        var val_9 = (val_5 != 0) ? 1 : 0;
        goto label_21;
    }
    private void 且上不丘丘丏且丌丙(Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, int 丌丝万上丅丒一丈丘, SceneInfo 丄不东丁丂丅万丒丟, bool 丗丂世丗丄不丟丘万, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        UnityEngine.GameObject val_3 = this.connectSceneSelectMap.grid.transform.GetChild(index:  丌丝万上丅丒一丈丘).gameObject;
        if(val_3.activeSelf != true)
        {
                val_3.SetActive(value:  true);
        }
        
        val_3.GetComponent<MapPreviewController>().上东与丛丞下丈专丈(业丞丟万不丄丂丘丑:  业丞丟万不丄丂丘丑, 丄不东丁丂丅万丒丟:  丄不东丁丂丅万丒丟, 丗丂世丗丄不丟丘万:  丗丂世丗丄不丟丘万, 专且丆东且丁丂丝上:  丐且丘丑与万丞丑丅, 丈三丆丏丄三丏丛丒:  false);
    }
    private void 上丅丑七丅一三世丐(Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, int 丌丝万上丅丒一丈丘, SceneInfo 丄不东丁丂丅万丒丟)
    {
        UnityEngine.GameObject val_3 = this.connectSceneSelectMap.grid.transform.GetChild(index:  丌丝万上丅丒一丈丘).gameObject;
        if(val_3.activeSelf != true)
        {
                val_3.SetActive(value:  true);
        }
        
        val_3.GetComponent<MapPreviewController>().世丕且丞丙业丕一丅(业丞丟万不丄丂丘丑:  业丞丟万不丄丂丘丑, 丄不东丁丂丅万丒丟:  丄不东丁丂丅万丒丟);
    }
    private void 世丁不丝业与丄三一(int 丌丝万上丅丒一丈丘, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        UnityEngine.GameObject val_3 = this.connectSceneSelectMap.grid.transform.GetChild(index:  丌丝万上丅丒一丈丘).gameObject;
        if(val_3.activeSelf != true)
        {
                val_3.SetActive(value:  true);
        }
        
        val_3.GetComponent<MapPreviewController>().世丆丕一丟丂丁丆东(丂丛丑东不丅丈一东:  丂丛丑东不丅丈一东);
    }
    private void 丁丞专丆不不丟东东(int 丌丝万上丅丒一丈丘, SceneInfo 丄不东丁丂丅万丒丟)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        UnityEngine.GameObject val_3 = this.connectSceneSelectMap.voteGrid.transform.GetChild(index:  丌丝万上丅丒一丈丘).gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
        MapVoteItem val_4 = val_3.GetComponent<MapVoteItem>();
        if(val_4 != null)
        {
                val_4.curSceneInfo = 丄不东丁丂丅万丒丟;
        }
        else
        {
                mem[24] = 丄不东丁丂丅万丒丟;
        }
        
        UnityEngine.Texture val_6 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  丄不东丁丂丅万丒丟.丙且上丒不下丑下丞());
        val_10 = null;
        val_10 = null;
        val_11 = null;
        val_11 = null;
        if((MapVoteController.丛丆丂丐丛不不丟万.下丘丙丌万上与丏七(丂丛丑东不丅丈一东:  ConnectScene.丙东丁丂丝世丑丒丘, 下丞七丒业丂丈丘下:  丄不东丁丂丅万丒丟.indexMap)) != false)
        {
                val_4.SetLiked(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_4.SetLiked(丙业与丙丗丝不丈东:  false);
            val_12 = null;
            val_12 = null;
            val_13 = null;
            val_13 = null;
            if((MapVoteController.丛丆丂丐丛不不丟万.丙七万丅万丞下一丕(丂丛丑东不丅丈一东:  ConnectScene.丙东丁丂丝世丑丒丘)) <= 0)
        {
                val_4.SetShowVotes();
        }
        
        }
        
        val_4.SetMapPreviewTitle();
        val_14 = null;
        val_14 = null;
        val_15 = null;
        val_15 = null;
        val_4.丙丂不丘丗丙且专三(丙业与丙丗丝不丈东:  MapVoteController.丛丆丂丐丛不不丟万.七丛与丅丞丝丁丐专(丂丛丑东不丅丈一东:  ConnectScene.丙东丁丂丝世丑丒丘, 不万丈丟上丙丟万世:  丄不东丁丂丅万丒丟.indexMap));
    }
    private void 丞丑丐丐丁丑业丕丞()
    {
        if(this.connectSceneSelectMap.votePanelWidget.gameObject.activeSelf == false)
        {
                return;
        }
        
        if(this.gameObject.activeSelf != false)
        {
                this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  false, 世丆丏七且业下丅专:  true, 业三丆丙丗丑丏丆不:  true, 一丅丆丂七与丆丈丂:  false);
            return;
        }
        
        if(this.丟上丐三丌丗丏丕三 == 1)
        {
                return;
        }
        
        this.东丆且丏丕七丟丌业 = true;
    }
    internal void 三万丛上丞丐业丕世()
    {
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  true, 世丆丏七且业下丅专:  true, 业三丆丙丗丑丏丆不:  true, 一丅丆丂七与丆丈丂:  false);
    }
    private void 丗丘专三丒丙丑世丗(bool 丈三丑丛丅丑丁丁丙 = True, bool 丕丈丌丐下丅三七丌 = False, bool 世丆丏七且业下丅专 = True, bool 业三丆丙丗丑丏丆不 = True, bool 一丅丆丂七与丆丈丂 = False)
    {
        float val_396;
        TSource val_397;
        object val_399;
        var val_400;
        float val_401;
        ConnectSceneSelectMap val_403;
        ConnectScene val_404;
        var val_405;
        System.Collections.Generic.List<T> val_406;
        var val_407;
        var val_408;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_409;
        var val_410;
        var val_411;
        var val_412;
        var val_413;
        var val_414;
        var val_415;
        var val_416;
        System.Collections.Generic.IEnumerable<TSource> val_418;
        var val_419;
        var val_420;
        System.Func<业丂丌丞丆东丏世万, System.Int32> val_422;
        int val_423;
        var val_424;
        Rilisoft.七丕丟丏三丈一丄世 val_425;
        var val_426;
        int val_427;
        var val_428;
        var val_429;
        Rilisoft.七丕丟丏三丈一丄世[] val_430;
        var val_431;
        ConnectScene.丌丝丒不丝丄丟一丐 val_432;
        SceneInfo val_433;
        var val_434;
        var val_435;
        int val_436;
        Rilisoft.七丕丟丏三丈一丄世 val_437;
        var val_438;
        ConnectScene val_439;
        var val_440;
        int val_441;
        float val_443;
        float val_444;
        var val_445;
        UnityEngine.GameObject val_446;
        var val_447;
        System.Action<Rilisoft.NeedSquadLevelConnectScene> val_449;
        var val_450;
        SceneInfo val_451;
        var val_452;
        var val_453;
        Rilisoft.七丕丟丏三丈一丄世 val_454;
        var val_455;
        int val_456;
        bool val_1 = 世丆丏七且业下丅专;
        val_396 = 0;
        ConnectScene.丌丝丒不丝丄丟一丐 val_2 = new ConnectScene.丌丝丒不丝丄丟一丐();
        if(丕丈丌丐下丅三七丌 != false)
        {
                UIPanel val_3 = this.connectSceneSelectMap.scrollViewSelectMapTransform.GetComponent<UIPanel>();
            val_396 = 0.001f;
        }
        
        this.丌业业丛丞业七丘万 = true;
        SpringPanel val_4 = this.丈丌下三专丆业与丕();
        if(val_4 != 0)
        {
                UnityEngine.Object.Destroy(obj:  val_4);
        }
        
        UIScrollView val_6 = this.丒丂丐丝丒丛丁丒丈();
        val_6.ResetPosition();
        if((0 != 0) && (丕丈丌丐下丅三七丌 != true))
        {
                this.丕丛丟丅丂东业丆丆();
        }
        
        Rilisoft.七丕丟丏三丈一丄世[] val_11 = new Rilisoft.七丕丟丏三丈一丄世[0];
        val_11[0] = 38;
        if(val_10.Length >= 1)
        {
                do
        {
            val_397 = System.Linq.Enumerable.ToArray<Rilisoft.七丕丟丏三丈一丄世>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(source:  GameConnect.丘丗世专不丅与丗丒, keySelector:  new System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(object:  Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世(), method:  System.Int32 Rilisoft.一世东上七三丌丅不::丒与丆三丟三丈丄丄(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌))))[0];
            if(val_397 != 38)
        {
                if(0 >= val_10.Length)
        {
                val_397 = mem[val_10[0x0] + 32];
            val_397 = val_10[0x0] + 32;
        }
        
            val_11[4] = val_397;
        }
        
        }
        while(1 < val_10.Length);
        
        }
        
        mem[1152921525800818000] = GameConnect.丑丌丛丈丅丅与不业();
        if(GameConnect.丂丏且丄丆丏与丄上() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_34;
        }
        
        }
        
        mem[1152921525800818000] = 4;
        System.Collections.Generic.List<SceneInfo> val_15 = new System.Collections.Generic.List<SceneInfo>();
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
            goto label_47;
        }
        
        AllScenesForMode val_17 = SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  5);
        if((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  17)) == null)
        {
            goto label_47;
        }
        
        goto label_46;
        label_34:
        label_47:
        label_46:
        if((GameConnect.丌不丅丆丏三丅丙上() != false) && (业三丆丙丗丑丏丆不 != false))
        {
                mem[1152921525800818000] = 16;
            if((SceneInfoController.丄丘七三上丕世丞业 != 0) && ((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  8)) != null))
        {
            
        }
        else
        {
                System.Collections.Generic.List<SceneInfo> val_22 = new System.Collections.Generic.List<SceneInfo>();
        }
        
        }
        
        val_399 = 1152921504848912384;
        if((GameConnect.丑丌丛丈丅丅与不业() != 8) || (业三丆丙丗丑丏丆不 == true))
        {
            goto label_66;
        }
        
        val_400 = 1152921505254395904;
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
            goto label_112;
        }
        
        if(SceneInfoController.丄丘七三上丕世丞业 != null)
        {
            goto label_75;
        }
        
        goto label_75;
        label_66:
        if((GameConnect.丑丌丛丈丅丅与不业() != 16) || (业三丆丙丗丑丏丆不 == true))
        {
            goto label_79;
        }
        
        val_400 = 1152921505254395904;
        goto label_84;
        label_79:
        val_400 = 1152921505254395904;
        if((GameConnect.丌不丅丆丏三丅丙上() == false) || (业三丆丙丗丑丏丆不 == false))
        {
            goto label_88;
        }
        
        label_84:
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
            goto label_112;
        }
        
        label_75:
        label_118:
        if((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  16)) == null)
        {
            goto label_112;
        }
        
        if((与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == true) || (ExperienceController.丞丞丘业东丙丏七丌() >= 2))
        {
            goto label_107;
        }
        
        System.Collections.Generic.List<TSource> val_32 = System.Linq.Enumerable.ToList<SceneInfo>(source:  丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<SceneInfo>(丅东丗丒丄东丛业丄:  val_28 + 16, 丂丆且一丛丙丑七丒:  0));
        goto label_107;
        label_88:
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
            goto label_112;
        }
        
        if(SceneInfoController.丄丘七三上丕世丞业 != null)
        {
            goto label_118;
        }
        
        goto label_118;
        label_112:
        if((ConnectScene.丙东丁丂丝世丑丒丘 != 24) && (ConnectScene.丙东丁丂丝世丑丒丘 != 34))
        {
                if(ConnectScene.丙东丁丂丝世丑丒丘 != 35)
        {
            goto label_127;
        }
        
        }
        
        System.Collections.Generic.List<SceneInfo> val_34 = new System.Collections.Generic.List<SceneInfo>();
        label_107:
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_41 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  mem[1152921525800818000], 丞丁丑丏丄丏七丂不:  0);
        if((1 & 1) == 0)
        {
            goto label_133;
        }
        
        且丛丈丒万与丁丟丟 val_43 = Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁();
        this.万丌丗七丑丄下丞与 = (val_43 == 2) ? 1 : 0;
        if(val_43 == 2)
        {
            goto label_137;
        }
        
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_46 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().下专丆丁丕丗东不丗(丞丁丑丏丄丏七丂不:  0);
        goto label_137;
        label_133:
        label_137:
        System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_47 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
        if(val_41 == null)
        {
            goto label_202;
        }
        
        goto label_158;
        label_171:
        if((val_41 == null) || ((System.String.IsNullOrEmpty(value:  val_41.丕丆丞丂业东与上丅())) == true))
        {
            goto label_158;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_52 = val_41.丌不丅不丞东万专专();
        if(((-280909624) & 1) == 0)
        {
            goto label_158;
        }
        
        int val_393 = (((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) != true) ? (1 + 1) : 1) + SceneInfoController.丄丘七三上丕世丞业.丕三与丌丂业丄世上();
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_41.丕丆丞丂业东与上丅())) == 0)
        {
            goto label_158;
        }
        
        if((1 & 1) == 0)
        {
            goto label_159;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_56 = val_41.丌不丅不丞东万专专();
        var val_58 = (val_56.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0;
        val_58 = val_58 & 1152921525800773832;
        if((val_58 & 1) == 0)
        {
            goto label_164;
        }
        
        val_47.Add(item:  val_41);
        goto label_164;
        label_159:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_59 = val_41.丌不丅不丞东万专专();
        var val_61 = (val_59.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0;
        val_61 = val_61 & 1152921525800773832;
        if((val_61 & 1) == 0)
        {
                val_47.Add(item:  val_41);
        }
        
        label_164:
        val_393 = val_393 + 1;
        label_158:
        if((val_41 & 1) != 0)
        {
            goto label_171;
        }
        
        if(val_41 != null)
        {
            goto label_172;
        }
        
        goto label_195;
        label_127:
        UnityEngine.Debug.LogError(message:  "modeInfo == null");
        return;
        label_172:
        label_195:
        if((0 != 1) && (988 == 988))
        {
            
        }
        
        label_202:
        System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_64 = new System.Collections.Generic.List<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>();
        if(GameConnect.丂丏且丄丆丏与丄上() != true)
        {
                if(GameConnect.丌不丅丆丏三丅丙上() == false)
        {
            goto label_266;
        }
        
        }
        
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_70 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  (GameConnect.丌不丅丆丏三丅丙上() != true) ? 8 : 5, 丞丁丑丏丄丏七丂不:  0);
        if(val_70 == null)
        {
            goto label_266;
        }
        
        goto label_235;
        label_242:
        if(val_70 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_73 = val_70.丌不丅不丞东万专专();
            if(((((-280909624) & 1) != 0) && ((System.String.IsNullOrEmpty(value:  val_70.丕丆丞丂业东与上丅())) != true)) && ((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_70.丕丆丞丂业东与上丅())) != 0))
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_79 = val_70.丌不丅不丞东万专专();
            var val_81 = (val_79.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0;
            val_81 = val_81 & 1152921525800773832;
            var val_394 = ???;
            if((val_81 & 1) == 0)
        {
                val_64.Add(item:  val_70);
            val_394 = val_394 + 1;
        }
        
        }
        
        }
        
        label_235:
        if((val_70 & 1) != 0)
        {
            goto label_242;
        }
        
        if(val_70 == null)
        {
            
        }
        
        if((0 != 1) && (988 == 1195))
        {
            
        }
        
        label_266:
        bool val_395 = 业三丆丙丗丑丏丆不;
        val_395 = 0 & val_395;
        if(val_395 == true)
        {
                int val_88 = (System.Linq.Enumerable.ToList<SceneInfo>(source:  System.Linq.Enumerable.OrderBy<SceneInfo, System.Int32>(source:  135970152, keySelector:  new System.Func<SceneInfo, System.Int32>(object:  val_399, method:  System.Int32 ConnectScene.丌丝丒不丝丄丟一丐::东丘下一与丏丒丗丐(SceneInfo 东一丁世丑丞业丄丐)))).Count) + W27;
        }
        
        var val_90 = (ConnectScene.丙东丁丂丝世丑丒丘 == 34) ? 0 : (W27 + val_11.Length);
        if(this.connectSceneSelectMap.grid.transform.childCount >= val_90)
        {
            goto label_281;
        }
        
        float val_396 = (float)UnityEngine.Screen.width;
        val_396 = val_396 / (float)UnityEngine.Screen.height;
        val_401 = 1.5f;
        if(val_396 < 0)
        {
            
        }
        else
        {
                val_401 = 1.8;
            float val_397 = (float)UnityEngine.Screen.width;
            val_397 = val_397 / (float)UnityEngine.Screen.height;
            if((double)val_397 < 0)
        {
            
        }
        
        }
        
        UnityEngine.Vector2 val_97 = this.connectSceneSelectMap.fonMapPreview.localSize;
        float val_398 = val_97.x;
        float val_98 = 5f * (-15f);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.mapPreviewTexture, 丏业丟一东丂东丘丛:  true);
        val_398 = val_398 + val_98;
        val_398 = val_398 + (-15f);
        val_98 = val_398 / 5f;
        int val_401 = this.connectSceneSelectMap.grid.transform.childCount;
        goto label_294;
        label_313:
        UnityEngine.GameObject val_101 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  1152921525549507984);
        val_403 = this.connectSceneSelectMap;
        val_101.transform.SetParent(parent:  this.connectSceneSelectMap.grid.transform, worldPositionStays:  false);
        val_404 = val_101.GetComponent<MapPreviewController>();
        UnityEngine.Vector2 val_105 = val_104.mapPreviewTexture.localSize;
        float val_399 = val_105.x;
        UnityEngine.Vector2 val_106 = val_104.mapPreviewTexture.localSize;
        float val_400 = val_106.y;
        val_399 = val_98 / val_399;
        val_401 = 0f;
        val_101.transform.GetChild(index:  0).localScale = new UnityEngine.Vector3() {x = 0f, y = val_401, z = 0f};
        string val_109 = "Map_" + val_401;
        val_101.name = val_109;
        int val_110 = val_401 / 5;
        val_110 = val_401 - (val_110 * 5);
        if(val_110 < 1)
        {
            goto label_309;
        }
        
        var val_112 = (val_110 == 4) ? (1 + 1) : 1;
        if(((val_110 > 0) ? (val_404) : 0) != 0)
        {
            goto label_310;
        }
        
        goto label_570;
        label_309:
        label_310:
        val_104.业上与丏上丑丘上下 = 0;
        val_400 = val_399 * val_400;
        val_401 = val_401 + 1;
        label_294:
        if(val_401 < val_90)
        {
            goto label_313;
        }
        
        this.connectSceneSelectMap.mapPreviewTexture.SetActive(value:  false);
        if((this.connectSceneSelectMap.grid.GetComponent<UIGrid>()) != null)
        {
                val_401 = val_98 + 15f;
            val_396 = val_400 + 15f;
            val_113.cellWidth = val_401;
            val_113.cellHeight = val_396;
            val_113.maxPerLine = 5;
        }
        else
        {
                mem[40] = val_98 + 15f;
            val_396 = val_400 + 15f;
            val_113.cellHeight = val_396;
            val_113.maxPerLine = 5;
        }
        
        mem[1152921525800786560] = val_400;
        label_281:
        mem[1152921525800786584].Clear();
        if(业三丆丙丗丑丏丆不 == false)
        {
            goto label_329;
        }
        
        System.Collections.Generic.List<SceneInfo> val_115 = MapVoteController.丛丆丂丐丛不不丟万.丄丙丕与三丅丅丈丝(丂丛丑东不丅丈一东:  ConnectScene.丙东丁丂丝世丑丒丘);
        if(MapVoteController.丛丆丂丐丛不不丟万.丂一丒万丈不丒一万() == false)
        {
            goto label_329;
        }
        
        goto label_330;
        label_341:
        if((val_115 == null) || (val_115.Count < 1))
        {
            goto label_332;
        }
        
        label_337:
        SceneInfo val_118 = val_115.Item[0];
        SceneInfo val_119 = 28563616.Item[0];
        if(val_118.indexMap == val_119.indexMap)
        {
            goto label_336;
        }
        
        if(1 < val_115.Count)
        {
            goto label_337;
        }
        
        label_332:
        mem[1152921525800786584].Add(item:  28563616.Item[0]);
        label_336:
        label_330:
        if(1 < 28563616.Count)
        {
            goto label_341;
        }
        
        label_329:
        val_406 = val_64;
        int val_124 = UnityEngine.Mathf.Max(a:  18, b:  mem[1152921525800786584].Count);
        if(this.connectSceneSelectMap.voteGrid.transform.childCount >= val_124)
        {
            goto label_348;
        }
        
        float val_402 = (float)UnityEngine.Screen.width;
        val_402 = val_402 / (float)UnityEngine.Screen.height;
        val_401 = 1.5f;
        if(val_402 < 0)
        {
            
        }
        else
        {
                val_401 = 1.8;
            float val_403 = (float)UnityEngine.Screen.width;
            val_403 = val_403 / (float)UnityEngine.Screen.height;
            if((double)val_403 < 0)
        {
            
        }
        
        }
        
        UnityEngine.Vector2 val_131 = this.connectSceneSelectMap.fonMapPreview.localSize;
        float val_404 = val_131.x;
        float val_132 = 5f * (-15f);
        this.connectSceneSelectMap.mapVoteObject.SetActive(value:  true);
        val_404 = val_404 + val_132;
        val_404 = val_404 + (-15f);
        UnityEngine.Transform val_133 = this.connectSceneSelectMap.voteGrid.transform;
        val_132 = val_404 / 5f;
        int val_407 = val_133.childCount;
        goto label_360;
        label_376:
        UnityEngine.GameObject val_135 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_133);
        val_135.transform.SetParent(parent:  this.connectSceneSelectMap.voteGrid.transform, worldPositionStays:  false);
        MapVoteItem val_138 = val_135.GetComponent<MapVoteItem>();
        UnityEngine.Vector2 val_139 = val_138.mapPreviewTexture.localSize;
        float val_405 = val_139.x;
        UnityEngine.Vector2 val_140 = val_138.mapPreviewTexture.localSize;
        float val_406 = val_140.y;
        val_405 = val_132 / val_405;
        val_401 = 0f;
        val_135.transform.GetChild(index:  0).localScale = new UnityEngine.Vector3() {x = 0f, y = val_401, z = 0f};
        val_406 = val_405 * val_406;
        val_135.name = "Map_" + val_407;
        val_407 = val_407 + 1;
        label_360:
        if(val_407 < val_124)
        {
            goto label_376;
        }
        
        this.connectSceneSelectMap.mapVoteObject.SetActive(value:  false);
        val_406 = val_64;
        this.connectSceneSelectMap.voteGrid.cellWidth = val_132 + 15f;
        val_396 = val_406 + 15f;
        this.connectSceneSelectMap.voteGrid.cellHeight = val_396;
        this.connectSceneSelectMap.voteGrid.maxPerLine = 5;
        mem[1152921525800786560] = val_406;
        label_348:
        mem[1152921525800786568].Clear();
        mem[1152921525800786576].Clear();
        if(0 != 0)
        {
                if(0.Count >= 1)
        {
                System.Collections.Generic.List<TSource> val_148 = System.Linq.Enumerable.ToList<SceneInfo>(source:  System.Linq.Enumerable.OrderBy<SceneInfo, System.Int32>(source:  val_397, keySelector:  new System.Func<SceneInfo, System.Int32>(object:  val_2, method:  System.Int32 ConnectScene.丌丝丒不丝丄丟一丐::丘丅业丄丏与且丒丆(SceneInfo 东一丁世丑丞业丄丐))));
        }
        
        }
        
        val_405 = 1152921525800057472;
        goto label_421;
        label_427:
        if((丕丈丌丐下丅三七丌 == false) || (丕丈丌丐下丅三七丌.Count < 1))
        {
            goto label_392;
        }
        
        label_409:
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_150 = 丕丈丌丐下丅三七丌.Item[0];
        if(val_150.丁东丒七与丄业丟丕() == true)
        {
            goto label_394;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_152 = val_150.丌不丅不丞东万专专();
        if((val_152.HasValue.丙东专丂世丈丏丁丂() != 3) || (((-280909624) & 1) == 0))
        {
            goto label_404;
        }
        
        label_394:
        SceneInfo val_155 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_150.丕丆丞丂业东与上丅());
        if(val_155 != 0)
        {
                if(val_155 == val_148.Item[0])
        {
            goto label_408;
        }
        
        }
        
        label_404:
        if(1 < 丕丈丌丐下丅三七丌.Count)
        {
            goto label_409;
        }
        
        label_392:
        label_425:
        if((1 & 1) == 0)
        {
            goto label_410;
        }
        
        var val_160 = (0 != 0) ? 1 : 0;
        val_160 = val_160 & 业三丆丙丗丑丏丆不;
        val_160 = 0 & val_160;
        if(val_160 == true)
        {
            goto label_411;
        }
        
        goto label_418;
        label_410:
        if((0 & 1) != 0)
        {
            goto label_418;
        }
        
        if((0 & 1) == 0)
        {
                MoonSharp.Interpreter.TablePair val_162 = new MoonSharp.Interpreter.TablePair(key:  val_148.Item[0], val:  0);
            mem[1152921525800786568].Add(item:  new 业丂丌丞丆东丏世万() {丏丈丗世丙万丆丐丅 = val_162.key, 丐且丘丑与万丞丑丅 = val_162.value});
        }
        
        if((0 == 0) || (业三丆丙丗丑丏丆不 == false))
        {
            goto label_418;
        }
        
        label_411:
        MoonSharp.Interpreter.TablePair val_164 = new MoonSharp.Interpreter.TablePair(key:  val_148.Item[0], val:  0);
        mem[1152921525800786568].Add(item:  new 业丂丌丞丆东丏世万() {丏丈丗世丙万丆丐丅 = val_164.key, 丐且丘丑与万丞丑丅 = val_164.value});
        label_418:
        val_406 = val_64;
        goto label_421;
        label_408:
        if(val_150 != null)
        {
                bool val_165 = val_150.丁东丒七与丄业丟丕();
        }
        else
        {
                bool val_166 = val_150.丁东丒七与丄业丟丕();
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_167 = val_150.丌不丅不丞东万专专();
        var val_170 = ((val_167.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0) & 1152921525800773832;
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_171 = val_150.丌不丅不丞东万专专();
        var val_174 = (((val_171.HasValue.丙东专丂世丈丏丁丂() == 3) ? 1 : 0) != (-280909624)) ? (val_150) : 0;
        goto label_425;
        label_421:
        val_404 = this;
        if(0 < val_148.Count)
        {
            goto label_427;
        }
        
        if((val_22 == 0) || (val_22.Count < 1))
        {
            goto label_429;
        }
        
        goto label_462;
        label_451:
        if(val_148 != null)
        {
                bool val_177 = val_148.丁东丒七与丄业丟丕();
        }
        else
        {
                bool val_178 = val_148.丁东丒七与丄业丟丕();
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_179 = val_148.丌不丅不丞东万专专();
        var val_182 = ((val_179.HasValue.丙东专丂世丈丏丁丂() == 4) ? 1 : 0) & 1152921525800773832;
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_183 = val_148.丌不丅不丞东万专专();
        var val_186 = (((val_183.HasValue.丙东专丂世丈丏丁丂() == 3) ? 1 : 0) != (-280909624)) ? (val_148) : 0;
        goto label_434;
        label_462:
        if(val_406 == 0)
        {
            goto label_435;
        }
        
        if(val_64.Count < 1)
        {
            goto label_453;
        }
        
        label_452:
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_188 = val_64.Item[0];
        if(val_188.丁东丒七与丄业丟丕() == true)
        {
            goto label_438;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_190 = val_188.丌不丅不丞东万专专();
        if((val_190.HasValue.丙东专丂世丈丏丁丂() != 3) || (((-280909624) & 1) == 0))
        {
            goto label_448;
        }
        
        label_438:
        SceneInfo val_193 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_188.丕丆丞丂业东与上丅());
        if(val_193 != 0)
        {
                if(val_193 == val_22.Item[0])
        {
            goto label_451;
        }
        
        }
        
        label_448:
        if(1 < val_64.Count)
        {
            goto label_452;
        }
        
        goto label_453;
        label_435:
        label_453:
        label_434:
        if((1 & 1) == 0)
        {
            goto label_454;
        }
        
        var val_198 = (0 != 0) ? 1 : 0;
        val_198 = val_198 & val_406;
        if(val_198 == 1)
        {
            goto label_455;
        }
        
        goto label_460;
        label_454:
        if((val_406 & 1) != 0)
        {
            goto label_460;
        }
        
        if((0 & 1) == 0)
        {
                MoonSharp.Interpreter.TablePair val_200 = new MoonSharp.Interpreter.TablePair(key:  val_22.Item[0], val:  0);
            mem[1152921525800786576].Add(item:  new 业丂丌丞丆东丏世万() {丏丈丗世丙万丆丐丅 = val_200.key, 丐且丘丑与万丞丑丅 = val_200.value});
        }
        
        if(0 == 0)
        {
            goto label_460;
        }
        
        label_455:
        MoonSharp.Interpreter.TablePair val_202 = new MoonSharp.Interpreter.TablePair(key:  val_22.Item[0], val:  0);
        mem[1152921525800786576].Add(item:  new 业丂丌丞丆东丏世万() {丏丈丗世丙万丆丐丅 = val_202.key, 丐且丘丑与万丞丑丅 = val_202.value});
        label_460:
        val_406 = val_64;
        if(1 < val_22.Count)
        {
            goto label_462;
        }
        
        label_429:
        var val_204 = (0 == 0) ? 1 : 0;
        val_204 = 1 | val_204;
        if((val_204 & 1) == 0)
        {
            goto label_466;
        }
        
        goto label_464;
        label_470:
        MoonSharp.Interpreter.TablePair val_207 = new MoonSharp.Interpreter.TablePair(key:  0.Item[0], val:  0);
        mem[1152921525800786576].Add(item:  new 业丂丌丞丆东丏世万() {丏丈丗世丙万丆丐丅 = val_207.key, 丐且丘丑与万丞丑丅 = val_207.value});
        label_466:
        if(1 < 0.Count)
        {
            goto label_470;
        }
        
        val_406 = val_64;
        label_464:
        if(业三丆丙丗丑丏丆不 != false)
        {
                var val_210 = (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 1 : 0;
        }
        
        val_407 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.connectSceneSelectMap.FreePlayMapPanel, 丏业丟一东丂东丘丛:  false);
        if(0 != 0)
        {
                业丂丌丞丆东丏世万 val_211 = mem[1152921525800786568].Item[0];
            this.connectSceneSelectMap.FreePlayMapPanel.mapPreview.上东与丛丞下丈专丈(业丞丟万不丄丂丘丑:  GameConnect.丑丌丛丈丅丅与不业(), 丄不东丁丂丅万丒丟:  val_211.丏丈丗世丙万丆丐丅, 丗丂世丗丄不丟丘万:  false, 专且丆东且丁丂丝上:  0, 丈三丆丏丄三丏丛丒:  false);
            this.connectSceneSelectMap.FreePlayMapPanel.mapPreview.丐丝万丈丞业丙丐丆(七丆丂丂下丈且丟世:  val_211.丏丈丗世丙万丆丐丅.丙且上丒不下丑下丞());
            val_406 = val_64;
            this.connectSceneSelectMap.selectMap = this.connectSceneSelectMap.FreePlayMapPanel.mapPreview;
        }
        
        if(业三丆丙丗丑丏丆不 != false)
        {
                val_408 = null;
            val_408 = null;
            var val_214 = (ConnectScene.丙东丁丂丝世丑丒丘 == 34) ? 1 : 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.armRaceContainer, 丏业丟一东丂东丘丛:  false);
        if(0 == 0)
        {
            goto label_538;
        }
        
        val_409 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().一丝丈丈三一丒丒丅();
        if(val_409 == null)
        {
            goto label_500;
        }
        
        val_410 = null;
        val_411 = 1152921504848912384;
        goto label_504;
        label_500:
        val_412 = 0;
        goto label_503;
        label_504:
        System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_217 = val_409.业丄丄且丕丕不一万();
        SceneInfo val_219 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_409.丕丆丞丂业东与上丅());
        SceneInfo val_220 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丐丝丟丙丛下专丐万:  val_217.HasValue, 丈东丅万丟丞丒不丒:  val_219.indexMap);
        if(val_220 == 0)
        {
            goto label_513;
        }
        
        System.Nullable<System.DateTime> val_222 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((-280909648) & 1) == 0)
        {
            goto label_513;
        }
        
        if(val_409.七丂丌丈丄专丄三世() == false)
        {
            goto label_514;
        }
        
        System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_224 = val_409.业丄丄且丕丕不一万();
        GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  val_224.HasValue);
        val_407 = 1152921505284374528;
        this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.上东与丛丞下丈专丈(业丞丟万不丄丂丘丑:  GameConnect.丑丌丛丈丅丅与不业(), 丄不东丁丂丅万丒丟:  val_220, 丗丂世丗丄不丟丘万:  false, 专且丆东且丁丂丝上:  val_409, 丈三丆丏丄三丏丛丒:  false);
        this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.丐丝万丈丞业丙丐丆(七丆丂丂下丈且丟世:  val_409.丕丆丞丂业东与上丅());
        val_409 = 0;
        val_413 = 0;
        val_412 = 1;
        this.connectSceneSelectMap.selectMap = this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview;
        goto label_567;
        label_513:
        val_407 = 1152921505284374528;
        val_412 = 0;
        val_409 = 0;
        label_503:
        val_413 = 1;
        label_567:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.rotationGameModeContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.rotationGameModeNotAvalible, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.rotationGameModeNowNotAvalible.gameObject, 丏业丟一东丂东丘丛:  false);
        val_406 = val_64;
        if((val_409 | val_413) == 1)
        {
                UIButton val_229 = mem[1152921525800786048] + 24.GetComponent<UIButton>();
        }
        
        label_538:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.grid, 丏业丟一东丂东丘丛:  (0 == 0) ? 1 : 0);
        val_403 = 1152921504848912384;
        if(GameConnect.丑丌丛丈丅丅与不业() != 20)
        {
            goto label_580;
        }
        
        List.Enumerator<T> val_232 = mem[1152921525800786568].GetEnumerator();
        label_552:
        if(((-280909696) & 1) == 0)
        {
            goto label_549;
        }
        
        ConfiguredValueTaskAwaiter val_234 = val_207.key.GetAwaiter();
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 东下丌丝且七丛丘丒:  val_234._value._obj, 丁丏丗且上丗下与下:  false))) == true)
        {
            goto label_552;
        }
        
        val_414 = -280909888;
        val_415 = 4055;
        val_416 = 1;
        val_418 = 0;
        goto label_553;
        label_549:
        val_414 = -280909888;
        val_415 = 4055;
        val_416 = 1;
        val_418 = 1;
        label_553:
        val_406 = val_64;
        goto label_554;
        label_514:
        System.Nullable<System.DateTime> val_238 = val_409.东丗丝丙丈丒丛丐丛();
        System.Nullable<System.DateTime> val_239 = FriendsController.业丈丏丏丞丘丛丈丛();
        System.TimeSpan val_240 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime() {});
        this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.rotationGameModeTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  (int)val_240._ticks.TotalSeconds, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.rotationGameModeNowNotAvalible.repositionNow = true;
        goto label_567;
        label_570:
        val_406 = val_64;
        if(val_109 != 1)
        {
            goto label_571;
        }
        
        val_418 = 1;
        label_554:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_416 == 1)
        {
            goto label_572;
        }
        
        if((1179403647 == 0) || (4055 == 4055))
        {
            goto label_688;
        }
        
        label_687:
        label_688:
        if(val_418 == 0)
        {
            goto label_575;
        }
        
        val_419 = null;
        val_419 = null;
        val_403 = 1152921504848912384;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_580;
        }
        
        val_418.Reverse();
        goto label_580;
        label_575:
        val_420 = null;
        val_420 = null;
        val_422 = ConnectScene.<>c.<>9__282_2;
        if(val_422 == null)
        {
                System.Func<业丂丌丞丆东丏世万, System.Int32> val_242 = null;
            val_422 = val_242;
            val_242 = new System.Func<业丂丌丞丆东丏世万, System.Int32>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ConnectScene.<>c::下三丘七且业东丂专(ConnectScene.业丂丌丞丆东丏世万 三丟东丕丄丄下下丑));
            ConnectScene.<>c.<>9__282_2 = val_422;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_243 = System.Linq.Enumerable.OrderBy<业丂丌丞丆东丏世万, System.Int32>(source:  val_418, keySelector:  val_242);
        mem2[0] = new System.Collections.Generic.List<业丂丌丞丆东丏世万>(collection:  val_243);
        val_406 = val_64;
        label_580:
        if(((((0 & 1) != 0) && (GameConnect.丑丌丛丈丅丅与不业() != 24)) && (GameConnect.丑丌丛丈丅丅与不业() != 14)) && (GameConnect.丑丌丛丈丅丅与不业() != 17))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 20)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 22)
        {
            goto label_601;
        }
        
        }
        
        }
        
        val_423 = 0;
        label_888:
        if(((0 != 0) && (GameConnect.丑丌丛丈丅丅与不业() != 16)) && (GameConnect.丑丌丛丈丅丅与不业() != 8))
        {
                PGCompany.丗三万丁三丗上专丟 val_252 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_252.丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) != false)
        {
                MapPreviewController val_257 = val_252.transform.GetChild(index:  0).gameObject.GetComponent<MapPreviewController>();
            val_257.gameObject.SetActive(value:  true);
            val_257.不丕且丑七丐与丒丐(业丞丟万不丄丂丘丑:  mem[1152921525800818000], 丅丘丘三三丒不业且:  val_104.hintPointLeft);
            val_403 = 1152921504848912384;
            val_406 = val_64;
            val_423 = val_423 + 1;
        }
        
        }
        
        if(业三丆丙丗丑丏丆不 == false)
        {
            goto label_657;
        }
        
        if((丕丈丌丐下丅三七丌 == false) || (丕丈丌丐下丅三七丌.Count < 1))
        {
            goto label_622;
        }
        
        var val_408 = 0;
        label_637:
        System.WeakReference val_260 = 丕丈丌丐下丅三七丌.Item[0];
        val_424 = null;
        val_424 = null;
        SceneInfo val_262 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_260.丕丆丞丂业东与上丅());
        if(val_262 != 0)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_264 = val_260.丌不丅不丞东万专专();
            if(val_264.HasValue.丙东专丂世丈丏丁丂() == 3)
        {
                if(((-280909624) & 1) != 0)
        {
            goto label_632;
        }
        
        }
        
            System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_266 = val_260.业丄丄且丕丕不一万();
            val_425 = mem[1152921525800818000];
            if((((val_266.HasValue.丙东专丂世丈丏丁丂() == 20) ? 1 : 0) & 1152921525800773824) != 0)
        {
                this.且上不丘丘丏且丌丙(业丞丟万不丄丂丘丑:  val_425, 丌丝万上丅丒一丈丘:  val_423, 丄不东丁丂丅万丒丟:  val_262, 丗丂世丗丄不丟丘万:  true, 丐且丘丑与万丞丑丅:  val_260);
            val_425 = mem[1152921525800818000];
            val_426 = val_423 + 1;
        }
        
            this.且上不丘丘丏且丌丙(业丞丟万不丄丂丘丑:  val_425, 丌丝万上丅丒一丈丘:  val_423, 丄不东丁丂丅万丒丟:  val_262, 丗丂世丗丄不丟丘万:  false, 丐且丘丑与万丞丑丅:  val_260);
            val_403 = 1152921504848912384;
            val_427 = val_423 + 1;
        }
        
        label_632:
        val_406 = val_64;
        val_408 = val_408 + 1;
        if(val_408 < 丕丈丌丐下丅三七丌.Count)
        {
            goto label_637;
        }
        
        label_622:
        if((val_406 == 0) || (val_64.Count < 1))
        {
            goto label_639;
        }
        
        var val_409 = 0;
        label_653:
        System.WeakReference val_272 = val_64.Item[0];
        val_428 = null;
        val_428 = null;
        SceneInfo val_274 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_272.丕丆丞丂业东与上丅());
        if(val_274 != 0)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_276 = val_272.丌不丅不丞东万专专();
            if(val_276.HasValue.丙东专丂世丈丏丁丂() == 3)
        {
                if(((-280909624) & 1) != 0)
        {
            goto label_649;
        }
        
        }
        
            this.且上不丘丘丏且丌丙(业丞丟万不丄丂丘丑:  (GameConnect.丌不丅丆丏三丅丙上() != true) ? 8 : 5, 丌丝万上丅丒一丈丘:  val_427, 丄不东丁丂丅万丒丟:  val_274, 丗丂世丗丄不丟丘万:  false, 丐且丘丑与万丞丑丅:  val_272);
            val_427 = val_427 + 1;
        }
        
        label_649:
        val_409 = val_409 + 1;
        if(val_409 < val_64.Count)
        {
            goto label_653;
        }
        
        label_639:
        val_429 = null;
        val_404 = this;
        val_430 = val_11;
        if(ConnectScene.丙东丁丂丝世丑丒丘 != 24)
        {
            goto label_657;
        }
        
        val_431 = 0;
        goto label_658;
        label_661:
        this.世丁不丝业与丄三一(丌丝万上丅丒一丈丘:  val_427 + val_431, 丂丛丑东不丅丈一东:  38);
        val_431 = 1;
        label_658:
        if(val_431 < val_11.Length)
        {
            goto label_661;
        }
        
        val_427 = val_427 + val_431;
        label_657:
        int val_285 = mem[1152921525800786568].Count << ((GameConnect.丑丌丛丈丅丅与不业() == 20) ? 1 : 0);
        val_432 = val_2;
        if(val_285 >= 1)
        {
                var val_410 = 0;
            do
        {
            if(GameConnect.丑丌丛丈丅丅与不业() == 20)
        {
                业丂丌丞丆东丏世万 val_287 = mem[1152921525800786568].Item[0];
            val_433 = val_287.丏丈丗世丙万丆丐丅;
            val_434 = public 业丂丌丞丆东丏世万 System.Collections.Generic.List<业丂丌丞丆东丏世万>::get_Item(int index);
            val_435 = 0;
        }
        else
        {
                业丂丌丞丆东丏世万 val_288 = mem[1152921525800786568].Item[0];
            val_433 = val_288.丏丈丗世丙万丆丐丅;
            val_434 = public 业丂丌丞丆东丏世万 System.Collections.Generic.List<业丂丌丞丆东丏世万>::get_Item(int index);
            val_435 = val_410;
        }
        
            业丂丌丞丆东丏世万 val_289 = mem[1152921525800786568].Item[0];
            this.且上不丘丘丏且丌丙(业丞丟万不丄丂丘丑:  mem[1152921525800818000], 丌丝万上丅丒一丈丘:  val_427 + val_410, 丄不东丁丂丅万丒丟:  val_433, 丗丂世丗丄不丟丘万:  ((GameConnect.丑丌丛丈丅丅与不业() == 20) ? 1 : 0) & (((val_410 & 1) != 0) ? 1 : 0), 丐且丘丑与万丞丑丅:  val_289.丐且丘丑与万丞丑丅);
            val_410 = val_410 + 1;
        }
        while(val_285 != val_410);
        
        }
        
        int val_295 = mem[1152921525800786576].Count;
        if(业三丆丙丗丑丏丆不 == false)
        {
            goto label_692;
        }
        
        if(GameConnect.丂丏且丄丆丏与丄上() != true)
        {
                if(GameConnect.丌不丅丆丏三丅丙上() == false)
        {
            goto label_684;
        }
        
        }
        
        if(val_295 >= 1)
        {
            goto label_685;
        }
        
        goto label_692;
        label_572:
        if(1179403647 != 0)
        {
            goto label_687;
        }
        
        goto label_688;
        label_684:
        if((GameConnect.与丂丝丟丟三丑丝万() == false) || (val_295 <= 0))
        {
            goto label_692;
        }
        
        label_685:
        var val_411 = 0;
        int val_299 = val_427 + val_285;
        label_706:
        业丂丌丞丆东丏世万 val_300 = mem[1152921525800786576].Item[0];
        业丂丌丞丆东丏世万 val_301 = mem[1152921525800786576].Item[0];
        val_432 = val_2;
        if(GameConnect.丌不丅丆丏三丅丙上() == false)
        {
            goto label_697;
        }
        
        val_436 = val_299 + val_411;
        val_437 = 8;
        goto label_704;
        label_697:
        if(val_411 >= mem[1152921525800786576].Count)
        {
            goto label_699;
        }
        
        val_436 = val_299 + val_411;
        val_437 = 5;
        goto label_704;
        label_699:
        val_436 = val_299 + val_411;
        val_437 = 17;
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  17)) == false)
        {
            goto label_704;
        }
        
        this.上丅丑七丅一三世丐(业丞丟万不丄丂丘丑:  17, 丌丝万上丅丒一丈丘:  val_436, 丄不东丁丂丅万丒丟:  val_300.丏丈丗世丙万丆丐丅);
        goto label_705;
        label_704:
        this.且上不丘丘丏且丌丙(业丞丟万不丄丂丘丑:  val_437, 丌丝万上丅丒一丈丘:  val_436, 丄不东丁丂丅万丒丟:  val_300.丏丈丗世丙万丆丐丅, 丗丂世丗丄不丟丘万:  false, 丐且丘丑与万丞丑丅:  val_301.丐且丘丑与万丞丑丅);
        label_705:
        val_411 = val_411 + 1;
        if(val_411 < val_295)
        {
            goto label_706;
        }
        
        label_692:
        if(0 == 0)
        {
            goto label_707;
        }
        
        val_438 = 1152921525776312064;
        val_439 = this;
        val_440 = 0;
        if(0.Count < 1)
        {
            goto label_711;
        }
        
        var val_412 = val_427;
        val_412 = val_295 + val_412;
        do
        {
            this.上丅丑七丅一三世丐(业丞丟万不丄丂丘丑:  mem[1152921525800818000], 丌丝万上丅丒一丈丘:  (val_412 + val_285) + val_440, 丄不东丁丂丅万丒丟:  0.Item[0]);
            val_440 = val_440 + 1;
        }
        while(val_440 < 0.Count);
        
        goto label_711;
        label_707:
        val_439 = this;
        val_438 = 1152921525776312064;
        val_440 = 0;
        label_711:
        int val_310 = val_285 + val_427;
        val_441 = (val_310 + val_295) + val_440;
        if((this.connectSceneSelectMap.grid.GetComponent<UIGrid>()) != null)
        {
                int val_413 = val_312.maxPerLine;
            int val_313 = val_441 / val_413;
            val_413 = val_441 - (val_313 * val_413);
            val_310 = (val_413 != 0) ? (val_313 + 1) : (val_313);
        }
        else
        {
                int val_414 = val_312.maxPerLine;
            int val_314 = val_441 / val_312.maxPerLine;
            val_414 = val_441 - ((val_441 / val_414) * val_414);
            val_310 = (val_414 != 0) ? (val_314 + 1) : (val_314);
        }
        
        float val_416 = val_312.cellHeight;
        UnityEngine.Vector3 val_317 = this.connectSceneSelectMap.grid.transform.localPosition;
        float val_415 = (float)val_310;
        float val_421 = -0.5f;
        val_415 = val_415 + val_421;
        val_416 = val_415 * val_416;
        val_443 = val_416 - val_317.y;
        val_444 = -val_443;
        UnityEngine.Vector3 val_320 = this.connectSceneSelectMap.voteGrid.transform.localPosition;
        float val_417 = val_312.cellHeight;
        val_417 = val_417 * val_421;
        val_417 = val_444 + val_417;
        val_417 = val_417 + (-70f);
        this.connectSceneSelectMap.voteGrid.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.GameObject val_322 = this.connectSceneSelectMap.votePanelWidget.gameObject;
        if(mem[1152921525800786584].Count < 1)
        {
            goto label_729;
        }
        
        val_322.SetActive(value:  true);
        this.connectSceneSelectMap.votePanelWidget.transform.SetParent(parent:  this.connectSceneSelectMap.scrollViewSelectMapTransform, worldPositionStays:  true);
        val_444 = val_312.cellWidth;
        float val_418 = (float)val_312.maxPerLine;
        val_418 = val_444 * val_418;
        this.connectSceneSelectMap.votePanelWidget.width = (UnityEngine.Mathf.RoundToInt(f:  val_418)) - 14;
        UnityEngine.Vector3 val_328 = this.connectSceneSelectMap.grid.transform.localPosition;
        float val_419 = -35f;
        val_419 = val_419 - val_443;
        this.connectSceneSelectMap.votePanelWidget.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(this.connectSceneSelectMap.customButtonsContainer.activeSelf == false)
        {
            goto label_772;
        }
        
        int val_330 = mem[1152921525800786584].Count;
        int val_420 = val_312.maxPerLine;
        val_443 = val_312.cellHeight;
        int val_331 = val_330 / val_420;
        val_420 = val_330 - (val_331 * val_420);
        UnityEngine.Vector3 val_334 = this.connectSceneSelectMap.voteGrid.transform.localPosition;
        float val_422 = val_334.y;
        this.connectSceneSelectMap.customButtonsContainer.transform.SetParent(parent:  this.connectSceneSelectMap.scrollViewSelectMapTransform, worldPositionStays:  true);
        val_421 = ((float)(val_420 != 0) ? (val_331 + 1) : (val_331)) + val_421;
        val_421 = val_443 * val_421;
        val_445 = this.connectSceneSelectMap.customButtonsContainer.transform;
        val_446 = this.connectSceneSelectMap.grid;
        val_422 = val_421 - val_422;
        val_444 = -val_422;
        goto label_780;
        label_729:
        val_322.SetActive(value:  false);
        UnityEngine.Vector3 val_340 = this.connectSceneSelectMap.grid.transform.localPosition;
        float val_423 = -35f;
        val_423 = val_423 - val_443;
        this.connectSceneSelectMap.votePanelWidget.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_424 = (float)val_312.maxPerLine;
        val_424 = val_312.cellWidth * val_424;
        this.connectSceneSelectMap.votePanelWidget.width = (UnityEngine.Mathf.RoundToInt(f:  val_424)) - 14;
        if(this.connectSceneSelectMap.customButtonsContainer.activeSelf == false)
        {
            goto label_772;
        }
        
        this.connectSceneSelectMap.customButtonsContainer.transform.SetParent(parent:  this.connectSceneSelectMap.scrollViewSelectMapTransform, worldPositionStays:  true);
        val_445 = this.connectSceneSelectMap.customButtonsContainer.transform;
        val_446 = this.connectSceneSelectMap.grid;
        label_780:
        UnityEngine.Vector3 val_346 = val_446.transform.localPosition;
        val_445.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_772:
        this.世丘丞丝丞丘三且丞().ResetAndUpdateAnchors();
        if(val_6 != 0)
        {
                val_6.ResetPosition();
        }
        else
        {
                0.ResetPosition();
        }
        
        val_6.Restrict();
        if(0 == 0)
        {
            goto label_786;
        }
        
        val_447 = null;
        val_447 = null;
        val_449 = ConnectScene.<>c.<>9__282_3;
        if(val_449 == null)
        {
                System.Action<Rilisoft.NeedSquadLevelConnectScene> val_349 = null;
            val_449 = val_349;
            val_349 = new System.Action<Rilisoft.NeedSquadLevelConnectScene>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectScene.<>c::万丝丝丁三丌世丏丒(Rilisoft.NeedSquadLevelConnectScene 三丟东丕丄丄下下丑));
            ConnectScene.<>c.<>9__282_3 = val_449;
        }
        
        Rilisoft.NeedSquadLevelConnectScene val_350 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.NeedSquadLevelConnectScene>(丞下万上三丘上与专:  this.NeedSquadLevelConnectSceneScript, 丌专业且丛丏丞丝且:  val_349);
        val_397 = 丕丈丌丐下丅三七丌;
        val_450 = this.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this.connectSceneSelectMap.selectMap, 下下丁一下丒业丄业:  true);
        if(this.丆丙丗下专万丗世丑 != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_798;
        }
        
        }
        
        val_450 = val_450 & ((this.上丕东万与一专丂业() != 0) ? 1 : 0);
        label_798:
        if(GameConnect.丑丌丛丈丅丅与不业() == 34)
        {
                if(this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.rotationGameModeNotAvalible.activeSelf != true)
        {
                if(this.connectSceneSelectMap.ArmRaceMapPanel.mapPreview.rotationGameModeNowNotAvalible.gameObject.activeSelf == false)
        {
            goto label_812;
        }
        
        }
        
            val_450 = 0;
        }
        
        label_812:
        UIButton val_359 = mem[1152921525800786048] + 24.GetComponent<UIButton>();
        var val_360 = val_450 & 1;
        goto label_836;
        label_786:
        if(GameConnect.丑丌丛丈丅丅与不业() != 17)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 20)
        {
            goto label_822;
        }
        
        }
        
        val_452 = (丕丈丌丐下丅三七丌.Count + val_64.Count) + 1;
        goto label_825;
        label_822:
        val_452 = 0;
        label_825:
        val_397 = 丕丈丌丐下丅三七丌;
        val_453 = null;
        val_453 = null;
        val_454 = ConnectScene.丙东丁丂丝世丑丒丘;
        val_454 = ConnectScene.丙东丁丂丝世丑丒丘;
        if(val_454 == 17)
        {
                int val_367 = 0;
        }
        
        PGCompany.丁东丌世与丕东丆上.丛专丁世丐丑丐丌丂(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丛且丞与丕业下丏丞: ref  val_367, 世丆丏七且业下丅专:  true);
        val_451 = val_367;
        this.丆丒丆丂与丈上丏丕(丞丁丑丏丄丏七丂不:  System.String.alignConst, 丛且丞与丕业下丏丞:  0);
        goto label_836;
        label_847:
        val_451 = 0;
        UnityEngine.GameObject val_370 = this.connectSceneSelectMap.grid.transform.GetChild(index:  val_441).gameObject;
        if(val_370.activeSelf != false)
        {
                val_451 = 0;
            val_370.SetActive(value:  false);
        }
        
        val_441 = val_441 + 1;
        label_836:
        UnityEngine.Transform val_372 = this.connectSceneSelectMap.grid.transform;
        if(val_441 < val_372.childCount)
        {
            goto label_847;
        }
        
        val_455 = 0;
        goto label_848;
        label_851:
        val_451 = val_372.Item[0];
        this.丁丞专丆不不丟东东(丌丝万上丅丒一丈丘:  0, 丄不东丁丂丅万丒丟:  val_451);
        val_455 = 1;
        label_848:
        if(val_455 < mem[1152921525800786584].Count)
        {
            goto label_851;
        }
        
        val_456 = mem[1152921525800786584].Count;
        goto label_852;
        label_863:
        val_451 = 0;
        UnityEngine.GameObject val_379 = this.connectSceneSelectMap.voteGrid.transform.GetChild(index:  val_456).gameObject;
        if(val_379.activeSelf != false)
        {
                val_451 = 0;
            val_379.SetActive(value:  false);
        }
        
        val_456 = val_456 + 1;
        label_852:
        val_399 = this.connectSceneSelectMap;
        val_400 = this.connectSceneSelectMap.voteGrid.transform;
        if(val_456 < val_400.childCount)
        {
            goto label_863;
        }
        
        mem[1152921525800786593] = 1;
        if(val_397 != false)
        {
                val_451 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.gameObject, 丏业丟一东丂东丘丛:  false);
            val_399 = this.connectSceneSelectMap;
            UIPanel val_384 = this.connectSceneSelectMap.scrollViewSelectMapTransform.GetComponent<UIPanel>();
            this.丕丛丟丅丂东业丆丆();
        }
        
        mem[1152921525800786152] = 0;
        if(GameConnect.与丂丝丟丟三丑丝万() != true)
        {
                if(this.丆丙丗下专万丗世丑 == false)
        {
                return;
        }
        
        }
        
        if(this.上丕东万与一专丂业() != 0)
        {
                return;
        }
        
        val_399 = mem[1152921525800786048] + 24.GetComponent<UIButton>();
        return;
        label_601:
        MapPreviewController val_391 = val_243.transform.GetChild(index:  0).gameObject.GetComponent<MapPreviewController>();
        val_391.gameObject.SetActive(value:  true);
        val_391.与丆丅万与丛东三丈(业丞丟万不丄丂丘丑:  mem[1152921525800818000], 丗丗丈一世丞丏丙丟:  val_104.clanWarIconObject);
        goto label_888;
        label_571:
    }
    internal void 丄三一丑不丏丙业业()
    {
        var val_11;
        var val_12;
        Rilisoft.七丕丟丏三丈一丄世 val_13;
        var val_14;
        this.connectSceneSelectMap.votePanelVotesCountTween.PlayForward();
        val_11 = null;
        val_11 = null;
        val_12 = null;
        val_12 = null;
        val_13 = ConnectScene.丙东丁丂丝世丑丒丘;
        if((MapVoteController.丛丆丂丐丛不不丟万.丙七万丅万丞下一丕(丂丛丑东不丅丈一东:  val_13)) > 0)
        {
                return;
        }
        
        val_14 = 0;
        goto label_9;
        label_24:
        if((this.connectSceneSelectMap.voteGrid.transform.GetChild(index:  0).gameObject.activeSelf) != false)
        {
                this.connectSceneSelectMap.voteGrid.transform.GetChild(index:  0).GetComponent<MapVoteItem>().SetShowVotes();
        }
        
        val_14 = 1;
        label_9:
        val_13 = this.connectSceneSelectMap.voteGrid.transform;
        if(val_14 < val_13.childCount)
        {
            goto label_24;
        }
    
    }
    internal void 丛万业丛丈丐万下丂()
    {
        var val_9;
        var val_10;
        int val_11;
        UILabel val_12;
        var val_14;
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        val_11 = MapVoteController.丛丆丂丐丛不不丟万.丙七万丅万丞下一丕(丂丛丑东不丅丈一东:  ConnectScene.丙东丁丂丝世丑丒丘);
        if(val_11 > 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.votesLeftGO, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.voteTimeLeftGO, 丏业丟一东丂东丘丛:  false);
            val_12 = this.connectSceneSelectMap.votePanelVotesCount;
            string val_2 = val_11.ToString();
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.votesLeftGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.voteTimeLeftGO, 丏业丟一东丂东丘丛:  true);
            val_14 = null;
            val_14 = null;
            long val_3 = MapVoteController.丛丆丂丐丛不不丟万.且丝丞丆专丑下专业();
            val_12 = this.connectSceneSelectMap.votePanelVoteTimeLeft;
            if(val_3 != 1)
        {
                val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6626");
            System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  (double)val_3);
            string val_7 = System.String.Format(format:  val_11, arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_5._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        }
        
        }
        
        val_12.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
    }
    private void LateUpdate()
    {
        if(this.丛丗丆丏丟丞东丝丒 != false)
        {
                UIPanel val_1 = this.下丐丝丗东丙下世丄();
            if(val_1 != null)
        {
                val_1.SetDirty();
        }
        else
        {
                0.SetDirty();
        }
        
            val_1.Refresh();
            this.丛丗丆丏丟丞东丝丒 = false;
        }
        
        this.UpdateMapEvents();
        this.丛万业丛丈丐万下丂();
    }
    private int 上丕东万与一专丂业()
    {
        var val_13;
        var val_15;
        var val_17;
        var val_18;
        System.Collections.IEnumerator val_2 = this.connectSceneSelectMap.grid.transform.GetEnumerator();
        val_13 = 0;
        goto label_4;
        label_22:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_15 = val_2.Current;
        if(val_15 != null)
        {
                val_15 = 0;
        }
        
        val_13 = val_13 + val_15.gameObject.activeSelf;
        label_4:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_22;
        }
        
        val_17 = 0;
        val_18 = 0;
        if(val_2 != null)
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return (int)val_13;
        }
        
        if( == false)
        {
                return (int)val_13;
        }
        
        return (int)val_13;
    }
    internal bool 与丒万丆丈万丄丗下()
    {
        return (bool)(this.上丕东万与一专丂业() == 0) ? 1 : 0;
    }
    internal void 丆丒丆丂与丈上丏丕(string 丞丁丑丏丄丏七丂不, int 丛且丞与丕业下丏丞 = 0)
    {
        var val_3;
        var val_54;
        var val_55;
        float val_56;
        var val_58;
        var val_60;
        var val_61;
        var val_62;
        ConnectSceneSelectMap val_63;
        UnityEngine.Transform val_64;
        var val_68;
        var val_69;
        System.Action<Rilisoft.NeedSquadLevelConnectScene> val_71;
        var val_72;
        var val_73;
        System.Action<Rilisoft.DoubleRewardConnectScene> val_75;
        var val_76;
        System.Func<HintObject, HintItem> val_78;
        val_54 = this;
        val_55 = null;
        val_55 = null;
        ConnectScene.丑业业业丒丏丈丞下 = 丞丁丑丏丄丏七丂不;
        UIPanel val_4 = this.下丐丝丗东丙下世丄();
        UnityEngine.Vector2 val_5 = val_4.GetViewSize();
        val_56 = val_5.y;
        bool val_6 = System.String.IsNullOrEmpty(value:  ConnectScene.丑业业业丒丏丈丞下);
        UnityEngine.Transform val_7 = this.connectSceneSelectMap.grid.transform;
        if(val_7 == null)
        {
            goto label_7;
        }
        
        if(val_6 == false)
        {
            goto label_8;
        }
        
        label_16:
        val_7.GetChild(index:  丛且丞与丕业下丏丞).GetComponent<UIToggle>().value = true;
        this.connectSceneSelectMap.selectMap = this.connectSceneSelectMap.grid.transform.GetChild(index:  丛且丞与丕业下丏丞).GetComponent<MapPreviewController>();
        goto label_15;
        label_7:
        if(val_6 == true)
        {
            goto label_16;
        }
        
        label_8:
        UnityEngine.Transform val_13 = val_7.GetChild(index:  0);
        float val_15 = V1.16B + V1.16B;
        System.Collections.IEnumerator val_16 = this.connectSceneSelectMap.grid.transform.GetEnumerator();
        goto label_33;
        label_41:
        var val_56 = 0;
        val_56 = val_56 + 1;
        object val_18 = val_16.Current;
        MapPreviewController val_20 = 0.GetComponent<MapPreviewController>();
        val_58 = null;
        val_58 = null;
        if((ConnectScene.丑业业业丒丏丈丞下.Equals(value:  val_20.sceneMapName)) == false)
        {
            goto label_33;
        }
        
        goto label_34;
        label_33:
        var val_57 = 0;
        val_57 = val_57 + 1;
        if(val_16.MoveNext() == true)
        {
            goto label_41;
        }
        
        val_60 = -278589408;
        val_61 = 0;
        val_62 = 0;
        goto label_63;
        label_34:
        val_60 = -278589408;
        if(val_15 > val_56)
        {
                UnityEngine.Vector3 val_24 = 0.localPosition;
            UnityEngine.Vector2 val_25 = val_4.clipSoftness;
            float val_58 = 0.5f;
            val_58 = this.丏丝丕丈丑丙丄丁业 * val_58;
            val_58 = val_24.y + val_58;
            val_25.y = (val_15 - val_56) + val_25.y;
            val_56 = ((-val_58) > val_25.y) ? (val_25.y) : (-val_58);
            if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  val_56, 丒丈丙丐丏丕丆万丗:  0f, 丌丕丗七丒丛万丒东:  0.001f)) != false)
        {
                this.丒丂丐丝丒丛丁丒丈().ResetPosition();
        }
        else
        {
                val_63 = this.connectSceneSelectMap;
            if(val_63 != null)
        {
                val_64 = this.connectSceneSelectMap.scrollViewSelectMapTransform;
        }
        else
        {
                val_64 = this.connectSceneSelectMap.scrollViewSelectMapTransform;
            if(this.connectSceneSelectMap != null)
        {
                val_63 = this.connectSceneSelectMap;
        }
        else
        {
                val_63 = 0;
        }
        
        }
        
            UnityEngine.Vector3 val_28 = 123372880.localPosition;
            UnityEngine.Vector3 val_29 = this.connectSceneSelectMap.scrollViewSelectMapTransform.localPosition;
            val_3 = 0;
            val_64.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        }
        
        0.GetComponent<UIToggle>().value = true;
        val_61 = 0;
        val_62 = 0;
        this.connectSceneSelectMap.selectMap = 0.GetComponent<MapPreviewController>();
        label_63:
        if(val_16 != null)
        {
                var val_59 = 0;
            val_59 = val_59 + 1;
            val_16.Dispose();
        }
        
        if( == 1)
        {
            goto label_92;
        }
        
        if(( == 0) || ( == 417))
        {
            goto label_148;
        }
        
        label_147:
        label_148:
        val_68 = null;
        val_68 = null;
        ConnectScene.丑业业业丒丏丈丞下 = "";
        label_15:
        val_69 = null;
        val_69 = null;
        val_71 = ConnectScene.<>c.<>9__291_0;
        if(val_71 == null)
        {
                System.Action<Rilisoft.NeedSquadLevelConnectScene> val_34 = null;
            val_71 = val_34;
            val_34 = new System.Action<Rilisoft.NeedSquadLevelConnectScene>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectScene.<>c::丞丄丞丁丞丂世东丌(Rilisoft.NeedSquadLevelConnectScene 三丟东丕丄丄下下丑));
            ConnectScene.<>c.<>9__291_0 = val_71;
        }
        
        Rilisoft.NeedSquadLevelConnectScene val_35 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.NeedSquadLevelConnectScene>(丞下万上三丘上与专:  this.NeedSquadLevelConnectSceneScript, 丌专业且丛丏丞丝且:  val_34);
        val_72 = this.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  this.connectSceneSelectMap.selectMap, 下下丁一下丒业丄业:  true);
        if(this.丆丙丗下专万丗世丑 != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_108;
        }
        
        }
        
        val_72 = val_72 & ((this.上丕东万与一专丂业() != 0) ? 1 : 0);
        label_108:
        UIButton val_40 = this.connectSceneMainMenu.goBtn.GetComponent<UIButton>();
        bool val_41 = val_72;
        val_73 = null;
        val_73 = null;
        val_75 = ConnectScene.<>c.<>9__291_1;
        if(val_75 == null)
        {
                System.Action<Rilisoft.DoubleRewardConnectScene> val_43 = null;
            val_75 = val_43;
            val_43 = new System.Action<Rilisoft.DoubleRewardConnectScene>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectScene.<>c::且丂专下丞上下东业(Rilisoft.DoubleRewardConnectScene 三丟东丕丄丄下下丑));
            ConnectScene.<>c.<>9__291_1 = val_75;
        }
        
        Rilisoft.DoubleRewardConnectScene val_44 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.DoubleRewardConnectScene>(丞下万上三丘上与专:  this.DoubleRewardConnectScene, 丌专业且丛丏丞丝且:  val_43);
        HintController val_45 = HintController.与一丅丝不丈业与丙();
        val_76 = null;
        val_76 = null;
        val_78 = ConnectScene.<>c.<>9__291_2;
        if(val_78 == null)
        {
                System.Func<HintObject, HintItem> val_46 = null;
            val_78 = val_46;
            val_46 = new System.Func<HintObject, HintItem>(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  HintItem ConnectScene.<>c::丆丄丙丌且丛与东丟(HintObject 三丟东丕丄丄下下丑));
            ConnectScene.<>c.<>9__291_2 = val_78;
        }
        
        if((丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<HintItem, HintObject>(丞下万上三丘上与专:  val_45.hintObject, 丏丅丁丛一业丈专专:  val_46)) == null)
        {
                return;
        }
        
        HintController val_48 = HintController.与一丅丝不丈业与丙();
        HintItem val_49 = val_48.hintObject.丈丑丑东万丒一丁丐();
        if((System.String.op_Equality(a:  val_49.name, b:  "gobattle")) == false)
        {
                return;
        }
        
        if(((this.connectSceneMainMenu.goBtn.GetComponent<UIButton>()) & 1) == 0)
        {
            goto label_139;
        }
        
        HintController val_52 = HintController.与一丅丝不丈业与丙();
        HintItem val_53 = val_52.hintObject.丈丑丑东万丒一丁丐();
        val_53.defaultSpriteName = "green_btn";
        val_54 = HintController.与一丅丝不丈业与丙();
        val_54.丙万丞丄丐丂下丅丘();
        return;
        label_92:
        if( != 0)
        {
            goto label_147;
        }
        
        goto label_148;
        label_139:
        val_54 = HintController.与一丅丝不丈业与丙();
        val_54.东丏一丁下丄丙丙丂();
    }
    internal bool 且东丝丑丑丛世丈下(MapPreviewController 丞丁丑丏丄丏七丂不, bool 下下丁一下丒业丄业 = True)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_11;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_12;
        var val_13;
        var val_14;
        var val_15;
        SceneInfo val_16;
        if(丞丁丑丏丄丏七丂不 == 0)
        {
                val_12 = 1;
            return (bool)val_12;
        }
        
        if(丞丁丑丏丄丏七丂不.业丞丟万不丄丂丘丑 != 17)
        {
            goto label_6;
        }
        
        val_11 = 丞丁丑丏丄丏七丂不.业丞丟万不丄丂丘丑;
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  val_11)) == true)
        {
            goto label_27;
        }
        
        label_6:
        if(下下丁一下丒业丄业 == false)
        {
            goto label_14;
        }
        
        val_13 = null;
        val_13 = null;
        if(ConnectScene.丙东丁丂丝世丑丒丘 != 34)
        {
            goto label_14;
        }
        
        val_12 = 丞丁丑丏丄丏七丂不.丐且丘丑与万丞丑丅;
        if(val_12 == null)
        {
                return (bool)val_12;
        }
        
        if(val_12.七丂丌丈丄专丄三世() == false)
        {
            goto label_27;
        }
        
        label_14:
        val_14 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        if((val_14.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  丞丁丑丏丄丏七丂不.业丞丟万不丄丂丘丑)) == false)
        {
            goto label_20;
        }
        
        label_27:
        val_12 = 0;
        return (bool)val_12;
        label_20:
        if(丞丁丑丏丄丏七丂不.curSceneInfo == 0)
        {
                return val_10.东丌丕丆且丗丏丗丝(下丞七丒业丂丈丘下:  丞丁丑丏丄丏七丂不.mapID, 丂丛丑东不丅丈一东:  丞丁丑丏丄丏七丂不.业丒与丐不丘七业丒);
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = 丞丁丑丏丄丏七丂不.curSceneInfo;
        bool val_10 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  SceneInfoController.丄丘七三上丕世丞业.丝上专丂且东丏丄丌(丂丛丑东不丅丈一东:  丞丁丑丏丄丏七丂不.业丞丟万不丄丂丘丑, 东下丌丝且七丛丘丒:  val_16, 丁丏丗且上丗下与下:  (丞丁丑丏丄丏七丂不.squadMode == true) ? 1 : 0));
        if(val_10 == false)
        {
            goto label_27;
        }
        
        return val_10.东丌丕丆且丗丏丗丝(下丞七丒业丂丈丘下:  丞丁丑丏丄丏七丂不.mapID, 丂丛丑东不丅丈一东:  丞丁丑丏丄丏七丂不.业丒与丐不丘七业丒);
    }
    internal bool 东丌丕丆且丗丏丗丝(int 下丞七丒业丂丈丘下, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东)
    {
        var val_10;
        int val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = 下丞七丒业丂丈丘下;
        if(val_14 == 3)
        {
            goto label_1;
        }
        
        if(val_14 != 2)
        {
            goto label_2;
        }
        
        val_15 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.squad");
        goto label_7;
        label_1:
        val_15 = (Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  丂丛丑东不丅丈一东)) ^ 1;
        goto label_7;
        label_2:
        val_15 = 1;
        label_7:
        val_16 = null;
        val_16 = null;
        val_17 = val_15 & ((val_14 != 4) ? 1 : 0);
        if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  val_14)) != false)
        {
                int val_8 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  22, 专万丟三世业丙丈且:  val_14.ToString(), 丁丏丗且上丗下与下:  false));
            if(val_8 == 2147483647)
        {
                val_18 = null;
            val_18 = null;
            万丗且专万丟丌丂丐 val_9 = DungeonWindowUI.dungeonsInfo.Item[val_14];
            val_14 = val_10;
            var val_12 = (ExperienceController.丞丞丘业东丙丏七丌() >= val_14) ? 1 : 0;
        }
        else
        {
                bool val_13 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(上丕丈丞丌丘丅不与:  val_8);
            val_17 = val_13;
        }
        
        }
        
        val_13 = val_17;
        return (bool)val_13;
    }
    private void OnReceivedRoomListUpdate()
    {
        var val_3;
        var val_4;
        var val_5;
        if(this.丏上丒专丞丑东且丞 != false)
        {
                CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_1.customPanel.activeSelf == false)
        {
                return;
        }
        
        }
        
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(ConnectScene.一七丁三丄专下且丂 == null)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
    }
    private void 丆丝丁东丆与上上不(GameInfo 专专丂丝且万丂不世, int 丞世不丒下上上丝丑)
    {
        丞丘丒一上与丕丒且 val_27;
        string val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        专专丂丝且万丂不世.index = 丞世不丒下上上丝丑;
        UnityEngine.GameObject val_2 = 专专丂丝且万丂不世.gameObject;
        if(this.丑丐丅丟下丞三丛且.Count <= 丞世不丒下上上丝丑)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
        val_27 = this.丑丐丅丟下丞三丛且.Item[丞世不丒下上上丝丑];
        val_28 = val_27.丙丆丌丝丛丏丝丕业();
        if((val_28.Length == 36) && ((val_28.IndexOf(value:  "-")) == 8))
        {
                if((val_28.LastIndexOf(value:  "-")) == 23)
        {
                val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0088");
        }
        
        }
        
        专专丂丝且万丂不世.serverNameLabel.text = val_28;
        专专丂丝且万丂不世.countPlayersLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  val_27.三不万不丕丑一上与(), arg1:  val_27.丄丁丗丞丏丞世丕业());
        val_29 = null;
        val_29 = null;
        string val_27 = GameConnect.丂万且丟丛丈与丞丏;
        bool val_14 = System.String.Equals(a:  val_27.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七], b:  val_27);
        val_27 = val_14;
        专专丂丝且万丂不世.openSprite.SetActive(value:  val_27);
        专专丂丝且万丂不世.closeSprite.SetActive(value:  (~val_14) & 1);
        val_30 = null;
        val_30 = null;
        SceneInfo val_19 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  val_27.丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]));
        专专丂丝且万丂不世.mapNameLabel.SetText(丕丗丘丑丛与丑业丒:  val_19.七丛一丛专七丈丅专());
        专专丂丝且万丂不世.roomInfo = val_27;
        UnityEngine.Texture val_22 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_19.丙且上丒不下丑下丞());
        专专丂丝且万丂不世.丏丛与业丆丝世丒丗(万丁世丗丒丐丙丄丆:  val_19);
        专专丂丝且万丂不世.SetCustomizedIconVision(三丟东丕丄丄下下丑:  false);
        if(val_27.丂丂丁丕专丂丏与丌().Item[GameConnect.不丕丂三丙与丈且三] == null)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        val_27 = GameConnect.不丕丂三丙与丈且三;
        if(val_27.丂丂丁丕专丂丏与丌().Item[val_27] == "")
        {
            goto label_44;
        }
        
        val_32 = 1;
        goto label_45;
        label_3:
        val_2.SetActive(value:  false);
        return;
        label_44:
        val_32 = 0;
        label_45:
        专专丂丝且万丂不世.SetCustomizedIconVision(三丟东丕丄丄下下丑:  false);
    }
    private void 丘丒丛丙丏丟世不丘(string 丞丘与万丞三丁丘丙)
    {
        var val_60;
        var val_61;
        var val_105;
        var val_106;
        var val_107;
        var val_109;
        var val_110;
        var val_111;
        var val_112;
        bool val_114;
        var val_115;
        var val_116;
        var val_117;
        var val_118;
        int val_119;
        var val_120;
        var val_121;
        int val_122;
        var val_123;
        float val_124;
        var val_125;
        float val_126;
        val_105 = this;
        this.丑丐丅丟下丞三丛且.Clear();
        丞丘丒一上与丕丒且[] val_1 = 丅丒丗丑丒丙丛不丆.丘上业丗丈丌下不丑();
        bool val_2 = System.String.IsNullOrEmpty(value:  丞丘与万丞三丁丘丙);
        val_106 = 0;
        goto label_4;
        label_88:
        if(val_2 == false)
        {
            goto label_5;
        }
        
        if(val_1[0].三不万不丕丑一上与() == (val_1[0x0] + 32.丄丁丗丞丏丞世丕业()))
        {
            goto label_74;
        }
        
        label_5:
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
            goto label_13;
        }
        
        val_107 = null;
        val_107 = null;
        if((System.String.IsNullOrEmpty(value:  (null == null) ? val_1[0].丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七] : 0)) == true)
        {
            goto label_74;
        }
        
        label_13:
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
            goto label_37;
        }
        
        val_109 = null;
        val_109 = null;
        if(val_1[0].丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且] == null)
        {
            goto label_37;
        }
        
        val_110 = null;
        val_110 = null;
        if((val_1[0x0] + 32.丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且].Equals(value:  GameConnect.丅丕专丗东东丏专世.ToString())) == true)
        {
            goto label_37;
        }
        
        val_111 = null;
        val_111 = null;
        if((val_1[0x0] + 32.丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且].Equals(value:  3.ToString())) == false)
        {
            goto label_74;
        }
        
        label_37:
        if(val_2 == false)
        {
            goto label_46;
        }
        
        label_86:
        val_112 = null;
        val_112 = null;
        val_114 = val_1[0].丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆];
        val_115 = GameConnect.丑丌丛丈丅丅与不业();
        val_116 = GameConnect.丑丌丛丈丅丅与不业();
        val_117 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_114);
        if((val_114.七丛丛丁丕丄丕丅东(丒三东丆丕专丞且一:  21884928, 东一业丝丁专丄下东:  (val_115 == 8) ? 1 : 0, 且丈三且七上一丏丞:  (val_116 == 16) ? 1 : 0)) == false)
        {
            goto label_74;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
            goto label_57;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
            goto label_74;
        }
        
        val_118 = null;
        val_118 = null;
        if((System.String.IsNullOrEmpty(value:  val_1[0x0] + 32.丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七])) == true)
        {
            goto label_74;
        }
        
        label_57:
        this.丑丐丅丟下丞三丛且.Add(item:  val_1[0x0] + 32);
        goto label_74;
        label_46:
        if((val_1[0].丙丆丌丝丛丏丝丕业().Contains(value:  丞丘与万丞三丁丘丙)) != false)
        {
                if((((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().Length) != 36) || ((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().IndexOf(value:  "-")) != 8)) || ((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().LastIndexOf(value:  "-")) != 23))
        {
            goto label_86;
        }
        
        }
        
        label_74:
        val_106 = 1;
        label_4:
        if(val_106 < val_1.Length)
        {
            goto label_88;
        }
        
        if(this.丄丈丟丙不世与丅丈 >= 11)
        {
                this.丄丈丟丙不世与丅丈 = 1;
        }
        
        this.丄丈丟丙不世与丅丈 = 50;
        val_119 = this.丄丈丟丙不世与丅丈;
        if(this.丑丐丅丟下丞三丛且.Count < val_119)
        {
                val_119 = this.丑丐丅丟下丞三丛且.Count;
            this.丄丈丟丙不世与丅丈 = val_119;
        }
        
        val_115 = 1152921519068977584;
        val_114 = 1152921524288826496;
        val_116 = 1152921504848912384;
        goto label_93;
        label_101:
        if(this.gamesInfo != null)
        {
                val_120 = this.gamesInfo.Count;
        }
        else
        {
                val_120 = 0.Count;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gamesInfo.Item[val_120 - 1]);
        if(this.gamesInfo != null)
        {
                val_121 = this.gamesInfo.Count;
        }
        else
        {
                val_121 = 0.Count;
        }
        
        this.gamesInfo.RemoveAt(index:  val_121 - 1);
        val_119 = this.丄丈丟丙不世与丅丈;
        label_93:
        if(val_119 < this.gamesInfo.Count)
        {
            goto label_101;
        }
        
        val_122 = this.丄丈丟丙不世与丅丈;
        val_123 = public System.Int32 System.Collections.Generic.List<UnityEngine.GameObject>::get_Count();
        if(val_122 <= this.gamesInfo.Count)
        {
            goto label_103;
        }
        
        float val_110 = (float)UnityEngine.Screen.width;
        val_110 = val_110 / (float)UnityEngine.Screen.height;
        this.丕专丗万上丁世丝丁 = (val_110 < 0) ? 3 : 4;
        val_117 = 1152921505055887360;
        CustomPanelConnectScene val_55 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_56 = val_55.fonGames.localSize;
        int val_57 = this.丕专丗万上丁世丝丁 + (this.丕专丗万上丁世丝丁 << 2);
        val_57 = val_57 << 1;
        val_56.x = val_56.x - (float)val_57;
        val_124 = (float)this.丕专丗万上丁世丝丁;
        val_56.x = val_56.x / val_124;
        this.丒丙丘丟且丈丗且丞 = val_56.x;
        if(this.丄丈丟丙不世与丅丈 <= this.gamesInfo.Count)
        {
            goto label_109;
        }
        
        CustomPanelConnectScene val_59 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_125 = 1;
        goto label_114;
        label_140:
        if(val_61 == 0)
        {
            
        }
        
        CustomPanelConnectScene val_62 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.GameObject val_63 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_62.gameInfoItemPrefab);
        string val_65 = "GameInfo_" + X0 + 192.Count(X0 + 192.Count);
        if(val_63 != null)
        {
                val_63.name = val_65;
        }
        else
        {
                0.name = val_65;
        }
        
        CustomPanelConnectScene val_67 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_63.transform.SetParent(parent:  val_67.gridGamesTransform, worldPositionStays:  false);
        GameInfo val_68 = val_63.GetComponent<GameInfo>();
        UnityEngine.Vector2 val_69 = val_68.mapTexture.localSize;
        val_69.x = (X0 + 616) / val_69.x;
        mem2[0] = val_69.x;
        GameInfo val_70 = val_63.GetComponent<GameInfo>();
        UnityEngine.Vector2 val_71 = val_70.mapTexture.localSize;
        float val_111 = X0 + 624;
        val_111 = val_71.y * val_111;
        mem2[0] = val_111;
        val_60 = 0;
        val_124 = 0f;
        val_63.transform.GetChild(index:  0).transform.localScale = new UnityEngine.Vector3() {x = 0f, y = val_124, z = 0f};
        X0 + 192.Add(item:  val_63);
        CustomPanelConnectScene val_75 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_125 = 0;
        label_114:
        val_75.gameInfoItemPrefab.SetActive(value:  false);
        label_109:
        if((X0 + 536) > (X0 + 192.Count))
        {
            goto label_140;
        }
        
        CustomPanelConnectScene val_77 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_77.gameInfoItemPrefab.activeSelf != false)
        {
                CustomPanelConnectScene val_79 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_79.gameInfoItemPrefab.SetActive(value:  false);
        }
        
        CustomPanelConnectScene val_80 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_123 = public UIGrid UnityEngine.Component::GetComponent<UIGrid>();
        if((val_80.gridGames.GetComponent<UIGrid>()) != null)
        {
                val_81.cellWidth = (X0 + 616) + (X0 + 628);
            float val_112 = X0 + 620;
            val_124 = mem[X0 + 628];
            val_124 = X0 + 628;
            val_112 = val_112 + val_124;
            val_81.cellHeight = val_112;
            val_122 = mem[X0 + 612];
            val_122 = X0 + 612;
        }
        else
        {
                mem[40] = (X0 + 616) + (X0 + 628);
            val_81.cellHeight = (X0 + 620) + (X0 + 628);
            val_122 = mem[X0 + 612];
            val_122 = X0 + 612;
        }
        
        val_81.maxPerLine = val_122;
        label_103:
        CustomPanelConnectScene val_85 = CustomPanelConnectScene.丑七不且上丗丁一世();
        CustomPanelConnectScene val_87 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_89 = val_87.scrollGames.GetComponent<UIPanel>().GetViewSize();
        CustomPanelConnectScene val_90 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_126 = val_124 + val_124;
        if(val_126 >= 0)
        {
                if((X0 + 610) != 0)
        {
            goto label_166;
        }
        
        }
        
        CustomPanelConnectScene val_91 = CustomPanelConnectScene.丑七不且上丗丁一世();
        CustomPanelConnectScene val_93 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_95 = val_93.gridGames.transform.localPosition;
        val_126 = val_95.y;
        CustomPanelConnectScene val_96 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_122 = val_96.gridGames.transform;
        UnityEngine.Vector3 val_98 = val_122.localPosition;
        float val_113 = (float)X0 + 612;
        val_113 = val_113 * 0.5f;
        float val_99 = (X0 + 616) + (X0 + 628);
        val_113 = val_113 + (-0.5f);
        val_99 = -(val_99 * val_113);
        val_60 = 0;
        val_91.gridGames.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        CustomPanelConnectScene val_100 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_100.scrollGames.ResetPosition();
        mem2[0] = 1;
        label_166:
        if((X0 + 536) >= 1)
        {
                var val_114 = 0;
            do
        {
            val_122 = X0 + 192.Item[0];
            丆丝丁东丆与上上不(专专丂丝且万丂不世:  val_122.GetComponent<GameInfo>(), 丞世不丒下上上丝丑:  0);
            val_114 = val_114 + 1;
        }
        while(val_114 < (X0 + 536));
        
        }
        
        CustomPanelConnectScene val_103 = CustomPanelConnectScene.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_103.scrollGames, 丏业丟一东丂东丘丛:  false);
        CustomPanelConnectScene val_104 = CustomPanelConnectScene.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_104.scrollGames, 丏业丟一东丂东丘丛:  true);
    }
    private void OnPhotonJoinRoomFailed()
    {
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        this.loadingMapPanel.SetActive(value:  false);
        if(this.丏上丒专丞丑东且丞 != false)
        {
                CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_1.gameIsfullLabel.timer = 3f;
            CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_2.gameIsfullLabel.gameObject.SetActive(value:  true);
            this = CustomPanelConnectScene.丑七不且上丗丁一世();
            this.丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
        }
        
        UnityEngine.Debug.Log(message:  "[Connect_Scene] On_PhotonJoinRoomFailed");
    }
    private void OnJoinedRoom()
    {
        var val_28;
        string val_29;
        var val_30;
        var val_31;
        var val_32;
        val_28 = null;
        val_28 = null;
        val_29 = GameConnect.七丟丞不丆万上业丆;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_29] == null)
        {
                return;
        }
        
        val_29 = 1152921504848912384;
        if(this.丈丁下丟不不丛丗丏 != 0)
        {
                if(this.丈丁下丟不不丛丗丏.gameObject.activeSelf == true)
        {
                return;
        }
        
        }
        
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 != 0)
        {
                if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丈丄不丞丝丌上丄丐() != 0)
        {
                if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丈丄不丞丝丌上丄丐().gameObject.activeSelf == true)
        {
                return;
        }
        
        }
        
        }
        
        InfoWindowController val_13 = InfoWindowController.丑七不且上丗丁一世();
        if(val_13.competitionConnectWindow.丙东丞丛丝丅世七三() == true)
        {
                return;
        }
        
        if(this.丛丂丘三丐丐丕世丂 != false)
        {
                return;
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "On JoinedRoom");
        if(UnityEngine.Application.isEditor != false)
        {
                val_30 = null;
            val_30 = null;
            UnityEngine.Debug.Log(message:  "On Joined Room " + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]);
        }
        
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        NotificationController.下世东丘且丏丙丐与();
        val_31 = null;
        val_31 = null;
        val_32 = null;
        val_32 = null;
        SceneInfo val_24 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]));
        if(val_24 != null)
        {
                this.上下丟七丗业丁丒丕 = val_24.丙且上丒不下丑下丞();
        }
        else
        {
                this.上下丟七丗业丁丒丕 = 0.丙且上丒不下丑下丞();
        }
        
        this.丝业丗上上丘丐与丗(丂丗一丆丂丌下丛丐:  val_24.丙且上丒不下丑下丞());
    }
    private void 丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)
    {
        丞丘丒一上与丕丒且 val_17;
        var val_18;
        var val_19;
        var val_20;
        if(丟丄下上丈丗丙丞世 == false)
        {
            goto label_1;
        }
        
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.nameAlreadyUsedLabel.timer = 3f;
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_2.nameAlreadyUsedLabel.gameObject.SetActive(value:  true);
        goto label_41;
        label_1:
        if(this.丏上丒专丞丑东且丞 == false)
        {
            goto label_10;
        }
        
        if(this.一世东丄丗丆丘丛丂 == null)
        {
            goto label_23;
        }
        
        var val_18 = 0;
        label_19:
        if(val_18 >= val_4.Length)
        {
            goto label_15;
        }
        
        val_18 = val_18 + 1;
        if((System.String.op_Equality(a:  丅丒丗丑丒丙丛不丆.丘上业丗丈丌下不丑()[0].东丙上东业丆不丟丘(), b:  this.一世东丄丗丆丘丛丂.东丙上东业丆不丟丘())) == false)
        {
            goto label_19;
        }
        
        val_18 = 0;
        goto label_20;
        label_15:
        val_18 = 1;
        label_20:
        val_17 = this.一世东丄丗丆丘丛丂;
        val_17.丂与丗七丒丂丏七丛(丙业与丙丗丝不丈东:  true);
        label_10:
        if((this.一世东丄丗丆丘丛丂 == null) || (this.一世东丄丗丆丘丛丂.专上丕世丒一万东丂() == false))
        {
            goto label_23;
        }
        
        val_17 = 1152921505055887360;
        CustomPanelConnectScene val_9 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_9.enterPasswordPanel.SetActive(value:  false);
        val_19 = null;
        val_19 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_20 = null;
            val_20 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        CustomPanelConnectScene val_11 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_11.customPanel.SetActive(value:  true);
        this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
        CustomPanelConnectScene.丑七不且上丗丁一世().丘丁丛丟丟东七东上();
        goto label_41;
        label_23:
        CustomPanelConnectScene val_13 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_13.gameIsfullLabel.timer = 3f;
        CustomPanelConnectScene val_14 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_14.gameIsfullLabel.gameObject.SetActive(value:  true);
        CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
        label_41:
        this.loadingMapPanel.SetActive(value:  false);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    private void 丂丐与丞丗丒丘丑上()
    {
        var val_27;
        var val_28;
        System.Collections.Generic.List<UnityEngine.GameObject> val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        UnityEngine.Debug.Log(message:  "On Disconnected From Photon");
        val_27 = null;
        val_27 = null;
        GameConnect.七七丈东丅上丝丒万 = false;
        if(this.connectSceneMainMenu.gameObject.activeSelf != false)
        {
                if(this.loadingMapPanel.activeSelf == false)
        {
            goto label_13;
        }
        
        }
        
        if(this.丘丛上丑丗上世专业 == false)
        {
            goto label_13;
        }
        
        val_28 = null;
        val_28 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_13;
        }
        
        this.connectSceneMainMenu.gameObject.SetActive(value:  true);
        this.allInterfacePanel.backBtn.SetActive(value:  true);
        this.allInterfacePanel.backBtnSecond.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.gameObject, 丏业丟一东丂东丘丛:  true);
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_6.createPanel.SetActive(value:  false);
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  false, 世丆丏七且业下丅专:  true, 业三丆丙丗丑丏丆不:  true, 一丅丆丂七与丆丈丂:  false);
        CustomPanelConnectScene val_7 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_7.customPanel.SetActive(value:  false);
        CustomPanelConnectScene val_8 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_8.customizePanel.SetActive(value:  false);
        if(this.丏上丒专丞丑东且丞 == false)
        {
            goto label_31;
        }
        
        CustomPanelConnectScene val_9 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_9.searchPanel.SetActive(value:  false);
        CustomPanelConnectScene val_10 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_10.enterPasswordPanel.SetActive(value:  false);
        CustomPanelConnectScene val_11 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_11.enterPasswordCustomPanel.SetActive(value:  false);
        goto label_40;
        label_55:
        CustomPanelConnectScene val_12 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Transform val_13 = val_12.gridGamesTransform.GetChild(index:  0);
        if(val_13 != null)
        {
                val_13.parent = 0;
            val_29 = this.gamesInfo;
        }
        else
        {
                0.parent = 0;
            val_29 = this.gamesInfo;
        }
        
        bool val_15 = val_29.Remove(item:  val_13.gameObject);
        UnityEngine.Object.Destroy(obj:  val_13.gameObject);
        label_40:
        CustomPanelConnectScene val_17 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_17.gridGamesTransform.childCount > 0)
        {
            goto label_55;
        }
        
        label_31:
        val_30 = null;
        val_30 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_31 = null;
            val_31 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        this.丕丛丟丅丂东业丆丆();
        this.connectSceneMainMenu.serverIsNotAvalible.timer = 3f;
        this.connectSceneMainMenu.serverIsNotAvalible.gameObject.SetActive(value:  true);
        UICamera.selectedObject = 0;
        this.丟三丛万丅丙丆万丑(丌丝专丕业丛丝丏世:  ((GameConnect.丞丗东丆下丈丒东业(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true) ? 24 : GameConnect.丑丌丛丈丅丅与不业(), 下不丄丞丒丕万丟三:  false, 丌丁丙上七丟丈丌七:  false);
        this.丏上丒专丞丑东且丞 = false;
        val_32 = null;
        val_32 = null;
        GameConnect.丛丑世丕丌上丑丂丈 = false;
        this.connectSceneSelectMap.SetWideBg(三丟东丕丄丄下下丑:  (GameConnect.丛丑世丕丌上丑丂丈 == true) ? 1 : 0);
        GameConnect.东丒丗丄一丐且丆丝 = false;
        label_13:
        val_33 = null;
        val_33 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_34 = null;
            val_34 = null;
            WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  0);
        }
        
        this.loadingMapPanel.SetActive(value:  false);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    internal void 丏丑不七丕丄丅东丆(string 七丆丂丂下丈且丟世)
    {
        this.丅丟丘专丞丁丄丌丗(丛丘七丂且丟丁一丙:  七丆丂丂下丈且丟世, 丑一丈丐专丑且丞丅:  false);
    }
    private void 丅丟丘专丞丁丄丌丗(string 丛丘七丂且丟丁一丙 = "", bool 丑一丈丐专丑且丞丅 = False)
    {
        LoadingNGUIController val_3;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "start SetFonLoadingWaitForReset");
        丑一丈丐专丑且丞丅 = 丑一丈丐专丑且丞丅;
        this.丆丆业丂专与丙丐不(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙, 丑一丈丐专丑且丞丅:  丑一丈丐专丑且丞丅);
        val_3 = this.三三丆下东丏丌丅上;
        if(val_3 != 0)
        {
                val_3 = this.三三丆下东丏丌丅上.gameObject;
            UnityEngine.Object.Destroy(obj:  val_3);
            this.三三丆下东丏丌丅上 = 0;
        }
        
        this.上丌万丙丝世三丌丝(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "End SetFonLoadingWaitForReset");
    }
    private void 丒专丏丄与与丏丆丌(string 丛丘七丂且丟丁一丙 = "", bool 丑一丈丐专丑且丞丅 = False)
    {
        LoadingNGUIController val_3;
        丑一丈丐专丑且丞丅 = 丑一丈丐专丑且丞丅;
        this.丆丆业丂专与丙丐不(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙, 丑一丈丐专丑且丞丅:  丑一丈丐专丑且丞丅);
        val_3 = this.三三丆下东丏丌丅上;
        if(val_3 != 0)
        {
                val_3 = this.三三丆下东丏丌丅上.gameObject;
            UnityEngine.Object.Destroy(obj:  val_3);
            this.三三丆下东丏丌丅上 = 0;
        }
        
        this.上丌万丙丝世三丌丝(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙);
    }
    private void 上丌万丙丝世三丌丝(string 丛丘七丂且丟丁一丙)
    {
        var val_9;
        var val_10;
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindowNoShowNext();
        val_9 = null;
        val_9 = null;
        LoadingNGUIController.丙丅东上世万丐丏丞 = true;
        LoadingNGUIController val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
        this.三三丆下东丏丌丅上 = val_4;
        val_4.SceneToLoad = 丛丘七丂且丟丁一丙;
        val_10 = null;
        val_10 = null;
        this.三三丆下东丏丌丅上.SetLoadingTexture(与万丆丛丒万丝丙丑:  LoadConnectScene.上三丕下一丅丘上丝);
        this.三三丆下东丏丌丅上.transform.parent = this.loadingMapPanel.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        this.三三丆下东丏丌丅上.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        this.三三丆下东丏丌丅上.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  false, 丐且丘丑与万丞丑丅:  0);
    }
    private void 丆丆业丂专与丙丐不(string 丛丘七丂且丟丁一丙, bool 丑一丈丐专丑且丞丅)
    {
        string val_35;
        object val_37;
        var val_38;
        var val_39;
        var val_40;
        UnityEngine.Texture val_41;
        var val_42;
        UnityEngine.Debug.Log(message:  "setFonLoading " + 丛丘七丂且丟丁一丙);
        if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                int val_3 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunCoop", defaultValue:  0);
            if(丑一丈丐专丑且丞丅 != false)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "CountRunCoop", value:  (UnityEngine.PlayerPrefs.GetInt(key:  "CountRunCoop", defaultValue:  0)) + 1);
        }
        
            int val_35 = this.上丁丈丛丌上不丟与;
            val_35 = val_3 - ((val_3 / val_35) * val_35);
            UnityEngine.Object val_8 = UnityEngine.Resources.Load(path:  "NoteLoadings/note_Time_Survival_"("NoteLoadings/note_Time_Survival_") + val_35);
        }
        else
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 2)
        {
                val_35 = "CountRunCompany";
            int val_10 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunCompany", defaultValue:  0);
            int val_36 = this.一丁丈丗丄丛丑丗业;
            val_36 = val_10 - ((val_10 / val_36) * val_36);
            val_37 = "NoteLoadings/note_Team_Battle_";
        }
        else
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 3)
        {
                val_35 = "CountRunHunger";
            int val_13 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunHunger", defaultValue:  0);
            int val_37 = this.七一丟丆丟丞专丆东;
            val_37 = val_13 - ((val_13 / val_37) * val_37);
            val_37 = "NoteLoadings/note_Deadly_Games_";
        }
        else
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 4)
        {
                val_35 = "CountRunFlag";
            int val_16 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunFlag", defaultValue:  0);
            int val_38 = this.丗丌上丁且专丈上世;
            val_38 = val_16 - ((val_16 / val_38) * val_38);
            val_37 = "NoteLoadings/note_Flag_Capture_";
        }
        else
        {
                val_35 = "CountRunDeadmath";
            int val_18 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunDeadmath", defaultValue:  0);
            int val_39 = this.上丞且不七丙万万丘;
            val_39 = val_18 - ((val_18 / val_39) * val_39);
            val_37 = "NoteLoadings/note_Deathmatch_";
        }
        
        }
        
        }
        
            UnityEngine.Object val_21 = UnityEngine.Resources.Load(path:  val_37 + val_39);
            if(丑一丈丐专丑且丞丅 != false)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "CountRunDeadmath", value:  (UnityEngine.PlayerPrefs.GetInt(key:  val_35, defaultValue:  0)) + 1);
        }
        
        }
        
        string[] val_24 = new string[6];
        val_24[0] = "LevelLoadings";
        val_24[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "";
        val_24[2] = "/Loading_";
        val_24[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : "";
        val_24[4] = 丛丘七丂且丟丁一丙;
        val_38 = "";
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_39 = null;
            val_39 = null;
        }
        
        val_24[5] = (GameConnect.丙丙东七丙丞专丛不 == true) ? "_squad" : (val_38);
        UnityEngine.Object val_32 = UnityEngine.Resources.Load(path:  +val_24);
        val_40 = null;
        val_40 = null;
        if(val_32 != null)
        {
                var val_33 = (null == null) ? (val_32) : 0;
        }
        else
        {
                val_41 = 0;
        }
        
        LoadConnectScene.上三丕下一丅丘上丝 = val_41;
        val_42 = null;
        val_42 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = LoadConnectScene.上三丕下一丅丘上丝;
        LoadConnectScene.丞丗专丝丙专丂上丗 = 丛丘七丂且丟丁一丙;
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        this.loadingToDraw.gameObject.SetActive(value:  false);
        if(this.loadingToDraw != null)
        {
                return;
        }
    
    }
    internal void 东与丌东丐丏七且专()
    {
        this.丈丝丛东且丁丝且三 = true;
        this.丛丂丘三丐丐丕世丂 = true;
    }
    internal void 丝业丗上上丘丐与丗(string 丂丗一丆丂丌下丛丐)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        FpsManager.丞丝下丄丆且丌丈丐();
        FpsManager.专上七丝丝丅丙上丝 = true;
        ShopNGUIController.上万丐丞丂丐丌丛丆(丁丅丟丒丙丐丅与丂:  false);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start Move To Game Scene");
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Move To Game Scene="("Move To Game Scene=") + 丂丗一丆丂丌下丛丐);
        }
        
        val_13 = null;
        val_13 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_14 = null;
        val_14 = null;
        GameConnect.七七丈东丅上丝丒万 = true;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_4 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
            if(val_4 != null)
        {
                val_16 = val_4.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        }
        else
        {
                val_16 = 0;
        }
        
            val_17 = null;
            val_17 = null;
            if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  丂丗一丆丂丌下丛丐)) != false)
        {
                val_18 = null;
            val_18 = null;
            val_16 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[丂丗一丆丂丌下丛丐];
        }
        
            val_19 = null;
            val_19 = null;
            WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 105 : (val_16));
        }
        
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "mapPreview clear");
        if(this.三三丆下东丏丌丅上 == 0)
        {
                this.丅丟丘专丞丁丄丌丗(丛丘七丂且丟丁一丙:  丂丗一丆丂丌下丛丐, 丑一丈丐专丑且丞丅:  true);
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "SetFonLoadingWaitForReset");
        this.loadingMapPanel.SetActive(value:  true);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  2651");
        this.丈丝丛东且丁丝且三 = true;
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                Rilisoft.一丟专且三万丞丁丂.丄丌丟下丂丒丅丛且(丛一丆专世丝丄丒与:  false, 丙世不不一丏业三且:  false, 丆丗丝丗丂丅丝丏专:  0, 七丆丂丂下丈且丟世:  丂丗一丆丂丌下丛丐);
        }
        
        val_20 = null;
        val_20 = null;
        与丂丏丛丞丞丒丟丄.丝丂丌丅丛丘与丌丏 = true;
        val_21 = null;
        val_21 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = false;
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  丂丗一丆丂丌下丛丐);
    }
    private void 七丘专丕上一丝丌丈()
    {
        this.lanScan.StartSearchBroadCasting(丄丕丝丌上万专世不:  new LANBroadcastService.丘丛世丘业丛专七世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ConnectScene::丑丗三万丐上丒丐丕(string 丌丑三不丝与丟丏丗)));
    }
    private void 丑丗三万丐上丒丐丕(string 丌丑三不丝与丟丏丗)
    {
        string val_6;
        var val_8;
        var val_13;
        System.Collections.Generic.List<丝与一东丄三东丁上> val_14;
        var val_16;
        val_14 = this.七丄丁丘丝丑三世专;
        if(val_14.Count < 1)
        {
            goto label_12;
        }
        
        val_14 = this.七丄丁丘丝丑三世专;
        List.Enumerator<T> val_2 = val_14.GetEnumerator();
        val_13 = 1152921525807998368;
        val_16 = 0;
        goto label_4;
        label_6:
        Unity.Notifications.Android.AndroidNotificationChannel val_7 = val_6.丗丗丏丆一丟丝东丏();
        val_14 = val_8;
        label_4:
        if(((-273612816) & 1) != 0)
        {
            goto label_6;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((((((val_14.Equals(value:  丌丑三不丝与丟丏丗)) & true) != 0) ? (val_16) : (0 + 1)) & 255) != 0)
        {
                return;
        }
        
        label_12:
        val_6 = 丌丑三不丝与丟丏丗;
        this.七丄丁丘丝丑三世专.Add(item:  new 丝与一东丄三东丁上() {丐丅丐丐丌丅丒丛一 = val_6});
    }
    private int 丄东与七东丝专丛业(LANBroadcastService.丈丒世与万丘丈三专 丐东丗不下丏三下不, LANBroadcastService.丈丒世与万丘丈三专 上专下丕丂丑七业丅)
    {
        if(丐东丗不下丏三下不.丐丅丐丐丌丅丒丛一 != null)
        {
                return 丐东丗不下丏三下不.丐丅丐丐丌丅丒丛一.CompareTo(strB:  上专下丕丂丑七业丅.丐丅丐丐丌丅丒丛一);
        }
        
        return 丐东丗不下丏三下不.丐丅丐丐丌丅丒丛一.CompareTo(strB:  上专下丕丂丑七业丅.丐丅丐丐丌丅丒丛一);
    }
    private void 丂专丂丒下三丈东专(GameInfo 专专丂丝且万丂不世, LANBroadcastService.丈丒世与万丘丈三专 世东丈丙丘下丝丌三)
    {
        string val_8;
        var val_9;
        val_8 = 世东丈丙丘下丝丌三.丒丘丏上丙丟丑丕丈;
        if((System.String.IsNullOrEmpty(value:  世东丈丙丘下丝丌三.丒丘丏上丙丟丑丕丈)) != false)
        {
                val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0948");
        }
        
        专专丂丝且万丂不世.serverNameLabel.text = val_8;
        专专丂丝且万丂不世.countPlayersLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  世东丈丙丘下丝丌三.丙丕丁七丟丈丛丈专, arg1:  世东丈丙丘下丝丌三.丞与一东丈世且丐丕);
        专专丂丝且万丂不世.openSprite.SetActive(value:  true);
        专专丂丝且万丂不世.closeSprite.SetActive(value:  false);
        val_9 = null;
        val_9 = null;
        SceneInfo val_4 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不);
        专专丂丝且万丂不世.mapNameLabel.SetText(丕丗丘丑丛与丑业丒:  val_4.七丛一丛专七丈丅专());
        mem2[0] = 世东丈丙丘下丝丌三.丐丆丐七一上专三丑;
        mem2[0] = 世东丈丙丘下丝丌三.丁与丈业专三丐丞丒;
        mem2[0] = 世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不;
        专专丂丝且万丂不世.roomInfoLocal = 世东丈丙丘下丝丌三.丐丅丐丐丌丅丒丛一;
        UnityEngine.Texture val_7 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_4.丙且上丒不下丑下丞());
        专专丂丝且万丂不世.丏丛与业丆丝世丒丗(万丁世丗丒丐丙丄丆:  val_4);
    }
    public void UpdateLocalServersList()
    {
        string val_3;
        var val_12;
        string val_15;
        string val_16;
        string val_17;
        string val_18;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        int val_83;
        UITexture val_84;
        var val_85;
        var val_86;
        var val_87;
        float val_88;
        var val_89;
        int val_90;
        UIGrid val_92;
        float val_93;
        System.Collections.Generic.List<丈丒世与万丘丈三专> val_1 = new System.Collections.Generic.List<丈丒世与万丘丈三专>();
        val_79 = 0;
        goto label_1;
        label_31:
        val_80 = null;
        val_80 = null;
        丈丒世与万丘丈三专 val_2 = this.lanScan.lstReceivedMessages.Item[0];
        if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  val_3)) != false)
        {
                val_81 = null;
            val_81 = null;
            丈丒世与万丘丈三专 val_5 = this.lanScan.lstReceivedMessages.Item[0];
            var val_7 = (与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[val_3] == 3) ? 1 : 0;
        }
        else
        {
                val_82 = 0;
        }
        
        if((val_82 & GameConnect.东且三丆丑世世丘丟()) != true)
        {
                if((val_82 != 0) || (GameConnect.东且三丆丑世世丘丟() == true))
        {
            goto label_25;
        }
        
        }
        
        丈丒世与万丘丈三专 val_11 = this.lanScan.lstReceivedMessages.Item[0];
        if(val_12 == GameConnect.丑丌丛丈丅丅与不业())
        {
                丈丒世与万丘丈三专 val_14 = this.lanScan.lstReceivedMessages.Item[0];
            val_3 = val_16;
            val_1.Add(item:  new 丈丒世与万丘丈三专() {丐丅丐丐丌丅丒丛一 = val_17, 丒丘丏上丙丟丑丕丈 = val_17, 丞丁丑丏丄丏七丂不 = val_3, 丙丕丁七丟丈丛丈专 = val_3, 丞与一东丈世且丐丕 = val_3, 丐丆丐七一上专三丑 = val_15, 与且世三丙丈一丈万 = val_15, 丒七世丈丌丑丏丄丏 = val_15, 丁与丈业专三丐丞丒 = val_18});
        }
        
        label_25:
        val_79 = 1;
        label_1:
        if(val_79 < this.lanScan.lstReceivedMessages.Count)
        {
            goto label_31;
        }
        
        this.丄丈丟丙不世与丅丈 = 50;
        val_83 = this.丄丈丟丙不世与丅丈;
        if(val_1.Count < val_83)
        {
                val_83 = val_1.Count;
            this.丄丈丟丙不世与丅丈 = val_83;
        }
        
        val_84 = 1152921525804594720;
        goto label_35;
        label_43:
        if(this.gamesInfo != null)
        {
                val_85 = this.gamesInfo.Count;
        }
        else
        {
                val_85 = 0.Count;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gamesInfo.Item[val_85 - 1]);
        if(this.gamesInfo != null)
        {
                val_86 = this.gamesInfo.Count;
        }
        else
        {
                val_86 = 0.Count;
        }
        
        this.gamesInfo.RemoveAt(index:  val_86 - 1);
        val_83 = this.丄丈丟丙不世与丅丈;
        label_35:
        if(val_83 < this.gamesInfo.Count)
        {
            goto label_43;
        }
        
        val_87 = public System.Int32 System.Collections.Generic.List<UnityEngine.GameObject>::get_Count();
        if(this.丄丈丟丙不世与丅丈 <= this.gamesInfo.Count)
        {
            goto label_45;
        }
        
        float val_78 = (float)UnityEngine.Screen.width;
        val_78 = val_78 / (float)UnityEngine.Screen.height;
        this.丕专丗万上丁世丝丁 = (val_78 < 0) ? 3 : 4;
        CustomPanelConnectScene val_34 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_35 = val_34.fonGames.localSize;
        int val_36 = this.丕专丗万上丁世丝丁 + (this.丕专丗万上丁世丝丁 << 2);
        val_36 = val_36 << 1;
        val_35.x = val_35.x - (float)val_36;
        val_88 = (float)this.丕专丗万上丁世丝丁;
        val_35.x = val_35.x / val_88;
        this.丒丙丘丟且丈丗且丞 = val_35.x;
        if(this.丄丈丟丙不世与丅丈 <= this.gamesInfo.Count)
        {
            goto label_51;
        }
        
        CustomPanelConnectScene val_38 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_89 = 1;
        goto label_56;
        label_78:
        CustomPanelConnectScene val_39 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.GameObject val_40 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_39.gameInfoItemPrefab);
        val_17 = this.gamesInfo.Count;
        string val_42 = "GameInfo_" + val_17;
        if(val_40 != null)
        {
                val_40.name = val_42;
        }
        else
        {
                0.name = val_42;
        }
        
        CustomPanelConnectScene val_44 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_40.transform.SetParent(parent:  val_44.gridGamesTransform, worldPositionStays:  false);
        GameInfo val_45 = val_40.GetComponent<GameInfo>();
        val_84 = val_45.mapTexture;
        UnityEngine.Vector2 val_46 = val_84.localSize;
        val_46.x = this.丒丙丘丟且丈丗且丞 / val_46.x;
        this.丐与丒丐七丙丌三不 = val_46.x;
        UnityEngine.Vector2 val_47 = val_45.mapTexture.localSize;
        float val_79 = this.丐与丒丐七丙丌三不;
        val_79 = val_47.y * val_79;
        this.丏丝丕丈丑丙丄丁业 = val_79;
        val_88 = 0f;
        val_40.transform.GetChild(index:  0).localScale = new UnityEngine.Vector3() {x = 0f, y = val_88, z = 0f};
        this.gamesInfo.Add(item:  val_40);
        CustomPanelConnectScene val_50 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_89 = 0;
        label_56:
        val_50.gameInfoItemPrefab.SetActive(value:  false);
        label_51:
        if(this.丄丈丟丙不世与丅丈 > this.gamesInfo.Count)
        {
            goto label_78;
        }
        
        CustomPanelConnectScene val_52 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_52.gameInfoItemPrefab.activeSelf != false)
        {
                CustomPanelConnectScene val_54 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_54.gameInfoItemPrefab.SetActive(value:  false);
        }
        
        CustomPanelConnectScene val_55 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_87 = public UIGrid UnityEngine.Component::GetComponent<UIGrid>();
        if((val_55.gridGames.GetComponent<UIGrid>()) != null)
        {
                val_56.cellWidth = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
            float val_80 = this.丏丝丕丈丑丙丄丁业;
            val_88 = this.七与丌三丙丈丅丕丕;
            val_80 = val_80 + val_88;
            val_56.cellHeight = val_80;
            val_90 = this.丕专丗万上丁世丝丁;
        }
        else
        {
                mem[40] = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
            val_56.cellHeight = this.丏丝丕丈丑丙丄丁业 + this.七与丌三丙丈丅丕丕;
            val_90 = this.丕专丗万上丁世丝丁;
        }
        
        val_56.maxPerLine = val_90;
        label_45:
        CustomPanelConnectScene val_60 = CustomPanelConnectScene.丑七不且上丗丁一世();
        CustomPanelConnectScene val_61 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_63 = val_61.scrollGames.GetComponent<UIPanel>().GetViewSize();
        CustomPanelConnectScene val_64 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_92 = val_64.gridGames;
        val_93 = val_88 + val_88;
        if(val_93 >= 0)
        {
                if(this.上丐丐丆丝丕丟一丁 == true)
        {
            goto label_104;
        }
        
        }
        
        CustomPanelConnectScene val_65 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_84 = this.丕专丗万上丁世丝丁;
        CustomPanelConnectScene val_67 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_69 = val_67.gridGames.transform.localPosition;
        val_93 = val_69.y;
        CustomPanelConnectScene val_70 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_72 = val_70.gridGames.transform.localPosition;
        float val_81 = (float)val_84;
        val_81 = val_81 * 0.5f;
        float val_73 = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
        val_81 = val_81 + (-0.5f);
        val_73 = -(val_73 * val_81);
        val_65.gridGames.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        CustomPanelConnectScene val_74 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_92 = val_74.scrollGames;
        val_92.ResetPosition();
        this.上丐丐丆丝丕丟一丁 = true;
        label_104:
        if(this.丄丈丟丙不世与丅丈 < 1)
        {
                return;
        }
        
        val_84 = 1152921525804669568;
        do
        {
            丈丒世与万丘丈三专 val_77 = val_1.Item[0];
            this.丂专丂丒下三丈东专(专专丂丝且万丂不世:  this.gamesInfo.Item[0].GetComponent<GameInfo>(), 世东丈丙丘下丝丌三:  new 丈丒世与万丘丈三专() {丞丁丑丏丄丏七丂不 = val_3, 丙丕丁七丟丈丛丈专 = val_3, 丞与一东丈世且丐丕 = val_3, 丐丆丐七一上专三丑 = val_15, 与且世三丙丈一丈万 = val_15, 丒七世丈丌丑丏丄丏 = val_15, 丁与丈业专三丐丞丒 = val_18});
            val_92 = 0 + 1;
        }
        while(val_92 < this.丄丈丟丙不世与丅丈);
    
    }
    public void JoinToLocalRoom(LANBroadcastService.丈丒世与万丘丈三专 世东丈丙丘下丝丌三)
    {
        var val_8;
        var val_9;
        WeaponManager val_10;
        var val_11;
        var val_12;
        string val_13;
        var val_14;
        FilterMaps val_15;
        if(世东丈丙丘下丝丌三.丙丕丁七丟丈丛丈专 == 世东丈丙丘下丝丌三.丞与一东丈世且丐丕)
        {
                CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_1.gameIsfullLabel.timer = 3f;
            CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_2.gameIsfullLabel.gameObject.SetActive(value:  true);
            CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
            return;
        }
        
        val_8 = null;
        val_8 = null;
        与丂丏丛丞丞丒丟丄.丟三万丆万且三业下 = 世东丈丙丘下丝丌三.丐丅丐丐丌丅丒丛一;
        UnityEngine.PlayerPrefs.SetString(key:  "MaxKill", value:  世东丈丙丘下丝丌三.丐丆丐七一上专三丑);
        UnityEngine.PlayerPrefs.SetString(key:  "MapName", value:  世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不);
        val_9 = null;
        val_9 = null;
        val_10 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_10 == 0)
        {
            goto label_16;
        }
        
        val_11 = null;
        val_11 = null;
        val_12 = null;
        val_10 = WeaponManager.丟丗丄业丘丗业丗七;
        val_12 = null;
        val_13 = 世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不;
        if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不)) == false)
        {
            goto label_22;
        }
        
        val_14 = null;
        val_14 = null;
        val_13 = 世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不;
        val_15 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不];
        if(val_10 != null)
        {
            goto label_28;
        }
        
        goto label_27;
        label_22:
        val_15 = 0;
        if(val_10 != null)
        {
            goto label_28;
        }
        
        label_27:
        label_28:
        val_10.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  val_15);
        label_16:
        this.丅丟丘专丞丁丄丌丗(丛丘七丂且丟丁一丙:  世东丈丙丘下丝丌三.丞丁丑丏丄丏七丂不, 丑一丈丐专丑且丞丅:  false);
        this.Invoke(methodName:  "goGame", time:  0.1f);
    }
    public void JoinToRoomPhoton(丞丘丒一上与丕丒且 世东丈丙丘下丝丌三)
    {
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_39 = null;
        val_39 = null;
        if(ConnectScene.一七丁三丄专下且丂 == null)
        {
            goto label_3;
        }
        
        if(世东丈丙丘下丝丌三 == null)
        {
            goto label_4;
        }
        
        val_40 = 世东丈丙丘下丝丌三.三不万不丕丑一上与();
        goto label_5;
        label_3:
        CustomPanelConnectScene.丑七不且上丗丁一世().JoinToRoomPhoton(世东丈丙丘下丝丌三:  世东丈丙丘下丝丌三);
        return;
        label_4:
        val_40 = 0.三不万不丕丑一上与();
        label_5:
        if(val_40 == 世东丈丙丘下丝丌三.丄丁丗丞丏丞世丕业())
        {
                CustomPanelConnectScene val_5 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_5.gameIsfullLabel.timer = 3f;
            CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_6.gameIsfullLabel.gameObject.SetActive(value:  true);
            CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
            return;
        }
        
        this.一世东丄丗丆丘丛丂 = 世东丈丙丘下丝丌三;
        if((ConnectScene.丌丌一丅丂丐不丆丛(东七上世万下丗丄丛:  世东丈丙丘下丝丌三)) == false)
        {
            goto label_20;
        }
        
        val_41 = null;
        val_41 = null;
        object val_11 = this.一世东丄丗丆丘丛丂.丂丂丁丕专丂丏与丌().Item[GameConnect.不丕丂三丙与丈且三];
        UnityEngine.Debug.LogError(message:  val_11);
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_12 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丝与业丘丌业丄东万(丏丛与丅丛丌万专丌:  val_11);
        val_42 = 0;
        goto label_30;
        label_38:
        UnityEngine.Debug.LogError(message:  val_12.Item[0].丆丂丙丞一丛丞丄丘() + " is icon, description: "(" is icon, description: ") + val_12.Item[0].东且丏丆万与东丙万());
        val_42 = 1;
        label_30:
        if(val_42 < val_12.Count)
        {
            goto label_38;
        }
        
        label_20:
        val_43 = null;
        val_43 = null;
        if((System.String.Equals(a:  世东丈丙丘下丝丌三.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七], b:  GameConnect.丂万且丟丛丈与丞丏)) != false)
        {
                this.JoinToRoomPhotonAfterCheck();
            return;
        }
        
        CustomPanelConnectScene val_22 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_22.gameIsfullLabel.timer = -1f;
        CustomPanelConnectScene val_23 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_23.gameIsfullLabel.gameObject.SetActive(value:  false);
        CustomPanelConnectScene val_25 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_25.enterPasswordInput.value = System.String.alignConst;
        CustomPanelConnectScene val_26 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_26.enterPasswordCustomInput.value = System.String.alignConst;
        if((ConnectScene.丌丌一丅丂丐不丆丛(东七上世万下丗丄丛:  世东丈丙丘下丝丌三)) == false)
        {
            goto label_58;
        }
        
        CustomPanelConnectScene val_28 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_28.enterPasswordCustomPanel.SetActive(value:  true);
        CustomPanelConnectScene val_29 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_29.enterPasswordPanel.SetActive(value:  false);
        CustomPanelConnectScene val_30 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_30.enterPasswordCustomPanel.GetComponent<JoinPrivateGameInfoWindow>().ReadRoomNextFrame(东七上世万下丗丄丛:  世东丈丙丘下丝丌三);
        CustomPanelConnectScene val_32 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_32.enterPasswordCustomInput.isSelected = false;
        CustomPanelConnectScene val_33 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_33.enterPasswordCustomInput != null)
        {
            goto label_85;
        }
        
        label_86:
        label_85:
        val_33.enterPasswordCustomInput.isSelected = true;
        CustomPanelConnectScene val_34 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_34.customPanel.SetActive(value:  false);
        return;
        label_58:
        CustomPanelConnectScene val_35 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_35.enterPasswordPanel.SetActive(value:  true);
        CustomPanelConnectScene val_36 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_36.enterPasswordCustomPanel.SetActive(value:  false);
        CustomPanelConnectScene val_37 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_37.enterPasswordInput.isSelected = false;
        CustomPanelConnectScene val_38 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_38.enterPasswordInput != null)
        {
            goto label_85;
        }
        
        goto label_86;
    }
    internal static bool 丌丌一丅丂丐不丆丛(丞丘丒一上与丕丒且 东七上世万下丗丄丛)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = 东七上世万下丗丄丛;
        val_6 = null;
        val_6 = null;
        if(val_5.丂丂丁丕专丂丏与丌().Item[GameConnect.不丕丂三丙与丈且三] != null)
        {
                val_7 = null;
            val_5 = val_5.丂丂丁丕专丂丏与丌();
            val_7 = null;
            if(val_5.Item[GameConnect.不丕丂三丙与丈且三] != "")
        {
                val_8 = 1;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    private void 丐丛丈丅丌一丌丑丝()
    {
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.enterPasswordInput.RemoveFocus();
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_2.enterPasswordInput.isSelected = false;
        this.Invoke(methodName:  "EnterPassInput", time:  0.1f);
    }
    private void EnterPassInput()
    {
        this.HandleJoinRoomFromEnterPasswordBtnClicked(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    public void JoinToRoomPhotonAfterCheck()
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        this.丅丟丘专丞丁丄丌丗(丛丘七丂且丟丁一丙:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  this.一世东丄丗丆丘丛丂.丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆])).丙且上丒不下丑下丞(), 丑一丈丐专丑且丞丅:  false);
        this.loadingMapPanel.SetActive(value:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  2849");
        bool val_7 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  this.一世东丄丗丆丘丛丂.丙丆丌丝丛丏丝丕业());
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
    }
    private void 丕丛丟丅丂东业丆丆()
    {
        var val_3;
        var val_4;
        if(GameConnect.丑丌丛丈丅丅与不业() == 35)
        {
                val_3 = 0;
        }
        else
        {
                val_4 = null;
            val_4 = null;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.customButtonsContainer, 丏业丟一东丂东丘丛:  (ConnectScene.丙东丁丂丝世丑丒丘 != 34) ? 1 : 0);
        if(S8 >= 0)
        {
                return;
        }
        
        this.connectSceneSelectMapTransform.localPosition = new UnityEngine.Vector3() {x = this.丙一不且丑丆丆丂丆, y = V8.16B, z = V9.16B};
    }
    private void 上一丝三丗且丆下丟()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectSceneSelectMap.customButtonsContainer, 丏业丟一东丂东丘丛:  false);
        UnityEngine.Vector3 val_1 = this.connectSceneSelectMapTransform.localPosition;
        this.丙一不且丑丆丆丂丆 = val_1;
        mem[1152921525811174572] = val_1.y;
        mem[1152921525811174576] = val_1.z;
        this.connectSceneSelectMapTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return;
        }
        
        this = this.connectSceneSelectMapTransform;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void goGame()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_4 = null;
        val_4 = null;
        GameConnect.七七丈东丅上丝丒万 = true;
        val_5 = null;
        val_5 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = false;
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  UnityEngine.PlayerPrefs.GetString(key:  "MapName"));
    }
    private void OnDestroy()
    {
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        UnityEngine.Debug.Log(message:  "OnDestroy ConnectSceneController");
        PGCompany.丙丕丏丁世丆丘丒丌.丄丐丕丞丑丞下丕专();
        if((PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 != 0) && (PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丈丄不丞丝丌上丄丐() != 0))
        {
                val_18 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丈丄不丞丝丌上丄丐().gameObject.activeSelf;
        }
        else
        {
                val_18 = 0;
        }
        
        if(this.gameObject.activeSelf == false)
        {
            goto label_27;
        }
        
        val_19 = null;
        val_19 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_24;
        }
        
        if(((val_18 == 0) && (this.七丘丝丆丏丘丗丏丄 != true)) && (this.丈丝丛东且丁丝且三 != true))
        {
                if(丅丒丗丑丒丙丛不丆.专东世丞丂丐丂丈丁() == 2)
        {
            goto label_24;
        }
        
        }
        
        if(丅丒丗丑丒丙丛不丆.专东世丞丂丐丂丈丁() != 1)
        {
            goto label_27;
        }
        
        label_24:
        GameConnect.下与业丒丝丕丙丘丙();
        UnityEngine.Debug.Log(message:  "PhotonNetwork.Disconnect()");
        label_27:
        val_20 = null;
        val_20 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_21 = null;
            val_21 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        this.lanScan.StopBroadCasting();
        val_22 = null;
        val_22 = null;
        ConnectScene.丄丞丁丈与业上丞丟 = 0;
        val_23 = null;
        val_23 = null;
        val_24 = System.Delegate.Remove(source:  MapVoteController.丛丆丂丐丛不不丟万 + 64, value:  new System.Action(object:  this, method:  System.Void ConnectScene::丞丑丐丐丁丑业丕丞()));
        if(MapVoteController.丛丆丂丐丛不不丟万 == 0)
        {
            goto label_46;
        }
        
        if(val_24 != null)
        {
            goto label_47;
        }
        
        goto label_50;
        label_46:
        if(val_24 == null)
        {
            goto label_50;
        }
        
        label_47:
        if(null != null)
        {
                val_24 = 0;
        }
        
        label_50:
        MapVoteController.丛丆丂丐丛不不丟万.__unknownFiledOffset_40 = val_24;
        val_25 = 0;
        goto label_58;
        label_65:
        T val_16 = this.GetComponentsInChildren<System.IDisposable>(includeInactive:  true)[0];
        var val_19 = val_16;
        if((val_15[0x0][0] + 286) == 0)
        {
            goto label_57;
        }
        
        var val_17 = val_15[0x0][0] + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_56:
        if(((val_15[0x0][0] + 176 + 8) + -8) == null)
        {
            goto label_55;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (val_15[0x0][0] + 286))
        {
            goto label_56;
        }
        
        goto label_57;
        label_55:
        val_19 = val_19 + (((val_15[0x0][0] + 176 + 8)) << 4);
        val_26 = val_19 + 296;
        label_57:
        val_16.Dispose();
        val_25 = 1;
        label_58:
        if(val_25 < val_15.Length)
        {
            goto label_65;
        }
    
    }
    public void HandleShopClicked()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  0, 一专七丟丏且丑丄下:  0, 丝丗丙丞丙丕万业下:  0, 万且丟七不上丗丑丝:  false);
    }
    internal void 一丏丞丘专丘业丈丑(FilterMaps 丝丗丙丞丙丕万业下, 丙且上东下丏丏丟下 与丝丕与丙不与丗丆, CategoryNames 一专七丟丏且丑丄下, bool 丄丕三丞一丌与与丅 = False)
    {
        var val_2 = null;
        MainMenuController.丄丞丁丈与业上丞丟.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  与丝丕与丙不与丗丆, 一专七丟丏且丑丄下:  (一专七丟丏且丑丄下 == 1) ? 0 : 一专七丟丏且丑丄下, 丝丗丙丞丙丕万业下:  丝丗丙丞丙丕万业下, 万且丟七不上丗丑丝:  false);
    }
    public void HandleResumeFromShop()
    {
        var val_3;
        var val_5;
        var val_6;
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        val_3 = null;
        val_3 = null;
        if((ConnectScene.<>c.<>9__334_0) == null)
        {
            goto label_5;
        }
        
        label_18:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = ConnectScene.<>c.<>9__334_0;
        val_5 = null;
        val_5 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        return;
        label_5:
        ConnectScene.<>c.<>9__334_0 = new System.Action(object:  ConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectScene.<>c::七上丟丕东丏丘且且());
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }
    private void 不丝下丗业丘丝下丄()
    {
        if(this.connectSceneMainMenu.丗丛专七丈一下一丟 != 0)
        {
                return;
        }
        
        this = PGCompany.PixelPass.丁且七丅丞丐丌丌世.丒丒一丕世丟三丂丌<PGCompany.PixelPass.PixelPassTasksInConnectSceneUI>(丄三下丙下世丅丘丙:  this.connectSceneMainMenu.pixelPassHolder, 丟丈一下东业一丝丆:  "PixelPassTasksInConnectScene");
        this.connectSceneMainMenu.丗丛专七丈一下一丟 = this;
    }
    private void 丞丕丅业东丒丐丝万()
    {
        UnityEngine.GameObject val_22;
        UnityEngine.GameObject val_23;
        UnityEngine.Object val_24;
        val_22 = this;
        if(this.connectSceneMainMenu.battlePassHolder == 0)
        {
                return;
        }
        
        if(this.connectSceneMainMenu.battlePassHolder.childCount >= 1)
        {
                val_23 = this.connectSceneMainMenu.battlePassHolder.GetChild(index:  0).gameObject;
            val_24 = val_23.GetComponent<PGCompany.BattlePass.BattlePassConnectScene>();
            if(val_24 != 0)
        {
                PGCompany.BattlePass.上丕丁专三丗丝万丆 val_8 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_8 != null)
        {
                if((System.String.op_Inequality(a:  val_8.丕世丝七世与三丞一(), b:  val_24.BpGuiType)) == false)
        {
            goto label_21;
        }
        
        }
        
        }
        
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_23);
        }
        else
        {
                val_24 = 0;
        }
        
        label_21:
        if(val_24 != 0)
        {
                return;
        }
        
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
        {
                return;
        }
        
        string val_15 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPConnectScene");
        if(val_15 == null)
        {
                return;
        }
        
        UnityEngine.GameObject val_16 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_15);
        if(val_16 == 0)
        {
                return;
        }
        
        val_16.SetActive(value:  false);
        int val_18 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        val_23 = 1152921505284374528;
        val_22 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_16, 丈东丘丏与丌东东下:  this.connectSceneMainMenu.battlePassHolder, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        val_16.SetActive(value:  true);
        PGCompany.BattlePass.BattlePassConnectScene val_20 = val_22.GetComponent<PGCompany.BattlePass.BattlePassConnectScene>();
        if(val_20 != 0)
        {
                val_20.丞下丅不且不业丈丕(丙业与丙丗丝不丈东:  0);
            val_22.SetActive(value:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_22);
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectScenePanelEventHint.gameObject, 丏业丟一东丂东丘丛:  (this.与丘丏丆丁世世丁丗 == true) ? 1 : 0);
        MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    private void 与丒丒丏七不丞丐丄()
    {
        var val_13;
        var val_14;
        var val_15;
        if((Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙()) != false)
        {
                val_13 = null;
            val_13 = null;
            SeasonEndView.丌万丗与七丄丕不丁(丕专上丁丅丅丏万丌:  transform, 丛丝与丂世丌丌丝丂:  0, 丗七丟丈三不丕一三:  Rilisoft.Singleton<TournamentController>.Instance.丄万丐丑丌三丆丝丑());
            return;
        }
        
        if(TournamentController.丌万丘丙万世丗丈丏() != false)
        {
                val_14 = TournamentController.丅业东万丌丕上丌丄();
        }
        else
        {
                val_14 = 0;
        }
        
        val_15 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        bool val_10 = val_14 & (~(val_15.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  78)));
        val_10 = val_10 + 15;
        val_10 = val_10 & 15;
        if(val_10 == true)
        {
                return;
        }
        
        val_15 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_15.ForceShowBanner(丌丅丕一丛丛丄一万:  101, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    internal static bool 东世三丆东世丈丟不()
    {
        var val_3;
        ConnectScene val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = ConnectScene.丄丞丁丈与业上丞丟;
        if(val_4 != 0)
        {
                val_5 = null;
            val_5 = null;
            val_4 = ConnectScene.丄丞丁丈与业上丞丟;
            var val_2 = (ConnectScene.丄丞丁丈与业上丞丟.丂与丛上不丑东丒丘 > 0f) ? 1 : 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
    {
        return System.Globalization.CultureInfo.InvariantCulture;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    internal static void 与三丘丒一专丛丈丐(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        ConnectScene.丄丟不丌丑下世与丄 = 丙业与丙丗丝不丈东;
    }
    private static bool 丏丆丝专丄丝丏丝世()
    {
        null = null;
        ConnectScene.丄丟不丌丑下世与丄 = false;
        return (bool)ConnectScene.丄丟不丌丑下世与丄;
    }
    private void 丘丒丂丘丄丒世丏三()
    {
        string val_20;
        var val_21;
        var val_22;
        var val_23;
        string val_24;
        string val_25;
        var val_26;
        this.下七东东丁丅丗丂丏();
        if(PGCompany.丑丝万下上丌七不一.丑七不且上丗丁一世().丈业不丁丛丕丒丕下() == false)
        {
            goto label_4;
        }
        
        val_20 = "Was disconnected";
        goto label_41;
        label_4:
        val_21 = null;
        val_21 = null;
        if(ConnectScene.专七下丑丈三上下丞 == false)
        {
            goto label_8;
        }
        
        val_20 = "NeedShowReviewInConnectScene";
        goto label_41;
        label_8:
        if(PGCompany.丙丕丏丁世丆丘丒丌.下丒丂丒丗三不且世() == false)
        {
            goto label_10;
        }
        
        val_20 = "InterstitialSuppressed";
        label_41:
        label_40:
        val_22 = null;
        if(ConnectScene.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_20)) != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "[ConnectScene.ShowInterstitial] dismissReason: "("[ConnectScene.ShowInterstitial] dismissReason: ") + val_20);
        return;
        label_10:
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
            goto label_40;
        }
        
        val_23 = null;
        if(ConnectScene.丐丏且世丁丗业一丗() != false)
        {
                val_24 = ConnectScene.下丁丝业一丗丏丟丅();
        }
        else
        {
                val_24 = "Replace interstitial request not performed.";
        }
        
        val_25 = val_24;
        if((System.String.IsNullOrEmpty(value:  val_25)) == false)
        {
            goto label_24;
        }
        
        ConnectScene.东下丑丁丌丁丂丐上(丙业与丙丗丝不丈东:  false);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.丄一丕一七丆丑丗丛(与且专丈不万东一万:  "Connect Scene", 业丛丕丐丏世丞丈且:  false));
        goto label_41;
        label_24:
        if(ConnectScene.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[ConnectScene.ShowInterstitial] reasonToDismissFakeInterstitial: "("[ConnectScene.ShowInterstitial] reasonToDismissFakeInterstitial: ") + val_24);
        }
        
        val_26 = null;
        if(ConnectScene.丏丆丝专丄丝丏丝世() == false)
        {
            goto label_41;
        }
        
        if((System.String.IsNullOrEmpty(value:  ConnectScene.上丆丅与七一且丒丕())) == false)
        {
            goto label_40;
        }
        
        this.isStartShowAdvert = true;
        if(this.不专且丕丘丝丗丄与 != null)
        {
                this.StopCoroutine(routine:  this.不专且丕丘丝丗丄与);
        }
        
        this.不专且丕丘丝丗丄与 = this.StartCoroutine(routine:  this.丝丅与丝丂丕丄丗丑());
        goto label_40;
    }
    private System.Collections.IEnumerator 丝丅与丝丂丕丄丗丑()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ConnectScene.世东丐与且下下丟丙(丗丏丅丕丆世丁专丟:  0);
    }
    private void 下与丞三丅丛丄七丕(string 三七一丁上且丐丝丌)
    {
        var val_5;
        string val_6;
        ConnectScene.丏不丝世丛丗丂丟且 val_1 = new ConnectScene.丏不丝世丛丗丂丟且();
        if(val_1 != null)
        {
                val_5 = val_1;
            .万丕三丗下丗世丒丒 = 0;
            val_6 = 1152921525814221104;
            mem[1152921525814221112] = 三七一丁上且丐丝丌;
            mem[1152921525814221120] = this;
        }
        else
        {
                val_6 = 24;
            mem[24] = 三七一丁上且丐丝丌;
            mem[32] = this;
            val_5 = 16;
            mem[16] = 0;
        }
        
        .一业丁丘丏丙丐丕丄 = 0;
        System.Action val_2 = new System.Action(object:  val_1, method:  System.Void ConnectScene.丏不丝世丛丗丂丟且::丆且丒丗丈丞丈丘且());
        mem[16] = val_2;
        System.Action val_3 = new System.Action(object:  val_1, method:  System.Void ConnectScene.丏不丝世丛丗丂丟且::且业专丛丆丐丛丁一());
        if(val_1 != null)
        {
                .一业丁丘丏丙丐丕丄 = val_3;
            IronSourceEvents.add_onInterstitialAdClosedEvent(丙业与丙丗丝不丈东:  val_2);
        }
        else
        {
                .一业丁丘丏丙丐丕丄 = val_3;
            IronSourceEvents.add_onInterstitialAdClosedEvent(丙业与丙丗丝不丈东:  val_2);
        }
        
        IronSourceEvents.add_onInterstitialAdOpenedEvent(丙业与丙丗丝不丈东:  (ConnectScene.丏不丝世丛丗丂丟且)[1152921525814221088].一业丁丘丏丙丐丕丄);
        PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().不专丕专万丐丟丞丛(三七一丁上且丐丝丌:  val_6);
    }
    private System.Collections.IEnumerator 丝丝丟丟东丏丞丙丂()
    {
        return (System.Collections.IEnumerator)new ConnectScene.丙丂万丘丈丐丒丒丌(丗丏丅丕丆世丁专丟:  0);
    }
    internal static bool 丕业不业不丛丛丒丙(out string 丁丂丕与丁丒丕丟丞)
    {
        string val_23;
        var val_24;
        var val_25;
        double val_26;
        string val_6 = 0;
        PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_5 = 0;
        万丞丘丏丆丆丝与与.一专丕丆东丝上丐丞 val_14 = 0;
        上丒上丛业丕东世七 val_7 = 0;
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
            goto label_2;
        }
        
        val_23 = "IsRunningTutor";
        goto label_48;
        label_2:
        if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
        {
            goto label_6;
        }
        
        val_24 = 1152921505426546688;
        if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().下丅专丘且丘一丛七(上世丏丁世丟世丆业: out  val_5, 七丆丒与丗丌丄且丂: out  val_6, 丟丐丗万丅下丗丝万: out  val_7, 丏丞专丏业丗丝七丝: out  string val_8 = 丁丂丕与丁丒丕丟丞)) == false)
        {
                return true;
        }
        
        val_24 = 0;
        if((Rilisoft.万丅丐丄丑万东不丑.丕业不业不丛丛丒丙(丟丐丗万丅下丗丝万:  val_7, 丑专丛丅丞下丄丈丞:  new System.DateTime(), 丁丂丕与丁丒丕丟丞: out  val_8)) == true)
        {
                return true;
        }
        
        val_24 = val_7;
        if(ExperienceController.丞丞丘业东丙丏七丌() >= (val_24 + 40.丙东专丂世丈丏丁丂()))
        {
            goto label_17;
        }
        
        val_23 = "CurrentLevel";
        goto label_48;
        label_6:
        val_23 = "TryGetServerUniversalTime";
        label_48:
        丁丂丕与丁丒丕丟丞 = val_23;
        return true;
        label_17:
        if(((PGCompany.DataObjects.三丛丂丟与不专丛丏.丝东丈专丞丛丑万丗(上世丏丁世丟世丆业:  val_5, 七丆丒与丗丌丄且丂:  val_6, 丅专与丒丈丗丒丘丌:  "ReturnInConnectScene", 丌东丙丝丂一丅三丞: out  val_14)) == false) || ((PGCompany.DataObjects.丄丂七下东丝东丛上.丐丅且丗东丘上与丏(丌东丙丝丂一丅三丞:  val_14)) == false))
        {
            goto label_48;
        }
        
        if(((-267232568) & 1) != 0)
        {
                int val_19 = 0.丙东专丂世丈丏丁丂();
        }
        else
        {
                val_25 = 2147483647;
        }
        
        if((上七丄丆一与东丅丝.丑七不且上丗丁一世().一丝万丏丌丂上丂丞(丅丏丅丂丝一丆丙丅:  new System.DateTime())) >= val_25)
        {
            goto label_48;
        }
        
        System.TimeSpan val_21 = Rilisoft.InGameTimeKeeper.丑七不且上丗丁一世().东一丂一丘与世下不();
        if(((-267232584) & 1) != 0)
        {
                val_26 = (double)0.x;
        }
        else
        {
                val_26 = -2147483648;
        }
        
        if(val_21._ticks.TotalMinutes >= 0)
        {
            goto label_45;
        }
        
        goto label_48;
        label_45:
        丁丂丕与丁丒丕丟丞 = 0;
        return true;
    }
    internal static string 上丆丅与七一且丒丕()
    {
        string val_1 = 0;
        bool val_2 = ConnectScene.丕业不业不丛丛丒丙(丁丂丕与丁丒丕丟丞: out  val_1);
        return val_1;
    }
    public ConnectScene()
    {
        this.七丄丁丘丝丑三世专 = new System.Collections.Generic.List<丝与一东丄三东丁上>();
        this.gamesInfo = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.丑丐丅丟下丞三丛且 = new System.Collections.Generic.List<丞丘丒一上与丕丒且>();
        this.上丞且不七丙万万丘 = 5;
        this.上丁丈丛丌上不丟与 = 0;
        this.七一丟丆丟丞专丆东 = 5;
        this.丗丌上丁且专丈上世 = 0;
        this.一丁丈丗丄丛丑丗业 = 5;
        this.东丅丒丛丏丄丒丞专 = "";
        this.上丒一万世丐丝丏丞 = new Rilisoft.七丕丟丏三丈一丄世[17];
        this.下丒丏丙一不七丕丏 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture>();
        this.丂丝丕三东丏三且下 = System.String.alignConst;
        this.丂丁七丙下丞丗丁业 = new System.Collections.Generic.Dictionary<System.Int32, MapPreviewController>();
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.丟上丐三丌丗丏丕三 = 0;
        this.丏丘丞丆与丕三丝丘 = val_7;
        mem[1152921525814754160] = val_7.y;
        mem[1152921525814754164] = val_7.z;
        this.丄丈丟丙不世与丅丈 = 1;
        this.业且丄丟世且丄世下 = System.String.alignConst;
        this.业不专丛世丄与上丒 = new System.Collections.Generic.List<业丂丌丞丆东丏世万>();
        this.丂丗丙丆丕丁丛业丐 = new System.Collections.Generic.List<业丂丌丞丆东丏世万>();
        this.丕专丗万上丁世丝丁 = 3;
        this.一下丏一丅丝丂上不 = new System.Collections.Generic.List<SceneInfo>();
        mem2[0] = ;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  10000f);
        this.丙一不且丑丆丆丂丆 = val_12;
        mem[1152921525814754348] = val_12.y;
        mem[1152921525814754352] = val_12.z;
    }
    private static ConnectScene()
    {
        ConnectScene.一七丁三丄专下且丂 = 0;
        ConnectScene.丑业业业丒丏丈丞下 = System.String.alignConst;
        ConnectScene.丁丝丒丕丘不丁丁丂 = false;
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, Progress.不专丂万丐丄七上丗> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, Progress.不专丂万丐丄七上丗>();
        if(val_1 != null)
        {
                val_1.Add(key:  0, value:  7);
            val_1.Add(key:  1, value:  8);
            val_1.Add(key:  2, value:  9);
            val_1.Add(key:  3, value:  10);
            val_1.Add(key:  24, value:  29);
            val_1.Add(key:  4, value:  11);
            val_1.Add(key:  5, value:  12);
            val_1.Add(key:  8, value:  13);
            val_1.Add(key:  16, value:  14);
            val_1.Add(key:  17, value:  15);
            val_1.Add(key:  20, value:  16);
            val_1.Add(key:  22, value:  30);
            val_1.Add(key:  31, value:  69);
            val_1.Add(key:  32, value:  76);
            val_1.Add(key:  33, value:  77);
            val_1.Add(key:  34, value:  80);
            val_1.Add(key:  35, value:  81);
        }
        else
        {
                val_1.Add(key:  0, value:  7);
            val_1.Add(key:  1, value:  8);
            val_1.Add(key:  2, value:  9);
            val_1.Add(key:  3, value:  10);
            val_1.Add(key:  24, value:  29);
            val_1.Add(key:  4, value:  11);
            val_1.Add(key:  5, value:  12);
            val_1.Add(key:  8, value:  13);
            val_1.Add(key:  16, value:  14);
            val_1.Add(key:  17, value:  15);
            val_1.Add(key:  20, value:  16);
            val_1.Add(key:  22, value:  30);
            val_1.Add(key:  31, value:  69);
            val_1.Add(key:  32, value:  76);
            val_1.Add(key:  33, value:  77);
            val_1.Add(key:  34, value:  80);
            val_1.Add(key:  35, value:  81);
        }
        
        val_1.Add(key:  36, value:  83);
        ConnectScene.业丌丐且七丘东上丗 = val_1;
        ConnectScene.专七下丑丈三上下丞 = false;
        ConnectScene.丛丆丑三丞丏一丆丆 = false;
        ConnectScene.丝上丅丒丂与与不丁 = false;
    }
    private void 三东专下丌丈丐世与()
    {
        this.丆丑丑丆丗丗且丛丑(丟丟东丏世三一三丟:  false);
    }
    private void 专丘丙丘丒不上下丞()
    {
        this.丕丕三丝丈丙丗万万(丟丟东丏世三一三丟:  true);
    }
    private void 丕丕三丝丈丙丗万万(bool 丟丟东丏世三一三丟)
    {
        var val_4;
        ConnectScene.丆一专丕丌且东丒世 val_1 = new ConnectScene.丆一专丕丌且东丒世();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        .丟丟东丏世三一三丟 = 丟丟东丏世三一三丟;
        val_4 = null;
        val_4 = null;
        GameConnect.丛丑世丕丌上丑丂丈 = true;
        this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void ConnectScene.丆一专丕丌且东丒世::专上丑丕专世丄丅丛()), 丟丌丘世丟丛下万东:  true, 世丁丒丞丁丕一丟万:  false, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    private void 东丕丗丏丞丘丆丑不()
    {
        this.下丐丅丑丘专丑丈丑();
    }
    private void 且丒丏下丙万丛与丅()
    {
        this.丆丑丑丆丗丗且丛丑(丟丟东丏世三一三丟:  false);
    }
    private void 丆丞丒丞三丏丒东丌()
    {
        this.丆丑丑丆丗丗且丛丑(丟丟东丏世三一三丟:  true);
    }
    private void 丏一三东丆丌丛丛三()
    {
        this.丆丑丑丆丗丗且丛丑(丟丟东丏世三一三丟:  true);
        this.丑丌丙丙丞丗丙七丂();
    }
    private void 东丏丛丞丒一且丑丕()
    {
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                if(BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() != false)
        {
                BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
            return;
        }
        
        }
        
        this.丝东丐丝东三丈世丝(东丄丛丝三丛丘丟丑:  false);
    }
    internal static bool 与专丁丅丟丆丙丑丟(string 东丒丝不上丛丒丌丄, out string 丄丙下丝丛丒七丂丘)
    {
        丄丙下丝丛丒七丂丘 = 东丒丝不上丛丒丌丄;
        return true;
    }

}
