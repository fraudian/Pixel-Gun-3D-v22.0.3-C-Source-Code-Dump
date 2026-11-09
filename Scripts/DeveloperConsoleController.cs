using UnityEngine;
internal sealed class DeveloperConsoleController : MonoBehaviour
{
    // Fields
    private static System.Action 七丝丕丅与且丘业万;
    private static System.Action 丗丘丏专与一与万丅;
    internal static DeveloperConsoleController 丄丘七三上丕世丞业;
    private static bool 丆丐丁与丒万丈丈丄;
    private static bool 丌丁业三三丂业丈丁;
    private bool 丅丝丁丑且丁下丆丄;
    private PGCompany.BatteryWatcher 万一丁东丝丂东丗且;
    private System.Nullable<bool> 不丐且丒与丘丈丟丞;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private bool 丙丐丄丛东七丑万丙;
    private bool 上不下与丗丄丁丐丆;
    public UIToggle buffToogle;
    public bool isMiniConsole;
    private int 丈丐丒丐丕丛东丑业;
    private int 不丐丈丁一丘丄丐丅;
    public UIToggle ratingToogle;
    private int 丏一丟丒一与上丟丗;
    public DeveloperConsoleView view;
    private int 三一三丌下丟丒下业;
    private UILabel craftCurrencyCount;
    private UILabel couponsCurrencyCount;
    private UIToggle almanacDevUiToggle;
    private static bool 丗且七丙与丐丈丑丆;
    private UIToggle adaptiveAutoAimToggle;
    private UILabel adaptiveAutoAimLabel;
    
    // Properties
    internal static bool 丂丅一且丈丌丙世丗 { get; set; }
    private PGCompany.BatteryWatcher 丙东丟丕世专一与一 { get; }
    internal static bool 下上东丈世专下七丆 { get; }
    internal static bool 东丕与丂丝丗七丘与 { get; }
    
    // Methods
    internal static void 丒丏丏丛丕丐丂丛丐(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  DeveloperConsoleController.七丝丕丅与且丘业万, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丝七丘丌丝业一丟丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  DeveloperConsoleController.七丝丕丅与且丘业万, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丏世且东丈且且不且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  DeveloperConsoleController.丗丘丏专与一与万丅, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DeveloperConsoleController.丗丘丏专与一与万丅 != 1152921505306157064);
    
    }
    internal static void 世丅丏丘业且上丙与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  DeveloperConsoleController.丗丘丏专与一与万丅, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DeveloperConsoleController.丗丘丏专与一与万丅 != 1152921505306157064);
    
    }
    internal static bool 一三与丌上丝丅东丈()
    {
        null = null;
        return (bool)DeveloperConsoleController.丆丐丁与丒万丈丈丄;
    }
    private static void 丗一丕丘且丝不丛丏(bool 丙业与丙丗丝不丈东)
    {
    
    }
    private PGCompany.BatteryWatcher 上专丄丁丑丐丂与世()
    {
        if(this.万一丁东丝丂东丗且 != 0)
        {
                return (PGCompany.BatteryWatcher)this.万一丁东丝丂东丗且;
        }
        
        if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
                return (PGCompany.BatteryWatcher)this.万一丁东丝丂东丗且;
        }
        
        this.万一丁东丝丂东丗且 = InfoWindowController.丑七不且上丗丁一世().GetComponent<PGCompany.BatteryWatcher>();
        return (PGCompany.BatteryWatcher)this.万一丁东丝丂东丗且;
    }
    public void HandleBeginFromStart()
    {
    
    }
    public void HandleBeginFromStartNoTraining()
    {
    
    }
    public void HandleBeginFromStart6LevelAllItems()
    {
    
    }
    public void HandleBeginFromStartAllItems()
    {
    
    }
    public void HandleEnableX10()
    {
    
    }
    public void HandleCrarftAllFortItems()
    {
    
    }
    public void HandleAllGSQuestsAndTasksUpToLeaderboards()
    {
    
    }
    public void HandleAllGSQuestsAndTasks()
    {
    
    }
    public void HandleAllGSQuestsAndTasksUpToPool()
    {
    
    }
    public void HandleAllGSQuests()
    {
    
    }
    public void HandleGive100Details()
    {
    
    }
    internal static void 七丞万三丄丞专七世()
    {
    
    }
    public void HandleGiveAllEggs()
    {
    
    }
    internal static void 丝丕丁业丘业业三丄()
    {
    
    }
    public void HandleResetClanEngagementLimit()
    {
    
    }
    public void HandleClearProgress()
    {
    
    }
    private void 且世丐丐丂与丌丁七(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
    
    }
    public void HandleResetGatcha()
    {
    
    }
    public void HandleFacebookLoginReward(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleShowUpdateBanner(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleBackButton()
    {
        this.丅丝丁丑且丁下丆丄 = true;
    }
    public void HandleClearKeychainAndPlayerPrefs()
    {
    
    }
    public void HandleLevelMinusButton()
    {
    
    }
    public void HandleTipsShownButton()
    {
    
    }
    internal static void 与三丕专丌七丏丐丙()
    {
    
    }
    public void HandleAddGemsButton()
    {
    
    }
    public void HandleAddCoinsButton()
    {
    
    }
    public void HandleAddTicketsButton()
    {
    
    }
    public void HandleAddEventCurrencyButton()
    {
    
    }
    public void HandleAddSilverButton()
    {
    
    }
    public void HandleLevelPlusButton()
    {
    
    }
    public void HandleLevelChanged()
    {
    
    }
    public void HandleClanLevelChanged()
    {
    
    }
    public void HandleLevelSliderChanged()
    {
    
    }
    public void HandleClanLevelSliderChanged()
    {
    
    }
    public void HandleCoinsInputSubmit(UIInput 丗丄下丈丑七丗丞专)
    {
        bool val_1 = 丗丄下丈丑七丗丞专.isActiveAndEnabled;
    }
    public void HandleEnemyCountInSurvivalWaveInput(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    public void HandleEnemiesInCampaignChange()
    {
    
    }
    public void HandleDayChange(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    public void HandleDaySubmit(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    public void HandleEnemiesInCampaignInput(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    public void HandleTrainingCompleteChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleStrongDeviceChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleSet60FpsChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleMouseControlChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleSpectatorMode(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleTempGunChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleIpadMiniRetinaChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleWebSocketGuiChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleDebugConsoleChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleDontShowConsoleAndSocketNgui(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleWebSocketConsoleLogsChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleAutomaticallyShownBanners(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleUseTestHttpAuthorizationUrlChanged(UIToggle 丒世丅业丝东下与丗, UILabel 三丕业丄丂丈不丗丗, UILabel 丈丕丈不丕一丒且三)
    {
    
    }
    public void HandleIsPayingChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleIsolatedProtocol(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    private void 丛丏一丌丁不三丑与(UIInput 丑丄一丆丂且丙与丈, bool 丒丑且丙不丆一丞万)
    {
    
    }
    public void HandleProtocolInputSubmit(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    public void HandleProtocolInputChanged(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    public void HandleLocalPhoton(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleIsDebugGuiVisibleChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleIsFpsVisibleChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleServerTimeChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleAreLogsEnabledChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleIsBAlanceSyncedMarch2018Changed(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleIsEditorCloudChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleIsPixelGunLowChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void U_CompetitionAddPlayers()
    {
    
    }
    public void HandleNDTCT(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleForcedEventX3Changed(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleAdIdCanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    internal static void 不业与丁丗一丐丌丂(bool 丆丅丟丞上丈丂上上, bool 丂丒上且丘专丒丆丑 = True)
    {
    
    }
    public void HandleAllPets()
    {
    
    }
    public void HandleAllModuleChests()
    {
    
    }
    public void HandleAllModules()
    {
    
    }
    public void HandleAllMaxModules()
    {
    
    }
    public void RemoveAllBuffs()
    {
    
    }
    public void DevCollectTribute()
    {
    
    }
    internal static void 丗丌丂丐丞丝丂七丅()
    {
    
    }
    internal static void 万丟丐丘东丑三丙丆()
    {
    
    }
    internal static void 世丅丂不丈一不丏丄()
    {
    
    }
    public void HandleAllAchievements()
    {
    
    }
    public void HandleFillGunsButton()
    {
    
    }
    public void HandleClearPurchasesButton()
    {
    
    }
    public void HandleClearProgressButton()
    {
    
    }
    public void HandleFillProgressButton()
    {
    
    }
    internal static void 丗丁丁丒丄丑丒丗丛()
    {
    
    }
    public void FillCampaignProgressCoreInBox1()
    {
    
    }
    public void FillCampaignProgressCoreInBox2()
    {
    
    }
    public void FillCampaignProgressCoreInBox3()
    {
    
    }
    public void FillCampaignProgressCoreInBox4()
    {
    
    }
    internal static void 丁丏丙东不丒丗丏三(int 且丟且东专丏丝丛丝)
    {
    
    }
    public void HandleClearCloud()
    {
    
    }
    public void HandleBanUs(UIButton 丅不丁丒七丞专丐万)
    {
        丆丒东丁丝丙世丟丏.一丕丄丒丌丅丁业不(丁丂丕与丁丒丕丟丞:  "Ban from dev console");
    }
    public void HandleClearX3()
    {
    
    }
    public void HandleLeagueCnangeBtns(int 丟专丅丏专丒丐丘七)
    {
    
    }
    public void HandleRatingCnangeBtns(int 丟专丅丏专丒丐丘七)
    {
    
    }
    private void 丘万丏世丆丘专丞丐(bool 上丞丕专丈业丁世专)
    {
    
    }
    private void 专业不丙丝丘丆丄丌(bool 上丞丕专丈业丁世专)
    {
    
    }
    private void 丙丅丘万丑丑丏世丛()
    {
    
    }
    private void 世丟一上下丟世一上(int 丟专丅丏专丒丐丘七)
    {
    
    }
    private void 丂三专丈上丕丝业丄()
    {
    
    }
    private void 万丁与与下世丞丝上()
    {
    
    }
    private void 七丈丈七与上上不丆()
    {
    
    }
    private void 丐丄丘丕丏丗丗丟业()
    {
    
    }
    private void 丙且专万七丈丟丏丌()
    {
    
    }
    public void HandleExperienceSliderChanged()
    {
    
    }
    public void HandleAddExperienceButton()
    {
    
    }
    public void HandleReduceExperienceButton()
    {
    
    }
    public void HandleClanExperienceSliderChanged()
    {
    
    }
    public void HandleLeagueSliderChanged()
    {
    
    }
    public void HandleRatingSliderChanged()
    {
    
    }
    public void OnBatteryLevelNotificationThresholdSliderChanged()
    {
    
    }
    private void 丂上丅丌丈且专丁丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
    
    }
    private void 三下世七世丒丄且丑()
    {
    
    }
    private static string 三上丛丏丁丝下丟丐(PGCompany.BatteryWatcher 专下丄且丈丏且丐丙)
    {
        int val_3;
        object val_18;
        PGCompany.丌丛万丅丕丞业丌丄 val_1 = 专下丄且丈丏且丐丙.丘业世下丞丆东下业();
        decimal val_5 = 专下丄且丈丏且丐丙.一丛丟丂丆丄业七丝();
        decimal val_6 = System.Decimal.op_Multiply(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
        if(val_3.丙东专丂世丈丏丁丂() == 1)
        {
                val_3 = 0;
            decimal val_9 = System.Decimal.op_Implicit(value:  1020854432);
            decimal val_10 = System.Decimal.op_Implicit(value:  1020854432);
            decimal val_11 = System.Decimal.Divide(d1:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid}, d2:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid});
            decimal val_12 = System.Decimal.op_Multiply(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid});
            val_18 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0:f2}%", arg0:  val_12);
        }
        else
        {
                val_18 = val_3.丙东专丂世丈丏丁丂().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        
        val_3 = val_6.flags;
        return (string)System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "Battery threshold: {0:f0}% (current: {1}, {2})", arg0:  val_6, arg1:  val_18, arg2:  专下丄且丈丏且丐丙.丘七七丛与丕丅丑丟());
    }
    public void HandleSignInOuButton(UILabel 丝下万世丁世丅业三)
    {
    
    }
    public void SetMarathonTestMode(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void SetOffGameGUIMode(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void ClearStarterPackData()
    {
    
    }
    private void 业不不且丐且与不与()
    {
    
    }
    private void Awake()
    {
        null = null;
        DeveloperConsoleController.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        null = null;
        DeveloperConsoleController.丄丘七三上丕世丞业 = 0;
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new DeveloperConsoleController.丂与丞东丆丕丆丞专();
    }
    public void ChangePremiumAccountLiveTime(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    public void ClearAllPremiumAccounts()
    {
    
    }
    public void ClearCurrentPremiumAccont()
    {
    
    }
    public void HandleTicketsInputSubmit(UIInput 丗丄下丈丑七丗丞专)
    {
        bool val_1 = 丗丄下丈丑七丗丞专.isActiveAndEnabled;
    }
    public void HandleEventInputSubmit(UIInput 丗丄下丈丑七丗丞专)
    {
        bool val_1 = 丗丄下丈丑七丗丞专.isActiveAndEnabled;
    }
    public void BPReset()
    {
    
    }
    public void BPSeasonEnd()
    {
    
    }
    public void BPAddLevel()
    {
    
    }
    public void BPAddExp()
    {
    
    }
    public void BPCompleteChallenge()
    {
    
    }
    public void AddItem()
    {
    
    }
    public void AddFreeSpinForCurrentEvent(string 东业世丕与丛丞丈丒)
    {
    
    }
    public void HandleGemsInputSubmit(UIInput 丗丄下丈丑七丗丞专)
    {
        bool val_1 = 丗丄下丈丑七丗丞专.isActiveAndEnabled;
    }
    public void HandleSilverInputSubmit(UIInput 丗丄下丈丑七丗丞专)
    {
        bool val_1 = 丗丄下丈丑七丗丞专.isActiveAndEnabled;
    }
    private string 丐万丞三丑丗且丘丄()
    {
        return "";
    }
    internal static void 丄与丞丏不丑丞丁上(bool 丏业丟一东丂东丘丛)
    {
    
    }
    private void Update()
    {
    
    }
    private void 且丄丝丑丏丟不丂丒()
    {
    
    }
    private bool 丅丈丛丙业专一东丈(UIInput 丗丄下丈丑七丗丞专)
    {
        return false;
    }
    private void 丐丌丌丗丌丈下丒丘(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    private void 丑丘万下世丄丁丏丈()
    {
        null = null;
        if(DeveloperConsoleController.七丝丕丅与且丘业万 == null)
        {
                return;
        }
        
        DeveloperConsoleController.七丝丕丅与且丘业万.Invoke();
    }
    private void OnEnable()
    {
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
        }
        
        this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void DeveloperConsoleController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "DevConsole");
        this.almanacDevUiToggle.value = false;
    }
    private void OnDisable()
    {
        PGCompany.AdaptiveAutoAimController.上丑丐七与三丟与丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DeveloperConsoleController::丌丗丝丏丁世丙丝丆()));
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        this.且丂七丑丈丞丈三丑 = 0;
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        this.丅丝丁丑且丁下丆丄 = true;
    }
    public void OnChangeReviewActive()
    {
    
    }
    public void OnClickSystemBuff()
    {
    
    }
    public void OnClickRating()
    {
    
    }
    public void FillAll()
    {
    
    }
    public static void SetWeaponsForRaids()
    {
    
    }
    internal static void 七七丙与东且丏上丌()
    {
    
    }
    public void TournamentWinTop()
    {
    
    }
    public void TournamentWinMiddle()
    {
    
    }
    public void TournamentWinBottom()
    {
    
    }
    public void GetAllLobbyItems()
    {
    
    }
    internal static void 丁丘丟丛丙丒丟丈丕()
    {
    
    }
    public void ClearLobbyItems()
    {
    
    }
    public void OnClanTimeRestrictionsChanged(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleAppVersionChanged(UIInput 丗丄下丈丑七丗丞专)
    {
    
    }
    private void 上丕丝丈三丝丕丛丐()
    {
    
    }
    private void 七丘丗丄丆丆丐三丄()
    {
    
    }
    private void 与专不且三丁丗丗丕()
    {
    
    }
    public void U_HandleBreakIdBinding()
    {
        string val_7;
        丅丛丟上丁丆上丛专.不且万丒丑丌丛丒且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DeveloperConsoleController::上丕丝丈三丝丕丛丐()));
        丅丛丟上丁丆上丛专.丅丙丆世丐丗不下三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DeveloperConsoleController::上丕丝丈三丝丕丛丐()));
        上丆与下丌丅丅丈丙 val_3 = 丅丛丟上丁丆上丛专.下丂且丕与世丄丝万();
        if(val_3 == null)
        {
            goto label_4;
        }
        
        丙与不与七丌丟上东 val_5 = System.Linq.Enumerable.FirstOrDefault<丙与不与七丌丟上东>(source:  val_3.世专七与丈不丛丙丏());
        if(val_5 == null)
        {
            goto label_4;
        }
        
        val_7 = val_5.丞丈业东专丅丆与七();
        goto label_5;
        label_4:
        val_7 = 0;
        label_5:
        丅丛丟上丁丆上丛专.丌丅东三丑与丂下丟(业上上丏丄不上丅丈:  val_7, 丈丒丑上丗丘专丑一:  0);
    }
    public void U_HandleBreakGcBinding()
    {
        丅丛丟上丁丆上丛专.不且万丒丑丌丛丒且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DeveloperConsoleController::上丕丝丈三丝丕丛丐()));
        丅丛丟上丁丆上丛专.丅丙丆世丐丗不下三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DeveloperConsoleController::上丕丝丈三丝丕丛丐()));
        丅丛丟上丁丆上丛专.丌丅东三丑与丂下丟(业上上丏丄不上丅丈:  0, 丈丒丑上丗丘专丑一:  丅丛丟上丁丆上丛专.业丟不七丄且不东下());
    }
    public void HandleGetEggs()
    {
    
    }
    private void OnApplicationQuit()
    {
        Rilisoft.KeychainCleaner.丑东三东且下丙与丄();
    }
    internal static bool 丙丒丛一丞下三且一()
    {
        return false;
    }
    public void U_AlmanahcDevUi_OnValueChange()
    {
        var val_3 = null;
        DeveloperConsoleController.丗且七丙与丐丈丑丆 = this.almanacDevUiToggle.value;
    }
    internal static bool 七丅丄下丙丙丘七世()
    {
        return false;
    }
    public void U_AdaptiveAutoAimToggle()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        丌丝世丞世丛丆丅丟.万丈丛丞丕业丙东丄(下上丐丆丝丟丝丒不:  PGCompany.AdaptiveAutoAimController.丅丂与丟上丏丆丆不, 下下丏一丙不丘丌丞:  this.adaptiveAutoAimToggle.value, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        bool val_3 = this.view.adaptiveAutoAimKillRateInput.isActiveAndEnabled;
        bool val_4 = this.view.adaptiveAutoAimTimeLeftInput.isActiveAndEnabled;
        val_6 = null;
        val_6 = null;
        if(DeveloperConsoleController.丗丘丏专与一与万丅 == null)
        {
                return;
        }
        
        DeveloperConsoleController.丗丘丏专与一与万丅.Invoke();
    }
    public void HandleAdaptiveAutoAimKillRate(UIInput 丗丄下丈丑七丗丞专)
    {
        bool val_1 = 丗丄下丈丑七丗丞专.isActiveAndEnabled;
    }
    public void HandleAdaptiveAutoAimTimeLeft(UIInput 丗丄下丈丑七丗丞专)
    {
        bool val_1 = 丗丄下丈丑七丗丞专.isActiveAndEnabled;
    }
    private void 丌丗丝丏丁世丙丝丆()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.adaptiveAutoAimLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "paymentGroup={0} killRateGroup={1}", arg0:  PGCompany.AdaptiveAutoAimController.丑七不且上丗丁一世().且专世丈三丝业一一(), arg1:  PGCompany.AdaptiveAutoAimController.丑七不且上丗丁一世().丅丙三丘丗丗世丙东()));
    }
    private void 万三丞丒一且一丐七()
    {
    
    }
    public void U_HandleGaftToggleClick(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public DeveloperConsoleController()
    {
    
    }
    private static DeveloperConsoleController()
    {
    
    }

}
