using UnityEngine;

namespace Rilisoft
{
    public class LobbyCraftController : MonoBehaviour, 丑且丆万丏丝丘丙丟
    {
        // Fields
        private static System.Action 万丂不不丛丗业上下;
        internal static UnityEngine.GameObject 丅丄万东丅丏业丑丛;
        internal static Rilisoft.LobbyCraftController 丆丕丝丒不丙且丐丗;
        private readonly System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, UnityEngine.Transform> 丗不一丗丅七丘丕一;
        private readonly System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆> 下业丝丞丈丂丁丛丑;
        private readonly System.Collections.Generic.List<Rilisoft.上丆丕业丘业丈丄丆> 丕丏丑丐业丛世一丟;
        private readonly System.Collections.Generic.List<Rilisoft.上丆丕业丘业丈丄丆> 丑万丆丅丁与丂丌丒;
        private Rilisoft.LobbyItemGroupType 丐七丂万丂丛专上丄;
        private Rilisoft.专丕丝丏丒一一万丏<Rilisoft.CraftBuildingReadyWindow> 丄下丕与东专丆丞丁;
        private Rilisoft.丏丘七丞丄丙丌丞丁 下且丐丈丐东丗丟丄;
        private System.Collections.Generic.Queue<Rilisoft.丏丘七丞丄丙丌丞丁> 丌丏丛万丂下丐丈丕;
        private Rilisoft.LobbyItemGroupType 丒丞丟丅丝不丝丒一;
        private bool 丈与丏业丗丗丒七万;
        private bool 丆丟丟七丗丂丏丒丐;
        private UIGrid 丘丞下丛世七丐丐丒;
        private Rilisoft.UIScrollManager 东丒丝丁丛七丄世丝;
        internal AcceptWindow windowForAcceptSeasonLobby;
        private Rilisoft.ItemViewer 丐丄丘丂丈丒丌七专;
        private bool 上丛丑丂且丘丐丈丙;
        private bool 东三丟东业上一丅下;
        private bool 七丄业丌丒丄丟丌丗;
        private bool 不丆三丞丞丏上丕不;
        private Rilisoft.丏丘七丞丄丙丌丞丁 三七且丟丒丟丈丐丄;
        private Rilisoft.丏丘七丞丄丙丌丞丁 丆丗丟与丏丁且丒丕;
        private bool 三丂丏丅丆丙丝丒丂;
        private bool 七丑丘丝丒丞丑丈东;
        private UnityEngine.GameObject 世丄丄丁丁丆丆丌丏;
        internal System.Action 且丂丗七丕上丄丘与;
        private bool <专世丅丁上丝三丈与>k__BackingField;
        private static System.Action 专丆且丄丈丟丒业丄;
        private bool 丒七上三丄丂丝丁丑;
        private bool 上专丆丘业一不业专;
        private static System.Action<bool> 丙下与三丟丑业上专;
        private UnityEngine.GameObject _mainPanel;
        private UnityEngine.GameObject _screenPanel;
        private UnityEngine.GameObject _cameraSettingsPanel;
        private UnityEngine.GameObject _categoriesContainer;
        private UnityEngine.GameObject _categoryRootObj;
        private UnityEngine.GameObject _categoryDecorationsObj;
        private UnityEngine.GameObject _categoryBuildingsObj;
        private UnityEngine.GameObject _categoryBackgroundsObj;
        private UnityEngine.GameObject _itemsScrollContainer;
        private UIScrollView _itemsScroll;
        private Rilisoft.CraftScrollItemView _scrollDefaultItem;
        private LobbyItemSeason _scrollLobbySeasonItem;
        private Rilisoft.LobbyItemSpeedUpWindow _speedUpWindow;
        private Rilisoft.PrefabHandler _buildedWindowPrefabHandler;
        private UnityEngine.GameObject _connectionErrorBanner;
        private Rilisoft.TextGroup _headerText;
        private UnityEngine.GameObject _tutorialHintsContainer;
        private UnityEngine.GameObject _likeGuiObj;
        private UnityEngine.GameObject _likeButtonObj;
        private UnityEngine.GameObject _speedUpBanner;
        private UnityEngine.GameObject _bundleBanner;
        private UnityEngine.AudioClip _speedUpAudio;
        private UnityEngine.AudioClip _craftBeganAudio;
        private UnityEngine.AudioClip _cameraZoomInAudio;
        private UnityEngine.AudioClip _cameraZoomOutAudio;
        private System.Collections.Generic.List<Rilisoft.LobbyCraftController.LobbyItemsGroupSettings> _groupsSettings;
        private int 丝丗下丅业丟丟世丄;
        
        // Properties
        internal static UnityEngine.GameObject 丆丂下丐丙丙上七与 { get; }
        internal System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆> 丞丁万丌不业专丝丘 { get; }
        private Rilisoft.LobbyItemGroupType 丛丌丞一丑丛丂丞丑 { get; set; }
        private Rilisoft.LobbyItemGroupType 丅专且丏丂丂丑丆三 { get; set; }
        private Rilisoft.CraftBuildingReadyWindow 世与与且丌且丒丞丝 { get; }
        internal bool 丄不丈业丂专丈下丐 { get; }
        internal bool 不丁丄丌丒上丅丂丟 { get; set; }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 专一丟丆专丟一世一 { get; }
        internal Rilisoft.LobbyItemGroupType 丒不丈专丏业上业下 { get; }
        internal bool 丐丘丐且业三丑丅丈 { get; set; }
        private int 东丘且丌丙不专一丆 { get; set; }
        private bool 丛丏且丗世七丞丝丐 { get; }
        
        // Methods
        internal static void 三且丟丂丄丈世万七(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Rilisoft.LobbyCraftController.万丂不不丛丗业上下, b:  丙业与丙丗丝不丈东);
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
        internal static void 丂丄专丁丗丕丌丅丕(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Rilisoft.LobbyCraftController.万丂不不丛丗业上下, value:  丙业与丙丗丝不丈东);
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
        internal static UnityEngine.GameObject 七上丌上丗丕世丝下()
        {
            UnityEngine.GameObject val_4;
            var val_5;
            val_4 = Rilisoft.LobbyCraftController.丅丄万东丅丏业丑丛;
            if(val_4 == 0)
            {
                    val_4 = CraftLobbyPlacePoints.instance;
                val_5 = null;
                Rilisoft.LobbyCraftController.丅丄万东丅丏业丑丛 = val_4.gameObject;
                return (UnityEngine.GameObject)Rilisoft.LobbyCraftController.丅丄万东丅丏业丑丛;
            }
            
            val_5 = null;
            return (UnityEngine.GameObject)Rilisoft.LobbyCraftController.丅丄万东丅丏业丑丛;
        }
        internal System.Collections.Generic.Dictionary<丕专丟上与丄丈三丏.LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆> 丂丌与丅丗丞丈与不()
        {
            return (System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆>)this.下业丝丞丈丂丁丛丑;
        }
        private Rilisoft.LobbyItemGroupType 世上丞丛丝丆下丁一()
        {
            return (Rilisoft.LobbyItemGroupType)this.丐七丂万丂丛专上丄;
        }
        private void 丘东丌三丁丑丂东丂(Rilisoft.LobbyItemGroupType 丙业与丙丗丝不丈东)
        {
            this.丐七丂万丂丛专上丄 = 丙业与丙丗丝不丈东;
            this.丏东世丝业专三丞丌();
        }
        private Rilisoft.LobbyItemGroupType 三不且万丐七丒丒丟()
        {
            return (Rilisoft.LobbyItemGroupType)this.丒丞丟丅丝不丝丒一;
        }
        private void 一丙丕三丌与下不丅(Rilisoft.LobbyItemGroupType 丙业与丙丗丝不丈东)
        {
            this.丒丞丟丅丝不丝丒一 = 丙业与丙丗丝不丈东;
            if(this._headerText == 0)
            {
                    return;
            }
            
            this._headerText.Text = this.丅丟丟丏丘三丞丕业(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一);
        }
        private Rilisoft.CraftBuildingReadyWindow 丛丅专丑丏丂丞丏上()
        {
            Rilisoft.专丕丝丏丒一一万丏<Rilisoft.CraftBuildingReadyWindow> val_4 = this.丄下丕与东专丆丞丁;
            if(val_4 != null)
            {
                    return val_3.世三丞丅丑丌丈丈一();
            }
            
            Rilisoft.专丕丝丏丒一一万丏<Rilisoft.CraftBuildingReadyWindow> val_3 = null;
            val_4 = val_3;
            val_3 = new Rilisoft.专丕丝丏丒一一万丏<Rilisoft.CraftBuildingReadyWindow>(丑且不丕与专丄业丙:  this._buildedWindowPrefabHandler.Prefab, 丆丏七丟不丒与七专:  this.gameObject);
            this.丄下丕与东专丆丞丁 = val_4;
            if(val_4 != null)
            {
                    return val_3.世三丞丅丑丌丈丈一();
            }
            
            return val_3.世三丞丅丑丌丈丈一();
        }
        private void 三丕丕上且三丙丅世(bool 丙业与丙丗丝不丈东)
        {
            if(this._mainPanel == 0)
            {
                    return;
            }
            
            if(this._mainPanel.activeSelf ^ 丙业与丙丗丝不丈东 == false)
            {
                    return;
            }
            
            this._mainPanel.SetActive(value:  丙业与丙丗丝不丈东);
            if(Rilisoft.LobbyCraftController.万丂不不丛丗业上下 == null)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.万丂不不丛丗业上下.Invoke();
        }
        internal bool 万丂专世丄丆丒且下()
        {
            if(this._mainPanel != null)
            {
                    return this._mainPanel.activeSelf;
            }
            
            return this._mainPanel.activeSelf;
        }
        internal bool 上丙丆不丂丂丄一丂()
        {
            return (bool)this.丆丟丟七丗丂丏丒丐;
        }
        internal void 丟丁专丁丈丕丁一丙(bool 丙业与丙丗丝不丈东)
        {
            System.EventHandler val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            UnityEngine.Object val_28;
            var val_29;
            var val_1 = (this.丆丟丟七丗丂丏丒丐 == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            this.丆丟丟七丗丂丏丒丐 = 丙业与丙丗丝不丈东;
            this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._categoriesContainer.SetActive(value:  (this.丆丟丟七丗丂丏丒丐 == true) ? 1 : 0);
            this._itemsScrollContainer.SetActive(value:  false);
            AmongUsButtonLobby.Instance.丕丕业七丙七丅丈丄();
            RedLightButtonInLobby.丑上丞不与丄丗丌一();
            if(丙业与丙丗丝不丈东 != false)
            {
                    this._screenPanel.SetActive(value:  false);
            }
            
            val_22 = 1152921505080860672;
            val_23 = null;
            val_23 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_24 = null;
                val_24 = null;
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  (this.丆丟丟七丗丂丏丒丐 == false) ? 1 : 0);
            }
            
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                goto label_17;
            }
            
            this.上丛丑丂且丘丐丈丙 = false;
            val_25 = null;
            val_25 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_26 = null;
                val_26 = null;
                System.EventHandler val_7 = null;
                val_22 = val_7;
                val_7 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                MainMenuController.丄丞丁丈与业上丞丟.丌丁丆丁万上丁丘丑(丙业与丙丗丝不丈东:  val_7);
            }
            
            if(this._headerText != 0)
            {
                    val_22 = this.丅丟丟丏丘三丞丕业(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一);
                this._headerText.Text = val_22;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_11 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丐且丐业丙世丞与();
            if(val_11 != null)
            {
                    this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_11);
            }
            
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  false);
            if((this.丑丆丏丟丗丌丄丟丝() == true) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
            {
                goto label_60;
            }
            
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  0);
            this.丝丗下丅业丟丟世丄 = 0;
            goto label_60;
            label_17:
            val_27 = null;
            val_27 = null;
            val_28 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_28 != 0)
            {
                    val_29 = null;
                val_29 = null;
                System.EventHandler val_15 = null;
                val_22 = val_15;
                val_15 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                val_28 = MainMenuController.丄丞丁丈与业上丞丟;
                val_28.丒丟万丂万丆业三丑(丙业与丙丗丝不丈东:  val_15);
            }
            
            if(val_28.丑丆丏丟丗丌丄丟丝() != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
            {
                    this.三丟一万丙丞且丘专();
                this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  0);
                this.丝丗下丅业丟丟世丄 = 0;
            }
            
            }
            
            this.三丟一万丙丞且丘专();
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  false);
            if(this.上丛丑丂且丘丐丈丙 != false)
            {
                    bool val_19 = Rilisoft.丛丅丘业丏丕下业丏.丑七不且上丗丁一世().丐一七东丏不丅丗丘(七丆丟丗世丟且丒丆:  false);
                业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
            }
            else
            {
                    Rilisoft.丛丅丘业丏丕下业丏.丑七不且上丗丁一世().世世三不丏与丌与专();
            }
            
            if(this.且丂丗七丕上丄丘与 != null)
            {
                    this.且丂丗七丕上丄丘与.Invoke();
                this.且丂丗七丕上丄丘与 = 0;
            }
            
            label_60:
            PGCompany.LobbyEventStoreDelegate.UpdateState();
            if(Rilisoft.LobbyCraftController.专丆且丄丈丟丒业丄 == null)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.专丆且丄丈丟丒业丄.Invoke();
        }
        internal void 不业丕丕丌一不丄丐()
        {
            PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
            this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        }
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丕丟丐丈丐丄丌三丐()
        {
            return (Rilisoft.丏丘七丞丄丙丌丞丁)this.丆丗丟与丏丁且丒丕;
        }
        internal Rilisoft.LobbyItemGroupType 三丞业丂丐丈东与三()
        {
            return (Rilisoft.LobbyItemGroupType)this.丐七丂万丂丛专上丄;
        }
        internal bool 且丒丈丄上下丕丐上()
        {
            return (bool)this.<专世丅丁上丝三丈与>k__BackingField;
        }
        internal void 东丐丝七丞世丅丘一(bool 丙业与丙丗丝不丈东)
        {
            this.<专世丅丁上丝三丈与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丈丈东三丙且丟丗下(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  Rilisoft.LobbyCraftController.专丆且丄丈丟丒业丄, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.LobbyCraftController.专丆且丄丈丟丒业丄 != 1152921505471332376);
        
        }
        internal static void 东三世丟世业不丏上(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  Rilisoft.LobbyCraftController.专丆且丄丈丟丒业丄, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.LobbyCraftController.专丆且丄丈丟丒业丄 != 1152921505471332376);
        
        }
        internal static void 三专业与丑丈丈与丐(bool 不与万丌一丈下丑丈)
        {
            bool val_3 = 不与万丌一丈下丑丈;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  PersConfigurator.下一丁七丅丕七万丑().gameObject, 丏业丟一东丂东丘丛:  val_3);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  Rilisoft.LobbyCraftController.七上丌上丗丕世丝下(), 丏业丟一东丂东丘丛:  val_3);
        }
        private void 丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.且万丅上上丁业世与();
        }
        internal static string 上丝丕丄与上丂专丗(long 丆丐七丅丆丗丛上与)
        {
            object val_11;
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)丆丐七丅丆丗丛上与);
            val_11 = System.String.Format(format:  "{0:D2}:{1:D2}:{2:D2}", arg0:  val_1._ticks.Hours, arg1:  val_1._ticks.Minutes, arg2:  val_1._ticks.Seconds);
            if(val_1._ticks.Days < 1)
            {
                    return (string)val_11;
            }
            
            val_11 = System.String.Format(format:  "{0} {1}", arg0:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2913"), arg0:  val_1._ticks.Days), arg1:  val_11);
            return (string)val_11;
        }
        private void Awake()
        {
            this.丘上丐世丆丑且丞丒();
            BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftController::东丂东丟世七业丙丟()));
            BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftController::东丂东丟世七业丙丟()));
        }
        private void 丘上丐世丆丑且丞丒()
        {
            if((this.<专世丅丁上丝三丈与>k__BackingField) == true)
            {
                    return;
            }
            
            AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "LobbyCraftController strart init");
            this.<专世丅丁上丝三丈与>k__BackingField = true;
            this.丑万丆丅丁与丂丌丒.Add(item:  this._scrollDefaultItem);
            AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "LobbyCraftController Instantiate items");
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 = this;
            this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  false);
            this._screenPanel.SetActive(value:  false);
            this._scrollDefaultItem.gameObject.SetActive(value:  false);
            this.丘丞下丛世七丐丐丒 = this._itemsScroll.gameObject.GetComponentInChildren<UIGrid>();
            this.东丒丝丁丛七丄世丝 = this._itemsScroll.gameObject.GetComponent<Rilisoft.UIScrollManager>();
            this.丏东世丝业专三丞丌();
            Rilisoft.LobbyItemsController.与丌丌丒丘丅一丒上(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.丏丏与一丁丄世世万(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丝与丟丕且丈丙且上(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.专丏业且丙丆丁且丈(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丝与丟丕且丈丙且上(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.万丂丐一世业世万丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.三丘丒丞丕下丘万丂(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.七万丐丟业业且丕丂(丙业与丙丗丝不丈东:  new System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::世丐与下丂业上丗丛(丕专丟上与丄丈三丏.LobbyItemSlot 丒丘万下丄上丄丅丞, Rilisoft.丏丘七丞丄丙丌丞丁 丌丏丗与丕丈丄三丈, Rilisoft.丏丘七丞丄丙丌丞丁 丏一丕东丙丆与丒丄)));
            Rilisoft.LobbyItemsController.东与丐东下丈七不丒(丙业与丙丗丝不丈东:  new System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::世丐与下丂业上丗丛(丕专丟上与丄丈三丏.LobbyItemSlot 丒丘万下丄上丄丅丞, Rilisoft.丏丘七丞丄丙丌丞丁 丌丏丗与丕丈丄三丈, Rilisoft.丏丘七丞丄丙丌丞丁 丏一丕东丙丆与丒丄)));
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  128)) != true)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  128, 丙业与丙丗丝不丈东:  1);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  129, 丙业与丙丗丝不丈东:  0);
                UnityEngine.Coroutine val_20 = CoroutineRunner.Instance.StartCoroutine(routine:  MenuBackgroundMusic.丆不一万丗下不丆万(七不丐下丟专业万丅:  "season_lobby", 七丆丟丗世丟且丒丆:  true, 丝下丘下丈一丞丄丄:  true));
            }
            
            Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丏丐三丌丒丝不不(丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  128)));
            this._speedUpWindow.gameObject.SetActive(value:  false);
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.七丄业丅专上丌丅丙()) != false)
            {
                    AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "LobbyCraftController start SetMySceneViews");
                this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  this.丆丟丟七丗丂丏丒丐, 丒丞丐丘且不且丟东:  false);
                AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "LobbyCraftController SetMySceneViews");
            }
            else
            {
                    Rilisoft.LobbyItemsController.丟丟且世丘丒丞丏丒(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::世丆丝下丗不丐丛与(bool 丌丗丏丏丛东专丁且)));
            }
            
            Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛丁丞专七丛世三不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftController::下与三丅丈丑丝丌丟()));
            Rilisoft.LobbyItemsController.丞下丟丅丅丅与七丕(丙业与丙丗丝不丈东:  new System.Action<万东丙丛丅业丝世三, System.Single>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丆丄下丈丘丐丒专丛(丕专丟上与丄丈三丏.万东丙丛丅业丝世三 丛丆东与丑丞丅丝专, float 不丁丌丐业丑丟且不)));
        }
        private void 丏东世丝业专三丞丌()
        {
            UnityEngine.GameObject val_2;
            var val_3;
            UnityEngine.GameObject val_4;
            var val_5;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_3;
            }
            
            val_2 = this._bundleBanner;
            val_3 = 0;
            goto label_6;
            label_3:
            if(this.丐七丂万丂丛专上丄 != 600)
            {
                goto label_7;
            }
            
            val_3 = 1;
            val_2 = this._bundleBanner;
            label_6:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
            val_4 = this._speedUpBanner;
            val_5 = 0;
            goto label_10;
            label_7:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._bundleBanner, 丏业丟一东丂东丘丛:  false);
            val_4 = this._speedUpBanner;
            val_5 = 1;
            label_10:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        }
        private void Start()
        {
            this._itemsScroll.GetComponent<UIPanel>().UpdateAnchors();
        }
        private void LateUpdate()
        {
            if(this.不丆三丞丞丏上丕不 != false)
            {
                    this.不丆三丞丞丏上丕不 = false;
                this.上丞丈丟丅丈东七上();
                return;
            }
            
            if(this.七丑丘丝丒丞丑丈东 != false)
            {
                    this.七丑丘丝丒丞丑丈东 = false;
                this.丝丝丝七丙丝丆丅丛();
                return;
            }
            
            if(this.七丄业丌丒丄丟丌丗 == false)
            {
                    return;
            }
            
            this.七丄业丌丒丄丟丌丗 = false;
            if(this._itemsScroll.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this.不丈不与不丑丌丑下(丑丘丕且丆东丏丘丙:  this.丆丗丟与丏丁且丒丕);
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            var val_6;
            var val_7;
            val_6 = this;
            if(丁与丟万丄丒丗专丌 != false)
            {
                    if(this.下且丐丈丐东丗丟丄 == null)
            {
                    return;
            }
            
                this.三丞丁丗丟万业丗专(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
                return;
            }
            
            if(this.丄下丕与东专丆丞丁 == null)
            {
                    return;
            }
            
            if(this.丄下丕与东专丆丞丁.世三丞丅丑丌丈丈一() == 0)
            {
                    return;
            }
            
            val_6 = this.丄下丕与东专丆丞丁.世三丞丅丑丌丈丈一().gameObject;
            if(val_6.activeSelf == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  false);
        }
        private void OnDestroy()
        {
            Rilisoft.LobbyItemsController.与丌丌丒丘丅一丒上(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丝与丟丕且丈丙且上(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.万丂丐一世业世万丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)));
            Rilisoft.LobbyItemsController.七万丐丟业业且丕丂(丙业与丙丗丝不丈东:  new System.Action<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::世丐与下丂业上丗丛(丕专丟上与丄丈三丏.LobbyItemSlot 丒丘万下丄上丄丅丞, Rilisoft.丏丘七丞丄丙丌丞丁 丌丏丗与丕丈丄三丈, Rilisoft.丏丘七丞丄丙丌丞丁 丏一丕东丙丆与丒丄)));
            Rilisoft.LobbyItemsController.丘一与丂专万万丘丄(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::世丆丝下丗不丐丛与(bool 丌丗丏丏丛东专丁且)));
            Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛上丐丑丙三万丒丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftController::下与三丅丈丑丝丌丟()));
            if(this.下且丐丈丐东丗丟丄 != null)
            {
                    this.三丞丁丗丟万业丗专(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
            }
            
            Rilisoft.LobbyItemsController.丝下世丐丏丌丁不丄(丙业与丙丗丝不丈东:  new System.Action<万东丙丛丅业丝世三, System.Single>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丆丄下丈丘丐丒专丛(丕专丟上与丄丈三丏.万东丙丛丅业丝世三 丛丆东与丑丞丅丝专, float 不丁丌丐业丑丟且不)));
            BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftController::东丂东丟世七业丙丟()));
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 = 0;
        }
        private void 丆丄下丈丘丐丒专丛(丕专丟上与丄丈三丏.万东丙丛丅业丝世三 丛丆东与丑丞丅丝专, float 不丁丌丐业丑丟且不)
        {
            this.丝丝丝七丙丝丆丅丛();
        }
        internal string 丅丟丟丏丘三丞丕业(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗)
        {
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            if((System.Linq.Enumerable.FirstOrDefault<LobbyItemsGroupSettings>(source:  this._groupsSettings, predicate:  new System.Func<LobbyItemsGroupSettings, System.Boolean>(object:  new LobbyCraftController.丅且丒丙丗不世丟与(), method:  System.Boolean LobbyCraftController.丅且丒丙丗不世丟与::丂下专丁丈丑丐丁丗(Rilisoft.LobbyCraftController.LobbyItemsGroupSettings 且七丘且丟丘丏丑丗)))) == null)
            {
                    return (string)System.String.alignConst;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3.LocalizationKey);
        }
        internal UnityEngine.AudioClip 丞丒丝丘东七上与三(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗)
        {
            UnityEngine.AudioClip val_4;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            if((System.Linq.Enumerable.FirstOrDefault<LobbyItemsGroupSettings>(source:  this._groupsSettings, predicate:  new System.Func<LobbyItemsGroupSettings, System.Boolean>(object:  new LobbyCraftController.丅丆丛丄丘不丒丂丈(), method:  System.Boolean LobbyCraftController.丅丆丛丄丘不丒丂丈::一丞丁丆丕且丏丂丆(Rilisoft.LobbyCraftController.LobbyItemsGroupSettings 且七丘且丟丘丏丑丗)))) == null)
            {
                    return val_4;
            }
            
            val_4 = val_3.Clip;
            return val_4;
        }
        private void 世丆丝下丗不丐丛与(bool 丌丗丏丏丛东专丁且)
        {
            if(丌丗丏丏丛东专丁且 == false)
            {
                    return;
            }
            
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  this.丆丟丟七丗丂丏丒丐, 丒丞丐丘且不且丟东:  false);
        }
        private void 下与三丅丈丑丝丌丟()
        {
            if(this._speedUpWindow.isActiveAndEnabled != false)
            {
                    this._speedUpWindow.Hide();
            }
            
            if(this.丐七丂万丂丛专上丄 != 0)
            {
                    this.不丆三丞丞丏上丕不 = true;
            }
            
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  false);
        }
        private UnityEngine.Transform 丞丄丐世与丁丟东丘(丕专丟上与丄丈三丏.LobbyItemSlot 与丄不丌一世东丁丙)
        {
            var val_21;
            var val_22;
            var val_24;
            if(this.丗不一丗丅七丘丕一.Count != 0)
            {
                goto label_67;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  Rilisoft.LobbyCraftController.七上丌上丗丕世丝下()).GetEnumerator();
            label_43:
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            T val_9 = val_5.Current;
            System.Nullable<T> val_11 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<LobbyItemSlot>(下业七不丑丂丏丟东:  val_9.name, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-125097784) & 1) == 0)
            {
                goto label_22;
            }
            
            if((this.丗不一丗丅七丘丕一.ContainsKey(key:  val_11.HasValue)) == false)
            {
                goto label_24;
            }
            
            object[] val_13 = new object[1];
            val_13[0] = val_9.name;
            UnityEngine.Debug.LogErrorFormat(format:  "duplicate lobby item place point: \'{0}\'", args:  val_13);
            goto label_43;
            label_22:
            object[] val_15 = new object[1];
            val_15[0] = val_9.name;
            UnityEngine.Debug.LogErrorFormat(format:  "unknown lobby item place point name: \'{0}\'", args:  val_15);
            goto label_43;
            label_24:
            this.丗不一丗丅七丘丕一.Add(key:  val_11.HasValue, value:  val_9.transform);
            goto label_43;
            label_13:
            val_21 = 0;
            val_22 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_5.Dispose();
            }
            
            label_67:
            if((this.丗不一丗丅七丘丕一.ContainsKey(key:  与丄不丌一世东丁丙)) != false)
            {
                    UnityEngine.Transform val_20 = this.丗不一丗丅七丘丕一.Item[与丄不丌一世东丁丙];
                return (UnityEngine.Transform)val_24;
            }
            
            val_24 = 0;
            return (UnityEngine.Transform)val_24;
        }
        private void 上丞丈丟丅丈东七上()
        {
            var val_11;
            Rilisoft.上丆丕业丘业丈丄丆 val_37;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_39;
            var val_42;
            UIScrollView val_43;
            var val_44;
            this._itemsScroll.GetComponent<UIPanel>().UpdateAnchors();
            this.丙丆东上丟丌丈丌上();
            丞东丑专丛丆丄丝世.丒丑东世丛不上丈丛(七万上丐一丈丏丏专:  this.丘丞下丛世七丐丐丒.gameObject, 丌丝三丌丗丄丌丈且:  false, 与丐丌万丁丒不业丕:  true, 丈与丗且丐专一一丌:  true);
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_4 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.万丂丙丒丒丞丏下下(一丐丅且丛不不丌丗:  this.丐七丂万丂丛专上丄, 丁丅丑下丝丆丄下丏:  false);
            UnityEngine.Transform val_5 = this._scrollLobbySeasonItem.transform;
            UnityEngine.Transform val_6 = this.丘丞下丛世七丐丐丒.transform;
            if(this.丐七丂万丂丛专上丄 != 600)
            {
                goto label_9;
            }
            
            val_5.SetParent(p:  val_6);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._scrollLobbySeasonItem, 丏业丟一东丂东丘丛:  true);
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) != false)
            {
                    this._scrollLobbySeasonItem.SetSelectedState(丙业与丙丗丝不丈东:  true);
                this._scrollLobbySeasonItem.一丟上丟且业下丐业(丙业与丙丗丝不丈东:  true);
            }
            
            label_62:
            List.Enumerator<T> val_9 = val_4.GetEnumerator();
            label_56:
            if(((-124739936) & 1) == 0)
            {
                goto label_18;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            if(val_12.丐业丞丘七丈业丏丗() != false)
            {
                    if(val_12.且丅一一三七专丑丏() == false)
            {
                goto label_56;
            }
            
            }
            
            if(val_12.丐丙丛世丒丛丞丁万() != true)
            {
                    if(val_12.且丅一一三七专丑丏() == false)
            {
                goto label_56;
            }
            
            }
            
            if(this.丑万丆丅丁与丂丌丒.Count >= 1)
            {
                    val_37 = this.丑万丆丅丁与丂丌丒.Item[this.丑万丆丅丁与丂丌丒.Count - 1];
                bool val_21 = this.丑万丆丅丁与丂丌丒.Remove(item:  val_37);
            }
            else
            {
                    val_37 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._scrollDefaultItem.gameObject).GetComponent<Rilisoft.上丆丕业丘业丈丄丆>();
            }
            
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_39 = val_12;
            val_37.Setup(七万上丐一丈丏丏专:  this.丘丞下丛世七丐丐丒.transform, 下丅丙一丂丗丅丝七:  val_39);
            if((this.丆丗丟与丏丁且丒丕 != null) && (this.丆丗丟与丏丁且丒丕 == val_12))
            {
                    var val_38 = 0;
                val_38 = val_38 + 1;
                val_39 = 2;
                val_37.IsSelected = true;
            }
            
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_37.UpdateView();
            this.丕丏丑丐业丛世一丟.Add(item:  val_37);
            goto label_56;
            label_9:
            val_5.SetParent(p:  val_6.parent);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._scrollLobbySeasonItem, 丏业丟一东丂东丘丛:  false);
            if(val_4 != null)
            {
                goto label_62;
            }
            
            goto label_62;
            label_18:
            val_42 = public System.Void List.Enumerator<Rilisoft.丏丘七丞丄丙丌丞丁>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.zero;
            this._itemsScroll.currentMomentum = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            this._itemsScroll.ResetPosition();
            UIPanel val_32 = this._itemsScroll.panel;
            float val_40 = (float)this.丕丏丑丐业丛世一丟.Count;
            val_43 = this._itemsScroll;
            val_40 = this.丘丞下丛世七丐丐丒.cellWidth * val_40;
            if(val_40 <= val_32.width)
            {
                goto label_92;
            }
            
            if(val_32.丑丆丏丟丗丌丄丟丝() == false)
            {
                goto label_93;
            }
            
            val_44 = 1;
            if(val_43 != null)
            {
                goto label_101;
            }
            
            goto label_102;
            label_92:
            val_43.Restrict();
            this.东丒丝丁丛七丄世丝.ScrollTo(世万专丛与丐丌专不:  0);
            val_43 = this._itemsScroll;
            val_44 = 0;
            if(val_43 != null)
            {
                goto label_101;
            }
            
            label_102:
            label_101:
            val_43.enabled = false;
            return;
            label_93:
            bool val_36 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
            if(val_43 != null)
            {
                goto label_101;
            }
            
            goto label_102;
        }
        private void 丝丝丝七丙丝丆丅丛()
        {
            var val_10;
            object val_23;
            Rilisoft.LobbyItemGroupType val_24;
            var val_25;
            UIScrollView val_28;
            val_23 = this;
            if(this.丐七丂万丂丛专上丄 == 0)
            {
                    return;
            }
            
            if((this.丆丗丟与丏丁且丒丕 != null) && ((Rilisoft.LobbyItemsController.丞丑丙一与丐万且下(与丄不丌一世东丁丙:  this.丆丗丟与丏丁且丒丕.丘专上世与丟丝丟丛(), 不丝丄丒丌丐一一与:  this.丐七丂万丂丛专上丄, 丌七丅一丘与丅丅丏:  false)) != true))
            {
                    if(this.丆丗丟与丏丁且丒丕.丝丞世丕丒下东丌丄() != false)
            {
                    val_24 = 600;
            }
            else
            {
                    val_24 = Rilisoft.LobbyItemsController.丕丙专丂丛丐与下上(与丄不丌一世东丁丙:  this.丆丗丟与丏丁且丒丕.丘专上世与丟丝丟丛());
            }
            
                this.丐丟业丏丕东丗下一(一丐丅且丛不不丌丗:  val_24, 丗丒世丒东丆丅一七:  true, 世万丐专世丕业丟东:  0);
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._itemsScrollContainer, 丏业丟一东丂东丘丛:  true);
            val_25 = public static Rilisoft.上丆丕业丘业丈丄丆 System.Linq.Enumerable::FirstOrDefault<Rilisoft.上丆丕业丘业丈丄丆>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            Rilisoft.上丆丕业丘业丈丄丆 val_7 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上丆丕业丘业丈丄丆>(source:  this.丕丏丑丐业丛世一丟, predicate:  new System.Func<Rilisoft.上丆丕业丘业丈丄丆, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.LobbyCraftController::丗业丘丛丐丏丒业专(Rilisoft.上丆丕业丘业丈丄丆 业下丌下三丕丙丌下)));
            List.Enumerator<T> val_8 = this.丕丏丑丐业丛世一丟.GetEnumerator();
            label_27:
            if(((-124351328) & 1) == 0)
            {
                goto label_15;
            }
            
            string val_11 = val_10.丐丏七丌丕丗业且上();
            if(val_11 == val_7)
            {
                goto label_27;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_25 = 2;
            val_11.IsSelected = false;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_11.UpdateView();
            goto label_27;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            Rilisoft.上丆丕业丘业丈丄丆 val_15 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.上丆丕业丘业丈丄丆>(丄三丅七丆丛与与上:  val_7, 七丐丅专且专七三丆:  new System.Action<Rilisoft.上丆丕业丘业丈丄丆>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::一丈丛丁业丌三丁丂(Rilisoft.上丆丕业丘业丈丄丆 业下丌下三丕丙丌下)));
            UIPanel val_17 = this._itemsScroll.panel;
            float val_24 = (float)this.丕丏丑丐业丛世一丟.Count;
            val_28 = this._itemsScroll;
            val_24 = this.丘丞下丛世七丐丐丒.cellWidth * val_24;
            if(val_24 <= val_17.width)
            {
                goto label_37;
            }
            
            if(val_17.丑丆丏丟丗丌丄丟丝() == false)
            {
                goto label_38;
            }
            
            val_23 = 1;
            if(val_28 != null)
            {
                goto label_45;
            }
            
            goto label_46;
            label_37:
            val_28.ResetPosition();
            val_28 = this._itemsScroll;
            val_23 = 0;
            if(val_28 != null)
            {
                goto label_45;
            }
            
            label_46:
            label_45:
            val_28.enabled = false;
            return;
            label_38:
            bool val_21 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
            if(val_28 != null)
            {
                goto label_45;
            }
            
            goto label_46;
        }
        private void 丙丆东上丟丌丈丌上()
        {
            List.Enumerator<T> val_1 = this.丕丏丑丐业丛世一丟.GetEnumerator();
            label_9:
            if(((-124127656) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.Hide();
            this.丑万丆丅丁与丂丌丒.Add(item:  val_2);
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丕丏丑丐业丛世一丟.Clear();
        }
        internal void 丐丐丂下丞上丝丐七(Rilisoft.丏丘七丞丄丙丌丞丁 丂三七下丗且丌上一)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_9;
            var val_10;
            val_9 = 丂三七下丗且丌上一;
            if(this.丈与丏业丗丗丒七万 == true)
            {
                    return;
            }
            
            val_10 = this._likeGuiObj;
            if(val_10.activeInHierarchy != false)
            {
                    return;
            }
            
            if(((val_9 != null) && (this.丆丗丟与丏丁且丒丕 == val_9)) && (this.丒七上三丄丂丝丁丑 != true))
            {
                    val_10 = val_9;
                bool val_2 = val_10.丝丞世丕丒下东丌丄();
                val_9 = 0;
                if(val_2 == true)
            {
                    return;
            }
            
            }
            
            if(val_2.丑丆丏丟丗丌丄丟丝() != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_11;
            }
            
            }
            
            if((this.丆丗丟与丏丁且丒丕 != val_9) || ((val_9.丝丞世丕丒下东丌丄() == false) || (this.丒七上三丄丂丝丁丑 == true)))
            {
                goto label_15;
            }
            
            return;
            label_11:
            if(val_9 == 0)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  val_9.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) == false)
            {
                    return;
            }
            
            label_15:
            this.丒七上三丄丂丝丁丑 = false;
            this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  val_9, 丕丝丟下丗丛一丕业:  false);
        }
        internal void 丕且与万一丐丞下丁(Rilisoft.丏丘七丞丄丙丌丞丁 丂三七下丗且丌上一, bool 丗业三丝丁万世丄丐 = False)
        {
            LobbySeasonController val_3;
            var val_4;
            var val_5;
            val_3 = 丗业三丝丁万世丄丐;
            val_4 = 51462;
            if(val_3 == false)
            {
                goto label_1;
            }
            
            this.丒七上三丄丂丝丁丑 = true;
            this.七丑丘丝丒丞丑丈东 = true;
            val_5 = null;
            val_5 = null;
            val_3 = LobbySeasonController.instance;
            val_4 = val_3;
            val_4.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  true);
            if(丂三七下丗且丌上一 != null)
            {
                goto label_5;
            }
            
            return;
            label_1:
            this.丒七上三丄丂丝丁丑 = false;
            this.七丑丘丝丒丞丑丈东 = true;
            if(丂三七下丗且丌上一 == null)
            {
                    return;
            }
            
            label_5:
            if(this.丑丆丏丟丗丌丄丟丝() != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                    return;
            }
            
            }
            
            if(this.丐七丂万丂丛专上丄 == 600)
            {
                    return;
            }
            
            this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  丂三七下丗且丌上一, 丕丝丟下丗丛一丕业:  true);
        }
        private void 丆且丟丙丅丞万丄丗(Rilisoft.丏丘七丞丄丙丌丞丁 丂三七下丗且丌上一, bool 丕丝丟下丗丛一丕业)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_23;
            var val_24;
            var val_25;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.String> val_27;
            var val_28;
            System.Collections.Generic.IEnumerable<System.String> val_29;
            var val_30;
            var val_31;
            val_23 = 丂三七下丗且丌上一;
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                    return;
            }
            
            if(this.下且丐丈丐东丗丟丄 != null)
            {
                    return;
            }
            
            if(this._screenPanel.activeInHierarchy == true)
            {
                    return;
            }
            
            if(this._cameraSettingsPanel.activeInHierarchy == true)
            {
                    return;
            }
            
            if(this._likeGuiObj.activeInHierarchy != false)
            {
                    return;
            }
            
            bool val_4 = 丕丝丟下丗丛一丕业;
            this.丆丗丟与丏丁且丒丕 = val_23;
            this.七丄业丌丒丄丟丌丗 = val_4;
            if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            }
            
            }
            
            val_24 = this._itemsScroll.gameObject;
            if(val_24.activeInHierarchy == false)
            {
                goto label_18;
            }
            
            if(this.丆丗丟与丏丁且丒丕 != null)
            {
                    this.上丕且丁一丐丞丐丐(丑丘丕且丆东丏丘丙:  this.丆丗丟与丏丁且丒丕);
                this.丆丗丟与丏丁且丒丕 = val_23;
                this.上丕且丁一丐丞丐丐(丑丘丕且丆东丏丘丙:  val_23);
            }
            
            this.丆丗丟与丏丁且丒丕 = val_23;
            this.七丑丘丝丒丞丑丈东 = true;
            this.七丄业丌丒丄丟丌丗 = val_4;
            if(val_23 != null)
            {
                goto label_20;
            }
            
            goto label_28;
            label_18:
            this.七丄业丌丒丄丟丌丗 = true;
            this.丐丟业丏丕东丗下一(一丐丅且丛不不丌丗:  Rilisoft.LobbyItemsController.丕丙专丂丛丐与下上(与丄不丌一世东丁丙:  val_23.丘专上世与丟丝丟丛()), 丗丒世丒东丆丅一七:  true, 世万丐专世丕业丟东:  0);
            val_23 = this.丆丗丟与丏丁且丒丕;
            if(val_23 == null)
            {
                goto label_28;
            }
            
            label_20:
            if((val_23.丝丞世丕丒下东丌丄() == false) || (this.丆丗丟与丏丁且丒丕.丒丙丙世丅且下丁丐() == null))
            {
                goto label_28;
            }
            
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_16 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丑七丆丄一三不下丁();
            val_25 = null;
            val_25 = null;
            val_27 = LobbyCraftController.<>c.<>9__82_0;
            if(val_27 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.String> val_18 = null;
                val_27 = val_18;
                val_18 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.String>(object:  LobbyCraftController.<>c.__il2cppRuntimeField_static_fields, method:  System.String LobbyCraftController.<>c::丑丒与七七世丟万且(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyCraftController.<>c.<>9__82_0 = val_27;
            }
            
            val_24 = this.丆丗丟与丏丁且丒丕.丒丙丙世丅且下丁丐();
            val_28 = val_24.IsMyBandle;
            val_29 = System.Linq.Enumerable.Select<Rilisoft.丏丘七丞丄丙丌丞丁, System.String>(source:  val_16.丕丈专丅东三丄丆丏(丝丄不丑与丆丗七不:  val_16, 丝下且丐世丈丘丑丝:  this.丆丗丟与丏丁且丒丕.丒丙丙世丅且下丁丐().Items), selector:  val_18);
            val_30 = 0;
            goto label_39;
            label_28:
            val_28 = 1;
            val_30 = 1;
            val_29 = 0;
            label_39:
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  val_29, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
            val_31 = null;
            val_31 = null;
            LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  false);
            this._scrollLobbySeasonItem.SetSelectedState(丙业与丙丗丝不丈东:  false);
        }
        private System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> 丕丈专丅东三丄丆丏(System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> 丝丄不丑与丆丗七不, System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> 丝下且丐世丈丘丑丝)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_17;
            var val_18;
            var val_19;
            var val_20;
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_1 = new System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>();
            var val_21 = 0;
            val_21 = val_21 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = 丝丄不丑与丆丗七不.GetEnumerator();
            label_26:
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            new LobbyCraftController.丂丁丏丞丅与丗一与() = new System.Object();
            var val_23 = 0;
            val_23 = val_23 + 1;
            T val_8 = val_3.Current;
            if(new LobbyCraftController.丂丁丏丞丅与丗一与() == null)
            {
                goto label_17;
            }
            
            val_17 = new LobbyCraftController.丂丁丏丞丅与丗一与();
            .下丅丙一丂丗丅丝七 = val_8;
            if(val_8 == 0)
            {
                goto label_26;
            }
            
            goto label_19;
            label_17:
            mem[16] = val_8;
            val_17 = 16;
            if(mem[16] == 0)
            {
                goto label_26;
            }
            
            label_19:
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_9 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyCraftController.丂丁丏丞丅与丗一与(), method:  System.Boolean LobbyCraftController.丂丁丏丞丅与丗一与::丆丛与丑丑丕万且丌(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            Rilisoft.丏丘七丞丄丙丌丞丁 val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  丝下且丐世丈丘丑丝, predicate:  null);
            if(val_10 == null)
            {
                goto label_21;
            }
            
            val_1.Add(item:  val_10);
            goto label_26;
            label_21:
            val_1.Add(item:  val_17);
            goto label_26;
            label_11:
            val_18 = -123373360;
            val_19 = 0;
            val_20 = 0;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_3.Dispose();
            }
            
            if(( == 1) || ( != 104))
            {
                goto label_46;
            }
            
            val_19 = 0;
            if(丝下且丐世丈丘丑丝 != null)
            {
                goto label_50;
            }
            
            goto label_48;
            label_46:
            if( != false)
            {
                    val_20 = 0;
            }
            
            if(丝下且丐世丈丘丑丝 != null)
            {
                goto label_50;
            }
            
            label_48:
            label_50:
            var val_25 = 0;
            val_25 = val_25 + 1;
            System.Collections.Generic.IEnumerator<T> val_13 = 丝下且丐世丈丘丑丝.GetEnumerator();
            label_69:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_13.MoveNext() == false)
            {
                goto label_60;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            T val_17 = val_13.Current;
            if((val_1.Contains(item:  val_17)) == true)
            {
                goto label_69;
            }
            
            val_1.Add(item:  val_17);
            goto label_69;
            label_60:
            mem2[0] = 159;
            if(val_13 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_13.Dispose();
            }
            
            if((0 + 1) != 1)
            {
                    if( == false)
            {
                    return (System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁>)val_1;
            }
            
                if((val_18 + ((0 + 1)) << 2) == 159)
            {
                    return (System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁>)val_1;
            }
            
                return (System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁>)val_1;
            }
            
            if( == true)
            {
                    return (System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁>)val_1;
            }
            
            return (System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁>)val_1;
        }
        internal void 丆且且下东不世上丕(System.Collections.Generic.IEnumerable<string> 与丝东万丙丞丝丟七, bool 丗不且三丈丞专丄丛 = True, bool 丒丞丐丘且不且丟东 = True)
        {
            var val_9;
            System.Collections.Generic.IEnumerable<TSource> val_10;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_11;
            var val_12;
            LobbyCraftController.丅一丑三一一丅丑丌 val_1 = new LobbyCraftController.丅一丑三一一丅丑丌();
            if(val_1 != null)
            {
                    val_9 = val_1;
                .与丝东万丙丞丝丟七 = 与丝东万丙丞丝丟七;
                this.丈与丏业丗丗丒七万 = false;
            }
            else
            {
                    val_9 = 16;
                mem[16] = 与丝东万丙丞丝丟七;
                this.丈与丏业丗丗丒七万 = false;
            }
            
            Rilisoft.LobbyItemsController val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_9 == 0)
            {
                goto label_4;
            }
            
            label_6:
            val_10 = val_2.三下丙丛且丛丄丅丕();
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_4 = null;
            val_11 = val_4;
            val_4 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean LobbyCraftController.丅一丑三一一丅丑丌::丏一丛与东丗东丙丕(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            goto label_9;
            label_3:
            if(val_9 != 0)
            {
                goto label_6;
            }
            
            label_4:
            val_10 = val_2.丑七丆丄一三不下丁();
            val_12 = null;
            val_12 = null;
            val_11 = LobbyCraftController.<>c.<>9__84_1;
            if(val_11 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_6 = null;
                val_11 = val_6;
                val_6 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyCraftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyCraftController.<>c::丙丝丞丗三一丄七丏(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyCraftController.<>c.<>9__84_1 = val_11;
            }
            
            label_9:
            this.与丙丗丑丟丑一丂丛(丆丛与丅丙丒下丝丏:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_10, predicate:  val_6), 丗不且三丈丞专丄丛:  丗不且三丈丞专丄丛, 丒丞丐丘且不且丟东:  false, 丆且丌丟丅一丙东丁:  false);
        }
        internal void 与丅丒丝七丛丑丅丞(System.Collections.Generic.IEnumerable<string> 与丝东万丙丞丝丟七, bool 丒丞丐丘且不且丟东 = True, bool 丆且丌丟丅一丙东丁 = False)
        {
            string val_17;
            object val_18;
            var val_19;
            var val_20;
            System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁> val_1 = new System.Collections.Generic.List<Rilisoft.丏丘七丞丄丙丌丞丁>();
            var val_17 = 0;
            val_17 = val_17 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = 与丝东万丙丞丝丟七.GetEnumerator();
            label_29:
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            new LobbyCraftController.丏与丂丟世丙下专丆() = new LobbyCraftController.丏与丂丟世丙下专丆();
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_17 = val_3.Current;
            if(new LobbyCraftController.丏与丂丟世丙下专丆() != null)
            {
                    val_18 = new LobbyCraftController.丏与丂丟世丙下专丆();
                .丞一丁业丄一一业且 = val_17;
            }
            else
            {
                    mem[16] = val_17;
                val_17 = mem[16];
                val_18 = 16;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_17)) == true)
            {
                goto label_29;
            }
            
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_12 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new LobbyCraftController.丏与丂丟世丙下专丆(), method:  System.Boolean LobbyCraftController.丏与丂丟世丙下专丆::丑不丗三东丗一丏专(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            Rilisoft.丏丘七丞丄丙丌丞丁 val_13 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  null);
            if(val_13 == null)
            {
                goto label_23;
            }
            
            val_1.Add(item:  val_13);
            goto label_29;
            label_23:
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  "item wit id \'{0}\' not found", arg0:  val_18));
            goto label_29;
            label_11:
            val_19 = 0;
            val_20 = 0;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_3.Dispose();
            }
            
            this.丈与丏业丗丗丒七万 = true;
            this.与丙丗丑丟丑一丂丛(丆丛与丅丙丒下丝丏:  val_1, 丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  false, 丆且丌丟丅一丙东丁:  丆且丌丟丅一丙东丁);
        }
        internal void 与丅丒丝七丛丑丅丞(System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> 丑七不与丛丆一丂丞, bool 丒丞丐丘且不且丟东 = True, bool 丆且丌丟丅一丙东丁 = False)
        {
            this.丈与丏业丗丗丒七万 = true;
            this.与丙丗丑丟丑一丂丛(丆丛与丅丙丒下丝丏:  丑七不与丛丆一丂丞, 丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  false, 丆且丌丟丅一丙东丁:  丆且丌丟丅一丙东丁);
        }
        private void 与丙丗丑丟丑一丂丛(System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> 丆丛与丅丙丒下丝丏, bool 丗不且三丈丞专丄丛, bool 丒丞丐丘且不且丟东 = True, bool 丆且丌丟丅一丙东丁 = False)
        {
            var val_30;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_59;
            var val_63;
            var val_64;
            LobbyItemSlot val_66;
            var val_67;
            var val_68;
            var val_71;
            bool val_72;
            var val_75;
            var val_77;
            val_59 = 丗不且三丈丞专丄丛;
            System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁> val_1 = new System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.丏丘七丞丄丙丌丞丁>();
            var val_62 = 0;
            val_62 = val_62 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = 丆丛与丅丙丒下丝丏.GetEnumerator();
            label_22:
            var val_63 = 0;
            val_63 = val_63 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_64 = 0;
            val_64 = val_64 + 1;
            T val_7 = val_3.Current;
            if((val_1.ContainsKey(key:  val_7.丘专上世与丟丝丟丛())) == true)
            {
                goto label_22;
            }
            
            val_1.Add(key:  val_7.丘专上世与丟丝丟丛(), value:  val_7);
            goto label_22;
            label_11:
            val_63 = 0;
            val_64 = 0;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_65 = 0;
                val_65 = val_65 + 1;
                val_3.Dispose();
            }
            
            if(( != 1) && (72 == 72))
            {
                    val_63 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_64 = 0;
            }
            
            }
            
            if((this.丆丗丟与丏丁且丒丕 == null) || (丆且丌丟丅一丙东丁 == true))
            {
                goto label_51;
            }
            
            val_66 = val_1.ContainsKey(key:  this.丆丗丟与丏丁且丒丕.丘专上世与丟丝丟丛());
            LobbyItemSlot val_14 = this.丆丗丟与丏丁且丒丕.丘专上世与丟丝丟丛();
            if(val_66 == false)
            {
                goto label_44;
            }
            
            if(this.丆丗丟与丏丁且丒丕 == val_1.Item[val_14])
            {
                goto label_51;
            }
            
            val_66 = this.丆丗丟与丏丁且丒丕.丘专上世与丟丝丟丛();
            val_1.set_Item(key:  val_66, value:  this.丆丗丟与丏丁且丒丕);
            if(val_59 == true)
            {
                goto label_49;
            }
            
            goto label_63;
            label_44:
            if(val_14 != 1)
            {
                    val_66 = this.丆丗丟与丏丁且丒丕.丘专上世与丟丝丟丛();
                val_1.Add(key:  val_66, value:  this.丆丗丟与丏丁且丒丕);
            }
            
            label_51:
            if(val_59 == false)
            {
                goto label_63;
            }
            
            label_49:
            val_59 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万();
            if(((val_59 == null) || (val_59.丘专上世与丟丝丟丛() == 4)) || (val_59.丘专上世与丟丝丟丛() == 12))
            {
                goto label_63;
            }
            
            val_66 = val_1.ContainsKey(key:  val_59.丘专上世与丟丝丟丛());
            LobbyItemSlot val_24 = val_59.丘专上世与丟丝丟丛();
            if(val_66 == false)
            {
                goto label_61;
            }
            
            if(this.丆丗丟与丏丁且丒丕 != null)
            {
                    if(this.丆丗丟与丏丁且丒丕 == val_1.Item[val_24])
            {
                goto label_63;
            }
            
            }
            
            val_1.set_Item(key:  val_59.丘专上世与丟丝丟丛(), value:  val_59);
            if(val_1 != null)
            {
                goto label_67;
            }
            
            goto label_66;
            label_61:
            val_1.Add(key:  val_24, value:  val_59);
            label_63:
            if(val_1 != null)
            {
                goto label_67;
            }
            
            label_66:
            label_67:
            Dictionary.Enumerator<TKey, TValue> val_27 = val_1.GetEnumerator();
            val_67 = 1152921530798511392;
            label_105:
            if(((-122564416) & 1) == 0)
            {
                goto label_68;
            }
            
            ConfiguredValueTaskAwaiter val_31 = val_30.GetAwaiter();
            if(this.丆丗丟与丏丁且丒丕 != null)
            {
                    var val_32 = (this.丆丗丟与丏丁且丒丕 == (-122564432)) ? 1 : 0;
            }
            else
            {
                    val_68 = 0;
            }
            
            if((this.下业丝丞丈丂丁丛丑.ContainsKey(key:  val_31._value._obj.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_72;
            }
            
            var val_66 = 0;
            val_66 = val_66 + 1;
            goto label_78;
            label_72:
            this.三丅万丏丒丌丗丟丂(丑丘丕且丆东丏丘丙:  val_31._value._obj, 丞丈丌且东丆丅丗万:  false, 丛万下上万丙下世丂:  false);
            goto label_105;
            label_78:
            if(this.下业丝丞丈丂丁丛丑.Item[val_31._value._obj.丙东专丂世丈丏丁丂()].LobbyItem == (-122564432))
            {
                goto label_80;
            }
            
            var val_67 = 0;
            val_67 = val_67 + 1;
            this.下业丝丞丈丂丁丛丑.Item[val_31._value._obj.丙东专丂世丈丏丁丂()].Kill();
            bool val_43 = this.下业丝丞丈丂丁丛丑.Remove(key:  val_31._value._obj.丙东专丂世丈丏丁丂());
            this.三丅万丏丒丌丗丟丂(丑丘丕且丆东丏丘丙:  val_31._value._obj, 丞丈丌且东丆丅丗万:  false, 丛万下上万丙下世丂:  false);
            goto label_105;
            label_80:
            val_71 = public Rilisoft.上丆丕业丘业丈丄丆 System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆>::get_Item(LobbyItemSlot key);
            Rilisoft.上丆丕业丘业丈丄丆 val_45 = this.下业丝丞丈丂丁丛丑.Item[val_31._value._obj.丙东专丂世丈丏丁丂()];
            if(this.丈与丏业丗丗丒七万 == false)
            {
                goto label_90;
            }
            
            val_72 = 0;
            if(val_45 != null)
            {
                goto label_94;
            }
            
            goto label_92;
            label_90:
            val_72 = val_31._value._obj.丑丆丑三且丛上且丟();
            if(val_45 != null)
            {
                goto label_94;
            }
            
            label_92:
            label_94:
            var val_68 = 0;
            val_68 = val_68 + 1;
            val_71 = 4;
            val_45.IsCrafting = val_72;
            var val_69 = 0;
            val_69 = val_69 + 1;
            this.下业丝丞丈丂丁丛丑.Item[val_31._value._obj.丙东专丂世丈丏丁丂()].UpdateView();
            goto label_105;
            label_68:
            val_75 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_75 != 1) && (580 == 580))
            {
                    var val_70 = 0;
                val_70 = val_70 ^ 0;
                val_75 = val_75 + val_70;
            }
            else
            {
                    if( != 0)
            {
                    val_64 = 0;
            }
            
            }
            
            if(丆且丌丟丅一丙东丁 == true)
            {
                    return;
            }
            
            System.Collections.Generic.List<LobbyItemSlot> val_51 = null;
            val_67 = val_51;
            val_51 = new System.Collections.Generic.List<LobbyItemSlot>();
            Dictionary.Enumerator<TKey, TValue> val_52 = this.下业丝丞丈丂丁丛丑.GetEnumerator();
            label_138:
            if(((-122564480) & 1) == 0)
            {
                goto label_134;
            }
            
            ConfiguredValueTaskAwaiter val_53 = val_30.GetAwaiter();
            if((val_1.ContainsKey(key:  val_53._value._obj.丙东专丂世丈丏丁丂())) == true)
            {
                goto label_138;
            }
            
            val_51.Add(item:  val_53._value._obj.丙东专丂世丈丏丁丂());
            goto label_138;
            label_134:
            val_77 = val_75 + 1;
            mem2[0] = 672;
            val_66 = 1152921543138937424;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_77 == 1) || ((-122564608 + ((val_75 + 1)) << 2) != 672))
            {
                goto label_146;
            }
            
            var val_71 = 0;
            val_71 = val_71 ^ (val_77 >> 31);
            val_77 = val_77 + val_71;
            if(val_67 != null)
            {
                goto label_150;
            }
            
            goto label_148;
            label_146:
            if( != 0)
            {
                    val_64 = 0;
            }
            
            if(val_67 != null)
            {
                goto label_150;
            }
            
            label_148:
            label_150:
            List.Enumerator<T> val_57 = val_51.GetEnumerator();
            val_59 = 1152921543108594672;
            label_159:
            if(((-122564528) & 1) == 0)
            {
                goto label_151;
            }
            
            int val_58 = val_30.丙东专丂世丈丏丁丂();
            var val_72 = 0;
            val_72 = val_72 + 1;
            this.下业丝丞丈丂丁丛丑.Item[val_58].Kill();
            bool val_61 = this.下业丝丞丈丂丁丛丑.Remove(key:  val_58);
            goto label_159;
            label_151:
            val_75 = val_77 + 1;
            mem2[0] = 749;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_75 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((-122564608 + (((val_75 + 1) + 1)) << 2) == 749)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        private void 三丅万丏丒丌丗丟丂(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙, bool 丞丈丌且东丆丅丗万, bool 丛万下上万丙下世丂)
        {
            var val_12;
            LobbyCraftController.上世丑丐丄世丏三丗 val_1 = new LobbyCraftController.上世丑丐丄世丏三丗();
            if(val_1 != null)
            {
                    val_12 = val_1;
                .丑丘丕且丆东丏丘丙 = 丑丘丕且丆东丏丘丙;
                mem[1152921543139371872] = this;
            }
            else
            {
                    mem[16] = this;
                val_12 = 24;
                mem[24] = 丑丘丕且丆东丏丘丙;
            }
            
            .丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
            System.Action<System.Object, UnityEngine.GameObject> val_3 = new System.Action<System.Object, UnityEngine.GameObject>(object:  val_1, method:  System.Void LobbyCraftController.上世丑丐丄世丏三丗::且丈丙专世丈业丌丅(object 万且万且丑丗且丌丆, UnityEngine.GameObject 丑且不丕与专丄业丙));
            if(val_12 == 0)
            {
                goto label_4;
            }
            
            if(丛万下上万丙下世丂 == false)
            {
                goto label_5;
            }
            
            label_12:
            if(val_1 == null)
            {
                goto label_9;
            }
            
            if(mem[24] != 0)
            {
                goto label_15;
            }
            
            label_16:
            label_15:
            丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.SceneViewPrefabLoadOperation>(丝三丁东丈丒世丅业:  this.丞丄丐世与丁丟东丘(与丄不丌一世东丁丙:  val_12.丘专上世与丟丝丟丛()).gameObject).Setup(上丛东丆丆上世丟丞:  mem[24], 丑与丞三且丛与丟业:  mem[24].丝丑丏丑丄丌丐世丂(), 丒丒丁丆丁业丒三丆:  new System.Func<System.Object, System.Boolean>(object:  val_1, method:  System.Boolean LobbyCraftController.上世丑丐丄世丏三丗::丌且丞丄丝下丁丄丝(object 万且万且丑丗且丌丆)), 丈丌上上丕丙丞业丞:  val_3);
            return;
            label_4:
            if(丛万下上万丙下世丂 == true)
            {
                goto label_12;
            }
            
            label_5:
            val_3.Invoke(arg1:  mem[24], arg2:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_12.丝丑丏丑丄丌丐世丂()));
            return;
            label_9:
            if(mem[24] != 0)
            {
                goto label_15;
            }
            
            goto label_16;
        }
        internal void 丝且丁丒丕丟丏丗丅(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            this.丐丟业丏丕东丗下一(一丐丅且丛不不丌丗:  Rilisoft.LobbyItemsController.丕丙专丂丛丐与下上(与丄不丌一世东丁丙:  丑丘丕且丆东丏丘丙.丘专上世与丟丝丟丛()), 丗丒世丒东丆丅一七:  true, 世万丐专世丕业丟东:  0);
            this.七丑丘丝丒丞丑丈东 = true;
            this.丆丗丟与丏丁且丒丕 = 丑丘丕且丆东丏丘丙;
            this.七丄业丌丒丄丟丌丗 = true;
        }
        internal void 丐丟业丏丕东丗下一(Rilisoft.LobbyItemGroupType 一丐丅且丛不不丌丗, bool 丗丒世丒东丆丅一七 = True, string 世万丐专世丕业丟东)
        {
            UnityEngine.GameObject val_25;
            UnityEngine.Object val_26;
            UnityEngine.GameObject val_27;
            var val_28;
            UnityEngine.GameObject val_29;
            var val_30;
            UnityEngine.GameObject val_31;
            var val_32;
            var val_33;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_35;
            var val_36;
            val_25 = 世万丐专世丕业丟东;
            val_26 = this;
            if(this.丑丆丏丟丗丌丄丟丝() != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_4;
            }
            
            }
            
            this.一丙丕三丌与下不丅(丙业与丙丗丝不丈东:  一丐丅且丛不不丌丗);
            if(一丐丅且丛不不丌丗 > 199)
            {
                goto label_5;
            }
            
            if(一丐丅且丛不不丌丗 == 0)
            {
                goto label_6;
            }
            
            if(一丐丅且丛不不丌丗 != 100)
            {
                goto label_13;
            }
            
            this._categoriesContainer.SetActive(value:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryRootObj, 丏业丟一东丂东丘丛:  false);
            val_27 = this._categoryBuildingsObj;
            val_28 = 1;
            goto label_11;
            label_5:
            if(一丐丅且丛不不丌丗 == 200)
            {
                goto label_12;
            }
            
            if(一丐丅且丛不不丌丗 != 300)
            {
                goto label_13;
            }
            
            this._categoriesContainer.SetActive(value:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryRootObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryBuildingsObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryDecorationsObj, 丏业丟一东丂东丘丛:  false);
            val_29 = this._categoryBackgroundsObj;
            val_30 = 1;
            goto label_17;
            label_4:
            if(一丐丅且丛不不丌丗 == 204)
            {
                goto label_18;
            }
            
            if(一丐丅且丛不不丌丗 == 200)
            {
                goto label_19;
            }
            
            if(一丐丅且丛不不丌丗 != 0)
            {
                    return;
            }
            
            this._categoriesContainer.SetActive(value:  true);
            val_25 = this._categoryRootObj;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryBuildingsObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryDecorationsObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryBackgroundsObj, 丏业丟一东丂东丘丛:  false);
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  0);
            this.丝丗下丅业丟丟世丄 = 0;
            if(丗丒世丒东丆丅一七 == true)
            {
                goto label_87;
            }
            
            return;
            label_6:
            this._categoriesContainer.SetActive(value:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryRootObj, 丏业丟一东丂东丘丛:  true);
            val_27 = this._categoryBuildingsObj;
            val_28 = 0;
            label_11:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  false);
            val_31 = this._categoryDecorationsObj;
            val_32 = 0;
            goto label_29;
            label_12:
            this._categoriesContainer.SetActive(value:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryRootObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryBuildingsObj, 丏业丟一东丂东丘丛:  false);
            val_31 = this._categoryDecorationsObj;
            val_32 = 1;
            label_29:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  true);
            val_29 = this._categoryBackgroundsObj;
            val_30 = 0;
            label_17:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_29, 丏业丟一东丂东丘丛:  false);
            label_86:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_25)) != true)
            {
                    this.丆丗丟与丏丁且丒丕 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_25);
            }
            
            if(丗丒世丒东丆丅一七 == false)
            {
                    return;
            }
            
            label_87:
            val_26 = this.丞丒丝丘东七上与三(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一);
            if(val_26 == 0)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_26);
            return;
            label_13:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  false);
            this._itemsScrollContainer.SetActive(value:  true);
            if((this.丐七丂万丂丛专上丄 == 一丐丅且丛不不丌丗) && (一丐丅且丛不不丌丗 != 600))
            {
                    if(一丐丅且丛不不丌丗 != 0)
            {
                goto label_51;
            }
            
            }
            
            this.丙丆东上丟丌丈丌上();
            this.丐七丂万丂丛专上丄 = 一丐丅且丛不不丌丗;
            this.丏东世丝业专三丞丌();
            this.不丆三丞丞丏上丕不 = true;
            if((this.丒丞丟丅丝不丝丒一 != 600) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_25)) == false))
            {
                goto label_55;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_12 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  "bundle_my");
            if((val_12 == null) || ((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) == true))
            {
                goto label_86;
            }
            
            this.丆丗丟与丏丁且丒丕 = val_12;
            goto label_86;
            label_55:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_25)) == true)
            {
                goto label_86;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_17 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_25);
            if(val_17 == null)
            {
                goto label_86;
            }
            
            this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  val_17, 丕丝丟下丗丛一丕业:  true);
            goto label_86;
            label_18:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  false);
            this._itemsScrollContainer.SetActive(value:  true);
            if(this.丐七丂万丂丛专上丄 != 204)
            {
                goto label_70;
            }
            
            this.七丑丘丝丒丞丑丈东 = true;
            this.七丄业丌丒丄丟丌丗 = false;
            goto label_71;
            label_19:
            this._categoriesContainer.SetActive(value:  true);
            val_25 = this._categoryRootObj;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryBuildingsObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryDecorationsObj, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoryBackgroundsObj, 丏业丟一东丂东丘丛:  false);
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  1);
            this.丝丗下丅业丟丟世丄 = 1;
            if(丗丒世丒东丆丅一七 == true)
            {
                goto label_87;
            }
            
            return;
            label_70:
            this.丙丆东上丟丌丈丌上();
            this.丐七丂万丂丛专上丄 = 204;
            this.丏东世丝业专三丞丌();
            this.不丆三丞丞丏上丕不 = true;
            label_71:
            val_33 = null;
            val_33 = null;
            val_35 = LobbyCraftController.<>c.<>9__90_0;
            if(val_35 == null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_20 = null;
                val_35 = val_20;
                val_20 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  LobbyCraftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyCraftController.<>c::丈东丞丅丝丏与丕业(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                LobbyCraftController.<>c.<>9__90_0 = val_35;
            }
            
            this.丆丗丟与丏丁且丒丕 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  val_20);
            this.三丟一万丙丞且丘专();
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万()) == null)
            {
                goto label_84;
            }
            
            val_36 = 3;
            val_25 = 3;
            goto label_85;
            label_51:
            this.七丑丘丝丒丞丑丈东 = true;
            this.七丄业丌丒丄丟丌丗 = false;
            goto label_86;
            label_84:
            val_36 = 2;
            val_25 = 2;
            label_85:
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  2);
            this.丝丗下丅业丟丟世丄 = val_25;
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  false);
            if(丗丒世丒东丆丅一七 == true)
            {
                goto label_87;
            }
        
        }
        private void 不丈不与不丑丌丑下(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            var val_4;
            Rilisoft.UIScrollManager val_6;
            var val_7;
            val_4 = 0;
            goto label_1;
            label_10:
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(this.丕丏丑丐业丛世一丟.Item[0].LobbyItem == 丑丘丕且丆东丏丘丙)
            {
                goto label_8;
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < this.丕丏丑丐业丛世一丟.Count)
            {
                goto label_10;
            }
            
            val_6 = this.东丒丝丁丛七丄世丝;
            val_7 = 0;
            goto label_12;
            label_8:
            val_6 = this.东丒丝丁丛七丄世丝;
            val_7 = val_4;
            label_12:
            val_6.ScrollTo(世万专丛与丐丌专不:  0);
        }
        private void 世丐与下丂业上丗丛(丕专丟上与丄丈三丏.LobbyItemSlot 丒丘万下丄上丄丅丞, Rilisoft.丏丘七丞丄丙丌丞丁 丌丏丗与丕丈丄三丈, Rilisoft.丏丘七丞丄丙丌丞丁 丏一丕东丙丆与丒丄)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_5;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_6;
            val_5 = 丌丏丗与丕丈丄三丈;
            if(this.丈与丏业丗丗丒七万 == true)
            {
                    return;
            }
            
            if(this._likeGuiObj.activeInHierarchy == true)
            {
                    return;
            }
            
            this.上丛丑丂且丘丐丈丙 = true;
            if(val_5 != null)
            {
                    if(this.丆丗丟与丏丁且丒丕 == val_5)
            {
                    this.丆丗丟与丏丁且丒丕 = 0;
            }
            
                if(this.下且丐丈丐东丗丟丄 == null)
            {
                    if(this._screenPanel.activeInHierarchy != true)
            {
                    this.上丕且丁一丐丞丐丐(丑丘丕且丆东丏丘丙:  val_5);
            }
            
            }
            
            }
            
            if(丏一丕东丙丆与丒丄 == null)
            {
                goto label_8;
            }
            
            val_6 = this;
            this.丆丗丟与丏丁且丒丕 = 丏一丕东丙丆与丒丄;
            if(this.下且丐丈丐东丗丟丄 != null)
            {
                    return;
            }
            
            val_5 = this._screenPanel;
            if(val_5.activeInHierarchy == true)
            {
                goto label_12;
            }
            
            this.上丕且丁一丐丞丐丐(丑丘丕且丆东丏丘丙:  丏一丕东丙丆与丒丄);
            goto label_12;
            label_8:
            val_6 = this.下且丐丈丐东丗丟丄;
            label_12:
            if(mem[this.下且丐丈丐东丗丟丄] != 0)
            {
                    return;
            }
            
            if(this._screenPanel.activeInHierarchy != false)
            {
                    return;
            }
            
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
        }
        private void 上丕且丁一丐丞丐丐(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_17;
            var val_18;
            var val_21;
            var val_23;
            bool val_24;
            val_17 = 丑丘丕且丆东丏丘丙;
            LobbyCraftController.上与专上专丞东丄丆 val_1 = new LobbyCraftController.上与专上专丞东丄丆();
            .丑丘丕且丆东丏丘丙 = val_17;
            if(this.丈与丏业丗丗丒七万 == true)
            {
                    return;
            }
            
            val_17 = this._likeGuiObj;
            if(val_17.activeInHierarchy == true)
            {
                    return;
            }
            
            if((LobbyCraftController.上与专上专丞东丄丆)[1152921543140632384].丑丘丕且丆东丏丘丙 == null)
            {
                    return;
            }
            
            val_18 = public static Rilisoft.上丆丕业丘业丈丄丆 System.Linq.Enumerable::FirstOrDefault<Rilisoft.上丆丕业丘业丈丄丆>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            Rilisoft.上丆丕业丘业丈丄丆 val_4 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上丆丕业丘业丈丄丆>(source:  this.丕丏丑丐业丛世一丟, predicate:  new System.Func<Rilisoft.上丆丕业丘业丈丄丆, System.Boolean>(object:  val_1, method:  System.Boolean LobbyCraftController.上与专上专丞东丄丆::万丆七丏七丏不丅世(Rilisoft.上丆丕业丘业丈丄丆 业下丌下三丕丙丌下)));
            if(val_4 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_18 = 2;
                val_4.IsSelected = ((LobbyCraftController.上与专上专丞东丄丆)[1152921543140632384].丑丘丕且丆东丏丘丙 == this.丆丗丟与丏丁且丒丕) ? 1 : 0;
                var val_18 = 0;
                val_18 = val_18 + 1;
                val_4.UpdateView();
            }
            
            val_21 = public static Rilisoft.上丆丕业丘业丈丄丆 System.Linq.Enumerable::FirstOrDefault<Rilisoft.上丆丕业丘业丈丄丆>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            val_17 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上丆丕业丘业丈丄丆>(source:  this.下业丝丞丈丂丁丛丑.Values, predicate:  new System.Func<Rilisoft.上丆丕业丘业丈丄丆, System.Boolean>(object:  val_1, method:  System.Boolean LobbyCraftController.上与专上专丞东丄丆::丒丗丗万七丐丅丙业(Rilisoft.上丆丕业丘业丈丄丆 业下丌下三丕丙丌下)));
            if(val_17 == null)
            {
                    return;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_21 = 2;
            val_23 = public System.Void Rilisoft.上丆丕业丘业丈丄丆::set_IsSelected(bool 丙业与丙丗丝不丈东);
            val_17.IsSelected = ((LobbyCraftController.上与专上专丞东丄丆)[1152921543140632384].丑丘丕且丆东丏丘丙 == this.丆丗丟与丏丁且丒丕) ? 1 : 0;
            if(this.丈与丏业丗丗丒七万 != false)
            {
                    val_24 = 0;
            }
            else
            {
                    val_24 = (LobbyCraftController.上与专上专丞东丄丆)[1152921543140632384].丑丘丕且丆东丏丘丙.丑丆丑三且丛上且丟();
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_23 = 4;
            val_17.IsCrafting = val_24;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_17.UpdateView();
        }
        internal void 丒丑丙丂不丝七不七()
        {
            if(this._connectionErrorBanner == 0)
            {
                    return;
            }
            
            this._connectionErrorBanner.SetActive(value:  true);
        }
        internal void 与丅丟丌专与丑丈万(Rilisoft.CraftScrollItemView 丁世丛业丟下丕三丟)
        {
            Rilisoft.LobbyCraftController val_50;
            Rilisoft.CraftScrollItemView val_51;
            var val_52;
            var val_53;
            丈丞丕丘丕丗与上一 val_54;
            IntPtr val_56;
            val_50 = this;
            LobbyCraftController.丑七丂丙一丕丘东世 val_1 = new LobbyCraftController.丑七丂丙一丕丘东世();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = val_50;
            }
            else
            {
                    mem[16] = val_50;
            }
            
            .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  52);
            val_51 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟;
            if(val_51 == 0)
            {
                goto label_45;
            }
            
            System.Nullable<System.Int64> val_4 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            val_51 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem;
            if(val_51.且丅一一三七专丑丏() == true)
            {
                    return;
            }
            
            val_51 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem;
            bool val_8 = val_51.丑丆丑三且丛上且丟();
            if(val_8 == true)
            {
                    return;
            }
            
            if((val_8.丑丆丏丟丗丌丄丟丝() == true) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
            {
                goto label_21;
            }
            
            val_51 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem.丙丕丞且丕不丘丙丑();
            if((System.String.op_Equality(a:  val_51.业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) == false)
            {
                goto label_45;
            }
            
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  3);
            this.丝丗下丅业丟丟世丄 = 3;
            label_21:
            if(coinsShop.丏丅世七丞与丛丘业() == true)
            {
                goto label_42;
            }
            
            val_52 = null;
            val_52 = null;
            if((System.String.op_Inequality(a:  (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_42;
            }
            
            val_53 = null;
            val_51 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈().东与三丌丅三丒丏业();
            val_53 = null;
            if((System.String.op_Inequality(a:  val_51, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_42;
            }
            
            StoreKitEventListener.丆丂一丄丐丅丄东一(七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void LobbyCraftController.丑七丂丙一丕丘东世::丕丄丈丟世一丏丏一()));
            goto label_45;
            label_11:
            this.丒丑丙丂不丝七不七();
            label_45:
            val_50 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_50.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
            label_42:
            if((LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem.丝丞世丕丒下东丌丄() == false)
            {
                goto label_51;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_30 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem;
            if((System.String.op_Equality(a:  val_30.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈().东与三丌丅三丒丏业(), b:  "Real")) == false)
            {
                goto label_56;
            }
            
            val_30.丒丙丙世丅且下丁丐().东丞丐业丂丞不丕丈();
            goto label_65;
            label_51:
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万()) == null)
            {
                goto label_61;
            }
            
            this._speedUpWindow.Show(丆丝丕上丛且丗丝丙:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万(), 丑丟一丄丟丞七世丘:  (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem, 七丈丐与不一丘东一:  new System.Action<上三上与丒不丒丘丝, Rilisoft.丏丘七丞丄丙丌丞丁, Rilisoft.丏丘七丞丄丙丌丞丁>(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丈丝丑不万丁丙丅专(Rilisoft.LobbyItemSpeedUpWindow.上三上与丒不丒丘丝 且世丌丟丗专与不丑, Rilisoft.丏丘七丞丄丙丌丞丁 丆丝丕上丛且丗丝丙, Rilisoft.丏丘七丞丄丙丌丞丁 丙丑专丈一万三丟一)));
            goto label_65;
            label_56:
            val_54 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            val_56 = 1152921543141065680;
            goto label_69;
            label_61:
            val_54 = (LobbyCraftController.丑七丂丙一丕丘东世)[1152921543141152400].丁世丛业丟下丕三丟.LobbyItem.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            System.Action<System.Boolean> val_48 = null;
            val_56 = 1152921543141087184;
            label_69:
            val_48 = new System.Action<System.Boolean>(object:  val_1, method:  val_56);
            val_48.三不丘下且丞三丆丙(丒世丘丘上丆丝东丞:  val_54, 业丏丈世世世丞丒世:  val_48);
            label_65:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            this.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  false, 丅丁三世丝三丞专世:  true, 丝一专专丏丝丘丒东:  true);
        }
        internal void 不不丝与世丗七丙丅(Rilisoft.CraftScrollItemView 丁世丛业丟下丕三丟)
        {
            LobbyCraftController.丂丞丕丏丈且丆丞丆 val_1 = new LobbyCraftController.丂丞丕丏丈且丆丞丆();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) != false)
            {
                    this.丝业业丝丕丁丅丅丘(丘万且丑丂丈丈业丑:  false, 下丕下丅丙丞丐东丗:  new System.Action(object:  val_1, method:  System.Void LobbyCraftController.丂丞丕丏丈且丆丞丆::丗丐丙丆与丙世丘丂()), 丝丆丗一上且三丒丄:  new System.Action(object:  val_1, method:  System.Void LobbyCraftController.丂丞丕丏丈且丆丞丆::下丗与且丏丄万三丆()));
                return;
            }
            
            this.与丅丟丌专与丑丈万(丁世丛业丟下丕三丟:  (LobbyCraftController.丂丞丕丏丈且丆丞丆)[1152921543141499920].丁世丛业丟下丕三丟);
        }
        private void 丈丝丑不万丁丙丅专(Rilisoft.LobbyItemSpeedUpWindow.上三上与丒不丒丘丝 且世丌丟丗专与不丑, Rilisoft.丏丘七丞丄丙丌丞丁 丆丝丕上丛且丗丝丙, Rilisoft.丏丘七丞丄丙丌丞丁 丙丑专丈一万三丟一)
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_16;
            object val_17;
            丈丞丕丘丕丗与上一 val_18;
            IntPtr val_20;
            val_16 = 丙丑专丈一万三丟一;
            val_17 = 且世丌丟丗专与不丑;
            LobbyCraftController.丗且丈丂丁丄专丞专 val_1 = new LobbyCraftController.丗且丈丂丁丄专丞专();
            if(val_1 != null)
            {
                    .丆丝丕上丛且丗丝丙 = 丆丝丕上丛且丗丝丙;
                .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = 丆丝丕上丛且丗丝丙;
                mem[24] = this;
            }
            
            .丙丑专丈一万三丟一 = val_16;
            System.Nullable<System.Int64> val_2 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                    return;
            }
            
            if(val_17 == 2)
            {
                goto label_6;
            }
            
            if(val_17 != 1)
            {
                    return;
            }
            
            LobbyCraftController.世丈丂丄一专丁丏世 val_3 = null;
            val_17 = val_3;
            val_3 = new LobbyCraftController.世丈丂丄一专丁丏世();
            if(val_17 == null)
            {
                goto label_8;
            }
            
            val_16 = val_17;
            .东丟且丗且三专丙丁 = val_1;
            goto label_9;
            label_6:
            LobbyCraftController.丅七丟业万且一上万 val_4 = null;
            val_17 = val_4;
            val_4 = new LobbyCraftController.丅七丟业万且一上万();
            if(val_17 == null)
            {
                goto label_10;
            }
            
            val_16 = val_17;
            .丕丅丏丁丅东且七丌 = val_1;
            goto label_11;
            label_8:
            val_16 = 24;
            mem[24] = val_1;
            label_9:
            if(.丆丝丕上丛且丗丝丙 == null)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万()) != .丆丝丕上丛且丗丝丙)
            {
                    return;
            }
            
            int val_8 = .丆丝丕上丛且丗丝丙.且丕三丙七且且东下().丟丂丞不专丆万丒世();
            if(val_17 == null)
            {
                goto label_22;
            }
            
            .世丗丙丆七丄丌东上 = val_8;
            goto label_23;
            label_10:
            val_16 = 24;
            mem[24] = val_1;
            label_11:
            if(.丙丑专丈一万三丟一 == null)
            {
                    return;
            }
            
            int val_11 = .丙丑专丈一万三丟一.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌().丟丂丞不专丆万丒世();
            if(val_17 != null)
            {
                    .世丗丙丆七丄丌东上 = val_11;
            }
            else
            {
                    mem[16] = val_11;
            }
            
            val_18 = .丙丑专丈一万三丟一.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌();
            val_20 = 1152921543141633744;
            goto label_36;
            label_22:
            mem[16] = val_8;
            label_23:
            val_18 = .丆丝丕上丛且丗丝丙.且丕三丙七且且东下();
            System.Action<System.Boolean> val_15 = null;
            val_20 = 1152921543141642960;
            label_36:
            val_16 = val_15;
            val_15 = new System.Action<System.Boolean>(object:  val_3, method:  val_20);
            val_15.三不丘下且丞三丆丙(丒世丘丘上丆丝东丞:  val_18, 业丏丈世世世丞丒世:  val_15);
        }
        internal void 丞不丌下丐丄丕世丏(Rilisoft.CraftScrollItemView 丁世丛业丟下丕三丟)
        {
            this.丐丑丑丝丂丁丗丘丗();
        }
        internal void 专七丕业七丞丁丆丟()
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_15 = this;
            System.Nullable<System.Int64> val_1 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(( & 1) != 0)
            {
                    val_15 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
                if(val_15.丟丑丒丂万丟专丁万() == null)
            {
                    return;
            }
            
                val_15 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万();
                System.Nullable<System.Int64> val_6 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
                if(( & 1) == 0)
            {
                    return;
            }
            
                if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万()) != val_15)
            {
                    return;
            }
            
                if(Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
                if(Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世().丄丛丅丐世丌丕且丛() == false)
            {
                    return;
            }
            
                bool val_14 = Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世().三丙丆丕丗专丐丆丗(下丅丙一丂丗丅丝七:  val_15);
                return;
            }
            
            this.丒丑丙丂不丝七不七();
        }
        internal void 丐丑丑丝丂丁丗丘丗()
        {
            System.Action<System.Boolean> val_14;
            .丝且与丝丒丟万丁专 = this;
            val_14 = 1152921505469198336;
            System.Nullable<System.Int64> val_2 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(( & 1) != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万()) == null)
            {
                    return;
            }
            
                .丑丘丕且丆东丏丘丙 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万();
                System.Nullable<System.Int64> val_7 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
                if(( & 1) == 0)
            {
                    return;
            }
            
                Rilisoft.丏丘七丞丄丙丌丞丁 val_9 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万();
                if(val_9 != (LobbyCraftController.不下丛专万丟丕东万)[1152921543142233616].丑丘丕且丆东丏丘丙)
            {
                    return;
            }
            
                .丂丏丟丛丞东七丝上 = val_9.且丕三丙七且且东下().丟丂丞不专丆万丒世();
                System.Action<System.Boolean> val_13 = null;
                val_14 = val_13;
                val_13 = new System.Action<System.Boolean>(object:  new LobbyCraftController.不下丛专万丟丕东万(), method:  System.Void LobbyCraftController.不下丛专万丟丕东万::业丈万丐不丑三东不(bool 丌丗丏丏丛东专丁且));
                val_13.三不丘下且丞三丆丙(丒世丘丘上丆丝东丞:  (LobbyCraftController.不下丛专万丟丕东万)[1152921543142233616].丑丘丕且丆东丏丘丙.且丕三丙七且且东下(), 业丏丈世世世丞丒世:  val_13);
                return;
            }
            
            this.丒丑丙丂不丝七不七();
        }
        internal void 丘丙丅上丞世丄丞与(Rilisoft.CraftScrollItemView 丁世丛业丟下丕三丟)
        {
            LobbyCraftController.丆万世与丄三丌下万 val_1 = new LobbyCraftController.丆万世与丄三丌下万();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) != false)
            {
                    this.丝业业丝丕丁丅丅丘(丘万且丑丂丈丈业丑:  false, 下丕下丅丙丞丐东丗:  new System.Action(object:  val_1, method:  System.Void LobbyCraftController.丆万世与丄三丌下万::专丕与丆丙丛万丞且()), 丝丆丗一上且三丒丄:  new System.Action(object:  val_1, method:  System.Void LobbyCraftController.丆万世与丄三丌下万::东丒丆丁丝丟丑世丂()));
                return;
            }
            
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_8 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  (LobbyCraftController.丆万世与丄三丌下万)[1152921543142437776].丁世丛业丟下丕三丟.LobbyItem, 与且专丏丅世丐丐丑:  false, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
        }
        internal void 丘一东专丐丁七丞七(Rilisoft.CraftScrollItemView 丁世丛业丟下丕三丟)
        {
            if(丁世丛业丟下丕三丟 == 0)
            {
                    return;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_2 = 丁世丛业丟下丕三丟.LobbyItem;
            if((Rilisoft.LobbyItemsController.丄专与丝上专下东专(与丄不丌一世东丁丙:  val_2.丘专上世与丟丝丟丛())) != true)
            {
                    if(val_2.丙丄丝丕丏世丏丛丑() == true)
            {
                    return;
            }
            
            }
            
            Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丂丘与与丂下丞丛(与丄不丌一世东丁丙:  val_2.丘专上世与丟丝丟丛());
        }
        private void 三不丘下且丞三丆丙(丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞, System.Action<bool> 业丏丈世世世丞丒世)
        {
            LobbyCraftController.丟丗东丛丘丂丌七丑 val_1 = new LobbyCraftController.丟丗东丛丘丂丌七丑();
            .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  0, 丒世丘丘上丆丝东丞:  丒世丘丘上丆丝东丞, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void LobbyCraftController.丟丗东丛丘丂丌七丑::丞丕丛丛丄丏丒东丛()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  val_1, method:  System.Void LobbyCraftController.丟丗东丛丘丂丌七丑::一丟丙丟丏一且丌丑()), 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  89);
        }
        private void 丅专且丟丑丛东丏三()
        {
            if(this.丑丆丏丟丗丌丄丟丝() != true)
            {
                    this.三丟一万丙丞且丘专();
            }
            
            if(this._screenPanel.activeInHierarchy != false)
            {
                    return;
            }
            
            this.三七且丟丒丟丈丐丄 = this.丆丗丟与丏丁且丒丕;
            this.丆丗丟与丏丁且丒丕 = 0;
            this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  false);
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  true);
            this._likeGuiObj.SetActive(value:  false);
        }
        private void 丙不丘与丏丄丒不丄()
        {
            if(this.丑丆丏丟丗丌丄丟丝() != true)
            {
                    this.三丟一万丙丞且丘专();
            }
            
            if(this._likeGuiObj.activeInHierarchy != false)
            {
                    return;
            }
            
            this.三七且丟丒丟丈丐丄 = this.丆丗丟与丏丁且丒丕;
            this.丆丗丟与丏丁且丒丕 = 0;
            this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  false);
            this._likeGuiObj.SetActive(value:  true);
        }
        private void 业上丛丕业上丙万丞()
        {
            if(this.丑丆丏丟丗丌丄丟丝() != true)
            {
                    this.三丟一万丙丞且丘专();
            }
            
            if(this._cameraSettingsPanel.activeInHierarchy != false)
            {
                    return;
            }
            
            this.三七且丟丒丟丈丐丄 = this.丆丗丟与丏丁且丒丕;
            this.丆丗丟与丏丁且丒丕 = 0;
            this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  true);
            this._likeGuiObj.SetActive(value:  false);
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  true);
        }
        private void 且万丅上上丁业世与()
        {
            Rilisoft.LobbyItemGroupType val_18;
            if(this.下且丐丈丐东丗丟丄 != null)
            {
                    return;
            }
            
            if(this._screenPanel.activeInHierarchy != true)
            {
                    if(this._cameraSettingsPanel.activeInHierarchy != true)
            {
                    if(this._likeGuiObj.activeInHierarchy == false)
            {
                goto label_7;
            }
            
            }
            
            }
            
            this.丆丗丟与丏丁且丒丕 = this.三七且丟丒丟丈丐丄;
            this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemsScrollContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._likeGuiObj, 丏业丟一东丂东丘丛:  false);
            if(this.丐七丂万丂丛专上丄 == 0)
            {
                goto label_10;
            }
            
            this.丐丟业丏丕东丗下一(一丐丅且丛不不丌丗:  this.丐七丂万丂丛专上丄, 丗丒世丒东丆丅一七:  false, 世万丐专世丕业丟东:  0);
            goto label_30;
            label_10:
            if((this._likeGuiObj.丑丆丏丟丗丌丄丟丝() == true) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
            {
                goto label_30;
            }
            
            if(this._categoryRootObj.activeInHierarchy == false)
            {
                goto label_17;
            }
            
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  0);
            this.丝丗下丅业丟丟世丄 = 0;
            goto label_30;
            label_7:
            UnityEngine.AsyncOperation val_7 = UnityEngine.Resources.UnloadUnusedAssets();
            this.丆丗丟与丏丁且丒丕 = 0;
            if(this._itemsScrollContainer.activeInHierarchy == false)
            {
                goto label_20;
            }
            
            this._itemsScrollContainer.SetActive(value:  false);
            this.丐七丂万丂丛专上丄 = 0;
            this.丏东世丝业专三丞丌();
            val_18 = Rilisoft.LobbyItemsController.丌丐七丕丅丙不一丐(一丐丅且丛不不丌丗:  this.丐七丂万丂丛专上丄);
            goto label_24;
            label_20:
            this.丐七丂万丂丛专上丄 = 0;
            this.丏东世丝业专三丞丌();
            if(this._categoryRootObj.activeInHierarchy == false)
            {
                goto label_26;
            }
            
            this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
            PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
            goto label_28;
            label_17:
            if(this._categoryDecorationsObj.activeInHierarchy != false)
            {
                    this.三丟一万丙丞且丘专();
                this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  1);
                this.丝丗下丅业丟丟世丄 = 1;
            }
            
            label_30:
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
            Rilisoft.丏丘七丞丄丙丌丞丁 val_14 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丐且丐业丙世丞与();
            if(val_14 != null)
            {
                    this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_14);
            }
            
            label_35:
            this.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
            return;
            label_26:
            val_18 = 0;
            label_24:
            this.丐丟业丏丕东丗下一(一丐丅且丛不不丌丗:  val_18, 丗丒世丒东丆丅一七:  false, 世万丐专世丕业丟东:  0);
            label_28:
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                goto label_35;
            }
            
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
            goto label_35;
        }
        private void 丝与丟丕且丈丙且上(Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙)
        {
            if(this.丈与丏业丗丗丒七万 != false)
            {
                    return;
            }
            
            if(丑丘丕且丆东丏丘丙 == null)
            {
                    return;
            }
            
            if(this._likeGuiObj.activeInHierarchy == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  丑丘丕且丆东丏丘丙.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) != false)
            {
                    this.三丟一万丙丞且丘专();
            }
            
            if((this.下且丐丈丐东丗丟丄 == null) && (this._screenPanel.activeInHierarchy != true))
            {
                    if(this._cameraSettingsPanel.activeInHierarchy != true)
            {
                    this.上丕且丁一丐丞丐丐(丑丘丕且丆东丏丘丙:  丑丘丕且丆东丏丘丙);
            }
            
            }
            
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                    return;
            }
            
            if(BankController.丑七不且上丗丁一世() != 0)
            {
                    if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
            {
                    return;
            }
            
            }
            
            if(this._screenPanel.activeInHierarchy == true)
            {
                    return;
            }
            
            if(this._cameraSettingsPanel.activeInHierarchy == true)
            {
                    return;
            }
            
            if(this._likeGuiObj.activeInHierarchy == true)
            {
                    return;
            }
            
            if(this.下且丐丈丐东丗丟丄 != null)
            {
                    this.丌丏丛万丂下丐丈丕.Enqueue(item:  丑丘丕且丆东丏丘丙);
                return;
            }
            
            this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  丑丘丕且丆东丏丘丙);
        }
        private void 东丂东丟世七业丙丟()
        {
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                    return;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丐且丐业丙世丞与();
            if(val_2 == null)
            {
                    return;
            }
            
            this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_2);
        }
        private void 丙丄丛三丒丈下丄丛(Rilisoft.丏丘七丞丄丙丌丞丁 丘丂世不丌上且且一)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
            {
                    return;
            }
            
            if(丘丂世不丌上且且一 == null)
            {
                    Rilisoft.丏丘七丞丄丙丌丞丁 val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丐且丐业丙世丞与();
                if(val_3 == null)
            {
                    return;
            }
            
            }
            
            if(this.丐丄丘丂丈丒丌七专 != 0)
            {
                    this.丐丄丘丂丈丒丌七专 = 0;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  28);
            this.下且丐丈丐东丗丟丄 = val_3;
            if(this._speedUpWindow.IsVisible != false)
            {
                    this._speedUpWindow.Hide();
            }
            
            this.上丛丑丂且丘丐丈丙 = true;
            val_20 = null;
            val_20 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_32;
            }
            
            val_21 = null;
            val_21 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.rotateCamera == 0)
            {
                goto label_32;
            }
            
            val_22 = null;
            val_22 = null;
            if((CanZoomTo(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄)) == false)
            {
                goto label_32;
            }
            
            this.三丂丏丅丆丙丝丒丂 = this._mainPanel.activeSelf;
            this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  false);
            val_23 = null;
            val_23 = null;
            PlayLobbyItemZoom(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
            this.东三丟东业上一丅下 = activeSelf;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  false);
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioSource val_15 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this._cameraZoomInAudio);
            }
            
            if(Rilisoft.LobbyCraftController.丙下与三丟丑业上专 != null)
            {
                    Rilisoft.LobbyCraftController.丙下与三丟丑业上专.Invoke(obj:  true);
            }
            
            val_24 = null;
            val_24 = null;
            LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  false);
            goto label_52;
            label_32:
            this.三丞丁丗丟万业丗专(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
            label_52:
            PGCompany.Analytics.一业丗丆世世上丁且.丄专丕丑丗三丅七丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞丙上一丁丐丌与丝:  this.下且丐丈丐东丗丟丄, 丒世丘丘上丆丝东丞:  this.下且丐丈丐东丗丟丄.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal void 三丞丁丗丟万业丗专(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            bool val_17;
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            val_17 = 下丅丙一丂丗丅丝七.丌七丌下丙三世丅一();
            if(val_1.IsCraftedAndNotShown == false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  139);
            Rilisoft.LobbyItemPlayerInfo val_3 = 下丅丙一丂丗丅丝七.丌七丌下丙三世丅一();
            val_3.IsCraftedAndNotShown = false;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专专丙丂丌上三业万(丑丘丕且丆东丏丘丙:  下丅丙一丂丗丅丝七.丌七丌下丙三世丅一(), 丛丏丟万世丐丒丛丁:  下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().三丌专三东世丆东专());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            this.下且丐丈丐东丗丟丄 = 0;
            if((System.String.op_Equality(a:  下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) != false)
            {
                    this.三丟一万丙丞且丘专();
                this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  4);
                this.丝丗下丅业丟丟世丄 = 4;
            }
            
            val_17 = this.上专丆丘业一不业专;
            bool val_13 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业();
            if(val_17 == false)
            {
                goto label_14;
            }
            
            if(val_13 == false)
            {
                goto label_16;
            }
            
            System.Action val_15 = null;
            val_17 = val_15;
            val_15 = new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftController::不丏丁丑丛丅与下丕());
            this.丝业业丝丕丁丅丅丘(丘万且丑丂丈丈业丑:  false, 下丕下丅丙丞丐东丗:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyCraftController::丌丅丁且丁万东丅丕()), 丝丆丗一上且三丒丄:  val_15);
            goto label_16;
            label_14:
            this.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  val_13, 丅丁三世丝三丞专世:  true, 丝一专专丏丝丘丒东:  true);
            label_16:
            this.上专丆丘业一不业专 = false;
        }
        internal void 丈丑丙丌丛东丙丅丐(string 丆万一不丌且东丐丐, int 丌丒丝东丌下丕丁丅 = 1)
        {
            this.丐丄丘丂丈丒丌七专 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丕丁下丌不万丅丞丛:  丆万一不丌且东丐丐, 丅三丟世下丞丝丙万:  丌丒丝东丌下丕丁丅, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        }
        internal void 丄业万万丄丕丗与丑(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            null = null;
            PlayFromItem();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this._cameraZoomOutAudio);
        }
        internal static void 上丙丛丅丁与专下一(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  Rilisoft.LobbyCraftController.丙下与三丟丑业上专, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.LobbyCraftController.丙下与三丟丑业上专 != 1152921505471332384);
        
        }
        internal static void 丁丞丐丟丘丏丟与丂(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  Rilisoft.LobbyCraftController.丙下与三丟丑业上专, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(Rilisoft.LobbyCraftController.丙下与三丟丑业上专 != 1152921505471332384);
        
        }
        internal void 丝业业丝丕丁丅丅丘(bool 丘万且丑丂丈丈业丑, System.Action 下丕下丅丙丞丐东丗, System.Action 丝丆丗一上且三丒丄)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.windowForAcceptSeasonLobby, 丏业丟一东丂东丘丛:  true);
            this.windowForAcceptSeasonLobby.Setup(丘万且丑丂丈丈业丑:  丘万且丑丂丈丈业丑, 丙万丌专丟丌丘丆丞:  下丕下丅丙丞丐东丗, 丁丙丆丙丑丅丅丞东:  丝丆丗一上且三丒丄);
        }
        internal void 丆上业与下丟三丆丛()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.windowForAcceptSeasonLobby, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丙专且一丗一丘丂世(bool 丙业与丙丗丝不丈东, bool 丅丁三世丝三丞专世 = True, bool 丝一专专丏丝丘丒东 = True)
        {
            LobbyItemSeason val_19;
            bool val_20;
            var val_21;
            var val_22;
            var val_23;
            LobbySeasonController val_24;
            var val_25;
            var val_26;
            var val_27;
            val_20 = 丙业与丙丗丝不丈东;
            if(丝一专专丏丝丘丒东 != false)
            {
                    val_19 = this._scrollLobbySeasonItem;
                bool val_1 = val_20;
                this.丒七上三丄丂丝丁丑 = val_1;
                this.七丑丘丝丒丞丑丈东 = true;
                val_19.一丟上丟且业下丐业(丙业与丙丗丝不丈东:  val_1);
                this.上丛丑丂且丘丐丈丙 = true;
            }
            
            val_21 = null;
            val_21 = null;
            if(LobbySeasonController.instance != 0)
            {
                    val_22 = null;
                val_22 = null;
                LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  val_20);
            }
            
            val_23 = null;
            val_23 = null;
            val_24 = LobbySeasonController.instance;
            if(LobbySeasonController.instance.与三丂与世丗丆丆丗 != false)
            {
                    val_25 = null;
                val_25 = null;
                LobbySeasonController.instance.与三丂与世丗丆丆丗 = false;
                val_24 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
                val_19 = mem[val_20 != true ? "season" : "user"];
                val_19 = (val_20 != true) ? "season" : "user";
                PGCompany.Analytics.一业丗丆世世上丁且.与丞东专丒三一专不(丆丛丑世下一丐且丕:  val_24, 世不下丟世一丝丐丗:  LobbySeasonController.instance.seasonNameEn, 丕丆丟丘上丆丒丘不:  val_19);
            }
            
            if(丅丁三世丝三丞专世 == false)
            {
                    return;
            }
            
            val_26 = null;
            val_26 = null;
            if(LobbySeasonController.instance != 0)
            {
                    if(((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) ^ val_20) != false)
            {
                    val_27 = null;
                val_27 = null;
                val_24 = mem[LobbySeasonController.instance + 112];
                val_24 = LobbySeasonController.instance.seasonNameEn;
                PGCompany.Analytics.一业丗丆世世上丁且.与丞东专丒三一专不(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 世不下丟世一丝丐丗:  val_24, 丕丆丟丘上丆丒丘不:  (val_20 != true) ? "season" : "user");
            }
            
            }
            
            业丂丏与世一丏业不.丑七不且上丗丁一世().丈万丆丄丞丅且七七(丙业与丙丗丝不丈东:  true);
            Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丄丏丐三丌丒丝不不(丙业与丙丗丝不丈东:  val_20);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  128, 丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  val_20));
            val_20 = Rilisoft.丛丅丘业丏丕下业丏.丑七不且上丗丁一世();
            val_20.东三世丈东丝丄与业(七丆丟丗世丟且丒丆:  true);
        }
        private int 世下丌丙与丛东丝丙()
        {
            return (int)this.丝丗下丅业丟丟世丄;
        }
        private void 丈与丏上丝丏丌丗丞(int 丙业与丙丗丝不丈东)
        {
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  丙业与丙丗丝不丈东);
            this.丝丗下丅业丟丟世丄 = 丙业与丙丗丝不丈东;
        }
        private bool 丑丆丏丟丗丌丄丟丝()
        {
            return Rilisoft.LobbyItemsController.丑丆丏丟丗丌丄丟丝();
        }
        private UnityEngine.GameObject 与丏丏丏丁与丘丛丌(int 丛东与丑丌丗东丕丗)
        {
            return (UnityEngine.GameObject)丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  this._tutorialHintsContainer, 丒丘丏上丙丟丑丕丈:  丛东与丑丌丗东丕丗.ToString(), 丟丝七七一丁丏丏丙:  true);
        }
        private void 七业丑三丈丈丒下三(int 丛东与丑丌丗东丕丗)
        {
            UnityEngine.GameObject val_1 = this.与丏丏丏丁与丘丛丌(丛东与丑丌丗东丕丗:  丛东与丑丌丗东丕丗);
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.SetActive(value:  true);
        }
        private void 三丟一万丙丞且丘专()
        {
            var val_3;
            System.Action<UnityEngine.GameObject> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = LobbyCraftController.<>c.<>9__156_0;
            if(val_5 == null)
            {
                    System.Action<UnityEngine.GameObject> val_2 = null;
                val_5 = val_2;
                val_2 = new System.Action<UnityEngine.GameObject>(object:  LobbyCraftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LobbyCraftController.<>c::万与丑万世丛丄丂世(UnityEngine.GameObject 丁丂专业丁丅丅丈丙));
                LobbyCraftController.<>c.<>9__156_0 = val_5;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this._tutorialHintsContainer), 七丐丅专且专七三丆:  val_2);
        }
        public void OnZoomIn()
        {
            this.丛丅专丑丏丂丞丏上().Show(丑丘丕且丆东丏丘丙:  this.下且丐丈丐东丗丟丄);
        }
        public void OnZoomOut()
        {
            var val_4;
            this.丛丅专丑丏丂丞丏上().Hide();
            if(this.三丂丏丅丆丙丝丒丂 != false)
            {
                    this.三丕丕上且三丙丅世(丙业与丙丗丝不丈东:  true);
                this.七丄业丌丒丄丟丌丗 = false;
                this.七丑丘丝丒丞丑丈东 = true;
            }
            
            if(this.东三丟东业上一丅下 != false)
            {
                    val_4 = null;
                val_4 = null;
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this.丌丏丛万丂下丐丈丕.Count < 1)
            {
                goto label_10;
            }
            
            this.三丞丁丗丟万业丗专(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
            Rilisoft.丏丘七丞丄丙丌丞丁 val_3 = this.丌丏丛万丂下丐丈丕.Dequeue();
            if(val_3 == null)
            {
                goto label_13;
            }
            
            this.上丕且丁一丐丞丐丐(丑丘丕且丆东丏丘丙:  val_3);
            this.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
            this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_3);
            goto label_13;
            label_10:
            if((this.三丂丏丅丆丙丝丒丂 != false) && (this.下且丐丈丐东丗丟丄 != null))
            {
                    this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  this.下且丐丈丐东丗丟丄, 丕丝丟下丗丛一丕业:  true);
            }
            
            this.三丞丁丗丟万业丗专(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
            label_13:
            if(Rilisoft.LobbyCraftController.丙下与三丟丑业上专 == null)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丙下与三丟丑业上专.Invoke(obj:  false);
        }
        public void U_BackButtonAction()
        {
            this.且万丅上上丁业世与();
        }
        public void U_ToScreenViewAction()
        {
            this.丅专且丟丑丛东丏三();
        }
        public void U_ToCameraSettingsAction()
        {
            this.业上丛丕业上丙万丞();
        }
        public void U_ToLikePanel()
        {
            this.丙不丘与丏丄丒不丄();
        }
        public void TurnOn()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        public void TurnOff()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public bool IsVisibleLobbyMenu()
        {
            return false;
        }
        public bool IsEnabledLobbyCamera()
        {
            return true;
        }
        public float GetDelayTurnOff()
        {
            return 0f;
        }
        public LobbyCraftController()
        {
            this.丗不一丗丅七丘丕一 = new System.Collections.Generic.Dictionary<LobbyItemSlot, UnityEngine.Transform>();
            this.下业丝丞丈丂丁丛丑 = new System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆>();
            this.丕丏丑丐业丛世一丟 = new System.Collections.Generic.List<Rilisoft.上丆丕业丘业丈丄丆>();
            this.丑万丆丅丁与丂丌丒 = new System.Collections.Generic.List<Rilisoft.上丆丕业丘业丈丄丆>();
            this.丌丏丛万丂下丐丈丕 = new System.Collections.Generic.Queue<Rilisoft.丏丘七丞丄丙丌丞丁>();
        }
        private bool 丗业丘丛丐丏丒业专(Rilisoft.上丆丕业丘业丈丄丆 业下丌下三丕丙丌下)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (bool)(业下丌下三丕丙丌下.LobbyItem == this.丆丗丟与丏丁且丒丕) ? 1 : 0;
        }
        private void 一丈丛丁业丌三丁丂(Rilisoft.上丆丕业丘业丈丄丆 业下丌下三丕丙丌下)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            业下丌下三丕丙丌下.IsSelected = (this.丒七上三丄丂丝丁丑 == false) ? 1 : 0;
            var val_5 = 0;
            val_5 = val_5 + 1;
            业下丌下三丕丙丌下.UpdateView();
        }
        private void 丌丅丁且丁万东丅丕()
        {
            this.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  false, 丅丁三世丝三丞专世:  true, 丝一专专丏丝丘丒东:  true);
            this.丆上业与下丟三丆丛();
        }
        private void 不丏丁丑丛丅与下丕()
        {
            this.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  true, 丅丁三世丝三丞专世:  true, 丝一专专丏丝丘丒东:  true);
            this.丆上业与下丟三丆丛();
        }
    
    }

}
