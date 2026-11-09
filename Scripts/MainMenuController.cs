using UnityEngine;
internal sealed class MainMenuController : ControlsSettingsBase
{
    // Fields
    private static System.Action 丒丑三上丐一丆且丞;
    private static System.Action 丞丒下丄世丂不七丝;
    public ModuleChestsMaxCountReachedUI reachMaxChestCountUI;
    public PGCompany.MainMenuMainPanel mainMenuPanel;
    internal static int 与不丒下丕丐万丗丞;
    internal static System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 丂不三丈丕丑丌业下;
    private static bool <下丌丞丛丆丙丝一东>k__BackingField;
    public TrainingHints trainingHints;
    private static bool <丄丌万丆丒且丅丌且>k__BackingField;
    public UnityEngine.Camera Camera;
    private UnityEngine.GameObject _subwindowsHandler;
    private UnityEngine.GameObject _fortLoadingPanel;
    private float _alfaTweenTime;
    private Rilisoft.PrefabHandler _socialBannerPrefab;
    private Rilisoft.专丕丝丏丒一一万丏<SocialGunBannerView> 不丌世世丗丗下丄丏;
    private Rilisoft.PrefabHandler _userCharactersPrefab;
    private Rilisoft.专丕丝丏丒一一万丏<UserCharacterMainWindow> 丟丙丗七与丆且与丞;
    internal UnityEngine.GameObject 丐丘丒丗丛丁丐业业;
    public UnityEngine.Transform RentExpiredPoint;
    public BottomButtonLobbyPanel lobbyPanel;
    private UnityEngine.Transform 一丁三三丙丟丆丄丄;
    public UnityEngine.GameObject FortSceneStubLoading;
    public UITexture FortSceneStubTexture;
    public UnityEngine.GameObject stubLoading;
    public UITexture stubTexture;
    public MainMenuHeroCamera rotateCamera;
    internal static MainMenuController 丄丞丁丈与业上丞丟;
    internal static bool 丆不丑丆下丞丙不丞;
    internal UnityEngine.GameObject 丈三丂丕不一业丙丄;
    internal UnityEngine.GameObject 丆丌丄七业与与丝丟;
    internal UnityEngine.GameObject 丗万三世丛丌丟丂丒;
    internal UnityEngine.GameObject 丏丕丛丕丅三万丄七;
    public UnityEngine.GameObject mainPanel;
    private UnityEngine.Coroutine 丏丈丅专东三东丏业;
    private UnityEngine.Coroutine 丛七丌不七丐一下七;
    private Rilisoft.ButtonHandler _openFeedBackBtn;
    private Rilisoft.PrefabHandler _feedbackPrefab;
    private Rilisoft.PrefabHandler _newsPrefab;
    public UnreadNewsCounter[] _unreadNewsCounters;
    private Rilisoft.PrefabHandler _newClanVesionPrefab;
    public UnityEngine.GameObject bannerContainer;
    internal UnityEngine.GameObject 丈丈丅丒丗丒且不下;
    public UICamera uiCamera;
    public LobbyMainMenuSounds lobbySoundButton;
    internal static bool 丂丛丗丁丐丗丒丞万;
    private float 丁丛三丁三七丏丙且;
    private bool 丁丆与丘丘丞丐丑一;
    private Rilisoft.AdvertisementController 丙丕丌丒丞丕不上万;
    private ShopNGUIController 三三丒丅丂丝七下丁;
    private bool 上世与丈专世丟丘丘;
    private bool 世丞与丐世丐三丌丅;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丛专一丘丙丞丅丞业;
    private static System.Action 七丕上丕丐丒丕世世;
    private static System.Action<bool> 丑丒丞丘丗丗丑与丁;
    internal static bool 丞且丙丛丞不世专七;
    internal static bool 丞丟丂三丝丆丌丌丗;
    internal UnityEngine.GameObject 丗上丏丟丆专与丗丆;
    internal UnityEngine.GameObject 且专业世七丄丑丏专;
    internal ConnectionControl 丝丆业上世丅丞且丙;
    private ConnectPanel 丒丏丝丛东丁专七丌;
    private Rilisoft.专丕丝丏丒一一万丏<PGCompany.NewsLobbyController> 世专丟丆丙丂丙万丂;
    private Rilisoft.专丕丝丏丒一一万丏<FeedbackMenuController> 丌丐丅一丛丐丕丆一;
    private Rilisoft.专丕丝丏丒一一万丏<ClanSecondVersionBanner> 丏丟丝丘丐丏三世丐;
    internal ConnectionControl 丙不丅丝丙专丕世丐;
    public UnityEngine.GameObject connectScene;
    internal UnityEngine.GameObject 世丆丂上丛丈丅丘东;
    internal UnityEngine.GameObject 万万一丁丆世丄业万;
    internal UnityEngine.GameObject 丘丒丒丅七丅七丒丑;
    public UnityEngine.Transform taskWindowHintPoint;
    private TasksWindow 丐七不丑丗三丈丆专;
    private UnityEngine.Coroutine 不下下丆丐丁丒与丗;
    private UnityEngine.Coroutine 世丁万专丞丗三丌一;
    private UnityEngine.Coroutine 丗且七丂丄丆丌丅三;
    private bool 丘一丅七丕丏丞丂丅;
    private static bool 七七丈丘丏丗丏一丈;
    public SettingsController settingsContoller;
    private readonly System.Collections.Generic.List<System.EventHandler> 世丟丁不世丘丐与丑;
    private bool 万不专丕丒东世三丘;
    private float 丂与丛上不丑东丒丘;
    private static bool 七万丆丘丈丄丂与丒;
    private bool 丑丕丌世丄丒丂三上;
    private bool 丟丑丆万丂丟丗丙丏;
    private bool 丛东丁上丁且丑万丝;
    private bool 七丑丝丕下丘丂丐丐;
    private System.Collections.Generic.Dictionary<string, string> 丞万上丒东一三丝与;
    private System.Collections.Generic.Dictionary<string, string> 丐丘丆丐不丙丟丌上;
    private System.Collections.Generic.List<string> 丏丒丒丄丆与下丄专;
    private System.Collections.Generic.HashSet<string> 丞且与丄丂丂上丕丘;
    private const string 丙上丐七丙业一一丁 = "ShowedLightHintsKey";
    private string 丌丛不丄与丈三丕丞;
    private string 丙下丘丕丂丛与丙丄;
    private bool 丟三丘东丘不上七丑;
    private static bool 丝丈丙下且不丈下业;
    private int 丁世专不东丌丛且丘;
    private bool <丅丑丕丈上丑下丈丈>k__BackingField;
    private bool <丕丙丐丆丝丈三七丆>k__BackingField;
    internal static bool 业万且与丘与与三丕;
    internal static bool 业丌专丒丛三不业且;
    internal static bool 下且丄丝丘丝丈上丒;
    internal static bool 业丏不世下专下丅丅;
    internal static bool 上与丐丅专丘七业上;
    internal static bool 丁丝丒丕丘不丁丁丂;
    internal static bool 丗业丒三丘上丌丄七;
    internal static bool 万丂丅丕丏丐丈东世;
    internal static bool 三丙丌丞东不且丝丞;
    internal static string 专丑丙丞丙万丗东丒;
    internal static CategoryNames 与丝与丄三丅下丒七;
    private static bool 丙一三丒丘与丒丐丞;
    private float 丏丟东东东上丑丕不;
    private string 丞与与丙七东与丐丙;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<bool> 丌且丝丄丂丛且丛世;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private float 东丌丆一专与丝丕丝;
    private float 东世七上东丐丁丑东;
    private float 东世专七丈不上三丆;
    internal static bool 丂世丗丌丌一丐丝丛;
    private LoadingNGUIController 三三丆下东丏丌丅上;
    private bool 丑与三七丙丆万丞丒;
    private bool 丏丅与七丞丐丒与丌;
    private static bool 丐世丂丄丗世丈丆与;
    private UnityEngine.GameObject 丑丝丙丌丁丟丕丑业;
    private bool 丛上不三三不与丞丑;
    private static bool 丌下丗万丗丝不丅业;
    private float 丝丞业丄七专丟丟丙;
    public System.Collections.Generic.List<int> shownMinigameModes;
    private const string 丛丈东丒丙不丈丑丞 = "MainMenuController.MINIGAME_SHOWN_MODES_KEY";
    private static UnityEngine.GameObject 丕专与专丈丘丑且丕;
    public UnityEngine.Transform miniGamesPoint;
    private bool <丄七三丝丄上丞丅丛>k__BackingField;
    private const string 丏丂业丕专丕业下丂 = "Ads.Offerwall.IronSource.ProcessedCreditsResponse-v2";
    private System.Threading.CancellationTokenSource 丈丛且七三丌丂丏丒;
    
    // Properties
    internal static bool 万丐上丑且业丁七丆 { get; set; }
    internal static bool 丈万业丏丑上丝业丆 { get; set; }
    internal bool 丁七与丘专丛丐万东 { get; }
    internal UserCharacterMainWindow 下丛丗丆下万且丁东 { get; }
    private UnityEngine.Transform 丑丗丑丒丅丘一丕丛 { get; }
    internal UnityEngine.Camera 丝业丑世专丟三不丗 { get; }
    internal static bool 丂丂东东丅丅三万丟 { get; }
    internal ConnectPanel 业丈不万七不业专一 { get; }
    internal bool 丝业丒专丝丑丗丐业 { get; }
    internal static bool 丑丅不且万丐上业业 { set; }
    internal bool 丐下业丅丝丞万丂丄 { get; set; }
    internal bool 丏万丅丟上且与东专 { get; set; }
    internal static UnityEngine.Vector3 业丙丂不丏下丂丙丌 { get; }
    public bool 专丅丆丑东丒世专丒 { get; }
    internal bool 丝丐专丄专丒丕下下 { get; }
    internal static bool 且业丞丈世与丐上丂 { get; }
    internal UnityEngine.GameObject 丛东丛专三三丕丟丄 { get; }
    internal bool 丐专不一专丂丒下丄 { get; set; }
    private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    
    // Methods
    internal static void 与丄不丒丕不丅丘丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  MainMenuController.丏丂业丕专丕业下丂, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丛丁丐丝丟专丞丟业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  MainMenuController.丏丂业丕专丕业下丂, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 三丟丗七三丛丅丕丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  MainMenuController.丞丒下丄世丂不七丝, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MainMenuController.丞丒下丄世丂不七丝 != 1152921505080864776);
    
    }
    internal static void 丙七业丞丁丂丄丏丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  MainMenuController.丞丒下丄世丂不七丝, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MainMenuController.丞丒下丄世丂不七丝 != 1152921505080864776);
    
    }
    internal static bool 上丌丁丝且丅丒丟一()
    {
        null = null;
        return (bool)MainMenuController.<下丌丞丛丆丙丝一东>k__BackingField;
    }
    internal static void 丑下上丙三丟世丒丂(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        MainMenuController.<下丌丞丛丆丙丝一东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丈一丏一丂丟三且丌()
    {
        null = null;
        return (bool)MainMenuController.<丄丌万丆丒且丅丌且>k__BackingField;
    }
    private static void 丅丟不丝一丝万丟丂(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        MainMenuController.<丄丌万丆丒且丅丌且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 与丙七丞丞不丒丙丘()
    {
        if(this.丟丙丗七与丆且与丞 == null)
        {
                return (bool)this.丟丙丗七与丆且与丞;
        }
        
        return this.丟丙丗七与丆且与丞.丅专七丞东丐丒丒丗();
    }
    internal UserCharacterMainWindow 七万三丈三一丕丙丆()
    {
        Rilisoft.专丕丝丏丒一一万丏<UserCharacterMainWindow> val_3;
        Rilisoft.专丕丝丏丒一一万丏<UserCharacterMainWindow> val_4;
        val_3 = this;
        val_4 = this.丟丙丗七与丆且与丞;
        if(val_4 == null)
        {
                return (UserCharacterMainWindow)val_4;
        }
        
        if(val_4.丙三专丞丒丂万三丁() != false)
        {
                val_3 = this.丟丙丗七与丆且与丞;
            UserCharacterMainWindow val_2 = val_3.世三丞丅丑丌丈丈一();
            return (UserCharacterMainWindow)val_4;
        }
        
        val_4 = 0;
        return (UserCharacterMainWindow)val_4;
    }
    private UnityEngine.Transform 与丗丂丕丛一丛丟丌()
    {
        if(this.一丁三三丙丟丆丄丄 != 0)
        {
                return (UnityEngine.Transform)this.一丁三三丙丟丆丄丄;
        }
        
        if(PersConfigurator.下一丁七丅丕七万丑() == 0)
        {
                return (UnityEngine.Transform)this.一丁三三丙丟丆丄丄;
        }
        
        this.一丁三三丙丟丆丄丄 = PersConfigurator.下一丁七丅丕七万丑().transform;
        return (UnityEngine.Transform)this.一丁三三丙丟丆丄丄;
    }
    internal UnityEngine.Camera 丌丒丒丙与东丈丟东()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        val_4 = this;
        val_5 = 0;
        if(this.rotateCamera == 0)
        {
                return (UnityEngine.Camera)丞东丑专丛丆丄丝世.丙业业丈丌下丗专与<UnityEngine.Camera>(丝三丁东丈丒世丅业:  val_4 = this.rotateCamera.gameObject, 丒丘丏上丙丟丑丕丈:  "Main Camera", 丟丝七七一丁丏丏丙:  true);
        }
        
        return (UnityEngine.Camera)丞东丑专丛丆丄丝世.丙业业丈丌下丗专与<UnityEngine.Camera>(丝三丁东丈丒世丅业:  val_4, 丒丘丏上丙丟丑丕丈:  "Main Camera", 丟丝七七一丁丏丏丙:  true);
    }
    internal static bool 丙丏丝丟丞丐丘丑三()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        return UnityEngine.Object.op_Inequality(x:  MainMenuController.丄丞丁丈与业上丞丟.三三丒丅丂丝七下丁, y:  0);
    }
    internal static void 丄丈丝丕世丕且东丗(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  MainMenuController.七丕上丕丐丒丕世世, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MainMenuController.七丕上丕丐丒丕世世 != 1152921505080864816);
    
    }
    internal static void 丌七丝与丂丒七丑丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  MainMenuController.七丕上丕丐丒丕世世, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MainMenuController.七丕上丕丐丒丕世世 != 1152921505080864816);
    
    }
    internal static void 丗丝丗丗丒一丝丑丘(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  MainMenuController.丑丒丞丘丗丗丑与丁, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MainMenuController.丑丒丞丘丗丗丑与丁 != 1152921505080864824);
    
    }
    internal static void 与专业七与丁世一世(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  MainMenuController.丑丒丞丘丗丗丑与丁, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(MainMenuController.丑丒丞丘丗丗丑与丁 != 1152921505080864824);
    
    }
    internal ConnectPanel 丆丂三一丌一丏丁丞()
    {
        if(this.丗上丏丟丆专与丗丆 == 0)
        {
                return (ConnectPanel)this.丒丏丝丛东丁专七丌;
        }
        
        if(this.丒丏丝丛东丁专七丌 != 0)
        {
                return (ConnectPanel)this.丒丏丝丛东丁专七丌;
        }
        
        this.丒丏丝丛东丁专七丌 = this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>();
        return (ConnectPanel)this.丒丏丝丛东丁专七丌;
    }
    internal bool 丏丆丈专丈丈丈丘丘()
    {
        Rilisoft.专丕丝丏丒一一万丏<PGCompany.NewsLobbyController> val_2 = this.世专丟丆丙丂丙万丂;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        if(val_2.丅专七丞东丐丒丒丗() != false)
        {
                val_2 = 1;
            return (bool)val_2;
        }
        
        if(this.世专丟丆丙丂丙万丂 != null)
        {
                return this.世专丟丆丙丂丙万丂.丙世万一不丒上专丏();
        }
        
        return this.世专丟丆丙丂丙万丂.丙世万一不丒上专丏();
    }
    private void Awake()
    {
        MainMenuController val_67;
        var val_68;
        System.Func<PGCompany.三丘丌上丁万丏丛丟, System.Boolean> val_70;
        var val_71;
        var val_72;
        var val_73;
        UnityEngine.GameObject val_74;
        UnityEngine.GameObject val_75;
        var val_77;
        val_67 = this;
        ShopNGUIController.万丟丂与业丟丘一一();
        if(this.丗上丏丟丆专与丗丆 != 0)
        {
                if(this.丒丏丝丛东丁专七丌 == 0)
        {
                this.丒丏丝丛东丁专七丌 = this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>();
        }
        
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake MainMenu");
        Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丁万丟丕东丅丕丌丗();
        业丈不上丟万一丕丏.丑七不且上丗丁一世().上丛丌丆丑上七世三();
        if(((与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true) || (业丈不上丟万一丕丏.丑七不且上丗丁一世().丗业丝万业一与三且() != 1)) || (业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丑东东丒丑丁不丕() == false))
        {
            goto label_29;
        }
        
        val_68 = null;
        val_68 = null;
        val_70 = MainMenuController.<>c.<>9__104_0;
        if(val_70 == null)
        {
                val_70 = null;
            val_70 = new System.Func<PGCompany.三丘丌上丁万丏丛丟, System.Boolean>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainMenuController.<>c::丗丏丌丏且业丐丞东(PGCompany.三丘丌上丁万丏丛丟 丁丂专业丁丅丅丈丙));
            MainMenuController.<>c.<>9__104_0 = val_70;
        }
        
        bool val_15 = System.Linq.Enumerable.Any<PGCompany.三丘丌上丁万丏丛丟>(source:  System.Linq.Enumerable.OfType<PGCompany.三丘丌上丁万丏丛丟>(source:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  136, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})), predicate:  null);
        业丈不上丟万一丕丏 val_16 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_16 == null)
        {
            goto label_27;
        }
        
        if(val_15 == false)
        {
            goto label_28;
        }
        
        label_30:
        val_16.丄丑业丝丐与世一丝();
        this.丟丙且丝万与不丑丐();
        goto label_29;
        label_27:
        if(val_15 == true)
        {
            goto label_30;
        }
        
        label_28:
        val_16.不丘七七丛丙丏丆万();
        label_29:
        this.<丅丑丕丈上丑下丈丈>k__BackingField = false;
        this.丌丈且丛丅丏丏丌丆(丏业丟一东丂东丘丛:  true);
        val_71 = null;
        val_71 = null;
        if(MainMenuController.七万丆丘丈丄丂与丒 != true)
        {
                ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
            val_71 = null;
        }
        
        val_71 = null;
        MainMenuController.丄丞丁丈与业上丞丟 = val_67;
        val_72 = null;
        val_72 = null;
        GameConnect.七七丈东丅上丝丒万 = false;
        业丂丏与世一丏业不 val_17 = 业丂丏与世一丏业不.丑七不且上丗丁一世();
        丛丟丘专丅丑丗丌七.丑七不且上丗丁一世().丅东丅一丛丐丒丅丏();
        丟丌丁且且世丈丈丟.丟丟丙丐丁丄丁丝丞();
        val_73 = null;
        val_73 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  true, 专丆丌丛东一不丑丙:  0);
        bool val_20 = UnityEngine.Object.op_Implicit(exists:  Rilisoft.AchievementsManager.Instance);
        this.不丌世世丗丗下丄丏 = new Rilisoft.专丕丝丏丒一一万丏<SocialGunBannerView>(丆万丕丏与丈与丒丗:  this._socialBannerPrefab.ResourcePath, 丆丏七丟不丒与七专:  this._subwindowsHandler);
        this.丟丙丗七与丆且与丞 = new Rilisoft.专丕丝丏丒一一万丏<UserCharacterMainWindow>(丆万丕丏与丈与丒丗:  this._userCharactersPrefab.ResourcePath, 丆丏七丟不丒与七专:  this._subwindowsHandler);
        this.世专丟丆丙丂丙万丂 = new Rilisoft.专丕丝丏丒一一万丏<PGCompany.NewsLobbyController>(丆万丕丏与丈与丒丗:  this._newsPrefab.ResourcePath, 丆丏七丟不丒与七专:  this._subwindowsHandler);
        this.丌丐丅一丛丐丕丆一 = new Rilisoft.专丕丝丏丒一一万丏<FeedbackMenuController>(丆万丕丏与丈与丒丗:  this._feedbackPrefab.ResourcePath, 丆丏七丟不丒与七专:  this._subwindowsHandler);
        this.丏丟丝丘丐丏三世丐 = new Rilisoft.专丕丝丏丒一一万丏<ClanSecondVersionBanner>(丆万丕丏与丈与丒丗:  this._newClanVesionPrefab.ResourcePath, 丆丏七丟不丒与七专:  this._subwindowsHandler);
        this.mainPanel.SetActive(value:  true);
        UnityEngine.Object val_31 = UnityEngine.Resources.Load(path:  "ConnectPanel");
        if(val_31 != null)
        {
                var val_32 = (null == null) ? (val_31) : 0;
        }
        else
        {
                val_74 = 0;
        }
        
        UnityEngine.GameObject val_33 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_74);
        this.丗上丏丟丆专与丗丆 = val_33;
        val_33.transform.SetParent(parent:  this.uiCamera.transform, worldPositionStays:  false);
        this.丗上丏丟丆专与丗丆.SetActive(value:  false);
        this.丗上丏丟丆专与丗丆.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "Banners");
        PGCompany.GameModeHub.丙丙与东一丐丂丐上.丑七不且上丗丁一世().丂丐不上专丘丏丄丁(丛丘下丗业丂一且业:  this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>());
        UnityEngine.GameObject val_40 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_74);
        this.且专业世七丄丑丏专 = val_40;
        val_40.transform.SetParent(parent:  this.uiCamera.transform, worldPositionStays:  false);
        this.且专业世七丄丑丏专.SetActive(value:  false);
        ConnectionControl val_43 = this.且专业世七丄丑丏专.AddComponent<ConnectionControl>();
        this.丝丆业上世丅丞且丙 = val_43;
        val_43.SetConnectPanel(丛丘下丗业丂一且业:  this.且专业世七丄丑丏专.GetComponent<ConnectPanel>());
        if(this.lobbyPanel.speedRunOfflineButton != 0)
        {
                this.lobbyPanel.speedRunOfflineButton.SetActive(value:  与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆());
        }
        
        if(this.lobbyPanel.arenaOfflineButton != 0)
        {
                this.lobbyPanel.arenaOfflineButton.SetActive(value:  与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆());
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "MainMenuController.MINIGAME_SHOWN_MODES_KEY")) != true)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "MainMenuController.MINIGAME_SHOWN_MODES_KEY", 下下丏一丙不丘丌丞:  "[]");
        }
        
        this.shownMinigameModes = MainMenuController.丌丁专丐丑下丒丈丁();
        int val_54 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  MainMenuController.丟业丙丗世丄丟丞且(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        this.丝丞业丄七专丟丟丙 = UnityEngine.Time.realtimeSinceStartup;
        UnityEngine.Object val_56 = UnityEngine.Resources.Load(path:  "NguiWindows/Hints");
        if(val_56 != null)
        {
                val_56 = (null == null) ? (val_56) : 0;
        }
        else
        {
                val_75 = 0;
        }
        
        this.trainingHints.SetHintObject(丝三丁东丈丒世丅业:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_75));
        UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  (null == null) ? UnityEngine.Resources.Load(path:  "NguiWindows/OfflineMod") : 0).transform.SetParent(parent:  this.uiCamera.transform, worldPositionStays:  false);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake end");
        int val_66 = MainMenuController.与不丒下丕丐万丗丞;
        val_66 = val_66 + 1;
        MainMenuController.与不丒下丕丐万丗丞 = val_66;
        this.丄丄且与丂不一丁三();
        this.丐丂丙丘丞丘专丗下();
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
        {
                MainMenuController.丅丘丄七上万丕丏丗();
        }
        
        if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == false)
        {
                return;
        }
        
        val_67 = 1152921505061052416;
        if(ExperienceController.万丏丙丈东东万丝丞() != 0)
        {
                return;
        }
        
        val_77 = null;
        val_77 = null;
        if(ExperienceController.sharedController == null)
        {
                return;
        }
        
        ExperienceController.sharedController.丗丒丂丕丟东丟丙不(业不七丗东丛下一东:  5, 世丁丙世丄一万丆三:  5, 与丌丛丈丕丁丅丄丗:  0);
    }
    private static void 丅丘丄七上万丕丏丗()
    {
        var val_7;
        var val_8;
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  56)) != false)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  246);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  56);
        label_32:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        if(0 != 1)
        {
                if(0 == 0)
        {
                return;
        }
        
            if(79 != 79)
        {
            goto label_19;
        }
        
            return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        label_19:
        val_7 = 0;
        val_8 = 0;
        if(val_7 != 1)
        {
            goto label_29;
        }
        
        if((null & 1) == 0)
        {
            goto label_21;
        }
        
        object[] val_6 = new object[1];
        val_6[0] = 1179403647;
        UnityEngine.Debug.LogErrorFormat(format:  "Exception in equip armor and sniper migration: {0}", args:  val_6);
        mem2[0] = 79;
        goto label_32;
        label_21:
        mem[8] = 1179403647;
        val_7 = 123444064;
        val_8 = 8;
        label_29:
        if( != 1)
        {
            goto label_31;
        }
        
        goto label_32;
        label_31:
    }
    private void 丐丂丙丘丞丘专丗下()
    {
        this.世丁万专丞丗三丌一 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  5f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void MainMenuController::丈三丐丐与丝万业与()));
    }
    private void 丗世丕丈丘七上上丕()
    {
        if(this.世丁万专丞丗三丌一 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.世丁万专丞丗三丌一);
        }
        
        if(this.不下下丆丐丁丒与丗 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.不下下丆丐丁丒与丗);
        }
        
        if(this.丗且七丂丄丆丌丅三 == null)
        {
                return;
        }
        
        CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丗且七丂丄丆丌丅三);
    }
    private void 丈三丐丐与丝万业与()
    {
        ulong val_18;
        System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
        this.世丁万专丞丗三丌一 = 0;
        if(((464733024 & 1) == 0) || ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丁下丆三丏丌丕业丂()) == false))
        {
            goto label_17;
        }
        
        System.DateTime val_5 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.且丒万一丑丘东万上();
        val_18;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_5.dateData}, d2:  new System.DateTime() {dateData = val_18});
        System.DateTime val_8 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丘丘丌丁世七专万与();
        System.TimeSpan val_9 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_8.dateData}, d2:  new System.DateTime() {});
        if(val_6._ticks.TotalSeconds >= 0f)
        {
            goto label_10;
        }
        
        int val_12 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丈丏丗万丑丕丗东丘(且下丕七丙丗丄不七:  2);
        if((val_12 < 1) || (this.丗且七丂丄丆丌丅三 != null))
        {
            goto label_17;
        }
        
        System.Action val_13 = null;
        val_18 = val_13;
        val_13 = new System.Action(object:  this, method:  System.Void MainMenuController::丗丞丂丅丐上丏万丝());
        this.丗且七丂丄丆丌丅三 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  (float)val_12, 丌专业且丛丏丞丝且:  val_13);
        goto label_17;
        label_10:
        if(this.不下下丆丐丁丒与丗 == null)
        {
                this.不下下丆丐丁丒与丗 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  (float)val_6._ticks.TotalSeconds, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void MainMenuController::专丒丗专丗丕丐丐丏()));
        }
        
        label_17:
        this.丐丂丙丘丞丘专丗下();
    }
    private void 专丈不丘丛丅七万丙()
    {
        InfoWindowController.丅三东下不丅丅业丆(不且东三三丐世下丝:  false);
        PGCompany.ClanWarController.东丝丞丘一丂丆丘七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuController::专丈不丘丛丅七万丙()));
    }
    private void 丄丄且与丂不一丁三()
    {
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/EventTournamentReward"), parent:  this._subwindowsHandler.transform);
    }
    private static System.Collections.Generic.List<int> 丌丁专丐丑下丒丈丁()
    {
        var val_6;
        object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "MainMenuController.MINIGAME_SHOWN_MODES_KEY"));
        val_6 = 0;
        return System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<System.Object, System.Int32>(source:  null, selector:  new System.Func<System.Object, System.Int32>(object:  0, method:  public static System.Int32 System.Convert::ToInt32(object value))));
    }
    public void FortOpenBegin()
    {
        TweenAlpha val_1 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  this._fortLoadingPanel, 与丈业丛丝丒丙一丏:  this._alfaTweenTime, 与专丌丅丙上丌一丄:  1f);
    }
    public void FortOpenEnd()
    {
        TweenAlpha val_1 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  this._fortLoadingPanel, 与丈业丛丝丒丙一丏:  this._alfaTweenTime, 与专丌丅丙上丌一丄:  0f);
    }
    public void SaveShowPanelAndClose()
    {
        var val_10;
        if(this.mainPanel == 0)
        {
                return;
        }
        
        this.丛专一丘丙丞丅丞业.Clear();
        val_10 = 0;
        goto label_5;
        label_19:
        UnityEngine.GameObject val_4 = this.mainPanel.transform.GetChild(index:  0).gameObject;
        if((val_4.GetComponent<UICamera>()) == 0)
        {
                if(val_4.activeSelf != false)
        {
                this.丛专一丘丙丞丅丞业.Add(item:  val_4);
            val_4.SetActive(value:  false);
        }
        
        }
        
        val_10 = 1;
        label_5:
        if(val_10 < this.mainPanel.transform.childCount)
        {
            goto label_19;
        }
    
    }
    public void ShowSavePanel(bool 丁丗丏东七不丞丒丄 = True)
    {
        goto label_1;
        label_8:
        UnityEngine.GameObject val_1 = this.丛专一丘丙丞丅丞业.Item[0];
        if(val_1 != 0)
        {
                val_1.SetActive(value:  true);
        }
        
        0 = 1;
        label_1:
        if(0 < this.丛专一丘丙丞丅丞业.Count)
        {
            goto label_8;
        }
        
        if(丁丗丏东七不丞丒丄 == false)
        {
                return;
        }
        
        this.丛专一丘丙丞丅丞业.Clear();
    }
    internal void 丌丁丆丁万上丁丘丑(System.EventHandler 丙业与丙丗丝不丈东)
    {
        this.世丟丁不世丘丐与丑.Add(item:  丙业与丙丗丝不丈东);
    }
    internal void 丒丟万丂万丆业三丑(System.EventHandler 丙业与丙丗丝不丈东)
    {
        bool val_1 = this.世丟丁不世丘丐与丑.Remove(item:  丙业与丙丗丝不丈东);
    }
    private void 东丂下且世丅与七丝()
    {
        var val_8;
        if(this.世丟丁不世丘丐与丑.Count == 0)
        {
                return;
        }
        
        if(this.世丟丁不世丘丐与丑 != null)
        {
                val_8 = this.世丟丁不世丘丐与丑.Count;
        }
        else
        {
                val_8 = 0.Count;
        }
        
        System.EventHandler val_7 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<System.EventHandler>(丄三丅七丆丛与与上:  this.世丟丁不世丘丐与丑.Item[val_8 - 1], 七丐丅专且专七三丆:  new System.Action<System.EventHandler>(object:  this, method:  System.Void MainMenuController::丆丒丏下丐丏丘丗丙(System.EventHandler 丐丟与丄丈下一东丘)));
    }
    private static MainMenuController()
    {
        MainMenuController.与不丒下丕丐万丗丞 = 0;
        MainMenuController.丂不三丈丕丑丌业下 = 0;
        MainMenuController.丆不丑丆下丞丙不丞 = false;
        MainMenuController.丂丛丗丁丐丗丒丞万 = false;
        MainMenuController.丞且丙丛丞不世专七 = true;
        MainMenuController.丞丟丂三丝丆丌丌丗 = false;
        MainMenuController.七万丆丘丈丄丂与丒 = true;
        MainMenuController.与丝与丄三丅下丒七 = 9990000;
        MainMenuController.丂世丗丌丌一丐丝丛 = false;
        MainMenuController.丐世丂丄丗世丈丆与 = true;
        MainMenuController.丌下丗万丗丝不丅业 = true;
        MainMenuController.丅丟不丝一丝万丟丂(丙业与丙丗丝不丈东:  false);
    }
    internal static bool 丆万丒丆且世丙丒上(bool 丈丈不丒丗与丝不丗 = False)
    {
        var val_9;
        var val_10;
        bool val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_10 = null;
            val_10 = null;
            val_11 = mem[ExperienceController.sharedController + 49];
            val_11 = ExperienceController.sharedController.丁与丌东丄丙下下万;
        }
        else
        {
                val_11 = 0;
        }
        
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                val_12 = BannerWindowController.与丅与丒丅专丙丐丗().不且丝丆丈三与世东(丈丈不丒丗与丝不丗:  丈丈不丒丗与丝不丗);
        }
        else
        {
                val_12 = 0;
        }
        
        val_12 = val_12 | val_11;
        return (bool)(val_12 != 0) ? 1 : 0;
    }
    internal static bool 丏丗丙丙丞丆万丘丅(bool 丈丈不丒丗与丝不丗 = False)
    {
        bool val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = 丈丈不丒丗与丝不丗;
        if((MainMenuController.丆万丒丆且世丙丒上(丈丈不丒丗与丝不丗:  val_6)) == false)
        {
            goto label_3;
        }
        
        label_13:
        val_7 = 1;
        return (bool)(与丂丏丛丞丞丒丟丄.丘不丅丛丁且上不丟 == true) ? 1 : 0;
        label_3:
        val_8 = null;
        val_8 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_9;
        }
        
        val_9 = null;
        val_9 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
            goto label_13;
        }
        
        label_9:
        val_6 = 1152921505171275776;
        val_10 = null;
        val_10 = null;
        return (bool)(与丂丏丛丞丞丒丟丄.丘不丅丛丁且上不丟 == true) ? 1 : 0;
    }
    internal static void 业业丅丘丑丁丕且专(System.Action 七丐丅专且专七三丆, System.Action 丆丒丅丁不且丛一业)
    {
        if(东丗上丁下业一丂丂.专七与丏丞丁丅丈丟() != false)
        {
                CleanUpAndDoAction.七丐丅专且专七三丆 = (丆丒丅丁不且丛一业 == 0) ? 七丐丅专且专七三丆 : 丆丒丅丁不且丛一业;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "LoadAnotherApp");
            return;
        }
        
        if(七丐丅专且专七三丆 == null)
        {
                return;
        }
        
        七丐丅专且专七三丆.Invoke();
    }
    public void HandleFacebookLoginButton()
    {
        var val_3;
        System.Action val_5;
        ButtonClickSound.丁业上丏不丕三丗不();
        if(Facebook.Unity.FB.IsLoggedIn != false)
        {
                Facebook.Unity.FB.LogOut();
            return;
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = MainMenuController.<>c.<>9__125_0;
        if(val_5 == null)
        {
                System.Action val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::丄丝丒丕丝七专丞万());
            MainMenuController.<>c.<>9__125_0 = val_5;
        }
        
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  val_2, 丆丒丅丁不且丛一业:  0);
    }
    public void HandleTwitterLoginButton()
    {
        var val_4;
        var val_5;
        var val_6;
        System.Action val_8;
        ButtonClickSound.丁业上丏不丕三丗不();
        if(TwitterController.丒丆世一与丁丛丐下() != false)
        {
                val_4 = null;
            val_4 = null;
            if(TwitterController.丗丘丒丈专丘丕世与 != 0)
        {
                val_5 = null;
            val_5 = null;
            TwitterController.丗丘丒丈专丘丕世与.Logout();
            return;
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        val_8 = MainMenuController.<>c.<>9__126_0;
        if(val_8 == null)
        {
                System.Action val_3 = null;
            val_8 = val_3;
            val_3 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::丐业丏丐万世下七丅());
            MainMenuController.<>c.<>9__126_0 = val_8;
        }
        
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  val_3, 丆丒丅丁不且丛一业:  0);
    }
    private System.Collections.IEnumerator OnApplicationPause(bool 丄七丙不丟丛与丏丐)
    {
        MainMenuController.丆与丁丘丘丂东丛丘 val_1 = new MainMenuController.丆与丁丘丘丂东丛丘(丗丏丅丕丆世丁专丟:  0);
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
    private void 丕丂丄丑东专下丙下()
    {
        if(this.丏丈丅专东三东丏业 != null)
        {
                return;
        }
        
        this.丏丈丅专东三东丏业 = this.StartCoroutine(routine:  this.丙丝丞万丆一丘丒万());
    }
    private System.Collections.IEnumerator 丙丝丞万丆一丘丒万()
    {
        return (System.Collections.IEnumerator)new MainMenuController.东丕万专一丕下丝东(丗丏丅丕丆世丁专丟:  0);
    }
    public void OnSocialGunEventButtonClick()
    {
        var val_5;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(SkinEditorController.丄丞丁丈与业上丞丟 != 0)
        {
                return;
        }
        
        if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
        {
                return;
        }
        
        this.不丌世世丗丗下丄丏.世三丞丅丑丌丈丈一().Show();
    }
    private void OnDestroy()
    {
        System.Action<TInput> val_16;
        var val_17;
        var val_18;
        System.Func<UnityEngine.Transform, UnityEngine.GameObject> val_20;
        val_16 = 1152921504615739392;
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuController::丅专不丟下丘丈专丘()));
        Rilisoft.LobbyItemSlotClickHandler.万丟丟丈专丞丒与丗(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void MainMenuController::丄万丕丑下丕不丝丘(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)));
        FriendsController.丌业丗丈业丑一丙与();
        SocialGunBannerView.丑业丗上丛丙丟七丒(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void MainMenuController::上与丝丙下丕丂丞丏(bool 丐万丗丒下七丟丁三)));
        PromoActionClick.丆丝且一丆丏丐专丌(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  public System.Void MainMenuController::HandlePromoActionClicked(string 丒东业不丐丑丕丄丆)));
        SettingsController.丛丛且与专丙丕丘丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ControlsSettingsBase::不丐三且上专丄丏丟()));
        val_17 = null;
        val_17 = null;
        MainMenuController.丄丞丁丈与业上丞丟 = 0;
        if(FreeAwardController.丑七不且上丗丁一世() != 0)
        {
                val_18 = null;
            val_18 = null;
            val_20 = MainMenuController.<>c.<>9__133_0;
            if(val_20 == null)
        {
                System.Func<UnityEngine.Transform, UnityEngine.GameObject> val_11 = null;
            val_20 = val_11;
            val_11 = new System.Func<UnityEngine.Transform, UnityEngine.GameObject>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject MainMenuController.<>c::世七且东一下万丑丆(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            MainMenuController.<>c.<>9__133_0 = val_20;
        }
        
            System.Action<UnityEngine.GameObject> val_13 = null;
            val_16 = val_13;
            val_13 = new System.Action<UnityEngine.GameObject>(object:  0, method:  public static System.Void UnityEngine.Object::Destroy(UnityEngine.Object obj));
            UnityEngine.GameObject val_14 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UnityEngine.GameObject>(丄三丅七丆丛与与上:  Rilisoft.NullExtensions.七三与丛三丈丏且专.一丘东丌丑且丏一丙<UnityEngine.Transform, UnityEngine.GameObject>(丄三丅七丆丛与与上:  FreeAwardController.丑七不且上丗丁一世().transform.root, 东丑丈丅丌万东丅且:  val_11), 七丐丅专且专七三丆:  val_13);
        }
        
        if(val_16 != null)
        {
                this.StopCoroutine(routine:  val_13);
            mem[1152921530844280712] = 0;
        }
        
        if(val_16 != null)
        {
                this.StopCoroutine(routine:  val_13);
            mem[1152921530844280720] = 0;
        }
        
        if(val_16 != null)
        {
                this.StopCoroutine(routine:  val_13);
            mem[1152921530844280704] = 0;
        }
        
        丛丟丘专丅丑丗丌七 val_15 = 丛丟丘专丅丑丗丌七.丑七不且上丗丁一世();
        val_15.丁三丒丆丛丏丂丅丐();
        val_15.上丘丟丝丏丐丗万且();
        this.丑丂丒上东丙丟丕三();
        this.丗世丕丈丘七上上丕();
    }
    internal static void 丅上丏丈万丒丈丑东(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        MainMenuController.七万丆丘丈丄丂与丒 = 丙业与丙丗丝不丈东;
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
    private void 丌世七丐七丐丁丛丛()
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  37);
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  27)) != false)
        {
                if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  27)) >= 1)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  27, 丙业与丙丗丝不丈东:  0);
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private static void 丒三丑丙三丞丙丗丂()
    {
        int val_4;
        var val_5;
        var val_6;
        if(FacebookController.且丈丄一丁丞丒丑东() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = FacebookController.业万专东上丝丛与丁;
        if(val_4 == 0)
        {
                return;
        }
        
        if(Facebook.Unity.FB.IsLoggedIn == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        FacebookController.业万专东上丝丛与丁.不丑丘东与不丒万不(七丒上且丝业业下七:  0, 丑下丐世丆且丝上丈:  true);
    }
    public void RefreshSettingsButton()
    {
        object val_13;
        System.EventHandler val_14;
        val_13 = this;
        if(this.mainMenuPanel.settingsButton == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_2 = this.mainMenuPanel.settingsButton.GetComponent<Rilisoft.ButtonHandler>();
        if(val_2 != 0)
        {
                System.EventHandler val_4 = null;
            val_14 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  System.Void MainMenuController::专丕与丙丆丕丝丘丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_2.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        val_13 = this.mainMenuPanel.settingsButton.GetComponent<UIButton>();
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = ???;
        val_14 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void UpdateOldHints(bool 丕丕世且下一与丝与)
    {
    
    }
    internal string 丗丘丞丛丁七丆专丌()
    {
        string val_4;
        int val_5;
        val_4 = this;
        if((System.String.IsNullOrEmpty(value:  this.丙下丘丕丂丛与丙丄)) != true)
        {
                if((this.丐丘丆丐不丙丟丌上.ContainsKey(key:  this.丙下丘丕丂丛与丙丄)) != false)
        {
                val_4 = this.丙下丘丕丂丛与丙丄;
            string val_3 = this.丐丘丆丐不丙丟丌上.Item[val_4];
            return (string)val_5;
        }
        
        }
        
        val_5 = System.String.alignConst;
        return (string)val_5;
    }
    private void 丆上丅丝丛下丞东丑()
    {
        var val_10;
        string val_11;
        var val_12;
        System.Collections.Generic.HashSet<System.String> val_13;
        string val_14;
        val_10 = 1152921505266909184;
        val_11 = "";
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "ShowedLightHintsKey")) != false)
        {
                val_11 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "ShowedLightHintsKey");
        }
        else
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ShowedLightHintsKey", 下下丏一丙不丘丌丞:  "");
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_11);
        val_12 = 0;
        System.Collections.Generic.HashSet<System.String> val_4 = null;
        val_13 = val_4;
        val_4 = new System.Collections.Generic.HashSet<System.String>();
        this.丞且与丄丂丂上丕丘 = val_13;
        if(Count < 1)
        {
                return;
        }
        
        label_18:
        val_10 = Item[0];
        if(this.丞且与丄丂丂上丕丘 == null)
        {
            goto label_14;
        }
        
        if(val_10 == null)
        {
            goto label_15;
        }
        
        label_17:
        var val_7 = (null == null) ? (val_10) : 0;
        goto label_16;
        label_14:
        if(val_10 != null)
        {
            goto label_17;
        }
        
        label_15:
        val_14 = 0;
        label_16:
        bool val_8 = this.丞且与丄丂丂上丕丘.Add(item:  val_14);
        val_13 = 0 + 1;
        if(val_13 < Count)
        {
            goto label_18;
        }
    
    }
    private bool 丒丐万丙丗丂丑下丆(string 丞丅上丏丂且下丅与)
    {
        if(this.丞且与丄丂丂上丕丘 != null)
        {
                return 0.Contains(item:  丞丅上丏丂且下丅与);
        }
        
        this.丆上丅丝丛下丞东丑();
        if(this.丞且与丄丂丂上丕丘 != null)
        {
                return 0.Contains(item:  丞丅上丏丂且下丅与);
        }
        
        return 0.Contains(item:  丞丅上丏丂且下丅与);
    }
    private void 丐下七丆下不丂上上(string 丞丅上丏丂且下丅与)
    {
        System.Collections.Generic.HashSet<System.String> val_5 = this.丞且与丄丂丂上丕丘;
        if(val_5 == null)
        {
                this.丆上丅丝丛下丞东丑();
            val_5 = this.丞且与丄丂丂上丕丘;
            if(val_5 == null)
        {
                val_5 = 0;
        }
        
        }
        
        if((val_5.Contains(item:  丞丅上丏丂且下丅与)) != false)
        {
                return;
        }
        
        bool val_2 = this.丞且与丄丂丂上丕丘.Add(item:  丞丅上丏丂且下丅与);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ShowedLightHintsKey", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  this.丞且与丄丂丂上丕丘)));
    }
    internal void 丛丟丒丈丅下且丙下(string 世三丐七丑丅专丏丞)
    {
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == false)
        {
                return;
        }
        
        this.丏丒丒丄丆与下丄专.Add(item:  世三丐七丑丅专丏丞);
    }
    public void UpdateTutorialHints()
    {
    
    }
    private void 丆丌丗业丕丏上丛与()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.lobbyPanel.footersOnlineMode, 丏业丟一东丂东丘丛:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.lobbyPanel.footersOfflineMode, 丏业丟一东丂东丘丛:  与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆());
    }
    internal bool 丌世世万不上丝丆三()
    {
        return (bool)this.<丅丑丕丈上丑下丈丈>k__BackingField;
    }
    private void 丄丐三丐一丏下丕丈(bool 丙业与丙丗丝不丈东)
    {
        this.<丅丑丕丈上丑下丈丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private System.Collections.IEnumerator Start()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuController.不丒下丝丄丛丛且丒(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丅专且且丁丒丘丅且()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.万七业与丞丐不丕丝(丄丁上丒丌丝一上丕:  true));
    }
    private void 丘丂丂丟且专丄一丅()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.万七业与丞丐不丕丝(丄丁上丒丌丝一上丕:  false));
    }
    private System.Collections.IEnumerator 万七业与丞丐不丕丝(bool 丄丁上丒丌丝一上丕)
    {
        MainMenuController.丅丞丝丝丈丏不丒专 val_1 = new MainMenuController.丅丞丝丝丈丏不丒专(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丄丁上丒丌丝一上丕 = 丄丁上丒丌丝一上丕;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丅专不丟下丘丈专丘()
    {
        丅丛丟上丁丆上丛专.丟丝丞丁万三丘丄丒();
        int val_3 = 丅丛丟上丁丆上丛专.世专丑七丈丕与上世(业丕丄专与与上丌业:  上丞丑上丙丈丄丗丐.下丄丈不与世丐业专(), 丑与丙丒且一业万丈:  AccountsMenuItem.与与丆丞世丒丐丁上(), 丞世丌丗世丑业业与:  true);
    }
    internal void 丟丙且丝万与不丑丐()
    {
        var val_5;
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() != false)
        {
                val_5 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainMenuPanel.modulesTutorialBlocker, 丏业丟一东丂东丘丛:  false);
    }
    private void 丌丈且丛丅丏丏丌丆(bool 丏业丟一东丂东丘丛)
    {
        UITexture val_4;
        bool val_6;
        var val_7;
        if(丏业丟一东丂东丘丛 != false)
        {
                UnityEngine.Texture val_1 = ConnectScene.丗丅专与丁丙且且丐();
            val_4 = this.FortSceneStubTexture;
            UnityEngine.Texture val_2 = ConnectScene.丗丅专与丁丙且且丐();
            if(val_4 != null)
        {
            goto label_6;
        }
        
        }
        else
        {
                val_4 = this.FortSceneStubTexture;
        }
        
        label_6:
        val_6 = 丏业丟一东丂东丘丛;
        this.stubLoading.SetActive(value:  val_6);
        if(val_6 == true)
        {
                return;
        }
        
        val_6 = 1152921505080860672;
        val_7 = null;
        val_7 = null;
        if(MainMenuController.丞丒下丄世丂不七丝 == null)
        {
                return;
        }
        
        MainMenuController.丞丒下丄世丂不七丝.Invoke();
    }
    internal bool 下丑与丆三丝不丗一()
    {
        return (bool)this.<丕丙丐丆丝丈三七丆>k__BackingField;
    }
    private void 丐丙丌丄且丗一丈且(bool 丙业与丙丗丝不丈东)
    {
        this.<丕丙丐丆丝丈三七丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 世专且三不业丕东下(int 丌丒丝东丌下丕丁丅)
    {
        goto label_0;
        label_4:
        this._unreadNewsCounters[0].UpdateUnreadNewsCount(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        0 = 1;
        label_0:
        if(0 < this._unreadNewsCounters.Length)
        {
            goto label_4;
        }
    
    }
    private void 丄万丕丑下丕不丝丘(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
    {
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        if(下丅丙一丂丗丅丝七.丘专上世与丟丝丟丛() != 3)
        {
                return;
        }
        
        if(Rilisoft.Nest.丆丈一丌丒丅丌丌丝() == false)
        {
                return;
        }
        
        if(this.丑东丑丟上丘下七丘() == true)
        {
                return;
        }
        
        if(下丅丙一丂丗丅丝七.activeInHierarchy != false)
        {
                return;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_35 = null;
        val_35 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 != 0)
        {
                val_36 = null;
            val_36 = null;
            if(FriendProfileView.丐丕丝上丅丈丐丞专.gameObject.activeInHierarchy == true)
        {
                return;
        }
        
        }
        
        val_37 = null;
        val_37 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_38 = null;
            val_38 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
        {
                return;
        }
        
        }
        
        if(Rilisoft.ClansLobbyGui.丑七不且上丗丁一世() != 0)
        {
                if(Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().gameObject.activeInHierarchy == true)
        {
                return;
        }
        
        }
        
        if(PGCompany.丁东丌世与丕东丆上.丛不丆丕且丗丏丑丒() == false)
        {
                return;
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() < 2)
        {
                return;
        }
        
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
        {
                return;
        }
        
        val_39 = null;
        val_39 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_40 = null;
            val_40 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟 + 40.activeInHierarchy) == true)
        {
                return;
        }
        
        }
        
        if(FeedbackMenuController.丑七不且上丗丁一世() != 0)
        {
                if(FeedbackMenuController.丑七不且上丗丁一世().gameObject.activeInHierarchy == true)
        {
                return;
        }
        
        }
        
        val_41 = null;
        val_41 = null;
        if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_42 = null;
            val_42 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() == true)
        {
                return;
        }
        
        if(LeaderboardsGui.丑丙丗世丏丞万世丒() == true)
        {
                return;
        }
        
        if(LeaderboardsClans.丑丙丗世丏丞万世丒() == true)
        {
                return;
        }
        
        val_43 = null;
        val_43 = null;
        if(SeasonEndView.世丑丗上丘丟丐丂丕 == true)
        {
                return;
        }
        
        this.丐专丕丂丗丙丆丄丌(丑丝丏丂且不下一东:  0, 一专七丟丏且丑丄下:  168, 丏丐世且丑丅丘丅丟:  0, 万且丟七不上丗丑丝:  true, 丄丕三丞一丌与与丅:  true, 专丆丌丛东一不丑丙:  0, 丈丈不丒丗与丝不丗:  true, 丌丂丁七丏不丂丁上:  true);
    }
    private static bool 丂上丟丌一业专丏丕()
    {
        ClansWindowGUI val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_33 = 1152921505158602752;
        if(ClanWarUI.丈丐丞丐上丑且丕万() == true)
        {
            goto label_80;
        }
        
        val_34 = 1152921505152585728;
        val_35 = null;
        val_35 = null;
        val_32 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_32 == 0)
        {
            goto label_8;
        }
        
        val_36 = null;
        val_36 = null;
        val_32 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_32.InterfaceEnabled == true)
        {
            goto label_80;
        }
        
        label_8:
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((((System.String.op_Equality(a:  val_4.m_Handle.name, b:  "FortFieldBuild")) == true) || ((System.String.op_Equality(a:  val_4.m_Handle.name, b:  "ClanTankBuild")) == true)) || (PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() == true))
        {
            goto label_80;
        }
        
        val_37 = null;
        val_37 = null;
        val_32 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_32 == 0)
        {
            goto label_22;
        }
        
        val_38 = null;
        val_38 = null;
        val_32 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_32.与丙七丞丞不丒丙丘() == true)
        {
            goto label_80;
        }
        
        label_22:
        if(((((LeaderboardsGui.丑丙丗世丏丞万世丒() == true) || (LeaderboardsClans.丑丙丗世丏丞万世丒() == true)) || (ClanWarUI.丈丐丞丐上丑且丕万() == true)) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)) || (Rilisoft.丐丌丝七下丈丒丅丗.丁丟丗与万丆丝丈丞() == true))
        {
            goto label_80;
        }
        
        val_33 = 1152921505266909184;
        if(((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "RecommendDuelsBannerShownKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0) || ((Rilisoft.业丈下丒丁专万七丗.丆下丗丗丁专丗丄丛(丛专下丞丒丛下下与:  false, 丈丑业与丆下丝丝丐:  false)) == false))
        {
            goto label_80;
        }
        
        val_39 = null;
        val_39 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_50;
        }
        
        val_40 = null;
        val_40 = null;
        val_32 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_32.InterfaceEnabled == true)
        {
            goto label_80;
        }
        
        label_50:
        val_41 = null;
        val_41 = null;
        val_32 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_32 == 0)
        {
            goto label_59;
        }
        
        val_42 = null;
        val_42 = null;
        val_32 = MainMenuController.丄丞丁丈与业上丞丟;
        if((MainMenuController.丄丞丁丈与业上丞丟.<丄七三丝丄上丞丅丛>k__BackingField) == true)
        {
            goto label_80;
        }
        
        label_59:
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "RecommendDuelButtonShownOnThisDeviceKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) <= 0)
        {
                if((丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  "RecommendDuelButtonShownOnAnyDeviceKey", 丝丒上丑一三丑丐丛:  true)) == true)
        {
            goto label_80;
        }
        
        }
        
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
        {
                val_32 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
            if(val_32.丌丗丑业丁上丆万七() != true)
        {
                val_34 = 1152921505133842432;
            val_32 = BannerWindowController.与丅与丒丅专丙丐丗();
            if((val_32 != 0) && (PGCompany.ConnectSceneRollBackMigrationBanner.丌七丘七丗下丐七丞() != true))
        {
                val_32 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_32.ForceShowBanner(丌丅丕一丛丛丄一万:  27, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            val_43 = 1;
            return (bool)val_43;
        }
        
        }
        
        }
        
        label_80:
        val_43 = 0;
        return (bool)val_43;
    }
    private void 世丅丄丈丗专丅专东()
    {
        if(ProfileController.丑七不且上丗丁一世() != 0)
        {
                return;
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "ProfileGui start load");
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "ProfileGui load");
        UnityEngine.Object.DontDestroyOnLoad(target:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "ProfileGui")));
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "ProfileGui Instantiate");
    }
    private void 上与丝丙下丕丂丞丏(bool 丐万丗丒下七丟丁三)
    {
        var val_13;
        UnityEngine.GameObject val_14;
        val_13 = 丐万丗丒下七丟丁三;
        val_14 = this.mainPanel;
        if(val_14 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/"("NguiWindows/") + (val_13 != true) ? "PanelAuthSucces" : "PanelAuthFailed"((val_13 != true) ? "PanelAuthSucces" : "PanelAuthFailed")));
        val_14 = val_5.transform;
        val_14.parent = this.mainPanel.transform;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_5, 不东丛三丂丌丑专丆:  this.mainPanel.layer);
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        val_5.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        val_13 = val_5.transform;
        val_13.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void HandleClansLockedClicked()
    {
        this.HandleClansLockedClickedCore(三丂东专丕专业丏万:  true);
    }
    public void HandleClansLockedClickedCore(bool 三丂东专丕专业丏万)
    {
        var val_7;
        bool val_8 = 三丂东专丕专业丏万;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_7 = 1152921504848912384;
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if((472038892 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if(val_8 != false)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        val_8 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_8.ForceShowBanner(丌丅丕一丛丛丄一万:  22, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public void HandleClansClicked()
    {
        this.HandleClansClickedCore(三丂东专丕专业丏万:  true);
    }
    public void HandleClansClickedCore(bool 三丂东专丕专业丏万)
    {
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if((472284412 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if(三丂东专丕专业丏万 != false)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void MainMenuController::东世丏一丕丕丗丆下()))) == true)
        {
                return;
        }
        
        this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  false);
    }
    internal void 丐丐世三丆东丆丌丛()
    {
        this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  true);
    }
    private void 业丕丐丂一上丏丏不(bool 丈丈不丒丗与丝不丗 = False)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Action val_23;
        val_15 = null;
        val_15 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "ClansWindowGUI.Instance == null");
            return;
        }
        
        val_16 = null;
        val_16 = null;
        ClansController.丑丏丛不丂丄上且丈 = false;
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  丈丈不丒丗与丝不丗)) != false)
        {
                return;
        }
        
        if(与丂丅三丂且不不与.丑七不且上丗丁一世().丈丏丒丈丐丌丗上丂() == 1)
        {
                与丂丅三丂且不不与.丑七不且上丗丁一世().上丈丂丒世下丌与三();
            return;
        }
        
        val_17 = 1152921524404748272;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟业丅世丟丗丄丞万()) >= 2)
        {
            goto label_20;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        FriendsController.丄丞丁丈与业上丞丟.GetFriendsData(一丌丐万丐丒丁丏丙:  true);
        if(0 != 0)
        {
                0.SetActive(value:  false);
        }
        
        val_19 = null;
        val_19 = null;
        Rilisoft.ClanLobbyWarLeaderboardView.一下丆丌丂上丟丈且 = true;
        val_20 = null;
        val_20 = null;
        val_21 = null;
        val_21 = null;
        val_23 = MainMenuController.<>c.<>9__199_0;
        if(val_23 == null)
        {
                System.Action val_13 = null;
            val_23 = val_13;
            val_13 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::世业丏丈东与丗丒一());
            MainMenuController.<>c.<>9__199_0 = val_23;
        }
        
        ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowInterface(丄丐丙丏业丐世丐丛:  val_13);
        return;
        label_20:
        this.万下丆不三丏丆丂万();
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丁丏一专丁七丝丞();
    }
    private static string 丆丌丂上一丟不与丝(uint 丝业丌丑丌丘世下丒)
    {
        return (string)丝业丌丑丌丘世下丒 ^ 894321575.ToString(format:  "x");
    }
    internal static bool 专上三丛专万丂下万()
    {
        var val_5;
        MainMenuController val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_6 != 0)
        {
                val_7 = null;
            val_7 = null;
            val_6 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 264];
            val_6 = MainMenuController.丄丞丁丈与业上丞丟.RentExpiredPoint;
            if(val_6 != 0)
        {
                return (bool)(childCount > 0) ? 1 : 0;
        }
        
        }
        
        val_8 = 0;
        return (bool)(childCount > 0) ? 1 : 0;
    }
    internal static bool 丝丂丒且与丆丛丝丒()
    {
        return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.东不丞丗丟丞世与丛(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) < ExpController.与丁丆丂丒丌丝且丅()) ? 1 : 0;
    }
    internal bool 丑东丑丟上丘下七丘()
    {
        var val_26;
        var val_27;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                return true;
        }
        
        if(FreeAwardController.丑七不且上丗丁一世() != 0)
        {
                if((FreeAwardController.丑七不且上丗丁一世().IsInState<下丝丒东丟丂一七世>()) == false)
        {
                return true;
        }
        
        }
        
        if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
        {
                if(BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() == true)
        {
                return true;
        }
        
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return true;
        }
        
        }
        
        if(this.丌丐丅一丛丐丕丆一.丅专七丞东丐丒丒丗() == true)
        {
                return true;
        }
        
        if(this.丏丟丝丘丐丏三世丐.丅专七丞东丐丒丒丗() == true)
        {
                return true;
        }
        
        if(ProfileController.丑七不且上丗丁一世() != 0)
        {
                if(ProfileController.丑七不且上丗丁一世().InterfaceEnabled == true)
        {
                return true;
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_27 = null;
            val_27 = null;
            if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return true;
        }
        
        }
        
        if(this.stubLoading.activeInHierarchy == true)
        {
                return true;
        }
        
        if((this.<丄七三丝丄上丞丅丛>k__BackingField) == true)
        {
                return true;
        }
        
        if(this.activeInHierarchy == true)
        {
                return true;
        }
        
        if(ExchangeWindow.与丌上丄丌丐丟丟丈() == true)
        {
                return true;
        }
        
        PGCompany.TransitionController val_25 = PGCompany.TransitionController.丑七不且上丗丁一世();
        if(val_25 != null)
        {
                return val_25.一丌丛上不丑七东丐();
        }
        
        return val_25.一丌丛上不丑七东丐();
    }
    private System.Collections.IEnumerator 七丟丆丅下丙下专丈()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuController.丁丘丂丞与丝丞丆丑(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator TryToShowExpiredBanner()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuController.丄丁业丌丆丏万丟丕(丗丏丅丕丆世丁专丟:  0);
    }
    public void HandleDeveloperConsoleClicked()
    {
    
    }
    public void HandleEventHubClicked()
    {
    
    }
    public void HandleTaskBookClicked()
    {
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  38, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public void HandlePromoActionClicked(string 丒东业不丐丑丕丄丆)
    {
        var val_7;
        var val_8;
        var val_9;
        if(this.丛上不三三不与丞丑 != false)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if((473866428 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if(丒东业不丐丑丕丄丆 != null)
        {
                if((System.String.op_Equality(a:  丒东业不丐丑丕丄丆, b:  "StickersPromoActionsPanelKey")) != false)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            return;
        }
        
        }
        
        val_7 = null;
        val_7 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        int val_4 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆);
        if(val_4 != 1)
        {
                val_8 = null;
            val_8 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose = val_4;
        }
        
        val_9 = null;
        val_9 = null;
        丙且上东下丏丏丟下 val_5 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丒东业不丐丑丕丄丆, 七丆丒与丗丌丄且丂:  val_4);
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丐丟丆世三七丏丐下(与丝丕与丙不与丗丆:  val_5);
        if(val_4 == 1)
        {
                return;
        }
        
        this.HandleShopClicked(不丟丗丏丛丕不丁丌:  val_5, 丗丛不丁丑专专丂且:  0);
    }
    public bool PromoOffersPanelShouldBeShown()
    {
        var val_4;
        if(this.三三丒丅丂丝七下丁 == 0)
        {
                val_4 = (MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 0;
        return (bool)val_4 & 1;
    }
    internal void 丒丌丄丛丟丏丒世丄(System.Func<bool> 丝丛业丑专业一丁上)
    {
        if((UnityEngine.Object.op_Implicit(exists:  137105408)) != false)
        {
                if(activeInHierarchy != false)
        {
                return;
        }
        
        }
        
        UnityEngine.Rect val_5 = this.丛七专丂丈丌丂世丆();
        RilisoftRotator.丒丌丄丛丟丏丒世丄(世丟丈丏丕万丝丆万:  this.与丗丂丕丛一丛丟丌(), 丄七丛丝丏丈丒丝业:  RilisoftRotator.丙丂专一丄丞丛业上(), 丕丏丘七丗丘万丟丛:  new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height}, 丑丗丘丞丗丌三丈丆: ref  this.东世七上东丐丁丑东, 三丕丂且一丝丈三一: ref  this.东丌丆一专与丝丕丝, 丝丛业丑专业一丁上:  丝丛业丑专业一丁上);
    }
    private UnityEngine.Rect 丛七专丂丈丌丂世丆()
    {
        var val_11;
        var val_12;
        var val_13;
        if(X19.activeInHierarchy != false)
        {
                val_11 = UnityEngine.Screen.height;
            float val_9 = 0.5f;
            val_9 = (float)UnityEngine.Screen.width * val_9;
            val_12 = (float)val_11 * 0.1f;
            val_13 = (float)UnityEngine.Screen.height * 0.8f;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        
        val_11 = UnityEngine.Screen.width;
        val_12 = (float)UnityEngine.Screen.height * 0.25f;
        float val_11 = 1.4f;
        float val_10 = (float)val_11;
        val_10 = val_10 * 0.2f;
        val_11 = (float)UnityEngine.Screen.width * val_11;
        val_13 = (float)UnityEngine.Screen.height * 0.65f;
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        if(this.世丟丁不世丘丐与丑.Count >= 1)
        {
                this.东丂下且世丅与七丝();
            return;
        }
        
        mem[1152921530851018352] = 1;
    }
    internal static UnityEngine.Vector3 七业丛与且丈丟东一()
    {
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 丘不专丘上丘丟丟丆()
    {
        int val_2 = Holoville.HOTween.HOTween.Kill(p_target:  this.与丗丂丕丛一丛丟丌());
        float val_11 = this.东世七上东丐丁丑东;
        val_11 = val_11 + 1000000f;
        this.东世七上东丐丁丑东 = val_11;
        Holoville.HOTween.Tweener val_10 = Holoville.HOTween.HOTween.To(p_target:  this.与丗丂丕丛一丛丟丌(), p_duration:  0.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "localRotation", p_plugin:  new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})).Ease(p_easeType:  0).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void MainMenuController::丁业且业丙丐丙万丞())));
    }
    protected override void 与业丞丗丂业丙丌丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        this.与业丞丗丂业丙丌丂(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
        val_2 = null;
        val_2 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
    }
    private void OnEnable()
    {
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        System.Action<System.Boolean> val_30;
        var val_31;
        object val_32;
        var val_33;
        Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> val_19 = 0;
        this.OnEnable();
        if(137105408 == 0)
        {
                mem[1152921530851671408] = this.GetComponentInChildren<iPhoneXOrientationDetector>(includeInactive:  true);
        }
        
        val_26 = 0;
        goto label_4;
        label_8:
        this.GetComponentsInChildren<RewardedLikeButton>(includeInactive:  true)[0].业不不且丐且与不与();
        val_26 = 1;
        label_4:
        if(val_26 < val_3.Length)
        {
            goto label_8;
        }
        
        val_27 = null;
        val_27 = null;
        if((ExperienceController.sharedController != 0) && (this.stubLoading.activeSelf != true))
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
        {
                val_28 = null;
            val_28 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = MainMenuController.丑丒丞丘丗丗丑与丁;
        if(val_30 != null)
        {
                val_30 = MainMenuController.丑丒丞丘丗丗丑与丁;
            if(val_30 == null)
        {
                val_30 = 0;
        }
        
            val_30.Invoke(obj:  true);
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丟东丟丒三丗一与丏());
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.不一丅世丛丁不丂丛());
        this.丄丙丆业丝丏丗且丒();
        this.StopCoroutine(methodName:  "TryToShowExpiredBanner");
        UnityEngine.Coroutine val_11 = this.StartCoroutine(methodName:  "TryToShowExpiredBanner");
        if(this.丛七丌不七丐一下七 != null)
        {
                this.StopCoroutine(routine:  this.丛七丌不七丐一下七);
        }
        
        this.丛七丌不七丐一下七 = this.StartCoroutine(routine:  this.七丟丆丅下丙下专丈());
        this.丕丂丄丑东专下丙下();
        丅丂丌丗丈七业七丕.丑七不且上丗丁一世().业下上丁与丘万丌丐();
        this.丆丌丗业丕丏上丛与();
        this.丗丅三一世三丟万丑();
        val_31 = null;
        if(MainMenuController.丈一丏一丂丟三且丌() != true)
        {
                bool val_16 = Rilisoft.PushNotifications.PushNotificationHandler.丄丗丄丟丑丗与下不();
        }
        
        MainMenuController.丅丟不丝一丝万丟丂(丙业与丙丗丝不丈东:  true);
        PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.世七丈丅丁丘丈七丝();
        PGCompany.ClanWarController.丙业丛丝世丅丏丈丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuController::专丈不丘丛丅七万丙()));
        val_32 = PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世();
        if((val_32.丗丄丈丙世丘下专丘(丅丟丛丙下丙丄丒丁: out  val_19)) == false)
        {
                return;
        }
        
        val_32 = val_19;
        val_33 = val_32;
        if(MainMenuController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_32 = "[MainMenuController.OnEnable] TryProcessEvent(Disable): "("[MainMenuController.OnEnable] TryProcessEvent(Disable): ") + val_33.TryProcessEvent(ev:  11).ToString()(val_33.TryProcessEvent(ev:  11).ToString());
        UnityEngine.Debug.Log(message:  val_32);
    }
    private void 丗丅三一世三丟万丑()
    {
        bool val_6;
        var val_7;
        var val_8;
        val_6 = this;
        if((this.<丕丙丐丆丝丈三七丆>k__BackingField) == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_4;
        }
        
        val_7 = null;
        val_7 = null;
        this.丘一丅七丕丏丞丂丅 = MainMenuController.七七丈丘丏丗丏一丈 ^ 1;
        if(MainMenuController.七七丈丘丏丗丏一丈 == true)
        {
            goto label_12;
        }
        
        InfoWindowController.丟丂不丘丂下上与世(丏不丄丑丝丁丘万不:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7161"));
        goto label_12;
        label_4:
        this.丘一丅七丕丏丞丂丅 = false;
        label_12:
        val_6 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
        val_8 = null;
        val_8 = null;
        MainMenuController.七七丈丘丏丗丏一丈 = val_6;
    }
    private System.Collections.IEnumerator 丟东丟丒三丗一与丏()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuController.业丗丁丛丆丕丞七丗(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator 不一丅世丛丁不丂丛()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuController.丈专丗丗丌丂丏丁下(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丑丂丒上东丙丟丕三()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnDisable()
    {
        var val_2;
        System.Action<System.Boolean> val_3;
        PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.与丕丌丑世丘丛丞丗();
        val_2 = null;
        val_2 = null;
        val_3 = MainMenuController.丑丒丞丘丗丗丑与丁;
        if(val_3 != null)
        {
                val_3 = MainMenuController.丑丒丞丘丗丗丑与丁;
            if(val_3 == null)
        {
                val_3 = 0;
        }
        
            val_3.Invoke(obj:  false);
        }
        
        if(this.丈丛且七三丌丂丏丒 != null)
        {
                this.丈丛且七三丌丂丏丒.Cancel();
            this.丈丛且七三丌丂丏丒 = 0;
        }
        
        PGCompany.ClanWarController.东丝丞丘一丂丆丘七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainMenuController::专丈不丘丛丅七万丙()));
    }
    private void 丝东与丗丙丞丏不丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        与丂丏丛丞丞丒丟丄.丘不丅丛丁且上不丟 = false;
    }
    internal void 上世与丗丁丕丌丘上(bool 丞丕东丒丝不下上丙 = True, string 丆丟七丝丏业丅上丄, string 世丁丙世丄一万丆三 = "", System.Collections.Generic.List<BankView.BankViewTab> 丐万丂丞万丌丐丞世, bool 丁丕丈丏且丕丒丞丏 = False, PGCompany.专丟专世丅丂丁且专 上不丗业一丛丈丞且)
    {
        System.Collections.Generic.List<BankViewTab> val_30;
        object val_31;
        var val_32;
        var val_33;
        val_30 = 丐万丂丞万丌丐丞世;
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  丆丟七丝丏业丅上丄, 万丆丛世丈上丕东丗:  val_30, 世丁丙世丄一万丆三:  世丁丙世丄一万丆三, 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  上不丗业一丛丈丞且, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
            return;
        }
        
        System.Nullable<System.Boolean> val_4 = TrainingController.万丑万专丑三专丏丟();
        if((476064316 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if(this.三三丒丅丂丝七下丁 == 0)
        {
            goto label_13;
        }
        
        val_31 = "_shopInstance != null";
        goto label_24;
        label_13:
        if(BankController.丑七不且上丗丁一世() != 0)
        {
            goto label_21;
        }
        
        val_31 = "bankController == null";
        goto label_24;
        label_21:
        if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() == false)
        {
            goto label_28;
        }
        
        val_31 = "InterfaceEnabledCoroutineLocked";
        label_24:
        UnityEngine.Debug.LogWarning(message:  val_31);
        return;
        label_28:
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuController::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(丞丕东丒丝不下上丙 == false)
        {
            goto label_44;
        }
        
        val_32 = null;
        val_32 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
        {
            goto label_39;
        }
        
        val_33 = null;
        val_33 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业.gameObject.activeInHierarchy == true)
        {
            goto label_44;
        }
        
        label_39:
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        label_44:
        this.东世专七丈不上三丆 = UnityEngine.Time.realtimeSinceStartup;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(this.mainPanel != 0)
        {
                this.mainPanel.transform.root.gameObject.SetActive(value:  false);
        }
        
        if(this.丈丈丅丒丗丒且不下 != 0)
        {
                this.丈丈丅丒丗丒且不下.transform.root.gameObject.SetActive(value:  false);
        }
        
        if(val_30 == null)
        {
                val_30 = BankController.丑七不且上丗丁一世().世丂丅下丅且上丂丝();
        }
        
        BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  val_30);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丆丟七丝丏业丅上丄, 丁丕丈丏且丕丒丞丏:  丁丕丈丏且丕丒丞丏, 世丁丙世丄一万丆三:  "");
    }
    internal void 东丏且丑上丑专上不(string 世且不丏丒丞丙东丐)
    {
        ShopNGUIController val_23;
        object val_24;
        var val_25;
        var val_26;
        val_23 = 1152921505331179520;
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if((476356556 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        bool val_23 = this.丛上不三三不与丞丑;
        val_23 = val_23 + 7;
        var val_24 = ~val_23;
        val_24 = val_24 & 7;
        if(val_24 != 0)
        {
                return;
        }
        
        val_23 = this.三三丒丅丂丝七下丁;
        if(val_23 == 0)
        {
            goto label_9;
        }
        
        val_24 = "_shopInstance != null";
        goto label_20;
        label_9:
        val_23 = BankController.丑七不且上丗丁一世();
        if(val_23 != 0)
        {
            goto label_17;
        }
        
        val_24 = "bankController == null";
        goto label_20;
        label_17:
        val_23 = BankController.丑七不且上丗丁一世();
        if(val_23.上丌业丘下丞丂下丐() == false)
        {
            goto label_24;
        }
        
        val_24 = "InterfaceEnabledCoroutineLocked";
        label_20:
        UnityEngine.Debug.LogWarning(message:  val_24);
        return;
        label_24:
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuController::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_25 = null;
        val_25 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
        {
            goto label_34;
        }
        
        val_26 = null;
        val_26 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业.gameObject.activeInHierarchy == true)
        {
            goto label_39;
        }
        
        label_34:
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        label_39:
        this.东世专七丈不上三丆 = UnityEngine.Time.realtimeSinceStartup;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(this.mainPanel != 0)
        {
                this.mainPanel.transform.root.gameObject.SetActive(value:  false);
        }
        
        if(this.丈丈丅丒丗丒且不下 != 0)
        {
                this.丈丈丅丒丗丒且不下.transform.root.gameObject.SetActive(value:  false);
        }
        
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  世且不丏丒丞丙东丐, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    private void 丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        object val_17;
        var val_18;
        if(this.三三丒丅丂丝七下丁 == 0)
        {
            goto label_3;
        }
        
        val_17 = "_shopInstance != null";
        goto label_14;
        label_3:
        if(BankController.丑七不且上丗丁一世() != 0)
        {
            goto label_11;
        }
        
        val_17 = "bankController == null";
        goto label_14;
        label_11:
        if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() == false)
        {
            goto label_18;
        }
        
        val_17 = "InterfaceEnabledCoroutineLocked";
        label_14:
        UnityEngine.Debug.LogWarning(message:  val_17);
        return;
        label_18:
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MainMenuController::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        if(this.丈丈丅丒丗丒且不下 != 0)
        {
                this.丈丈丅丒丗丒且不下.transform.root.gameObject.SetActive(value:  true);
        }
        
        if(this.mainPanel != 0)
        {
                this.mainPanel.transform.root.gameObject.SetActive(value:  true);
        }
        
        if((this.<丄七三丝丄上丞丅丛>k__BackingField) != false)
        {
                ExperienceController.丌丒丘七下丐丄专东(丑丒业丘丑东丕世丅:  true);
        }
        
        val_18 = null;
        val_18 = null;
        Rilisoft.VIPController.下丈丙丞专且丂丁不 = false;
    }
    private void 三丒世丝丁不丆丝下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if((476823276 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        SetActive(value:  false);
        this.丌丐丅一丛丐丕丆一.世三丞丅丑丌丈丈一().gameObject.SetActive(value:  true);
    }
    internal void 万下丆不三丏丆丂万()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丏丟丝丘丐丏三世丐.世三丞丅丑丌丈丈一(), 丏业丟一东丂东丘丛:  true);
    }
    public void StartCampaingButton()
    {
        var val_3;
        System.Action val_5;
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if((477090284 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        Rilisoft.LobbyMiniGamesButton.不丌丁丅丗丘丈丌专();
        val_3 = null;
        val_3 = null;
        val_5 = MainMenuController.<>c.<>9__238_0;
        if(val_5 == null)
        {
                System.Action val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::丁一丏丐三业丌丏专());
            MainMenuController.<>c.<>9__238_0 = val_5;
        }
        
        val_2.Invoke();
    }
    private void 丄丈丟丁丕丕业丏丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        bool val_2 = MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false);
        if(val_2 != false)
        {
                return;
        }
        
        val_2.StartCampaingButton();
    }
    internal static void 丅与丁丌丝丒七不与()
    {
        ShopNGUIController.上万丐丞丂丐丌丛丆(丁丅丟丒丙丐丅与丂:  false);
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "CampaignLoading");
    }
    public void StartSpeedrunButton()
    {
        var val_3;
        System.Action val_5;
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if((477468380 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = MainMenuController.<>c.<>9__241_0;
        if(val_5 == null)
        {
                System.Action val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::万丂丘丛丘丝丐丄丈());
            MainMenuController.<>c.<>9__241_0 = val_5;
        }
        
        val_2.Invoke();
    }
    public void StartSurvivalButton()
    {
        var val_3;
        System.Action val_5;
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if((477589596 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = MainMenuController.<>c.<>9__242_0;
        if(val_5 == null)
        {
                System.Action val_2 = null;
            val_5 = val_2;
            val_2 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::丁丂丕丑万丄丑专且());
            MainMenuController.<>c.<>9__242_0 = val_5;
        }
        
        val_2.Invoke();
    }
    public void StartClassicArenaButton()
    {
        var val_4;
        var val_5;
        var val_6;
        System.Nullable<System.Boolean> val_1 = TrainingController.万丑万专丑三专丏丟();
        if((477709884 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_4 = null;
        val_4 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = false;
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  25);
        val_5 = null;
        val_5 = null;
        丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 = "";
        val_6 = null;
        val_6 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  0);
        StoreKitEventListener.丄丙丂丝丄丌丗丂丅().七丙世丙丅三东丐七(丙业与丙丗丝不丈东:  "In game");
        与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 = UnityEngine.Random.Range(min:  0, max:  与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length);
        MainMenuController.丅与丁丌丝丒七不与();
    }
    public void HandleClassicArenaClicked()
    {
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        bool val_2 = MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false);
        if(val_2 != false)
        {
                return;
        }
        
        val_2.StartClassicArenaButton();
    }
    public void HandleSurvivalClicked()
    {
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        bool val_2 = MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false);
        if(val_2 != false)
        {
                return;
        }
        
        val_2.StartSurvivalButton();
    }
    public void HandleSandboxClicked()
    {
        ShopNGUIController val_4 = this;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_4 = this.三三丒丅丂丝七下丁;
        if(val_4 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if((478070460 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_4 = ButtonClickSound.丆丕丝丒不丙且丐丗;
        val_4.PlayClick();
    }
    public void GoSandBox()
    {
    
    }
    public void JoinToSquadPoint(string 丅一丞万丑专丅丅与)
    {
        MainMenuController.不丆世上且丂丛丟丅 val_1 = new MainMenuController.不丆世上且丂丛丟丅();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丅一丞万丑专丅丅与 = 丅一丞万丑专丅丅与;
        this.丝丆业上世丅丞且丙.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  val_1, method:  System.Void MainMenuController.不丆世上且丂丛丟丅::丆且丂丗丐三丟且丛()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }
    public void EnterClanSquadBack()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        System.Action<Rilisoft.ClansLobbyGui> val_20;
        var val_21;
        System.Action val_23;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        val_13 = 1152921505323884544;
        val_14 = null;
        val_14 = null;
        if(SquadController.上丂七上丘且丕且丈 == 2)
        {
                val_15 = null;
            val_15 = null;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  与丂丏丛丞丞丒丟丄.丘且丝万丙丕丙丁丙)) != true)
        {
                if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丁下丆三丏丌丕业丂()) != false)
        {
                if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丆丅丟丂且丑一与丘()) == false)
        {
            goto label_14;
        }
        
        }
        
        }
        
            val_16 = null;
            val_16 = null;
            SquadController.上丂七上丘且丕且丈 = 0;
            this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  false);
            return;
        }
        
        label_14:
        val_17 = null;
        val_17 = null;
        MainMenuController.丂世丗丌丌一丐丝丛 = true;
        this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  false);
        val_18 = null;
        val_18 = null;
        val_20 = MainMenuController.<>c.<>9__250_0;
        if(val_20 == null)
        {
                System.Action<Rilisoft.ClansLobbyGui> val_9 = null;
            val_20 = val_9;
            val_9 = new System.Action<Rilisoft.ClansLobbyGui>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::不丑丒七丙专三丆世(Rilisoft.ClansLobbyGui 三丟东丕丄丄下下丑));
            MainMenuController.<>c.<>9__250_0 = val_20;
        }
        
        Rilisoft.ClansLobbyGui val_10 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.ClansLobbyGui>(丞下万上三丘上与专:  Rilisoft.ClansLobbyGui.丑七不且上丗丁一世(), 丌专业且丛丏丞丝且:  val_9);
        val_21 = null;
        val_21 = null;
        val_23 = MainMenuController.<>c.<>9__250_1;
        if(val_23 == null)
        {
                System.Action val_11 = null;
            val_23 = val_11;
            val_11 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::丛丝丘世东世丆三丂());
            MainMenuController.<>c.<>9__250_1 = val_23;
        }
        
        UnityEngine.Coroutine val_12 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  val_11, 丆丐七丅丆丗丛上与:  10f);
    }
    public void EnterClanSiege()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  false);
        Rilisoft.ClansLobbyGui val_5 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.ClansLobbyGui>(丞下万上三丘上与专:  Rilisoft.ClansLobbyGui.丑七不且上丗丁一世(), 丌专业且丛丏丞丝且:  new System.Action<Rilisoft.ClansLobbyGui>(object:  this, method:  System.Void MainMenuController::丛丛东丁丂丆下与七(Rilisoft.ClansLobbyGui 三丟东丕丄丄下下丑)));
    }
    public void EnterClanWar()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  false);
        Rilisoft.ClansLobbyGui val_5 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.ClansLobbyGui>(丞下万上三丘上与专:  Rilisoft.ClansLobbyGui.丑七不且上丗丁一世(), 丌专业且丛丏丞丝且:  new System.Action<Rilisoft.ClansLobbyGui>(object:  this, method:  System.Void MainMenuController::下丝丐不丙丁丄丑丁(Rilisoft.ClansLobbyGui 三丟东丕丄丄下下丑)));
    }
    public void EnterClanWarTestMode()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  false);
        Rilisoft.ClansLobbyGui val_5 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<Rilisoft.ClansLobbyGui>(丞下万上三丘上与专:  Rilisoft.ClansLobbyGui.丑七不且上丗丁一世(), 丌专业且丛丏丞丝且:  new System.Action<Rilisoft.ClansLobbyGui>(object:  this, method:  System.Void MainMenuController::丛上丐世丛上下丐丙(Rilisoft.ClansLobbyGui 三丟东丕丄丄下下丑)));
    }
    public void ShowConnectionToMap(SceneInfo 丄不东丁丂丅万丒丟)
    {
        var val_21;
        UnityEngine.Texture val_22;
        var val_23;
        if(this.三三丆下东丏丌丅上 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.三三丆下东丏丌丅上.gameObject);
        }
        
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        string[] val_3 = new string[5];
        val_3[0] = "LevelLoadings";
        val_3[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "";
        val_3[2] = "/Loading_";
        val_3[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : "";
        val_3[4] = 丄不东丁丂丅万丒丟.丙且上丒不下丑下丞();
        UnityEngine.Object val_10 = UnityEngine.Resources.Load(path:  +val_3);
        val_21 = null;
        val_21 = null;
        if(val_10 != null)
        {
                var val_11 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_22 = 0;
        }
        
        LoadConnectScene.上三丕下一丅丘上丝 = val_22;
        val_23 = null;
        val_23 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = LoadConnectScene.上三丕下一丅丘上丝;
        LoadConnectScene.丞丗专丝丙专丂上丗 = 丄不东丁丂丅万丒丟.丙且上丒不下丑下丞();
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        LoadingNGUIController val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
        this.三三丆下东丏丌丅上 = val_15;
        val_15.SceneToLoad = 丄不东丁丂丅万丒丟.丙且上丒不下丑下丞();
        this.三三丆下东丏丌丅上.SetLoadingTexture(与万丆丛丒万丝丙丑:  LoadConnectScene.上三丕下一丅丘上丝);
        this.三三丆下东丏丌丅上.transform.parent = this.transform;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        this.三三丆下东丏丌丅上.transform.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        this.三三丆下东丏丌丅上.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  false, 丐且丘丑与万丞丑丅:  0);
    }
    public void HideConnectionToMap()
    {
        if(this.三三丆下东丏丌丅上 != 0)
        {
                this = this.三三丆下东丏丌丅上.gameObject;
            UnityEngine.Object.Destroy(obj:  this);
        }
        
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    internal static System.Collections.IEnumerator 丝业丗上上丘丐与丗(bool 丛丑丂丛丙一上专丆 = False, bool 世不丛业丟丝与丆丙 = False, string 丑丐丗三丒世丏东丅 = "", bool 丒不丙万万不丕丞与 = False, bool 丌与一丌且一不七丆 = False, bool 丝丅与业且一丛丒一 = False, 与丂丏丛丞丞丒丟丄.丘丑丏业专丞业丆三 丁丟丑丆三丆业一丅 = 0, Rilisoft.七丕丟丏三丈一丄世 丅与丏与丙东世丌世 = 100)
    {
        MainMenuController.丗丆丏丏丆万万丒世 val_1 = new MainMenuController.丗丆丏丏丆万万丒世(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丑丐丗三丒世丏东丅 = 丑丐丗三丒世丏东丅;
            .丛丑丂丛丙一上专丆 = 丛丑丂丛丙一上专丆;
            .世不丛业丟丝与丆丙 = 世不丛业丟丝与丆丙;
            .丒不丙万万不丕丞与 = 丒不丙万万不丕丞与;
            .丌与一丌且一不七丆 = 丌与一丌且一不七丆;
            .丝丅与业且一丛丒一 = 丝丅与业且一丛丒一;
            .丁丟丑丆三丆业一丅 = 丁丟丑丆三丆业一丅;
        }
        else
        {
                mem[56] = 丛丑丂丛丙一上专丆;
            mem[40] = 世不丛业丟丝与丆丙;
            mem[48] = 丑丐丗三丒世丏东丅;
            mem[32] = 丒不丙万万不丕丞与;
            .丌与一丌且一不七丆 = 丌与一丌且一不七丆;
            .丝丅与业且一丛丒一 = 丝丅与业且一丛丒一;
            .丁丟丑丆三丆业一丅 = 丁丟丑丆三丆业一丅;
        }
        
        .丅与丏与丙东世丌世 = 丅与丏与丙东世丌世;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 丏丆丕不丗且丝万丄()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_16 = this;
        val_17 = static_value_081DACA8;
        val_17 = static_value_081DACA8;
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  static_value_081DACA8 + 184 + 16);
        val_18 = 1152921504848912384;
        if(this.mainPanel == 0)
        {
                return;
        }
        
        if(this.connectScene == 0)
        {
                return;
        }
        
        if(ClanWarUI.丈丐丞丐上丑且丕万() != false)
        {
                ClanWarUI.丑七不且上丗丁一世().万万丄丌与丐丘东三();
        }
        
        MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = false;
        BannerWindowController.与丅与丒丅专丙丐丗().ResetScene();
        val_19 = static_value_081DACA8;
        val_19 = static_value_081DACA8;
        mem2[0] = 0;
        val_20 = null;
        val_20 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = true;
        val_18 = 1152921505083416576;
        val_21 = null;
        val_21 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.mainPanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.connectScene, 丏业丟一东丂东丘丛:  true);
        this.connectScene.GetComponent<ConnectScene>().世丞丄丝专上丐丗丂();
        this.trainingHints.HideSmallHint();
        val_16 = Rilisoft.Singleton<TournamentController>.Instance;
        if(val_16.丁业世丄专一丁专丙() == false)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 35)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        SeasonEndView.丌万丗与七丄丕不丁(丕专上丁丅丅丏万丌:  transform, 丛丝与丂世丌丌丝丂:  0, 丗七丟丈三不丕一三:  Rilisoft.Singleton<TournamentController>.Instance.丄万丐丑丌三丆丝丑());
    }
    public void OnClickMultiplyerButton()
    {
        this.OnClickMultiplyerButtonCore(三丂东专丕专业丏万:  true);
    }
    public void OnClickMultiplyerButtonCore(bool 三丂东专丕专业丏万)
    {
        if(this.丛上不三三不与丞丑 != false)
        {
                return;
        }
        
        if(三丂东专丕专业丏万 != false)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.丏丆丕不丗且丝万丄();
    }
    public void HandleMultiPlayerClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) != false)
        {
                return;
        }
        
        this.OnClickMultiplyerButtonCore(三丂东专丕专业丏万:  true);
    }
    public void GoToGameModeHub(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂, PGCompany.GameModeHub.丗丙丈下上丞不丅丑 丂丛丑东不丅丈一东, PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丁丑丏丄丏七丂不)
    {
        UnityEngine.GameObject val_8;
        var val_9;
        var val_10;
        string val_11;
        val_8 = this.mainPanel;
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = this.connectScene;
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = this.三三丒丅丂丝七下丁;
        if(val_8 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_8 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_8.丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 != null)
        {
            
        }
        else
        {
                val_9 = 0;
        }
        
        if(丂丛丑东不丅丈一东 != null)
        {
            
        }
        else
        {
                val_10 = 0;
        }
        
        if(丞丁丑丏丄丏七丂不 != null)
        {
            
        }
        else
        {
                val_11 = 0;
        }
        
        PGCompany.GameModeHub.GMHMainView.下下且丅丆丐丞且丒(丗丟上上丒丐丗丞丙:  new 丝丐丝丈不且丕丈丌() {丟丑丟东丝东与丈丌 = val_11});
        this.丏丆丕不丗且丝万丄();
    }
    private void 万丌丘丕丆万丂丆上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        ShopNGUIController val_6;
        var val_7;
        val_6 = this.三三丒丅丂丝七下丁;
        if(val_6 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if((480464284 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丕上丙万丂丛三丗与(), value:  0);
        val_7 = null;
        val_7 = null;
        丟丌丁且且世丈丈丟.丆业不三丆下丄丂丑 = 0;
        丟丌丁且且世丈丈丟.与七东且丂上丛丆上 = 0;
        val_6 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
        val_6.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "SkinEditor");
    }
    private System.Collections.IEnumerator 丟丟丘七七丏上世丛(UnityEngine.GameObject 丑上一丁丐一丞丅丂, System.Threading.CancellationToken 三七丈丟一丐世与丈)
    {
        MainMenuController.丘万专三丕丝丁下丑 val_1 = new MainMenuController.丘万专三丕丝丁下丑(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丑上一丁丐一丞丅丂 = 丑上一丁丐一丞丅丂;
        }
        else
        {
                mem[32] = this;
            mem[48] = 丑上一丁丐一丞丅丂;
        }
        
        .三七丈丟一丐世与丈 = 三七丈丟一丐世与丈;
        return (System.Collections.IEnumerator)val_1;
    }
    public bool get_IsOpeningFriends()
    {
        return (bool)this.丏丅与七丞丐丒与丌;
    }
    public void GoFriendStackable()
    {
        this.丒丄业七不丂不丞丝(且丂丗七丕上丄丘与:  0, 丈丈不丒丗与丝不丗:  true);
    }
    internal void 丒丄业七不丂不丞丝(System.Action 且丂丗七丕上丄丘与, bool 丈丈不丒丗与丝不丗 = False)
    {
        bool val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_12 = 丈丈不丒丗与丝不丗;
        MainMenuController.丞丙丂丌业丄丆丄丕 val_1 = new MainMenuController.丞丙丂丌业丄丆丄丕();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .且丂丗七丕上丄丘与 = 且丂丗七丕上丄丘与;
        val_13 = null;
        val_13 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = true;
        val_14 = null;
        val_14 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "FriendsWindowController.Instance == null");
            return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  val_12)) == true)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        FriendsController.丄丞丁丈与业上丞丟.GetFriendsData(一丌丐万丐丒丁丏丙:  true);
        .专丐丟且丏丕丄丐专 = new System.Threading.CancellationTokenSource();
        val_16 = null;
        val_16 = null;
        if(MainMenuController.业万且与丘与与三丕 != true)
        {
                System.Threading.CancellationToken val_6 = (MainMenuController.丞丙丂丌业丄丆丄丕)[1152921530857686080].专丐丟且丏丕丄丐专.Token;
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丟丟丘七七丏上世丛(丑上一丁丐一丞丅丂:  0, 三七丈丟一丐世与丈:  new System.Threading.CancellationToken() {m_source = val_6.m_source}));
        }
        
        val_17 = null;
        val_17 = null;
        val_12 = FriendsWindowGUI.丆丕丝丒不丙且丐丗;
        val_12.不业丕丕丌一不丄丐(丄丐丙丏业丐世丐丛:  new System.Action(object:  val_1, method:  System.Void MainMenuController.丞丙丂丌业丄丆丄丕::丂丄丝且丏三丐丅东()));
        下丐丒丂丏一丝东丏.丑七不且上丗丁一世().丁万丑丛丘丙丏丌丙();
        且世且丄七世丗丂丑.丑七不且上丗丁一世().上丂丐且一不丞不不();
        this.丏丅与七丞丐丒与丌 = true;
    }
    internal void 丈丑丏下七世丆不万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() == true)
        {
                return;
        }
        
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_5 = TrainingController.万丑万专丑三专丏丟();
        if((481164732 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_7 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.friendsLobbyButtonSound);
        }
        
        this.丒丄业七不丂不丞丝(且丂丗七丕上丄丘与:  0, 丈丈不丒丗与丝不丗:  false);
    }
    public void HandleNewsButtonClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_8;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() != false)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_5 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.newsLobbyButtonSound);
        }
        
        this.世专丟丆丙丂丙万丂.世三丞丅丑丌丈丈一().gameObject.SetActive(value:  true);
        this.mainPanel.SetActive(value:  false);
        this.SetActive(value:  false);
    }
    internal void 丞丒丅东丞丄丝丄丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(Rilisoft.GameEventGuiHandler.丄丏丂丘丌万世丛与() == true)
        {
                return;
        }
        
        if(Rilisoft.FreeBundleBannerWindow.丌七丘七丗下丐七丞() != false)
        {
                this = BannerWindowController.与丅与丒丅专丙丐丗();
            this.ForceShowBanner(丌丅丕一丛丛丄一万:  26, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return;
        }
        
        this.丄丒丂丈丁丂且丟丒(丁丛七丞丑一丌丞丆:  new System.Nullable<Rilisoft.LobbyItemGroupType>() {HasValue = false}, 世万丐专世丕业丟东:  0);
    }
    internal void 丝丌丛与下丛七丒且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丂业专上不丌丒丆丌();
    }
    private void 万丂丗专七丅丒丕世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丛业丂丈丕丆且万下();
    }
    private void 丘丗丄丗丈七丄三丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.万丅与丞东丅丆专丕();
    }
    internal void 丄丒丂丈丁丂且丟丒(System.Nullable<Rilisoft.LobbyItemGroupType> 丁丛七丞丑一丌丞丆, string 世万丐专世丕业丟东)
    {
        ShopNGUIController val_11;
        var val_12;
        var val_13;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_11 = this.三三丒丅丂丝七下丁;
        if(val_11 != 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_13 = null;
            val_13 = null;
            val_11 = FriendsWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_11.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        val_11 = this.mainPanel;
        if(val_11 == 0)
        {
                return;
        }
        
        val_11 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_11 == 0)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_7 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.craftLobbyButtonSound);
        }
        
        this.mainPanel.SetActive(value:  false);
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.不业丕丕丌一不丄丐();
        this.丑丂丒上东丙丟丕三();
        val_11 = Rilisoft.BackSystem.丑七不且上丗丁一世();
        this.丐丆七且丞丏下三丙 = val_11.Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void MainMenuController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Main Menu Controller");
        if((482066200 & 1) == 0)
        {
                return;
        }
        
        val_11;
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丐丟业丏丕东丗下一(一丐丅且丛不不丌丗:  丁丛七丞丑一丌丞丆.HasValue, 丗丒世丒东丆丅一七:  true, 世万丐专世丕业丟东:  世万丐专世丕业丟东);
    }
    public void GoToProfile()
    {
        if(ProfileController.丑七不且上丗丁一世() != 0)
        {
                ProfileController.丑七不且上丗丁一世().SetStaticticTab(丈丒丅上丗丅丙下丞:  0);
        }
        
        this.万丅与丞东丅丆专丕();
    }
    internal void 万丅与丞东丅丆专丕()
    {
        var val_11;
        var val_12;
        val_11 = this;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_4 = TrainingController.万丑万专丑三专丏丟();
        if((482372268 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        this.世丅丄丈丗专丅专东();
        if(ProfileController.丑七不且上丗丁一世() == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "ProfileController.Instance == null");
            return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.profileLobbyButtonSound);
        }
        
        val_11 = ProfileController.丑七不且上丗丁一世();
        val_11.ShowInterface();
    }
    internal void 丆七丌三丈丕丅丗专()
    {
        this.mainMenuPanel.tasksBtn.gameObject.SetActive(value:  false);
    }
    internal void 丂业专上不丌丒丆丌()
    {
        UnityEngine.GameObject val_5;
        this.trainingHints.HideSmallHint();
        if(this.丐七不丑丗三丈丆专 != 0)
        {
                return;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "Kek/kek_armory");
        if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        UnityEngine.GameObject val_4 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.mainPanel, 丑且不丕与专丄业丙:  val_5);
    }
    internal void 丛业丂丈丕丆且万下()
    {
        UnityEngine.GameObject val_11;
        this.trainingHints.HideSmallHint();
        if(this.丐七不丑丗三丈丆专 == 0)
        {
                UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "NguiWindows/Tasks");
            if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_11 = 0;
        }
        
            this.丐七不丑丗三丈丆专 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.mainPanel, 丑且不丕与专丄业丙:  val_11).GetComponent<TasksWindow>();
            this.taskWindowHintPoint.gameObject.SetActive(value:  true);
            this.taskWindowHintPoint.parent = this.丐七不丑丗三丈丆专.taskItem.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.taskWindowHintPoint.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
            this.taskWindowHintPoint.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            this.taskWindowHintPoint.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        
        this.丐七不丑丗三丈丆专.ShowWindow();
    }
    private void 丒丈专丛丟上上东丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_4 = this;
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if((483054988 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        this.SetActive(value:  false);
    }
    private void 世丙丐世丐丆且丗丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
    
    }
    public void HandleResumeFromShopCore(bool 丞七丅丏丁丘世丌丙 = True)
    {
        ShopNGUIController val_6;
        var val_7;
        val_6 = this.三三丒丅丂丝七下丁;
        if(val_6 == 0)
        {
            goto label_3;
        }
        
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        val_7 = null;
        val_7 = null;
        val_6 = MainMenuController.<>c.<>9__287_0;
        if(val_6 == null)
        {
            goto label_8;
        }
        
        label_19:
        this.三三丒丅丂丝七下丁.丏丐世且丑丅丘丅丟 = val_6;
        this.三三丒丅丂丝七下丁 = 0;
        if(丞七丅丏丁丘世丌丙 != false)
        {
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  MainMenuController.七三丏下丏丁丝丒丙());
        }
        
        this.丟丙且丝万与不丑丐();
        label_3:
        Rilisoft.丛丅丘业丏丕下业丏.丑七不且上丗丁一世().世世三不丏与丌与专();
        return;
        label_8:
        MainMenuController.<>c.<>9__287_0 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::一丞丒丒丆丅丄丌丞());
        if(this.三三丒丅丂丝七下丁 != null)
        {
            goto label_19;
        }
        
        goto label_19;
    }
    internal void 丞丈丏丈世丛丒丛丞()
    {
        this.HandleResumeFromShopCore(丞七丅丏丁丘世丌丙:  true);
    }
    private static System.Collections.IEnumerator 七三丏下丏丁丝丒丙()
    {
        return (System.Collections.IEnumerator)new MainMenuController.一且丒世丗丞丝丈下(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 与东丒业丈丒丛世万(丙且上东下丏丏丟下 丑丝丏丂且不下一东, CategoryNames 一专七丟丏且丑丄下, FilterMaps 丝丗丙丞丙丕万业下 = -1, bool 万且丟七不上丗丑丝 = False)
    {
        this.丐专丕丂丗丙丆丄丌(丑丝丏丂且不下一东:  丑丝丏丂且不下一东, 一专七丟丏且丑丄下:  一专七丟丏且丑丄下, 丏丐世且丑丅丘丅丟:  0, 万且丟七不上丗丑丝:  万且丟七不上丗丑丝, 丄丕三丞一丌与与丅:  true, 专丆丌丛东一不丑丙:  丝丗丙丞丙丕万业下, 丈丈不丒丗与丝不丗:  true, 丌丂丁七丏不丂丁上:  true);
    }
    internal void 丐专丕丂丗丙丆丄丌(丙且上东下丏丏丟下 丑丝丏丂且不下一东, CategoryNames 一专七丟丏且丑丄下, System.Action 丏丐世且丑丅丘丅丟, bool 万且丟七不上丗丑丝 = False, bool 丄丕三丞一丌与与丅 = False, FilterMaps 专丆丌丛东一不丑丙 = -1, bool 丈丈不丒丗与丝不丗 = False, bool 丌丂丁七丏不丂丁上 = True)
    {
        UnityEngine.AudioClip val_13;
        System.Action val_14;
        CategoryNames val_15;
        丙且上东下丏丏丟下 val_16;
        bool val_17;
        var val_18;
        var val_19;
        val_13 = 万且丟七不上丗丑丝;
        val_14 = 丏丐世且丑丅丘丅丟;
        val_15 = 一专七丟丏且丑丄下;
        val_16 = 丑丝丏丂且不下一东;
        MainMenuController.丆一一丈丝丐七与万 val_1 = new MainMenuController.丆一一丈丝丐七与万();
        if(val_1 != null)
        {
                val_17 = val_1;
            .丏丐世且丑丅丘丅丟 = val_14;
        }
        else
        {
                val_17 = 16;
            mem[16] = val_14;
        }
        
        .丝且与丝丒丟万丁专 = this;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_14 = this.三三丒丅丂丝七下丁;
        if(val_14 != 0)
        {
                return;
        }
        
        if(丄丕三丞一丌与与丅 != true)
        {
                if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  丈丈不丒丗与丝不丗)) == true)
        {
                return;
        }
        
        }
        
        if(val_17 == 0)
        {
                mem[16] = new System.Action(object:  this, method:  System.Void MainMenuController::丞丈丏丈世丛丒丛丞());
        }
        
        val_17 = 1152921505331179520;
        System.Nullable<System.Boolean> val_6 = TrainingController.万丑万专丑三专丏丟();
        if((483902172 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_14 = 1152921505261211648;
        val_18 = null;
        val_18 = null;
        this.三三丒丅丂丝七下丁 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                if(val_13 != false)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_13 = this.lobbySoundButton.arsenalLobbyButtonSound;
            UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_13);
        }
        
        }
        
            if(丈丈不丒丗与丝不丗 != false)
        {
                val_13 = PGCompany.TransitionController.丑七不且上丗丁一世();
            val_13.丗丝上一不三东丁专(不丌不世且丄不三丝:  this.三三丒丅丂丝七下丁);
        }
        
            this.三三丒丅丂丝七下丁.丝丞与丄丆业丛丏专(丗丛不丁丑专专丂且:  false);
            val_19 = null;
            val_19 = null;
            val_17 = 丌丂丁七丏不丂丁上;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丐丟丆世三七丏丐下(与丝丕与丙不与丗丆:  val_16);
            val_16 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose = val_15;
            ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  专丆丌丛东一不丑丙, 丌丂丁七丏不丂丁上:  val_17);
            System.Action val_12 = null;
            val_15 = val_12;
            val_12 = new System.Action(object:  val_1, method:  System.Void MainMenuController.丆一一丈丝丐七与万::世东专丈丂丁与丏丒());
            this.三三丒丅丂丝七下丁.丏丐世且丑丅丘丅丟 = val_15;
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "HandleEnterShopWithDesiredItem == null");
    }
    internal void 丕丙丌东丆丂与专丂(System.Action 丏丐世且丑丅丘丅丟)
    {
        this.丐专丕丂丗丙丆丄丌(丑丝丏丂且不下一东:  System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  176, 丙丑丄与丅丐一不东:  true)), 一专七丟丏且丑丄下:  176, 丏丐世且丑丅丘丅丟:  0, 万且丟七不上丗丑丝:  false, 丄丕三丞一丌与与丅:  true, 专丆丌丛东一不丑丙:  0, 丈丈不丒丗与丝不丗:  true, 丌丂丁七丏不丂丁上:  true);
    }
    public void HandleShopClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        bool val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_12 = 1152921504848912384;
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if((484266620 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        val_13 = null;
        val_13 = null;
        this.三三丒丅丂丝七下丁 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.arsenalLobbyButtonSound);
        }
        
            this.三三丒丅丂丝七下丁.丝丞与丄丆业丛丏专(丗丛不丁丑专专丂且:  false);
            PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this.三三丒丅丂丝七下丁);
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  164)) != false)
        {
                val_14 = null;
            val_14 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
                val_14 = null;
        }
        
            ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose = 0;
            val_15 = null;
            val_15 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丐丟丆世三七丏丐下(与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  与世丁丙且丑下丌不.七丒丞丙丏三业丐丙, 七丆丒与丗丌丄且丂:  0));
        }
        
            val_12 = true;
            ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
            this.三三丒丅丂丝七下丁.丏丐世且丑丅丘丅丟 = new System.Action(object:  this, method:  System.Void MainMenuController::丞丈丏丈世丛丒丛丞());
            ShopNGUIController.丞业丙三丙丄丏丞丘 = val_12;
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "sharedShop == null");
    }
    public void U_OpenUserCharactersWindowFromSettings()
    {
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  public System.Void MainMenuController::OpenCharactersWindowFromSettings()))) != false)
        {
                return;
        }
        
        this.OpenCharactersWindowFromSettings();
    }
    public void OpenCharactersWindowFromSettings()
    {
        this.rotateCamera.PlayOpenCharacters();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rotateCamera, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainPanel, 丏业丟一东丂东丘丛:  false);
        this.EnableUserCharactersWindow(丑丒业丘丑东丕世丅:  true, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void MainMenuController::GoBackFromUserCharactersToOptions()));
        if(AnimationGift.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
    }
    public void OpenUserCharactersWindowFromLobby()
    {
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
        {
                return;
        }
        
        this.rotateCamera.PlayOpenCharacters();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainPanel, 丏业丟一东丂东丘丛:  false);
        this.EnableUserCharactersWindow(丑丒业丘丑东丕世丅:  true, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void MainMenuController::GoBackFromUserCharactersToLobby()));
        this = AnimationGift.丄丘七三上丕世丞业;
        if(this == 0)
        {
                return;
        }
        
        AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
    }
    public void EnableUserCharactersWindow(bool 丑丒业丘丑东丕世丅, System.Action 丛丝与丂世丌丌丝丂)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丟丙丗七与丆且与丞.世三丞丅丑丌丈丈一(), 丏业丟一东丂东丘丛:  丑丒业丘丑东丕世丅);
        UserCharacterMainWindow val_3 = this.丟丙丗七与丆且与丞.世三丞丅丑丌丈丈一();
        val_3.三丁丕丈丅丏丅丕丌 = 丛丝与丂世丌丌丝丂;
        bool val_6 = 丑丒业丘丑东丕世丅 ^ 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.与丗丂丕丛一丛丟丌().gameObject, 丏业丟一东丂东丘丛:  val_6);
        PersConfigurator val_9 = this.与丗丂丕丛一丛丟丌().GetComponent<PersConfigurator>();
        if(val_9 == 0)
        {
                return;
        }
        
        if(val_9.丗丛丄丁丛丅与丘丐() == 0)
        {
                return;
        }
        
        bool val_15 = val_6;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9.丗丛丄丁丛丅与丘丐().丐丁丟丏丄东不丘丒(), 丏业丟一东丂东丘丛:  val_15);
        val_9.EnableShadow(丑丒业丘丑东丕世丅:  val_15);
    }
    public void GoBackFromUserCharactersToOptions()
    {
        this.rotateCamera.PlayOpenOptions();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rotateCamera, 丏业丟一东丂东丘丛:  true);
        this.EnableUserCharactersWindow(丑丒业丘丑东丕世丅:  false, 丛丝与丂世丌丌丝丂:  0);
        if(AnimationGift.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
    }
    public void GoBackFromUserCharactersToLobby()
    {
        this.rotateCamera.PlayCloseCharacters();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mainPanel, 丏业丟一东丂东丘丛:  true);
        this.EnableUserCharactersWindow(丑丒业丘丑东丕世丅:  false, 丛丝与丂世丌丌丝丂:  0);
        if(AnimationGift.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
    }
    public void HandleSocialClicked()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        SettingsController.丙万丞丄与丂丑七专 = true;
        val_2 = null;
        val_2 = null;
        MainMenuFreePanel.丄丂丘丑万东七不丘 = true;
        this.丆世世丈七丌丈丁丂();
        Rilisoft.一丟专且三万丞丁丂.专丕丒万业一丑丗丙(丝丏业丅丈东业丝丒:  "Tap Lobby");
    }
    internal void 专丕与丙丆丕丝丘丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丆世世丈七丌丈丁丂();
    }
    internal void 丘丘丕丘丟业世丗丂()
    {
        SettingsWindowManager val_3;
        this.丆世世丈七丌丈丁丂();
        val_3 = SettingsWindowManager.丆丕丝丒不丙且丐丗;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        val_3 = mem[SettingsWindowManager.丆丕丝丒不丙且丐丗 + 96];
        val_3 = SettingsWindowManager.丆丕丝丒不丙且丐丗.tabsContainer;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        与丐且业丛丌不丄丑(丟专丛丏丝万丘丄丗:  "Account");
    }
    internal void 丆世世丈七丌丈丁丂()
    {
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if(this.三三丒丅丂丝七下丁 != 0)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_4 = TrainingController.万丑万专丑三专丏丟();
        if((485677644 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.settingsLobbyButtonSound);
        }
        
        this.rotateCamera.PlayOpenOptions();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丈丘丗丒丁丘丏丞丝());
    }
    private System.Collections.IEnumerator 丈丘丗丒丁丘丏丞丝()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MainMenuController.丕丝丟丒丞且丒东丗(丗丏丅丕丆世丁专丟:  0);
    }
    public void RateUs()
    {
        var val_6 = null;
        if(MainMenuController.丙丏丝丟丞丐丘丑三() == true)
        {
                return;
        }
        
        if((MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
        if((485946716 & 1) != 0)
        {
                TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        丌丏丏丄丁世丐丄丑.丑七不且上丗丁一世().丟丂下丏丛世丐专业(丙业与丙丗丝不丈东:  true);
        UnityEngine.Application.OpenURL(url:  丄丛丏丄不一丆丐丑.丅丙业上丄不丘丝三());
    }
    internal static void 丕七一丒丆不与丏丑(bool 丝三丄专丗丞丄丄丌)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        enabled = 丝三丄专丗丞丄丄丌;
    }
    public void OnShowBannerGift()
    {
        BannerWindowController val_1 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.ForceShowBanner(丌丅丕一丛丛丄一万:  14, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public void HandleLeaderboardsClicked()
    {
        if((Rilisoft.Singleton<ClansVisitController>.Instance) != 0)
        {
                ClansVisitController val_3 = Rilisoft.Singleton<ClansVisitController>.Instance;
            val_3.丈万丂丘丂下丒丌七 = 1;
        }
        
        this.丙七丄与与万世丞丏(世下不上丛丅丌一七:  this.mainPanel, 丐丅丒专丛丏上与业:  3, 三丂东专丕专业丏万:  true);
    }
    internal void 丙七丄与与万世丞丏(UnityEngine.GameObject 世下不上丛丅丌一七, LeaderboardsGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业 = 3, bool 三丂东专丕专业丏万 = True)
    {
        var val_9;
        FriendsWindowGUI val_10;
        var val_11;
        MainMenuController.七丕丞丝丙专七丛丞 val_1 = new MainMenuController.七丕丞丝丙专七丛丞();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .世下不上丛丅丌一七 = 世下不上丛丅丌一七;
        if(世下不上丛丅丌一七 != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        if(世下不上丛丅丌一七.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        if((this.<丄七三丝丄上丞丅丛>k__BackingField) == false)
        {
            goto label_5;
        }
        
        return;
        label_1:
        mem[16] = 世下不上丛丅丌一七;
        if(mem[16] != 0)
        {
            goto label_6;
        }
        
        goto label_7;
        label_5:
        val_9 = null;
        val_9 = null;
        val_10 = FriendsWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_10 != 0)
        {
                val_11 = null;
            val_11 = null;
            val_10 = FriendsWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_10.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(Rilisoft.GameEventGuiHandler.丄丏丂丘丌万世丛与() == true)
        {
                return;
        }
        
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (三丂东专丕专业丏万 != false))
        {
                UnityEngine.AudioSource val_7 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.topLobbyButtonSound);
        }
        
        LeaderboardsGui.丌万丗与七丄丕不丁(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丛丝与丂世丌丌丝丂:  new System.Action(object:  val_1, method:  System.Void MainMenuController.七丕丞丝丙专七丛丞::一丞丂且丈七丑且七()));
        .世下不上丛丅丌一七.SetActive(value:  false);
    }
    private System.Collections.IEnumerator 丘且与丘下一世丁上(System.Threading.Tasks.Task 万不且且丛丆东丒业, System.Action<System.Threading.Tasks.Task> 七丆丘上专丞上丟丗)
    {
        MainMenuController.东丅下且丑丌丅与与 val_1 = new MainMenuController.东丅下且丑丌丅与与(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .万不且且丛丆东丒业 = 万不且且丛丆东丒业;
        }
        else
        {
                mem[32] = 万不且且丛丆东丒业;
        }
        
        .七丆丘上专丞上丟丗 = 七丆丘上专丞上丟丗;
        return (System.Collections.IEnumerator)val_1;
    }
    internal bool 丂丙丈与世专上丒上()
    {
        return (bool)this.丛上不三三不与丞丑;
    }
    private bool 丄丆七丑丘且下上丟()
    {
        if(activeInHierarchy == true)
        {
                return (bool)0 & 1;
        }
        
        if(activeInHierarchy != true)
        {
                if((this.<丄七三丝丄上丞丅丛>k__BackingField) == false)
        {
            goto label_5;
        }
        
        }
        
        return (bool)0 & 1;
        label_5:
        if(FeedbackMenuController.丑七不且上丗丁一世() == 0)
        {
                return (bool)0 & 1;
        }
        
        bool val_9 = FeedbackMenuController.丑七不且上丗丁一世().gameObject.activeInHierarchy ^ 1;
        return (bool)0 & 1;
    }
    private void 丟不丅万丝丕丈丌一()
    {
        if(BalanceController.下丂万丐丄丅七一东() != null)
        {
                if(this.丄丆七丑丘且下上丟() == true)
        {
            goto label_27;
        }
        
        }
        
        if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().业丟丁与与丑丂丘丞() != true)
        {
                if(Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().Count <= 0)
        {
                if(Rilisoft.VIPController.丌丏丄专丘丕丑上且() == false)
        {
            goto label_16;
        }
        
        }
        
        }
        
        label_27:
        label_33:
        if(Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        if(1 == Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世().Enabled)
        {
                return;
        }
        
        Rilisoft.InAppBonusLobbyController.丑七不且上丗丁一世().Enabled = true;
        return;
        label_16:
        if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance) != 0)
        {
                if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) == true)
        {
            goto label_27;
        }
        
        }
        
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
        {
            goto label_33;
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_24 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        val_24 = val_24.专丁丟丏丁丏不丗三();
        goto label_33;
    }
    internal static bool 世丂七上与丈丈丗上()
    {
        null = null;
        return (bool)MainMenuController.丌下丗万丗丝不丅业;
    }
    internal UnityEngine.GameObject 专丑丆不不专七丝下()
    {
        return (UnityEngine.GameObject)this._subwindowsHandler;
    }
    private void 丁丞丝且丞丛不丄丕()
    {
        this.connectScene.SetActive(value:  true);
    }
    public void LoadSquadPanel()
    {
        UnityEngine.GameObject val_29;
        if(this.世丆丂上丛丈丅丘东 != 0)
        {
                return;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "ConnectScene/PanelSquad2");
        if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_29 = 0;
        }
        
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_29);
        this.世丆丂上丛丈丅丘东 = val_4;
        val_4.transform.parent = this.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        this.世丆丂上丛丈丅丘东.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        this.世丆丂上丛丈丅丘东.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        this.世丆丂上丛丈丅丘东.SetActive(value:  false);
        UnityEngine.GameObject val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  (null == null) ? UnityEngine.Resources.Load(path:  "ConnectScene/SquadInviteGui") : 0);
        this.丘丒丒丅七丅七丒丑 = val_13;
        val_13.transform.parent = this.transform;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
        this.丘丒丒丅七丅七丒丑.transform.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        this.丘丒丒丅七丅七丒丑.transform.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        this.丘丒丒丅七丅七丒丑.SetActive(value:  false);
        UnityEngine.GameObject val_22 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  (null == null) ? UnityEngine.Resources.Load(path:  "NguiWindows/Clan/ClanParty") : 0);
        this.万万一丁丆世丄业万 = val_22;
        val_22.transform.parent = this.transform;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
        this.万万一丁丆世丄业万.transform.localScale = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
        this.万万一丁丆世丄业万.transform.localPosition = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        this.万万一丁丆世丄业万.SetActive(value:  false);
    }
    internal System.Collections.Generic.List<int> 丞丅东丄丁丝丕丘三()
    {
        return System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Except<System.Int32>(first:  MainMenuController.丒七丁丏三丟不业丅(), second:  this.shownMinigameModes));
    }
    internal void 丁七丆丏三丆丞丛且(int 丂丛丑东不丅丈一东)
    {
        if((this.shownMinigameModes.Contains(item:  丂丛丑东不丅丈一东)) != false)
        {
                return;
        }
        
        this.shownMinigameModes.Add(item:  丂丛丑东不丅丈一东);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "MainMenuController.MINIGAME_SHOWN_MODES_KEY", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.shownMinigameModes));
    }
    internal static void 丄丗丙三丂万三上丄()
    {
        var val_7;
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Union<System.Int32>(first:  MainMenuController.丌丁专丐丑下丒丈丁(), second:  MainMenuController.丒七丁丏三丟不业丅()));
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "MainMenuController.MINIGAME_SHOWN_MODES_KEY", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4));
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        MainMenuController.丄丞丁丈与业上丞丟.shownMinigameModes = val_4;
    }
    private static System.Collections.Generic.List<int> 丒七丁丏三丟不业丅()
    {
        null = null;
        return System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(source:  System.Linq.Enumerable.Where<Rilisoft.七丕丟丏三丈一丄世>(source:  GameConnect.丘丗世专不丅与丗丒, predicate:  new System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Boolean>(object:  0, method:  static System.Boolean MainMenuController::丛丐丈业丕一丅丙世(Rilisoft.七丕丟丏三丈一丄世 专万丒万丛与万丅且))), selector:  new System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Int32>(object:  0, method:  static System.Int32 MainMenuController::丒丝世丏三丂一丑丐(Rilisoft.七丕丟丏三丈一丄世 专万丒万丛与万丅且))));
    }
    private static bool 丛丐丈业丕一丅丙世(Rilisoft.七丕丟丏三丈一丄世 专万丒万丛与万丅且)
    {
        var val_4;
        if(专万丒万丛与万丅且 == 11)
        {
                val_4 = 1;
        }
        else
        {
                bool val_2 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  专万丒万丛与万丅且);
            val_4 = val_2 ^ 1;
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    private static int 丒丝世丏三丂一丑丐(Rilisoft.七丕丟丏三丈一丄世 专万丒万丛与万丅且)
    {
        return (int)专万丒万丛与万丅且;
    }
    private static string 丟业丙丗世丄丟丞且()
    {
        return "shown-our-likes-key-"("shown-our-likes-key-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }
    public void ShowNewBalanceBanner_12_5()
    {
        var val_12;
        var val_13;
        var val_14;
        val_12 = this;
        val_13 = null;
        val_13 = null;
        if(MainMenuController.丕专与专丈丘丑且丕 != 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        MainMenuController.丕专与专丈丘丑且丕 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/NewBalanceBanner"));
        MainMenuController.丕专与专丈丘丑且丕.transform.parent = this.RentExpiredPoint;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  MainMenuController.丕专与专丈丘丑且丕, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "NGUI"));
        MainMenuController.丕专与专丈丘丑且丕.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        MainMenuController.丕专与专丈丘丑且丕.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        MainMenuController.丕专与专丈丘丑且丕.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "_12_5_Banner_shown_key_V4", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        val_12 = MainMenuController.丕专与专丈丘丑且丕.GetComponent<NewGameBalance12_5WindowController>();
        丏且且与三丙丘丒三 val_11 = ClientUpdateBannerWindow.业丝上东世世七万业();
        if(val_12 != null)
        {
                val_10.ContentType = val_11;
        }
        else
        {
                mem[72] = val_11;
        }
        
        val_12.Show(丑丒丄万丅丛丗丛丕:  true);
    }
    private void 丟与丏且丁丈万丁一()
    {
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
        {
                return;
        }
        
        丄上三丛丛上一业三.丑七不且上丗丁一世().丈且丑万丌专丗世世();
        且世且丄七世丗丂丑.丑七不且上丗丁一世().丈且丑万丌专丗世世();
        if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                Rilisoft.Singleton<TournamentController>.Instance.东丙丗万下丌不下丏();
        }
        
        丄三万丑丑东且丁丙.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上());
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                丄三万丑丑东且丁丙.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丌丂丑上七丄一且());
        }
        
        PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().丘下丙丟丅且一丗丈();
        PGCompany.GiftSystem.业三东上与丁丁专三.丑七不且上丗丁一世().下七东业一丄专丌七();
    }
    private void 上丘丟丝丏丐丗万且()
    {
        丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丝丑丛万丟丝三上世();
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                丄三万丑丑东且丁丙.丑七不且上丗丁一世().丅丌丁专专东世丌丕(丅下丏丙丞东丒丕丁:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丌丂丑上七丄一且());
        }
        
        丂与专万与丐丌丏不.丑七不且上丗丁一世().丁丑业丕七丛三一丏();
        TournamentController.三丘与丈丒世丒与一();
    }
    private void Update()
    {
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        bool val_58;
        UnityEngine.GameObject val_59;
        var val_60;
        var val_61;
        var val_62;
        System.Action val_64;
        this.丟不丅万丝丕丈丌一();
        if(((this.<丄七三丝丄上丞丅丛>k__BackingField) == false) || (this.stubLoading.activeSelf == true))
        {
            goto label_26;
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
            goto label_26;
        }
        
        }
        
        val_54 = null;
        val_54 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
            goto label_17;
        }
        
        val_55 = null;
        val_55 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad == true)
        {
            goto label_26;
        }
        
        label_17:
        val_56 = null;
        val_56 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_57 = null;
            val_57 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        label_26:
        if((BankController.丑七不且上丗丁一世() != 0) && (BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false))
        {
                val_58 = 0;
        }
        else
        {
                val_58 = (~ShopNGUIController.丛世丛与丌不丈丐丐()) & 1;
        }
        
        val_59 = this.mainMenuPanel.starParticleStarterPackGaemObject;
        if(val_59 != 0)
        {
                val_59 = this.mainMenuPanel.starParticleStarterPackGaemObject;
            bool val_16 = val_59.activeInHierarchy;
            if(val_58 != val_16)
        {
                val_59 = this.mainMenuPanel.starParticleStarterPackGaemObject;
            val_59.SetActive(value:  val_58);
        }
        
        }
        
        float val_17 = UnityEngine.Time.realtimeSinceStartup;
        val_17 = val_17 - this.丁丛三丁三七丏丙且;
        if(val_17 >= 0.5f)
        {
                this.丁丛三丁三七丏丙且 = UnityEngine.Time.realtimeSinceStartup;
        }
        
        if(val_16 == false)
        {
            goto label_52;
        }
        
        val_60 = null;
        val_60 = null;
        if(val_59.activeSelf == false)
        {
            goto label_56;
        }
        
        MainMenuController.丄丞丁丈与业上丞丟.SetActive(value:  false);
        if(MainMenuController.丄丞丁丈与业上丞丟 != null)
        {
            goto label_70;
        }
        
        label_71:
        label_70:
        MainMenuController.丄丞丁丈与业上丞丟.SetActive(value:  true);
        label_140:
        mem[1152921530866277136] = 0;
        label_52:
        if(this.rotateCamera != 0)
        {
                if(this.rotateCamera.丘丈丙专上上三上丒() != true)
        {
                this.丒丌丄丛丟丏丒世丄(丝丛业丑专业一丁上:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean MainMenuController::丟丛丂丘丁丘丈丙世()));
        }
        
        }
        
        val_61 = null;
        val_61 = null;
        if((UnityEngine.Time.realtimeSinceStartup - this.东世七上东丐丁丑东) <= ShopNGUIController.上丈丂丁三丂业丛丝)
        {
                return;
        }
        
        this.丘不专丘上丘丟丟丆();
        return;
        label_56:
        if(this.世专丟丆丙丂丙万丂.丅专七丞东丐丒丒丗() == false)
        {
            goto label_68;
        }
        
        this.世专丟丆丙丂丙万丂.丙不丂丝丒丐专丝丆();
        if(this.mainPanel != null)
        {
            goto label_70;
        }
        
        goto label_71;
        label_68:
        BannerWindowController val_26 = BannerWindowController.与丅与丒丅专丙丐丗();
        if((val_26 == 0) || (BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() == false))
        {
            goto label_80;
        }
        
        if(BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner.type == 31)
        {
                if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false)
        {
            goto label_140;
        }
        
        }
        
        if(BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner.type == 60)
        {
            goto label_140;
        }
        
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丁丏一专丁七丝丞();
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
        goto label_140;
        label_80:
        if(val_26 != 0)
        {
                if(val_26.activeInHierarchy == true)
        {
            goto label_140;
        }
        
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
            goto label_140;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
            goto label_140;
        }
        
        if(ProfileController.丑七不且上丗丁一世() != 0)
        {
                if(ProfileController.丑七不且上丗丁一世().InterfaceEnabled == true)
        {
            goto label_140;
        }
        
        }
        
        if((MainMenuController.丄丞丁丈与业上丞丟 == 0) || ((MainMenuController.丄丞丁丈与业上丞丟.<丄七三丝丄上丞丅丛>k__BackingField) == false))
        {
            goto label_129;
        }
        
        MainMenuController.丄丞丁丈与业上丞丟.OnClickBackMiniGamesButton();
        goto label_140;
        label_129:
        val_62 = null;
        val_62 = null;
        val_64 = MainMenuController.<>c.<>9__337_0;
        if(val_64 == null)
        {
                System.Action val_51 = null;
            val_64 = val_51;
            val_51 = new System.Action(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MainMenuController.<>c::丕与丕东七下丞丟下());
            MainMenuController.<>c.<>9__337_0 = val_64;
        }
        
        InfoWindowController.丕丌丞七丛三一丌万(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3463"), 东不丒丗万丏世世丒:  val_51, 丏丙且东丑上丗丏丛:  0);
        goto label_140;
    }
    private bool 丟丛丂丘丁丘丈丙世()
    {
        var val_13;
        var val_14;
        bool val_15;
        val_13 = this;
        val_14 = null;
        val_14 = null;
        val_15 = MainMenuController.丞且丙丛丞不世专七;
        if(val_15 == false)
        {
                return (bool)val_15 & 1;
        }
        
        if(((ShopNGUIController.丛世丛与丌不丈丐丐() == true) || (this.activeInHierarchy == true)) || (ConnectScene.丈丘丂丙不丛业丟三() == true))
        {
            goto label_11;
        }
        
        if(ChooseMiniGameController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_17;
        }
        
        val_13 = ChooseMiniGameController.丄丞丁丈与业上丞丟.gameObject;
        if(val_13.activeInHierarchy == false)
        {
            goto label_17;
        }
        
        label_11:
        val_15 = 0;
        return (bool)val_15 & 1;
        label_17:
        if(PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世() == 0)
        {
                return (bool)val_15 & 1;
        }
        
        bool val_13 = PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世().gameObject.activeInHierarchy ^ 1;
        return (bool)val_15 & 1;
    }
    public void PlayVideo()
    {
        ModalBannerHolder val_1 = ModalBannerHolder.丑七不且上丗丁一世();
        val_1.mainStoreHolder.ShowBanner(丌丅丕一丛丛丄一万:  106, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public void HandlePremiumClicked()
    {
    
    }
    internal bool 一丑丟世丛丌丁下不()
    {
        return (bool)this.<丄七三丝丄上丞丅丛>k__BackingField;
    }
    private void 丂丘丒丟丁且一丗丆(bool 丙业与丙丗丝不丈东)
    {
        this.<丄七三丝丄上丞丅丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void OnClickMiniGamesButton()
    {
        if(this.丛上不三三不与丞丑 != false)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        ButtonClickSound.丆丕丝丒不丙且丐丗.StartCampaingButton();
    }
    public void OnClickBackMiniGamesButton()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  MainMenuController.七三丏下丏丁丝丒丙());
        this.rotateCamera.OnCloseMinigamesGui();
    }
    private void 丁丝丟业丐丁上不且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_4;
        if(this.丛上不三三不与丞丑 == true)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() != false)
        {
                return;
        }
        
        this.rotateCamera.PlayOpenSocial();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.lobbySoundButton.socialLobbyButtonSound);
        }
        
        this.mainPanel.SetActive(value:  false);
        AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
    }
    private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
    {
        return System.Globalization.CultureInfo.InvariantCulture;
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
                return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        
        return false;
    }
    internal void 丄丙丆业丝丏丗且丒()
    {
        if(this.丈丛且七三丌丂丏丒 != null)
        {
                this.丈丛且七三丌丂丏丒.Cancel();
        }
        
        System.Threading.CancellationTokenSource val_1 = new System.Threading.CancellationTokenSource();
        this.丈丛且七三丌丂丏丒 = val_1;
        System.Threading.CancellationToken val_2 = val_1.Token;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.与丙丕丗不丆丝东丈(业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_2.m_source}));
    }
    private System.Collections.IEnumerator 与丙丕丗不丆丝东丈(System.Threading.CancellationToken 业丘丝业丛丆丄一上)
    {
        MainMenuController.丅下丗丛丛丟丅丝且 val_1 = new MainMenuController.丅下丗丛丛丟丅丝且(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 一丛丟丞与丘丄丌三()
    {
        string val_19;
        var val_20;
        object val_23;
        var val_24;
        var val_25;
        string val_3 = 0;
        val_19 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
        val_20 = PGCompany.Offerwall.丑丟专一丑丆一丒丙.丑七不且上丗丁一世();
        if((val_20.下丆与与丛丕丄丌丕(丙业与丙丗丝不丈东: out  val_3)) == false)
        {
            goto label_2;
        }
        
        if(MainMenuController.世丈且业丆丑丏丐一() != false)
        {
                val_19 = "[Offerwall/MainMenuController.CheckVcsResponse] userId: "("[Offerwall/MainMenuController.CheckVcsResponse] userId: ") + val_19 + ", pendingResponseString: "(", pendingResponseString: ") + val_3;
            UnityEngine.Debug.Log(message:  val_19);
        }
        
        if((PGCompany.丄丙与丄丛丒丟下丛.东一万丈丘业丂丂丑(丌丏不下一与丛丙丝:  val_3, 丙业与丙丗丝不丈东: out  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false})) == false)
        {
            goto label_8;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_11;
        }
        
        UnityEngine.Debug.LogWarning(message:  "[Offerwall/MainMenuController.CheckVcsResponse] isOffline: true");
        return;
        label_2:
        if(MainMenuController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_19 = "[Offerwall/MainMenuController.CheckVcsResponse] userId: "("[Offerwall/MainMenuController.CheckVcsResponse] userId: ") + val_19 + ", hasPendingResponse: false"(", hasPendingResponse: false");
        val_23 = val_19;
        goto label_20;
        label_8:
        val_24 = null;
        if(MainMenuController.世丈且业丆丑丏丐一() == false)
        {
                return;
        }
        
        val_23 = "[Offerwall/MainMenuController.CheckVcsResponse] TryParse: false";
        label_20:
        UnityEngine.Debug.Log(message:  val_23);
        return;
        label_11:
        if(0.丙东专丂世丈丏丁丂() >= 1)
        {
                val_25 = null;
            if(MainMenuController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[Offerwall/MainMenuController.CheckVcsResponse] Credits: "("[Offerwall/MainMenuController.CheckVcsResponse] Credits: ") + 0.丙东专丂世丈丏丁丂().ToString(provider:  MainMenuController.丙专丝世不业下丂丈())(0.丙东专丂世丈丏丁丂().ToString(provider:  MainMenuController.丙专丝世不业下丂丈())));
        }
        
            MainMenuController.与与丙丄东丆丒丝下(且丝丂且丝丘七上且:  0.丙东专丂世丈丏丁丂(), : ref  new 丏不丝世丛丗丂丟且() {东与丙丛丆丘丌丑丘 = val_3});
            return;
        }
        
        MainMenuController.丂三丝丂东丈丛丙上(东与丙丛丆丘丌丑丘:  val_3, 与丗丆丏丙丟与丒业:  "CheckVcsResponse");
    }
    private static void 丂三丝丂东丈丛丙上(string 东与丙丛丆丘丌丑丘, string 与丗丆丏丙丟与丒业 = "")
    {
        var val_4 = null;
        if(MainMenuController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[MainMenuController.MovePendingToProcessed] pendingResponseString: "("[MainMenuController.MovePendingToProcessed] pendingResponseString: ") + 东与丙丛丆丘丌丑丘 + ", caller: "(", caller: ") + 与丗丆丏丙丟与丒业);
        }
        
        PGCompany.Offerwall.丑丟专一丑丆一丒丙.丑七不且上丗丁一世().且且世专与丒丌专世(丙业与丙丗丝不丈东:  System.String.alignConst);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Ads.Offerwall.IronSource.ProcessedCreditsResponse-v2", 下下丏一丙不丘丌丞:  东与丙丛丆丘丌丑丘);
        UnityEngine.PlayerPrefs.Save();
    }
    public MainMenuController()
    {
        var val_9;
        System.Func<System.Boolean> val_11;
        this._alfaTweenTime = 0.3f;
        this.丛专一丘丙丞丅丞业 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.世丟丁不世丘丐与丑 = new System.Collections.Generic.List<System.EventHandler>();
        System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_3 != null)
        {
                val_3.Add(key:  "Shtab", value:  "good_choice");
        }
        else
        {
                val_3.Add(key:  "Shtab", value:  "good_choice");
        }
        
        val_3.Add(key:  "gacha", value:  "after_training_gacha");
        if(val_3 != null)
        {
                val_3.Add(key:  "newsbox", value:  "after_task_newsbox");
        }
        else
        {
                val_3.Add(key:  "newsbox", value:  "after_task_newsbox");
        }
        
        val_3.Add(key:  "ad_chest", value:  "after_task_ad_chest");
        if(val_3 != null)
        {
                val_3.Add(key:  "flag_piedestal", value:  "after_task_flag_piedestal");
        }
        else
        {
                val_3.Add(key:  "flag_piedestal", value:  "after_task_flag_piedestal");
        }
        
        val_3.Add(key:  "igrovoy_avtomat", value:  "after_task_igrovoy_avtomat");
        if(val_3 != null)
        {
                val_3.Add(key:  "landscape", value:  "after_task_landscape");
        }
        else
        {
                val_3.Add(key:  "landscape", value:  "after_task_landscape");
        }
        
        val_3.Add(key:  "radar", value:  "after_task_clans");
        this.丞万上丒东一三丝与 = val_3;
        System.Collections.Generic.Dictionary<System.String, System.String> val_4 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_4 != null)
        {
                val_4.Add(key:  "gacha", value:  "task_gacha_in_tasks");
        }
        else
        {
                val_4.Add(key:  "gacha", value:  "task_gacha_in_tasks");
        }
        
        val_4.Add(key:  "newsbox", value:  "task_gacha_in_tasks");
        if(val_4 != null)
        {
                val_4.Add(key:  "ad_chest", value:  "task_gacha_in_tasks");
        }
        else
        {
                val_4.Add(key:  "ad_chest", value:  "task_gacha_in_tasks");
        }
        
        val_4.Add(key:  "flag_piedestal", value:  "task_gacha_in_tasks");
        if(val_4 != null)
        {
                val_4.Add(key:  "igrovoy_avtomat", value:  "task_gacha_in_tasks");
        }
        else
        {
                val_4.Add(key:  "igrovoy_avtomat", value:  "task_gacha_in_tasks");
        }
        
        val_4.Add(key:  "landscape", value:  "task_gacha_in_tasks");
        val_4.Add(key:  "radar", value:  "task_gacha_in_tasks");
        this.丐丘丆丐不丙丟丌上 = val_4;
        this.丏丒丒丄丆与下丄专 = new System.Collections.Generic.List<System.String>();
        this.丞与与丙七东与丐丙 = System.String.alignConst;
        val_9 = null;
        val_9 = null;
        val_11 = MainMenuController.<>c.<>9__359_0;
        if(val_11 == null)
        {
                System.Func<System.Boolean> val_6 = null;
            val_11 = val_6;
            val_6 = new System.Func<System.Boolean>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainMenuController.<>c::且专丕丗且丒丗不丌());
            MainMenuController.<>c.<>9__359_0 = val_11;
        }
        
        this.丌且丝丄丂丛且丛世 = new Rilisoft.七丞丞丅东丞专丙丝<System.Boolean>(丙丂丌且丌世丒丐三:  val_6);
        this.丝丞业丄七专丟丟丙 = -3.402823E+38f;
        this.shownMinigameModes = new System.Collections.Generic.List<System.Int32>();
    }
    private void 专丒丗专丗丕丐丐丏()
    {
        var val_6;
        System.Func<System.String, System.Boolean> val_8;
        this.不下下丆丐丁丒与丗 = 0;
        val_6 = null;
        val_6 = null;
        val_8 = MainMenuController.<>c.<>9__108_1;
        if(val_8 == null)
        {
                System.Func<System.String, System.Boolean> val_3 = null;
            val_8 = val_3;
            val_3 = new System.Func<System.String, System.Boolean>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainMenuController.<>c::丅丑下丝丌下世丟一(string 三丟东丕丄丄下下丑));
            MainMenuController.<>c.<>9__108_1 = val_8;
        }
        
        if((System.Linq.Enumerable.Count<System.String>(source:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丞与不丂万丈丏丛(), predicate:  val_3)) != PGCompany.丂丘丞丂丏七丁丄不.丘不丗丌丗丕丘丕一())
        {
                return;
        }
        
        InfoWindowController.丅三东下不丅丅业丆(不且东三三丐世下丝:  true);
    }
    private void 丗丞丂丅丐上丏万丝()
    {
        var val_6;
        System.Func<System.String, System.Boolean> val_8;
        this.丗且七丂丄丆丌丅三 = 0;
        val_6 = null;
        val_6 = null;
        val_8 = MainMenuController.<>c.<>9__108_3;
        if(val_8 == null)
        {
                System.Func<System.String, System.Boolean> val_3 = null;
            val_8 = val_3;
            val_3 = new System.Func<System.String, System.Boolean>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainMenuController.<>c::不且专下丂丂丈丕丛(string 三丟东丕丄丄下下丑));
            MainMenuController.<>c.<>9__108_3 = val_8;
        }
        
        if((System.Linq.Enumerable.Count<System.String>(source:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丞与不丂万丈丏丛(), predicate:  val_3)) != PGCompany.丂丘丞丂丏七丁丄不.丘不丗丌丗丕丘丕一())
        {
                return;
        }
        
        InfoWindowController.世丌丂丑丕丁丕一丗();
    }
    private void 丆丒丏下丐丏丘丗丙(System.EventHandler 丐丟与丄丈下一东丘)
    {
        null = null;
        丐丟与丄丈下一东丘.Invoke(sender:  this, e:  System.EventArgs.Empty);
    }
    private void 东世丏一丕丕丗丆下()
    {
        this.业丕丐丂一上丏丏不(丈丈不丒丗与丝不丗:  false);
    }
    private void 丁业且业丙丐丙万丞()
    {
        float val_1 = this.东世七上东丐丁丑东;
        val_1 = val_1 + 1000000f;
        this.东世七上东丐丁丑东 = val_1;
    }
    private void 丛丛东丁丂丆下与七(Rilisoft.ClansLobbyGui 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.HandleOnSiegeClicked(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  0);
    }
    private void 下丝丐不丙丁丄丑丁(Rilisoft.ClansLobbyGui 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.HandleOnClanWarClicked(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  0);
    }
    private void 丛上丐世丛上下丐丙(Rilisoft.ClansLobbyGui 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.HandleOnClanWarTestModeClicked(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  0);
    }
    internal static void 与与丙丄东丆丒丝下(int 且丝丂且丝丘七上且, ref MainMenuController.丏不丝世丛丗丂丟且 )
    {
        var val_4;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  182);
        MainMenuController.丂三丝丂东丈丛丙上(东与丙丛丆丘丌丑丘:  .东与丙丛丆丘丌丑丘, 与丗丆丏丙丟与丒业:  "CheckVcsResponse");
        val_4 = null;
        val_4 = null;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗世丈丂丒丞专上丟:  且丝丂且丝丘七上且, 世丁丙世丄一万丆三:  1, 丛丞万三下丘七丌丅:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        InfoWindowController.一业丏万上三上丑不(丗七丟丈三不丕一三:  且丝丂且丝丘七上且, 丐一业丏上七丆下丌:  "gems");
    }

}
