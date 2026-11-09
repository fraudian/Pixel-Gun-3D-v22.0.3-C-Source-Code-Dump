using UnityEngine;

namespace Rilisoft
{
    public class ClansLobbyGui : PGBehaviour
    {
        // Fields
        internal static System.DateTime 丁丛东业丕丈丕丆东;
        internal static bool 丝万丈丕一丝丙丌丘;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UnityEngine.GameObject _smilesBanner;
        private UnityEngine.GameObject _bankHolder;
        private UnityEngine.Transform[] _bottomButtons;
        private Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.MonoBehaviour> 一三丆丂下一专上丈;
        private bool 丙丐丄丛东七丑万丙;
        private bool 丕丏且丁丅不丗三世;
        private bool 与业上丈丝世丏丄丈;
        private Rilisoft.ClansLobbyGui.丄丌丈不丒且丈丒丈 丑丒上业丈不七丕丐;
        private UnityEngine.GameObject _mainView;
        private UnityEngine.GameObject _newItemsNotifier;
        private UnityEngine.GameObject _serverAwaiter;
        private UnityEngine.Transform[] _separatorsButtons;
        private UnityEngine.GameObject siegeParty;
        private UITexture divisionTexture;
        private UnityEngine.GameObject fewWarScoresContainer;
        private UnityEngine.GameObject promotingContainer;
        private UITexture[] clanLogos;
        private UIButton btnEdit;
        private UIButton btnFort;
        private UIButton btnMyClan;
        private UIButton btnChat;
        private UnityEngine.GameObject btnRequetsGO;
        private ConnectionControl 丙不丅丝丙专丕世丐;
        private UnityEngine.GameObject 丗上丏丟丆专与丗丆;
        private DialogWindowController 丐东上丈上一东丏与;
        private DialogWindowController 三丙一丘丄丂丙丛丐;
        private UILabel labelOnline;
        private UILabel timeLeftLabel;
        private UILabel clanCapacityLabel;
        private UILabel leaderMessageLabel;
        private UILabel[] clanNameLabel;
        public UnityEngine.AudioClip craftButtonSound;
        public UnityEngine.AudioClip findButtonSound;
        public UnityEngine.AudioClip leadersButtonSound;
        public UnityEngine.AudioClip siegeButtonSound;
        public UnityEngine.AudioClip storageButtonSound;
        private UIButton medalButton;
        private UIButton[] logoButtons;
        private PGCompany.TimerUI timerUntilWarEnd;
        private UIInput leaderMessageInput;
        private ClansLobbyMemberView lobbyMemberViewPrefab;
        private UnityEngine.GameObject _membersGrid;
        private UnityEngine.GameObject _membersScroll;
        private Rilisoft.ClanMembersHeaderView _headerView;
        private UnityEngine.GameObject _clanWarPendingContainer;
        private UnityEngine.GameObject _clanWarOffContainer;
        private UnityEngine.GameObject _clanWarContainer;
        private UnityEngine.GameObject _clanWarNewVersionWorkInProgressContainer;
        private UnityEngine.GameObject _clanWarNewVersionAvailablePleaseUpdateContainer;
        private UnityEngine.GameObject _clanWarRegCloseButton;
        private UnityEngine.GameObject _clanWarNewVersionWorkInProgressButton;
        private UnityEngine.GameObject _clanWarNewVersionAvailablePleaseUpdateButton;
        private PGCompany.TimerUI _clanWarRegCloseButtonTimer;
        private UnityEngine.GameObject _clanWarRegButton;
        private PGCompany.TimerUI _clanWarRegButtonTimer;
        private UnityEngine.GameObject _clanWarRegisteredButton;
        private PGCompany.TimerUI _clanWarRegisteredButtonTimer;
        private UnityEngine.GameObject _clanWarWaitingOpponents;
        private UnityEngine.GameObject _clanWarEndedByTime;
        private UnityEngine.GameObject _clanWarOpenButton;
        private UnityEngine.GameObject _clanWarDevToggleRegSettings;
        private UnityEngine.GameObject _clanWarDevMarkRegSettings;
        private UnityEngine.GameObject _devPanelSettings;
        private UILabel _clanWarRegLabel;
        private PGCompany.ClanWarWindowRegDone _clanWarWindowRegDone;
        private PGCompany.ClanWarRegistration _buyClanWarReg;
        private PGCompany.ClanWarWindowRegError _smallClanForClanWarReg;
        private PGCompany.ClanWarWindowRegError _clanWarWindowRegError;
        private UnityEngine.GameObject craftBtnNotifContainer;
        private UILabel craftBtnNotifLabel;
        private UnityEngine.GameObject craftFortBtnNotifContainer;
        private UILabel craftFortBtnNotifLabel;
        private UnityEngine.GameObject craftTankBtnNotifContainer;
        private UILabel craftTankBtnNotifLabel;
        private UnityEngine.GameObject _newClanСraftWeaponAndGadgetContainer;
        private UILabel _newClanСraftWeaponAndGadgetCountLabel;
        internal GoblinAutoCollectorUi GoblinAutoCollectorUi;
        private UnityEngine.GameObject 下且丄丆丑丗丈一丙;
        private UnityEngine.GameObject 丆丐丗丒丄七且世丅;
        private UnityEngine.GameObject 丒下丂丗万丄业与且;
        private static Rilisoft.ClansLobbyGui <不丁丄七丛不丆丁丕>k__BackingField;
        public UnityEngine.GameObject selectBuilderUI;
        public UnityEngine.Transform clanWarInfoHolder;
        
        // Properties
        internal static Rilisoft.ClansLobbyGui 丆丕丝丒不丙且丐丗 { get; set; }
        internal static bool 下丐丙专丕丙丗万丕 { get; }
        internal static bool 世七下丑丝不丐七与 { get; }
        internal static bool 丟世业丒七丅丒丐丄 { get; }
        public bool 丑丕与上一丙一世丒 { get; }
        public static bool 丈丁下且且丅丙业丑 { get; }
        
        // Methods
        private ClansLobbyGui()
        {
            this.一三丆丂下一专上丈 = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.MonoBehaviour>(丙丂丌且丌世丒丐三:  new System.Func<UnityEngine.MonoBehaviour>(object:  this, method:  UnityEngine.MonoBehaviour Rilisoft.ClansLobbyGui::丝七东丘丑丑下丒丒()));
        }
        internal static Rilisoft.ClansLobbyGui 丑七不且上丗丁一世()
        {
            return (Rilisoft.ClansLobbyGui)Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.ClansLobbyGui 丙业与丙丗丝不丈东)
        {
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丛世丛与丌不丈丐丐()
        {
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_2 = Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.gameObject;
            if(val_2 != null)
            {
                    return val_2.activeInHierarchy;
            }
            
            return val_2.activeInHierarchy;
        }
        internal static bool 丑丂丂丈丐丌丏七丐()
        {
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_3 = 世三丞丅丑丌丈丈一().gameObject;
            if(val_3 != null)
            {
                    return val_3.activeInHierarchy;
            }
            
            return val_3.activeInHierarchy;
        }
        internal static bool 丛丞丒丌丑三丝丑丈()
        {
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return false;
            }
            
            if(null != 0)
            {
                    return activeInHierarchy;
            }
            
            return activeInHierarchy;
        }
        public bool get_showConnectLoading()
        {
            if(this.丙不丅丝丙专丕世丐 != null)
            {
                    return (bool)this.丙不丅丝丙专丕世丐.canShowStubLoading;
            }
            
            return (bool)this.丙不丅丝丙专丕世丐.canShowStubLoading;
        }
        internal void 不万三丗丗不丌世丘()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanWarWindowRegDone, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanWarWindowRegError, 丏业丟一东丂东丘丛:  false);
        }
        public static bool get_OpenChestProcessing()
        {
            return false;
        }
        private void Awake()
        {
            UnityEngine.GameObject val_15;
            var val_16;
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField = this;
            UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "ConnectPanel");
            if(val_1 != null)
            {
                    val_1 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_15);
            this.丗上丏丟丆专与丗丆 = val_2;
            val_2.transform.SetParent(parent:  this.丌丟丄业且三丛丕丄(), worldPositionStays:  false);
            this.丗上丏丟丆专与丗丆.SetActive(value:  false);
            ConnectionControl val_6 = this.gameObject.AddComponent<ConnectionControl>();
            this.丙不丅丝丙专丕世丐 = val_6;
            val_6.SetConnectPanel(丛丘下丗业丂一且业:  this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>());
            val_16 = null;
            val_16 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.clanLobbyConnectionControl = this.丙不丅丝丙专丕世丐;
            ClanChatController val_9 = this.一三丆丂下一专上丈.世三丞丅丑丌丈丈一().GetComponent<ClanChatController>();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.一三丆丂下一专上丈.世三丞丅丑丌丈丈一(), 丏业丟一东丂东丘丛:  false);
            UnityEngine.Transform val_12 = this.transform;
            ClansTutorialController.Instance.丐业一三专世丁丏世(业丝丛且丛专丝业丁:  2, 丈东丘丏与丌东东下:  val_12);
            ClansTutorialController.Instance.丐业一三专世丁丏世(业丝丛且丛专丝业丁:  1, 丈东丘丏与丌东东下:  val_12.transform);
            ClansWindowGUI.丆丂丐丈丈三丛丂世 = false;
        }
        private void OnDestroy()
        {
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        public void ShowLeaders()
        {
            if((Rilisoft.Singleton<ClansVisitController>.Instance) != 0)
            {
                    ClansVisitController val_3 = Rilisoft.Singleton<ClansVisitController>.Instance;
                val_3.丈万丂丘丂下丒丌七 = 2;
            }
            
            LeaderboardsClans.丌万丗与七丄丕不丁(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丂丁专丏专三且丕东()));
            ClanLobbyItemController.丄丘七三上丕世丞业.HideClanLobbyItems();
            this.gameObject.SetActive(value:  false);
        }
        private void OnEnable()
        {
            this.与业上丈丝世丏丄丈 = false;
            if(this.丐东上丈上一东丏与 != 0)
            {
                    this.丐东上丈上一东丏与.CloseWindow();
            }
            
            if(this.三丙一丘丄丂丙丛丐 != 0)
            {
                    this.三丙一丘丄丂丙丛丐.CloseWindow();
            }
            
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::U_BackRequest()), 与且专丈不万东一万:  "ClanLobby");
            if(this._newItemsNotifier != 0)
            {
                    this._newItemsNotifier.SetActive(value:  false);
            }
            
            ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::UpdateMembersScroll()));
            ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::专丑万下万专丗丏丐()));
            ClansController.东丅上丝丁业丑丒丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丛丈丒万丙丗七丐丗()));
            ClansController.丕丅丟丘丝不下丑丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丛丈丒万丙丗七丐丗()));
            PGCompany.Clans.Network.丈万丂丌一丅下丐丂.世丕丝三与丄丄丑三(丙业与丙丗丝不丈东:  new System.Action<专世一东业丛丞且丗>(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::世丅丌一丂丑东丕七(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)));
            丐丌不丏东丟丕七丟.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::UpdateMembersScroll()));
            PGCompany.ClanWarProgressController.三丘丗丞丈丈三丛丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::东丙丅丘丙世且上丝()));
            PGCompany.ClanWarProgressController.丐三且丝丒丄丑丙丟(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丂丘丞丂丏七丁丄不::一丑且上丑丙丁丄丟()));
            PGCompany.ClanWarProgressController.三丘丗丞丈丈三丛丞(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丂丘丞丂丏七丁丄不::丄丝专与与丈一丞业()));
            PGCompany.ClanWarProgressController.三丘丗丞丈丈三丛丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丟丌丟丑丞丗下丗丄()));
            PGCompany.ClanWarController.丙业丛丝世丅丏丈丗(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丐丁七一丒三东万丌::且一不专丆不专专丙()));
            PGCompany.ClanWarEndUI.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丐丁七一丒三东万丌::且一不专丆不专专丙()));
            ClanChangeRegionBannerController.三丂东丑上丅丞东丞(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丈下与丂丘丅丐与东(string 万且万且丑丗且丌丆)));
            ClanSetMinimumRankBannerController.万丛丒世丈上丕丏丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::东丌业丆且与东万与()));
            this.丌万丗与七丄丕不丁();
            this.丒且丕三世且丅三不();
        }
        private void 东丌业丆且与东万与()
        {
            this.HandleOnEditClicked(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  0);
        }
        private void 丈下与丂丘丅丐与东(string 万且万且丑丗且丌丆)
        {
            PGCompany.不东丏三丞丞东丕丙.丐丒丑丗丛三不丒三(上丏万丕丆七不与万:  万且万且丑丗且丌丆);
            PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丁丌一丄三业丗东丘().丟丈世与丌丝丒业七(专丐下丙丐七丑丑丂:  0, 下丂丏丘丈不丘丙丞:  0, 丘业丘不丝一丁丄丙:  0, 下丞业丂丂丟且丘丆:  new System.Nullable<丏丆丘丌且丒丏丄丏>() {HasValue = false}, 一丟丛丆丛业丗丘丆:  new System.Nullable<System.Int32>() {HasValue = false}, 丟丟不丌丄丟丈丂丙:  0, 一东丐一东丄一万丙:  万且万且丑丗且丌丆, 万丂不丁丟丄世专下:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        private void 丒且丕三世且丅三不()
        {
            object val_5;
            if(PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世() != null)
            {
                    val_5 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丄丐下丘专三一专丈();
            }
            else
            {
                    val_5 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newClanСraftWeaponAndGadgetContainer, 丏业丟一东丂东丘丛:  (val_5 > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._newClanСraftWeaponAndGadgetCountLabel, 丕丗丘丑丛与丑业丒:  val_5);
        }
        private void 世丅丌一丂丑东丕七(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)
        {
            this.UpdateMembersScroll();
        }
        private void OnDisable()
        {
            var val_36;
            var val_37;
            var val_40;
            ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::UpdateMembersScroll()));
            ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::专丑万下万专丗丏丐()));
            System.Action val_3 = null;
            val_36 = 1152921542399974656;
            val_3 = new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丛丈丒万丙丗七丐丗());
            ClansController.三丌丁丑丁丕丟东丙(丙业与丙丗丝不丈东:  val_3);
            ClansController.东丏丘丞上丅丟丙不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丛丈丒万丙丗七丐丗()));
            PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丛丌丌丁丑丘丛丈业(丙业与丙丗丝不丈东:  new System.Action<专世一东业丛丞且丗>(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::世丅丌一丂丑东丕七(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)));
            丐丌不丏东丟丕七丟.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::UpdateMembersScroll()));
            PGCompany.ClanWarProgressController.丆且且丄与业世业丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::东丙丅丘丙世且上丝()));
            PGCompany.ClanWarProgressController.业万不丁丞丆一丏丆(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丂丘丞丂丏七丁丄不::一丑且上丑丙丁丄丟()));
            PGCompany.ClanWarProgressController.丆且且丄与业世业丟(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丂丘丞丂丏七丁丄不::丄丝专与与丈一丞业()));
            PGCompany.ClanWarProgressController.丆且且丄与业世业丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丟丌丟丑丞丗下丗丄()));
            PGCompany.ClanWarController.东丝丞丘一丂丆丘七(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丐丁七一丒三东万丌::且一不专丆不专专丙()));
            PGCompany.ClanWarEndUI.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void PGCompany.丐丁七一丒三东万丌::且一不专丆不专专丙()));
            ClanChangeRegionBannerController.丁丟且丅丁世世丄丏(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丈下与丂丘丅丐与东(string 万且万且丑丗且丌丆)));
            ClanSetMinimumRankBannerController.丁丏七七丌一丙一丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::东丌业丆且与东万与()));
            val_37 = 1152921504848912384;
            if(((CraftLobbyPlacePoints.instance == 0) || ((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) == 0)) || ((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) == true))
            {
                goto label_58;
            }
            
            System.Collections.IEnumerator val_23 = CraftLobbyPlacePoints.instance.transform.GetEnumerator();
            goto label_31;
            label_38:
            var val_38 = 0;
            val_38 = val_38 + 1;
            object val_25 = val_23.Current;
            if((System.String.op_Equality(a:  0.name, b:  "skybox")) != true)
            {
                    if((System.String.op_Equality(a:  0.name, b:  "background_1")) != true)
            {
                    if((System.String.op_Equality(a:  0.name, b:  "background_2")) == false)
            {
                goto label_31;
            }
            
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  0, 丏业丟一东丂东丘丛:  true);
            label_31:
            var val_39 = 0;
            val_39 = val_39 + 1;
            if(val_23.MoveNext() == true)
            {
                goto label_38;
            }
            
            val_40 = 0;
            val_37 = 0;
            val_36 = 1152921504621703168;
            if(val_23 != null)
            {
                    var val_40 = 0;
                val_40 = val_40 + 1;
                val_23.Dispose();
            }
            
            label_58:
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_41 = 0;
            val_41 = val_41 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        private void Start()
        {
            var val_27;
            System.Func<UnityEngine.GameObject, System.Boolean> val_29;
            val_27 = null;
            val_27 = null;
            val_29 = ClansLobbyGui.<>c.<>9__109_0;
            if(val_29 == null)
            {
                    System.Func<UnityEngine.GameObject, System.Boolean> val_2 = null;
                val_29 = val_2;
                val_2 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  ClansLobbyGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClansLobbyGui.<>c::与七东与且丅丛丗丏(UnityEngine.GameObject 丂丈丛下丄专丅与三));
                ClansLobbyGui.<>c.<>9__109_0 = val_29;
            }
            
            UnityEngine.GameObject val_3 = System.Linq.Enumerable.FirstOrDefault<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  this._bankHolder), predicate:  val_2);
            if(val_3 != 0)
            {
                    UIButton val_5 = val_3.GetComponent<UIButton>();
                EventDelegate val_6 = null;
                val_29 = val_6;
                val_6 = new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HandleCoinsShop");
                EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_5.onClick, 丙不不丒丁丄丄与丛:  val_6);
            }
            
            if(this.medalButton != 0)
            {
                    EventDelegate val_8 = null;
                val_29 = val_8;
                val_8 = new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HandleCoinsShop");
                EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.medalButton.onClick, 丙不不丒丁丄丄与丛:  val_8);
            }
            
            if(this.logoButtons != null)
            {
                    System.Action<UIButton> val_9 = null;
                val_29 = val_9;
                val_9 = new System.Action<UIButton>(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丈且丐万与上丌丄丒(UIButton 三丟东丕丄丄下下丑));
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UIButton>(丌丛丏业世丄丞三丌:  this.logoButtons, 七丐丅专且专七三丆:  val_9);
            }
            
            if(this.btnMyClan != 0)
            {
                    Rilisoft.ButtonHandler val_11 = this.btnMyClan.GetComponent<Rilisoft.ButtonHandler>();
                if(val_11 != 0)
            {
                    System.EventHandler val_13 = null;
                val_29 = val_13;
                val_13 = new System.EventHandler(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::HandleOnMyClanClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                val_11.add_Clicked(丙业与丙丗丝不丈东:  val_13);
            }
            
            }
            
            if(this.btnChat != 0)
            {
                    Rilisoft.ButtonHandler val_15 = this.btnChat.GetComponent<Rilisoft.ButtonHandler>();
                if(val_15 != 0)
            {
                    System.EventHandler val_17 = null;
                val_29 = val_17;
                val_17 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::东丛丕丄丑东丂丛且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                val_15.add_Clicked(丙业与丙丗丝不丈东:  val_17);
            }
            
            }
            
            if(this.btnEdit != 0)
            {
                    Rilisoft.ButtonHandler val_19 = this.btnEdit.GetComponent<Rilisoft.ButtonHandler>();
                if(val_19 != 0)
            {
                    System.EventHandler val_21 = null;
                val_29 = val_21;
                val_21 = new System.EventHandler(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::HandleOnEditClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                val_19.add_Clicked(丙业与丙丗丝不丈东:  val_21);
            }
            
            }
            
            if(this.btnFort != 0)
            {
                    Rilisoft.ButtonHandler val_23 = this.btnFort.GetComponent<Rilisoft.ButtonHandler>();
                if(val_23 != 0)
            {
                    System.EventHandler val_25 = null;
                val_29 = val_25;
                val_25 = new System.EventHandler(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::HandleOnFortClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                val_23.add_Clicked(丙业与丙丗丝不丈东:  val_25);
            }
            
            }
            
            丄三万丑丑东且丁丙.丑七不且上丗丁一世().下上丂丆丌一东丏东();
        }
        private void 东丛丕丄丑东丂丛且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.一三丆丂下一专上丈.世三丞丅丑丌丈丈一(), 丏业丟一东丂东丘丛:  true);
            if((Rilisoft.Singleton<NotificationMessageController>.Instance) == 0)
            {
                    return;
            }
            
            Rilisoft.Singleton<NotificationMessageController>.Instance.丘丐丗丕丕丕丝丅上(丁丅丈丌丟世丗丗丟:  1, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = false, isViewd = false});
        }
        public void HandleOnFortClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_6;
            System.Action val_8;
            var val_9;
            var val_10;
            if(this.与业上丈丝世丏丄丈 != false)
            {
                    return;
            }
            
            this.与业上丈丝世丏丄丈 = true;
            val_6 = null;
            val_6 = null;
            val_8 = ClansLobbyGui.<>c.<>9__111_0;
            if(val_8 == null)
            {
                    System.Action val_1 = null;
                val_8 = val_1;
                val_1 = new System.Action(object:  ClansLobbyGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClansLobbyGui.<>c::不丝丟丝丙丈丝丌专());
                ClansLobbyGui.<>c.<>9__111_0 = val_8;
            }
            
            val_9 = null;
            val_9 = null;
            Rilisoft.Singleton<Rilisoft.FortCraftSceneLoader>.Instance.ToCraftScene(丞丌丐丞丞丘丏专下:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟(), 丆三丑万丂丌世丆丆:  false, 丟不丒万丝与丂上丘:  val_1, 丈东丘丏与丌东东下:  MainMenuController.丄丞丁丈与业上丞丟.gameObject);
            val_10 = null;
            val_10 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.HideInterface();
        }
        public void HandleOnSiegeClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            string val_8;
            var val_9;
            val_8 = this;
            if(this.与业上丈丝世丏丄丈 == true)
            {
                    return;
            }
            
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.siegeButtonSound);
            }
            
            this.CreateClanSquad(丏东丕与丂丞七业丗:  1);
            PGCompany.一丏不三且丆专东东 val_4 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.一丏不三且丆专东东>(且下丕七丙丗丄不七:  2);
            if(val_4 != null)
            {
                    val_9 = val_4.专东丏与万下丑丂丅();
            }
            else
            {
                    val_9 = 0;
            }
            
            val_8 = PGCompany.丂丘丞丂丏七丁丄不.丒不世丌业不一丆丏(丄丝丏上丄丛丘丟丆:  0);
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_8)) == false)
            {
                    return;
            }
            
            PGCompany.一丝丐丕丒丛专七丄.丗丑丅下丘世丆三丄(丟丙丈丄丈丈丙丆三:  val_8);
        }
        public void HandleOnClanWarClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.与业上丈丝世丏丄丈 != false)
            {
                    return;
            }
            
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.siegeButtonSound);
            }
            
            this.CreateClanSquad(丏东丕与丂丞七业丗:  2);
        }
        public void HandleOnClanWarTestModeClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.与业上丈丝世丏丄丈 != false)
            {
                    return;
            }
            
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.siegeButtonSound);
            }
            
            this.CreateClanSquad(丏东丕与丂丞七业丗:  3);
        }
        public void HandleOnChestClicked()
        {
            Rilisoft.Singleton<PGCompany.ClanWarTributeChestController>.Instance.业专三丗丁丕且东世();
        }
        public void CreateClanSquad(丛丗丐世下丛丄丞丟 丏东丕与丂丞七业丗)
        {
            ConnectionControl val_2;
            IntPtr val_4;
            this.丙不丅丝丙专丕世丐.enabled = true;
            if(丏东丕与丂丞七业丗 == 3)
            {
                goto label_2;
            }
            
            if(丏东丕与丂丞七业丗 == 2)
            {
                goto label_3;
            }
            
            if(丏东丕与丂丞七业丗 != 1)
            {
                    return;
            }
            
            val_2 = this.丙不丅丝丙专丕世丐;
            val_4 = 1152921542402435456;
            goto label_6;
            label_2:
            val_2 = this.丙不丅丝丙专丕世丐;
            val_4 = 1152921542402444672;
            goto label_6;
            label_3:
            val_2 = this.丙不丅丝丙专丕世丐;
            System.Action val_1 = null;
            val_4 = 1152921542402453888;
            label_6:
            val_1 = new System.Action(object:  this, method:  val_4);
            val_2.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  val_1, 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  true, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
        }
        private void 丅丌丄上一不丗丅上()
        {
            var val_3;
            this.gameObject.SetActive(value:  false);
            val_3 = null;
            val_3 = null;
            SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::BackFromSquad()), 上且丗一丏丏万丅丌:  17, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  1, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "", 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
        }
        private void 丛丘下丄丈专一与业()
        {
            var val_3;
            this.gameObject.SetActive(value:  false);
            val_3 = null;
            val_3 = null;
            SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::BackFromSquad()), 上且丗一丏丏万丅丌:  100, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  2, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "", 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
        }
        private void 丈丑上业丗丟与三丕()
        {
            var val_3;
            this.gameObject.SetActive(value:  false);
            val_3 = null;
            val_3 = null;
            SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::BackFromSquad()), 上且丗一丏丏万丅丌:  100, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  3, 丟与丏丈丁东丅下丕:  false, 丗不下业上下丆丑丑:  "", 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
        }
        public void CreateClanSquadReturn()
        {
            this.丙不丅丝丙专丕世丐.enabled = true;
            this.丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丟丌丝丕不丅专丄丛()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  true, 丐丝丛丂与专下丝丙:  true, 丅万丁丌一世下丐丑:  true, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
        }
        private void 丟丌丝丕不丅专丄丛()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            this.gameObject.SetActive(value:  false);
            val_6 = null;
            val_6 = null;
            val_7 = null;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  与丂丏丛丞丞丒丟丄.丘且丝万丙丕丙丁丙)) != false)
            {
                    val_8 = null;
                SquadController.丄丘七三上丕世丞业.丛丒万丟专且世且丟(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::BackFromSquad()), 上且丗一丏丏万丅丌:  26, 丌与一丌且一不七丆:  false, 三丛业业专丄丟丄丅:  1, 丟与丏丈丁东丅下丕:  true, 丗不下业上下丆丑丑:  "", 丞丁丑丏丄丏七丂不:  new 丛且丏丑丕丘丒丞且());
                return;
            }
            
            val_9 = null;
            val_10 = null;
            val_10 = null;
            SquadController.丄丘七三上丕世丞业.丘一丕丘丌上丌丂上(丅一丞万丑专丅丅与:  与丂丏丛丞丞丒丟丄.丘且丝万丙丕丙丁丙, 丂七丒丈且东七丅丅:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::丐丏丂丈三丞业丑丁(UnityEngine.Vector2 丙丗丄万丒丏丟丈三)), 丗业万丌三且丙丅上:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::三丄丗三三丐上丞丐(int 丟丟丄专上丟丁丐丝)));
        }
        private void 丐丏丂丈三丞业丑丁(UnityEngine.Vector2 丙丗丄万丒丏丟丈三)
        {
            object val_11;
            SquadController val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = this;
            val_12 = 1152921525544440992;
            DiscreteVector2 val_2 = new DiscreteVector2(丘丑丛丕下丈世下丂:  new UnityEngine.Vector2() {x = 丙丗丄万丒丏丟丈三.x, y = 丙丗丄万丒丏丟丈三.y});
            PGCompany.丁下丒丕丆下丂丆丌 val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丈下丗丐丝丅丑丑(专丘丏丅且丆万东丈:  new DiscreteVector2() {_x = val_2._x, _y = val_2._x});
            if(val_3 == null)
            {
                goto label_2;
            }
            
            val_12 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_12.丁下丆三丏丌丕业丂() == false)
            {
                    return;
            }
            
            val_12 = val_3.下三下东业丘且丟业();
            if(val_12.丈丐丞丐上丑且丕万() == false)
            {
                goto label_6;
            }
            
            val_13 = null;
            val_13 = null;
            val_12 = SquadController.丄丘七三上丕世丞业;
            val_12.七丙一丘丛丒丟丝丗(丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::BackFromSquad()), 丌丝万上丅丒一丈丘:  val_3, 丟与丏丈丁东丅下丕:  true, 丗不下业上下丆丑丑:  "");
            return;
            label_2:
            UnityEngine.Debug.LogError(message:  "Cell with coords " + 丙丗丄万丒丏丟丈三.x + " is NULL");
            val_11 = 1152921505080860672;
            val_14 = null;
            val_14 = null;
            MainMenuController.三丙丌丞东不且丝丞 = true;
            return;
            label_6:
            val_11 = 1152921505080860672;
            val_15 = null;
            val_15 = null;
            MainMenuController.三丙丌丞东不且丝丞 = true;
            bool val_10 = OpenClanWar();
        }
        private void 三丄丗三三丐上丞丐(int 丟丟丄专上丟丁丐丝)
        {
            object val_14;
            var val_15;
            var val_16;
            SquadController val_17;
            System.Action val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_14 = this;
            ClansLobbyGui.万业丙下丈一丛丈丄 val_1 = new ClansLobbyGui.万业丙下丈一丛丈丄();
            val_15 = val_1;
            .丟丟丄专上丟丁丐丝 = 丟丟丄专上丟丁丐丝;
            PGCompany.丟与丞丗丌丂万丕丝 val_5 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丟与丞丗丌丂万丕丝>(source:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丟丛上丅七丂七丛下(), predicate:  new System.Func<PGCompany.丟与丞丗丌丂万丕丝, System.Boolean>(object:  val_1, method:  System.Boolean ClansLobbyGui.万业丙下丈一丛丈丄::丙三丈丅丈世丛与三(PGCompany.丟与丞丗丌丂万丕丝 三丟东丕丄丄下下丑)));
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_15 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_15.丁下丆三丏丌丕业丂() == false)
            {
                    return;
            }
            
            if((val_5 & 1) == 0)
            {
                goto label_6;
            }
            
            PGCompany.丂不上丗与丌与丐丌 val_8 = val_5.不业丙丒丂丞下丆丙();
            if(val_8 == 1)
            {
                goto label_7;
            }
            
            if(val_8 != 2)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            val_17 = SquadController.丄丘七三上丕世丞业;
            System.Action val_9 = null;
            val_18 = val_9;
            val_9 = new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::BackFromSquad());
            val_19 = "";
            val_20 = 27;
            goto label_12;
            label_3:
            UnityEngine.Debug.LogError(message:  "Event with ID " + .丟丟丄专上丟丁丐丝.ToString() + " is NULL or Not Active");
            val_14 = 1152921505080860672;
            val_21 = null;
            val_21 = null;
            MainMenuController.三丙丌丞东不且丝丞 = true;
            return;
            label_6:
            val_22 = null;
            val_22 = null;
            MainMenuController.三丙丌丞东不且丝丞 = true;
            bool val_12 = OpenClanWar();
            return;
            label_7:
            val_23 = null;
            val_23 = null;
            val_17 = SquadController.丄丘七三上丕世丞业;
            System.Action val_13 = null;
            val_18 = val_13;
            val_13 = new System.Action(object:  this, method:  public System.Void Rilisoft.ClansLobbyGui::BackFromSquad());
            val_19 = "";
            val_20 = 26;
            label_12:
            val_17.不丂七上丁丙丗业丁(丛丝与丂世丌丌丝丂:  val_13, 且世上丙与丐一丛业:  val_5, 上且丗一丏丏万丅丌:  26, 丟与丏丈丁东丅下丕:  true, 丗不下业上下丆丑丑:  val_19);
        }
        public void BackFromSquad()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            Rilisoft.ClansLobbyGui.丁丛东业丕丈丕丆东 = val_1.dateData;
            this.gameObject.SetActive(value:  true);
        }
        public void HandleOnMyClanClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.与业上丈丝世丏丄丈 == true)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance) == 0)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return;
            }
            
            this.一丐丕且丝丄上丁丄(丟一专与丟丟丘丝万:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟());
        }
        internal void 一丐丕且丝丄上丁丄(丞丂丘丒丟丞丑下丄 丟一专与丟丟丘丝万)
        {
            var val_9;
            .丝且与丝丒丟万丁专 = this;
            if(丟一专与丟丟丘丝万 == null)
            {
                    return;
            }
            
            if(this.与业上丈丝世丏丄丈 == true)
            {
                    return;
            }
            
            .丞丒业万东专上丒丛 = 0;
            .丞丒业万东专上丒丛 = new System.Action(object:  new ClansLobbyGui.丟丗丁丞万丒下丘三(), method:  System.Void ClansLobbyGui.丟丗丁丞万丒下丘三::丟且不业丗丗丆丐七());
            val_9 = null;
            val_9 = null;
            int val_7 = ClansWindowInfoViewController.与且丂丐万丝丘三下(丕专上丁丅丅丏万丌:  ClansWindowGUI.丆丕丝丒不丙且丐丗.gameObject, 丞丌丐丞丞丘丏专下:  丟一专与丟丟丘丝万, 丘丗不丁丘丒丅丌不:  (ClansLobbyGui.丟丗丁丞万丒下丘三)[1152921542404017984].丞丒业万东专上丒丛, 世丟七丕且丝丅不上:  ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != 丟一专与丟丟丘丝万) ? 1 : 0, 不丆丁且丕丅不丕七:  false);
            this.gameObject.SetActive(value:  false);
        }
        public void HandleOnEditClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.与业上丈丝世丏丄丈 != false)
            {
                    return;
            }
            
            string val_4 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((System.String.op_Equality(a:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丁丏丌丟丂丌一七与(), b:  val_4)) != false)
            {
                    丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
                ClanCreateGui.丌万丗与七丄丕不丁(丂丛丑东不丅丈一东:  1, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::万七丘专不丐不且丝()), 不丘丘丝丅丁且丞丝:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::专丆丒丘丌丟东丐丈()));
                return;
            }
            
            this.HandleOnMyClanClicked(不丟丗丏丛丕不丁丌:  val_4, 丗丛不丁丑专专丂且:  0);
        }
        public void U_AddClick()
        {
            .丝且与丝丒丟万丁专 = this;
            if(this.与业上丈丝世丏丄丈 != false)
            {
                    return;
            }
            
            .丞丒业万东专上丒丛 = 0;
            .丞丒业万东专上丒丛 = new System.Action(object:  new ClansLobbyGui.丗丐东丙丕丈三丝丗(), method:  System.Void ClansLobbyGui.丗丐东丙丕丈三丝丗::下不上丂丕世丅一万());
            int val_8 = ClansInviteGuiController.丅万万不专上丟丑丙(丈东丘丏与丌东东下:  this.gameObject, 丟不丒万丝与丂上丘:  (ClansLobbyGui.丗丐东丙丕丈三丝丗)[1152921542404376128].丞丒业万东专上丒丛, 丂丛丑东不丅丈一东:  (((Rilisoft.Singleton<ClansController>.Instance.丞一不下一丁丞东一(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丕万丐东与一丈万与:  0)) & true) != 0) ? 3 : (0 + 1));
            this.gameObject.SetActive(value:  false);
        }
        public void U_FindClick()
        {
            if(this.与业上丈丝世丏丄丈 != false)
            {
                    return;
            }
            
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.findButtonSound);
            }
            
            ClanSearchGui.丌万丗与七丄丕不丁(丐丅丒专丛丏上与业:  0, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::东一上万业丟丁丕与()));
            this.gameObject.SetActive(value:  false);
        }
        private void 专丑万下万专丗丏丐()
        {
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return;
            }
            
            this.专丑万下万专丗丏丐(且丟丅丄丒丑丂丁世:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟());
        }
        private void 专丑万下万专丗丏丐(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            丞丂丘丒丟丞丑下丄 val_35;
            string val_36;
            丞丂丘丒丟丞丑下丄 val_37;
            丞丂丘丒丟丞丑下丄 val_38;
            var val_39;
            val_35 = 且丟丅丄丒丑丂丁世;
            ClansLobbyGui.丄丘丟专丟且下丑下 val_1 = new ClansLobbyGui.丄丘丟专丟且下丑下();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .且丟丅丄丒丑丂丁世 = val_35;
            if(val_35 == null)
            {
                goto label_2;
            }
            
            label_5:
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_36 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            goto label_9;
            label_1:
            mem[16] = val_35;
            val_37 = mem[16];
            if(val_37 != 0)
            {
                goto label_5;
            }
            
            label_2:
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "LOG: Trying to draw clans lobby with null clan given.");
            return;
            label_3:
            val_38 = .且丟丅丄丒丑丂丁世;
            val_36 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            label_9:
            丌丌丄丂丕丑专万丆 val_5 = val_38.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_36);
            this.上丑丂丆丄丟丞且丂(丕万丐东与一丈万与:  val_36);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.clanNameLabel, 丕丗丘丑丛与丑业丒:  .且丟丅丄丒丑丂丁世.东丙上东业丆不丟丘());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanCapacityLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}/{2}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1477"), arg1:  .且丟丅丄丒丑丂丁世.丙丆丞东丆丏丞一不().Count, arg2:  且丟丅丄丒丑丂丁世.丄丑丙万丌丂一丄丙));
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UITexture>(丌丛丏业世丄丞三丌:  this.clanLogos, 七丐丅专且专七三丆:  new System.Action<UITexture>(object:  val_1, method:  System.Void ClansLobbyGui.丄丘丟专丟且下丑下::不丐丐且丝丞丁丏一(UITexture 三丟东丕丄丄下下丑)));
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.divisionTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "Shields/tournament_shield_{0}", arg0:  .且丟丅丄丒丑丂丁世.世丝丌一且丝专丑丛())));
            丞东丑专丛丆丄丝世.一专丅丗丁一丙东丁(丙一丑丏丁一且丒业:  this.timerUntilWarEnd, 丆丐七丅丆丗丛上与:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丅丙丛万不且一丟(), 三丘丄丕丂丏东不丛:  0);
            val_39 = null;
            val_39 = null;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fewWarScoresContainer, 丏业丟一东丂东丘丛:  (.且丟丅丄丒丑丂丁世.业不且丟丆下丏丌丒() <= BalanceController.丗丛丞下丟与丞丞七) ? 1 : 0);
            this.丕丛专丁七万丝丙丌(且丟丅丄丒丑丂丁世:  .且丟丅丄丒丑丂丁世);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.leaderMessageLabel, 丕丗丘丑丛与丑业丒:  .且丟丅丄丒丑丂丁世.丞业三与丞三丏万丂());
            UnityEngine.Collider val_20 = this.leaderMessageInput.GetComponent<UnityEngine.Collider>();
            if(val_20 != 0)
            {
                    val_20.enabled = Rilisoft.Singleton<ClansController>.Instance.下丑上丌丐丑世丁丕();
            }
            
            val_37 = .且丟丅丄丒丑丂丁世;
            if(val_37.丞万丞七东万上东丗() != false)
            {
                    val_37 = .且丟丅丄丒丑丂丁世;
                if((((this.丕丏且丁丅不丗三世 == true) ? 1 : 0) ^ val_37.丞万丞七东万上东丗()) != false)
            {
                    System.DateTime val_29 = System.DateTime.UtcNow;
                val_37 = val_29.dateData;
                System.DateTime val_30 = AddSeconds(value:  30);
                if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_37}, t2:  new System.DateTime() {dateData = val_30.dateData})) != false)
            {
                    val_37 = InfoWindowController.丑七不且上丗丁一世();
                val_37.下丝丁丂丞下丘东丗();
            }
            
            }
            
            }
            
            this.丕丏且丁丅不丗三世 = .且丟丅丄丒丑丂丁世.丞万丞七东万上东丗();
        }
        private void 丄丐专丞下丄东一丗(int 丗三丏丌丅丛丟上丁)
        {
            this.专丑万下万专丗丏丐();
            this.UpdateMembersScroll();
        }
        internal void 丟业不丂一丒丁丑丝(Rilisoft.ClansLobbyGui.丄丌丈不丒且丈丒丈 丁丅丈丌丟世丗丗丟)
        {
            this.丑丒上业丈不七丕丐 = 丁丅丈丌丟世丗丗丟;
        }
        private void 丌万丗与七丄丕不丁()
        {
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            UnityEngine.Object val_33;
            if(ClanLobbyItemController.丄丘七三上丕世丞业 == 0)
            {
                    UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans/ClanLobbyItemController"));
            }
            
            Rilisoft.Singleton<ClansController>.Instance.上丂一丌丑丘世丑丆(丙业与丙丗丝不丈东:  false);
            this.丕丏且丁丅不丗三世 = false;
            this.丑丒上业丈不七丕丐 = 0;
            Rilisoft.Singleton<ClansController>.Instance.上七丏业下丕丟丞不();
            this.专丑万下万专丗丏丐();
            val_27 = null;
            val_27 = null;
            if(ClanChatController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_28 = null;
                val_28 = null;
                if(ClanChatController.丄丞丁丈与业上丞丟.stickersShopBanner != 0)
            {
                    val_29 = null;
                val_29 = null;
                SetActive(value:  false);
            }
            
                val_30 = null;
                val_30 = null;
                ClanChatController.丄丞丁丈与业上丞丟.东丗上丄且丁专万丗();
            }
            
            val_31 = 0;
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
            {
                    this.UpdateMembersScroll();
                UIWrapContent val_10 = this._membersGrid.GetComponent<UIWrapContent>();
                UIScrollView val_11 = this._membersScroll.GetComponent<UIScrollView>();
                if(val_11 != null)
            {
                    val_11.ResetPosition();
            }
            else
            {
                    val_11.ResetPosition();
            }
            
                val_11.StopMomentumForce();
                PGCompany.丐丁七一丒三东万丌.且一不专丆不专专丙();
                val_31 = 0;
                ClanLobbyItemController.丄丘七三上丕世丞业.ShowClanLobbyItems();
                this.东丙丅丘丙世且上丝();
            }
            
            if(Rilisoft.ClansLobbyGui.丝万丈丕一丝丙丌丘 == false)
            {
                goto label_36;
            }
            
            val_31 = 0;
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.东丛世丟七上丞丕丝()) == false)
            {
                goto label_36;
            }
            
            Rilisoft.ClansLobbyGui.丝万丈丕一丝丙丌丘 = false;
            val_32 = null;
            val_32 = null;
            ClanWarUI.东东丄丅丅丅丙七一 = true;
            bool val_14 = OpenClanWar();
            goto label_39;
            label_36:
            PGCompany.丂丘丞丂丏七丁丄不.一丑且上丑丙丁丄丟();
            label_39:
            System.ValueTuple<PGCompany.丟与丞丗丌丂万丕丝, System.Boolean> val_15 = ClanWarEventBanner.丐专丟丏丑且与东下();
            if((val_31 & 255) == 0)
            {
                goto label_44;
            }
            
            label_54:
            val_33 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_33 == 0)
            {
                    return;
            }
            
            val_33 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丗丕三下上丗专东业();
            if((val_33 | (Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丗丛丗丏丑丏丌丒丆())) == false)
            {
                goto label_50;
            }
            
            return;
            label_44:
            if(((val_15.Item2 == false) || (val_15.Item2 != null)) || (val_15.Item2.丅业东万丌丕上丌丄() == false))
            {
                goto label_54;
            }
            
            string val_25 = val_15.Item2.丂丅丏丘世且丅丗三();
            UnityEngine.Coroutine val_27 = this.StartCoroutine(routine:  val_25.丐丌丅上丟丗丕丕上(丆丘不丌丁丈丆丟丘:  val_25));
            goto label_54;
            label_50:
            NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  7);
        }
        private void 丟丌丟丑丞丗下丗丄()
        {
            null = null;
            if(BalanceController.下七不丙丌一丁专丕.丟丂丞不专丆万丒世() < 1)
            {
                    return;
            }
            
            PGCompany.ClanWarRegistration.七世东丕且丆丅丌丒();
        }
        private void 丘上丐世丆丑且丞丒()
        {
            丙丏丒丐丑三丆丝世 val_13;
            UIWrapContent val_1 = this._membersGrid.GetComponent<UIWrapContent>();
            UIWrapContent.丙丏丒丐丑三丆丝世 val_2 = null;
            val_13 = val_2;
            val_2 = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.ClansLobbyGui::丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
            val_1.onInitializeItem = val_13;
            if(this.lobbyMemberViewPrefab != 0)
            {
                    UIDragScrollView val_4 = this.lobbyMemberViewPrefab.GetComponent<UIDragScrollView>();
                val_4.scrollView = this._membersScroll.GetComponent<UIScrollView>();
                do
            {
                UnityEngine.GameObject val_8 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this._membersGrid.gameObject, 丑且不丕与专丄业丙:  this.lobbyMemberViewPrefab.gameObject);
                val_13 = 0.ToString(format:  "000")(0.ToString(format:  "000")) + "_MemberView";
                if(val_8 != null)
            {
                    val_8.name = val_13;
            }
            else
            {
                    0.name = val_13;
            }
            
                val_8.SetActive(value:  true);
            }
            while(1 <= 9);
            
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "lobbyMemberViewPrefab is null");
            }
            
            UIWrapContent val_11 = this._membersGrid.GetComponent<UIWrapContent>();
            val_11.cullContent = false;
            UIScrollView val_12 = this._membersScroll.GetComponent<UIScrollView>();
            val_12.disableDragIfFits = true;
            this.丙丐丄丛东七丑万丙 = true;
        }
        private void 丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
        {
            ClansLobbyMemberView val_1 = 丝三丁东丈丒世丅业.GetComponent<ClansLobbyMemberView>();
            val_1.wrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
            this.丞丙丞丅丘七丅不世(下丅丙一丂丗丅丝七:  丝三丁东丈丒世丅业.GetComponent<ClansLobbyMemberView>());
        }
        private void 丞丙丞丅丘七丅不世(ClansLobbyMemberView 下丅丙一丂丗丅丝七)
        {
            var val_59;
            var val_60;
            var val_61;
            int val_62;
            与丛丕丝丑丁与丐丝 val_63;
            var val_64;
            bool val_65;
            var val_66;
            var val_67;
            var val_68;
            val_59 = 下丅丙一丂丗丅丝七;
            val_60 = this;
            val_61 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_61 == null)
            {
                    return;
            }
            
            val_62 = 下丅丙一丂丗丅丝七.wrapIndex;
            if(((val_62 & 2147483648) != 0) || (val_62 >= val_61.丙丆丞东丆丏丞一不().Count))
            {
                goto label_6;
            }
            
            与丛丕丝丑丁与丐丝 val_5 = null;
            val_63 = val_5;
            val_5 = new 与丛丕丝丑丁与丐丝();
            val_64 = 1152921536523277200;
            .丞丅上丏丂且下丅与 = val_61.丙丆丞东丆丏丞一不().Item[下丅丙一丂丗丅丝七.wrapIndex].业丐丐三丕一丗丛丁();
            .丄丒下业一不丈丝丘 = val_61.业丐丐三丕一丗丛丁();
            .丁七万丟丆丟不万丗 = System.String.op_Equality(a:  val_61.丙丆丞东丆丏丞一不().Item[下丅丙一丂丗丅丝七.wrapIndex].业丐丐三丕一丗丛丁(), b:  val_61.丁丏丌丟丂丌一七与());
            .丕万丐东与一丈万与 = val_61.丙丆丞东丆丏丞一不().Item[下丅丙一丂丗丅丝七.wrapIndex].丙丐丅丕丗丁丅丁丐();
            if((System.String.op_Equality(a:  (与丛丕丝丑丁与丐丝)[1152921542406470576].丞丅上丏丂且下丅与, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    val_61.丙丆丞东丆丏丞一不().Item[下丅丙一丂丗丅丝七.wrapIndex].丌丏上丏东且丄丑丌(丙业与丙丗丝不丈东:  专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  ProfileController.丆三丂丂丆上丆丕专()));
            }
            
            .丒丘丏上丙丟丑丕丈 = val_61.丙丆丞东丆丏丞一不().Item[下丅丙一丂丗丅丝七.wrapIndex].东丙上东业丆不丟丘();
            if((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  (与丛丕丝丑丁与丐丝)[1152921542406470576].丞丅上丏丂且下丅与)) == false)
            {
                goto label_23;
            }
            
            val_65 = 1;
            goto label_24;
            label_6:
            val_59.UpdateView(丕丝丄三丂三与丑世:  0);
            val_59.gameObject.SetActive(value:  false);
            if(下丅丙一丂丗丅丝七.ContextMenu == 0)
            {
                    return;
            }
            
            val_60 = ???;
            val_59 = ???;
            val_63 = ???;
            val_66 = ???;
            val_64 = ???;
            goto typeof(ContextMenuBase).__il2cppRuntimeField_198;
            label_23:
            val_65 = 丐丌不丏东丟丕七丟.丑七不且上丗丁一世().万丄丘与丒丅丒下世().ContainsKey(key:  val_63 + 32);
            label_24:
            mem2[0] = val_65;
            mem2[0] = val_66.丙丆丞东丆丏丞一不().Item[val_59 + 168].三七丆丑丙丆丘丛丆();
            mem2[0] = val_66.丙丆丞东丆丏丞一不().Item[val_59 + 168].不丕丒丁丈丅丏三丌();
            val_62 = val_66.丙丆丞东丆丏丞一不().Item[val_59 + 168];
            mem2[0] = val_62.丏丐世上东丙七丆丗();
            mem2[0] = val_60 + 116;
            val_67 = val_66.丙丆丞东丆丏丞一不();
            mem2[0] = val_67.Item[val_59 + 168].与丘且丟不丅丏万丆();
            val_59.UpdateView(丕丝丄三丂三与丑世:  val_63);
            if((val_59 + 160) == 0)
            {
                    return;
            }
            
            if((val_59 + 160) != 0)
            {
                    val_68 = null;
                val_68 = null;
                var val_48 = (((val_59 + 160 + 200 + (ClanMemberContextMenu.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_68) ? (val_59 + 160) : 0;
            }
            
            0.Refresh();
        }
        public void UpdateMembersScroll()
        {
            UILabel val_35;
            T val_36;
            System.Collections.Generic.List<七丈丗不丞丈丝丙七> val_37;
            var val_38;
            System.Func<七丈丗不丞丈丝丙七, System.Int32> val_40;
            var val_41;
            var val_43;
            string val_45;
            var val_46;
            System.Func<七丈丗不丞丈丝丙七, System.Boolean> val_48;
            val_35 = this;
            val_36 = 1152921524404748272;
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 == null)
            {
                    return;
            }
            
            if(this.丙丐丄丛东七丑万丙 != true)
            {
                    this.丘上丐世丆丑且丞丒();
            }
            
            丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丌丂丑上七丄一且());
            if(this.丑丒上业丈不七丕丐 == 2)
            {
                goto label_7;
            }
            
            if(this.丑丒上业丈不七丕丐 == 1)
            {
                goto label_8;
            }
            
            if(this.丑丒上业丈不七丕丐 != 0)
            {
                goto label_9;
            }
            
            val_37 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不();
            val_38 = null;
            val_38 = null;
            val_40 = ClansLobbyGui.<>c.<>9__139_0;
            if(val_40 != null)
            {
                goto label_30;
            }
            
            System.Func<七丈丗不丞丈丝丙七, System.Int32> val_10 = null;
            val_40 = val_10;
            val_10 = new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  ClansLobbyGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClansLobbyGui.<>c::世丗丏丙丈丕丛丒东(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
            ClansLobbyGui.<>c.<>9__139_0 = val_40;
            goto label_30;
            label_7:
            val_37 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不();
            val_41 = null;
            val_41 = null;
            val_40 = ClansLobbyGui.<>c.<>9__139_2;
            if(val_40 != null)
            {
                goto label_30;
            }
            
            System.Func<七丈丗不丞丈丝丙七, System.Int32> val_14 = null;
            val_40 = val_14;
            val_14 = new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  ClansLobbyGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClansLobbyGui.<>c::丐万不不丑下丌上一(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
            ClansLobbyGui.<>c.<>9__139_2 = val_40;
            goto label_30;
            label_8:
            val_37 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不();
            val_43 = null;
            val_43 = null;
            val_40 = ClansLobbyGui.<>c.<>9__139_1;
            if(val_40 == null)
            {
                    System.Func<七丈丗不丞丈丝丙七, System.Int32> val_18 = null;
                val_40 = val_18;
                val_18 = new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  ClansLobbyGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClansLobbyGui.<>c::不世丟丁下丅丄丝丂(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
                ClansLobbyGui.<>c.<>9__139_1 = val_40;
            }
            
            label_30:
            Rilisoft.ClansLobbyGui.丙丟丙丆丐东丙专丑(丝丘丑业丛万丞丌丝:  val_37, 丂与万东一三丆下业:  val_18);
            label_9:
            T[] val_19 = this._membersGrid.GetComponentsInChildren<ClansLobbyMemberView>(includeInactive:  true);
            var val_37 = 0;
            label_40:
            if(val_37 >= val_19.Length)
            {
                goto label_35;
            }
            
            val_37 = val_37 + 1;
            if((val_19[0x0][0] + 160) == 0)
            {
                goto label_40;
            }
            
            val_45 = val_19[0].GetClanMember().业丐丐三丕一丗丛丁();
            goto label_42;
            label_35:
            val_45 = 0;
            label_42:
            val_36 = this._membersGrid.GetComponent<UIWrapContent>();
            int val_25 = val_2.丙丆丞东丆丏丞一不().Count;
            if(val_36 != null)
            {
                    int val_38 = 1;
                val_38 = val_38 - val_25;
                val_23.minIndex = val_38;
            }
            else
            {
                    int val_39 = 1;
                val_39 = val_39 - val_25;
                mem[32] = val_39;
            }
            
            if(val_19.Length >= 1)
            {
                    do
            {
                val_36 = val_19[0];
                this.丞丙丞丅丘七丅不世(下丅丙一丂丗丅丝七:  val_36);
                if(((val_19[0x0][0] + 160) != 0) && (((-854689464) & 1) != 0))
            {
                    if(((System.String.op_Inequality(a:  val_45, b:  val_36.GetClanMember().业丐丐三丕一丗丛丁())) != false) && ((val_19[0x0][0] + 168) == (-854689464)))
            {
                    val_36 = mem[val_19[0x0][0] + 160];
                val_36 = val_19[0x0][0] + 160;
            }
            
            }
            
            }
            while((0 + 1) < val_19.Length);
            
            }
            
            val_35 = this.labelOnline;
            val_46 = null;
            val_46 = null;
            val_48 = ClansLobbyGui.<>c.<>9__139_3;
            if(val_48 == null)
            {
                    System.Func<七丈丗不丞丈丝丙七, System.Boolean> val_33 = null;
                val_48 = val_33;
                val_33 = new System.Func<七丈丗不丞丈丝丙七, System.Boolean>(object:  ClansLobbyGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClansLobbyGui.<>c::丌丘不世不丏丝丄三(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
                ClansLobbyGui.<>c.<>9__139_3 = val_48;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_35, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4243"), arg0:  System.Linq.Enumerable.Count<七丈丗不丞丈丝丙七>(source:  val_2.丙丆丞东丆丏丞一不(), predicate:  val_33)));
        }
        internal static void 丙丟丙丆丐东丙专丑(System.Collections.Generic.List<七丈丗不丞丈丝丙七> 丝丘丑业丛万丞丌丝, System.Func<七丈丗不丞丈丝丙七, int> 丂与万东一三丆下业)
        {
            var val_12;
            var val_13;
            七丈丗不丞丈丝丙七 val_14;
            val_13 = 0;
            goto label_1;
            label_11:
            val_12 = 1;
            goto label_2;
            label_9:
            if(丝丘丑业丛万丞丌丝 != null)
            {
                    val_14 = 丝丘丑业丛万丞丌丝.Item[W22];
            }
            else
            {
                    val_14 = 丝丘丑业丛万丞丌丝.Item[W22];
            }
            
            if((Rilisoft.ClansLobbyGui.下丄丆下丁丝丘丏丒(丈丂丕下丏丈丞丗业:  val_14, 丂丌丌丛丆丆丙丌丈:  丝丘丑业丛万丞丌丝.Item[1], 丂与万东一三丆下业:  丂与万东一三丆下业)) > 0)
            {
                    if(丝丘丑业丛万丞丌丝 != null)
            {
                    val_14 = 丝丘丑业丛万丞丌丝.Item[1];
                丝丘丑业丛万丞丌丝.set_Item(index:  1, value:  丝丘丑业丛万丞丌丝.Item[W22]);
            }
            else
            {
                    val_14 = 丝丘丑业丛万丞丌丝.Item[1];
                丝丘丑业丛万丞丌丝.set_Item(index:  1, value:  丝丘丑业丛万丞丌丝.Item[W22]);
            }
            
                丝丘丑业丛万丞丌丝.set_Item(index:  W22, value:  val_14);
            }
            
            val_12 = 2;
            label_2:
            if((val_12 - 1) < (丝丘丑业丛万丞丌丝.Count - 1))
            {
                goto label_9;
            }
            
            val_13 = 1;
            label_1:
            if(val_13 < 丝丘丑业丛万丞丌丝.Count)
            {
                goto label_11;
            }
        
        }
        internal static int 下丄丆下丁丝丘丏丒(七丈丗不丞丈丝丙七 丈丂丕下丏丈丞丗业, 七丈丗不丞丈丝丙七 丂丌丌丛丆丆丙丌丈, System.Func<七丈丗不丞丈丝丙七, int> 丂与万东一三丆下业)
        {
            string val_14;
            var val_15;
            var val_16;
            val_14 = 丂与万东一三丆下业;
            val_15 = 0;
            if(丈丂丕下丏丈丞丗业 == null)
            {
                    return -854173576;
            }
            
            if(丂丌丌丛丆丆丙丌丈 == null)
            {
                    return -854173576;
            }
            
            if(丈丂丕下丏丈丞丗业.丙丐丅丕丗丁丅丁丐() != 丂丌丌丛丆丆丙丌丈.丙丐丅丕丗丁丅丁丐())
            {
                goto label_3;
            }
            
            if((val_14.Invoke(arg:  丈丂丕下丏丈丞丗业)) != (val_14.Invoke(arg:  丂丌丌丛丆丆丙丌丈)))
            {
                goto label_6;
            }
            
            val_14 = 丈丂丕下丏丈丞丗业.东丙上东业丆不丟丘();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14)) == true)
            {
                goto label_9;
            }
            
            val_14 = 丂丌丌丛丆丆丙丌丈.东丙上东业丆不丟丘();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14)) == false)
            {
                goto label_12;
            }
            
            label_9:
            val_15 = 0;
            return -854173576;
            label_3:
            if(丈丂丕下丏丈丞丗业.丙丐丅丕丗丁丅丁丐() > 2)
            {
                goto label_14;
            }
            
            val_16 = mem[106034048 + (val_9) << 2];
            val_16 = 106034048 + (val_9) << 2;
            goto label_15;
            label_6:
            label_20:
            val_15 = -1152921542407379068;
            return -854173576;
            label_14:
            val_16 = 3;
            label_15:
            if(丂丌丌丛丆丆丙丌丈.丙丐丅丕丗丁丅丁丐() <= 2)
            {
                    return -854173576;
            }
            
            return -854173576;
            label_12:
            int val_13 = 丈丂丕下丏丈丞丗业.东丙上东业丆不丟丘().CompareTo(strB:  丂丌丌丛丆丆丙丌丈.东丙上东业丆不丟丘());
            goto label_20;
        }
        internal static int 丈与且三且丗不一且(七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丕万丐东与一丈万与)
        {
            if(丕万丐东与一丈万与 > 2)
            {
                    return 3;
            }
            
            return (int)106034048 + (丕万丐东与一丈万与) << 2;
        }
        private void 上丑丂丆丄丟丞且丂(七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丕万丐东与一丈万与)
        {
            var val_20;
            var val_21;
            var val_22;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.btnRequetsGO, 丏业丟一东丂东丘丛:  true);
            var val_20 = -4294967296;
            val_20 = val_20 + ((this._separatorsButtons.Length) << 32);
            this._separatorsButtons[val_20 >> 32].gameObject.SetActive(value:  true);
            val_20 = 0;
            val_21 = 0;
            goto label_7;
            label_13:
            this._bottomButtons[0] = this._bottomButtons[0].gameObject.activeSelf;
            val_21 = val_21 + this._bottomButtons[0];
            val_20 = 1;
            label_7:
            if(val_20 < this._bottomButtons.Length)
            {
                goto label_13;
            }
            
            float val_6 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            val_6 = (float)UnityEngine.Screen.width / val_6;
            float val_23 = (float)val_21;
            val_6 = val_6 + (-180f);
            val_6 = val_6 + (-180f);
            val_23 = val_23 * 72f;
            val_6 = val_6 - val_23;
            float val_24 = 36f;
            val_6 = val_6 / ((float)val_21 + 1);
            val_24 = val_6 + val_24;
            val_22 = 0;
            float val_8 = val_6 + 72f;
            float val_9 = val_24 + 180f;
            goto label_16;
            label_34:
            UnityEngine.Transform val_25 = this._bottomButtons[0];
            val_21 = val_25.gameObject;
            if(val_21.activeSelf != false)
            {
                    UnityEngine.Vector3 val_12 = val_25.localPosition;
                val_21 = UnityEngine.Screen.width;
                float val_14 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
                val_14 = (float)val_21 / val_14;
                val_14 = val_14 * (-0.5f);
                val_14 = (val_9 + (val_8 * 0f)) + val_14;
                val_25.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                int val_26 = this._bottomButtons.Length;
                val_26 = val_26 - 1;
                if(val_22 < val_26)
            {
                    val_21 = UnityEngine.Screen.width;
                float val_18 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
                float val_19 = 0f + 0.5f;
                val_19 = val_8 * val_19;
                val_18 = (float)val_21 / val_18;
                val_19 = val_9 + val_19;
                val_18 = val_18 * 0.5f;
                val_18 = val_19 - val_18;
                this._separatorsButtons[0].localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            }
            
            val_22 = 1;
            label_16:
            if(val_22 < this._bottomButtons.Length)
            {
                goto label_34;
            }
        
        }
        public void U_HandleRewardInfo()
        {
            PGCompany.ClanWarScoreViewUI.丆丙丗三东专丐不上();
        }
        public void U_HandleClanStore()
        {
            var val_8;
            var val_9;
            UnityEngine.Object val_10;
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.craftButtonSound);
            }
            
            val_8 = null;
            val_8 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    PGCompany.ClanStoreMainUI.丆丙丗三东专丐不上(丐丅丒专丛丏上与业:  1, 且丘丏丁丑与丙与丁:  0, 丅丘丌且丈丘丄丗丄:  0, 丞丘丞丏业且丛丏丘:  0);
            }
            else
            {
                    val_9 = null;
                val_9 = null;
                ClansWindowGUI.丆丕丝丒不丙且丐丗.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4467"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
            }
            
            val_10 = Rilisoft.Singleton<NotificationMessageController>.Instance;
            if(val_10 == 0)
            {
                    return;
            }
            
            val_10 = Rilisoft.Singleton<NotificationMessageController>.Instance;
            val_10.丘丐丗丕丕丕丝丅上(丁丅丈丌丟世丗丗丟:  6, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = false, isViewd = false});
        }
        public void U_HandleArmory()
        {
            PGCompany.丌不丞丐世丞三丘丌 val_7;
            var val_8;
            var val_9;
            val_7 = this;
            if(this.与业上丈丝世丏丄丈 == true)
            {
                    return;
            }
            
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.craftButtonSound);
            }
            
            val_8 = null;
            val_8 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_12;
            }
            
            val_7 = new PGCompany.丌不丞丐世丞三丘丌();
            val_7 = new PGCompany.丌不丞丐世丞三丘丌();
            if(val_7 == null)
            {
                goto label_13;
            }
            
            .Type = 1;
            goto label_14;
            label_12:
            val_9 = null;
            val_9 = null;
            val_7 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            val_7.ShowBlockMessage(丞丗专丌丝东丄万丁:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4467"), 丝世业丘上业三且丄:  true, 丘下专下丅下业与与:  true);
            return;
            label_13:
            mem[16] = 1;
            label_14:
            .ShopCategory = 110000;
            if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌())) == null)
            {
                    return;
            }
        
        }
        public void U_BackRequest()
        {
            this.丆世与丑丆丅丐万且();
        }
        internal void 丆世与丑丆丅丐万且()
        {
            Rilisoft.LobbyCraftController val_8;
            var val_9;
            var val_10;
            val_8 = this;
            if(this.与业上丈丝世丏丄丈 == true)
            {
                    return;
            }
            
            ClanLobbyItemController.丄丘七三上丕世丞业.HideClanLobbyItems();
            val_9 = null;
            val_9 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_10 = null;
                val_10 = null;
                ClansWindowGUI.丆丕丝丒不丙且丐丗.丝东丐丝东三丈世丝();
            }
            
            丐丌不丏东丟丕七丟.丑七不且上丗丁一世().丝丑丛万丟丝三上世();
            UnityEngine.AsyncOperation val_3 = UnityEngine.Resources.UnloadUnusedAssets();
            val_8 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
            if((UnityEngine.Object.op_Implicit(exists:  val_8)) == false)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
        }
        private void 下丌丆业丅丌一一丕()
        {
        
        }
        private void 东丙丅丘丙世且上丝()
        {
            UnityEngine.GameObject val_30;
            bool val_31;
            var val_32;
            var val_33;
            var val_34;
            System.Func<System.String, System.Boolean> val_36;
            var val_37;
            PGCompany.TimerUI val_38;
            var val_39;
            this.七丙与丐丌且东丛丅();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarOffContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarPendingContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarNewVersionWorkInProgressContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarNewVersionAvailablePleaseUpdateContainer, 丏业丟一东丂东丘丛:  false);
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世业丟丒丐丕专不丙()) == false)
            {
                goto label_5;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarNewVersionWorkInProgressContainer, 丏业丟一东丂东丘丛:  true);
            val_30 = this._clanWarNewVersionWorkInProgressButton;
            goto label_54;
            label_5:
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐万丄丄下世丗丝丈()) == false)
            {
                goto label_9;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarNewVersionAvailablePleaseUpdateContainer, 丏业丟一东丂东丘丛:  true);
            val_30 = this._clanWarNewVersionAvailablePleaseUpdateButton;
            label_54:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30, 丏业丟一东丂东丘丛:  true);
            return;
            label_9:
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.与七世丝上丗丄丌丗()) == false)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丆丅丟丂且丑一与丘()) != false)
            {
                    return;
            }
            
            bool val_10 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丗丕三下上丗专东业();
            val_31 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丗丛丗丏丑丏丌丒丆();
            val_32 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.东丛世丟七上丞丕丝();
            val_33 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丅丙丛万不且一丟();
            val_34 = null;
            val_34 = null;
            val_36 = ClansLobbyGui.<>c.<>9__150_0;
            if(val_36 == null)
            {
                    val_37 = val_33;
                System.Func<System.String, System.Boolean> val_19 = null;
                val_36 = val_19;
                val_19 = new System.Func<System.String, System.Boolean>(object:  ClansLobbyGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClansLobbyGui.<>c::七丟万丒七丆丗丝下(string 三丟东丕丄丄下下丑));
                val_33 = ;
                val_32 = val_32;
                ClansLobbyGui.<>c.<>9__150_0 = val_36;
                val_31 = val_31;
            }
            
            if((val_31 & (~val_10)) == false)
            {
                goto label_29;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarRegCloseButton, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarOffContainer, 丏业丟一东丂东丘丛:  true);
            val_38 = this._clanWarRegCloseButtonTimer;
            val_39 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            int val_24 = val_39.专丅丙丛万不且一丟();
            goto label_44;
            label_29:
            if(val_10 == false)
            {
                goto label_34;
            }
            
            if(val_32 == false)
            {
                goto label_35;
            }
            
            if((System.Linq.Enumerable.Count<System.String>(source:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丞与不丂万丈丏丛(), predicate:  val_19)) != PGCompany.丂丘丞丂丏七丁丄不.丘不丗丌丗丕丘丕一())
            {
                goto label_36;
            }
            
            if(val_33 <= 0)
            {
                goto label_37;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarOpenButton, 丏业丟一东丂东丘丛:  true);
            goto label_54;
            label_34:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarRegButton, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarOffContainer, 丏业丟一东丂东丘丛:  true);
            val_38 = this._clanWarRegButtonTimer;
            val_39 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            int val_26 = val_39.下且丈丕丂丛丒上丑();
            goto label_44;
            label_35:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarRegisteredButton, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarOffContainer, 丏业丟一东丂东丘丛:  true);
            val_38 = this._clanWarRegisteredButtonTimer;
            val_39 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            label_44:
            val_38.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_39.丐丏丌丟一丁丄丏上(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void Rilisoft.ClansLobbyGui::东丙丅丘丙世且上丝()), 丛且丛丛下丒丑丙七:  0.5f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            return;
            label_36:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarWaitingOpponents, 丏业丟一东丂东丘丛:  true);
            goto label_54;
            label_37:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._clanWarEndedByTime, 丏业丟一东丂东丘丛:  true);
            goto label_54;
        }
        public void U_OpenClanWars()
        {
            bool val_1 = this.OpenClanWar();
        }
        public bool OpenClanWar()
        {
            var val_9;
            if(与丂丅三丂且不不与.丑七不且上丗丁一世().丈丏丒丈丐丌丗上丂() == 2)
            {
                    val_9 = 与丂丅三丂且不不与.丑七不且上丗丁一世();
                val_9.上丈丂丒世下丌与三();
                return false;
            }
            
            val_9 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_9.丁下丆三丏丌丕业丂() == false)
            {
                    return false;
            }
            
            val_9 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_9.丆丅丟丂且丑一与丘() != false)
            {
                    return false;
            }
            
            Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丒丐与丐丝丞东丝丌();
            return false;
        }
        internal void 丕丗不与丟丑东不下()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanWarWindowRegDone, 丏业丟一东丂东丘丛:  true);
            this._clanWarWindowRegDone.丈且东丑丂且万丒丅(丛万不丘七丐丗丙三:  0);
        }
        public void U_RegistrationInClanWar()
        {
            int val_16;
            PGCompany.ClanWarWindowRegError val_17;
            var val_18;
            val_16 = 1152921525544440992;
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丗丕三下上丗专东业()) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanWarWindowRegDone, 丏业丟一东丂东丘丛:  true);
                val_16 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐丏丌丟一丁丄丏上();
                this._clanWarWindowRegDone.丈且东丑丂且万丒丅(丛万不丘七丐丗丙三:  val_16);
            }
            else
            {
                    if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丗丛丗丏丑丏丌丒丆()) != true)
            {
                    if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丁丈丕丆下丙丏业世()) < PGCompany.丂丘丞丂丏七丁丄不.不专不丝与丂丐三业())
            {
                    val_16 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8539"), arg0:  PGCompany.丂丘丞丂丏七丁丄不.不专不丝与丂丐三业());
                this._smallClanForClanWarReg.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  val_16);
                val_17 = this._smallClanForClanWarReg;
                val_18 = null;
            }
            else
            {
                    if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丁三丂丒业丁丙丂且()) != false)
            {
                    val_18 = null;
                val_17 = this._buyClanWarReg;
            }
            else
            {
                    val_18 = null;
                val_17 = this._clanWarWindowRegError;
            }
            
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_17, 丏业丟一东丂东丘丛:  true);
            }
            
            }
            
            this.东丙丅丘丙世且上丝();
        }
        private void 专丆丂且世一丈专丛(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            var val_6;
            bool val_1 = false;
            if(丑与丂丌世丕丆一丗 == null)
            {
                    return;
            }
            
            bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Boolean>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "reg", 丙业与丙丗丝不丈东: out  val_1);
            if(val_1 != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanWarWindowRegDone, 丏业丟一东丂东丘丛:  true);
                this._clanWarWindowRegDone.丈且东丑丂且万丒丅(丛万不丘七丐丗丙三:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐丏丌丟一丁丄丏上());
            }
            
            val_6 = null;
            val_6 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丁上东丞丒丅丘丛丌, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.ClansLobbyGui::专丆丂且世一丈专丛(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        public void U_OpenBuilders()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectBuilderUI, 丏业丟一东丂东丘丛:  true);
        }
        public void U_CloseBuilders()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectBuilderUI, 丏业丟一东丂东丘丛:  false);
        }
        public void U_OpenFortBuilder()
        {
            Rilisoft.ClansLobbyGui.丘不丌丈下专丘东七();
        }
        internal static void 丘不丌丈下专丘东七()
        {
            var val_2;
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "FortFieldBuild");
            Rilisoft.ClansLobbyGui.丒一丈丙丄世丆且一();
            val_2 = null;
            val_2 = null;
            MainMenuController.下且丄丝丘丝丈上丒 = true;
        }
        public void U_OpenTankBuilder()
        {
            Rilisoft.ClansLobbyGui.东丗丁丂专七丑丞丈();
        }
        internal static void 东丗丁丂专七丑丞丈()
        {
            var val_2;
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "ClanTankBuild");
            Rilisoft.ClansLobbyGui.丒一丈丙丄世丆且一();
            val_2 = null;
            val_2 = null;
            MainMenuController.下且丄丝丘丝丈上丒 = true;
        }
        internal static void 丒一丈丙丄世丆且一()
        {
            if((Rilisoft.Singleton<NotificationMessageController>.Instance) == 0)
            {
                    return;
            }
            
            Rilisoft.Singleton<NotificationMessageController>.Instance.丘丐丗丕丕丕丝丅上(丁丅丈丌丟世丗丗丟:  4, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = false, isViewd = false});
        }
        public void U_SendLeaderMessageToServer(UIInput 丗丄下丈丑七丗丞专)
        {
            UIInput val_15 = 丗丄下丈丑七丗丞专;
            if((Rilisoft.Singleton<ClansController>.Instance.下丑上丌丐丑世丁丕()) == false)
            {
                    return;
            }
            
            string val_3 = val_15.value;
            val_15 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  0.Trim());
            if(val_15.Length > 100)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丞业三与丞三丏万丂(), b:  val_15)) != false)
            {
                    return;
            }
            
            PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丁丌一丄三业丗东丘().丟丈世与丌丝丒业七(专丐下丙丐七丑丑丂:  0, 下丂丏丘丈不丘丙丞:  0, 丘业丘不丝一丁丄丙:  0, 下丞业丂丂丟且丘丆:  new System.Nullable<丏丆丘丌且丒丏丄丏>() {HasValue = false}, 一丟丛丆丛业丗丘丆:  new System.Nullable<System.Int32>() {HasValue = false}, 丟丟不丌丄丟丈丂丙:  val_15, 一东丐一东丄一万丙:  0, 万丂不丁丟丄世专下:  new System.Nullable<System.Int32>() {HasValue = false});
            Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟上上丆丝业不丂下(丙业与丙丗丝不丈东:  val_15);
        }
        public void U_ToggleClanWarRegSettings()
        {
        
        }
        public void U_ShowDevPanel()
        {
        
        }
        public void U_HideDevPanel()
        {
        
        }
        public void U_AddClanRank()
        {
            丌丅且丗七丘丅丛丑.东专丆丑丛万丁与丒();
        }
        public void U_ResetClanRank()
        {
            丌丅且丗七丘丅丛丑.丐专三不丅与丐丁丐();
        }
        public void U_SelectNextMembersHeader()
        {
            if(this._headerView == 0)
            {
                    return;
            }
            
            this._headerView.七丑丏丁专且丄丆丛();
        }
        public void U_SelectPreviousMembersHeader()
        {
            if(this._headerView == 0)
            {
                    return;
            }
            
            this._headerView.且丟上丞丑三丄专一();
        }
        private void 七丙与丐丌且东丛丅()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarRegCloseButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarRegButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarRegisteredButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarWaitingOpponents, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._clanWarEndedByTime, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarOpenButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarNewVersionWorkInProgressButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanWarNewVersionAvailablePleaseUpdateButton, 丏业丟一东丂东丘丛:  false);
        }
        private System.Collections.IEnumerator 丐丌丅上丟丗丕丕上(string 丆丘不丌丁丈丆丟丘)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丆丘不丌丁丈丆丟丘 = 丆丘不丌丁丈丆丟丘;
            return (System.Collections.IEnumerator)new ClansLobbyGui.且且丝丅丙万不且丑();
        }
        public void U_ShowClanWarInfo()
        {
            if(this.clanWarInfoHolder == 0)
            {
                    return;
            }
            
            ClansTutorialController.Instance.下丐丁丑丁下丘七不(业丝丛且丛专丝业丁:  3, 丈东丘丏与丌东东下:  this.clanWarInfoHolder);
            if(this.clanWarInfoHolder.childCount < 1)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.clanWarInfoHolder.GetChild(index:  0).gameObject, 不东丛三丂丌丑专丆:  this.clanWarInfoHolder.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public void U_WarWorkInProgress()
        {
            UnityEngine.GameObject val_7;
            var val_8;
            var val_9;
            val_7 = this;
            if(this.下且丄丆丑丗丈一丙 != 0)
            {
                    val_7 = this.下且丄丆丑丗丈一丙;
                val_8 = 1;
                val_9 = val_7;
            }
            else
            {
                    UnityEngine.GameObject val_3 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.IO.Path.Combine(path1:  "NguiWindows", path2:  "Clan", path3:  "AdditionalClanPrefabsUI", path4:  "ClanUI_MaintenanceMessage"));
                if(val_3 == 0)
            {
                    return;
            }
            
                UnityEngine.GameObject val_6 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_3, 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄(), 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                val_8 = 1;
                this.下且丄丆丑丗丈一丙 = val_6;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
        }
        public void U_WarNewVersionAvailable()
        {
            UnityEngine.GameObject val_7;
            var val_8;
            var val_9;
            val_7 = this;
            if(this.丆丐丗丒丄七且世丅 != 0)
            {
                    val_7 = this.丆丐丗丒丄七且世丅;
                val_8 = 1;
                val_9 = val_7;
            }
            else
            {
                    UnityEngine.GameObject val_3 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.IO.Path.Combine(path1:  "NguiWindows", path2:  "Clan", path3:  "AdditionalClanPrefabsUI", path4:  "ClanUI_UpdateMessage"));
                if(val_3 == 0)
            {
                    return;
            }
            
                UnityEngine.GameObject val_6 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_3, 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄(), 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                val_8 = 1;
                this.丆丐丗丒丄七且世丅 = val_6;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
        }
        public void U_WarregClose()
        {
            UnityEngine.GameObject val_7;
            var val_8;
            var val_9;
            val_7 = this;
            if(this.丒下丂丗万丄业与且 != 0)
            {
                    val_7 = this.丒下丂丗万丄业与且;
                val_8 = 1;
                val_9 = val_7;
            }
            else
            {
                    UnityEngine.GameObject val_3 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.IO.Path.Combine(path1:  "NguiWindows", path2:  "Clan", path3:  "AdditionalClanPrefabsUI", path4:  "ClanUI_RegClosedMessage"));
                if(val_3 == 0)
            {
                    return;
            }
            
                UnityEngine.GameObject val_6 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_3, 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄(), 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                val_8 = 1;
                this.丒下丂丗万丄业与且 = val_6;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
        }
        private void 丛丈丒万丙丗七丐丗()
        {
            ClanLobbyItemController.丄丘七三上丕世丞业.ShowClanLobbyItems();
        }
        private void 丕丛专丁七万丝丙丌(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            if(且丟丅丄丒丑丂丁世 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.promotingContainer, 丏业丟一东丂东丘丛:  且丟丅丄丒丑丂丁世.丗丅与三不万一丟丐());
        }
        private void Update()
        {
            this.丕丛专丁七万丝丙丌(且丟丅丄丒丑丂丁世:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟());
        }
        private UnityEngine.MonoBehaviour 丝七东丘丑丑下丒丒()
        {
            return 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕<UnityEngine.MonoBehaviour>(丑与丞三且丛与丟业:  "NguiWindows/Clan/ClanChat", 七万上丐一丈丏丏专:  this.gameObject, 万世丛丄丄业丆且丅:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        private void 丂丁专丏专三且丕东()
        {
            UnityEngine.Object val_5;
            this.gameObject.SetActive(value:  true);
            ClanLobbyItemController.丄丘七三上丕世丞业.ShowClanLobbyItems();
            val_5 = Rilisoft.Singleton<ClansVisitController>.Instance;
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = Rilisoft.Singleton<ClansVisitController>.Instance;
            val_4.丈万丂丘丂下丒丌七 = 0;
        }
        private void 丈且丐万与上丌丄丒(UIButton 三丟东丕丄丄下下丑)
        {
            三丟东丕丄丄下下丑.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.ClansLobbyGui::丆丙三丅一东丏丅丏())));
        }
        private void 丆丙三丅一东丏丅丏()
        {
            this.HandleOnMyClanClicked(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
        }
        private void 万七丘专不丐不且丝()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        private void 专丆丒丘丌丟东丐丈()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        private void 东一上万业丟丁丕与()
        {
            this.gameObject.SetActive(value:  true);
        }
    
    }

}
