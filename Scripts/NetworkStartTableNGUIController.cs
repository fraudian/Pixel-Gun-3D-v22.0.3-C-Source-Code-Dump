using UnityEngine;
internal sealed class NetworkStartTableNGUIController : MonoBehaviour
{
    // Fields
    private static System.Action 与七丅下丈不丕三万;
    internal static NetworkStartTableNGUIController 丄丞丁丈与业上丞丟;
    public UILabel countPlayersLabel;
    public UnityEngine.GameObject miniGamesNextMatchPriceContainer;
    public UILabel[] miniGamesNextMatchPriceLabels;
    public UnityEngine.GameObject allInterfaceContainer;
    public UnityEngine.GameObject facebookButton;
    public UnityEngine.GameObject twitterButton;
    public UnityEngine.Transform rentScreenPoint;
    public UnityEngine.GameObject ranksInterface;
    public RanksTable ranksTable;
    public UnityEngine.GameObject shopAnchor;
    public UnityEngine.GameObject finishedInterface;
    public UnityEngine.AudioClip deadheatSound;
    public UnityEngine.AudioClip winSound;
    public UnityEngine.AudioClip looseSound;
    public UILabel[] finishedInterfaceLabels;
    public UnityEngine.GameObject startInterfacePanel;
    public UnityEngine.GameObject endInterfacePanel;
    public UnityEngine.GameObject siegeEndInterfacePanel;
    public UILabel[] siegeEndWinnerLabel;
    public UILabel[] dungeonEndWinnerLabel;
    public UnityEngine.GameObject dungeonsEndInterfacePanel;
    public UnityEngine.Animator interfaceAnimator;
    public UnityEngine.GameObject allInterfacePanel;
    public UnityEngine.GameObject ProgressInterfaceGo;
    public UnityEngine.GameObject randomBtn;
    public UnityEngine.GameObject randomBtnSiege;
    public UnityEngine.GameObject socialPnl;
    public Rilisoft.BankBannersHolder BannersHolder;
    public Rilisoft.BankBannersHolder VeteranChestBannerHolder;
    public UIAnchor spectatorModeButtonsAnchor;
    public UnityEngine.GameObject spectratorModePnl;
    public UnityEngine.GameObject spectatorModeBtnPnl;
    public UnityEngine.GameObject spectatorModeOnBtn;
    public UnityEngine.GameObject spectatorModeOffBtn;
    public UnityEngine.GameObject spectratorPrewNext;
    public UnityEngine.GameObject spectratorDuelScoreController;
    public UnityEngine.GameObject MapSelectPanel;
    internal string 丛七丂丕一世不不丄;
    internal int 上下三三丟丆丟丕丞;
    public UILabel HungerStartLabel;
    private int 丗一丈丕丛丟丂东丕;
    private int 且丆下丐丒不七丒丛;
    private bool 丑东丅七业丞丆万丘;
    private bool 丁丘丟万丙万且丆专;
    public UnityEngine.GameObject SexualButton;
    public UnityEngine.GameObject InAppropriateActButton;
    public UnityEngine.GameObject OtherButton;
    public UnityEngine.GameObject ReasonsPanel;
    public UnityEngine.GameObject ActionPanel;
    public UnityEngine.GameObject AddButton;
    public UnityEngine.GameObject ReportButton;
    public UnityEngine.GameObject OkNoAdsButton;
    public UnityEngine.GameObject Continue_GoToLobbyButton_StartInterface;
    public UnityEngine.GameObject Continue_GoToLobbyButton;
    public UnityEngine.GameObject OpenNoAdsButton;
    public UnityEngine.GameObject OkWithAds;
    public UnityEngine.GameObject OkWithAdsButton;
    public UnityEngine.GameObject OpenWithAdsButton;
    public Rilisoft.ButtonHandler CompetitionContinueButton;
    public UnityEngine.GameObject rewardFullScreenButton;
    public UnityEngine.Transform _clanWarChallengeHolder;
    public ClanWarConnectScene clanwarChallagne;
    public UILabel X2TimesLeftLabel;
    private UILabel x3BonusButtonLabel;
    public Rilisoft.BankShopViewGuiElement BankShopGUI;
    public UILabel[] actionPanelNicklabel;
    public UnityEngine.GameObject trophiAddIcon;
    public UnityEngine.GameObject trophiMinusIcon;
    public UILabel trophyLabel;
    public TrophyMagicAnimation trophyAnimation;
    internal string 丆世丘丒丒丏上且丗;
    internal string 不丆业丏上丐与丌业;
    internal bool 丏且丒不上丄不丘三;
    public GoMapInEndGame[] goMapInEndGameButtons;
    public GoMapInEndGame[] goMapInEndGameButtonsDuel;
    internal int 下丐丙且不丞与丘丛;
    private UnityEngine.GameObject 丁专丆丐与世上丛丑;
    private UnityEngine.Camera _camera;
    private UICamera _uiCamera;
    public UnityEngine.GameObject changeMapLabel;
    public UnityEngine.GameObject listOfPlayers;
    public UnityEngine.GameObject backButtonInHunger;
    public UnityEngine.GameObject goBattleLabel;
    public UnityEngine.GameObject daterButtonLabel;
    private RewardWindowController 丑七专东丘丐三下丒;
    public UIBasicSprite rewardCoinsObject;
    public UIBasicSprite rewardExpObject;
    public UISprite currentCup;
    public UISprite NewCup;
    public UnityEngine.GameObject currentCupPoint;
    public UnityEngine.GameObject newCupPoint;
    public UnityEngine.GameObject cupsHolder;
    public UnityEngine.GameObject[] cupsObjects;
    private UnityEngine.GameObject 丟且丑丒丟丁丒丞丗;
    public UnityEngine.GameObject trophyPanel;
    public UnityEngine.GameObject trophyShine;
    public UISprite currentBar;
    public UISprite nextBar;
    public UILabel trophyPoints;
    public UnityEngine.AudioClip trophySound;
    public UnityEngine.Transform rewardCoinsAnimPoint;
    public UnityEngine.Transform rewardExpAnimPoint;
    public UILabel[] rewardTrophy;
    public UILabel[] gameModeLabel;
    public UILabel[] TitleLabelsAboveTableBig;
    public UILabel[] TitleLabelsAboveTable;
    public UILabel[] SubtitleLabelsAboveTable;
    public UnityEngine.GameObject TitleGameObjectAboveTable;
    public UnityEngine.GameObject SubtitleGameObjectAboveTable;
    public UnityEngine.GameObject[] finishWin;
    public UnityEngine.GameObject[] finishDefeat;
    public UnityEngine.GameObject[] finishDraw;
    public UnityEngine.GameObject roundShieldsContainer;
    public UnityEngine.GameObject roundShieldsContainerScore;
    public UISprite[] roundShields;
    public UISprite[] roundShieldsScore;
    public UIToggle shareToggle;
    public UIToggle shareToggleWithAds;
    public UILabel[] textLeagueUp;
    public UILabel[] textLeagueDown;
    public UnityEngine.GameObject duelPanel;
    public UnityEngine.GameObject teamDuelPanel;
    public DuelUIController duelUI;
    public TeamDuelUI teamDuelUI;
    public SiegeUI siegeUI;
    public SiegeUI matchMakingUI;
    public DungeonsUI dungeonsUI;
    public Rilisoft.ButtonHandler exitDialogYes;
    public Rilisoft.ButtonHandler exitDialogNo;
    public Rilisoft.ButtonHandler exitButtonTeamDuel;
    public Rilisoft.ButtonHandler[] exitButtonsSiege;
    public Rilisoft.ButtonHandler[] exitButtonsDungeons;
    public UILabel exitDialogTeamDuelLabel;
    public UnityEngine.GameObject exitDialogTeamDuel;
    internal bool 上丏丙东丁不丕丁丟;
    internal bool 三与万丝丒一丏丝七;
    public UnityEngine.RuntimeAnimatorController standartAnimController;
    public UnityEngine.RuntimeAnimatorController DuelAnimController;
    public UnityEngine.GameObject betsReward;
    public UIBasicSprite betTexture;
    public UILabel betLabel;
    public UnityEngine.GameObject rewardLabelObject;
    public UnityEngine.GameObject sniperModeHint;
    public UILabel sniperModeHintCombatLvlLabel;
    public MapEventRewardProgress specialRewardProgress;
    public UnityEngine.GameObject ReadyTimerContainer;
    public UILabel DesireCounterLabel;
    public UILabel DesireTimerLabel;
    public UnityEngine.GameObject fonTableChangeBomb;
    public SimpleTweenePlayer tweeneBlueWinner;
    public SimpleTweenePlayer tweeneRedWinner;
    public UITexture plantTheBombTeamOneIcon;
    public UITexture plantTheBombTeamTwoIcon;
    public UnityEngine.Texture plantTheBombIconTextureBomb;
    public UnityEngine.Texture plantTheBombIconTextureCutters;
    private System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万> 丈丄丏专丄丆丄丟丕;
    private System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万> 下丂丐上东上丑上东;
    private System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万>[] 丆丅丂专丏丏丙与丕;
    private System.Collections.IEnumerator 七三丝丛丈三万丁一;
    private TournamentEventRespriteUi 且丘丈与业丝丕丑丙;
    public UnityEngine.GameObject plantTheBombPanel;
    public PlantTheBombNotificationsSystem plantTheBombNotificationsSystem;
    public PlantTheBombScoresPanel plantTheBombScoresPanel;
    public UnityEngine.GameObject modePanel;
    public MutationNotificationsSystem mutationNotificationsSystem;
    public RedLightNotificationsSystem redLightNotificationsSystem;
    private int 丆七下丒上丈丒业世;
    private ImposterVoteUI 东下一丄丈万且上丄;
    private ImposterVoteResultUi 丞丘丅且丐下丕业东;
    private ImposterVoteBeginningUi 丁丅与丑万丝丐上丐;
    private ImposterFinalUI 丁业丗专万丁与丌七;
    private ChoiceCharacterUI 丞一业丒丁丟丁丕丞;
    private const string 丞丐与丙丛丏丁丅一 = "Key_8889";
    private PGCompany.Analytics.不且丙丙东丘丏业业 丑丛丒万世世丏业与;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<string> 一丛下丅丏下丒与丂;
    private bool 业丕与上丗丟丙世与;
    private UnityEngine.GameObject 丑丄丘一丐丐七七丞;
    private bool 下下丂丂业丟一下丙;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private RewardWindowBase <丞三丅三丟万丟丟业>k__BackingField;
    private UnityEngine.Coroutine 丞丗丆万丆丗丘丕丙;
    private bool 世丒丗一丑丏丞丑一;
    private bool 丐丐丑丏丁丙上上丄;
    private int 丛丏丒一丗丝丌不丅;
    private int 下丕丌丈丙与与丏丟;
    private int 丙丏丏丛丁与丘三丝;
    private int 丈七丈丞专七丟专丛;
    private int 七上世丌丘丕万丅东;
    private int 丕专丐上东丑丑下丘;
    private int 丂三丅丘丆丂丛七丌;
    private Rilisoft.OfferItem 丕一丄丏丗丄丏万下;
    private PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丒丕丅下丒丂丛下七;
    private float 丒丒且丅丁丑丕丙丁;
    private float 丗丙丁东上三丘丛丆;
    private bool 三丑丑丈万丛丗与下;
    private bool 上业丈丐上丂上东丌;
    private bool 一七丑三丝丝丌丕丗;
    private bool 与与丁下万丈丆丝上;
    private bool 丆上丐丄丗丆丟丝丝;
    private bool 丌一丏丘丞东与上世;
    private bool 下丄三丒丟丄丂丑世;
    private FacebookController.上丘丟丂万东丟下丂 世丂丑世丏丐丗下丞;
    private FacebookController.上丘丟丂万东丟下丂 与丂与丗与丁专丏丄;
    private System.Action 丁万上丛业丟世丞丒;
    private System.Action 丑下丟丑丄与业丝丌;
    private string <丝且万丁丐丄丌丕与>k__BackingField;
    private System.Func<string> <下丁业丁丄东且与三>k__BackingField;
    private UnityEngine.Coroutine 专丆三七世下丌七东;
    private bool 丙不七专且与丑丝丅;
    private UnityEngine.Coroutine 丞丑丌世且丘丁丝下;
    private UnityEngine.Coroutine 专东丝丈丕丞与万不;
    private System.Collections.Generic.List<SceneInfo> 业不专丛世丄与上丒;
    private UnityEngine.Coroutine 丟专下丑万丌世下不;
    
    // Properties
    private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
    internal TournamentEventRespriteUi 不万三业业丁丑丅专 { get; }
    internal ImposterVoteUI 丟丗丆丞丗丅万东丗 { get; }
    internal ImposterVoteChatUi 与丑不专一一丑丐丙 { get; }
    internal ImposterVoteResultUi 且丗专丕丈不丙丕一 { get; }
    internal ImposterVoteBeginningUi 丞万丞丌万业丟七丕 { get; }
    internal ImposterFinalUI 丂丈丒丒丄下丞丟丏 { get; }
    internal ChoiceCharacterUI 丄丂丄上丌与丏七专 { get; }
    private UnityEngine.GameObject 世丐且世与丗且丒专 { get; }
    private UIToggle 丗丈七专丅丆丝七不 { get; }
    private System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万> 丂丆丁与丘丕丗丛丙 { get; set; }
    internal RewardWindowBase 丏丆丈丝丂与丘与丟 { get; set; }
    private bool 业丆丗三世丛万专世 { get; }
    private bool 丟丆三丒丐丕丅丒丝 { get; }
    private FacebookController.上丘丟丂万东丟下丂 丄七丂下万一丝丂丌 { get; set; }
    private FacebookController.上丘丟丂万东丟下丂 丄业三上丑丞丁七三 { get; set; }
    private FacebookController.上丘丟丂万东丟下丂 丈业三丅丘一丟丆丐 { set; }
    private string 且七专丗丛丒专丗世 { get; set; }
    private System.Func<string> 一丟丙丂丒丁丟且专 { get; set; }
    
    // Methods
    internal static void 丄丌不丁丄丘万丁与(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  NetworkStartTableNGUIController.丞丐与丙丛丏丁丅一, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 下丁不丐丟东丂丗丅(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  NetworkStartTableNGUIController.丞丐与丙丛丏丁丅一, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
    {
        return System.Globalization.CultureInfo.InvariantCulture;
    }
    public void HandleContinue_GoToLobbyButton()
    {
        PGCompany.丕丝下丁七东丄三丑.丗与丆丏丝下丅丕世(丈丁下不丐丑丈丈业:  0, 专上且丗丑丌丟丈丄:  false, 丁丟丑丆三丆业一丅:  0);
    }
    internal void 万丌专丘丟东万且丘()
    {
        var val_18;
        var val_19;
        string val_20;
        var val_21;
        var val_22;
        bool val_23;
        var val_24;
        var val_25;
        UnityEngine.Texture val_26;
        var val_27;
        UnityEngine.Texture val_28;
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.一丘丂丄上丅丁丙丝)) != false)
        {
                val_19 = null;
            val_19 = null;
            val_20 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.一丘丂丄上丅丁丙丝];
            int val_8 = System.Int32.Parse(s:  val_20);
        }
        else
        {
                if(PlantTheBombController.丆丕丝丒不丙且丐丗 != null)
        {
                val_21 = PlantTheBombController.丆丕丝丒不丙且丐丗.丁丝三丝一丂丕丑一();
        }
        else
        {
                val_21 = 0.丁丝三丝一丂丕丑一();
        }
        
            val_20 = PlantTheBombController.丆丕丝丒不丙且丐丗;
            int val_12 = val_20.SelectBomberCommand(丝丐丐丟丙丆一丄丗:  val_21 + 1);
        }
        
        val_22 = null;
        val_22 = null;
        int val_13 = 丘丑丅三丆丑丌且丝();
        val_23 = 1;
        if(((val_13 == 1) ? ((val_13 == 1) ? 1 : 0) : (val_13)) != val_12)
        {
                val_23 = mem[PlantTheBombController.丆丕丝丒不丙且丐丗 + 60];
            val_23 = PlantTheBombController.丆丕丝丒不丙且丐丗.七业丕且万丝丛丝与;
        }
        
        if(((val_13 == 1) ? (val_23 + 1) : (val_23)) == val_12)
        {
                val_24 = 0;
        }
        
        if(val_23 != false)
        {
                val_25 = null;
            val_26 = this.plantTheBombIconTextureBomb;
        }
        else
        {
                val_25 = null;
            val_26 = this.plantTheBombIconTextureCutters;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.plantTheBombTeamOneIcon, 与万丆丛丒万丝丙丑:  val_26);
        if((((PlantTheBombController.丆丕丝丒不丙且丐丗.七业丕且万丝丛丝与 == false) ? 1 : 0) & 1) != 0)
        {
                val_27 = null;
            val_28 = this.plantTheBombIconTextureCutters;
        }
        else
        {
                val_27 = null;
            val_28 = this.plantTheBombIconTextureBomb;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.plantTheBombTeamTwoIcon, 与万丆丛丒万丝丙丑:  val_28);
    }
    internal TournamentEventRespriteUi 丑丗丌丆丘丂业丞下()
    {
        TournamentEventRespriteUi val_11;
        if(this.且丘丈与业丝丕丑丙 != 0)
        {
            goto label_3;
        }
        
        TournamentEventRespriteUi val_2 = UnityEngine.Resources.Load<TournamentEventRespriteUi>(path:  "ContestWindows/Contest_RespiteWindow");
        UnityEngine.Vector3 val_4 = val_2.丌丟丄业且三丛丕丄().localPosition;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        UnityEngine.Transform val_7 = UnityEngine.Object.Instantiate<TournamentEventRespriteUi>(original:  val_2, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}).丌丟丄业且三丛丕丄();
        val_7.SetParent(p:  this.startInterfacePanel.transform);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_7.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        if(val_7 == null)
        {
            goto label_16;
        }
        
        val_7.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_17;
        label_3:
        val_11 = this.且丘丈与业丝丕丑丙;
        return val_10;
        label_16:
        0.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_17:
        TournamentEventRespriteUi val_10 = val_7.GetComponent<TournamentEventRespriteUi>();
        this.且丘丈与业丝丕丑丙 = val_10;
        return val_10;
    }
    internal ImposterVoteUI 丗一三丒丄丄一丙丅()
    {
        ImposterVoteUI val_5;
        if(this.东下一丄丈万且上丄 == 0)
        {
                this.东下一丄丈万且上丄 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.allInterfaceContainer, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NetworkStartTableNGUI/ImposterVoteUI")).GetComponent<ImposterVoteUI>();
            return val_5;
        }
        
        val_5 = this.东下一丄丈万且上丄;
        return val_5;
    }
    internal ImposterVoteChatUi 丁下东丙丞丝且丒丐()
    {
        ImposterVoteUI val_3;
        var val_4;
        val_3 = this;
        val_4 = 0;
        if(this.东下一丄丈万且上丄 == 0)
        {
                return (ImposterVoteChatUi)val_3.GetComponent<ImposterVoteChatUi>();
        }
        
        val_3 = this.东下一丄丈万且上丄;
        return (ImposterVoteChatUi)val_3.GetComponent<ImposterVoteChatUi>();
    }
    internal ImposterVoteResultUi 一丝丄专丛丙业丝业()
    {
        ImposterVoteResultUi val_5;
        if(this.丞丘丅且丐下丕业东 == 0)
        {
                this.丞丘丅且丐下丕业东 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.allInterfaceContainer, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/ImposterModeUI/ImposterModeVotingResults")).GetComponent<ImposterVoteResultUi>();
            return val_5;
        }
        
        val_5 = this.丞丘丅且丐下丕业东;
        return val_5;
    }
    internal ImposterVoteBeginningUi 丘专东三丗业下东丅()
    {
        ImposterVoteBeginningUi val_5;
        if(this.丁丅与丑万丝丐上丐 == 0)
        {
                this.丁丅与丑万丝丐上丐 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.allInterfaceContainer, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/ImposterModeUI/ImposterModeVotingStart")).GetComponent<ImposterVoteBeginningUi>();
            return val_5;
        }
        
        val_5 = this.丁丅与丑万丝丐上丐;
        return val_5;
    }
    internal ImposterFinalUI 丑丘业丐丟世丗下且()
    {
        ImposterFinalUI val_5;
        if(this.丁业丗专万丁与丌七 == 0)
        {
                this.丁业丗专万丁与丌七 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.allInterfaceContainer, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/ImposterModeUI/ImposterModeFinalUI")).GetComponent<ImposterFinalUI>();
            return val_5;
        }
        
        val_5 = this.丁业丗专万丁与丌七;
        return val_5;
    }
    internal ChoiceCharacterUI 丕世丝且下且丒业丏()
    {
        if(this.丞一业丒丁丟丁丕丞 != 0)
        {
                return (ChoiceCharacterUI)this.丞一业丒丁丟丁丕丞;
        }
        
        ChoiceCharacterUI val_4 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.allInterfaceContainer, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/CharacterChoice/MutationChoice")).GetComponent<ChoiceCharacterUI>();
        this.丞一业丒丁丟丁丕丞 = val_4;
        val_4.gameObject.SetActive(value:  false);
        return (ChoiceCharacterUI)this.丞一业丒丁丟丁丕丞;
    }
    private UnityEngine.GameObject 丒丕丟东三世丑丛丟()
    {
        if(this.OkWithAdsButton.activeInHierarchy == true)
        {
                return (UnityEngine.GameObject)(this.丆丈丟丘丏丛丕业丅() != true) ? (this.OkWithAdsButton) : this.OkNoAdsButton;
        }
        
        return (UnityEngine.GameObject)(this.丆丈丟丘丏丛丕业丅() != true) ? (this.OkWithAdsButton) : this.OkNoAdsButton;
    }
    private UIToggle 丟下下丞七丅丈东丙()
    {
        UIToggle val_3;
        if(this.OkWithAdsButton.activeInHierarchy != true)
        {
                if(this.丆丈丟丘丏丛丕业丅() == false)
        {
            goto label_2;
        }
        
        }
        
        val_3 = this.shareToggleWithAds;
        return (UIToggle)mem[this.shareToggle];
        label_2:
        val_3 = this.shareToggle;
        return (UIToggle)mem[this.shareToggle];
    }
    private System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万> 丐丅七丂且丈丕丕三()
    {
        System.Collections.Generic.Queue<丙丏下世且七丌上万> val_2 = this.丈丄丏专丄丆丄丟丕;
        if(val_2 != null)
        {
                return val_2;
        }
        
        System.Collections.Generic.Queue<丙丏下世且七丌上万> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.Queue<丙丏下世且七丌上万>();
        this.丈丄丏专丄丆丄丟丕 = val_2;
        return val_2;
    }
    private void 专丈下丈世三丂丞丟(System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万> 丙业与丙丗丝不丈东)
    {
        this.丈丄丏专丄丆丄丟丕 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        this.丑七专东丘丐三下丒 = this.GetComponent<RewardWindowController>();
        if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_11;
        }
        
        }
        
        }
        
        label_11:
        this.interfaceAnimator.runtimeAnimatorController = mem[this.DuelAnimController];
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 = this;
    }
    private void OnDestroy()
    {
        Rilisoft.GameEventOpenChestBase.不丒丅且上丗丂丗丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丅三丟下七丂三丟万()));
        LootBoxBanner.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丅三丟下七丂三丟万()));
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 = 0;
    }
    private void Start()
    {
        bool val_95;
        var val_96;
        var val_97;
        var val_98;
        float val_99;
        float val_100;
        float val_101;
        float val_102;
        var val_103;
        var val_104;
        var val_105;
        var val_106;
        var val_107;
        UnityEngine.GameObject val_1 = this.countPlayersLabel.gameObject;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_4;
        }
        
        val_95 = 1;
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_6;
        label_4:
        val_95 = GameConnect.一业上七丟业且业丙();
        if(val_1 != null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_1.SetActive(value:  val_95);
        this.丙不七专且与丑丝丅 = false;
        this.丁专丆丐与世上丛丑 = this.transform.GetChild(index:  0).gameObject;
        if(GameConnect.丒丗丁丙丗丄丙不丐() != false)
        {
                val_96 = 1;
        }
        else
        {
                val_96 = 0;
        }
        
        this.fonTableChangeBomb.SetActive(value:  false);
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_20;
        }
        
        UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Mutation/MutationNotificationsSystem"), parent:  this.modePanel.transform);
        this.mutationNotificationsSystem = val_11.GetComponent<MutationNotificationsSystem>();
        if(this.modePanel != null)
        {
            goto label_36;
        }
        
        label_37:
        label_36:
        val_95 = this.modePanel.layer;
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_11, 不东丛三丂丌丑专丆:  val_95, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        goto label_31;
        label_20:
        if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_31;
        }
        
        this.redLightNotificationsSystem = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "RedLight/RedLightNotificationsSystem"), parent:  this.modePanel.transform).GetComponent<RedLightNotificationsSystem>();
        if(this.modePanel != null)
        {
            goto label_36;
        }
        
        goto label_37;
        label_31:
        if(this._camera == 0)
        {
                this._camera = this.丁专丆丐与世上丛丑.GetComponent<UnityEngine.Camera>();
        }
        
        if(this.SexualButton != 0)
        {
                Rilisoft.ButtonHandler val_22 = this.SexualButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_22 != 0)
        {
                System.EventHandler val_24 = null;
            val_95 = val_24;
            val_24 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丆世万丙业丘丑丑丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_22.add_Clicked(丙业与丙丗丝不丈东:  val_24);
        }
        
        }
        
        if(this.InAppropriateActButton != 0)
        {
                Rilisoft.ButtonHandler val_26 = this.InAppropriateActButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_26 != 0)
        {
                System.EventHandler val_28 = null;
            val_95 = val_28;
            val_28 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::上丝丂丄万世丟下丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_26.add_Clicked(丙业与丙丗丝不丈东:  val_28);
        }
        
        }
        
        if(this.OtherButton != 0)
        {
                Rilisoft.ButtonHandler val_30 = this.OtherButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_30 != 0)
        {
                System.EventHandler val_32 = null;
            val_95 = val_32;
            val_32 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丘丅丗丙丘专一丟丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_30.add_Clicked(丙业与丙丗丝不丈东:  val_32);
        }
        
        }
        
        if(this.ReportButton != 0)
        {
                Rilisoft.ButtonHandler val_34 = this.ReportButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_34 != 0)
        {
                System.EventHandler val_36 = null;
            val_95 = val_36;
            val_36 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::下丗丛万不丄丏丐丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_34.add_Clicked(丙业与丙丗丝不丈东:  val_36);
        }
        
        }
        
        if(this.AddButton != 0)
        {
                Rilisoft.ButtonHandler val_38 = this.AddButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_38 != 0)
        {
                System.EventHandler val_40 = null;
            val_95 = val_40;
            val_40 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::三丆业丈不一丘丁丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_38.add_Clicked(丙业与丙丗丝不丈东:  val_40);
        }
        
        }
        
        if(this.exitButtonTeamDuel != 0)
        {
                System.EventHandler val_42 = null;
            val_95 = val_42;
            val_42 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::东丙不丕丑七下丙丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.exitButtonTeamDuel.add_Clicked(丙业与丙丗丝不丈东:  val_42);
        }
        
        val_97 = 0;
        goto label_86;
        label_90:
        System.EventHandler val_43 = null;
        val_95 = val_43;
        val_43 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::东丙不丕丑七下丙丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        this.exitButtonsSiege[0].add_Clicked(丙业与丙丗丝不丈东:  val_43);
        val_97 = 1;
        label_86:
        if(val_97 < this.exitButtonsSiege.Length)
        {
            goto label_90;
        }
        
        val_98 = 0;
        goto label_91;
        label_95:
        System.EventHandler val_44 = null;
        val_95 = val_44;
        val_44 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::东丙不丕丑七下丙丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        this.exitButtonsDungeons[0].add_Clicked(丙业与丙丗丝不丈东:  val_44);
        val_98 = 1;
        label_91:
        if(val_98 < this.exitButtonsDungeons.Length)
        {
            goto label_95;
        }
        
        if(this.exitDialogYes != 0)
        {
                System.EventHandler val_46 = null;
            val_95 = val_46;
            val_46 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::万丕丄丈丟东丑一一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.exitDialogYes.add_Clicked(丙业与丙丗丝不丈东:  val_46);
        }
        
        if(this.exitDialogNo != 0)
        {
                System.EventHandler val_48 = null;
            val_95 = val_48;
            val_48 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丁丁专丈丟业一丙丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.exitDialogNo.add_Clicked(丙业与丙丗丝不丈东:  val_48);
        }
        
        if((GameConnect.丑丌丛丈丅丅与不业() != 2) && (GameConnect.丑丌丛丈丅丅与不业() != 4))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 19)
        {
            goto label_123;
        }
        
        }
        
        }
        
        UnityEngine.Transform val_53 = this.listOfPlayers.transform;
        UnityEngine.Vector3 val_54 = val_53.localPosition;
        val_95 = 1152921504838316032;
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Multiply(d:  50f, a:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z});
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, b:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
        val_99 = val_57.x;
        val_100 = val_99;
        val_101 = val_57.y;
        val_102 = val_57.z;
        val_53.localPosition = new UnityEngine.Vector3() {x = val_100, y = val_101, z = val_102};
        if(NetworkStartTable.与一专丒东丏丘专丕() != false)
        {
                UnityEngine.Transform val_59 = this.MapSelectPanel.transform;
            UnityEngine.Vector3 val_60 = val_59.localPosition;
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Multiply(d:  80f, a:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, b:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z});
            val_99 = val_63.x;
            val_100 = val_99;
            val_101 = val_63.y;
            val_102 = val_63.z;
            val_59.localPosition = new UnityEngine.Vector3() {x = val_100, y = val_101, z = val_102};
        }
        
        label_123:
        val_103 = null;
        val_103 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
        {
                UnityEngine.Transform val_64 = this.MapSelectPanel.transform;
            UnityEngine.Vector3 val_65 = val_64.localPosition;
            UnityEngine.Vector3 val_66 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_67 = UnityEngine.Vector3.op_Multiply(d:  8000f, a:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z});
            UnityEngine.Vector3 val_68 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z}, b:  new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z});
            val_99 = val_68.x;
            val_100 = val_99;
            val_101 = val_68.y;
            val_102 = val_68.z;
            val_64.localPosition = new UnityEngine.Vector3() {x = val_100, y = val_101, z = val_102};
        }
        
        if((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.丁丁丗丐东丄丞一丛() != true))
        {
                if(GameConnect.丙丌丒丈东七丒上丌() != true)
        {
                if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_149;
        }
        
        }
        
        }
        
        label_218:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.BankShopGUI, 丏业丟一东丂东丘丛:  false);
        label_217:
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                this.BankShopGUI.ShowPixelBucks = true;
            this.BankShopGUI.丝一丅丆三东丂丞七();
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                this.shopAnchor.SetActive(value:  false);
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_194;
        }
        
        }
        
        }
        
        val_104 = null;
        val_104 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕 == null)
        {
            goto label_172;
        }
        
        label_194:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_183;
        }
        
        val_105 = null;
        val_105 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕 == null)
        {
            goto label_183;
        }
        
        UnityEngine.Vector3 val_80 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_81 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z}, d:  0.75f);
        val_99 = val_81.x;
        this.spectatorModeBtnPnl.transform.localScale = new UnityEngine.Vector3() {x = val_99, y = val_81.y, z = val_81.z};
        goto label_183;
        label_172:
        this.spectatorModeButtonsAnchor.side = 7;
        label_183:
        if(this.rewardFullScreenButton == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_83 = this.rewardFullScreenButton.GetComponent<Rilisoft.ButtonHandler>();
        if(val_83 == 0)
        {
                return;
        }
        
        val_83.ClearEvents();
        val_83.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::不丞丆业丗世一丕东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        return;
        label_149:
        if((GameConnect.不专专丂万丝上东丐() != true) && (GameConnect.东且三丆丑世世丘丟() != true))
        {
                if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_226;
        }
        
        }
        
        }
        
        this.BankShopGUI.且不丄丂上专丗三七(丙业与丙丗丝不丈东:  1);
        this.丘丙丏丝丛丘丟业丙(丈丞丁丐丑丏万万丒:  false);
        this.BankShopGUI.丄下与业丏丂丞不世(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        label_226:
        val_106 = null;
        val_106 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
            goto label_213;
        }
        
        if(mem[this.BankShopGUI] != 0)
        {
            goto label_224;
        }
        
        label_225:
        label_224:
        mem2[0] = (1 != 0) ? 1 : 0;
        if(PGCompany.丁东丌世与丕东丆上.丛丈丂丝丁丘不丁东() == false)
        {
            goto label_217;
        }
        
        goto label_218;
        label_213:
        val_107 = null;
        val_107 = null;
        if(GameController.丆丘丂丈世丏丟丑丏 == null)
        {
            goto label_221;
        }
        
        if(mem[this.BankShopGUI] != 0)
        {
            goto label_224;
        }
        
        goto label_225;
        label_221:
        if(mem[this.BankShopGUI] != 0)
        {
            goto label_224;
        }
        
        goto label_225;
    }
    private void 丞下万丘丙丑上丌专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.上世与丗丁丕丌丘上();
    }
    internal void 丘丙丏丝丛丘丟业丙(bool 丈丞丁丐丑丏万万丒)
    {
        bool val_1 = 丈丞丁丐丑丏万万丒;
        this.BankShopGUI.ShowTickets = val_1;
        this.BankShopGUI.ShowEventCurrency = val_1;
        this.BankShopGUI.ShowOnlyEventCurrency = val_1;
        bool val_2 = ~丈丞丁丐丑丏万万丒;
        val_2 = val_2 & 1;
        this.BankShopGUI.ShowCoins = val_2;
        this.BankShopGUI.丝一丅丆三东丂丞七();
    }
    internal void 上世与丗丁丕丌丘上()
    {
        object val_10;
        var val_11;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_3;
        }
        
        val_10 = "ShowBankWindow ShopNGUIController.GuiActive != null";
        goto label_14;
        label_3:
        if(BankController.丑七不且上丗丁一世() != 0)
        {
            goto label_11;
        }
        
        val_10 = "ShowBankWindow bankController == null";
        goto label_14;
        label_11:
        if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() == false)
        {
            goto label_18;
        }
        
        val_10 = "ShowBankWindow InterfaceEnabledCoroutineLocked";
        label_14:
        UnityEngine.Debug.LogWarning(message:  val_10);
        return;
        label_18:
        if((GameConnect.业丛丛丂一丆丕丗丟() != false) && (this.BankShopGUI.ShowEventCurrency != false))
        {
                val_11 = null;
            val_11 = null;
            DuelController.丄丘七三上丕世丞业.丏东丐丞丘丟丐丙丝();
            return;
        }
        
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfaceContainer, 丏业丟一东丂东丘丛:  false);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    internal void 东丏且丑上丑专上不(string 世且不丏丒丞丙东丐)
    {
        UnityEngine.Object val_9;
        object val_10;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_3;
        }
        
        val_10 = "ShowBankWindow ShopNGUIController.GuiActive != null";
        goto label_14;
        label_3:
        val_9 = BankController.丑七不且上丗丁一世();
        if(val_9 != 0)
        {
            goto label_11;
        }
        
        val_10 = "ShowBankWindow bankController == null";
        goto label_14;
        label_11:
        val_9 = BankController.丑七不且上丗丁一世();
        if(val_9.上丌业丘下丞丂下丐() == false)
        {
            goto label_18;
        }
        
        val_10 = "ShowBankWindow InterfaceEnabledCoroutineLocked";
        label_14:
        UnityEngine.Debug.LogWarning(message:  val_10);
        return;
        label_18:
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfaceContainer, 丏业丟一东丂东丘丛:  false);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  世且不丏丒丞丙东丐, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    internal void 丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        object val_9;
        var val_10;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_3;
        }
        
        val_9 = "HandleBackFromBankClicked ShopNGUIController.GuiActive  != null";
        goto label_14;
        label_3:
        if(BankController.丑七不且上丗丁一世() != 0)
        {
            goto label_11;
        }
        
        val_9 = "HandleBackFromBankClicked bankController == null";
        goto label_14;
        label_11:
        if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() == false)
        {
            goto label_18;
        }
        
        val_9 = "HandleBackFromBankClicked InterfaceEnabledCoroutineLocked";
        label_14:
        UnityEngine.Debug.LogWarning(message:  val_9);
        return;
        label_18:
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丞丘东丂丐一丑与且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfaceContainer, 丏业丟一东丂东丘丛:  true);
        this.业丕与上丗丟丙世与 = true;
        val_10 = null;
        val_10 = null;
        Rilisoft.VIPController.世且丑丑丄丈东丟专 = false;
    }
    private void 东上丞丆业世丈丟丕()
    {
        object val_12;
        System.Action val_13;
        val_12 = this;
        val_13 = System.Delegate.Remove(source:  val_1.丟丙丐丅三东上业丅, value:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::东上丞丆业世丈丟丕()));
        if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance) == null)
        {
            goto label_2;
        }
        
        if(val_13 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_13 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_13 = 0;
        }
        
        label_6:
        val_1.丟丙丐丅三东上业丅 = val_13;
        if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) == false)
        {
                return;
        }
        
        this.丑七专东丘丐三下丒.专世七丟丄专丁与且();
        val_13 = Rilisoft.VIPController.专丌丞丌丕丕丞丅丆();
        val_12 = this.丏不三丁世专丐丅丞(丗七丟丈三不丕一三:  new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  2, 丟业丈丈丞丂丞丑业:  val_13), 丕丕世且下一与丝与:  1f);
        UnityEngine.Coroutine val_11 = CoroutineRunner.Instance.StartCoroutine(routine:  val_12);
    }
    private void Update()
    {
        bool val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        bool val_51;
        UnityEngine.GameObject val_52;
        this.丙世丏七丌专万丁一();
        if(MainStoreView.丈丐丞丐上丑且丕万() != false)
        {
                label_11:
            val_46 = 0;
        }
        else
        {
                if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().丐丛丁丅丟丆丟业丂() == true)
        {
            goto label_11;
        }
        
        }
        
            if(BankController.丑七不且上丗丁一世() == 0)
        {
                val_46 = 1;
        }
        else
        {
                val_46 = (~BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂()) & 1;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丁专丆丐与世上丛丑, 丏业丟一东丂东丘丛:  val_46);
        if(this.丁专丆丐与世上丛丑.activeInHierarchy != false)
        {
                if((InGameGUI.丙丞专丌丁丞与不丐 == 0) || (InGameGUI.丙丞专丌丁丞与不丐.isActiveAndEnabled == false))
        {
            goto label_29;
        }
        
        }
        
        if(this._camera != null)
        {
            goto label_109;
        }
        
        label_110:
        label_109:
        this._camera.enabled = false;
        this._uiCamera.enabled = (~PGCompany.VeteranChest.丒专丛丒丄业丛业丁.丕三三丐一一丟丘丂()) & 1;
        if((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true))
        {
                if(GameConnect.不专专丂万丝上东丐() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_65;
        }
        
        }
        
        }
        
        val_47 = null;
        val_47 = null;
        if(丞下丗丞一业丏上不() != true)
        {
                if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true)) && (GameConnect.世丐丄三三上丅七三() != true))
        {
                val_48 = null;
            val_48 = null;
            if(与丂丏丛丞丞丒丟丄.与丈丝丌东丄丏丞丙 != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_65;
        }
        
        }
        
        }
        
            if(this.spectatorModeBtnPnl.activeSelf != false)
        {
                this.spectatorModeBtnPnl.SetActive(value:  false);
            this.spectratorModePnl.SetActive(value:  false);
            this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  GameConnect.一业上七丟业且业丙());
        }
        
        }
        
        label_65:
        if((FacebookController.且丈丄一丁丞丒丑东() == false) || (FacebookController.丘七下丂上一丅三丏() == false))
        {
            goto label_75;
        }
        
        val_49 = Facebook.Unity.FB.IsLoggedIn;
        if(this.facebookButton != null)
        {
            goto label_80;
        }
        
        goto label_79;
        label_75:
        val_49 = 0;
        if(this.facebookButton != null)
        {
            goto label_80;
        }
        
        label_79:
        label_80:
        this.facebookButton.SetActive(value:  false);
        if((TwitterController.上业丗丛三丕丒丗丙() == false) || (TwitterController.丂丌与下丛丑丂丐丘() == false))
        {
            goto label_86;
        }
        
        val_50 = TwitterController.丒丆世一与丁丛丐下();
        if(this.twitterButton != null)
        {
            goto label_91;
        }
        
        goto label_90;
        label_86:
        val_50 = 0;
        if(this.twitterButton != null)
        {
            goto label_91;
        }
        
        label_90:
        label_91:
        this.twitterButton.SetActive(value:  false);
        if(this.facebookButton.activeSelf != false)
        {
                val_51 = 1;
        }
        else
        {
                val_51 = this.twitterButton.activeSelf;
        }
        
        val_52 = this.socialPnl;
        if(val_51 != val_52.activeSelf)
        {
                val_52 = this.socialPnl;
            val_52.SetActive(value:  val_51);
        }
        
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
                return;
        }
        
        if(PlantTheBombController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        this.plantTheBombScoresPanel.gameObject.SetActive(value:  (~this.ranksTable.panelRanksPlantTheBomb.activeSelf) & 1);
        return;
        label_29:
        var val_43 = (~PGCompany.VeteranChest.丒专丛丒丄业丛业丁.丕三三丐一一丟丘丂()) & 1;
        if(this._camera != null)
        {
            goto label_109;
        }
        
        goto label_110;
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Network Start Table GUI");
        ExpController.上业业丝丑丆三与丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::一丝专上丑业丅丒下()));
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::一业业七不业丈下丞()));
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::一业业七不业丈下丞()));
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丏丈下丈七丕丙丒丁()));
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丏丈下丈七丕丙丒丁()));
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        ExpController.丟丅七丄下丙下丑丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::一丝专上丑业丅丒下()));
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::一业业七不业丈下丞()));
        业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::一业业七不业丈下丞()));
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丏丈下丈七丕丙丒丁()));
        业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丏丈下丈七丕丙丒丁()));
    }
    private void 一丝专上丑业丅丒下()
    {
        bool val_1 = this.上下下上三业丒丐东();
    }
    private void 丅三丟下七丂三丟万()
    {
        Rilisoft.GameEventOpenChestBase.不丒丅且上丗丂丗丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丅三丟下七丂三丟万()));
        LootBoxBanner.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丅三丟下七丂三丟万()));
        if(this.丑丄丘一丐丐七七丞 != 0)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丑丄丘一丐丐七七丞);
            this.丑丄丘一丐丐七七丞 = 0;
        }
        
        if(this.丞丗丆万丆丗丘丕丙 != null)
        {
                this.StopCoroutine(routine:  this.丞丗丆万丆丗丘丕丙);
        }
        
        this.丞丗丆万丆丗丘丕丙 = this.StartCoroutine(routine:  this.且丄丄专东下丈丈七());
    }
    private bool 丘业丞丗上且一丏下()
    {
        Rilisoft.BankBannersHolder val_11 = this;
        if(this.下下丂丂业丟一下丙 == false)
        {
                return false;
        }
        
        val_11 = this.VeteranChestBannerHolder;
        if(val_11 == 0)
        {
                return false;
        }
        
        val_11 = PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世();
        if(val_11.世东丑丁上业专丏丙() == false)
        {
                return false;
        }
        
        if(ExpController.丑七不且上丗丁一世() == 0)
        {
                return false;
        }
        
        val_11 = ExpController.丑七不且上丗丁一世();
        if(val_11.下不上丌丘七世丘丙() == true)
        {
                return false;
        }
        
        val_11 = ExpController.丑七不且上丗丁一世();
        if(val_11.丆丝丅丗世丞丟下且() != true)
        {
                val_11 = ExpController.丑七不且上丗丁一世();
            if(val_10.丘一专丛丅丗专丅丒 == false)
        {
                return false;
        }
        
        }
        
        return false;
    }
    private bool 上下下上三业丒丐东()
    {
        object val_11;
        UnityEngine.Transform val_12;
        val_11 = this;
        UnityEngine.Debug.Log(message:  ">>> TryShowVeteranChest");
        if(this.丘业丞丗上且一丏下() == false)
        {
                return false;
        }
        
        if(ProgressRoadView.IsActive == true)
        {
                return false;
        }
        
        val_12 = 1152921504615739392;
        Rilisoft.GameEventOpenChestBase.且丐三丅丁且万且下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丅三丟下七丂三丟万()));
        LootBoxBanner.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丅三丟下七丂三丟万()));
        PGCompany.VeteranChest.丒专丛丒丄业丛业丁.东不丙三与丟丈东丘(七万上丐一丈丏丏专:  this.VeteranChestBannerHolder, 七丘丑丂且万丄丒丟:  true);
        UnityEngine.GameObject val_5 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Banners/VeteranChestMatchEndCamera");
        if(val_5 != 0)
        {
                val_12 = this.VeteranChestBannerHolder.transform;
            this.丑丄丘一丐丐七七丞 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_5, parent:  val_12, worldPositionStays:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ActionPanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startInterfacePanel, 丏业丟一东丂东丘丛:  false);
        val_11 = this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().gameObject;
        val_11.SetActive(value:  false);
        return false;
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        WeaponManager val_13;
        var val_14;
        var val_15;
        var val_16;
        val_13 = this;
        if(this.ReasonsPanel != 0)
        {
                if(this.ReasonsPanel.activeInHierarchy != false)
        {
                this.丗丌一不丁七丙丕丕();
            return;
        }
        
        }
        
        if(this.ActionPanel != 0)
        {
                if(this.ActionPanel.activeInHierarchy != false)
        {
                this.丌七丕世丌业丅丞丈();
            return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_14 = null;
            val_14 = null;
            val_13 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_13 == 0)
        {
                return;
        }
        
            val_15 = null;
            val_15 = null;
            val_13 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 88];
            val_13 = WeaponManager.丟丗丄业丘丗业丗七.myTable;
            if(val_13 == 0)
        {
                return;
        }
        
            val_16 = null;
            val_16 = null;
            GetComponent<NetworkStartTable>().丞丈丏丈世丛丒丛丞();
            return;
        }
        
        if(this.丒丕丟东三世丑丛丟().activeInHierarchy == false)
        {
                return;
        }
        
        UIButton val_12 = this.丒丕丟东三世丑丛丟().GetComponent<UIButton>();
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_12.onClick);
    }
    internal void 丆丗丌世且丛丐丒丗(string 丛丄世丐丐丗且丈与, string 丆丆丂业丒丈丙丒丅, bool 下上丐东丛丗丐且丑)
    {
        var val_6;
        var val_7;
        var val_8;
        this.丆世丘丒丒丏上且丗 = 丛丄世丐丐丗且丈与;
        this.不丆业丏上丐与丌业 = 丆丆丂业丒丈丙丒丅;
        this.丏且丒不上丄不丘三 = 下上丐东丛丗丐且丑;
        this.丞三专丈业丈丙丆丘();
        val_6 = 0;
        goto label_1;
        label_6:
        this.actionPanelNicklabel[0].text = this.不丆业丏上丐与丌业;
        val_6 = 1;
        label_1:
        if(val_6 < this.actionPanelNicklabel.Length)
        {
            goto label_6;
        }
        
        this.ActionPanel.SetActive(value:  true);
        this.spectatorModeBtnPnl.SetActive(value:  false);
        val_7 = null;
        val_7 = null;
        if((((FriendsController.丄丞丁丈与业上丞丟.IsShowAdd(业丗丑丝丙业丝丏上:  this.丆世丘丒丒丏上且丗)) == false) || (this.下丐丙且不丞与丘丛 > 2)) || ((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.friends")) == false))
        {
            goto label_14;
        }
        
        val_8 = this.AddButton.GetComponent<UIButton>();
        if(val_8 != null)
        {
            goto typeof(UIButton).__il2cppRuntimeField_178;
        }
        
        goto typeof(UIButton).__il2cppRuntimeField_178;
        label_14:
        val_8 = this.AddButton.GetComponent<UIButton>();
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void 丌丑与专丆丞丆丘一()
    {
        var val_6;
        var val_7;
        this.ActionPanel.SetActive(value:  false);
        this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  this.丁丘丟万丙万且丆专);
        if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true)) && (GameConnect.世丐丄三三上丅七三() != true))
        {
                val_6 = null;
            val_6 = null;
            if(与丂丏丛丞丞丒丟丄.与丈丝丌东丄丏丞丙 != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        }
        
        }
        
        val_7 = null;
        val_7 = null;
        if(丞下丗丞一业丏上不() == false)
        {
                return;
        }
        
        if(this.上丏丙东丁不丕丁丟 != false)
        {
                return;
        }
        
        this.spectatorModeBtnPnl.SetActive(value:  true);
    }
    private void 下丗丛万不丄丏丐丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_6;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Show ReasonPanel");
        this.ReasonsPanel.SetActive(value:  true);
        this.ActionPanel.SetActive(value:  false);
    }
    private void 且丘且丙丁世不丕丅()
    {
        var val_6;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        this.ReasonsPanel.SetActive(value:  false);
        this.ActionPanel.SetActive(value:  true);
    }
    internal bool 丞丁丛丐不丞丗丒三()
    {
        var val_3;
        if(this.ActionPanel.activeInHierarchy == false)
        {
            goto label_1;
        }
        
        this.丌七丕世丌业丅丞丈();
        goto label_2;
        label_1:
        if(this.ReasonsPanel.activeInHierarchy == false)
        {
            goto label_4;
        }
        
        this.丗丌一不丁七丙丕丕();
        label_2:
        val_3 = 1;
        return (bool)val_3;
        label_4:
        val_3 = 0;
        return (bool)val_3;
    }
    private void 丈万七丑丙万与丏丝(bool 下下东且万业丞丅丒)
    {
        UILabel val_10;
        var val_11;
        var val_12;
        val_10 = this;
        下下东且万业丞丅丒 = 下下东且万业丞丅丒;
        this.exitDialogTeamDuel.SetActive(value:  下下东且万业丞丅丒);
        if(下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        if(RatingSystem.与且丙丒丂丗世丂世() != false)
        {
                val_11 = 0;
        }
        else
        {
                val_11 = UnityEngine.PlayerPrefs.GetInt(key:  "p_Leave_count", defaultValue:  0);
        }
        
        val_12 = null;
        val_10 = this.exitDialogTeamDuelLabel;
        val_12 = null;
        if(val_11 < RatingSystem.七业丈丝万丆下丏七)
        {
                string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6585");
        }
        
        val_10.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2950"), arg0:  UnityEngine.Mathf.Abs(value:  RatingSystem.与一丅丝不丈业与丙().一丈丒东丑专丒丅丘()).ToString());
    }
    private void 万丕丄丈丟东丑一一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_3 = null;
            val_3 = null;
            typeof(NetworkStartTable).__il2cppRuntimeField_71 = 1;
        }
        
        this.丟且丗东丗丗丗世丟();
    }
    private void 丁丁专丈丟业一丙丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丈万七丑丙万与丏丝(下下东且万业丞丅丒:  false);
    }
    private void 东丙不丕丑七下丙丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 == true)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_17 = null;
            val_17 = null;
            if((上且一丁七丙丙丈丁(丝丐不丛丗七七丞一:  true)) != false)
        {
                if(RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅() >= 1)
        {
                this.丈万七丑丙万与丏丝(下下东且万业丞丅丒:  true);
            return;
        }
        
        }
        
        }
        
        this.丟且丗东丗丗丗世丟();
    }
    private void 丟且丗东丗丗丗世丟()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_13 = null;
        val_13 = null;
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 == true)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_16 = null;
            val_16 = null;
            GetComponent<NetworkStartTable>().丗一丄七世不专丞丟();
            return;
        }
        
        bool val_12 = this.丞丁丛丐不丞丗丒三();
    }
    internal void 三丆业丈不一丘丁丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = 1152921505175109632;
        val_15 = 0;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 == true)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        if(this.丏且丒不上丄不丘三 != true)
        {
                int val_14 = this.下丐丙且不丞与丘丛;
            val_14 = val_14 + 1;
            this.下丐丙且不丞与丘丛 = val_14;
            object val_9 = (GameConnect.东且三丆丑世世丘丟() != true) ? "Sandbox (Dating)" : "Multiplayer Battle";
            System.Collections.Generic.Dictionary<System.String, System.Object> val_10 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_10 != null)
        {
                val_10.Add(key:  "Added Friends", value:  val_9);
        }
        else
        {
                val_10.Add(key:  "Added Friends", value:  val_9);
        }
        
            val_10.Add(key:  "Deleted Friends", value:  "Add");
            丌丟丄专丂丒丁丛三.丑七不且上丗丁一世().丙与丗世丏丅丈丞万(丄丒且丙三丆丟与丏:  this.丆世丘丒丒丏上且丗, 下丏丏世丈丌丕丛与:  val_10, 业丏丈世世世丞丒世:  0);
            val_17 = null;
            val_17 = null;
            val_14 = this.丆世丘丒丒丏上且丗;
            val_15 = public System.Boolean System.Collections.Generic.List<System.String>::Contains(System.String item);
            if((Contains(item:  val_14)) != true)
        {
                val_18 = null;
            val_18 = null;
            val_14 = this.丆世丘丒丒丏上且丗;
            val_15 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            Add(item:  val_14);
        }
        
        }
        
        if((this.AddButton.GetComponent<UIButton>()) == null)
        {
            
        }
    
    }
    private void 丌七丕世丌业丅丞丈()
    {
        var val_6;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        this.丌丑与专丆丞丆丘一();
    }
    private void 丗丌一不丁七丙丕丕()
    {
        var val_6;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        this.且丘且丙丁世不丕丅();
    }
    private void 上丝丂丄万世丟下丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_7;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        FeedbackMenuController.上丌丂且世不丁丈丛(丕丒上丄丒业丕丕丐:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::世丏丂且万丒丅东上()));
    }
    private void 丆世万丙业丘丑丑丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_7;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        FeedbackMenuController.上丌丂且世不丁丈丛(丕丒上丄丒业丕丕丐:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丐万专丘丞与丑丗丑()));
    }
    private void 丘丅丗丙丘专一丟丙(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_7;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        FeedbackMenuController.上丌丂且世不丁丈丛(丕丒上丄丒业丕丕丐:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丄三业丅与下丗且丙()));
    }
    internal void 丆丄上丛丝东丅专东()
    {
        var val_11;
        var val_12;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                SetActive(value:  true);
        }
        
        this.spectratorDuelScoreController.SetActive(value:  GameConnect.一与东丝万上三丆丏());
        this.spectatorModeOnBtn.SetActive(value:  true);
        this.spectatorModeOffBtn.SetActive(value:  false);
        this.spectratorModePnl.SetActive(value:  true);
        this.socialPnl.SetActive(value:  false);
        this.socialPnl.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  false, 丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        this.exitButtonTeamDuel.gameObject.SetActive(value:  GameConnect.一与东丝万上三丆丏());
        this.丞三专丈业丈丙丆丘();
        this.丗东丞一丞丑三丈专(丛丅丘一丏丙且丌上:  false);
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_12 = null;
            val_12 = null;
            NetworkStartTable val_9 = GetComponent<NetworkStartTable>();
            val_9.丄丝丛丟丙世丁不丁 = true;
        }
        
        if(GameConnect.一业上七丟业且业丙() == false)
        {
                return;
        }
        
        this.modePanel.SetActive(value:  true);
    }
    internal void 业七万七专丄丑万丘()
    {
        bool val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                SetActive(value:  false);
        }
        
        this.spectatorModeOnBtn.SetActive(value:  false);
        this.spectatorModeOffBtn.SetActive(value:  true);
        this.spectratorModePnl.SetActive(value:  false);
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_18 = 0;
        }
        else
        {
                bool val_3 = GameConnect.与丂丝丟丟三丑丝万();
            val_18 = (~val_3) & 1;
        }
        
        val_3.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  val_18, 丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        this.exitButtonTeamDuel.gameObject.SetActive(value:  false);
        this.exitDialogTeamDuel.SetActive(value:  false);
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_20 = null;
            val_20 = null;
            if(NetworkStartTable.__il2cppRuntimeField_generic_class != 0)
        {
                val_21 = null;
            val_21 = null;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  NetworkStartTable.__il2cppRuntimeField_generic_class.transform.GetChild(index:  0).gameObject, 不东丛三丂丌丑专丆:  0);
        }
        
            val_22 = null;
            val_22 = null;
            NetworkStartTable val_11 = GetComponent<NetworkStartTable>();
            val_11.丄丝丛丟丙世丁不丁 = false;
        }
        
        if((GameConnect.一与东丝万上三丆丏() != true) && (GameConnect.与丂丝丟丟三丑丝万() != true))
        {
                if(GameConnect.丒丗丁丙丗丄丙不丐() != true)
        {
                this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  true);
            this.丌三上丁丞丆丛丑下();
        }
        
        }
        
        if(GameConnect.丒丗丁丙丗丄丙不丐() != false)
        {
                this.plantTheBombPanel.SetActive(value:  false);
        }
        
        if(GameConnect.一业上七丟业且业丙() == false)
        {
                return;
        }
        
        this.modePanel.SetActive(value:  false);
    }
    internal void 丑与丑丕七丞一一丏()
    {
        var val_3;
        if(this.丑东丅七业丞丆万丘 == true)
        {
                return;
        }
        
        this.<丞三丅三丟万丟丟业>k__BackingField = 0;
        this.丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  this.上下三三丟丆丟丕丞);
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable == 0)
        {
                UnityEngine.Object.Destroy(obj:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.gameObject);
        }
        
        this.丑东丅七业丞丆万丘 = true;
    }
    internal RewardWindowBase 且丘丏丑不丈丒专丕()
    {
        return (RewardWindowBase)this.<丞三丅三丟万丟丟业>k__BackingField;
    }
    internal void 丄丄丂上丘丛丄丐丞(RewardWindowBase 丙业与丙丗丝不丈东)
    {
        this.<丞三丅三丟万丟丟业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丒丈丗三专丅丒丌三(bool 丑一丂丙丈丝丑丅丑, bool 专东丘一三丐不丈专)
    {
        var val_40;
        UnityEngine.AudioClip val_41;
        var val_42;
        var val_43;
        string val_44;
        var val_45;
        var val_46;
        var val_47;
        if(((GameConnect.丆丁上丟丛业丄丅丝() != true) && (GameConnect.万不丒丌丙万丗东不() != true)) && (GameConnect.丅丟下专不丁一丈七() != true))
        {
                if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_15;
        }
        
        }
        
        }
        
        label_120:
        this.finishedInterface.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  true);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(专东丘一三丐不丈专 != false)
        {
                val_40 = 1152921505093320704;
            val_41 = this.deadheatSound;
        }
        else
        {
                if(丑一丂丙丈丝丑丅丑 != false)
        {
                val_40 = 1152921505093320704;
            val_41 = this.winSound;
        }
        else
        {
                val_40 = 1152921505093320704;
            val_41 = this.looseSound;
        }
        
        }
        
            UnityEngine.AudioSource val_7 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_41);
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) == 0)
        {
            goto label_32;
        }
        
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_35;
        }
        
        val_42 = "Key_1987";
        goto label_45;
        label_35:
        if(专东丘一三丐不丈专 == false)
        {
            goto label_37;
        }
        
        val_42 = "Key_0571";
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_45;
        }
        
        val_43 = null;
        val_43 = null;
        var val_12 = (Count < 2) ? "Key_2436" : (val_42);
        goto label_45;
        label_37:
        label_45:
        val_44 = mem[丑一丂丙丈丝丑丅丑 != true ? "Key_1115" : 1 != 0x0 ? "Key_1116" : "Key_1976"];
        val_44 = (丑一丂丙丈丝丑丅丑 != true) ? "Key_1115" : ((1 != 0) ? "Key_1116" : "Key_1976");
        goto label_48;
        label_32:
        val_44 = mem[专东丘一三丐不丈专 != true ? "Key_3696" : 丑一丂丙丈丝丑丅丑 != true ? "Key_3685" : "Key_3686"];
        val_44 = (专东丘一三丐不丈专 != true) ? "Key_3696" : ((丑一丂丙丈丝丑丅丑 != true) ? "Key_3685" : "Key_3686");
        label_48:
        bool val_40 = 丑一丂丙丈丝丑丅丑;
        val_40 = ((1 != 0) ? 1 : 0) | val_40;
        val_45 = 0;
        goto label_57;
        label_67:
        UnityEngine.GameObject val_41 = this.finishDraw[0];
        if((val_40 & 专东丘一三丐不丈专 ^ 1) != true)
        {
                if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_55;
        }
        
        }
        
        if(val_41 != null)
        {
            goto label_64;
        }
        
        label_65:
        label_64:
        val_41.SetActive(value:  (0 != 0) ? 1 : 0);
        val_45 = 1;
        goto label_57;
        label_55:
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_60;
        }
        
        if(val_41 != null)
        {
            goto label_64;
        }
        
        goto label_65;
        label_60:
        if(val_41 != null)
        {
            goto label_64;
        }
        
        goto label_65;
        label_57:
        if(val_45 < this.finishDraw.Length)
        {
            goto label_67;
        }
        
        bool val_42 = 丑一丂丙丈丝丑丅丑;
        val_46 = 0;
        val_42 = val_42 ^ 1;
        goto label_75;
        label_85:
        UnityEngine.GameObject val_43 = this.finishWin[0];
        if((val_42 | 专东丘一三丐不丈专) != true)
        {
                if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_73;
        }
        
        }
        
        if(val_43 != null)
        {
            goto label_82;
        }
        
        label_83:
        label_82:
        val_43.SetActive(value:  (0 != 0) ? 1 : 0);
        val_46 = 1;
        goto label_75;
        label_73:
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_78;
        }
        
        if(val_43 != null)
        {
            goto label_82;
        }
        
        goto label_83;
        label_78:
        if(val_43 != null)
        {
            goto label_82;
        }
        
        goto label_83;
        label_75:
        if(val_46 < this.finishWin.Length)
        {
            goto label_85;
        }
        
        var val_28 = (1 == 0) ? 1 : 0;
        val_28 = val_28 | 丑一丂丙丈丝丑丅丑;
        val_47 = 0;
        goto label_93;
        label_103:
        UnityEngine.GameObject val_44 = this.finishDefeat[0];
        if((val_28 | 专东丘一三丐不丈专) != true)
        {
                if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_91;
        }
        
        }
        
        if(val_44 != null)
        {
            goto label_100;
        }
        
        label_101:
        label_100:
        val_44.SetActive(value:  (0 != 0) ? 1 : 0);
        val_47 = 1;
        goto label_93;
        label_91:
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_96;
        }
        
        if(val_44 != null)
        {
            goto label_100;
        }
        
        goto label_101;
        label_96:
        if(val_44 != null)
        {
            goto label_100;
        }
        
        goto label_101;
        label_93:
        if(val_47 < this.finishDefeat.Length)
        {
            goto label_103;
        }
        
        this.roundShieldsContainer.gameObject.SetActive(value:  GameConnect.一与东丝万上三丆丏());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.finishedInterfaceLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_44));
        this.finishedInterfaceLabels[0].gameObject.SetActive(value:  true);
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        if(丑一丂丙丈丝丑丅丑 == true)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.finishedInterfaceLabels, 丕丗丘丑丛与丑业丒:  "");
        return;
        label_15:
        bool val_39 = GameConnect.丙丌丒丈东七丒上丌();
        goto label_120;
    }
    private void 且东丟且丌丈丈丒丐()
    {
        this.startInterfacePanel.SetActive(value:  false);
        this.allInterfacePanel.SetActive(value:  false);
        this.丞三专丈业丈丙丆丘();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
        this.duelPanel.SetActive(value:  true);
        this.duelUI.ShowStartInterface();
    }
    private void 丛不丛丐丒丑丗业丁()
    {
        this.startInterfacePanel.SetActive(value:  false);
        this.allInterfacePanel.SetActive(value:  false);
        this.丞三专丈业丈丙丆丘();
        this.teamDuelUI.ShowStartInterface();
    }
    internal void 丐且丂不丛专下三丆()
    {
        this.startInterfacePanel.SetActive(value:  false);
        this.allInterfacePanel.SetActive(value:  false);
        this.丞三专丈业丈丙丆丘();
        this.siegeUI.ShowStartInterface();
    }
    internal void 世丞万丂丛东业丄丕()
    {
        this.startInterfacePanel.SetActive(value:  false);
        this.allInterfacePanel.SetActive(value:  false);
        this.丞三专丈业丈丙丆丘();
        this.matchMakingUI.backButton.SetActive(value:  false);
        this.matchMakingUI.ShowStartInterface();
    }
    private void 世丞丟丞丞业丕丄与()
    {
        this.startInterfacePanel.SetActive(value:  false);
        this.allInterfacePanel.SetActive(value:  false);
        this.丞三专丈业丈丙丆丘();
        this.dungeonsUI.ShowStartInterface();
    }
    public void ShowStartInterface()
    {
        var val_22;
        if(QuestsGSMAnager.丑七不且上丗丁一世().ActiveQuest != null)
        {
                丏下丒东丅丏丌一丛 val_4 = QuestsGSMAnager.丑七不且上丗丁一世().ActiveQuest;
        }
        
        val_22 = null;
        val_22 = null;
        GameController.onlineMode.丗三不丞丈业丑丘万 = true;
        if(GameConnect.业丛丛丂一丆丕丗丟() != false)
        {
                this.且东丟且丌丈丈丒丐();
            return;
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                this.丛不丛丐丒丑丗业丁();
            return;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                this.丐且丂不丛专下三丆();
            return;
        }
        
        if(GameConnect.业丗与丈丁东下一丛() != false)
        {
                this.世丞万丂丛东业丄丕();
            return;
        }
        
        bool val_9 = GameConnect.且丞丁东丝丗上丈业();
        if(val_9 != false)
        {
                this.世丞丟丞丞业丕丄与();
            return;
        }
        
        val_9.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  false, 丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        this.goBattleLabel.SetActive(value:  (~GameConnect.东且三丆丑世世丘丟()) & 1);
        this.daterButtonLabel.SetActive(value:  GameConnect.东且三丆丑世世丘丟());
        if(this.ReadyTimerContainer != 0)
        {
                this.ReadyTimerContainer.SetActive(value:  false);
        }
        
        if(this.sniperModeHint != 0)
        {
                this.sniperModeHint.SetActive(value:  false);
        }
        
        this.三东且三丈与丂丐丄(下丁丞丝丛一丘丐丒:  true);
        this.startInterfacePanel.SetActive(value:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().gameObject.SetActive(value:  false);
        this.上丏丙东丁不丕丁丟 = false;
        this.三与万丝丒一丏丝七 = false;
        this.丌一丏丘丞东与上世 = false;
        this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  true);
        var val_23 = 0;
        val_23 = val_23 + 1;
        this.专东丝丈丕丞与万不 = this.StartCoroutine(routine:  this.TryToShowExpiredBanner().GetEnumerator());
    }
    private System.Collections.IEnumerator 且丄丄专东下丈丈七()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NetworkStartTableNGUIController.丝七丟丂丟不丞丒丞(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 丒丆且丑业世丅三上()
    {
        null = null;
        GameController.onlineMode.丗三不丞丈业丑丘万 = false;
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                this.siegeUI.丒丆且丑业世丅三上();
        }
        
        if(GameConnect.业丗与丈丁东下一丛() != false)
        {
                this.matchMakingUI.丒丆且丑业世丅三上();
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                this.dungeonsUI.丒丆且丑业世丅三上();
        }
        
        this.上丏丙东丁不丕丁丟 = false;
        this.三与万丝丒一丏丝七 = false;
        this.丌一丏丘丞东与上世 = false;
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().gameObject.SetActive(value:  false);
        UnityEngine.Debug.Log(message:  "Hide Start Interface");
        this.finishedInterface.SetActive(value:  false);
        this.allInterfacePanel.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
        this.startInterfacePanel.SetActive(value:  false);
        this.ReasonsPanel.SetActive(value:  false);
        this.ActionPanel.SetActive(value:  false);
        this.丁丘丟万丙万且丆专 = true;
        this.丞三专丈业丈丙丆丘();
        if(this.专东丝丈丕丞与万不 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.专东丝丈丕丞与万不);
        this.专东丝丈丕丞与万不 = 0;
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        if(东丗七丕丄不丐专丒 == true)
        {
                return;
        }
        
        if(this.clanwarChallagne == 0)
        {
                return;
        }
        
        if(this.clanwarChallagne._challengeView == 0)
        {
                return;
        }
        
        if(this.丐丐丑丏丁丙上上丄 == false)
        {
                return;
        }
        
        this.interfaceAnimator.SetBool(name:  "ClanWarHide", value:  true);
        this = this.clanwarChallagne._challengeView;
        this.clanwarChallagne._challengeView.专下七丌丙丂丟万丐 = false;
    }
    private void 三专丟丞世丌丟丕且(string 丏三万下丘下专丛专, RatingSystem.丁上且上一丆丘与业 丕丈一丐丛世丆上万)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.且下丂上且丝丒丝丞(丏三万下丘下专丛专:  丏三万下丘下专丛专, 丕丈一丐丛世丆上万:  new 丁上且上一丆丘与业() {丈丘丙丛丗不七专丟 = 丕丈一丐丛世丆上万.丈丘丙丛丗不七专丟, 丈丐丒丐丕丛东丑业 = 丕丈一丐丛世丆上万.丈丘丙丛丗不七专丟, 丗丛世世丙丝丌与丑 = 丕丈一丐丛世丆上万.丗丛世世丙丝丌与丑}, 丆丐丐丕世丕丌世与:  false, 业七丅丟东丑专丅万:  0, 丟丒丅丂丛丄丗万丌:  0, 不丄丅一一一丏一丌:  false, 丁东丄东丑与七丆世:  false, 专丌丁且丗与丞丕且:  false, 丑丏七丙下丛丐丁一:  false, 丕东丈丒与丟丅丞丁:  0, 丝丕三丝丗丞且丟丐:  0, 七丛丕七不丄不丆丄:  0, 丈三丌丁丈丒丅丌三:  0, 丑丑上丑下丐下丌业:  0, 丁丑下丄东丙一丘且:  false, 业专丁丘丐丅万专与:  0, 丆世万七丆世丟丌业:  0, 丅下七下不东不丂丝:  0, 丄丅丟丟丛丟丟丟上:  0, 丌三丒丌丆东万丆一:  false, 丄丗世丈丈丙不丐丂:  0, 丏丝且世丞丅与丆东:  0, 业东丆丒丏丒丒专世:  0, 一下下丛七丈丅丂与:  0));
    }
    internal void 业丁七丞与一万丆丅()
    {
        if(this.spectratorModePnl.activeSelf != false)
        {
                this.业七万七专丄丑万丘();
            return;
        }
        
        this.spectatorModeOnBtn.SetActive(value:  false);
        this.spectatorModeOffBtn.SetActive(value:  true);
        this.spectratorModePnl.SetActive(value:  false);
    }
    internal static void 丘专丗丗丕丄丗丐丆()
    {
        var val_5;
        Player_move_c val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_6 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        丒丈丛丘丄七三丒丆();
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                InGameGUI.丙丞专丌丁丞与不丐.DeactivateInterface();
        }
        
        val_8 = null;
        val_8 = null;
        val_6 = ChatViewrController.丄丞丁丈与业上丞丟;
        if(val_6 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        UnityEngine.Object.Destroy(obj:  ChatViewrController.丄丞丁丈与业上丞丟.gameObject);
    }
    internal void 丏丑丅丕东七丌丞上(专上丈丌丒丁丒丆三.上丑丝丌七不丙丗丅 丒丝下丙万丟丂世丆, 丁丁丒丆不丒下丟三 丞丙下万丗丝丄七丝)
    {
        string val_17;
        var val_18;
        int val_21;
        int val_22;
        int val_23;
        int val_24;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_3;
        }
        
        if(丞丙下万丗丝丄七丝.丞七一丛丟下丝丏丙 == 0)
        {
            goto label_7;
        }
        
        if(丞丙下万丗丝丄七丝.与丟丙丛东丒丞万丆 == 3)
        {
            goto label_27;
        }
        
        if(丞丙下万丗丝丄七丝.与丟丙丛东丒丞万丆 == 2)
        {
            goto label_9;
        }
        
        if(丞丙下万丗丝丄七丝.与丟丙丛东丒丞万丆 != 1)
        {
            goto label_32;
        }
        
        val_17 = "Key_1762";
        goto label_27;
        label_3:
        if(丞丙下万丗丝丄七丝 != null)
        {
            goto label_32;
        }
        
        val_18 = 1;
        goto label_15;
        label_7:
        val_17 = "Key_1427";
        label_27:
        label_31:
        label_32:
        val_18 = 0;
        label_15:
        if(GameConnect.世丐丄三三上丅七三() != false)
        {
                var val_6 = (丞丙下万丗丝丄七丝.丄上丐丞上一专丑丛 == true) ? 1 : 0;
        }
        
        val_21 = 丒丝下丙万丟丂世丆.下丅丌丌丆不东专丁;
        val_22 = 丒丝下丙万丟丂世丆.丌丙专丗丏不丐丗丅;
        val_24 = 丒丝下丙万丟丂世丆.上丛丕丙三丁专下丂;
        val_23 = 丒丝下丙万丟丂世丆.丕且七丅业丄丝丞东;
        if(this == null)
        {
                val_23 = val_23;
            val_21 = val_21;
            val_24 = val_24;
            val_22 = val_22;
        }
        
        UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  this.且下丂上且丝丒丝丞(丏三万下丘下专丛专:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_17), 丕丈一丐丛世丆上万:  new 丁上且上一丆丘与业() {丈丘丙丛丗不七专丟 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万, 丈丐丒丐丕丛东丑业 = 丞丙下万丗丝丄七丝.丕丈一丐丛世丆上万, 丗丛世世丙丝丌与丑 = 136903856}, 丆丐丐丕世丕丌世与:  false, 业七丅丟东丑专丅万:  642110368, 丟丒丅丂丛丄丗万丌:  丒丝下丙万丟丂世丆.下丅丌丌丆不东专丁.丆丒丘丐下丞丛上丈(), 不丄丅一一一丏一丌:  (丞丙下万丗丝丄七丝.丟不世三丘与丆丘丂 == true) ? 1 : 0, 丁东丄东丑与七丆世:  (丞丙下万丗丝丄七丝.且七丙丁与丌丗与上 == 0) ? 1 : 0, 专丌丁且丗与丞丕且:  (丞丙下万丗丝丄七丝.与丟丙丛东丒丞万丆 == 1) ? 1 : 0, 丑丏七丙下丛丐丁一:  (丞丙下万丗丝丄七丝.与丟丙丛东丒丞万丆 == 3) ? 1 : 0, 丕东丈丒与丟丅丞丁:  丞丙下万丗丝丄七丝.丙东世丟下丑丙丈丞, 丝丕三丝丗丞且丟丐:  (int)丞丙下万丗丝丄七丝.东丙丂丌丒丏丅丄丕, 七丛丕七不丄不丆丄:  (int)丞丙下万丗丝丄七丝.丘丁七丁不丙不丟上, 丈三丌丁丈丒丅丌三:  1152921531018761120, 丑丑上丑下丐下丌业:  val_22, 丁丑下丄东丙一丘且:  (丞丙下万丗丝丄七丝.不丁丛丈丙世丈万丟 == true) ? 1 : 0, 业专丁丘丐丅万专与:  val_24, 丆世万七丆世丟丌业:  val_23, 丅下七下不东不丂丝:  丒丝下丙万丟丂世丆.业丒下业丛丆丂丗丕, 丄丅丟丟丛丟丟丟上:  val_21, 丌三丒丌丆东万丆一:  (丞丙下万丗丝丄七丝.丄上丐丞上一专丑丛 == true) ? 1 : 0, 丄丗世丈丈丙不丐丂:  丒丝下丙万丟丂世丆.丄丐不丏丁丘不丒丈, 丏丝且世丞丅与丆东:  丒丝下丙万丟丂世丆.上丁丗丐丝丛丝世丂, 业东丆丒丏丒丒专世:  丒丝下丙万丟丂世丆.业东丆丒丏丒丒专世, 一下下丛七丈丅丂与:  丒丝下丙万丟丂世丆.世一丆丟与与专七万));
        return;
        label_9:
        string val_16 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1763"), arg0:  丞丙下万丗丝丄七丝.丞七一丛丟下丝丏丙.丂丈丐不丏万三七丐);
        goto label_31;
    }
    private bool 一丈丛丘与丕丛丝东()
    {
        var val_13;
        if(GameConnect.不专专丂万丝上东丐() == true)
        {
                return true;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return true;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == true)
        {
                return true;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() == true)
        {
                return true;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == true)
        {
                return true;
        }
        
        if(GameConnect.业丗与丈丁东下一丛() == true)
        {
                return true;
        }
        
        if(GameConnect.东丒七专丂世丝丏丗() == true)
        {
                return true;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == true)
        {
                return true;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() == true)
        {
                return true;
        }
        
        val_13 = null;
        val_13 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == true)
        {
                return true;
        }
        
        if(GameConnect.丒丈丒万七丁东丁不() == true)
        {
                return true;
        }
        
        if(GameConnect.丒丗丁丙丗丄丙不丐() == true)
        {
                return true;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return GameConnect.一业上七丟业且业丙();
        }
        
        return true;
    }
    internal void 与丏东上丅丕上万上(int 下上丐丂丈东丆丝东, int 专且一上丒丟上丄丗, int 丁丞丗业丆丒上丈丞)
    {
        this.ranksTable.totalBlue = 下上丐丂丈东丆丝东;
        this.ranksTable.totalRed = 专且一上丒丟上丄丗;
        this.ranksTable.且丂不丗丛丟丗丑丞(丂丆专不丙丘丞丕且:  丁丞丗业丆丒上丈丞);
    }
    internal System.Collections.IEnumerator 且下丂上且丝丒丝丞(string 丏三万下丘下专丛专, RatingSystem.丁上且上一丆丘与业 丕丈一丐丛世丆上万, bool 丆丐丐丕世丕丌世与, int 业七丅丟东丑专丅万, int 丟丒丅丂丛丄丗万丌, bool 不丄丅一一一丏一丌, bool 丁东丄东丑与七丆世, bool 专丌丁且丗与丞丕且, bool 丑丏七丙下丛丐丁一, int 丕东丈丒与丟丅丞丁, int 丝丕三丝丗丞且丟丐, int 七丛丕七不丄不丆丄, int 丈三丌丁丈丒丅丌三, int 丑丑上丑下丐下丌业, bool 丁丑下丄东丙一丘且, int 业专丁丘丐丅万专与, int 丆世万七丆世丟丌业, int 丅下七下不东不丂丝, int 丄丅丟丟丛丟丟丟上, bool 丌三丒丌丆东万丆一, Rilisoft.OfferItem 丄丗世丈丈丙不丐丂, PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丏丝且世丞丅与丆东, int 业东丆丒丏丒丒专世, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 一下下丛七丈丅丂与)
    {
        NetworkStartTableNGUIController.丅丗丞丙丙万与七且 val_1 = new NetworkStartTableNGUIController.丅丗丞丙丙万与七且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丏三万下丘下专丛专 = 丏三万下丘下专丛专;
            .丆丐丐丕世丕丌世与 = 丆丐丐丕世丕丌世与;
            .不丄丅一一一丏一丌 = 不丄丅一一一丏一丌;
            .丁东丄东丑与七丆世 = 丁东丄东丑与七丆世;
            .专丌丁且丗与丞丕且 = 专丌丁且丗与丞丕且;
            .丑丏七丙下丛丐丁一 = 丑丏七丙下丛丐丁一;
            .丕东丈丒与丟丅丞丁 = 丕东丈丒与丟丅丞丁;
            .丟丒丅丂丛丄丗万丌 = 丟丒丅丂丛丄丗万丌;
            .丝丕三丝丗丞且丟丐 = 丝丕三丝丗丞且丟丐;
            .业七丅丟东丑专丅万 = 业七丅丟东丑专丅万;
            .七丛丕七不丄不丆丄 = 七丛丕七不丄不丆丄;
            .丈三丌丁丈丒丅丌三 = 丈三丌丁丈丒丅丌三;
            .丁丑下丄东丙一丘且 = 丁丑下丄东丙一丘且;
            .丑丑上丑下丐下丌业 = 丑丑上丑下丐下丌业;
            .业专丁丘丐丅万专与 = 业专丁丘丐丅万专与;
            .丆世万七丆世丟丌业 = 丆世万七丆世丟丌业;
            .丅下七下不东不丂丝 = 丅下七下不东不丂丝;
            .丌三丒丌丆东万丆一 = 丌三丒丌丆东万丆一;
            .丄丅丟丟丛丟丟丟上 = 丄丅丟丟丛丟丟丟上;
            .丄丗世丈丈丙不丐丂 = 丄丗世丈丈丙不丐丂;
            .丕丈一丐丛世丆上万 = 丕丈一丐丛世丆上万.丈丘丙丛丗不七专丟;
            mem[1152921531019249088] = 丕丈一丐丛世丆上万.丗丛世世丙丝丌与丑;
            .丏丝且世丞丅与丆东 = 丏丝且世丞丅与丆东;
            .业东丆丒丏丒丒专世 = 业东丆丒丏丒丒专世;
        }
        else
        {
                mem[32] = this;
            mem[128] = 丏三万下丘下专丛专;
            mem[80] = 丕丈一丐丛世丆上万.丗丛世世丙丝丌与丑;
            mem[64] = 丕丈一丐丛世丆上万.丈丘丙丛丗不七专丟;
            .丆丐丐丕世丕丌世与 = 丆丐丐丕世丕丌世与;
            mem[56] = 业七丅丟东丑专丅万;
            mem[40] = 丟丒丅丂丛丄丗万丌;
            .不丄丅一一一丏一丌 = 不丄丅一一一丏一丌;
            mem[88] = 丁东丄东丑与七丆世;
            mem[96] = 专丌丁且丗与丞丕且;
            .丑丏七丙下丛丐丁一 = 丑丏七丙下丛丐丁一;
            .丕东丈丒与丟丅丞丁 = 丕东丈丒与丟丅丞丁;
            .丝丕三丝丗丞且丟丐 = 丝丕三丝丗丞且丟丐;
            mem[48] = 七丛丕七不丄不丆丄;
            .丈三丌丁丈丒丅丌三 = 丈三丌丁丈丒丅丌三;
            mem[136] = 丑丑上丑下丐下丌业;
            .丁丑下丄东丙一丘且 = 丁丑下丄东丙一丘且;
            .业专丁丘丐丅万专与 = 业专丁丘丐丅万专与;
            mem[104] = 丆世万七丆世丟丌业;
            .丅下七下不东不丂丝 = 丅下七下不东不丂丝;
            mem[144] = 丄丅丟丟丛丟丟丟上;
            .丌三丒丌丆东万丆一 = 丌三丒丌丆东万丆一;
            mem[112] = 丄丗世丈丈丙不丐丂;
            mem[120] = 丏丝且世丞丅与丆东;
            mem[152] = 业东丆丒丏丒丒专世;
        }
        
        .一下下丛七丈丅丂与 = 一下下丛七丈丅丂与;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 丐丏丅不丟丒丁丗丄()
    {
        TournamentController.七丅三丏三丛专丅与(丙业与丙丗丝不丈东:  this.丆七下丒上丈丒业世);
    }
    public void OnTrophyAnimationDone()
    {
        if(this.一七丑三丝丝丌丕丗 != false)
        {
                return;
        }
        
        this.与与丁下万丈丆丝上 = false;
        this.interfaceAnimator.SetBool(name:  "isTrophyAdded", value:  true);
        this.一七丑三丝丝丌丕丗 = true;
        this.丕业不丞不丕世且丏(丕丕世且下一与丝与:  0.5f);
    }
    public void StartClanWarViewAnimation()
    {
        if(this.clanwarChallagne == 0)
        {
                return;
        }
        
        this.clanwarChallagne._challengeView.StartAnimation();
    }
    internal void 丑丌丏丙上丂丒丞三()
    {
        if(this.trophySound == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.trophySound);
    }
    public void OnMatchEndAnimationDone()
    {
        this.interfaceAnimator.SetBool(name:  "interfaceAnimationDone", value:  true);
    }
    public void OnTablesShow()
    {
        this.世丒丗一丑丏丞丑一 = false;
    }
    public void OnHideTrophy()
    {
        this.与与丁下万丈丆丝上 = false;
        if(this.clanwarChallagne == 0)
        {
                return;
        }
        
        this.clanwarChallagne._challengeView.一一丐丂不一业丞丝 = false;
        this.clanwarChallagne._challengeView.丝一丅丆三东丂丞七();
        this = this.clanwarChallagne._challengeView;
        this.clanwarChallagne._challengeView.一一丐丂不一业丞丝 = true;
    }
    public void OnCWViewShow()
    {
        this.丐丐丑丏丁丙上上丄 = false;
        this.interfaceAnimator.SetBool(name:  "ClanWarChallangeActive", value:  false);
        if(this._clanWarChallengeHolder.childCount < 1)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this._clanWarChallengeHolder.GetChild(index:  0).gameObject);
        this.clanwarChallagne = 0;
    }
    public void OnRewardShow()
    {
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丑七专东丘丐三下丒.丙丝丒专一丌丑且丐(丗丗世丘丙不世丁丅:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::不丑丐丙丟丒丕且三())));
    }
    private void 不丑丐丙丟丒丕且三()
    {
        this.业丞东且万丈不丅三();
        bool val_1 = this.上下下上三业丒丐东();
    }
    private void 业丞东且万丈不丅三()
    {
        this.interfaceAnimator.SetTrigger(name:  "finishRewardAnimation");
        mem2[0] = 0;
        this.丈七丈丞专七丟专丛 = 0;
        this.七上世丌丘丕万丅东 = 0;
        this.丕专丐上东丑丑下丘 = 0;
        this.丂三丅丘丆丂丛七丌 = 0;
    }
    private void 丕业不丞不丕世且丏(float 丕丕世且下一与丝与)
    {
        this.七三丝丛丈三万丁一 = this.万丘丙世丐下丙丅丆(丕丕世且下一与丝与:  丕丕世且下一与丝与);
        UnityEngine.Coroutine val_3 = CoroutineRunner.Instance.StartCoroutine(routine:  this.七三丝丛丈三万丁一);
    }
    public void CanShowNextReward()
    {
        this.丆上丐丄丗丆丟丝丝 = true;
    }
    private System.Collections.IEnumerator 万丘丙世丐下丙丅丆(float 丕丕世且下一与丝与)
    {
        NetworkStartTableNGUIController.丐丗一丞业不丟三丝 val_1 = new NetworkStartTableNGUIController.丐丗一丞业不丟三丝(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丛三下丛丛丈万世丟(float 丕丕世且下一与丝与, bool 丈丅三丈丗丐下一丄 = False)
    {
        NetworkStartTableNGUIController.丄丛三丛丞万三丗下 val_1 = new NetworkStartTableNGUIController.丄丛三丛丞万三丗下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丕丕世且下一与丝与;
        }
        
        .丈丅三丈丗丐下一丄 = 丈丅三丈丗丐下一丄;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丒一不丅丌业丁三丕()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OkNoAdsButton, 丏业丟一东丂东丘丛:  true);
        if(NetworkStartTableNGUIController.丞丐与丙丛丏丁丅一 == null)
        {
                return;
        }
        
        NetworkStartTableNGUIController.丞丐与丙丛丏丁丅一.Invoke();
    }
    private System.Collections.IEnumerator 丏不三丁世专丐丅丞(丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三, float 丕丕世且下一与丝与)
    {
        NetworkStartTableNGUIController.上丞世一丟丙上专丂 val_1 = new NetworkStartTableNGUIController.上丞世一丟丙上专丂(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丗七丟丈三不丕一三 = 丗七丟丈三不丕一三;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丗七丟丈三不丕一三;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丛丙三丝下丐不丐丝()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NetworkStartTableNGUIController.与丆下丞丘且丘万七(丗丏丅丕丆世丁专丟:  0);
    }
    private void 不丞丆业丗世一丕东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.一丕东丌丈丝丟丝与();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardFullScreenButton, 丏业丟一东丂东丘丛:  false);
    }
    private void 一丕东丌丈丝丟丝与()
    {
        if(this.七三丝丛丈三万丁一 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.七三丝丛丈三万丁一);
        this.七三丝丛丈三万丁一 = 0;
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丛丙三丝下丐不丐丝());
    }
    public void StartTrophyAnim()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丟丗且一三丝丕业丙());
    }
    private System.Collections.IEnumerator 丟丗且一三丝丕业丙()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NetworkStartTableNGUIController.上专七丑丈丞丈东下(丗丏丅丕丆世丁专丟:  0);
    }
    private void 不三丒专丗丞一丒丛(int 业七丅丟东丑专丅万, int 丟丒丅丂丛丄丗万丌, bool 不丄丅一一一丏一丌, bool 丁东丄东丑与七丆世, int 丕东丈丒与丟丅丞丁, int 丈三丌丁丈丒丅丌三, int 七丒丄丙丙三东上丛, int 丑丑上丑下丐下丌业, bool 丁丑下丄东丙一丘且, int 业专丁丘丐丅万专与, int 丆世万七丆世丟丌业, int 丆丈丑下丈丆业东一, int 丄丅丟丟丛丟丟丟上, bool 丌三丒丌丆东万丆一, out Rilisoft.OfferItem 丛丐丌丐不丌丗三丕, Rilisoft.OfferItem 丄丗世丈丈丙不丐丂, PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丏丝且世丞丅与丆东, int 业东丆丒丏丒丒专世, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 一下下丛七丈丅丂与)
    {
        int val_63;
        int val_64;
        int val_65;
        Rilisoft.OfferItem val_96;
        int val_99;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_100;
        int val_135;
        int val_136;
        int val_137;
        var val_138;
        int val_139;
        int val_140;
        int val_141;
        int val_142;
        下东丙丑丙丞丛丑上 val_143;
        Rilisoft.OfferItem val_144;
        int val_145;
        bool val_146;
        NetworkStartTableNGUIController val_147;
        var val_148;
        var val_149;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_150;
        Rilisoft.七丕丟丏三丈一丄世 val_151;
        int val_152;
        var val_153;
        var val_154;
        var val_155;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_156;
        InGameConnection val_157;
        var val_158;
        bool val_159;
        var val_160;
        var val_161;
        int val_162;
        var val_163;
        var val_164;
        var val_165;
        int val_166;
        var val_167;
        var val_168;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_169;
        var val_170;
        Rilisoft.OfferItem val_171;
        var val_172;
        var val_173;
        System.Func<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗, System.Boolean> val_175;
        var val_176;
        var val_177;
        System.Func<System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>, PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_179;
        var val_180;
        var val_181;
        var val_182;
        System.Func<System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>, PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_184;
        val_135 = 七丒丄丙丙三东上丛;
        int val_2 = 丟丒丅丂丛丄丗万丌;
        int val_1 = 业七丅丟东丑专丅万;
        int val_3 = 丈三丌丁丈丒丅丌三;
        丛丐丌丐不丌丗三丕 = 0;
        PGCompany.丁东丌世与丕东丆上.丕丞专丘业三世一丘(一七东丑丘世丑丙不: ref  val_1, 丛丏丟万世丐丒丛丁: ref  val_2, 丈上下与丌丘丅丙丒: ref  val_3);
        this.丑七专东丘丐三下丒.Clear();
        val_137 = val_2;
        val_136 = val_1;
        val_138 = null;
        val_139 = val_3;
        val_139 = val_139;
        val_136 = val_136;
        val_138 = null;
        val_140 = 丆丈丑下丈丆业东一;
        val_141 = 丆世万七丆世丟丌业;
        val_142 = 业专丁丘丐丅万专与;
        if(GameController.mode == null)
        {
                val_139 = val_139;
            val_136 = val_136;
        }
        
        val_144 = 丄丗世丈丈丙不丐丂;
        val_143 = 丏丝且世丞丅与丆东;
        val_145 = 丄丅丟丟丛丟丟丟上;
        val_146 = 丁丑下丄东丙一丘且;
        if(this.丑七专东丘丐三下丒 == null)
        {
                val_139 = val_139;
            val_136 = val_136;
            val_144 = val_144;
            val_145 = val_145;
            val_140 = val_140;
            val_141 = val_141;
            val_142 = val_142;
            val_137 = val_137;
            val_143 = val_143;
            val_135 = val_135;
            val_146 = val_146;
        }
        
        this.丑七专东丘丐三下丒.三万不业七丘丄丂丞(一七东丑丘世丑丙不:  val_136, 丂丁丏丏万丛丈丐丆:  val_137, 丈上下与丌丘丅丙丒:  val_139, 丙七丝丂丏丌丞万一:  val_135, 丌丙专丗丏不丐丗丅:  丑丑上丑下丐下丌业, 不丁丛丈丙世丈万丟:  val_146, 上丛丕丙三丁专下丂:  val_142, 丕且七丅业丄丝丞东:  val_141, 业丒下业丛丆丂丗丕:  val_140, 下丅丌丌丆不东专丁:  val_145, 下丅丙一丂丗丅丝七:  0, 丄丐不丏丁丘不丒丈:  val_144, 上丁丗丐丝丛丝世丂:  val_143, 丞丙下万丗丝丄七丝:  GameController.mode.东丈丆下丂丛丒丟专);
        val_147 = this;
        this.丑七专东丘丐三下丒.丕丅世东业三丟丙业(丙业与丙丗丝不丈东:  业东丆丒丏丒丒专世);
        this.丑七专东丘丐三下丒.丛丛丂一丂三丆不丈(丙业与丙丗丝不丈东:  一下下丛七丈丅丂与);
        val_148 = 1152921505253011456;
        bool val_6 = this.丑七专东丘丐三下丒.丗丕东七三世一丗东(丗七丟丈三不丕一三:  new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  0, 丟业丈丈丞丂丞丑业:  1));
        mem[1152921531022379624] = (不丄丅一一一丏一丌 != true) ? 0 : (val_1);
        mem[1152921531022379628] = (不丄丅一一一丏一丌 != true) ? 0 : (val_2);
        val_149 = null;
        val_149 = null;
        val_150 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_150 == null)
        {
            goto label_13;
        }
        
        val_150 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_150 == null)
        {
                val_150 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_9 = val_150.丌不丅不丞东万专专();
        val_151 = 1152921525549506960;
        val_152 = 1152921525549507984;
        if((val_9.HasValue.丙东专丂世丈丏丁丂() != 3) || ((645716408 & 1) == 0))
        {
            goto label_18;
        }
        
        label_13:
        Rilisoft.丂丒三丙世丝三丏丞 val_132 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世();
        val_152 = 1152921505189646336;
        val_151 = GameConnect.丑丌丛丈丅丅与不业();
        val_132 = (val_132.东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  val_151)) & ((val_1 > 0) ? 1 : 0);
        var val_16 = (val_1 > 0) ? 1 : 0;
        val_16 = 与丂丏丛丞丞丒丟丄.世与专丕丛三万丘丟() & val_16;
        val_16 = val_132 & val_16;
        if(val_16 != true)
        {
                if(val_132 == false)
        {
            goto label_27;
        }
        
        }
        
        val_151 = Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丑丆丗丞丈不丘丞丝(丅丈专上丄丅丛丈业:  GameConnect.丑丌丛丈丅丅与不业());
        bool val_21 = this.丑七专东丘丐三下丒.丗丕东七三世一丗东(丗七丟丈三不丕一三:  new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  1, 丟业丈丈丞丂丞丑业:  val_151));
        label_27:
        val_153 = null;
        val_153 = null;
        if((GameController.丆丘丂丈世丏丟丑丏.丁七丗专业世丈丒下 != true) && (PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丝丞丙丂与上且丙丛() != false))
        {
                val_151 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207);
            PGCompany.七下丐丂丙丑东专丂 val_26 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  val_151, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(((val_26 != null) && (val_26.丂丁丏一丙丛业且丌() >= 1)) && (val_26.且业上丞丄丁专不丙() != null))
        {
                val_151 = val_26.且业上丞丄丁专不丙();
            if(val_151.Count != 0)
        {
                val_151 = this.丑七专东丘丐三下丒;
            bool val_33 = val_151.丗丕东七三世一丗东(丗七丟丈三不丕一三:  new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  6, 丈丄不七三万丄丁不:  val_26.且业上丞丄丁专不丙()));
        }
        
        }
        
        }
        
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
            goto label_54;
        }
        
        }
        
        val_154 = 0;
        goto label_55;
        label_18:
        val_155 = null;
        val_155 = null;
        val_156 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_156 != null)
        {
                val_156 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_156 == null)
        {
                val_156 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_36 = val_156.丌不丅不丞东万专专();
            val_157 = val_36.HasValue.丙东专丂世丈丏丁丂();
            if(val_157 == 4)
        {
                if((645716408 & 1) != 0)
        {
            goto label_194;
        }
        
        }
        
            val_155 = null;
        }
        
        val_155 = null;
        PGCompany.GameModeEvents.下与丛丒丙一世丟专 val_38 = new PGCompany.GameModeEvents.下与丛丒丙一世丟专(与不下三丈专丘丂世:  GameConnect.丈丝丂丐丟万丙丑丕);
        if(GameConnect.丈丝丂丐丟万丙丑丕.丘一丒丕丟万丏一丟() == false)
        {
            goto label_71;
        }
        
        val_158 = null;
        val_158 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕.三业丂丞丕东下七丒() == false)
        {
            goto label_71;
        }
        
        val_159 = 1;
        goto label_72;
        label_54:
        val_154 = GameConnect.世丐丄三三上丅七三() ^ 1;
        label_55:
        var val_44 = (val_1 < 1) ? 1 : 0;
        val_44 = val_44 | (~(Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()));
        val_44 = val_154 | val_44;
        if(val_44 != true)
        {
                丞丅与与丈丕丟丑丘 val_46 = null;
            val_151 = val_46;
            val_46 = new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  2, 丟业丈丈丞丂丞丑业:  Rilisoft.VIPController.专丌丞丌丕丕丞丅丆());
            bool val_47 = this.丑七专东丘丐三下丒.丗丕东七三世一丗东(丗七丟丈三不丕一三:  val_46);
        }
        
        val_160 = null;
        val_160 = null;
        val_157 = GameController.丆丘丂丈世丏丟丑丏;
        if((GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑 == false) || (((丑丑上丑下丐下丌业 < 1) || (GameConnect.与丂丝丟丟三丑丝万() == false)) || (val_146 == true)))
        {
            goto label_194;
        }
        
        val_157 = this.丑七专东丘丐三下丒;
        丞丅与与丈丕丟丑丘 val_49 = null;
        val_151 = val_49;
        val_49 = new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  4, 丟业丈丈丞丂丞丑业:  2);
        bool val_50 = val_157.丗丕东七三世一丗东(丗七丟丈三不丕一三:  val_49);
        goto label_194;
        label_71:
        val_161 = null;
        val_161 = null;
        val_159 = 丌三丒丌丆东万丆一 & (~GameConnect.丈丝丂丐丟万丙丑丕.丘一丒丕丟万丏一丟());
        label_72:
        上丑丝丌七不丙丗丅 val_53 = val_38.东丁上丈东与下丅丅(三丂丞丒一与且丈丆:  new 上丑丝丌七不丙丗丅() {<业丟东丟丑与丑丌七>k__BackingField = false, <丝业丄丒丙与与三且>k__BackingField = false, <丌七万丁丁丅丗丁且>k__BackingField = false}, 丟且丄专丌丁丆丅丛:  true, 丑丆世丟万丁丆上丛:  val_159);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                int val_58 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟业丅世丟丗丄丞万();
        }
        
        int val_59 = val_1 - 1152921531022367088;
        int val_61 = val_2 - 丆丒丘丐下丞丛上丈();
        int val_133 = 0;
        val_133 = 丑丑上丑下丐下丌业 - val_133;
        int val_62 = val_3 - 1152921531022367088;
        int val_134 = val_63;
        int val_135 = val_64;
        int val_136 = val_65;
        val_134 = val_142 - val_134;
        val_135 = val_141 - val_135;
        val_136 = val_140 - val_136;
        int val_68 = 丆丒丘丐下丞丛上丈();
        if(val_38 != null)
        {
                val_162 = val_133;
            val_163 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  1, 世东上丕专丞丑专丄:  (val_68 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
        }
        else
        {
                val_162 = val_133;
            val_163 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  1, 世东上丕专丞丑专丄:  (val_68 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
        }
        
        if(val_38 != null)
        {
                val_164 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  3, 世东上丕专丞丑专丄:  ( > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
            val_165 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  6, 世东上丕专丞丑专丄:  (val_134 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
            val_166 = val_136;
            val_167 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  18, 世东上丕专丞丑专丄:  (val_135 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
        }
        else
        {
                val_164 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  3, 世东上丕专丞丑专丄:  ( > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
            val_165 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  6, 世东上丕专丞丑专丄:  (val_134 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
            val_166 = val_136;
            val_167 = val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  18, 世东上丕专丞丑专丄:  (val_135 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159);
        }
        
        int val_89 = (645716264 > 0) ? val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  2, 世东上丕专丞丑专丄:  ( > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159) : (0 + 1);
        int val_91 = (丆丒丘丐下丞丛上丈() > 0) ? (val_163) : (0 + 1);
        val_159 = (val_133 > 0) ? val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  5, 世东上丕专丞丑专丄:  (val_162 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159) : (0 + 1);
        int val_92 = (645716264 > 0) ? (val_164) : (0 + 1);
        int val_93 = (val_134 > 0) ? (val_165) : (0 + 1);
        int val_94 = (val_135 > 0) ? (val_167) : (0 + 1);
        int val_95 = (val_136 > 0) ? val_38.丆丑丞丁下丄丑上丕(丁丅丈丌丟世丗丗丟:  20, 世东上丕专丞丑专丄:  (val_166 > 0) ? 1 : 0, 专丂丑且丙七丈万丑:  val_159) : (0 + 1);
        if(((((((val_159 <= 1) && (val_89 <= 1)) && (val_91 <= 1)) && (val_92 <= 1)) && (val_93 <= 1)) && (val_94 <= 1)) && (val_95 <= 1))
        {
                if(645716336 <= 0)
        {
            goto label_112;
        }
        
        }
        
        label_192:
        丛丐丌丐不丌丗三丕 = val_96;
        label_193:
        丞丅与与丈丕丟丑丘 val_97 = new 丞丅与与丈丕丟丑丘(丟丛丑丒丆丛东下丌:  5, 不上三丌下丏与与丒:  val_159, 丙丁丆且东丝专丘丐:  val_89, 下业丅专专丗与丑丙:  val_91, 丝丌丝上业万丘丑三:  val_92, 丅且万丆下丗不世丐:  val_93, 三丟一东世万三丙丑:  val_94, 丗东丗丞丑丁丆丟丘:  val_95, 一丂丛丗世上丐丐丄:  val_92, 丄丐不丏丁丘不丒丈:  1, 丅丈丑丒丞万丞丏一:  1);
        val_97.丌丘七丞丒丝业下丘(丙业与丙丗丝不丈东:  645716336);
        int val_98 = 丆丒丘丐下丞丛上丈();
        if(val_97 != null)
        {
                val_97.丏丄丟丟三万三丅丑(丙业与丙丗丝不丈东:  val_98);
            val_168 = 0;
        }
        else
        {
                val_97.丏丄丟丟三万三丅丑(丙业与丙丗丝不丈东:  val_98);
            val_168 = 0;
        }
        
        val_97.一丝丁丕一丘专不三(丙业与丙丗丝不丈东:  0);
        if(val_97 != null)
        {
                val_97.上丆丕不七与世丟丝(丙业与丙丗丝不丈东:  645716336);
            val_97.丏丙丒万丘丟业与丄(丙业与丙丗丝不丈东:  val_63);
            val_97.与七丕丐万东丟丌丂(丙业与丙丗丝不丈东:  val_64);
            val_97.丄丌丁丑丂丗七丁丆(丙业与丙丗丝不丈东:  val_65);
            val_97.丕丅世东业三丟丙业(丙业与丙丗丝不丈东:  val_99);
            val_169 = val_100;
        }
        else
        {
                val_97.上丆丕不七与世丟丝(丙业与丙丗丝不丈东:  645716336);
            val_97.丏丙丒万丘丟业与丄(丙业与丙丗丝不丈东:  val_63);
            val_97.与七丕丐万东丟丌丂(丙业与丙丗丝不丈东:  val_64);
            val_97.丄丌丁丑丂丗七丁丆(丙业与丙丗丝不丈东:  val_65);
            val_97.丕丅世东业三丟丙业(丙业与丙丗丝不丈东:  val_99);
            val_169 = val_100;
        }
        
        val_97.丛丛丂一丂三丆不丈(丙业与丙丗丝不丈东:  val_169);
        bool val_101 = this.丑七专东丘丐三下丒.丗丕东七三世一丗东(丗七丟丈三不丕一三:  val_97);
        val_148;
        val_170 = null;
        val_142 = val_134;
        val_152 = val_136;
        val_170 = null;
        val_171 = val_144;
        if(GameController.mode == null)
        {
                val_171 = val_144;
        }
        
        if(this.丑七专东丘丐三下丒 == null)
        {
                val_171 = val_144;
        }
        
        this.丑七专东丘丐三下丒.三万不业七丘丄丂丞(一七东丑丘世丑丙不:  645716264, 丂丁丏丏万丛丈丐丆:  丆丒丘丐下丞丛上丈(), 丈上下与丌丘丅丙丒:  645716264, 丙七丝丂丏丌丞万一:  645716264, 丌丙专丗丏不丐丗丅:  val_133, 不丁丛丈丙世丈万丟:  val_146, 上丛丕丙三丁专下丂:  val_142, 丕且七丅业丄丝丞东:  val_135, 业丒下业丛丆丂丗丕:  val_152, 下丅丌丌丆不东专丁:  val_145, 下丅丙一丂丗丅丝七:  val_96, 丄丐不丏丁丘不丒丈:  val_171, 上丁丗丐丝丛丝世丂:  val_143, 丞丙下万丗丝丄七丝:  GameController.mode.东丈丆下丂丛丒丟专);
        val_147 = this;
        this.丑七专东丘丐三下丒.丕丅世东业三丟丙业(丙业与丙丗丝不丈东:  val_97.丄丁丝七不丂且丏丛());
        this.丑七专东丘丐三下丒.丛丛丂一丂三丆不丈(丙业与丙丗丝不丈东:  val_97.丗丏一丑丑丟与丝专());
        this.丑七专东丘丐三下丒.丙与丟丁七业丙东丌(丙业与丙丗丝不丈东:  val_97.丟丈东丒丆丘一丒丗());
        this.丑七专东丘丐三下丒.丘丆丘丘丏专东丗与(丙业与丙丗丝不丈东:  val_97.专一且丈丁下与丙丗());
        this.丑七专东丘丐三下丒.万三东与丁且且丑丌(丙业与丙丗丝不丈东:  val_97.且丈万丄丅东不业与());
        this.丑七专东丘丐三下丒.丟七一丟与七丆不三(丙业与丙丗丝不丈东:  val_97.丏丑下丂不一三且丟());
        this.丑七专东丘丐三下丒.七丌丗不丄丛丟丞丁(丙业与丙丗丝不丈东:  val_97.丐丂丐丕丒丛七万丐());
        this.丑七专东丘丐三下丒.丌上丏丐丘东丗丛丙(丙业与丙丗丝不丈东:  val_97.七万三东东一丁世丘());
        this.丑七专东丘丐三下丒.业丏丈丞丐丈丌万丘(丙业与丙丗丝不丈东:  val_97.下丛业不上丒一丅丄());
        this.丑七专东丘丐三下丒.丒丁上万丏世丈丝丈(丙业与丙丗丝不丈东:  val_97.与丗世七三丝业丏丏());
        this.丑七专东丘丐三下丒.业丌万且丐丅丏三丗(丙业与丙丗丝不丈东:  val_97.下七东业丒丞不专丈());
        if(val_96 != 0)
        {
            goto label_145;
        }
        
        val_172 = null;
        val_172 = null;
        val_152 = 1152921505086611456;
        val_173 = null;
        val_173 = null;
        val_175 = NetworkStartTableNGUIController.<>c.<>9__309_0;
        if(val_175 == null)
        {
                System.Func<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗, System.Boolean> val_116 = null;
            val_175 = val_116;
            val_116 = new System.Func<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗, System.Boolean>(object:  NetworkStartTableNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NetworkStartTableNGUIController.<>c::丕丛丒丘且丆丂专丂(PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗 三丟东丕丄丄下下丑));
            NetworkStartTableNGUIController.<>c.<>9__309_0 = val_175;
        }
        
        PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗 val_117 = System.Linq.Enumerable.FirstOrDefault<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗>(source:  GameConnect.丈丝丂丐丟万丙丑丕.丙丐丗丏与丛丌丐丂(), predicate:  val_116);
        if((val_117 != null) && ((PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丕且一三丅上万丑三(丂三丗丑丕丛丝业丌:  val_117.业上丙丞丐丄丆丅七(), 丟丟丄专上丟丁丐丝:  val_117.丅东丄丛上丁丐万丏(), 不与丝且下万专且不:  false)) != true))
        {
                val_176 = null;
            val_176 = null;
            val_177 = null;
            val_177 = null;
            val_179 = NetworkStartTableNGUIController.<>c.<>9__309_1;
            if(val_179 == null)
        {
                System.Func<System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>, PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_123 = null;
            val_179 = val_123;
            val_123 = new System.Func<System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>, PGCompany.GameModeEvents.丝一七万丗不丄丒上>(object:  NetworkStartTableNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.GameModeEvents.丝一七万丗不丄丒上 NetworkStartTableNGUIController.<>c::三丌丁丟丒丗与丂丆(System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上> 三丟东丕丄丄下下丑));
            NetworkStartTableNGUIController.<>c.<>9__309_1 = val_179;
        }
        
            PGCompany.GameModeEvents.丝一七万丗不丄丒上 val_124 = 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<PGCompany.GameModeEvents.丝一七万丗不丄丒上, System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>>(丞下万上三丘上与专:  GameConnect.丈丝丂丐丟万丙丑丕.且与业丞丞业丐丄丗(), 丏丅丁丛一业丈专专:  val_123);
            if(val_124 != null)
        {
                if(val_124.丑丑丏丁丗丏丘七一() == 0)
        {
            goto label_196;
        }
        
        }
        
        }
        
        if(val_96 == 0)
        {
            goto label_169;
        }
        
        label_145:
        val_151 = 1;
        label_196:
        val_180 = null;
        val_180 = null;
        val_157 = GameConnect.丈丝丂丐丟万丙丑丕.业上丙丞丐丄丆丅七();
        Rilisoft.一丟专且三万丞丁丂.丛丂丂下丕丞丝下且(专丏不丏东丏丈丆上:  1, 丟丟丄专上丟丁丐丝:  val_157);
        label_194:
        this.丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  丕东丈丒与丟丅丞丁);
        return;
        label_169:
        val_181 = null;
        val_181 = null;
        val_182 = null;
        System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_137 = GameConnect.丈丝丂丐丟万丙丑丕.且与业丞丞业丐丄丗();
        val_182 = null;
        val_184 = NetworkStartTableNGUIController.<>c.<>9__309_2;
        if(val_184 == null)
        {
                System.Func<System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>, PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_128 = null;
            val_184 = val_128;
            val_128 = new System.Func<System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>, PGCompany.GameModeEvents.丝一七万丗不丄丒上>(object:  NetworkStartTableNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.GameModeEvents.丝一七万丗不丄丒上 NetworkStartTableNGUIController.<>c::丛丐万丂万丐业东丄(System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上> 三丟东丕丄丄下下丑));
            NetworkStartTableNGUIController.<>c.<>9__309_2 = val_184;
        }
        
        PGCompany.GameModeEvents.丝一七万丗不丄丒上 val_129 = 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<PGCompany.GameModeEvents.丝一七万丗不丄丒上, System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上>>(丞下万上三丘上与专:  val_137, 丏丅丁丛一业丈专专:  val_128);
        if(val_129 == null)
        {
            goto label_196;
        }
        
        int val_130 = val_129.丑丑丏丁丗丏丘七一();
        val_137 = (val_130 == 2) ? (val_130) : (!0);
        goto label_196;
        label_112:
        if((((((丆丒丘丐下丞丛上丈() > 0) || (0 > 0)) || (645716336 > 0)) || (val_63 > 0)) || (val_64 > 0)) || (val_65 >= 1))
        {
            goto label_192;
        }
        
        丛丐丌丐不丌丗三丕 = val_96;
        if(val_96 != 0)
        {
            goto label_193;
        }
        
        goto label_194;
    }
    private void 丘丘丆下丞丟与一与(丞丅与与丈丕丟丑丘 丒丙业丕万丒丞万丂)
    {
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丝丗丌上丐丑业一业();
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丏丏丟上丙万一丌东(丆三与下丅一不丘世:  this.丑七专东丘丐三下丒.专不三丙丅丞丄不丑(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丘业丏丁万上不丐丙(丟且丗丆丁丐丅丏丆:  this.丑七专东丘丐三下丒.丐丞丕丞丟下丑下丒(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().业七业丄业丟丄下一(丝世三世不丏上七丞:  this.丑七专东丘丐三下丒.且丞上丁万不专下专(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().七丂万且一上专丒丁(丝世三世不丏上七丞:  this.丑七专东丘丐三下丒.丝东丗丏丗丁丕丈丝());
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丞与万丌丏下不与丞(丌丁且丕丞一一与七:  this.丑七专东丘丐三下丒.丐万丐丌丛上丘丞丂(), 丛丕不丞与丕万世丆:  this.丑七专东丘丐三下丒.丈丂丟丒万下上下业(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丟东丅与三一不万丝(丛丅下世丑丈丐与一:  this.丑七专东丘丐三下丒.丅下丐丕丂丞丝丑丝(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丏丘七与上丅丗丆丙(与上丌丞丙丙丂丈丌:  this.丑七专东丘丐三下丒.丛与丆丏与丛丈世上(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丏丏丁且专丛丅丗丂(且专不下丒万东丟丏:  this.丑七专东丘丐三下丒.丏下七丐且且丙万丕(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().业丙丈丞一下万丗丐(丂且且丟丟东丕一丑:  this.丑七专东丘丐三下丒.丕东与丞丈丕丟上丈(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丟丁丄世丈丄一万丏(下丅丙一丂丗丅丝七:  this.丑七专东丘丐三下丒.丗丈丝且一三七不丐(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().丒丏丕丘丗丘丕业丂(一丘业丄三七世万丞:  this.丑七专东丘丐三下丒.丘三丘上丙丌丞丂丏(), 丒丙业丕万丒丞万丂:  丒丙业丕万丒丞万丂, 丙万丟上丞丒丞万丗:  true);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.丑七专东丘丐三下丒.业一上七一丄丒东丅());
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().且丕丅丕丕业丞不东(不东丂上且与万丙丕:  this.丑七专东丘丐三下丒.丄丁丝七不丂且丏丛());
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().与业丈丝三丁丝东丐(丈丄不七三万丄丁不:  this.丑七专东丘丐三下丒.丗丏一丑丑丟与丝专());
        RewardWindowView val_32 = this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七();
        if(this.丑七专东丘丐三下丒.下丙丅丑专丝三丗丞() == null)
        {
            goto label_47;
        }
        
        丁丁丒丆不丒下丟三 val_34 = this.丑七专东丘丐三下丒.下丙丅丑专丝三丗丞();
        if(val_32 != null)
        {
            goto label_53;
        }
        
        label_54:
        label_53:
        val_32.丈丗丟丛丕上三世丙(丄下丘丘丗丙丙丕丞:  val_34.丕丈一丐丛世丆上万);
        this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().Resize();
        return;
        label_47:
        if(val_32 != null)
        {
            goto label_53;
        }
        
        goto label_54;
    }
    private void 三东且三丈与丂丐丄(bool 下丁丞丝丛一丘丐丒)
    {
        if((((下丁丞丝丛一丘丐丒 != false) && (GameConnect.业丛丛丂一丆丕丗丟() != true)) && (GameConnect.一与东丝万上三丆丏() != true)) && (GameConnect.与丂丝丟丟三丑丝万() != true))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 18)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 26)
        {
            goto label_16;
        }
        
        }
        
        }
        
        if(this.allInterfacePanel != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        this.allInterfacePanel.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  下丁丞丝丛一丘丐丒);
        return;
        label_16:
        var val_8 = (GameConnect.丑丌丛丈丅丅与不业() != 27) ? 1 : 0;
        if(this.allInterfacePanel != null)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    internal void 丂世丈丅丟且丆丑丝(int 丕东丈丒与丟丅丞丁)
    {
        var val_60;
        var val_61;
        System.Action<UILabel> val_62;
        UnityEngine.GameObject val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_71;
        val_60 = null;
        val_60 = null;
        NotificationController.丄丘七三上丕世丞业.SaveTimeValues();
        val_61 = null;
        val_61 = null;
        丒丞与一丙且三丆丝();
        this.startInterfacePanel.SetActive(value:  GameConnect.东且三丆丑世世丘丟());
        this.endInterfacePanel.SetActive(value:  (~GameConnect.东且三丆丑世世丘丟()) & 1);
        this.goBattleLabel.SetActive(value:  (~GameConnect.东且三丆丑世世丘丟()) & 1);
        this.daterButtonLabel.SetActive(value:  GameConnect.东且三丆丑世世丘丟());
        if((this.ReadyTimerContainer != 0) && (this.ReadyTimerContainer != null))
        {
                this.ReadyTimerContainer.SetActive(value:  false);
        }
        
        new NetworkStartTableNGUIController.不丈业七丙下丘丅且() = new NetworkStartTableNGUIController.不丈业七丙下丘丅且();
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                if(GameConnect.与丈丘丈上丌丝丝丛() != true)
        {
                if(GameConnect.世丐丄三三上丅七三() == false)
        {
            goto label_26;
        }
        
        }
        
        }
        
        val_62 = 0;
        if(new NetworkStartTableNGUIController.不丈业七丙下丘丅且() != null)
        {
            goto label_157;
        }
        
        label_158:
        label_157:
        .专业丛丛丄丟不丛与 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.miniGamesNextMatchPriceContainer, 丏业丟一东丂东丘丛:  val_62 & ((0 > 0) ? 1 : 0));
        if(this.miniGamesNextMatchPriceContainer.activeSelf != false)
        {
                val_62 = null;
            val_62 = new System.Action<UILabel>(object:  new NetworkStartTableNGUIController.不丈业七丙下丘丅且(), method:  System.Void NetworkStartTableNGUIController.不丈业七丙下丘丅且::丈丁三丝与丛丛且上(UILabel 丛丞丑丞丐丗上丂上));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.miniGamesNextMatchPriceLabels, 七丐丅专且专七三丆:  null);
        }
        
        val_63 = this.backButtonInHunger;
        if(GameConnect.不专专丂万丝上东丐() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_42;
        }
        
        }
        
        }
        
        if(val_63 != null)
        {
            goto label_150;
        }
        
        label_151:
        label_150:
        val_63.SetActive(value:  true);
        if(GameConnect.丆丁上丟丛业丄丅丝() != true)
        {
                if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_49;
        }
        
        }
        
        val_63 = this.ranksTable;
        val_63.三上丗业丑三丗一丌(丛丅丘一丏丙且丌上:  true, 丗三上丞丆七不且七:  丕东丈丒与丟丅丞丁);
        label_49:
        if(GameConnect.业丛丛丂一丆丕丗丟() == true)
        {
                return;
        }
        
        if(GameConnect.一与东丝万上三丆丏() == true)
        {
                return;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == true)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                SetActive(value:  false);
        }
        
        val_63 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
        this.socialPnl.SetActive(value:  (val_63 != 19) ? 1 : 0);
        this.三东且三丈与丂丐丄(下丁丞丝丛一丘丐丒:  true);
        this.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  false);
        val_64 = null;
        val_64 = null;
        if(null != 0)
        {
                val_65 = null;
            val_65 = null;
            if(!=0)
        {
                this.ranksTable.丟丛万丗丙丁且不不();
        }
        
        }
        
        val_66 = null;
        val_66 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
        {
                if(this.CompetitionContinueButton != 0)
        {
                this.CompetitionContinueButton.gameObject.SetActive(value:  false);
            System.EventHandler val_31 = null;
            val_63 = val_31;
            val_31 = new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::与下丘万丌丆万丟丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.CompetitionContinueButton.add_Clicked(丙业与丙丗丝不丈东:  val_31);
        }
        
        }
        
        if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true)) && (GameConnect.不专专丂万丝上东丐() != true))
        {
                val_67 = null;
            val_67 = null;
            if(与丂丏丛丞丞丒丟丄.与丈丝丌东丄丏丞丙 != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_100;
        }
        
        }
        
        }
        
        if(GameConnect.不专专丂万丝上东丐() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_106;
        }
        
        }
        
        val_68 = null;
        val_68 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_116;
        }
        
        }
        
        }
        
        val_63 = 0;
        label_162:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.randomBtn, 丏业丟一东丂东丘丛:  (val_63 != 0) ? 1 : 0);
        label_106:
        if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true)) && (GameConnect.世丐丄三三上丅七三() != true))
        {
                if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_133;
        }
        
        }
        
        }
        
        val_69 = null;
        val_69 = null;
        val_63 = 丞下丗丞一业丏上不();
        this.spectatorModeBtnPnl.SetActive(value:  val_63);
        label_133:
        this.丁丘丟万丙万且丆专 = true;
        if(this.ActionPanel.activeSelf != true)
        {
                if(this.ReasonsPanel.activeSelf != true)
        {
                this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  true);
        }
        
        }
        
        label_163:
        var val_61 = 0;
        val_61 = val_61 + 1;
        goto label_147;
        label_42:
        bool val_52 = GameConnect.一业上七丟业且业丙();
        if(val_63 != null)
        {
            goto label_150;
        }
        
        goto label_151;
        label_26:
        丌丑丕丏丝丆上东丄 val_54 = BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  GameConnect.丑丌丛丈丅丅与不业());
        if(new NetworkStartTableNGUIController.不丈业七丙下丘丅且() != null)
        {
            goto label_157;
        }
        
        goto label_158;
        label_147:
        this.专东丝丈丕丞与万不 = this.StartCoroutine(routine:  this.TryToShowExpiredBanner().GetEnumerator());
        return;
        label_116:
        val_71 = null;
        val_71 = null;
        bool val_62 = GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七;
        val_62 = val_62 ^ 1;
        bool val_58 = val_62 & 255;
        goto label_162;
        label_100:
        this.丁丘丟万丙万且丆专 = false;
        this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  false);
        this.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  false, 丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        goto label_163;
    }
    private bool 丆丈丟丘丏丛丕业丅()
    {
        RewardWindowController val_17;
        Rilisoft.七丕丟丏三丈一丄世 val_18;
        var val_19;
        var val_20;
        var val_21;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_22;
        var val_23;
        val_17 = this;
        val_18 = GameConnect.丑丌丛丈丅丅与不业();
        if(((Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  val_18)) == true) || (Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世() == 0))
        {
            goto label_17;
        }
        
        val_18 = GameConnect.丑丌丛丈丅丅与不业();
        val_19 = null;
        val_19 = null;
        if((Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().丗丒丅丛丒丏丟不丘(上且丗一丏丏万丅丌:  val_18, 丏世丈七一丟东丂丅:  typeof(NetworkStartTable).__il2cppRuntimeField_168)) == false)
        {
            goto label_17;
        }
        
        val_17 = this.丑七专东丘丐三下丒;
        var val_10 = (val_17.万万下东上丏且丅七() > 0) ? 1 : 0;
        goto label_19;
        label_17:
        val_20 = 0;
        label_19:
        val_21 = null;
        val_21 = null;
        val_22 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_22 != null)
        {
                val_22 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_22 == null)
        {
                val_22 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_11 = val_22.丌不丅不丞东万专专();
            val_17 = val_11.HasValue.丙东专丂世丈丏丁丂();
            val_23 = ((val_17 != 4) ? 1 : 0) | 1152921531023877481;
            return (bool)((val_20 != 0) ? 1 : 0) & val_23;
        }
        
        val_23 = 1;
        return (bool)((val_20 != 0) ? 1 : 0) & val_23;
    }
    private bool 丁与不万上业丁丏业()
    {
        var val_5;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = this;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_41;
        }
        
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_41;
        }
        
        val_13 = null;
        val_13 = null;
        List.Enumerator<T> val_3 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_30:
        if((647367344 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((GameConnect.万不丒丌丙万丗东不() == false) || (val_6 == 0))
        {
            goto label_30;
        }
        
        val_14 = null;
        val_14 = null;
        if((((val_6 & 1) != 0) || (null != null)) || (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0))
        {
            goto label_30;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丆丄上丛丝东丅专东();
        val_15 = 1;
        return (bool)val_15;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_41:
        val_15 = 0;
        return (bool)val_15;
    }
    private FacebookController.上丘丟丂万东丟下丂 丝丝三丗丟丑丅丝丝()
    {
        return (上丘丟丂万东丟下丂)this.世丂丑世丏丐丗下丞;
    }
    private void 丝丈丆丏丒丛且丗业(FacebookController.上丘丟丂万东丟下丂 丙业与丙丗丝不丈东)
    {
        this.世丂丑世丏丐丗下丞 = 丙业与丙丗丝不丈东;
    }
    private FacebookController.上丘丟丂万东丟下丂 丛丒专丗丒世丛丙丒()
    {
        return (上丘丟丂万东丟下丂)this.与丂与丗与丁专丏丄;
    }
    private void 七三丆丅下上丙丕丐(FacebookController.上丘丟丂万东丟下丂 丙业与丙丗丝不丈东)
    {
        this.与丂与丗与丁专丏丄 = 丙业与丙丗丝不丈东;
    }
    private void 丐丌七业下丂丗丅丆(FacebookController.上丘丟丂万东丟下丂 丙业与丙丗丝不丈东)
    {
        this.世丂丑世丏丐丗下丞 = 丙业与丙丗丝不丈东;
        this.与丂与丗与丁专丏丄 = 丙业与丙丗丝不丈东;
    }
    private string 丆丈不丛丈丅且丝世()
    {
        return (string)this.<丝且万丁丐丄丌丕与>k__BackingField;
    }
    private void 丐丘丗下丙万且与业(string 丙业与丙丗丝不丈东)
    {
        this.<丝且万丁丐丄丌丕与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private System.Func<string> 丌丈下三丐丑丄丂丛()
    {
        return (System.Func<System.String>)this.<下丁业丁丄东且与三>k__BackingField;
    }
    private void 一丆丅一丄丒七下丑(System.Func<string> 丙业与丙丗丝不丈东)
    {
        this.<下丁业丁丄东且与三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 丂丗丐三下七丞丈丂()
    {
        var val_7;
        System.Func<System.String> val_9;
        上丘丟丂万东丟下丂 val_10;
        var val_11;
        var val_12;
        this.世丂丑世丏丐丗下丞 = 3;
        val_7 = null;
        val_7 = null;
        val_9 = NetworkStartTableNGUIController.<>c.<>9__337_0;
        if(val_9 == null)
        {
                System.Func<System.String> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Func<System.String>(object:  NetworkStartTableNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String NetworkStartTableNGUIController.<>c::丕丟丄丙一丐且一丅());
            NetworkStartTableNGUIController.<>c.<>9__337_0 = val_9;
        }
        
        this.<下丁业丁丄东且与三>k__BackingField = val_9;
        this.<丝且万丁丐丄丌丕与>k__BackingField = "Won Batlle";
        if(TwitterController.上业丗丛三丕丒丗丙() == false)
        {
                return;
        }
        
        if(TwitterController.丒丆世一与丁丛丐下() == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = this.与丂与丗与丁专丏丄;
        if((TwitterController.丗丘丒丈专丘丕世与.不专下丒丌丒三丂丄(与丈丂一丌三丈丟丅:  val_10)) == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        TwitterController.丗丘丒丈专丘丕世与.丑与东丒七丁丝三丁(丝丝不丝上丂三丌世:  this.<下丁业丁丄东且与三>k__BackingField.Invoke(), 与丈丂一丌三丈丟丅:  this.与丂与丗与丁专丏丄);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_6 != null)
        {
                val_6.Add(key:  "Post Twitter", value:  this.<丝且万丁丐丄丌丕与>k__BackingField);
        }
        else
        {
                val_6.Add(key:  "Post Twitter", value:  this.<丝且万丁丐丄丌丕与>k__BackingField);
        }
        
        val_6.Add(key:  "Total Twitter", value:  "Posts");
        Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Virality", 丛东不丒丏丈丄且丕:  val_6);
    }
    public void OnTablesShown()
    {
        bool val_28;
        var val_29;
        bool val_30;
        UnityEngine.GameObject val_31;
        bool val_1 = GameConnect.东且三丆丑世世丘丟();
        if(val_1 == false)
        {
            goto label_3;
        }
        
        this.三与丁丞丂丗丅丆丁(丝三丄专丗丞丄丄丌:  true, 下丈下七一万丆丁丕:  0);
        goto label_4;
        label_3:
        if((((((val_1.一丈丛丘与丕丛丝东() != false) && (this.丛丏丒一丗丝丌不丅 <= 0)) && (this.下丕丌丈丙与与丏丟 <= 0)) && (this.丈七丈丞专七丟专丛 <= 0)) && (this.七上世丌丘丕万丅东 <= 0)) && (this.丕专丐上东丑丑下丘 <= 0))
        {
                if(this.丂三丅丘丆丂丛七丌 < 1)
        {
            goto label_11;
        }
        
        }
        
        if(this.专丆三七世下丌七东 != null)
        {
                this.StopCoroutine(routine:  this.专丆三七世下丌七东);
            this.专丆三七世下丌七东 = 0;
        }
        
        if(PGCompany.丁东丌世与丕东丆上.东丙不丛世丅丂丐世() != true)
        {
                var val_26 = 0;
            val_26 = val_26 + 1;
            this.专丆三七世下丌七东 = this.StartCoroutine(routine:  this.丟业一丑万丁丄下丕(丕丕世且下一与丝与:  60f).GetEnumerator());
        }
        
        this.下丄三丒丟丄丂丑世 = true;
        if(this.上丏丙东丁不丕丁丟 == true)
        {
            goto label_21;
        }
        
        if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_27;
        }
        
        }
        
        val_28 = 0;
        goto label_28;
        label_27:
        val_28 = (~GameConnect.与丂丝丟丟三丑丝万()) & 1;
        label_28:
        this.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  val_28);
        label_21:
        if((GameConnect.一业上七丟业且业丙() != true) && (GameConnect.不专专丂万丝上东丐() != true))
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_42;
        }
        
        }
        
        }
        
        this.backButtonInHunger.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.randomBtn, 丏业丟一东丂东丘丛:  false);
        this.randomBtn.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  false, 丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        this.spectatorModeBtnPnl.SetActive(value:  false);
        label_42:
        val_29 = null;
        val_29 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 != false)
        {
                if(this.CompetitionContinueButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.CompetitionContinueButton.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        label_74:
        this.丌三上丁丞丆丛丑下();
        label_4:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        if(this.三丑丑丈万丛丗与下 != false)
        {
                return;
        }
        
        bool val_19 = this.丁与不万上业丁丏业();
        return;
        label_11:
        this.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  false);
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_30 = 0;
        }
        else
        {
                bool val_21 = GameConnect.与丂丝丟丟三丑丝万();
            val_30 = val_21 ^ 1;
        }
        
        val_21.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  val_30, 丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        this.三与丁丞丂丗丅丆丁(丝三丄专丗丞丄丄丌:  true, 下丈下七一万丆丁丕:  0);
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_74;
        }
        
        this.backButtonInHunger.SetActive(value:  false);
        val_31 = this.randomBtn;
        val_31 = val_31;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  false);
        val_31.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  false, 丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        this.spectatorModeBtnPnl.SetActive(value:  false);
        goto label_74;
    }
    private void 丌七三丞业丄丂丁丌()
    {
        if(this.专丆三七世下丌七东 != null)
        {
                this.StopCoroutine(routine:  this.专丆三七世下丌七东);
            this.专丆三七世下丌七东 = 0;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.专丆三七世下丌七东 = this.StartCoroutine(routine:  this.丟业一丑万丁丄下丕(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    private System.Collections.IEnumerable 丟业一丑万丁丄下丕(float 丕丕世且下一与丝与)
    {
        NetworkStartTableNGUIController.业下世丟丌专丐丐上 val_1 = new NetworkStartTableNGUIController.业下世丟丌专丐丐上(丗丏丅丕丆世丁专丟:  -2);
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
    private void 丟业丁丐丟七丒丘业(bool 丑丒业丘丑东丕世丅)
    {
        UILabel val_24;
        UnityEngine.GameObject val_25;
        UnityEngine.GameObject val_26;
        val_25 = this;
        if(丑丒业丘丑东丕世丅 == false)
        {
            goto label_1;
        }
        
        if(this.丆丈丟丘丏丛丕业丅() == false)
        {
            goto label_2;
        }
        
        this.丑丛丒万世世丏业与 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OkWithAds, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OkNoAdsButton, 丏业丟一东丂东丘丛:  false);
        if(this.X2TimesLeftLabel != 0)
        {
                val_24 = this.X2TimesLeftLabel;
            val_24.text = System.String.Format(provider:  NetworkStartTableNGUIController.丙专丝世不业下丂丈(), format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8889"), arg0:  Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().丅世丁七世丂丅专丑().ToString(provider:  NetworkStartTableNGUIController.丙专丝世不业下丂丈()));
        }
        
        int val_11 = Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().世丁上丅且丂丄丁丑();
        if(this.x3BonusButtonLabel != 0)
        {
                val_24 = this.x3BonusButtonLabel;
            val_24.text = System.String.Format(provider:  NetworkStartTableNGUIController.丙专丝世不业下丂丈(), format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8890"), arg0:  val_11.ToString(provider:  NetworkStartTableNGUIController.丙专丝世不业下丂丈()));
        }
        
        val_25 = this.GetComponentInChildren<PGCompany.SpriteSelector>();
        if(val_25 == null)
        {
                return;
        }
        
        val_24 = val_11;
        val_25.丄丄且丞丒丒丘丙丁(丏丙东下丌三丑与丕:  System.Convert.ToInt32(value:  (val_24 != 2) ? 1 : 0));
        val_25 = val_25.GetComponent<PGCompany.LabelColorSelector>();
        if(val_25 == null)
        {
                return;
        }
        
        val_25.三丑东上三不丑七业(与不丘丗东丆世丌丛:  System.Convert.ToInt32(value:  (val_11 != 2) ? 1 : 0));
        return;
        label_1:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OkWithAds, 丏业丟一东丂东丘丛:  false);
        val_26 = this.OkNoAdsButton;
        goto label_28;
        label_2:
        this.丑丛丒万世世丏业与 = -2;
        this.丒一不丅丌业丁三丕();
        val_25 = this.OkWithAds;
        val_26 = val_25;
        label_28:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_26, 丏业丟一东丂东丘丛:  false);
    }
    public void HandleShowAds()
    {
        Rilisoft.七丕丟丏三丈一丄世 val_41;
        object val_42;
        if(Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世() == 0)
        {
            goto label_3;
        }
        
        val_41 = GameConnect.丑丌丛丈丅丅与不业();
        if((Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  val_41)) == false)
        {
            goto label_9;
        }
        
        val_42 = "[New X2] Don\'t show ADS";
        goto label_12;
        label_3:
        val_42 = "[New X2] Not found BonuseForFirstWinVideoController";
        label_12:
        UnityEngine.Debug.LogError(message:  val_42);
        return;
        label_9:
        if(Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().丄丛丅丐世丌丕且丛() == false)
        {
                return;
        }
        
        if(Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo, 丏业丟一东丂东丘丛:  true);
        }
        
        this.丑丛丒万世世丏业与 = 0;
        System.Action val_14 = null;
        val_41 = val_14;
        val_14 = new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::丄丄一丑丐业丈丅丄());
        if((Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().三丙丆丕丗专丐丆丗(业丏丈世世世丞丒世:  val_14)) == false)
        {
                return;
        }
        
        NetworkStartTableNGUIController.丁丞丆七上且丏丞丘 val_16 = new NetworkStartTableNGUIController.丁丞丆七上且丏丞丘();
        if(val_16 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丅丏丅丂丝一丆丙丅 = 0;
        mem[1152921531026423192] = 0;
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.remove_EnterWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_16, method:  System.Void NetworkStartTableNGUIController.丁丞丆七上且丏丞丘::丅七丝世丆专丕丙丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.remove_ExitWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丂且丏丁丛丘世丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.remove_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_16, method:  System.Void NetworkStartTableNGUIController.丁丞丆七上且丏丞丘::与七丐丅丏下丁丌业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.remove_DiscardWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::专丄丆不万丘七丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.add_EnterWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_16, method:  System.Void NetworkStartTableNGUIController.丁丞丆七上且丏丞丘::丅七丝世丆专丕丙丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.add_ExitWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丂且丏丁丛丘世丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.add_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_16, method:  System.Void NetworkStartTableNGUIController.丁丞丆七上且丏丞丘::与七丐丅丏下丁丌业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.add_DiscardWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::专丄丆不万丘七丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public void HandleHideOldRanksClick()
    {
        if(this.下丄三丒丟丄丂丑世 == false)
        {
                return;
        }
        
        if(this.丌一丏丘丞东与上世 != false)
        {
                return;
        }
        
        if(this.丟下下丞七丅丈东丙().value != false)
        {
                if((this.丛丏丒一丗丝丌不丅 <= 0) && (this.下丕丌丈丙与与丏丟 <= 0))
        {
                if(this.丈七丈丞专七丟专丛 < 1)
        {
            goto label_6;
        }
        
        }
        
            this.丂丗丐三下七丞丈丂();
        }
        
        label_6:
        this.SendAnalytics();
        this.丌七三丞业丄丂丁丌();
    }
    public void SendAnalytics()
    {
        PGCompany.Analytics.不且丙丙东丘丏业业 val_13;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "NetworkStartTableNGUIController.SendAnalytics", arg1:  "x3AdShownCompletionStatus", arg2:  this.丑丛丒万世世丏业与));
        }
        
        val_13 = this.丑丛丒万世世丏业与;
        if(val_13 == 1)
        {
            goto label_6;
        }
        
        if((val_13 & 2147483648) == 0)
        {
            goto label_7;
        }
        
        return;
        label_6:
        val_13 = 2;
        label_7:
        Rilisoft.一丟专且三万丞丁丂.丂东丂丆丑万丟世丛(东丏丆丝丆丄丝不丙:  (val_13 != 1) ? 1 : 0, 专专丂世专一业丝丆:  this.丛丏丒一丗丝丌不丅, 丅丙上丕丑与与丌丄:  this.下丕丌丈丙与与丏丟);
        PGCompany.七丑一上且三世丝三<K, V> val_4 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
        if(val_13 != 1)
        {
                val_4.set_Item(key:  "exp", value:  this.丛丏丒一丗丝丌不丅);
            val_4.set_Item(key:  "coins", value:  this.下丕丌丈丙与与丏丟);
        }
        
        Rilisoft.BonuseForFirstWinVideoController val_5 = Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世();
        if(val_13 == 1)
        {
                int val_6 = val_5.世丁上丅且丂丄丁丑();
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.丛丛丈世丅丘丙丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "rewarded video", 丟丛丑丒丆丛东下丌:  "rewarded_x" + val_5.丕三七丏且下丞丛不().ToString(provider:  NetworkStartTableNGUIController.丙专丝世不业下丂丈())(val_5.丕三七丏且下丞丛不().ToString(provider:  NetworkStartTableNGUIController.丙专丝世不业下丂丈())), 丗七丟丈三不丕一三:  val_4, 丝丟专丒丅丁丝丘丅:  2);
        PGCompany.七丑一上且三世丝三<K, V> val_12 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
        this.丙不七专且与丑丝丅 = true;
    }
    public void HandleGetVipClick()
    {
        var val_1;
        if(this.下丄三丒丟丄丂丑世 == false)
        {
                return;
        }
        
        this.东丏且丑上丑专上不(世且不丏丒丞丙东丐:  "VipOffer");
        val_1 = null;
        val_1 = null;
        Rilisoft.VIPController.世且丑丑丄丈东丟专 = true;
        Rilisoft.一丟专且三万丞丁丂.与专丘丘三丛东丛一();
    }
    public void HandleGoToCurrencyEventClick()
    {
        var val_10;
        var val_11;
        var val_12;
        if(this.丑七专东丘丐三下丒.三丆世三上万丙丈不() != false)
        {
                return;
        }
        
        this.丑七专东丘丐三下丒.不丘丂丐丙丂丟且丁(丕下一七东丁丌丂专:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::业丞东且万丈不丅三()));
        业丈不上丟万一丕丏.丑七不且上丗丁一世().三丝丟丗一世万丝丛();
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丛业丐丅丑丐下丏一() != false)
        {
                业丈不上丟万一丕丏.丑七不且上丗丁一世().上丄与丂不且丑丞丛();
            return;
        }
        
        val_10 = null;
        val_10 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = true;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_12 = null;
            val_12 = null;
            GetComponent<NetworkStartTable>().丗一丄七世不专丞丟();
            return;
        }
        
        GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
    }
    public void HandleGoToClansClick()
    {
        var val_10;
        var val_11;
        var val_12;
        if(this.丑七专东丘丐三下丒.三丆世三上万丙丈不() != false)
        {
                return;
        }
        
        if(this.丙不七专且与丑丝丅 != false)
        {
                this.丙不七专且与丑丝丅 = false;
        }
        else
        {
                this.SendAnalytics();
        }
        
        this.丑七专东丘丐三下丒.不丘丂丐丙丂丟且丁(丕下一七东丁丌丂专:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::业丞东且万丈不丅三()));
        业丈不上丟万一丕丏.丑七不且上丗丁一世().三丝丟丗一世万丝丛();
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丛业丐丅丑丐下丏一() != false)
        {
                业丈不上丟万一丕丏.丑七不且上丗丁一世().上丄与丂不且丑丞丛();
            return;
        }
        
        val_10 = null;
        val_10 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = true;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_12 = null;
            val_12 = null;
            GetComponent<NetworkStartTable>().丗一丄七世不专丞丟();
            return;
        }
        
        GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
    }
    public void HandleGoToModuleChests()
    {
        var val_10;
        var val_11;
        var val_12;
        if(this.丑七专东丘丐三下丒.三丆世三上万丙丈不() != false)
        {
                return;
        }
        
        this.丑七专东丘丐三下丒.不丘丂丐丙丂丟且丁(丕下一七东丁丌丂专:  new System.Action(object:  this, method:  System.Void NetworkStartTableNGUIController::业丞东且万丈不丅三()));
        业丈不上丟万一丕丏.丑七不且上丗丁一世().三丝丟丗一世万丝丛();
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丛业丐丅丑丐下丏一() != false)
        {
                业丈不上丟万一丕丏.丑七不且上丗丁一世().上丄与丂不且丑丞丛();
            return;
        }
        
        val_10 = null;
        val_10 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = true;
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_12 = null;
            val_12 = null;
            GetComponent<NetworkStartTable>().丗一丄七世不专丞丟();
            return;
        }
        
        GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
    }
    public void FinishHideOldRanks()
    {
        if(this.丞丑丌世且丘丁丝下 != null)
        {
                this.StopCoroutine(routine:  this.丞丑丌世且丘丁丝下);
        }
        
        this.丞丑丌世且丘丁丝下 = this.StartCoroutine(routine:  this.FinishHideOldRanksCoroutine());
    }
    public System.Collections.IEnumerator FinishHideOldRanksCoroutine()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NetworkStartTableNGUIController.东丑三丄与丄丏丌丌(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerator 丑专东专世丁与上丙()
    {
        return (System.Collections.IEnumerator)new NetworkStartTableNGUIController.丙世丐丂丝丒七七丕(丗丏丅丕丆世丁专丟:  0);
    }
    private System.Collections.IEnumerable TryToShowExpiredBanner()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new NetworkStartTableNGUIController.不东三丕一专丄丝丄(丗丏丅丕丆世丁专丟:  -2);
    }
    internal static bool 丙丁丘专丕不上不东()
    {
        NetworkStartTableNGUIController val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 144];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.startInterfacePanel;
        if(val_3 == 0)
        {
                return false;
        }
        
        if(null != 0)
        {
                return activeSelf;
        }
        
        return activeSelf;
    }
    internal static bool 且业且丗丐丟世业业()
    {
        NetworkStartTableNGUIController val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_3 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 152];
        val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.endInterfacePanel;
        if(val_3 == 0)
        {
                return false;
        }
        
        if(null != 0)
        {
                return activeSelf;
        }
        
        return activeSelf;
    }
    internal void 丐丅丑丞丆丝上丈丝()
    {
        UnityEngine.Debug.Log(message:  "Hide End Interface");
        this.socialPnl.SetActive(value:  false);
        this.allInterfacePanel.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
        this.endInterfacePanel.SetActive(value:  false);
        this.ranksTable.三上丗业丑三丗一丌(丛丅丘一丏丙且丌上:  false, 丗三上丞丆七不且七:  0);
        this.丞三专丈业丈丙丆丘();
        this.ReasonsPanel.SetActive(value:  false);
        this.ActionPanel.SetActive(value:  false);
        this.丁丘丟万丙万且丆专 = true;
        if(this.专东丝丈丕丞与万不 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.专东丝丈丕丞与万不);
        this.专东丝丈丕丞与万不 = 0;
    }
    internal void 世丞丂不世丆下丄丒()
    {
        this.allInterfacePanel.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ProgressInterfaceGo, 丏业丟一东丂东丘丛:  false);
        this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  true);
    }
    private void 丟丐丄丂一一丝丕丝(bool 东丗丗丌专上丗丐丑 = True)
    {
        UnityEngine.Debug.Log(message:  ">>> ShowTable");
        this.ranksTable.isShowRanks = 东丗丗丌专上丗丐丑;
        this.ranksTable.tekPanel.SetActive(value:  true);
    }
    internal void 丞三专丈业丈丙丆丘()
    {
        this.ranksTable.isShowRanks = false;
        this.ranksTable.tekPanel.SetActive(value:  false);
    }
    internal void 专丌且业三丄丂下丆()
    {
        this.丟丐丄丂一一丝丕丝(东丗丗丌专上丗丐丑:  true);
        this.ranksInterface.SetActive(value:  true);
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
                return;
        }
        
        if(TeamDuelController.丅丌丛丏丞上万丛丕 == 0)
        {
                return;
        }
        
        this.roundShieldsContainerScore.SetActive(value:  true);
        TeamDuelController.丅丌丛丏丞上万丛丕.丆丟丕丈业丘丒丕三(丞三丕丅丝万丛丂丆:  this.roundShieldsScore);
    }
    private void 丑丝丂丅三丙丕丕且(bool 丟丆丞丏业七世东丒 = True)
    {
        if(丟丆丞丏业七世东丒 != false)
        {
                this.丞三专丈业丈丙丆丘();
        }
        
        this.ranksInterface.SetActive(value:  false);
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
                return;
        }
        
        this.roundShieldsContainerScore.SetActive(value:  false);
    }
    internal void 丏专七丁七丙下丆丁(bool 丟丆丞丏业七世东丒 = True)
    {
        Player_move_c val_3;
        var val_4;
        var val_5;
        val_3 = this;
        if(this.丞丁丛丐不丞丗丒三() == true)
        {
                return;
        }
        
        丟丆丞丏业七世东丒 = 丟丆丞丏业七世东丒;
        this.丑丝丂丅三丙丕丕且(丟丆丞丏业七世东丒:  丟丆丞丏业七世东丒);
        this.ReasonsPanel.SetActive(value:  false);
        this.ActionPanel.SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        val_3 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_3 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_3 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        上三业东上丞丈丞丕();
    }
    private void 丂丘三与丈丁丕丒丂(bool 丛与丙丒丒下丌丟且 = True)
    {
        NetworkStartTableNGUIController val_63;
        var val_64;
        var val_65;
        var val_66;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_67;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_68;
        var val_69;
        Rilisoft.七丕丟丏三丈一丄世 val_70;
        UnityEngine.GameObject val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_78;
        var val_79;
        var val_80;
        var val_82;
        NetworkStartTableNGUIController val_83;
        val_63 = this;
        val_64 = null;
        val_64 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 != 0)
        {
            goto label_6;
        }
        
        val_65 = 1;
        if(丛与丙丒丒下丌丟且 == false)
        {
            goto label_162;
        }
        
        label_161:
        val_66 = null;
        val_66 = null;
        val_67 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_67 == null)
        {
            goto label_14;
        }
        
        val_68 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_68 == null)
        {
                val_68 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_68.丌不丅不丞东万专专();
        var val_4 = (val_2.HasValue.丙东专丂世丈丏丁丂() != 3) ? 1 : 0;
        val_4 = val_4 | (~1152921531029452680);
        val_69 = val_4 & 1;
        goto label_14;
        label_6:
        val_70 = GameConnect.丑丌丛丈丅丅与不业();
        val_63 = val_63;
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  val_70, 丞丁丑丏丄丏七丂不:  typeof(SceneInfo).__il2cppRuntimeField_38)) != true)
        {
                if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丅丄丌丗丛七丆丌丘:  typeof(SceneInfo).__il2cppRuntimeField_38>>0&0xFFFFFFFF)) == false)
        {
            goto label_22;
        }
        
        }
        
        val_65 = (~(GameConnect.下丒下三下丘丄下上(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业()))) & 1;
        if(丛与丙丒丒下丌丟且 == true)
        {
            goto label_161;
        }
        
        label_162:
        val_69 = 1;
        label_14:
        val_71 = 0;
        val_72 = val_69 | val_65;
        goto label_26;
        label_33:
        var val_12 = mem[1152921531029465384] + 0;
        val_70 = mem[1152921531029466040];
        this.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  (val_72 == 0) ? 1 : 0, 丅丆东丏丙丝丅丆丟:  (mem[1152921531029465384] + 0) + 32.gameObject, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  (val_70 + 0) + 32);
        val_71 = 1;
        label_26:
        if(val_71 < (mem[1152921531029465384] + 24))
        {
            goto label_33;
        }
        
        mem[1152921531029465424].SetActive(value:  (val_72 == 0) ? 1 : 0);
        if(val_72 != 0)
        {
                return;
        }
        
        val_73 = null;
        val_73 = null;
        AllScenesForMode val_19 = SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  GameConnect.丑丌丛丈丅丅与不业());
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_22 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0);
        mem[1152921531029466360].Clear();
        val_70 = 0;
        val_74 = 0;
        goto label_44;
        label_115:
        if(val_22 == null)
        {
            goto label_95;
        }
        
        var val_65 = 0;
        val_65 = val_65 + 1;
        System.Collections.Generic.IEnumerator<T> val_24 = val_22.GetEnumerator();
        label_73:
        var val_66 = 0;
        val_66 = val_66 + 1;
        if(val_24.MoveNext() == false)
        {
            goto label_55;
        }
        
        var val_67 = 0;
        val_67 = val_67 + 1;
        T val_28 = val_24.Current;
        if(val_28.丁东丒七与丄业丟丕() == false)
        {
            goto label_73;
        }
        
        val_78 = null;
        val_78 = null;
        SceneInfo val_31 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_28.丕丆丞丂业东与上丅());
        if((val_31 == 0) || (val_31 != val_19.avaliableScenes.Item[0]))
        {
            goto label_73;
        }
        
        val_79 = 1;
        val_80 = 1;
        if(val_24 != null)
        {
            goto label_76;
        }
        
        goto label_87;
        label_55:
        val_80 = 0;
        val_79 = 1;
        if(val_24 != null)
        {
            goto label_76;
        }
        
        goto label_87;
        label_76:
        var val_68 = 0;
        val_68 = val_68 + 1;
        val_24.Dispose();
        label_87:
        var val_70 = val_79;
        if((val_70 == 1) || (385 != 385))
        {
            goto label_93;
        }
        
        var val_69 = 0;
        val_63 = val_63;
        val_69 = val_69 ^ 0;
        val_70 = val_70 + val_69;
        if( != 0)
        {
            goto label_111;
        }
        
        goto label_95;
        label_93:
        val_63 = val_63;
        val_70 = 0;
        if( != 0)
        {
            goto label_111;
        }
        
        label_95:
        SceneInfo val_38 = val_19.avaliableScenes.Item[0];
        val_63 = val_63;
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  val_38.indexMap)) == true)
        {
            goto label_103;
        }
        
        SceneInfo val_41 = val_19.avaliableScenes.Item[0];
        val_63 = val_63;
        if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丅丄丌丗丛七丆丌丘:  val_41.indexMap)) == false)
        {
            goto label_108;
        }
        
        label_103:
        if((GameConnect.下丒下三下丘丄下上(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) == false)
        {
            goto label_111;
        }
        
        label_108:
        mem[1152921531029466360].Add(item:  val_19.avaliableScenes.Item[0]);
        val_63 = val_63;
        label_111:
        val_74 = 1;
        label_44:
        if(val_74 < val_19.avaliableScenes.Count)
        {
            goto label_115;
        }
        
        SceneInfo[] val_47 = new SceneInfo[0];
        val_72 = mem[1152921531029465384];
        val_71 = mem[mem[1152921531029465384] + 32];
        val_71 = mem[1152921531029465384] + 32;
        val_71.SetMap(丄不东丁丂丅万丒丟:  0);
        val_82 = 1;
        goto label_120;
        label_160:
        int val_73 = UnityEngine.Random.Range(min:  0, max:  mem[1152921531029466360].Count);
        var val_74 = 0;
        SceneInfo[] val_71 = val_47[val_82][32];
        goto label_143;
        label_140:
        val_83 = val_63;
        val_70 = 0;
        mem2[0] = val_74;
        goto label_126;
        label_143:
        if((1 & 1) == 0)
        {
            goto label_127;
        }
        
        SceneInfo val_50 = mem[1152921531029466360].Item[val_73];
        if(val_82 < 1)
        {
            goto label_129;
        }
        
        var val_72 = 0;
        label_135:
        if(1152921531029412032 == val_50)
        {
            goto label_138;
        }
        
        val_72 = val_72 + 1;
        if(val_72 < 1)
        {
            goto label_135;
        }
        
        label_129:
        if((val_50.丙且上丒不下丑下丞().Equals(value:  UnityEngine.Application.loadedLevelName)) != true)
        {
                if(val_50.AvaliableWeapon != 3)
        {
            goto label_140;
        }
        
        }
        
        label_138:
        val_83 = val_63;
        val_73 = val_73 + 1;
        val_74 = val_74 + 1;
        var val_57 = (val_73 > (mem[1152921531029466360].Count - 1)) ? 0 : (val_73);
        val_70 = 1;
        label_126:
        var val_59 = (val_70 != 0) ? 1 : 0;
        if(val_74 <= mem[1152921531029466360].Count)
        {
            goto label_143;
        }
        
        UnityEngine.Debug.LogWarning(message:  "no map");
        label_127:
        val_72 = mem[1152921531029465384];
        var val_61 = val_72 + 8;
        val_71 = mem[(mem[1152921531029465384] + 8) + 32];
        val_71 = (mem[1152921531029465384] + 8) + 32;
        if(val_71 != 0)
        {
                val_71.SetMap(丄不东丁丂丅万丒丟:  val_71);
        }
        else
        {
                val_72 = mem[1152921531029466040];
            val_71 = val_71.gameObject;
            this.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  false, 丅丆东丏丙丝丅丆丟:  val_71, 下丈下七一万丆丁丕:  0, 丒丂丑丅丒丁业且与: ref  (val_72 + 8) + 32);
        }
        
        val_82 = 2;
        label_120:
        if(val_82 < val_47.Length)
        {
            goto label_160;
        }
        
        return;
        label_22:
        if(丛与丙丒丒下丌丟且 == true)
        {
            goto label_161;
        }
        
        goto label_162;
    }
    internal void 七丘丈丛世与丘万丝(bool 丛与丙丒丒下丌丟且 = True)
    {
        var val_29;
        var val_81;
        NetworkStartTableNGUIController val_82;
        var val_83;
        var val_84;
        SceneInfo val_85;
        var val_86;
        bool val_87;
        var val_88;
        var val_89;
        var val_90;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_91;
        var val_92;
        var val_93;
        var val_94;
        var val_95;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_96;
        var val_97;
        var val_98;
        var val_102;
        var val_103;
        var val_104;
        var val_106;
        NetworkStartTableNGUIController val_107;
        val_82 = this;
        if(GameConnect.业丛丛丂一丆丕丗丟() != false)
        {
                丛与丙丒丒下丌丟且 = 丛与丙丒丒下丌丟且;
            this.丂丘三与丈丁丕丒丂(丛与丙丒丒下丌丟且:  丛与丙丒丒下丌丟且);
            return;
        }
        
        val_83 = 1152921505189646336;
        val_84 = null;
        val_84 = null;
        val_85 = mem[GameController.丆丘丂丈世丏丟丑丏 + 48];
        val_85 = GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上;
        if(val_85 != 0)
        {
            goto label_10;
        }
        
        val_86 = 1;
        if(丛与丙丒丒下丌丟且 == true)
        {
            goto label_23;
        }
        
        goto label_34;
        label_10:
        Rilisoft.七丕丟丏三丈一丄世 val_4 = GameConnect.丑丌丛丈丅丅与不业();
        val_82 = val_82;
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  val_4, 丞丁丑丏丄丏七丂不:  typeof(SceneInfo).__il2cppRuntimeField_38)) != true)
        {
                if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丅丄丌丗丛七丆丌丘:  typeof(SceneInfo).__il2cppRuntimeField_38>>0&0xFFFFFFFF)) == false)
        {
            goto label_20;
        }
        
        }
        
        val_86 = (~(GameConnect.下丒下三下丘丄下上(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业()))) & 1;
        if(丛与丙丒丒下丌丟且 == true)
        {
            goto label_23;
        }
        
        goto label_34;
        label_20:
        val_86 = 0;
        if(丛与丙丒丒下丌丟且 == false)
        {
            goto label_34;
        }
        
        label_23:
        if((GameConnect.一与东丝万上三丆丏() != true) && (GameConnect.与丂丝丟丟三丑丝万() != true))
        {
                bool val_12 = GameConnect.丟丆丏上丌一丝丟业();
            if(val_12 != true)
        {
                if(val_12.一丈丛丘与丕丛丝东() == false)
        {
            goto label_35;
        }
        
        }
        
        }
        
        label_34:
        var val_82 = 1;
        label_89:
        val_82 = val_82 | val_86;
        if(val_82 != 0)
        {
                val_87 = 1;
        }
        else
        {
                val_88 = null;
            val_88 = null;
            val_87 = mem[GameController.onlineMode + 416];
            val_87 = GameController.onlineMode.丅丅丌丞七东丂上丙;
        }
        
        val_89 = 0;
        goto label_41;
        label_52:
        val_85 = 0;
        var val_14 = mem[1152921531029831456] + 0;
        if(((mem[1152921531029831456] + 0) + 32) != 0)
        {
                var val_16 = mem[1152921531029831456] + 0;
            (mem[1152921531029831456] + 0) + 32.gameObject.SetActive(value:  (val_87 == false) ? 1 : 0);
        }
        
        val_89 = 1;
        label_41:
        if(val_89 < (mem[1152921531029831456] + 24))
        {
            goto label_52;
        }
        
        val_81 = 1152921505066536960;
        if(mem[1152921531029831504] != 0)
        {
                mem[1152921531029831504].SetActive(value:  (val_87 == false) ? 1 : 0);
        }
        
        val_90 = null;
        val_90 = null;
        val_91 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_91 == null)
        {
            goto label_59;
        }
        
        val_91 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_91 == null)
        {
                val_91 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_21 = val_91.丌不丅不丞东万专专();
        if((val_21.HasValue.丙东专丂世丈丏丁丂() != 3) || ((653168008 & 1) == 0))
        {
            goto label_64;
        }
        
        label_59:
        if(val_87 == true)
        {
                return;
        }
        
        goto label_66;
        label_64:
        val_92 = null;
        val_92 = null;
        System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_23 = GameConnect.丈丝丂丐丟万丙丑丕.且与业丞丞业丐丄丗();
        if(val_23.Count >= 1)
        {
                val_93 = val_23.Item[0];
        }
        else
        {
                val_93 = 0;
        }
        
        val_94 = null;
        val_94 = null;
        List.Enumerator<T> val_27 = GameConnect.丈丝丂丐丟万丙丑丕.丙丐丗丏与丛丌丐丂().GetEnumerator();
        label_80:
        if((653167984 & 1) == 0)
        {
            goto label_78;
        }
        
        val_85 = val_29.丐丏七丌丕丗业且上();
        if(val_85.不业丙丒丂丞下丆丙() != 8)
        {
            goto label_80;
        }
        
        goto label_81;
        label_78:
        val_85 = 0;
        label_81:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_92;
        label_35:
        val_95 = null;
        val_95 = null;
        val_96 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_96 == null)
        {
            goto label_89;
        }
        
        val_96 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_96 == null)
        {
                val_96 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_32 = val_96.丌不丅不丞东万专专();
        int val_33 = val_32.HasValue.丙东专丂世丈丏丁丂();
        var val_34 = (val_33 != 3) ? 1 : 0;
        val_34 = val_34 | (~1152921531029818760);
        val_34 = val_34 & 1;
        goto label_89;
        label_92:
        var val_37 = ((val_33 == 0) ? 1 : 0) | (( == 0) ? 1 : 0);
        if(mem[1152921531029832016] == 0)
        {
            goto label_93;
        }
        
        if((val_37 & 1) == 0)
        {
            goto label_94;
        }
        
        label_98:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921531029832016].gameObject, 丏业丟一东丂东丘丛:  false);
        goto label_97;
        label_93:
        if((val_37 & 1) != 0)
        {
            goto label_98;
        }
        
        label_94:
        mem[1152921531029832016].上东与丛丞下丈专丈(丞三丕世业三丒丅三:  val_33, 丄丄七丞丙丞丗一丟:  null);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  mem[1152921531029832016], 丏业丟一东丂东丘丛:  true);
        label_97:
        val_81 = 1152921505066536960;
        if(val_4 != 0)
        {
                return;
        }
        
        label_66:
        val_97 = null;
        val_97 = null;
        AllScenesForMode val_40 = SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  GameConnect.丑丌丛丈丅丅与不业());
        System.Collections.Generic.IEnumerable<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒> val_43 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0);
        mem[1152921531029832440].Clear();
        val_87 = 0;
        val_98 = 0;
        goto label_110;
        label_181:
        if(val_43 == null)
        {
            goto label_161;
        }
        
        var val_83 = 0;
        val_83 = val_83 + 1;
        System.Collections.Generic.IEnumerator<T> val_45 = val_43.GetEnumerator();
        label_139:
        var val_84 = 0;
        val_84 = val_84 + 1;
        if(val_45.MoveNext() == false)
        {
            goto label_121;
        }
        
        var val_85 = 0;
        val_85 = val_85 + 1;
        T val_49 = val_45.Current;
        if(val_49.丁东丒七与丄业丟丕() == false)
        {
            goto label_139;
        }
        
        val_102 = null;
        val_102 = null;
        SceneInfo val_52 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_49.丕丆丞丂业东与上丅());
        if((val_52 == 0) || (val_52 != val_40.avaliableScenes.Item[0]))
        {
            goto label_139;
        }
        
        val_103 = 1;
        val_104 = 1;
        if(val_45 != null)
        {
            goto label_142;
        }
        
        goto label_153;
        label_121:
        val_104 = 0;
        val_103 = 1;
        if(val_45 != null)
        {
            goto label_142;
        }
        
        goto label_153;
        label_142:
        var val_86 = 0;
        val_86 = val_86 + 1;
        val_45.Dispose();
        label_153:
        var val_88 = val_103;
        if((val_88 == 1) || (670 != 670))
        {
            goto label_159;
        }
        
        var val_87 = 0;
        val_82 = val_82;
        val_87 = val_87 ^ 0;
        val_88 = val_88 + val_87;
        if( != 0)
        {
            goto label_177;
        }
        
        goto label_161;
        label_159:
        val_82 = val_82;
        val_87 = 0;
        if( != 0)
        {
            goto label_177;
        }
        
        label_161:
        SceneInfo val_59 = val_40.avaliableScenes.Item[0];
        val_82 = val_82;
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  val_59.indexMap)) == true)
        {
            goto label_169;
        }
        
        SceneInfo val_62 = val_40.avaliableScenes.Item[0];
        val_82 = val_82;
        if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丅丄丌丗丛七丆丌丘:  val_62.indexMap)) == false)
        {
            goto label_174;
        }
        
        label_169:
        if((GameConnect.下丒下三下丘丄下上(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) == false)
        {
            goto label_177;
        }
        
        label_174:
        mem[1152921531029832440].Add(item:  val_40.avaliableScenes.Item[0]);
        val_82 = val_82;
        label_177:
        val_98 = 1;
        label_110:
        if(val_98 < val_40.avaliableScenes.Count)
        {
            goto label_181;
        }
        
        SceneInfo[] val_68 = new SceneInfo[0];
        val_81 = mem[1152921531029831456];
        val_85 = mem[mem[1152921531029831456] + 32];
        val_85 = mem[1152921531029831456] + 32;
        val_85.SetMap(丄不东丁丂丅万丒丟:  0);
        val_106 = 1;
        goto label_186;
        label_218:
        int val_91 = UnityEngine.Random.Range(min:  0, max:  mem[1152921531029832440].Count);
        var val_92 = 0;
        goto label_209;
        label_206:
        val_107 = val_82;
        val_87 = 0;
        mem2[0] = val_98;
        goto label_192;
        label_209:
        if((1 & 1) == 0)
        {
            goto label_193;
        }
        
        SceneInfo val_71 = mem[1152921531029832440].Item[val_91];
        if(val_106 < 1)
        {
            goto label_195;
        }
        
        var val_90 = 0;
        label_201:
        if(1152921531029412032 == val_71)
        {
            goto label_204;
        }
        
        val_90 = val_90 + 1;
        if(val_90 < 1)
        {
            goto label_201;
        }
        
        label_195:
        if((val_71.丙且上丒不下丑下丞().Equals(value:  UnityEngine.Application.loadedLevelName)) != true)
        {
                if(val_71.AvaliableWeapon != 3)
        {
            goto label_206;
        }
        
        }
        
        label_204:
        val_107 = val_82;
        val_91 = val_91 + 1;
        val_92 = val_92 + 1;
        var val_78 = (val_91 > (mem[1152921531029832440].Count - 1)) ? 0 : (val_91);
        val_87 = 1;
        label_192:
        var val_80 = (val_87 != 0) ? 1 : 0;
        if(val_92 <= mem[1152921531029832440].Count)
        {
            goto label_209;
        }
        
        UnityEngine.Debug.LogWarning(message:  "no map");
        label_193:
        val_81 = mem[1152921531029831456];
        var val_81 = val_81 + 8;
        val_85 = mem[(mem[1152921531029831456] + 8) + 32];
        val_85 = (mem[1152921531029831456] + 8) + 32;
        val_85.SetMap(丄不东丁丂丅万丒丟:  val_68[val_106][32]);
        val_106 = 2;
        label_186:
        if(val_106 < val_68.Length)
        {
            goto label_218;
        }
    
    }
    public void OnRewardAnimationEnds()
    {
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                bool val_2 = this.丁与不万上业丁丏业();
        }
        
        this.interfaceAnimator.SetTrigger(name:  "AnimationEnds");
    }
    public void OnTrophyOkButtonPress()
    {
        if(this.丟专下丑万丌世下不 != null)
        {
                this.StopCoroutine(routine:  this.丟专下丑万丌世下不);
            this.丟专下丑万丌世下不 = 0;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.丟专下丑万丌世下不 = this.StartCoroutine(routine:  this.业丒丏丘丗业丈七上(丕丕世且下一与丝与:  0f).GetEnumerator());
    }
    private System.Collections.IEnumerable 业丒丏丘丗业丈七上(float 丕丕世且下一与丝与)
    {
        NetworkStartTableNGUIController.下一丗丟七下不丆丞 val_1 = new NetworkStartTableNGUIController.下一丗丟七下不丆丞(丗丏丅丕丆世丁专丟:  -2);
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
    private void 丙世丏七丌专万丁一()
    {
        if(this.BankShopGUI == 0)
        {
                return;
        }
        
        if(this.BankShopGUI.丄世下丟三与丛世丅() == 0)
        {
                return;
        }
        
        if(this.BankShopGUI.丌三不七丌丗丞丌专() != 0)
        {
                return;
        }
        
        Rilisoft.BankShopView val_5 = this.BankShopGUI.丄世下丟三与丛世丅();
        UIButton val_6 = val_5.ShopButton.GetComponent<UIButton>();
        Rilisoft.BankShopView val_7 = this.BankShopGUI.丄世下丟三与丛世丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7.ArmoryBlinkHint, 丏业丟一东丂东丘丛:  false);
        Rilisoft.BankShopView val_8 = this.BankShopGUI.丄世下丟三与丛世丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8.GoArmoryHint, 丏业丟一东丂东丘丛:  false);
    }
    private void 丗东丞一丞丑三丈专(bool 丛丅丘一丏丙且丌上)
    {
        bool val_1 = 丛丅丘一丏丙且丌上;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.TitleGameObjectAboveTable, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.SubtitleGameObjectAboveTable, 丏业丟一东丂东丘丛:  val_1);
    }
    internal void 专丏三丙一丕东且丌()
    {
        var val_19;
        GameModeController val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        string val_26;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTableBig, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SubtitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  "");
        if((RedLightController.Instance == 0) || (GameConnect.一业上七丟业且业丙() == false))
        {
            goto label_8;
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = GameController.mode;
        if(null == 0)
        {
            goto label_12;
        }
        
        val_21 = null;
        val_21 = null;
        if(null != 0)
        {
            goto label_33;
        }
        
        goto label_33;
        label_8:
        this.丗东丞一丞丑三丈专(丛丅丘一丏丙且丌上:  false);
        return;
        label_12:
        val_20 = 1152921505286238208;
        val_23 = null;
        val_23 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_28;
        }
        
        val_24 = null;
        val_24 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_28;
        }
        
        val_25 = null;
        val_25 = null;
        val_22 = 业七业丅丅丝万丕丝();
        goto label_33;
        label_28:
        val_22 = 0;
        label_33:
        val_26 = RedLightController.Instance.一与丞丌丏一专丐丞();
        if(val_22 == 0)
        {
            goto label_35;
        }
        
        if(val_26 == false)
        {
            goto label_36;
        }
        
        val_26 = System.String.Format(format:  "[FFED00FF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1976"));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTableBig, 丕丗丘丑丛与丑业丒:  val_26);
        goto label_41;
        label_35:
        val_20 = System.String.Format(format:  "[FFED00FF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1446"));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  val_20);
        if(val_26 == false)
        {
            goto label_46;
        }
        
        label_41:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTableBig, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1976"));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SubtitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  "");
        return;
        label_36:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFED00FF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1446")));
        label_46:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SubtitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  System.String.Format(format:  "[00DFFFFF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5644")), arg1:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5723"), arg0:  val_22 + 1)));
    }
    internal void 丌三上丁丞丆丛丑下()
    {
        this.丗东丞一丞丑三丈专(丛丅丘一丏丙且丌上:  true);
        Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
        if((val_1 - 29) <= 9)
        {
                var val_3 = 106025860 + ((val_1 - 29)) << 2;
            val_3 = val_3 + 106025860;
        }
        else
        {
                if(val_1 == 20)
        {
                this.上且丐业丏丑丅丘且();
            return;
        }
        
            this.丗东丞一丞丑三丈专(丛丅丘一丏丙且丌上:  false);
        }
    
    }
    internal void 下上丅丗丁丕丗专上(bool 丝丘丅丙业丏丞万丁, int 丁丂丁丄三丄且万丁, int 与业丄丂丂丆下上丞, int 丄专万丏丘上丑与一)
    {
        bool val_10 = 丝丘丅丙业丏丞万丁;
        if(this.ReadyTimerContainer != 0)
        {
                this.ReadyTimerContainer.SetActive(value:  val_10 = 丝丘丅丙业丏丞万丁);
        }
        
        if(val_10 == false)
        {
                return;
        }
        
        val_10 = this.DesireCounterLabel;
        if(val_10 == 0)
        {
                return;
        }
        
        val_10 = this.DesireTimerLabel;
        if(val_10 == 0)
        {
                return;
        }
        
        val_10 = this.DesireCounterLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_10, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11151"), arg0:  丁丂丁丄三丄且万丁.ToString(), arg1:  与业丄丂丂丆下上丞.ToString()));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.DesireTimerLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丄专万丏丘上丑与一, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
    }
    internal void 上且丐业丏丑丅丘且()
    {
        object val_37;
        UILabel[] val_38;
        var val_39;
        var val_40;
        string val_41;
        var val_42;
        var val_43;
        object val_44;
        var val_45;
        var val_46;
        var val_47;
        object val_48;
        string val_49;
        var val_50;
        丈万且丗丂丝丙一东 val_51;
        var val_52;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Int32> val_54;
        string val_55;
        if((BattleRoyaleController.丑七不且上丗丁一世() == 0) || (GameConnect.万不丒丌丙万丗东不() == false))
        {
            goto label_8;
        }
        
        BattleRoyaleController val_4 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_4.squadMode == false)
        {
            goto label_16;
        }
        
        val_37 = BattleRoyaleController.丑七不且上丗丁一世().丟丁丕世丕与丑专丈();
        if(val_37 == 1)
        {
            goto label_16;
        }
        
        val_38 = this.TitleLabelsAboveTable;
        val_39 = 0;
        val_40 = 0;
        val_41 = "[FFED00FF]{0}[-]";
        if(val_37 == 1)
        {
            goto label_17;
        }
        
        goto label_27;
        label_8:
        this.丗东丞一丞丑三丈专(丛丅丘一丏丙且丌上:  false);
        return;
        label_16:
        val_42 = null;
        val_42 = null;
        if(null == 0)
        {
            goto label_22;
        }
        
        val_43 = null;
        val_43 = null;
        label_46:
        val_38 = this.TitleLabelsAboveTable;
        val_37 = 0;
        val_39 = 1;
        val_41 = "[FFED00FF]{0}[-]";
        label_17:
        val_44 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1446");
        goto label_30;
        label_22:
        val_45 = null;
        val_45 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_41;
        }
        
        val_46 = null;
        val_46 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_41;
        }
        
        val_47 = null;
        val_47 = null;
        int val_10 = 业七业丅丅丝万丕丝();
        goto label_46;
        label_41:
        val_38 = this.TitleLabelsAboveTable;
        val_39 = 1;
        val_40 = 0;
        val_37 = 0;
        val_41 = "[FFED00FF]{0}[-]";
        label_27:
        val_44 = "";
        label_30:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_38, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_41, arg0:  val_44));
        if((val_39 & 1) != 0)
        {
                val_48 = System.String.Format(format:  "[00DFFFFF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5644"));
            val_49 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5723");
            val_50 = null;
            var val_15 = val_40 + 1;
        }
        else
        {
                val_48 = System.String.Format(format:  "[00DFFFFF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6136"));
            val_49 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5723");
            val_50 = null;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SubtitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  val_48, arg1:  System.String.Format(format:  val_49, arg0:  val_37)));
        if(BattleRoyaleController.丑七不且上丗丁一世().roomStatus != 1)
        {
                return;
        }
        
        val_51 = System.Linq.Enumerable.FirstOrDefault<丈万且丗丂丝丙一东>(source:  一且下与丂丌丝三三.万三下下丅丘丐与丄(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 且专丏丏丈三丒与丙:  false));
        .丛七丂丕一世不不丄 = val_51;
        if((val_39 & 1) == 0)
        {
                BattleRoyaleController val_27 = BattleRoyaleController.丑七不且上丗丁一世();
            val_52 = null;
            val_52 = null;
            val_54 = NetworkStartTableNGUIController.<>c.<>9__378_1;
            if(val_54 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Int32> val_30 = null;
            val_54 = val_30;
            val_30 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Int32>(object:  NetworkStartTableNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 NetworkStartTableNGUIController.<>c::与丏丅丗业丗丏丆丞(System.Collections.Generic.KeyValuePair<string, 丈万且丗丂丝丙一东> 三丟东丕丄丄下下丑));
            NetworkStartTableNGUIController.<>c.<>9__378_1 = val_54;
        }
        
            System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东> val_32 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Int32>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>>(source:  val_27.上丄丈丙丐丘丙丁与, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丈万且丗丂丝丙一东>, System.Boolean>(object:  new NetworkStartTableNGUIController.丅丏万丅上丗且业不(), method:  System.Boolean NetworkStartTableNGUIController.丅丏万丅上丗且业不::业三东丂万不丘丈丝(System.Collections.Generic.KeyValuePair<string, 丈万且丗丂丝丙一东> 三丟东丕丄丄下下丑))), keySelector:  val_30));
            val_51;
            .丛七丂丕一世不不丄 = val_51;
            if(val_37 == 1)
        {
                return;
        }
        
        }
        
        if(val_40 == 0)
        {
                return;
        }
        
        if(val_32.Value == 0)
        {
                return;
        }
        
        if(val_39 != 0)
        {
                val_55 = "Key_5716";
        }
        else
        {
                val_55 = "Key_6135";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFED00FF]" + System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_55), arg0:  "{0}{1}{2}")(System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_55), arg0:  "{0}{1}{2}")) + "[-]"("[-]"), arg0:  "[-]", arg1:  System.String.Format(format:  "[FF9900FF]{0}[-]", arg0:  (NetworkStartTableNGUIController.丅丏万丅上丗且业不)[1152921531032635488].丛七丂丕一世不不丄.丒丘丏上丙丟丑丕丈), arg2:  "[FFED00FF]"));
    }
    internal void 丌丆万丑上与丑丘丌()
    {
        var val_10;
        var val_11;
        object val_12;
        string val_13;
        val_10 = null;
        val_10 = null;
        if(null != 0)
        {
                val_11 = null;
            val_11 = null;
            val_13 = mem[丁丁丒丆不丒下丟三.__il2cppRuntimeField_fields == 0x1 ? "Key_1115" : "Key_1116"];
            val_13 = (丁丁丒丆不丒下丟三.__il2cppRuntimeField_fields == 1) ? "Key_1115" : "Key_1116";
        }
        else
        {
                val_12 = 0;
            val_13 = "Key_1116";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFED00FF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_13)));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SubtitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  System.String.Format(format:  "[00DFFFFF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5644")), arg1:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5723"), arg0:  val_12)));
    }
    internal void 丝丑万丈丁东丑丝专()
    {
        var val_5;
        var val_6;
        var val_7;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTableBig, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SubtitleLabelsAboveTable, 丕丗丘丑丛与丑业丒:  "");
        val_5 = null;
        val_5 = null;
        if(null == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = "Key_1115";
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.TitleLabelsAboveTableBig, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "[FFED00FF]{0}[-]", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null)));
    }
    internal void 与下丘万丌丆万丟丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        NetworkStartTable val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        val_3 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_3 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_3 != 0)
        {
                val_4 = null;
            val_4 = null;
            val_3 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_3 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            typeof(NetworkStartTable).__il2cppRuntimeField_72 = 1;
        }
        
        PGCompany.丕丝下丁七东丄三丑.丗与丆丏丝下丅丕世(丈丁下不丐丑丈丈业:  0, 专上且丗丑丌丟丈丄:  true, 丁丟丑丆三丆业一丅:  3);
    }
    private void 一业业七不业丈下丞()
    {
        var val_8;
        丙丏下世且七丌上万 val_9;
        var val_10;
        if(this.BankShopGUI == 0)
        {
                return;
        }
        
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false)
        {
            goto label_6;
        }
        
        Queue.Enumerator<T> val_4 = this.丐丅七丂且丈丕丕三().GetEnumerator();
        label_9:
        if((657024568 & 1) == 0)
        {
            goto label_8;
        }
        
        if(657024568 == 1)
        {
            goto label_9;
        }
        
        val_8 = 0;
        goto label_14;
        label_6:
        if(this.BankShopGUI.InteractionEnabled == false)
        {
                return;
        }
        
        val_9 = 1;
        val_10 = 0;
        goto label_13;
        label_8:
        val_8 = 1;
        label_14:
        if(this.丐丅七丂且丈丕丕三().Count == 0)
        {
            goto label_18;
        }
        
        if( != 0)
        {
            goto label_19;
        }
        
        return;
        label_18:
        var val_7 = (this.BankShopGUI.InteractionEnabled == true) ? 1 : 0;
        val_7 =  & val_7;
        if((val_7 & 1) == 0)
        {
                return;
        }
        
        label_19:
        val_10 = 1;
        val_9 = 0;
        label_13:
        this.三与丁丞丂丗丅丆丁(丝三丄专丗丞丄丄丌:  true, 下丈下七一万丆丁丕:  val_9);
    }
    private void 三与丁丞丂丗丅丆丁(bool 丝三丄专丗丞丄丄丌, NetworkStartTableNGUIController.丙丏下世且七丌上万 下丈下七一万丆丁丕)
    {
        丙丏下世且七丌上万 val_6;
        bool val_7;
        val_6 = 下丈下七一万丆丁丕;
        if(this.丐丅七丂且丈丕丕三() == null)
        {
            goto label_1;
        }
        
        if(丝三丄专丗丞丄丄丌 == false)
        {
            goto label_2;
        }
        
        label_7:
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false)
        {
            goto label_5;
        }
        
        val_7 = 1;
        goto label_8;
        label_1:
        this.丈丄丏专丄丆丄丟丕 = new System.Collections.Generic.Queue<丙丏下世且七丌上万>();
        if(丝三丄专丗丞丄丄丌 == true)
        {
            goto label_7;
        }
        
        label_2:
        val_7 = 0;
        goto label_8;
        label_5:
        this.丐丅七丂且丈丕丕三().Clear();
        val_7 = false;
        val_6 = 1;
        label_8:
        System.Collections.Generic.Queue<丙丏下世且七丌上万> val_5 = this.丐丅七丂且丈丕丕三();
        if(val_5 == null)
        {
            goto label_10;
        }
        
        if(val_7 == 0)
        {
            goto label_11;
        }
        
        label_13:
        val_5.Clear();
        goto label_12;
        label_10:
        if(val_7 != 0)
        {
            goto label_13;
        }
        
        label_11:
        val_5.Enqueue(item:  val_6);
        label_12:
        this.BankShopGUI.InteractionEnabled = val_7;
        this.BankShopGUI.丝一丅丆三东丂丞七();
    }
    internal void 丕丞丂丆丁丕三万丟(bool 丛丅丘一丏丙且丌上, UnityEngine.GameObject 丅丆东丏丙丝丅丆丟, NetworkStartTableNGUIController.丙丏下世且七丌上万 下丈下七一万丆丁丕, ref System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万> 丒丂丑丅丒丁业且与)
    {
        丙丏下世且七丌上万 val_3;
        var val_4;
        val_3 = 下丈下七一万丆丁丕;
        if(丒丂丑丅丒丁业且与 == null)
        {
            goto label_1;
        }
        
        if(丛丅丘一丏丙且丌上 == false)
        {
            goto label_2;
        }
        
        label_7:
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false)
        {
            goto label_5;
        }
        
        val_4 = 1;
        goto label_8;
        label_1:
        System.Collections.Generic.Queue<丙丏下世且七丌上万> val_2 = new System.Collections.Generic.Queue<丙丏下世且七丌上万>();
        丒丂丑丅丒丁业且与 = val_2;
        if(丛丅丘一丏丙且丌上 == true)
        {
            goto label_7;
        }
        
        label_2:
        val_4 = 0;
        goto label_8;
        label_5:
        val_2.Clear();
        val_4 = 0;
        val_3 = 1;
        label_8:
        if(丒丂丑丅丒丁业且与 == null)
        {
            goto label_10;
        }
        
        if(val_4 == 0)
        {
            goto label_11;
        }
        
        label_13:
        val_2.Clear();
        goto label_12;
        label_10:
        if(val_4 != 0)
        {
            goto label_13;
        }
        
        label_11:
        val_2.Enqueue(item:  val_3);
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丅丆东丏丙丝丅丆丟, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丏丈下丈七丕丙丒丁()
    {
        var val_4;
        this.丏丈下丈七丕丙丒丁(丅丆东丏丙丝丅丆丟:  this.MapSelectPanel, 丒丂丑丅丒丁业且与: ref  this.下丂丐上东上丑上东);
        val_4 = 0;
        goto label_0;
        label_7:
        this.丏丈下丈七丕丙丒丁(丅丆东丏丙丝丅丆丟:  this.goMapInEndGameButtonsDuel[0].gameObject, 丒丂丑丅丒丁业且与: ref  this.丆丅丂专丏丏丙与丕[0][32]);
        val_4 = 1;
        label_0:
        if(val_4 < this.goMapInEndGameButtonsDuel.Length)
        {
            goto label_7;
        }
    
    }
    private void 丏丈下丈七丕丙丒丁(UnityEngine.GameObject 丅丆东丏丙丝丅丆丟, ref System.Collections.Generic.Queue<NetworkStartTableNGUIController.丙丏下世且七丌上万> 丒丂丑丅丒丁业且与)
    {
        System.Collections.Generic.Queue<T> val_9;
        var val_10;
        丙丏下世且七丌上万 val_11;
        var val_12;
        UnityEngine.GameObject val_13;
        if(val_8 == null)
        {
                System.Collections.Generic.Queue<丙丏下世且七丌上万> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Collections.Generic.Queue<丙丏下世且七丌上万>();
            丒丂丑丅丒丁业且与 = val_9;
        }
        
        if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false)
        {
            goto label_4;
        }
        
        Queue.Enumerator<T> val_3 = val_1.GetEnumerator();
        label_7:
        if((657843048 & 1) == 0)
        {
            goto label_6;
        }
        
        if(657843048 == 1)
        {
            goto label_7;
        }
        
        val_10 = 0;
        goto label_12;
        label_4:
        if(丅丆东丏丙丝丅丆丟.activeSelf == false)
        {
                return;
        }
        
        val_11 = 1;
        val_12 = 0;
        val_13 = 丅丆东丏丙丝丅丆丟;
        goto label_11;
        label_6:
        val_10 = 1;
        label_12:
        val_9 = 丒丂丑丅丒丁业且与;
        if(val_1.Count == 0)
        {
            goto label_16;
        }
        
        if( != 0)
        {
            goto label_17;
        }
        
        return;
        label_16:
        bool val_6 = 丅丆东丏丙丝丅丆丟.activeSelf;
        if(( & val_6) == false)
        {
                return;
        }
        
        label_17:
        val_12 = 1;
        val_13 = 丅丆东丏丙丝丅丆丟;
        val_11 = 0;
        label_11:
        val_6.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  true, 丅丆东丏丙丝丅丆丟:  val_13, 下丈下七一万丆丁丕:  val_11, 丒丂丑丅丒丁业且与: ref  System.Collections.Generic.Queue<丙丏下世且七丌上万> val_8 = 丒丂丑丅丒丁业且与);
    }
    public NetworkStartTableNGUIController()
    {
        var val_7;
        System.Func<System.String> val_9;
        this.丁丘丟万丙万且丆专 = true;
        this.goMapInEndGameButtons = new GoMapInEndGame[3];
        this.goMapInEndGameButtonsDuel = new GoMapInEndGame[2];
        this.丆丅丂专丏丏丙与丕 = new System.Collections.Generic.Queue<丙丏下世且七丌上万>[2];
        this.丑丛丒万世世丏业与 = -2;
        val_7 = null;
        val_7 = null;
        val_9 = NetworkStartTableNGUIController.<>c.<>9__387_0;
        if(val_9 == null)
        {
                System.Func<System.String> val_4 = null;
            val_9 = val_4;
            val_4 = new System.Func<System.String>(object:  NetworkStartTableNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String NetworkStartTableNGUIController.<>c::与万丑不丈世丐业丝());
            NetworkStartTableNGUIController.<>c.<>9__387_0 = val_9;
        }
        
        this.一丛下丅丏下丒与丂 = new Rilisoft.七丞丞丅东丞专丙丝<System.String>(丙丂丌且丌世丒丐三:  val_4);
        this.业不专丛世丄与上丒 = new System.Collections.Generic.List<SceneInfo>();
    }
    private void 世丏丂且万丒丅东上()
    {
        object[] val_2 = new object[9];
        string val_3 = FriendsController.丞丘丛一丝丟与丅丞();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_3 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_2[0] = val_3;
        val_2[1] = this.不丆业丏上丐与丌业;
        val_2[2] = this.丆世丘丒丒丏上且丗;
        System.DateTime val_4 = System.DateTime.UtcNow;
        System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
        val_2[3] = ;
        val_2[4] = this.一丛下丅丏下丒与丂.世三丞丅丑丌丈丈一();
        val_2[5] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_2[6] = UnityEngine.SystemInfo.deviceType;
        val_2[7] = UnityEngine.SystemInfo.deviceModel;
        val_2[8] = UnityEngine.SystemInfo.operatingSystem;
        UnityEngine.Application.OpenURL(url:  System.String.Format(format:  "mailto:{0}?subject=INAPPROPRIATE ACT {1}({2})&body=%0D%0A%0D%0A%0D%0A%0D%0A%0D%0A------------%20DO NOT DELETE%20------------%0D%0AUTC%20Time:%20{3}%0D%0AGame:%20PixelGun3D%0D%0AVersion:%20{4}%0D%0APlayerID:%20{5}%0D%0ACategory:%20INAPPROPRIATE ACT {1}({2})%0D%0ADevice%20Type:%20{6}%20{7}%0D%0AOS%20Version:%20{8}%0D%0A------------------------", args:  val_2).Replace(oldValue:  " ", newValue:  "%20"));
    }
    private void 丐万专丘丞与丑丗丑()
    {
        object[] val_2 = new object[9];
        string val_3 = FriendsController.丞丘丛一丝丟与丅丞();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_3 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_2[0] = val_3;
        val_2[1] = this.不丆业丏上丐与丌业;
        val_2[2] = this.丆世丘丒丒丏上且丗;
        System.DateTime val_4 = System.DateTime.UtcNow;
        System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
        val_2[3] = ;
        val_2[4] = this.一丛下丅丏下丒与丂.世三丞丅丑丌丈丈一();
        val_2[5] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_2[6] = UnityEngine.SystemInfo.deviceType;
        val_2[7] = UnityEngine.SystemInfo.deviceModel;
        val_2[8] = UnityEngine.SystemInfo.operatingSystem;
        UnityEngine.Application.OpenURL(url:  System.String.Format(format:  "mailto:{0}?subject=CHEATING {1}({2})&body=%0D%0A%0D%0A%0D%0A%0D%0A%0D%0A------------%20DO NOT DELETE%20------------%0D%0AUTC%20Time:%20{3}%0D%0AGame:%20PixelGun3D%0D%0AVersion:%20{4}%0D%0APlayerID:%20{5}%0D%0ACategory:%20CHEATING {1}({2})%0D%0ADevice%20Type:%20{6}%20{7}%0D%0AOS%20Version:%20{8}%0D%0A------------------------", args:  val_2).Replace(oldValue:  " ", newValue:  "%20"));
    }
    private void 丄三业丅与下丗且丙()
    {
        object[] val_2 = new object[9];
        string val_3 = FriendsController.丞丘丛一丝丟与丅丞();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_3 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_2[0] = val_3;
        val_2[1] = this.不丆业丏上丐与丌业;
        val_2[2] = this.丆世丘丒丒丏上且丗;
        System.DateTime val_4 = System.DateTime.UtcNow;
        System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
        val_2[3] = ;
        val_2[4] = this.一丛下丅丏下丒与丂.世三丞丅丑丌丈丈一();
        val_2[5] = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_2[6] = UnityEngine.SystemInfo.deviceType;
        val_2[7] = UnityEngine.SystemInfo.deviceModel;
        val_2[8] = UnityEngine.SystemInfo.operatingSystem;
        UnityEngine.Application.OpenURL(url:  System.String.Format(format:  "mailto:{0}?subject=Report {1}({2})&body=%0D%0A%0D%0A%0D%0A%0D%0A%0D%0A------------%20DO NOT DELETE%20------------%0D%0AUTC%20Time:%20{3}%0D%0AGame:%20PixelGun3D%0D%0AVersion:%20{4}%0D%0APlayerID:%20{5}%0D%0ACategory:%20Report {1}({2})%0D%0ADevice%20Type:%20{6}%20{7}%0D%0AOS%20Version:%20{8}%0D%0A------------------------", args:  val_2).Replace(oldValue:  " ", newValue:  "%20"));
    }
    private bool 世丘上丁业丒上丙丛()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if(this.endInterfacePanel == 0)
        {
                val_7 = 1;
            return (bool)val_7 & 1;
        }
        
        if((this.丐丐丑丏丁丙上上丄 != true) && (this.与与丁下万丈丆丝上 != true))
        {
                val_6 = this.endInterfacePanel.gameObject;
            if(val_6.activeInHierarchy != false)
        {
                val_7 = ShopNGUIController.丛世丛与丌不丈丐丐() ^ 1;
            return (bool)val_7 & 1;
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7 & 1;
    }
    private bool 丞丐丁三下丑丌丄丐()
    {
        var val_4;
        if(this.丆上丐丄丗丆丟丝丝 != false)
        {
                if(this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().IsCounting() == false)
        {
            goto label_3;
        }
        
        }
        
        var val_3 = (this.业丕与上丗丟丙世与 == true) ? 1 : 0;
        return (bool)val_4;
        label_3:
        val_4 = 1;
        return (bool)val_4;
    }
    private bool 丞丙丞丑丗丆一丒丂()
    {
        return (bool)(this.丌一丏丘丞东与上世 == false) ? 1 : 0;
    }
    private bool 丗丟东不丈丌丄七丄()
    {
        bool val_4 = this.丆上丐丄丗丆丟丝丝;
        if(val_4 != false)
        {
                bool val_2 = this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().IsCounting();
            val_4 = val_2 ^ 1;
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    private bool 丁丅丕不丘丐丁丏丙()
    {
        if(this.与与丁下万丈丆丝上 == false)
        {
                return (bool)(this.丐丐丑丏丁丙上上丄 == false) ? 1 : 0;
        }
        
        return false;
    }
    private bool 丁业与丕三丙丄丞七()
    {
        bool val_4 = this.丆上丐丄丗丆丟丝丝;
        if(val_4 != false)
        {
                bool val_2 = this.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().IsCounting();
            val_4 = val_2 ^ 1;
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    private void 丄丄一丑丐业丈丅丄()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OkWithAds, 丏业丟一东丂东丘丛:  false);
        this.丒一不丅丌业丁三丕();
    }
    private void 丂且丏丁丛丘世丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_4;
        GamePauseController.丄丘七三上丕世丞业.丟下世世专业下丈丞 = false;
        val_4 = static_value_081D9CF0;
        val_4 = static_value_081D9CF0;
        mem2[0] = 1114636288;
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.remove_ExitWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::丂且丏丁丛丘世丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.丒一不丅丌业丁三丕();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.OkWithAds, 丏业丟一东丂东丘丛:  false);
    }
    private void 专丄丆不万丘七丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        Rilisoft.BonuseForFirstWinVideoController.丑七不且上丗丁一世().RewardedVideo.remove_DiscardWatching(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void NetworkStartTableNGUIController::专丄丆不万丘七丆丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.丑丛丒万世世丏业与 = 2;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        this = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "NetworkStartTableNGUIController.HandleShowAds+RewardVideoDiscarded", arg1:  "x3AdShownCompletionStatus", arg2:  this.丑丛丒万世世丏业与);
        UnityEngine.Debug.Log(message:  this);
    }

}
