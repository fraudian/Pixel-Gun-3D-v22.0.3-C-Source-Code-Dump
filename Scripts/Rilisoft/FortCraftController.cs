using UnityEngine;

namespace Rilisoft
{
    public class FortCraftController : MonoBehaviour
    {
        // Fields
        internal static UnityEngine.GameObject 丅丄万东丅丏业丑丛;
        internal static Rilisoft.FortCraftController 丆丕丝丒不丙且丐丗;
        private static UnityEngine.GameObject 丗东与丝丞丕丘丁丌;
        internal static string 世一且丗丙丈丙七丛;
        private readonly System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, UnityEngine.Transform> 丗不一丗丅七丘丕一;
        private readonly System.Collections.Generic.List<Rilisoft.丕丂丒丁丏东且一七> 丕丏丑丐业丛世一丟;
        private readonly System.Collections.Generic.List<Rilisoft.丕丂丒丁丏东且一七> 丑万丆丅丁与丂丌丒;
        private Rilisoft.专丕丝丏丒一一万丏<Rilisoft.FortBuildingReadyWindow> 丄下丕与东专丆丞丁;
        private Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.ClanStockWindow> 专且且丏丈丐上丕丗;
        private Rilisoft.东且东丒丐世丐丞丒 丙七东业丈东东一不;
        private Rilisoft.东且东丒丐世丐丞丒 下且丐丈丐东丗丟丄;
        private System.Collections.Generic.Queue<Rilisoft.东且东丒丐世丐丞丒> 丌丏丛万丂下丐丈丕;
        private Rilisoft.FortItemGroupType 丒丞丟丅丝不丝丒一;
        private Rilisoft.FortItemGroupType 丛丌丞一丑丛丂丞丑;
        private bool 业丕三万丂东丁丗三;
        private System.IDisposable 且丂七丑丈丞丈三丑;
        private bool 丆丟丟七丗丂丏丒丐;
        private UIGrid 丘丞下丛世七丐丐丒;
        private Rilisoft.UIScrollManager 东丒丝丁丛七丄世丝;
        private bool 东三丟东业上一丅下;
        private bool 七丄业丌丒丄丟丌丗;
        private Rilisoft.FortItemGroupType 丁丕丏七上业丄万丛;
        private bool 不丆三丞丞丏上丕不;
        private Rilisoft.东且东丒丐世丐丞丒 三七且丟丒丟丈丐丄;
        private Rilisoft.东且东丒丐世丐丞丒 丆丗丟与丏丁且丒丕;
        private 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丑上一不丅丈业丟丛;
        private bool 三丂丏丅丆丙丝丒丂;
        private bool 七丑丘丝丒丞丑丈东;
        private bool 丆三丑万丂丌世丆丆;
        private 丞丂丘丒丟丞丑下丄 专丁丕丞丑丕丕丟下;
        public bool isZoomItem;
        private bool <专世丅丁上丝三丈与>k__BackingField;
        private static System.Action 专丆且丄丈丟丒业丄;
        private static System.Action 丛丛丟丕丕丛丟丑丌;
        private System.Action 丄丑上丕丂丈丘丙七;
        private UnityEngine.GameObject _mainPanel;
        private UnityEngine.GameObject _screenPanel;
        private UnityEngine.GameObject _cameraSettingsPanel;
        private UnityEngine.GameObject _categoriesContainer;
        private UnityEngine.GameObject _categoryRootObj;
        private UnityEngine.GameObject _categoryDecorationsObj;
        private UnityEngine.GameObject _categoryDeffenceRootObj;
        private UnityEngine.GameObject _categoryFortRootObj;
        private UnityEngine.GameObject _categoryBridgeRootObj;
        private UnityEngine.GameObject _categoryTurretsRootObj;
        private UnityEngine.GameObject _categoryTurretsFar1Obj;
        private UnityEngine.GameObject _categoryTurretsFar2Obj;
        private UnityEngine.GameObject _categoryTurretsNier1Obj;
        private UnityEngine.GameObject _categoryTurretsNier2Obj;
        private UIButton _stockButton;
        private UnityEngine.GameObject _itemsScrollContainer;
        private UIScrollView _itemsScroll;
        private Rilisoft.FortCraftScrollItemView _scrollDefaultItem;
        private Rilisoft.FortItemSpeedUpWindow _speedUpWindow;
        private Rilisoft.PrefabHandler _buildedWindowPrefabHandler;
        private UnityEngine.GameObject _connectionErrorBanner;
        private Rilisoft.TextGroup _headerText;
        private UnityEngine.GameObject _tutorialHintsContainer;
        private UnityEngine.GameObject _likeGuiObj;
        private UnityEngine.GameObject _likeButtonObj;
        private UnityEngine.AudioClip _speedUpAudio;
        private UnityEngine.AudioClip _craftBeganAudio;
        private UnityEngine.AudioClip _cameraZoomInAudio;
        private UnityEngine.AudioClip _cameraZoomOutAudio;
        private FortRatingPanelController fortRatingPanel;
        private System.Collections.Generic.List<Rilisoft.FortCraftController.FortItemsGroupSettings> _groupsSettings;
        private string fortBackGroundMusicName;
        private int 丝丗下丅业丟丟世丄;
        
        // Properties
        internal static UnityEngine.GameObject 丆丂下丐丙丙上七与 { get; }
        internal string 丄丁丐业万丈丂东下 { get; }
        internal 丞丂丘丒丟丞丑下丄 丞丙丌万丒业业丑世 { get; }
        private Rilisoft.FortItemGroupType 丅专且丏丂丂丑丆三 { get; set; }
        private Rilisoft.FortBuildingReadyWindow 世与与且丌且丒丞丝 { get; }
        internal bool 不丁丄丌丒上丅丂丟 { get; set; }
        internal 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 下丏丁七丞不上丘不 { get; }
        public bool 丐丘丐且业三丑丅丈 { get; set; }
        private int 东丘且丌丙不专一丆 { get; set; }
        private bool 丛丏且丗世七丞丝丐 { get; }
        
        // Methods
        internal static UnityEngine.GameObject 七上丌上丗丕世丝下()
        {
            CraftFortPlacePoints val_1 = CraftFortPlacePoints.instance;
            if(val_1 != null)
            {
                    return val_1.gameObject;
            }
            
            return val_1.gameObject;
        }
        internal string 与万上丗上丕三丐七()
        {
            return (string)this.fortBackGroundMusicName;
        }
        internal 丞丂丘丒丟丞丑下丄 业三丐丐三丒丙上万()
        {
            return (丞丂丘丒丟丞丑下丄)this.专丁丕丞丑丕丕丟下;
        }
        private Rilisoft.FortItemGroupType 三不且万丐七丒丒丟()
        {
            return (Rilisoft.FortItemGroupType)this.丒丞丟丅丝不丝丒一;
        }
        private void 一丙丕三丌与下不丅(Rilisoft.FortItemGroupType 丙业与丙丗丝不丈东)
        {
            this.丒丞丟丅丝不丝丒一 = 丙业与丙丗丝不丈东;
            if(this._headerText == 0)
            {
                    return;
            }
            
            this._headerText.Text = this.丅丟丟丏丘三丞丕业(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一);
        }
        private Rilisoft.FortBuildingReadyWindow 丛丅专丑丏丂丞丏上()
        {
            if(this.丄下丕与东专丆丞丁 != null)
            {
                    return 0.世三丞丅丑丌丈丈一();
            }
            
            Rilisoft.专丕丝丏丒一一万丏<Rilisoft.FortBuildingReadyWindow> val_3 = new Rilisoft.专丕丝丏丒一一万丏<Rilisoft.FortBuildingReadyWindow>(丑且不丕与专丄业丙:  this._buildedWindowPrefabHandler.Prefab, 丆丏七丟不丒与七专:  this.gameObject);
            this.丄下丕与东专丆丞丁 = val_3;
            val_3.世三丞丅丑丌丈丈一().add_OnWindowClose(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒>(object:  this, method:  System.Void Rilisoft.FortCraftController::丄业万万丄丕丗与丑(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)));
            if(this.丄下丕与东专丆丞丁 != null)
            {
                    return 0.世三丞丅丑丌丈丈一();
            }
            
            return 0.世三丞丅丑丌丈丈一();
        }
        internal bool 上丙丆不丂丂丄一丂()
        {
            return (bool)this.丆丟丟七丗丂丏丒丐;
        }
        internal void 丟丁专丁丈丕丁一丙(bool 丙业与丙丗丝不丈东)
        {
            System.EventHandler val_19;
            object val_20;
            var val_21;
            var val_22;
            var val_23;
            UnityEngine.Object val_24;
            var val_25;
            UnityEngine.Object val_26;
            var val_27;
            var val_29;
            System.Action val_30;
            val_20 = this;
            var val_1 = (this.丆丟丟七丗丂丏丒丐 == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            bool val_2 = 丙业与丙丗丝不丈东;
            this.丆丟丟七丗丂丏丒丐 = val_2;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  val_2);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  this.丆丟丟七丗丂丏丒丐);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemsScrollContainer, 丏业丟一东丂东丘丛:  false);
            if(丙业与丙丗丝不丈东 != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            }
            
            val_19 = 1152921505080860672;
            val_21 = null;
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                goto label_7;
            }
            
            val_22 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_23 = null;
                val_23 = null;
                System.EventHandler val_4 = null;
                val_19 = val_4;
                val_4 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.FortCraftController::丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                MainMenuController.丄丞丁丈与业上丞丟.丌丁丆丁万上丁丘丑(丙业与丙丗丝不丈东:  val_4);
            }
            
            val_24 = this._headerText;
            if(val_24 != 0)
            {
                    val_19 = this.丅丟丟丏丘三丞丕业(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一);
                val_24 = this._headerText;
                val_24.Text = val_19;
            }
            
            if(this.且丂七丑丈丞丈三丑 == null)
            {
                    System.Action val_8 = null;
                val_19 = val_8;
                val_8 = new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftController::且万丅上上丁业世与());
                this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_8, 与且专丈不万东一万:  "FortCraft");
            }
            
            if(this.丆三丑万丂丌世丆丆 != true)
            {
                    val_24 = val_20;
                this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  false);
            }
            
            if(this.丑丆丏丟丗丌丄丟丝() != true)
            {
                    this.三丟一万丙丞且丘专();
                this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  0);
                this.丝丗下丅业丟丟世丄 = 0;
            }
            
            if(this.丌丏丛万丂下丐丈丕.Count < 1)
            {
                goto label_46;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_12 = this.丌丏丛万丂下丐丈丕.Dequeue();
            if(val_12 == null)
            {
                goto label_46;
            }
            
            val_19 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_12, 丆丐专丘丅万丂丐不:  val_19.丏世丛丂与丐丟与丏());
            goto label_46;
            label_7:
            val_25 = null;
            val_26 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_26 != 0)
            {
                    val_27 = null;
                val_27 = null;
                System.EventHandler val_16 = null;
                val_19 = val_16;
                val_16 = new System.EventHandler(object:  this, method:  System.Void Rilisoft.FortCraftController::丁丁丑丙丙一丈丐丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
                val_26 = MainMenuController.丄丞丁丈与业上丞丟;
                val_26.丒丟万丂万丆业三丑(丙业与丙丗丝不丈东:  val_16);
            }
            
            if(this.且丂七丑丈丞丈三丑 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_26 = this.且丂七丑丈丞丈三丑;
                val_26.Dispose();
                this.且丂七丑丈丞丈三丑 = 0;
            }
            
            if(val_26.丑丆丏丟丗丌丄丟丝() != true)
            {
                    this.三丟一万丙丞且丘专();
                this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  0);
                this.丝丗下丅业丟丟世丄 = 0;
            }
            
            if(this.丆三丑万丂丌世丆丆 != true)
            {
                    this.三丟一万丙丞且丘专();
                this.SetMySceneViews(丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  false);
            }
            
            label_46:
            val_20 = 1152921505448005632;
            val_29 = null;
            val_29 = null;
            val_30 = Rilisoft.FortCraftController.专丆且丄丈丟丒业丄;
            if(val_30 == null)
            {
                    return;
            }
            
            val_30 = Rilisoft.FortCraftController.专丆且丄丈丟丒业丄;
            if(val_30 == null)
            {
                    val_30 = 0;
            }
            
            val_30.Invoke();
        }
        internal 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丆丘世丛丗丘三丌丙()
        {
            return (丗丞丏丙七丑丕且丐)this.丑上一不丅丈业丟丛;
        }
        public bool get_IsInitialized()
        {
            return (bool)this.<专世丅丁上丝三丈与>k__BackingField;
        }
        protected void 东丐丝七丞世丅丘一(bool 丙业与丙丗丝不丈东)
        {
            this.<专世丅丁上丝三丈与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丈丈东三丙且丟丗下(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortCraftController.专丆且丄丈丟丒业丄, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortCraftController.专丆且丄丈丟丒业丄 != 1152921505448009760);
        
        }
        internal static void 东三世丟世业不丏上(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortCraftController.专丆且丄丈丟丒业丄, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortCraftController.专丆且丄丈丟丒业丄 != 1152921505448009760);
        
        }
        internal static void 丈且丗丞丕世且丁丟(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌 != 1152921505448009768);
        
        }
        internal static void 丌上丕丈丛丝三且七(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌 != 1152921505448009768);
        
        }
        internal void 丄东丘七世世丞不丛()
        {
            this.ShowConnectionErrorBanner();
        }
        internal static void 三专业与丑丈丈与丐(bool 不与万丌一丈下丑丈)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  Rilisoft.FortCraftController.七上丌上丗丕世丝下(), 丏业丟一东丂东丘丛:  不与万丌一丈下丑丈);
        }
        internal void 丘万丟丕业不万丂丁(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丑上丕丂丈丘丙七, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丑上丕丂丈丘丙七 != 1152921542638138272);
        
        }
        internal void 丅七丅丐丗丛一丑丁(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丑上丕丂丈丘丙七, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丑上丕丂丈丘丙七 != 1152921542638274848);
        
        }
        internal static int 东七丞丄丌与丌丄丅(UnityEngine.GameObject 丕专上丁丅丅丏万丌, System.Action 丘丗不丁丘丒丅丌不, 丞丂丘丒丟丞丑下丄 丞丌丐丞丞丘丏专下, bool 丘丌与上三且丈东东 = False)
        {
            UnityEngine.GameObject val_34;
            System.Object[] val_35;
            System.Action val_36;
            var val_37;
            var val_38;
            string val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            val_35 = 丞丌丐丞丞丘丏专下;
            val_36 = 丘丗不丁丘丒丅丌不;
            if(val_36 == null)
            {
                    if(丕专上丁丅丅丏万丌 == 0)
            {
                goto label_4;
            }
            
            }
            
            val_37 = null;
            val_37 = null;
            if(Rilisoft.FortCraftController.丗东与丝丞丕丘丁丌 != 0)
            {
                goto label_14;
            }
            
            val_38 = null;
            val_38 = null;
            Rilisoft.FortCraftController.丗东与丝丞丕丘丁丌 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/Fort/FortCraftGui");
            val_34 = Rilisoft.FortCraftController.丗东与丝丞丕丘丁丌;
            if(val_34 != 0)
            {
                goto label_14;
            }
            
            val_35 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "prefab not found FortCraft", args:  val_35);
            label_4:
            val_39 = 0;
            return (int)val_39;
            label_14:
            val_40 = null;
            val_40 = null;
            val_41 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_42 = null;
                UnityEngine.Object.Destroy(obj:  Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.gameObject);
                val_43 = null;
                Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 = 0;
            }
            
            val_43 = null;
            UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  Rilisoft.FortCraftController.丗东与丝丞丕丘丁丌);
            val_8.transform.SetParent(p:  丕专上丁丅丅丏万丌.transform);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            val_8.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_8, 不东丛三丂丌丑专丆:  丕专上丁丅丅丏万丌.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
            this.丘万丟丕业不万丂丁(丙业与丙丗丝不丈东:  val_36);
            mem[174] = 丘丌与上三且丈东东;
            val_34 = 1152921524473519280;
            this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
            val_44 = null;
            if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == null)
            {
                    val_44 = null;
            }
            
            if(mem[174] != false)
            {
                    val_45 = null;
                this.一丙丕三丌与下不丅(丙业与丙丗丝不丈东:  0);
                this.丅专且丟丑丛东丏三();
            }
            else
            {
                    val_46 = null;
                this.GoToGroup(一丐丅且丛不不丌丗:  0, 丗丒世丒东丆丅一七:  true, 丌丒丌丁丛丕专丗丝:  false);
            }
            
            if((((Rilisoft.Singleton<ClansController>.Instance) != 0) && ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)) && ((System.String.op_Equality(a:  val_35.业丐丐三丕一丗丛丁(), b:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁())) != false))
            {
                    val_47 = null;
                val_47 = null;
                val_36 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
                mem[176] = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
                this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
            }
            else
            {
                    val_48 = null;
                val_48 = null;
                if(Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 == null)
            {
                    val_48 = null;
            }
            
                mem[176] = val_35;
                val_36 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
                this.SetSceneViews(丆丛与丅丙丒下丝丏:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丗丈专上不万丙丛丟(丄丒下业一不丈丝丘:  val_35.业丐丐三丕一丗丛丁(), 丈丙七丆丂七丌丒丏:  "{}"), 丒丞丐丘且不且丟东:  true);
            }
            
            val_49 = null;
            val_49 = null;
            0.丒东丝下丒东七且丙(丞丌丐丞丞丘丏专下:  val_35);
            val_39 = Rilisoft.FortCraftController.世一且丗丙丈丙七丛;
            if(val_39 == null)
            {
                    return (int)val_39;
            }
            
            val_50 = null;
            val_50 = null;
            val_35 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  Rilisoft.FortCraftController.世一且丗丙丈丙七丛);
            if(val_35 != null)
            {
                    val_51 = null;
                val_51 = null;
                val_36 = val_35.丘专上世与丟丝丟丛();
                this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  val_35, 丕丝丟下丗丛一丕业:  true, 与丄不丌一世东丁丙:  val_36, 与七丁与丌丒丝专一:  true);
            }
            
            val_52 = null;
            val_52 = null;
            val_39 = 0;
            Rilisoft.FortCraftController.世一且丗丙丈丙七丛 = 0;
            return (int)val_39;
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
            null = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 = this;
            this.丘上丐世丆丑且丞丒();
            this.专且且丏丈丐上丕丗 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.ClanStockWindow>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.ClanStockWindow>(object:  this, method:  Rilisoft.ClanStockWindow Rilisoft.FortCraftController::丄丙业与东丏丛丒三()));
            BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftController::东丂东丟世七业丙丟()));
            BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftController::东丂东丟世七业丙丟()));
        }
        internal void 丘上丐世丆丑且丞丒()
        {
            var val_28;
            if((this.<专世丅丁上丝三丈与>k__BackingField) != false)
            {
                    return;
            }
            
            AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "FortCraftController start init");
            this.<专世丅丁上丝三丈与>k__BackingField = true;
            this.丑万丆丅丁与丂丌丒.Add(item:  this._scrollDefaultItem);
            var val_28 = 0;
            do
            {
                Rilisoft.丕丂丒丁丏东且一七 val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._scrollDefaultItem.gameObject).GetComponent<Rilisoft.丕丂丒丁丏东且一七>();
                var val_26 = 0;
                val_26 = val_26 + 1;
                val_3.Setup(七万上丐一丈丏丏专:  0, 丒专丈丛下丒一丒丛:  this, 下丅丙一丂丗丅丝七:  0, 不丝丄丒丌丐一一与:  0);
                var val_27 = 0;
                val_27 = val_27 + 1;
                val_3.Hide();
                this.丑万丆丅丁与丂丌丒.Add(item:  val_3);
                val_28 = val_28 + 1;
            }
            while(val_28 != 10);
            
            AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "FortCraftController Instantiate items");
            val_28 = null;
            val_28 = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗 = this;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._scrollDefaultItem.gameObject, 丏业丟一东丂东丘丛:  false);
            this.丘丞下丛世七丐丐丒 = this._itemsScroll.gameObject.GetComponentInChildren<UIGrid>();
            this.东丒丝丁丛七丄世丝 = this._itemsScroll.gameObject.GetComponent<Rilisoft.UIScrollManager>();
            Rilisoft.FortsManager.与丌丌丒丘丅一丒上(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.丏丏与一丁丄世世万(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::丝与丟丕且丈丙且上(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.专丏业且丙丆丁且丈(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::丝与丟丕且丈丙且上(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.万丂丐一世业世万丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.三丘丒丞丕下丘万丂(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.七万丐丟业业且丕丂(丙业与丙丗丝不丈东:  new System.Action<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒>(object:  this, method:  System.Void Rilisoft.FortCraftController::世丐与下丂业上丗丛(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 下不万下且丂业丌丘, Rilisoft.东且东丒丐世丐丞丒 丌丏丗与丕丈丄三丈, Rilisoft.东且东丒丐世丐丞丒 丏一丕东丙丆与丒丄)));
            Rilisoft.FortsManager.东与丐东下丈七不丒(丙业与丙丗丝不丈东:  new System.Action<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒>(object:  this, method:  System.Void Rilisoft.FortCraftController::世丐与下丂业上丗丛(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 下不万下且丂业丌丘, Rilisoft.东且东丒丐世丐丞丒 丌丏丗与丕丈丄三丈, Rilisoft.东且东丒丐世丐丞丒 丏一丕东丙丆与丒丄)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._speedUpWindow.gameObject, 丏业丟一东丂东丘丛:  false);
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.七丄业丅专上丌丅丙()) != false)
            {
                    AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "FortCraftController start SetMySceneViews");
                AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "FortCraftController SetMySceneViews");
            }
            else
            {
                    Rilisoft.FortsManager.丟丟且世丘丒丞丏丒(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.FortCraftController::世丄东丏丟丝下丁一(bool 丌丗丏丏丛东专丁且)));
            }
            
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丛丁丞专七丛世三不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftController::下与三丅丈丑丝丌丟()));
            Rilisoft.FortsManager.丞下丟丅丅丅与七丕(丙业与丙丗丝不丈东:  new System.Action<且丟世丆丑丞丄三三, System.Single>(object:  this, method:  System.Void Rilisoft.FortCraftController::三七世丈丘与丞丐专(丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三 丛丆东与丑丞丅丝专, float 不丁丌丐业丑丟且不)));
        }
        private void Start()
        {
            this._itemsScroll.GetComponent<UIPanel>().UpdateAnchors();
            if(this._stockButton == 0)
            {
                    return;
            }
            
            Rilisoft.ButtonHandler val_3 = this._stockButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.FortCraftController::丑七丐丂业东丙丟东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 丑七丐丂业东丙丟东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.专且且丏丈丐上丕丗.世三丞丅丑丌丈丈一() == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel.gameObject, 丏业丟一东丂东丘丛:  false);
            this.专且且丏丈丐上丕丗.世三丞丅丑丌丈丈一().remove_OnClose(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftController::且丗丆不丙与丅不丌()));
            this.专且且丏丈丐上丕丗.世三丞丅丑丌丈丈一().add_OnClose(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftController::且丗丆不丙与丅不丌()));
            this.专且且丏丈丐上丕丗.世三丞丅丑丌丈丈一().Show();
        }
        private void 且丗丆不丙与丅不丌()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel.gameObject, 丏业丟一东丂东丘丛:  true);
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
                this.UpdateItemsScroll();
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
            
            this.不丈不与不丑丌丑下(三丐业七丘丂丐下丘:  this.丆丗丟与丏丁且丒丕);
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            if(丁与丟万丄丒丗专丌 == false)
            {
                    return;
            }
            
            if(this.下且丐丈丐东丗丟丄 == null)
            {
                    return;
            }
            
            this.GetCraftReward(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
        }
        private void OnDestroy()
        {
            Rilisoft.FortsManager.与丌丌丒丘丅一丒上(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.专七三丂下业丘丏丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::丝与丟丕且丈丙且上(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.万丂丐一世业世万丑(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.东且东丒丐世丐丞丒, 丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void Rilisoft.FortCraftController::上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            Rilisoft.FortsManager.七万丐丟业业且丕丂(丙业与丙丗丝不丈东:  new System.Action<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒>(object:  this, method:  System.Void Rilisoft.FortCraftController::世丐与下丂业上丗丛(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 下不万下且丂业丌丘, Rilisoft.东且东丒丐世丐丞丒 丌丏丗与丕丈丄三丈, Rilisoft.东且东丒丐世丐丞丒 丏一丕东丙丆与丒丄)));
            Rilisoft.FortsManager.丘一与丂专万万丘丄(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.FortCraftController::世丄东丏丟丝下丁一(bool 丌丗丏丏丛东专丁且)));
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丛上丐丑丙三万丒丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftController::下与三丅丈丑丝丌丟()));
            if(this.下且丐丈丐东丗丟丄 != null)
            {
                    this.GetCraftReward(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
            }
            
            Rilisoft.FortsManager.丝下世丐丏丌丁不丄(丙业与丙丗丝不丈东:  new System.Action<且丟世丆丑丞丄三三, System.Single>(object:  this, method:  System.Void Rilisoft.FortCraftController::三七世丈丘与丞丐专(丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三 丛丆东与丑丞丅丝专, float 不丁丌丐业丑丟且不)));
        }
        private void 三七世丈丘与丞丐专(丞东丌丟与丅丅万丝.且丟世丆丑丞丄三三 丛丆东与丑丞丅丝专, float 不丁丌丐业丑丟且不)
        {
            this.UpdateItemsScroll();
        }
        internal string 丅丟丟丏丘三丞丕业(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗)
        {
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            if((System.Linq.Enumerable.FirstOrDefault<FortItemsGroupSettings>(source:  this._groupsSettings, predicate:  new System.Func<FortItemsGroupSettings, System.Boolean>(object:  new FortCraftController.且丛丑丘丏丈七丑丝(), method:  System.Boolean FortCraftController.且丛丑丘丏丈七丑丝::丂下专丁丈丑丐丁丗(Rilisoft.FortCraftController.FortItemsGroupSettings 且七丘且丟丘丏丑丗)))) == null)
            {
                    return (string)System.String.alignConst;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3.LocalizationKey);
        }
        internal UnityEngine.AudioClip 丞丒丝丘东七上与三(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗)
        {
            UnityEngine.AudioClip val_4;
            .一丐丅且丛不不丌丗 = 一丐丅且丛不不丌丗;
            if((System.Linq.Enumerable.FirstOrDefault<FortItemsGroupSettings>(source:  this._groupsSettings, predicate:  new System.Func<FortItemsGroupSettings, System.Boolean>(object:  new FortCraftController.丘丈万一丅东一上万(), method:  System.Boolean FortCraftController.丘丈万一丅东一上万::一丞丁丆丕且丏丂丆(Rilisoft.FortCraftController.FortItemsGroupSettings 且七丘且丟丘丏丑丗)))) == null)
            {
                    return val_4;
            }
            
            val_4 = val_3.Clip;
            return val_4;
        }
        private void 世丄东丏丟丝下丁一(bool 丌丗丏丏丛东专丁且)
        {
            if(丌丗丏丏丛东专丁且 == false)
            {
                    return;
            }
            
            this.SetMySceneViews(丗不且三丈丞专丄丛:  this.丆丟丟七丗丂丏丒丐, 丒丞丐丘且不且丟东:  false);
        }
        private void 下与三丅丈丑丝丌丟()
        {
            if(this.丛丌丞一丑丛丂丞丑 != 0)
            {
                    this.不丆三丞丞丏上丕不 = true;
            }
            
            this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  false);
        }
        private UnityEngine.Transform 丆丟丁丏丟丞丂万与(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_4;
            Rilisoft.FortCraftController.业丌且专一下世丐丟(丗专世丅一丏丟下丅:  this.丗不一丗丅七丘丕一, 且丏丟丏下七丂业与:  Rilisoft.FortCraftController.七上丌上丗丕世丝下());
            if((this.丗不一丗丅七丘丕一.ContainsKey(key:  与丄不丌一世东丁丙)) != false)
            {
                    UnityEngine.Transform val_3 = this.丗不一丗丅七丘丕一.Item[与丄不丌一世东丁丙];
                return (UnityEngine.Transform)val_4;
            }
            
            val_4 = 0;
            return (UnityEngine.Transform)val_4;
        }
        internal static void 业丌且专一下世丐丟(System.Collections.Generic.Dictionary<丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐, UnityEngine.Transform> 丗专世丅一丏丟下丅, UnityEngine.GameObject 且丏丟丏下七丂业与)
        {
            var val_16;
            UnityEngine.Object val_17;
            var val_21;
            val_17 = 且丏丟丏下七丂业与;
            if(丗专世丅一丏丟下丅 == null)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<丗丞丏丙七丑丕且丐, UnityEngine.Transform>>(source:  丗专世丅一丏丟下丅)) == true)
            {
                    return;
            }
            
            if(val_17 == 0)
            {
                    return;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_17 = Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  val_17).GetEnumerator();
            label_44:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_17.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            T val_9 = val_17.Current;
            System.Nullable<T> val_11 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<丗丞丏丙七丑丕且丐>(下业七不丑丂丏丟东:  val_9.name, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-620080568) & 1) == 0)
            {
                goto label_25;
            }
            
            if((丗专世丅一丏丟下丅.ContainsKey(key:  val_11.HasValue)) == false)
            {
                goto label_26;
            }
            
            object[] val_13 = new object[1];
            val_13[0] = val_9.name;
            UnityEngine.Debug.LogErrorFormat(format:  "FillPlacePoints duplicate fort item place point: \'{0}\'", args:  val_13);
            goto label_44;
            label_25:
            object[] val_15 = new object[1];
            val_15[0] = val_9.name;
            UnityEngine.Debug.LogErrorFormat(format:  "FillPlacePoints unknown fort item place point name: \'{0}\'", args:  val_15);
            goto label_44;
            label_26:
            丗专世丅一丏丟下丅.Add(key:  val_11.HasValue, value:  val_9.transform);
            goto label_44;
            label_16:
            val_16 = 0;
            val_21 = 0;
            if(val_17 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_17.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        internal static UnityEngine.Transform[] 丕丐下丙丏丕丘丈世(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, UnityEngine.Transform 与丄丙丌上丅丑世丛)
        {
            var val_12;
            var val_13;
            val_12 = 0;
            if(与丄丙丌上丅丑世丛 == 0)
            {
                    return (UnityEngine.Transform[])val_12;
            }
            
            if(与丄丙丌上丅丑世丛.childCount == 0)
            {
                goto label_18;
            }
            
            System.Collections.Generic.List<UnityEngine.Transform> val_3 = new System.Collections.Generic.List<UnityEngine.Transform>();
            val_13 = 0;
            goto label_6;
            label_16:
            UnityEngine.Transform val_4 = 与丄丙丌上丅丑世丛.GetChild(index:  0);
            if(val_4 != 0)
            {
                    if((val_4.name.IndexOf(value:  "[SubPoint")) == 0)
            {
                    val_3.Add(item:  val_4);
            }
            
            }
            
            val_13 = 1;
            label_6:
            if(val_13 < 与丄丙丌上丅丑世丛.childCount)
            {
                goto label_16;
            }
            
            if(val_3.Count > 0)
            {
                    val_12 = val_3.ToArray();
                return (UnityEngine.Transform[])val_12;
            }
            
            label_18:
            val_12 = new UnityEngine.Transform[1];
            val_12[0] = 与丄丙丌上丅丑世丛;
            return (UnityEngine.Transform[])val_12;
        }
        private Rilisoft.丕丂丒丁丏东且一七[] 丗世丄三丟丁丘万丈(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_4;
            UnityEngine.Transform val_1 = this.丆丟丁丏丟丞丂万与(与丄不丌一世东丁丙:  与丄不丌一世东丁丙);
            val_4 = 0;
            if(val_1 == 0)
            {
                    return (Rilisoft.丕丂丒丁丏东且一七[])val_1.GetComponentsInChildren<Rilisoft.丕丂丒丁丏东且一七>(includeInactive:  true);
            }
            
            return (Rilisoft.丕丂丒丁丏东且一七[])val_1.GetComponentsInChildren<Rilisoft.丕丂丒丁丏东且一七>(includeInactive:  true);
        }
        private void 上丞丈丟丅丈东七上()
        {
            var val_7;
            Rilisoft.丕丂丒丁丏东且一七 val_29;
            Rilisoft.FortCraftController val_31;
            var val_34;
            UIScrollView val_35;
            var val_36;
            this._itemsScroll.GetComponent<UIPanel>().UpdateAnchors();
            this.丙丆东上丟丌丈丌上();
            丞东丑专丛丆丄丝世.丒丑东世丛不上丈丛(七万上丐一丈丏丏专:  this.丘丞下丛世七丐丐丒.gameObject, 丌丝三丌丗丄丌丈且:  false, 与丐丌万丁丒不业丕:  true, 丈与丗且丐专一一丌:  true);
            List.Enumerator<T> val_5 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.万丂丙丒丒丞丏下下(一丐丅且丛不不丌丗:  this.丛丌丞一丑丛丂丞丑, 丁丅丑下丝丆丄下丏:  false).GetEnumerator();
            label_42:
            if(((-619342944) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if(val_8.丙丕丞且丕不丘丙丑().丐业丞丘七丈业丏丗() != false)
            {
                    if(val_8.丕丐丈丁上丞与三丌() == false)
            {
                goto label_42;
            }
            
            }
            
            if(this.丑万丆丅丁与丂丌丒.Count >= 1)
            {
                    val_29 = this.丑万丆丅丁与丂丌丒.Item[0];
                bool val_14 = this.丑万丆丅丁与丂丌丒.Remove(item:  val_29);
            }
            else
            {
                    val_29 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._scrollDefaultItem.gameObject).GetComponent<Rilisoft.丕丂丒丁丏东且一七>();
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_31 = this;
            val_29.Setup(七万上丐一丈丏丏专:  this.丘丞下丛世七丐丐丒.transform, 丒专丈丛下丒一丒丛:  this, 下丅丙一丂丗丅丝七:  val_8, 不丝丄丒丌丐一一与:  Rilisoft.丗一且丈上丝下丈丝.丏专丄丕丏丕东丈与(丁丅丈丌丟世丗丗丟:  this.丒丞丟丅丝不丝丒一));
            if((this.丆丗丟与丏丁且丒丕 != null) && (this.丆丗丟与丏丁且丒丕 == val_8))
            {
                    var val_29 = 0;
                val_29 = val_29 + 1;
                val_31 = 2;
                val_29.IsSelected = true;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_29.UpdateView();
            this.丕丏丑丐业丛世一丟.Add(item:  val_29);
            goto label_42;
            label_8:
            val_34 = public System.Void List.Enumerator<Rilisoft.东且东丒丐世丐丞丒>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.zero;
            this._itemsScroll.currentMomentum = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            this._itemsScroll.ResetPosition();
            UIPanel val_25 = this._itemsScroll.panel;
            float val_31 = (float)this.丕丏丑丐业丛世一丟.Count;
            val_35 = this._itemsScroll;
            val_31 = this.丘丞下丛世七丐丐丒.cellWidth * val_31;
            if(val_31 <= val_25.width)
            {
                goto label_71;
            }
            
            val_36 = val_25.丑丆丏丟丗丌丄丟丝();
            if(val_35 != null)
            {
                goto label_76;
            }
            
            goto label_73;
            label_71:
            val_35.Restrict();
            this.东丒丝丁丛七丄世丝.ScrollTo(世万专丛与丐丌专不:  0);
            val_35 = this._itemsScroll;
            val_36 = 0;
            if(val_35 != null)
            {
                goto label_76;
            }
            
            label_73:
            label_76:
            val_35.enabled = false;
        }
        public void UpdateItemsScroll()
        {
            var val_7;
            object val_19;
            var val_20;
            var val_23;
            System.Action<Rilisoft.丕丂丒丁丏东且一七> val_25;
            UIScrollView val_26;
            val_19 = this;
            if(this.丛丌丞一丑丛丂丞丑 == 0)
            {
                    return;
            }
            
            if(this.丆丗丟与丏丁且丒丕 != null)
            {
                    if((Rilisoft.FortsManager.丞丑丙一与丐万且下(与丄不丌一世东丁丙:  this.丑上一不丅丈业丟丛, 不丝丄丒丌丐一一与:  this.丛丌丞一丑丛丂丞丑, 丌七丅一丘与丅丅丏:  false)) != true)
            {
                    this.GoToGroup(一丐丅且丛不不丌丗:  Rilisoft.FortsManager.丕丙专丂丛丐与下上(与丄不丌一世东丁丙:  this.丑上一不丅丈业丟丛), 丗丒世丒东丆丅一七:  true, 丌丒丌丁丛丕专丗丝:  false);
            }
            
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._itemsScrollContainer, 丏业丟一东丂东丘丛:  true);
            val_20 = public static Rilisoft.丕丂丒丁丏东且一七 System.Linq.Enumerable::FirstOrDefault<Rilisoft.丕丂丒丁丏东且一七>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            Rilisoft.丕丂丒丁丏东且一七 val_4 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丕丂丒丁丏东且一七>(source:  this.丕丏丑丐业丛世一丟, predicate:  new System.Func<Rilisoft.丕丂丒丁丏东且一七, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.FortCraftController::丏丂下丂不丝七丁业(Rilisoft.丕丂丒丁丏东且一七 业下丌下三丕丙丌下)));
            List.Enumerator<T> val_5 = this.丕丏丑丐业丛世一丟.GetEnumerator();
            label_23:
            if(((-618999392) & 1) == 0)
            {
                goto label_11;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if(val_8 == val_4)
            {
                goto label_23;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_20 = 2;
            val_8.IsSelected = false;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_8.UpdateView();
            goto label_23;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_23 = null;
            val_23 = null;
            val_25 = FortCraftController.<>c.<>9__83_1;
            if(val_25 == null)
            {
                    System.Action<Rilisoft.丕丂丒丁丏东且一七> val_11 = null;
                val_25 = val_11;
                val_11 = new System.Action<Rilisoft.丕丂丒丁丏东且一七>(object:  FortCraftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FortCraftController.<>c::丅不丌不七丞丄丝丂(Rilisoft.丕丂丒丁丏东且一七 业下丌下三丕丙丌下));
                FortCraftController.<>c.<>9__83_1 = val_25;
            }
            
            Rilisoft.丕丂丒丁丏东且一七 val_12 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<Rilisoft.丕丂丒丁丏东且一七>(丄三丅七丆丛与与上:  val_4, 七丐丅专且专七三丆:  val_11);
            UIPanel val_14 = this._itemsScroll.panel;
            float val_19 = (float)this.丕丏丑丐业丛世一丟.Count;
            val_26 = this._itemsScroll;
            val_19 = this.丘丞下丛世七丐丐丒.cellWidth * val_19;
            if(val_19 <= val_14.width)
            {
                goto label_38;
            }
            
            val_19 = val_14.丑丆丏丟丗丌丄丟丝();
            if(val_26 != null)
            {
                goto label_42;
            }
            
            goto label_40;
            label_38:
            val_26.ResetPosition();
            val_26 = this._itemsScroll;
            val_19 = 0;
            if(val_26 != null)
            {
                goto label_42;
            }
            
            label_40:
            label_42:
            val_26.enabled = false;
        }
        private void 丙丆东上丟丌丈丌上()
        {
            List.Enumerator<T> val_1 = this.丕丏丑丐业丛世一丟.GetEnumerator();
            label_9:
            if(((-618788008) & 1) == 0)
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
        public void SelectItemOnScrollRequest(Rilisoft.东且东丒丐世丐丞丒 丂三七下丗且丌上一, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, bool 与七丁与丌丒丝专一 = True)
        {
            if(this.业丕三万丂东丁丗三 == true)
            {
                    return;
            }
            
            bool val_1 = this._likeGuiObj.activeInHierarchy;
            if(val_1 == true)
            {
                    return;
            }
            
            this.丆丗丟与丏丁且丒丕 = 丂三七下丗且丌上一;
            this.丑上一不丅丈业丟丛 = 与丄不丌一世东丁丙;
            if(val_1.丑丆丏丟丗丌丄丟丝() == false)
            {
                    return;
            }
            
            this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  this.丆丗丟与丏丁且丒丕, 丕丝丟下丗丛一丕业:  false, 与丄不丌一世东丁丙:  this.丑上一不丅丈业丟丛, 与七丁与丌丒丝专一:  与七丁与丌丒丝专一);
        }
        public void SelectItemOnSceneRequest(Rilisoft.东且东丒丐世丐丞丒 丂三七下丗且丌上一, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            if(this.丑丆丏丟丗丌丄丟丝() == false)
            {
                    return;
            }
            
            this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  丂三七下丗且丌上一, 丕丝丟下丗丛一丕业:  true, 与丄不丌一世东丁丙:  与丄不丌一世东丁丙, 与七丁与丌丒丝专一:  true);
        }
        private void 丆且丟丙丅丞万丄丗(Rilisoft.东且东丒丐世丐丞丒 丂三七下丗且丌上一, bool 丕丝丟下丗丛一丕业, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙, bool 与七丁与丌丒丝专一 = True)
        {
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
            
            if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            }
            
            }
            
            if(丂三七下丗且丌上一 == null)
            {
                goto label_16;
            }
            
            bool val_6 = 丕丝丟下丗丛一丕业;
            this.丆丗丟与丏丁且丒丕 = 丂三七下丗且丌上一;
            this.丑上一不丅丈业丟丛 = 与丄不丌一世东丁丙;
            this.七丄业丌丒丄丟丌丗 = val_6;
            if(this._itemsScroll.gameObject.activeInHierarchy == false)
            {
                goto label_19;
            }
            
            if(this.丆丗丟与丏丁且丒丕 != null)
            {
                    this.上丕且丁一丐丞丐丐(三丐业七丘丂丐下丘:  this.丆丗丟与丏丁且丒丕, 与丄不丌一世东丁丙:  与丄不丌一世东丁丙);
            }
            
            this.丆丗丟与丏丁且丒丕 = 丂三七下丗且丌上一;
            this.七丑丘丝丒丞丑丈东 = 与七丁与丌丒丝专一;
            this.七丄业丌丒丄丟丌丗 = val_6;
            goto label_21;
            label_16:
            this.GoToGroup(一丐丅且丛不不丌丗:  Rilisoft.FortsManager.丕丙专丂丛丐与下上(与丄不丌一世东丁丙:  与丄不丌一世东丁丙), 丗丒世丒东丆丅一七:  true, 丌丒丌丁丛丕专丗丝:  false);
            return;
            label_19:
            this.七丄业丌丒丄丟丌丗 = true;
            this.GoToGroup(一丐丅且丛不不丌丗:  Rilisoft.FortsManager.丕丙专丂丛丐与下上(与丄不丌一世东丁丙:  与丄不丌一世东丁丙), 丗丒世丒东丆丅一七:  true, 丌丒丌丁丛丕专丗丝:  false);
            label_21:
            this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
        }
        public void SetMySceneViews(bool 丗不且三丈丞专丄丛, bool 丒丞丐丘且不且丟东 = True)
        {
            this.业丕三万丂东丁丗三 = false;
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) == 0)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丑丝丛丟上万丕丕上()) != null)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丑丝丛丟上万丕丕上().Count) >= Rilisoft.FortsManager.丌七丐丙丛丄丒且业())
            {
                goto label_10;
            }
            
            }
            
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丘下丆专一丈丅丈丝();
            label_10:
            this.与丙丗丑丟丑一丂丛(丆丛与丅丙丒下丝丏:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丑丝丛丟上万丕丕上(), 丗不且三丈丞专丄丛:  丗不且三丈丞专丄丛, 丒丞丐丘且不且丟东:  丒丞丐丘且不且丟东);
        }
        public void SetSceneViews(System.Collections.Generic.Dictionary<string, object> 丆丛与丅丙丒下丝丏, bool 丒丞丐丘且不且丟东 = True)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = 丆丛与丅丙丒下丝丏;
            if(val_5 == null)
            {
                    return;
            }
            
            this.业丕三万丂东丁丗三 = true;
            if(val_5.Count < Rilisoft.FortsManager.丌七丐丙丛丄丒且业())
            {
                    val_5 = Rilisoft.FortsManager.一上丄与丌七业丈不(专丘丘丗万一业下丆:  val_5 = 丆丛与丅丙丒下丝丏);
            }
            
            this.与丙丗丑丟丑一丂丛(丆丛与丅丙丒下丝丏:  val_5, 丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  丒丞丐丘且不且丟东);
        }
        private void 与丙丗丑丟丑一丂丛(System.Collections.Generic.Dictionary<string, object> 丆丛与丅丙丒下丝丏, bool 丗不且三丈丞专丄丛, bool 丒丞丐丘且不且丟东 = True)
        {
            var val_6;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_58;
            丗丞丏丙七丑丕且丐 val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_67;
            bool val_68;
            var val_71;
            var val_73;
            var val_74;
            var val_78;
            FortCraftController.与且世丛丗丞三丞且 val_1 = new FortCraftController.与且世丛丗丞三丞且();
            .丝且与丝丒丟万丁专 = this;
            .丁一丄丁丐三丂丞丅 = new System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, Rilisoft.东且东丒丐世丐丞丒>();
            Dictionary.Enumerator<TKey, TValue> val_3 = 丆丛与丅丙丒下丝丏.GetEnumerator();
            label_51:
            if(((-617604832) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            new FortCraftController.万上丞与丒且丕丄且() = new FortCraftController.万上丞与丒且丕丄且();
            val_58;
            if(val_7._value._obj != 0)
            {
                    val_58 = 0;
            }
            
            .专丘丘丗万一业下丆 = ;
            if(new FortCraftController.万上丞与丒且丕丄且() == null)
            {
                goto label_9;
            }
            
            label_15:
            if(new FortCraftController.万上丞与丒且丕丄且() == null)
            {
                goto label_11;
            }
            
            goto label_13;
            label_9:
            if((FortCraftController.万上丞与丒且丕丄且)[1152921542644004256].专丘丘丗万一业下丆 == null)
            {
                goto label_51;
            }
            
            goto label_15;
            label_11:
            val_58 = (FortCraftController.万上丞与丒且丕丄且)[1152921542644004256].专丘丘丗万一业下丆;
            if(val_58 != null)
            {
                goto label_16;
            }
            
            label_13:
            label_16:
            if((val_58.ContainsKey(key:  "id")) == false)
            {
                goto label_51;
            }
            
            System.Predicate<Rilisoft.东且东丒丐世丐丞丒> val_14 = new System.Predicate<Rilisoft.东且东丒丐世丐丞丒>(object:  new FortCraftController.万上丞与丒且丕丄且(), method:  System.Boolean FortCraftController.万上丞与丒且丕丄且::丟丞下丗丈丛丆丆丂(Rilisoft.东且东丒丐世丐丞丒 三丟东丕丄丄下下丑));
            Rilisoft.东且东丒丐世丐丞丒 val_15 = System.Linq.Enumerable.ToList<Rilisoft.东且东丒丐世丐丞丒>(source:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.三下丙丛且丛丄丅丕()).Find(match:  null);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_7._value._obj.丐丏七丌丕丗业且上()));
            if(val_15 == null)
            {
                goto label_26;
            }
            
            (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.Add(key:  1152921504628731904, value:  val_15);
            goto label_51;
            label_26:
            Rilisoft.东且东丒丐世丐丞丒 val_19 = Rilisoft.FortsManager.丟丝丌丏一下丒丝丛(与丄不丌一世东丁丙:  1152921504628731904);
            if(val_19 == null)
            {
                goto label_51;
            }
            
            (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.Add(key:  1152921504628731904, value:  val_19);
            goto label_51;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.丆丗丟与丏丁且丒丕 == null)
            {
                goto label_75;
            }
            
            if(((FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.ContainsKey(key:  this.丑上一不丅丈业丟丛)) == false)
            {
                goto label_71;
            }
            
            if(this.丆丗丟与丏丁且丒丕 == (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.Item[this.丑上一不丅丈业丟丛])
            {
                goto label_75;
            }
            
            val_61 = this.丑上一不丅丈业丟丛;
            (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.set_Item(key:  val_61, value:  this.丆丗丟与丏丁且丒丕);
            goto label_75;
            label_71:
            val_61 = this.丆丗丟与丏丁且丒丕;
            (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.Add(key:  this.丑上一不丅丈业丟丛, value:  val_61);
            label_75:
            if(丗不且三丈丞专丄丛 == false)
            {
                goto label_91;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_24 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丟丑丒丂万丟专丁万();
            if(((val_24 == null) || ((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏()) == 6)) || ((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏()) == 8))
            {
                goto label_91;
            }
            
            val_61 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏();
            if(((FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.ContainsKey(key:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏())) == false)
            {
                goto label_89;
            }
            
            if(this.丆丗丟与丏丁且丒丕 != null)
            {
                    if(this.丆丗丟与丏丁且丒丕 == (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.Item[val_61])
            {
                goto label_91;
            }
            
            }
            
            (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.set_Item(key:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏(), value:  val_24);
            if(val_1 != null)
            {
                goto label_96;
            }
            
            goto label_95;
            label_89:
            (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.Add(key:  val_61, value:  val_24);
            label_91:
            if(val_1 != null)
            {
                goto label_96;
            }
            
            label_95:
            label_96:
            Dictionary.Enumerator<TKey, TValue> val_37 = (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.GetEnumerator();
            val_62 = 0;
            val_63 = 0;
            label_159:
            if(((-617604896) & 1) == 0)
            {
                goto label_98;
            }
            
            ConfiguredValueTaskAwaiter val_38 = val_6.GetAwaiter();
            if(this.丆丗丟与丏丁且丒丕 != null)
            {
                    var val_39 = (this.丆丗丟与丏丁且丒丕 == (-617604912)) ? 1 : 0;
            }
            else
            {
                    val_64 = 0;
            }
            
            Rilisoft.丕丂丒丁丏东且一七[] val_41 = this.丗世丄三丟丁丘万丈(与丄不丌一世东丁丙:  val_38._value._obj.丙东专丂世丈丏丁丂());
            if(val_41 != null)
            {
                    if(val_41.Length != 0)
            {
                goto label_102;
            }
            
            }
            
            this.三丅万丏丒丌丗丟丂(三丐业七丘丂丐下丘:  val_38._value._obj, 丞丈丌且东丆丅丗万:  false, 丛万下上万丙下世丂:  丒丞丐丘且不且丟东, 与丄不丌一世东丁丙:  val_38._value._obj.丙东专丂世丈丏丁丂());
            goto label_159;
            label_102:
            if(val_41.Length == 0)
            {
                    val_65 = 0;
            }
            
            var val_60 = 0;
            val_60 = val_60 + 1;
            val_65 = 0;
            if(val_41[0].FortItem != (-617604912))
            {
                goto label_110;
            }
            
            if(val_41.Length < 1)
            {
                goto label_159;
            }
            
            label_127:
            if(0 >= val_41.Length)
            {
                    val_67 = 0;
            }
            
            Rilisoft.丕丂丒丁丏东且一七 val_61 = val_41[0];
            if(this.业丕三万丂东丁丗三 == false)
            {
                goto label_113;
            }
            
            val_68 = 0;
            if(val_61 != null)
            {
                goto label_117;
            }
            
            goto label_115;
            label_113:
            val_68 = val_38._value._obj.丑丆丑三且丛上且丟();
            if(val_61 != null)
            {
                goto label_117;
            }
            
            label_115:
            label_117:
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_67 = 4;
            val_61.IsCrafting = val_68;
            var val_63 = 0;
            val_63 = val_63 + 1;
            val_61.UpdateView();
            if(1 < val_41.Length)
            {
                goto label_127;
            }
            
            goto label_159;
            label_110:
            Dictionary.Enumerator<TKey, TValue> val_49 = (FortCraftController.与且世丛丗丞三丞且)[1152921542643996064].丁一丄丁丐三丂丞丅.GetEnumerator();
            goto label_131;
            label_139:
            ConfiguredValueTaskAwaiter val_50 = val_6.GetAwaiter();
            if(val_41.Length == 0)
            {
                    val_71 = 0;
            }
            
            var val_65 = 0;
            val_65 = val_65 + 1;
            val_71 = 0;
            Rilisoft.东且东丒丐世丐丞丒 val_52 = val_41[0].FortItem;
            val_73 = val_50._value._obj;
            if(val_73 == 0)
            {
                    val_73 = val_50._value._obj;
            }
            
            val_74 = mem[val_50._value._obj + 296 + 8];
            val_74 = val_50._value._obj + 296 + 8;
            var val_66 = 0;
            val_66 = val_66 + (val_73 & 1);
            label_131:
            if(((-617604960) & 1) != 0)
            {
                goto label_139;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((1 != 1) && (709 == 709))
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_74 = 0;
            }
            
            }
            
            if(val_41.Length >= 1)
            {
                    do
            {
                if(0 >= val_41.Length)
            {
                    val_74 = 0;
            }
            
                var val_68 = 0;
                val_68 = val_68 + 1;
                val_74 = 9;
                val_41[0].Kill(不丟一丄丁丆丅上丒:  (val_66 == 0) ? 1 : 0);
            }
            while(1 < val_41.Length);
            
            }
            
            this.三丅万丏丒丌丗丟丂(三丐业七丘丂丐下丘:  val_38._value._obj, 丞丈丌且东丆丅丗万:  false, 丛万下上万丙下世丂:  丒丞丐丘且不且丟东, 与丄不丌一世东丁丙:  val_38._value._obj.丙东专丂世丈丏丁丂());
            goto label_159;
            label_98:
            val_78 = 2;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_179;
            }
            
            if(( == 0) || (709 == 887))
            {
                goto label_185;
            }
            
            label_184:
            label_185:
            丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<丗丞丏丙七丑丕且丐>(七丐丅专且专七三丆:  new System.Action<丗丞丏丙七丑丕且丐>(object:  val_1, method:  System.Void FortCraftController.与且世丛丗丞三丞且::与丏丛与与且丘七丘(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)));
            return;
            label_179:
            if( != 0)
            {
                goto label_184;
            }
            
            goto label_185;
        }
        private void 三丅万丏丒丌丗丟丂(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, bool 丞丈丌且东丆丅丗万, bool 丛万下上万丙下世丂, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_18;
            丗丞丏丙七丑丕且丐 val_19;
            var val_20;
            var val_21;
            object val_22;
            string val_23;
            FortCraftController.丟丐丟丝丝不丈下丒 val_1 = new FortCraftController.丟丐丟丝丝不丈下丒();
            if(val_1 != null)
            {
                    val_18 = val_1;
                .三丐业七丘丂丐下丘 = 三丐业七丘丂丐下丘;
                val_19 = 1152921542644441104;
                mem[1152921542644441088] = this;
                mem[1152921542644441096] = 与丄不丌一世东丁丙;
            }
            else
            {
                    mem[16] = this;
                val_19 = 24;
                mem[24] = 与丄不丌一世东丁丙;
                val_18 = 32;
                mem[32] = 三丐业七丘丂丐下丘;
            }
            
            .丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
            System.Action<System.Object, UnityEngine.GameObject> val_3 = new System.Action<System.Object, UnityEngine.GameObject>(object:  val_1, method:  System.Void FortCraftController.丟丐丟丝丝不丈下丒::且丈丙专世丈业丌丅(object 万且万且丑丗且丌丆, UnityEngine.GameObject 丑且不丕与专丄业丙));
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(丛万下上万丙下世丂 == false)
            {
                goto label_4;
            }
            
            label_8:
            UnityEngine.Transform val_4 = this.丆丟丁丏丟丞丂万与(与丄不丌一世东丁丙:  val_19);
            if(val_4 != 0)
            {
                goto label_7;
            }
            
            return;
            label_3:
            if(丛万下上万丙下世丂 == true)
            {
                goto label_8;
            }
            
            label_4:
            if((mem[32].丙丕丞且丕不丘丙丑().丁丞一不不丗丕丟丛().Contains(item:  1023)) == false)
            {
                goto label_12;
            }
            
            val_20 = "FortItemsContent/fort_future";
            val_21 = public static UnityEngine.GameObject UnityEngine.Resources::Load<UnityEngine.GameObject>(string path);
            goto label_13;
            label_7:
            if((mem[32].丙丕丞且丕不丘丙丑().丁丞一不不丗丕丟丛().Contains(item:  1023)) == false)
            {
                goto label_22;
            }
            
            val_22 = mem[32];
            val_23 = "FortItemsContent/fort_future";
            goto label_24;
            label_12:
            val_21 = public static UnityEngine.GameObject UnityEngine.Resources::Load<UnityEngine.GameObject>(string path);
            label_13:
            val_3.Invoke(arg1:  mem[32], arg2:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  mem[32].丝丑丏丑丄丌丐世丂()));
            return;
            label_22:
            if(val_1 == null)
            {
                goto label_29;
            }
            
            label_33:
            val_22 = mem[32];
            val_23 = mem[32].丝丑丏丑丄丌丐世丂();
            label_24:
            丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.SceneViewPrefabLoadOperation>(丝三丁东丈丒世丅业:  val_4.gameObject).Setup(上丛东丆丆上世丟丞:  val_22, 丑与丞三且丛与丟业:  val_23, 丒丒丁丆丁业丒三丆:  new System.Func<System.Object, System.Boolean>(object:  val_1, method:  System.Boolean FortCraftController.丟丐丟丝丝不丈下丒::丌且丞丄丝下丁丄丝(object 万且万且丑丗且丌丆)), 丈丌上上丕丙丞业丞:  val_3);
            return;
            label_29:
            if(mem[32] != 0)
            {
                goto label_33;
            }
            
            goto label_33;
        }
        public void GoToGroup(Rilisoft.FortItemGroupType 一丐丅且丛不不丌丗, bool 丗丒世丒东丆丅一七 = True, bool 丌丒丌丁丛丕专丗丝 = False)
        {
            UnityEngine.Object val_7;
            var val_8;
            MainMenuHeroCamera val_9;
            Rilisoft.FortItemGroupType val_10;
            var val_11;
            UnityEngine.GameObject val_12;
            var val_14;
            val_7 = this;
            if((一丐丅且丛不不丌丗 - 10) >= 18)
            {
                goto label_1;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 320];
            val_9 = MainMenuController.丄丞丁丈与业上丞丟.rotateCamera;
            val_10 = 10;
            goto label_6;
            label_1:
            if((一丐丅且丛不不丌丗 - 4) > 5)
            {
                goto label_7;
            }
            
            val_11 = null;
            val_11 = null;
            val_9 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 320];
            val_9 = MainMenuController.丄丞丁丈与业上丞丟.rotateCamera;
            val_10 = 4;
            label_6:
            label_64:
            PlayFortSlotZoom(不丝丄丒丌丐一一与:  val_10);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryRootObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryDeffenceRootObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryDecorationsObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryFortRootObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryBridgeRootObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryTurretsRootObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryTurretsFar1Obj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryTurretsFar2Obj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryTurretsNier1Obj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoryTurretsNier2Obj, 丏业丟一东丂东丘丛:  false);
            if(一丐丅且丛不不丌丗 > 16)
            {
                goto label_14;
            }
            
            var val_7 = 106029204 + (一丐丅且丛不不丌丗) << 2;
            val_7 = val_7 + 106029204;
            goto (106029204 + (一丐丅且丛不不丌丗) << 2 + 106029204);
            label_14:
            if(一丐丅且丛不不丌丗 != 30)
            {
                goto label_18;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  true);
            val_12 = this._categoryDecorationsObj;
            goto label_29;
            label_18:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemsScrollContainer, 丏业丟一东丂东丘丛:  true);
            if((this.丛丌丞一丑丛丂丞丑 == 0) || (this.丛丌丞一丑丛丂丞丑 != 一丐丅且丛不不丌丗))
            {
                goto label_25;
            }
            
            this.七丑丘丝丒丞丑丈东 = true;
            this.七丄业丌丒丄丟丌丗 = false;
            goto label_59;
            label_29:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  null, 丏业丟一东丂东丘丛:  true);
            label_59:
            this.一丙丕三丌与下不丅(丙业与丙丗丝不丈东:  一丐丅且丛不不丌丗);
            if(丗丒世丒东丆丅一七 == false)
            {
                    return;
            }
            
            val_7 = this.丞丒丝丘东七上与三(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一);
            if(val_7 == 0)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_7);
            return;
            label_25:
            this.丙丆东上丟丌丈丌上();
            this.丛丌丞一丑丛丂丞丑 = 一丐丅且丛不不丌丗;
            this.不丆三丞丞丏上丕不 = true;
            goto label_59;
            label_7:
            val_14 = null;
            val_14 = null;
            if(null != 0)
            {
                goto label_64;
            }
            
            goto label_64;
        }
        private void 不丈不与不丑丌丑下(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘)
        {
            var val_4;
            Rilisoft.UIScrollManager val_6;
            var val_7;
            val_4 = 0;
            goto label_1;
            label_10:
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(this.丕丏丑丐业丛世一丟.Item[0].FortItem == 三丐业七丘丂丐下丘)
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
        private void 世丐与下丂业上丗丛(丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 下不万下且丂业丌丘, Rilisoft.东且东丒丐世丐丞丒 丌丏丗与丕丈丄三丈, Rilisoft.东且东丒丐世丐丞丒 丏一丕东丙丆与丒丄)
        {
            Rilisoft.东且东丒丐世丐丞丒 val_5;
            if(this.业丕三万丂东丁丗三 == true)
            {
                    return;
            }
            
            if(this._likeGuiObj.activeInHierarchy == true)
            {
                    return;
            }
            
            if(丌丏丗与丕丈丄三丈 != null)
            {
                    if(this.丆丗丟与丏丁且丒丕 == 丌丏丗与丕丈丄三丈)
            {
                    this.丆丗丟与丏丁且丒丕 = 0;
            }
            
                if(this.下且丐丈丐东丗丟丄 == null)
            {
                    if(this._screenPanel.activeInHierarchy != true)
            {
                    this.上丕且丁一丐丞丐丐(三丐业七丘丂丐下丘:  丌丏丗与丕丈丄三丈, 与丄不丌一世东丁丙:  下不万下且丂业丌丘);
            }
            
            }
            
            }
            
            if(丏一丕东丙丆与丒丄 == null)
            {
                goto label_8;
            }
            
            val_5 = this;
            this.丆丗丟与丏丁且丒丕 = 丏一丕东丙丆与丒丄;
            mem[1152921542645195832] = 下不万下且丂业丌丘;
            if(this.下且丐丈丐东丗丟丄 != null)
            {
                    return;
            }
            
            if(this._screenPanel.activeInHierarchy == true)
            {
                goto label_12;
            }
            
            this.上丕且丁一丐丞丐丐(三丐业七丘丂丐下丘:  丏一丕东丙丆与丒丄, 与丄不丌一世东丁丙:  下不万下且丂业丌丘);
            goto label_12;
            label_8:
            val_5 = this.下且丐丈丐东丗丟丄;
            label_12:
            if(mem[this.下且丐丈丐东丗丟丄] != 0)
            {
                    return;
            }
            
            if(this._screenPanel.activeInHierarchy != false)
            {
                    return;
            }
            
            this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
        }
        private void 上丕且丁一丐丞丐丐(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            丗丞丏丙七丑丕且丐 val_14;
            System.Func<TSource, System.Boolean> val_15;
            var val_16;
            Rilisoft.东且东丒丐世丐丞丒 val_17;
            var val_18;
            var val_20;
            var val_23;
            val_14 = 与丄不丌一世东丁丙;
            .三丐业七丘丂丐下丘 = 三丐业七丘丂丐下丘;
            if(this.业丕三万丂东丁丗三 == true)
            {
                    return;
            }
            
            if(this._likeGuiObj.activeInHierarchy == true)
            {
                    return;
            }
            
            if((FortCraftController.丑七丂丙一丕丘东世)[1152921542645484128].三丐业七丘丂丐下丘 == null)
            {
                    return;
            }
            
            System.Func<Rilisoft.丕丂丒丁丏东且一七, System.Boolean> val_3 = null;
            val_15 = val_3;
            val_3 = new System.Func<Rilisoft.丕丂丒丁丏东且一七, System.Boolean>(object:  new FortCraftController.丑七丂丙一丕丘东世(), method:  System.Boolean FortCraftController.丑七丂丙一丕丘东世::万丆七丏七丏不丅世(Rilisoft.丕丂丒丁丏东且一七 业下丌下三丕丙丌下));
            val_16 = public static Rilisoft.丕丂丒丁丏东且一七 System.Linq.Enumerable::FirstOrDefault<Rilisoft.丕丂丒丁丏东且一七>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            Rilisoft.丕丂丒丁丏东且一七 val_4 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丕丂丒丁丏东且一七>(source:  this.丕丏丑丐业丛世一丟, predicate:  val_3);
            if(val_4 != null)
            {
                    val_17 = this.丆丗丟与丏丁且丒丕;
                val_15 = 1152921505449816064;
                var val_15 = 0;
                val_15 = val_15 + 1;
                val_18 = 2;
                val_20 = public System.Void Rilisoft.丕丂丒丁丏东且一七::set_IsSelected(bool 丙业与丙丗丝不丈东);
                val_4.IsSelected = ((FortCraftController.丑七丂丙一丕丘东世)[1152921542645484128].三丐业七丘丂丐下丘 == val_17) ? 1 : 0;
                var val_16 = 0;
                val_16 = val_16 + 1;
                val_20 = 7;
                val_4.UpdateView();
            }
            
            val_14 = this.丗世丄三丟丁丘万丈(与丄不丌一世东丁丙:  val_14);
            if(val_14 == null)
            {
                    return;
            }
            
            if(val_8.Length == 0)
            {
                    return;
            }
            
            if(val_8.Length < 1)
            {
                    return;
            }
            
            label_40:
            val_17 = 0;
            if(0 >= val_8.Length)
            {
                    val_20 = 0;
            }
            
            Rilisoft.丕丂丒丁丏东且一七 val_17 = val_14[val_17];
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_20 = 2;
            val_23 = public System.Void Rilisoft.丕丂丒丁丏东且一七::set_IsSelected(bool 丙业与丙丗丝不丈东);
            val_17.IsSelected = ((FortCraftController.丑七丂丙一丕丘东世)[1152921542645484128].三丐业七丘丂丐下丘 == this.丆丗丟与丏丁且丒丕) ? 1 : 0;
            if(this.业丕三万丂东丁丗三 == false)
            {
                goto label_25;
            }
            
            val_15 = 0;
            if(val_17 != null)
            {
                goto label_33;
            }
            
            label_34:
            label_33:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_23 = 4;
            goto label_30;
            label_25:
            Rilisoft.东且东丒丐世丐丞丒 val_20 = (FortCraftController.丑七丂丙一丕丘东世)[1152921542645484128].三丐业七丘丂丐下丘;
            val_20 = val_20.丑丆丑三且丛上且丟();
            if(val_17 != null)
            {
                goto label_33;
            }
            
            goto label_34;
            label_30:
            val_17.IsCrafting = false;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_17.UpdateView();
            if((val_17 + 1) < val_8.Length)
            {
                goto label_40;
            }
        
        }
        public void ShowConnectionErrorBanner()
        {
            if(this._connectionErrorBanner == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._connectionErrorBanner, 丏业丟一东丂东丘丛:  true);
        }
        public void CraftRequest(Rilisoft.FortCraftScrollItemView 丁世丛业丟下丕三丟)
        {
            Rilisoft.FortCraftScrollItemView val_25;
            Rilisoft.FortCraftScrollItemView val_26;
            var val_27;
            var val_28;
            System.Action val_29;
            val_25 = 丁世丛业丟下丕三丟;
            FortCraftController.与丈下丒三丏丒丆丏 val_1 = null;
            val_26 = val_1;
            val_1 = new FortCraftController.与丈下丒三丏丒丆丏();
            if(val_26 != null)
            {
                    val_27 = val_26;
                .丁世丛业丟下丕三丟 = val_25;
                mem[1152921542645895624] = this;
            }
            else
            {
                    val_27 = 16;
                mem[16] = val_25;
                mem[24] = this;
                val_25 = mem[16];
            }
            
            if(val_25 == 0)
            {
                    return;
            }
            
            val_25 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if(val_25.丄丆丑世东丏丐上丒() == true)
            {
                    return;
            }
            
            System.Nullable<System.Int64> val_5 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                goto label_10;
            }
            
            val_25 = val_27.FortItem;
            if(val_25.丕丐丈丁上丞与三丌() == true)
            {
                    return;
            }
            
            val_25 = mem[16].FortItem;
            bool val_9 = val_25.丑丆丑三且丛上且丟();
            if(val_9 == true)
            {
                    return;
            }
            
            if(val_9.丑丆丏丟丗丌丄丟丝() != true)
            {
                    val_25 = mem[16].FortItem.丙丕丞且丕不丘丙丑();
                if((System.String.op_Equality(a:  val_25.业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) == false)
            {
                    return;
            }
            
                this.三丟一万丙丞且丘专();
                this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  3);
                this.丝丗下丅业丟丟世丄 = 3;
            }
            
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丟丑丒丂万丟专丁万()) == null)
            {
                goto label_26;
            }
            
            val_25 = this._speedUpWindow;
            val_25.Show(丆丝丕上丛且丗丝丙:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丟丑丒丂万丟专丁万(), 丑丟一丄丟丞七世丘:  mem[16].FortItem, 七丈丐与不一丘东一:  new System.Action<上三上与丒不丒丘丝, Rilisoft.东且东丒丐世丐丞丒, Rilisoft.东且东丒丐世丐丞丒>(object:  this, method:  System.Void Rilisoft.FortCraftController::丈丝丑不万丁丙丅专(Rilisoft.FortItemSpeedUpWindow.上三上与丒不丒丘丝 且世丌丟丗专与不丑, Rilisoft.东且东丒丐世丐丞丒 丆丝丕上丛且丗丝丙, Rilisoft.东且东丒丐世丐丞丒 丙丑专丈一万三丟一)));
            val_26 = mem[16];
            val_26.UpdateView();
            return;
            label_10:
            this.ShowConnectionErrorBanner();
            val_26 = 1152921505448005632;
            val_28 = null;
            val_28 = null;
            val_29 = Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌;
            if(val_29 == null)
            {
                    return;
            }
            
            val_29 = Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌;
            if(val_29 == null)
            {
                    val_29 = 0;
            }
            
            val_29.Invoke();
            return;
            label_26:
            System.Action<System.Boolean> val_24 = new System.Action<System.Boolean>(object:  val_1, method:  System.Void FortCraftController.与丈下丒三丏丒丆丏::丗丐丙丆与丙世丘丂(bool 丌丗丏丏丛东专丁且));
            val_24.三不丘下且丞三丆丙(丒世丘丘上丆丝东丞:  mem[16].FortItem.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈(), 业丏丈世世世丞丒世:  val_24);
        }
        private void 丈丝丑不万丁丙丅专(Rilisoft.FortItemSpeedUpWindow.上三上与丒不丒丘丝 且世丌丟丗专与不丑, Rilisoft.东且东丒丐世丐丞丒 丆丝丕上丛且丗丝丙, Rilisoft.东且东丒丐世丐丞丒 丙丑专丈一万三丟一)
        {
            Rilisoft.东且东丒丐世丐丞丒 val_14;
            var val_15;
            丈丞丕丘丕丗与上一 val_16;
            IntPtr val_18;
            val_14 = 丙丑专丈一万三丟一;
            FortCraftController.丗且丈丂丁丄专丞专 val_1 = new FortCraftController.丗且丈丂丁丄专丞专();
            if(val_1 != null)
            {
                    val_15 = val_1;
                .丆丝丕上丛且丗丝丙 = 丆丝丕上丛且丗丝丙;
                mem[1152921542646161224] = this;
            }
            else
            {
                    val_15 = 16;
                mem[16] = 丆丝丕上丛且丗丝丙;
                mem[24] = this;
            }
            
            .丙丑专丈一万三丟一 = val_14;
            System.Nullable<System.Int64> val_2 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                    return;
            }
            
            if(且世丌丟丗专与不丑 != 2)
            {
                    if(且世丌丟丗专与不丑 != 1)
            {
                    return;
            }
            
                if(val_15 == 0)
            {
                    return;
            }
            
                Rilisoft.东且东丒丐世丐丞丒 val_4 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丟丑丒丂万丟专丁万();
                if(val_4 != mem[16])
            {
                    return;
            }
            
                int val_6 = val_4.且丕三丙七且且东下().丟丂丞不专丆万丒世();
                val_16 = mem[16].且丕三丙七且且东下();
                val_18 = 1152921542646062192;
            }
            else
            {
                    if((FortCraftController.丗且丈丂丁丄专丞专)[1152921542646161200].丙丑专丈一万三丟一 == null)
            {
                    return;
            }
            
                int val_10 = (FortCraftController.丗且丈丂丁丄专丞专)[1152921542646161200].丙丑专丈一万三丟一.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌().丟丂丞不专丆万丒世();
                val_16 = (FortCraftController.丗且丈丂丁丄专丞专)[1152921542646161200].丙丑专丈一万三丟一.丙丕丞且丕不丘丙丑().丙丏丁丐丟上丁东丌();
                System.Action<System.Boolean> val_13 = null;
                val_18 = 1152921542646091888;
            }
            
            val_14 = val_13;
            val_13 = new System.Action<System.Boolean>(object:  val_1, method:  val_18);
            val_13.三不丘下且丞三丆丙(丒世丘丘上丆丝东丞:  val_16, 业丏丈世世世丞丒世:  val_13);
        }
        public void SpeedUpRequest(Rilisoft.FortCraftScrollItemView 丁世丛业丟下丕三丟)
        {
            this.SpeedUpCraftingItem();
        }
        public void SpeedUpCraftingItemVideo()
        {
            var val_9;
            var val_10;
            System.Action val_11;
            System.Nullable<System.Int64> val_1 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            if(( & 1) != 0)
            {
                    val_9 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_9.丟丑丒丂万丟专丁万() == null)
            {
                    return;
            }
            
                val_9 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                Rilisoft.东且东丒丐世丐丞丒 val_5 = val_9.丟丑丒丂万丟专丁万();
                System.Nullable<System.Int64> val_6 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
                if(( & 1) == 0)
            {
                    return;
            }
            
                val_9 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                Rilisoft.东且东丒丐世丐丞丒 val_8 = val_9.丟丑丒丂万丟专丁万();
                return;
            }
            
            this.ShowConnectionErrorBanner();
            val_9 = 1152921505448005632;
            val_10 = null;
            val_10 = null;
            val_11 = Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌;
            if(val_11 == null)
            {
                    return;
            }
            
            val_11 = Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌;
            if(val_11 == null)
            {
                    val_11 = 0;
            }
            
            val_11.Invoke();
        }
        public void SpeedUpCraftingItem()
        {
            object val_12;
            System.Action<System.Boolean> val_13;
            var val_14;
            System.Action val_15;
            FortCraftController.不下丛专万丟丕东万 val_1 = null;
            val_12 = val_1;
            val_1 = new FortCraftController.不下丛专万丟丕东万();
            .丝且与丝丒丟万丁专 = this;
            val_13 = 1152921505444278272;
            System.Nullable<System.Int64> val_2 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            if(( & 1) != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丟丑丒丂万丟专丁万()) == null)
            {
                    return;
            }
            
                .三丐业七丘丂丐下丘 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丟丑丒丂万丟专丁万();
                System.Nullable<System.Int64> val_7 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
                if(( & 1) == 0)
            {
                    return;
            }
            
                Rilisoft.东且东丒丐世丐丞丒 val_9 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丟丑丒丂万丟专丁万();
                if(val_9 != (FortCraftController.不下丛专万丟丕东万)[1152921542646649776].三丐业七丘丂丐下丘)
            {
                    return;
            }
            
                System.Action<System.Boolean> val_11 = null;
                val_13 = val_11;
                val_11 = new System.Action<System.Boolean>(object:  val_1, method:  System.Void FortCraftController.不下丛专万丟丕东万::业丈万丐不丑三东不(bool 丌丗丏丏丛东专丁且));
                val_11.三不丘下且丞三丆丙(丒世丘丘上丆丝东丞:  val_9.且丕三丙七且且东下(), 业丏丈世世世丞丒世:  val_11);
                return;
            }
            
            this.ShowConnectionErrorBanner();
            val_12 = 1152921505448005632;
            val_14 = null;
            val_14 = null;
            val_15 = Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌;
            if(val_15 == null)
            {
                    return;
            }
            
            val_15 = Rilisoft.FortCraftController.丛丛丟丕丕丛丟丑丌;
            if(val_15 == null)
            {
                    val_15 = 0;
            }
            
            val_15.Invoke();
        }
        public void PlaceRequest(Rilisoft.FortCraftScrollItemView 丁世丛业丟下丕三丟)
        {
            Rilisoft.东且东丒丐世丐丞丒 val_5;
            if(丁世丛业丟下丕三丟 != null)
            {
                    val_5 = 丁世丛业丟下丕三丟.FortItem;
            }
            else
            {
                    val_5 = 0.FortItem;
            }
            
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_5, 与丄不丌一世东丁丙:  丁世丛业丟下丕三丟.Slot, 上丅丏不丗丒丈七丒:  false);
        }
        public void RemoveRequest(Rilisoft.FortCraftScrollItemView 丁世丛业丟下丕三丟)
        {
            if(丁世丛业丟下丕三丟 == 0)
            {
                    return;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_2 = 丁世丛业丟下丕三丟.FortItem;
            Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丂丂丘与与丂下丞丛(与丄不丌一世东丁丙:  丁世丛业丟下丕三丟.Slot);
        }
        private void 三不丘下且丞三丆丙(丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞, System.Action<bool> 业丏丈世世世丞丒世)
        {
            FortCraftController.丟丗东丛丘丂丌七丑 val_1 = new FortCraftController.丟丗东丛丘丂丌七丑();
            .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  0, 丒世丘丘上丆丝东丞:  丒世丘丘上丆丝东丞, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void FortCraftController.丟丗东丛丘丂丌七丑::丞丕丛丛丄丏丒东丛()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  val_1, method:  System.Void FortCraftController.丟丗东丛丘丂丌七丑::一丟丙丟丏一且丌丑()), 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  true, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  81);
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
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._likeGuiObj, 丏业丟一东丂东丘丛:  false);
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
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._likeGuiObj, 丏业丟一东丂东丘丛:  true);
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
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._likeGuiObj, 丏业丟一东丂东丘丛:  false);
            this.SetMySceneViews(丗不且三丈丞专丄丛:  false, 丒丞丐丘且不且丟东:  true);
        }
        private void 且万丅上上丁业世与()
        {
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            Rilisoft.FortItemGroupType val_28;
            val_24 = 1152921505080860672;
            val_25 = null;
            val_25 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_26 = null;
                val_26 = null;
                if(MainMenuController.丄丞丁丈与业上丞丟.FortSceneStubLoading != 0)
            {
                    val_27 = null;
                val_27 = null;
                if(activeInHierarchy == true)
            {
                    return;
            }
            
            }
            
            }
            
            val_24 = 1152921524473519280;
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄丆丑世东丏丐上丒()) == true)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
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
                goto label_27;
            }
            
            }
            
            }
            
            this.丆丗丟与丏丁且丒丕 = this.三七且丟丒丟丈丐丄;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._categoriesContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemsScrollContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._screenPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cameraSettingsPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._likeGuiObj, 丏业丟一东丂东丘丛:  false);
            if(this.丆三丑万丂丌世丆丆 != false)
            {
                    this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
                UnityEngine.AsyncOperation val_11 = UnityEngine.Resources.UnloadUnusedAssets();
                if(this.丄丑上丕丂丈丘丙七 == null)
            {
                    return;
            }
            
                this.丄丑上丕丂丈丘丙七.Invoke();
                return;
            }
            
            if(this.丛丌丞一丑丛丂丞丑 == 0)
            {
                goto label_32;
            }
            
            this.GoToGroup(一丐丅且丛不不丌丗:  this.丛丌丞一丑丛丂丞丑, 丗丒世丒东丆丅一七:  false, 丌丒丌丁丛丕专丗丝:  false);
            goto label_50;
            label_27:
            this.丆丗丟与丏丁且丒丕 = 0;
            if(this._itemsScrollContainer.activeInHierarchy == false)
            {
                goto label_35;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemsScrollContainer, 丏业丟一东丂东丘丛:  false);
            Rilisoft.FortItemGroupType val_13 = Rilisoft.FortsManager.丌丐七丕丅丙不一丐(一丐丅且丛不不丌丗:  this.丛丌丞一丑丛丂丞丑);
            this.丛丌丞一丑丛丂丞丑 = val_13;
            val_28 = val_13;
            goto label_40;
            label_32:
            if(this._likeGuiObj.丑丆丏丟丗丌丄丟丝() == true)
            {
                goto label_50;
            }
            
            if(this._categoryRootObj.activeInHierarchy == false)
            {
                goto label_43;
            }
            
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  0);
            this.丝丗下丅业丟丟世丄 = 0;
            goto label_50;
            label_35:
            this.丛丌丞一丑丛丂丞丑 = 0;
            if(this._categoryRootObj.activeInHierarchy == false)
            {
                goto label_46;
            }
            
            this.丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
            UnityEngine.AsyncOperation val_17 = UnityEngine.Resources.UnloadUnusedAssets();
            if(this.丄丑上丕丂丈丘丙七 == null)
            {
                goto label_48;
            }
            
            this.丄丑上丕丂丈丘丙七.Invoke();
            goto label_48;
            label_43:
            if(this._categoryDecorationsObj.activeInHierarchy != false)
            {
                    this.三丟一万丙丞且丘专();
                this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  1);
                this.丝丗下丅业丟丟世丄 = 1;
            }
            
            label_50:
            this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                    return;
            }
            
            if(this.丌丏丛万丂下丐丈丕.Count < 1)
            {
                    return;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_20 = this.丌丏丛万丂下丐丈丕.Dequeue();
            if(val_20 == null)
            {
                    return;
            }
            
            this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_20, 丆丐专丘丅万丂丐不:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏());
            return;
            label_46:
            Rilisoft.FortItemGroupType val_23 = Rilisoft.FortsManager.丌丐七丕丅丙不一丐(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一);
            this.一丙丕三丌与下不丅(丙业与丙丗丝不丈东:  val_23);
            val_28 = val_23;
            label_40:
            this.GoToGroup(一丐丅且丛不不丌丗:  val_28, 丗丒世丒东丆丅一七:  false, 丌丒丌丁丛丕专丗丝:  false);
            label_48:
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                    return;
            }
            
            this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
        }
        private void 丝与丟丕且丈丙且上(Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 与丄不丌一世东丁丙)
        {
            var val_11;
            if(this.业丕三万丂东丁丗三 != false)
            {
                    return;
            }
            
            if(三丐业七丘丂丐下丘 == null)
            {
                    return;
            }
            
            if(this._likeGuiObj.activeInHierarchy == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  三丐业七丘丂丐下丘.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) != false)
            {
                    this.三丟一万丙丞且丘专();
            }
            
            val_11 = null;
            val_11 = null;
            if((BankController.三与丈且丘丆丂与丒 == true) || ((this._screenPanel.activeInHierarchy == true) || (this.丆丟丟七丗丂丏丒丐 == false)))
            {
                goto label_12;
            }
            
            if((this.下且丐丈丐东丗丟丄 == null) && (this._screenPanel.activeInHierarchy != true))
            {
                    if(this._cameraSettingsPanel.activeInHierarchy != true)
            {
                    this.上丕且丁一丐丞丐丐(三丐业七丘丂丐下丘:  三丐业七丘丂丐下丘, 与丄不丌一世东丁丙:  与丄不丌一世东丁丙);
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
            
            if(this.下且丐丈丐东丗丟丄 == null)
            {
                goto label_24;
            }
            
            label_12:
            this.丌丏丛万丂下丐丈丕.Enqueue(item:  三丐业七丘丂丐下丘);
            return;
            label_24:
            this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  三丐业七丘丂丐下丘, 丆丐专丘丅万丂丐不:  与丄不丌一世东丁丙);
        }
        private void 东丂东丟世七业丙丟()
        {
            if(this.丆丟丟七丗丂丏丒丐 == false)
            {
                    return;
            }
            
            if(this.丌丏丛万丂下丐丈丕.Count < 1)
            {
                    return;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_2 = this.丌丏丛万丂下丐丈丕.Dequeue();
            if(val_2 == null)
            {
                    return;
            }
            
            this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_2, 丆丐专丘丅万丂丐不:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏());
        }
        private void 丙丄丛三丒丈下丄丛(Rilisoft.东且东丒丐世丐丞丒 丘丂世不丌上且且一, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丆丐专丘丅万丂丐不 = 1023)
        {
            var val_20;
            var val_21;
            MainMenuController val_22;
            var val_23;
            var val_24;
            var val_25;
            val_20 = 1152921524404748272;
            if((Rilisoft.Singleton<ClansController>.Instance) == 0)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return;
            }
            
            val_20 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if((System.String.op_Inequality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_20.丁丏丌丟丂丌一七与())) != false)
            {
                    return;
            }
            
            if(丘丂世不丌上且且一 == null)
            {
                    Rilisoft.东且东丒丐世丐丞丒 val_11 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄丐且丐业丙世丞与();
                if(val_11 == null)
            {
                    return;
            }
            
            }
            
            this.下且丐丈丐东丗丟丄 = val_11;
            if(this._speedUpWindow.IsVisible != false)
            {
                    this._speedUpWindow.Hide();
            }
            
            val_21 = null;
            val_21 = null;
            val_22 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_22 == 0)
            {
                goto label_25;
            }
            
            val_23 = null;
            val_23 = null;
            val_22 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 320];
            val_22 = MainMenuController.丄丞丁丈与业上丞丟.rotateCamera;
            if(val_22 == 0)
            {
                goto label_25;
            }
            
            val_22 = 1152921505210572800;
            val_24 = null;
            val_24 = null;
            if(BankController.三与丈且丘丆丂与丒 == false)
            {
                goto label_28;
            }
            
            label_25:
            this.GetCraftReward(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
            return;
            label_28:
            this.三丂丏丅丆丙丝丒丂 = this._mainPanel.activeSelf;
            val_25 = null;
            val_25 = null;
            PlayFortItemZoom(不丝丄丒丌丐一一与:  Rilisoft.丗一且丈上丝下丈丝.丗与世丟丆丐下三丝(丁丅丈丌丟世丗丗丟:  丆丐专丘丅万丂丐不), 丞一丁业丄一一业且:  "");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  false);
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            UnityEngine.AudioSource val_19 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this._cameraZoomInAudio);
        }
        public void GetCraftReward(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)
        {
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            if(this.下且丐丈丐东丗丟丄 == 下丅丙一丂丗丅丝七)
            {
                    this.下且丐丈丐东丗丟丄 = 0;
            }
            
            if((System.String.op_Equality(a:  下丅丙一丂丗丅丝七.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) == false)
            {
                    return;
            }
            
            this.三丟一万丙丞且丘专();
            this.七业丑三丈丈丒下三(丛东与丑丌丗东丕丗:  4);
            this.丝丗下丅业丟丟世丄 = 4;
        }
        private void 丄业万万丄丕丗与丑(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)
        {
            null = null;
            PlayFortSlotZoom(不丝丄丒丌丐一一与:  Rilisoft.FortsManager.丌丐七丕丅丙不一丐(一丐丅且丛不不丌丗:  this.丒丞丟丅丝不丝丒一));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainPanel, 丏业丟一东丂东丘丛:  true);
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
            return Rilisoft.FortsManager.丑丆丏丟丗丌丄丟丝();
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
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
        }
        private void 三丟一万丙丞且丘专()
        {
            var val_3;
            System.Action<UnityEngine.GameObject> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = FortCraftController.<>c.<>9__155_0;
            if(val_5 == null)
            {
                    System.Action<UnityEngine.GameObject> val_2 = null;
                val_5 = val_2;
                val_2 = new System.Action<UnityEngine.GameObject>(object:  FortCraftController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FortCraftController.<>c::一丐丕丐丟丟七丄丌(UnityEngine.GameObject 丁丂专业丁丅丅丈丙));
                FortCraftController.<>c.<>9__155_0 = val_5;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this._tutorialHintsContainer), 七丐丅专且专七三丆:  val_2);
        }
        public void OnZoomIn()
        {
            this.丛丅专丑丏丂丞丏上().Show(三丐业七丘丂丐下丘:  this.下且丐丈丐东丗丟丄);
        }
        public void OnZoomOut()
        {
            this.丛丅专丑丏丂丞丏上().Hide();
            if(this.三丂丏丅丆丙丝丒丂 != false)
            {
                    this.七丄业丌丒丄丟丌丗 = false;
                this.七丑丘丝丒丞丑丈东 = true;
            }
            
            if(this.丌丏丛万丂下丐丈丕.Count >= 1)
            {
                    this.GetCraftReward(下丅丙一丂丗丅丝七:  this.丌丏丛万丂下丐丈丕.Dequeue());
                Rilisoft.东且东丒丐世丐丞丒 val_4 = this.丌丏丛万丂下丐丈丕.Dequeue();
                if(val_4 == null)
            {
                    return;
            }
            
                this.上丕且丁一丐丞丐丐(三丐业七丘丂丐下丘:  val_4, 与丄不丌一世东丁丙:  Rilisoft.丗一且丈上丝下丈丝.丏专丄丕丏丕东丈与(丁丅丈丌丟世丗丗丟:  this.丒丞丟丅丝不丝丒一));
                this.SetMySceneViews(丗不且三丈丞专丄丛:  true, 丒丞丐丘且不且丟东:  true);
                this.丙丄丛三丒丈下丄丛(丘丂世不丌上且且一:  val_4, 丆丐专丘丅万丂丐不:  Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丏世丛丂与丐丟与丏());
                return;
            }
            
            if((this.三丂丏丅丆丙丝丒丂 != false) && (this.下且丐丈丐东丗丟丄 != null))
            {
                    this.丆且丟丙丅丞万丄丗(丂三七下丗且丌上一:  this.下且丐丈丐东丗丟丄, 丕丝丟下丗丛一丕业:  true, 与丄不丌一世东丁丙:  0, 与七丁与丌丒丝专一:  true);
            }
            
            this.GetCraftReward(下丅丙一丂丗丅丝七:  this.下且丐丈丐东丗丟丄);
        }
        public void U_BackButtonAction()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄丆丑世东丏丐上丒()) != false)
            {
                    return;
            }
            
            }
            
            this.且万丅上上丁业世与();
        }
        public void U_ToScreenViewAction()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄丆丑世东丏丐上丒()) != false)
            {
                    return;
            }
            
            }
            
            this.丅专且丟丑丛东丏三();
        }
        public void U_ToCameraSettingsAction()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄丆丑世东丏丐上丒()) != false)
            {
                    return;
            }
            
            }
            
            this.业上丛丕业上丙万丞();
        }
        public void U_ToLikePanel()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄丆丑世东丏丐上丒()) != false)
            {
                    return;
            }
            
            }
            
            this.丙不丘与丏丄丒不丄();
        }
        public FortCraftController()
        {
            this.丗不一丗丅七丘丕一 = new System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, UnityEngine.Transform>();
            this.丕丏丑丐业丛世一丟 = new System.Collections.Generic.List<Rilisoft.丕丂丒丁丏东且一七>();
            this.丑万丆丅丁与丂丌丒 = new System.Collections.Generic.List<Rilisoft.丕丂丒丁丏东且一七>();
            this.丌丏丛万丂下丐丈丕 = new System.Collections.Generic.Queue<Rilisoft.东且东丒丐世丐丞丒>();
        }
        private static FortCraftController()
        {
        
        }
        private Rilisoft.ClanStockWindow 丄丙业与东丏丛丒三()
        {
            return 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕<Rilisoft.ClanStockWindow>(丑与丞三且丛与丟业:  "NguiWindows/Clan/ClanStock", 七万上丐一丈丏丏专:  this.gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        private bool 丏丂下丂不丝七丁业(Rilisoft.丕丂丒丁丏东且一七 业下丌下三丕丙丌下)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (bool)(业下丌下三丕丙丌下.FortItem == this.丆丗丟与丏丁且丒丕) ? 1 : 0;
        }
    
    }

}
